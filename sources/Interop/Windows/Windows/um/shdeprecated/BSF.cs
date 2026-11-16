// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BSF
{
    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_REGISTERASDROPTARGET"]/*' />
    [NativeTypeName("#define BSF_REGISTERASDROPTARGET 0x00000001")]
    public const int BSF_REGISTERASDROPTARGET = 0x00000001;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_THEATERMODE"]/*' />
    [NativeTypeName("#define BSF_THEATERMODE 0x00000002")]
    public const int BSF_THEATERMODE = 0x00000002;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_NOLOCALFILEWARNING"]/*' />
    [NativeTypeName("#define BSF_NOLOCALFILEWARNING 0x00000010")]
    public const int BSF_NOLOCALFILEWARNING = 0x00000010;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_UISETBYAUTOMATION"]/*' />
    [NativeTypeName("#define BSF_UISETBYAUTOMATION 0x00000100")]
    public const int BSF_UISETBYAUTOMATION = 0x00000100;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_RESIZABLE"]/*' />
    [NativeTypeName("#define BSF_RESIZABLE 0x00000200")]
    public const int BSF_RESIZABLE = 0x00000200;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_CANMAXIMIZE"]/*' />
    [NativeTypeName("#define BSF_CANMAXIMIZE 0x00000400")]
    public const int BSF_CANMAXIMIZE = 0x00000400;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_TOPBROWSER"]/*' />
    [NativeTypeName("#define BSF_TOPBROWSER 0x00000800")]
    public const int BSF_TOPBROWSER = 0x00000800;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_NAVNOHISTORY"]/*' />
    [NativeTypeName("#define BSF_NAVNOHISTORY 0x00001000")]
    public const int BSF_NAVNOHISTORY = 0x00001000;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_HTMLNAVCANCELED"]/*' />
    [NativeTypeName("#define BSF_HTMLNAVCANCELED 0x00002000")]
    public const int BSF_HTMLNAVCANCELED = 0x00002000;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_DONTSHOWNAVCANCELPAGE"]/*' />
    [NativeTypeName("#define BSF_DONTSHOWNAVCANCELPAGE 0x00004000")]
    public const int BSF_DONTSHOWNAVCANCELPAGE = 0x00004000;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_SETNAVIGATABLECODEPAGE"]/*' />
    [NativeTypeName("#define BSF_SETNAVIGATABLECODEPAGE 0x00008000")]
    public const int BSF_SETNAVIGATABLECODEPAGE = 0x00008000;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_DELEGATEDNAVIGATION"]/*' />
    [NativeTypeName("#define BSF_DELEGATEDNAVIGATION 0x00010000")]
    public const int BSF_DELEGATEDNAVIGATION = 0x00010000;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_TRUSTEDFORACTIVEX"]/*' />
    [NativeTypeName("#define BSF_TRUSTEDFORACTIVEX 0x00020000")]
    public const int BSF_TRUSTEDFORACTIVEX = 0x00020000;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_MERGEDMENUS"]/*' />
    [NativeTypeName("#define BSF_MERGEDMENUS 0x00040000")]
    public const int BSF_MERGEDMENUS = 0x00040000;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_FEEDNAVIGATION"]/*' />
    [NativeTypeName("#define BSF_FEEDNAVIGATION 0x00080000")]
    public const int BSF_FEEDNAVIGATION = 0x00080000;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_FEEDSUBSCRIBED"]/*' />
    [NativeTypeName("#define BSF_FEEDSUBSCRIBED 0x00100000")]
    public const int BSF_FEEDSUBSCRIBED = 0x00100000;
}
