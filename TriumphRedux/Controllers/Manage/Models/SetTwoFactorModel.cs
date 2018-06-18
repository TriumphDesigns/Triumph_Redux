using Newtonsoft.Json;

namespace TriumphRedux.Controllers.Manage.Models
{
    public class SetTwoFactorModel
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
