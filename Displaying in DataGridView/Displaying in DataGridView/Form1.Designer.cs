namespace Displaying_in_DataGridView
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
            this.dbView = new System.Windows.Forms.DataGridView();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnGridview = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbView
            // 
            this.dbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbView.Location = new System.Drawing.Point(12, 12);
            this.dbView.Name = "dbView";
            this.dbView.RowHeadersWidth = 51;
            this.dbView.RowTemplate.Height = 24;
            this.dbView.Size = new System.Drawing.Size(594, 240);
            this.dbView.TabIndex = 1;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(12, 284);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(594, 212);
            this.lstOutput.TabIndex = 2;
            // 
            // btnGridview
            // 
            this.btnGridview.Location = new System.Drawing.Point(679, 102);
            this.btnGridview.Name = "btnGridview";
            this.btnGridview.Size = new System.Drawing.Size(195, 60);
            this.btnGridview.TabIndex = 3;
            this.btnGridview.Text = "Display in DataGridView";
            this.btnGridview.UseVisualStyleBackColor = true;
            this.btnGridview.Click += new System.EventHandler(this.btnGridview_Click);
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(679, 363);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(195, 60);
            this.btnReader.TabIndex = 4;
            this.btnReader.Text = "Display using DataReader";
            this.btnReader.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 544);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.btnGridview);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.dbView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbView;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnGridview;
        private System.Windows.Forms.Button btnReader;
    }
}

