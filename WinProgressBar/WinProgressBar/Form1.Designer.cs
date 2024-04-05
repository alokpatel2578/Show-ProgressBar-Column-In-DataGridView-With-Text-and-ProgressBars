namespace WinProgressBar
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
            this.components = new System.ComponentModel.Container();
            this.softwareupdatedataGrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.softwareupdatedataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // softwareupdatedataGrid
            // 
            this.softwareupdatedataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareupdatedataGrid.Location = new System.Drawing.Point(40, 76);
            this.softwareupdatedataGrid.Name = "softwareupdatedataGrid";
            this.softwareupdatedataGrid.RowHeadersWidth = 51;
            this.softwareupdatedataGrid.RowTemplate.Height = 29;
            this.softwareupdatedataGrid.Size = new System.Drawing.Size(657, 291);
            this.softwareupdatedataGrid.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.softwareupdatedataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareupdatedataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView softwareupdatedataGrid;
        private System.Windows.Forms.Timer timer1;
    }
}