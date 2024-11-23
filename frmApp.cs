using Memory_Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class frmApp : Form
    {
        Form1.stSetting Setting;
        Random random = new Random();

        List<Button> ButtonList = new List<Button>();
        List<byte> RandomTag = new List<byte>();

        Button Choice1 = new Button();
        Button Choice2 = new Button();

        short XLocation = 17,
              YLocation = 17;

        byte Check = 0,
             EndGame = 0,
             ButtonNumber = 1,
             NumberOfButtons = 0,//Number of buttons in Game
             Player1Count = 0,
             Player2Count = 0,
             Minutes = 0, Seconds = 0;

        PrivateFontCollection privateFontCollection = new PrivateFontCollection();


        public void SetValues(Form1.stSetting StartSetting)
        {

            Setting = StartSetting;
            Minutes = StartSetting.Minutes;
            Seconds = StartSetting.Seconds;
        }

        private void InstallCustomFont()
        {
            //After add font file in solution explore 

            // Specify the path to the font file
            string fontFilePath = "C:\\Users\\Hp\\source\\repos\\Memory Game\\lcdmono2-normal.ttf";

            // Create a new PrivateFontCollection

            //PrivateFontCollection privateFontCollection = new PrivateFontCollection();


            // Add the font file to the collection
            privateFontCollection.AddFontFile(fontFilePath);

            // Use the font from the collection
            lblTimer.Font = new Font(privateFontCollection.Families[0], 25);
            // ... Use the customFont in your application ...


        }

        private void AddButtonToList()
        {

            RandomTag.Add(1);
            RandomTag.Add(2);
            RandomTag.Add(3);
            RandomTag.Add(4);
            RandomTag.Add(5);
            RandomTag.Add(6);
            RandomTag.Add(7);
            RandomTag.Add(8);
            RandomTag.Add(9);
            RandomTag.Add(10);
            RandomTag.Add(11);
            RandomTag.Add(12);

        }

        private void SelecteSet(ref string Tag)
        {
            switch (Setting.Set)
            {
                case Form1.enSets.enAnimals:
                    Tag = "A";

                    break;

                case Form1.enSets.enCars:

                    Tag = "C";

                    break;

                default:

                    Tag = "N";


                    break;
            }
        }

        private void FillImageTag()
        {
            string Tag = "";

            SelecteSet(ref Tag);
            AddButtonToList();
            byte RandomNumber = 0;
            RandomNumber = Convert.ToByte(random.Next(0, RandomTag.Count));
            Tag += RandomTag[RandomNumber];

            for (byte i = 0; i < NumberOfButtons; i++)
            {
                ButtonList[i].Tag = Tag;
                if (i > 1 && i % 2 == 0)
                {
                    RandomTag.RemoveAt(RandomNumber);

                    RandomNumber = Convert.ToByte(random.Next(0, RandomTag.Count));


                    Tag = Tag[0] + RandomTag[RandomNumber].ToString();


                    ButtonList[i].Tag = Tag;
                }
            }

        }

        private void Swap(List<Button> list, byte index1, byte index2)
        {

            string temp = list[index1].Tag.ToString();
            list[index1].Tag = list[index2].Tag.ToString();
            list[index2].Tag = temp;

        }

        private void Shuffle()
        {
            for (byte i = 0; i < 24; i++)
                Swap(ButtonList, Convert.ToByte(random.Next(0, NumberOfButtons)), Convert.ToByte(random.Next(0, NumberOfButtons)));

        }

        private void CheckMatching(Button btn1, Button btn2)
        {

            if (btn1.Tag != btn2.Tag)
            {
                if (txtPlayer1.Enabled)
                {
                    txtPlayer1.Enabled = false;
                    txtPlayer2.Enabled = true;
                }
                else
                {
                    txtPlayer2.Enabled = false;
                    txtPlayer1.Enabled = true;
                }


                btn1.BackgroundImage = Resources.Question_mark;
                btn2.BackgroundImage = Resources.Question_mark;
                Check = 0;

                SoundPlayer ErrorSound = new SoundPlayer(@"C:\Users\Hp\Downloads\Erorr.wav");
                ErrorSound.Play();


            }
            else
            {
                EndGame++;

                btn1.Enabled = false;
                btn2.Enabled = false;

                if (txtPlayer1.Enabled)
                {
                    Player1Count++;
                }
                else { Player2Count++; }

                if (Setting.HidPairs)
                {
                    btn1.BackgroundImage = null;
                    btn2.BackgroundImage = null;
                }
                txtPlayer1.Text = "Player1\r\nPairs : " + Player1Count;
                txtPlayer2.Text = "Player1\r\nPairs : " + Player2Count;



                SoundPlayer TrueSound = new SoundPlayer(@"C:\Users\Hp\Downloads\Right choice.wav");
                TrueSound.Play();
            }
        }

        private void RestartGame()
        {
            timer1.Enabled = false;
            foreach (Button item in ButtonList)
            {
                item.BackgroundImage = Resources.Question_mark;

            }


            EndGame = 0;
            Setting.Minutes = Minutes;
            Setting.Seconds = Seconds;
            lblTimer.Text = Setting.Minutes.ToString().PadLeft(2, '0') + ":" + Setting.Seconds.ToString().PadLeft(2, '0');

            Shuffle();


            if (Setting.GameMode == Form1.enGameMode.enWithFriend)
            {
                Player1Count = 0;
                Player2Count = 0;
                txtPlayer1.Text = "Player1\r\nPairs : " + Player1Count;
                txtPlayer2.Text = "Player1\r\nPairs : " + Player2Count;
            }

        }

        private void DrawCols()
        {
            short initialYLocation = YLocation;  // Store the initial YLocation for each row

            for (short i = 0; i < Setting.Rows; i++)
            {
                CreateButtons();
                YLocation += 73;
            }

            YLocation = initialYLocation;
        }

        private void DrawRowAndCols()
        {
            short initialXLocation = XLocation;  // Store the initial XLocation for each column

            for (short i = 0; i < Setting.Cols; i++)
            {
                DrawCols();
                XLocation += 87;
            }
            XLocation = initialXLocation;
        }

        private void DrawGame()
        {

            DrawRowAndCols();

        }

        public frmApp()
        {
            InitializeComponent();

        }

        private void CreateButtons()
        {

            Button btn = new Button();

            btn.BackgroundImage = Resources.Question_mark;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Location = new System.Drawing.Point(XLocation, YLocation);
            btn.Margin = new System.Windows.Forms.Padding(15);
            btn.Name = "btn" + ButtonNumber;
            btn.Size = new System.Drawing.Size(50, 50);
            btn.TabIndex = 0;
            btn.TabStop = false;
            btn.Tag = "";
            btn.Text = "";
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(this.btns_Click);
            ButtonList.Add(btn);
            panel1.Controls.Add(btn);


            ButtonNumber++;
            NumberOfButtons++;






        }

        private void frmApp_Load(object sender, EventArgs e)
        {
            if (Setting.GameMode == Form1.enGameMode.enSolo)
            {
                panel2.Controls.Add(txtPlayer2);
                panel2.Controls.Add(txtPlayer1);
            }

            txtPlayer1.Text = "Player1\r\nPairs : " + Player1Count;
            txtPlayer2.Text = "Player1\r\nPairs : " + Player2Count;
            txtPlayer2.Enabled = false;
            InstallCustomFont();
            DrawGame();
            FillImageTag();



            Shuffle();
            lblTimer.Text = Setting.Minutes.ToString().PadLeft(2, '0') + ":" + Setting.Seconds.ToString().PadLeft(2, '0');

            if (Setting.HideMistake)
            {
                txtMistake.Visible = false;
            }

            if (Setting.HideMoves)
            {
                txtMoves.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            lblTimer.Text = Setting.Minutes.ToString().PadLeft(2, '0') + ":" + Setting.Seconds.ToString().PadLeft(2, '0');

            if (EndGame == (NumberOfButtons / 2))
            {

                timer1.Stop();
                MessageBox.Show("Great job");
                RestartGame();
            }

            if (Setting.Minutes > 0)
            {


                Setting.Minutes--;
                Setting.Seconds = 60;


            }

            else
            {
                if (Setting.Seconds != 0)
                {
                    Setting.Seconds--;
                }
                else if (Setting.Seconds == 0 && EndGame != 10)
                {


                    timer1.Stop();
                    MessageBox.Show("Sorry your time is out");
                    RestartGame();
                }



            }
        }

        private void ChangeToAnimalImage(Button btn)
        {
            switch (btn.Tag)
            {
                case "A1":

                    btn.BackgroundImage = Resources.Animal_1;
                    break;

                case "A2":
                    btn.BackgroundImage = Resources.Animal_2;
                    break;

                case "A3":
                    btn.BackgroundImage = Resources.Animal_3;
                    break;

                case "A4":
                    btn.BackgroundImage = Resources.Animal_4;
                    break;

                case "A5":
                    btn.BackgroundImage = Resources.Animal_5;
                    break;

                case "A6":
                    btn.BackgroundImage = Resources.Animal_6;
                    break;

                case "A7":
                    btn.BackgroundImage = Resources.Animal_7;
                    break;

                case "A8":
                    btn.BackgroundImage = Resources.Animal_8;
                    break;

                case "A9":
                    btn.BackgroundImage = Resources.Animal_9;
                    break;
                case "A10":
                    btn.BackgroundImage = Resources.Animal_10;
                    break;
                case "A11":
                    btn.BackgroundImage = Resources.Animal_11;
                    break;
                default:
                    btn.BackgroundImage = Resources.Animal_12;
                    break;
            }

        }

        private void ChangeToCarsImage(Button btn)
        {
            switch (btn.Tag)
            {
                case "C1":

                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car1;
                    break;

                case "C2":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car2;
                    break;

                case "C3":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car3;
                    break;

                case "C4":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car4;
                    break;

                case "C5":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car5;
                    break;

                case "C6":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car6;
                    break;

                case "C7":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car7;
                    break;

                case "C8":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car8;
                    break;

                case "C9":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car9;
                    break;

                case "C10":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car10;
                    break;
                case "C11":
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car11;
                    break;
                default:
                    btn.BackgroundImage = Memory_Game.Properties.Resources.Car12; ;
                    break;
            }

        }

        private void ChangeToNumberImage(Button btn)
        {
            switch (btn.Tag)
            {
                case "N1":

                    btn.BackgroundImage = Resources.Number1;
                    break;

                case "N2":
                    btn.BackgroundImage = Resources.Number2;
                    break;

                case "N3":
                    btn.BackgroundImage = Resources.Number3;
                    break;

                case "N4":
                    btn.BackgroundImage = Resources.Number4;
                    break;

                case "N5":
                    btn.BackgroundImage = Resources.Number5;
                    break;

                case "N6":
                    btn.BackgroundImage = Resources.Number6;
                    break;

                case "N7":
                    btn.BackgroundImage = Resources.Number7;
                    break;

                case "N8":
                    btn.BackgroundImage = Resources.Number8;
                    break;

                case "N9":
                    btn.BackgroundImage = Resources.Number9;
                    break;

                case "N10":
                    btn.BackgroundImage = Resources.Number10;
                    break;
                case "N11":
                    btn.BackgroundImage = Resources.Number11;
                    break;

                default:
                    btn.BackgroundImage = Resources.Number12;
                    break;
            }

        }

        private void ChangeImage(Button btn)
        {
            switch (Setting.Set)
            {
                case Form1.enSets.enAnimals:
                    ChangeToAnimalImage(btn);


                    break;

                case Form1.enSets.enCars:
                    ChangeToCarsImage(btn);


                    break;

                default:
                    ChangeToNumberImage(btn);


                    break;
            }

        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (btnSound.Tag.ToString() == "ON")
            {
                btnSound.Image = Resources.mute__1_;
                btnSound.Tag = "OFF";
            }
            else
            {
                (btnSound).Image = Resources.volume_up__1_;
                (btnSound).Tag = "ON";
            }
        }

        private async void btns_Click(object sender, EventArgs e)
        {
            SoundPlayer FlipSound = new SoundPlayer(@"C:\Users\Hp\Downloads\flipcard.wav");
            if (sender as Button == Choice1)
            {


                return;
            }


            if (btnSound.Tag.ToString() == "ON")
            {
                FlipSound.Play();
            }

            ChangeImage(sender as Button);
            Check++;
            if (Check == 1)
            {

                Choice1 = sender as Button;

            }
            else
            {

                Choice2 = sender as Button;

                await Task.Delay(Setting.Speed);
                CheckMatching(Choice1, Choice2);
                Check = 0;
                Choice1 = null;
                Choice2 = null;

            }




        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            timer1.Enabled = true;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

    }
}

