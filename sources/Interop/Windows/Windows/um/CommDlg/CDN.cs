// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CDN
{
    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_FIRST"]/*' />
    [NativeTypeName("#define CDN_FIRST (0U-601U)")]
    public const uint CDN_FIRST = unchecked(0U - 601U);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_LAST"]/*' />
    [NativeTypeName("#define CDN_LAST (0U-699U)")]
    public const uint CDN_LAST = unchecked(0U - 699U);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_INITDONE"]/*' />
    [NativeTypeName("#define CDN_INITDONE (CDN_FIRST - 0x0000)")]
    public const uint CDN_INITDONE = unchecked((0U - 601U) - 0x0000);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_SELCHANGE"]/*' />
    [NativeTypeName("#define CDN_SELCHANGE (CDN_FIRST - 0x0001)")]
    public const uint CDN_SELCHANGE = unchecked((0U - 601U) - 0x0001);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_FOLDERCHANGE"]/*' />
    [NativeTypeName("#define CDN_FOLDERCHANGE (CDN_FIRST - 0x0002)")]
    public const uint CDN_FOLDERCHANGE = unchecked((0U - 601U) - 0x0002);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_SHAREVIOLATION"]/*' />
    [NativeTypeName("#define CDN_SHAREVIOLATION (CDN_FIRST - 0x0003)")]
    public const uint CDN_SHAREVIOLATION = unchecked((0U - 601U) - 0x0003);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_HELP"]/*' />
    [NativeTypeName("#define CDN_HELP (CDN_FIRST - 0x0004)")]
    public const uint CDN_HELP = unchecked((0U - 601U) - 0x0004);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_FILEOK"]/*' />
    [NativeTypeName("#define CDN_FILEOK (CDN_FIRST - 0x0005)")]
    public const uint CDN_FILEOK = unchecked((0U - 601U) - 0x0005);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_TYPECHANGE"]/*' />
    [NativeTypeName("#define CDN_TYPECHANGE (CDN_FIRST - 0x0006)")]
    public const uint CDN_TYPECHANGE = unchecked((0U - 601U) - 0x0006);

    /// <include file='CDN.xml' path='doc/member[@name="CDN.CDN_INCLUDEITEM"]/*' />
    [NativeTypeName("#define CDN_INCLUDEITEM (CDN_FIRST - 0x0007)")]
    public const uint CDN_INCLUDEITEM = unchecked((0U - 601U) - 0x0007);
}
