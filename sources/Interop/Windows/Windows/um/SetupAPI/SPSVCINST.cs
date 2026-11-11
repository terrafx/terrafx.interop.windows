// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPSVCINST
{
    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_TAGTOFRONT"]/*' />
    [NativeTypeName("#define SPSVCINST_TAGTOFRONT (0x00000001)")]
    public const int SPSVCINST_TAGTOFRONT = (0x00000001);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_ASSOCSERVICE"]/*' />
    [NativeTypeName("#define SPSVCINST_ASSOCSERVICE (0x00000002)")]
    public const int SPSVCINST_ASSOCSERVICE = (0x00000002);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_DELETEEVENTLOGENTRY"]/*' />
    [NativeTypeName("#define SPSVCINST_DELETEEVENTLOGENTRY (0x00000004)")]
    public const int SPSVCINST_DELETEEVENTLOGENTRY = (0x00000004);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_DISPLAYNAME"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_DISPLAYNAME (0x00000008)")]
    public const int SPSVCINST_NOCLOBBER_DISPLAYNAME = (0x00000008);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_STARTTYPE"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_STARTTYPE (0x00000010)")]
    public const int SPSVCINST_NOCLOBBER_STARTTYPE = (0x00000010);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_ERRORCONTROL"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_ERRORCONTROL (0x00000020)")]
    public const int SPSVCINST_NOCLOBBER_ERRORCONTROL = (0x00000020);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_LOADORDERGROUP"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_LOADORDERGROUP (0x00000040)")]
    public const int SPSVCINST_NOCLOBBER_LOADORDERGROUP = (0x00000040);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_DEPENDENCIES"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_DEPENDENCIES (0x00000080)")]
    public const int SPSVCINST_NOCLOBBER_DEPENDENCIES = (0x00000080);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_DESCRIPTION"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_DESCRIPTION (0x00000100)")]
    public const int SPSVCINST_NOCLOBBER_DESCRIPTION = (0x00000100);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_STOPSERVICE"]/*' />
    [NativeTypeName("#define SPSVCINST_STOPSERVICE (0x00000200)")]
    public const int SPSVCINST_STOPSERVICE = (0x00000200);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_CLOBBER_SECURITY"]/*' />
    [NativeTypeName("#define SPSVCINST_CLOBBER_SECURITY (0x00000400)")]
    public const int SPSVCINST_CLOBBER_SECURITY = (0x00000400);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_STARTSERVICE"]/*' />
    [NativeTypeName("#define SPSVCINST_STARTSERVICE (0x00000800)")]
    public const int SPSVCINST_STARTSERVICE = (0x00000800);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_REQUIREDPRIVILEGES"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_REQUIREDPRIVILEGES (0x00001000)")]
    public const int SPSVCINST_NOCLOBBER_REQUIREDPRIVILEGES = (0x00001000);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_TRIGGERS"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_TRIGGERS (0x00002000)")]
    public const int SPSVCINST_NOCLOBBER_TRIGGERS = (0x00002000);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_SERVICESIDTYPE"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_SERVICESIDTYPE (0x00004000)")]
    public const int SPSVCINST_NOCLOBBER_SERVICESIDTYPE = (0x00004000);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_DELAYEDAUTOSTART"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_DELAYEDAUTOSTART (0x00008000)")]
    public const int SPSVCINST_NOCLOBBER_DELAYEDAUTOSTART = (0x00008000);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_UNIQUE_NAME"]/*' />
    [NativeTypeName("#define SPSVCINST_UNIQUE_NAME (0x00010000)")]
    public const int SPSVCINST_UNIQUE_NAME = (0x00010000);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_FAILUREACTIONS"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_FAILUREACTIONS (0x00020000)")]
    public const int SPSVCINST_NOCLOBBER_FAILUREACTIONS = (0x00020000);

    /// <include file='SPSVCINST.xml' path='doc/member[@name="SPSVCINST.SPSVCINST_NOCLOBBER_BOOTFLAGS"]/*' />
    [NativeTypeName("#define SPSVCINST_NOCLOBBER_BOOTFLAGS (0x00040000)")]
    public const int SPSVCINST_NOCLOBBER_BOOTFLAGS = (0x00040000);
}
