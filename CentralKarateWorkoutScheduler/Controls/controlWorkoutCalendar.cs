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

			for (DateTime dt = DateTime.Now.AddYears(-1); dt <= DateTime.Now.AddYears(1); dt = dt.AddYears(1))
				this.tsComboBoxYear.Items.Add(dt.ToString("yyyy"));
		}

		public void Init()
		{
			DateTime dateTime = DateTime.ParseExact($"{this.tsComboBoxYear.Text}-{this.tsComboBoxMonth.Text}-01 00:00:00.000", "yyyy-MMMM-dd HH:mm:ss.fff", null);

			this.controlDailyCalendar.Init(dateTime.Year, dateTime.Month);
		}

        private void tsComboBoxYear_TextUpdate(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.ParseExact($"{this.tsComboBoxYear.Text}-{this.tsComboBoxMonth.Text}-01 00:00:00.000", "yyyy-MMMM-dd HH:mm:ss.fff", null);

			this.controlDailyCalendar.Init(dateTime.Year, dateTime.Month);
		}

        private void tsComboBoxMonth_TextUpdate(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.ParseExact($"{this.tsComboBoxYear.Text}-{this.tsComboBoxMonth.Text}-01 00:00:00.000", "yyyy-MMMM-dd HH:mm:ss.fff", null);

			this.controlDailyCalendar.Init(dateTime.Year, dateTime.Month);
		}

        private void tsComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.ParseExact($"{this.tsComboBoxYear.Text}-{this.tsComboBoxMonth.Text}-01 00:00:00.000", "yyyy-MMMM-dd HH:mm:ss.fff", null);

			this.controlDailyCalendar.Init(dateTime.Year, dateTime.Month);
		}

        private void tsComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.ParseExact($"{this.tsComboBoxYear.Text}-{this.tsComboBoxMonth.Text}-01 00:00:00.000", "yyyy-MMMM-dd HH:mm:ss.fff", null);

			this.controlDailyCalendar.Init(dateTime.Year, dateTime.Month);
		}
    }
}
