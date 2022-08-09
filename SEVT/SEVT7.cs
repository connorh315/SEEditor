using ModLib;

/// SEVT8 = Conversation

namespace SEEditor.SEVT
{
    internal class SEVT7 : ISoundEvent
    {
        public Type SEType { get; set; } = typeof(SEVT7);

        public void Read(ModFile file)
        {
            byte unknown1 = file.ReadByte();
            byte unknown2 = file.ReadByte();
            byte unknown3 = file.ReadByte();
            byte unknown4 = file.ReadByte();
            byte unknown5 = file.ReadByte();
            byte unknown6 = file.ReadByte();
            byte unknown7 = file.ReadByte();
        }
    }
}
