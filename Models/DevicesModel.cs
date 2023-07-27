using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
        using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ITGateway.Models
{
    public class DevicesModel
    {


    [Key]
    public int device_id { get; set; }

    [MaxLength(255)]
    public string device_name { get; set; }

    public DateTime? created_at_utc { get; set; }
    public DateTime? updated_at_utc { get; set; }

    [MaxLength(100)]
    public string created_by { get; set; }

    [MaxLength(100)]
    public string updated_by { get; set; }


    }
}