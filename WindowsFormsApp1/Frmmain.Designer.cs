
namespace WindowsFormsApp1
{
    partial class Frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmain));
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblTextField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.BackColor = System.Drawing.Color.Lime;
            this.btnClickMe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClickMe.BackgroundImage")));
            this.btnClickMe.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClickMe.Location = new System.Drawing.Point(40, 105);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(819, 505);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Ryan Gosling gomb";
            this.btnClickMe.UseVisualStyleBackColor = false;
            this.btnClickMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTextField
            // 
            this.lblTextField.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextField.Location = new System.Drawing.Point(40, 28);
            this.lblTextField.Name = "lblTextField";
            this.lblTextField.Size = new System.Drawing.Size(819, 74);
            this.lblTextField.TabIndex = 1;
            this.lblTextField.Text = "##Place Holder##";
            this.lblTextField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTextField.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 762);
            this.Controls.Add(this.lblTextField);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Frmmain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblTextField;
    }
}

