﻿
namespace Project_PCS
{
    partial class MasterBuku
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuku = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnMember);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnPreOrder);
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.btnBuku);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 660);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_PCS.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(36, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOOK STATION";
            // 
            // btnBuku
            // 
            this.btnBuku.BackColor = System.Drawing.Color.White;
            this.btnBuku.FlatAppearance.BorderSize = 0;
            this.btnBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuku.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuku.ForeColor = System.Drawing.Color.Navy;
            this.btnBuku.Location = new System.Drawing.Point(0, 168);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Size = new System.Drawing.Size(226, 43);
            this.btnBuku.TabIndex = 4;
            this.btnBuku.Text = "Buku";
            this.btnBuku.UseVisualStyleBackColor = false;
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 211);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(226, 43);
            this.btnTransaksi.TabIndex = 5;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.MouseLeave += new System.EventHandler(this.btnTransaksi_MouseLeave);
            this.btnTransaksi.MouseHover += new System.EventHandler(this.btnTransaksi_MouseHover);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.FlatAppearance.BorderSize = 0;
            this.btnPreOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOrder.ForeColor = System.Drawing.Color.White;
            this.btnPreOrder.Location = new System.Drawing.Point(0, 260);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(226, 43);
            this.btnPreOrder.TabIndex = 6;
            this.btnPreOrder.Text = "Pre-Order";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.MouseLeave += new System.EventHandler(this.btnPreOrder_MouseLeave);
            this.btnPreOrder.MouseHover += new System.EventHandler(this.btnPreOrder_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 596);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 43);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMember
            // 
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Location = new System.Drawing.Point(0, 309);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(226, 43);
            this.btnMember.TabIndex = 8;
            this.btnMember.Text = "Members";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.MouseLeave += new System.EventHandler(this.btnMember_MouseLeave);
            this.btnMember.MouseHover += new System.EventHandler(this.btnMember_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1108, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lihat Detail";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Detail Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Judul :";
            // 
            // MasterBuku
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterBuku";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterBuku_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}