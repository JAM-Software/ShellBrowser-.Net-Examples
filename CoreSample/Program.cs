using System;
using Jam.Shell;
    
namespace CoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 3)
                    throw new ArgumentException(String.Format("Missing parameter!\nUsage \"{0}\" CanonicalShellColumnId [GET | SET PropertyValue] File(s) \n\nNote that files must be absolute paths and enquoted.\n\nExample: To set property \"Artist\" of an .mp3 file use \"{0}\" System.Music.Artist \"Great Artist\" \"C:\\Users\\Public\\album.mp3\".\n\nVisit https://msdn.microsoft.com/en-us/library/windows/desktop/mt805470(v=vs.85).aspx for more properties.", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName));

                SHCOLUMNID lShellColumnId = new SHCOLUMNID(args[0]);

                if (lShellColumnId.IsInvalid())
                    throw new ArgumentException("Invalid canonical property name. Use e.g. System.Music.Artist");

                bool lSetProperty = args[1].Equals("SET", StringComparison.OrdinalIgnoreCase);

                for (int i = (lSetProperty ? 3 : 2); i < args.Length; i++)
                {
                    ItemIdList itemIdList = new ItemIdList(args[i]);

                    if (itemIdList.IsInvalid)
                    {
                        Console.WriteLine("\"{0}\" is invalid", args[i]);
                        continue;
                    }

                    // Get or set properties
                    if (lSetProperty)
                    {
                        Console.WriteLine("Setting property \"{0}\" with value \"{1}\" of \"{2}\"", lShellColumnId.ToString(), args[2], args[i]);
                        itemIdList.SetPropertyValue(lShellColumnId, args[2]);

                        if (!args[2].Equals(itemIdList.GetPropertyDisplayValue(lShellColumnId)))
                            Console.WriteLine("Failed to set property \"{0}\" with value \"{1}\" of \"{2}\"", lShellColumnId.ToString(), args[2], args[i]);
                    }
                    else
                    {
                        Console.WriteLine("Property \"{0}\" of \"{1}\" is \"{2}\"", lShellColumnId.ToString(), args[i], itemIdList.GetPropertyDisplayValue(lShellColumnId));
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("[Error] " + e.Message);
            }
            finally
            {
                Console.WriteLine("Done. Press enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
