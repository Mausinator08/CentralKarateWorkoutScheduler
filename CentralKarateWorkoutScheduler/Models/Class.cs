﻿using System;
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

		Guid id;
		string name;
		string displayName;
		int startHour;
		int startMinute;
		int durationInMinutes;

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

		public int StartHour
		{
			get => startHour;
			set => SetPropertyValue(nameof(StartHour), ref startHour, value);
		}

		public int StartMinute
		{
			get => startMinute;
			set => SetPropertyValue(nameof(StartMinute), ref startMinute, value);
		}

		public int DurationInMinutes
		{
			get => durationInMinutes;
			set => SetPropertyValue(nameof(DurationInMinutes), ref durationInMinutes, value);
		}

		[Association("Class-Routines"), Aggregated]
		public XPCollection<Routine> Routines
		{
			get => GetCollection<Routine>(nameof(Routines));
		}
	}
}
