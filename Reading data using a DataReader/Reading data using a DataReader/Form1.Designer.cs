namespace Reading_data_using_a_DataReader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dbView = new System.Windows.Forms.DataGridView();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbView);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstOutput);
            this.groupBox2.Location = new System.Drawing.Point(657, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ListBox Data";
            // 
            // dbView
            // 
            this.dbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbView.Location = new System.Drawing.Point(24, 45);
            this.dbView.Name = "dbView";
            this.dbView.RowHeadersWidth = 51;
            this.dbView.RowTemplate.Height = 24;
            this.dbView.Size = new System.Drawing.Size(569, 268);
            this.dbView.TabIndex = 0;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(20, 34);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(417, 276);
            this.lstOutput.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 388);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 40);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(153, 388);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(117, 40);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(298, 388);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(117, 40);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move Data";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1001, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dbView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnExit;
    }
}

