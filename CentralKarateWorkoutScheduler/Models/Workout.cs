using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CentralKarateWorkoutScheduler.Models
{
	public class Workout : XPObject
	{
		public Workout() : base()
		{

		}

		public Workout(Session session) : base(session)
		{

		}

		public override void AfterConstruction()
		{
			base.AfterConstruction();
		}

		Guid id;
		string name;
		string displayName;
		string description;
		Routine routineRef;

		public Guid Id
		{
			get => id;
			set => SetPropertyValue(nameof(Id), ref id, value);
		}

		[Size(50)]
		public string Name
		{
			get => name;
			set => SetPropertyValue(nameof(Name), ref name, value);
		}

		[Size(100)]
		public string DisplayName
		{
			get => displayName;
			set => SetPropertyValue(nameof(DisplayName), ref displayName, value);
		}

		[Size(250)]
		public string Description
		{
			get => description;
			set => SetPropertyValue(nameof(Description), ref description, value);
		}

		[Association("Routine-Workouts")]
		public Routine RoutineRef
		{
			get => routineRef;
			set => SetPropertyValue(nameof(RoutineRef), ref routineRef, value);
		}
	}
}
