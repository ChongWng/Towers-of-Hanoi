/*
 * Class: Disk
 * Created by: S.G.Dacey
 * Modified by:	Chong Wang
 * Date: 27/10/2016
 * Description: The class is used to store data about the disks.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    class Disk
    {
        private int diameter;
        private int color;
        private int level; // Position in each peg
        private int pNum; // Number of peg 
        private Label label;

        /// <summary>
        /// default constructor
        /// </summary>
        public Disk()
        {
            diameter = 0;
            color = 0;
            level = 0;
            pNum = 0;
            label = null;
        }

        /// <summary>
        /// Alternative constructor
        /// public Disk(int diam, int col, int lv, int peg)
        /// </summary>
        /// <param name="aLabel"></param>
        /// <param name="col"></param>
        /// <param name="lv"></param>
        /// <param name="peg"></param>
        public Disk(Label aLabel, int col, int lv, int peg)
        {
            diameter = aLabel.Width;
            color = col;
            level = lv;
            pNum = peg;
            label = aLabel;
        }

        /// <summary>
        /// This method set new level in Disk object.
        /// </summary>
        /// <param name="lvl"></param>
        public void setLevel(int lvl)
        {
            level = lvl;
        }

        /// <summary>
        /// This mehod get level stored in disk object.
        /// </summary>
        /// <returns></returns>
        public int getLevel()
        {
            return level;
        }

        /// <summary>
        /// This method set color of Disk object.
        /// </summary>
        /// <param name="col"></param>
        public void setColor(int col)
        {
            color = col;
        }

        /// <summary>
        /// This method get color stored in Disk object. 
        /// </summary>
        /// <returns></returns>
        public int getColor()
        {
            return color;
        }

        /// <summary>
        /// This method set diameter in Disk object.
        /// @param Label is passed.
        /// </summary>
        /// <param name="aLabel"></param>
        public void setDiameter(Label aLabel)
        {
            diameter = aLabel.Width;
        }

        /// <summary>
        /// This method get diameter of Disk object.
        /// @return width of associated label.  
        /// </summary>
        /// <returns></returns>
        public int getDiameter()
        {
            return diameter;
        }

        /// <summary>
        /// This method stores peg index in Disk object.
        /// @param disk index is passed. 
        /// </summary>
        /// <param name="pn"></param>
        public void setPegNum(int pn)
        {
            pNum = pn;
        }

        /// <summary>
        /// This method get the index of the peg stored in Disk object.
        /// @return index of peg. 
        /// </summary>
        /// <returns></returns>
        public int getPegNum()
        {
            return pNum;
        }

        /// <summary>
        /// This method get label stored in Disk object.    
        /// </summary>
        /// <returns></returns>
        public Label getLabel()
        {
            return label;
        }

        /// <summary>
        /// This object set label in disk object.
        /// @param label
        /// </summary>
        /// <param name="aLabel"></param>
        public void setLabel(Label aLabel)
        {
            label = aLabel;
        }
    }
}
