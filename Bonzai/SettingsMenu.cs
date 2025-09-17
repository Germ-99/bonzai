// NOTE: I recommend keeping ping spike TTS off
// people have really bad internet...

// ok, mac has gotten on me for writing that comment
// to clarify; those are meant for developers who are reading the code and may test other things during development
// screw you mac (I still love you)

// can a twink not be bored in class?

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

            switch (Properties.Settings.Default.voiceGender)
            {
                case 0:
                    MainMenu.synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
                    break;
                case 1:
                    MainMenu.synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                    break;
            }
            switch (Properties.Settings.Default.voiceSpeed)
            {
                case 0:
                    MainMenu.synthesizer.Rate = -5;
                    break;
                case 1:
                    MainMenu.synthesizer.Rate = 0;
                    break;
                case 2:
                    MainMenu.synthesizer.Rate = 7;
                    break;
            }
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