using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CentralKarateWorkoutScheduler.Models
{
	public class Class : XPObject
	{
		public Class() : base()
		{

		}

		public Class(Session session) : base(session)
		{

		}

		public override void AfterConstruction()
		{
			base.AfterConstruction();
		}

		int id;
		string name;
		int startTimeInMinutes;
		int durationInMinutes;

		[DbType("id", DbColumnTypeName = "int")]
		public int Id {
			get => id;
			set => SetPropertyValue(nameof(Id), ref id, value);
		}

		[DbType("name", DbColumnTypeName = "nvarchar(50)")]
		public string Name
		{
			get => name;
			set => SetPropertyValue(nameof(Name), ref name, value);
		}

		[DbType("start_time_in_minutes", DbColumnTypeName = "int")]
		public int StartTimeInMinutes 
		{
			get => startTimeInMinutes;
			set => SetPropertyValue(nameof(StartTimeInMinutes), ref startTimeInMinutes, value);
		}

		[DbType("duration_in_minutes", DbColumnTypeName = "int")]
		public int DurationInMinutes 
		{
			get => durationInMinutes;
			set => SetPropertyValue(nameof(DurationInMinutes), ref durationInMinutes, value);
		}
	}
}
