using Google.Protobuf;
using System.Collections.Generic;
using static Protobuf.Person.Types;

namespace Protobuf
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jesus = new()
            {
                Id = 1234,
                Name = "Jesus",
                Email = "jesus@jerusalem.com",
                Phones =
                {
                    new PhoneNumber
                    {
                        Number = "1234567890",
                        Type = PhoneType.Mobile
                    }
                }
            };

            // Collections are get-only, use .Add to mutate the list
            // See https://stackoverflow.com/a/16618870/7177029
            jesus.Aliases.Add(new[] { "Water walker", "Wine maker" });
            jesus.Kvs.Add(new Dictionary<string, string>
            {
                ["WineMaker"] = "Jesus",
                ["WaterWalker"] = "Jesus"
            });

            // Serialize to byte array
            byte[] b = jesus.ToByteArray();

            // Deserialize back
            Person jesusResurrected = Person.Parser.ParseFrom(b);
        }
    }
}
