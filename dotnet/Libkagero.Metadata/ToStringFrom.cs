using System.Text.Json;

namespace Libkagero.Metadata {
    public class ToStringFrom {
        public string toString() {
            return JsonSerializer.Serialize(this);
        }
        public static string toString(Shuriken katana) {
            return JsonSerializer.Serialize(katana);
        }
        public static Shuriken fromString(string json) {
            return JsonSerializer.Deserialize<Shuriken>(json);
        }
    }
}