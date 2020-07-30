namespace C_sharp_forms
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.Instance_Hello_Everybody = new System.Windows.Forms.Button();
            this.Instance_Variebal_String = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(124, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programing C # Language Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Instance_Hello_Everybody
            // 
            this.Instance_Hello_Everybody.BackColor = System.Drawing.Color.Red;
            this.Instance_Hello_Everybody.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Instance_Hello_Everybody.Location = new System.Drawing.Point(98, 152);
            this.Instance_Hello_Everybody.Name = "Instance_Hello_Everybody";
            this.Instance_Hello_Everybody.Size = new System.Drawing.Size(200, 97);
            this.Instance_Hello_Everybody.TabIndex = 1;
            this.Instance_Hello_Everybody.Text = "Hello Everybody";
            this.Instance_Hello_Everybody.UseVisualStyleBackColor = false;
            // 
            // Instance_Variebal_String
            // 
            this.Instance_Variebal_String.BackColor = System.Drawing.Color.Yellow;
            this.Instance_Variebal_String.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Instance_Variebal_String.Location = new System.Drawing.Point(373, 152);
            this.Instance_Variebal_String.Name = "Instance_Variebal_String";
            this.Instance_Variebal_String.Size = new System.Drawing.Size(226, 97);
            this.Instance_Variebal_String.TabIndex = 2;
            this.Instance_Variebal_String.Text = "Variebal String";
            this.Instance_Variebal_String.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 572);
            this.Controls.Add(this.Instance_Variebal_String);
            this.Controls.Add(this.Instance_Hello_Everybody);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Instance_Hello_Everybody;
        private System.Windows.Forms.Button Instance_Variebal_String;
    }
}