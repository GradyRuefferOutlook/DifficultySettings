namespace DifficultySettings
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.masterButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(419, 58);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "WELCOME YONDER TRAVELLER! WHAT IS THY NAME?";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(272, 74);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(250, 29);
            this.nameInput.TabIndex = 1;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.difficultyLabel.Location = new System.Drawing.Point(13, 118);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(509, 23);
            this.difficultyLabel.TabIndex = 2;
            this.difficultyLabel.Text = "HOW DIFFICULT IS THOUST QUEST?";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Black;
            this.easyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.easyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(26, 241);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(160, 106);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            this.easyButton.MouseEnter += new System.EventHandler(this.easyButton_MouseEnter);
            this.easyButton.MouseLeave += new System.EventHandler(this.easyButton_MouseLeave);
            // 
            // normalButton
            // 
            this.normalButton.BackColor = System.Drawing.Color.Black;
            this.normalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.normalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalButton.ForeColor = System.Drawing.Color.White;
            this.normalButton.Location = new System.Drawing.Point(192, 151);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(160, 106);
            this.normalButton.TabIndex = 4;
            this.normalButton.Text = "Normal";
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            this.normalButton.MouseEnter += new System.EventHandler(this.normalButton_MouseEnter);
            this.normalButton.MouseLeave += new System.EventHandler(this.normalButton_MouseLeave);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Black;
            this.hardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(362, 241);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(160, 106);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            this.hardButton.MouseEnter += new System.EventHandler(this.hardButton_MouseEnter);
            this.hardButton.MouseLeave += new System.EventHandler(this.hardButton_MouseLeave);
            // 
            // masterButton
            // 
            this.masterButton.BackColor = System.Drawing.Color.Black;
            this.masterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.masterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterButton.ForeColor = System.Drawing.Color.White;
            this.masterButton.Location = new System.Drawing.Point(192, 331);
            this.masterButton.Name = "masterButton";
            this.masterButton.Size = new System.Drawing.Size(160, 106);
            this.masterButton.TabIndex = 6;
            this.masterButton.Text = "Master";
            this.masterButton.UseVisualStyleBackColor = false;
            this.masterButton.Click += new System.EventHandler(this.masterButton_Click);
            this.masterButton.MouseEnter += new System.EventHandler(this.masterButton_MouseEnter);
            this.masterButton.MouseLeave += new System.EventHandler(this.masterButton_MouseLeave);
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.Black;
            this.beginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.Color.White;
            this.beginButton.Location = new System.Drawing.Point(214, 263);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(118, 62);
            this.beginButton.TabIndex = 7;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            this.beginButton.MouseEnter += new System.EventHandler(this.beginButton_MouseEnter);
            this.beginButton.MouseLeave += new System.EventHandler(this.beginButton_MouseLeave);
            // 
            // bButton
            // 
            this.bButton.BackColor = System.Drawing.Color.Black;
            this.bButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bButton.ForeColor = System.Drawing.Color.White;
            this.bButton.Location = new System.Drawing.Point(422, 450);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(118, 62);
            this.bButton.TabIndex = 8;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = false;
            this.bButton.Click += new System.EventHandler(this.bButton_Click);
            this.bButton.MouseEnter += new System.EventHandler(this.bButton_MouseEnter);
            this.bButton.MouseLeave += new System.EventHandler(this.bButton_MouseLeave);
            // 
            // aButton
            // 
            this.aButton.BackColor = System.Drawing.Color.Black;
            this.aButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButton.ForeColor = System.Drawing.Color.White;
            this.aButton.Location = new System.Drawing.Point(-3, 450);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(118, 62);
            this.aButton.TabIndex = 9;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = false;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            this.aButton.MouseEnter += new System.EventHandler(this.aButton_MouseEnter);
            this.aButton.MouseLeave += new System.EventHandler(this.aButton_MouseLeave);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(121, 479);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(295, 23);
            this.welcomeLabel.TabIndex = 10;
            this.welcomeLabel.Text = "Welcome To The Land Of Yore!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameChecker
            // 
            this.nameChecker.Interval = 250;
            this.nameChecker.Tick += new System.EventHandler(this.nameChecker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.masterButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button masterButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Timer nameChecker;
    }
}

