using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laundry_System
{
    public partial class panelOrders : UserControl
    {
        public panelOrders()
        {
            InitializeComponent();
            SetupDataGridView();

            LoadData();
        }

        private void SetupDataGridView()
        {
            // Set header font to Microsoft Sans Serif, 18pt
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            // Optional: Auto-size columns to fill the width of the DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Add 7 custom-named columns
            dataGridView1.Columns.Add("OrderID", "ORDER ID");
            dataGridView1.Columns.Add("CustomerName", "Name");
            dataGridView1.Columns.Add("ContactInfo", "Contact Info");
            dataGridView1.Columns.Add("ServiceType", "Service Type");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("DropOffDate", "Date of Drop-Off");
            dataGridView1.Columns.Add("Special Instruction", "Special Instruction");
            dataGridView1.Columns.Add("Status", "Status");
        }


        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            string conString = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
            string query = "SELECT * FROM services_table";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    using (MySqlDataReader myReader = cmd.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            int id = myReader.GetInt32("id");
                            string name = myReader.GetString("name");
                            string contact_info = myReader.GetString("contact_info");
                            string service_type = myReader.GetString("service_type");
                            int total_cost = myReader.GetInt32("total_cost");
                            string special_instruction = myReader.GetString("special_instruction");
                            string date_time = myReader.GetString("date_time"); // Fixed
                            string status = myReader.GetString("status");

                            dataGridView1.Rows.Add(id, name, contact_info, service_type, total_cost, date_time, special_instruction, status);
                        }
                    }
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                string idvalue = row.Cells[0].Value.ToString();
                string namevalue = row.Cells[1].Value.ToString();
                string contact_infovalue = row.Cells[2].Value.ToString();
                string service_typevalue = row.Cells[3].Value.ToString();
                string total_costvalue = row.Cells[4].Value.ToString();
                string date_timevalue = row.Cells[5].Value.ToString();
                string special_instructionvalue = row.Cells[6].Value.ToString();
                


                id_txb.Text = idvalue;
                name_txb.Text = namevalue;
                contact_info_txb.Text = contact_infovalue;
                service_type_txb.Text = service_typevalue;
                price_txb.Text = total_costvalue;
                date_of_drop_txb.Text = date_timevalue;
                special_instruction_txb.Text = special_instructionvalue;



            }

        }

        private void update_status_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_txb.Text))
            {

                MessageBox.Show("Please input!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    string conString = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
                    string query = "UPDATE services_table SET status = 'Completed' WHERE id = '"+ id_txb.Text +"'";

                    MySqlConnection con = new MySqlConnection(conString);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader myReader;

                    con.Open();
                    myReader = cmd.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Successfully updated!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();

                }

                catch(Exception error)
                {
                    MessageBox.Show("Connection "+ error, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
                }
            }
        }

        private string status_checker()
        {
            string conString = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
            string query = "SELECT status FROM services_table WHERE id = @id";

            using (MySqlConnection con = new MySqlConnection(conString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id_txb.Text);

                try
                {
                    con.Open();
                    using (MySqlDataReader myReader = cmd.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            return myReader.GetString("status");
                        }
                        else
                        {
                            return "No record found.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking status: " + ex.Message);
                    return "Error";
                }
            }
        }

        private void oder_complete_btn_Click(object sender, EventArgs e)
        {
            if (status_checker().Equals("Pending"))
            {
                MessageBox.Show("Cannot complete pending order");
                return;
            }
            try
            {
                string conString = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
                string dateNow = DateTime.Now.ToString("yyyy-MM-dd");

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    // Insert into completed_table
                    string insertQuery = "INSERT INTO completed_table ( name, contact_info, total_cost, date) " +
                                         "VALUES ( @name, @contact, @cost, @date)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                    {
                       
                        insertCmd.Parameters.AddWithValue("@name", name_txb.Text);
                        insertCmd.Parameters.AddWithValue("@contact", contact_info_txb.Text);
                        insertCmd.Parameters.AddWithValue("@cost", price_txb.Text);
                        insertCmd.Parameters.AddWithValue("@date", dateNow);

                        insertCmd.ExecuteNonQuery();
                    }

                    // Delete from services_table
                    string deleteQuery = "DELETE FROM services_table WHERE id = @id";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con))
                    {
                        deleteCmd.Parameters.AddWithValue("@id", id_txb.Text);
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order Completed!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception error)
            {
                MessageBox.Show("Connection Error: " + error.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelOrders_Load(object sender, EventArgs e)
        {

        }
    }
}

