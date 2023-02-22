using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace KoreMVC.Models
{
    public class MembershipType
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int MembershipId { get; set; }
        
        public string ? MembershipName { get; set;}
    }
}
