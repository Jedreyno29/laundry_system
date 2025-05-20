using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Laundry_System
{
    public partial class panelDashboard : UserControl
    {
        public panelDashboard()
        {
            InitializeComponent();
            LoadPendingOrdersCount();
            LoadCompletedOrdersCount();
            LoadTotalSales();
        }

        private void LoadPendingOrdersCount()
        {
            string connStr = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
            string query = "SELECT COUNT(*) FROM services_table WHERE status = 'Pending'";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int pendingCount = result != null ? Convert.ToInt32(result) : 0;

                        if (pending_lbl != null)
                        {
                            pending_lbl.Text = pendingCount.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Label 'pending_lbl' is not initialized.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending order count: " + ex.Message);
            }
        }

        private void LoadCompletedOrdersCount()
        {
            string connStr = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
            string query = "SELECT COUNT(*) FROM completed_table";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int completedCount = result != null ? Convert.ToInt32(result) : 0;

                        if (completed_lbl != null)
                        {
                            completed_lbl.Text = completedCount.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Label 'completed_lbl' is not initialized.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading completed order count: " + ex.Message);
            }
        }

        private void LoadTotalSales()
        {
            string connStr = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
            string query = "SELECT SUM(total_cost) FROM completed_table"; // Replace 'total_amount' if needed

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal totalSales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                        if (total_sales_lbl != null)
                        {
                            total_sales_lbl.Text = "₱ " + totalSales.ToString("N2"); // Format with 2 decimal places
                        }
                        else
                        {
                            MessageBox.Show("Label 'total_sales_lbl' is not initialized.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total sales: " + ex.Message);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            }

        private void panelDashboard_Load(object sender, EventArgs e)
        {
            // Set header font and alignment
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set cell content font and alignment
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set fixed row and header height to fit larger font
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.ColumnHeadersHeight = 60;

            // Auto-size columns to fill the grid
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable editing and extra empty row
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            // Clear existing columns
            dataGridView1.Columns.Clear();

            // Add columns
            dataGridView1.Columns.Add("ServiceType", "Service Type");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");

            // Add rows
            dataGridView1.Rows.Add("Machine Wash Small", "Small Bag, Maximum 5 kg", "P300");
            dataGridView1.Rows.Add("Machine Wash Large", "Large Bag, Maximum 8 kg.", "P400");
            dataGridView1.Rows.Add("Beddings and Towels", "Maximum 3 kg", "P400");
            dataGridView1.Rows.Add("Blanket", "Single/Twin (65\"-90\")", "P150");
            dataGridView1.Rows.Add("Curtains", "Maximum 8 kg", "P500");
        }






    }
}
    
