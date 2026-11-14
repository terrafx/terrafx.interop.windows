// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TBN
{
    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_FIRST"]/*' />
    [NativeTypeName("#define TBN_FIRST (0U-700U)")]
    public const uint TBN_FIRST = unchecked(0U - 700U);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_LAST"]/*' />
    [NativeTypeName("#define TBN_LAST (0U-720U)")]
    public const uint TBN_LAST = unchecked(0U - 720U);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETBUTTONINFOA"]/*' />
    [NativeTypeName("#define TBN_GETBUTTONINFOA (TBN_FIRST-0)")]
    public const uint TBN_GETBUTTONINFOA = unchecked((0U - 700U) - 0);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_BEGINDRAG"]/*' />
    [NativeTypeName("#define TBN_BEGINDRAG (TBN_FIRST-1)")]
    public const uint TBN_BEGINDRAG = unchecked((0U - 700U) - 1);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_ENDDRAG"]/*' />
    [NativeTypeName("#define TBN_ENDDRAG (TBN_FIRST-2)")]
    public const uint TBN_ENDDRAG = unchecked((0U - 700U) - 2);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_BEGINADJUST"]/*' />
    [NativeTypeName("#define TBN_BEGINADJUST (TBN_FIRST-3)")]
    public const uint TBN_BEGINADJUST = unchecked((0U - 700U) - 3);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_ENDADJUST"]/*' />
    [NativeTypeName("#define TBN_ENDADJUST (TBN_FIRST-4)")]
    public const uint TBN_ENDADJUST = unchecked((0U - 700U) - 4);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_RESET"]/*' />
    [NativeTypeName("#define TBN_RESET (TBN_FIRST-5)")]
    public const uint TBN_RESET = unchecked((0U - 700U) - 5);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_QUERYINSERT"]/*' />
    [NativeTypeName("#define TBN_QUERYINSERT (TBN_FIRST-6)")]
    public const uint TBN_QUERYINSERT = unchecked((0U - 700U) - 6);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_QUERYDELETE"]/*' />
    [NativeTypeName("#define TBN_QUERYDELETE (TBN_FIRST-7)")]
    public const uint TBN_QUERYDELETE = unchecked((0U - 700U) - 7);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_TOOLBARCHANGE"]/*' />
    [NativeTypeName("#define TBN_TOOLBARCHANGE (TBN_FIRST-8)")]
    public const uint TBN_TOOLBARCHANGE = unchecked((0U - 700U) - 8);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_CUSTHELP"]/*' />
    [NativeTypeName("#define TBN_CUSTHELP (TBN_FIRST-9)")]
    public const uint TBN_CUSTHELP = unchecked((0U - 700U) - 9);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_DROPDOWN"]/*' />
    [NativeTypeName("#define TBN_DROPDOWN (TBN_FIRST - 10)")]
    public const uint TBN_DROPDOWN = unchecked((0U - 700U) - 10);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETOBJECT"]/*' />
    [NativeTypeName("#define TBN_GETOBJECT (TBN_FIRST - 12)")]
    public const uint TBN_GETOBJECT = unchecked((0U - 700U) - 12);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_HOTITEMCHANGE"]/*' />
    [NativeTypeName("#define TBN_HOTITEMCHANGE (TBN_FIRST - 13)")]
    public const uint TBN_HOTITEMCHANGE = unchecked((0U - 700U) - 13);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_DRAGOUT"]/*' />
    [NativeTypeName("#define TBN_DRAGOUT (TBN_FIRST - 14)")]
    public const uint TBN_DRAGOUT = unchecked((0U - 700U) - 14);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_DELETINGBUTTON"]/*' />
    [NativeTypeName("#define TBN_DELETINGBUTTON (TBN_FIRST - 15)")]
    public const uint TBN_DELETINGBUTTON = unchecked((0U - 700U) - 15);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETDISPINFOA"]/*' />
    [NativeTypeName("#define TBN_GETDISPINFOA (TBN_FIRST - 16)")]
    public const uint TBN_GETDISPINFOA = unchecked((0U - 700U) - 16);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETDISPINFOW"]/*' />
    [NativeTypeName("#define TBN_GETDISPINFOW (TBN_FIRST - 17)")]
    public const uint TBN_GETDISPINFOW = unchecked((0U - 700U) - 17);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETINFOTIPA"]/*' />
    [NativeTypeName("#define TBN_GETINFOTIPA (TBN_FIRST - 18)")]
    public const uint TBN_GETINFOTIPA = unchecked((0U - 700U) - 18);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETINFOTIPW"]/*' />
    [NativeTypeName("#define TBN_GETINFOTIPW (TBN_FIRST - 19)")]
    public const uint TBN_GETINFOTIPW = unchecked((0U - 700U) - 19);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETBUTTONINFOW"]/*' />
    [NativeTypeName("#define TBN_GETBUTTONINFOW (TBN_FIRST - 20)")]
    public const uint TBN_GETBUTTONINFOW = unchecked((0U - 700U) - 20);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_RESTORE"]/*' />
    [NativeTypeName("#define TBN_RESTORE (TBN_FIRST - 21)")]
    public const uint TBN_RESTORE = unchecked((0U - 700U) - 21);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_SAVE"]/*' />
    [NativeTypeName("#define TBN_SAVE (TBN_FIRST - 22)")]
    public const uint TBN_SAVE = unchecked((0U - 700U) - 22);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_INITCUSTOMIZE"]/*' />
    [NativeTypeName("#define TBN_INITCUSTOMIZE (TBN_FIRST - 23)")]
    public const uint TBN_INITCUSTOMIZE = unchecked((0U - 700U) - 23);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_WRAPHOTITEM"]/*' />
    [NativeTypeName("#define TBN_WRAPHOTITEM (TBN_FIRST - 24)")]
    public const uint TBN_WRAPHOTITEM = unchecked((0U - 700U) - 24);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_DUPACCELERATOR"]/*' />
    [NativeTypeName("#define TBN_DUPACCELERATOR (TBN_FIRST - 25)")]
    public const uint TBN_DUPACCELERATOR = unchecked((0U - 700U) - 25);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_WRAPACCELERATOR"]/*' />
    [NativeTypeName("#define TBN_WRAPACCELERATOR (TBN_FIRST - 26)")]
    public const uint TBN_WRAPACCELERATOR = unchecked((0U - 700U) - 26);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_DRAGOVER"]/*' />
    [NativeTypeName("#define TBN_DRAGOVER (TBN_FIRST - 27)")]
    public const uint TBN_DRAGOVER = unchecked((0U - 700U) - 27);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_MAPACCELERATOR"]/*' />
    [NativeTypeName("#define TBN_MAPACCELERATOR (TBN_FIRST - 28)")]
    public const uint TBN_MAPACCELERATOR = unchecked((0U - 700U) - 28);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETINFOTIP"]/*' />
    [NativeTypeName("#define TBN_GETINFOTIP TBN_GETINFOTIPW")]
    public const uint TBN_GETINFOTIP = unchecked((0U - 700U) - 19);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETDISPINFO"]/*' />
    [NativeTypeName("#define TBN_GETDISPINFO TBN_GETDISPINFOW")]
    public const uint TBN_GETDISPINFO = unchecked((0U - 700U) - 17);

    /// <include file='TBN.xml' path='doc/member[@name="TBN.TBN_GETBUTTONINFO"]/*' />
    [NativeTypeName("#define TBN_GETBUTTONINFO TBN_GETBUTTONINFOW")]
    public const uint TBN_GETBUTTONINFO = unchecked((0U - 700U) - 20);
}
