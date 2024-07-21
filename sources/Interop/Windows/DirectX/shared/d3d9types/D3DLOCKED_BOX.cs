// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DLOCKED_BOX.xml' path='doc/member[@name="D3DLOCKED_BOX"]/*' />
public unsafe partial struct D3DLOCKED_BOX
{
    /// <include file='D3DLOCKED_BOX.xml' path='doc/member[@name="D3DLOCKED_BOX.RowPitch"]/*' />
    public int RowPitch;

    /// <include file='D3DLOCKED_BOX.xml' path='doc/member[@name="D3DLOCKED_BOX.SlicePitch"]/*' />
    public int SlicePitch;

    /// <include file='D3DLOCKED_BOX.xml' path='doc/member[@name="D3DLOCKED_BOX.pBits"]/*' />
    public void* pBits;
}
