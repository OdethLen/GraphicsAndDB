namespace GraphicsAndDB
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
            btnOpen = new Button();
            dgvAppData = new DataGridView();
            frmP = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            formsPlot4 = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)dgvAppData).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(64, 150);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(89, 30);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dgvAppData
            // 
            dgvAppData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppData.Location = new Point(194, 34);
            dgvAppData.Name = "dgvAppData";
            dgvAppData.Size = new Size(762, 239);
            dgvAppData.TabIndex = 1;
            // 
            // frmP
            // 
            frmP.DisplayScale = 1F;
            frmP.Location = new Point(42, 303);
            frmP.Name = "frmP";
            frmP.Size = new Size(208, 177);
            frmP.TabIndex = 2;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(277, 303);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(208, 177);
            formsPlot2.TabIndex = 3;
            // 
            // formsPlot3
            // 
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(528, 303);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(208, 177);
            formsPlot3.TabIndex = 4;
            // 
            // formsPlot4
            // 
            formsPlot4.DisplayScale = 1F;
            formsPlot4.Location = new Point(773, 303);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new Size(208, 177);
            formsPlot4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 492);
            Controls.Add(formsPlot4);
            Controls.Add(formsPlot3);
            Controls.Add(formsPlot2);
            Controls.Add(frmP);
            Controls.Add(dgvAppData);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAppData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private DataGridView dgvAppData;
        private ScottPlot.WinForms.FormsPlot frmP;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private ScottPlot.WinForms.FormsPlot formsPlot4;
    }
}
