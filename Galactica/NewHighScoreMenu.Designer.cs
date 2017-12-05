namespace Galactica
{
    partial class NewHighScoreMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewHighScoreSubmitButton = new System.Windows.Forms.Button();
            this.EnterNameBelowLabel = new System.Windows.Forms.Label();
            this.NewHighScoreLabel = new System.Windows.Forms.Label();
            this.NewHighScoreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewHighScoreSubmitButton
            // 
            this.NewHighScoreSubmitButton.Location = new System.Drawing.Point(239, 325);
            this.NewHighScoreSubmitButton.Name = "NewHighScoreSubmitButton";
            this.NewHighScoreSubmitButton.Size = new System.Drawing.Size(76, 27);
            this.NewHighScoreSubmitButton.TabIndex = 3;
            this.NewHighScoreSubmitButton.Text = "Submit";
            this.NewHighScoreSubmitButton.UseVisualStyleBackColor = true;
            this.NewHighScoreSubmitButton.Click += new System.EventHandler(this.NewHighScoreSubmitButton_Click);
            // 
            // EnterNameBelowLabel
            // 
            this.EnterNameBelowLabel.AutoSize = true;
            this.EnterNameBelowLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNameBelowLabel.Location = new System.Drawing.Point(103, 269);
            this.EnterNameBelowLabel.Name = "EnterNameBelowLabel";
            this.EnterNameBelowLabel.Size = new System.Drawing.Size(265, 23);
            this.EnterNameBelowLabel.TabIndex = 2;
            this.EnterNameBelowLabel.Text = "Please Enter Initials Below";
            // 
            // NewHighScoreLabel
            // 
            this.NewHighScoreLabel.AutoSize = true;
            this.NewHighScoreLabel.Font = new System.Drawing.Font("Tele-Marines", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHighScoreLabel.Location = new System.Drawing.Point(69, 80);
            this.NewHighScoreLabel.Name = "NewHighScoreLabel";
            this.NewHighScoreLabel.Size = new System.Drawing.Size(329, 25);
            this.NewHighScoreLabel.TabIndex = 1;
            this.NewHighScoreLabel.Text = "New HighScore";
            this.NewHighScoreLabel.Click += new System.EventHandler(this.NewHighScoreLabel_Click);
            // 
            // NewHighScoreTextBox
            // 
            this.NewHighScoreTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHighScoreTextBox.Location = new System.Drawing.Point(171, 325);
            this.NewHighScoreTextBox.MaxLength = 3;
            this.NewHighScoreTextBox.Name = "NewHighScoreTextBox";
            this.NewHighScoreTextBox.Size = new System.Drawing.Size(62, 27);
            this.NewHighScoreTextBox.TabIndex = 0;
            // 
            // NewHighScoreMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Galactica.Properties.Resources.SpaceBackground_002;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NewHighScoreSubmitButton);
            this.Controls.Add(this.NewHighScoreTextBox);
            this.Controls.Add(this.EnterNameBelowLabel);
            this.Controls.Add(this.NewHighScoreLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(466, 422);
            this.MinimumSize = new System.Drawing.Size(466, 422);
            this.Name = "NewHighScoreMenu";
            this.Size = new System.Drawing.Size(464, 420);
            this.Load += new System.EventHandler(this.NewHighScoreMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EnterNameBelowLabel;
        private System.Windows.Forms.Label NewHighScoreLabel;
        public System.Windows.Forms.TextBox NewHighScoreTextBox;
        public System.Windows.Forms.Button NewHighScoreSubmitButton;
    }
}
