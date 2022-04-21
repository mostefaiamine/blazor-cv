using MyResumeBlazor;
using Newtonsoft.Json;
using System.IO;
using Xunit;

namespace MyResume.Tests
{
    public class ParseTest
    {
        [Fact]
        public void ParseDataTest()
        {
            var path = Path.Combine(System.Environment.CurrentDirectory, "data/cv.json");
            Assert.True(File.Exists(path));
            var str = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<CVInfo>(str);
            Assert.NotNull(data);
        }
    }
}