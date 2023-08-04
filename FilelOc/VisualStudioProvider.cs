using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilelOc
{
    public static class VisualStudioProvider
    {
        public static  DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());


            while (directory != null && !directory.GetFiles("*.sln").Any())
            {

                directory = directory.Parent;
            }
            return directory;
        }
    }
}
