using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace heroMovements
{
    public partial class GameScreen : UserControl
    {
        //control variables for hero
        int heroX, heroY, heroSpeed, heroWidth, heroHeight;

        //indicates whether a key is being pressed or not 
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;

        //graphic objects
        SolidBrush drawBrush;

        public GameScreen()
        {
            InitializeComponent();
            gameStartValues();
        }

        /// <summary>
        /// This method is to be run each time a game starts or restars to set
        /// initial variable values
        /// </summary>
        public void gameStartValues()
        {
            heroX = 100;
            heroY = 200;
            heroSpeed = 2;
            heroWidth = 10;
            heroHeight = 20;

            leftArrowDown = downArrowDown = rightArrowDown = upArrowDown = false;

            drawBrush = new SolidBrush(Color.Black);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key has been released and set its KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                default:
                    break;
            }
        }

        // Game Engine Loop
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region move character based on key presses

            if (leftArrowDown == true)
            {
                heroX = heroX - heroSpeed;
            }

            if (downArrowDown == true)
            {
                heroY = heroY + heroSpeed;
            }

            if (rightArrowDown == true)
            {
                heroX = heroX + heroSpeed;
            }

            if (upArrowDown == true)
            {
                heroY = heroY - heroSpeed;
            }

            #endregion

            //refresh the screen, which causes the Form1_Paint method to run
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw rectangle to screen
            e.Graphics.FillRectangle(drawBrush, heroX, heroY, heroWidth, heroHeight);
        }

    }
}
