namespace C_sharp_forms
{
    partial class Hello_Everybody
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
            this.Instant_Input = new System.Windows.Forms.TextBox();
            this.Instance_Submit = new System.Windows.Forms.Button();
            this.Instance_Show_Hello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frist And Last Name ";
            // 
            // Instant_Input
            // 
            this.Instant_Input.Location = new System.Drawing.Point(67, 122);
            this.Instant_Input.Multiline = true;
            this.Instant_Input.Name = "Instant_Input";
            this.Instant_Input.Size = new System.Drawing.Size(217, 62);
            this.Instant_Input.TabIndex = 1;
            // 
            // Instance_Submit
            // 
            this.Instance_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Instance_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instance_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Instance_Submit.Location = new System.Drawing.Point(67, 231);
            this.Instance_Submit.Name = "Instance_Submit";
            this.Instance_Submit.Size = new System.Drawing.Size(103, 57);
            this.Instance_Submit.TabIndex = 2;
            this.Instance_Submit.Text = "Submit";
            this.Instance_Submit.UseVisualStyleBackColor = false;
            this.Instance_Submit.Click += new System.EventHandler(this.Instance_Submit_Click);
            // 
            // Instance_Show_Hello
            // 
            this.Instance_Show_Hello.AutoSize = true;
            this.Instance_Show_Hello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Instance_Show_Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instance_Show_Hello.ForeColor = System.Drawing.Color.OrangeRed;
            this.Instance_Show_Hello.Location = new System.Drawing.Point(207, 344);
            this.Instance_Show_Hello.Name = "Instance_Show_Hello";
            this.Instance_Show_Hello.Size = new System.Drawing.Size(400, 54);
            this.Instance_Show_Hello.TabIndex = 3;
            this.Instance_Show_Hello.Text = "Hello everybody !!!";
            this.Instance_Show_Hello.Click += new System.EventHandler(this.Instance_Show_Hello_Click);
            // 
            // Hello_Everybody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.Instance_Show_Hello);
            this.Controls.Add(this.Instance_Submit);
            this.Controls.Add(this.Instant_Input);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Hello_Everybody";
            this.Text = "Hello Everybody";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Instant_Input;
        private System.Windows.Forms.Button Instance_Submit;
        private System.Windows.Forms.Label Instance_Show_Hello;
    }
}

