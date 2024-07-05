using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO.IsolatedStorage;

namespace AutoRechner
{
    public static class IsolatedDiskStorage
    {
        private static IsolatedStorageFile isoStore_ = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

        private const string databaseFileName = "auto_datenbank.xml";
        private const string partslistFileName = "parts_list.txt";
        private const string brandslistFileName = "brands.txt";
        private const string settingsFileName = "settings.xml";


        public static void SaveCars(List<Car> cars)
        {
            try
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(databaseFileName, FileMode.Create, isoStore_))
                {
                    using (TextWriter tw = new StreamWriter(isoStream))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
                        serializer.Serialize(tw, cars);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExporCars(List<Car> cars, string destination)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(File.Open(destination, FileMode.Create)))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
                    serializer.Serialize(tw, cars);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<Car> LoadCars()
        {
            List<Car> cars = new List<Car>();

            IsolatedStorageFileStream isoStream = null;
            StreamReader reader = null;

            try
            {
                if (isoStore_.FileExists(databaseFileName))
                {
                    isoStream = new IsolatedStorageFileStream(databaseFileName, FileMode.Open, isoStore_);
                    
                    reader = new StreamReader(isoStream);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
                    cars = (List<Car>)serializer.Deserialize(reader);   
                }
                else
                {
                    MessageBox.Show($"{Properties.GUIStrings.ErrorNoDatabaseFile} {Properties.GUIStrings.FirstStart}", Properties.GUIStrings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader?.Dispose();
                isoStream?.Dispose();
            }

            return cars;
        }

        public static void SavePartsList(HashSet<string> parts)
        {
            try
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(partslistFileName, FileMode.Create, isoStore_))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        foreach (string part in parts)
                        {
                            writer.WriteLine(part);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static HashSet<string> LoadPartsList()
        {
            HashSet<string> parts = new HashSet<string>();

            try
            {
                if (isoStore_.FileExists(partslistFileName))
                {
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(partslistFileName, FileMode.Open, isoStore_))
                    {
                        using (StreamReader reader = new StreamReader(isoStream))
                        {
                            while (!reader.EndOfStream)
                            {
                                parts.Add(reader.ReadLine());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return parts;
        }

        public static void SaveBrandList(HashSet<string> brands)
        {
            try
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(brandslistFileName, FileMode.Create, isoStore_))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        foreach (string brand in brands)
                        {
                            writer.WriteLine(brand);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static HashSet<string> LoadBrandsList()
        {
            HashSet<string> brands = new HashSet<string>();

            try
            {
                if (isoStore_.FileExists(brandslistFileName))
                {
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(brandslistFileName, FileMode.Open, isoStore_))
                    {
                        using (StreamReader reader = new StreamReader(isoStream))
                        {
                            while (!reader.EndOfStream)
                            {
                                brands.Add(reader.ReadLine());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return brands;
        }

        public static void SaveSettings(SettingsManager settings)
        {
            try
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(settingsFileName, FileMode.Create, isoStore_))
                {
                    using (TextWriter tw = new StreamWriter(isoStream))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(SettingsManager));
                        serializer.Serialize(tw, settings);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static SettingsManager LoadSettings()
        {
            SettingsManager settings = new SettingsManager();
            settings.Users.Add(Properties.Resources.UserNone);

            try
            {
                if (isoStore_.FileExists(settingsFileName))
                {
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(settingsFileName, FileMode.Open, isoStore_))
                    {
                        using (TextReader sr = new StreamReader(isoStream))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(SettingsManager));
                            settings = (SettingsManager)serializer.Deserialize(sr);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"{Properties.GUIStrings.ErrorNoSettingsFile} {Properties.GUIStrings.FirstStart}", Properties.GUIStrings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.GUIStrings.ErrorPrefix + ex.Message, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return settings;
        }
    }
}
