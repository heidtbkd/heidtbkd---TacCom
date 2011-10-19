using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Resources;
using TacCom;

namespace WindowsFormsApplication1
{
    public partial class GameUI : Form
    {
        private Effect currentEffect;
        private GameBoard board;
        private ResourceManager lanMan = new ResourceManager("GameUI",typeof(GameUI).Assembly);


        public GameUI()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");

            Character bob = new Character("Bob", null, 10, 10, 10, null, "Wizard");
            bob.SetFirstAbilityForCharacter(new CharAbility("It Has Begun",new Effect("health", 1, 10, false, null),"attack",10,null));
            bob.SetSecondAbilityForCharacter(new CharAbility("Devour Soul", new Effect("attackPower", 1, 10, false, null), "attack", 10, null));
            bob.SetThirdAbilityForCharacter(new CharAbility("Enrage", new Effect("dodge", 1, 1, false, null), "spell", 10, null));
            bob.SetFourthAbilityForCharacter(new CharAbility("Time Branch", new Effect("crit",1,1,false,null), "spell", 100, null));

            Character george = new Character("George", null, 1, 1, 10, null, "Warrior");
            george.SetFirstAbilityForCharacter(new CharAbility("Let's Do This!", new Effect("health", 1, 40, false, null), "attack", 1, null));
            george.SetSecondAbilityForCharacter(new CharAbility("Poke", new Effect("health", 1, 1, false, null), "attack", 1, null));
            george.SetThirdAbilityForCharacter(new CharAbility("Prod", new Effect("health", 1, 2, false, null), "attack", 2, null));
            george.SetFourthAbilityForCharacter(new CharAbility("Glitter Strike", new Effect("spellPower", 1, 10, false, null), "spell", 10, null));
            
            
            String[] names = {"Red", "Blue"};
            Character[] team1 = {bob, null, null, null, null, null};
            Character[] team2 = {george, null, null, null, null, null};
            board = new GameBoard(names , team1, team2, null, null);

            Player1Health.Value = team1[0].GetCharacterHitPoints();
            PlayerHealth2.Value = team2[0].GetCharacterHitPoints();
            if (board.getTurn())
            {
                CurrentTeam.Text = names[0];
                CurrentCharacterName.Text = team1[0].GetCharacterName();

                attack1.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[0].getAbilityName();
                attack2.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[1].getAbilityName();
                attack3.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[2].getAbilityName();
                attack4.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[3].getAbilityName();
            }
            else
            {
                CurrentTeam.Text = names[1];
                CurrentCharacterName.Text = team2[0].GetCharacterName();

                attack1.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[0].getAbilityName();
                attack2.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[1].getAbilityName();
                attack3.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[2].getAbilityName();
                attack4.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[3].getAbilityName();
            }

            
            georgeImg.Image = Image.FromFile("C:/Documents and Settings/heidtbkd/TacCom/Source/TacCom/WindowsFormsApplication1/textures/characters/george/George_The_Fancy_Man.png");
            bobImg.Image = Image.FromFile("C:/Documents and Settings/heidtbkd/TacCom/Source/TacCom/WindowsFormsApplication1/textures/characters/bob/bob.png");

            Size imgSize = new Size();
            imgSize.Width = 400;
            imgSize.Height = 400;

            georgeImg.Image = resizeImage(georgeImg.Image, imgSize);
            bobImg.Image = resizeImage(bobImg.Image, imgSize);
            
        }

        public System.Drawing.Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW) nPercent = nPercentH;
            else
                nPercent = nPercentW;
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }


        private void GameUI_Load(object sender, EventArgs e)
        {

        }

        private void attack1_CheckedChanged(object sender, EventArgs e)
        {
            if (board.getTurn())
            {
                currentEffect = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[0].getAbilityEffect();
            }
            else
            {
                currentEffect = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[0].getAbilityEffect();
            }
        }

        private void attack2_CheckedChanged(object sender, EventArgs e)
        {
            if (board.getTurn())
            {
                currentEffect = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[1].getAbilityEffect();
            }
            else
            {
                currentEffect = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[1].getAbilityEffect();
            }
        }

        private void attack3_CheckedChanged(object sender, EventArgs e)
        {
            if (board.getTurn())
            {
                currentEffect = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[2].getAbilityEffect();
            }
            else
            {
                currentEffect = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[2].getAbilityEffect();
            }
        }

        private void attack4_CheckedChanged(object sender, EventArgs e)
        {
            if (board.getTurn())
            {
                currentEffect = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[3].getAbilityEffect();
            }
            else
            {
                currentEffect = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[3].getAbilityEffect();
            }
        }

        private void attack_Click(object sender, EventArgs e)
        {
            if (board.getTurn())
            {
                currentEffect.setTarget(board.getSecondTeamCharacters()[0]);
            }
            else
            {
                currentEffect.setTarget(board.getFirstTeamCharacters()[0]);
            }
            board.addEffect(currentEffect);
            board.turn();


            Player1Health.Value = board.getFirstTeamCharacters()[0].GetCharacterHitPoints();
            PlayerHealth2.Value = board.getSecondTeamCharacters()[0].GetCharacterHitPoints();
            if (board.getTurn())
            {
                CurrentTeam.Text = board.getTeamNames()[0];
                CurrentCharacterName.Text = board.getFirstTeamCharacters()[0].GetCharacterName();

                attack1.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[0].getAbilityName();
                attack2.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[1].getAbilityName();
                attack3.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[2].getAbilityName();
                attack4.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[3].getAbilityName();

                if (board.getFirstTeamCharacters()[0].GetDead())
                {
                    win.Visible = true;
                }
            }
            else
            {
                CurrentTeam.Text = board.getTeamNames()[1];
                CurrentCharacterName.Text = board.getSecondTeamCharacters()[0].GetCharacterName();

                attack1.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[0].getAbilityName();
                attack2.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[1].getAbilityName();
                attack3.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[2].getAbilityName();
                attack4.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[3].getAbilityName();
                
                if (board.getSecondTeamCharacters()[0].GetDead())
                {
                    win2.Visible = true;
                }
            }
            
        }

        private void defeat_Click(object sender, EventArgs e)
        {
            if (board.getTurn())
            {
                board.getFirstTeamCharacters()[0].SetDead();
            }
            else
            {
                board.getSecondTeamCharacters()[0].SetDead();
            }
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newBattleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void englishToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ChangeLanguage("en");
             
        }

        private void deutschToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangeLanguage("de");
        }

       // [Matt Klaasse]
        private void ChangeLanguage(string lang)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(GameUI));
            foreach (Control c in this.Controls)
            {
                
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }

            resources.ApplyResources(languageToolStripMenuItem1, languageToolStripMenuItem1.Name, new CultureInfo(lang));
            resources.ApplyResources(optionsToolStripMenuItem1, optionsToolStripMenuItem1.Name, new CultureInfo(lang));
            resources.ApplyResources(fileToolStripMenuItem1, fileToolStripMenuItem1.Name, new CultureInfo(lang));
            resources.ApplyResources(exitToolStripMenuItem1, exitToolStripMenuItem1.Name, new CultureInfo(lang));
            resources.ApplyResources(newCharacterToolStripMenuItem1, newCharacterToolStripMenuItem1.Name, new CultureInfo(lang));
            resources.ApplyResources(newBattleToolStripMenuItem1, newBattleToolStripMenuItem1.Name, new CultureInfo(lang));
            resources.ApplyResources(englishToolStripMenuItem1, englishToolStripMenuItem1.Name, new CultureInfo(lang));
            resources.ApplyResources(deutschToolStripMenuItem, deutschToolStripMenuItem.Name, new CultureInfo(lang));
            resources.ApplyResources(win, win.Name, new CultureInfo(lang));
            resources.ApplyResources(win2, win2.Name, new CultureInfo(lang));

            if (board.getTurn())
            {
                CurrentTeam.Text = board.getFirstTeamCharacters()[0].GetCharacterName();
                CurrentCharacterName.Text = board.getTeamNames()[0];

                attack1.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[0].getAbilityName();
                attack2.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[1].getAbilityName();
                attack3.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[2].getAbilityName();
                attack4.Text = board.getFirstTeamCharacters()[0].GetCharacterAbilities()[3].getAbilityName();
            }
            else
            {
                CurrentTeam.Text = board.getSecondTeamCharacters()[0].GetCharacterName();
                CurrentCharacterName.Text = board.getTeamNames()[1];

                attack1.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[0].getAbilityName();
                attack2.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[1].getAbilityName();
                attack3.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[2].getAbilityName();
                attack4.Text = board.getSecondTeamCharacters()[0].GetCharacterAbilities()[3].getAbilityName();
            }
        }
    }
}
