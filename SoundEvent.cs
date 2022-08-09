using ModLib;
using SEEditor.SEVT;

namespace SEEditor
{
    internal class SoundEvent
    {
        public static bool Read(string fileLocation)
        {
            SoundEvent se = new();

            using (ModFile file = ModFile.Open(fileLocation))
            {
                uint mainLength = file.ReadUint(true);

                while (file.Position < file.fileStream.Length - 4)
                {
                    string sign = file.ReadString(4);
                    //if (sign == "\x0\x0\x0") { return se; }
#if FINDBROKEN
                    if (sign != "TVES") { /*Logger.Warn("Paused execution due to error offset ({0}) in file {1}!", file.Position.ToString(), fileLocation);*/ return false; }
#else
                    if (sign != "TVES") { Logger.Warn("Paused execution due to error offset ({0}) in file {1}!", file.Position.ToString(), fileLocation); return false; }
#endif

                    uint version = file.ReadUint(true);

                    uint type = file.ReadUint(true);

                    uint uuid = file.ReadUint(true);

                    switch (type)
                    {
                        case 0:
                            new SEVT0().Read(file);
                            break;
                        case 1:
                            new SEVT1().Read(file);
                            break;
                        case 2:
                            new SEVT2().Read(file);
                            break;
                        case 3:
                            new SEVT3().Read(file);
                            break;
                        case 4:
                            new SEVT4().Read(file);
                            break;
                        case 6:
                            new SEVT6().Read(file);
                            break;
                        case 7:
                            new SEVT7().Read(file);
                            break;
                        case 8:
                            new SEVT8().Read(file);
                            break;
                        case 9:
                            new SEVT9().Read(file);
                            break;
                        case 0xA:
                            new SEVTA().Read(file);
                            break;
                        default:
                            //Console.WriteLine(fileLocation);
                            //Console.WriteLine("Unknown SEVT Type: " + type);
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
