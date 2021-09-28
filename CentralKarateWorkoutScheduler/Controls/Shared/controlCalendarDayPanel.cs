using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralKarateWorkoutScheduler.Controls.Shared
{
	public partial class controlCalendarDayPanel : UserControl
	{
		public controlCalendarDayPanel()
		{
			InitializeComponent();
		}

		public void Init(int day, string[] workouts = null)
		{
			this.labelDate.Text = day.ToString();
			this.textBoxDetails.Lines = workouts;
		}

		public void SetWorkouts(string[] workouts)
		{
			this.textBoxDetails.Lines = workouts;
		}
	}
}
