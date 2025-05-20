using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laundry_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var dashboard = new panelDashboard();
            LoadMainControl(dashboard);
        }

        private void LoadMainControl(UserControl uc)
        {
            mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            var dashboard = new panelDashboard();
            LoadMainControl(dashboard);
        }

        private void sevices_btn_Click(object sender, EventArgs e)
        {
            var services = new panelService();
            LoadMainControl(services);
        }


        private void orders_btn_Click(object sender, EventArgs e)
        {
            var orders = new panelOrders();
            LoadMainControl(orders);
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            var registration = new panelRegistration();
            LoadMainControl(registration);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }

}
    
