namespace InsertToursm
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.EToursmshowdata = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttipe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EToursmshowdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 633);
            this.panel1.TabIndex = 49;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(9, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "Admin_Mode";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 59);
            this.panel2.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1262, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EToursmshowdata
            // 
            this.EToursmshowdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EToursmshowdata.Location = new System.Drawing.Point(532, 130);
            this.EToursmshowdata.Name = "EToursmshowdata";
            this.EToursmshowdata.RowHeadersWidth = 51;
            this.EToursmshowdata.RowTemplate.Height = 24;
            this.EToursmshowdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EToursmshowdata.Size = new System.Drawing.Size(741, 541);
            this.EToursmshowdata.TabIndex = 60;
            this.EToursmshowdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EToursmshowdata_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 51);
            this.button4.TabIndex = 59;
            this.button4.Text = "insert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tipe Pariwisata";
            // 
            // txttipe
            // 
            this.txttipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipe.Location = new System.Drawing.Point(164, 418);
            this.txttipe.Multiline = true;
            this.txttipe.Name = "txttipe";
            this.txttipe.Size = new System.Drawing.Size(264, 38);
            this.txttipe.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Alamat Pariwisata";
            // 
            // txtalamat
            // 
            this.txtalamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalamat.Location = new System.Drawing.Point(164, 333);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(264, 38);
            this.txtalamat.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Harga Tiket";
            // 
            // txtharga
            // 
            this.txtharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga.Location = new System.Drawing.Point(164, 242);
            this.txtharga.Multiline = true;
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(264, 38);
            this.txtharga.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nama Pariwisata";
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(164, 161);
            this.txtnama.Multiline = true;
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(264, 38);
            this.txtnama.TabIndex = 51;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 51);
            this.button3.TabIndex = 61;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 573);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 51);
            this.button5.TabIndex = 62;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(315, 573);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 51);
            this.button6.TabIndex = 63;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 692);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EToursmshowdata);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EToursmshowdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView EToursmshowdata;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}