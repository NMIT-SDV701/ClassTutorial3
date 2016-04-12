namespace Version_3_C
{
    partial class frmPhotograph
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(97, 171);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(96, 20);
            this.txtType.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(9, 174);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(56, 23);
            this.Label6.TabIndex = 56;
            this.Label6.Text = "Type";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(97, 139);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(96, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(9, 142);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 23);
            this.Label5.TabIndex = 54;
            this.Label5.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(97, 107);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(96, 20);
            this.txtWidth.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(9, 110);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 23);
            this.Label4.TabIndex = 52;
            this.Label4.Text = "Width";
            // 
            // frmPhotograph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(363, 205);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtType);
            this.Name = "frmPhotograph";
            this.Text = "Photograph";
            this.Controls.SetChildIndex(this.txtType, 0);
            this.Controls.SetChildIndex(this.Label6, 0);
            this.Controls.SetChildIndex(this.txtHeight, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.txtWidth, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtType;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtHeight;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtWidth;
        internal System.Windows.Forms.Label Label4;
    }
}
