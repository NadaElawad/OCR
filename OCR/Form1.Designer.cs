namespace OCR
{
    partial class inputForm
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
            this.hiddenLayerLbl = new System.Windows.Forms.Label();
            this.hiddenLayerTxt = new System.Windows.Forms.TextBox();
            this.neuronsPerLayerLbl = new System.Windows.Forms.Label();
            this.neuronsPerLayerTxt = new System.Windows.Forms.TextBox();
            this.layerInfoLbl = new System.Windows.Forms.Label();
            this.activationFunctionLbl = new System.Windows.Forms.Label();
            this.activationFunctionCmbx = new System.Windows.Forms.ComboBox();
            this.valALbl = new System.Windows.Forms.Label();
            this.valATxt = new System.Windows.Forms.TextBox();
            this.learningRateLbl = new System.Windows.Forms.Label();
            this.learningRateTxt = new System.Windows.Forms.TextBox();
            this.errorRateLbl = new System.Windows.Forms.Label();
            this.errorThresholdTxt = new System.Windows.Forms.TextBox();
            this.trainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hiddenLayerLbl
            // 
            this.hiddenLayerLbl.AutoSize = true;
            this.hiddenLayerLbl.Location = new System.Drawing.Point(51, 50);
            this.hiddenLayerLbl.Name = "hiddenLayerLbl";
            this.hiddenLayerLbl.Size = new System.Drawing.Size(78, 13);
            this.hiddenLayerLbl.TabIndex = 0;
            this.hiddenLayerLbl.Text = "Hidden Layers:";
            // 
            // hiddenLayerTxt
            // 
            this.hiddenLayerTxt.Location = new System.Drawing.Point(185, 47);
            this.hiddenLayerTxt.Name = "hiddenLayerTxt";
            this.hiddenLayerTxt.Size = new System.Drawing.Size(100, 20);
            this.hiddenLayerTxt.TabIndex = 1;
            // 
            // neuronsPerLayerLbl
            // 
            this.neuronsPerLayerLbl.AutoSize = true;
            this.neuronsPerLayerLbl.Location = new System.Drawing.Point(51, 82);
            this.neuronsPerLayerLbl.Name = "neuronsPerLayerLbl";
            this.neuronsPerLayerLbl.Size = new System.Drawing.Size(119, 13);
            this.neuronsPerLayerLbl.TabIndex = 2;
            this.neuronsPerLayerLbl.Text = "No. of Neurons / Layer:";
            // 
            // neuronsPerLayerTxt
            // 
            this.neuronsPerLayerTxt.Location = new System.Drawing.Point(185, 79);
            this.neuronsPerLayerTxt.Name = "neuronsPerLayerTxt";
            this.neuronsPerLayerTxt.Size = new System.Drawing.Size(100, 20);
            this.neuronsPerLayerTxt.TabIndex = 3;
            // 
            // layerInfoLbl
            // 
            this.layerInfoLbl.AutoSize = true;
            this.layerInfoLbl.Location = new System.Drawing.Point(12, 21);
            this.layerInfoLbl.Name = "layerInfoLbl";
            this.layerInfoLbl.Size = new System.Drawing.Size(91, 13);
            this.layerInfoLbl.TabIndex = 4;
            this.layerInfoLbl.Text = "Layer Information:";
            // 
            // activationFunctionLbl
            // 
            this.activationFunctionLbl.AutoSize = true;
            this.activationFunctionLbl.Location = new System.Drawing.Point(12, 118);
            this.activationFunctionLbl.Name = "activationFunctionLbl";
            this.activationFunctionLbl.Size = new System.Drawing.Size(101, 13);
            this.activationFunctionLbl.TabIndex = 5;
            this.activationFunctionLbl.Text = "Activation Function:";
            // 
            // activationFunctionCmbx
            // 
            this.activationFunctionCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activationFunctionCmbx.Items.AddRange(new object[] {
            "Sigmoid",
            "Tanh"});
            this.activationFunctionCmbx.Location = new System.Drawing.Point(119, 114);
            this.activationFunctionCmbx.Name = "activationFunctionCmbx";
            this.activationFunctionCmbx.Size = new System.Drawing.Size(121, 21);
            this.activationFunctionCmbx.TabIndex = 14;
            this.activationFunctionCmbx.SelectedIndexChanged += new System.EventHandler(this.activationFunctionCmbx_SelectedIndexChanged);
            // 
            // valALbl
            // 
            this.valALbl.AutoSize = true;
            this.valALbl.Location = new System.Drawing.Point(262, 118);
            this.valALbl.Name = "valALbl";
            this.valALbl.Size = new System.Drawing.Size(46, 13);
            this.valALbl.TabIndex = 7;
            this.valALbl.Text = "Val of a:";
            // 
            // valATxt
            // 
            this.valATxt.Location = new System.Drawing.Point(315, 115);
            this.valATxt.Name = "valATxt";
            this.valATxt.Size = new System.Drawing.Size(63, 20);
            this.valATxt.TabIndex = 8;
            // 
            // learningRateLbl
            // 
            this.learningRateLbl.AutoSize = true;
            this.learningRateLbl.Location = new System.Drawing.Point(12, 159);
            this.learningRateLbl.Name = "learningRateLbl";
            this.learningRateLbl.Size = new System.Drawing.Size(77, 13);
            this.learningRateLbl.TabIndex = 9;
            this.learningRateLbl.Text = "Learning Rate:";
            // 
            // learningRateTxt
            // 
            this.learningRateTxt.Location = new System.Drawing.Point(110, 156);
            this.learningRateTxt.Name = "learningRateTxt";
            this.learningRateTxt.Size = new System.Drawing.Size(100, 20);
            this.learningRateTxt.TabIndex = 10;
            // 
            // errorRateLbl
            // 
            this.errorRateLbl.AutoSize = true;
            this.errorRateLbl.Location = new System.Drawing.Point(12, 196);
            this.errorRateLbl.Name = "errorRateLbl";
            this.errorRateLbl.Size = new System.Drawing.Size(82, 13);
            this.errorRateLbl.TabIndex = 11;
            this.errorRateLbl.Text = "Error Threshold:";
            // 
            // errorThresholdTxt
            // 
            this.errorThresholdTxt.Location = new System.Drawing.Point(110, 193);
            this.errorThresholdTxt.Name = "errorThresholdTxt";
            this.errorThresholdTxt.Size = new System.Drawing.Size(100, 20);
            this.errorThresholdTxt.TabIndex = 12;
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(315, 216);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(75, 23);
            this.trainButton.TabIndex = 13;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // inputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 260);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.errorThresholdTxt);
            this.Controls.Add(this.errorRateLbl);
            this.Controls.Add(this.learningRateTxt);
            this.Controls.Add(this.learningRateLbl);
            this.Controls.Add(this.valATxt);
            this.Controls.Add(this.valALbl);
            this.Controls.Add(this.activationFunctionCmbx);
            this.Controls.Add(this.activationFunctionLbl);
            this.Controls.Add(this.layerInfoLbl);
            this.Controls.Add(this.neuronsPerLayerTxt);
            this.Controls.Add(this.neuronsPerLayerLbl);
            this.Controls.Add(this.hiddenLayerTxt);
            this.Controls.Add(this.hiddenLayerLbl);
            this.Name = "inputForm";
            this.Text = "Input Form";
            this.Load += new System.EventHandler(this.inputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hiddenLayerLbl;
        private System.Windows.Forms.TextBox hiddenLayerTxt;
        private System.Windows.Forms.Label neuronsPerLayerLbl;
        private System.Windows.Forms.TextBox neuronsPerLayerTxt;
        private System.Windows.Forms.Label layerInfoLbl;
        private System.Windows.Forms.Label activationFunctionLbl;
        private System.Windows.Forms.ComboBox activationFunctionCmbx;
        private System.Windows.Forms.Label valALbl;
        private System.Windows.Forms.TextBox valATxt;
        private System.Windows.Forms.Label learningRateLbl;
        private System.Windows.Forms.TextBox learningRateTxt;
        private System.Windows.Forms.Label errorRateLbl;
        private System.Windows.Forms.TextBox errorThresholdTxt;
        private System.Windows.Forms.Button trainButton;
    }
}

