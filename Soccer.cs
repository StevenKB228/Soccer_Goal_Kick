using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soccer_Penalty_Kick_Game
{
    public partial class Form1 : Form
    {

    Random rnd = new Random();
    // create a random number generator
    //list of goal keepers position as strings

    List<string> KeeperPosition = new List<string> {"Right","left","topsave","bottomsave"};

    int ballX = 0; // balls horizontal position
    int ballY = 0; //balls vertical position

    string state; //this string will save the players current target
    string playerTarget; // this string will save the players current target
    bool aimSet = false; // this is the aim set boolean

    int goal; // this will save the amount of goals we scored
    int miss;// this will save the amount of goals we missed

    public Form1()
    {
        InitializeComponent();
    }
   private void shootball(object sender,EventArgs e)
    {
      // in this event we will check which aim was clicked and where the ball has landed

      football.Left -= ballX; // linking the football left to ballX integer
      football.Top -= ballY; // linking the football top to ballY integer

      // below is the big if statement, this is checking all the 5 conditions
      // if the ball is selected to hit a target and it reaches that target
      // then we can reset the ball back to the starting position  
    }
    }
    
}