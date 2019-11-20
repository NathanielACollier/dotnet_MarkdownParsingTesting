using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarkdownParsingTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBasicImageFinding()
        {
            var testMarkdownText = System.IO.File.ReadAllText(@"../../../../markdownFiles/1.md");
            var doc = Markdig.Markdown.Parse(testMarkdownText);

            foreach( var img in FindImages(doc))
            {

            }
        }


        private IEnumerable<Markdig.Syntax.MarkdownObject> FindImages(IEnumerable<Markdig.Syntax.MarkdownObject> objects)
        {

            foreach (var obj in objects)
            {
                if( obj is IEnumerable<Markdig.Syntax.MarkdownObject> subObjects)
                {
                    foreach( var subObj in FindImages(subObjects))
                    {
                        // is it an image
                        yield return subObj;
                    }
                }else
                {
                    // is it an image
                    yield return obj;
                }
            }
        }
    }
}
