using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTest.Models
{
    public class PuppyPost
    {
        [Key] // informing ef that this is the tables unique identifier
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // informing ef that the db will provide this value

        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string dateBorn { get; set; }
        public string description { get; set; }
        public string coat { get; set; }
        public string eyes { get; set; }
        public string imgUrl { get; set; }

        public PuppyPost() { }

        public PuppyPost(int id, string name, string price, string dateBorn, string description, string coat, string eyes, string imgUrl)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.dateBorn = dateBorn;
            this.description = description;
            this.coat = coat;
            this.eyes = eyes;
            this.imgUrl = imgUrl;
        }
    }
}