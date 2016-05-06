using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ParallelExtensions
{
    /// <summary>
    /// Traverses file system and performs operations over file.
    /// </summary>
    public class FileSystemTraverse
    {
        private const int RepeatCount = 1000;

        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = null;
            try
            {
                fileEntries = Directory.GetFiles(targetDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            if (fileEntries != null)
            {
                Parallel.ForEach(fileEntries, f => ProcessFile(f));
                //foreach (string fileName in fileEntries)
                //{
                //    ProcessFile(fileName);
                //}
            }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = null;
            try
            {
                subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            if (subdirectoryEntries != null)
            {
                foreach (string subdirectory in subdirectoryEntries)
                {
                    ProcessDirectory(subdirectory);
                }
            }
        }

        private static void ProcessFile(string path)
        {
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        for (int i = 0; i < RepeatCount; i++)
                        {
                            md5.ComputeHash(stream);
                        }
                    }
                }

                Console.WriteLine($"Processed {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
