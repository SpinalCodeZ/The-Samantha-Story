using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Samantha_Story
{
    public partial class theSamanthaStory : Form
    {

        //add datatable to allow for save? do research and figure out best solution to holding game saves.

        public theSamanthaStory()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            //link button to display outcome of text adventure
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            //link button to display outcome of text adventure
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            //link button to display outcome of text adventure
        }

        private void defendButton_Click(object sender, EventArgs e)
        {
            //link button to display outcome of text adventure
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //link button to save the game 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //was going to use as a save holder but might change, still need to research the best option
        }
    }
}


//Learn how to display text and make it reactive to the button clicks of the user. Text box is for UI design ideas and not for game text display.