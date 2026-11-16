// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NM
{
    /// <include file='NM.xml' path='doc/member[@name="NM.NM_OUTOFMEMORY"]/*' />
    [NativeTypeName("#define NM_OUTOFMEMORY (NM_FIRST-1)")]
    public const uint NM_OUTOFMEMORY = unchecked((0U - 0U) - 1);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_CLICK"]/*' />
    [NativeTypeName("#define NM_CLICK (NM_FIRST-2)")]
    public const uint NM_CLICK = unchecked((0U - 0U) - 2);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_DBLCLK"]/*' />
    [NativeTypeName("#define NM_DBLCLK (NM_FIRST-3)")]
    public const uint NM_DBLCLK = unchecked((0U - 0U) - 3);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_RETURN"]/*' />
    [NativeTypeName("#define NM_RETURN (NM_FIRST-4)")]
    public const uint NM_RETURN = unchecked((0U - 0U) - 4);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_RCLICK"]/*' />
    [NativeTypeName("#define NM_RCLICK (NM_FIRST-5)")]
    public const uint NM_RCLICK = unchecked((0U - 0U) - 5);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_RDBLCLK"]/*' />
    [NativeTypeName("#define NM_RDBLCLK (NM_FIRST-6)")]
    public const uint NM_RDBLCLK = unchecked((0U - 0U) - 6);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_SETFOCUS"]/*' />
    [NativeTypeName("#define NM_SETFOCUS (NM_FIRST-7)")]
    public const uint NM_SETFOCUS = unchecked((0U - 0U) - 7);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_KILLFOCUS"]/*' />
    [NativeTypeName("#define NM_KILLFOCUS (NM_FIRST-8)")]
    public const uint NM_KILLFOCUS = unchecked((0U - 0U) - 8);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_CUSTOMDRAW"]/*' />
    [NativeTypeName("#define NM_CUSTOMDRAW (NM_FIRST-12)")]
    public const uint NM_CUSTOMDRAW = unchecked((0U - 0U) - 12);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_HOVER"]/*' />
    [NativeTypeName("#define NM_HOVER (NM_FIRST-13)")]
    public const uint NM_HOVER = unchecked((0U - 0U) - 13);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_NCHITTEST"]/*' />
    [NativeTypeName("#define NM_NCHITTEST (NM_FIRST-14)")]
    public const uint NM_NCHITTEST = unchecked((0U - 0U) - 14);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_KEYDOWN"]/*' />
    [NativeTypeName("#define NM_KEYDOWN (NM_FIRST-15)")]
    public const uint NM_KEYDOWN = unchecked((0U - 0U) - 15);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_RELEASEDCAPTURE"]/*' />
    [NativeTypeName("#define NM_RELEASEDCAPTURE (NM_FIRST-16)")]
    public const uint NM_RELEASEDCAPTURE = unchecked((0U - 0U) - 16);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_SETCURSOR"]/*' />
    [NativeTypeName("#define NM_SETCURSOR (NM_FIRST-17)")]
    public const uint NM_SETCURSOR = unchecked((0U - 0U) - 17);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_CHAR"]/*' />
    [NativeTypeName("#define NM_CHAR (NM_FIRST-18)")]
    public const uint NM_CHAR = unchecked((0U - 0U) - 18);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_TOOLTIPSCREATED"]/*' />
    [NativeTypeName("#define NM_TOOLTIPSCREATED (NM_FIRST-19)")]
    public const uint NM_TOOLTIPSCREATED = unchecked((0U - 0U) - 19);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_LDOWN"]/*' />
    [NativeTypeName("#define NM_LDOWN (NM_FIRST-20)")]
    public const uint NM_LDOWN = unchecked((0U - 0U) - 20);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_RDOWN"]/*' />
    [NativeTypeName("#define NM_RDOWN (NM_FIRST-21)")]
    public const uint NM_RDOWN = unchecked((0U - 0U) - 21);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_THEMECHANGED"]/*' />
    [NativeTypeName("#define NM_THEMECHANGED (NM_FIRST-22)")]
    public const uint NM_THEMECHANGED = unchecked((0U - 0U) - 22);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_FONTCHANGED"]/*' />
    [NativeTypeName("#define NM_FONTCHANGED (NM_FIRST-23)")]
    public const uint NM_FONTCHANGED = unchecked((0U - 0U) - 23);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_CUSTOMTEXT"]/*' />
    [NativeTypeName("#define NM_CUSTOMTEXT (NM_FIRST-24)")]
    public const uint NM_CUSTOMTEXT = unchecked((0U - 0U) - 24);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_TVSTATEIMAGECHANGING"]/*' />
    [NativeTypeName("#define NM_TVSTATEIMAGECHANGING (NM_FIRST-24)")]
    public const uint NM_TVSTATEIMAGECHANGING = unchecked((0U - 0U) - 24);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_FIRST"]/*' />
    [NativeTypeName("#define NM_FIRST (0U-  0U)")]
    public const uint NM_FIRST = (0U - 0U);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_LAST"]/*' />
    [NativeTypeName("#define NM_LAST (0U- 99U)")]
    public const uint NM_LAST = unchecked(0U - 99U);

    /// <include file='NM.xml' path='doc/member[@name="NM.NM_GETCUSTOMSPLITRECT"]/*' />
    [NativeTypeName("#define NM_GETCUSTOMSPLITRECT (BCN_FIRST + 0x0003)")]
    public const uint NM_GETCUSTOMSPLITRECT = unchecked((0U - 1250U) + 0x0003);
}
