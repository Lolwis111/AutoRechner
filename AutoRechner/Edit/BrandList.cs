using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRechner.Edit
{
    public class BrandList
    {
        public HashSet<string> Brands { get; } = new HashSet<string>();

        public BrandList()
        {
            Brands = IsolatedDiskStorage.LoadBrandsList();  
        }

        public void Save()
        {
            IsolatedDiskStorage.SaveBrandList(Brands);
        }

        public void AddBrand(string brand)
        {
            if(!Brands.Contains(brand)) Brands.Add(brand);
        }

        public void RemoveBrand(string brand)
        {
            Brands.Remove(brand);
        }

        public IEnumerable<string> FindMatching(string pattern)
        {
            return Brands.Where(x => x.IndexOf(pattern, StringComparison.OrdinalIgnoreCase) >= 0).Take(10);
        }
    }
}
