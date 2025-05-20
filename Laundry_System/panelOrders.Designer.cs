namespace Laundry_System
{
    partial class panelOrders
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
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_drop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special_instruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.id_txb = new System.Windows.Forms.TextBox();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contact_info_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.service_type_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_of_drop_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.special_instruction_txb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.update_status_btn = new System.Windows.Forms.Button();
            this.price_txb = new System.Windows.Forms.TextBox();
            this.oder_complete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.name,
            this.contact_info,
            this.service_type,
            this.price,
            this.date_of_drop,
            this.special_instruction,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(24, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(837, 549);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // order_id
            // 
            this.order_id.HeaderText = "Order ID";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // contact_info
            // 
            this.contact_info.HeaderText = "Contact Info";
            this.contact_info.Name = "contact_info";
            this.contact_info.ReadOnly = true;
            // 
            // service_type
            // 
            this.service_type.HeaderText = "Service Type";
            this.service_type.Name = "service_type";
            this.service_type.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // date_of_drop
            // 
            this.date_of_drop.HeaderText = "Date of Drop-Off";
            this.date_of_drop.Name = "date_of_drop";
            this.date_of_drop.ReadOnly = true;
            // 
            // special_instruction
            // 
            this.special_instruction.HeaderText = "Special Instruction";
            this.special_instruction.Name = "special_instruction";
            this.special_instruction.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(867, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // id_txb
            // 
            this.id_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txb.Location = new System.Drawing.Point(867, 75);
            this.id_txb.Name = "id_txb";
            this.id_txb.ReadOnly = true;
            this.id_txb.Size = new System.Drawing.Size(42, 22);
            this.id_txb.TabIndex = 7;
            // 
            // name_txb
            // 
            this.name_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txb.Location = new System.Drawing.Point(867, 124);
            this.name_txb.Name = "name_txb";
            this.name_txb.ReadOnly = true;
            this.name_txb.Size = new System.Drawing.Size(257, 29);
            this.name_txb.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(864, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // contact_info_txb
            // 
            this.contact_info_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_info_txb.Location = new System.Drawing.Point(867, 183);
            this.contact_info_txb.Name = "contact_info_txb";
            this.contact_info_txb.ReadOnly = true;
            this.contact_info_txb.Size = new System.Drawing.Size(257, 29);
            this.contact_info_txb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(864, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact info";
            // 
            // service_type_txb
            // 
            this.service_type_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_type_txb.Location = new System.Drawing.Point(867, 242);
            this.service_type_txb.Name = "service_type_txb";
            this.service_type_txb.ReadOnly = true;
            this.service_type_txb.Size = new System.Drawing.Size(257, 29);
            this.service_type_txb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(864, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Service Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(864, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price";
            // 
            // date_of_drop_txb
            // 
            this.date_of_drop_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_of_drop_txb.Location = new System.Drawing.Point(942, 75);
            this.date_of_drop_txb.Name = "date_of_drop_txb";
            this.date_of_drop_txb.ReadOnly = true;
            this.date_of_drop_txb.Size = new System.Drawing.Size(182, 22);
            this.date_of_drop_txb.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(939, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date of Drop-Off";
            // 
            // special_instruction_txb
            // 
            this.special_instruction_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.special_instruction_txb.Location = new System.Drawing.Point(867, 359);
            this.special_instruction_txb.Multiline = true;
            this.special_instruction_txb.Name = "special_instruction_txb";
            this.special_instruction_txb.ReadOnly = true;
            this.special_instruction_txb.Size = new System.Drawing.Size(257, 135);
            this.special_instruction_txb.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(864, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Special Instruction";
            // 
            // update_status_btn
            // 
            this.update_status_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.update_status_btn.Location = new System.Drawing.Point(883, 508);
            this.update_status_btn.Name = "update_status_btn";
            this.update_status_btn.Size = new System.Drawing.Size(97, 28);
            this.update_status_btn.TabIndex = 22;
            this.update_status_btn.Text = "Update Status";
            this.update_status_btn.UseVisualStyleBackColor = false;
            this.update_status_btn.Click += new System.EventHandler(this.update_status_btn_Click);
            // 
            // price_txb
            // 
            this.price_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txb.Location = new System.Drawing.Point(867, 299);
            this.price_txb.Name = "price_txb";
            this.price_txb.ReadOnly = true;
            this.price_txb.Size = new System.Drawing.Size(257, 29);
            this.price_txb.TabIndex = 23;
            // 
            // oder_complete_btn
            // 
            this.oder_complete_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.oder_complete_btn.Location = new System.Drawing.Point(1027, 508);
            this.oder_complete_btn.Name = "oder_complete_btn";
            this.oder_complete_btn.Size = new System.Drawing.Size(97, 28);
            this.oder_complete_btn.TabIndex = 24;
            this.oder_complete_btn.Text = "Order Complete";
            this.oder_complete_btn.UseVisualStyleBackColor = false;
            this.oder_complete_btn.Click += new System.EventHandler(this.oder_complete_btn_Click);
            // 
            // panelOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oder_complete_btn);
            this.Controls.Add(this.price_txb);
            this.Controls.Add(this.update_status_btn);
            this.Controls.Add(this.special_instruction_txb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_of_drop_txb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.service_type_txb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contact_info_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_txb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "panelOrders";
            this.Size = new System.Drawing.Size(1143, 594);
            this.Load += new System.EventHandler(this.panelOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_drop;
        private System.Windows.Forms.DataGridViewTextBoxColumn special_instruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox id_txb;
        private System.Windows.Forms.TextBox name_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contact_info_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox service_type_txb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox date_of_drop_txb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox special_instruction_txb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update_status_btn;
        private System.Windows.Forms.TextBox price_txb;
        private System.Windows.Forms.Button oder_complete_btn;
    }
}
