﻿
namespace saleManagement
{
    partial class revenueMonthly
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
            this.label1 = new System.Windows.Forms.Label();
            this.revenueMonthlyGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.revenueMonthlyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "REVENUE MONTHLY";
            // 
            // revenueMonthlyGridView
            // 
            this.revenueMonthlyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.revenueMonthlyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenueMonthlyGridView.Location = new System.Drawing.Point(35, 59);
            this.revenueMonthlyGridView.Name = "revenueMonthlyGridView";
            this.revenueMonthlyGridView.RowHeadersWidth = 51;
            this.revenueMonthlyGridView.RowTemplate.Height = 24;
            this.revenueMonthlyGridView.Size = new System.Drawing.Size(735, 380);
            this.revenueMonthlyGridView.TabIndex = 1;
            // 
            // revenueMonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.revenueMonthlyGridView);
            this.Controls.Add(this.label1);
            this.Name = "revenueMonthly";
            this.Text = "Revenue Monthly";
            ((System.ComponentModel.ISupportInitialize)(this.revenueMonthlyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView revenueMonthlyGridView;
    }
}