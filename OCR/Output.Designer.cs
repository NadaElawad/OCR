namespace OCR
{
    partial class Output
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
            this.mismatchingSamplesLbl = new System.Windows.Forms.Label();
            this.mismatchingSamplesOutLbl = new System.Windows.Forms.Label();
            this.accuracyRateLbl = new System.Windows.Forms.Label();
            this.accuracyRateOutLbl = new System.Windows.Forms.Label();
            this.mseLbl = new System.Windows.Forms.Label();
            this.mseOutLbl = new System.Windows.Forms.Label();
            this.imageClassifyButton = new System.Windows.Forms.Button();
            this.imageBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.classifiedPattern = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mismatchingSamplesLbl
            // 
            this.mismatchingSamplesLbl.AutoSize = true;
            this.mismatchingSamplesLbl.Location = new System.Drawing.Point(15, 44);
            this.mismatchingSamplesLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mismatchingSamplesLbl.Name = "mismatchingSamplesLbl";
            this.mismatchingSamplesLbl.Size = new System.Drawing.Size(228, 25);
            this.mismatchingSamplesLbl.TabIndex = 0;
            this.mismatchingSamplesLbl.Text = "Mismatching Samples:";
            // 
            // mismatchingSamplesOutLbl
            // 
            this.mismatchingSamplesOutLbl.AutoSize = true;
            this.mismatchingSamplesOutLbl.Location = new System.Drawing.Point(260, 44);
            this.mismatchingSamplesOutLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mismatchingSamplesOutLbl.Name = "mismatchingSamplesOutLbl";
            this.mismatchingSamplesOutLbl.Size = new System.Drawing.Size(0, 25);
            this.mismatchingSamplesOutLbl.TabIndex = 1;
            // 
            // accuracyRateLbl
            // 
            this.accuracyRateLbl.AutoSize = true;
            this.accuracyRateLbl.Location = new System.Drawing.Point(15, 98);
            this.accuracyRateLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.accuracyRateLbl.Name = "accuracyRateLbl";
            this.accuracyRateLbl.Size = new System.Drawing.Size(158, 25);
            this.accuracyRateLbl.TabIndex = 2;
            this.accuracyRateLbl.Text = "Accuracy Rate:";
            // 
            // accuracyRateOutLbl
            // 
            this.accuracyRateOutLbl.AutoSize = true;
            this.accuracyRateOutLbl.Location = new System.Drawing.Point(260, 98);
            this.accuracyRateOutLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.accuracyRateOutLbl.Name = "accuracyRateOutLbl";
            this.accuracyRateOutLbl.Size = new System.Drawing.Size(0, 25);
            this.accuracyRateOutLbl.TabIndex = 3;
            // 
            // mseLbl
            // 
            this.mseLbl.AutoSize = true;
            this.mseLbl.Location = new System.Drawing.Point(15, 147);
            this.mseLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mseLbl.Name = "mseLbl";
            this.mseLbl.Size = new System.Drawing.Size(212, 25);
            this.mseLbl.TabIndex = 4;
            this.mseLbl.Text = "Mean Squared Error:";
            // 
            // mseOutLbl
            // 
            this.mseOutLbl.AutoSize = true;
            this.mseOutLbl.Location = new System.Drawing.Point(260, 147);
            this.mseOutLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mseOutLbl.Name = "mseOutLbl";
            this.mseOutLbl.Size = new System.Drawing.Size(0, 25);
            this.mseOutLbl.TabIndex = 5;
            // 
            // imageClassifyButton
            // 
            this.imageClassifyButton.Location = new System.Drawing.Point(20, 223);
            this.imageClassifyButton.Margin = new System.Windows.Forms.Padding(6);
            this.imageClassifyButton.Name = "imageClassifyButton";
            this.imageClassifyButton.Size = new System.Drawing.Size(178, 44);
            this.imageClassifyButton.TabIndex = 6;
            this.imageClassifyButton.Text = "Classify Image";
            this.imageClassifyButton.UseVisualStyleBackColor = true;
            this.imageClassifyButton.Click += new System.EventHandler(this.imageClassifyButton_Click);
            // 
            // imageBrowserDialog
            // 
            this.imageBrowserDialog.FileName = "openFileDialog1";
            // 
            // classifiedPattern
            // 
            this.classifiedPattern.AutoSize = true;
            this.classifiedPattern.Location = new System.Drawing.Point(260, 233);
            this.classifiedPattern.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.classifiedPattern.Name = "classifiedPattern";
            this.classifiedPattern.Size = new System.Drawing.Size(0, 25);
            this.classifiedPattern.TabIndex = 7;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 341);
            this.Controls.Add(this.classifiedPattern);
            this.Controls.Add(this.imageClassifyButton);
            this.Controls.Add(this.mseOutLbl);
            this.Controls.Add(this.mseLbl);
            this.Controls.Add(this.accuracyRateOutLbl);
            this.Controls.Add(this.accuracyRateLbl);
            this.Controls.Add(this.mismatchingSamplesOutLbl);
            this.Controls.Add(this.mismatchingSamplesLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Output";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mismatchingSamplesLbl;
        private System.Windows.Forms.Label mismatchingSamplesOutLbl;
        private System.Windows.Forms.Label accuracyRateLbl;
        private System.Windows.Forms.Label accuracyRateOutLbl;
        private System.Windows.Forms.Label mseLbl;
        private System.Windows.Forms.Label mseOutLbl;
        private System.Windows.Forms.Button imageClassifyButton;
        private System.Windows.Forms.OpenFileDialog imageBrowserDialog;
        private System.Windows.Forms.Label classifiedPattern;
    }
}