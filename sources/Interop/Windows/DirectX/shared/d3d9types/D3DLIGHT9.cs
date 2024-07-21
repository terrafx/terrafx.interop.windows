// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9"]/*' />
public partial struct D3DLIGHT9
{
    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Type"]/*' />
    public D3DLIGHTTYPE Type;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Diffuse"]/*' />
    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Diffuse;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Specular"]/*' />
    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Specular;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Ambient"]/*' />
    [NativeTypeName("D3DCOLORVALUE")]
    public DXGI_RGBA Ambient;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Position"]/*' />
    public D3DVECTOR Position;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Direction"]/*' />
    public D3DVECTOR Direction;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Range"]/*' />
    public float Range;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Falloff"]/*' />
    public float Falloff;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Attenuation0"]/*' />
    public float Attenuation0;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Attenuation1"]/*' />
    public float Attenuation1;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Attenuation2"]/*' />
    public float Attenuation2;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Theta"]/*' />
    public float Theta;

    /// <include file='D3DLIGHT9.xml' path='doc/member[@name="D3DLIGHT9.Phi"]/*' />
    public float Phi;
}
