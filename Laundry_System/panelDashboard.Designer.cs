namespace Laundry_System
{
    partial class panelDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.completed_lbl = new System.Windows.Forms.Label();
            this.pending_lbl = new System.Windows.Forms.Label();
            this.total_sales_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.price,
            this.service_type});
            this.dataGridView1.Location = new System.Drawing.Point(43, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // service_type
            // 
            this.service_type.HeaderText = "Service Type";
            this.service_type.Name = "service_type";
            this.service_type.ReadOnly = true;
            this.service_type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.completed_lbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(424, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 146);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pending";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.total_sales_lbl);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(800, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 146);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Completed";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pending_lbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(43, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 146);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Sales";
            // 
            // completed_lbl
            // 
            this.completed_lbl.AutoSize = true;
            this.completed_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completed_lbl.Location = new System.Drawing.Point(143, 22);
            this.completed_lbl.Name = "completed_lbl";
            this.completed_lbl.Size = new System.Drawing.Size(29, 31);
            this.completed_lbl.TabIndex = 1;
            this.completed_lbl.Text = "0";
            // 
            // pending_lbl
            // 
            this.pending_lbl.AutoSize = true;
            this.pending_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending_lbl.Location = new System.Drawing.Point(137, 22);
            this.pending_lbl.Name = "pending_lbl";
            this.pending_lbl.Size = new System.Drawing.Size(29, 31);
            this.pending_lbl.TabIndex = 2;
            this.pending_lbl.Text = "0";
            // 
            // total_sales_lbl
            // 
            this.total_sales_lbl.AutoSize = true;
            this.total_sales_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_sales_lbl.Location = new System.Drawing.Point(76, 22);
            this.total_sales_lbl.Name = "total_sales_lbl";
            this.total_sales_lbl.Size = new System.Drawing.Size(0, 31);
            this.total_sales_lbl.TabIndex = 2;
            // 
            // panelDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "panelDashboard";
            this.Size = new System.Drawing.Size(1143, 594);
            this.Load += new System.EventHandler(this.panelDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_type;
        private System.Windows.Forms.Label completed_lbl;
        private System.Windows.Forms.Label total_sales_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pending_lbl;
    }
}
