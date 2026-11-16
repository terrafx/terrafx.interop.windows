// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPFILENOTIFY
{
    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_STARTQUEUE"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_STARTQUEUE 0x00000001")]
    public const int SPFILENOTIFY_STARTQUEUE = 0x00000001;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_ENDQUEUE"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_ENDQUEUE 0x00000002")]
    public const int SPFILENOTIFY_ENDQUEUE = 0x00000002;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_STARTSUBQUEUE"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_STARTSUBQUEUE 0x00000003")]
    public const int SPFILENOTIFY_STARTSUBQUEUE = 0x00000003;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_ENDSUBQUEUE"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_ENDSUBQUEUE 0x00000004")]
    public const int SPFILENOTIFY_ENDSUBQUEUE = 0x00000004;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_STARTDELETE"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_STARTDELETE 0x00000005")]
    public const int SPFILENOTIFY_STARTDELETE = 0x00000005;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_ENDDELETE"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_ENDDELETE 0x00000006")]
    public const int SPFILENOTIFY_ENDDELETE = 0x00000006;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_DELETEERROR"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_DELETEERROR 0x00000007")]
    public const int SPFILENOTIFY_DELETEERROR = 0x00000007;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_STARTRENAME"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_STARTRENAME 0x00000008")]
    public const int SPFILENOTIFY_STARTRENAME = 0x00000008;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_ENDRENAME"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_ENDRENAME 0x00000009")]
    public const int SPFILENOTIFY_ENDRENAME = 0x00000009;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_RENAMEERROR"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_RENAMEERROR 0x0000000a")]
    public const int SPFILENOTIFY_RENAMEERROR = 0x0000000a;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_STARTCOPY"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_STARTCOPY 0x0000000b")]
    public const int SPFILENOTIFY_STARTCOPY = 0x0000000b;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_ENDCOPY"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_ENDCOPY 0x0000000c")]
    public const int SPFILENOTIFY_ENDCOPY = 0x0000000c;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_COPYERROR"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_COPYERROR 0x0000000d")]
    public const int SPFILENOTIFY_COPYERROR = 0x0000000d;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_NEEDMEDIA"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_NEEDMEDIA 0x0000000e")]
    public const int SPFILENOTIFY_NEEDMEDIA = 0x0000000e;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_QUEUESCAN"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN 0x0000000f")]
    public const int SPFILENOTIFY_QUEUESCAN = 0x0000000f;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_CABINETINFO"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_CABINETINFO 0x00000010")]
    public const int SPFILENOTIFY_CABINETINFO = 0x00000010;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_FILEINCABINET"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_FILEINCABINET 0x00000011")]
    public const int SPFILENOTIFY_FILEINCABINET = 0x00000011;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_NEEDNEWCABINET"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_NEEDNEWCABINET 0x00000012")]
    public const int SPFILENOTIFY_NEEDNEWCABINET = 0x00000012;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_FILEEXTRACTED"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_FILEEXTRACTED 0x00000013")]
    public const int SPFILENOTIFY_FILEEXTRACTED = 0x00000013;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_FILEOPDELAYED"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_FILEOPDELAYED 0x00000014")]
    public const int SPFILENOTIFY_FILEOPDELAYED = 0x00000014;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_STARTBACKUP"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_STARTBACKUP 0x00000015")]
    public const int SPFILENOTIFY_STARTBACKUP = 0x00000015;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_BACKUPERROR"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_BACKUPERROR 0x00000016")]
    public const int SPFILENOTIFY_BACKUPERROR = 0x00000016;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_ENDBACKUP"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_ENDBACKUP 0x00000017")]
    public const int SPFILENOTIFY_ENDBACKUP = 0x00000017;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_QUEUESCAN_EX"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN_EX 0x00000018")]
    public const int SPFILENOTIFY_QUEUESCAN_EX = 0x00000018;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_STARTREGISTRATION"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_STARTREGISTRATION 0x00000019")]
    public const int SPFILENOTIFY_STARTREGISTRATION = 0x00000019;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_ENDREGISTRATION"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_ENDREGISTRATION 0x00000020")]
    public const int SPFILENOTIFY_ENDREGISTRATION = 0x00000020;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_QUEUESCAN_SIGNERINFO"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN_SIGNERINFO 0x00000040")]
    public const int SPFILENOTIFY_QUEUESCAN_SIGNERINFO = 0x00000040;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_LANGMISMATCH"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_LANGMISMATCH 0x00010000")]
    public const int SPFILENOTIFY_LANGMISMATCH = 0x00010000;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_TARGETEXISTS"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_TARGETEXISTS 0x00020000")]
    public const int SPFILENOTIFY_TARGETEXISTS = 0x00020000;

    /// <include file='SPFILENOTIFY.xml' path='doc/member[@name="SPFILENOTIFY.SPFILENOTIFY_TARGETNEWER"]/*' />
    [NativeTypeName("#define SPFILENOTIFY_TARGETNEWER 0x00040000")]
    public const int SPFILENOTIFY_TARGETNEWER = 0x00040000;
}
