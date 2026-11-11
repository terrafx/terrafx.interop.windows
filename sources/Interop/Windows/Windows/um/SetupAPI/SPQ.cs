// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPQ
{
    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_FILE_PRESENCE"]/*' />
    [NativeTypeName("#define SPQ_SCAN_FILE_PRESENCE 0x00000001")]
    public const int SPQ_SCAN_FILE_PRESENCE = 0x00000001;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_FILE_VALIDITY"]/*' />
    [NativeTypeName("#define SPQ_SCAN_FILE_VALIDITY 0x00000002")]
    public const int SPQ_SCAN_FILE_VALIDITY = 0x00000002;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_USE_CALLBACK"]/*' />
    [NativeTypeName("#define SPQ_SCAN_USE_CALLBACK 0x00000004")]
    public const int SPQ_SCAN_USE_CALLBACK = 0x00000004;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_USE_CALLBACKEX"]/*' />
    [NativeTypeName("#define SPQ_SCAN_USE_CALLBACKEX 0x00000008")]
    public const int SPQ_SCAN_USE_CALLBACKEX = 0x00000008;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_INFORM_USER"]/*' />
    [NativeTypeName("#define SPQ_SCAN_INFORM_USER 0x00000010")]
    public const int SPQ_SCAN_INFORM_USER = 0x00000010;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_PRUNE_COPY_QUEUE"]/*' />
    [NativeTypeName("#define SPQ_SCAN_PRUNE_COPY_QUEUE 0x00000020")]
    public const int SPQ_SCAN_PRUNE_COPY_QUEUE = 0x00000020;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_USE_CALLBACK_SIGNERINFO"]/*' />
    [NativeTypeName("#define SPQ_SCAN_USE_CALLBACK_SIGNERINFO 0x00000040")]
    public const int SPQ_SCAN_USE_CALLBACK_SIGNERINFO = 0x00000040;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_PRUNE_DELREN"]/*' />
    [NativeTypeName("#define SPQ_SCAN_PRUNE_DELREN 0x00000080")]
    public const int SPQ_SCAN_PRUNE_DELREN = 0x00000080;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_FILE_PRESENCE_WITHOUT_SOURCE"]/*' />
    [NativeTypeName("#define SPQ_SCAN_FILE_PRESENCE_WITHOUT_SOURCE 0x00000100")]
    public const int SPQ_SCAN_FILE_PRESENCE_WITHOUT_SOURCE = 0x00000100;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_FILE_COMPARISON"]/*' />
    [NativeTypeName("#define SPQ_SCAN_FILE_COMPARISON 0x00000200")]
    public const int SPQ_SCAN_FILE_COMPARISON = 0x00000200;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_ACTIVATE_DRP"]/*' />
    [NativeTypeName("#define SPQ_SCAN_ACTIVATE_DRP 0x00000400")]
    public const int SPQ_SCAN_ACTIVATE_DRP = 0x00000400;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_SCAN_USE_OEM_CATALOGS"]/*' />
    [NativeTypeName("#define SPQ_SCAN_USE_OEM_CATALOGS 0x00000800")]
    public const int SPQ_SCAN_USE_OEM_CATALOGS = 0x00000800;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_DELAYED_COPY"]/*' />
    [NativeTypeName("#define SPQ_DELAYED_COPY 0x00000001")]
    public const int SPQ_DELAYED_COPY = 0x00000001;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_FLAG_BACKUP_AWARE"]/*' />
    [NativeTypeName("#define SPQ_FLAG_BACKUP_AWARE 0x00000001")]
    public const int SPQ_FLAG_BACKUP_AWARE = 0x00000001;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_FLAG_ABORT_IF_UNSIGNED"]/*' />
    [NativeTypeName("#define SPQ_FLAG_ABORT_IF_UNSIGNED 0x00000002")]
    public const int SPQ_FLAG_ABORT_IF_UNSIGNED = 0x00000002;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_FLAG_FILES_MODIFIED"]/*' />
    [NativeTypeName("#define SPQ_FLAG_FILES_MODIFIED 0x00000004")]
    public const int SPQ_FLAG_FILES_MODIFIED = 0x00000004;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_FLAG_DO_SHUFFLEMOVE"]/*' />
    [NativeTypeName("#define SPQ_FLAG_DO_SHUFFLEMOVE 0x00000008")]
    public const int SPQ_FLAG_DO_SHUFFLEMOVE = 0x00000008;

    /// <include file='SPQ.xml' path='doc/member[@name="SPQ.SPQ_FLAG_VALID"]/*' />
    [NativeTypeName("#define SPQ_FLAG_VALID 0x0000000F")]
    public const int SPQ_FLAG_VALID = 0x0000000F;
}
