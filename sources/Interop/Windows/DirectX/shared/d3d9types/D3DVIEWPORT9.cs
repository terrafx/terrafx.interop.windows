// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DVIEWPORT9.xml' path='doc/member[@name="D3DVIEWPORT9"]/*' />
public partial struct D3DVIEWPORT9
{
    /// <include file='D3DVIEWPORT9.xml' path='doc/member[@name="D3DVIEWPORT9.X"]/*' />
    [NativeTypeName("DWORD")]
    public uint X;

    /// <include file='D3DVIEWPORT9.xml' path='doc/member[@name="D3DVIEWPORT9.Y"]/*' />
    [NativeTypeName("DWORD")]
    public uint Y;

    /// <include file='D3DVIEWPORT9.xml' path='doc/member[@name="D3DVIEWPORT9.Width"]/*' />
    [NativeTypeName("DWORD")]
    public uint Width;

    /// <include file='D3DVIEWPORT9.xml' path='doc/member[@name="D3DVIEWPORT9.Height"]/*' />
    [NativeTypeName("DWORD")]
    public uint Height;

    /// <include file='D3DVIEWPORT9.xml' path='doc/member[@name="D3DVIEWPORT9.MinZ"]/*' />
    public float MinZ;

    /// <include file='D3DVIEWPORT9.xml' path='doc/member[@name="D3DVIEWPORT9.MaxZ"]/*' />
    public float MaxZ;
}
