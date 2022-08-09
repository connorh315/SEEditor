using ModLib;

namespace SEEditor.SEVT
{
    internal class SEVTA
    {
        public Type SEType { get; set; } = typeof(SEVTA);

        public void Read(ModFile file)
        {
            ushort one = file.ReadUshort(true);
            byte four = file.ReadByte(); // Always 4
            byte one1 = file.ReadByte(); // Always 1
            byte byte5 = file.ReadByte(); // Always 0
            byte byte6 = file.ReadByte(); // Types: 5, 9 (4015, 6)
            byte type = file.ReadByte(); // Types: 5, 1, 2, 0 (325, 3637, 7, 52)

            //Copilot.Type(type, ((FileStream)file.fileStream).Name);

            file.Seek(16, SeekOrigin.Current);
            if (type == 5)
            {
                new SEVT6().ReadShort(file);
            }
            else if (type == 1)
            {
                new SEVT6().Read(file);
            }
        }
    }
}
