using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class Form1 : Form
    {
        
        public enum enSets
        {
            enAnimals,
            enCars,
            enNumbers
        };
        
        public enum enLevel 
        {
            enFourXThree,
            enFourXFour,
            enFourXFive,
            enFourXSix
        };
        
        public enum enDiffculty
        {
            enEasy,
            enMeduim,
            enHard
        };
        
        public enum enGameMode
        {
            enSolo,
            enWithFriend,
            enAgainstComputer
        };
        
        public enum enFlipSpeed
        {
            enSlow,
            enStandred,
            enFast
        };
        
        public struct stSetting
        {
            public enLevel CardsNumber;
            public enSets Set;
            public enDiffculty Diffculty;
            public enGameMode GameMode;
            public enFlipSpeed FlipSpeed;
            public bool HidPairs, HideMistake, HideMoves;
            public byte Minutes;
            public byte Seconds;
            public short Speed;
            public byte Rows;
            public byte Cols;
        }
       
       stSetting DefalutSetting;
        
        void EditPostions()
        {
            
           
            lblDiffculty.Location = lblGameMode.Location;
            lblGameMode.BringToFront();
            
            btnEasyDiffculty.Location =btnSoloMode.Location;
            btnMeduimDiffculty.Location = btnWithFriendMode.Location;
            btnHardDiffculty.Location = btnAgainstComputerMode.Location;
           
            btnSoloMode.BringToFront();
            btnWithFriendMode.BringToFront();
            btnAgainstComputerMode.BringToFront();

            lblHidePairs.Location = new Point(4, 61);
            btnOnHidePairs.Location = new Point(377, 61);
            btnOffHidePairs.Location = new Point(506, 61);

            lblHideMistake.Location    = new Point(lblHidePairs.Location.X,lblHidePairs.Location.Y+65) ;
            btnOnHideMistake.Location  = new Point(btnOnHidePairs.Location.X, btnOnHidePairs.Location.Y + 65);
            btnOffHideMistake.Location = new Point(btnOffHidePairs.Location.X, btnOffHidePairs.Location.Y + 65);

            lblHideMoves.Location    = new Point(lblHideMistake.Location.X, lblHideMistake.Location.Y+65) ;
            btnOnHideMoves.Location  = new Point(btnOnHideMistake.Location.X, btnOnHideMistake.Location.Y + 65);
            btnOffHideMoves.Location = new Point(btnOffHideMistake.Location.X, btnOffHideMistake.Location.Y + 65); ;

            lblFlipSpeed.Location         = new Point(lblHideMoves.Location.X, lblHideMoves.Location.Y+65);
            btnStandredFlipSpeed.Location = new Point(btnOnHideMoves.Location.X, btnOnHideMoves.Location.Y + 65 );
            btnFastFlipSpeed.Location     = new Point(btnOffHideMoves.Location.X, btnOffHideMoves.Location.Y + 65);
            btnSlowFliepSpeed.Location    = new Point(btnSoloMode.Location.X, btnStandredFlipSpeed.Location.Y );
           
           btnEasyDiffculty.Enabled   = false;
           btnMeduimDiffculty.Enabled = false;
           btnHardDiffculty.Enabled   = false;

            
        }
        
        void ReturnPostion()
        {
            lblDiffculty.Location = new Point(lblGameMode.Location.X, lblGameMode.Location.Y + 65);
            btnEasyDiffculty.Location = new Point(btnSoloMode.Location.X, btnSoloMode.Location.Y + 65);
            btnMeduimDiffculty.Location = new Point(btnWithFriendMode.Location.X, btnWithFriendMode.Location.Y + 65);
            btnHardDiffculty.Location = new Point(btnAgainstComputerMode.Location.X, btnAgainstComputerMode.Location.Y + 65);

            lblHidePairs.Location = new Point(4, 130);
            btnOnHidePairs.Location = new Point(377, 130);
            btnOffHidePairs.Location = new Point(506, 130);

            lblHideMistake.Location    = new Point(4, 179);
            btnOnHideMistake.Location  = new Point(377, 179);
            btnOffHideMistake.Location = new Point(506, 179);

            lblHideMoves.Location = new Point(4, 228);
            btnOnHideMoves.Location = new Point(377, 228);
            btnOffHideMoves.Location = new Point(506, 228);

            lblFlipSpeed.Location = new Point(4, 284);
            btnStandredFlipSpeed.Location = new Point(249, 284);
            btnFastFlipSpeed.Location = new Point(377, 284);
            btnSlowFliepSpeed.Location = new Point(506, 284);

            btnEasyDiffculty.Enabled    = true;
            btnMeduimDiffculty.Enabled  = true;
            btnHardDiffculty.Enabled    =true;
        }
        
        void DetermindRowsAndCols()
        {
            switch (DefalutSetting.CardsNumber)
            {
                case enLevel.enFourXThree:
                    DefalutSetting.Rows = 4;
                    DefalutSetting.Cols = 3;

                    break;

                case enLevel.enFourXFour:
                    DefalutSetting.Rows = 4;
                    DefalutSetting.Cols = 4;


                    break;

                case enLevel.enFourXFive:

                    DefalutSetting.Rows = 4;
                    DefalutSetting.Cols = 5;


                    break;
                    
                default:

                    DefalutSetting.Rows = 4;
                    DefalutSetting.Cols = 6;

                    break;
            }
        }
       
        void StartupSetting()
        {
            btnOffHidePairs.BackColor = Color.Gray;
            DefalutSetting.HidPairs = false;
            
            btnOffHideMistake.BackColor = Color.Gray;
            DefalutSetting.HideMistake = false;

            btnOffHideMoves.BackColor = Color.Gray;
            DefalutSetting.HideMoves = false;

            btnSoloMode.BackColor = Color.FromArgb(255, 128, 0);
            DefalutSetting.GameMode = enGameMode.enSolo;
            
            btnStandredFlipSpeed.BackColor = Color.Blue;
            DefalutSetting.FlipSpeed = enFlipSpeed.enStandred;
            DefalutSetting.Speed = 300;


            cmbMinutes.SelectedIndex = 0;
            DefalutSetting.Minutes = 0;

            cmbSecnods.SelectedIndex = 0;
            DefalutSetting.Seconds = 0;

            cmbSets.SelectedIndex = 0;
            DefalutSetting.Set = enSets.enAnimals;
            
            cmbSquareNumber.SelectedIndex = 1;
            DefalutSetting.CardsNumber = enLevel.enFourXFour;

            EditPostions();
            DetermindRowsAndCols();


        }
        
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void HidePairs_Click(object sender, EventArgs e)
        {
            if (sender as Button == btnOnHidePairs)
            {
                btnOnHidePairs.BackColor = Color.FromArgb(0, 192, 0);
                btnOffHidePairs.BackColor = Color.White;
                DefalutSetting.HidPairs = true;
            }
            else
            {
                btnOnHidePairs.BackColor = Color.White;
                btnOffHidePairs.BackColor = Color.Gray;
                DefalutSetting.HidPairs = false;
            }
        }

        private void HideMistake_Click(object sender, EventArgs e)
        {
            if (sender as Button == btnOnHideMistake)
            {
                btnOnHideMistake.BackColor = Color.FromArgb(0, 192, 0);
                btnOffHideMistake.BackColor = Color.White;
                DefalutSetting.HideMistake = true;
            }
            else
            {
                btnOnHideMistake.BackColor = Color.White;
                btnOffHideMistake.BackColor = Color.Gray;
                DefalutSetting.HideMistake = false;

            }
        }

        private void HideMove_Click(object sender, EventArgs e)
        {
            if (sender as Button == btnOnHideMoves)
            {
                btnOnHideMoves.BackColor = Color.FromArgb(0, 192, 0);
                btnOffHideMoves.BackColor = Color.White;
                DefalutSetting.HideMoves = true;

            }
            else
            {
                btnOnHideMoves.BackColor = Color.White;
                btnOffHideMoves.BackColor = Color.Gray;
                DefalutSetting.HideMoves = false;

            }
        }

        private void GameMode_Click(object sender, EventArgs e)
        {

            if (sender as Button == btnSoloMode)
            {
                btnSoloMode.BackColor = Color.FromArgb(255, 128, 0);
                btnWithFriendMode.BackColor = Color.White;
                btnAgainstComputerMode.BackColor = Color.White;
                DefalutSetting.GameMode=enGameMode.enSolo;

                EditPostions();
            }
            else if (sender as Button == btnWithFriendMode)
            {
                btnSoloMode.BackColor = Color.White;
                btnWithFriendMode.BackColor = Color.FromArgb(255, 128, 0);
                btnAgainstComputerMode.BackColor = Color.White;
                DefalutSetting.GameMode = enGameMode.enWithFriend;
                EditPostions();
            }
            else
            {
                btnSoloMode.BackColor = Color.White;
                btnWithFriendMode.BackColor = Color.White;
                btnAgainstComputerMode.BackColor = Color.FromArgb(255, 128, 0);
                DefalutSetting.GameMode = enGameMode.enAgainstComputer;
                ReturnPostion();




               


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StartupSetting();

        }

        private void cmbMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefalutSetting.Minutes = Convert.ToByte(cmbMinutes.Items[cmbMinutes.SelectedIndex]);
        }

        private void cmbSecnods_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefalutSetting.Seconds = Convert.ToByte(cmbSecnods.Items[cmbMinutes.SelectedIndex]);
        }

        private void cmbSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefalutSetting.Set = (enSets)cmbSets.SelectedIndex;
        }

        private void btnFlipSpeed_Click(object sender, EventArgs e)
        {
            if (sender as Button == btnSlowFliepSpeed)
            {
                btnSlowFliepSpeed.BackColor = Color.Yellow;
                btnStandredFlipSpeed.BackColor = Color.White;
                btnFastFlipSpeed.BackColor = Color.White;
                DefalutSetting.FlipSpeed = enFlipSpeed.enSlow;
                DefalutSetting.Speed = 800;
            }
            else if (sender as Button == btnStandredFlipSpeed)
            {
                btnSlowFliepSpeed.BackColor = Color.White;
                btnStandredFlipSpeed.BackColor = Color.Blue;
                btnFastFlipSpeed.BackColor = Color.White;
                DefalutSetting.FlipSpeed = enFlipSpeed.enStandred;
                DefalutSetting.Speed = 400;

            }
            else
            {
                btnSlowFliepSpeed.BackColor = Color.White;
                btnStandredFlipSpeed.BackColor = Color.White;
                btnFastFlipSpeed.BackColor = Color.FromArgb(192, 64, 0);
                DefalutSetting.FlipSpeed = enFlipSpeed.enFast;
                DefalutSetting.Speed = 200;

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbMinutes.SelectedIndex == 0)
            {
                MessageBox.Show("Please Determined your timer", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            frmApp frmGame= new frmApp();
            frmGame.SetValues(DefalutSetting);
            frmGame.ShowDialog();
            Application.Exit();
        }

        private void cmbSquareNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefalutSetting.CardsNumber = (enLevel)cmbSquareNumber.SelectedIndex;
            DetermindRowsAndCols();
        }
    }

    
}

