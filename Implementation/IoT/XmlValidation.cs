using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace IoT
{
    class XmlValidation
    {
        static string thingSchema, thingXML = "";
        static string requesterSchema= "", requesterXML = "";
        static bool thingError, requesterError;
     
        XmlReaderSettings settingsRequester = new XmlReaderSettings();
        XmlReader readerRequester;


        public void addThingschema(string path)
        {
            thingSchema = path;
        }
        public void addThingXML(string path)
        {
            thingXML = path;
        }

        public void addRequesterSchema(string path)
        {
            requesterSchema = path;
        }
        public void addRequesterXML(string path)
        {
            requesterXML = path;
        }


        public Boolean validateThing()
        {
            if(thingSchema == null)
            {
                System.Windows.Forms.MessageBox.Show("Upload a Schema First!");
                return false;
            }

            thingError = false;

            XmlReaderSettings settingsThing = new XmlReaderSettings();
            // Set the validation settings.
            settingsThing.ValidationType = ValidationType.Schema;
            settingsThing.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settingsThing.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settingsThing.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settingsThing.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            settingsThing.Schemas.Add(null, thingSchema);

            XmlReader readerThing = XmlReader.Create(thingXML, settingsThing);
            Console.Out.WriteLine(readerThing.ReadInnerXml());
            // Parse the file. 
            while (readerThing.Read()) ;

            if (thingError == true)
                return false;
            return true;
           

        }

        public Boolean validateRequester()
        {
            if (requesterSchema == null)
            {
                System.Windows.Forms.MessageBox.Show("Upload a Schema First!");
                return false;
            }
            requesterError = false;
            XmlReaderSettings settingsRequester = new XmlReaderSettings();
            // Set the validation settings.
            settingsRequester.ValidationType = ValidationType.Schema;
            settingsRequester.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settingsRequester.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settingsRequester.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settingsRequester.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            settingsRequester.Schemas.Add(null, requesterSchema);

            XmlReader readerRequester = XmlReader.Create(requesterXML, settingsRequester);
            Console.Out.WriteLine(readerRequester.ReadInnerXml());

            // Parse the file. 
            while (readerRequester.Read()) ;

            if (requesterError == true)
                return false;
            return true;

        }
        // Display any warnings or errors.
        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                System.Windows.Forms.MessageBox.Show("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            else
                System.Windows.Forms.MessageBox.Show("\tValidation error: " + args.Message);
            thingError = true;
        }
        private static void ValidationCallBack1(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                System.Windows.Forms.MessageBox.Show("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            else
                System.Windows.Forms.MessageBox.Show("\tValidation error: " + args.Message);
            requesterError = true;
        }

    }
}
