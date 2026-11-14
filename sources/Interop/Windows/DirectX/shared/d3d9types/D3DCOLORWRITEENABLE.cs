// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCOLORWRITEENABLE
{
    /// <include file='D3DCOLORWRITEENABLE.xml' path='doc/member[@name="D3DCOLORWRITEENABLE.D3DCOLORWRITEENABLE_RED"]/*' />
    [NativeTypeName("#define D3DCOLORWRITEENABLE_RED (1L<<0)")]
    public const int D3DCOLORWRITEENABLE_RED = (1 << 0);

    /// <include file='D3DCOLORWRITEENABLE.xml' path='doc/member[@name="D3DCOLORWRITEENABLE.D3DCOLORWRITEENABLE_GREEN"]/*' />
    [NativeTypeName("#define D3DCOLORWRITEENABLE_GREEN (1L<<1)")]
    public const int D3DCOLORWRITEENABLE_GREEN = (1 << 1);

    /// <include file='D3DCOLORWRITEENABLE.xml' path='doc/member[@name="D3DCOLORWRITEENABLE.D3DCOLORWRITEENABLE_BLUE"]/*' />
    [NativeTypeName("#define D3DCOLORWRITEENABLE_BLUE (1L<<2)")]
    public const int D3DCOLORWRITEENABLE_BLUE = (1 << 2);

    /// <include file='D3DCOLORWRITEENABLE.xml' path='doc/member[@name="D3DCOLORWRITEENABLE.D3DCOLORWRITEENABLE_ALPHA"]/*' />
    [NativeTypeName("#define D3DCOLORWRITEENABLE_ALPHA (1L<<3)")]
    public const int D3DCOLORWRITEENABLE_ALPHA = (1 << 3);
}
