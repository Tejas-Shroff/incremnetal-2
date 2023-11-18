// Models/Player.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models{

    public class Player{


        [Key]
        [Required]
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? Category { get; set; }

        public decimal BiddingAmount { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }

        public Team Team { get; set; }



    }


}
