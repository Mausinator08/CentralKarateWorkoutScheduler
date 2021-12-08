
namespace CentralKarateWorkoutScheduler.Controls
{
	partial class controlWorkoutCalendar
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
            this.controlDailyCalendar = new CentralKarateWorkoutScheduler.Controls.Shared.controlDailyCalendar();
            this.controlDaysOfWeek = new CentralKarateWorkoutScheduler.Controls.Shared.controlDaysOfWeek();
            this.tsLabelYear = new System.Windows.Forms.ToolStripLabel();
            this.tsComboBoxYear = new System.Windows.Forms.ToolStripComboBox();
            this.tsLabelMonth = new System.Windows.Forms.ToolStripLabel();
            this.tsComboBoxMonth = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripWorkoutCalendar = new System.Windows.Forms.ToolStrip();
            this.toolStripWorkoutCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlDailyCalendar
            // 
            this.controlDailyCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlDailyCalendar.Location = new System.Drawing.Point(3, 67);
            this.controlDailyCalendar.Name = "controlDailyCalendar";
            this.controlDailyCalendar.Size = new System.Drawing.Size(1194, 650);
            this.controlDailyCalendar.TabIndex = 2;
            // 
            // controlDaysOfWeek
            // 
            this.controlDaysOfWeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlDaysOfWeek.Location = new System.Drawing.Point(3, 28);
            this.controlDaysOfWeek.Name = "controlDaysOfWeek";
            this.controlDaysOfWeek.Size = new System.Drawing.Size(1194, 33);
            this.controlDaysOfWeek.TabIndex = 1;
            // 
            // tsLabelYear
            // 
            this.tsLabelYear.Name = "tsLabelYear";
            this.tsLabelYear.Size = new System.Drawing.Size(63, 22);
            this.tsLabelYear.Text = "Select Year";
            // 
            // tsComboBoxYear
            // 
            this.tsComboBoxYear.Name = "tsComboBoxYear";
            this.tsComboBoxYear.Size = new System.Drawing.Size(121, 25);
            this.tsComboBoxYear.SelectedIndexChanged += new System.EventHandler(this.tsComboBoxYear_SelectedIndexChanged);
            this.tsComboBoxYear.TextUpdate += new System.EventHandler(this.tsComboBoxYear_TextUpdate);
            // 
            // tsLabelMonth
            // 
            this.tsLabelMonth.Name = "tsLabelMonth";
            this.tsLabelMonth.Size = new System.Drawing.Size(77, 22);
            this.tsLabelMonth.Text = "Select Month";
            // 
            // tsComboBoxMonth
            // 
            this.tsComboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.tsComboBoxMonth.Name = "tsComboBoxMonth";
            this.tsComboBoxMonth.Size = new System.Drawing.Size(121, 25);
            this.tsComboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.tsComboBoxMonth_SelectedIndexChanged);
            this.tsComboBoxMonth.TextUpdate += new System.EventHandler(this.tsComboBoxMonth_TextUpdate);
            // 
            // toolStripWorkoutCalendar
            // 
            this.toolStripWorkoutCalendar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripWorkoutCalendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelYear,
            this.tsComboBoxYear,
            this.tsLabelMonth,
            this.tsComboBoxMonth});
            this.toolStripWorkoutCalendar.Location = new System.Drawing.Point(0, 0);
            this.toolStripWorkoutCalendar.Name = "toolStripWorkoutCalendar";
            this.toolStripWorkoutCalendar.Size = new System.Drawing.Size(1200, 25);
            this.toolStripWorkoutCalendar.TabIndex = 3;
            this.toolStripWorkoutCalendar.Text = "toolStrip1";
            // 
            // controlWorkoutCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.toolStripWorkoutCalendar);
            this.Controls.Add(this.controlDailyCalendar);
            this.Controls.Add(this.controlDaysOfWeek);
            this.Name = "controlWorkoutCalendar";
            this.Size = new System.Drawing.Size(1200, 720);
            this.Load += new System.EventHandler(this.controlWorkoutCalendar_Load);
            this.toolStripWorkoutCalendar.ResumeLayout(false);
            this.toolStripWorkoutCalendar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Shared.controlDaysOfWeek controlDaysOfWeek;
		private Shared.controlDailyCalendar controlDailyCalendar;
		private System.Windows.Forms.ToolStripLabel tsLabelYear;
		private System.Windows.Forms.ToolStripComboBox tsComboBoxYear;
		private System.Windows.Forms.ToolStripLabel tsLabelMonth;
		private System.Windows.Forms.ToolStripComboBox tsComboBoxMonth;
		private System.Windows.Forms.ToolStrip toolStripWorkoutCalendar;
	}
}
