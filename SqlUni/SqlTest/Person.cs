using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlTest
{
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string conString = "data source=DESKTOP-D5VFL9P; initial catalog = university; integrated security = True; MultipleActiveResultSets = True;";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO Persons(PersonID,LastName,FirstName,Age,City) VALUES (" + int.Parse(txtPersonID.Text) + ", '"
                    + txtLastName.Text + "', '" + txtFirstName.Text +"' ," + int.Parse(txtAge.Text) + ", '" + txtCity.Text + "')" ,connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        txtResult.Text = "(1 row(s) affected)";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtPersonID.Text = "";
                        txtAge.Text = "";
                        txtCity.Text = "";
                    }
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string conString = "data source=DESKTOP-D5VFL9P; initial catalog = university; integrated security = True; MultipleActiveResultSets = True;";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT * FROM Persons", connection))
                {
                    txtResult.Text = "";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                txtResult.Text += reader.GetValue(i);
                                txtResult.Text += " , ";
                            }
                            txtResult.Text += "\r\n";
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conString = "data source=DESKTOP-D5VFL9P; initial catalog = university; integrated security = True; MultipleActiveResultSets = True;";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "DELETE FROM Persons WHERE PersonID=" + txtIdDelete.Text + ";", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                txtResult.Text += reader.GetValue(i);
                                txtResult.Text += " , ";
                            }
                            txtResult.Text += "\r\n";
                        }
                        txtResult.Text = "(1 row(s) affected) (DELETED)";
                    }
                }
            }
        }

        private void Person_Load(object sender, EventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 900, 630);
            this.Region = new Region(path);
            this.Show();
        }
    }
}
