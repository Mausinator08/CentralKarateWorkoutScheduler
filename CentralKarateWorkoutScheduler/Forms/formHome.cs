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
using CentralKarateWorkoutScheduler.Models;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using System.Data.SQLite;
using System.IO;

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

		private void formHome_Load(object sender, EventArgs e)
		{
			Directory.CreateDirectory(@"Data");
			XpoDefault.DataLayer = XpoDefault.GetDataLayer(SQLiteConnectionProvider.GetConnectionString(@"Data\CentralKarateWorkoutScheduler.db"), AutoCreateOption.DatabaseAndSchema);

			using (UnitOfWork uow = new UnitOfWork())
			{
				uow.UpdateSchema(typeof(Class), typeof(Routine), typeof(Workout));
				uow.CommitChanges();
			}

			controlWorkoutCalendar1.Init();
		}
	}
}
