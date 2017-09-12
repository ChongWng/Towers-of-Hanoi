/*
 * Class: DiskMove
 * Created by: S.G.Dacey
 * Modified by:	Chong Wang
 * Date: 27/10/2016
 * Description: The class is used for saving moves.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Towers_of_Hanoi
{
    class DiskMove
    {
        private int diskInd;
        private int pegInd;

        /// <summary>
        /// Default constructor
        /// </summary>
        public DiskMove()
        {
            diskInd = 0;
            pegInd = 0;
        }

        /// <summary>
        /// Alternative constuctor
        /// @param index number of disk and peg 
        /// </summary>
        /// <param name="dI"></param>
        /// <param name="pI"></param>
        public DiskMove(int dI, int pI)
        {
            diskInd = dI;
            pegInd = pI;
        }

        /// <summary>
        /// Alternative constructor
        /// @parm string type of data about disk movement 
        /// </summary>
        /// <param name="move"></param>
        public DiskMove(string move)
        {
            string[] mv = move.Split(',');
            diskInd = Convert.ToInt32(mv[0]);
            pegInd = Convert.ToInt32(mv[1]);
        }

        /// <summary>
        /// This method converts data of disk index and peg index
        /// in DiskMove object into text style.
        /// </summary>
        /// <returns></returns>
        public string AsText()
        {
            string d = (diskInd + 1).ToString();
            string p = (pegInd + 1).ToString();
            string text = "Disk (" + d + ") moved to Peg (" + p + ")";
            return text;
        }

        /// <summary>
        /// Get disk index from DiskMove object.
        /// </summary>
        /// <returns></returns>
        public int getDiskInd()
        {
            return diskInd;
        }

        /// <summary>
        /// Get peg index number from DiskMove object.
        /// </summary>
        /// <returns></returns>
        public int getPegInd()
        {
            return pegInd;
        }

        /// <summary>
        /// Convert DiskMove data into Dthe format of "disk index , Peg index"        
        /// </summary>
        /// <returns></returns>
        public string commaText()
        {
            string d = (diskInd).ToString();
            string p = (pegInd).ToString();
            string text = d.ToString() + "," + p.ToString();
            return text;
        }
    }
}
