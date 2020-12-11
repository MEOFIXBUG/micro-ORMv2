// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace micro_ORM.POCO
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Collections.Generic;

    /// <summary>
    /// A class which represents the rooms table.
    /// </summary>
	[Table("rooms")]
	public partial class Room
	{
		[Key]
		public virtual int ID { get; set; }
		public virtual string RoomName { get; set; }
		public virtual int Status { get; set; }
		public virtual double Price { get; set; }
		public virtual int Type { get; set; }
		public virtual int MaxPeople { get; set; }
	}
}