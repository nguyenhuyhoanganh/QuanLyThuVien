namespace WindowsFormsApp1
{
    partial class fHelp
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
            this.treeview_Display = new System.Windows.Forms.TreeView();
            this.richtextbox_Display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeview_Display
            // 
            this.treeview_Display.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeview_Display.Location = new System.Drawing.Point(0, 0);
            this.treeview_Display.Name = "treeview_Display";
            this.treeview_Display.Size = new System.Drawing.Size(230, 531);
            this.treeview_Display.TabIndex = 0;
            // 
            // richtextbox_Display
            // 
            this.richtextbox_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtextbox_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextbox_Display.Location = new System.Drawing.Point(230, 0);
            this.richtextbox_Display.Name = "richtextbox_Display";
            this.richtextbox_Display.Size = new System.Drawing.Size(617, 531);
            this.richtextbox_Display.TabIndex = 1;
            this.richtextbox_Display.Text = "";
            // 
            // fHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 531);
            this.Controls.Add(this.richtextbox_Display);
            this.Controls.Add(this.treeview_Display);
            this.Name = "fHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHelp";
            this.Load += new System.EventHandler(this.fHelp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeview_Display;
        private System.Windows.Forms.RichTextBox richtextbox_Display;
    }
}