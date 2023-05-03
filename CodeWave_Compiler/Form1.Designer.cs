
namespace CodeWave
{
    partial class Compiler
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
            this.CodeWave = new System.Windows.Forms.TextBox();
            this.Errors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CodeWave
            // 
            this.CodeWave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CodeWave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeWave.ForeColor = System.Drawing.SystemColors.Window;
            this.CodeWave.Location = new System.Drawing.Point(1, 1);
            this.CodeWave.Multiline = true;
            this.CodeWave.Name = "CodeWave";
            this.CodeWave.Size = new System.Drawing.Size(391, 457);
            this.CodeWave.TabIndex = 0;
            this.CodeWave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Errors
            // 
            this.Errors.BackColor = System.Drawing.Color.Black;
            this.Errors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Errors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Errors.FormattingEnabled = true;
            this.Errors.Location = new System.Drawing.Point(399, 5);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(337, 442);
            this.Errors.TabIndex = 1;
            this.Errors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Compiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Errors);
            this.Controls.Add(this.CodeWave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compiler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeWave;
        private System.Windows.Forms.ListBox Errors;
    }
}

