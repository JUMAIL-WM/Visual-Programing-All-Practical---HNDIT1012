namespace Activity_01
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnumber1 = new System.Windows.Forms.TextBox();
            this.textBoxnumber2 = new System.Windows.Forms.TextBox();
            this.buttonClick = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER YOUR NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER YOUR AGE :";
            // 
            // textBoxnumber1
            // 
            this.textBoxnumber1.Location = new System.Drawing.Point(315, 83);
            this.textBoxnumber1.Name = "textBoxnumber1";
            this.textBoxnumber1.Size = new System.Drawing.Size(181, 22);
            this.textBoxnumber1.TabIndex = 2;
            // 
            // textBoxnumber2
            // 
            this.textBoxnumber2.Location = new System.Drawing.Point(315, 139);
            this.textBoxnumber2.Name = "textBoxnumber2";
            this.textBoxnumber2.Size = new System.Drawing.Size(181, 22);
            this.textBoxnumber2.TabIndex = 3;
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(315, 211);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(184, 56);
            this.buttonClick.TabIndex = 4;
            this.buttonClick.Text = "CLICK";
            this.buttonClick.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(282, 339);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 34);
            this.labelResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.textBoxnumber2);
            this.Controls.Add(this.textBoxnumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnumber1;
        private System.Windows.Forms.TextBox textBoxnumber2;
        private System.Windows.Forms.Button buttonClick;
        private System.Windows.Forms.Label labelResult;
    }
}

