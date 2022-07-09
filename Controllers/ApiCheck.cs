using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestA.Controllers
{
    [Table("histories")]
    public class ApiCheck
    {

        [JsonPropertyName("id")]
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("check")]
        [Column("check")]
        public string Check { get; set; }

        [JsonPropertyName("count")]
        [Column("count")]
        public int Count { get; set; }

        [JsonPropertyName("date")]
        [Column("date")]
        public DateTime Date { get; set; }

    }
}
