using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarkdownParsingTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBasicImageFinding()
        {
            var doc = Markdig.Markdown.Parse(System.IO.File.ReadAllText(@"../../examples/1.md"));

            
        }
    }
}
