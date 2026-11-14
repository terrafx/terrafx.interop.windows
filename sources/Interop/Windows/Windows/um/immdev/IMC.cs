// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IMC
{
    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETCONVERSIONMODE"]/*' />
    [NativeTypeName("#define IMC_SETCONVERSIONMODE 0x0002")]
    public const int IMC_SETCONVERSIONMODE = 0x0002;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETSENTENCEMODE"]/*' />
    [NativeTypeName("#define IMC_SETSENTENCEMODE 0x0004")]
    public const int IMC_SETSENTENCEMODE = 0x0004;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETOPENSTATUS"]/*' />
    [NativeTypeName("#define IMC_SETOPENSTATUS 0x0006")]
    public const int IMC_SETOPENSTATUS = 0x0006;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_GETSOFTKBDFONT"]/*' />
    [NativeTypeName("#define IMC_GETSOFTKBDFONT 0x0011")]
    public const int IMC_GETSOFTKBDFONT = 0x0011;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETSOFTKBDFONT"]/*' />
    [NativeTypeName("#define IMC_SETSOFTKBDFONT 0x0012")]
    public const int IMC_SETSOFTKBDFONT = 0x0012;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_GETSOFTKBDPOS"]/*' />
    [NativeTypeName("#define IMC_GETSOFTKBDPOS 0x0013")]
    public const int IMC_GETSOFTKBDPOS = 0x0013;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETSOFTKBDPOS"]/*' />
    [NativeTypeName("#define IMC_SETSOFTKBDPOS 0x0014")]
    public const int IMC_SETSOFTKBDPOS = 0x0014;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_GETSOFTKBDSUBTYPE"]/*' />
    [NativeTypeName("#define IMC_GETSOFTKBDSUBTYPE 0x0015")]
    public const int IMC_GETSOFTKBDSUBTYPE = 0x0015;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETSOFTKBDSUBTYPE"]/*' />
    [NativeTypeName("#define IMC_SETSOFTKBDSUBTYPE 0x0016")]
    public const int IMC_SETSOFTKBDSUBTYPE = 0x0016;

    /// <include file='IMC.xml' path='doc/member[@name="IMC.IMC_SETSOFTKBDDATA"]/*' />
    [NativeTypeName("#define IMC_SETSOFTKBDDATA 0x0018")]
    public const int IMC_SETSOFTKBDDATA = 0x0018;
}
