using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Bonzai
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void SETTINGSCLOSEBUTTON_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Hide();
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            TTSCHECK.Checked = Properties.Settings.Default.tts;
            GENDER.SelectedIndex = Properties.Settings.Default.voiceGender;
            SPEED.SelectedIndex = Properties.Settings.Default.voiceSpeed;
            LTCHECK.Checked = Properties.Settings.Default.lastThrow;
            LGCHECK.Checked = Properties.Settings.Default.lastGoal;
            RSCHECK.Checked = Properties.Settings.Default.regrabSpeed;
            PSCHECK.Checked = Properties.Settings.Default.pingSpike;
        }
        
        private void SaveSettings()
        {
            Properties.Settings.Default.tts = TTSCHECK.Checked;
            Properties.Settings.Default.voiceGender = GENDER.SelectedIndex;
            Properties.Settings.Default.voiceSpeed = SPEED.SelectedIndex;
            Properties.Settings.Default.lastThrow = LTCHECK.Checked;
            Properties.Settings.Default.lastGoal = LGCHECK.Checked;
            Properties.Settings.Default.regrabSpeed = RSCHECK.Checked;
            Properties.Settings.Default.pingSpike = PSCHECK.Checked;

            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.voiceGender == 0) 
            { 
                MainMenu.synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult); 
            }
            else if (Properties.Settings.Default.voiceGender == 1) 
            { 
                MainMenu.synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); 
            }

            if (Properties.Settings.Default.voiceSpeed == 0) 
            { 
                MainMenu.synthesizer.Rate = -5; 
            }
            else if (Properties.Settings.Default.voiceSpeed == 1) 
            { 
                MainMenu.synthesizer.Rate = 0; 
            }
            else if (Properties.Settings.Default.voiceSpeed == 2) 
            { 
                MainMenu.synthesizer.Rate = 7; 
            }

            if (Properties.Settings.Default.voiceGender == 0) 
            { 
                FetchAPIData.synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult); 
            }
            else if (Properties.Settings.Default.voiceGender == 1) 
            { 
                FetchAPIData.synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); 
            }

            if (Properties.Settings.Default.voiceSpeed == 0) 
            { 
                FetchAPIData.synthesizer.Rate = -5; 
            }
            else if (Properties.Settings.Default.voiceSpeed == 1) 
            { 
                FetchAPIData.synthesizer.Rate = 0; 
            }
            else if (Properties.Settings.Default.voiceSpeed == 2) 
            { 
                FetchAPIData.synthesizer.Rate = 7; 
            }

            System.Diagnostics.Debug.WriteLine(Properties.Settings.Default.voiceGender.ToString() + " + " + Properties.Settings.Default.voiceSpeed.ToString());
        }

        private void TTSCHECK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}
