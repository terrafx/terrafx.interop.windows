// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D2D1_VERTEX_BUFFER_PROPERTIES
    {
        [NativeTypeName("UINT32")]
        public uint inputCount;

        public D2D1_VERTEX_USAGE usage;

        [NativeTypeName("const BYTE *")]
        public byte* data;

        [NativeTypeName("UINT32")]
        public uint byteWidth;
    }
}
