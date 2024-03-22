﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLMS.Core.Models;

public partial class TestAppointment
{
    [Key]
    public int TestAppointmentID { get; set; }

    public int TestTypeID { get; set; }

    public int LocalDrivingLicenseApplicationID { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime AppointmentDate { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal PaidFees { get; set; }

    public bool IsLocked { get; set; }

    public int? RetakeTestApplicationID { get; set; }

    [ForeignKey("LocalDrivingLicenseApplicationID")]
    [InverseProperty("TestAppointments")]
    public virtual LocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; }

    [ForeignKey("RetakeTestApplicationID")]
    [InverseProperty("TestAppointments")]
    public virtual Application RetakeTestApplication { get; set; }

    [ForeignKey("TestTypeID")]
    [InverseProperty("TestAppointments")]
    public virtual TestType TestType { get; set; }

    [InverseProperty("TestAppointment")]
    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}