using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* Created by Mr. T
 * to demonstrate how to use key presses to control the movement 
 * of an object on screen
 */

namespace heroMovements
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // launch directly into game screen when program starts
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
        }

    }

}
