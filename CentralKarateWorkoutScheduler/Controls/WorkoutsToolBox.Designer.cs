
namespace CentralKarateWorkoutScheduler.Controls
{
	partial class WorkoutsToolBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Workouts In Rotation");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Default");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Monthly Calendar");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Views", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.treeviewWorkoutTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeviewWorkoutTree
            // 
            this.treeviewWorkoutTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeviewWorkoutTree.Location = new System.Drawing.Point(0, 0);
            this.treeviewWorkoutTree.Name = "treeviewWorkoutTree";
            treeNode1.Name = "WorkoutsInRotation";
            treeNode1.Tag = "root";
            treeNode1.Text = "Workouts In Rotation";
            treeNode2.Name = "Default";
            treeNode2.Tag = "view";
            treeNode2.Text = "Default";
            treeNode3.Name = "MonthlyCalendar";
            treeNode3.Tag = "view";
            treeNode3.Text = "Monthly Calendar";
            treeNode4.Name = "Views";
            treeNode4.Tag = "root";
            treeNode4.Text = "Views";
            this.treeviewWorkoutTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            this.treeviewWorkoutTree.Size = new System.Drawing.Size(178, 580);
            this.treeviewWorkoutTree.TabIndex = 0;
            this.treeviewWorkoutTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeviewWorkoutTree_ItemDrag);
            // 
            // WorkoutsToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.treeviewWorkoutTree);
            this.Name = "WorkoutsToolBox";
            this.Size = new System.Drawing.Size(178, 580);
            this.ResumeLayout(false);

		}

        #endregion

        public System.Windows.Forms.TreeView treeviewWorkoutTree;
    }
}
