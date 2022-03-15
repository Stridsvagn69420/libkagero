using System.Collections.Generic;
using System.Text.Json;

namespace Libkagero.Metadata
{
    public class Katana : ToStringFrom {
        public string uuid { get; set; }
        public string website { get; set; }
        public string root { get; set; }
        public string name { get; set; }
        public List<Maintainer> maintainers { get; set; }
        public List<string> shurikens { get; set; }
        public Katana(string jsonText) {
            Katana dummy = JsonSerializer.Deserialize<Katana>(jsonText);
            this.name = dummy.name;
            this.maintainers = dummy.maintainers;
            this.root = dummy.root;
            this.shurikens = dummy.shurikens;
            this.uuid = dummy.uuid;
            this.website = dummy.website;
        }
    }
    public class Maintainer : ToStringFrom
    {
        public string name { get; set; }
        public string email { get; set; }
        public string profile { get; set; }
        public Maintainer(string jsonText) {
            Maintainer dummy = JsonSerializer.Deserialize<Maintainer>(jsonText);
            this.name = dummy.name;
            this.email = dummy.email;
            this.profile = dummy.profile;
        }
        public Maintainer(string name, string email, string profile) {
            this.name = name;
            this.email = email;
            this.profile = profile;
        }
    }
}