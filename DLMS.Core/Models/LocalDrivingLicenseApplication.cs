﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLMS.Core.Models;

public partial class LocalDrivingLicenseApplication
{
    [Key]
    public int LocalDrivingLicenseApplicationID { get; set; }

    public int ApplicationID { get; set; }

    public int LicenseClassID { get; set; }

    [ForeignKey("ApplicationID")]
    [InverseProperty("LocalDrivingLicenseApplications")]
    public virtual Application Application { get; set; }

    [ForeignKey("LicenseClassID")]
    [InverseProperty("LocalDrivingLicenseApplications")]
    public virtual LicenseClass LicenseClass { get; set; }

    [InverseProperty("LocalDrivingLicenseApplication")]
    public virtual ICollection<TestAppointment> TestAppointments { get; set; } = new List<TestAppointment>();
}