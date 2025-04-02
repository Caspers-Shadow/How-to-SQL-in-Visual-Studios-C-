namespace Displaying_using_a_DataGridView
{
    partial class Form1
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
            this.dsView = new System.Windows.Forms.DataGridView();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnDatagridviewDisplay = new System.Windows.Forms.Button();
            this.btnListboxDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsView
            // 
            this.dsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsView.Location = new System.Drawing.Point(35, 16);
            this.dsView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dsView.Name = "dsView";
            this.dsView.RowHeadersWidth = 51;
            this.dsView.RowTemplate.Height = 24;
            this.dsView.Size = new System.Drawing.Size(562, 259);
            this.dsView.TabIndex = 0;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(35, 315);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(562, 224);
            this.lstOutput.TabIndex = 1;
            // 
            // btnDatagridviewDisplay
            // 
            this.btnDatagridviewDisplay.Location = new System.Drawing.Point(642, 101);
            this.btnDatagridviewDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatagridviewDisplay.Name = "btnDatagridviewDisplay";
            this.btnDatagridviewDisplay.Size = new System.Drawing.Size(320, 66);
            this.btnDatagridviewDisplay.TabIndex = 2;
            this.btnDatagridviewDisplay.Text = "Displaying using a Datagridview";
            this.btnDatagridviewDisplay.UseVisualStyleBackColor = true;
            this.btnDatagridviewDisplay.Click += new System.EventHandler(this.btnDatagridviewDisplay_Click);
            // 
            // btnListboxDisplay
            // 
            this.btnListboxDisplay.Location = new System.Drawing.Point(642, 388);
            this.btnListboxDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnListboxDisplay.Name = "btnListboxDisplay";
            this.btnListboxDisplay.Size = new System.Drawing.Size(320, 66);
            this.btnListboxDisplay.TabIndex = 3;
            this.btnListboxDisplay.Text = "Displaying using a Listbox";
            this.btnListboxDisplay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnListboxDisplay);
            this.Controls.Add(this.btnDatagridviewDisplay);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.dsView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsView;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnDatagridviewDisplay;
        private System.Windows.Forms.Button btnListboxDisplay;
    }
}

