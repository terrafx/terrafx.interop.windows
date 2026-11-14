// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CBEN
{
    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_FIRST"]/*' />
    [NativeTypeName("#define CBEN_FIRST (0U-800U)")]
    public const uint CBEN_FIRST = unchecked(0U - 800U);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_LAST"]/*' />
    [NativeTypeName("#define CBEN_LAST (0U-830U)")]
    public const uint CBEN_LAST = unchecked(0U - 830U);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_GETDISPINFO"]/*' />
    [NativeTypeName("#define CBEN_GETDISPINFO CBEN_GETDISPINFOW")]
    public const uint CBEN_GETDISPINFO = unchecked((0U - 800U) - 7);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_GETDISPINFOA"]/*' />
    [NativeTypeName("#define CBEN_GETDISPINFOA (CBEN_FIRST - 0)")]
    public const uint CBEN_GETDISPINFOA = unchecked((0U - 800U) - 0);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_INSERTITEM"]/*' />
    [NativeTypeName("#define CBEN_INSERTITEM (CBEN_FIRST - 1)")]
    public const uint CBEN_INSERTITEM = unchecked((0U - 800U) - 1);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_DELETEITEM"]/*' />
    [NativeTypeName("#define CBEN_DELETEITEM (CBEN_FIRST - 2)")]
    public const uint CBEN_DELETEITEM = unchecked((0U - 800U) - 2);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_BEGINEDIT"]/*' />
    [NativeTypeName("#define CBEN_BEGINEDIT (CBEN_FIRST - 4)")]
    public const uint CBEN_BEGINEDIT = unchecked((0U - 800U) - 4);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_ENDEDITA"]/*' />
    [NativeTypeName("#define CBEN_ENDEDITA (CBEN_FIRST - 5)")]
    public const uint CBEN_ENDEDITA = unchecked((0U - 800U) - 5);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_ENDEDITW"]/*' />
    [NativeTypeName("#define CBEN_ENDEDITW (CBEN_FIRST - 6)")]
    public const uint CBEN_ENDEDITW = unchecked((0U - 800U) - 6);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_GETDISPINFOW"]/*' />
    [NativeTypeName("#define CBEN_GETDISPINFOW (CBEN_FIRST - 7)")]
    public const uint CBEN_GETDISPINFOW = unchecked((0U - 800U) - 7);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_DRAGBEGINA"]/*' />
    [NativeTypeName("#define CBEN_DRAGBEGINA (CBEN_FIRST - 8)")]
    public const uint CBEN_DRAGBEGINA = unchecked((0U - 800U) - 8);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_DRAGBEGINW"]/*' />
    [NativeTypeName("#define CBEN_DRAGBEGINW (CBEN_FIRST - 9)")]
    public const uint CBEN_DRAGBEGINW = unchecked((0U - 800U) - 9);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_DRAGBEGIN"]/*' />
    [NativeTypeName("#define CBEN_DRAGBEGIN CBEN_DRAGBEGINW")]
    public const uint CBEN_DRAGBEGIN = unchecked((0U - 800U) - 9);

    /// <include file='CBEN.xml' path='doc/member[@name="CBEN.CBEN_ENDEDIT"]/*' />
    [NativeTypeName("#define CBEN_ENDEDIT CBEN_ENDEDITW")]
    public const uint CBEN_ENDEDIT = unchecked((0U - 800U) - 6);
}
