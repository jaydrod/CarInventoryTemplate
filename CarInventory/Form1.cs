using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(yearInput.Text);
            string make  = makeInput.Text;
            string colour = colourInput.Text;
            int mileage = Convert.ToInt32(mileageInput.Text);
            
            Car a = new Car(year, make, colour, mileage);
            cars.Add(a);

            //for(int i = 0; i < cars.Count(); i++)
            //{
            //    outputLabel.Text += cars[i] + "\n";
            //    outputLabel.Text += cars[i] + "\n";
            //    outputLabel.Text += cars[i] + "\n";
            //    outputLabel.Text += cars[i] + "/n";
            //}

            // the foreach loop does the same thing as the loop above

            outputLabel.Text = "";

            foreach (Car c in cars )
            {
                outputLabel.Text += c.year + "\n";
                outputLabel.Text += c.make + "\n";
                outputLabel.Text += c.colour + "\n";
                outputLabel.Text += c.mileage + "\n";
            }
        }
        }
    }
