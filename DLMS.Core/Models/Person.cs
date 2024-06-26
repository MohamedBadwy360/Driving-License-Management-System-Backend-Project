﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DLMS.Core.Models;

public partial class Person
{
    [Key]
    public int PersonID { get; set; }

    [Required]
    [StringLength(20)]
    public string NationalNo { get; set; }

    [Required]
    [StringLength(20)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(20)]
    public string SecondName { get; set; }

    [StringLength(20)]
    public string ThirdName { get; set; }

    [Required]
    [StringLength(20)]
    public string LastName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// 0 Male , 1 Femail
    /// </summary>
    public byte Gendor { get; set; }

    [Required]
    [StringLength(500)]
    public string Address { get; set; }

    [Required]
    [StringLength(20)]
    public string Phone { get; set; }

    [StringLength(50)]
    public string Email { get; set; }

    public int NationalityCountryID { get; set; }

    [StringLength(250)]
    public string ImagePath { get; set; }

    [InverseProperty("ApplicantPerson")]
    [JsonIgnore]
    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    [InverseProperty("Person")]
    [JsonIgnore]
    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();

    [ForeignKey("NationalityCountryID")]
    [InverseProperty("People")]
    [JsonIgnore]
    public virtual Country NationalityCountry { get; set; }
}