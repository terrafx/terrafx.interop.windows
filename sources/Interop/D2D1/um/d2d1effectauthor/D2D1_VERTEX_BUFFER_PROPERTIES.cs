// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>This defines the properties of a vertex buffer which uses the default vertex layout.</summary>
    public unsafe partial struct D2D1_VERTEX_BUFFER_PROPERTIES
    {
        [NativeTypeName("UINT32")]
        public uint inputCount;

        public D2D1_VERTEX_USAGE usage;

        [NativeTypeName("BYTE[]")]
        public byte* data;

        [NativeTypeName("UINT32")]
        public uint byteWidth;
    }
}
