using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Employee
{
    [Column("EmployeeId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Employee name cant be null")]
    [MaxLength(30,ErrorMessage = "Employee Name length should be less than 30")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Age is required field")]
    public int Age { get; set; }
    
    [Required(ErrorMessage = "Position cant be null")]
    [MaxLength(20,ErrorMessage = "Position length should be less than 20")]
    public string? Position { get; set; }
    
    [ForeignKey(nameof(Company))]
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }
}