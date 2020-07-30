namespace C_sharp_forms
{
    partial class Variebal_String
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
            this.Instance_Show_Variebal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Instance_Show_Variebal
            // 
            this.Instance_Show_Variebal.AutoSize = true;
            this.Instance_Show_Variebal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instance_Show_Variebal.ForeColor = System.Drawing.Color.Blue;
            this.Instance_Show_Variebal.Location = new System.Drawing.Point(241, 175);
            this.Instance_Show_Variebal.Name = "Instance_Show_Variebal";
            this.Instance_Show_Variebal.Size = new System.Drawing.Size(126, 44);
            this.Instance_Show_Variebal.TabIndex = 0;
            this.Instance_Show_Variebal.Text = "label1";
            this.Instance_Show_Variebal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Variebal_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1116, 1421);
            this.Controls.Add(this.Instance_Show_Variebal);
            this.Name = "Variebal_String";
            this.Text = "Variebal_String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instance_Show_Variebal;
    }
}