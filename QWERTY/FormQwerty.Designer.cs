namespace QWERTY
{
    partial class FormQwerty
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
            this.BtnTranslate = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTranslate
            // 
            this.BtnTranslate.Location = new System.Drawing.Point(49, 57);
            this.BtnTranslate.Name = "BtnTranslate";
            this.BtnTranslate.Size = new System.Drawing.Size(182, 68);
            this.BtnTranslate.TabIndex = 0;
            this.BtnTranslate.Text = "Translate";
            this.BtnTranslate.UseVisualStyleBackColor = true;
            this.BtnTranslate.Click += new System.EventHandler(this.BtnTranslate_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(304, 57);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(410, 339);
            this.TxtResult.TabIndex = 1;
            // 
            // FormQwerty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnTranslate);
            this.Name = "FormQwerty";
            this.Text = "Qwerty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTranslate;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

