﻿using System.ComponentModel;
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
            this.HelpButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.HighScoreTable = new System.Windows.Forms.DataGridView();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelReached = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewHighScorePanel = new System.Windows.Forms.Panel();
            this.NewHighScoreTextBox = new System.Windows.Forms.TextBox();
            this.NewHighScoreLabel = new System.Windows.Forms.Label();
            this.EnterNameBelowLabel = new System.Windows.Forms.Label();
            this.highScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewHighScoreSubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreTable)).BeginInit();
            this.NewHighScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Font = new System.Drawing.Font("Tele-Marines", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(12, 364);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(468, 57);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tele-Marines", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Galactica";
            this.label1.Click += new System.EventHandler(this.Title_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.OptionsButton.Font = new System.Drawing.Font("Tele-Marines", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.Location = new System.Drawing.Point(12, 427);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(468, 38);
            this.OptionsButton.TabIndex = 3;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpButton.Font = new System.Drawing.Font("Tele-Marines", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(12, 471);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(468, 40);
            this.HelpButton.TabIndex = 4;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Tele-Marines", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(12, 517);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(468, 43);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HighScoreTable
            // 
            this.HighScoreTable.AllowUserToAddRows = false;
            this.HighScoreTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.HighScoreTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HighScoreTable.BackgroundColor = System.Drawing.Color.Black;
            this.HighScoreTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.HighScoreTable.Location = new System.Drawing.Point(96, 136);
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            this.HighScoreTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.HighScoreTable.RowTemplate.ReadOnly = true;
            this.HighScoreTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HighScoreTable.ShowRowErrors = false;
            this.HighScoreTable.Size = new System.Drawing.Size(306, 183);
            this.HighScoreTable.TabIndex = 7;
            this.HighScoreTable.VirtualMode = true;
            this.HighScoreTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HighScoreTable_CellContentClick);
            // 
            // Player
            // 
            this.Player.DataPropertyName = "Name";
            this.Player.HeaderText = "Player Name";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            // 
            // Score
            // 
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
            // NewHighScorePanel
            // 
            this.NewHighScorePanel.Controls.Add(this.NewHighScoreSubmitButton);
            this.NewHighScorePanel.Controls.Add(this.EnterNameBelowLabel);
            this.NewHighScorePanel.Controls.Add(this.NewHighScoreLabel);
            this.NewHighScorePanel.Controls.Add(this.NewHighScoreTextBox);
            this.NewHighScorePanel.Location = new System.Drawing.Point(42, 136);
            this.NewHighScorePanel.Name = "NewHighScorePanel";
            this.NewHighScorePanel.Size = new System.Drawing.Size(407, 397);
            this.NewHighScorePanel.TabIndex = 8;
            this.NewHighScorePanel.Visible = false;
            // 
            // NewHighScoreTextBox
            // 
            this.NewHighScoreTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHighScoreTextBox.Location = new System.Drawing.Point(54, 318);
            this.NewHighScoreTextBox.MaxLength = 10;
            this.NewHighScoreTextBox.Name = "NewHighScoreTextBox";
            this.NewHighScoreTextBox.Size = new System.Drawing.Size(237, 27);
            this.NewHighScoreTextBox.TabIndex = 0;
            this.NewHighScoreTextBox.TextChanged += new System.EventHandler(this.NewHighScoreTextBox_TextChanged);
            // 
            // NewHighScoreLabel
            // 
            this.NewHighScoreLabel.AutoSize = true;
            this.NewHighScoreLabel.Font = new System.Drawing.Font("Tele-Marines", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHighScoreLabel.Location = new System.Drawing.Point(49, 99);
            this.NewHighScoreLabel.Name = "NewHighScoreLabel";
            this.NewHighScoreLabel.Size = new System.Drawing.Size(329, 25);
            this.NewHighScoreLabel.TabIndex = 1;
            this.NewHighScoreLabel.Text = "New HighScore";
            this.NewHighScoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // EnterNameBelowLabel
            // 
            this.EnterNameBelowLabel.AutoSize = true;
            this.EnterNameBelowLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNameBelowLabel.Location = new System.Drawing.Point(77, 244);
            this.EnterNameBelowLabel.Name = "EnterNameBelowLabel";
            this.EnterNameBelowLabel.Size = new System.Drawing.Size(253, 23);
            this.EnterNameBelowLabel.TabIndex = 2;
            this.EnterNameBelowLabel.Text = "Please Enter Name Below";
            // 
            // highScoreBindingSource
            // 
            this.highScoreBindingSource.DataSource = typeof(Galactica.HighScore);
            // 
            // NewHighScoreSubmitButton
            // 
            this.NewHighScoreSubmitButton.Location = new System.Drawing.Point(297, 318);
            this.NewHighScoreSubmitButton.Name = "NewHighScoreSubmitButton";
            this.NewHighScoreSubmitButton.Size = new System.Drawing.Size(76, 27);
            this.NewHighScoreSubmitButton.TabIndex = 3;
            this.NewHighScoreSubmitButton.Text = "Submit";
            this.NewHighScoreSubmitButton.UseVisualStyleBackColor = true;
            this.NewHighScoreSubmitButton.Click += new System.EventHandler(this.NewHighScoreSubmitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Galactica.Properties.Resources.SpaceBackground_001;
            this.ClientSize = new System.Drawing.Size(492, 567);
            this.Controls.Add(this.NewHighScorePanel);
            this.Controls.Add(this.HighScoreTable);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayButton);
            this.ForeColor = System.Drawing.Color.White;
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
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreTable)).EndInit();
            this.NewHighScorePanel.ResumeLayout(false);
            this.NewHighScorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button ExitButton;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.BindingSource highScoreBindingSource;
        public System.Windows.Forms.DataGridView HighScoreTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelReached;
        private Panel NewHighScorePanel;
        private Label NewHighScoreLabel;
        private TextBox NewHighScoreTextBox;
        private Label EnterNameBelowLabel;
        private Button NewHighScoreSubmitButton;
    }
}
