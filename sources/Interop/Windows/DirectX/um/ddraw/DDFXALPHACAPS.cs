// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDFXALPHACAPS
{
    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_BLTALPHAEDGEBLEND"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_BLTALPHAEDGEBLEND 0x00000001l")]
    public const int DDFXALPHACAPS_BLTALPHAEDGEBLEND = 0x00000001;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_BLTALPHAPIXELS"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_BLTALPHAPIXELS 0x00000002l")]
    public const int DDFXALPHACAPS_BLTALPHAPIXELS = 0x00000002;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_BLTALPHAPIXELSNEG"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_BLTALPHAPIXELSNEG 0x00000004l")]
    public const int DDFXALPHACAPS_BLTALPHAPIXELSNEG = 0x00000004;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_BLTALPHASURFACES"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_BLTALPHASURFACES 0x00000008l")]
    public const int DDFXALPHACAPS_BLTALPHASURFACES = 0x00000008;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_BLTALPHASURFACESNEG"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_BLTALPHASURFACESNEG 0x00000010l")]
    public const int DDFXALPHACAPS_BLTALPHASURFACESNEG = 0x00000010;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_OVERLAYALPHAEDGEBLEND"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHAEDGEBLEND 0x00000020l")]
    public const int DDFXALPHACAPS_OVERLAYALPHAEDGEBLEND = 0x00000020;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_OVERLAYALPHAPIXELS"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHAPIXELS 0x00000040l")]
    public const int DDFXALPHACAPS_OVERLAYALPHAPIXELS = 0x00000040;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_OVERLAYALPHAPIXELSNEG"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHAPIXELSNEG 0x00000080l")]
    public const int DDFXALPHACAPS_OVERLAYALPHAPIXELSNEG = 0x00000080;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_OVERLAYALPHASURFACES"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHASURFACES 0x00000100l")]
    public const int DDFXALPHACAPS_OVERLAYALPHASURFACES = 0x00000100;

    /// <include file='DDFXALPHACAPS.xml' path='doc/member[@name="DDFXALPHACAPS.DDFXALPHACAPS_OVERLAYALPHASURFACESNEG"]/*' />
    [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHASURFACESNEG 0x00000200l")]
    public const int DDFXALPHACAPS_OVERLAYALPHASURFACESNEG = 0x00000200;
}
