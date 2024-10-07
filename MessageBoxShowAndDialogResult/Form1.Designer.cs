
namespace MessageBoxShowAndDialogResult
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnChoice = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(14, 14);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(142, 53);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "&Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(166, 14);
            this.btnError.Margin = new System.Windows.Forms.Padding(5);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(142, 53);
            this.btnError.TabIndex = 0;
            this.btnError.Text = "&Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(318, 14);
            this.btnChoice.Margin = new System.Windows.Forms.Padding(5);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(142, 53);
            this.btnChoice.TabIndex = 0;
            this.btnChoice.Text = "&Choice";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(14, 85);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(152, 32);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "DialogResult:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 126);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "MessageBox.Show() and DialogResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Label lblResult;
    }
}

