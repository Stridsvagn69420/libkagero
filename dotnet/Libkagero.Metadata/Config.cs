using System.Collections.Generic;

namespace Libkagero.Metadata
{
    public class GitConfig : ToStringFrom
    {
        public string name { get; set; }
        public string email { get; set; }
        public string token { get; set; }
        public GitConfig(string name, string email, string token)
        {
            this.name = name;
            this.email = email;
            this.token = token;
        }
        
    }

    public class Config  : ToStringFrom
    {
        public GitConfig git { get; set; }
        public List<string> repos { get; set; }
    }
}