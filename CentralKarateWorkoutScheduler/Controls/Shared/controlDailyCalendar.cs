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
	public partial class controlDailyCalendar : UserControl
	{
		public controlDailyCalendar()
		{
			InitializeComponent();
		}

		public void Init(int year, int month)
		{
			DateTime startDate = new DateTime(year, month, 1);

			while (startDate.DayOfWeek != DayOfWeek.Sunday)
			{
				startDate = startDate.AddDays(-1);
			}

			this.tableLayoutDailyCalendar.Controls.Clear();

			for (DateTime date = startDate; date <= startDate.AddDays(34); date = date.AddDays(1))
			{
				controlCalendarDayPanel calDayPanel = new controlCalendarDayPanel();
				calDayPanel.Init(date.Day);
				if (date.Month > month)
                {
					calDayPanel.BackColor = Color.DimGray;
					calDayPanel.DisableDetails();
                }

				if (date.Month < month)
                {
					calDayPanel.BackColor = Color.DimGray;
					calDayPanel.DisableDetails();
                }

				calDayPanel.Dock = DockStyle.Fill;
				this.tableLayoutDailyCalendar.Controls.Add(calDayPanel);
			}
		}
    }
}
