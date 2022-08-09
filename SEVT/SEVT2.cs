using ModLib;

namespace SEEditor.SEVT
{
    internal class SEVT2
    {
        public Type SEType { get; set; } = typeof(SEVT2);

        public void Read(ModFile file)
        {
            //Console.WriteLine(((FileStream)file.fileStream).Name);

            byte byte1 = file.ReadByte();
            byte byte2 = file.ReadByte();
            byte byte3 = file.ReadByte();
            byte byte4 = file.ReadByte();
            byte byte5 = file.ReadByte();
            byte byte6 = file.ReadByte();
            byte byte7 = file.ReadByte();

            if (byte7 != 0)
            {
                return;
            }

            file.Seek(24, SeekOrigin.Current); // Unknown

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
            //Console.WriteLine("Volume: {0}", volume);

            float zero8 = file.ReadFloat(true);

            float one2 = file.ReadFloat(true);

            float zero9 = file.ReadFloat(true);
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

            byte unknownX = file.ReadByte();
            byte unknownY = file.ReadByte();
            byte unknownZ = file.ReadByte();
        }
    }
}
