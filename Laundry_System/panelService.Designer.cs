namespace Laundry_System
{
    partial class panelService
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
            this.label1 = new System.Windows.Forms.Label();
            this.service_type_cbx = new System.Windows.Forms.ComboBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contact_info_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.special_instruction_tbx = new System.Windows.Forms.TextBox();
            this.total_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.voucher_tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Service Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // service_type_cbx
            // 
            this.service_type_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_type_cbx.FormattingEnabled = true;
            this.service_type_cbx.Items.AddRange(new object[] {
            "",
            "Machine Wash Small",
            "Machine Wash Large",
            "Beddings and Towels",
            "Blanket",
            "Curtains"});
            this.service_type_cbx.Location = new System.Drawing.Point(437, 184);
            this.service_type_cbx.Name = "service_type_cbx";
            this.service_type_cbx.Size = new System.Drawing.Size(330, 33);
            this.service_type_cbx.TabIndex = 14;
            this.service_type_cbx.SelectedIndexChanged += new System.EventHandler(this.service_type_cbx_SelectedIndexChanged);
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(838, 486);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(240, 48);
            this.confirm_btn.TabIndex = 18;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // name_txb
            // 
            this.name_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txb.Location = new System.Drawing.Point(437, 83);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(330, 35);
            this.name_txb.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Contact Info:";
            // 
            // contact_info_txb
            // 
            this.contact_info_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_info_txb.Location = new System.Drawing.Point(437, 133);
            this.contact_info_txb.Name = "contact_info_txb";
            this.contact_info_txb.Size = new System.Drawing.Size(330, 35);
            this.contact_info_txb.TabIndex = 22;
            this.contact_info_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contact_info_txb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Voucher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 27;
            this.label4.Text = "Special Instruction:";
            // 
            // special_instruction_tbx
            // 
            this.special_instruction_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.special_instruction_tbx.Location = new System.Drawing.Point(437, 288);
            this.special_instruction_tbx.Multiline = true;
            this.special_instruction_tbx.Name = "special_instruction_tbx";
            this.special_instruction_tbx.Size = new System.Drawing.Size(476, 147);
            this.special_instruction_tbx.TabIndex = 28;
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(431, 493);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(83, 31);
            this.total_lbl.TabIndex = 30;
            this.total_lbl.Text = "Total:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(792, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // voucher_tbx
            // 
            this.voucher_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher_tbx.Location = new System.Drawing.Point(437, 237);
            this.voucher_tbx.Name = "voucher_tbx";
            this.voucher_tbx.ReadOnly = true;
            this.voucher_tbx.Size = new System.Drawing.Size(330, 35);
            this.voucher_tbx.TabIndex = 32;
            // 
            // panelService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.voucher_tbx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.special_instruction_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contact_info_txb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_txb);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.service_type_cbx);
            this.Controls.Add(this.label1);
            this.Name = "panelService";
            this.Size = new System.Drawing.Size(1143, 594);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox service_type_cbx;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox name_txb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contact_info_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox special_instruction_tbx;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox voucher_tbx;
    }
}
