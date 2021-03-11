
namespace Geriatric_Status
{
    partial class Analize
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
            this.GSLabel = new System.Windows.Forms.Label();
            this.RButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Гериатрический статус";
            // 
            // GSLabel
            // 
            this.GSLabel.AutoSize = true;
            this.GSLabel.Location = new System.Drawing.Point(193, 53);
            this.GSLabel.Name = "GSLabel";
            this.GSLabel.Size = new System.Drawing.Size(38, 15);
            this.GSLabel.TabIndex = 1;
            this.GSLabel.Text = "label2";
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(29, 136);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(75, 23);
            this.RButton.TabIndex = 2;
            this.RButton.Text = "Отчет";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(178, 136);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Закрыть";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Analize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 179);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.GSLabel);
            this.Controls.Add(this.label1);
            this.Name = "Analize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ";
            this.Load += new System.EventHandler(this.Analize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GSLabel;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button Exit;
    }
}