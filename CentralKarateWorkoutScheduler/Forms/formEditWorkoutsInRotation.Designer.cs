
namespace CentralKarateWorkoutScheduler.Forms
{
	partial class formEditWorkoutsInRotation
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
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Monday");
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Tuesday");
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Wednesday");
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Thrusday");
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Class 1", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Monday");
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Tuesday");
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Wednesday");
			System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Thursday");
			System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Class 2", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
			System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Monday");
			System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Tuesday");
			System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Wednesday");
			System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Thursday");
			System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Class 3", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
			System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Workouts In Rotation", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode26,
            treeNode31});
			this.treeviewWorkoutsInRotation = new System.Windows.Forms.TreeView();
			this.buttonAddClass = new System.Windows.Forms.Button();
			this.buttonAddWorkout = new System.Windows.Forms.Button();
			this.buttonRemoveItem = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonAddRoutine = new System.Windows.Forms.Button();
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeviewWorkoutsInRotation
			// 
			this.treeviewWorkoutsInRotation.Location = new System.Drawing.Point(13, 13);
			this.treeviewWorkoutsInRotation.Name = "treeviewWorkoutsInRotation";
			treeNode17.Name = "MondayClass1";
			treeNode17.Text = "Monday";
			treeNode18.Name = "TuesdayClass1";
			treeNode18.Text = "Tuesday";
			treeNode19.Name = "WednesdayClass1";
			treeNode19.Text = "Wednesday";
			treeNode20.Name = "ThursdayClass1";
			treeNode20.Text = "Thrusday";
			treeNode21.Name = "Class1";
			treeNode21.Text = "Class 1";
			treeNode22.Name = "MondayClass2";
			treeNode22.Text = "Monday";
			treeNode23.Name = "TuesdayClass2";
			treeNode23.Text = "Tuesday";
			treeNode24.Name = "WednesdayClass2";
			treeNode24.Text = "Wednesday";
			treeNode25.Name = "ThursdayClass2";
			treeNode25.Text = "Thursday";
			treeNode26.Name = "Class2";
			treeNode26.Text = "Class 2";
			treeNode27.Name = "MondayClass3";
			treeNode27.Text = "Monday";
			treeNode28.Name = "TuesdayClass3";
			treeNode28.Text = "Tuesday";
			treeNode29.Name = "WednesdayClass3";
			treeNode29.Text = "Wednesday";
			treeNode30.Name = "ThursdayClass3";
			treeNode30.Text = "Thursday";
			treeNode31.Name = "Class3";
			treeNode31.Text = "Class 3";
			treeNode32.Name = "WorkoutsInRotation";
			treeNode32.Text = "Workouts In Rotation";
			this.treeviewWorkoutsInRotation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32});
			this.treeviewWorkoutsInRotation.Size = new System.Drawing.Size(213, 425);
			this.treeviewWorkoutsInRotation.TabIndex = 0;
			// 
			// buttonAddClass
			// 
			this.buttonAddClass.Location = new System.Drawing.Point(232, 13);
			this.buttonAddClass.Name = "buttonAddClass";
			this.buttonAddClass.Size = new System.Drawing.Size(103, 23);
			this.buttonAddClass.TabIndex = 1;
			this.buttonAddClass.Text = "Add Class";
			this.buttonAddClass.UseVisualStyleBackColor = true;
			// 
			// buttonAddWorkout
			// 
			this.buttonAddWorkout.Location = new System.Drawing.Point(232, 74);
			this.buttonAddWorkout.Name = "buttonAddWorkout";
			this.buttonAddWorkout.Size = new System.Drawing.Size(103, 23);
			this.buttonAddWorkout.TabIndex = 2;
			this.buttonAddWorkout.Text = "Add Workout";
			this.buttonAddWorkout.UseVisualStyleBackColor = true;
			// 
			// buttonRemoveItem
			// 
			this.buttonRemoveItem.Location = new System.Drawing.Point(232, 103);
			this.buttonRemoveItem.Name = "buttonRemoveItem";
			this.buttonRemoveItem.Size = new System.Drawing.Size(103, 23);
			this.buttonRemoveItem.TabIndex = 3;
			this.buttonRemoveItem.Text = "Remove Item";
			this.buttonRemoveItem.UseVisualStyleBackColor = true;
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Location = new System.Drawing.Point(232, 132);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
			this.buttonMoveUp.TabIndex = 4;
			this.buttonMoveUp.Text = "Move Up";
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			// 
			// buttonAddRoutine
			// 
			this.buttonAddRoutine.Location = new System.Drawing.Point(233, 43);
			this.buttonAddRoutine.Name = "buttonAddRoutine";
			this.buttonAddRoutine.Size = new System.Drawing.Size(102, 23);
			this.buttonAddRoutine.TabIndex = 5;
			this.buttonAddRoutine.Text = "Add Routine";
			this.buttonAddRoutine.UseVisualStyleBackColor = true;
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Location = new System.Drawing.Point(233, 162);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(75, 23);
			this.buttonMoveDown.TabIndex = 6;
			this.buttonMoveDown.Text = "Move Down";
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(233, 366);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(103, 23);
			this.buttonOK.TabIndex = 7;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(233, 404);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(103, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// formEditWorkoutsInRotation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonMoveDown);
			this.Controls.Add(this.buttonAddRoutine);
			this.Controls.Add(this.buttonMoveUp);
			this.Controls.Add(this.buttonRemoveItem);
			this.Controls.Add(this.buttonAddWorkout);
			this.Controls.Add(this.buttonAddClass);
			this.Controls.Add(this.treeviewWorkoutsInRotation);
			this.Name = "formEditWorkoutsInRotation";
			this.Text = "Workouts in Rotation Editor";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeviewWorkoutsInRotation;
		private System.Windows.Forms.Button buttonAddClass;
		private System.Windows.Forms.Button buttonAddWorkout;
		private System.Windows.Forms.Button buttonRemoveItem;
		private System.Windows.Forms.Button buttonMoveUp;
		private System.Windows.Forms.Button buttonAddRoutine;
		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}