using ModLib;

/// SEVT3 = Group

namespace SEEditor.SEVT
{
    internal class SEVT3 : ISoundEvent
    {
        public Type SEType { get; set; } = typeof(SEVT3);

        public void Read(ModFile file)
        {
            ushort one = file.ReadUshort(true); // Assumed for SEVT3
            byte byte1 = file.ReadByte();
            byte byte2 = file.ReadByte();
            byte byte3 = file.ReadByte();
            byte byte4 = file.ReadByte();
            byte byte5 = file.ReadByte();

            if (byte5 != 0)
            {
                return;
            }

            byte roar = file.ReadByte();
            uint unknown3 = file.ReadUint(true);

            ushort declarations = file.ReadUshort(true);
            //Console.WriteLine(declarations);
        }
    }
}
