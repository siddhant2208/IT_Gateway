using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ITGateway.Models
{
    public class inventoryModel
    {


    [Key]
    public Guid inventory_id { get; set; }

    [ForeignKey("Device")]
    public int device_id { get; set; }

    public DateTime? created_at_utc { get; set; }
    public DateTime? updated_at_utc { get; set; }

    [MaxLength(50)]
    public string device_state { get; set; }


    }
}