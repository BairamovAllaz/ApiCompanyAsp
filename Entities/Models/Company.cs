using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Company
{
    [Column("CompanyId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Company name cant be null")]
    [MaxLength(60,ErrorMessage = "Company Name length should be less than 60")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Company Adress cant be null")]
    [MaxLength(60,ErrorMessage = "Company Adress length should be less than 60")]
    public string? Adress { get; set; }
    public string? Country { get; set; }
    public ICollection<Employee>? Employees { get; set; }
}