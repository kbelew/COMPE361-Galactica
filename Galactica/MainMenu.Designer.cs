using System.ComponentModel;
using System.Windows.Forms;

namespace Galactica
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.PlayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.newHelpButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.HighScoreTable = new System.Windows.Forms.DataGridView();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelReached = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsMenu1 = new Galactica.OptionsMenu();
            this.helpMenu1 = new Galactica.HelpMenu();
            this.newHighScoreMenu1 = new Galactica.NewHighScoreMenu();
            this.highScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Font = new System.Drawing.Font("Tele-Marines", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(12, 354);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(468, 57);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tele-Marines", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Galactica";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Title_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.OptionsButton.Font = new System.Drawing.Font("Tele-Marines", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.Location = new System.Drawing.Point(12, 414);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(468, 48);
            this.OptionsButton.TabIndex = 3;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // newHelpButton
            // 
            this.newHelpButton.BackColor = System.Drawing.Color.Transparent;
            this.newHelpButton.Font = new System.Drawing.Font("Tele-Marines", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHelpButton.Location = new System.Drawing.Point(12, 465);
            this.newHelpButton.Name = "newHelpButton";
            this.newHelpButton.Size = new System.Drawing.Size(468, 48);
            this.newHelpButton.TabIndex = 4;
            this.newHelpButton.Text = "Hielp";
            this.newHelpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newHelpButton.UseVisualStyleBackColor = false;
            this.newHelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Tele-Marines", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 516);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(468, 48);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HighScoreTable
            // 
            this.HighScoreTable.AllowUserToAddRows = false;
            this.HighScoreTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.HighScoreTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HighScoreTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HighScoreTable.BackgroundColor = System.Drawing.Color.Black;
            this.HighScoreTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HighScoreTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HighScoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HighScoreTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player,
            this.Score,
            this.LevelReached});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HighScoreTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.HighScoreTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.HighScoreTable.Enabled = false;
            this.HighScoreTable.EnableHeadersVisualStyles = false;
            this.HighScoreTable.GridColor = System.Drawing.Color.Black;
            this.HighScoreTable.Location = new System.Drawing.Point(92, 140);
            this.HighScoreTable.MultiSelect = false;
            this.HighScoreTable.Name = "HighScoreTable";
            this.HighScoreTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HighScoreTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.HighScoreTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            this.HighScoreTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.HighScoreTable.RowTemplate.ReadOnly = true;
            this.HighScoreTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HighScoreTable.ShowRowErrors = false;
            this.HighScoreTable.Size = new System.Drawing.Size(306, 174);
            this.HighScoreTable.TabIndex = 7;
            this.HighScoreTable.VirtualMode = true;
            this.HighScoreTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HighScoreTable_CellContentClick);
            // 
            // Player
            // 
            this.Player.DataPropertyName = "Name";
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // LevelReached
            // 
            this.LevelReached.DataPropertyName = "LevelReached";
            this.LevelReached.HeaderText = "Level Reached";
            this.LevelReached.Name = "LevelReached";
            this.LevelReached.ReadOnly = true;
            // 
            // optionsMenu1
            // 
            this.optionsMenu1.BackColor = System.Drawing.Color.Black;
            this.optionsMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("optionsMenu1.BackgroundImage")));
            this.optionsMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionsMenu1.ForeColor = System.Drawing.Color.White;
            this.optionsMenu1.Location = new System.Drawing.Point(12, 140);
            this.optionsMenu1.MaximumSize = new System.Drawing.Size(466, 422);
            this.optionsMenu1.MinimumSize = new System.Drawing.Size(466, 422);
            this.optionsMenu1.Name = "optionsMenu1";
            this.optionsMenu1.Size = new System.Drawing.Size(466, 422);
            this.optionsMenu1.TabIndex = 9;
            this.optionsMenu1.Visible = false;
            this.optionsMenu1.Load += new System.EventHandler(this.optionsMenu1_Load);
            // 
            // helpMenu1
            // 
            this.helpMenu1.BackColor = System.Drawing.Color.Black;
            this.helpMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpMenu1.BackgroundImage")));
            this.helpMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpMenu1.ForeColor = System.Drawing.Color.White;
            this.helpMenu1.Location = new System.Drawing.Point(12, 140);
            this.helpMenu1.MaximumSize = new System.Drawing.Size(466, 422);
            this.helpMenu1.MinimumSize = new System.Drawing.Size(466, 422);
            this.helpMenu1.Name = "helpMenu1";
            this.helpMenu1.Size = new System.Drawing.Size(466, 422);
            this.helpMenu1.TabIndex = 10;
            this.helpMenu1.Visible = false;
            this.helpMenu1.Load += new System.EventHandler(this.helpMenu1_Load);
            // 
            // newHighScoreMenu1
            // 
            this.newHighScoreMenu1.BackColor = System.Drawing.Color.Black;
            this.newHighScoreMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newHighScoreMenu1.BackgroundImage")));
            this.newHighScoreMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newHighScoreMenu1.ForeColor = System.Drawing.Color.White;
            this.newHighScoreMenu1.Location = new System.Drawing.Point(12, 140);
            this.newHighScoreMenu1.MaximumSize = new System.Drawing.Size(466, 422);
            this.newHighScoreMenu1.MinimumSize = new System.Drawing.Size(466, 422);
            this.newHighScoreMenu1.Name = "newHighScoreMenu1";
            this.newHighScoreMenu1.Size = new System.Drawing.Size(466, 422);
            this.newHighScoreMenu1.TabIndex = 8;
            this.newHighScoreMenu1.Visible = false;
            this.newHighScoreMenu1.Load += new System.EventHandler(this.newHighScoreMenu1_Load);
            // 
            // highScoreBindingSource
            // 
            this.highScoreBindingSource.DataSource = typeof(Galactica.HighScore);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Galactica.Properties.Resources.SpaceBackground_001;
            this.ClientSize = new System.Drawing.Size(492, 567);
            this.Controls.Add(this.optionsMenu1);
            this.Controls.Add(this.helpMenu1);
            this.Controls.Add(this.newHighScoreMenu1);
            this.Controls.Add(this.HighScoreTable);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.newHelpButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "MainMenu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.CanFocus = true;
            this.RootElement.MaxSize = new System.Drawing.Size(500, 600);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galactica Main Menu";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button newHelpButton;
        private System.Windows.Forms.Button ExitButton;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.BindingSource highScoreBindingSource;
        public System.Windows.Forms.DataGridView HighScoreTable;
        private NewHighScoreMenu newHighScoreMenu1;
        private OptionsMenu optionsMenu1;
        private HelpMenu helpMenu1;
        private DataGridViewTextBoxColumn Player;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn LevelReached;
    }
}
