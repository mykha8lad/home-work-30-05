namespace WinFormsApp1
{
    partial class Child
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
            this.textBoxChild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxChild
            // 
            this.textBoxChild.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxChild.Location = new System.Drawing.Point(70, 100);
            this.textBoxChild.Name = "textBoxChild";
            this.textBoxChild.Size = new System.Drawing.Size(340, 43);
            this.textBoxChild.TabIndex = 0;
            this.textBoxChild.TextChanged += new System.EventHandler(this.textBoxChild_TextChanged);
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.textBoxChild);
            this.Name = "Child";
            this.Text = "Child";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxChild;
    }
}