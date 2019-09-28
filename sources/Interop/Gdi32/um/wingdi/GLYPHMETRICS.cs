
// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct GLYPHMETRICS
    {
        [NativeTypeName("UINT")]
        public uint gmBlackBoxX;

        [NativeTypeName("UINT")]
        public uint gmBlackBoxY;

        public POINT gmptGlyphOrigin;

        public short gmCellIncX;

        public short gmCellIncY;
    }
}
