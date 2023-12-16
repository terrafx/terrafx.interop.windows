// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DMATERIAL9.xml' path='doc/member[@name="D3DMATERIAL9"]/*' />
public partial struct D3DMATERIAL9
{
    /// <include file='D3DMATERIAL9.xml' path='doc/member[@name="D3DMATERIAL9.Diffuse"]/*' />
    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Diffuse;

    /// <include file='D3DMATERIAL9.xml' path='doc/member[@name="D3DMATERIAL9.Ambient"]/*' />
    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Ambient;

    /// <include file='D3DMATERIAL9.xml' path='doc/member[@name="D3DMATERIAL9.Specular"]/*' />
    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Specular;

    /// <include file='D3DMATERIAL9.xml' path='doc/member[@name="D3DMATERIAL9.Emissive"]/*' />
    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Emissive;

    /// <include file='D3DMATERIAL9.xml' path='doc/member[@name="D3DMATERIAL9.Power"]/*' />
    public float Power;
}
