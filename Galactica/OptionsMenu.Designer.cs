namespace Galactica
{
    partial class OptionsMenu
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
            this.BackButton = new System.Windows.Forms.Button();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.DevModeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Tele-Marines", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(153, 359);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 45);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Tele-Marines", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.Location = new System.Drawing.Point(163, 25);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(179, 32);
            this.OptionsLabel.TabIndex = 7;
            this.OptionsLabel.Text = "Options";
            // 
            // DevModeCheckBox
            // 
            this.DevModeCheckBox.AutoSize = true;
            this.DevModeCheckBox.Location = new System.Drawing.Point(39, 91);
            this.DevModeCheckBox.Name = "DevModeCheckBox";
            this.DevModeCheckBox.Size = new System.Drawing.Size(151, 24);
            this.DevModeCheckBox.TabIndex = 9;
            this.DevModeCheckBox.Text = "Developer Mode";
            this.DevModeCheckBox.UseVisualStyleBackColor = true;
            this.DevModeCheckBox.CheckedChanged += new System.EventHandler(this.DevModeCheckBox_CheckedChanged);
            // 
            // OptionsMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Galactica.Properties.Resources.SpaceBackground_002;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DevModeCheckBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OptionsLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(466, 422);
            this.MinimumSize = new System.Drawing.Size(466, 422);
            this.Name = "OptionsMenu";
            this.Size = new System.Drawing.Size(464, 420);
            this.Load += new System.EventHandler(this.OptionsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.CheckBox DevModeCheckBox;
    }
}
