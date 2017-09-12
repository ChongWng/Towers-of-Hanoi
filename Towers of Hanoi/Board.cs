/*
 * Class: Board
 * Created by: S.G.Dacey
 * Modified by:	Chong Wang
 * Date: 27/10/2016
 * Description: The class is used to control what happens to the disks.
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    class Board
    {
        Disk[,] board; //condition says TWO dimentional array            
        ArrayList movements;
        Disk[] disks; //Array of disks

        private const int NUM_DISKS = 4;
        private const int NUM_PEGS = 3;

        //constants needed to handle the display of disks
        private const int pegStart = 121;
        private const int pegGap = 180;
        private const int deckHeight = 315;
        private const int diskHeight = 24;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Board()
        {
            //Array of disk objects
            disks = new Disk[NUM_DISKS];
            disks[0] = null;
            disks[1] = null;
            disks[2] = null;
            disks[3] = null;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  

            board[0, 3] = new Disk();
            board[0, 2] = new Disk();
            board[0, 1] = new Disk();
            board[0, 0] = new Disk();

            //Creating arraylist of movement 
            movements = new ArrayList();
        }

        /// <summary>
        /// Alterntative constructor
        /// </summary>
        public Board(Disk d1, Disk d2, Disk d3, Disk d4)
        {
            //Storing into disks array
            disks = new Disk[NUM_DISKS];
            disks[0] = d1;
            disks[1] = d2;
            disks[2] = d3;
            disks[3] = d4;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  
            board[0, 3] = d1;
            board[0, 2] = d2;
            board[0, 1] = d3;
            board[0, 0] = d4;

            //Arraylist of movement.
            movements = new ArrayList();
        }

        /// <summary>
        /// Reset the game to the beginning.
        /// </summary>
        public void reset()
        {
            for (int iP = 0; iP < NUM_PEGS; iP++)
            {
                //Remove all elements from board array
                for (int iD = 0; iD < NUM_DISKS; iD++)
                {
                    board[iP, iD] = null;

                    //Update disks array
                    disks[iD].setPegNum(1);
                    disks[iD].setLevel(NUM_DISKS - iD);
                }
            }

            //Reallocate elements 
            board[0, 3] = disks[0]; //Peg 1/Level4 
            board[0, 2] = disks[1]; //Peg 1/Level3 
            board[0, 1] = disks[2]; //Peg 1/Level2
            board[0, 0] = disks[3]; //Peg 1/Level1 

            //Remove all elements from movement arraylist
            movements.Clear();

            //Replace the 4 disks
            disks[0].getLabel().Left = 98;
            disks[0].getLabel().Top = 219;

            disks[1].getLabel().Left = 82;
            disks[1].getLabel().Top = 243;

            disks[2].getLabel().Left = 66;
            disks[2].getLabel().Top = 267;

            disks[3].getLabel().Left = 49;
            disks[3].getLabel().Top = 291;
        }

        /// <summary>
        /// Check if it is valid to begin a move with a particular Disk.
        /// @param the disk to be moved
        /// </summary>
        /// <param name="aDisk"></param>
        public bool canStartMove(Disk aDisk)
        {
            //can only move the top disk
            if (aDisk.getLevel() == 4) 
            {
                return true;
            }
            else if (board[aDisk.getPegNum()-1, aDisk.getLevel()] == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Move - you can only move top disk", "Error");
                return false;
            }

        }

        /// <summary>
        /// Check if it is valid to drop a particular disk on a Peg.
        /// @param the disk to be moved
        /// @param the peg to be droped
        /// </summary>
        public bool canDrop(Disk aDisk, int aPeg)
        {
            int newLevel = newLevInPeg(aPeg);
            if (board[aPeg-1, 3] != null) //cannot drop on a full peg
            {
                return false;
            }

            else if (newLevel > 1)
            {
                if (aDisk.getDiameter() > board[aPeg-1, newLevel-2].getDiameter()) //cannot drop a larger disk on a smmaler one
                {
                    return false;
                }
                else
                    return true;
            }

            else
            {
                return true;
            }
            
        }

        /// <summary>
        /// Move a disk to a new Peg.
        /// @param the disk to be moved
        /// @param the level to be droped
        /// </summary>
        public void move(Disk aDisk, int newLevel)
        {
            //match board[ipeg, jlevel] with the dragged disk to get old peg number and old level number
            int oldPeg = -1;
            int oldLevel = -1;

            for (int ipeg = 0; ipeg < 3; ipeg++)
            {
                for (int jlevel = 0; jlevel < 4; jlevel++)
                {
                    if (board[ipeg, jlevel] != null)
                    {
                        if (board[ipeg, jlevel] == aDisk)
                        {
                            oldPeg = ipeg + 1;
                            oldLevel = jlevel + 1;
                            break;
                        }
                    }
                }
                if (oldPeg > -1) break;
            }

            int newPeg = aDisk.getPegNum();
            aDisk.setLevel(newLevel);
            board[newPeg-1, newLevel-1] = aDisk;
            board[oldPeg-1, oldLevel-1] = null;


            //Save a DiskMove object representing the latest move to the ArrayList of moves. 
            int diskNum = 0;
            for (int i = 0; i < NUM_DISKS; i++)
            {
                if (aDisk.getLabel().Name == "lblDisk" + (i + 1).ToString())
                    diskNum = i;
            }
            DiskMove aMove = new DiskMove(diskNum, newPeg-1);
            movements.Add(aMove);
        }

        /// <summary>
        /// Return a string giving the moves so far, one move per line.
        /// </summary>
        public string allMovesAsString()
        {
            String moves = "";
            int counter = 1;
            foreach (DiskMove aDM in movements)
            {
                //store move steps and movement details in the string
                moves += "Step " + counter.ToString("000") + ": " + aDM.AsText() + "\r\n";
                counter++;
            }

            //when all of the disks are transferred to the third peg
            //show the messages
            //put here to avoid these messages appear again when animating
            if (board[2, 3] != null)
            {
                if (movements.Count == 15) MessageBox.Show("You have successfully completed the game with the minimum number of moves", "Success");
                else MessageBox.Show("You have successfully completed the game but not with the minimum number of moves", "Success");
            }

            return moves; 
        }

        /// <summary>
        /// Display the current position of the disks.
        /// </summary>
        public void Display()
        {
            //Turn the DiskMove arraylist into an array
            //Get the last element in the array
            //Use methods in DiskMove class to get new peg and compute new level
            DiskMove[] DMs = (DiskMove[])movements.ToArray(typeof(DiskMove));
            DiskMove aDM = DMs[movements.Count - 1];
            Label aLabel = disks[aDM.getDiskInd()].getLabel();
            int newPeg = aDM.getPegInd() + 1;
            int newLevel = newLevInPeg(newPeg) - 1;

            //Use constant variables to display the label in the correct position
            aLabel.Hide();
            aLabel.Left = pegStart + ((newPeg - 1) * pegGap) - (aLabel.Width / 2);
            aLabel.Top = deckHeight - (newLevel * diskHeight);
            aLabel.Show();
        }

        /// <summary>
        /// Get a reference to the disk that matches a label. 
        /// @param label
        /// </summary>
        /// <param name="aLabel"></param>
        public Disk FindDisk(Label aLabel)
        {
            Disk aDisk = null;
            for (int i = 0; i < NUM_DISKS; i++)
            {
                if (aLabel.Name == "lblDisk" + (i + 1).ToString())
                    aDisk = disks[i];  //Match a disk with the label name
            }

            return aDisk;  
        }

        /// <summary>
        /// Find the new level using a target peg 
        /// @param peg number
        /// </summary>
        /// <param name="pegNum"></param>
        public int newLevInPeg(int pegNum)
        {
            int newLevel = 5; //if board[2,3] is not null, new level should be level 4+1
            for (int i = 0; i < NUM_DISKS; i++)
            {
                //if the board from bottom is null, then get the new level in this peg
                if (board[pegNum-1, i] == null) 
                {
                    newLevel = i + 1;
                    break;
                }
            }
            return newLevel;    
        }

 
        public String getText(int cnt)
        {
           
            return "1";    // Dummy return to avoid syntax error - must be changed
        }


        public void backToSelected(int ind)
        {

        }


        public int getPegInd(int ind)
        {
             return 1;    // Dummy return to avoid syntax error - must be changed
        }


        public int getLevel(int ind)
        {
            return 1;    // Dummy return to avoid syntax error - must be changed
        }


        public void unDo()
        {

        }


        public void loadData(ArrayList dm)
        {

        }
   }
}
