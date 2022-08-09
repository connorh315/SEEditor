using ModLib;

namespace SEEditor.SEVT
{
    internal interface ISoundEvent
    {
        internal void Read(ModFile file);

        internal Type SEType { get; set; }
    }
}
