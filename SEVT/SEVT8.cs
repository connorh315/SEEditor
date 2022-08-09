using ModLib;

/// SEVT8 = Conversation

namespace SEEditor.SEVT
{
    internal class SEVT8 : ISoundEvent
    {
        public Type SEType { get; set; } = typeof(SEVT8);

        public void Read(ModFile file)
        {
            byte unknown1 = file.ReadByte();
            byte unknown2 = file.ReadByte();
            byte unknown3 = file.ReadByte();
            byte unknown4 = file.ReadByte();
            byte unknown5 = file.ReadByte();

            byte unknown6 = file.ReadByte();
            byte decCount = file.ReadByte();
            if (unknown6 >= 8)
            {
                int unknown8 = file.ReadInt(); // Wrong
                int unknown9 = file.ReadInt(); // Wrong
            }
            //Console.WriteLine(playPriority);

            for (int i = 0; i < decCount; i++)
            {
                file.Seek(16, SeekOrigin.Current);

                SEVT4 str = new SEVT4();
                str.ReadABitLonger = unknown6 == 5;
                str.Read(file);
            }
        }
    }
}
