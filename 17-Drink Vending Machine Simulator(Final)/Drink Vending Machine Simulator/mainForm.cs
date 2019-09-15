using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Developler: Carlos David Chirino Varela   
//Program Name: Drink Vending Machine Simulator
//Date: 4/27/2018
//Purpose: The purpose of this program is to simulate a Drink Vending Machine.

namespace Drink_Vending_Machine_Simulator
{
    public partial class mainForm : Form
    {        // Create array of type Drinks
        Drinks [] arrayOfDrinks = new Drinks[5];
        //Variables
        decimal totalSales = 0;
        int remainingDrink;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Drinks cola = new Drinks("Cola", (decimal)1.00);
            Drinks lemonLime = new Drinks("Lemon Lime", (decimal)1.00);
            Drinks creamSoda = new Drinks("Cream Soda", (decimal)1.50);
            Drinks rootBeer = new Drinks("Root Beer", (decimal)1.00);
            Drinks grapeSoda = new Drinks("Grape Soda", (decimal)1.50);

            arrayOfDrinks[0] = cola;
            arrayOfDrinks[1] = lemonLime;
            arrayOfDrinks[2] = creamSoda;
            arrayOfDrinks[3] = rootBeer;
            arrayOfDrinks[4] = grapeSoda;
        }//end Load method
          //FindDrinks method
        public int FindDrinks(string name)
        {
            //Variables
            bool found = false;
            int index = 0;       
 
            while (!found && index < arrayOfDrinks.Length)
            {
                if (arrayOfDrinks[index].Name.Equals(name))
                {
                    if(arrayOfDrinks[index].NumberOfDrinks > 0)
                    {
                        arrayOfDrinks[index].NumberOfDrinks = arrayOfDrinks[index].NumberOfDrinks - 1;
                        remainingDrink = arrayOfDrinks[index].NumberOfDrinks;
                        totalSales += arrayOfDrinks[index].Cost;
                        totalSalesLabel.Text = totalSales.ToString("c");
                    }//end if
                    else
                    {
                        MessageBox.Show("The drink is currently sold out ", "Sold out", MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                    }//end else
                    found = true;                    
                }//end if
                else
                {
                    index++;
                }//end else
            }// end while
            return index;
        }//end FindDrinks method    

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            FindDrinks("Cola");
            colaQuantityLeftLabel.Text = remainingDrink.ToString();            
        }

        private void lemonLimePictureBox_Click(object sender, EventArgs e)
        {
            FindDrinks("Lemon Lime");
            lemonQuantityLeftLabel.Text = remainingDrink.ToString();
        }

        private void creamSodaPictureBox_Click(object sender, EventArgs e)
        {
            FindDrinks("Cream Soda");
            sodaQuantityLeftLabel.Text = remainingDrink.ToString();
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            FindDrinks("Root Beer");
            beerQuantityLeftLabel.Text = remainingDrink.ToString();
        }

        private void grapeSodaPictureBox_Click(object sender, EventArgs e)
        {
            FindDrinks("Grape Soda");
            grapeQuantityLeftLabel.Text = remainingDrink.ToString();
        }

        //Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close the simulator?", "Exit",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                == DialogResult.Yes)
            {
                this.Close();
            }//end if
        }//end Exit Button
        //Reset Button
        private void resetButton_Click(object sender, EventArgs e)
        {
            arrayOfDrinks = new Drinks[5];
            totalSales = 0;
            mainForm_Load(sender, e);
            totalSalesLabel.Text = "$0.00";
            colaQuantityLeftLabel.Text = "20";
            lemonQuantityLeftLabel.Text = "20";
            sodaQuantityLeftLabel.Text = "20";
            beerQuantityLeftLabel.Text = "20";
            grapeQuantityLeftLabel.Text = "20";
        }//end Reset Button
        
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrayOfDrinks = new Drinks[5];
            totalSales = 0;
            mainForm_Load(sender, e);
            totalSalesLabel.Text = "$0.00";
            colaQuantityLeftLabel.Text = "20";
            lemonQuantityLeftLabel.Text = "20";
            sodaQuantityLeftLabel.Text = "20";
            beerQuantityLeftLabel.Text = "20";
            grapeQuantityLeftLabel.Text = "20";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Developer: Carlos David Chirino Varela " + " \n " +
                            " Program Name: Drink Vending Machine Simulator " + " \n " +
                            " Date: 4/27/2018 ", "Info", MessageBoxButtons.OK, MessageBoxIcon
                            .Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the simulator?", "Exit",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                == DialogResult.Yes)
            {
                this.Close();
            }//end if
        }
    }//end Class
}//end namespace