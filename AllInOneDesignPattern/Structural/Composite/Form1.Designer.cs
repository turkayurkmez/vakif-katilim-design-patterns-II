namespace Composite
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
            TreeNode treeNode15 = new TreeNode("Ayşe Topuzoğlu");
            TreeNode treeNode16 = new TreeNode("TS", new TreeNode[] { treeNode15 });
            TreeNode treeNode17 = new TreeNode("EA");
            TreeNode treeNode18 = new TreeNode("FM");
            TreeNode treeNode19 = new TreeNode("10A", new TreeNode[] { treeNode16, treeNode17, treeNode18 });
            TreeNode treeNode20 = new TreeNode("10B");
            TreeNode treeNode21 = new TreeNode("Sınıflar", new TreeNode[] { treeNode19, treeNode20 });
            treeViewSample = new TreeView();
            treeViewCategories = new TreeView();
            SuspendLayout();
            // 
            // treeViewSample
            // 
            treeViewSample.Location = new Point(31, 45);
            treeViewSample.Name = "treeViewSample";
            treeNode15.Name = "Node6";
            treeNode15.Text = "Ayşe Topuzoğlu";
            treeNode16.Name = "Node2";
            treeNode16.Text = "TS";
            treeNode17.Name = "Node3";
            treeNode17.Text = "EA";
            treeNode18.Name = "Node4";
            treeNode18.Text = "FM";
            treeNode19.Name = "Node1";
            treeNode19.Text = "10A";
            treeNode20.Name = "Node5";
            treeNode20.Text = "10B";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Sınıflar";
            treeViewSample.Nodes.AddRange(new TreeNode[] { treeNode21 });
            treeViewSample.Size = new Size(203, 242);
            treeViewSample.TabIndex = 0;
            // 
            // treeViewCategories
            // 
            treeViewCategories.Location = new Point(381, 45);
            treeViewCategories.Name = "treeViewCategories";
            treeViewCategories.Size = new Size(203, 242);
            treeViewCategories.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeViewCategories);
            Controls.Add(treeViewSample);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewSample;
        private TreeView treeViewCategories;
    }
}
