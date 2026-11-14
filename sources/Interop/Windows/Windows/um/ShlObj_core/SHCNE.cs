// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SHCNE
{
    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_RENAMEITEM"]/*' />
    [NativeTypeName("#define SHCNE_RENAMEITEM 0x00000001L")]
    public const int SHCNE_RENAMEITEM = 0x00000001;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_CREATE"]/*' />
    [NativeTypeName("#define SHCNE_CREATE 0x00000002L")]
    public const int SHCNE_CREATE = 0x00000002;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_DELETE"]/*' />
    [NativeTypeName("#define SHCNE_DELETE 0x00000004L")]
    public const int SHCNE_DELETE = 0x00000004;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_MKDIR"]/*' />
    [NativeTypeName("#define SHCNE_MKDIR 0x00000008L")]
    public const int SHCNE_MKDIR = 0x00000008;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_RMDIR"]/*' />
    [NativeTypeName("#define SHCNE_RMDIR 0x00000010L")]
    public const int SHCNE_RMDIR = 0x00000010;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_MEDIAINSERTED"]/*' />
    [NativeTypeName("#define SHCNE_MEDIAINSERTED 0x00000020L")]
    public const int SHCNE_MEDIAINSERTED = 0x00000020;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_MEDIAREMOVED"]/*' />
    [NativeTypeName("#define SHCNE_MEDIAREMOVED 0x00000040L")]
    public const int SHCNE_MEDIAREMOVED = 0x00000040;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_DRIVEREMOVED"]/*' />
    [NativeTypeName("#define SHCNE_DRIVEREMOVED 0x00000080L")]
    public const int SHCNE_DRIVEREMOVED = 0x00000080;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_DRIVEADD"]/*' />
    [NativeTypeName("#define SHCNE_DRIVEADD 0x00000100L")]
    public const int SHCNE_DRIVEADD = 0x00000100;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_NETSHARE"]/*' />
    [NativeTypeName("#define SHCNE_NETSHARE 0x00000200L")]
    public const int SHCNE_NETSHARE = 0x00000200;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_NETUNSHARE"]/*' />
    [NativeTypeName("#define SHCNE_NETUNSHARE 0x00000400L")]
    public const int SHCNE_NETUNSHARE = 0x00000400;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_ATTRIBUTES"]/*' />
    [NativeTypeName("#define SHCNE_ATTRIBUTES 0x00000800L")]
    public const int SHCNE_ATTRIBUTES = 0x00000800;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_UPDATEDIR"]/*' />
    [NativeTypeName("#define SHCNE_UPDATEDIR 0x00001000L")]
    public const int SHCNE_UPDATEDIR = 0x00001000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_UPDATEITEM"]/*' />
    [NativeTypeName("#define SHCNE_UPDATEITEM 0x00002000L")]
    public const int SHCNE_UPDATEITEM = 0x00002000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_SERVERDISCONNECT"]/*' />
    [NativeTypeName("#define SHCNE_SERVERDISCONNECT 0x00004000L")]
    public const int SHCNE_SERVERDISCONNECT = 0x00004000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_UPDATEIMAGE"]/*' />
    [NativeTypeName("#define SHCNE_UPDATEIMAGE 0x00008000L")]
    public const int SHCNE_UPDATEIMAGE = 0x00008000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_DRIVEADDGUI"]/*' />
    [NativeTypeName("#define SHCNE_DRIVEADDGUI 0x00010000L")]
    public const int SHCNE_DRIVEADDGUI = 0x00010000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_RENAMEFOLDER"]/*' />
    [NativeTypeName("#define SHCNE_RENAMEFOLDER 0x00020000L")]
    public const int SHCNE_RENAMEFOLDER = 0x00020000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_FREESPACE"]/*' />
    [NativeTypeName("#define SHCNE_FREESPACE 0x00040000L")]
    public const int SHCNE_FREESPACE = 0x00040000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_EXTENDED_EVENT"]/*' />
    [NativeTypeName("#define SHCNE_EXTENDED_EVENT 0x04000000L")]
    public const int SHCNE_EXTENDED_EVENT = 0x04000000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_ASSOCCHANGED"]/*' />
    [NativeTypeName("#define SHCNE_ASSOCCHANGED 0x08000000L")]
    public const int SHCNE_ASSOCCHANGED = 0x08000000;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_DISKEVENTS"]/*' />
    [NativeTypeName("#define SHCNE_DISKEVENTS 0x0002381FL")]
    public const int SHCNE_DISKEVENTS = 0x0002381F;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_GLOBALEVENTS"]/*' />
    [NativeTypeName("#define SHCNE_GLOBALEVENTS 0x0C0581E0L")]
    public const int SHCNE_GLOBALEVENTS = 0x0C0581E0;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_ALLEVENTS"]/*' />
    [NativeTypeName("#define SHCNE_ALLEVENTS 0x7FFFFFFFL")]
    public const int SHCNE_ALLEVENTS = 0x7FFFFFFF;

    /// <include file='SHCNE.xml' path='doc/member[@name="SHCNE.SHCNE_INTERRUPT"]/*' />
    [NativeTypeName("#define SHCNE_INTERRUPT 0x80000000L")]
    public const uint SHCNE_INTERRUPT = 0x80000000;
}
