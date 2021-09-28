using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralKarateWorkoutScheduler.Controls
{
	public partial class controlWorkoutCalendar : UserControl
	{
		public controlWorkoutCalendar()
		{
			InitializeComponent();
		}

		private void controlWorkoutCalendar_Load(object sender, EventArgs e)
		{
			this.tsComboBoxYear.Text = DateTime.Now.ToString("yyyy");
			this.tsComboBoxMonth.Text = DateTime.Now.ToString("MMMM");
		}

		public void Init()
		{
			this.controlDailyCalendar.Init(DateTime.Parse(this.tsComboBoxYear.Text).Year, DateTime.Parse(this.tsComboBoxMonth.Text).Month);
		}
	}
}
