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
            this.neuronsPerLayerGridView = new System.Windows.Forms.DataGridView();
            this.neuronsPerLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.neuronsPerLayerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hiddenLayerLbl
            // 
            this.hiddenLayerLbl.AutoSize = true;
            this.hiddenLayerLbl.Location = new System.Drawing.Point(102, 96);
            this.hiddenLayerLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hiddenLayerLbl.Name = "hiddenLayerLbl";
            this.hiddenLayerLbl.Size = new System.Drawing.Size(157, 25);
            this.hiddenLayerLbl.TabIndex = 0;
            this.hiddenLayerLbl.Text = "Hidden Layers:";
            // 
            // hiddenLayerTxt
            // 
            this.hiddenLayerTxt.Location = new System.Drawing.Point(348, 92);
            this.hiddenLayerTxt.Margin = new System.Windows.Forms.Padding(6);
            this.hiddenLayerTxt.Name = "hiddenLayerTxt";
            this.hiddenLayerTxt.Size = new System.Drawing.Size(134, 31);
            this.hiddenLayerTxt.TabIndex = 1;
            this.hiddenLayerTxt.Text = "1";
            // 
            // neuronsPerLayerLbl
            // 
            this.neuronsPerLayerLbl.AutoSize = true;
            this.neuronsPerLayerLbl.Location = new System.Drawing.Point(102, 158);
            this.neuronsPerLayerLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.neuronsPerLayerLbl.Name = "neuronsPerLayerLbl";
            this.neuronsPerLayerLbl.Size = new System.Drawing.Size(234, 25);
            this.neuronsPerLayerLbl.TabIndex = 2;
            this.neuronsPerLayerLbl.Text = "No. of Neurons / Layer:";
            // 
            // layerInfoLbl
            // 
            this.layerInfoLbl.AutoSize = true;
            this.layerInfoLbl.Location = new System.Drawing.Point(24, 40);
            this.layerInfoLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.layerInfoLbl.Name = "layerInfoLbl";
            this.layerInfoLbl.Size = new System.Drawing.Size(184, 25);
            this.layerInfoLbl.TabIndex = 4;
            this.layerInfoLbl.Text = "Layer Information:";
            // 
            // activationFunctionLbl
            // 
            this.activationFunctionLbl.AutoSize = true;
            this.activationFunctionLbl.Location = new System.Drawing.Point(668, 40);
            this.activationFunctionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.activationFunctionLbl.Name = "activationFunctionLbl";
            this.activationFunctionLbl.Size = new System.Drawing.Size(201, 25);
            this.activationFunctionLbl.TabIndex = 5;
            this.activationFunctionLbl.Text = "Activation Function:";
            // 
            // activationFunctionCmbx
            // 
            this.activationFunctionCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activationFunctionCmbx.Items.AddRange(new object[] {
            "Sigmoid",
            "Tanh"});
            this.activationFunctionCmbx.Location = new System.Drawing.Point(754, 90);
            this.activationFunctionCmbx.Margin = new System.Windows.Forms.Padding(6);
            this.activationFunctionCmbx.Name = "activationFunctionCmbx";
            this.activationFunctionCmbx.Size = new System.Drawing.Size(238, 33);
            this.activationFunctionCmbx.TabIndex = 14;
            this.activationFunctionCmbx.SelectedIndexChanged += new System.EventHandler(this.activationFunctionCmbx_SelectedIndexChanged);
            // 
            // valALbl
            // 
            this.valALbl.AutoSize = true;
            this.valALbl.Location = new System.Drawing.Point(749, 158);
            this.valALbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.valALbl.Name = "valALbl";
            this.valALbl.Size = new System.Drawing.Size(73, 25);
            this.valALbl.TabIndex = 7;
            this.valALbl.Text = "Slope:";
            // 
            // valATxt
            // 
            this.valATxt.Location = new System.Drawing.Point(858, 155);
            this.valATxt.Margin = new System.Windows.Forms.Padding(6);
            this.valATxt.Name = "valATxt";
            this.valATxt.Size = new System.Drawing.Size(134, 31);
            this.valATxt.TabIndex = 8;
            this.valATxt.Text = "1";
            // 
            // learningRateLbl
            // 
            this.learningRateLbl.AutoSize = true;
            this.learningRateLbl.Location = new System.Drawing.Point(668, 233);
            this.learningRateLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.learningRateLbl.Name = "learningRateLbl";
            this.learningRateLbl.Size = new System.Drawing.Size(153, 25);
            this.learningRateLbl.TabIndex = 9;
            this.learningRateLbl.Text = "Learning Rate:";
            // 
            // learningRateTxt
            // 
            this.learningRateTxt.Location = new System.Drawing.Point(858, 230);
            this.learningRateTxt.Margin = new System.Windows.Forms.Padding(6);
            this.learningRateTxt.Name = "learningRateTxt";
            this.learningRateTxt.Size = new System.Drawing.Size(134, 31);
            this.learningRateTxt.TabIndex = 10;
            this.learningRateTxt.Text = "0.1";
            // 
            // errorRateLbl
            // 
            this.errorRateLbl.AutoSize = true;
            this.errorRateLbl.Location = new System.Drawing.Point(668, 279);
            this.errorRateLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorRateLbl.Name = "errorRateLbl";
            this.errorRateLbl.Size = new System.Drawing.Size(167, 25);
            this.errorRateLbl.TabIndex = 11;
            this.errorRateLbl.Text = "Error Threshold:";
            // 
            // errorThresholdTxt
            // 
            this.errorThresholdTxt.Location = new System.Drawing.Point(858, 273);
            this.errorThresholdTxt.Margin = new System.Windows.Forms.Padding(6);
            this.errorThresholdTxt.Name = "errorThresholdTxt";
            this.errorThresholdTxt.Size = new System.Drawing.Size(134, 31);
            this.errorThresholdTxt.TabIndex = 12;
            this.errorThresholdTxt.Text = "0.05";
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(1071, 328);
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
            this.neuronsPerLayerGridView.Location = new System.Drawing.Point(348, 152);
            this.neuronsPerLayerGridView.Name = "neuronsPerLayerGridView";
            this.neuronsPerLayerGridView.RowTemplate.Height = 33;
            this.neuronsPerLayerGridView.Size = new System.Drawing.Size(256, 306);
            this.neuronsPerLayerGridView.TabIndex = 15;
            // 
            // neuronsPerLayer
            // 
            this.neuronsPerLayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.neuronsPerLayer.DefaultCellStyle = dataGridViewCellStyle1;
            this.neuronsPerLayer.HeaderText = "#Neurons/Layer";
            this.neuronsPerLayer.Name = "neuronsPerLayer";
            this.neuronsPerLayer.Width = 210;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 512);
            this.Controls.Add(this.neuronsPerLayerGridView);
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
            this.Controls.Add(this.neuronsPerLayerLbl);
            this.Controls.Add(this.hiddenLayerTxt);
            this.Controls.Add(this.hiddenLayerLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InputForm";
            this.Text = "Input Form";
            this.Load += new System.EventHandler(this.inputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.neuronsPerLayerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hiddenLayerLbl;
        private System.Windows.Forms.TextBox hiddenLayerTxt;
        private System.Windows.Forms.Label neuronsPerLayerLbl;
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
        private System.Windows.Forms.DataGridView neuronsPerLayerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn neuronsPerLayer;
    }
}

