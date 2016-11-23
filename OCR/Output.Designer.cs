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
            this.matchingSamplesOutLbl = new System.Windows.Forms.Label();
            this.accuracyRateLbl = new System.Windows.Forms.Label();
            this.accuracyRateOutLbl = new System.Windows.Forms.Label();
            this.mseLbl = new System.Windows.Forms.Label();
            this.mseOutLbl = new System.Windows.Forms.Label();
            this.imageClassifyButton = new System.Windows.Forms.Button();
            this.imageBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mismatchingSamplesLbl
            // 
            this.mismatchingSamplesLbl.AutoSize = true;
            this.mismatchingSamplesLbl.Location = new System.Drawing.Point(12, 23);
            this.mismatchingSamplesLbl.Name = "mismatchingSamplesLbl";
            this.mismatchingSamplesLbl.Size = new System.Drawing.Size(112, 13);
            this.mismatchingSamplesLbl.TabIndex = 0;
            this.mismatchingSamplesLbl.Text = "Mismatching Samples:";
            // 
            // matchingSamplesOutLbl
            // 
            this.matchingSamplesOutLbl.AutoSize = true;
            this.matchingSamplesOutLbl.Location = new System.Drawing.Point(130, 23);
            this.matchingSamplesOutLbl.Name = "matchingSamplesOutLbl";
            this.matchingSamplesOutLbl.Size = new System.Drawing.Size(89, 13);
            this.matchingSamplesOutLbl.TabIndex = 1;
            this.matchingSamplesOutLbl.Text = "Output goes here";
            // 
            // accuracyRateLbl
            // 
            this.accuracyRateLbl.AutoSize = true;
            this.accuracyRateLbl.Location = new System.Drawing.Point(12, 58);
            this.accuracyRateLbl.Name = "accuracyRateLbl";
            this.accuracyRateLbl.Size = new System.Drawing.Size(81, 13);
            this.accuracyRateLbl.TabIndex = 2;
            this.accuracyRateLbl.Text = "Accuracy Rate:";
            // 
            // accuracyRateOutLbl
            // 
            this.accuracyRateOutLbl.AutoSize = true;
            this.accuracyRateOutLbl.Location = new System.Drawing.Point(130, 58);
            this.accuracyRateOutLbl.Name = "accuracyRateOutLbl";
            this.accuracyRateOutLbl.Size = new System.Drawing.Size(89, 13);
            this.accuracyRateOutLbl.TabIndex = 3;
            this.accuracyRateOutLbl.Text = "Output goes here";
            // 
            // mseLbl
            // 
            this.mseLbl.AutoSize = true;
            this.mseLbl.Location = new System.Drawing.Point(12, 91);
            this.mseLbl.Name = "mseLbl";
            this.mseLbl.Size = new System.Drawing.Size(105, 13);
            this.mseLbl.TabIndex = 4;
            this.mseLbl.Text = "Mean Squared Error:";
            // 
            // mseOutLbl
            // 
            this.mseOutLbl.AutoSize = true;
            this.mseOutLbl.Location = new System.Drawing.Point(130, 91);
            this.mseOutLbl.Name = "mseOutLbl";
            this.mseOutLbl.Size = new System.Drawing.Size(89, 13);
            this.mseOutLbl.TabIndex = 5;
            this.mseOutLbl.Text = "Output goes here";
            // 
            // imageClassifyButton
            // 
            this.imageClassifyButton.Location = new System.Drawing.Point(18, 121);
            this.imageClassifyButton.Name = "imageClassifyButton";
            this.imageClassifyButton.Size = new System.Drawing.Size(89, 23);
            this.imageClassifyButton.TabIndex = 6;
            this.imageClassifyButton.Text = "Classify Image";
            this.imageClassifyButton.UseVisualStyleBackColor = true;
            this.imageClassifyButton.Click += new System.EventHandler(this.imageClassifyButton_Click);
            // 
            // imageBrowserDialog
            // 
            this.imageBrowserDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output goes here";
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageClassifyButton);
            this.Controls.Add(this.mseOutLbl);
            this.Controls.Add(this.mseLbl);
            this.Controls.Add(this.accuracyRateOutLbl);
            this.Controls.Add(this.accuracyRateLbl);
            this.Controls.Add(this.matchingSamplesOutLbl);
            this.Controls.Add(this.mismatchingSamplesLbl);
            this.Name = "Output";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mismatchingSamplesLbl;
        private System.Windows.Forms.Label matchingSamplesOutLbl;
        private System.Windows.Forms.Label accuracyRateLbl;
        private System.Windows.Forms.Label accuracyRateOutLbl;
        private System.Windows.Forms.Label mseLbl;
        private System.Windows.Forms.Label mseOutLbl;
        private System.Windows.Forms.Button imageClassifyButton;
        private System.Windows.Forms.OpenFileDialog imageBrowserDialog;
        private System.Windows.Forms.Label label1;
    }
}