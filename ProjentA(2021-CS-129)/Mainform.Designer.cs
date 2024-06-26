
namespace ProjentA_2021_CS_139_
{
    partial class Mainform
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblheading = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnprojectdetail = new System.Windows.Forms.Button();
            this.btnmanageadvisor = new System.Windows.Forms.Button();
            this.btnmanageprojects = new System.Windows.Forms.Button();
            this.btnformationgroup = new System.Windows.Forms.Button();
            this.btnprojectassign = new System.Windows.Forms.Button();
            this.btnmultipleadvisor = new System.Windows.Forms.Button();
            this.btnmanageevaluation = new System.Windows.Forms.Button();
            this.btnmarkevaluation = new System.Windows.Forms.Button();
            this.btncreatestudent = new System.Windows.Forms.Button();
            this.btnmarkssheet = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.41232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.lblheading, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnlogout, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblheading
            // 
            this.lblheading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(320, 15);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(212, 42);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Main Menu";
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(739, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(95, 37);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel2.Controls.Add(this.btnprojectdetail, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnmanageadvisor, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnmanageprojects, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnformationgroup, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnprojectassign, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnmultipleadvisor, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnmanageevaluation, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnmarkevaluation, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btncreatestudent, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnmarkssheet, 0, 10);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 91);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(201, 454);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnprojectdetail
            // 
            this.btnprojectdetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprojectdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprojectdetail.Location = new System.Drawing.Point(3, 372);
            this.btnprojectdetail.Name = "btnprojectdetail";
            this.btnprojectdetail.Size = new System.Drawing.Size(195, 35);
            this.btnprojectdetail.TabIndex = 10;
            this.btnprojectdetail.Text = "Project Detail";
            this.btnprojectdetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprojectdetail.UseVisualStyleBackColor = true;
            // 
            // btnmanageadvisor
            // 
            this.btnmanageadvisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmanageadvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageadvisor.Location = new System.Drawing.Point(3, 85);
            this.btnmanageadvisor.Name = "btnmanageadvisor";
            this.btnmanageadvisor.Size = new System.Drawing.Size(195, 35);
            this.btnmanageadvisor.TabIndex = 3;
            this.btnmanageadvisor.Text = "Manage  Advisors";
            this.btnmanageadvisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmanageadvisor.UseVisualStyleBackColor = true;
            // 
            // btnmanageprojects
            // 
            this.btnmanageprojects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmanageprojects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageprojects.Location = new System.Drawing.Point(3, 126);
            this.btnmanageprojects.Name = "btnmanageprojects";
            this.btnmanageprojects.Size = new System.Drawing.Size(195, 35);
            this.btnmanageprojects.TabIndex = 4;
            this.btnmanageprojects.Text = "Manage  Projects";
            this.btnmanageprojects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmanageprojects.UseVisualStyleBackColor = true;
            // 
            // btnformationgroup
            // 
            this.btnformationgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnformationgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnformationgroup.Location = new System.Drawing.Point(3, 167);
            this.btnformationgroup.Name = "btnformationgroup";
            this.btnformationgroup.Size = new System.Drawing.Size(195, 35);
            this.btnformationgroup.TabIndex = 5;
            this.btnformationgroup.Text = " Groups Formation";
            this.btnformationgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnformationgroup.UseVisualStyleBackColor = true;
            // 
            // btnprojectassign
            // 
            this.btnprojectassign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprojectassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprojectassign.Location = new System.Drawing.Point(3, 208);
            this.btnprojectassign.Name = "btnprojectassign";
            this.btnprojectassign.Size = new System.Drawing.Size(195, 35);
            this.btnprojectassign.TabIndex = 6;
            this.btnprojectassign.Text = "Project Assign";
            this.btnprojectassign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprojectassign.UseVisualStyleBackColor = true;
            // 
            // btnmultipleadvisor
            // 
            this.btnmultipleadvisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmultipleadvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultipleadvisor.Location = new System.Drawing.Point(3, 249);
            this.btnmultipleadvisor.Name = "btnmultipleadvisor";
            this.btnmultipleadvisor.Size = new System.Drawing.Size(195, 35);
            this.btnmultipleadvisor.TabIndex = 7;
            this.btnmultipleadvisor.Text = "Assign multiple Advisor";
            this.btnmultipleadvisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmultipleadvisor.UseVisualStyleBackColor = true;
            // 
            // btnmanageevaluation
            // 
            this.btnmanageevaluation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmanageevaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageevaluation.Location = new System.Drawing.Point(3, 290);
            this.btnmanageevaluation.Name = "btnmanageevaluation";
            this.btnmanageevaluation.Size = new System.Drawing.Size(195, 35);
            this.btnmanageevaluation.TabIndex = 8;
            this.btnmanageevaluation.Text = "Manage  Evaluation";
            this.btnmanageevaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmanageevaluation.UseVisualStyleBackColor = true;
            // 
            // btnmarkevaluation
            // 
            this.btnmarkevaluation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmarkevaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarkevaluation.Location = new System.Drawing.Point(3, 331);
            this.btnmarkevaluation.Name = "btnmarkevaluation";
            this.btnmarkevaluation.Size = new System.Drawing.Size(195, 35);
            this.btnmarkevaluation.TabIndex = 9;
            this.btnmarkevaluation.Text = "Mark evaluation of Groups";
            this.btnmarkevaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmarkevaluation.UseVisualStyleBackColor = true;
            // 
            // btncreatestudent
            // 
            this.btncreatestudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncreatestudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatestudent.Location = new System.Drawing.Point(3, 44);
            this.btncreatestudent.Name = "btncreatestudent";
            this.btncreatestudent.Size = new System.Drawing.Size(195, 35);
            this.btncreatestudent.TabIndex = 1;
            this.btncreatestudent.Text = "Create Student";
            this.btncreatestudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreatestudent.UseVisualStyleBackColor = true;
            this.btncreatestudent.Click += new System.EventHandler(this.btncreatestudent_Click);
            // 
            // btnmarkssheet
            // 
            this.btnmarkssheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmarkssheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarkssheet.Location = new System.Drawing.Point(3, 413);
            this.btnmarkssheet.Name = "btnmarkssheet";
            this.btnmarkssheet.Size = new System.Drawing.Size(195, 38);
            this.btnmarkssheet.TabIndex = 11;
            this.btnmarkssheet.Text = "Marks sheet of Projects";
            this.btnmarkssheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmarkssheet.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtsearch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnsearch, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(236, 91);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(384, 43);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(3, 6);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(297, 31);
            this.txtsearch.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(306, 3);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 34);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 402);
            this.dataGridView1.TabIndex = 3;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btncreatestudent;
        private System.Windows.Forms.Button btnmanageadvisor;
        private System.Windows.Forms.Button btnprojectdetail;
        private System.Windows.Forms.Button btnmanageprojects;
        private System.Windows.Forms.Button btnformationgroup;
        private System.Windows.Forms.Button btnprojectassign;
        private System.Windows.Forms.Button btnmultipleadvisor;
        private System.Windows.Forms.Button btnmanageevaluation;
        private System.Windows.Forms.Button btnmarkevaluation;
        private System.Windows.Forms.Button btnmarkssheet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}