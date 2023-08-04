using Microsoft.Extensions.FileProviders.Physical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDataReader
{
    internal class DirectoryProvider
    {
        public static DirectoryInfo TrySlnDirectory(string? currentPath = null)
        {
            var directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());

            while (directory != null  &&  !directory.GetFiles("*.sln").Any()) { 
               directory = directory.Parent; 
            }
            return directory;
         }
    }
}
