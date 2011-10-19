namespace WindowsFormsApplication1
{
    partial class GameUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUI));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBattleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.attack = new System.Windows.Forms.Button();
            this.defeat = new System.Windows.Forms.Button();
            this.attack2 = new System.Windows.Forms.RadioButton();
            this.attack3 = new System.Windows.Forms.RadioButton();
            this.attack1 = new System.Windows.Forms.RadioButton();
            this.attack4 = new System.Windows.Forms.RadioButton();
            this.CurrentCharacterName = new System.Windows.Forms.Label();
            this.CurrentTeam = new System.Windows.Forms.Label();
            this.Player1Health = new System.Windows.Forms.ProgressBar();
            this.PlayerHealth2 = new System.Windows.Forms.ProgressBar();
            this.georgeImg = new System.Windows.Forms.PictureBox();
            this.bobImg = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.Label();
            this.win2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newBattleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.georgeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobImg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            resources.ApplyResources(this.newCharacterToolStripMenuItem, "newCharacterToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // newBattleToolStripMenuItem
            // 
            this.newBattleToolStripMenuItem.Name = "newBattleToolStripMenuItem";
            resources.ApplyResources(this.newBattleToolStripMenuItem, "newBattleToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            resources.ApplyResources(this.lineShape2, "lineShape2");
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            resources.ApplyResources(this.lineShape1, "lineShape1");
            // 
            // attack
            // 
            resources.ApplyResources(this.attack, "attack");
            this.attack.Name = "attack";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.attack_Click);
            // 
            // defeat
            // 
            resources.ApplyResources(this.defeat, "defeat");
            this.defeat.Name = "defeat";
            this.defeat.UseVisualStyleBackColor = true;
            this.defeat.Click += new System.EventHandler(this.defeat_Click);
            // 
            // attack2
            // 
            resources.ApplyResources(this.attack2, "attack2");
            this.attack2.Name = "attack2";
            this.attack2.TabStop = true;
            this.attack2.UseVisualStyleBackColor = true;
            this.attack2.CheckedChanged += new System.EventHandler(this.attack2_CheckedChanged);
            // 
            // attack3
            // 
            resources.ApplyResources(this.attack3, "attack3");
            this.attack3.Name = "attack3";
            this.attack3.TabStop = true;
            this.attack3.UseVisualStyleBackColor = true;
            this.attack3.CheckedChanged += new System.EventHandler(this.attack3_CheckedChanged);
            // 
            // attack1
            // 
            resources.ApplyResources(this.attack1, "attack1");
            this.attack1.Name = "attack1";
            this.attack1.TabStop = true;
            this.attack1.UseVisualStyleBackColor = true;
            this.attack1.CheckedChanged += new System.EventHandler(this.attack1_CheckedChanged);
            // 
            // attack4
            // 
            resources.ApplyResources(this.attack4, "attack4");
            this.attack4.Name = "attack4";
            this.attack4.TabStop = true;
            this.attack4.UseVisualStyleBackColor = true;
            this.attack4.CheckedChanged += new System.EventHandler(this.attack4_CheckedChanged);
            // 
            // CurrentCharacterName
            // 
            resources.ApplyResources(this.CurrentCharacterName, "CurrentCharacterName");
            this.CurrentCharacterName.Name = "CurrentCharacterName";
            // 
            // CurrentTeam
            // 
            resources.ApplyResources(this.CurrentTeam, "CurrentTeam");
            this.CurrentTeam.Name = "CurrentTeam";
            // 
            // Player1Health
            // 
            resources.ApplyResources(this.Player1Health, "Player1Health");
            this.Player1Health.Name = "Player1Health";
            this.Player1Health.Value = 100;
            // 
            // PlayerHealth2
            // 
            resources.ApplyResources(this.PlayerHealth2, "PlayerHealth2");
            this.PlayerHealth2.Name = "PlayerHealth2";
            this.PlayerHealth2.Value = 100;
            // 
            // georgeImg
            // 
            resources.ApplyResources(this.georgeImg, "georgeImg");
            this.georgeImg.Name = "georgeImg";
            this.georgeImg.TabStop = false;
            // 
            // bobImg
            // 
            resources.ApplyResources(this.bobImg, "bobImg");
            this.bobImg.Name = "bobImg";
            this.bobImg.TabStop = false;
            // 
            // win
            // 
            resources.ApplyResources(this.win, "win");
            this.win.Name = "win";
            // 
            // win2
            // 
            resources.ApplyResources(this.win2, "win2");
            this.win2.Name = "win2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.newBattleToolStripMenuItem1,
            this.optionsToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            resources.ApplyResources(this.fileToolStripMenuItem1, "fileToolStripMenuItem1");
            // 
            // newCharacterToolStripMenuItem1
            // 
            this.newCharacterToolStripMenuItem1.Name = "newCharacterToolStripMenuItem1";
            resources.ApplyResources(this.newCharacterToolStripMenuItem1, "newCharacterToolStripMenuItem1");
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click_1);
            // 
            // newBattleToolStripMenuItem1
            // 
            this.newBattleToolStripMenuItem1.Name = "newBattleToolStripMenuItem1";
            resources.ApplyResources(this.newBattleToolStripMenuItem1, "newBattleToolStripMenuItem1");
            this.newBattleToolStripMenuItem1.Click += new System.EventHandler(this.newBattleToolStripMenuItem1_Click_1);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem1});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            resources.ApplyResources(this.optionsToolStripMenuItem1, "optionsToolStripMenuItem1");
            // 
            // languageToolStripMenuItem1
            // 
            this.languageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem1,
            this.deutschToolStripMenuItem});
            this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
            resources.ApplyResources(this.languageToolStripMenuItem1, "languageToolStripMenuItem1");
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            resources.ApplyResources(this.englishToolStripMenuItem1, "englishToolStripMenuItem1");
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem1_Click_1);
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            resources.ApplyResources(this.deutschToolStripMenuItem, "deutschToolStripMenuItem");
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click_1);
            // 
            // GameUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.win2);
            this.Controls.Add(this.win);
            this.Controls.Add(this.bobImg);
            this.Controls.Add(this.georgeImg);
            this.Controls.Add(this.PlayerHealth2);
            this.Controls.Add(this.Player1Health);
            this.Controls.Add(this.CurrentTeam);
            this.Controls.Add(this.CurrentCharacterName);
            this.Controls.Add(this.attack4);
            this.Controls.Add(this.attack1);
            this.Controls.Add(this.attack3);
            this.Controls.Add(this.attack2);
            this.Controls.Add(this.defeat);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameUI";
            this.Load += new System.EventHandler(this.GameUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.georgeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobImg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBattleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.Button defeat;
        private System.Windows.Forms.RadioButton attack2;
        private System.Windows.Forms.RadioButton attack3;
        private System.Windows.Forms.RadioButton attack1;
        private System.Windows.Forms.RadioButton attack4;
        private System.Windows.Forms.Label CurrentCharacterName;
        private System.Windows.Forms.Label CurrentTeam;
        private System.Windows.Forms.ProgressBar Player1Health;
        private System.Windows.Forms.ProgressBar PlayerHealth2;
        private System.Windows.Forms.PictureBox georgeImg;
        private System.Windows.Forms.PictureBox bobImg;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label win2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newBattleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
    }
}