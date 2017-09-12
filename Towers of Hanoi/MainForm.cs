/*
 * Class: MainForm
 * Created by: S.G.Dacey
 * Modified by:	Chong Wang
 * Date: 27/10/2016
 * Description: This class is used to control the game. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    public partial class MainForm : Form
    {
        private Disk dragDisk;  //the disk being dragged 
        private Board bd;
        private int targetPeg = 0;  //the peg that is the target of the drop
        private int movesCounter;

        /// <summary>
        /// Default constructor to initialize all components
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create Disk objects matching each Disk labels on the first peg
        /// Create a board object
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Disk d1 = new Disk(lblDisk1, ColorTranslator.ToWin32(lblDisk1.BackColor), 4, 1); //Disk1/Peg 1/Level4 
            Disk d2 = new Disk(lblDisk2, ColorTranslator.ToWin32(lblDisk2.BackColor), 3, 1); //Disk2/Peg 1/Level3 
            Disk d3 = new Disk(lblDisk3, ColorTranslator.ToWin32(lblDisk3.BackColor), 2, 1); //Disk3/Peg 1/Level2 
            Disk d4 = new Disk(lblDisk4, ColorTranslator.ToWin32(lblDisk4.BackColor), 1, 1); //Disk4/Peg 1/Level1 
            bd = new Board(d1, d2, d3, d4);
        }


        /// <summary>
        /// Move the dragged disk to the target peg
        /// Display the moves and details in the text box
        /// </summary>
        private void Disk_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Label alabel = (sender as Label);
            dragDisk = bd.FindDisk(alabel); //Use the dragged label to find the disk

            if (bd.canStartMove(dragDisk)) //check whether the disk can be moved
            {
                DragDropEffects result = alabel.DoDragDrop(dragDisk, DragDropEffects.All);

                if (result != DragDropEffects.None)
                {
                    dragDisk.setPegNum(targetPeg);  //Set the disk with target peg number
                    bd.move(dragDisk, bd.newLevInPeg(targetPeg));
                    bd.Display();
                    txtMoves.Text = bd.allMovesAsString();
                }
                else
                {
                    MessageBox.Show("Invalid drop - you cannot drop the disk here", "Error");
                }

            }
        }

        /// <summary>
        /// Change the cursor to show whether dropping is allowed
        /// </summary>
        private void Peg_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            //when a drop happens store the information about which pole was
            //dropped on in the global variable targetPole
            Label alabel = (sender as Label);
            if (alabel == lblPeg1) targetPeg = 1;
            else if (alabel == lblPeg2) targetPeg = 2;
            else if (alabel == lblPeg3) targetPeg = 3;

            if (bd.canDrop(dragDisk, targetPeg))  //check wheter the peg can be dropped
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
              
        }

        /// <summary>
        /// Some events
        /// </summary>
        private void Peg_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            
        }

        /// <summary>
        /// Exit from the program
        /// </summary>
        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Reset the game to the beginning
        /// replace the labels to the starting positions
        /// clear the textbox
        /// </summary>
        private void menuNew_Click(object sender, EventArgs e)
        {
            bd.reset();
            txtMoves.Clear();
            tmr.Enabled = false;
        }

        /// <summary>
        /// Open a text file to load stored games
        /// </summary>
        private void menuOpen_Click(object sender, EventArgs e)
        {
            bd.reset();
            txtMoves.Clear();
            openMovesDlg.FileName = "";

            if(openMovesDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openMovesDlg.FileName);
                string temp = sr.ReadLine(); //Read the file 1 line at a time
                while (temp != null)
                {
                    //use indexes to get disk number and peg number
                    int diskInd = Convert.ToInt32(temp[16].ToString());
                    int pegNum = Convert.ToInt32(temp[33].ToString());

                    //match the disk number with the label
                    Label aLabel;
                    if (diskInd == 1) aLabel = lblDisk1;
                    else if (diskInd == 2) aLabel = lblDisk2;
                    else if (diskInd == 3) aLabel = lblDisk3;
                    else aLabel = lblDisk4;

                    //move the disk to the target peg
                    dragDisk = bd.FindDisk(aLabel);
                    dragDisk.setPegNum(pegNum);
                    bd.move(dragDisk, bd.newLevInPeg(pegNum));
                    bd.Display();

                    txtMoves.Text += temp + "\r\n"; //store the file in text box
                    temp = sr.ReadLine();
                }
                sr.Close();
            }
        }

        /// <summary>
        /// save games as text files
        /// </summary>
        private void menuSave_Click(object sender, EventArgs e)
        {
            saveMovesDlg.FileName = openMovesDlg.FileName; //use the open file name as default save file name

            if (saveMovesDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveMovesDlg.FileName);
                sw.Write(txtMoves.Text); //Save the text from text box
                sw.Close();
            }
        }

        /// <summary>
        /// Use timer to control the moves of disks
        /// </summary>
        private void tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string aMove = txtMoves.Lines[movesCounter];
            //use indexes to get disk number and peg number
            int diskInd = Convert.ToInt32(aMove[16].ToString());
            int pegNum = Convert.ToInt32(aMove[33].ToString());

            //match the disk number with the label
            Label aLabel;
            if (diskInd == 1) aLabel = lblDisk1;
            else if (diskInd == 2) aLabel = lblDisk2;
            else if (diskInd == 3) aLabel = lblDisk3;
            else aLabel = lblDisk4;

            //move the disk to the target peg
            dragDisk = bd.FindDisk(aLabel);
            dragDisk.setPegNum(pegNum);
            bd.move(dragDisk, bd.newLevInPeg(pegNum));
            bd.Display();
            movesCounter++;

            //when the counter exceeds the actual movements length
            //stop the timer
            if (movesCounter > txtMoves.Lines.Length - 2) tmr.Enabled = false;
        }

        /// <summary>
        /// Turn the timer on to begin animation of the moves stored in the textbox.
        /// </summary>
        private void menuAnimate_Click(object sender, EventArgs e)
        {
            bd.reset(); 
            tmr.Enabled = true;
            movesCounter = 0;
        }
    }
}
