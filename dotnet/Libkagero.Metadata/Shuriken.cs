using System.Text.Json;

namespace Libkagero.Metadata {
    public class Shuriken : ToStringFrom
    {
        public string package { get; set; }
        public string hash { get; set; }
        public string platform { get; set; }
        public string arch { get; set; }
        public Data data { get; set; }
        public Shuriken(string package, string platform, string arch, string hash, Data data)
        {
            this.package = package;
            this.platform = platform;
            this.arch = arch;
            this.hash = hash;
            this.data = data;
        }
        public Shuriken(string jsonText) {
            Shuriken dummy = JsonSerializer.Deserialize<Shuriken>(jsonText);
            this.package = dummy.package;
            this.platform = dummy.platform;
            this.arch = dummy.arch;
            this.hash = dummy.hash;
            this.data = dummy.data;
        }
        
    }
    public class Data : ToStringFrom
    {
        public string path { get; set; }
        public string type { get; set; }
        public Data(string path, string type)
        {
            this.path = path;
            this.type = type;
        }
    }
}