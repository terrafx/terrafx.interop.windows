// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPSHADECAPS
{
    /// <include file='D3DPSHADECAPS.xml' path='doc/member[@name="D3DPSHADECAPS.D3DPSHADECAPS_COLORGOURAUDRGB"]/*' />
    [NativeTypeName("#define D3DPSHADECAPS_COLORGOURAUDRGB 0x00000008L")]
    public const int D3DPSHADECAPS_COLORGOURAUDRGB = 0x00000008;

    /// <include file='D3DPSHADECAPS.xml' path='doc/member[@name="D3DPSHADECAPS.D3DPSHADECAPS_SPECULARGOURAUDRGB"]/*' />
    [NativeTypeName("#define D3DPSHADECAPS_SPECULARGOURAUDRGB 0x00000200L")]
    public const int D3DPSHADECAPS_SPECULARGOURAUDRGB = 0x00000200;

    /// <include file='D3DPSHADECAPS.xml' path='doc/member[@name="D3DPSHADECAPS.D3DPSHADECAPS_ALPHAGOURAUDBLEND"]/*' />
    [NativeTypeName("#define D3DPSHADECAPS_ALPHAGOURAUDBLEND 0x00004000L")]
    public const int D3DPSHADECAPS_ALPHAGOURAUDBLEND = 0x00004000;

    /// <include file='D3DPSHADECAPS.xml' path='doc/member[@name="D3DPSHADECAPS.D3DPSHADECAPS_FOGGOURAUD"]/*' />
    [NativeTypeName("#define D3DPSHADECAPS_FOGGOURAUD 0x00080000L")]
    public const int D3DPSHADECAPS_FOGGOURAUD = 0x00080000;
}
