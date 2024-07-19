using System.Text.Json.Serialization;

namespace Todo_App.Models
{
    public class TodoRequest
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public DateTime  DateCreated { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExecutionTime { get; set; }
        [JsonIgnore]
        public bool Isdeleted { get; set; }
    }
}
