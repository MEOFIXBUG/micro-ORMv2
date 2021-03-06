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
    /// A class which represents the bookings table.
    /// </summary>
	[Table("bookings")]
	public partial class Booking
	{
		[Key]
		public virtual int ID { get; set; }
		public virtual int CustomerId { get; set; }
		public virtual double Total { get; set; }
		public virtual bool IsPaid { get; set; }
		public virtual DateTime CreatedAt { get; set; }
		public virtual int? Discount { get; set; }
		public virtual DateTime? PaidTime { get; set; }
	}
}