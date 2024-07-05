using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace AutoRechner.Edit
{
    public class PartList
    {
        private HashSet<string> parts = new HashSet<string>();

        public HashSet<string> Parts { get { return parts; } }

        public PartList()
        {
            parts = IsolatedDiskStorage.LoadPartsList();  
        }

        public void Save()
        {
            IsolatedDiskStorage.SavePartsList(parts);
        }

        public void AddPart(string part)
        {
            if(!parts.Contains(part)) parts.Add(part);
        }

        public void RemovePart(string part)
        {
            parts.Remove(part);
        }

        public IEnumerable<string> FindMatching(string pattern)
        {
            return parts.Where(x => x.IndexOf(pattern, StringComparison.OrdinalIgnoreCase) >= 0).Take(10);
        }
    }
}
