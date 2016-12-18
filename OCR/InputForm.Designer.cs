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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.hiddenLayerLbl.Location = new System.Drawing.Point(29, 63);
            this.hiddenLayerLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hiddenLayerLbl.Name = "hiddenLayerLbl";
            this.hiddenLayerLbl.Size = new System.Drawing.Size(157, 25);
            this.hiddenLayerLbl.TabIndex = 0;
            this.hiddenLayerLbl.Text = "Hidden Layers:";
            // 
            // hiddenLayerTxt
            // 
            this.hiddenLayerTxt.Location = new System.Drawing.Point(321, 60);
            this.hiddenLayerTxt.Margin = new System.Windows.Forms.Padding(6);
            this.hiddenLayerTxt.Name = "hiddenLayerTxt";
            this.hiddenLayerTxt.Size = new System.Drawing.Size(134, 31);
            this.hiddenLayerTxt.TabIndex = 1;
            this.hiddenLayerTxt.Text = "1";
            // 
            // neuronsPerLayerLbl
            // 
            this.neuronsPerLayerLbl.AutoSize = true;
            this.neuronsPerLayerLbl.Location = new System.Drawing.Point(29, 108);
            this.neuronsPerLayerLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.neuronsPerLayerLbl.Name = "neuronsPerLayerLbl";
            this.neuronsPerLayerLbl.Size = new System.Drawing.Size(234, 25);
            this.neuronsPerLayerLbl.TabIndex = 2;
            this.neuronsPerLayerLbl.Text = "No. of Neurons / Layer:";
            // 
            // activationFunctionCmbx
            // 
            this.activationFunctionCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activationFunctionCmbx.Items.AddRange(new object[] {
            "Sigmoid",
            "Tanh"});
            this.activationFunctionCmbx.Location = new System.Drawing.Point(228, 58);
            this.activationFunctionCmbx.Margin = new System.Windows.Forms.Padding(6);
            this.activationFunctionCmbx.Name = "activationFunctionCmbx";
            this.activationFunctionCmbx.Size = new System.Drawing.Size(154, 33);
            this.activationFunctionCmbx.TabIndex = 14;
            this.activationFunctionCmbx.SelectedIndexChanged += new System.EventHandler(this.activationFunctionCmbx_SelectedIndexChanged);
            // 
            // valALbl
            // 
            this.valALbl.AutoSize = true;
            this.valALbl.Location = new System.Drawing.Point(15, 122);
            this.valALbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.valALbl.Name = "valALbl";
            this.valALbl.Size = new System.Drawing.Size(73, 25);
            this.valALbl.TabIndex = 7;
            this.valALbl.Text = "Slope:";
            // 
            // valATxt
            // 
            this.valATxt.Location = new System.Drawing.Point(228, 116);
            this.valATxt.Margin = new System.Windows.Forms.Padding(6);
            this.valATxt.Name = "valATxt";
            this.valATxt.Size = new System.Drawing.Size(134, 31);
            this.valATxt.TabIndex = 8;
            this.valATxt.Text = "1";
            // 
            // learningRateLbl
            // 
            this.learningRateLbl.AutoSize = true;
            this.learningRateLbl.Location = new System.Drawing.Point(15, 165);
            this.learningRateLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.learningRateLbl.Name = "learningRateLbl";
            this.learningRateLbl.Size = new System.Drawing.Size(153, 25);
            this.learningRateLbl.TabIndex = 9;
            this.learningRateLbl.Text = "Learning Rate:";
            // 
            // learningRateTxt
            // 
            this.learningRateTxt.Location = new System.Drawing.Point(228, 159);
            this.learningRateTxt.Margin = new System.Windows.Forms.Padding(6);
            this.learningRateTxt.Name = "learningRateTxt";
            this.learningRateTxt.Size = new System.Drawing.Size(134, 31);
            this.learningRateTxt.TabIndex = 10;
            this.learningRateTxt.Text = "0.1";
            // 
            // errorRateLbl
            // 
            this.errorRateLbl.AutoSize = true;
            this.errorRateLbl.Location = new System.Drawing.Point(15, 208);
            this.errorRateLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorRateLbl.Name = "errorRateLbl";
            this.errorRateLbl.Size = new System.Drawing.Size(167, 25);
            this.errorRateLbl.TabIndex = 11;
            this.errorRateLbl.Text = "Error Threshold:";
            // 
            // errorThresholdTxt
            // 
            this.errorThresholdTxt.Location = new System.Drawing.Point(228, 202);
            this.errorThresholdTxt.Margin = new System.Windows.Forms.Padding(6);
            this.errorThresholdTxt.Name = "errorThresholdTxt";
            this.errorThresholdTxt.Size = new System.Drawing.Size(134, 31);
            this.errorThresholdTxt.TabIndex = 12;
            this.errorThresholdTxt.Text = "0.05";
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(1304, 401);
            this.trainButton.Margin = new System.Windows.Forms.Padding(6);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(196, 80);
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
            this.neuronsPerLayerGridView.Location = new System.Drawing.Point(321, 102);
            this.neuronsPerLayerGridView.Name = "neuronsPerLayerGridView";
            this.neuronsPerLayerGridView.RowTemplate.Height = 33;
            this.neuronsPerLayerGridView.Size = new System.Drawing.Size(256, 234);
            this.neuronsPerLayerGridView.TabIndex = 15;
            // 
            // neuronsPerLayer
            // 
            this.neuronsPerLayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.neuronsPerLayer.DefaultCellStyle = dataGridViewCellStyle4;
            this.neuronsPerLayer.HeaderText = "#Neurons/Layer";
            this.neuronsPerLayer.Name = "neuronsPerLayer";
            this.neuronsPerLayer.Width = 210;
            // 
            // layersInformationGroupBox
            // 
            this.layersInformationGroupBox.Controls.Add(this.neuronsPerLayerGridView);
            this.layersInformationGroupBox.Controls.Add(this.neuronsPerLayerLbl);
            this.layersInformationGroupBox.Controls.Add(this.hiddenLayerTxt);
            this.layersInformationGroupBox.Controls.Add(this.hiddenLayerLbl);
            this.layersInformationGroupBox.Location = new System.Drawing.Point(21, 40);
            this.layersInformationGroupBox.Name = "layersInformationGroupBox";
            this.layersInformationGroupBox.Size = new System.Drawing.Size(592, 352);
            this.layersInformationGroupBox.TabIndex = 16;
            this.layersInformationGroupBox.TabStop = false;
            this.layersInformationGroupBox.Text = "Layer\'s Information";
            // 
            // activationFunctionLbl
            // 
            this.activationFunctionLbl.AutoSize = true;
            this.activationFunctionLbl.Location = new System.Drawing.Point(15, 59);
            this.activationFunctionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.activationFunctionLbl.Name = "activationFunctionLbl";
            this.activationFunctionLbl.Size = new System.Drawing.Size(201, 25);
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
            this.groupBox1.Location = new System.Drawing.Point(1027, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 352);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PCA Data Reduction";
            // 
            // pcaAlphaTxtBox
            // 
            this.pcaAlphaTxtBox.Location = new System.Drawing.Point(316, 198);
            this.pcaAlphaTxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.pcaAlphaTxtBox.Name = "pcaAlphaTxtBox";
            this.pcaAlphaTxtBox.Size = new System.Drawing.Size(134, 31);
            this.pcaAlphaTxtBox.TabIndex = 16;
            this.pcaAlphaTxtBox.Text = "0.01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Learning Rate:";
            // 
            // numPCTxtBox
            // 
            this.numPCTxtBox.Location = new System.Drawing.Point(316, 155);
            this.numPCTxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.numPCTxtBox.Name = "numPCTxtBox";
            this.numPCTxtBox.Size = new System.Drawing.Size(134, 31);
            this.numPCTxtBox.TabIndex = 16;
            this.numPCTxtBox.Text = "1";
            // 
            // numEpochsTxtBox
            // 
            this.numEpochsTxtBox.Location = new System.Drawing.Point(316, 112);
            this.numEpochsTxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.numEpochsTxtBox.Name = "numEpochsTxtBox";
            this.numEpochsTxtBox.Size = new System.Drawing.Size(134, 31);
            this.numEpochsTxtBox.TabIndex = 15;
            this.numEpochsTxtBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. of Principal Components:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. of Epochs:";
            // 
            // pcaCheckBox
            // 
            this.pcaCheckBox.AutoSize = true;
            this.pcaCheckBox.Location = new System.Drawing.Point(20, 60);
            this.pcaCheckBox.Name = "pcaCheckBox";
            this.pcaCheckBox.Size = new System.Drawing.Size(147, 29);
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
            this.groupBox2.Location = new System.Drawing.Point(619, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 352);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Learning Parameters";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1536, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.layersInformationGroupBox);
            this.Controls.Add(this.trainButton);
            this.Margin = new System.Windows.Forms.Padding(6);
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

