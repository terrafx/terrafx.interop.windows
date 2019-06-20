// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_QUERY_HEAP_DESC
    {
        #region Fields
        public D3D12_QUERY_HEAP_TYPE Type;

        [NativeTypeName("UINT")]
        public uint Count;

        [NativeTypeName("UINT")]
        public uint NodeMask;
        #endregion
    }
}
