namespace Bonzai
{
    partial class Overlay
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
            TIME = new Label();
            ORANGESCORE = new Label();
            BLUESCORE = new Label();
            pictureBox16 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox14 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // TIME
            // 
            TIME.Anchor = AnchorStyles.None;
            TIME.AutoSize = true;
            TIME.BackColor = Color.FromArgb(64, 64, 64);
            TIME.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TIME.ForeColor = Color.White;
            TIME.Location = new Point(112, 21);
            TIME.Name = "TIME";
            TIME.Size = new Size(57, 15);
            TIME.TabIndex = 43;
            TIME.Text = "00:00.00";
            // 
            // ORANGESCORE
            // 
            ORANGESCORE.Anchor = AnchorStyles.Right;
            ORANGESCORE.AutoSize = true;
            ORANGESCORE.BackColor = Color.FromArgb(178, 103, 36);
            ORANGESCORE.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ORANGESCORE.ForeColor = Color.White;
            ORANGESCORE.Location = new Point(184, 18);
            ORANGESCORE.Name = "ORANGESCORE";
            ORANGESCORE.Size = new Size(27, 20);
            ORANGESCORE.TabIndex = 42;
            ORANGESCORE.Text = "00";
            // 
            // BLUESCORE
            // 
            BLUESCORE.Anchor = AnchorStyles.Left;
            BLUESCORE.AutoSize = true;
            BLUESCORE.BackColor = Color.FromArgb(39, 101, 166);
            BLUESCORE.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BLUESCORE.ForeColor = SystemColors.ButtonHighlight;
            BLUESCORE.Location = new Point(71, 18);
            BLUESCORE.Name = "BLUESCORE";
            BLUESCORE.Size = new Size(27, 20);
            BLUESCORE.TabIndex = 41;
            BLUESCORE.Text = "00";
            // 
            // pictureBox16
            // 
            pictureBox16.Anchor = AnchorStyles.None;
            pictureBox16.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox16.Location = new Point(101, 9);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(77, 43);
            pictureBox16.TabIndex = 40;
            pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Anchor = AnchorStyles.Right;
            pictureBox15.BackColor = Color.FromArgb(178, 103, 36);
            pictureBox15.Location = new Point(177, 9);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(41, 43);
            pictureBox15.TabIndex = 39;
            pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Anchor = AnchorStyles.Left;
            pictureBox14.BackColor = Color.FromArgb(39, 101, 166);
            pictureBox14.Location = new Point(66, 9);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(35, 43);
            pictureBox14.TabIndex = 38;
            pictureBox14.TabStop = false;
            // 
            // Overlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LawnGreen;
            ClientSize = new Size(284, 61);
            Controls.Add(TIME);
            Controls.Add(ORANGESCORE);
            Controls.Add(BLUESCORE);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Overlay";
            Text = "Overlay";
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TIME;
        private Label ORANGESCORE;
        private Label BLUESCORE;
        private PictureBox pictureBox16;
        private PictureBox pictureBox15;
        private PictureBox pictureBox14;
    }
}