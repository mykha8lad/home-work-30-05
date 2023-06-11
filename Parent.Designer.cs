namespace WinFormsApp1
{
    partial class Parent
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
            this.textBoxParent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxParent
            // 
            this.textBoxParent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxParent.Location = new System.Drawing.Point(70, 100);
            this.textBoxParent.Name = "textBoxParent";
            this.textBoxParent.Size = new System.Drawing.Size(340, 43);
            this.textBoxParent.TabIndex = 0;
            this.textBoxParent.TextChanged += new System.EventHandler(this.textBoxParent_TextChanged);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.textBoxParent);
            this.Name = "Parent";
            this.Text = "Parent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxParent;
    }
}