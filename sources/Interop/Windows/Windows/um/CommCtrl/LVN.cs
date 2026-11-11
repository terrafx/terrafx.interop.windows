// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LVN
{
    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_FIRST"]/*' />
    [NativeTypeName("#define LVN_FIRST (0U-100U)")]
    public const uint LVN_FIRST = unchecked(0U - 100U);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_LAST"]/*' />
    [NativeTypeName("#define LVN_LAST (0U-199U)")]
    public const uint LVN_LAST = unchecked(0U - 199U);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ITEMCHANGING"]/*' />
    [NativeTypeName("#define LVN_ITEMCHANGING (LVN_FIRST-0)")]
    public const uint LVN_ITEMCHANGING = unchecked((0U - 100U) - 0);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ITEMCHANGED"]/*' />
    [NativeTypeName("#define LVN_ITEMCHANGED (LVN_FIRST-1)")]
    public const uint LVN_ITEMCHANGED = unchecked((0U - 100U) - 1);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_INSERTITEM"]/*' />
    [NativeTypeName("#define LVN_INSERTITEM (LVN_FIRST-2)")]
    public const uint LVN_INSERTITEM = unchecked((0U - 100U) - 2);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_DELETEITEM"]/*' />
    [NativeTypeName("#define LVN_DELETEITEM (LVN_FIRST-3)")]
    public const uint LVN_DELETEITEM = unchecked((0U - 100U) - 3);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_DELETEALLITEMS"]/*' />
    [NativeTypeName("#define LVN_DELETEALLITEMS (LVN_FIRST-4)")]
    public const uint LVN_DELETEALLITEMS = unchecked((0U - 100U) - 4);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_BEGINLABELEDITA"]/*' />
    [NativeTypeName("#define LVN_BEGINLABELEDITA (LVN_FIRST-5)")]
    public const uint LVN_BEGINLABELEDITA = unchecked((0U - 100U) - 5);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_BEGINLABELEDITW"]/*' />
    [NativeTypeName("#define LVN_BEGINLABELEDITW (LVN_FIRST-75)")]
    public const uint LVN_BEGINLABELEDITW = unchecked((0U - 100U) - 75);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ENDLABELEDITA"]/*' />
    [NativeTypeName("#define LVN_ENDLABELEDITA (LVN_FIRST-6)")]
    public const uint LVN_ENDLABELEDITA = unchecked((0U - 100U) - 6);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ENDLABELEDITW"]/*' />
    [NativeTypeName("#define LVN_ENDLABELEDITW (LVN_FIRST-76)")]
    public const uint LVN_ENDLABELEDITW = unchecked((0U - 100U) - 76);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_COLUMNCLICK"]/*' />
    [NativeTypeName("#define LVN_COLUMNCLICK (LVN_FIRST-8)")]
    public const uint LVN_COLUMNCLICK = unchecked((0U - 100U) - 8);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_BEGINDRAG"]/*' />
    [NativeTypeName("#define LVN_BEGINDRAG (LVN_FIRST-9)")]
    public const uint LVN_BEGINDRAG = unchecked((0U - 100U) - 9);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_BEGINRDRAG"]/*' />
    [NativeTypeName("#define LVN_BEGINRDRAG (LVN_FIRST-11)")]
    public const uint LVN_BEGINRDRAG = unchecked((0U - 100U) - 11);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ODCACHEHINT"]/*' />
    [NativeTypeName("#define LVN_ODCACHEHINT (LVN_FIRST-13)")]
    public const uint LVN_ODCACHEHINT = unchecked((0U - 100U) - 13);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ODFINDITEMA"]/*' />
    [NativeTypeName("#define LVN_ODFINDITEMA (LVN_FIRST-52)")]
    public const uint LVN_ODFINDITEMA = unchecked((0U - 100U) - 52);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ODFINDITEMW"]/*' />
    [NativeTypeName("#define LVN_ODFINDITEMW (LVN_FIRST-79)")]
    public const uint LVN_ODFINDITEMW = unchecked((0U - 100U) - 79);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ITEMACTIVATE"]/*' />
    [NativeTypeName("#define LVN_ITEMACTIVATE (LVN_FIRST-14)")]
    public const uint LVN_ITEMACTIVATE = unchecked((0U - 100U) - 14);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ODSTATECHANGED"]/*' />
    [NativeTypeName("#define LVN_ODSTATECHANGED (LVN_FIRST-15)")]
    public const uint LVN_ODSTATECHANGED = unchecked((0U - 100U) - 15);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ODFINDITEM"]/*' />
    [NativeTypeName("#define LVN_ODFINDITEM LVN_ODFINDITEMW")]
    public const uint LVN_ODFINDITEM = unchecked((0U - 100U) - 79);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_HOTTRACK"]/*' />
    [NativeTypeName("#define LVN_HOTTRACK (LVN_FIRST-21)")]
    public const uint LVN_HOTTRACK = unchecked((0U - 100U) - 21);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_GETDISPINFOA"]/*' />
    [NativeTypeName("#define LVN_GETDISPINFOA (LVN_FIRST-50)")]
    public const uint LVN_GETDISPINFOA = unchecked((0U - 100U) - 50);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_GETDISPINFOW"]/*' />
    [NativeTypeName("#define LVN_GETDISPINFOW (LVN_FIRST-77)")]
    public const uint LVN_GETDISPINFOW = unchecked((0U - 100U) - 77);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_SETDISPINFOA"]/*' />
    [NativeTypeName("#define LVN_SETDISPINFOA (LVN_FIRST-51)")]
    public const uint LVN_SETDISPINFOA = unchecked((0U - 100U) - 51);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_SETDISPINFOW"]/*' />
    [NativeTypeName("#define LVN_SETDISPINFOW (LVN_FIRST-78)")]
    public const uint LVN_SETDISPINFOW = unchecked((0U - 100U) - 78);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_BEGINLABELEDIT"]/*' />
    [NativeTypeName("#define LVN_BEGINLABELEDIT LVN_BEGINLABELEDITW")]
    public const uint LVN_BEGINLABELEDIT = unchecked((0U - 100U) - 75);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ENDLABELEDIT"]/*' />
    [NativeTypeName("#define LVN_ENDLABELEDIT LVN_ENDLABELEDITW")]
    public const uint LVN_ENDLABELEDIT = unchecked((0U - 100U) - 76);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_GETDISPINFO"]/*' />
    [NativeTypeName("#define LVN_GETDISPINFO LVN_GETDISPINFOW")]
    public const uint LVN_GETDISPINFO = unchecked((0U - 100U) - 77);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_SETDISPINFO"]/*' />
    [NativeTypeName("#define LVN_SETDISPINFO LVN_SETDISPINFOW")]
    public const uint LVN_SETDISPINFO = unchecked((0U - 100U) - 78);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_KEYDOWN"]/*' />
    [NativeTypeName("#define LVN_KEYDOWN (LVN_FIRST-55)")]
    public const uint LVN_KEYDOWN = unchecked((0U - 100U) - 55);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_MARQUEEBEGIN"]/*' />
    [NativeTypeName("#define LVN_MARQUEEBEGIN (LVN_FIRST-56)")]
    public const uint LVN_MARQUEEBEGIN = unchecked((0U - 100U) - 56);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_GETINFOTIPA"]/*' />
    [NativeTypeName("#define LVN_GETINFOTIPA (LVN_FIRST-57)")]
    public const uint LVN_GETINFOTIPA = unchecked((0U - 100U) - 57);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_GETINFOTIPW"]/*' />
    [NativeTypeName("#define LVN_GETINFOTIPW (LVN_FIRST-58)")]
    public const uint LVN_GETINFOTIPW = unchecked((0U - 100U) - 58);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_GETINFOTIP"]/*' />
    [NativeTypeName("#define LVN_GETINFOTIP LVN_GETINFOTIPW")]
    public const uint LVN_GETINFOTIP = unchecked((0U - 100U) - 58);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_INCREMENTALSEARCHA"]/*' />
    [NativeTypeName("#define LVN_INCREMENTALSEARCHA (LVN_FIRST-62)")]
    public const uint LVN_INCREMENTALSEARCHA = unchecked((0U - 100U) - 62);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_INCREMENTALSEARCHW"]/*' />
    [NativeTypeName("#define LVN_INCREMENTALSEARCHW (LVN_FIRST-63)")]
    public const uint LVN_INCREMENTALSEARCHW = unchecked((0U - 100U) - 63);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_INCREMENTALSEARCH"]/*' />
    [NativeTypeName("#define LVN_INCREMENTALSEARCH LVN_INCREMENTALSEARCHW")]
    public const uint LVN_INCREMENTALSEARCH = unchecked((0U - 100U) - 63);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_COLUMNDROPDOWN"]/*' />
    [NativeTypeName("#define LVN_COLUMNDROPDOWN (LVN_FIRST-64)")]
    public const uint LVN_COLUMNDROPDOWN = unchecked((0U - 100U) - 64);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_COLUMNOVERFLOWCLICK"]/*' />
    [NativeTypeName("#define LVN_COLUMNOVERFLOWCLICK (LVN_FIRST-66)")]
    public const uint LVN_COLUMNOVERFLOWCLICK = unchecked((0U - 100U) - 66);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_BEGINSCROLL"]/*' />
    [NativeTypeName("#define LVN_BEGINSCROLL (LVN_FIRST-80)")]
    public const uint LVN_BEGINSCROLL = unchecked((0U - 100U) - 80);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_ENDSCROLL"]/*' />
    [NativeTypeName("#define LVN_ENDSCROLL (LVN_FIRST-81)")]
    public const uint LVN_ENDSCROLL = unchecked((0U - 100U) - 81);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_LINKCLICK"]/*' />
    [NativeTypeName("#define LVN_LINKCLICK (LVN_FIRST-84)")]
    public const uint LVN_LINKCLICK = unchecked((0U - 100U) - 84);

    /// <include file='LVN.xml' path='doc/member[@name="LVN.LVN_GETEMPTYMARKUP"]/*' />
    [NativeTypeName("#define LVN_GETEMPTYMARKUP (LVN_FIRST-87)")]
    public const uint LVN_GETEMPTYMARKUP = unchecked((0U - 100U) - 87);
}
