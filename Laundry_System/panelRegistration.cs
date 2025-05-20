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
    public partial class panelRegistration : UserControl
    {
        

        public panelRegistration()
        {
            InitializeComponent();
          
        }

        private void panelRegistration_Load(object sender, EventArgs e)
        {

        }

        private string GetSelectedGender()
        {
            if (male_rb.Checked)
                return "Male";
            else if (female_rb.Checked)
                return "Female";
            else
                return null; // or "Not selected"
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string connStr = "Server=localhost;Database=laundry_db;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string insertQuery = "INSERT INTO user (name, contact_info, age, birthday, gender) VALUES (@name, @contact_info, @age, @birthday, @gender)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                   
                    cmd.Parameters.AddWithValue("@name", name_txb.Text);
                    cmd.Parameters.AddWithValue("@contact_info", contact_info_txb.Text);
                    cmd.Parameters.AddWithValue("@age", age_txb.Text);
                    cmd.Parameters.AddWithValue("@birthday", birthday_dtp.Value.Date); 
                    cmd.Parameters.AddWithValue("@gender", GetSelectedGender());
                   
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User uploaded successfully!");
                        name_txb.Text = "";
                        contact_info_txb.Text = "";
                        age_txb.Text = "";
                        female_rb.Checked = false;
                        male_rb.Checked = false;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Upload failed: " + ex.Message);
                    }
                }
            }

        }
    }
}
