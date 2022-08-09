using ModLib;

namespace SEEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

#if FINDBROKEN
            int successful = 0;
            int failed = 0;

            string[] failedPaths = new string[10];
            int offset = 0;

            foreach (string path in Directory.EnumerateFiles(@"G:\", "*.*"))
            {
                if (offset == 10)
                {
                    offset = 0;
                }

                try
                {
                    bool success = SoundEvent.Read(path);
                    if (success)
                    {
                        successful++;
                    }
                    else
                    {
                        failed++;
                        failedPaths[offset] = path;
                        offset++;
                    }
                }
                catch (Exception ex)
                {
                    failed++;
                    failedPaths[offset] = path;
                    offset++;
                }
            }

            foreach (string path in failedPaths)
            {
                Console.WriteLine(path);
            }

            foreach (KeyValuePair<byte, int> entry in Copilot.count)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value + " - " + Copilot.examples[entry.Key]);
            }

            Console.WriteLine("Success: {0}", successful);
            Console.WriteLine("Failed: {0}", failed);
#endif
            // ~2050 failed
            //SoundEvent se = SoundEvent.Read(@"A:\Dimensions\EXTRACT\AUDIO\EVENTS\DX_JOKER_ENTRANCE.SOUND_EVENT");
#if DEBUG
            Console.WriteLine(SoundEvent.Read(@"G:\WPN_KNIGHTBOSS_FORTCANNON_IMP.SOUND_EVENT"));
#endif
            //SoundEvent se = SoundEvent.Read(@"A:\Dimensions\EXTRACT\AUDIO\EVENTS\DX_10RETROGAMESA_CONV01.SOUND_EVENT");
            //SoundEvent se = SoundEvent.Read(@"A:\Dimensions\EXTRACT\AUDIO\EVENTS\8BIT_BEEP.SOUND_EVENT");

        }
    }
}