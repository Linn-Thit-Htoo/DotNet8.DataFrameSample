using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet8.DataFrameSample.Models;

[Table("Tbl_PlaceState")]
public class StateDataModel
{
    [Key]
    public int StateId { get; set; }
    public string StateCode { get; set; } = null!;
    public string StateName { get; set; } = null!;
}