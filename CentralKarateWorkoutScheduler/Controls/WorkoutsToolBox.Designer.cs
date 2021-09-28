
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Class 1");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Class 2");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Class 3");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("In Rotation", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Class 1");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Class 2");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Class 3");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Additional", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Workouts", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Default");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Views", new System.Windows.Forms.TreeNode[] {
            treeNode10});
			this.treeviewWorkoutTree = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeviewWorkoutTree
			// 
			this.treeviewWorkoutTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeviewWorkoutTree.Location = new System.Drawing.Point(0, 0);
			this.treeviewWorkoutTree.Name = "treeviewWorkoutTree";
			treeNode1.Name = "Class1";
			treeNode1.Text = "Class 1";
			treeNode2.Name = "Class2";
			treeNode2.Text = "Class 2";
			treeNode3.Name = "Class3";
			treeNode3.Text = "Class 3";
			treeNode4.Name = "InRotation";
			treeNode4.Text = "In Rotation";
			treeNode5.Name = "Class1";
			treeNode5.Text = "Class 1";
			treeNode6.Name = "Class2";
			treeNode6.Text = "Class 2";
			treeNode7.Name = "Class3";
			treeNode7.Text = "Class 3";
			treeNode8.Name = "Additional";
			treeNode8.Text = "Additional";
			treeNode9.Name = "Workouts";
			treeNode9.Text = "Workouts";
			treeNode10.Name = "Default";
			treeNode10.Text = "Default";
			treeNode11.Name = "Views";
			treeNode11.Text = "Views";
			this.treeviewWorkoutTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11});
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

		private System.Windows.Forms.TreeView treeviewWorkoutTree;
	}
}
