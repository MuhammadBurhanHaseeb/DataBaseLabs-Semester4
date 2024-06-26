
namespace ProjentA_2021_CS_139_
{
    partial class insertstudent
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
            this.lblregistratoinno = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbldateofbirth = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.txtregistrationno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtdateofbirth = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.41232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.lblheading, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnlogout, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 64);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblheading
            // 
            this.lblheading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(212, 11);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(476, 42);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Enter  Student Information";
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(781, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(95, 37);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Back";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.46715F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.53285F));
            this.tableLayoutPanel2.Controls.Add(this.txtgender, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtlastname, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtdateofbirth, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtfirstname, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtemail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblregistratoinno, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblfirstname, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblemail, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbldateofbirth, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblgender, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtregistrationno, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtcontact, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnregister, 1, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(48, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 395);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblregistratoinno
            // 
            this.lblregistratoinno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblregistratoinno.AutoSize = true;
            this.lblregistratoinno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistratoinno.Location = new System.Drawing.Point(3, 11);
            this.lblregistratoinno.Name = "lblregistratoinno";
            this.lblregistratoinno.Size = new System.Drawing.Size(137, 20);
            this.lblregistratoinno.TabIndex = 0;
            this.lblregistratoinno.Text = "Registration NO";
            // 
            // lblfirstname
            // 
            this.lblfirstname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(3, 97);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(96, 20);
            this.lblfirstname.TabIndex = 1;
            this.lblfirstname.Text = "First Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact";
            // 
            // lblemail
            // 
            this.lblemail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(334, 11);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(53, 20);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // lbldateofbirth
            // 
            this.lbldateofbirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbldateofbirth.AutoSize = true;
            this.lbldateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofbirth.Location = new System.Drawing.Point(334, 97);
            this.lbldateofbirth.Name = "lbldateofbirth";
            this.lbldateofbirth.Size = new System.Drawing.Size(115, 20);
            this.lbldateofbirth.TabIndex = 5;
            this.lbldateofbirth.Text = "Date Of Birth";
            // 
            // lblgender
            // 
            this.lblgender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(334, 183);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(69, 20);
            this.lblgender.TabIndex = 6;
            this.lblgender.Text = "Gender";
            // 
            // txtregistrationno
            // 
            this.txtregistrationno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregistrationno.Location = new System.Drawing.Point(3, 46);
            this.txtregistrationno.Name = "txtregistrationno";
            this.txtregistrationno.Size = new System.Drawing.Size(297, 31);
            this.txtregistrationno.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(334, 46);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(297, 31);
            this.txtemail.TabIndex = 8;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(3, 132);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(297, 31);
            this.txtfirstname.TabIndex = 9;
            // 
            // txtdateofbirth
            // 
            this.txtdateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateofbirth.Location = new System.Drawing.Point(334, 132);
            this.txtdateofbirth.Name = "txtdateofbirth";
            this.txtdateofbirth.Size = new System.Drawing.Size(297, 31);
            this.txtdateofbirth.TabIndex = 10;
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(3, 218);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(297, 31);
            this.txtlastname.TabIndex = 11;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(3, 304);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(297, 31);
            this.txtcontact.TabIndex = 13;
            // 
            // btnregister
            // 
            this.btnregister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(444, 307);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(128, 31);
            this.btnregister.TabIndex = 14;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtgender.Location = new System.Drawing.Point(334, 218);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(297, 33);
            this.txtgender.TabIndex = 5;
            // 
            // insertstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 519);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "insertstudent";
            this.Text = "insertstudent";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblregistratoinno;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbldateofbirth;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox txtregistrationno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtdateofbirth;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.ComboBox txtgender;
    }
}