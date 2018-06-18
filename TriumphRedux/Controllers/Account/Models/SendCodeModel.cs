using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TriumphRedux.Controllers.Account.Models
{
    public class SendCodeModel
    {
        [Required]
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("remember")]
        public bool Remember { get; set; }
    }
}
