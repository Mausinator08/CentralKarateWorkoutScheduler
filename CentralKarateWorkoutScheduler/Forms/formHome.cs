using CentralKarateWorkoutScheduler.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralKarateWorkoutScheduler.Forms
{
	public partial class formHome : Form
	{
		private formEditWorkoutsInRotation formEditWorkoutsInRotation = null;

		public formHome()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonGenerateWorkouts_Click(object sender, EventArgs e)
		{

		}

		private void buttonEditWorkoutsInRotation_Click(object sender, EventArgs e)
		{
			formEditWorkoutsInRotation = new formEditWorkoutsInRotation();
			formEditWorkoutsInRotation.ShowDialog();
		}
	}
}
