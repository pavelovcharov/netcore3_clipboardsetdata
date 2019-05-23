using NUnit.Framework;
using System;
using System.Windows;

namespace netcore3_clipboardsetdata {
    [TestFixture]
    public class TestClass {
        [Test]
        public void Test() {
            DataObject data = new DataObject();
            data.SetData(typeof(string), "SampleText");
            Clipboard.SetDataObject(data);
            string text = ((DataObject)Clipboard.GetDataObject()).GetText();
            Assert.AreEqual("SampleText", text);
        }
    }
}
