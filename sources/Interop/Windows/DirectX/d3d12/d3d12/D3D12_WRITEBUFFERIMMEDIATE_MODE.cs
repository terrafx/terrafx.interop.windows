// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_WRITEBUFFERIMMEDIATE_MODE.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_MODE"]/*' />
public enum D3D12_WRITEBUFFERIMMEDIATE_MODE
{
    /// <include file='D3D12_WRITEBUFFERIMMEDIATE_MODE.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_MODE.D3D12_WRITEBUFFERIMMEDIATE_MODE_DEFAULT"]/*' />
    D3D12_WRITEBUFFERIMMEDIATE_MODE_DEFAULT = 0,

    /// <include file='D3D12_WRITEBUFFERIMMEDIATE_MODE.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_MODE.D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN"]/*' />
    D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_IN = 0x1,

    /// <include file='D3D12_WRITEBUFFERIMMEDIATE_MODE.xml' path='doc/member[@name="D3D12_WRITEBUFFERIMMEDIATE_MODE.D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT"]/*' />
    D3D12_WRITEBUFFERIMMEDIATE_MODE_MARKER_OUT = 0x2,
}
