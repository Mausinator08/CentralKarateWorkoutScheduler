
namespace CentralKarateWorkoutScheduler.Forms
{
	partial class formHome
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.buttonGenerateWorkouts = new System.Windows.Forms.ToolStripButton();
			this.buttonEditWorkoutsInRotation = new System.Windows.Forms.ToolStripButton();
			this.workoutsToolBox1 = new CentralKarateWorkoutScheduler.Controls.WorkoutsToolBox();
			this.controlWorkoutCalendar1 = new CentralKarateWorkoutScheduler.Controls.controlWorkoutCalendar();
			this.menuStrip.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.editToolStripMenuItem,
			this.viewToolStripMenuItem,
			this.windowToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1264, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// windowToolStripMenuItem
			// 
			this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
			this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.windowToolStripMenuItem.Text = "Window";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonGenerateWorkouts,
			this.buttonEditWorkoutsInRotation});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// buttonGenerateWorkouts
			// 
			this.buttonGenerateWorkouts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonGenerateWorkouts.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonGenerateWorkouts.Name = "buttonGenerateWorkouts";
			this.buttonGenerateWorkouts.Size = new System.Drawing.Size(112, 22);
			this.buttonGenerateWorkouts.Text = "Generate Workouts";
			this.buttonGenerateWorkouts.Click += new System.EventHandler(this.buttonGenerateWorkouts_Click);
			// 
			// buttonEditWorkoutsInRotation
			// 
			this.buttonEditWorkoutsInRotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonEditWorkoutsInRotation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonEditWorkoutsInRotation.Name = "buttonEditWorkoutsInRotation";
			this.buttonEditWorkoutsInRotation.Size = new System.Drawing.Size(155, 22);
			this.buttonEditWorkoutsInRotation.Text = "Edit Workouts in Rotation...";
			this.buttonEditWorkoutsInRotation.Click += new System.EventHandler(this.buttonEditWorkoutsInRotation_Click);
			// 
			// workoutsToolBox1
			// 
			this.workoutsToolBox1.AutoScroll = true;
			this.workoutsToolBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.workoutsToolBox1.Location = new System.Drawing.Point(0, 49);
			this.workoutsToolBox1.Name = "workoutsToolBox1";
			this.workoutsToolBox1.Size = new System.Drawing.Size(178, 672);
			this.workoutsToolBox1.TabIndex = 2;
			// 
			// controlWorkoutCalendar1
			// 
			this.controlWorkoutCalendar1.AutoScroll = true;
			this.controlWorkoutCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.controlWorkoutCalendar1.Location = new System.Drawing.Point(178, 49);
			this.controlWorkoutCalendar1.Name = "controlWorkoutCalendar1";
			this.controlWorkoutCalendar1.Size = new System.Drawing.Size(1086, 672);
			this.controlWorkoutCalendar1.TabIndex = 3;
			// 
			// formHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 721);
			this.Controls.Add(this.controlWorkoutCalendar1);
			this.Controls.Add(this.workoutsToolBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "formHome";
			this.Text = "Central Karate - Workout Scheduler";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton buttonGenerateWorkouts;
		private System.Windows.Forms.ToolStripButton buttonEditWorkoutsInRotation;
		private Controls.WorkoutsToolBox workoutsToolBox1;
		private Controls.controlWorkoutCalendar controlWorkoutCalendar1;
	}
}

