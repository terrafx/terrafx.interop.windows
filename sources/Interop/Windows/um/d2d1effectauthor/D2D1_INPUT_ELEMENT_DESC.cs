// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>This defines a single element of the vertex layout.</summary>
    [Unmanaged]
    public unsafe struct D2D1_INPUT_ELEMENT_DESC
    {
        #region Fields
        [NativeTypeName("PCSTR")]
        public sbyte* semanticName;

        [NativeTypeName("UINT32")]
        public uint semanticIndex;

        public DXGI_FORMAT format;

        [NativeTypeName("UINT32")]
        public uint inputSlot;

        [NativeTypeName("UINT32")]
        public uint alignedByteOffset;
        #endregion
    }
}
