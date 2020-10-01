using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_Assignment
{
    /* Rory Stouder
     * Assignment SQLite 
     * 11/16/17
     * work with an SQLite database. 
     */

    public partial class Form1 : Form
    {
        DBCities dbUtils = new DBCities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!dbUtils.TestDatabaseConnection())
            {
                lblStatus.Text = dbUtils.LastStatus;
            }
            else
            {
                DisplayTable();
            }
        }

        private void DisplayTable()
        {
            dgvCity.DataSource = dbUtils.GetAllCities();
            dgvCity.ClearSelection();
            ClearTextBoxes();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //HOUSEKEEPING
            ClearTextBoxes();

            DisplayTable();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "";

                String enteredCity = "";
                int enteredId = 0;
                double enteredPopulation = 0;
               

                if (radAdd.Checked)
                {
                    enteredPopulation = double.Parse(txtPopulation.Text);
                    AddCity(txtCity.Text, enteredPopulation);
                }
                else if (radDelete.Checked)
                {
                    DeleteCity(txtCity.Text);
                }
                else if (radEdit.Checked)
                {
                    enteredPopulation = double.Parse(txtPopulation.Text);
                    EditCity(txtCity.Text, enteredPopulation);
                }
                else if (radFindByName.Checked)
                {
                    enteredCity = txtCity.Text;

                    dgvCity.DataSource = dbUtils.FindByName(enteredCity);
                }
              
            }
            catch (Exception crap)
            {
                lblStatus.Text = crap.Message;
            }
        }

        private void AddCity(string enteredCity, double enteredPopulation)
        {
            if (IsCityValid(enteredCity))
            {
                if (dbUtils.AddCity(enteredCity, enteredPopulation))
                {
                    DisplayTable();
                }

                lblStatus.Text = dbUtils.LastStatus;
            }
        }


        private void DeleteCity(string enteredCity)
        {
            if (IsCityValid(enteredCity))
            {
                if (dbUtils.DeleteCity(enteredCity))
                {
                    DisplayTable();
                }

                lblStatus.Text = dbUtils.LastStatus;
            }

            ClearTextBoxes();
        }

        private void EditCity(string enteredCity, double enteredPopulation)
        {
            if (dgvCity.SelectedCells.Count == 0)
            {
                lblStatus.Text = "No city selected";
                return;
            }

            if (dbUtils.EditCity(enteredCity, enteredPopulation))
            {
                DisplayTable();
            }

            lblStatus.Text = dbUtils.LastStatus;
        }

        private bool IsCityValid(string enteredCity)
        {
            return !string.IsNullOrEmpty(enteredCity);
        }

       
        private void btnTotalPopulation_Click(object sender, EventArgs e)
        {
            lblStatus.Text = ("Population Total: " + dbUtils.GetPopulationTotal());
        }

        private void dgvCity_SelectionChanged(object sender, EventArgs e)
        {
            if ((radEdit.Checked || radDelete.Checked) && dgvCity.SelectedRows.Count != 0)
            {
                txtCity.Text = dgvCity.SelectedRows[0].Cells[0].Value.ToString();
                txtPopulation.Text = dgvCity.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void radFindByName_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtCity.Text = string.Empty;
            txtPopulation.Text = string.Empty;
            lblStatus.Text = string.Empty;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            lblStatus.Text = ("Population Average: " + dbUtils.GetPopulationAverage());
            
        }
    }
}
