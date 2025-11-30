namespace empMg
{
    partial class dept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dept));
            this.Updbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeptNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deptlist = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpLab = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sallab = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Deptlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Updbtn
            // 
            this.Updbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Updbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updbtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Updbtn.ForeColor = System.Drawing.Color.Black;
            this.Updbtn.Location = new System.Drawing.Point(53, 253);
            this.Updbtn.Name = "Updbtn";
            this.Updbtn.Size = new System.Drawing.Size(88, 32);
            this.Updbtn.TabIndex = 44;
            this.Updbtn.Text = "تعديل";
            this.Updbtn.UseVisualStyleBackColor = false;
            this.Updbtn.Click += new System.EventHandler(this.Updbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Teal;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Addbtn.ForeColor = System.Drawing.Color.Transparent;
            this.Addbtn.Location = new System.Drawing.Point(189, 253);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(88, 32);
            this.Addbtn.TabIndex = 43;
            this.Addbtn.Text = "اضافة";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(52, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(52, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "اسم القسم";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DeptNameTb
            // 
            this.DeptNameTb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptNameTb.ForeColor = System.Drawing.Color.Teal;
            this.DeptNameTb.Location = new System.Drawing.Point(53, 180);
            this.DeptNameTb.Name = "DeptNameTb";
            this.DeptNameTb.Size = new System.Drawing.Size(224, 27);
            this.DeptNameTb.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "HR Mini System -نظام موارد بشرية مصغر ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 22);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 63);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Deptlist
            // 
            this.Deptlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Deptlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Deptlist.BackgroundColor = System.Drawing.Color.Azure;
            this.Deptlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Deptlist.Location = new System.Drawing.Point(327, 212);
            this.Deptlist.Name = "Deptlist";
            this.Deptlist.ReadOnly = true;
            this.Deptlist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Deptlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Deptlist.Size = new System.Drawing.Size(588, 353);
            this.Deptlist.TabIndex = 45;
            this.Deptlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Deptlist_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(588, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "قائمة الاقسام";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // EmpLab
            // 
            this.EmpLab.AutoSize = true;
            this.EmpLab.BackColor = System.Drawing.SystemColors.Window;
            this.EmpLab.CausesValidation = false;
            this.EmpLab.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLab.ForeColor = System.Drawing.Color.Teal;
            this.EmpLab.Location = new System.Drawing.Point(418, 80);
            this.EmpLab.Name = "EmpLab";
            this.EmpLab.Size = new System.Drawing.Size(80, 19);
            this.EmpLab.TabIndex = 48;
            this.EmpLab.Text = "الموظفين";
            this.EmpLab.Click += new System.EventHandler(this.EmpLab_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(526, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "الاقسام";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sallab
            // 
            this.sallab.AutoSize = true;
            this.sallab.BackColor = System.Drawing.SystemColors.Window;
            this.sallab.CausesValidation = false;
            this.sallab.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sallab.ForeColor = System.Drawing.Color.Teal;
            this.sallab.Location = new System.Drawing.Point(638, 80);
            this.sallab.Name = "sallab";
            this.sallab.Size = new System.Drawing.Size(59, 19);
            this.sallab.TabIndex = 52;
            this.sallab.Text = "الرواتب";
            this.sallab.Click += new System.EventHandler(this.sallab_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(737, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "خروج";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Red;
            this.deletebtn.CausesValidation = false;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deletebtn.ForeColor = System.Drawing.Color.Black;
            this.deletebtn.Location = new System.Drawing.Point(850, 212);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(65, 27);
            this.deletebtn.TabIndex = 55;
            this.deletebtn.Text = "حذف";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sallab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmpLab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Deptlist);
            this.Controls.Add(this.Updbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeptNameTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dept";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dept_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Deptlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Updbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeptNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Deptlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmpLab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sallab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}