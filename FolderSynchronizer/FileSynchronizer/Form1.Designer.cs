namespace FolderSynchronizer
{
    partial class FolderSynchronizerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderSynchronizerForm));
            this.textBoxFolderPathLeft = new System.Windows.Forms.TextBox();
            this.buttonFolderPathLeft = new System.Windows.Forms.Button();
            this.textBoxFolderPathRight = new System.Windows.Forms.TextBox();
            this.buttonFolderPathRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFolderPathLeft
            // 
            this.textBoxFolderPathLeft.Location = new System.Drawing.Point(12, 12);
            this.textBoxFolderPathLeft.Name = "textBoxFolderPathLeft";
            this.textBoxFolderPathLeft.Size = new System.Drawing.Size(381, 20);
            this.textBoxFolderPathLeft.TabIndex = 0;
            // 
            // buttonFolderPathLeft
            // 
            this.buttonFolderPathLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonFolderPathLeft.Image")));
            this.buttonFolderPathLeft.Location = new System.Drawing.Point(399, 2);
            this.buttonFolderPathLeft.Name = "buttonFolderPathLeft";
            this.buttonFolderPathLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonFolderPathLeft.TabIndex = 1;
            this.buttonFolderPathLeft.UseVisualStyleBackColor = true;
            this.buttonFolderPathLeft.Click += new System.EventHandler(this.buttonFolderPathLeft_Click);
            // 
            // textBoxFolderPathRight
            // 
            this.textBoxFolderPathRight.Location = new System.Drawing.Point(554, 12);
            this.textBoxFolderPathRight.Name = "textBoxFolderPathRight";
            this.textBoxFolderPathRight.Size = new System.Drawing.Size(381, 20);
            this.textBoxFolderPathRight.TabIndex = 2;
            // 
            // buttonFolderPathRight
            // 
            this.buttonFolderPathRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonFolderPathRight.Image")));
            this.buttonFolderPathRight.Location = new System.Drawing.Point(508, 2);
            this.buttonFolderPathRight.Name = "buttonFolderPathRight";
            this.buttonFolderPathRight.Size = new System.Drawing.Size(40, 40);
            this.buttonFolderPathRight.TabIndex = 3;
            this.buttonFolderPathRight.UseVisualStyleBackColor = true;
            this.buttonFolderPathRight.Click += new System.EventHandler(this.buttonFolderPathRight_Click);
            // 
            // FolderSynchronizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 357);
            this.Controls.Add(this.buttonFolderPathRight);
            this.Controls.Add(this.textBoxFolderPathRight);
            this.Controls.Add(this.buttonFolderPathLeft);
            this.Controls.Add(this.textBoxFolderPathLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderSynchronizerForm";
            this.Text = "Folder Synchronizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFolderPathLeft;
        private System.Windows.Forms.Button buttonFolderPathLeft;
        private System.Windows.Forms.TextBox textBoxFolderPathRight;
        private System.Windows.Forms.Button buttonFolderPathRight;
    }
}

