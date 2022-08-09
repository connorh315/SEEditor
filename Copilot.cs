using ModLib;

// File that should not be referenced in Release builds, purely for debugging/RE etc.
namespace SEEditor
{
    internal static class Copilot
    {
        public static Dictionary<byte, int> count = new();
        public static Dictionary<byte, List<string>> examples = new();

        public static void Type(byte type, string path)
        {
            if (count.ContainsKey(type))
            {
                count[type]++;
            }
            else
            {
                count[type] = 1;
                examples.Add(type, new List<string>());
            }

            examples[type].Add(path);
        }

        public static void AggressiveCompare()
        {
            foreach (string path in Directory.EnumerateFiles(@"G:\", "*.*"))
            {
                using (ModFile file = ModFile.Open(path))
                {
                    int offset = 0;
                    bool found = false;
                    while (true)
                    {
                        if (offset + 5 > file.fileStream.Length) break;

                        file.Seek(offset, SeekOrigin.Begin);
                        if (file.ReadByte() == 0x4d) // m
                        {
                            if (file.ReadByte() == 0x69) // i
                            {
                                if (file.ReadByte() == 0x78) // x
                                {
                                    if (file.ReadByte() == 0x53) // S
                                    {
                                        if (file.ReadByte() == 0x6f) // o
                                        {
                                            found = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        offset++;
                    }

                    if (found)
                    {
                        file.Seek(offset + 15, SeekOrigin.Begin);
                        if (file.ReadString(4) != "TVES")
                        {
                            file.Seek(offset + 15, SeekOrigin.Begin);
                            Console.WriteLine(BitConverter.ToString(file.ReadArray(9)).Replace("-", ""));
                        }
                    }
                }
            }
        }

        public static void FilesStartWith()
        {
            foreach (string path in Directory.EnumerateFiles(@"G:\", "*.*"))
            {
                using (ModFile file = ModFile.Open(path))
                {
                    file.Seek(15, SeekOrigin.Begin);

                    Copilot.Type(file.ReadByte(), path);
                }
            }

            Random rand = new Random();
            foreach (KeyValuePair<byte, int> entry in Copilot.count)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value + ":");
                for (int i = 0; i < Math.Min(10, entry.Value); i++)
                {
                    Logger.Log(new LogSeg("  {0}", ConsoleColor.Green, Copilot.examples[entry.Key][rand.Next(entry.Value)].ToString()));
                }
            }
        }
    }
}
