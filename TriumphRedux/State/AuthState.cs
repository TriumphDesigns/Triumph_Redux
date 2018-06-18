using Newtonsoft.Json;
using TriumphRedux.Models.Api;

namespace TriumphRedux.State
{
    public class AuthState
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("loggedIn")]
        public bool LoggedIn { get; set; }
    }
}
