using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonzai
{
    public partial class MainMenu : Form, INotifyPropertyChanged
    {
        private double _lastThrow;
        private double _lastGoal;
        public string lastSessionID;
        public static SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public event PropertyChangedEventHandler PropertyChanged;
        private System.Windows.Forms.Timer timer;

        public MainMenu()
        {
            InitializeComponent();
            PropertyChanged += MainPropertyChanged;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += async (s, e) => await FetchAPIData.UpdateDataAsync();
            timer.Tick += async (s, e) => await UpdateData();
            timer.Start();
        }

        private void MainPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(last_Throw))
            {
                OnLastThrowChanged();
            }
            else if (e.PropertyName == nameof(last_Goal))
            {
                OnLastGoalChanged();
            }
        }

        public double last_Throw
        {
            get { return _lastThrow; }
            set
            {
                if (_lastThrow != value)
                {
                    _lastThrow = value;
                    OnPropertyChanged(nameof(last_Throw));
                }
            }
        }
        public double last_Goal
        {
            get { return _lastGoal; }
            set
            {
                if (_lastGoal != value)
                {
                    _lastGoal = value;
                    OnPropertyChanged(nameof(last_Goal));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lastSessionID = "";

            if (Properties.Settings.Default.voiceGender == 0) { synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult); }

            if (Properties.Settings.Default.voiceGender == 1) { synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); }


            if (Properties.Settings.Default.voiceSpeed == 0) { synthesizer.Rate = -5; }

            if (Properties.Settings.Default.voiceSpeed == 1) { synthesizer.Rate = 0; }

            if (Properties.Settings.Default.voiceSpeed == 2) { synthesizer.Rate = 7; }
        }

        public async Task UpdateData()
        {
            if (FetchAPIData.sessionID != null)
            {
                CONNECTSTATUS.Text = "Connected";
                playerText.Text = FetchAPIData.client_Name;

                if (lastSessionID != FetchAPIData.sessionID)
                {
                    sdf.Text = await IPGeolocation.GetLocationAsync(FetchAPIData.lobby_IP);
                    lastSessionID = FetchAPIData.sessionID;

                    Console.WriteLine("IP-API USED");
                }

                BLUEPLAYER.Text = string.Join(Environment.NewLine, FetchAPIData.bluePlayerNames);
                ORANGEPLAYER.Text = string.Join(Environment.NewLine, FetchAPIData.orangePlayerNames);
                SPECTATORS.Text = string.Join(Environment.NewLine, FetchAPIData.specatatorPlayerNames);

                CheckPingSpikes();

                if (FetchAPIData.blue_points <= 9)
                {
                    BLUESCORE.Text = ("0" + FetchAPIData.blue_points);
                }
                else
                {
                    BLUESCORE.Text = FetchAPIData.blue_points.ToString();
                }

                if (FetchAPIData.orange_points <= 9)
                {
                    ORANGESCORE.Text = ("0" + FetchAPIData.orange_points);
                }
                else
                {
                    ORANGESCORE.Text = FetchAPIData.orange_points.ToString();
                }

                TIME.Text = FetchAPIData.game_clock_display;

                last_Throw = FetchAPIData.last_Throw;
                last_Goal = FetchAPIData.last_Goal;

            }
            else
            {
                CONNECTSTATUS.Text = "Not Connected";
                playerText.Text = "Player: ...";
                BLUEPLAYER.Text = "";

                BLUESCORE.Text = "00";
                ORANGESCORE.Text = "00";
                TIME.Text = "00:00.00";
            }
        }

        private void CheckPingSpikes()
        {
            if (Properties.Settings.Default.pingSpike && Properties.Settings.Default.tts)
            {
                foreach (var kvp in FetchAPIData.playerPings)
                {
                    string playerName = kvp.Key;
                    int currentPing = kvp.Value;

                    if (FetchAPIData.previousPlayerPings.TryGetValue(playerName, out int previousPing))
                    {
                        int pingIncrease = currentPing - previousPing;

                        if (pingIncrease >= 25)
                        {
                            synthesizer.SpeakAsync($"{playerName} had a ping spike");
                        }
                    }

                    // Update or add this player's current ping for the next comparison
                    FetchAPIData.previousPlayerPings[playerName] = currentPing;
                }

                // Remove player pings for people who are no longer in the game
                var stalePlayers = FetchAPIData.previousPlayerPings.Keys
                    .Where(name => !FetchAPIData.playerPings.ContainsKey(name))
                    .ToList();

                foreach (var name in stalePlayers)
                {
                    FetchAPIData.previousPlayerPings.Remove(name);
                }
            }
        }

        void OnLastThrowChanged()
        {
            if (last_Throw >= 10 && Properties.Settings.Default.lastThrow && Properties.Settings.Default.tts)
                synthesizer.SpeakAsync(Math.Round(last_Throw, 1).ToString());
        }

        void OnLastGoalChanged()
        {
            if (Properties.Settings.Default.lastGoal && Properties.Settings.Default.tts)
                synthesizer.SpeakAsync(Math.Round(last_Throw, 1).ToString());
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SETTINGSBUTTON_Click(object sender, EventArgs e)
        {
            SettingsMenu settingsMenu = new SettingsMenu();
            settingsMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("spark://c/" + FetchAPIData.sessionID);
        }

        private void OVERLAYBUTTON_Click(object sender, EventArgs e)
        {
            Overlay overlay = new Overlay();
            overlay.Show();
        }
    }
}
