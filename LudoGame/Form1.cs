using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoGame
{
    public partial class Form1 : Form
    {
        private const int BoardSize = 17;
        private int[,] gameBoards = new int[BoardSize, BoardSize]

        {
            {1,1,1,1,1,1,1,0,0,0,2,2,2,2,2,2,2},
            {1,0,0,0,0,0,1,0,2,0,2,0,0,0,0,0,2},
           {1,0,3,0,3,0,1,0,2,0,2,0,3,0,3,0,2},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
             {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
             {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
              {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
               {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                   {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                      {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                       {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };
         public Form1()
         {
            InitializeComponent();
            InitializeGameBoard();
            DrawGameBoard();
         }

        private void InitializeGameBoard()
        {
           
           


        }

        private void DrawGameBoard()
        {
            const int cellSize = 50; //px
            const int cornerSize = 6;

            for(int i = 0;i < BoardSize; i++)
            {
                for (int j = 0;j < BoardSize; j++)
                {
                    PictureBox pictureBox = new PictureBox()
                    {
                        Size = new System.Drawing.Size(cellSize, cellSize),
                        Location = new System.Drawing.Point(j * cellSize, i * cellSize),//calculeaza pozitia casutei in f de rand si coloana
                        BorderStyle = BorderStyle.FixedSingle // add contur 
                    };

                    /*if (gameBoards[i, j] == 1)
                    {
                        pictureBox.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox.BackColor= System.Drawing.Color.Black;
                    }*/

                    switch(gameBoards[i, j])
                    {
                        case 0: pictureBox.BackColor = System.Drawing.Color.White; break;
                        case 1: pictureBox.BackColor = System.Drawing.Color.Red; break;
                        case 2: pictureBox.BackColor= System.Drawing.Color.Green;break;
                        case 3: pictureBox.BackColor = System.Drawing.Color.LightGray; break;
                    }

                    Controls.Add(pictureBox);

                }
            }

        }  

        
    }

}
