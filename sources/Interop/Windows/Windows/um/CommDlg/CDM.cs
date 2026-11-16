// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CDM
{
    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_FIRST"]/*' />
    [NativeTypeName("#define CDM_FIRST (WM_USER + 100)")]
    public const int CDM_FIRST = (0x0400 + 100);

    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_LAST"]/*' />
    [NativeTypeName("#define CDM_LAST (WM_USER + 200)")]
    public const int CDM_LAST = (0x0400 + 200);

    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_GETSPEC"]/*' />
    [NativeTypeName("#define CDM_GETSPEC (CDM_FIRST + 0x0000)")]
    public const int CDM_GETSPEC = ((0x0400 + 100) + 0x0000);

    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_GETFILEPATH"]/*' />
    [NativeTypeName("#define CDM_GETFILEPATH (CDM_FIRST + 0x0001)")]
    public const int CDM_GETFILEPATH = ((0x0400 + 100) + 0x0001);

    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_GETFOLDERPATH"]/*' />
    [NativeTypeName("#define CDM_GETFOLDERPATH (CDM_FIRST + 0x0002)")]
    public const int CDM_GETFOLDERPATH = ((0x0400 + 100) + 0x0002);

    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_GETFOLDERIDLIST"]/*' />
    [NativeTypeName("#define CDM_GETFOLDERIDLIST (CDM_FIRST + 0x0003)")]
    public const int CDM_GETFOLDERIDLIST = ((0x0400 + 100) + 0x0003);

    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_SETCONTROLTEXT"]/*' />
    [NativeTypeName("#define CDM_SETCONTROLTEXT (CDM_FIRST + 0x0004)")]
    public const int CDM_SETCONTROLTEXT = ((0x0400 + 100) + 0x0004);

    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_HIDECONTROL"]/*' />
    [NativeTypeName("#define CDM_HIDECONTROL (CDM_FIRST + 0x0005)")]
    public const int CDM_HIDECONTROL = ((0x0400 + 100) + 0x0005);

    /// <include file='CDM.xml' path='doc/member[@name="CDM.CDM_SETDEFEXT"]/*' />
    [NativeTypeName("#define CDM_SETDEFEXT (CDM_FIRST + 0x0006)")]
    public const int CDM_SETDEFEXT = ((0x0400 + 100) + 0x0006);
}
