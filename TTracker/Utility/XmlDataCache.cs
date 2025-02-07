﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using TTracker.Interfaces;

namespace TTracker.Utility
{
    internal class XmlDataCache
    {

        private string _saveDataPath = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Data\\";

        /// <summary>
        /// Writes the data that is given into the list into a xml file. 
        /// Split like this: "Name/" + user.Name
        /// </summary>
        /// <param name="directoryName"></param>
        /// <param name="data"></param>
        public void SaveNewToXml(string directoryName, Guid Id, List<string> data)
        {
            try
            {
                Directory.CreateDirectory(_saveDataPath + directoryName);
                string xmlPath = _saveDataPath + directoryName + "\\";
                string xmlName = Id.ToString() + ".xml";
                string fullLocationPath = xmlPath + xmlName;

                //So that the xmlWriter makes breaks between lines
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.NewLineOnAttributes = true;
                xmlWriterSettings.Indent = true;

                using (XmlWriter writer = XmlWriter.Create(fullLocationPath, xmlWriterSettings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Data");

                    foreach (var s in data)
                    {
                        string[] splitedString = s.Split(new char[] { '/' });
                        string dataName = splitedString[0];
                        var splitedStringValueAsOne = string.Empty;
                        for (int i = 1; i < splitedString.Length; i++)
                        {
                            if (i > 1)
                            {
                                splitedStringValueAsOne = splitedStringValueAsOne + "/" + splitedString[i];
                            }
                            else
                            {
                                splitedStringValueAsOne = splitedStringValueAsOne + splitedString[i];
                            }
                        }
                        string dataValue = splitedStringValueAsOne;

                        writer.WriteElementString(dataName, dataValue);
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An exception in the XmlDataCache - SaveNewToXml threw an error: {ex.Message}");
            }

        }

        /// <summary>
        /// This takes in a XmlDocument and a list of changedProperties
        /// It overwrites to the current doc the new propertyValues
        /// </summary>
        /// <param name="saveableXmlDoc"></param>
        /// <param name="changedProperties"></param>
        public void OverwriteSaveToXml<T>(XDocument saveableXmlDoc, List<string> changedProperties)
        {
            try
            {
                //split the Name/Hans string
                var changedPropertyName = new List<string>();
                var changedPropertyValue = new List<string>();

                //Gets the ID/Name of the doc
                string docId = string.Empty;

                //Split the changed Data
                foreach (var data in changedProperties)
                {
                    string[] splitedString = data.Split(new char[] { '/' });
                    var splitedValueAsOne = string.Empty;
                    for (int i = 1; i < splitedString.Length; i++)
                    {
                        if (i > 1)
                        {
                            splitedValueAsOne = splitedValueAsOne + "/" + splitedString[i];
                        }
                        else
                        {
                            splitedValueAsOne = splitedValueAsOne + splitedString[i];
                        }
                    }
                    changedPropertyName.Add((splitedString[0] + ">"));
                    changedPropertyValue.Add(splitedValueAsOne);
                }

                //Go through all elements. Search for elementName. When matched with any propertyName, change Value of elemtn
                var docElements = saveableXmlDoc.Root.Elements();
                foreach (var element in docElements)
                {
                    string[] splitedString = element.ToString().Split(new char[] { '/' });
                    var elementName = splitedString[1];

                    if (elementName == "Id>")
                    {
                        docId = element.Value;
                    }

                    if (changedPropertyName.Contains(elementName))
                    {
                        var index = changedPropertyName.IndexOf(elementName);
                        element.Value = changedPropertyValue.ElementAt(index);
                        changedPropertyName.RemoveAt(index);
                        changedPropertyValue.RemoveAt(index);
                    }
                }

                //When a property hasent been added to the xml yet, then add it.
                if (changedPropertyName.Count > 0 && changedPropertyValue.Count > 0)
                {
                    foreach (var addablePropertyName in changedPropertyName)
                    {
                        var index = changedPropertyName.IndexOf(addablePropertyName);
                        var name = addablePropertyName.Remove(addablePropertyName.Length - 1);
                        var value = changedPropertyValue.ElementAt(index);
                        XElement root = saveableXmlDoc.Root;
                        root.Add(new XElement(name, value));
                    }
                }

                var fullSavePath = _saveDataPath + typeof(T).Name + "s\\" + docId + ".xml";
                saveableXmlDoc.Save(fullSavePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An exception in the XmlDataCache - OverwriteSaveToXml threw an error: {ex.Message}");
            }

        }

        /// <summary>
        /// This takes in a xmlFile and deletes it from the XmlDataCache
        /// </summary>
        public void DeleteTFromXmlCache<T>(XDocument deletableXmlDoc)
        {
            var upperFolderName = typeof(T).Name;
            var docId = string.Empty;

            var docElements = deletableXmlDoc.Root.Elements();
            foreach (var element in docElements)
            {
                string[] splitedString = element.ToString().Split(new char[] { '/' });
                var elementName = splitedString[1];

                if (elementName == "Id>")
                {
                    docId = element.Value;
                }
            }

            var fullDeletePath = _saveDataPath + upperFolderName + "s\\" + docId + ".xml";
            File.Delete(fullDeletePath);
        }

        /// <summary>
        /// This takes in a xmlFilePath and returns a List<string> that contains the data
        /// formatted like Name/Value
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <returns></returns>
        public List<string> GetXmlDataByXmlPath(string xmlFilePath)
        {
            var doc = XDocument.Load(xmlFilePath);
            var docElements = doc.Root.Elements();

            List<string> data = new List<string>();

            foreach (var element in docElements)
            {
                data.Add(element.Name + "/" + element.Value);
            }
            return data;
        }

        public List<XDocument> GetAllXmlFilesFromDirectory<T>()
        {
            var allDoc = new List<XDocument>();

            try
            {
                //Gets the type of generic T
                var result = typeof(T);
                var directoryName = result.Name;
                //Path of directory all xml files should be loaded from
                string directoryXmlPath = _saveDataPath + directoryName + "s\\";

                //Stores all the file Names in an array
                if (!(Directory.Exists(directoryXmlPath)))
                {
                    var createDicPath = directoryXmlPath.Remove(directoryXmlPath.Length - 1);
                    Directory.CreateDirectory(createDicPath);
                }
                string[] files = Directory.GetFiles(directoryXmlPath);
                //Saves all docs in direcotry

                //Foreach file in files Directory
                foreach (var file in files)
                {
                    //Read every file. File is the path
                    var doc = XDocument.Load(file);
                    allDoc.Add(doc);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An exception in the XmlDataCache - GetAllXmlFilesFromDirectory threw an error: {ex.Message}");
            }

            return allDoc;
        }

    }
}
