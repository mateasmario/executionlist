using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Execution_List
{
    public partial class Form1 : Form
    {
        string currentName;
        int timeLeft = 30;
        int actualTimeLeft;
        int counter = 0;
        System.Media.SoundPlayer player;

        public List<string> MaleFirstNames = new List<string>(
            new string[]
            {
                "Christian",
                "Cyprian",
                "Dante",
                "Hal",
                "Henry",
                "John",
                "Julian",
                "Lucan",
                "Peter",
                "Roger",
                "Ulrich",
                "Walter",
                "William",
            }
        );
        public List<string> FemaleFirstNames = new List<string>(
            new string[]
            {
                "Alice",
                "Amabel",
                "Amira",
                "Beatrice",
                "Bess",
                "Elisabeth",
                "Ellen",
                "Ellis",
                "Emma",
                "Emmeline",
                "Ermentrude",
                "Hilary",
                "Isabeau",
                "Isabella",
                "Lucia",
                "Vivian"
            }    
        );

        public List<string> LastNames = new List<string>(
            new string[]
            {
                "Ashdown",
                "Baker",
                "Beckett",
                "Bennett",
                "Bigge",
                "Brewer",
                "Brickenden",
                "Brooker",
                "Browne",
                "Carey",
                "Carpenter",
                "Cheeseman",
                "Clarke",
                "Cooper",
                "Ead",
                "Fisher",
                "Fletcher",
                "Foreman",
                "Godfrey",
                "Gregory",
                "Hill",
                "Hughes",
                "Kaiser",
                "Kimball",
                "Klein",
                "Koch",
                "Kruger",
                "Maddock",
                "Mannering",
                "Nash",
                "Norman",
                "Nuemann",
                "Payne",
                "Rolfe",
                "Schneider",
                "Taylor",
                "Turner",
                "Walter",
                "Ward",
                "Webb",
                "Wood",
                "Wright",
                "Zimmerman"
            }
        );

        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        public void DisableDoubleBuffering(TabPage tabPage)
        {
            typeof(TabPage).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, tabPage, new object[] { true });
        }
                
        public void DisableDoubleBuffering(PictureBox pictureBox)
        {
            typeof(PictureBox).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, pictureBox, new object[] { true });
        }
        
        public void HideTabControlHeader(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        public void DisableWhiteBackgroundFromChild(Object obj, TabPage parent)
        {
            if (obj is PictureBox)
            {
                PictureBox temp = (PictureBox)obj;
                temp.Parent = parent;
                temp.BackColor = Color.Transparent;
                temp.Refresh();
            }
            else if (obj is Label)
            {
                Label temp = (Label)obj;
                temp.Parent = parent;
                temp.BackColor = Color.Transparent;
                temp.Refresh();
            }
            else if (obj is Button)
            {
                Button temp = (Button)obj;
                temp.Parent = parent;
                temp.BackColor = Color.Transparent;
                temp.Refresh();
            }
        }

        public void DisableWhiteBackgroundFromChild(Object obj, PictureBox parent)
        {
            if (obj is PictureBox)
            {
                PictureBox temp = (PictureBox)obj;
                temp.Parent = parent;
                temp.BackColor = Color.Transparent;
                temp.Refresh();
            }
            else if (obj is Label)
            {
                Label temp = (Label)obj;
                temp.Parent = parent;
                temp.BackColor = Color.Transparent;
                parent.Refresh();
            }
            else if (obj is Button)
            {
                Button temp = (Button)obj;
                temp.Parent = parent;
                temp.BackColor = Color.Transparent;
                temp.Refresh();
            }
        }

        public void PlaySoundEffect(string path)
        {
            mciSendString(@"close applause", null, 0, IntPtr.Zero);
            mciSendString(@"open music/ButtonClick.wav type waveaudio alias applause", null, 0, IntPtr.Zero);
            mciSendString(@"play applause", null, 0, IntPtr.Zero);
        }

        public string GenerateName()
        {
            string result = "";

            Random random = new Random();
            int genderChoice = random.Next(2);

            int firstNameChoice;

            List<string> firstNameChoices;

            if (genderChoice == 0)
                firstNameChoices = MaleFirstNames;
            else firstNameChoices = FemaleFirstNames;

            int nameChoice;

            // take first name randomly
            nameChoice = random.Next(firstNameChoices.Count);
            result += firstNameChoices[nameChoice];

            result += " ";

            nameChoice = random.Next(LastNames.Count);
            result += LastNames[nameChoice];

            return result;
        }

        public void ModifyLabel()
        {
            currentName = GenerateName();
            NameLabel_Game.Text = currentName;
            actualTimeLeft = timeLeft;
            TimerLabel_Game.Text = actualTimeLeft.ToString();
            counter++;
            if (counter % 2 == 0 && Timer.Interval > 100) Timer.Interval -= 100;
        }

        public void RemoveLetterFromLabel()
        {
            currentName = currentName.Substring(1);
            NameLabel_Game.Text = NameLabel_Game.Text.Substring(1);
            if (currentName.Length == 0)
                ModifyLabel();
        }

        public void AlignLabelToCenter(Label label, PictureBox pictureBox, int prefHeight)
        {
            label.Location = new Point(0, prefHeight);
            label.AutoSize = false;
            label.Left = 10;
            label.Width = pictureBox.Width - 10;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.None;
        }

        public void AlignLabelToCenter(Label label, TabPage tabPage, int prefHeight)
        {
            label.Location = new Point(0, prefHeight);
            label.AutoSize = false;
            label.Left = 10;
            label.Width = tabPage.Width - 10;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.None;
        }
        
        public void Start()
        {
            counter = 0;
            ModifyLabel();
            TabControl.SelectTab(2);
            GameTabPage.Focus();
            timeLeft = 30;
            Timer.Interval = 2000;
            Timer.Start();
        }

        public void Lost()
        {
            if (counter < 15)
            {
                MessageLabel_Lost.Text = "Already done? You'll be executed for that.";
                RankLabel_Lost.Text = "Rank:  Prisoner";
            }
            else if (counter >= 15 && counter < 35)
            {
                MessageLabel_Lost.Text = "I think you're going to be fired for that.";
                RankLabel_Lost.Text = "Rank:  Peasant";
            }
            else if (counter > 35 && counter < 75)
            {
                MessageLabel_Lost.Text = "Pretty average, but not bad.";
                RankLabel_Lost.Text = "Rank:  Beginner Copyist";
            }
            else if (counter > 75 && counter < 150)
            {
                MessageLabel_Lost.Text = "Hmm... the king kind of likes you.";
                RankLabel_Lost.Text = "Rank:  Intermediate Copyist";
            }
            else if (counter >= 150 && counter < 300)
            {
                MessageLabel_Lost.Text = "Nice. Keep up the good work!";
                RankLabel_Lost.Text = "Rank:  Advanced Copyist";
            }
            else if (counter >= 300)
            {
                MessageLabel_Lost.Text = "You're a monster! That was amazing!";
                RankLabel_Lost.Text = "Rank:  Master Copyist of the Kingdom";
            }

            player = new System.Media.SoundPlayer("music/Lost.wav");
            player.Play();

            TabControl.SelectTab(3);
            LostTabPage.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fix Design Flaws
            DisableDoubleBuffering(MainMenuTabPage);
            DisableDoubleBuffering(CreditsTabPage);
            DisableDoubleBuffering(LogoPictureBox_MainMenu);
            HideTabControlHeader(TabControl);
            DisableWhiteBackgroundFromChild(LogoPictureBox_MainMenu, MainMenuTabPage);
            DisableWhiteBackgroundFromChild(PapyrusPictureBox_Game, GameTabPage);
            DisableWhiteBackgroundFromChild(NameLabel_Game, PapyrusPictureBox_Game);
            DisableWhiteBackgroundFromChild(TimerLabel_Game, GameTabPage);
            DisableWhiteBackgroundFromChild(MessageLabel_Lost, LostTabPage);
            DisableWhiteBackgroundFromChild(RankLabel_Lost, LostTabPage);
            DisableWhiteBackgroundFromChild(RetryButton_Lost, LostTabPage);
            DisableWhiteBackgroundFromChild(DesignLabel_Credits, CreditsTabPage);
            DisableWhiteBackgroundFromChild(DesignDescription_Credits, CreditsTabPage);
            DisableWhiteBackgroundFromChild(MusicLabel_Credits, CreditsTabPage);
            DisableWhiteBackgroundFromChild(MusicDescription_Credits, CreditsTabPage);
            DisableWhiteBackgroundFromChild(FinalTextLabel_Credits, CreditsTabPage);

            // Move Labels
            AlignLabelToCenter(NameLabel_Game, PapyrusPictureBox_Game, PapyrusPictureBox_Game.Height / 3 + 10);
            AlignLabelToCenter(MessageLabel_Lost, LostTabPage, LostTabPage.Height-120);
            AlignLabelToCenter(RankLabel_Lost, LostTabPage, LostTabPage.Height-90);


            // Play Theme Song
            player = new System.Media.SoundPlayer("music/Theme.wav");
            player.PlayLooping();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button temp = sender as Button;
                string name = temp.Name;
                temp.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(name + "_Hover", Properties.Resources.Culture);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button temp = sender as Button;
                string name = temp.Name;
                temp.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(name + "_Plain", Properties.Resources.Culture);
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button temp = sender as Button;
                string name = temp.Name;
                temp.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(name + "_Pressed", Properties.Resources.Culture);
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button temp = sender as Button;
                string name = temp.Name;
                temp.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(name + "_Hover", Properties.Resources.Culture);
            }
        }

        private void ExitButton_MainMenu_Click(object sender, EventArgs e)
        {
            PlaySoundEffect("music/ButtonClick.wav");
            Application.Exit();
        }

        private void CreditsButton_MainMenu_Click(object sender, EventArgs e)
        {
            PlaySoundEffect("music/ButtonClick.wav");
            TabControl.SelectTab(1);
        }

        private void BackButton_Credits_Click(object sender, EventArgs e)
        {
            PlaySoundEffect("music/ButtonClick.wav");
            TabControl.SelectTab(0);
        }

        private void GameTabPage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string keyPressed = e.KeyCode.ToString().ToLower();
            string actualNameLetter = currentName[0].ToString().ToLower();

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            if (alphabet.Contains(keyPressed) || keyPressed.Equals("space"))
            {

                if (keyPressed.Equals("space"))
                {
                    if (actualNameLetter.Equals(" "))
                    {
                        RemoveLetterFromLabel();
                    }
                    else
                    {
                        Lost();
                    }
                }
                else if (keyPressed.Equals(actualNameLetter))
                {
                    RemoveLetterFromLabel();
                }
                else
                {
                    Lost();
                }
            }
        }

        private void StartGameButton_MainMenu_Click(object sender, EventArgs e)
        {
            PlaySoundEffect("music/ButtonClick.wav");
            Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            actualTimeLeft--;
            TimerLabel_Game.Text = actualTimeLeft.ToString();

            if (actualTimeLeft == 0)
            {
                Lost();
            }
        }

        private void RetryButton_Lost_Click(object sender, EventArgs e)
        {
            PlaySoundEffect("music/ButtonClick.wav");
            Start();
            player = new System.Media.SoundPlayer("music/Theme.wav");
            player.PlayLooping();
        }
    }
}
