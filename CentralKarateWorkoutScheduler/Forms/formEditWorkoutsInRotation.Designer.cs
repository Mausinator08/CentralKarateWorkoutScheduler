
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
			System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("Monday");
			System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("Tuesday");
			System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Wednesday");
			System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("Thrusday");
			System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("Class 1", new System.Windows.Forms.TreeNode[] {
            treeNode193,
            treeNode194,
            treeNode195,
            treeNode196});
			System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("Monday");
			System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("Tuesday");
			System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("Wednesday");
			System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("Thursday");
			System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("Class 2", new System.Windows.Forms.TreeNode[] {
            treeNode198,
            treeNode199,
            treeNode200,
            treeNode201});
			System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("Monday");
			System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("Tuesday");
			System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("Wednesday");
			System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("Thursday");
			System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("Class 3", new System.Windows.Forms.TreeNode[] {
            treeNode203,
            treeNode204,
            treeNode205,
            treeNode206});
			System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("Workouts In Rotation", new System.Windows.Forms.TreeNode[] {
            treeNode197,
            treeNode202,
            treeNode207});
			this.treeviewWorkoutsInRotation = new System.Windows.Forms.TreeView();
			this.buttonAddClass = new System.Windows.Forms.Button();
			this.buttonAddWorkout = new System.Windows.Forms.Button();
			this.buttonRemoveItem = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonAddRoutine = new System.Windows.Forms.Button();
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxNodeText = new System.Windows.Forms.TextBox();
			this.labelNodeText = new System.Windows.Forms.Label();
			this.textBoxNewNodeText = new System.Windows.Forms.TextBox();
			this.labelNewNodeText = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeviewWorkoutsInRotation
			// 
			this.treeviewWorkoutsInRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeviewWorkoutsInRotation.Location = new System.Drawing.Point(13, 13);
			this.treeviewWorkoutsInRotation.Name = "treeviewWorkoutsInRotation";
			treeNode193.Name = "MondayClass1";
			treeNode193.Tag = "routine";
			treeNode193.Text = "Monday";
			treeNode194.Name = "TuesdayClass1";
			treeNode194.Tag = "routine";
			treeNode194.Text = "Tuesday";
			treeNode195.Name = "WednesdayClass1";
			treeNode195.Tag = "routine";
			treeNode195.Text = "Wednesday";
			treeNode196.Name = "ThursdayClass1";
			treeNode196.Tag = "routine";
			treeNode196.Text = "Thrusday";
			treeNode197.Name = "Class1";
			treeNode197.Tag = "class";
			treeNode197.Text = "Class 1";
			treeNode198.Name = "MondayClass2";
			treeNode198.Tag = "routine";
			treeNode198.Text = "Monday";
			treeNode199.Name = "TuesdayClass2";
			treeNode199.Tag = "routine";
			treeNode199.Text = "Tuesday";
			treeNode200.Name = "WednesdayClass2";
			treeNode200.Tag = "routine";
			treeNode200.Text = "Wednesday";
			treeNode201.Name = "ThursdayClass2";
			treeNode201.Tag = "routine";
			treeNode201.Text = "Thursday";
			treeNode202.Name = "Class2";
			treeNode202.Tag = "class";
			treeNode202.Text = "Class 2";
			treeNode203.Name = "MondayClass3";
			treeNode203.Tag = "routine";
			treeNode203.Text = "Monday";
			treeNode204.Name = "TuesdayClass3";
			treeNode204.Tag = "routine";
			treeNode204.Text = "Tuesday";
			treeNode205.Name = "WednesdayClass3";
			treeNode205.Tag = "routine";
			treeNode205.Text = "Wednesday";
			treeNode206.Name = "ThursdayClass3";
			treeNode206.Tag = "routine";
			treeNode206.Text = "Thursday";
			treeNode207.Name = "Class3";
			treeNode207.Tag = "class";
			treeNode207.Text = "Class 3";
			treeNode208.Name = "WorkoutsInRotation";
			treeNode208.Tag = "root";
			treeNode208.Text = "Workouts In Rotation";
			this.treeviewWorkoutsInRotation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode208});
			this.treeviewWorkoutsInRotation.Size = new System.Drawing.Size(204, 425);
			this.treeviewWorkoutsInRotation.TabIndex = 0;
			this.treeviewWorkoutsInRotation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeviewWorkoutsInRotation_AfterSelect);
			// 
			// buttonAddClass
			// 
			this.buttonAddClass.Location = new System.Drawing.Point(11, 18);
			this.buttonAddClass.Name = "buttonAddClass";
			this.buttonAddClass.Size = new System.Drawing.Size(103, 23);
			this.buttonAddClass.TabIndex = 14;
			this.buttonAddClass.Text = "Add Class";
			this.buttonAddClass.UseVisualStyleBackColor = true;
			this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
			// 
			// buttonAddWorkout
			// 
			this.buttonAddWorkout.Location = new System.Drawing.Point(11, 79);
			this.buttonAddWorkout.Name = "buttonAddWorkout";
			this.buttonAddWorkout.Size = new System.Drawing.Size(103, 23);
			this.buttonAddWorkout.TabIndex = 15;
			this.buttonAddWorkout.Text = "Add Workout";
			this.buttonAddWorkout.UseVisualStyleBackColor = true;
			this.buttonAddWorkout.Click += new System.EventHandler(this.buttonAddWorkout_Click);
			// 
			// buttonRemoveItem
			// 
			this.buttonRemoveItem.Location = new System.Drawing.Point(11, 108);
			this.buttonRemoveItem.Name = "buttonRemoveItem";
			this.buttonRemoveItem.Size = new System.Drawing.Size(103, 23);
			this.buttonRemoveItem.TabIndex = 16;
			this.buttonRemoveItem.Text = "Remove Item";
			this.buttonRemoveItem.UseVisualStyleBackColor = true;
			this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Location = new System.Drawing.Point(11, 137);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
			this.buttonMoveUp.TabIndex = 17;
			this.buttonMoveUp.Text = "Move Up";
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			// 
			// buttonAddRoutine
			// 
			this.buttonAddRoutine.Location = new System.Drawing.Point(12, 48);
			this.buttonAddRoutine.Name = "buttonAddRoutine";
			this.buttonAddRoutine.Size = new System.Drawing.Size(102, 23);
			this.buttonAddRoutine.TabIndex = 18;
			this.buttonAddRoutine.Text = "Add Routine";
			this.buttonAddRoutine.UseVisualStyleBackColor = true;
			this.buttonAddRoutine.Click += new System.EventHandler(this.buttonAddRoutine_Click);
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Location = new System.Drawing.Point(12, 167);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(75, 23);
			this.buttonMoveDown.TabIndex = 19;
			this.buttonMoveDown.Text = "Move Down";
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(12, 371);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(103, 23);
			this.buttonOK.TabIndex = 20;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(12, 409);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(103, 23);
			this.buttonCancel.TabIndex = 21;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxNodeText
			// 
			this.textBoxNodeText.Location = new System.Drawing.Point(12, 221);
			this.textBoxNodeText.Multiline = true;
			this.textBoxNodeText.Name = "textBoxNodeText";
			this.textBoxNodeText.Size = new System.Drawing.Size(178, 55);
			this.textBoxNodeText.TabIndex = 22;
			this.textBoxNodeText.TextChanged += new System.EventHandler(this.textBoxNodeText_TextChanged);
			// 
			// labelNodeText
			// 
			this.labelNodeText.AutoSize = true;
			this.labelNodeText.Location = new System.Drawing.Point(12, 205);
			this.labelNodeText.Name = "labelNodeText";
			this.labelNodeText.Size = new System.Drawing.Size(103, 13);
			this.labelNodeText.TabIndex = 23;
			this.labelNodeText.Text = "Rename Node Text:";
			// 
			// textBoxNewNodeText
			// 
			this.textBoxNewNodeText.Location = new System.Drawing.Point(11, 310);
			this.textBoxNewNodeText.Multiline = true;
			this.textBoxNewNodeText.Name = "textBoxNewNodeText";
			this.textBoxNewNodeText.Size = new System.Drawing.Size(179, 55);
			this.textBoxNewNodeText.TabIndex = 24;
			// 
			// labelNewNodeText
			// 
			this.labelNewNodeText.AutoSize = true;
			this.labelNewNodeText.Location = new System.Drawing.Point(12, 294);
			this.labelNewNodeText.Name = "labelNewNodeText";
			this.labelNewNodeText.Size = new System.Drawing.Size(85, 13);
			this.labelNewNodeText.TabIndex = 25;
			this.labelNewNodeText.Text = "New Node Text:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelNewNodeText);
			this.panel1.Controls.Add(this.textBoxNewNodeText);
			this.panel1.Controls.Add(this.labelNodeText);
			this.panel1.Controls.Add(this.textBoxNodeText);
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.buttonOK);
			this.panel1.Controls.Add(this.buttonMoveDown);
			this.panel1.Controls.Add(this.buttonAddRoutine);
			this.panel1.Controls.Add(this.buttonMoveUp);
			this.panel1.Controls.Add(this.buttonRemoveItem);
			this.panel1.Controls.Add(this.buttonAddWorkout);
			this.panel1.Controls.Add(this.buttonAddClass);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(223, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 450);
			this.panel1.TabIndex = 14;
			// 
			// formEditWorkoutsInRotation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 450);
			this.Controls.Add(this.treeviewWorkoutsInRotation);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(439, 489);
			this.MinimumSize = new System.Drawing.Size(439, 489);
			this.Name = "formEditWorkoutsInRotation";
			this.Text = "Workouts in Rotation Editor";
			this.Load += new System.EventHandler(this.formEditWorkoutsInRotation_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
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
		private System.Windows.Forms.TextBox textBoxNodeText;
		private System.Windows.Forms.Label labelNodeText;
		private System.Windows.Forms.TextBox textBoxNewNodeText;
		private System.Windows.Forms.Label labelNewNodeText;
		private System.Windows.Forms.Panel panel1;
	}
}