// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_STRIP_CUT_VALUE"]/*' />
public enum D3D12_INDEX_BUFFER_STRIP_CUT_VALUE
{
    /// <include file='D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED"]/*' />
    D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED = 0,

    /// <include file='D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF"]/*' />
    D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF = 1,

    /// <include file='D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF"]/*' />
    D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF = 2,
}
