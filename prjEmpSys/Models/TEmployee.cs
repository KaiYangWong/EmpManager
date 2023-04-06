using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace prjEmpSys.Models;

public partial class TEmployee
{
    [Display(Name = "員工編號")]
    [Required(ErrorMessage = "員工編號必填")]
    public string EmpId { get; set; } = null!;

    [Display(Name = "姓名")]
    [Required(ErrorMessage = "姓名必填")]
    public string? Name { get; set; }

    [Display(Name = "性別")]
    public string? Gender { get; set; }

    [Display(Name = "信箱")]
    [Required(ErrorMessage = "必須符合信箱格式")]
    public string? Mail { get; set; }

    [Display(Name = "薪資")]
    [Range(25000,65000,ErrorMessage = "薪資範圍25000~65000")]
    public int? Salary { get; set; }

    [Display(Name = "雇用日期")]
    [Required(ErrorMessage = "雇用日期必填")]
    [DataType(DataType.Date)]
    public DateTime? OnBoard { get; set; }
}
