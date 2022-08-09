using ModLib;

/// SEVT6 = Sample

namespace SEEditor.SEVT
{
    internal class SEVT6
    {
        public Type SEType { get; set; } = typeof(SEVT6);

        public void Read(ModFile file)
        {
            ushort unknown1 = file.ReadUshort(true);
            byte unknown2 = file.ReadByte();
            byte unknown3 = file.ReadByte();
            ushort unknown4 = file.ReadUshort(true);
            ushort unknown5 = file.ReadUshort(true);
            byte unknown6 = file.ReadByte();
            ushort unknown7 = file.ReadUshort(true);

            string name = file.ReadString(file.ReadInt(true));

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

            byte byte1 = file.ReadByte();
            byte byte2 = file.ReadByte();
            ushort short2 = file.ReadUshort(true);
            byte byte3 = file.ReadByte();
            byte characterCount = file.ReadByte();

            for (int i = 0; i < characterCount; i++)
            {
                byte byte5 = file.ReadByte();
                byte byte6 = file.ReadByte();
                byte byte7 = file.ReadByte();

                string charName = file.ReadString(file.ReadUshort(true));
                //Console.WriteLine(charName);
                uint zero15 = file.ReadUint(true);
                uint zero16 = file.ReadUint(true);
            }


        }

        public void ReadShort(ModFile file)
        {
            ushort unknown1 = file.ReadUshort(true);
            byte unknown2 = file.ReadByte();
            byte unknown3 = file.ReadByte();
            ushort unknown4 = file.ReadUshort(true);
            ushort unknown5 = file.ReadUshort(true);
            byte unknown6 = file.ReadByte();
            ushort unknown7 = file.ReadUshort(true);

            string name = file.ReadString(file.ReadInt(true));
        }
    }
}
