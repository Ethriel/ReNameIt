﻿namespace CouncilVouingResults
{
    partial class CouncilVouingResults
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
            this.butCreateTables = new System.Windows.Forms.Button();
            this.butRename = new System.Windows.Forms.Button();
            this.butHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCreateTables
            // 
            this.butCreateTables.Location = new System.Drawing.Point(12, 12);
            this.butCreateTables.Name = "butCreateTables";
            this.butCreateTables.Size = new System.Drawing.Size(180, 23);
            this.butCreateTables.TabIndex = 1;
            this.butCreateTables.Text = "Create HTML-table and XLSX-file";
            this.butCreateTables.UseVisualStyleBackColor = true;
            this.butCreateTables.Click += new System.EventHandler(this.button1_Click);
            // 
            // butRename
            // 
            this.butRename.Location = new System.Drawing.Point(220, 12);
            this.butRename.Name = "butRename";
            this.butRename.Size = new System.Drawing.Size(97, 23);
            this.butRename.TabIndex = 18;
            this.butRename.Text = "Rename files";
            this.butRename.UseVisualStyleBackColor = true;
            this.butRename.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // butHelp
            // 
            this.butHelp.Location = new System.Drawing.Point(344, 11);
            this.butHelp.Name = "butHelp";
            this.butHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butHelp.Size = new System.Drawing.Size(75, 23);
            this.butHelp.TabIndex = 19;
            this.butHelp.Text = "Help";
            this.butHelp.UseVisualStyleBackColor = true;
            this.butHelp.Click += new System.EventHandler(this.butHelp_Click);
            // 
            // CouncilVouingResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 50);
            this.Controls.Add(this.butHelp);
            this.Controls.Add(this.butRename);
            this.Controls.Add(this.butCreateTables);
            this.Name = "CouncilVouingResults";
            this.Text = "CouncilVouingResults";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butCreateTables;
        private System.Windows.Forms.Button butRename;
        private System.Windows.Forms.Button butHelp;
    }
}

