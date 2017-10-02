namespace MegaDesk_3_MarcoMorley1
{
    partial class ViewAllQuotes
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
            this.components = new System.ComponentModel.Container();
            this.rUSHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rUSHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rUSHBindingSource
            // 
            this.rUSHBindingSource.DataSource = typeof(MegaDesk_3_MarcoMorley1.DeskQuote.RUSH);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(-1, -3);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(484, 465);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.richTextBox);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.rUSHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource rUSHBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}