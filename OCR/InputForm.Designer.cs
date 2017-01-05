namespace OCR
{
    partial class InputForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hiddenLayerLbl = new System.Windows.Forms.Label();
            this.hiddenLayerTxt = new System.Windows.Forms.TextBox();
            this.neuronsPerLayerLbl = new System.Windows.Forms.Label();
            this.activationFunctionCmbx = new System.Windows.Forms.ComboBox();
            this.valALbl = new System.Windows.Forms.Label();
            this.valATxt = new System.Windows.Forms.TextBox();
            this.learningRateLbl = new System.Windows.Forms.Label();
            this.learningRateTxt = new System.Windows.Forms.TextBox();
            this.errorRateLbl = new System.Windows.Forms.Label();
            this.errorThresholdTxt = new System.Windows.Forms.TextBox();
            this.trainButton = new System.Windows.Forms.Button();
            this.neuronsPerLayerGridView = new System.Windows.Forms.DataGridView();
            this.neuronsPerLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layersInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.activationFunctionLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcaAlphaTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPCTxtBox = new System.Windows.Forms.TextBox();
            this.numEpochsTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcaCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.neuronsPerLayerGridView)).BeginInit();
            this.layersInformationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiddenLayerLbl
            // 
            this.hiddenLayerLbl.AutoSize = true;
            this.hiddenLayerLbl.Location = new System.Drawing.Point(14, 33);
            this.hiddenLayerLbl.Name = "hiddenLayerLbl";
            this.hiddenLayerLbl.Size = new System.Drawing.Size(78, 13);
            this.hiddenLayerLbl.TabIndex = 0;
            this.hiddenLayerLbl.Text = "Hidden Layers:";
            // 
            // hiddenLayerTxt
            // 
            this.hiddenLayerTxt.Location = new System.Drawing.Point(160, 31);
            this.hiddenLayerTxt.Name = "hiddenLayerTxt";
            this.hiddenLayerTxt.Size = new System.Drawing.Size(69, 20);
            this.hiddenLayerTxt.TabIndex = 1;
            this.hiddenLayerTxt.Text = "1";
            // 
            // neuronsPerLayerLbl
            // 
            this.neuronsPerLayerLbl.AutoSize = true;
            this.neuronsPerLayerLbl.Location = new System.Drawing.Point(14, 56);
            this.neuronsPerLayerLbl.Name = "neuronsPerLayerLbl";
            this.neuronsPerLayerLbl.Size = new System.Drawing.Size(119, 13);
            this.neuronsPerLayerLbl.TabIndex = 2;
            this.neuronsPerLayerLbl.Text = "No. of Neurons / Layer:";
            // 
            // activationFunctionCmbx
            // 
            this.activationFunctionCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activationFunctionCmbx.Items.AddRange(new object[] {
            "Sigmoid",
            "Tanh"});
            this.activationFunctionCmbx.Location = new System.Drawing.Point(114, 30);
            this.activationFunctionCmbx.Name = "activationFunctionCmbx";
            this.activationFunctionCmbx.Size = new System.Drawing.Size(79, 21);
            this.activationFunctionCmbx.TabIndex = 14;
            this.activationFunctionCmbx.SelectedIndexChanged += new System.EventHandler(this.activationFunctionCmbx_SelectedIndexChanged);
            // 
            // valALbl
            // 
            this.valALbl.AutoSize = true;
            this.valALbl.Location = new System.Drawing.Point(8, 63);
            this.valALbl.Name = "valALbl";
            this.valALbl.Size = new System.Drawing.Size(37, 13);
            this.valALbl.TabIndex = 7;
            this.valALbl.Text = "Slope:";
            // 
            // valATxt
            // 
            this.valATxt.Location = new System.Drawing.Point(114, 60);
            this.valATxt.Name = "valATxt";
            this.valATxt.Size = new System.Drawing.Size(69, 20);
            this.valATxt.TabIndex = 8;
            this.valATxt.Text = "1";
            // 
            // learningRateLbl
            // 
            this.learningRateLbl.AutoSize = true;
            this.learningRateLbl.Location = new System.Drawing.Point(8, 86);
            this.learningRateLbl.Name = "learningRateLbl";
            this.learningRateLbl.Size = new System.Drawing.Size(77, 13);
            this.learningRateLbl.TabIndex = 9;
            this.learningRateLbl.Text = "Learning Rate:";
            // 
            // learningRateTxt
            // 
            this.learningRateTxt.Location = new System.Drawing.Point(114, 83);
            this.learningRateTxt.Name = "learningRateTxt";
            this.learningRateTxt.Size = new System.Drawing.Size(69, 20);
            this.learningRateTxt.TabIndex = 10;
            this.learningRateTxt.Text = "0.6";
            // 
            // errorRateLbl
            // 
            this.errorRateLbl.AutoSize = true;
            this.errorRateLbl.Location = new System.Drawing.Point(8, 108);
            this.errorRateLbl.Name = "errorRateLbl";
            this.errorRateLbl.Size = new System.Drawing.Size(82, 13);
            this.errorRateLbl.TabIndex = 11;
            this.errorRateLbl.Text = "Error Threshold:";
            // 
            // errorThresholdTxt
            // 
            this.errorThresholdTxt.Location = new System.Drawing.Point(114, 105);
            this.errorThresholdTxt.Name = "errorThresholdTxt";
            this.errorThresholdTxt.Size = new System.Drawing.Size(69, 20);
            this.errorThresholdTxt.TabIndex = 12;
            this.errorThresholdTxt.Text = "0.4";
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(652, 209);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(98, 42);
            this.trainButton.TabIndex = 13;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // neuronsPerLayerGridView
            // 
            this.neuronsPerLayerGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.neuronsPerLayerGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.neuronsPerLayerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.neuronsPerLayerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.neuronsPerLayer});
            this.neuronsPerLayerGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.neuronsPerLayerGridView.Location = new System.Drawing.Point(160, 53);
            this.neuronsPerLayerGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.neuronsPerLayerGridView.Name = "neuronsPerLayerGridView";
            this.neuronsPerLayerGridView.RowTemplate.Height = 33;
            this.neuronsPerLayerGridView.Size = new System.Drawing.Size(128, 122);
            this.neuronsPerLayerGridView.TabIndex = 15;
            // 
            // neuronsPerLayer
            // 
            this.neuronsPerLayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.neuronsPerLayer.DefaultCellStyle = dataGridViewCellStyle1;
            this.neuronsPerLayer.HeaderText = "#Neurons/Layer";
            this.neuronsPerLayer.Name = "neuronsPerLayer";
            this.neuronsPerLayer.Width = 110;
            // 
            // layersInformationGroupBox
            // 
            this.layersInformationGroupBox.Controls.Add(this.neuronsPerLayerGridView);
            this.layersInformationGroupBox.Controls.Add(this.neuronsPerLayerLbl);
            this.layersInformationGroupBox.Controls.Add(this.hiddenLayerTxt);
            this.layersInformationGroupBox.Controls.Add(this.hiddenLayerLbl);
            this.layersInformationGroupBox.Location = new System.Drawing.Point(10, 21);
            this.layersInformationGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layersInformationGroupBox.Name = "layersInformationGroupBox";
            this.layersInformationGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layersInformationGroupBox.Size = new System.Drawing.Size(296, 183);
            this.layersInformationGroupBox.TabIndex = 16;
            this.layersInformationGroupBox.TabStop = false;
            this.layersInformationGroupBox.Text = "Layer\'s Information";
            // 
            // activationFunctionLbl
            // 
            this.activationFunctionLbl.AutoSize = true;
            this.activationFunctionLbl.Location = new System.Drawing.Point(8, 31);
            this.activationFunctionLbl.Name = "activationFunctionLbl";
            this.activationFunctionLbl.Size = new System.Drawing.Size(101, 13);
            this.activationFunctionLbl.TabIndex = 5;
            this.activationFunctionLbl.Text = "Activation Function:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcaAlphaTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numPCTxtBox);
            this.groupBox1.Controls.Add(this.numEpochsTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pcaCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(514, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(236, 183);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PCA Data Reduction";
            // 
            // pcaAlphaTxtBox
            // 
            this.pcaAlphaTxtBox.Location = new System.Drawing.Point(158, 103);
            this.pcaAlphaTxtBox.Name = "pcaAlphaTxtBox";
            this.pcaAlphaTxtBox.Size = new System.Drawing.Size(69, 20);
            this.pcaAlphaTxtBox.TabIndex = 16;
            this.pcaAlphaTxtBox.Text = "0.01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Learning Rate:";
            // 
            // numPCTxtBox
            // 
            this.numPCTxtBox.Location = new System.Drawing.Point(158, 81);
            this.numPCTxtBox.Name = "numPCTxtBox";
            this.numPCTxtBox.Size = new System.Drawing.Size(69, 20);
            this.numPCTxtBox.TabIndex = 16;
            this.numPCTxtBox.Text = "1";
            // 
            // numEpochsTxtBox
            // 
            this.numEpochsTxtBox.Location = new System.Drawing.Point(158, 58);
            this.numEpochsTxtBox.Name = "numEpochsTxtBox";
            this.numEpochsTxtBox.Size = new System.Drawing.Size(69, 20);
            this.numEpochsTxtBox.TabIndex = 15;
            this.numEpochsTxtBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. of Principal Components:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. of Epochs:";
            // 
            // pcaCheckBox
            // 
            this.pcaCheckBox.AutoSize = true;
            this.pcaCheckBox.Location = new System.Drawing.Point(10, 31);
            this.pcaCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcaCheckBox.Name = "pcaCheckBox";
            this.pcaCheckBox.Size = new System.Drawing.Size(76, 17);
            this.pcaCheckBox.TabIndex = 0;
            this.pcaCheckBox.Text = "Apply PCA";
            this.pcaCheckBox.UseVisualStyleBackColor = true;
            this.pcaCheckBox.CheckedChanged += new System.EventHandler(this.pcaCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.errorThresholdTxt);
            this.groupBox2.Controls.Add(this.errorRateLbl);
            this.groupBox2.Controls.Add(this.learningRateTxt);
            this.groupBox2.Controls.Add(this.learningRateLbl);
            this.groupBox2.Controls.Add(this.valATxt);
            this.groupBox2.Controls.Add(this.valALbl);
            this.groupBox2.Controls.Add(this.activationFunctionCmbx);
            this.groupBox2.Controls.Add(this.activationFunctionLbl);
            this.groupBox2.Location = new System.Drawing.Point(310, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(201, 183);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Learning Parameters";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(681, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.layersInformationGroupBox);
            this.Controls.Add(this.trainButton);
            this.Name = "InputForm";
            this.Text = "Input Form";
            ((System.ComponentModel.ISupportInitialize)(this.neuronsPerLayerGridView)).EndInit();
            this.layersInformationGroupBox.ResumeLayout(false);
            this.layersInformationGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hiddenLayerLbl;
        private System.Windows.Forms.TextBox hiddenLayerTxt;
        private System.Windows.Forms.Label neuronsPerLayerLbl;
        private System.Windows.Forms.ComboBox activationFunctionCmbx;
        private System.Windows.Forms.Label valALbl;
        private System.Windows.Forms.TextBox valATxt;
        private System.Windows.Forms.Label learningRateLbl;
        private System.Windows.Forms.TextBox learningRateTxt;
        private System.Windows.Forms.Label errorRateLbl;
        private System.Windows.Forms.TextBox errorThresholdTxt;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.DataGridView neuronsPerLayerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn neuronsPerLayer;
        private System.Windows.Forms.GroupBox layersInformationGroupBox;
        private System.Windows.Forms.Label activationFunctionLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox numPCTxtBox;
        private System.Windows.Forms.TextBox numEpochsTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pcaCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pcaAlphaTxtBox;
        private System.Windows.Forms.Label label3;
    }
}

