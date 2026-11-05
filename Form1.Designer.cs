namespace Topic_9_12___Assignment_2
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
            this.imgTemperature = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTemperature
            // 
            this.imgTemperature.Location = new System.Drawing.Point(12, 36);
            this.imgTemperature.Name = "imgTemperature";
            this.imgTemperature.Size = new System.Drawing.Size(380, 217);
            this.imgTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTemperature.TabIndex = 0;
            this.imgTemperature.TabStop = false;
            // 
            // btnTemperature
            // 
            this.btnTemperature.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperature.Location = new System.Drawing.Point(415, 198);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(150, 55);
            this.btnTemperature.TabIndex = 1;
            this.btnTemperature.Text = "Change Temperature!";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(414, 138);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(130, 21);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Enter Temperature:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(418, 162);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(147, 28);
            this.txtTemperature.TabIndex = 3;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(8, 12);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(142, 21);
            this.lblTemperature.TabIndex = 4;
            this.lblTemperature.Text = "Current Temperature:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 265);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnTemperature);
            this.Controls.Add(this.imgTemperature);
            this.Name = "Form1";
            this.Text = "Temperature";
            ((System.ComponentModel.ISupportInitialize)(this.imgTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTemperature;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblTemperature;
    }
}

