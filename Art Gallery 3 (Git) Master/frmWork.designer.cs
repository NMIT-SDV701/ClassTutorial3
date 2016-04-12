namespace Version_3_C
{
    partial class frmWork
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCreation = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(97, 81);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(96, 20);
            this.txtValue.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(9, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "Value  $";
            // 
            // txtCreation
            // 
            this.txtCreation.Location = new System.Drawing.Point(97, 49);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(96, 20);
            this.txtCreation.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(9, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "Creation Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 20);
            this.txtName.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(9, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(225, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 245);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtCreation);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "frmWork";
            this.Text = "frmWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtValue;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCreation;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
    }
}