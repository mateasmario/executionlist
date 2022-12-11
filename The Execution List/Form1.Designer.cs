namespace The_Execution_List
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MainMenuTabPage = new System.Windows.Forms.TabPage();
            this.ExitButton_MainMenu = new System.Windows.Forms.Button();
            this.CreditsButton_MainMenu = new System.Windows.Forms.Button();
            this.StartGameButton_MainMenu = new System.Windows.Forms.Button();
            this.LogoPictureBox_MainMenu = new System.Windows.Forms.PictureBox();
            this.CreditsTabPage = new System.Windows.Forms.TabPage();
            this.BackButton_Credits = new System.Windows.Forms.Button();
            this.GameTabPage = new System.Windows.Forms.TabPage();
            this.TimerLabel_Game = new System.Windows.Forms.Label();
            this.NameLabel_Game = new System.Windows.Forms.Label();
            this.PapyrusPictureBox_Game = new System.Windows.Forms.PictureBox();
            this.LostTabPage = new System.Windows.Forms.TabPage();
            this.RetryButton_Lost = new System.Windows.Forms.Button();
            this.RankLabel_Lost = new System.Windows.Forms.Label();
            this.MessageLabel_Lost = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DesignLabel_Credits = new System.Windows.Forms.Label();
            this.DesignDescription_Credits = new System.Windows.Forms.Label();
            this.MusicDescription_Credits = new System.Windows.Forms.Label();
            this.MusicLabel_Credits = new System.Windows.Forms.Label();
            this.FinalTextLabel_Credits = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.MainMenuTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox_MainMenu)).BeginInit();
            this.CreditsTabPage.SuspendLayout();
            this.GameTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PapyrusPictureBox_Game)).BeginInit();
            this.LostTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MainMenuTabPage);
            this.TabControl.Controls.Add(this.CreditsTabPage);
            this.TabControl.Controls.Add(this.GameTabPage);
            this.TabControl.Controls.Add(this.LostTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(862, 534);
            this.TabControl.TabIndex = 0;
            // 
            // MainMenuTabPage
            // 
            this.MainMenuTabPage.BackColor = System.Drawing.Color.Black;
            this.MainMenuTabPage.BackgroundImage = global::The_Execution_List.Properties.Resources.MenuBackground;
            this.MainMenuTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuTabPage.Controls.Add(this.ExitButton_MainMenu);
            this.MainMenuTabPage.Controls.Add(this.CreditsButton_MainMenu);
            this.MainMenuTabPage.Controls.Add(this.StartGameButton_MainMenu);
            this.MainMenuTabPage.Controls.Add(this.LogoPictureBox_MainMenu);
            this.MainMenuTabPage.Location = new System.Drawing.Point(4, 22);
            this.MainMenuTabPage.Name = "MainMenuTabPage";
            this.MainMenuTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainMenuTabPage.Size = new System.Drawing.Size(854, 508);
            this.MainMenuTabPage.TabIndex = 0;
            this.MainMenuTabPage.Text = "Main Menu";
            // 
            // ExitButton_MainMenu
            // 
            this.ExitButton_MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton_MainMenu.BackgroundImage = global::The_Execution_List.Properties.Resources.ExitButton_MainMenu_Plain;
            this.ExitButton_MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton_MainMenu.FlatAppearance.BorderSize = 0;
            this.ExitButton_MainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton_MainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton_MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton_MainMenu.Location = new System.Drawing.Point(6, 420);
            this.ExitButton_MainMenu.Name = "ExitButton_MainMenu";
            this.ExitButton_MainMenu.Size = new System.Drawing.Size(179, 52);
            this.ExitButton_MainMenu.TabIndex = 3;
            this.ExitButton_MainMenu.UseVisualStyleBackColor = false;
            this.ExitButton_MainMenu.Click += new System.EventHandler(this.ExitButton_MainMenu_Click);
            this.ExitButton_MainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.ExitButton_MainMenu.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ExitButton_MainMenu.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.ExitButton_MainMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // CreditsButton_MainMenu
            // 
            this.CreditsButton_MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.CreditsButton_MainMenu.BackgroundImage = global::The_Execution_List.Properties.Resources.CreditsButton_MainMenu_Plain;
            this.CreditsButton_MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CreditsButton_MainMenu.FlatAppearance.BorderSize = 0;
            this.CreditsButton_MainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreditsButton_MainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreditsButton_MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsButton_MainMenu.Location = new System.Drawing.Point(6, 375);
            this.CreditsButton_MainMenu.Name = "CreditsButton_MainMenu";
            this.CreditsButton_MainMenu.Size = new System.Drawing.Size(179, 52);
            this.CreditsButton_MainMenu.TabIndex = 2;
            this.CreditsButton_MainMenu.UseVisualStyleBackColor = false;
            this.CreditsButton_MainMenu.Click += new System.EventHandler(this.CreditsButton_MainMenu_Click);
            this.CreditsButton_MainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.CreditsButton_MainMenu.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.CreditsButton_MainMenu.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.CreditsButton_MainMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // StartGameButton_MainMenu
            // 
            this.StartGameButton_MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.StartGameButton_MainMenu.BackgroundImage = global::The_Execution_List.Properties.Resources.StartGameButton_MainMenu_Plain;
            this.StartGameButton_MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartGameButton_MainMenu.FlatAppearance.BorderSize = 0;
            this.StartGameButton_MainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartGameButton_MainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartGameButton_MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameButton_MainMenu.Location = new System.Drawing.Point(6, 330);
            this.StartGameButton_MainMenu.Name = "StartGameButton_MainMenu";
            this.StartGameButton_MainMenu.Size = new System.Drawing.Size(179, 52);
            this.StartGameButton_MainMenu.TabIndex = 1;
            this.StartGameButton_MainMenu.UseVisualStyleBackColor = false;
            this.StartGameButton_MainMenu.Click += new System.EventHandler(this.StartGameButton_MainMenu_Click);
            this.StartGameButton_MainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.StartGameButton_MainMenu.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.StartGameButton_MainMenu.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.StartGameButton_MainMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // LogoPictureBox_MainMenu
            // 
            this.LogoPictureBox_MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox_MainMenu.BackgroundImage = global::The_Execution_List.Properties.Resources.Logo;
            this.LogoPictureBox_MainMenu.Location = new System.Drawing.Point(-15, 200);
            this.LogoPictureBox_MainMenu.Name = "LogoPictureBox_MainMenu";
            this.LogoPictureBox_MainMenu.Size = new System.Drawing.Size(512, 140);
            this.LogoPictureBox_MainMenu.TabIndex = 0;
            this.LogoPictureBox_MainMenu.TabStop = false;
            // 
            // CreditsTabPage
            // 
            this.CreditsTabPage.BackgroundImage = global::The_Execution_List.Properties.Resources.CreditsBackground;
            this.CreditsTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreditsTabPage.Controls.Add(this.FinalTextLabel_Credits);
            this.CreditsTabPage.Controls.Add(this.MusicDescription_Credits);
            this.CreditsTabPage.Controls.Add(this.MusicLabel_Credits);
            this.CreditsTabPage.Controls.Add(this.DesignDescription_Credits);
            this.CreditsTabPage.Controls.Add(this.DesignLabel_Credits);
            this.CreditsTabPage.Controls.Add(this.BackButton_Credits);
            this.CreditsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CreditsTabPage.Name = "CreditsTabPage";
            this.CreditsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreditsTabPage.Size = new System.Drawing.Size(854, 508);
            this.CreditsTabPage.TabIndex = 1;
            this.CreditsTabPage.Text = "Credits";
            this.CreditsTabPage.UseVisualStyleBackColor = true;
            // 
            // BackButton_Credits
            // 
            this.BackButton_Credits.BackColor = System.Drawing.Color.Transparent;
            this.BackButton_Credits.BackgroundImage = global::The_Execution_List.Properties.Resources.BackButton_Credits_Plain;
            this.BackButton_Credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton_Credits.FlatAppearance.BorderSize = 0;
            this.BackButton_Credits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackButton_Credits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackButton_Credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton_Credits.Location = new System.Drawing.Point(3, 4);
            this.BackButton_Credits.Name = "BackButton_Credits";
            this.BackButton_Credits.Size = new System.Drawing.Size(179, 52);
            this.BackButton_Credits.TabIndex = 3;
            this.BackButton_Credits.UseVisualStyleBackColor = false;
            this.BackButton_Credits.Click += new System.EventHandler(this.BackButton_Credits_Click);
            this.BackButton_Credits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.BackButton_Credits.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.BackButton_Credits.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.BackButton_Credits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // GameTabPage
            // 
            this.GameTabPage.BackColor = System.Drawing.Color.Black;
            this.GameTabPage.BackgroundImage = global::The_Execution_List.Properties.Resources.MenuBackground;
            this.GameTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameTabPage.Controls.Add(this.TimerLabel_Game);
            this.GameTabPage.Controls.Add(this.NameLabel_Game);
            this.GameTabPage.Controls.Add(this.PapyrusPictureBox_Game);
            this.GameTabPage.Location = new System.Drawing.Point(4, 22);
            this.GameTabPage.Name = "GameTabPage";
            this.GameTabPage.Size = new System.Drawing.Size(854, 508);
            this.GameTabPage.TabIndex = 2;
            this.GameTabPage.Text = "Game";
            this.GameTabPage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameTabPage_PreviewKeyDown);
            // 
            // TimerLabel_Game
            // 
            this.TimerLabel_Game.AutoSize = true;
            this.TimerLabel_Game.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel_Game.Font = new System.Drawing.Font("Almendra SC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel_Game.ForeColor = System.Drawing.Color.White;
            this.TimerLabel_Game.Location = new System.Drawing.Point(8, 9);
            this.TimerLabel_Game.Name = "TimerLabel_Game";
            this.TimerLabel_Game.Size = new System.Drawing.Size(49, 23);
            this.TimerLabel_Game.TabIndex = 2;
            this.TimerLabel_Game.Text = "Time";
            // 
            // NameLabel_Game
            // 
            this.NameLabel_Game.AutoSize = true;
            this.NameLabel_Game.BackColor = System.Drawing.Color.White;
            this.NameLabel_Game.Font = new System.Drawing.Font("Almendra SC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel_Game.ForeColor = System.Drawing.Color.Black;
            this.NameLabel_Game.Location = new System.Drawing.Point(339, 210);
            this.NameLabel_Game.Name = "NameLabel_Game";
            this.NameLabel_Game.Size = new System.Drawing.Size(133, 29);
            this.NameLabel_Game.TabIndex = 0;
            this.NameLabel_Game.Text = "Input Name";
            // 
            // PapyrusPictureBox_Game
            // 
            this.PapyrusPictureBox_Game.BackColor = System.Drawing.Color.Transparent;
            this.PapyrusPictureBox_Game.BackgroundImage = global::The_Execution_List.Properties.Resources.Papyrus;
            this.PapyrusPictureBox_Game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PapyrusPictureBox_Game.Location = new System.Drawing.Point(6, 147);
            this.PapyrusPictureBox_Game.Name = "PapyrusPictureBox_Game";
            this.PapyrusPictureBox_Game.Size = new System.Drawing.Size(843, 175);
            this.PapyrusPictureBox_Game.TabIndex = 1;
            this.PapyrusPictureBox_Game.TabStop = false;
            // 
            // LostTabPage
            // 
            this.LostTabPage.BackgroundImage = global::The_Execution_List.Properties.Resources.Lost;
            this.LostTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LostTabPage.Controls.Add(this.RetryButton_Lost);
            this.LostTabPage.Controls.Add(this.RankLabel_Lost);
            this.LostTabPage.Controls.Add(this.MessageLabel_Lost);
            this.LostTabPage.Location = new System.Drawing.Point(4, 22);
            this.LostTabPage.Name = "LostTabPage";
            this.LostTabPage.Size = new System.Drawing.Size(854, 508);
            this.LostTabPage.TabIndex = 3;
            this.LostTabPage.Text = "Lost";
            this.LostTabPage.UseVisualStyleBackColor = true;
            // 
            // RetryButton_Lost
            // 
            this.RetryButton_Lost.BackColor = System.Drawing.Color.Transparent;
            this.RetryButton_Lost.BackgroundImage = global::The_Execution_List.Properties.Resources.RetryButton_Lost_Plain;
            this.RetryButton_Lost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RetryButton_Lost.FlatAppearance.BorderSize = 0;
            this.RetryButton_Lost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RetryButton_Lost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RetryButton_Lost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetryButton_Lost.Location = new System.Drawing.Point(3, 4);
            this.RetryButton_Lost.Name = "RetryButton_Lost";
            this.RetryButton_Lost.Size = new System.Drawing.Size(179, 52);
            this.RetryButton_Lost.TabIndex = 4;
            this.RetryButton_Lost.UseVisualStyleBackColor = false;
            this.RetryButton_Lost.Click += new System.EventHandler(this.RetryButton_Lost_Click);
            this.RetryButton_Lost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.RetryButton_Lost.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RetryButton_Lost.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.RetryButton_Lost.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            // 
            // RankLabel_Lost
            // 
            this.RankLabel_Lost.AutoSize = true;
            this.RankLabel_Lost.Font = new System.Drawing.Font("Almendra SC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankLabel_Lost.ForeColor = System.Drawing.Color.White;
            this.RankLabel_Lost.Location = new System.Drawing.Point(329, 430);
            this.RankLabel_Lost.Name = "RankLabel_Lost";
            this.RankLabel_Lost.Size = new System.Drawing.Size(191, 29);
            this.RankLabel_Lost.TabIndex = 1;
            this.RankLabel_Lost.Text = "Your Rank: Rank";
            // 
            // MessageLabel_Lost
            // 
            this.MessageLabel_Lost.AutoSize = true;
            this.MessageLabel_Lost.Font = new System.Drawing.Font("Almendra SC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel_Lost.ForeColor = System.Drawing.Color.White;
            this.MessageLabel_Lost.Location = new System.Drawing.Point(372, 401);
            this.MessageLabel_Lost.Name = "MessageLabel_Lost";
            this.MessageLabel_Lost.Size = new System.Drawing.Size(101, 29);
            this.MessageLabel_Lost.TabIndex = 0;
            this.MessageLabel_Lost.Text = "Message";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // DesignLabel_Credits
            // 
            this.DesignLabel_Credits.AutoSize = true;
            this.DesignLabel_Credits.Font = new System.Drawing.Font("Almendra SC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignLabel_Credits.ForeColor = System.Drawing.Color.Black;
            this.DesignLabel_Credits.Location = new System.Drawing.Point(6, 71);
            this.DesignLabel_Credits.Name = "DesignLabel_Credits";
            this.DesignLabel_Credits.Size = new System.Drawing.Size(110, 38);
            this.DesignLabel_Credits.TabIndex = 4;
            this.DesignLabel_Credits.Text = "Design";
            // 
            // DesignDescription_Credits
            // 
            this.DesignDescription_Credits.AutoSize = true;
            this.DesignDescription_Credits.Font = new System.Drawing.Font("Almendra SC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignDescription_Credits.ForeColor = System.Drawing.Color.Black;
            this.DesignDescription_Credits.Location = new System.Drawing.Point(10, 108);
            this.DesignDescription_Credits.Name = "DesignDescription_Credits";
            this.DesignDescription_Credits.Size = new System.Drawing.Size(505, 92);
            this.DesignDescription_Credits.TabIndex = 5;
            this.DesignDescription_Credits.Text = "Main Menu Background Image (vectorpocket - freepik.com)\r\nCredits Background Image" +
    " (0melapics - freepik.com)\r\nFinal Results Background Image (vectorpouch - freepi" +
    "k.com)\r\nButton Textures from clipart.me";
            // 
            // MusicDescription_Credits
            // 
            this.MusicDescription_Credits.AutoSize = true;
            this.MusicDescription_Credits.Font = new System.Drawing.Font("Almendra SC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicDescription_Credits.ForeColor = System.Drawing.Color.White;
            this.MusicDescription_Credits.Location = new System.Drawing.Point(10, 240);
            this.MusicDescription_Credits.Name = "MusicDescription_Credits";
            this.MusicDescription_Credits.Size = new System.Drawing.Size(669, 46);
            this.MusicDescription_Credits.TabIndex = 7;
            this.MusicDescription_Credits.Text = "One Bard Band by Alexander Nakarada (https://www.serpentsoundstudios.com)\r\nMusic " +
    "promoted by https://www.chosic.com/free-music/all/";
            // 
            // MusicLabel_Credits
            // 
            this.MusicLabel_Credits.AutoSize = true;
            this.MusicLabel_Credits.Font = new System.Drawing.Font("Almendra SC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicLabel_Credits.ForeColor = System.Drawing.Color.White;
            this.MusicLabel_Credits.Location = new System.Drawing.Point(6, 203);
            this.MusicLabel_Credits.Name = "MusicLabel_Credits";
            this.MusicLabel_Credits.Size = new System.Drawing.Size(253, 38);
            this.MusicLabel_Credits.TabIndex = 6;
            this.MusicLabel_Credits.Text = "Music and Sound";
            // 
            // FinalTextLabel_Credits
            // 
            this.FinalTextLabel_Credits.AutoSize = true;
            this.FinalTextLabel_Credits.Font = new System.Drawing.Font("Almendra SC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalTextLabel_Credits.ForeColor = System.Drawing.Color.White;
            this.FinalTextLabel_Credits.Location = new System.Drawing.Point(12, 473);
            this.FinalTextLabel_Credits.Name = "FinalTextLabel_Credits";
            this.FinalTextLabel_Credits.Size = new System.Drawing.Size(402, 23);
            this.FinalTextLabel_Credits.TabIndex = 9;
            this.FinalTextLabel_Credits.Text = "\"The Execution List\" developed by Mateas Mario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 534);
            this.Controls.Add(this.TabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "The Execution List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.MainMenuTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox_MainMenu)).EndInit();
            this.CreditsTabPage.ResumeLayout(false);
            this.CreditsTabPage.PerformLayout();
            this.GameTabPage.ResumeLayout(false);
            this.GameTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PapyrusPictureBox_Game)).EndInit();
            this.LostTabPage.ResumeLayout(false);
            this.LostTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MainMenuTabPage;
        private System.Windows.Forms.TabPage CreditsTabPage;
        private System.Windows.Forms.PictureBox LogoPictureBox_MainMenu;
        private System.Windows.Forms.Button StartGameButton_MainMenu;
        private System.Windows.Forms.Button CreditsButton_MainMenu;
        private System.Windows.Forms.Button ExitButton_MainMenu;
        private System.Windows.Forms.Button BackButton_Credits;
        private System.Windows.Forms.TabPage GameTabPage;
        private System.Windows.Forms.Label NameLabel_Game;
        private System.Windows.Forms.PictureBox PapyrusPictureBox_Game;
        private System.Windows.Forms.Label TimerLabel_Game;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TabPage LostTabPage;
        private System.Windows.Forms.Label RankLabel_Lost;
        private System.Windows.Forms.Label MessageLabel_Lost;
        private System.Windows.Forms.Button RetryButton_Lost;
        private System.Windows.Forms.Label MusicDescription_Credits;
        private System.Windows.Forms.Label MusicLabel_Credits;
        private System.Windows.Forms.Label DesignDescription_Credits;
        private System.Windows.Forms.Label DesignLabel_Credits;
        private System.Windows.Forms.Label FinalTextLabel_Credits;
    }
}

