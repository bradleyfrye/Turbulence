using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Turbulence
{
    public class FormController
    {
        private XmlDocument _xmlDoc;
        private XmlNodeList _bookList;
        private StartPage _startPage;

        public FormController()
        {
            initializeObjects();
            runApplication();
        }

        private void runApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiate startPage
            _startPage = new StartPage();

            Application.Run();
        }

        private void initializeObjects()
        {
            // initialize global xml variables
            _xmlDoc = new XmlDocument();

            // load file; create one if it doesn't exist
            if (!File.Exists("turbulence.xml"))
            {
                XmlNode rootNode = _xmlDoc.CreateElement("RootDoc");
                _xmlDoc.AppendChild(rootNode);
                _xmlDoc.Save("turbulence.xml");
            }
            else
            {
                _xmlDoc.Load("turbulence.xml");
            }

            // load all books (if any) for book selection display
            _bookList = _xmlDoc.SelectNodes("RootDoc/book");
        }
    }
}
