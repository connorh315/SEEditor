using ModLib;

namespace SEEditor.SEVT
{
    internal class SEVT0
    {
        public Type SEType { get; set; } = typeof(SEVT0);

        public void Read(ModFile file)
        {
            ushort unknown1 = file.ReadUshort(true);
            byte unknown2 = file.ReadByte();
            byte unknown3 = file.ReadByte();
            ushort unknown4 = file.ReadUshort(true);
            byte unknown5 = file.ReadByte();
        }
    }
}
