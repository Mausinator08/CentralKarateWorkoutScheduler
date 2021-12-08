using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CentralKarateWorkoutScheduler.Models
{
	public class Routine : XPObject
	{
		public Routine() : base()
		{

		}

		public Routine(Session session) : base(session)
		{

		}

		public override void AfterConstruction()
		{
			base.AfterConstruction();
		}

		Guid id;
		string name;
		string displayName;
		Class classRef;

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

		[Association("Routine-Workouts"), Aggregated]
		public XPCollection<Workout> Workouts
		{
			get => GetCollection<Workout>(nameof(Workouts));
		}

		[Association("Class-Routines")]
		public Class ClassRef
		{
			get => classRef;
			set => SetPropertyValue(nameof(ClassRef), ref classRef, value);
		}
	}
}
