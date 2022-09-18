namespace LMS_gen3
{
    partial class frmStudentlist
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
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvDataSource = new System.Windows.Forms.DataGridView();
            this.colstuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblStuid = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Yellow;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(201, 57);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(122, 36);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Results";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvDataSource
            // 
            this.dgvDataSource.AllowUserToAddRows = false;
            this.dgvDataSource.AllowUserToDeleteRows = false;
            this.dgvDataSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstuid,
            this.colName,
            this.colDepartment,
            this.colMobile,
            this.colDOB,
            this.colGender,
            this.comImage});
            this.dgvDataSource.Location = new System.Drawing.Point(39, 118);
            this.dgvDataSource.Name = "dgvDataSource";
            this.dgvDataSource.ReadOnly = true;
            this.dgvDataSource.RowTemplate.Height = 122;
            this.dgvDataSource.Size = new System.Drawing.Size(776, 296);
            this.dgvDataSource.TabIndex = 1;
            // 
            // colstuid
            // 
            this.colstuid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colstuid.DataPropertyName = "Stuid";
            this.colstuid.HeaderText = "Student ID";
            this.colstuid.Name = "colstuid";
            this.colstuid.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "Department";
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            // 
            // colMobile
            // 
            this.colMobile.DataPropertyName = "Mobile";
            this.colMobile.HeaderText = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            // 
            // colDOB
            // 
            this.colDOB.DataPropertyName = "DOB";
            this.colDOB.HeaderText = "DOB";
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // comImage
            // 
            this.comImage.DataPropertyName = "Image";
            this.comImage.HeaderText = "Image";
            this.comImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.comImage.Name = "comImage";
            this.comImage.ReadOnly = true;
            this.comImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblStuid
            // 
            this.lblStuid.AutoSize = true;
            this.lblStuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuid.Location = new System.Drawing.Point(35, 28);
            this.lblStuid.Name = "lblStuid";
            this.lblStuid.Size = new System.Drawing.Size(136, 20);
            this.lblStuid.TabIndex = 2;
            this.lblStuid.Text = "Select Student ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(387, 44);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 24);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "label1";
            // 
            // frmStudentlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(846, 444);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblStuid);
            this.Controls.Add(this.dgvDataSource);
            this.Controls.Add(this.btnShow);
            this.Name = "frmStudentlist";
            this.Text = "List of Student Members";
            this.Load += new System.EventHandler(this.frmStudentlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvDataSource;
        private System.Windows.Forms.Label lblStuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewImageColumn comImage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCount;
    }
}