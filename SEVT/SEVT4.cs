using ModLib;

namespace SEEditor.SEVT
{
    internal class SEVT4
    {
        public Type SEType { get; set; } = typeof(SEVT4);

        public bool ReadABitLonger = false;

        public void Read(ModFile file)
        {
            ushort unknown1 = file.ReadUshort(true);

            byte unknown2 = file.ReadByte();
            byte unknown3 = file.ReadByte();

            ushort unknown4 = file.ReadUshort(true);
            ushort unknown5 = file.ReadUshort(true);
            byte unknown6 = file.ReadByte();
            byte unknown7 = file.ReadByte();

            byte strings = file.ReadByte();
            string[] mixes = new string[strings];
            for (int i = 0; i < strings; i++)
            {
                string mix = file.ReadString(file.ReadUshort(true));
                //Console.WriteLine(mix);
                mixes[i] = mix;
            }

            if (unknown7 > 0)
            {
                byte roar = file.ReadByte();
                if (roar == 1)
                {
                    file.Seek(23, SeekOrigin.Current);

                    float twenty = file.ReadFloat(true);
                    float oneeighty = file.ReadFloat(true);
                    float seventy = file.ReadFloat(true);

                    float zero1 = file.ReadFloat(true);
                    float zero2 = file.ReadFloat(true);
                    float zero3 = file.ReadFloat(true);
                    float zero4 = file.ReadFloat(true);
                    float zero5 = file.ReadFloat(true);

                    float one1 = file.ReadFloat(true);

                    float zero6 = file.ReadFloat(true);
                    float zero7 = file.ReadFloat(true);

                    float near = file.ReadFloat(true);
                    float far = file.ReadFloat(true);

                    float volume = file.ReadFloat(true);

                    float randVol = file.ReadFloat(true);

                    float one2 = file.ReadFloat(true); // MIGHT BE PITCH

                    float randPitch = file.ReadFloat(true);
                    float zero10 = file.ReadFloat(true);

                    float one3 = file.ReadFloat(true);

                    float zero11 = file.ReadFloat(true);

                    float one4 = file.ReadFloat(true);

                    float zeropoint1 = file.ReadFloat(true);

                    float reverbWetMix = file.ReadFloat(true);

                    float zero12 = file.ReadFloat(true);
                    float zero13 = file.ReadFloat(true);
                    float zero14 = file.ReadFloat(true);

                    float one5 = file.ReadFloat(true);
                    float one6 = file.ReadFloat(true);
                    float one7 = file.ReadFloat(true);

                    string location = file.ReadString(file.ReadUshort(true));
                    //Console.WriteLine(location);

                    string mixType = file.ReadString(file.ReadUshort(true));

                    string outputType = file.ReadString(file.ReadUshort(true));
                }
                else
                {
                    file.Seek(7, SeekOrigin.Current); // Some bytes here that I don't know about
                }
            }
        }
    }
}
