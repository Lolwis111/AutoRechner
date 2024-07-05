using AutoRechner.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AutoRechner.Settings
{
    public static class LanguageSelection
    {
        public static IEnumerable<CultureInfo> GetSupportedCulture()
        {
            //Get all culture 
            CultureInfo[] culture = CultureInfo.GetCultures(CultureTypes.AllCultures);

            //Find the location where application installed.
            string exeLocation = Path.GetDirectoryName(Uri.UnescapeDataString(new UriBuilder(Assembly.GetExecutingAssembly().CodeBase).Path));

            //Return all culture for which satellite folder found with culture code.
            return culture.Where(cultureInfo => !cultureInfo.Equals(CultureInfo.InvariantCulture) && Directory.Exists(Path.Combine(exeLocation, cultureInfo.Name)));
        }
    }
}
