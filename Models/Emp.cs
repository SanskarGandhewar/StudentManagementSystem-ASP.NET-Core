using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models;

public partial class Emp
{
    [Required(ErrorMessage ="Id is Required")]
    public int Id { get; set; }
    [StringLength(45,MinimumLength =3,ErrorMessage ="String should be 45 Character")]
    public string? Ename { get; set; }
    [Required (ErrorMessage ="Salary is required")]
    [Range(500,100000,ErrorMessage = "Salary should between 500 to 100000")]
    public float? Salary { get; set; }
    [Required(ErrorMessage = "Address is required")]
    public string? Address { get; set; }
    [Required(ErrorMessage = "Gender is required")]
    public string? Gender { get; set; }
}
