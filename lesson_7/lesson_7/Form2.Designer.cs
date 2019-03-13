namespace lesson_7
{
    partial class Form2
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
            this.btnStart1 = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblGame1 = new System.Windows.Forms.Label();
            this.lblGame2 = new System.Windows.Forms.Label();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(228, 262);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(75, 23);
            this.btnStart1.TabIndex = 0;
            this.btnStart1.Text = "button1";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart_1);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.Location = new System.Drawing.Point(295, 41);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(118, 42);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "label1";
            // 
            // lblGame1
            // 
            this.lblGame1.AutoSize = true;
            this.lblGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGame1.Location = new System.Drawing.Point(156, 153);
            this.lblGame1.Name = "lblGame1";
            this.lblGame1.Size = new System.Drawing.Size(79, 29);
            this.lblGame1.TabIndex = 2;
            this.lblGame1.Text = "label2";
            // 
            // lblGame2
            // 
            this.lblGame2.AutoSize = true;
            this.lblGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGame2.Location = new System.Drawing.Point(485, 153);
            this.lblGame2.Name = "lblGame2";
            this.lblGame2.Size = new System.Drawing.Size(79, 29);
            this.lblGame2.TabIndex = 3;
            this.lblGame2.Text = "label3";
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(558, 262);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(75, 23);
            this.btnStart2.TabIndex = 4;
            this.btnStart2.Text = "button2";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart_2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.lblGame2);
            this.Controls.Add(this.lblGame1);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnStart1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblGame1;
        private System.Windows.Forms.Label lblGame2;
        private System.Windows.Forms.Button btnStart2;
    }
}