// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PSP
{
    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_DEFAULT"]/*' />
    [NativeTypeName("#define PSP_DEFAULT 0x00000000")]
    public const int PSP_DEFAULT = 0x00000000;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_DLGINDIRECT"]/*' />
    [NativeTypeName("#define PSP_DLGINDIRECT 0x00000001")]
    public const int PSP_DLGINDIRECT = 0x00000001;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_USEHICON"]/*' />
    [NativeTypeName("#define PSP_USEHICON 0x00000002")]
    public const int PSP_USEHICON = 0x00000002;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_USEICONID"]/*' />
    [NativeTypeName("#define PSP_USEICONID 0x00000004")]
    public const int PSP_USEICONID = 0x00000004;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_USETITLE"]/*' />
    [NativeTypeName("#define PSP_USETITLE 0x00000008")]
    public const int PSP_USETITLE = 0x00000008;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_RTLREADING"]/*' />
    [NativeTypeName("#define PSP_RTLREADING 0x00000010")]
    public const int PSP_RTLREADING = 0x00000010;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_HASHELP"]/*' />
    [NativeTypeName("#define PSP_HASHELP 0x00000020")]
    public const int PSP_HASHELP = 0x00000020;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_USEREFPARENT"]/*' />
    [NativeTypeName("#define PSP_USEREFPARENT 0x00000040")]
    public const int PSP_USEREFPARENT = 0x00000040;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_USECALLBACK"]/*' />
    [NativeTypeName("#define PSP_USECALLBACK 0x00000080")]
    public const int PSP_USECALLBACK = 0x00000080;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_PREMATURE"]/*' />
    [NativeTypeName("#define PSP_PREMATURE 0x00000400")]
    public const int PSP_PREMATURE = 0x00000400;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_HIDEHEADER"]/*' />
    [NativeTypeName("#define PSP_HIDEHEADER 0x00000800")]
    public const int PSP_HIDEHEADER = 0x00000800;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_USEHEADERTITLE"]/*' />
    [NativeTypeName("#define PSP_USEHEADERTITLE 0x00001000")]
    public const int PSP_USEHEADERTITLE = 0x00001000;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_USEHEADERSUBTITLE"]/*' />
    [NativeTypeName("#define PSP_USEHEADERSUBTITLE 0x00002000")]
    public const int PSP_USEHEADERSUBTITLE = 0x00002000;

    /// <include file='PSP.xml' path='doc/member[@name="PSP.PSP_USEFUSIONCONTEXT"]/*' />
    [NativeTypeName("#define PSP_USEFUSIONCONTEXT 0x00004000")]
    public const int PSP_USEFUSIONCONTEXT = 0x00004000;
}
