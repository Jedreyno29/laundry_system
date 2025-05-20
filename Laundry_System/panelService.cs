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
    public partial class panelService : UserControl
    {
        int total_cost = 0;
        int final_cost = 0;
        public panelService()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int GetServiceCount(string contactInfo)
        {
            string connStr = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string countQuery = "SELECT COUNT(*) FROM completed_table WHERE contact_info = @contact_info";
                using (MySqlCommand cmd = new MySqlCommand(countQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@contact_info", contactInfo);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        private void confirm_btn_Click(object sender, EventArgs e)
        {   
            DateTime now = DateTime.Now;

            string connStr = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string insertQuery = "INSERT INTO services_table (name, contact_info, 	service_type, total_cost, special_instruction, date_time, status) VALUES (@name, @contact_info, @service_type,@total_cost, @special_instruction,@date_time, @status)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {

                    cmd.Parameters.AddWithValue("@name", name_txb.Text);
                    cmd.Parameters.AddWithValue("@contact_info", contact_info_txb.Text);
                    cmd.Parameters.AddWithValue("@service_type", service_type_cbx.SelectedItem);
                    cmd.Parameters.AddWithValue("@total_cost", final_cost);
                    cmd.Parameters.AddWithValue("@special_instruction", special_instruction_tbx.Text);
                    cmd.Parameters.AddWithValue("@date_time", now);
                    cmd.Parameters.AddWithValue("@status", "Pending");
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Laundry order placed successfully!");
                        name_txb.Text = "";
                        contact_info_txb.Text = "";
                        service_type_cbx.SelectedIndex = -1;
                        voucher_tbx.Text = "";
                        special_instruction_tbx.Text = "";


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please input correct details.");
                    }
                }
            }
        }

        private void service_type_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (service_type_cbx.SelectedIndex)
            {
                case 1:
                    total_cost = 300;
                    break;
                case 2:
                    total_cost = 400;
                    break;
                case 3:
                    total_cost = 400;
                    break;
                case 4:
                    total_cost = 150;
                    break;
                case 5:
                    total_cost = 500;
                    break;
                default:
                    total_cost = 0;
                    break;
            }

            total_lbl.Text = "Total Cost: " + total_cost.ToString();
        }

        private void voucher_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int previousServices = GetServiceCount(contact_info_txb.Text);


            // Check if this is the 5th visit (0-based index + 1)
            if ((previousServices + 1) == 5)
            {
                MessageBox.Show("Voucher Applied");
                voucher_tbx.Text = "5 Time Customer Voucher";
                final_cost = total_cost / 2;
            }else if ((previousServices + 1) == 10)
            {
                MessageBox.Show("Voucher Applied");
                voucher_tbx.Text = "10 Time Customer Voucher";
                final_cost = 0;
            }
            else
            {
                MessageBox.Show("No Voucher Available");
                voucher_tbx.Text = "";
                final_cost = total_cost;
            }

            total_lbl.Text = "Total Cost: " + final_cost.ToString();
        }

        private void contact_info_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
