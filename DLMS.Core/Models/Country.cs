﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DLMS.Core.Models;

public partial class Country
{
    [Key]
    public int CountryID { get; set; }

    [Required]
    [StringLength(50)]
    public string CountryName { get; set; }

    [InverseProperty("NationalityCountry")]
    [JsonIgnore]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}