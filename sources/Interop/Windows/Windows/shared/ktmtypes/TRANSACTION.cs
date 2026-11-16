// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TRANSACTION
{
    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MANAGER_VOLATILE"]/*' />
    [NativeTypeName("#define TRANSACTION_MANAGER_VOLATILE 0x00000001")]
    public const int TRANSACTION_MANAGER_VOLATILE = 0x00000001;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MANAGER_COMMIT_DEFAULT"]/*' />
    [NativeTypeName("#define TRANSACTION_MANAGER_COMMIT_DEFAULT 0x00000000")]
    public const int TRANSACTION_MANAGER_COMMIT_DEFAULT = 0x00000000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MANAGER_COMMIT_SYSTEM_VOLUME"]/*' />
    [NativeTypeName("#define TRANSACTION_MANAGER_COMMIT_SYSTEM_VOLUME 0x00000002")]
    public const int TRANSACTION_MANAGER_COMMIT_SYSTEM_VOLUME = 0x00000002;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MANAGER_COMMIT_SYSTEM_HIVES"]/*' />
    [NativeTypeName("#define TRANSACTION_MANAGER_COMMIT_SYSTEM_HIVES 0x00000004")]
    public const int TRANSACTION_MANAGER_COMMIT_SYSTEM_HIVES = 0x00000004;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MANAGER_COMMIT_LOWEST"]/*' />
    [NativeTypeName("#define TRANSACTION_MANAGER_COMMIT_LOWEST 0x00000008")]
    public const int TRANSACTION_MANAGER_COMMIT_LOWEST = 0x00000008;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MANAGER_CORRUPT_FOR_RECOVERY"]/*' />
    [NativeTypeName("#define TRANSACTION_MANAGER_CORRUPT_FOR_RECOVERY 0x00000010")]
    public const int TRANSACTION_MANAGER_CORRUPT_FOR_RECOVERY = 0x00000010;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MANAGER_CORRUPT_FOR_PROGRESS"]/*' />
    [NativeTypeName("#define TRANSACTION_MANAGER_CORRUPT_FOR_PROGRESS 0x00000020")]
    public const int TRANSACTION_MANAGER_CORRUPT_FOR_PROGRESS = 0x00000020;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MANAGER_MAXIMUM_OPTION"]/*' />
    [NativeTypeName("#define TRANSACTION_MANAGER_MAXIMUM_OPTION 0x0000003F")]
    public const int TRANSACTION_MANAGER_MAXIMUM_OPTION = 0x0000003F;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_DO_NOT_PROMOTE"]/*' />
    [NativeTypeName("#define TRANSACTION_DO_NOT_PROMOTE 0x00000001")]
    public const int TRANSACTION_DO_NOT_PROMOTE = 0x00000001;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_MAXIMUM_OPTION"]/*' />
    [NativeTypeName("#define TRANSACTION_MAXIMUM_OPTION 0x00000001")]
    public const int TRANSACTION_MAXIMUM_OPTION = 0x00000001;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_MASK"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_MASK 0x3FFFFFFF")]
    public const int TRANSACTION_NOTIFY_MASK = 0x3FFFFFFF;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_PREPREPARE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_PREPREPARE 0x00000001")]
    public const int TRANSACTION_NOTIFY_PREPREPARE = 0x00000001;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_PREPARE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_PREPARE 0x00000002")]
    public const int TRANSACTION_NOTIFY_PREPARE = 0x00000002;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_COMMIT"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_COMMIT 0x00000004")]
    public const int TRANSACTION_NOTIFY_COMMIT = 0x00000004;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_ROLLBACK"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_ROLLBACK 0x00000008")]
    public const int TRANSACTION_NOTIFY_ROLLBACK = 0x00000008;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_PREPREPARE_COMPLETE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_PREPREPARE_COMPLETE 0x00000010")]
    public const int TRANSACTION_NOTIFY_PREPREPARE_COMPLETE = 0x00000010;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_PREPARE_COMPLETE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_PREPARE_COMPLETE 0x00000020")]
    public const int TRANSACTION_NOTIFY_PREPARE_COMPLETE = 0x00000020;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_COMMIT_COMPLETE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_COMMIT_COMPLETE 0x00000040")]
    public const int TRANSACTION_NOTIFY_COMMIT_COMPLETE = 0x00000040;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_ROLLBACK_COMPLETE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_ROLLBACK_COMPLETE 0x00000080")]
    public const int TRANSACTION_NOTIFY_ROLLBACK_COMPLETE = 0x00000080;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_RECOVER"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_RECOVER 0x00000100")]
    public const int TRANSACTION_NOTIFY_RECOVER = 0x00000100;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_SINGLE_PHASE_COMMIT"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_SINGLE_PHASE_COMMIT 0x00000200")]
    public const int TRANSACTION_NOTIFY_SINGLE_PHASE_COMMIT = 0x00000200;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_DELEGATE_COMMIT"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_DELEGATE_COMMIT 0x00000400")]
    public const int TRANSACTION_NOTIFY_DELEGATE_COMMIT = 0x00000400;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_RECOVER_QUERY"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_RECOVER_QUERY 0x00000800")]
    public const int TRANSACTION_NOTIFY_RECOVER_QUERY = 0x00000800;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_ENLIST_PREPREPARE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_ENLIST_PREPREPARE 0x00001000")]
    public const int TRANSACTION_NOTIFY_ENLIST_PREPREPARE = 0x00001000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_LAST_RECOVER"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_LAST_RECOVER 0x00002000")]
    public const int TRANSACTION_NOTIFY_LAST_RECOVER = 0x00002000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_INDOUBT"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_INDOUBT 0x00004000")]
    public const int TRANSACTION_NOTIFY_INDOUBT = 0x00004000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_PROPAGATE_PULL"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_PROPAGATE_PULL 0x00008000")]
    public const int TRANSACTION_NOTIFY_PROPAGATE_PULL = 0x00008000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_PROPAGATE_PUSH"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_PROPAGATE_PUSH 0x00010000")]
    public const int TRANSACTION_NOTIFY_PROPAGATE_PUSH = 0x00010000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_MARSHAL"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_MARSHAL 0x00020000")]
    public const int TRANSACTION_NOTIFY_MARSHAL = 0x00020000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_ENLIST_MASK"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_ENLIST_MASK 0x00040000")]
    public const int TRANSACTION_NOTIFY_ENLIST_MASK = 0x00040000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_RM_DISCONNECTED"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_RM_DISCONNECTED 0x01000000")]
    public const int TRANSACTION_NOTIFY_RM_DISCONNECTED = 0x01000000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_TM_ONLINE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_TM_ONLINE 0x02000000")]
    public const int TRANSACTION_NOTIFY_TM_ONLINE = 0x02000000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_COMMIT_REQUEST"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_COMMIT_REQUEST 0x04000000")]
    public const int TRANSACTION_NOTIFY_COMMIT_REQUEST = 0x04000000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_PROMOTE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_PROMOTE 0x08000000")]
    public const int TRANSACTION_NOTIFY_PROMOTE = 0x08000000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_PROMOTE_NEW"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_PROMOTE_NEW 0x10000000")]
    public const int TRANSACTION_NOTIFY_PROMOTE_NEW = 0x10000000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_REQUEST_OUTCOME"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_REQUEST_OUTCOME 0x20000000")]
    public const int TRANSACTION_NOTIFY_REQUEST_OUTCOME = 0x20000000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFY_COMMIT_FINALIZE"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFY_COMMIT_FINALIZE 0x40000000")]
    public const int TRANSACTION_NOTIFY_COMMIT_FINALIZE = 0x40000000;

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_OBJECT_PATH"]/*' />
    [NativeTypeName("#define TRANSACTION_OBJECT_PATH L\"\\Transaction\"")]
    public const string TRANSACTION_OBJECT_PATH = "\\Transaction\\";

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_OBJECT_NAME_LENGTH_IN_BYTES"]/*' />
    [NativeTypeName("#define TRANSACTION_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(TRANSACTION_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
    public const uint TRANSACTION_OBJECT_NAME_LENGTH_IN_BYTES = (28 + (38 * 2));

    /// <include file='TRANSACTION.xml' path='doc/member[@name="TRANSACTION.TRANSACTION_NOTIFICATION_TM_ONLINE_FLAG_IS_CLUSTERED"]/*' />
    [NativeTypeName("#define TRANSACTION_NOTIFICATION_TM_ONLINE_FLAG_IS_CLUSTERED 0x1")]
    public const int TRANSACTION_NOTIFICATION_TM_ONLINE_FLAG_IS_CLUSTERED = 0x1;
}
