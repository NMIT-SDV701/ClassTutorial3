namespace Version_3_C
{
    partial class frmArtist
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.optSort = new System.Windows.Forms.GroupBox();
            this.rbByDate = new System.Windows.Forms.RadioButton();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.lstWorks = new System.Windows.Forms.ListBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.optSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(155, 233);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 16);
            this.lblTotal.TabIndex = 27;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(75, 233);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 16);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Total Value";
            // 
            // optSort
            // 
            this.optSort.Controls.Add(this.rbByDate);
            this.optSort.Controls.Add(this.rbByName);
            this.optSort.Location = new System.Drawing.Point(99, 81);
            this.optSort.Name = "optSort";
            this.optSort.Size = new System.Drawing.Size(136, 48);
            this.optSort.TabIndex = 25;
            this.optSort.TabStop = false;
            this.optSort.Text = "Sort By";
            // 
            // rbByDate
            // 
            this.rbByDate.Location = new System.Drawing.Point(80, 16);
            this.rbByDate.Name = "rbByDate";
            this.rbByDate.Size = new System.Drawing.Size(48, 24);
            this.rbByDate.TabIndex = 1;
            this.rbByDate.Text = "Date";
            this.rbByDate.CheckedChanged += new System.EventHandler(this.rbByDate_CheckedChanged);
            // 
            // rbByName
            // 
            this.rbByName.Location = new System.Drawing.Point(8, 16);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(56, 24);
            this.rbByName.TabIndex = 0;
            this.rbByName.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(171, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 32);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(91, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 32);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 32);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(11, 121);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 16);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Works";
            // 
            // lstWorks
            // 
            this.lstWorks.Location = new System.Drawing.Point(11, 137);
            this.lstWorks.Name = "lstWorks";
            this.lstWorks.Size = new System.Drawing.Size(224, 82);
            this.lstWorks.TabIndex = 20;
            this.lstWorks.DoubleClick += new System.EventHandler(this.lstWorks_DoubleClick);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(75, 57);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 20);
            this.txtPhone.TabIndex = 19;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(11, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Contact Ph";
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Location = new System.Drawing.Point(75, 33);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.Size = new System.Drawing.Size(160, 20);
            this.txtSpeciality.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(11, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Speciality";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(11, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Name";
            // 
            // frmArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 299);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.optSort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lstWorks);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtSpeciality);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Name = "frmArtist";
            this.Text = "Artist Details";
            this.optSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox optSort;
        internal System.Windows.Forms.RadioButton rbByDate;
        internal System.Windows.Forms.RadioButton rbByName;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ListBox lstWorks;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtSpeciality;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label1;
    }
}