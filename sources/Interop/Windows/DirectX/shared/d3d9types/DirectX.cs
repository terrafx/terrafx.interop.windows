// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.D3DDECLMETHOD;
using static TerraFX.Interop.DirectX.D3DDECLTYPE;
using static TerraFX.Interop.DirectX.D3DDECLUSAGE;
using static TerraFX.Interop.DirectX.D3DRESOURCETYPE;

namespace TerraFX.Interop.DirectX;

public static partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DMAXUSERCLIPPLANES"]/*' />
    [NativeTypeName("#define D3DMAXUSERCLIPPLANES 32")]
    public const int D3DMAXUSERCLIPPLANES = 32;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCLIPPLANE0"]/*' />
    [NativeTypeName("#define D3DCLIPPLANE0 (1 << 0)")]
    public const int D3DCLIPPLANE0 = (1 << 0);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCLIPPLANE1"]/*' />
    [NativeTypeName("#define D3DCLIPPLANE1 (1 << 1)")]
    public const int D3DCLIPPLANE1 = (1 << 1);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCLIPPLANE2"]/*' />
    [NativeTypeName("#define D3DCLIPPLANE2 (1 << 2)")]
    public const int D3DCLIPPLANE2 = (1 << 2);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCLIPPLANE3"]/*' />
    [NativeTypeName("#define D3DCLIPPLANE3 (1 << 3)")]
    public const int D3DCLIPPLANE3 = (1 << 3);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCLIPPLANE4"]/*' />
    [NativeTypeName("#define D3DCLIPPLANE4 (1 << 4)")]
    public const int D3DCLIPPLANE4 = (1 << 4);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCLIPPLANE5"]/*' />
    [NativeTypeName("#define D3DCLIPPLANE5 (1 << 5)")]
    public const int D3DCLIPPLANE5 = (1 << 5);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DRENDERSTATE_WRAPBIAS"]/*' />
    [NativeTypeName("#define D3DRENDERSTATE_WRAPBIAS 128UL")]
    public const uint D3DRENDERSTATE_WRAPBIAS = 128U;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DWRAPCOORD_0"]/*' />
    [NativeTypeName("#define D3DWRAPCOORD_0 0x00000001L")]
    public const int D3DWRAPCOORD_0 = 0x00000001;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DWRAPCOORD_1"]/*' />
    [NativeTypeName("#define D3DWRAPCOORD_1 0x00000002L")]
    public const int D3DWRAPCOORD_1 = 0x00000002;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DWRAPCOORD_2"]/*' />
    [NativeTypeName("#define D3DWRAPCOORD_2 0x00000004L")]
    public const int D3DWRAPCOORD_2 = 0x00000004;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DWRAPCOORD_3"]/*' />
    [NativeTypeName("#define D3DWRAPCOORD_3 0x00000008L")]
    public const int D3DWRAPCOORD_3 = 0x00000008;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DDMAPSAMPLER"]/*' />
    [NativeTypeName("#define D3DDMAPSAMPLER 256")]
    public const int D3DDMAPSAMPLER = 256;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DVERTEXTEXTURESAMPLER0"]/*' />
    [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER0 (D3DDMAPSAMPLER+1)")]
    public const int D3DVERTEXTEXTURESAMPLER0 = (256 + 1);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DVERTEXTEXTURESAMPLER1"]/*' />
    [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER1 (D3DDMAPSAMPLER+2)")]
    public const int D3DVERTEXTEXTURESAMPLER1 = (256 + 2);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DVERTEXTEXTURESAMPLER2"]/*' />
    [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER2 (D3DDMAPSAMPLER+3)")]
    public const int D3DVERTEXTEXTURESAMPLER2 = (256 + 3);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DVERTEXTEXTURESAMPLER3"]/*' />
    [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER3 (D3DDMAPSAMPLER+4)")]
    public const int D3DVERTEXTEXTURESAMPLER3 = (256 + 4);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.MAXD3DDECLUSAGE"]/*' />
    [NativeTypeName("#define MAXD3DDECLUSAGE D3DDECLUSAGE_SAMPLE")]
    public const D3DDECLUSAGE MAXD3DDECLUSAGE = D3DDECLUSAGE_SAMPLE;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.MAXD3DDECLUSAGEINDEX"]/*' />
    [NativeTypeName("#define MAXD3DDECLUSAGEINDEX 15")]
    public const int MAXD3DDECLUSAGEINDEX = 15;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.MAXD3DDECLLENGTH"]/*' />
    [NativeTypeName("#define MAXD3DDECLLENGTH 64")]
    public const int MAXD3DDECLLENGTH = 64;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.MAXD3DDECLMETHOD"]/*' />
    [NativeTypeName("#define MAXD3DDECLMETHOD D3DDECLMETHOD_LOOKUPPRESAMPLED")]
    public const D3DDECLMETHOD MAXD3DDECLMETHOD = D3DDECLMETHOD_LOOKUPPRESAMPLED;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.MAXD3DDECLTYPE"]/*' />
    [NativeTypeName("#define MAXD3DDECLTYPE D3DDECLTYPE_UNUSED")]
    public const D3DDECLTYPE MAXD3DDECLTYPE = D3DDECLTYPE_UNUSED;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DSINCOSCONST1"]/*' />
    [NativeTypeName("#define D3DSINCOSCONST1 -1.5500992e-006f")]
    public const float D3DSINCOSCONST1 = -1.5500992e-006f;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DSINCOSCONST2"]/*' />
    [NativeTypeName("#define D3DSINCOSCONST2 -0.020833334f")]
    public const float D3DSINCOSCONST2 = -0.020833334f;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DRTYPECOUNT"]/*' />
    [NativeTypeName("#define D3DRTYPECOUNT (D3DRTYPE_INDEXBUFFER+1)")]
    public const int D3DRTYPECOUNT = ((int)(D3DRTYPE_INDEXBUFFER) + 1);
}
