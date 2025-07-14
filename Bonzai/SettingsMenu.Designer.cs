namespace Bonzai
{
    partial class SettingsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            settingsLabel = new Label();
            SETTINGSCLOSEBUTTON = new Button();
            TTS = new TabPage();
            label5 = new Label();
            label4 = new Label();
            SPEED = new ComboBox();
            label3 = new Label();
            PSCHECK = new CheckBox();
            RSCHECK = new CheckBox();
            LTCHECK = new CheckBox();
            LGCHECK = new CheckBox();
            GENDER = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TTSCHECK = new CheckBox();
            SETTINGSTABS = new TabControl();
            tabPage1 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            TTS.SuspendLayout();
            SETTINGSTABS.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.BackColor = Color.Transparent;
            settingsLabel.Cursor = Cursors.IBeam;
            settingsLabel.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            settingsLabel.ForeColor = SystemColors.ControlLightLight;
            settingsLabel.Location = new Point(12, 9);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(126, 32);
            settingsLabel.TabIndex = 8;
            settingsLabel.Text = "Settings";
            settingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SETTINGSCLOSEBUTTON
            // 
            SETTINGSCLOSEBUTTON.BackColor = Color.Transparent;
            SETTINGSCLOSEBUTTON.BackgroundImageLayout = ImageLayout.Stretch;
            SETTINGSCLOSEBUTTON.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SETTINGSCLOSEBUTTON.Location = new Point(389, 426);
            SETTINGSCLOSEBUTTON.Name = "SETTINGSCLOSEBUTTON";
            SETTINGSCLOSEBUTTON.Size = new Size(75, 23);
            SETTINGSCLOSEBUTTON.TabIndex = 9;
            SETTINGSCLOSEBUTTON.Text = "Save";
            SETTINGSCLOSEBUTTON.UseVisualStyleBackColor = false;
            SETTINGSCLOSEBUTTON.Click += SETTINGSCLOSEBUTTON_Click;
            // 
            // TTS
            // 
            TTS.BackColor = Color.FromArgb(62, 64, 75);
            TTS.Controls.Add(label5);
            TTS.Controls.Add(label4);
            TTS.Controls.Add(SPEED);
            TTS.Controls.Add(label3);
            TTS.Controls.Add(PSCHECK);
            TTS.Controls.Add(RSCHECK);
            TTS.Controls.Add(LTCHECK);
            TTS.Controls.Add(LGCHECK);
            TTS.Controls.Add(GENDER);
            TTS.Controls.Add(label2);
            TTS.Controls.Add(label1);
            TTS.Controls.Add(TTSCHECK);
            TTS.ForeColor = Color.Transparent;
            TTS.Location = new Point(4, 25);
            TTS.Name = "TTS";
            TTS.Padding = new Padding(3);
            TTS.Size = new Size(448, 324);
            TTS.TabIndex = 0;
            TTS.Text = "Text-to-Speech";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.IBeam;
            label5.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(119, 146);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 21;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.IBeam;
            label4.Font = new Font("Cascadia Mono Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(160, 93);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 20;
            label4.Text = "Voice Speed";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SPEED
            // 
            SPEED.FormattingEnabled = true;
            SPEED.Items.AddRange(new object[] { "Slow", "Normal", "Fast" });
            SPEED.Location = new Point(160, 113);
            SPEED.Name = "SPEED";
            SPEED.Size = new Size(121, 24);
            SPEED.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("Cascadia Mono Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 18;
            label3.Text = "Voice Gender";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PSCHECK
            // 
            PSCHECK.AutoSize = true;
            PSCHECK.Enabled = true;
            PSCHECK.Location = new Point(232, 265);
            PSCHECK.Name = "PSCHECK";
            PSCHECK.Size = new Size(96, 20);
            PSCHECK.TabIndex = 17;
            PSCHECK.Text = "Ping Spike";
            PSCHECK.UseVisualStyleBackColor = true;
            // 
            // RSCHECK
            // 
            RSCHECK.AutoSize = true;
            RSCHECK.Enabled = false;
            RSCHECK.Location = new Point(20, 265);
            RSCHECK.Name = "RSCHECK";
            RSCHECK.Size = new Size(201, 20);
            RSCHECK.TabIndex = 16;
            RSCHECK.Text = "Regrab Speed (over 20m/s)";
            RSCHECK.UseVisualStyleBackColor = true;
            // 
            // LTCHECK
            // 
            LTCHECK.AutoSize = true;
            LTCHECK.Location = new Point(20, 239);
            LTCHECK.Name = "LTCHECK";
            LTCHECK.Size = new Size(194, 20);
            LTCHECK.TabIndex = 15;
            LTCHECK.Text = "Last Throw (over 10 m/s)";
            LTCHECK.UseVisualStyleBackColor = true;
            // 
            // LGCHECK
            // 
            LGCHECK.AutoSize = true;
            LGCHECK.Location = new Point(232, 239);
            LGCHECK.Name = "LGCHECK";
            LGCHECK.Size = new Size(89, 20);
            LGCHECK.TabIndex = 14;
            LGCHECK.Text = "Last Goal";
            LGCHECK.UseVisualStyleBackColor = true;
            // 
            // GENDER
            // 
            GENDER.FormattingEnabled = true;
            GENDER.Items.AddRange(new object[] { "Male", "Female" });
            GENDER.Location = new Point(20, 113);
            GENDER.Name = "GENDER";
            GENDER.Size = new Size(121, 24);
            GENDER.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(210, 32);
            label2.TabIndex = 12;
            label2.Text = "Customization:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(14, 203);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 11;
            label1.Text = "Events:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TTSCHECK
            // 
            TTSCHECK.AutoSize = true;
            TTSCHECK.Location = new Point(20, 17);
            TTSCHECK.Name = "TTSCHECK";
            TTSCHECK.Size = new Size(124, 20);
            TTSCHECK.TabIndex = 0;
            TTSCHECK.Text = "Text-To-Speech";
            TTSCHECK.UseVisualStyleBackColor = true;
            TTSCHECK.CheckedChanged += TTSCHECK_CheckedChanged;
            // 
            // SETTINGSTABS
            // 
            SETTINGSTABS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SETTINGSTABS.Controls.Add(TTS);
            SETTINGSTABS.Controls.Add(tabPage1);
            SETTINGSTABS.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SETTINGSTABS.Location = new Point(12, 57);
            SETTINGSTABS.Name = "SETTINGSTABS";
            SETTINGSTABS.SelectedIndex = 0;
            SETTINGSTABS.Size = new Size(456, 353);
            SETTINGSTABS.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(62, 64, 75);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(448, 324);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Credit / Extra";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Cursor = Cursors.IBeam;
            label10.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.ImageAlign = ContentAlignment.TopCenter;
            label10.Location = new Point(334, 301);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 26;
            label10.Text = "version 1.0\r\n";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Cursor = Cursors.IBeam;
            label9.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(28, 189);
            label9.Name = "label9";
            label9.Size = new Size(207, 40);
            label9.TabIndex = 25;
            label9.Text = "aeryxx_ - code\r\nntsfranz - inspiration\r\n";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(15, 157);
            label8.Name = "label8";
            label8.Size = new Size(112, 32);
            label8.TabIndex = 24;
            label8.Text = "Credit:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Cursor = Cursors.IBeam;
            label7.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(28, 49);
            label7.Name = "label7";
            label7.Size = new Size(234, 80);
            label7.TabIndex = 23;
            label7.Text = "- Lobby Joining\r\n- Rule Changing / Presets\r\n- Chroma-Key Overlay\r\n- Other TTS Events\r\n";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.IBeam;
            label6.Font = new Font("Cascadia Mono SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(15, 17);
            label6.Name = "label6";
            label6.Size = new Size(252, 32);
            label6.TabIndex = 22;
            label6.Text = "Soon to be added!";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 42, 54);
            ClientSize = new Size(484, 461);
            Controls.Add(SETTINGSTABS);
            Controls.Add(SETTINGSCLOSEBUTTON);
            Controls.Add(settingsLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsMenu";
            Text = "Bonzai - Settings Menu";
            Load += SettingsMenu_Load;
            TTS.ResumeLayout(false);
            TTS.PerformLayout();
            SETTINGSTABS.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label settingsLabel;
        private Button SETTINGSCLOSEBUTTON;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage TTS;
        private CheckBox TTSCHECK;
        private TabControl SETTINGSTABS;
        private Label label1;
        private Label label2;
        private ComboBox GENDER;
        private CheckBox PSCHECK;
        private CheckBox RSCHECK;
        private CheckBox LTCHECK;
        private CheckBox LGCHECK;
        private Label label3;
        private Label label4;
        private ComboBox SPEED;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
    }
}
