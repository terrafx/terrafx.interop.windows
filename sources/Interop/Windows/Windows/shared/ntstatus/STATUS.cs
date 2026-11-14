// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STATUS
{
    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SEVERITY_SUCCESS"]/*' />
    [NativeTypeName("#define STATUS_SEVERITY_SUCCESS 0x0")]
    public const int STATUS_SEVERITY_SUCCESS = 0x0;

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SEVERITY_INFORMATIONAL"]/*' />
    [NativeTypeName("#define STATUS_SEVERITY_INFORMATIONAL 0x1")]
    public const int STATUS_SEVERITY_INFORMATIONAL = 0x1;

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SEVERITY_WARNING"]/*' />
    [NativeTypeName("#define STATUS_SEVERITY_WARNING 0x2")]
    public const int STATUS_SEVERITY_WARNING = 0x2;

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SEVERITY_ERROR"]/*' />
    [NativeTypeName("#define STATUS_SEVERITY_ERROR 0x3")]
    public const int STATUS_SEVERITY_ERROR = 0x3;

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SUCCESS"]/*' />
    [NativeTypeName("#define STATUS_SUCCESS ((NTSTATUS)0x00000000L)")]
    public const int STATUS_SUCCESS = ((int)(0x00000000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAIT_1"]/*' />
    [NativeTypeName("#define STATUS_WAIT_1 ((NTSTATUS)0x00000001L)")]
    public const int STATUS_WAIT_1 = ((int)(0x00000001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAIT_2"]/*' />
    [NativeTypeName("#define STATUS_WAIT_2 ((NTSTATUS)0x00000002L)")]
    public const int STATUS_WAIT_2 = ((int)(0x00000002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAIT_3"]/*' />
    [NativeTypeName("#define STATUS_WAIT_3 ((NTSTATUS)0x00000003L)")]
    public const int STATUS_WAIT_3 = ((int)(0x00000003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAIT_63"]/*' />
    [NativeTypeName("#define STATUS_WAIT_63 ((NTSTATUS)0x0000003FL)")]
    public const int STATUS_WAIT_63 = ((int)(0x0000003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABANDONED"]/*' />
    [NativeTypeName("#define STATUS_ABANDONED ((NTSTATUS)0x00000080L)")]
    public const int STATUS_ABANDONED = ((int)(0x00000080));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABANDONED_WAIT_63"]/*' />
    [NativeTypeName("#define STATUS_ABANDONED_WAIT_63 ((NTSTATUS)0x000000BFL)")]
    public const int STATUS_ABANDONED_WAIT_63 = ((int)(0x000000BF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALREADY_COMPLETE"]/*' />
    [NativeTypeName("#define STATUS_ALREADY_COMPLETE ((NTSTATUS)0x000000FFL)")]
    public const int STATUS_ALREADY_COMPLETE = ((int)(0x000000FF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KERNEL_APC"]/*' />
    [NativeTypeName("#define STATUS_KERNEL_APC ((NTSTATUS)0x00000100L)")]
    public const int STATUS_KERNEL_APC = ((int)(0x00000100));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALERTED"]/*' />
    [NativeTypeName("#define STATUS_ALERTED ((NTSTATUS)0x00000101L)")]
    public const int STATUS_ALERTED = ((int)(0x00000101));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REPARSE"]/*' />
    [NativeTypeName("#define STATUS_REPARSE ((NTSTATUS)0x00000104L)")]
    public const int STATUS_REPARSE = ((int)(0x00000104));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MORE_ENTRIES"]/*' />
    [NativeTypeName("#define STATUS_MORE_ENTRIES ((NTSTATUS)0x00000105L)")]
    public const int STATUS_MORE_ENTRIES = ((int)(0x00000105));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_ALL_ASSIGNED"]/*' />
    [NativeTypeName("#define STATUS_NOT_ALL_ASSIGNED ((NTSTATUS)0x00000106L)")]
    public const int STATUS_NOT_ALL_ASSIGNED = ((int)(0x00000106));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SOME_NOT_MAPPED"]/*' />
    [NativeTypeName("#define STATUS_SOME_NOT_MAPPED ((NTSTATUS)0x00000107L)")]
    public const int STATUS_SOME_NOT_MAPPED = ((int)(0x00000107));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OPLOCK_BREAK_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_OPLOCK_BREAK_IN_PROGRESS ((NTSTATUS)0x00000108L)")]
    public const int STATUS_OPLOCK_BREAK_IN_PROGRESS = ((int)(0x00000108));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_MOUNTED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_MOUNTED ((NTSTATUS)0x00000109L)")]
    public const int STATUS_VOLUME_MOUNTED = ((int)(0x00000109));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RXACT_COMMITTED"]/*' />
    [NativeTypeName("#define STATUS_RXACT_COMMITTED ((NTSTATUS)0x0000010AL)")]
    public const int STATUS_RXACT_COMMITTED = ((int)(0x0000010A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOTIFY_CLEANUP"]/*' />
    [NativeTypeName("#define STATUS_NOTIFY_CLEANUP ((NTSTATUS)0x0000010BL)")]
    public const int STATUS_NOTIFY_CLEANUP = ((int)(0x0000010B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOTIFY_ENUM_DIR"]/*' />
    [NativeTypeName("#define STATUS_NOTIFY_ENUM_DIR ((NTSTATUS)0x0000010CL)")]
    public const int STATUS_NOTIFY_ENUM_DIR = ((int)(0x0000010C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_QUOTAS_FOR_ACCOUNT"]/*' />
    [NativeTypeName("#define STATUS_NO_QUOTAS_FOR_ACCOUNT ((NTSTATUS)0x0000010DL)")]
    public const int STATUS_NO_QUOTAS_FOR_ACCOUNT = ((int)(0x0000010D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRIMARY_TRANSPORT_CONNECT_FAILED"]/*' />
    [NativeTypeName("#define STATUS_PRIMARY_TRANSPORT_CONNECT_FAILED ((NTSTATUS)0x0000010EL)")]
    public const int STATUS_PRIMARY_TRANSPORT_CONNECT_FAILED = ((int)(0x0000010E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGE_FAULT_TRANSITION"]/*' />
    [NativeTypeName("#define STATUS_PAGE_FAULT_TRANSITION ((NTSTATUS)0x00000110L)")]
    public const int STATUS_PAGE_FAULT_TRANSITION = ((int)(0x00000110));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGE_FAULT_DEMAND_ZERO"]/*' />
    [NativeTypeName("#define STATUS_PAGE_FAULT_DEMAND_ZERO ((NTSTATUS)0x00000111L)")]
    public const int STATUS_PAGE_FAULT_DEMAND_ZERO = ((int)(0x00000111));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGE_FAULT_COPY_ON_WRITE"]/*' />
    [NativeTypeName("#define STATUS_PAGE_FAULT_COPY_ON_WRITE ((NTSTATUS)0x00000112L)")]
    public const int STATUS_PAGE_FAULT_COPY_ON_WRITE = ((int)(0x00000112));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGE_FAULT_GUARD_PAGE"]/*' />
    [NativeTypeName("#define STATUS_PAGE_FAULT_GUARD_PAGE ((NTSTATUS)0x00000113L)")]
    public const int STATUS_PAGE_FAULT_GUARD_PAGE = ((int)(0x00000113));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGE_FAULT_PAGING_FILE"]/*' />
    [NativeTypeName("#define STATUS_PAGE_FAULT_PAGING_FILE ((NTSTATUS)0x00000114L)")]
    public const int STATUS_PAGE_FAULT_PAGING_FILE = ((int)(0x00000114));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CACHE_PAGE_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_CACHE_PAGE_LOCKED ((NTSTATUS)0x00000115L)")]
    public const int STATUS_CACHE_PAGE_LOCKED = ((int)(0x00000115));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CRASH_DUMP"]/*' />
    [NativeTypeName("#define STATUS_CRASH_DUMP ((NTSTATUS)0x00000116L)")]
    public const int STATUS_CRASH_DUMP = ((int)(0x00000116));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BUFFER_ALL_ZEROS"]/*' />
    [NativeTypeName("#define STATUS_BUFFER_ALL_ZEROS ((NTSTATUS)0x00000117L)")]
    public const int STATUS_BUFFER_ALL_ZEROS = ((int)(0x00000117));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REPARSE_OBJECT"]/*' />
    [NativeTypeName("#define STATUS_REPARSE_OBJECT ((NTSTATUS)0x00000118L)")]
    public const int STATUS_REPARSE_OBJECT = ((int)(0x00000118));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCE_REQUIREMENTS_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_RESOURCE_REQUIREMENTS_CHANGED ((NTSTATUS)0x00000119L)")]
    public const int STATUS_RESOURCE_REQUIREMENTS_CHANGED = ((int)(0x00000119));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSLATION_COMPLETE"]/*' />
    [NativeTypeName("#define STATUS_TRANSLATION_COMPLETE ((NTSTATUS)0x00000120L)")]
    public const int STATUS_TRANSLATION_COMPLETE = ((int)(0x00000120));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_MEMBERSHIP_EVALUATED_LOCALLY"]/*' />
    [NativeTypeName("#define STATUS_DS_MEMBERSHIP_EVALUATED_LOCALLY ((NTSTATUS)0x00000121L)")]
    public const int STATUS_DS_MEMBERSHIP_EVALUATED_LOCALLY = ((int)(0x00000121));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOTHING_TO_TERMINATE"]/*' />
    [NativeTypeName("#define STATUS_NOTHING_TO_TERMINATE ((NTSTATUS)0x00000122L)")]
    public const int STATUS_NOTHING_TO_TERMINATE = ((int)(0x00000122));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROCESS_NOT_IN_JOB"]/*' />
    [NativeTypeName("#define STATUS_PROCESS_NOT_IN_JOB ((NTSTATUS)0x00000123L)")]
    public const int STATUS_PROCESS_NOT_IN_JOB = ((int)(0x00000123));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROCESS_IN_JOB"]/*' />
    [NativeTypeName("#define STATUS_PROCESS_IN_JOB ((NTSTATUS)0x00000124L)")]
    public const int STATUS_PROCESS_IN_JOB = ((int)(0x00000124));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLSNAP_HIBERNATE_READY"]/*' />
    [NativeTypeName("#define STATUS_VOLSNAP_HIBERNATE_READY ((NTSTATUS)0x00000125L)")]
    public const int STATUS_VOLSNAP_HIBERNATE_READY = ((int)(0x00000125));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FSFILTER_OP_COMPLETED_SUCCESSFULLY"]/*' />
    [NativeTypeName("#define STATUS_FSFILTER_OP_COMPLETED_SUCCESSFULLY ((NTSTATUS)0x00000126L)")]
    public const int STATUS_FSFILTER_OP_COMPLETED_SUCCESSFULLY = ((int)(0x00000126));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTERRUPT_VECTOR_ALREADY_CONNECTED"]/*' />
    [NativeTypeName("#define STATUS_INTERRUPT_VECTOR_ALREADY_CONNECTED ((NTSTATUS)0x00000127L)")]
    public const int STATUS_INTERRUPT_VECTOR_ALREADY_CONNECTED = ((int)(0x00000127));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTERRUPT_STILL_CONNECTED"]/*' />
    [NativeTypeName("#define STATUS_INTERRUPT_STILL_CONNECTED ((NTSTATUS)0x00000128L)")]
    public const int STATUS_INTERRUPT_STILL_CONNECTED = ((int)(0x00000128));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROCESS_CLONED"]/*' />
    [NativeTypeName("#define STATUS_PROCESS_CLONED ((NTSTATUS)0x00000129L)")]
    public const int STATUS_PROCESS_CLONED = ((int)(0x00000129));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_LOCKED_WITH_ONLY_READERS"]/*' />
    [NativeTypeName("#define STATUS_FILE_LOCKED_WITH_ONLY_READERS ((NTSTATUS)0x0000012AL)")]
    public const int STATUS_FILE_LOCKED_WITH_ONLY_READERS = ((int)(0x0000012A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_LOCKED_WITH_WRITERS"]/*' />
    [NativeTypeName("#define STATUS_FILE_LOCKED_WITH_WRITERS ((NTSTATUS)0x0000012BL)")]
    public const int STATUS_FILE_LOCKED_WITH_WRITERS = ((int)(0x0000012B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VALID_IMAGE_HASH"]/*' />
    [NativeTypeName("#define STATUS_VALID_IMAGE_HASH ((NTSTATUS)0x0000012CL)")]
    public const int STATUS_VALID_IMAGE_HASH = ((int)(0x0000012C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VALID_CATALOG_HASH"]/*' />
    [NativeTypeName("#define STATUS_VALID_CATALOG_HASH ((NTSTATUS)0x0000012DL)")]
    public const int STATUS_VALID_CATALOG_HASH = ((int)(0x0000012D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VALID_STRONG_CODE_HASH"]/*' />
    [NativeTypeName("#define STATUS_VALID_STRONG_CODE_HASH ((NTSTATUS)0x0000012EL)")]
    public const int STATUS_VALID_STRONG_CODE_HASH = ((int)(0x0000012E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GHOSTED"]/*' />
    [NativeTypeName("#define STATUS_GHOSTED ((NTSTATUS)0x0000012FL)")]
    public const int STATUS_GHOSTED = ((int)(0x0000012F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATA_OVERWRITTEN"]/*' />
    [NativeTypeName("#define STATUS_DATA_OVERWRITTEN ((NTSTATUS)0x00000130L)")]
    public const int STATUS_DATA_OVERWRITTEN = ((int)(0x00000130));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCEMANAGER_READ_ONLY"]/*' />
    [NativeTypeName("#define STATUS_RESOURCEMANAGER_READ_ONLY ((NTSTATUS)0x00000202L)")]
    public const int STATUS_RESOURCEMANAGER_READ_ONLY = ((int)(0x00000202));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RING_PREVIOUSLY_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_RING_PREVIOUSLY_EMPTY ((NTSTATUS)0x00000210L)")]
    public const int STATUS_RING_PREVIOUSLY_EMPTY = ((int)(0x00000210));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RING_PREVIOUSLY_FULL"]/*' />
    [NativeTypeName("#define STATUS_RING_PREVIOUSLY_FULL ((NTSTATUS)0x00000211L)")]
    public const int STATUS_RING_PREVIOUSLY_FULL = ((int)(0x00000211));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RING_PREVIOUSLY_ABOVE_QUOTA"]/*' />
    [NativeTypeName("#define STATUS_RING_PREVIOUSLY_ABOVE_QUOTA ((NTSTATUS)0x00000212L)")]
    public const int STATUS_RING_PREVIOUSLY_ABOVE_QUOTA = ((int)(0x00000212));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RING_NEWLY_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_RING_NEWLY_EMPTY ((NTSTATUS)0x00000213L)")]
    public const int STATUS_RING_NEWLY_EMPTY = ((int)(0x00000213));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RING_SIGNAL_OPPOSITE_ENDPOINT"]/*' />
    [NativeTypeName("#define STATUS_RING_SIGNAL_OPPOSITE_ENDPOINT ((NTSTATUS)0x00000214L)")]
    public const int STATUS_RING_SIGNAL_OPPOSITE_ENDPOINT = ((int)(0x00000214));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OPLOCK_SWITCHED_TO_NEW_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_OPLOCK_SWITCHED_TO_NEW_HANDLE ((NTSTATUS)0x00000215L)")]
    public const int STATUS_OPLOCK_SWITCHED_TO_NEW_HANDLE = ((int)(0x00000215));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OPLOCK_HANDLE_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_OPLOCK_HANDLE_CLOSED ((NTSTATUS)0x00000216L)")]
    public const int STATUS_OPLOCK_HANDLE_CLOSED = ((int)(0x00000216));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAIT_FOR_OPLOCK"]/*' />
    [NativeTypeName("#define STATUS_WAIT_FOR_OPLOCK ((NTSTATUS)0x00000367L)")]
    public const int STATUS_WAIT_FOR_OPLOCK = ((int)(0x00000367));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REPARSE_GLOBAL"]/*' />
    [NativeTypeName("#define STATUS_REPARSE_GLOBAL ((NTSTATUS)0x00000368L)")]
    public const int STATUS_REPARSE_GLOBAL = ((int)(0x00000368));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGE_FAULT_RETRY"]/*' />
    [NativeTypeName("#define STATUS_PAGE_FAULT_RETRY ((NTSTATUS)0x00000369L)")]
    public const int STATUS_PAGE_FAULT_RETRY = ((int)(0x00000369));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_IO_COMPLETE"]/*' />
    [NativeTypeName("#define STATUS_FLT_IO_COMPLETE ((NTSTATUS)0x001C0001L)")]
    public const int STATUS_FLT_IO_COMPLETE = ((int)(0x001C0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_NAME_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_NAME_EXISTS ((NTSTATUS)0x40000000L)")]
    public const int STATUS_OBJECT_NAME_EXISTS = ((int)(0x40000000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREAD_WAS_SUSPENDED"]/*' />
    [NativeTypeName("#define STATUS_THREAD_WAS_SUSPENDED ((NTSTATUS)0x40000001L)")]
    public const int STATUS_THREAD_WAS_SUSPENDED = ((int)(0x40000001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WORKING_SET_LIMIT_RANGE"]/*' />
    [NativeTypeName("#define STATUS_WORKING_SET_LIMIT_RANGE ((NTSTATUS)0x40000002L)")]
    public const int STATUS_WORKING_SET_LIMIT_RANGE = ((int)(0x40000002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_NOT_AT_BASE"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_NOT_AT_BASE ((NTSTATUS)0x40000003L)")]
    public const int STATUS_IMAGE_NOT_AT_BASE = ((int)(0x40000003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RXACT_STATE_CREATED"]/*' />
    [NativeTypeName("#define STATUS_RXACT_STATE_CREATED ((NTSTATUS)0x40000004L)")]
    public const int STATUS_RXACT_STATE_CREATED = ((int)(0x40000004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOCAL_USER_SESSION_KEY"]/*' />
    [NativeTypeName("#define STATUS_LOCAL_USER_SESSION_KEY ((NTSTATUS)0x40000006L)")]
    public const int STATUS_LOCAL_USER_SESSION_KEY = ((int)(0x40000006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_CURRENT_DIRECTORY"]/*' />
    [NativeTypeName("#define STATUS_BAD_CURRENT_DIRECTORY ((NTSTATUS)0x40000007L)")]
    public const int STATUS_BAD_CURRENT_DIRECTORY = ((int)(0x40000007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERIAL_MORE_WRITES"]/*' />
    [NativeTypeName("#define STATUS_SERIAL_MORE_WRITES ((NTSTATUS)0x40000008L)")]
    public const int STATUS_SERIAL_MORE_WRITES = ((int)(0x40000008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REGISTRY_RECOVERED"]/*' />
    [NativeTypeName("#define STATUS_REGISTRY_RECOVERED ((NTSTATUS)0x40000009L)")]
    public const int STATUS_REGISTRY_RECOVERED = ((int)(0x40000009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_READ_RECOVERY_FROM_BACKUP"]/*' />
    [NativeTypeName("#define STATUS_FT_READ_RECOVERY_FROM_BACKUP ((NTSTATUS)0x4000000AL)")]
    public const int STATUS_FT_READ_RECOVERY_FROM_BACKUP = ((int)(0x4000000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_WRITE_RECOVERY"]/*' />
    [NativeTypeName("#define STATUS_FT_WRITE_RECOVERY ((NTSTATUS)0x4000000BL)")]
    public const int STATUS_FT_WRITE_RECOVERY = ((int)(0x4000000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERIAL_COUNTER_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_SERIAL_COUNTER_TIMEOUT ((NTSTATUS)0x4000000CL)")]
    public const int STATUS_SERIAL_COUNTER_TIMEOUT = ((int)(0x4000000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NULL_LM_PASSWORD"]/*' />
    [NativeTypeName("#define STATUS_NULL_LM_PASSWORD ((NTSTATUS)0x4000000DL)")]
    public const int STATUS_NULL_LM_PASSWORD = ((int)(0x4000000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_MACHINE_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_MACHINE_TYPE_MISMATCH ((NTSTATUS)0x4000000EL)")]
    public const int STATUS_IMAGE_MACHINE_TYPE_MISMATCH = ((int)(0x4000000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RECEIVE_PARTIAL"]/*' />
    [NativeTypeName("#define STATUS_RECEIVE_PARTIAL ((NTSTATUS)0x4000000FL)")]
    public const int STATUS_RECEIVE_PARTIAL = ((int)(0x4000000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RECEIVE_EXPEDITED"]/*' />
    [NativeTypeName("#define STATUS_RECEIVE_EXPEDITED ((NTSTATUS)0x40000010L)")]
    public const int STATUS_RECEIVE_EXPEDITED = ((int)(0x40000010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RECEIVE_PARTIAL_EXPEDITED"]/*' />
    [NativeTypeName("#define STATUS_RECEIVE_PARTIAL_EXPEDITED ((NTSTATUS)0x40000011L)")]
    public const int STATUS_RECEIVE_PARTIAL_EXPEDITED = ((int)(0x40000011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EVENT_DONE"]/*' />
    [NativeTypeName("#define STATUS_EVENT_DONE ((NTSTATUS)0x40000012L)")]
    public const int STATUS_EVENT_DONE = ((int)(0x40000012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EVENT_PENDING"]/*' />
    [NativeTypeName("#define STATUS_EVENT_PENDING ((NTSTATUS)0x40000013L)")]
    public const int STATUS_EVENT_PENDING = ((int)(0x40000013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CHECKING_FILE_SYSTEM"]/*' />
    [NativeTypeName("#define STATUS_CHECKING_FILE_SYSTEM ((NTSTATUS)0x40000014L)")]
    public const int STATUS_CHECKING_FILE_SYSTEM = ((int)(0x40000014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PREDEFINED_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_PREDEFINED_HANDLE ((NTSTATUS)0x40000016L)")]
    public const int STATUS_PREDEFINED_HANDLE = ((int)(0x40000016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAS_UNLOCKED"]/*' />
    [NativeTypeName("#define STATUS_WAS_UNLOCKED ((NTSTATUS)0x40000017L)")]
    public const int STATUS_WAS_UNLOCKED = ((int)(0x40000017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVICE_NOTIFICATION"]/*' />
    [NativeTypeName("#define STATUS_SERVICE_NOTIFICATION ((NTSTATUS)0x40000018L)")]
    public const int STATUS_SERVICE_NOTIFICATION = ((int)(0x40000018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAS_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_WAS_LOCKED ((NTSTATUS)0x40000019L)")]
    public const int STATUS_WAS_LOCKED = ((int)(0x40000019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_HARD_ERROR"]/*' />
    [NativeTypeName("#define STATUS_LOG_HARD_ERROR ((NTSTATUS)0x4000001AL)")]
    public const int STATUS_LOG_HARD_ERROR = ((int)(0x4000001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALREADY_WIN32"]/*' />
    [NativeTypeName("#define STATUS_ALREADY_WIN32 ((NTSTATUS)0x4000001BL)")]
    public const int STATUS_ALREADY_WIN32 = ((int)(0x4000001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_UNSIMULATE"]/*' />
    [NativeTypeName("#define STATUS_WX86_UNSIMULATE ((NTSTATUS)0x4000001CL)")]
    public const int STATUS_WX86_UNSIMULATE = ((int)(0x4000001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_CONTINUE"]/*' />
    [NativeTypeName("#define STATUS_WX86_CONTINUE ((NTSTATUS)0x4000001DL)")]
    public const int STATUS_WX86_CONTINUE = ((int)(0x4000001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_SINGLE_STEP"]/*' />
    [NativeTypeName("#define STATUS_WX86_SINGLE_STEP ((NTSTATUS)0x4000001EL)")]
    public const int STATUS_WX86_SINGLE_STEP = ((int)(0x4000001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_BREAKPOINT"]/*' />
    [NativeTypeName("#define STATUS_WX86_BREAKPOINT ((NTSTATUS)0x4000001FL)")]
    public const int STATUS_WX86_BREAKPOINT = ((int)(0x4000001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_EXCEPTION_CONTINUE"]/*' />
    [NativeTypeName("#define STATUS_WX86_EXCEPTION_CONTINUE ((NTSTATUS)0x40000020L)")]
    public const int STATUS_WX86_EXCEPTION_CONTINUE = ((int)(0x40000020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_EXCEPTION_LASTCHANCE"]/*' />
    [NativeTypeName("#define STATUS_WX86_EXCEPTION_LASTCHANCE ((NTSTATUS)0x40000021L)")]
    public const int STATUS_WX86_EXCEPTION_LASTCHANCE = ((int)(0x40000021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_EXCEPTION_CHAIN"]/*' />
    [NativeTypeName("#define STATUS_WX86_EXCEPTION_CHAIN ((NTSTATUS)0x40000022L)")]
    public const int STATUS_WX86_EXCEPTION_CHAIN = ((int)(0x40000022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_MACHINE_TYPE_MISMATCH_EXE"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_MACHINE_TYPE_MISMATCH_EXE ((NTSTATUS)0x40000023L)")]
    public const int STATUS_IMAGE_MACHINE_TYPE_MISMATCH_EXE = ((int)(0x40000023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_YIELD_PERFORMED"]/*' />
    [NativeTypeName("#define STATUS_NO_YIELD_PERFORMED ((NTSTATUS)0x40000024L)")]
    public const int STATUS_NO_YIELD_PERFORMED = ((int)(0x40000024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TIMER_RESUME_IGNORED"]/*' />
    [NativeTypeName("#define STATUS_TIMER_RESUME_IGNORED ((NTSTATUS)0x40000025L)")]
    public const int STATUS_TIMER_RESUME_IGNORED = ((int)(0x40000025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ARBITRATION_UNHANDLED"]/*' />
    [NativeTypeName("#define STATUS_ARBITRATION_UNHANDLED ((NTSTATUS)0x40000026L)")]
    public const int STATUS_ARBITRATION_UNHANDLED = ((int)(0x40000026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CARDBUS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_CARDBUS_NOT_SUPPORTED ((NTSTATUS)0x40000027L)")]
    public const int STATUS_CARDBUS_NOT_SUPPORTED = ((int)(0x40000027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_CREATEWX86TIB"]/*' />
    [NativeTypeName("#define STATUS_WX86_CREATEWX86TIB ((NTSTATUS)0x40000028L)")]
    public const int STATUS_WX86_CREATEWX86TIB = ((int)(0x40000028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MP_PROCESSOR_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_MP_PROCESSOR_MISMATCH ((NTSTATUS)0x40000029L)")]
    public const int STATUS_MP_PROCESSOR_MISMATCH = ((int)(0x40000029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HIBERNATED"]/*' />
    [NativeTypeName("#define STATUS_HIBERNATED ((NTSTATUS)0x4000002AL)")]
    public const int STATUS_HIBERNATED = ((int)(0x4000002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESUME_HIBERNATION"]/*' />
    [NativeTypeName("#define STATUS_RESUME_HIBERNATION ((NTSTATUS)0x4000002BL)")]
    public const int STATUS_RESUME_HIBERNATION = ((int)(0x4000002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FIRMWARE_UPDATED"]/*' />
    [NativeTypeName("#define STATUS_FIRMWARE_UPDATED ((NTSTATUS)0x4000002CL)")]
    public const int STATUS_FIRMWARE_UPDATED = ((int)(0x4000002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVERS_LEAKING_LOCKED_PAGES"]/*' />
    [NativeTypeName("#define STATUS_DRIVERS_LEAKING_LOCKED_PAGES ((NTSTATUS)0x4000002DL)")]
    public const int STATUS_DRIVERS_LEAKING_LOCKED_PAGES = ((int)(0x4000002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MESSAGE_RETRIEVED"]/*' />
    [NativeTypeName("#define STATUS_MESSAGE_RETRIEVED ((NTSTATUS)0x4000002EL)")]
    public const int STATUS_MESSAGE_RETRIEVED = ((int)(0x4000002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_POWERSTATE_TRANSITION"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_POWERSTATE_TRANSITION ((NTSTATUS)0x4000002FL)")]
    public const int STATUS_SYSTEM_POWERSTATE_TRANSITION = ((int)(0x4000002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALPC_CHECK_COMPLETION_LIST"]/*' />
    [NativeTypeName("#define STATUS_ALPC_CHECK_COMPLETION_LIST ((NTSTATUS)0x40000030L)")]
    public const int STATUS_ALPC_CHECK_COMPLETION_LIST = ((int)(0x40000030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_POWERSTATE_COMPLEX_TRANSITION"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_POWERSTATE_COMPLEX_TRANSITION ((NTSTATUS)0x40000031L)")]
    public const int STATUS_SYSTEM_POWERSTATE_COMPLEX_TRANSITION = ((int)(0x40000031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCESS_AUDIT_BY_POLICY"]/*' />
    [NativeTypeName("#define STATUS_ACCESS_AUDIT_BY_POLICY ((NTSTATUS)0x40000032L)")]
    public const int STATUS_ACCESS_AUDIT_BY_POLICY = ((int)(0x40000032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABANDON_HIBERFILE"]/*' />
    [NativeTypeName("#define STATUS_ABANDON_HIBERFILE ((NTSTATUS)0x40000033L)")]
    public const int STATUS_ABANDON_HIBERFILE = ((int)(0x40000033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BIZRULES_NOT_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_BIZRULES_NOT_ENABLED ((NTSTATUS)0x40000034L)")]
    public const int STATUS_BIZRULES_NOT_ENABLED = ((int)(0x40000034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_READ_FROM_COPY"]/*' />
    [NativeTypeName("#define STATUS_FT_READ_FROM_COPY ((NTSTATUS)0x40000035L)")]
    public const int STATUS_FT_READ_FROM_COPY = ((int)(0x40000035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_AT_DIFFERENT_BASE"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_AT_DIFFERENT_BASE ((NTSTATUS)0x40000036L)")]
    public const int STATUS_IMAGE_AT_DIFFERENT_BASE = ((int)(0x40000036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PATCH_DEFERRED"]/*' />
    [NativeTypeName("#define STATUS_PATCH_DEFERRED ((NTSTATUS)0x40000037L)")]
    public const int STATUS_PATCH_DEFERRED = ((int)(0x40000037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EMULATION_BREAKPOINT"]/*' />
    [NativeTypeName("#define STATUS_EMULATION_BREAKPOINT ((NTSTATUS)0x40000038L)")]
    public const int STATUS_EMULATION_BREAKPOINT = ((int)(0x40000038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EMULATION_SYSCALL"]/*' />
    [NativeTypeName("#define STATUS_EMULATION_SYSCALL ((NTSTATUS)0x40000039L)")]
    public const int STATUS_EMULATION_SYSCALL = ((int)(0x40000039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EMULATION_FLOAT_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_EMULATION_FLOAT_EXCEPTION ((NTSTATUS)0x4000003AL)")]
    public const int STATUS_EMULATION_FLOAT_EXCEPTION = ((int)(0x4000003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HEURISTIC_DAMAGE_POSSIBLE"]/*' />
    [NativeTypeName("#define STATUS_HEURISTIC_DAMAGE_POSSIBLE ((NTSTATUS)0x40190001L)")]
    public const int STATUS_HEURISTIC_DAMAGE_POSSIBLE = ((int)(0x40190001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BUFFER_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_BUFFER_OVERFLOW ((NTSTATUS)0x80000005L)")]
    public const int STATUS_BUFFER_OVERFLOW = unchecked((int)(0x80000005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_MORE_FILES"]/*' />
    [NativeTypeName("#define STATUS_NO_MORE_FILES ((NTSTATUS)0x80000006L)")]
    public const int STATUS_NO_MORE_FILES = unchecked((int)(0x80000006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAKE_SYSTEM_DEBUGGER"]/*' />
    [NativeTypeName("#define STATUS_WAKE_SYSTEM_DEBUGGER ((NTSTATUS)0x80000007L)")]
    public const int STATUS_WAKE_SYSTEM_DEBUGGER = unchecked((int)(0x80000007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HANDLES_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_HANDLES_CLOSED ((NTSTATUS)0x8000000AL)")]
    public const int STATUS_HANDLES_CLOSED = unchecked((int)(0x8000000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_INHERITANCE"]/*' />
    [NativeTypeName("#define STATUS_NO_INHERITANCE ((NTSTATUS)0x8000000BL)")]
    public const int STATUS_NO_INHERITANCE = unchecked((int)(0x8000000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GUID_SUBSTITUTION_MADE"]/*' />
    [NativeTypeName("#define STATUS_GUID_SUBSTITUTION_MADE ((NTSTATUS)0x8000000CL)")]
    public const int STATUS_GUID_SUBSTITUTION_MADE = unchecked((int)(0x8000000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PARTIAL_COPY"]/*' />
    [NativeTypeName("#define STATUS_PARTIAL_COPY ((NTSTATUS)0x8000000DL)")]
    public const int STATUS_PARTIAL_COPY = unchecked((int)(0x8000000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_PAPER_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_PAPER_EMPTY ((NTSTATUS)0x8000000EL)")]
    public const int STATUS_DEVICE_PAPER_EMPTY = unchecked((int)(0x8000000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_POWERED_OFF"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_POWERED_OFF ((NTSTATUS)0x8000000FL)")]
    public const int STATUS_DEVICE_POWERED_OFF = unchecked((int)(0x8000000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_OFF_LINE"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_OFF_LINE ((NTSTATUS)0x80000010L)")]
    public const int STATUS_DEVICE_OFF_LINE = unchecked((int)(0x80000010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_BUSY"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_BUSY ((NTSTATUS)0x80000011L)")]
    public const int STATUS_DEVICE_BUSY = unchecked((int)(0x80000011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_MORE_EAS"]/*' />
    [NativeTypeName("#define STATUS_NO_MORE_EAS ((NTSTATUS)0x80000012L)")]
    public const int STATUS_NO_MORE_EAS = unchecked((int)(0x80000012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_EA_NAME"]/*' />
    [NativeTypeName("#define STATUS_INVALID_EA_NAME ((NTSTATUS)0x80000013L)")]
    public const int STATUS_INVALID_EA_NAME = unchecked((int)(0x80000013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EA_LIST_INCONSISTENT"]/*' />
    [NativeTypeName("#define STATUS_EA_LIST_INCONSISTENT ((NTSTATUS)0x80000014L)")]
    public const int STATUS_EA_LIST_INCONSISTENT = unchecked((int)(0x80000014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_EA_FLAG"]/*' />
    [NativeTypeName("#define STATUS_INVALID_EA_FLAG ((NTSTATUS)0x80000015L)")]
    public const int STATUS_INVALID_EA_FLAG = unchecked((int)(0x80000015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VERIFY_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_VERIFY_REQUIRED ((NTSTATUS)0x80000016L)")]
    public const int STATUS_VERIFY_REQUIRED = unchecked((int)(0x80000016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EXTRANEOUS_INFORMATION"]/*' />
    [NativeTypeName("#define STATUS_EXTRANEOUS_INFORMATION ((NTSTATUS)0x80000017L)")]
    public const int STATUS_EXTRANEOUS_INFORMATION = unchecked((int)(0x80000017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RXACT_COMMIT_NECESSARY"]/*' />
    [NativeTypeName("#define STATUS_RXACT_COMMIT_NECESSARY ((NTSTATUS)0x80000018L)")]
    public const int STATUS_RXACT_COMMIT_NECESSARY = unchecked((int)(0x80000018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_MORE_ENTRIES"]/*' />
    [NativeTypeName("#define STATUS_NO_MORE_ENTRIES ((NTSTATUS)0x8000001AL)")]
    public const int STATUS_NO_MORE_ENTRIES = unchecked((int)(0x8000001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILEMARK_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_FILEMARK_DETECTED ((NTSTATUS)0x8000001BL)")]
    public const int STATUS_FILEMARK_DETECTED = unchecked((int)(0x8000001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEDIA_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_MEDIA_CHANGED ((NTSTATUS)0x8000001CL)")]
    public const int STATUS_MEDIA_CHANGED = unchecked((int)(0x8000001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BUS_RESET"]/*' />
    [NativeTypeName("#define STATUS_BUS_RESET ((NTSTATUS)0x8000001DL)")]
    public const int STATUS_BUS_RESET = unchecked((int)(0x8000001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_END_OF_MEDIA"]/*' />
    [NativeTypeName("#define STATUS_END_OF_MEDIA ((NTSTATUS)0x8000001EL)")]
    public const int STATUS_END_OF_MEDIA = unchecked((int)(0x8000001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BEGINNING_OF_MEDIA"]/*' />
    [NativeTypeName("#define STATUS_BEGINNING_OF_MEDIA ((NTSTATUS)0x8000001FL)")]
    public const int STATUS_BEGINNING_OF_MEDIA = unchecked((int)(0x8000001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEDIA_CHECK"]/*' />
    [NativeTypeName("#define STATUS_MEDIA_CHECK ((NTSTATUS)0x80000020L)")]
    public const int STATUS_MEDIA_CHECK = unchecked((int)(0x80000020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SETMARK_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_SETMARK_DETECTED ((NTSTATUS)0x80000021L)")]
    public const int STATUS_SETMARK_DETECTED = unchecked((int)(0x80000021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_DATA_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_NO_DATA_DETECTED ((NTSTATUS)0x80000022L)")]
    public const int STATUS_NO_DATA_DETECTED = unchecked((int)(0x80000022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REDIRECTOR_HAS_OPEN_HANDLES"]/*' />
    [NativeTypeName("#define STATUS_REDIRECTOR_HAS_OPEN_HANDLES ((NTSTATUS)0x80000023L)")]
    public const int STATUS_REDIRECTOR_HAS_OPEN_HANDLES = unchecked((int)(0x80000023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVER_HAS_OPEN_HANDLES"]/*' />
    [NativeTypeName("#define STATUS_SERVER_HAS_OPEN_HANDLES ((NTSTATUS)0x80000024L)")]
    public const int STATUS_SERVER_HAS_OPEN_HANDLES = unchecked((int)(0x80000024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALREADY_DISCONNECTED"]/*' />
    [NativeTypeName("#define STATUS_ALREADY_DISCONNECTED ((NTSTATUS)0x80000025L)")]
    public const int STATUS_ALREADY_DISCONNECTED = unchecked((int)(0x80000025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLEANER_CARTRIDGE_INSTALLED"]/*' />
    [NativeTypeName("#define STATUS_CLEANER_CARTRIDGE_INSTALLED ((NTSTATUS)0x80000027L)")]
    public const int STATUS_CLEANER_CARTRIDGE_INSTALLED = unchecked((int)(0x80000027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLUGPLAY_QUERY_VETOED"]/*' />
    [NativeTypeName("#define STATUS_PLUGPLAY_QUERY_VETOED ((NTSTATUS)0x80000028L)")]
    public const int STATUS_PLUGPLAY_QUERY_VETOED = unchecked((int)(0x80000028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REGISTRY_HIVE_RECOVERED"]/*' />
    [NativeTypeName("#define STATUS_REGISTRY_HIVE_RECOVERED ((NTSTATUS)0x8000002AL)")]
    public const int STATUS_REGISTRY_HIVE_RECOVERED = unchecked((int)(0x8000002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DLL_MIGHT_BE_INSECURE"]/*' />
    [NativeTypeName("#define STATUS_DLL_MIGHT_BE_INSECURE ((NTSTATUS)0x8000002BL)")]
    public const int STATUS_DLL_MIGHT_BE_INSECURE = unchecked((int)(0x8000002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DLL_MIGHT_BE_INCOMPATIBLE"]/*' />
    [NativeTypeName("#define STATUS_DLL_MIGHT_BE_INCOMPATIBLE ((NTSTATUS)0x8000002CL)")]
    public const int STATUS_DLL_MIGHT_BE_INCOMPATIBLE = unchecked((int)(0x8000002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STOPPED_ON_SYMLINK"]/*' />
    [NativeTypeName("#define STATUS_STOPPED_ON_SYMLINK ((NTSTATUS)0x8000002DL)")]
    public const int STATUS_STOPPED_ON_SYMLINK = unchecked((int)(0x8000002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_GRANT_REQUESTED_OPLOCK"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_GRANT_REQUESTED_OPLOCK ((NTSTATUS)0x8000002EL)")]
    public const int STATUS_CANNOT_GRANT_REQUESTED_OPLOCK = unchecked((int)(0x8000002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_ACE_CONDITION"]/*' />
    [NativeTypeName("#define STATUS_NO_ACE_CONDITION ((NTSTATUS)0x8000002FL)")]
    public const int STATUS_NO_ACE_CONDITION = unchecked((int)(0x8000002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_SUPPORT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_SUPPORT_IN_PROGRESS ((NTSTATUS)0x80000030L)")]
    public const int STATUS_DEVICE_SUPPORT_IN_PROGRESS = unchecked((int)(0x80000030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_POWER_CYCLE_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_POWER_CYCLE_REQUIRED ((NTSTATUS)0x80000031L)")]
    public const int STATUS_DEVICE_POWER_CYCLE_REQUIRED = unchecked((int)(0x80000031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_WORK_DONE"]/*' />
    [NativeTypeName("#define STATUS_NO_WORK_DONE ((NTSTATUS)0x80000032L)")]
    public const int STATUS_NO_WORK_DONE = unchecked((int)(0x80000032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RETURN_ADDRESS_HIJACK_ATTEMPT"]/*' />
    [NativeTypeName("#define STATUS_RETURN_ADDRESS_HIJACK_ATTEMPT ((NTSTATUS)0x80000033L)")]
    public const int STATUS_RETURN_ADDRESS_HIJACK_ATTEMPT = unchecked((int)(0x80000033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RECOVERABLE_BUGCHECK"]/*' />
    [NativeTypeName("#define STATUS_RECOVERABLE_BUGCHECK ((NTSTATUS)0x80000034L)")]
    public const int STATUS_RECOVERABLE_BUGCHECK = unchecked((int)(0x80000034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PTE_CHANGE_NOT_COMPLETED"]/*' />
    [NativeTypeName("#define STATUS_PTE_CHANGE_NOT_COMPLETED ((NTSTATUS)0x80000035L)")]
    public const int STATUS_PTE_CHANGE_NOT_COMPLETED = unchecked((int)(0x80000035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FAILED_SUBMITTED_DEVICE_COMMAND"]/*' />
    [NativeTypeName("#define STATUS_FAILED_SUBMITTED_DEVICE_COMMAND ((NTSTATUS)0x80000036L)")]
    public const int STATUS_FAILED_SUBMITTED_DEVICE_COMMAND = unchecked((int)(0x80000036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_ALREADY_UP"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_ALREADY_UP ((NTSTATUS)0x80130001L)")]
    public const int STATUS_CLUSTER_NODE_ALREADY_UP = unchecked((int)(0x80130001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_ALREADY_DOWN"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_ALREADY_DOWN ((NTSTATUS)0x80130002L)")]
    public const int STATUS_CLUSTER_NODE_ALREADY_DOWN = unchecked((int)(0x80130002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NETWORK_ALREADY_ONLINE"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NETWORK_ALREADY_ONLINE ((NTSTATUS)0x80130003L)")]
    public const int STATUS_CLUSTER_NETWORK_ALREADY_ONLINE = unchecked((int)(0x80130003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NETWORK_ALREADY_OFFLINE"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NETWORK_ALREADY_OFFLINE ((NTSTATUS)0x80130004L)")]
    public const int STATUS_CLUSTER_NETWORK_ALREADY_OFFLINE = unchecked((int)(0x80130004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_ALREADY_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_ALREADY_MEMBER ((NTSTATUS)0x80130005L)")]
    public const int STATUS_CLUSTER_NODE_ALREADY_MEMBER = unchecked((int)(0x80130005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_FLT_BUFFER_TOO_SMALL ((NTSTATUS)0x801C0001L)")]
    public const int STATUS_FLT_BUFFER_TOO_SMALL = unchecked((int)(0x801C0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_LINK_CONFIGURATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_LINK_CONFIGURATION_IN_PROGRESS ((NTSTATUS)0x801E0000L)")]
    public const int STATUS_GRAPHICS_LINK_CONFIGURATION_IN_PROGRESS = unchecked((int)(0x801E0000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_PARTIAL_METADATA"]/*' />
    [NativeTypeName("#define STATUS_FVE_PARTIAL_METADATA ((NTSTATUS)0x80210001L)")]
    public const int STATUS_FVE_PARTIAL_METADATA = unchecked((int)(0x80210001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TRANSIENT_STATE"]/*' />
    [NativeTypeName("#define STATUS_FVE_TRANSIENT_STATE ((NTSTATUS)0x80210002L)")]
    public const int STATUS_FVE_TRANSIENT_STATE = unchecked((int)(0x80210002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH ((NTSTATUS)0x8000CF00L)")]
    public const int STATUS_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH = unchecked((int)(0x8000CF00));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNSUCCESSFUL"]/*' />
    [NativeTypeName("#define STATUS_UNSUCCESSFUL ((NTSTATUS)0xC0000001L)")]
    public const int STATUS_UNSUCCESSFUL = unchecked((int)(0xC0000001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_IMPLEMENTED"]/*' />
    [NativeTypeName("#define STATUS_NOT_IMPLEMENTED ((NTSTATUS)0xC0000002L)")]
    public const int STATUS_NOT_IMPLEMENTED = unchecked((int)(0xC0000002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_INFO_CLASS"]/*' />
    [NativeTypeName("#define STATUS_INVALID_INFO_CLASS ((NTSTATUS)0xC0000003L)")]
    public const int STATUS_INVALID_INFO_CLASS = unchecked((int)(0xC0000003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INFO_LENGTH_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_INFO_LENGTH_MISMATCH ((NTSTATUS)0xC0000004L)")]
    public const int STATUS_INFO_LENGTH_MISMATCH = unchecked((int)(0xC0000004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGEFILE_QUOTA"]/*' />
    [NativeTypeName("#define STATUS_PAGEFILE_QUOTA ((NTSTATUS)0xC0000007L)")]
    public const int STATUS_PAGEFILE_QUOTA = unchecked((int)(0xC0000007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_INITIAL_STACK"]/*' />
    [NativeTypeName("#define STATUS_BAD_INITIAL_STACK ((NTSTATUS)0xC0000009L)")]
    public const int STATUS_BAD_INITIAL_STACK = unchecked((int)(0xC0000009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_INITIAL_PC"]/*' />
    [NativeTypeName("#define STATUS_BAD_INITIAL_PC ((NTSTATUS)0xC000000AL)")]
    public const int STATUS_BAD_INITIAL_PC = unchecked((int)(0xC000000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_CID"]/*' />
    [NativeTypeName("#define STATUS_INVALID_CID ((NTSTATUS)0xC000000BL)")]
    public const int STATUS_INVALID_CID = unchecked((int)(0xC000000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TIMER_NOT_CANCELED"]/*' />
    [NativeTypeName("#define STATUS_TIMER_NOT_CANCELED ((NTSTATUS)0xC000000CL)")]
    public const int STATUS_TIMER_NOT_CANCELED = unchecked((int)(0xC000000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_DEVICE ((NTSTATUS)0xC000000EL)")]
    public const int STATUS_NO_SUCH_DEVICE = unchecked((int)(0xC000000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_FILE"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_FILE ((NTSTATUS)0xC000000FL)")]
    public const int STATUS_NO_SUCH_FILE = unchecked((int)(0xC000000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_DEVICE_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_INVALID_DEVICE_REQUEST ((NTSTATUS)0xC0000010L)")]
    public const int STATUS_INVALID_DEVICE_REQUEST = unchecked((int)(0xC0000010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_END_OF_FILE"]/*' />
    [NativeTypeName("#define STATUS_END_OF_FILE ((NTSTATUS)0xC0000011L)")]
    public const int STATUS_END_OF_FILE = unchecked((int)(0xC0000011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WRONG_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_WRONG_VOLUME ((NTSTATUS)0xC0000012L)")]
    public const int STATUS_WRONG_VOLUME = unchecked((int)(0xC0000012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_MEDIA_IN_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_NO_MEDIA_IN_DEVICE ((NTSTATUS)0xC0000013L)")]
    public const int STATUS_NO_MEDIA_IN_DEVICE = unchecked((int)(0xC0000013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNRECOGNIZED_MEDIA"]/*' />
    [NativeTypeName("#define STATUS_UNRECOGNIZED_MEDIA ((NTSTATUS)0xC0000014L)")]
    public const int STATUS_UNRECOGNIZED_MEDIA = unchecked((int)(0xC0000014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NONEXISTENT_SECTOR"]/*' />
    [NativeTypeName("#define STATUS_NONEXISTENT_SECTOR ((NTSTATUS)0xC0000015L)")]
    public const int STATUS_NONEXISTENT_SECTOR = unchecked((int)(0xC0000015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MORE_PROCESSING_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_MORE_PROCESSING_REQUIRED ((NTSTATUS)0xC0000016L)")]
    public const int STATUS_MORE_PROCESSING_REQUIRED = unchecked((int)(0xC0000016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONFLICTING_ADDRESSES"]/*' />
    [NativeTypeName("#define STATUS_CONFLICTING_ADDRESSES ((NTSTATUS)0xC0000018L)")]
    public const int STATUS_CONFLICTING_ADDRESSES = unchecked((int)(0xC0000018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_MAPPED_VIEW"]/*' />
    [NativeTypeName("#define STATUS_NOT_MAPPED_VIEW ((NTSTATUS)0xC0000019L)")]
    public const int STATUS_NOT_MAPPED_VIEW = unchecked((int)(0xC0000019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNABLE_TO_FREE_VM"]/*' />
    [NativeTypeName("#define STATUS_UNABLE_TO_FREE_VM ((NTSTATUS)0xC000001AL)")]
    public const int STATUS_UNABLE_TO_FREE_VM = unchecked((int)(0xC000001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNABLE_TO_DELETE_SECTION"]/*' />
    [NativeTypeName("#define STATUS_UNABLE_TO_DELETE_SECTION ((NTSTATUS)0xC000001BL)")]
    public const int STATUS_UNABLE_TO_DELETE_SECTION = unchecked((int)(0xC000001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_SYSTEM_SERVICE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_SYSTEM_SERVICE ((NTSTATUS)0xC000001CL)")]
    public const int STATUS_INVALID_SYSTEM_SERVICE = unchecked((int)(0xC000001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LOCK_SEQUENCE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LOCK_SEQUENCE ((NTSTATUS)0xC000001EL)")]
    public const int STATUS_INVALID_LOCK_SEQUENCE = unchecked((int)(0xC000001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_VIEW_SIZE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_VIEW_SIZE ((NTSTATUS)0xC000001FL)")]
    public const int STATUS_INVALID_VIEW_SIZE = unchecked((int)(0xC000001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_FILE_FOR_SECTION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_FILE_FOR_SECTION ((NTSTATUS)0xC0000020L)")]
    public const int STATUS_INVALID_FILE_FOR_SECTION = unchecked((int)(0xC0000020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALREADY_COMMITTED"]/*' />
    [NativeTypeName("#define STATUS_ALREADY_COMMITTED ((NTSTATUS)0xC0000021L)")]
    public const int STATUS_ALREADY_COMMITTED = unchecked((int)(0xC0000021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_ACCESS_DENIED ((NTSTATUS)0xC0000022L)")]
    public const int STATUS_ACCESS_DENIED = unchecked((int)(0xC0000022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_BUFFER_TOO_SMALL ((NTSTATUS)0xC0000023L)")]
    public const int STATUS_BUFFER_TOO_SMALL = unchecked((int)(0xC0000023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_TYPE_MISMATCH ((NTSTATUS)0xC0000024L)")]
    public const int STATUS_OBJECT_TYPE_MISMATCH = unchecked((int)(0xC0000024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNWIND"]/*' />
    [NativeTypeName("#define STATUS_UNWIND ((NTSTATUS)0xC0000027L)")]
    public const int STATUS_UNWIND = unchecked((int)(0xC0000027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_STACK"]/*' />
    [NativeTypeName("#define STATUS_BAD_STACK ((NTSTATUS)0xC0000028L)")]
    public const int STATUS_BAD_STACK = unchecked((int)(0xC0000028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_UNWIND_TARGET"]/*' />
    [NativeTypeName("#define STATUS_INVALID_UNWIND_TARGET ((NTSTATUS)0xC0000029L)")]
    public const int STATUS_INVALID_UNWIND_TARGET = unchecked((int)(0xC0000029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_NOT_LOCKED ((NTSTATUS)0xC000002AL)")]
    public const int STATUS_NOT_LOCKED = unchecked((int)(0xC000002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PARITY_ERROR"]/*' />
    [NativeTypeName("#define STATUS_PARITY_ERROR ((NTSTATUS)0xC000002BL)")]
    public const int STATUS_PARITY_ERROR = unchecked((int)(0xC000002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNABLE_TO_DECOMMIT_VM"]/*' />
    [NativeTypeName("#define STATUS_UNABLE_TO_DECOMMIT_VM ((NTSTATUS)0xC000002CL)")]
    public const int STATUS_UNABLE_TO_DECOMMIT_VM = unchecked((int)(0xC000002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_COMMITTED"]/*' />
    [NativeTypeName("#define STATUS_NOT_COMMITTED ((NTSTATUS)0xC000002DL)")]
    public const int STATUS_NOT_COMMITTED = unchecked((int)(0xC000002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PORT_ATTRIBUTES"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PORT_ATTRIBUTES ((NTSTATUS)0xC000002EL)")]
    public const int STATUS_INVALID_PORT_ATTRIBUTES = unchecked((int)(0xC000002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_MESSAGE_TOO_LONG"]/*' />
    [NativeTypeName("#define STATUS_PORT_MESSAGE_TOO_LONG ((NTSTATUS)0xC000002FL)")]
    public const int STATUS_PORT_MESSAGE_TOO_LONG = unchecked((int)(0xC000002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_MIX"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_MIX ((NTSTATUS)0xC0000030L)")]
    public const int STATUS_INVALID_PARAMETER_MIX = unchecked((int)(0xC0000030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_QUOTA_LOWER"]/*' />
    [NativeTypeName("#define STATUS_INVALID_QUOTA_LOWER ((NTSTATUS)0xC0000031L)")]
    public const int STATUS_INVALID_QUOTA_LOWER = unchecked((int)(0xC0000031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_CORRUPT_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DISK_CORRUPT_ERROR ((NTSTATUS)0xC0000032L)")]
    public const int STATUS_DISK_CORRUPT_ERROR = unchecked((int)(0xC0000032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_NAME_INVALID"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_NAME_INVALID ((NTSTATUS)0xC0000033L)")]
    public const int STATUS_OBJECT_NAME_INVALID = unchecked((int)(0xC0000033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_NAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_NAME_NOT_FOUND ((NTSTATUS)0xC0000034L)")]
    public const int STATUS_OBJECT_NAME_NOT_FOUND = unchecked((int)(0xC0000034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_NAME_COLLISION"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_NAME_COLLISION ((NTSTATUS)0xC0000035L)")]
    public const int STATUS_OBJECT_NAME_COLLISION = unchecked((int)(0xC0000035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_DO_NOT_DISTURB"]/*' />
    [NativeTypeName("#define STATUS_PORT_DO_NOT_DISTURB ((NTSTATUS)0xC0000036L)")]
    public const int STATUS_PORT_DO_NOT_DISTURB = unchecked((int)(0xC0000036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_DISCONNECTED"]/*' />
    [NativeTypeName("#define STATUS_PORT_DISCONNECTED ((NTSTATUS)0xC0000037L)")]
    public const int STATUS_PORT_DISCONNECTED = unchecked((int)(0xC0000037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_ALREADY_ATTACHED"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_ALREADY_ATTACHED ((NTSTATUS)0xC0000038L)")]
    public const int STATUS_DEVICE_ALREADY_ATTACHED = unchecked((int)(0xC0000038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_PATH_INVALID"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_PATH_INVALID ((NTSTATUS)0xC0000039L)")]
    public const int STATUS_OBJECT_PATH_INVALID = unchecked((int)(0xC0000039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_PATH_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_PATH_NOT_FOUND ((NTSTATUS)0xC000003AL)")]
    public const int STATUS_OBJECT_PATH_NOT_FOUND = unchecked((int)(0xC000003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_PATH_SYNTAX_BAD"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_PATH_SYNTAX_BAD ((NTSTATUS)0xC000003BL)")]
    public const int STATUS_OBJECT_PATH_SYNTAX_BAD = unchecked((int)(0xC000003B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATA_OVERRUN"]/*' />
    [NativeTypeName("#define STATUS_DATA_OVERRUN ((NTSTATUS)0xC000003CL)")]
    public const int STATUS_DATA_OVERRUN = unchecked((int)(0xC000003C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATA_LATE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DATA_LATE_ERROR ((NTSTATUS)0xC000003DL)")]
    public const int STATUS_DATA_LATE_ERROR = unchecked((int)(0xC000003D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATA_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DATA_ERROR ((NTSTATUS)0xC000003EL)")]
    public const int STATUS_DATA_ERROR = unchecked((int)(0xC000003E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CRC_ERROR"]/*' />
    [NativeTypeName("#define STATUS_CRC_ERROR ((NTSTATUS)0xC000003FL)")]
    public const int STATUS_CRC_ERROR = unchecked((int)(0xC000003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECTION_TOO_BIG"]/*' />
    [NativeTypeName("#define STATUS_SECTION_TOO_BIG ((NTSTATUS)0xC0000040L)")]
    public const int STATUS_SECTION_TOO_BIG = unchecked((int)(0xC0000040));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_CONNECTION_REFUSED"]/*' />
    [NativeTypeName("#define STATUS_PORT_CONNECTION_REFUSED ((NTSTATUS)0xC0000041L)")]
    public const int STATUS_PORT_CONNECTION_REFUSED = unchecked((int)(0xC0000041));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PORT_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PORT_HANDLE ((NTSTATUS)0xC0000042L)")]
    public const int STATUS_INVALID_PORT_HANDLE = unchecked((int)(0xC0000042));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SHARING_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_SHARING_VIOLATION ((NTSTATUS)0xC0000043L)")]
    public const int STATUS_SHARING_VIOLATION = unchecked((int)(0xC0000043));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_QUOTA_EXCEEDED ((NTSTATUS)0xC0000044L)")]
    public const int STATUS_QUOTA_EXCEEDED = unchecked((int)(0xC0000044));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PAGE_PROTECTION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PAGE_PROTECTION ((NTSTATUS)0xC0000045L)")]
    public const int STATUS_INVALID_PAGE_PROTECTION = unchecked((int)(0xC0000045));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUTANT_NOT_OWNED"]/*' />
    [NativeTypeName("#define STATUS_MUTANT_NOT_OWNED ((NTSTATUS)0xC0000046L)")]
    public const int STATUS_MUTANT_NOT_OWNED = unchecked((int)(0xC0000046));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SEMAPHORE_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_SEMAPHORE_LIMIT_EXCEEDED ((NTSTATUS)0xC0000047L)")]
    public const int STATUS_SEMAPHORE_LIMIT_EXCEEDED = unchecked((int)(0xC0000047));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_ALREADY_SET"]/*' />
    [NativeTypeName("#define STATUS_PORT_ALREADY_SET ((NTSTATUS)0xC0000048L)")]
    public const int STATUS_PORT_ALREADY_SET = unchecked((int)(0xC0000048));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECTION_NOT_IMAGE"]/*' />
    [NativeTypeName("#define STATUS_SECTION_NOT_IMAGE ((NTSTATUS)0xC0000049L)")]
    public const int STATUS_SECTION_NOT_IMAGE = unchecked((int)(0xC0000049));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SUSPEND_COUNT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_SUSPEND_COUNT_EXCEEDED ((NTSTATUS)0xC000004AL)")]
    public const int STATUS_SUSPEND_COUNT_EXCEEDED = unchecked((int)(0xC000004A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREAD_IS_TERMINATING"]/*' />
    [NativeTypeName("#define STATUS_THREAD_IS_TERMINATING ((NTSTATUS)0xC000004BL)")]
    public const int STATUS_THREAD_IS_TERMINATING = unchecked((int)(0xC000004B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_WORKING_SET_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_BAD_WORKING_SET_LIMIT ((NTSTATUS)0xC000004CL)")]
    public const int STATUS_BAD_WORKING_SET_LIMIT = unchecked((int)(0xC000004C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INCOMPATIBLE_FILE_MAP"]/*' />
    [NativeTypeName("#define STATUS_INCOMPATIBLE_FILE_MAP ((NTSTATUS)0xC000004DL)")]
    public const int STATUS_INCOMPATIBLE_FILE_MAP = unchecked((int)(0xC000004D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECTION_PROTECTION"]/*' />
    [NativeTypeName("#define STATUS_SECTION_PROTECTION ((NTSTATUS)0xC000004EL)")]
    public const int STATUS_SECTION_PROTECTION = unchecked((int)(0xC000004E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EAS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_EAS_NOT_SUPPORTED ((NTSTATUS)0xC000004FL)")]
    public const int STATUS_EAS_NOT_SUPPORTED = unchecked((int)(0xC000004F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EA_TOO_LARGE"]/*' />
    [NativeTypeName("#define STATUS_EA_TOO_LARGE ((NTSTATUS)0xC0000050L)")]
    public const int STATUS_EA_TOO_LARGE = unchecked((int)(0xC0000050));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NONEXISTENT_EA_ENTRY"]/*' />
    [NativeTypeName("#define STATUS_NONEXISTENT_EA_ENTRY ((NTSTATUS)0xC0000051L)")]
    public const int STATUS_NONEXISTENT_EA_ENTRY = unchecked((int)(0xC0000051));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_EAS_ON_FILE"]/*' />
    [NativeTypeName("#define STATUS_NO_EAS_ON_FILE ((NTSTATUS)0xC0000052L)")]
    public const int STATUS_NO_EAS_ON_FILE = unchecked((int)(0xC0000052));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EA_CORRUPT_ERROR"]/*' />
    [NativeTypeName("#define STATUS_EA_CORRUPT_ERROR ((NTSTATUS)0xC0000053L)")]
    public const int STATUS_EA_CORRUPT_ERROR = unchecked((int)(0xC0000053));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_LOCK_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_FILE_LOCK_CONFLICT ((NTSTATUS)0xC0000054L)")]
    public const int STATUS_FILE_LOCK_CONFLICT = unchecked((int)(0xC0000054));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOCK_NOT_GRANTED"]/*' />
    [NativeTypeName("#define STATUS_LOCK_NOT_GRANTED ((NTSTATUS)0xC0000055L)")]
    public const int STATUS_LOCK_NOT_GRANTED = unchecked((int)(0xC0000055));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DELETE_PENDING"]/*' />
    [NativeTypeName("#define STATUS_DELETE_PENDING ((NTSTATUS)0xC0000056L)")]
    public const int STATUS_DELETE_PENDING = unchecked((int)(0xC0000056));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTL_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_CTL_FILE_NOT_SUPPORTED ((NTSTATUS)0xC0000057L)")]
    public const int STATUS_CTL_FILE_NOT_SUPPORTED = unchecked((int)(0xC0000057));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNKNOWN_REVISION"]/*' />
    [NativeTypeName("#define STATUS_UNKNOWN_REVISION ((NTSTATUS)0xC0000058L)")]
    public const int STATUS_UNKNOWN_REVISION = unchecked((int)(0xC0000058));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REVISION_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_REVISION_MISMATCH ((NTSTATUS)0xC0000059L)")]
    public const int STATUS_REVISION_MISMATCH = unchecked((int)(0xC0000059));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_OWNER"]/*' />
    [NativeTypeName("#define STATUS_INVALID_OWNER ((NTSTATUS)0xC000005AL)")]
    public const int STATUS_INVALID_OWNER = unchecked((int)(0xC000005A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PRIMARY_GROUP"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PRIMARY_GROUP ((NTSTATUS)0xC000005BL)")]
    public const int STATUS_INVALID_PRIMARY_GROUP = unchecked((int)(0xC000005B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_IMPERSONATION_TOKEN"]/*' />
    [NativeTypeName("#define STATUS_NO_IMPERSONATION_TOKEN ((NTSTATUS)0xC000005CL)")]
    public const int STATUS_NO_IMPERSONATION_TOKEN = unchecked((int)(0xC000005C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_DISABLE_MANDATORY"]/*' />
    [NativeTypeName("#define STATUS_CANT_DISABLE_MANDATORY ((NTSTATUS)0xC000005DL)")]
    public const int STATUS_CANT_DISABLE_MANDATORY = unchecked((int)(0xC000005D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_LOGON_SERVERS"]/*' />
    [NativeTypeName("#define STATUS_NO_LOGON_SERVERS ((NTSTATUS)0xC000005EL)")]
    public const int STATUS_NO_LOGON_SERVERS = unchecked((int)(0xC000005E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_LOGON_SESSION"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_LOGON_SESSION ((NTSTATUS)0xC000005FL)")]
    public const int STATUS_NO_SUCH_LOGON_SESSION = unchecked((int)(0xC000005F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_PRIVILEGE"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_PRIVILEGE ((NTSTATUS)0xC0000060L)")]
    public const int STATUS_NO_SUCH_PRIVILEGE = unchecked((int)(0xC0000060));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRIVILEGE_NOT_HELD"]/*' />
    [NativeTypeName("#define STATUS_PRIVILEGE_NOT_HELD ((NTSTATUS)0xC0000061L)")]
    public const int STATUS_PRIVILEGE_NOT_HELD = unchecked((int)(0xC0000061));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_ACCOUNT_NAME"]/*' />
    [NativeTypeName("#define STATUS_INVALID_ACCOUNT_NAME ((NTSTATUS)0xC0000062L)")]
    public const int STATUS_INVALID_ACCOUNT_NAME = unchecked((int)(0xC0000062));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_USER_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_USER_EXISTS ((NTSTATUS)0xC0000063L)")]
    public const int STATUS_USER_EXISTS = unchecked((int)(0xC0000063));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_USER"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_USER ((NTSTATUS)0xC0000064L)")]
    public const int STATUS_NO_SUCH_USER = unchecked((int)(0xC0000064));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GROUP_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_GROUP_EXISTS ((NTSTATUS)0xC0000065L)")]
    public const int STATUS_GROUP_EXISTS = unchecked((int)(0xC0000065));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_GROUP"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_GROUP ((NTSTATUS)0xC0000066L)")]
    public const int STATUS_NO_SUCH_GROUP = unchecked((int)(0xC0000066));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEMBER_IN_GROUP"]/*' />
    [NativeTypeName("#define STATUS_MEMBER_IN_GROUP ((NTSTATUS)0xC0000067L)")]
    public const int STATUS_MEMBER_IN_GROUP = unchecked((int)(0xC0000067));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEMBER_NOT_IN_GROUP"]/*' />
    [NativeTypeName("#define STATUS_MEMBER_NOT_IN_GROUP ((NTSTATUS)0xC0000068L)")]
    public const int STATUS_MEMBER_NOT_IN_GROUP = unchecked((int)(0xC0000068));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LAST_ADMIN"]/*' />
    [NativeTypeName("#define STATUS_LAST_ADMIN ((NTSTATUS)0xC0000069L)")]
    public const int STATUS_LAST_ADMIN = unchecked((int)(0xC0000069));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WRONG_PASSWORD"]/*' />
    [NativeTypeName("#define STATUS_WRONG_PASSWORD ((NTSTATUS)0xC000006AL)")]
    public const int STATUS_WRONG_PASSWORD = unchecked((int)(0xC000006A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ILL_FORMED_PASSWORD"]/*' />
    [NativeTypeName("#define STATUS_ILL_FORMED_PASSWORD ((NTSTATUS)0xC000006BL)")]
    public const int STATUS_ILL_FORMED_PASSWORD = unchecked((int)(0xC000006B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PASSWORD_RESTRICTION"]/*' />
    [NativeTypeName("#define STATUS_PASSWORD_RESTRICTION ((NTSTATUS)0xC000006CL)")]
    public const int STATUS_PASSWORD_RESTRICTION = unchecked((int)(0xC000006C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOGON_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_LOGON_FAILURE ((NTSTATUS)0xC000006DL)")]
    public const int STATUS_LOGON_FAILURE = unchecked((int)(0xC000006D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCOUNT_RESTRICTION"]/*' />
    [NativeTypeName("#define STATUS_ACCOUNT_RESTRICTION ((NTSTATUS)0xC000006EL)")]
    public const int STATUS_ACCOUNT_RESTRICTION = unchecked((int)(0xC000006E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LOGON_HOURS"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LOGON_HOURS ((NTSTATUS)0xC000006FL)")]
    public const int STATUS_INVALID_LOGON_HOURS = unchecked((int)(0xC000006F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_WORKSTATION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_WORKSTATION ((NTSTATUS)0xC0000070L)")]
    public const int STATUS_INVALID_WORKSTATION = unchecked((int)(0xC0000070));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PASSWORD_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_PASSWORD_EXPIRED ((NTSTATUS)0xC0000071L)")]
    public const int STATUS_PASSWORD_EXPIRED = unchecked((int)(0xC0000071));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCOUNT_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_ACCOUNT_DISABLED ((NTSTATUS)0xC0000072L)")]
    public const int STATUS_ACCOUNT_DISABLED = unchecked((int)(0xC0000072));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NONE_MAPPED"]/*' />
    [NativeTypeName("#define STATUS_NONE_MAPPED ((NTSTATUS)0xC0000073L)")]
    public const int STATUS_NONE_MAPPED = unchecked((int)(0xC0000073));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_LUIDS_REQUESTED"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_LUIDS_REQUESTED ((NTSTATUS)0xC0000074L)")]
    public const int STATUS_TOO_MANY_LUIDS_REQUESTED = unchecked((int)(0xC0000074));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LUIDS_EXHAUSTED"]/*' />
    [NativeTypeName("#define STATUS_LUIDS_EXHAUSTED ((NTSTATUS)0xC0000075L)")]
    public const int STATUS_LUIDS_EXHAUSTED = unchecked((int)(0xC0000075));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_SUB_AUTHORITY"]/*' />
    [NativeTypeName("#define STATUS_INVALID_SUB_AUTHORITY ((NTSTATUS)0xC0000076L)")]
    public const int STATUS_INVALID_SUB_AUTHORITY = unchecked((int)(0xC0000076));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_ACL"]/*' />
    [NativeTypeName("#define STATUS_INVALID_ACL ((NTSTATUS)0xC0000077L)")]
    public const int STATUS_INVALID_ACL = unchecked((int)(0xC0000077));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_SID"]/*' />
    [NativeTypeName("#define STATUS_INVALID_SID ((NTSTATUS)0xC0000078L)")]
    public const int STATUS_INVALID_SID = unchecked((int)(0xC0000078));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_SECURITY_DESCR"]/*' />
    [NativeTypeName("#define STATUS_INVALID_SECURITY_DESCR ((NTSTATUS)0xC0000079L)")]
    public const int STATUS_INVALID_SECURITY_DESCR = unchecked((int)(0xC0000079));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROCEDURE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PROCEDURE_NOT_FOUND ((NTSTATUS)0xC000007AL)")]
    public const int STATUS_PROCEDURE_NOT_FOUND = unchecked((int)(0xC000007A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_FORMAT ((NTSTATUS)0xC000007BL)")]
    public const int STATUS_INVALID_IMAGE_FORMAT = unchecked((int)(0xC000007B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_TOKEN"]/*' />
    [NativeTypeName("#define STATUS_NO_TOKEN ((NTSTATUS)0xC000007CL)")]
    public const int STATUS_NO_TOKEN = unchecked((int)(0xC000007C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_INHERITANCE_ACL"]/*' />
    [NativeTypeName("#define STATUS_BAD_INHERITANCE_ACL ((NTSTATUS)0xC000007DL)")]
    public const int STATUS_BAD_INHERITANCE_ACL = unchecked((int)(0xC000007D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RANGE_NOT_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_RANGE_NOT_LOCKED ((NTSTATUS)0xC000007EL)")]
    public const int STATUS_RANGE_NOT_LOCKED = unchecked((int)(0xC000007E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_FULL"]/*' />
    [NativeTypeName("#define STATUS_DISK_FULL ((NTSTATUS)0xC000007FL)")]
    public const int STATUS_DISK_FULL = unchecked((int)(0xC000007F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVER_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_SERVER_DISABLED ((NTSTATUS)0xC0000080L)")]
    public const int STATUS_SERVER_DISABLED = unchecked((int)(0xC0000080));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVER_NOT_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_SERVER_NOT_DISABLED ((NTSTATUS)0xC0000081L)")]
    public const int STATUS_SERVER_NOT_DISABLED = unchecked((int)(0xC0000081));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_GUIDS_REQUESTED"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_GUIDS_REQUESTED ((NTSTATUS)0xC0000082L)")]
    public const int STATUS_TOO_MANY_GUIDS_REQUESTED = unchecked((int)(0xC0000082));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GUIDS_EXHAUSTED"]/*' />
    [NativeTypeName("#define STATUS_GUIDS_EXHAUSTED ((NTSTATUS)0xC0000083L)")]
    public const int STATUS_GUIDS_EXHAUSTED = unchecked((int)(0xC0000083));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_ID_AUTHORITY"]/*' />
    [NativeTypeName("#define STATUS_INVALID_ID_AUTHORITY ((NTSTATUS)0xC0000084L)")]
    public const int STATUS_INVALID_ID_AUTHORITY = unchecked((int)(0xC0000084));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AGENTS_EXHAUSTED"]/*' />
    [NativeTypeName("#define STATUS_AGENTS_EXHAUSTED ((NTSTATUS)0xC0000085L)")]
    public const int STATUS_AGENTS_EXHAUSTED = unchecked((int)(0xC0000085));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_VOLUME_LABEL"]/*' />
    [NativeTypeName("#define STATUS_INVALID_VOLUME_LABEL ((NTSTATUS)0xC0000086L)")]
    public const int STATUS_INVALID_VOLUME_LABEL = unchecked((int)(0xC0000086));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECTION_NOT_EXTENDED"]/*' />
    [NativeTypeName("#define STATUS_SECTION_NOT_EXTENDED ((NTSTATUS)0xC0000087L)")]
    public const int STATUS_SECTION_NOT_EXTENDED = unchecked((int)(0xC0000087));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_MAPPED_DATA"]/*' />
    [NativeTypeName("#define STATUS_NOT_MAPPED_DATA ((NTSTATUS)0xC0000088L)")]
    public const int STATUS_NOT_MAPPED_DATA = unchecked((int)(0xC0000088));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCE_DATA_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_RESOURCE_DATA_NOT_FOUND ((NTSTATUS)0xC0000089L)")]
    public const int STATUS_RESOURCE_DATA_NOT_FOUND = unchecked((int)(0xC0000089));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCE_TYPE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_RESOURCE_TYPE_NOT_FOUND ((NTSTATUS)0xC000008AL)")]
    public const int STATUS_RESOURCE_TYPE_NOT_FOUND = unchecked((int)(0xC000008A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCE_NAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_RESOURCE_NAME_NOT_FOUND ((NTSTATUS)0xC000008BL)")]
    public const int STATUS_RESOURCE_NAME_NOT_FOUND = unchecked((int)(0xC000008B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_PAGING_FILES"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_PAGING_FILES ((NTSTATUS)0xC0000097L)")]
    public const int STATUS_TOO_MANY_PAGING_FILES = unchecked((int)(0xC0000097));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_FILE_INVALID ((NTSTATUS)0xC0000098L)")]
    public const int STATUS_FILE_INVALID = unchecked((int)(0xC0000098));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALLOTTED_SPACE_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_ALLOTTED_SPACE_EXCEEDED ((NTSTATUS)0xC0000099L)")]
    public const int STATUS_ALLOTTED_SPACE_EXCEEDED = unchecked((int)(0xC0000099));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSUFFICIENT_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_INSUFFICIENT_RESOURCES ((NTSTATUS)0xC000009AL)")]
    public const int STATUS_INSUFFICIENT_RESOURCES = unchecked((int)(0xC000009A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DFS_EXIT_PATH_FOUND"]/*' />
    [NativeTypeName("#define STATUS_DFS_EXIT_PATH_FOUND ((NTSTATUS)0xC000009BL)")]
    public const int STATUS_DFS_EXIT_PATH_FOUND = unchecked((int)(0xC000009B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_DATA_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_DATA_ERROR ((NTSTATUS)0xC000009CL)")]
    public const int STATUS_DEVICE_DATA_ERROR = unchecked((int)(0xC000009C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_NOT_CONNECTED ((NTSTATUS)0xC000009DL)")]
    public const int STATUS_DEVICE_NOT_CONNECTED = unchecked((int)(0xC000009D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_POWER_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_POWER_FAILURE ((NTSTATUS)0xC000009EL)")]
    public const int STATUS_DEVICE_POWER_FAILURE = unchecked((int)(0xC000009E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FREE_VM_NOT_AT_BASE"]/*' />
    [NativeTypeName("#define STATUS_FREE_VM_NOT_AT_BASE ((NTSTATUS)0xC000009FL)")]
    public const int STATUS_FREE_VM_NOT_AT_BASE = unchecked((int)(0xC000009F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEMORY_NOT_ALLOCATED"]/*' />
    [NativeTypeName("#define STATUS_MEMORY_NOT_ALLOCATED ((NTSTATUS)0xC00000A0L)")]
    public const int STATUS_MEMORY_NOT_ALLOCATED = unchecked((int)(0xC00000A0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WORKING_SET_QUOTA"]/*' />
    [NativeTypeName("#define STATUS_WORKING_SET_QUOTA ((NTSTATUS)0xC00000A1L)")]
    public const int STATUS_WORKING_SET_QUOTA = unchecked((int)(0xC00000A1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEDIA_WRITE_PROTECTED"]/*' />
    [NativeTypeName("#define STATUS_MEDIA_WRITE_PROTECTED ((NTSTATUS)0xC00000A2L)")]
    public const int STATUS_MEDIA_WRITE_PROTECTED = unchecked((int)(0xC00000A2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_NOT_READY ((NTSTATUS)0xC00000A3L)")]
    public const int STATUS_DEVICE_NOT_READY = unchecked((int)(0xC00000A3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_GROUP_ATTRIBUTES"]/*' />
    [NativeTypeName("#define STATUS_INVALID_GROUP_ATTRIBUTES ((NTSTATUS)0xC00000A4L)")]
    public const int STATUS_INVALID_GROUP_ATTRIBUTES = unchecked((int)(0xC00000A4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_IMPERSONATION_LEVEL"]/*' />
    [NativeTypeName("#define STATUS_BAD_IMPERSONATION_LEVEL ((NTSTATUS)0xC00000A5L)")]
    public const int STATUS_BAD_IMPERSONATION_LEVEL = unchecked((int)(0xC00000A5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_OPEN_ANONYMOUS"]/*' />
    [NativeTypeName("#define STATUS_CANT_OPEN_ANONYMOUS ((NTSTATUS)0xC00000A6L)")]
    public const int STATUS_CANT_OPEN_ANONYMOUS = unchecked((int)(0xC00000A6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_VALIDATION_CLASS"]/*' />
    [NativeTypeName("#define STATUS_BAD_VALIDATION_CLASS ((NTSTATUS)0xC00000A7L)")]
    public const int STATUS_BAD_VALIDATION_CLASS = unchecked((int)(0xC00000A7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_TOKEN_TYPE"]/*' />
    [NativeTypeName("#define STATUS_BAD_TOKEN_TYPE ((NTSTATUS)0xC00000A8L)")]
    public const int STATUS_BAD_TOKEN_TYPE = unchecked((int)(0xC00000A8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_MASTER_BOOT_RECORD"]/*' />
    [NativeTypeName("#define STATUS_BAD_MASTER_BOOT_RECORD ((NTSTATUS)0xC00000A9L)")]
    public const int STATUS_BAD_MASTER_BOOT_RECORD = unchecked((int)(0xC00000A9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSTRUCTION_MISALIGNMENT"]/*' />
    [NativeTypeName("#define STATUS_INSTRUCTION_MISALIGNMENT ((NTSTATUS)0xC00000AAL)")]
    public const int STATUS_INSTRUCTION_MISALIGNMENT = unchecked((int)(0xC00000AA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSTANCE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_INSTANCE_NOT_AVAILABLE ((NTSTATUS)0xC00000ABL)")]
    public const int STATUS_INSTANCE_NOT_AVAILABLE = unchecked((int)(0xC00000AB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PIPE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_PIPE_NOT_AVAILABLE ((NTSTATUS)0xC00000ACL)")]
    public const int STATUS_PIPE_NOT_AVAILABLE = unchecked((int)(0xC00000AC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PIPE_STATE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PIPE_STATE ((NTSTATUS)0xC00000ADL)")]
    public const int STATUS_INVALID_PIPE_STATE = unchecked((int)(0xC00000AD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PIPE_BUSY"]/*' />
    [NativeTypeName("#define STATUS_PIPE_BUSY ((NTSTATUS)0xC00000AEL)")]
    public const int STATUS_PIPE_BUSY = unchecked((int)(0xC00000AE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ILLEGAL_FUNCTION"]/*' />
    [NativeTypeName("#define STATUS_ILLEGAL_FUNCTION ((NTSTATUS)0xC00000AFL)")]
    public const int STATUS_ILLEGAL_FUNCTION = unchecked((int)(0xC00000AF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PIPE_DISCONNECTED"]/*' />
    [NativeTypeName("#define STATUS_PIPE_DISCONNECTED ((NTSTATUS)0xC00000B0L)")]
    public const int STATUS_PIPE_DISCONNECTED = unchecked((int)(0xC00000B0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PIPE_CLOSING"]/*' />
    [NativeTypeName("#define STATUS_PIPE_CLOSING ((NTSTATUS)0xC00000B1L)")]
    public const int STATUS_PIPE_CLOSING = unchecked((int)(0xC00000B1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PIPE_CONNECTED"]/*' />
    [NativeTypeName("#define STATUS_PIPE_CONNECTED ((NTSTATUS)0xC00000B2L)")]
    public const int STATUS_PIPE_CONNECTED = unchecked((int)(0xC00000B2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PIPE_LISTENING"]/*' />
    [NativeTypeName("#define STATUS_PIPE_LISTENING ((NTSTATUS)0xC00000B3L)")]
    public const int STATUS_PIPE_LISTENING = unchecked((int)(0xC00000B3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_READ_MODE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_READ_MODE ((NTSTATUS)0xC00000B4L)")]
    public const int STATUS_INVALID_READ_MODE = unchecked((int)(0xC00000B4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_IO_TIMEOUT ((NTSTATUS)0xC00000B5L)")]
    public const int STATUS_IO_TIMEOUT = unchecked((int)(0xC00000B5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_FORCED_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_FILE_FORCED_CLOSED ((NTSTATUS)0xC00000B6L)")]
    public const int STATUS_FILE_FORCED_CLOSED = unchecked((int)(0xC00000B6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROFILING_NOT_STARTED"]/*' />
    [NativeTypeName("#define STATUS_PROFILING_NOT_STARTED ((NTSTATUS)0xC00000B7L)")]
    public const int STATUS_PROFILING_NOT_STARTED = unchecked((int)(0xC00000B7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROFILING_NOT_STOPPED"]/*' />
    [NativeTypeName("#define STATUS_PROFILING_NOT_STOPPED ((NTSTATUS)0xC00000B8L)")]
    public const int STATUS_PROFILING_NOT_STOPPED = unchecked((int)(0xC00000B8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COULD_NOT_INTERPRET"]/*' />
    [NativeTypeName("#define STATUS_COULD_NOT_INTERPRET ((NTSTATUS)0xC00000B9L)")]
    public const int STATUS_COULD_NOT_INTERPRET = unchecked((int)(0xC00000B9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_IS_A_DIRECTORY"]/*' />
    [NativeTypeName("#define STATUS_FILE_IS_A_DIRECTORY ((NTSTATUS)0xC00000BAL)")]
    public const int STATUS_FILE_IS_A_DIRECTORY = unchecked((int)(0xC00000BA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED ((NTSTATUS)0xC00000BBL)")]
    public const int STATUS_NOT_SUPPORTED = unchecked((int)(0xC00000BB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REMOTE_NOT_LISTENING"]/*' />
    [NativeTypeName("#define STATUS_REMOTE_NOT_LISTENING ((NTSTATUS)0xC00000BCL)")]
    public const int STATUS_REMOTE_NOT_LISTENING = unchecked((int)(0xC00000BC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DUPLICATE_NAME"]/*' />
    [NativeTypeName("#define STATUS_DUPLICATE_NAME ((NTSTATUS)0xC00000BDL)")]
    public const int STATUS_DUPLICATE_NAME = unchecked((int)(0xC00000BD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_NETWORK_PATH"]/*' />
    [NativeTypeName("#define STATUS_BAD_NETWORK_PATH ((NTSTATUS)0xC00000BEL)")]
    public const int STATUS_BAD_NETWORK_PATH = unchecked((int)(0xC00000BE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_BUSY"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_BUSY ((NTSTATUS)0xC00000BFL)")]
    public const int STATUS_NETWORK_BUSY = unchecked((int)(0xC00000BF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_DOES_NOT_EXIST ((NTSTATUS)0xC00000C0L)")]
    public const int STATUS_DEVICE_DOES_NOT_EXIST = unchecked((int)(0xC00000C0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_COMMANDS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_COMMANDS ((NTSTATUS)0xC00000C1L)")]
    public const int STATUS_TOO_MANY_COMMANDS = unchecked((int)(0xC00000C1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ADAPTER_HARDWARE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_ADAPTER_HARDWARE_ERROR ((NTSTATUS)0xC00000C2L)")]
    public const int STATUS_ADAPTER_HARDWARE_ERROR = unchecked((int)(0xC00000C2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_NETWORK_RESPONSE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_NETWORK_RESPONSE ((NTSTATUS)0xC00000C3L)")]
    public const int STATUS_INVALID_NETWORK_RESPONSE = unchecked((int)(0xC00000C3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNEXPECTED_NETWORK_ERROR"]/*' />
    [NativeTypeName("#define STATUS_UNEXPECTED_NETWORK_ERROR ((NTSTATUS)0xC00000C4L)")]
    public const int STATUS_UNEXPECTED_NETWORK_ERROR = unchecked((int)(0xC00000C4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_REMOTE_ADAPTER"]/*' />
    [NativeTypeName("#define STATUS_BAD_REMOTE_ADAPTER ((NTSTATUS)0xC00000C5L)")]
    public const int STATUS_BAD_REMOTE_ADAPTER = unchecked((int)(0xC00000C5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRINT_QUEUE_FULL"]/*' />
    [NativeTypeName("#define STATUS_PRINT_QUEUE_FULL ((NTSTATUS)0xC00000C6L)")]
    public const int STATUS_PRINT_QUEUE_FULL = unchecked((int)(0xC00000C6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SPOOL_SPACE"]/*' />
    [NativeTypeName("#define STATUS_NO_SPOOL_SPACE ((NTSTATUS)0xC00000C7L)")]
    public const int STATUS_NO_SPOOL_SPACE = unchecked((int)(0xC00000C7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRINT_CANCELLED"]/*' />
    [NativeTypeName("#define STATUS_PRINT_CANCELLED ((NTSTATUS)0xC00000C8L)")]
    public const int STATUS_PRINT_CANCELLED = unchecked((int)(0xC00000C8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_NAME_DELETED"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_NAME_DELETED ((NTSTATUS)0xC00000C9L)")]
    public const int STATUS_NETWORK_NAME_DELETED = unchecked((int)(0xC00000C9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_ACCESS_DENIED ((NTSTATUS)0xC00000CAL)")]
    public const int STATUS_NETWORK_ACCESS_DENIED = unchecked((int)(0xC00000CA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_DEVICE_TYPE"]/*' />
    [NativeTypeName("#define STATUS_BAD_DEVICE_TYPE ((NTSTATUS)0xC00000CBL)")]
    public const int STATUS_BAD_DEVICE_TYPE = unchecked((int)(0xC00000CB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_NETWORK_NAME"]/*' />
    [NativeTypeName("#define STATUS_BAD_NETWORK_NAME ((NTSTATUS)0xC00000CCL)")]
    public const int STATUS_BAD_NETWORK_NAME = unchecked((int)(0xC00000CC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_NAMES"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_NAMES ((NTSTATUS)0xC00000CDL)")]
    public const int STATUS_TOO_MANY_NAMES = unchecked((int)(0xC00000CD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_SESSIONS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_SESSIONS ((NTSTATUS)0xC00000CEL)")]
    public const int STATUS_TOO_MANY_SESSIONS = unchecked((int)(0xC00000CE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SHARING_PAUSED"]/*' />
    [NativeTypeName("#define STATUS_SHARING_PAUSED ((NTSTATUS)0xC00000CFL)")]
    public const int STATUS_SHARING_PAUSED = unchecked((int)(0xC00000CF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REQUEST_NOT_ACCEPTED"]/*' />
    [NativeTypeName("#define STATUS_REQUEST_NOT_ACCEPTED ((NTSTATUS)0xC00000D0L)")]
    public const int STATUS_REQUEST_NOT_ACCEPTED = unchecked((int)(0xC00000D0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REDIRECTOR_PAUSED"]/*' />
    [NativeTypeName("#define STATUS_REDIRECTOR_PAUSED ((NTSTATUS)0xC00000D1L)")]
    public const int STATUS_REDIRECTOR_PAUSED = unchecked((int)(0xC00000D1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NET_WRITE_FAULT"]/*' />
    [NativeTypeName("#define STATUS_NET_WRITE_FAULT ((NTSTATUS)0xC00000D2L)")]
    public const int STATUS_NET_WRITE_FAULT = unchecked((int)(0xC00000D2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROFILING_AT_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_PROFILING_AT_LIMIT ((NTSTATUS)0xC00000D3L)")]
    public const int STATUS_PROFILING_AT_LIMIT = unchecked((int)(0xC00000D3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SAME_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_NOT_SAME_DEVICE ((NTSTATUS)0xC00000D4L)")]
    public const int STATUS_NOT_SAME_DEVICE = unchecked((int)(0xC00000D4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_RENAMED"]/*' />
    [NativeTypeName("#define STATUS_FILE_RENAMED ((NTSTATUS)0xC00000D5L)")]
    public const int STATUS_FILE_RENAMED = unchecked((int)(0xC00000D5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRTUAL_CIRCUIT_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_VIRTUAL_CIRCUIT_CLOSED ((NTSTATUS)0xC00000D6L)")]
    public const int STATUS_VIRTUAL_CIRCUIT_CLOSED = unchecked((int)(0xC00000D6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SECURITY_ON_OBJECT"]/*' />
    [NativeTypeName("#define STATUS_NO_SECURITY_ON_OBJECT ((NTSTATUS)0xC00000D7L)")]
    public const int STATUS_NO_SECURITY_ON_OBJECT = unchecked((int)(0xC00000D7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_WAIT"]/*' />
    [NativeTypeName("#define STATUS_CANT_WAIT ((NTSTATUS)0xC00000D8L)")]
    public const int STATUS_CANT_WAIT = unchecked((int)(0xC00000D8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PIPE_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_PIPE_EMPTY ((NTSTATUS)0xC00000D9L)")]
    public const int STATUS_PIPE_EMPTY = unchecked((int)(0xC00000D9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_ACCESS_DOMAIN_INFO"]/*' />
    [NativeTypeName("#define STATUS_CANT_ACCESS_DOMAIN_INFO ((NTSTATUS)0xC00000DAL)")]
    public const int STATUS_CANT_ACCESS_DOMAIN_INFO = unchecked((int)(0xC00000DA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_TERMINATE_SELF"]/*' />
    [NativeTypeName("#define STATUS_CANT_TERMINATE_SELF ((NTSTATUS)0xC00000DBL)")]
    public const int STATUS_CANT_TERMINATE_SELF = unchecked((int)(0xC00000DB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_SERVER_STATE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_SERVER_STATE ((NTSTATUS)0xC00000DCL)")]
    public const int STATUS_INVALID_SERVER_STATE = unchecked((int)(0xC00000DC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_DOMAIN_STATE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_DOMAIN_STATE ((NTSTATUS)0xC00000DDL)")]
    public const int STATUS_INVALID_DOMAIN_STATE = unchecked((int)(0xC00000DD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_DOMAIN_ROLE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_DOMAIN_ROLE ((NTSTATUS)0xC00000DEL)")]
    public const int STATUS_INVALID_DOMAIN_ROLE = unchecked((int)(0xC00000DE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_DOMAIN"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_DOMAIN ((NTSTATUS)0xC00000DFL)")]
    public const int STATUS_NO_SUCH_DOMAIN = unchecked((int)(0xC00000DF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DOMAIN_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_DOMAIN_EXISTS ((NTSTATUS)0xC00000E0L)")]
    public const int STATUS_DOMAIN_EXISTS = unchecked((int)(0xC00000E0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DOMAIN_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_DOMAIN_LIMIT_EXCEEDED ((NTSTATUS)0xC00000E1L)")]
    public const int STATUS_DOMAIN_LIMIT_EXCEEDED = unchecked((int)(0xC00000E1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OPLOCK_NOT_GRANTED"]/*' />
    [NativeTypeName("#define STATUS_OPLOCK_NOT_GRANTED ((NTSTATUS)0xC00000E2L)")]
    public const int STATUS_OPLOCK_NOT_GRANTED = unchecked((int)(0xC00000E2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_OPLOCK_PROTOCOL"]/*' />
    [NativeTypeName("#define STATUS_INVALID_OPLOCK_PROTOCOL ((NTSTATUS)0xC00000E3L)")]
    public const int STATUS_INVALID_OPLOCK_PROTOCOL = unchecked((int)(0xC00000E3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTERNAL_DB_CORRUPTION"]/*' />
    [NativeTypeName("#define STATUS_INTERNAL_DB_CORRUPTION ((NTSTATUS)0xC00000E4L)")]
    public const int STATUS_INTERNAL_DB_CORRUPTION = unchecked((int)(0xC00000E4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_INTERNAL_ERROR ((NTSTATUS)0xC00000E5L)")]
    public const int STATUS_INTERNAL_ERROR = unchecked((int)(0xC00000E5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GENERIC_NOT_MAPPED"]/*' />
    [NativeTypeName("#define STATUS_GENERIC_NOT_MAPPED ((NTSTATUS)0xC00000E6L)")]
    public const int STATUS_GENERIC_NOT_MAPPED = unchecked((int)(0xC00000E6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_DESCRIPTOR_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_BAD_DESCRIPTOR_FORMAT ((NTSTATUS)0xC00000E7L)")]
    public const int STATUS_BAD_DESCRIPTOR_FORMAT = unchecked((int)(0xC00000E7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_USER_BUFFER"]/*' />
    [NativeTypeName("#define STATUS_INVALID_USER_BUFFER ((NTSTATUS)0xC00000E8L)")]
    public const int STATUS_INVALID_USER_BUFFER = unchecked((int)(0xC00000E8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNEXPECTED_IO_ERROR"]/*' />
    [NativeTypeName("#define STATUS_UNEXPECTED_IO_ERROR ((NTSTATUS)0xC00000E9L)")]
    public const int STATUS_UNEXPECTED_IO_ERROR = unchecked((int)(0xC00000E9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNEXPECTED_MM_CREATE_ERR"]/*' />
    [NativeTypeName("#define STATUS_UNEXPECTED_MM_CREATE_ERR ((NTSTATUS)0xC00000EAL)")]
    public const int STATUS_UNEXPECTED_MM_CREATE_ERR = unchecked((int)(0xC00000EA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNEXPECTED_MM_MAP_ERROR"]/*' />
    [NativeTypeName("#define STATUS_UNEXPECTED_MM_MAP_ERROR ((NTSTATUS)0xC00000EBL)")]
    public const int STATUS_UNEXPECTED_MM_MAP_ERROR = unchecked((int)(0xC00000EB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNEXPECTED_MM_EXTEND_ERR"]/*' />
    [NativeTypeName("#define STATUS_UNEXPECTED_MM_EXTEND_ERR ((NTSTATUS)0xC00000ECL)")]
    public const int STATUS_UNEXPECTED_MM_EXTEND_ERR = unchecked((int)(0xC00000EC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_LOGON_PROCESS"]/*' />
    [NativeTypeName("#define STATUS_NOT_LOGON_PROCESS ((NTSTATUS)0xC00000EDL)")]
    public const int STATUS_NOT_LOGON_PROCESS = unchecked((int)(0xC00000ED));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOGON_SESSION_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_LOGON_SESSION_EXISTS ((NTSTATUS)0xC00000EEL)")]
    public const int STATUS_LOGON_SESSION_EXISTS = unchecked((int)(0xC00000EE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_1"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_1 ((NTSTATUS)0xC00000EFL)")]
    public const int STATUS_INVALID_PARAMETER_1 = unchecked((int)(0xC00000EF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_2"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_2 ((NTSTATUS)0xC00000F0L)")]
    public const int STATUS_INVALID_PARAMETER_2 = unchecked((int)(0xC00000F0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_3"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_3 ((NTSTATUS)0xC00000F1L)")]
    public const int STATUS_INVALID_PARAMETER_3 = unchecked((int)(0xC00000F1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_4"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_4 ((NTSTATUS)0xC00000F2L)")]
    public const int STATUS_INVALID_PARAMETER_4 = unchecked((int)(0xC00000F2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_5"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_5 ((NTSTATUS)0xC00000F3L)")]
    public const int STATUS_INVALID_PARAMETER_5 = unchecked((int)(0xC00000F3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_6"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_6 ((NTSTATUS)0xC00000F4L)")]
    public const int STATUS_INVALID_PARAMETER_6 = unchecked((int)(0xC00000F4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_7"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_7 ((NTSTATUS)0xC00000F5L)")]
    public const int STATUS_INVALID_PARAMETER_7 = unchecked((int)(0xC00000F5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_8"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_8 ((NTSTATUS)0xC00000F6L)")]
    public const int STATUS_INVALID_PARAMETER_8 = unchecked((int)(0xC00000F6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_9"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_9 ((NTSTATUS)0xC00000F7L)")]
    public const int STATUS_INVALID_PARAMETER_9 = unchecked((int)(0xC00000F7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_10"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_10 ((NTSTATUS)0xC00000F8L)")]
    public const int STATUS_INVALID_PARAMETER_10 = unchecked((int)(0xC00000F8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_11"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_11 ((NTSTATUS)0xC00000F9L)")]
    public const int STATUS_INVALID_PARAMETER_11 = unchecked((int)(0xC00000F9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER_12"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER_12 ((NTSTATUS)0xC00000FAL)")]
    public const int STATUS_INVALID_PARAMETER_12 = unchecked((int)(0xC00000FA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REDIRECTOR_NOT_STARTED"]/*' />
    [NativeTypeName("#define STATUS_REDIRECTOR_NOT_STARTED ((NTSTATUS)0xC00000FBL)")]
    public const int STATUS_REDIRECTOR_NOT_STARTED = unchecked((int)(0xC00000FB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REDIRECTOR_STARTED"]/*' />
    [NativeTypeName("#define STATUS_REDIRECTOR_STARTED ((NTSTATUS)0xC00000FCL)")]
    public const int STATUS_REDIRECTOR_STARTED = unchecked((int)(0xC00000FC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_PACKAGE"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_PACKAGE ((NTSTATUS)0xC00000FEL)")]
    public const int STATUS_NO_SUCH_PACKAGE = unchecked((int)(0xC00000FE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_FUNCTION_TABLE"]/*' />
    [NativeTypeName("#define STATUS_BAD_FUNCTION_TABLE ((NTSTATUS)0xC00000FFL)")]
    public const int STATUS_BAD_FUNCTION_TABLE = unchecked((int)(0xC00000FF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VARIABLE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_VARIABLE_NOT_FOUND ((NTSTATUS)0xC0000100L)")]
    public const int STATUS_VARIABLE_NOT_FOUND = unchecked((int)(0xC0000100));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIRECTORY_NOT_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_DIRECTORY_NOT_EMPTY ((NTSTATUS)0xC0000101L)")]
    public const int STATUS_DIRECTORY_NOT_EMPTY = unchecked((int)(0xC0000101));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_CORRUPT_ERROR"]/*' />
    [NativeTypeName("#define STATUS_FILE_CORRUPT_ERROR ((NTSTATUS)0xC0000102L)")]
    public const int STATUS_FILE_CORRUPT_ERROR = unchecked((int)(0xC0000102));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_A_DIRECTORY"]/*' />
    [NativeTypeName("#define STATUS_NOT_A_DIRECTORY ((NTSTATUS)0xC0000103L)")]
    public const int STATUS_NOT_A_DIRECTORY = unchecked((int)(0xC0000103));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_LOGON_SESSION_STATE"]/*' />
    [NativeTypeName("#define STATUS_BAD_LOGON_SESSION_STATE ((NTSTATUS)0xC0000104L)")]
    public const int STATUS_BAD_LOGON_SESSION_STATE = unchecked((int)(0xC0000104));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOGON_SESSION_COLLISION"]/*' />
    [NativeTypeName("#define STATUS_LOGON_SESSION_COLLISION ((NTSTATUS)0xC0000105L)")]
    public const int STATUS_LOGON_SESSION_COLLISION = unchecked((int)(0xC0000105));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NAME_TOO_LONG"]/*' />
    [NativeTypeName("#define STATUS_NAME_TOO_LONG ((NTSTATUS)0xC0000106L)")]
    public const int STATUS_NAME_TOO_LONG = unchecked((int)(0xC0000106));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILES_OPEN"]/*' />
    [NativeTypeName("#define STATUS_FILES_OPEN ((NTSTATUS)0xC0000107L)")]
    public const int STATUS_FILES_OPEN = unchecked((int)(0xC0000107));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONNECTION_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_CONNECTION_IN_USE ((NTSTATUS)0xC0000108L)")]
    public const int STATUS_CONNECTION_IN_USE = unchecked((int)(0xC0000108));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MESSAGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_MESSAGE_NOT_FOUND ((NTSTATUS)0xC0000109L)")]
    public const int STATUS_MESSAGE_NOT_FOUND = unchecked((int)(0xC0000109));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROCESS_IS_TERMINATING"]/*' />
    [NativeTypeName("#define STATUS_PROCESS_IS_TERMINATING ((NTSTATUS)0xC000010AL)")]
    public const int STATUS_PROCESS_IS_TERMINATING = unchecked((int)(0xC000010A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LOGON_TYPE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LOGON_TYPE ((NTSTATUS)0xC000010BL)")]
    public const int STATUS_INVALID_LOGON_TYPE = unchecked((int)(0xC000010B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_GUID_TRANSLATION"]/*' />
    [NativeTypeName("#define STATUS_NO_GUID_TRANSLATION ((NTSTATUS)0xC000010CL)")]
    public const int STATUS_NO_GUID_TRANSLATION = unchecked((int)(0xC000010C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_IMPERSONATE"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_IMPERSONATE ((NTSTATUS)0xC000010DL)")]
    public const int STATUS_CANNOT_IMPERSONATE = unchecked((int)(0xC000010D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_ALREADY_LOADED"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_ALREADY_LOADED ((NTSTATUS)0xC000010EL)")]
    public const int STATUS_IMAGE_ALREADY_LOADED = unchecked((int)(0xC000010E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABIOS_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_ABIOS_NOT_PRESENT ((NTSTATUS)0xC000010FL)")]
    public const int STATUS_ABIOS_NOT_PRESENT = unchecked((int)(0xC000010F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABIOS_LID_NOT_EXIST"]/*' />
    [NativeTypeName("#define STATUS_ABIOS_LID_NOT_EXIST ((NTSTATUS)0xC0000110L)")]
    public const int STATUS_ABIOS_LID_NOT_EXIST = unchecked((int)(0xC0000110));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABIOS_LID_ALREADY_OWNED"]/*' />
    [NativeTypeName("#define STATUS_ABIOS_LID_ALREADY_OWNED ((NTSTATUS)0xC0000111L)")]
    public const int STATUS_ABIOS_LID_ALREADY_OWNED = unchecked((int)(0xC0000111));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABIOS_NOT_LID_OWNER"]/*' />
    [NativeTypeName("#define STATUS_ABIOS_NOT_LID_OWNER ((NTSTATUS)0xC0000112L)")]
    public const int STATUS_ABIOS_NOT_LID_OWNER = unchecked((int)(0xC0000112));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABIOS_INVALID_COMMAND"]/*' />
    [NativeTypeName("#define STATUS_ABIOS_INVALID_COMMAND ((NTSTATUS)0xC0000113L)")]
    public const int STATUS_ABIOS_INVALID_COMMAND = unchecked((int)(0xC0000113));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABIOS_INVALID_LID"]/*' />
    [NativeTypeName("#define STATUS_ABIOS_INVALID_LID ((NTSTATUS)0xC0000114L)")]
    public const int STATUS_ABIOS_INVALID_LID = unchecked((int)(0xC0000114));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABIOS_SELECTOR_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_ABIOS_SELECTOR_NOT_AVAILABLE ((NTSTATUS)0xC0000115L)")]
    public const int STATUS_ABIOS_SELECTOR_NOT_AVAILABLE = unchecked((int)(0xC0000115));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABIOS_INVALID_SELECTOR"]/*' />
    [NativeTypeName("#define STATUS_ABIOS_INVALID_SELECTOR ((NTSTATUS)0xC0000116L)")]
    public const int STATUS_ABIOS_INVALID_SELECTOR = unchecked((int)(0xC0000116));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_LDT"]/*' />
    [NativeTypeName("#define STATUS_NO_LDT ((NTSTATUS)0xC0000117L)")]
    public const int STATUS_NO_LDT = unchecked((int)(0xC0000117));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LDT_SIZE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LDT_SIZE ((NTSTATUS)0xC0000118L)")]
    public const int STATUS_INVALID_LDT_SIZE = unchecked((int)(0xC0000118));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LDT_OFFSET"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LDT_OFFSET ((NTSTATUS)0xC0000119L)")]
    public const int STATUS_INVALID_LDT_OFFSET = unchecked((int)(0xC0000119));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LDT_DESCRIPTOR"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LDT_DESCRIPTOR ((NTSTATUS)0xC000011AL)")]
    public const int STATUS_INVALID_LDT_DESCRIPTOR = unchecked((int)(0xC000011A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_NE_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_NE_FORMAT ((NTSTATUS)0xC000011BL)")]
    public const int STATUS_INVALID_IMAGE_NE_FORMAT = unchecked((int)(0xC000011B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RXACT_INVALID_STATE"]/*' />
    [NativeTypeName("#define STATUS_RXACT_INVALID_STATE ((NTSTATUS)0xC000011CL)")]
    public const int STATUS_RXACT_INVALID_STATE = unchecked((int)(0xC000011C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RXACT_COMMIT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_RXACT_COMMIT_FAILURE ((NTSTATUS)0xC000011DL)")]
    public const int STATUS_RXACT_COMMIT_FAILURE = unchecked((int)(0xC000011D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MAPPED_FILE_SIZE_ZERO"]/*' />
    [NativeTypeName("#define STATUS_MAPPED_FILE_SIZE_ZERO ((NTSTATUS)0xC000011EL)")]
    public const int STATUS_MAPPED_FILE_SIZE_ZERO = unchecked((int)(0xC000011E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_OPENED_FILES"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_OPENED_FILES ((NTSTATUS)0xC000011FL)")]
    public const int STATUS_TOO_MANY_OPENED_FILES = unchecked((int)(0xC000011F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANCELLED"]/*' />
    [NativeTypeName("#define STATUS_CANCELLED ((NTSTATUS)0xC0000120L)")]
    public const int STATUS_CANCELLED = unchecked((int)(0xC0000120));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_DELETE"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_DELETE ((NTSTATUS)0xC0000121L)")]
    public const int STATUS_CANNOT_DELETE = unchecked((int)(0xC0000121));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_COMPUTER_NAME"]/*' />
    [NativeTypeName("#define STATUS_INVALID_COMPUTER_NAME ((NTSTATUS)0xC0000122L)")]
    public const int STATUS_INVALID_COMPUTER_NAME = unchecked((int)(0xC0000122));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_DELETED"]/*' />
    [NativeTypeName("#define STATUS_FILE_DELETED ((NTSTATUS)0xC0000123L)")]
    public const int STATUS_FILE_DELETED = unchecked((int)(0xC0000123));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPECIAL_ACCOUNT"]/*' />
    [NativeTypeName("#define STATUS_SPECIAL_ACCOUNT ((NTSTATUS)0xC0000124L)")]
    public const int STATUS_SPECIAL_ACCOUNT = unchecked((int)(0xC0000124));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPECIAL_GROUP"]/*' />
    [NativeTypeName("#define STATUS_SPECIAL_GROUP ((NTSTATUS)0xC0000125L)")]
    public const int STATUS_SPECIAL_GROUP = unchecked((int)(0xC0000125));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPECIAL_USER"]/*' />
    [NativeTypeName("#define STATUS_SPECIAL_USER ((NTSTATUS)0xC0000126L)")]
    public const int STATUS_SPECIAL_USER = unchecked((int)(0xC0000126));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEMBERS_PRIMARY_GROUP"]/*' />
    [NativeTypeName("#define STATUS_MEMBERS_PRIMARY_GROUP ((NTSTATUS)0xC0000127L)")]
    public const int STATUS_MEMBERS_PRIMARY_GROUP = unchecked((int)(0xC0000127));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_FILE_CLOSED ((NTSTATUS)0xC0000128L)")]
    public const int STATUS_FILE_CLOSED = unchecked((int)(0xC0000128));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_THREADS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_THREADS ((NTSTATUS)0xC0000129L)")]
    public const int STATUS_TOO_MANY_THREADS = unchecked((int)(0xC0000129));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREAD_NOT_IN_PROCESS"]/*' />
    [NativeTypeName("#define STATUS_THREAD_NOT_IN_PROCESS ((NTSTATUS)0xC000012AL)")]
    public const int STATUS_THREAD_NOT_IN_PROCESS = unchecked((int)(0xC000012A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOKEN_ALREADY_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_TOKEN_ALREADY_IN_USE ((NTSTATUS)0xC000012BL)")]
    public const int STATUS_TOKEN_ALREADY_IN_USE = unchecked((int)(0xC000012B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGEFILE_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_PAGEFILE_QUOTA_EXCEEDED ((NTSTATUS)0xC000012CL)")]
    public const int STATUS_PAGEFILE_QUOTA_EXCEEDED = unchecked((int)(0xC000012C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COMMITMENT_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_COMMITMENT_LIMIT ((NTSTATUS)0xC000012DL)")]
    public const int STATUS_COMMITMENT_LIMIT = unchecked((int)(0xC000012D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_LE_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_LE_FORMAT ((NTSTATUS)0xC000012EL)")]
    public const int STATUS_INVALID_IMAGE_LE_FORMAT = unchecked((int)(0xC000012E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_NOT_MZ"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_NOT_MZ ((NTSTATUS)0xC000012FL)")]
    public const int STATUS_INVALID_IMAGE_NOT_MZ = unchecked((int)(0xC000012F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_PROTECT"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_PROTECT ((NTSTATUS)0xC0000130L)")]
    public const int STATUS_INVALID_IMAGE_PROTECT = unchecked((int)(0xC0000130));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_WIN_16"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_WIN_16 ((NTSTATUS)0xC0000131L)")]
    public const int STATUS_INVALID_IMAGE_WIN_16 = unchecked((int)(0xC0000131));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOGON_SERVER_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_LOGON_SERVER_CONFLICT ((NTSTATUS)0xC0000132L)")]
    public const int STATUS_LOGON_SERVER_CONFLICT = unchecked((int)(0xC0000132));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TIME_DIFFERENCE_AT_DC"]/*' />
    [NativeTypeName("#define STATUS_TIME_DIFFERENCE_AT_DC ((NTSTATUS)0xC0000133L)")]
    public const int STATUS_TIME_DIFFERENCE_AT_DC = unchecked((int)(0xC0000133));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYNCHRONIZATION_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_SYNCHRONIZATION_REQUIRED ((NTSTATUS)0xC0000134L)")]
    public const int STATUS_SYNCHRONIZATION_REQUIRED = unchecked((int)(0xC0000134));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OPEN_FAILED"]/*' />
    [NativeTypeName("#define STATUS_OPEN_FAILED ((NTSTATUS)0xC0000136L)")]
    public const int STATUS_OPEN_FAILED = unchecked((int)(0xC0000136));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_PRIVILEGE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_IO_PRIVILEGE_FAILED ((NTSTATUS)0xC0000137L)")]
    public const int STATUS_IO_PRIVILEGE_FAILED = unchecked((int)(0xC0000137));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOCAL_DISCONNECT"]/*' />
    [NativeTypeName("#define STATUS_LOCAL_DISCONNECT ((NTSTATUS)0xC000013BL)")]
    public const int STATUS_LOCAL_DISCONNECT = unchecked((int)(0xC000013B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REMOTE_DISCONNECT"]/*' />
    [NativeTypeName("#define STATUS_REMOTE_DISCONNECT ((NTSTATUS)0xC000013CL)")]
    public const int STATUS_REMOTE_DISCONNECT = unchecked((int)(0xC000013C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REMOTE_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_REMOTE_RESOURCES ((NTSTATUS)0xC000013DL)")]
    public const int STATUS_REMOTE_RESOURCES = unchecked((int)(0xC000013D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LINK_FAILED"]/*' />
    [NativeTypeName("#define STATUS_LINK_FAILED ((NTSTATUS)0xC000013EL)")]
    public const int STATUS_LINK_FAILED = unchecked((int)(0xC000013E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LINK_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_LINK_TIMEOUT ((NTSTATUS)0xC000013FL)")]
    public const int STATUS_LINK_TIMEOUT = unchecked((int)(0xC000013F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_CONNECTION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_CONNECTION ((NTSTATUS)0xC0000140L)")]
    public const int STATUS_INVALID_CONNECTION = unchecked((int)(0xC0000140));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_ADDRESS"]/*' />
    [NativeTypeName("#define STATUS_INVALID_ADDRESS ((NTSTATUS)0xC0000141L)")]
    public const int STATUS_INVALID_ADDRESS = unchecked((int)(0xC0000141));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MISSING_SYSTEMFILE"]/*' />
    [NativeTypeName("#define STATUS_MISSING_SYSTEMFILE ((NTSTATUS)0xC0000143L)")]
    public const int STATUS_MISSING_SYSTEMFILE = unchecked((int)(0xC0000143));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNHANDLED_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_UNHANDLED_EXCEPTION ((NTSTATUS)0xC0000144L)")]
    public const int STATUS_UNHANDLED_EXCEPTION = unchecked((int)(0xC0000144));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APP_INIT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_APP_INIT_FAILURE ((NTSTATUS)0xC0000145L)")]
    public const int STATUS_APP_INIT_FAILURE = unchecked((int)(0xC0000145));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGEFILE_CREATE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_PAGEFILE_CREATE_FAILED ((NTSTATUS)0xC0000146L)")]
    public const int STATUS_PAGEFILE_CREATE_FAILED = unchecked((int)(0xC0000146));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_PAGEFILE"]/*' />
    [NativeTypeName("#define STATUS_NO_PAGEFILE ((NTSTATUS)0xC0000147L)")]
    public const int STATUS_NO_PAGEFILE = unchecked((int)(0xC0000147));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LEVEL"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LEVEL ((NTSTATUS)0xC0000148L)")]
    public const int STATUS_INVALID_LEVEL = unchecked((int)(0xC0000148));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WRONG_PASSWORD_CORE"]/*' />
    [NativeTypeName("#define STATUS_WRONG_PASSWORD_CORE ((NTSTATUS)0xC0000149L)")]
    public const int STATUS_WRONG_PASSWORD_CORE = unchecked((int)(0xC0000149));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ILLEGAL_FLOAT_CONTEXT"]/*' />
    [NativeTypeName("#define STATUS_ILLEGAL_FLOAT_CONTEXT ((NTSTATUS)0xC000014AL)")]
    public const int STATUS_ILLEGAL_FLOAT_CONTEXT = unchecked((int)(0xC000014A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PIPE_BROKEN"]/*' />
    [NativeTypeName("#define STATUS_PIPE_BROKEN ((NTSTATUS)0xC000014BL)")]
    public const int STATUS_PIPE_BROKEN = unchecked((int)(0xC000014B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REGISTRY_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_REGISTRY_CORRUPT ((NTSTATUS)0xC000014CL)")]
    public const int STATUS_REGISTRY_CORRUPT = unchecked((int)(0xC000014C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REGISTRY_IO_FAILED"]/*' />
    [NativeTypeName("#define STATUS_REGISTRY_IO_FAILED ((NTSTATUS)0xC000014DL)")]
    public const int STATUS_REGISTRY_IO_FAILED = unchecked((int)(0xC000014D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_EVENT_PAIR"]/*' />
    [NativeTypeName("#define STATUS_NO_EVENT_PAIR ((NTSTATUS)0xC000014EL)")]
    public const int STATUS_NO_EVENT_PAIR = unchecked((int)(0xC000014E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNRECOGNIZED_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_UNRECOGNIZED_VOLUME ((NTSTATUS)0xC000014FL)")]
    public const int STATUS_UNRECOGNIZED_VOLUME = unchecked((int)(0xC000014F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERIAL_NO_DEVICE_INITED"]/*' />
    [NativeTypeName("#define STATUS_SERIAL_NO_DEVICE_INITED ((NTSTATUS)0xC0000150L)")]
    public const int STATUS_SERIAL_NO_DEVICE_INITED = unchecked((int)(0xC0000150));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_ALIAS"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_ALIAS ((NTSTATUS)0xC0000151L)")]
    public const int STATUS_NO_SUCH_ALIAS = unchecked((int)(0xC0000151));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEMBER_NOT_IN_ALIAS"]/*' />
    [NativeTypeName("#define STATUS_MEMBER_NOT_IN_ALIAS ((NTSTATUS)0xC0000152L)")]
    public const int STATUS_MEMBER_NOT_IN_ALIAS = unchecked((int)(0xC0000152));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEMBER_IN_ALIAS"]/*' />
    [NativeTypeName("#define STATUS_MEMBER_IN_ALIAS ((NTSTATUS)0xC0000153L)")]
    public const int STATUS_MEMBER_IN_ALIAS = unchecked((int)(0xC0000153));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALIAS_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_ALIAS_EXISTS ((NTSTATUS)0xC0000154L)")]
    public const int STATUS_ALIAS_EXISTS = unchecked((int)(0xC0000154));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOGON_NOT_GRANTED"]/*' />
    [NativeTypeName("#define STATUS_LOGON_NOT_GRANTED ((NTSTATUS)0xC0000155L)")]
    public const int STATUS_LOGON_NOT_GRANTED = unchecked((int)(0xC0000155));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_SECRETS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_SECRETS ((NTSTATUS)0xC0000156L)")]
    public const int STATUS_TOO_MANY_SECRETS = unchecked((int)(0xC0000156));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECRET_TOO_LONG"]/*' />
    [NativeTypeName("#define STATUS_SECRET_TOO_LONG ((NTSTATUS)0xC0000157L)")]
    public const int STATUS_SECRET_TOO_LONG = unchecked((int)(0xC0000157));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTERNAL_DB_ERROR"]/*' />
    [NativeTypeName("#define STATUS_INTERNAL_DB_ERROR ((NTSTATUS)0xC0000158L)")]
    public const int STATUS_INTERNAL_DB_ERROR = unchecked((int)(0xC0000158));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FULLSCREEN_MODE"]/*' />
    [NativeTypeName("#define STATUS_FULLSCREEN_MODE ((NTSTATUS)0xC0000159L)")]
    public const int STATUS_FULLSCREEN_MODE = unchecked((int)(0xC0000159));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_CONTEXT_IDS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_CONTEXT_IDS ((NTSTATUS)0xC000015AL)")]
    public const int STATUS_TOO_MANY_CONTEXT_IDS = unchecked((int)(0xC000015A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOGON_TYPE_NOT_GRANTED"]/*' />
    [NativeTypeName("#define STATUS_LOGON_TYPE_NOT_GRANTED ((NTSTATUS)0xC000015BL)")]
    public const int STATUS_LOGON_TYPE_NOT_GRANTED = unchecked((int)(0xC000015B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_REGISTRY_FILE"]/*' />
    [NativeTypeName("#define STATUS_NOT_REGISTRY_FILE ((NTSTATUS)0xC000015CL)")]
    public const int STATUS_NOT_REGISTRY_FILE = unchecked((int)(0xC000015C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NT_CROSS_ENCRYPTION_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_NT_CROSS_ENCRYPTION_REQUIRED ((NTSTATUS)0xC000015DL)")]
    public const int STATUS_NT_CROSS_ENCRYPTION_REQUIRED = unchecked((int)(0xC000015D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DOMAIN_CTRLR_CONFIG_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DOMAIN_CTRLR_CONFIG_ERROR ((NTSTATUS)0xC000015EL)")]
    public const int STATUS_DOMAIN_CTRLR_CONFIG_ERROR = unchecked((int)(0xC000015E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_MISSING_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_FT_MISSING_MEMBER ((NTSTATUS)0xC000015FL)")]
    public const int STATUS_FT_MISSING_MEMBER = unchecked((int)(0xC000015F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ILL_FORMED_SERVICE_ENTRY"]/*' />
    [NativeTypeName("#define STATUS_ILL_FORMED_SERVICE_ENTRY ((NTSTATUS)0xC0000160L)")]
    public const int STATUS_ILL_FORMED_SERVICE_ENTRY = unchecked((int)(0xC0000160));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ILLEGAL_CHARACTER"]/*' />
    [NativeTypeName("#define STATUS_ILLEGAL_CHARACTER ((NTSTATUS)0xC0000161L)")]
    public const int STATUS_ILLEGAL_CHARACTER = unchecked((int)(0xC0000161));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNMAPPABLE_CHARACTER"]/*' />
    [NativeTypeName("#define STATUS_UNMAPPABLE_CHARACTER ((NTSTATUS)0xC0000162L)")]
    public const int STATUS_UNMAPPABLE_CHARACTER = unchecked((int)(0xC0000162));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNDEFINED_CHARACTER"]/*' />
    [NativeTypeName("#define STATUS_UNDEFINED_CHARACTER ((NTSTATUS)0xC0000163L)")]
    public const int STATUS_UNDEFINED_CHARACTER = unchecked((int)(0xC0000163));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOPPY_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_FLOPPY_VOLUME ((NTSTATUS)0xC0000164L)")]
    public const int STATUS_FLOPPY_VOLUME = unchecked((int)(0xC0000164));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOPPY_ID_MARK_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FLOPPY_ID_MARK_NOT_FOUND ((NTSTATUS)0xC0000165L)")]
    public const int STATUS_FLOPPY_ID_MARK_NOT_FOUND = unchecked((int)(0xC0000165));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOPPY_WRONG_CYLINDER"]/*' />
    [NativeTypeName("#define STATUS_FLOPPY_WRONG_CYLINDER ((NTSTATUS)0xC0000166L)")]
    public const int STATUS_FLOPPY_WRONG_CYLINDER = unchecked((int)(0xC0000166));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOPPY_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define STATUS_FLOPPY_UNKNOWN_ERROR ((NTSTATUS)0xC0000167L)")]
    public const int STATUS_FLOPPY_UNKNOWN_ERROR = unchecked((int)(0xC0000167));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOPPY_BAD_REGISTERS"]/*' />
    [NativeTypeName("#define STATUS_FLOPPY_BAD_REGISTERS ((NTSTATUS)0xC0000168L)")]
    public const int STATUS_FLOPPY_BAD_REGISTERS = unchecked((int)(0xC0000168));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_RECALIBRATE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_DISK_RECALIBRATE_FAILED ((NTSTATUS)0xC0000169L)")]
    public const int STATUS_DISK_RECALIBRATE_FAILED = unchecked((int)(0xC0000169));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_OPERATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_DISK_OPERATION_FAILED ((NTSTATUS)0xC000016AL)")]
    public const int STATUS_DISK_OPERATION_FAILED = unchecked((int)(0xC000016A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_RESET_FAILED"]/*' />
    [NativeTypeName("#define STATUS_DISK_RESET_FAILED ((NTSTATUS)0xC000016BL)")]
    public const int STATUS_DISK_RESET_FAILED = unchecked((int)(0xC000016B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SHARED_IRQ_BUSY"]/*' />
    [NativeTypeName("#define STATUS_SHARED_IRQ_BUSY ((NTSTATUS)0xC000016CL)")]
    public const int STATUS_SHARED_IRQ_BUSY = unchecked((int)(0xC000016C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_ORPHANING"]/*' />
    [NativeTypeName("#define STATUS_FT_ORPHANING ((NTSTATUS)0xC000016DL)")]
    public const int STATUS_FT_ORPHANING = unchecked((int)(0xC000016D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BIOS_FAILED_TO_CONNECT_INTERRUPT"]/*' />
    [NativeTypeName("#define STATUS_BIOS_FAILED_TO_CONNECT_INTERRUPT ((NTSTATUS)0xC000016EL)")]
    public const int STATUS_BIOS_FAILED_TO_CONNECT_INTERRUPT = unchecked((int)(0xC000016E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PARTITION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_PARTITION_FAILURE ((NTSTATUS)0xC0000172L)")]
    public const int STATUS_PARTITION_FAILURE = unchecked((int)(0xC0000172));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_BLOCK_LENGTH"]/*' />
    [NativeTypeName("#define STATUS_INVALID_BLOCK_LENGTH ((NTSTATUS)0xC0000173L)")]
    public const int STATUS_INVALID_BLOCK_LENGTH = unchecked((int)(0xC0000173));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_NOT_PARTITIONED"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_NOT_PARTITIONED ((NTSTATUS)0xC0000174L)")]
    public const int STATUS_DEVICE_NOT_PARTITIONED = unchecked((int)(0xC0000174));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNABLE_TO_LOCK_MEDIA"]/*' />
    [NativeTypeName("#define STATUS_UNABLE_TO_LOCK_MEDIA ((NTSTATUS)0xC0000175L)")]
    public const int STATUS_UNABLE_TO_LOCK_MEDIA = unchecked((int)(0xC0000175));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNABLE_TO_UNLOAD_MEDIA"]/*' />
    [NativeTypeName("#define STATUS_UNABLE_TO_UNLOAD_MEDIA ((NTSTATUS)0xC0000176L)")]
    public const int STATUS_UNABLE_TO_UNLOAD_MEDIA = unchecked((int)(0xC0000176));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EOM_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_EOM_OVERFLOW ((NTSTATUS)0xC0000177L)")]
    public const int STATUS_EOM_OVERFLOW = unchecked((int)(0xC0000177));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_MEDIA"]/*' />
    [NativeTypeName("#define STATUS_NO_MEDIA ((NTSTATUS)0xC0000178L)")]
    public const int STATUS_NO_MEDIA = unchecked((int)(0xC0000178));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SUCH_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_NO_SUCH_MEMBER ((NTSTATUS)0xC000017AL)")]
    public const int STATUS_NO_SUCH_MEMBER = unchecked((int)(0xC000017A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_INVALID_MEMBER ((NTSTATUS)0xC000017BL)")]
    public const int STATUS_INVALID_MEMBER = unchecked((int)(0xC000017B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KEY_DELETED"]/*' />
    [NativeTypeName("#define STATUS_KEY_DELETED ((NTSTATUS)0xC000017CL)")]
    public const int STATUS_KEY_DELETED = unchecked((int)(0xC000017C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_LOG_SPACE"]/*' />
    [NativeTypeName("#define STATUS_NO_LOG_SPACE ((NTSTATUS)0xC000017DL)")]
    public const int STATUS_NO_LOG_SPACE = unchecked((int)(0xC000017D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_SIDS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_SIDS ((NTSTATUS)0xC000017EL)")]
    public const int STATUS_TOO_MANY_SIDS = unchecked((int)(0xC000017E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LM_CROSS_ENCRYPTION_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_LM_CROSS_ENCRYPTION_REQUIRED ((NTSTATUS)0xC000017FL)")]
    public const int STATUS_LM_CROSS_ENCRYPTION_REQUIRED = unchecked((int)(0xC000017F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KEY_HAS_CHILDREN"]/*' />
    [NativeTypeName("#define STATUS_KEY_HAS_CHILDREN ((NTSTATUS)0xC0000180L)")]
    public const int STATUS_KEY_HAS_CHILDREN = unchecked((int)(0xC0000180));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CHILD_MUST_BE_VOLATILE"]/*' />
    [NativeTypeName("#define STATUS_CHILD_MUST_BE_VOLATILE ((NTSTATUS)0xC0000181L)")]
    public const int STATUS_CHILD_MUST_BE_VOLATILE = unchecked((int)(0xC0000181));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_CONFIGURATION_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_CONFIGURATION_ERROR ((NTSTATUS)0xC0000182L)")]
    public const int STATUS_DEVICE_CONFIGURATION_ERROR = unchecked((int)(0xC0000182));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_INTERNAL_ERROR ((NTSTATUS)0xC0000183L)")]
    public const int STATUS_DRIVER_INTERNAL_ERROR = unchecked((int)(0xC0000183));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_DEVICE_STATE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_DEVICE_STATE ((NTSTATUS)0xC0000184L)")]
    public const int STATUS_INVALID_DEVICE_STATE = unchecked((int)(0xC0000184));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_DEVICE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_IO_DEVICE_ERROR ((NTSTATUS)0xC0000185L)")]
    public const int STATUS_IO_DEVICE_ERROR = unchecked((int)(0xC0000185));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_PROTOCOL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_PROTOCOL_ERROR ((NTSTATUS)0xC0000186L)")]
    public const int STATUS_DEVICE_PROTOCOL_ERROR = unchecked((int)(0xC0000186));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BACKUP_CONTROLLER"]/*' />
    [NativeTypeName("#define STATUS_BACKUP_CONTROLLER ((NTSTATUS)0xC0000187L)")]
    public const int STATUS_BACKUP_CONTROLLER = unchecked((int)(0xC0000187));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_FILE_FULL"]/*' />
    [NativeTypeName("#define STATUS_LOG_FILE_FULL ((NTSTATUS)0xC0000188L)")]
    public const int STATUS_LOG_FILE_FULL = unchecked((int)(0xC0000188));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_LATE"]/*' />
    [NativeTypeName("#define STATUS_TOO_LATE ((NTSTATUS)0xC0000189L)")]
    public const int STATUS_TOO_LATE = unchecked((int)(0xC0000189));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_TRUST_LSA_SECRET"]/*' />
    [NativeTypeName("#define STATUS_NO_TRUST_LSA_SECRET ((NTSTATUS)0xC000018AL)")]
    public const int STATUS_NO_TRUST_LSA_SECRET = unchecked((int)(0xC000018A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_TRUST_SAM_ACCOUNT"]/*' />
    [NativeTypeName("#define STATUS_NO_TRUST_SAM_ACCOUNT ((NTSTATUS)0xC000018BL)")]
    public const int STATUS_NO_TRUST_SAM_ACCOUNT = unchecked((int)(0xC000018B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRUSTED_DOMAIN_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_TRUSTED_DOMAIN_FAILURE ((NTSTATUS)0xC000018CL)")]
    public const int STATUS_TRUSTED_DOMAIN_FAILURE = unchecked((int)(0xC000018C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRUSTED_RELATIONSHIP_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_TRUSTED_RELATIONSHIP_FAILURE ((NTSTATUS)0xC000018DL)")]
    public const int STATUS_TRUSTED_RELATIONSHIP_FAILURE = unchecked((int)(0xC000018D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EVENTLOG_FILE_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_EVENTLOG_FILE_CORRUPT ((NTSTATUS)0xC000018EL)")]
    public const int STATUS_EVENTLOG_FILE_CORRUPT = unchecked((int)(0xC000018E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EVENTLOG_CANT_START"]/*' />
    [NativeTypeName("#define STATUS_EVENTLOG_CANT_START ((NTSTATUS)0xC000018FL)")]
    public const int STATUS_EVENTLOG_CANT_START = unchecked((int)(0xC000018F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRUST_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_TRUST_FAILURE ((NTSTATUS)0xC0000190L)")]
    public const int STATUS_TRUST_FAILURE = unchecked((int)(0xC0000190));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUTANT_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_MUTANT_LIMIT_EXCEEDED ((NTSTATUS)0xC0000191L)")]
    public const int STATUS_MUTANT_LIMIT_EXCEEDED = unchecked((int)(0xC0000191));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETLOGON_NOT_STARTED"]/*' />
    [NativeTypeName("#define STATUS_NETLOGON_NOT_STARTED ((NTSTATUS)0xC0000192L)")]
    public const int STATUS_NETLOGON_NOT_STARTED = unchecked((int)(0xC0000192));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCOUNT_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_ACCOUNT_EXPIRED ((NTSTATUS)0xC0000193L)")]
    public const int STATUS_ACCOUNT_EXPIRED = unchecked((int)(0xC0000193));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_POSSIBLE_DEADLOCK"]/*' />
    [NativeTypeName("#define STATUS_POSSIBLE_DEADLOCK ((NTSTATUS)0xC0000194L)")]
    public const int STATUS_POSSIBLE_DEADLOCK = unchecked((int)(0xC0000194));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_CREDENTIAL_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_CREDENTIAL_CONFLICT ((NTSTATUS)0xC0000195L)")]
    public const int STATUS_NETWORK_CREDENTIAL_CONFLICT = unchecked((int)(0xC0000195));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REMOTE_SESSION_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_REMOTE_SESSION_LIMIT ((NTSTATUS)0xC0000196L)")]
    public const int STATUS_REMOTE_SESSION_LIMIT = unchecked((int)(0xC0000196));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EVENTLOG_FILE_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_EVENTLOG_FILE_CHANGED ((NTSTATUS)0xC0000197L)")]
    public const int STATUS_EVENTLOG_FILE_CHANGED = unchecked((int)(0xC0000197));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT"]/*' />
    [NativeTypeName("#define STATUS_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT ((NTSTATUS)0xC0000198L)")]
    public const int STATUS_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = unchecked((int)(0xC0000198));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOLOGON_WORKSTATION_TRUST_ACCOUNT"]/*' />
    [NativeTypeName("#define STATUS_NOLOGON_WORKSTATION_TRUST_ACCOUNT ((NTSTATUS)0xC0000199L)")]
    public const int STATUS_NOLOGON_WORKSTATION_TRUST_ACCOUNT = unchecked((int)(0xC0000199));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOLOGON_SERVER_TRUST_ACCOUNT"]/*' />
    [NativeTypeName("#define STATUS_NOLOGON_SERVER_TRUST_ACCOUNT ((NTSTATUS)0xC000019AL)")]
    public const int STATUS_NOLOGON_SERVER_TRUST_ACCOUNT = unchecked((int)(0xC000019A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DOMAIN_TRUST_INCONSISTENT"]/*' />
    [NativeTypeName("#define STATUS_DOMAIN_TRUST_INCONSISTENT ((NTSTATUS)0xC000019BL)")]
    public const int STATUS_DOMAIN_TRUST_INCONSISTENT = unchecked((int)(0xC000019B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FS_DRIVER_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_FS_DRIVER_REQUIRED ((NTSTATUS)0xC000019CL)")]
    public const int STATUS_FS_DRIVER_REQUIRED = unchecked((int)(0xC000019C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_ALREADY_LOADED_AS_DLL"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_ALREADY_LOADED_AS_DLL ((NTSTATUS)0xC000019DL)")]
    public const int STATUS_IMAGE_ALREADY_LOADED_AS_DLL = unchecked((int)(0xC000019D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING"]/*' />
    [NativeTypeName("#define STATUS_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING ((NTSTATUS)0xC000019EL)")]
    public const int STATUS_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = unchecked((int)(0xC000019E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SHORT_NAMES_NOT_ENABLED_ON_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_SHORT_NAMES_NOT_ENABLED_ON_VOLUME ((NTSTATUS)0xC000019FL)")]
    public const int STATUS_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = unchecked((int)(0xC000019F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECURITY_STREAM_IS_INCONSISTENT"]/*' />
    [NativeTypeName("#define STATUS_SECURITY_STREAM_IS_INCONSISTENT ((NTSTATUS)0xC00001A0L)")]
    public const int STATUS_SECURITY_STREAM_IS_INCONSISTENT = unchecked((int)(0xC00001A0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LOCK_RANGE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LOCK_RANGE ((NTSTATUS)0xC00001A1L)")]
    public const int STATUS_INVALID_LOCK_RANGE = unchecked((int)(0xC00001A1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_ACE_CONDITION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_ACE_CONDITION ((NTSTATUS)0xC00001A2L)")]
    public const int STATUS_INVALID_ACE_CONDITION = unchecked((int)(0xC00001A2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_SUBSYSTEM_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_SUBSYSTEM_NOT_PRESENT ((NTSTATUS)0xC00001A3L)")]
    public const int STATUS_IMAGE_SUBSYSTEM_NOT_PRESENT = unchecked((int)(0xC00001A3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOTIFICATION_GUID_ALREADY_DEFINED"]/*' />
    [NativeTypeName("#define STATUS_NOTIFICATION_GUID_ALREADY_DEFINED ((NTSTATUS)0xC00001A4L)")]
    public const int STATUS_NOTIFICATION_GUID_ALREADY_DEFINED = unchecked((int)(0xC00001A4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_EXCEPTION_HANDLER"]/*' />
    [NativeTypeName("#define STATUS_INVALID_EXCEPTION_HANDLER ((NTSTATUS)0xC00001A5L)")]
    public const int STATUS_INVALID_EXCEPTION_HANDLER = unchecked((int)(0xC00001A5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DUPLICATE_PRIVILEGES"]/*' />
    [NativeTypeName("#define STATUS_DUPLICATE_PRIVILEGES ((NTSTATUS)0xC00001A6L)")]
    public const int STATUS_DUPLICATE_PRIVILEGES = unchecked((int)(0xC00001A6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_ALLOWED_ON_SYSTEM_FILE"]/*' />
    [NativeTypeName("#define STATUS_NOT_ALLOWED_ON_SYSTEM_FILE ((NTSTATUS)0xC00001A7L)")]
    public const int STATUS_NOT_ALLOWED_ON_SYSTEM_FILE = unchecked((int)(0xC00001A7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REPAIR_NEEDED"]/*' />
    [NativeTypeName("#define STATUS_REPAIR_NEEDED ((NTSTATUS)0xC00001A8L)")]
    public const int STATUS_REPAIR_NEEDED = unchecked((int)(0xC00001A8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUOTA_NOT_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_QUOTA_NOT_ENABLED ((NTSTATUS)0xC00001A9L)")]
    public const int STATUS_QUOTA_NOT_ENABLED = unchecked((int)(0xC00001A9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_APPLICATION_PACKAGE"]/*' />
    [NativeTypeName("#define STATUS_NO_APPLICATION_PACKAGE ((NTSTATUS)0xC00001AAL)")]
    public const int STATUS_NO_APPLICATION_PACKAGE = unchecked((int)(0xC00001AA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_METADATA_OPTIMIZATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_FILE_METADATA_OPTIMIZATION_IN_PROGRESS ((NTSTATUS)0xC00001ABL)")]
    public const int STATUS_FILE_METADATA_OPTIMIZATION_IN_PROGRESS = unchecked((int)(0xC00001AB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SAME_OBJECT"]/*' />
    [NativeTypeName("#define STATUS_NOT_SAME_OBJECT ((NTSTATUS)0xC00001ACL)")]
    public const int STATUS_NOT_SAME_OBJECT = unchecked((int)(0xC00001AC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FATAL_MEMORY_EXHAUSTION"]/*' />
    [NativeTypeName("#define STATUS_FATAL_MEMORY_EXHAUSTION ((NTSTATUS)0xC00001ADL)")]
    public const int STATUS_FATAL_MEMORY_EXHAUSTION = unchecked((int)(0xC00001AD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ERROR_PROCESS_NOT_IN_JOB"]/*' />
    [NativeTypeName("#define STATUS_ERROR_PROCESS_NOT_IN_JOB ((NTSTATUS)0xC00001AEL)")]
    public const int STATUS_ERROR_PROCESS_NOT_IN_JOB = unchecked((int)(0xC00001AE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CPU_SET_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CPU_SET_INVALID ((NTSTATUS)0xC00001AFL)")]
    public const int STATUS_CPU_SET_INVALID = unchecked((int)(0xC00001AF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_DEVICE_INVALID_DATA"]/*' />
    [NativeTypeName("#define STATUS_IO_DEVICE_INVALID_DATA ((NTSTATUS)0xC00001B0L)")]
    public const int STATUS_IO_DEVICE_INVALID_DATA = unchecked((int)(0xC00001B0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_UNALIGNED_WRITE"]/*' />
    [NativeTypeName("#define STATUS_IO_UNALIGNED_WRITE ((NTSTATUS)0xC00001B1L)")]
    public const int STATUS_IO_UNALIGNED_WRITE = unchecked((int)(0xC00001B1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WEAK_WHFBKEY_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_WEAK_WHFBKEY_BLOCKED ((NTSTATUS)0xC00001B3L)")]
    public const int STATUS_WEAK_WHFBKEY_BLOCKED = unchecked((int)(0xC00001B3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVER_TRANSPORT_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_SERVER_TRANSPORT_CONFLICT ((NTSTATUS)0xC00001B4L)")]
    public const int STATUS_SERVER_TRANSPORT_CONFLICT = unchecked((int)(0xC00001B4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CERTIFICATE_VALIDATION_PREFERENCE_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_CERTIFICATE_VALIDATION_PREFERENCE_CONFLICT ((NTSTATUS)0xC00001B5L)")]
    public const int STATUS_CERTIFICATE_VALIDATION_PREFERENCE_CONFLICT = unchecked((int)(0xC00001B5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_RESET_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_RESET_REQUIRED ((NTSTATUS)0x800001B6L)")]
    public const int STATUS_DEVICE_RESET_REQUIRED = unchecked((int)(0x800001B6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_OPEN_RESTRICTION"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_OPEN_RESTRICTION ((NTSTATUS)0xC0000201L)")]
    public const int STATUS_NETWORK_OPEN_RESTRICTION = unchecked((int)(0xC0000201));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_USER_SESSION_KEY"]/*' />
    [NativeTypeName("#define STATUS_NO_USER_SESSION_KEY ((NTSTATUS)0xC0000202L)")]
    public const int STATUS_NO_USER_SESSION_KEY = unchecked((int)(0xC0000202));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_USER_SESSION_DELETED"]/*' />
    [NativeTypeName("#define STATUS_USER_SESSION_DELETED ((NTSTATUS)0xC0000203L)")]
    public const int STATUS_USER_SESSION_DELETED = unchecked((int)(0xC0000203));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCE_LANG_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_RESOURCE_LANG_NOT_FOUND ((NTSTATUS)0xC0000204L)")]
    public const int STATUS_RESOURCE_LANG_NOT_FOUND = unchecked((int)(0xC0000204));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSUFF_SERVER_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_INSUFF_SERVER_RESOURCES ((NTSTATUS)0xC0000205L)")]
    public const int STATUS_INSUFF_SERVER_RESOURCES = unchecked((int)(0xC0000205));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_BUFFER_SIZE ((NTSTATUS)0xC0000206L)")]
    public const int STATUS_INVALID_BUFFER_SIZE = unchecked((int)(0xC0000206));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_ADDRESS_COMPONENT"]/*' />
    [NativeTypeName("#define STATUS_INVALID_ADDRESS_COMPONENT ((NTSTATUS)0xC0000207L)")]
    public const int STATUS_INVALID_ADDRESS_COMPONENT = unchecked((int)(0xC0000207));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_ADDRESS_WILDCARD"]/*' />
    [NativeTypeName("#define STATUS_INVALID_ADDRESS_WILDCARD ((NTSTATUS)0xC0000208L)")]
    public const int STATUS_INVALID_ADDRESS_WILDCARD = unchecked((int)(0xC0000208));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_ADDRESSES"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_ADDRESSES ((NTSTATUS)0xC0000209L)")]
    public const int STATUS_TOO_MANY_ADDRESSES = unchecked((int)(0xC0000209));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ADDRESS_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_ADDRESS_ALREADY_EXISTS ((NTSTATUS)0xC000020AL)")]
    public const int STATUS_ADDRESS_ALREADY_EXISTS = unchecked((int)(0xC000020A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ADDRESS_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_ADDRESS_CLOSED ((NTSTATUS)0xC000020BL)")]
    public const int STATUS_ADDRESS_CLOSED = unchecked((int)(0xC000020B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONNECTION_DISCONNECTED"]/*' />
    [NativeTypeName("#define STATUS_CONNECTION_DISCONNECTED ((NTSTATUS)0xC000020CL)")]
    public const int STATUS_CONNECTION_DISCONNECTED = unchecked((int)(0xC000020C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONNECTION_RESET"]/*' />
    [NativeTypeName("#define STATUS_CONNECTION_RESET ((NTSTATUS)0xC000020DL)")]
    public const int STATUS_CONNECTION_RESET = unchecked((int)(0xC000020D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_NODES"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_NODES ((NTSTATUS)0xC000020EL)")]
    public const int STATUS_TOO_MANY_NODES = unchecked((int)(0xC000020E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_ABORTED ((NTSTATUS)0xC000020FL)")]
    public const int STATUS_TRANSACTION_ABORTED = unchecked((int)(0xC000020F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_TIMED_OUT"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_TIMED_OUT ((NTSTATUS)0xC0000210L)")]
    public const int STATUS_TRANSACTION_TIMED_OUT = unchecked((int)(0xC0000210));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NO_RELEASE"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NO_RELEASE ((NTSTATUS)0xC0000211L)")]
    public const int STATUS_TRANSACTION_NO_RELEASE = unchecked((int)(0xC0000211));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NO_MATCH"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NO_MATCH ((NTSTATUS)0xC0000212L)")]
    public const int STATUS_TRANSACTION_NO_MATCH = unchecked((int)(0xC0000212));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_RESPONDED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_RESPONDED ((NTSTATUS)0xC0000213L)")]
    public const int STATUS_TRANSACTION_RESPONDED = unchecked((int)(0xC0000213));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_INVALID_ID"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_INVALID_ID ((NTSTATUS)0xC0000214L)")]
    public const int STATUS_TRANSACTION_INVALID_ID = unchecked((int)(0xC0000214));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_INVALID_TYPE"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_INVALID_TYPE ((NTSTATUS)0xC0000215L)")]
    public const int STATUS_TRANSACTION_INVALID_TYPE = unchecked((int)(0xC0000215));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SERVER_SESSION"]/*' />
    [NativeTypeName("#define STATUS_NOT_SERVER_SESSION ((NTSTATUS)0xC0000216L)")]
    public const int STATUS_NOT_SERVER_SESSION = unchecked((int)(0xC0000216));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_CLIENT_SESSION"]/*' />
    [NativeTypeName("#define STATUS_NOT_CLIENT_SESSION ((NTSTATUS)0xC0000217L)")]
    public const int STATUS_NOT_CLIENT_SESSION = unchecked((int)(0xC0000217));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_LOAD_REGISTRY_FILE"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_LOAD_REGISTRY_FILE ((NTSTATUS)0xC0000218L)")]
    public const int STATUS_CANNOT_LOAD_REGISTRY_FILE = unchecked((int)(0xC0000218));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEBUG_ATTACH_FAILED"]/*' />
    [NativeTypeName("#define STATUS_DEBUG_ATTACH_FAILED ((NTSTATUS)0xC0000219L)")]
    public const int STATUS_DEBUG_ATTACH_FAILED = unchecked((int)(0xC0000219));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_PROCESS_TERMINATED"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_PROCESS_TERMINATED ((NTSTATUS)0xC000021AL)")]
    public const int STATUS_SYSTEM_PROCESS_TERMINATED = unchecked((int)(0xC000021A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATA_NOT_ACCEPTED"]/*' />
    [NativeTypeName("#define STATUS_DATA_NOT_ACCEPTED ((NTSTATUS)0xC000021BL)")]
    public const int STATUS_DATA_NOT_ACCEPTED = unchecked((int)(0xC000021B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_BROWSER_SERVERS_FOUND"]/*' />
    [NativeTypeName("#define STATUS_NO_BROWSER_SERVERS_FOUND ((NTSTATUS)0xC000021CL)")]
    public const int STATUS_NO_BROWSER_SERVERS_FOUND = unchecked((int)(0xC000021C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VDM_HARD_ERROR"]/*' />
    [NativeTypeName("#define STATUS_VDM_HARD_ERROR ((NTSTATUS)0xC000021DL)")]
    public const int STATUS_VDM_HARD_ERROR = unchecked((int)(0xC000021D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_CANCEL_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_CANCEL_TIMEOUT ((NTSTATUS)0xC000021EL)")]
    public const int STATUS_DRIVER_CANCEL_TIMEOUT = unchecked((int)(0xC000021E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REPLY_MESSAGE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_REPLY_MESSAGE_MISMATCH ((NTSTATUS)0xC000021FL)")]
    public const int STATUS_REPLY_MESSAGE_MISMATCH = unchecked((int)(0xC000021F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MAPPED_ALIGNMENT"]/*' />
    [NativeTypeName("#define STATUS_MAPPED_ALIGNMENT ((NTSTATUS)0xC0000220L)")]
    public const int STATUS_MAPPED_ALIGNMENT = unchecked((int)(0xC0000220));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_CHECKSUM_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_CHECKSUM_MISMATCH ((NTSTATUS)0xC0000221L)")]
    public const int STATUS_IMAGE_CHECKSUM_MISMATCH = unchecked((int)(0xC0000221));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOST_WRITEBEHIND_DATA"]/*' />
    [NativeTypeName("#define STATUS_LOST_WRITEBEHIND_DATA ((NTSTATUS)0xC0000222L)")]
    public const int STATUS_LOST_WRITEBEHIND_DATA = unchecked((int)(0xC0000222));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIENT_SERVER_PARAMETERS_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CLIENT_SERVER_PARAMETERS_INVALID ((NTSTATUS)0xC0000223L)")]
    public const int STATUS_CLIENT_SERVER_PARAMETERS_INVALID = unchecked((int)(0xC0000223));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PASSWORD_MUST_CHANGE"]/*' />
    [NativeTypeName("#define STATUS_PASSWORD_MUST_CHANGE ((NTSTATUS)0xC0000224L)")]
    public const int STATUS_PASSWORD_MUST_CHANGE = unchecked((int)(0xC0000224));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_NOT_FOUND ((NTSTATUS)0xC0000225L)")]
    public const int STATUS_NOT_FOUND = unchecked((int)(0xC0000225));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_TINY_STREAM"]/*' />
    [NativeTypeName("#define STATUS_NOT_TINY_STREAM ((NTSTATUS)0xC0000226L)")]
    public const int STATUS_NOT_TINY_STREAM = unchecked((int)(0xC0000226));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RECOVERY_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_RECOVERY_FAILURE ((NTSTATUS)0xC0000227L)")]
    public const int STATUS_RECOVERY_FAILURE = unchecked((int)(0xC0000227));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STACK_OVERFLOW_READ"]/*' />
    [NativeTypeName("#define STATUS_STACK_OVERFLOW_READ ((NTSTATUS)0xC0000228L)")]
    public const int STATUS_STACK_OVERFLOW_READ = unchecked((int)(0xC0000228));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FAIL_CHECK"]/*' />
    [NativeTypeName("#define STATUS_FAIL_CHECK ((NTSTATUS)0xC0000229L)")]
    public const int STATUS_FAIL_CHECK = unchecked((int)(0xC0000229));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DUPLICATE_OBJECTID"]/*' />
    [NativeTypeName("#define STATUS_DUPLICATE_OBJECTID ((NTSTATUS)0xC000022AL)")]
    public const int STATUS_DUPLICATE_OBJECTID = unchecked((int)(0xC000022A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECTID_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_OBJECTID_EXISTS ((NTSTATUS)0xC000022BL)")]
    public const int STATUS_OBJECTID_EXISTS = unchecked((int)(0xC000022B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONVERT_TO_LARGE"]/*' />
    [NativeTypeName("#define STATUS_CONVERT_TO_LARGE ((NTSTATUS)0xC000022CL)")]
    public const int STATUS_CONVERT_TO_LARGE = unchecked((int)(0xC000022C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RETRY"]/*' />
    [NativeTypeName("#define STATUS_RETRY ((NTSTATUS)0xC000022DL)")]
    public const int STATUS_RETRY = unchecked((int)(0xC000022D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FOUND_OUT_OF_SCOPE"]/*' />
    [NativeTypeName("#define STATUS_FOUND_OUT_OF_SCOPE ((NTSTATUS)0xC000022EL)")]
    public const int STATUS_FOUND_OUT_OF_SCOPE = unchecked((int)(0xC000022E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALLOCATE_BUCKET"]/*' />
    [NativeTypeName("#define STATUS_ALLOCATE_BUCKET ((NTSTATUS)0xC000022FL)")]
    public const int STATUS_ALLOCATE_BUCKET = unchecked((int)(0xC000022F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROPSET_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PROPSET_NOT_FOUND ((NTSTATUS)0xC0000230L)")]
    public const int STATUS_PROPSET_NOT_FOUND = unchecked((int)(0xC0000230));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MARSHALL_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_MARSHALL_OVERFLOW ((NTSTATUS)0xC0000231L)")]
    public const int STATUS_MARSHALL_OVERFLOW = unchecked((int)(0xC0000231));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_VARIANT"]/*' />
    [NativeTypeName("#define STATUS_INVALID_VARIANT ((NTSTATUS)0xC0000232L)")]
    public const int STATUS_INVALID_VARIANT = unchecked((int)(0xC0000232));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DOMAIN_CONTROLLER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_DOMAIN_CONTROLLER_NOT_FOUND ((NTSTATUS)0xC0000233L)")]
    public const int STATUS_DOMAIN_CONTROLLER_NOT_FOUND = unchecked((int)(0xC0000233));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCOUNT_LOCKED_OUT"]/*' />
    [NativeTypeName("#define STATUS_ACCOUNT_LOCKED_OUT ((NTSTATUS)0xC0000234L)")]
    public const int STATUS_ACCOUNT_LOCKED_OUT = unchecked((int)(0xC0000234));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HANDLE_NOT_CLOSABLE"]/*' />
    [NativeTypeName("#define STATUS_HANDLE_NOT_CLOSABLE ((NTSTATUS)0xC0000235L)")]
    public const int STATUS_HANDLE_NOT_CLOSABLE = unchecked((int)(0xC0000235));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONNECTION_REFUSED"]/*' />
    [NativeTypeName("#define STATUS_CONNECTION_REFUSED ((NTSTATUS)0xC0000236L)")]
    public const int STATUS_CONNECTION_REFUSED = unchecked((int)(0xC0000236));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRACEFUL_DISCONNECT"]/*' />
    [NativeTypeName("#define STATUS_GRACEFUL_DISCONNECT ((NTSTATUS)0xC0000237L)")]
    public const int STATUS_GRACEFUL_DISCONNECT = unchecked((int)(0xC0000237));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ADDRESS_ALREADY_ASSOCIATED"]/*' />
    [NativeTypeName("#define STATUS_ADDRESS_ALREADY_ASSOCIATED ((NTSTATUS)0xC0000238L)")]
    public const int STATUS_ADDRESS_ALREADY_ASSOCIATED = unchecked((int)(0xC0000238));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ADDRESS_NOT_ASSOCIATED"]/*' />
    [NativeTypeName("#define STATUS_ADDRESS_NOT_ASSOCIATED ((NTSTATUS)0xC0000239L)")]
    public const int STATUS_ADDRESS_NOT_ASSOCIATED = unchecked((int)(0xC0000239));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONNECTION_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CONNECTION_INVALID ((NTSTATUS)0xC000023AL)")]
    public const int STATUS_CONNECTION_INVALID = unchecked((int)(0xC000023A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONNECTION_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_CONNECTION_ACTIVE ((NTSTATUS)0xC000023BL)")]
    public const int STATUS_CONNECTION_ACTIVE = unchecked((int)(0xC000023B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_UNREACHABLE"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_UNREACHABLE ((NTSTATUS)0xC000023CL)")]
    public const int STATUS_NETWORK_UNREACHABLE = unchecked((int)(0xC000023C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HOST_UNREACHABLE"]/*' />
    [NativeTypeName("#define STATUS_HOST_UNREACHABLE ((NTSTATUS)0xC000023DL)")]
    public const int STATUS_HOST_UNREACHABLE = unchecked((int)(0xC000023D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROTOCOL_UNREACHABLE"]/*' />
    [NativeTypeName("#define STATUS_PROTOCOL_UNREACHABLE ((NTSTATUS)0xC000023EL)")]
    public const int STATUS_PROTOCOL_UNREACHABLE = unchecked((int)(0xC000023E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_UNREACHABLE"]/*' />
    [NativeTypeName("#define STATUS_PORT_UNREACHABLE ((NTSTATUS)0xC000023FL)")]
    public const int STATUS_PORT_UNREACHABLE = unchecked((int)(0xC000023F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REQUEST_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_REQUEST_ABORTED ((NTSTATUS)0xC0000240L)")]
    public const int STATUS_REQUEST_ABORTED = unchecked((int)(0xC0000240));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONNECTION_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_CONNECTION_ABORTED ((NTSTATUS)0xC0000241L)")]
    public const int STATUS_CONNECTION_ABORTED = unchecked((int)(0xC0000241));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_COMPRESSION_BUFFER"]/*' />
    [NativeTypeName("#define STATUS_BAD_COMPRESSION_BUFFER ((NTSTATUS)0xC0000242L)")]
    public const int STATUS_BAD_COMPRESSION_BUFFER = unchecked((int)(0xC0000242));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_USER_MAPPED_FILE"]/*' />
    [NativeTypeName("#define STATUS_USER_MAPPED_FILE ((NTSTATUS)0xC0000243L)")]
    public const int STATUS_USER_MAPPED_FILE = unchecked((int)(0xC0000243));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AUDIT_FAILED"]/*' />
    [NativeTypeName("#define STATUS_AUDIT_FAILED ((NTSTATUS)0xC0000244L)")]
    public const int STATUS_AUDIT_FAILED = unchecked((int)(0xC0000244));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TIMER_RESOLUTION_NOT_SET"]/*' />
    [NativeTypeName("#define STATUS_TIMER_RESOLUTION_NOT_SET ((NTSTATUS)0xC0000245L)")]
    public const int STATUS_TIMER_RESOLUTION_NOT_SET = unchecked((int)(0xC0000245));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONNECTION_COUNT_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_CONNECTION_COUNT_LIMIT ((NTSTATUS)0xC0000246L)")]
    public const int STATUS_CONNECTION_COUNT_LIMIT = unchecked((int)(0xC0000246));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOGIN_TIME_RESTRICTION"]/*' />
    [NativeTypeName("#define STATUS_LOGIN_TIME_RESTRICTION ((NTSTATUS)0xC0000247L)")]
    public const int STATUS_LOGIN_TIME_RESTRICTION = unchecked((int)(0xC0000247));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOGIN_WKSTA_RESTRICTION"]/*' />
    [NativeTypeName("#define STATUS_LOGIN_WKSTA_RESTRICTION ((NTSTATUS)0xC0000248L)")]
    public const int STATUS_LOGIN_WKSTA_RESTRICTION = unchecked((int)(0xC0000248));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_MP_UP_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_MP_UP_MISMATCH ((NTSTATUS)0xC0000249L)")]
    public const int STATUS_IMAGE_MP_UP_MISMATCH = unchecked((int)(0xC0000249));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSUFFICIENT_LOGON_INFO"]/*' />
    [NativeTypeName("#define STATUS_INSUFFICIENT_LOGON_INFO ((NTSTATUS)0xC0000250L)")]
    public const int STATUS_INSUFFICIENT_LOGON_INFO = unchecked((int)(0xC0000250));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_DLL_ENTRYPOINT"]/*' />
    [NativeTypeName("#define STATUS_BAD_DLL_ENTRYPOINT ((NTSTATUS)0xC0000251L)")]
    public const int STATUS_BAD_DLL_ENTRYPOINT = unchecked((int)(0xC0000251));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_SERVICE_ENTRYPOINT"]/*' />
    [NativeTypeName("#define STATUS_BAD_SERVICE_ENTRYPOINT ((NTSTATUS)0xC0000252L)")]
    public const int STATUS_BAD_SERVICE_ENTRYPOINT = unchecked((int)(0xC0000252));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LPC_REPLY_LOST"]/*' />
    [NativeTypeName("#define STATUS_LPC_REPLY_LOST ((NTSTATUS)0xC0000253L)")]
    public const int STATUS_LPC_REPLY_LOST = unchecked((int)(0xC0000253));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IP_ADDRESS_CONFLICT1"]/*' />
    [NativeTypeName("#define STATUS_IP_ADDRESS_CONFLICT1 ((NTSTATUS)0xC0000254L)")]
    public const int STATUS_IP_ADDRESS_CONFLICT1 = unchecked((int)(0xC0000254));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IP_ADDRESS_CONFLICT2"]/*' />
    [NativeTypeName("#define STATUS_IP_ADDRESS_CONFLICT2 ((NTSTATUS)0xC0000255L)")]
    public const int STATUS_IP_ADDRESS_CONFLICT2 = unchecked((int)(0xC0000255));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REGISTRY_QUOTA_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_REGISTRY_QUOTA_LIMIT ((NTSTATUS)0xC0000256L)")]
    public const int STATUS_REGISTRY_QUOTA_LIMIT = unchecked((int)(0xC0000256));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PATH_NOT_COVERED"]/*' />
    [NativeTypeName("#define STATUS_PATH_NOT_COVERED ((NTSTATUS)0xC0000257L)")]
    public const int STATUS_PATH_NOT_COVERED = unchecked((int)(0xC0000257));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_CALLBACK_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_NO_CALLBACK_ACTIVE ((NTSTATUS)0xC0000258L)")]
    public const int STATUS_NO_CALLBACK_ACTIVE = unchecked((int)(0xC0000258));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LICENSE_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_LICENSE_QUOTA_EXCEEDED ((NTSTATUS)0xC0000259L)")]
    public const int STATUS_LICENSE_QUOTA_EXCEEDED = unchecked((int)(0xC0000259));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PWD_TOO_SHORT"]/*' />
    [NativeTypeName("#define STATUS_PWD_TOO_SHORT ((NTSTATUS)0xC000025AL)")]
    public const int STATUS_PWD_TOO_SHORT = unchecked((int)(0xC000025A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PWD_TOO_RECENT"]/*' />
    [NativeTypeName("#define STATUS_PWD_TOO_RECENT ((NTSTATUS)0xC000025BL)")]
    public const int STATUS_PWD_TOO_RECENT = unchecked((int)(0xC000025B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PWD_HISTORY_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_PWD_HISTORY_CONFLICT ((NTSTATUS)0xC000025CL)")]
    public const int STATUS_PWD_HISTORY_CONFLICT = unchecked((int)(0xC000025C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLUGPLAY_NO_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_PLUGPLAY_NO_DEVICE ((NTSTATUS)0xC000025EL)")]
    public const int STATUS_PLUGPLAY_NO_DEVICE = unchecked((int)(0xC000025E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNSUPPORTED_COMPRESSION"]/*' />
    [NativeTypeName("#define STATUS_UNSUPPORTED_COMPRESSION ((NTSTATUS)0xC000025FL)")]
    public const int STATUS_UNSUPPORTED_COMPRESSION = unchecked((int)(0xC000025F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_HW_PROFILE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_HW_PROFILE ((NTSTATUS)0xC0000260L)")]
    public const int STATUS_INVALID_HW_PROFILE = unchecked((int)(0xC0000260));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PLUGPLAY_DEVICE_PATH"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PLUGPLAY_DEVICE_PATH ((NTSTATUS)0xC0000261L)")]
    public const int STATUS_INVALID_PLUGPLAY_DEVICE_PATH = unchecked((int)(0xC0000261));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_ORDINAL_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_ORDINAL_NOT_FOUND ((NTSTATUS)0xC0000262L)")]
    public const int STATUS_DRIVER_ORDINAL_NOT_FOUND = unchecked((int)(0xC0000262));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_ENTRYPOINT_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_ENTRYPOINT_NOT_FOUND ((NTSTATUS)0xC0000263L)")]
    public const int STATUS_DRIVER_ENTRYPOINT_NOT_FOUND = unchecked((int)(0xC0000263));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCE_NOT_OWNED"]/*' />
    [NativeTypeName("#define STATUS_RESOURCE_NOT_OWNED ((NTSTATUS)0xC0000264L)")]
    public const int STATUS_RESOURCE_NOT_OWNED = unchecked((int)(0xC0000264));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_LINKS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_LINKS ((NTSTATUS)0xC0000265L)")]
    public const int STATUS_TOO_MANY_LINKS = unchecked((int)(0xC0000265));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUOTA_LIST_INCONSISTENT"]/*' />
    [NativeTypeName("#define STATUS_QUOTA_LIST_INCONSISTENT ((NTSTATUS)0xC0000266L)")]
    public const int STATUS_QUOTA_LIST_INCONSISTENT = unchecked((int)(0xC0000266));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_IS_OFFLINE"]/*' />
    [NativeTypeName("#define STATUS_FILE_IS_OFFLINE ((NTSTATUS)0xC0000267L)")]
    public const int STATUS_FILE_IS_OFFLINE = unchecked((int)(0xC0000267));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EVALUATION_EXPIRATION"]/*' />
    [NativeTypeName("#define STATUS_EVALUATION_EXPIRATION ((NTSTATUS)0xC0000268L)")]
    public const int STATUS_EVALUATION_EXPIRATION = unchecked((int)(0xC0000268));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ILLEGAL_DLL_RELOCATION"]/*' />
    [NativeTypeName("#define STATUS_ILLEGAL_DLL_RELOCATION ((NTSTATUS)0xC0000269L)")]
    public const int STATUS_ILLEGAL_DLL_RELOCATION = unchecked((int)(0xC0000269));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LICENSE_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_LICENSE_VIOLATION ((NTSTATUS)0xC000026AL)")]
    public const int STATUS_LICENSE_VIOLATION = unchecked((int)(0xC000026A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DLL_INIT_FAILED_LOGOFF"]/*' />
    [NativeTypeName("#define STATUS_DLL_INIT_FAILED_LOGOFF ((NTSTATUS)0xC000026BL)")]
    public const int STATUS_DLL_INIT_FAILED_LOGOFF = unchecked((int)(0xC000026B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_UNABLE_TO_LOAD"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_UNABLE_TO_LOAD ((NTSTATUS)0xC000026CL)")]
    public const int STATUS_DRIVER_UNABLE_TO_LOAD = unchecked((int)(0xC000026C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DFS_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_DFS_UNAVAILABLE ((NTSTATUS)0xC000026DL)")]
    public const int STATUS_DFS_UNAVAILABLE = unchecked((int)(0xC000026D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_DISMOUNTED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_DISMOUNTED ((NTSTATUS)0xC000026EL)")]
    public const int STATUS_VOLUME_DISMOUNTED = unchecked((int)(0xC000026E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_WX86_INTERNAL_ERROR ((NTSTATUS)0xC000026FL)")]
    public const int STATUS_WX86_INTERNAL_ERROR = unchecked((int)(0xC000026F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WX86_FLOAT_STACK_CHECK"]/*' />
    [NativeTypeName("#define STATUS_WX86_FLOAT_STACK_CHECK ((NTSTATUS)0xC0000270L)")]
    public const int STATUS_WX86_FLOAT_STACK_CHECK = unchecked((int)(0xC0000270));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VALIDATE_CONTINUE"]/*' />
    [NativeTypeName("#define STATUS_VALIDATE_CONTINUE ((NTSTATUS)0xC0000271L)")]
    public const int STATUS_VALIDATE_CONTINUE = unchecked((int)(0xC0000271));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_MATCH"]/*' />
    [NativeTypeName("#define STATUS_NO_MATCH ((NTSTATUS)0xC0000272L)")]
    public const int STATUS_NO_MATCH = unchecked((int)(0xC0000272));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_MORE_MATCHES"]/*' />
    [NativeTypeName("#define STATUS_NO_MORE_MATCHES ((NTSTATUS)0xC0000273L)")]
    public const int STATUS_NO_MORE_MATCHES = unchecked((int)(0xC0000273));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_A_REPARSE_POINT"]/*' />
    [NativeTypeName("#define STATUS_NOT_A_REPARSE_POINT ((NTSTATUS)0xC0000275L)")]
    public const int STATUS_NOT_A_REPARSE_POINT = unchecked((int)(0xC0000275));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_REPARSE_TAG_INVALID"]/*' />
    [NativeTypeName("#define STATUS_IO_REPARSE_TAG_INVALID ((NTSTATUS)0xC0000276L)")]
    public const int STATUS_IO_REPARSE_TAG_INVALID = unchecked((int)(0xC0000276));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_REPARSE_TAG_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_IO_REPARSE_TAG_MISMATCH ((NTSTATUS)0xC0000277L)")]
    public const int STATUS_IO_REPARSE_TAG_MISMATCH = unchecked((int)(0xC0000277));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_REPARSE_DATA_INVALID"]/*' />
    [NativeTypeName("#define STATUS_IO_REPARSE_DATA_INVALID ((NTSTATUS)0xC0000278L)")]
    public const int STATUS_IO_REPARSE_DATA_INVALID = unchecked((int)(0xC0000278));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_REPARSE_TAG_NOT_HANDLED"]/*' />
    [NativeTypeName("#define STATUS_IO_REPARSE_TAG_NOT_HANDLED ((NTSTATUS)0xC0000279L)")]
    public const int STATUS_IO_REPARSE_TAG_NOT_HANDLED = unchecked((int)(0xC0000279));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PWD_TOO_LONG"]/*' />
    [NativeTypeName("#define STATUS_PWD_TOO_LONG ((NTSTATUS)0xC000027AL)")]
    public const int STATUS_PWD_TOO_LONG = unchecked((int)(0xC000027A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STOWED_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_STOWED_EXCEPTION ((NTSTATUS)0xC000027BL)")]
    public const int STATUS_STOWED_EXCEPTION = unchecked((int)(0xC000027B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONTEXT_STOWED_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_CONTEXT_STOWED_EXCEPTION ((NTSTATUS)0xC000027CL)")]
    public const int STATUS_CONTEXT_STOWED_EXCEPTION = unchecked((int)(0xC000027C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REPARSE_POINT_NOT_RESOLVED"]/*' />
    [NativeTypeName("#define STATUS_REPARSE_POINT_NOT_RESOLVED ((NTSTATUS)0xC0000280L)")]
    public const int STATUS_REPARSE_POINT_NOT_RESOLVED = unchecked((int)(0xC0000280));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIRECTORY_IS_A_REPARSE_POINT"]/*' />
    [NativeTypeName("#define STATUS_DIRECTORY_IS_A_REPARSE_POINT ((NTSTATUS)0xC0000281L)")]
    public const int STATUS_DIRECTORY_IS_A_REPARSE_POINT = unchecked((int)(0xC0000281));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RANGE_LIST_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_RANGE_LIST_CONFLICT ((NTSTATUS)0xC0000282L)")]
    public const int STATUS_RANGE_LIST_CONFLICT = unchecked((int)(0xC0000282));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SOURCE_ELEMENT_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_SOURCE_ELEMENT_EMPTY ((NTSTATUS)0xC0000283L)")]
    public const int STATUS_SOURCE_ELEMENT_EMPTY = unchecked((int)(0xC0000283));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DESTINATION_ELEMENT_FULL"]/*' />
    [NativeTypeName("#define STATUS_DESTINATION_ELEMENT_FULL ((NTSTATUS)0xC0000284L)")]
    public const int STATUS_DESTINATION_ELEMENT_FULL = unchecked((int)(0xC0000284));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ILLEGAL_ELEMENT_ADDRESS"]/*' />
    [NativeTypeName("#define STATUS_ILLEGAL_ELEMENT_ADDRESS ((NTSTATUS)0xC0000285L)")]
    public const int STATUS_ILLEGAL_ELEMENT_ADDRESS = unchecked((int)(0xC0000285));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MAGAZINE_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_MAGAZINE_NOT_PRESENT ((NTSTATUS)0xC0000286L)")]
    public const int STATUS_MAGAZINE_NOT_PRESENT = unchecked((int)(0xC0000286));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REINITIALIZATION_NEEDED"]/*' />
    [NativeTypeName("#define STATUS_REINITIALIZATION_NEEDED ((NTSTATUS)0xC0000287L)")]
    public const int STATUS_REINITIALIZATION_NEEDED = unchecked((int)(0xC0000287));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_REQUIRES_CLEANING"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_REQUIRES_CLEANING ((NTSTATUS)0x80000288L)")]
    public const int STATUS_DEVICE_REQUIRES_CLEANING = unchecked((int)(0x80000288));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_DOOR_OPEN"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_DOOR_OPEN ((NTSTATUS)0x80000289L)")]
    public const int STATUS_DEVICE_DOOR_OPEN = unchecked((int)(0x80000289));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCRYPTION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_ENCRYPTION_FAILED ((NTSTATUS)0xC000028AL)")]
    public const int STATUS_ENCRYPTION_FAILED = unchecked((int)(0xC000028A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DECRYPTION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_DECRYPTION_FAILED ((NTSTATUS)0xC000028BL)")]
    public const int STATUS_DECRYPTION_FAILED = unchecked((int)(0xC000028B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RANGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_RANGE_NOT_FOUND ((NTSTATUS)0xC000028CL)")]
    public const int STATUS_RANGE_NOT_FOUND = unchecked((int)(0xC000028C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_RECOVERY_POLICY"]/*' />
    [NativeTypeName("#define STATUS_NO_RECOVERY_POLICY ((NTSTATUS)0xC000028DL)")]
    public const int STATUS_NO_RECOVERY_POLICY = unchecked((int)(0xC000028D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_EFS"]/*' />
    [NativeTypeName("#define STATUS_NO_EFS ((NTSTATUS)0xC000028EL)")]
    public const int STATUS_NO_EFS = unchecked((int)(0xC000028E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WRONG_EFS"]/*' />
    [NativeTypeName("#define STATUS_WRONG_EFS ((NTSTATUS)0xC000028FL)")]
    public const int STATUS_WRONG_EFS = unchecked((int)(0xC000028F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_USER_KEYS"]/*' />
    [NativeTypeName("#define STATUS_NO_USER_KEYS ((NTSTATUS)0xC0000290L)")]
    public const int STATUS_NO_USER_KEYS = unchecked((int)(0xC0000290));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_NOT_ENCRYPTED"]/*' />
    [NativeTypeName("#define STATUS_FILE_NOT_ENCRYPTED ((NTSTATUS)0xC0000291L)")]
    public const int STATUS_FILE_NOT_ENCRYPTED = unchecked((int)(0xC0000291));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_EXPORT_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_NOT_EXPORT_FORMAT ((NTSTATUS)0xC0000292L)")]
    public const int STATUS_NOT_EXPORT_FORMAT = unchecked((int)(0xC0000292));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_ENCRYPTED"]/*' />
    [NativeTypeName("#define STATUS_FILE_ENCRYPTED ((NTSTATUS)0xC0000293L)")]
    public const int STATUS_FILE_ENCRYPTED = unchecked((int)(0xC0000293));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAKE_SYSTEM"]/*' />
    [NativeTypeName("#define STATUS_WAKE_SYSTEM ((NTSTATUS)0x40000294L)")]
    public const int STATUS_WAKE_SYSTEM = ((int)(0x40000294));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_GUID_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_WMI_GUID_NOT_FOUND ((NTSTATUS)0xC0000295L)")]
    public const int STATUS_WMI_GUID_NOT_FOUND = unchecked((int)(0xC0000295));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_INSTANCE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_WMI_INSTANCE_NOT_FOUND ((NTSTATUS)0xC0000296L)")]
    public const int STATUS_WMI_INSTANCE_NOT_FOUND = unchecked((int)(0xC0000296));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_ITEMID_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_WMI_ITEMID_NOT_FOUND ((NTSTATUS)0xC0000297L)")]
    public const int STATUS_WMI_ITEMID_NOT_FOUND = unchecked((int)(0xC0000297));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_TRY_AGAIN"]/*' />
    [NativeTypeName("#define STATUS_WMI_TRY_AGAIN ((NTSTATUS)0xC0000298L)")]
    public const int STATUS_WMI_TRY_AGAIN = unchecked((int)(0xC0000298));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SHARED_POLICY"]/*' />
    [NativeTypeName("#define STATUS_SHARED_POLICY ((NTSTATUS)0xC0000299L)")]
    public const int STATUS_SHARED_POLICY = unchecked((int)(0xC0000299));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_POLICY_OBJECT_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_POLICY_OBJECT_NOT_FOUND ((NTSTATUS)0xC000029AL)")]
    public const int STATUS_POLICY_OBJECT_NOT_FOUND = unchecked((int)(0xC000029A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_POLICY_ONLY_IN_DS"]/*' />
    [NativeTypeName("#define STATUS_POLICY_ONLY_IN_DS ((NTSTATUS)0xC000029BL)")]
    public const int STATUS_POLICY_ONLY_IN_DS = unchecked((int)(0xC000029B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_NOT_UPGRADED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_NOT_UPGRADED ((NTSTATUS)0xC000029CL)")]
    public const int STATUS_VOLUME_NOT_UPGRADED = unchecked((int)(0xC000029C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REMOTE_STORAGE_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_REMOTE_STORAGE_NOT_ACTIVE ((NTSTATUS)0xC000029DL)")]
    public const int STATUS_REMOTE_STORAGE_NOT_ACTIVE = unchecked((int)(0xC000029D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REMOTE_STORAGE_MEDIA_ERROR"]/*' />
    [NativeTypeName("#define STATUS_REMOTE_STORAGE_MEDIA_ERROR ((NTSTATUS)0xC000029EL)")]
    public const int STATUS_REMOTE_STORAGE_MEDIA_ERROR = unchecked((int)(0xC000029E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_TRACKING_SERVICE"]/*' />
    [NativeTypeName("#define STATUS_NO_TRACKING_SERVICE ((NTSTATUS)0xC000029FL)")]
    public const int STATUS_NO_TRACKING_SERVICE = unchecked((int)(0xC000029F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVER_SID_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_SERVER_SID_MISMATCH ((NTSTATUS)0xC00002A0L)")]
    public const int STATUS_SERVER_SID_MISMATCH = unchecked((int)(0xC00002A0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_NO_ATTRIBUTE_OR_VALUE"]/*' />
    [NativeTypeName("#define STATUS_DS_NO_ATTRIBUTE_OR_VALUE ((NTSTATUS)0xC00002A1L)")]
    public const int STATUS_DS_NO_ATTRIBUTE_OR_VALUE = unchecked((int)(0xC00002A1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_INVALID_ATTRIBUTE_SYNTAX"]/*' />
    [NativeTypeName("#define STATUS_DS_INVALID_ATTRIBUTE_SYNTAX ((NTSTATUS)0xC00002A2L)")]
    public const int STATUS_DS_INVALID_ATTRIBUTE_SYNTAX = unchecked((int)(0xC00002A2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_ATTRIBUTE_TYPE_UNDEFINED"]/*' />
    [NativeTypeName("#define STATUS_DS_ATTRIBUTE_TYPE_UNDEFINED ((NTSTATUS)0xC00002A3L)")]
    public const int STATUS_DS_ATTRIBUTE_TYPE_UNDEFINED = unchecked((int)(0xC00002A3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_ATTRIBUTE_OR_VALUE_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_DS_ATTRIBUTE_OR_VALUE_EXISTS ((NTSTATUS)0xC00002A4L)")]
    public const int STATUS_DS_ATTRIBUTE_OR_VALUE_EXISTS = unchecked((int)(0xC00002A4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_BUSY"]/*' />
    [NativeTypeName("#define STATUS_DS_BUSY ((NTSTATUS)0xC00002A5L)")]
    public const int STATUS_DS_BUSY = unchecked((int)(0xC00002A5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_DS_UNAVAILABLE ((NTSTATUS)0xC00002A6L)")]
    public const int STATUS_DS_UNAVAILABLE = unchecked((int)(0xC00002A6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_NO_RIDS_ALLOCATED"]/*' />
    [NativeTypeName("#define STATUS_DS_NO_RIDS_ALLOCATED ((NTSTATUS)0xC00002A7L)")]
    public const int STATUS_DS_NO_RIDS_ALLOCATED = unchecked((int)(0xC00002A7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_NO_MORE_RIDS"]/*' />
    [NativeTypeName("#define STATUS_DS_NO_MORE_RIDS ((NTSTATUS)0xC00002A8L)")]
    public const int STATUS_DS_NO_MORE_RIDS = unchecked((int)(0xC00002A8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_INCORRECT_ROLE_OWNER"]/*' />
    [NativeTypeName("#define STATUS_DS_INCORRECT_ROLE_OWNER ((NTSTATUS)0xC00002A9L)")]
    public const int STATUS_DS_INCORRECT_ROLE_OWNER = unchecked((int)(0xC00002A9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_RIDMGR_INIT_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DS_RIDMGR_INIT_ERROR ((NTSTATUS)0xC00002AAL)")]
    public const int STATUS_DS_RIDMGR_INIT_ERROR = unchecked((int)(0xC00002AA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_OBJ_CLASS_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_DS_OBJ_CLASS_VIOLATION ((NTSTATUS)0xC00002ABL)")]
    public const int STATUS_DS_OBJ_CLASS_VIOLATION = unchecked((int)(0xC00002AB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_CANT_ON_NON_LEAF"]/*' />
    [NativeTypeName("#define STATUS_DS_CANT_ON_NON_LEAF ((NTSTATUS)0xC00002ACL)")]
    public const int STATUS_DS_CANT_ON_NON_LEAF = unchecked((int)(0xC00002AC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_CANT_ON_RDN"]/*' />
    [NativeTypeName("#define STATUS_DS_CANT_ON_RDN ((NTSTATUS)0xC00002ADL)")]
    public const int STATUS_DS_CANT_ON_RDN = unchecked((int)(0xC00002AD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_CANT_MOD_OBJ_CLASS"]/*' />
    [NativeTypeName("#define STATUS_DS_CANT_MOD_OBJ_CLASS ((NTSTATUS)0xC00002AEL)")]
    public const int STATUS_DS_CANT_MOD_OBJ_CLASS = unchecked((int)(0xC00002AE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_CROSS_DOM_MOVE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_DS_CROSS_DOM_MOVE_FAILED ((NTSTATUS)0xC00002AFL)")]
    public const int STATUS_DS_CROSS_DOM_MOVE_FAILED = unchecked((int)(0xC00002AF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_GC_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_DS_GC_NOT_AVAILABLE ((NTSTATUS)0xC00002B0L)")]
    public const int STATUS_DS_GC_NOT_AVAILABLE = unchecked((int)(0xC00002B0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIRECTORY_SERVICE_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_DIRECTORY_SERVICE_REQUIRED ((NTSTATUS)0xC00002B1L)")]
    public const int STATUS_DIRECTORY_SERVICE_REQUIRED = unchecked((int)(0xC00002B1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REPARSE_ATTRIBUTE_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_REPARSE_ATTRIBUTE_CONFLICT ((NTSTATUS)0xC00002B2L)")]
    public const int STATUS_REPARSE_ATTRIBUTE_CONFLICT = unchecked((int)(0xC00002B2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_ENABLE_DENY_ONLY"]/*' />
    [NativeTypeName("#define STATUS_CANT_ENABLE_DENY_ONLY ((NTSTATUS)0xC00002B3L)")]
    public const int STATUS_CANT_ENABLE_DENY_ONLY = unchecked((int)(0xC00002B3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_REMOVED"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_REMOVED ((NTSTATUS)0xC00002B6L)")]
    public const int STATUS_DEVICE_REMOVED = unchecked((int)(0xC00002B6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_JOURNAL_DELETE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_JOURNAL_DELETE_IN_PROGRESS ((NTSTATUS)0xC00002B7L)")]
    public const int STATUS_JOURNAL_DELETE_IN_PROGRESS = unchecked((int)(0xC00002B7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_JOURNAL_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_JOURNAL_NOT_ACTIVE ((NTSTATUS)0xC00002B8L)")]
    public const int STATUS_JOURNAL_NOT_ACTIVE = unchecked((int)(0xC00002B8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOINTERFACE"]/*' />
    [NativeTypeName("#define STATUS_NOINTERFACE ((NTSTATUS)0xC00002B9L)")]
    public const int STATUS_NOINTERFACE = unchecked((int)(0xC00002B9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_RIDMGR_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_DS_RIDMGR_DISABLED ((NTSTATUS)0xC00002BAL)")]
    public const int STATUS_DS_RIDMGR_DISABLED = unchecked((int)(0xC00002BA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_ADMIN_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_DS_ADMIN_LIMIT_EXCEEDED ((NTSTATUS)0xC00002C1L)")]
    public const int STATUS_DS_ADMIN_LIMIT_EXCEEDED = unchecked((int)(0xC00002C1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_FAILED_SLEEP"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_FAILED_SLEEP ((NTSTATUS)0xC00002C2L)")]
    public const int STATUS_DRIVER_FAILED_SLEEP = unchecked((int)(0xC00002C2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUTUAL_AUTHENTICATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_MUTUAL_AUTHENTICATION_FAILED ((NTSTATUS)0xC00002C3L)")]
    public const int STATUS_MUTUAL_AUTHENTICATION_FAILED = unchecked((int)(0xC00002C3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CORRUPT_SYSTEM_FILE"]/*' />
    [NativeTypeName("#define STATUS_CORRUPT_SYSTEM_FILE ((NTSTATUS)0xC00002C4L)")]
    public const int STATUS_CORRUPT_SYSTEM_FILE = unchecked((int)(0xC00002C4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATATYPE_MISALIGNMENT_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DATATYPE_MISALIGNMENT_ERROR ((NTSTATUS)0xC00002C5L)")]
    public const int STATUS_DATATYPE_MISALIGNMENT_ERROR = unchecked((int)(0xC00002C5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_READ_ONLY"]/*' />
    [NativeTypeName("#define STATUS_WMI_READ_ONLY ((NTSTATUS)0xC00002C6L)")]
    public const int STATUS_WMI_READ_ONLY = unchecked((int)(0xC00002C6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_SET_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_WMI_SET_FAILURE ((NTSTATUS)0xC00002C7L)")]
    public const int STATUS_WMI_SET_FAILURE = unchecked((int)(0xC00002C7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COMMITMENT_MINIMUM"]/*' />
    [NativeTypeName("#define STATUS_COMMITMENT_MINIMUM ((NTSTATUS)0xC00002C8L)")]
    public const int STATUS_COMMITMENT_MINIMUM = unchecked((int)(0xC00002C8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSPORT_FULL"]/*' />
    [NativeTypeName("#define STATUS_TRANSPORT_FULL ((NTSTATUS)0xC00002CAL)")]
    public const int STATUS_TRANSPORT_FULL = unchecked((int)(0xC00002CA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_SAM_INIT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_DS_SAM_INIT_FAILURE ((NTSTATUS)0xC00002CBL)")]
    public const int STATUS_DS_SAM_INIT_FAILURE = unchecked((int)(0xC00002CB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ONLY_IF_CONNECTED"]/*' />
    [NativeTypeName("#define STATUS_ONLY_IF_CONNECTED ((NTSTATUS)0xC00002CCL)")]
    public const int STATUS_ONLY_IF_CONNECTED = unchecked((int)(0xC00002CC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_SENSITIVE_GROUP_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_DS_SENSITIVE_GROUP_VIOLATION ((NTSTATUS)0xC00002CDL)")]
    public const int STATUS_DS_SENSITIVE_GROUP_VIOLATION = unchecked((int)(0xC00002CD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_RESTART_ENUMERATION"]/*' />
    [NativeTypeName("#define STATUS_PNP_RESTART_ENUMERATION ((NTSTATUS)0xC00002CEL)")]
    public const int STATUS_PNP_RESTART_ENUMERATION = unchecked((int)(0xC00002CE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_JOURNAL_ENTRY_DELETED"]/*' />
    [NativeTypeName("#define STATUS_JOURNAL_ENTRY_DELETED ((NTSTATUS)0xC00002CFL)")]
    public const int STATUS_JOURNAL_ENTRY_DELETED = unchecked((int)(0xC00002CF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_CANT_MOD_PRIMARYGROUPID"]/*' />
    [NativeTypeName("#define STATUS_DS_CANT_MOD_PRIMARYGROUPID ((NTSTATUS)0xC00002D0L)")]
    public const int STATUS_DS_CANT_MOD_PRIMARYGROUPID = unchecked((int)(0xC00002D0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_IMAGE_BAD_SIGNATURE"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_IMAGE_BAD_SIGNATURE ((NTSTATUS)0xC00002D1L)")]
    public const int STATUS_SYSTEM_IMAGE_BAD_SIGNATURE = unchecked((int)(0xC00002D1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_PNP_REBOOT_REQUIRED ((NTSTATUS)0xC00002D2L)")]
    public const int STATUS_PNP_REBOOT_REQUIRED = unchecked((int)(0xC00002D2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_POWER_STATE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_POWER_STATE_INVALID ((NTSTATUS)0xC00002D3L)")]
    public const int STATUS_POWER_STATE_INVALID = unchecked((int)(0xC00002D3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_INVALID_GROUP_TYPE"]/*' />
    [NativeTypeName("#define STATUS_DS_INVALID_GROUP_TYPE ((NTSTATUS)0xC00002D4L)")]
    public const int STATUS_DS_INVALID_GROUP_TYPE = unchecked((int)(0xC00002D4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN"]/*' />
    [NativeTypeName("#define STATUS_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN ((NTSTATUS)0xC00002D5L)")]
    public const int STATUS_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = unchecked((int)(0xC00002D5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN"]/*' />
    [NativeTypeName("#define STATUS_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN ((NTSTATUS)0xC00002D6L)")]
    public const int STATUS_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = unchecked((int)(0xC00002D6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER ((NTSTATUS)0xC00002D7L)")]
    public const int STATUS_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = unchecked((int)(0xC00002D7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER ((NTSTATUS)0xC00002D8L)")]
    public const int STATUS_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = unchecked((int)(0xC00002D8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER ((NTSTATUS)0xC00002D9L)")]
    public const int STATUS_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = unchecked((int)(0xC00002D9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER ((NTSTATUS)0xC00002DAL)")]
    public const int STATUS_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = unchecked((int)(0xC00002DA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER ((NTSTATUS)0xC00002DBL)")]
    public const int STATUS_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = unchecked((int)(0xC00002DB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_HAVE_PRIMARY_MEMBERS"]/*' />
    [NativeTypeName("#define STATUS_DS_HAVE_PRIMARY_MEMBERS ((NTSTATUS)0xC00002DCL)")]
    public const int STATUS_DS_HAVE_PRIMARY_MEMBERS = unchecked((int)(0xC00002DC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_WMI_NOT_SUPPORTED ((NTSTATUS)0xC00002DDL)")]
    public const int STATUS_WMI_NOT_SUPPORTED = unchecked((int)(0xC00002DD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSUFFICIENT_POWER"]/*' />
    [NativeTypeName("#define STATUS_INSUFFICIENT_POWER ((NTSTATUS)0xC00002DEL)")]
    public const int STATUS_INSUFFICIENT_POWER = unchecked((int)(0xC00002DE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SAM_NEED_BOOTKEY_PASSWORD"]/*' />
    [NativeTypeName("#define STATUS_SAM_NEED_BOOTKEY_PASSWORD ((NTSTATUS)0xC00002DFL)")]
    public const int STATUS_SAM_NEED_BOOTKEY_PASSWORD = unchecked((int)(0xC00002DF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SAM_NEED_BOOTKEY_FLOPPY"]/*' />
    [NativeTypeName("#define STATUS_SAM_NEED_BOOTKEY_FLOPPY ((NTSTATUS)0xC00002E0L)")]
    public const int STATUS_SAM_NEED_BOOTKEY_FLOPPY = unchecked((int)(0xC00002E0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_CANT_START"]/*' />
    [NativeTypeName("#define STATUS_DS_CANT_START ((NTSTATUS)0xC00002E1L)")]
    public const int STATUS_DS_CANT_START = unchecked((int)(0xC00002E1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_INIT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_DS_INIT_FAILURE ((NTSTATUS)0xC00002E2L)")]
    public const int STATUS_DS_INIT_FAILURE = unchecked((int)(0xC00002E2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SAM_INIT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_SAM_INIT_FAILURE ((NTSTATUS)0xC00002E3L)")]
    public const int STATUS_SAM_INIT_FAILURE = unchecked((int)(0xC00002E3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_GC_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_DS_GC_REQUIRED ((NTSTATUS)0xC00002E4L)")]
    public const int STATUS_DS_GC_REQUIRED = unchecked((int)(0xC00002E4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_LOCAL_MEMBER_OF_LOCAL_ONLY"]/*' />
    [NativeTypeName("#define STATUS_DS_LOCAL_MEMBER_OF_LOCAL_ONLY ((NTSTATUS)0xC00002E5L)")]
    public const int STATUS_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = unchecked((int)(0xC00002E5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_NO_FPO_IN_UNIVERSAL_GROUPS"]/*' />
    [NativeTypeName("#define STATUS_DS_NO_FPO_IN_UNIVERSAL_GROUPS ((NTSTATUS)0xC00002E6L)")]
    public const int STATUS_DS_NO_FPO_IN_UNIVERSAL_GROUPS = unchecked((int)(0xC00002E6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED ((NTSTATUS)0xC00002E7L)")]
    public const int STATUS_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = unchecked((int)(0xC00002E7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MULTIPLE_FAULT_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_MULTIPLE_FAULT_VIOLATION ((NTSTATUS)0xC00002E8L)")]
    public const int STATUS_MULTIPLE_FAULT_VIOLATION = unchecked((int)(0xC00002E8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CURRENT_DOMAIN_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_CURRENT_DOMAIN_NOT_ALLOWED ((NTSTATUS)0xC00002E9L)")]
    public const int STATUS_CURRENT_DOMAIN_NOT_ALLOWED = unchecked((int)(0xC00002E9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_MAKE"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_MAKE ((NTSTATUS)0xC00002EAL)")]
    public const int STATUS_CANNOT_MAKE = unchecked((int)(0xC00002EA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_SHUTDOWN"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_SHUTDOWN ((NTSTATUS)0xC00002EBL)")]
    public const int STATUS_SYSTEM_SHUTDOWN = unchecked((int)(0xC00002EB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_INIT_FAILURE_CONSOLE"]/*' />
    [NativeTypeName("#define STATUS_DS_INIT_FAILURE_CONSOLE ((NTSTATUS)0xC00002ECL)")]
    public const int STATUS_DS_INIT_FAILURE_CONSOLE = unchecked((int)(0xC00002EC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_SAM_INIT_FAILURE_CONSOLE"]/*' />
    [NativeTypeName("#define STATUS_DS_SAM_INIT_FAILURE_CONSOLE ((NTSTATUS)0xC00002EDL)")]
    public const int STATUS_DS_SAM_INIT_FAILURE_CONSOLE = unchecked((int)(0xC00002ED));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNFINISHED_CONTEXT_DELETED"]/*' />
    [NativeTypeName("#define STATUS_UNFINISHED_CONTEXT_DELETED ((NTSTATUS)0xC00002EEL)")]
    public const int STATUS_UNFINISHED_CONTEXT_DELETED = unchecked((int)(0xC00002EE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_TGT_REPLY"]/*' />
    [NativeTypeName("#define STATUS_NO_TGT_REPLY ((NTSTATUS)0xC00002EFL)")]
    public const int STATUS_NO_TGT_REPLY = unchecked((int)(0xC00002EF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECTID_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_OBJECTID_NOT_FOUND ((NTSTATUS)0xC00002F0L)")]
    public const int STATUS_OBJECTID_NOT_FOUND = unchecked((int)(0xC00002F0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_IP_ADDRESSES"]/*' />
    [NativeTypeName("#define STATUS_NO_IP_ADDRESSES ((NTSTATUS)0xC00002F1L)")]
    public const int STATUS_NO_IP_ADDRESSES = unchecked((int)(0xC00002F1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WRONG_CREDENTIAL_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_WRONG_CREDENTIAL_HANDLE ((NTSTATUS)0xC00002F2L)")]
    public const int STATUS_WRONG_CREDENTIAL_HANDLE = unchecked((int)(0xC00002F2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CRYPTO_SYSTEM_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CRYPTO_SYSTEM_INVALID ((NTSTATUS)0xC00002F3L)")]
    public const int STATUS_CRYPTO_SYSTEM_INVALID = unchecked((int)(0xC00002F3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MAX_REFERRALS_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_MAX_REFERRALS_EXCEEDED ((NTSTATUS)0xC00002F4L)")]
    public const int STATUS_MAX_REFERRALS_EXCEEDED = unchecked((int)(0xC00002F4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUST_BE_KDC"]/*' />
    [NativeTypeName("#define STATUS_MUST_BE_KDC ((NTSTATUS)0xC00002F5L)")]
    public const int STATUS_MUST_BE_KDC = unchecked((int)(0xC00002F5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STRONG_CRYPTO_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_STRONG_CRYPTO_NOT_SUPPORTED ((NTSTATUS)0xC00002F6L)")]
    public const int STATUS_STRONG_CRYPTO_NOT_SUPPORTED = unchecked((int)(0xC00002F6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_PRINCIPALS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_PRINCIPALS ((NTSTATUS)0xC00002F7L)")]
    public const int STATUS_TOO_MANY_PRINCIPALS = unchecked((int)(0xC00002F7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_PA_DATA"]/*' />
    [NativeTypeName("#define STATUS_NO_PA_DATA ((NTSTATUS)0xC00002F8L)")]
    public const int STATUS_NO_PA_DATA = unchecked((int)(0xC00002F8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PKINIT_NAME_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_PKINIT_NAME_MISMATCH ((NTSTATUS)0xC00002F9L)")]
    public const int STATUS_PKINIT_NAME_MISMATCH = unchecked((int)(0xC00002F9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_LOGON_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_LOGON_REQUIRED ((NTSTATUS)0xC00002FAL)")]
    public const int STATUS_SMARTCARD_LOGON_REQUIRED = unchecked((int)(0xC00002FA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KDC_INVALID_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_KDC_INVALID_REQUEST ((NTSTATUS)0xC00002FBL)")]
    public const int STATUS_KDC_INVALID_REQUEST = unchecked((int)(0xC00002FB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KDC_UNABLE_TO_REFER"]/*' />
    [NativeTypeName("#define STATUS_KDC_UNABLE_TO_REFER ((NTSTATUS)0xC00002FCL)")]
    public const int STATUS_KDC_UNABLE_TO_REFER = unchecked((int)(0xC00002FC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KDC_UNKNOWN_ETYPE"]/*' />
    [NativeTypeName("#define STATUS_KDC_UNKNOWN_ETYPE ((NTSTATUS)0xC00002FDL)")]
    public const int STATUS_KDC_UNKNOWN_ETYPE = unchecked((int)(0xC00002FD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SHUTDOWN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_SHUTDOWN_IN_PROGRESS ((NTSTATUS)0xC00002FEL)")]
    public const int STATUS_SHUTDOWN_IN_PROGRESS = unchecked((int)(0xC00002FE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVER_SHUTDOWN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_SERVER_SHUTDOWN_IN_PROGRESS ((NTSTATUS)0xC00002FFL)")]
    public const int STATUS_SERVER_SHUTDOWN_IN_PROGRESS = unchecked((int)(0xC00002FF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_ON_SBS"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_ON_SBS ((NTSTATUS)0xC0000300L)")]
    public const int STATUS_NOT_SUPPORTED_ON_SBS = unchecked((int)(0xC0000300));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_GUID_DISCONNECTED"]/*' />
    [NativeTypeName("#define STATUS_WMI_GUID_DISCONNECTED ((NTSTATUS)0xC0000301L)")]
    public const int STATUS_WMI_GUID_DISCONNECTED = unchecked((int)(0xC0000301));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_ALREADY_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_WMI_ALREADY_DISABLED ((NTSTATUS)0xC0000302L)")]
    public const int STATUS_WMI_ALREADY_DISABLED = unchecked((int)(0xC0000302));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WMI_ALREADY_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_WMI_ALREADY_ENABLED ((NTSTATUS)0xC0000303L)")]
    public const int STATUS_WMI_ALREADY_ENABLED = unchecked((int)(0xC0000303));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MFT_TOO_FRAGMENTED"]/*' />
    [NativeTypeName("#define STATUS_MFT_TOO_FRAGMENTED ((NTSTATUS)0xC0000304L)")]
    public const int STATUS_MFT_TOO_FRAGMENTED = unchecked((int)(0xC0000304));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COPY_PROTECTION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_COPY_PROTECTION_FAILURE ((NTSTATUS)0xC0000305L)")]
    public const int STATUS_COPY_PROTECTION_FAILURE = unchecked((int)(0xC0000305));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CSS_AUTHENTICATION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_CSS_AUTHENTICATION_FAILURE ((NTSTATUS)0xC0000306L)")]
    public const int STATUS_CSS_AUTHENTICATION_FAILURE = unchecked((int)(0xC0000306));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CSS_KEY_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_CSS_KEY_NOT_PRESENT ((NTSTATUS)0xC0000307L)")]
    public const int STATUS_CSS_KEY_NOT_PRESENT = unchecked((int)(0xC0000307));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CSS_KEY_NOT_ESTABLISHED"]/*' />
    [NativeTypeName("#define STATUS_CSS_KEY_NOT_ESTABLISHED ((NTSTATUS)0xC0000308L)")]
    public const int STATUS_CSS_KEY_NOT_ESTABLISHED = unchecked((int)(0xC0000308));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CSS_SCRAMBLED_SECTOR"]/*' />
    [NativeTypeName("#define STATUS_CSS_SCRAMBLED_SECTOR ((NTSTATUS)0xC0000309L)")]
    public const int STATUS_CSS_SCRAMBLED_SECTOR = unchecked((int)(0xC0000309));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CSS_REGION_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_CSS_REGION_MISMATCH ((NTSTATUS)0xC000030AL)")]
    public const int STATUS_CSS_REGION_MISMATCH = unchecked((int)(0xC000030A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CSS_RESETS_EXHAUSTED"]/*' />
    [NativeTypeName("#define STATUS_CSS_RESETS_EXHAUSTED ((NTSTATUS)0xC000030BL)")]
    public const int STATUS_CSS_RESETS_EXHAUSTED = unchecked((int)(0xC000030B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PASSWORD_CHANGE_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_PASSWORD_CHANGE_REQUIRED ((NTSTATUS)0xC000030CL)")]
    public const int STATUS_PASSWORD_CHANGE_REQUIRED = unchecked((int)(0xC000030C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOST_MODE_LOGON_RESTRICTION"]/*' />
    [NativeTypeName("#define STATUS_LOST_MODE_LOGON_RESTRICTION ((NTSTATUS)0xC000030DL)")]
    public const int STATUS_LOST_MODE_LOGON_RESTRICTION = unchecked((int)(0xC000030D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PKINIT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_PKINIT_FAILURE ((NTSTATUS)0xC0000320L)")]
    public const int STATUS_PKINIT_FAILURE = unchecked((int)(0xC0000320));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_SUBSYSTEM_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_SUBSYSTEM_FAILURE ((NTSTATUS)0xC0000321L)")]
    public const int STATUS_SMARTCARD_SUBSYSTEM_FAILURE = unchecked((int)(0xC0000321));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_KERB_KEY"]/*' />
    [NativeTypeName("#define STATUS_NO_KERB_KEY ((NTSTATUS)0xC0000322L)")]
    public const int STATUS_NO_KERB_KEY = unchecked((int)(0xC0000322));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HOST_DOWN"]/*' />
    [NativeTypeName("#define STATUS_HOST_DOWN ((NTSTATUS)0xC0000350L)")]
    public const int STATUS_HOST_DOWN = unchecked((int)(0xC0000350));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNSUPPORTED_PREAUTH"]/*' />
    [NativeTypeName("#define STATUS_UNSUPPORTED_PREAUTH ((NTSTATUS)0xC0000351L)")]
    public const int STATUS_UNSUPPORTED_PREAUTH = unchecked((int)(0xC0000351));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EFS_ALG_BLOB_TOO_BIG"]/*' />
    [NativeTypeName("#define STATUS_EFS_ALG_BLOB_TOO_BIG ((NTSTATUS)0xC0000352L)")]
    public const int STATUS_EFS_ALG_BLOB_TOO_BIG = unchecked((int)(0xC0000352));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_NOT_SET"]/*' />
    [NativeTypeName("#define STATUS_PORT_NOT_SET ((NTSTATUS)0xC0000353L)")]
    public const int STATUS_PORT_NOT_SET = unchecked((int)(0xC0000353));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEBUGGER_INACTIVE"]/*' />
    [NativeTypeName("#define STATUS_DEBUGGER_INACTIVE ((NTSTATUS)0xC0000354L)")]
    public const int STATUS_DEBUGGER_INACTIVE = unchecked((int)(0xC0000354));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_VERSION_CHECK_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_DS_VERSION_CHECK_FAILURE ((NTSTATUS)0xC0000355L)")]
    public const int STATUS_DS_VERSION_CHECK_FAILURE = unchecked((int)(0xC0000355));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AUDITING_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_AUDITING_DISABLED ((NTSTATUS)0xC0000356L)")]
    public const int STATUS_AUDITING_DISABLED = unchecked((int)(0xC0000356));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRENT4_MACHINE_ACCOUNT"]/*' />
    [NativeTypeName("#define STATUS_PRENT4_MACHINE_ACCOUNT ((NTSTATUS)0xC0000357L)")]
    public const int STATUS_PRENT4_MACHINE_ACCOUNT = unchecked((int)(0xC0000357));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER ((NTSTATUS)0xC0000358L)")]
    public const int STATUS_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = unchecked((int)(0xC0000358));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_WIN_32"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_WIN_32 ((NTSTATUS)0xC0000359L)")]
    public const int STATUS_INVALID_IMAGE_WIN_32 = unchecked((int)(0xC0000359));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_WIN_64"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_WIN_64 ((NTSTATUS)0xC000035AL)")]
    public const int STATUS_INVALID_IMAGE_WIN_64 = unchecked((int)(0xC000035A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_BINDINGS"]/*' />
    [NativeTypeName("#define STATUS_BAD_BINDINGS ((NTSTATUS)0xC000035BL)")]
    public const int STATUS_BAD_BINDINGS = unchecked((int)(0xC000035B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_SESSION_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_SESSION_EXPIRED ((NTSTATUS)0xC000035CL)")]
    public const int STATUS_NETWORK_SESSION_EXPIRED = unchecked((int)(0xC000035C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPHELP_BLOCK"]/*' />
    [NativeTypeName("#define STATUS_APPHELP_BLOCK ((NTSTATUS)0xC000035DL)")]
    public const int STATUS_APPHELP_BLOCK = unchecked((int)(0xC000035D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALL_SIDS_FILTERED"]/*' />
    [NativeTypeName("#define STATUS_ALL_SIDS_FILTERED ((NTSTATUS)0xC000035EL)")]
    public const int STATUS_ALL_SIDS_FILTERED = unchecked((int)(0xC000035E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SAFE_MODE_DRIVER"]/*' />
    [NativeTypeName("#define STATUS_NOT_SAFE_MODE_DRIVER ((NTSTATUS)0xC000035FL)")]
    public const int STATUS_NOT_SAFE_MODE_DRIVER = unchecked((int)(0xC000035F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCESS_DISABLED_BY_POLICY_DEFAULT"]/*' />
    [NativeTypeName("#define STATUS_ACCESS_DISABLED_BY_POLICY_DEFAULT ((NTSTATUS)0xC0000361L)")]
    public const int STATUS_ACCESS_DISABLED_BY_POLICY_DEFAULT = unchecked((int)(0xC0000361));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCESS_DISABLED_BY_POLICY_PATH"]/*' />
    [NativeTypeName("#define STATUS_ACCESS_DISABLED_BY_POLICY_PATH ((NTSTATUS)0xC0000362L)")]
    public const int STATUS_ACCESS_DISABLED_BY_POLICY_PATH = unchecked((int)(0xC0000362));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCESS_DISABLED_BY_POLICY_PUBLISHER"]/*' />
    [NativeTypeName("#define STATUS_ACCESS_DISABLED_BY_POLICY_PUBLISHER ((NTSTATUS)0xC0000363L)")]
    public const int STATUS_ACCESS_DISABLED_BY_POLICY_PUBLISHER = unchecked((int)(0xC0000363));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCESS_DISABLED_BY_POLICY_OTHER"]/*' />
    [NativeTypeName("#define STATUS_ACCESS_DISABLED_BY_POLICY_OTHER ((NTSTATUS)0xC0000364L)")]
    public const int STATUS_ACCESS_DISABLED_BY_POLICY_OTHER = unchecked((int)(0xC0000364));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FAILED_DRIVER_ENTRY"]/*' />
    [NativeTypeName("#define STATUS_FAILED_DRIVER_ENTRY ((NTSTATUS)0xC0000365L)")]
    public const int STATUS_FAILED_DRIVER_ENTRY = unchecked((int)(0xC0000365));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_ENUMERATION_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_ENUMERATION_ERROR ((NTSTATUS)0xC0000366L)")]
    public const int STATUS_DEVICE_ENUMERATION_ERROR = unchecked((int)(0xC0000366));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MOUNT_POINT_NOT_RESOLVED"]/*' />
    [NativeTypeName("#define STATUS_MOUNT_POINT_NOT_RESOLVED ((NTSTATUS)0xC0000368L)")]
    public const int STATUS_MOUNT_POINT_NOT_RESOLVED = unchecked((int)(0xC0000368));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_DEVICE_OBJECT_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_INVALID_DEVICE_OBJECT_PARAMETER ((NTSTATUS)0xC0000369L)")]
    public const int STATUS_INVALID_DEVICE_OBJECT_PARAMETER = unchecked((int)(0xC0000369));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MCA_OCCURED"]/*' />
    [NativeTypeName("#define STATUS_MCA_OCCURED ((NTSTATUS)0xC000036AL)")]
    public const int STATUS_MCA_OCCURED = unchecked((int)(0xC000036A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_BLOCKED_CRITICAL"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_BLOCKED_CRITICAL ((NTSTATUS)0xC000036BL)")]
    public const int STATUS_DRIVER_BLOCKED_CRITICAL = unchecked((int)(0xC000036B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_BLOCKED ((NTSTATUS)0xC000036CL)")]
    public const int STATUS_DRIVER_BLOCKED = unchecked((int)(0xC000036C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_DATABASE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_DATABASE_ERROR ((NTSTATUS)0xC000036DL)")]
    public const int STATUS_DRIVER_DATABASE_ERROR = unchecked((int)(0xC000036D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_HIVE_TOO_LARGE"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_HIVE_TOO_LARGE ((NTSTATUS)0xC000036EL)")]
    public const int STATUS_SYSTEM_HIVE_TOO_LARGE = unchecked((int)(0xC000036E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMPORT_OF_NON_DLL"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMPORT_OF_NON_DLL ((NTSTATUS)0xC000036FL)")]
    public const int STATUS_INVALID_IMPORT_OF_NON_DLL = unchecked((int)(0xC000036F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_SHUTTING_DOWN"]/*' />
    [NativeTypeName("#define STATUS_DS_SHUTTING_DOWN ((NTSTATUS)0x40000370L)")]
    public const int STATUS_DS_SHUTTING_DOWN = ((int)(0x40000370));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SECRETS"]/*' />
    [NativeTypeName("#define STATUS_NO_SECRETS ((NTSTATUS)0xC0000371L)")]
    public const int STATUS_NO_SECRETS = unchecked((int)(0xC0000371));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY"]/*' />
    [NativeTypeName("#define STATUS_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY ((NTSTATUS)0xC0000372L)")]
    public const int STATUS_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = unchecked((int)(0xC0000372));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FAILED_STACK_SWITCH"]/*' />
    [NativeTypeName("#define STATUS_FAILED_STACK_SWITCH ((NTSTATUS)0xC0000373L)")]
    public const int STATUS_FAILED_STACK_SWITCH = unchecked((int)(0xC0000373));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_WRONG_PIN"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_WRONG_PIN ((NTSTATUS)0xC0000380L)")]
    public const int STATUS_SMARTCARD_WRONG_PIN = unchecked((int)(0xC0000380));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_CARD_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_CARD_BLOCKED ((NTSTATUS)0xC0000381L)")]
    public const int STATUS_SMARTCARD_CARD_BLOCKED = unchecked((int)(0xC0000381));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_CARD_NOT_AUTHENTICATED"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_CARD_NOT_AUTHENTICATED ((NTSTATUS)0xC0000382L)")]
    public const int STATUS_SMARTCARD_CARD_NOT_AUTHENTICATED = unchecked((int)(0xC0000382));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_NO_CARD"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_NO_CARD ((NTSTATUS)0xC0000383L)")]
    public const int STATUS_SMARTCARD_NO_CARD = unchecked((int)(0xC0000383));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_NO_KEY_CONTAINER"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_NO_KEY_CONTAINER ((NTSTATUS)0xC0000384L)")]
    public const int STATUS_SMARTCARD_NO_KEY_CONTAINER = unchecked((int)(0xC0000384));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_NO_CERTIFICATE"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_NO_CERTIFICATE ((NTSTATUS)0xC0000385L)")]
    public const int STATUS_SMARTCARD_NO_CERTIFICATE = unchecked((int)(0xC0000385));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_NO_KEYSET"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_NO_KEYSET ((NTSTATUS)0xC0000386L)")]
    public const int STATUS_SMARTCARD_NO_KEYSET = unchecked((int)(0xC0000386));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_IO_ERROR"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_IO_ERROR ((NTSTATUS)0xC0000387L)")]
    public const int STATUS_SMARTCARD_IO_ERROR = unchecked((int)(0xC0000387));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DOWNGRADE_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_DOWNGRADE_DETECTED ((NTSTATUS)0xC0000388L)")]
    public const int STATUS_DOWNGRADE_DETECTED = unchecked((int)(0xC0000388));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_CERT_REVOKED"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_CERT_REVOKED ((NTSTATUS)0xC0000389L)")]
    public const int STATUS_SMARTCARD_CERT_REVOKED = unchecked((int)(0xC0000389));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ISSUING_CA_UNTRUSTED"]/*' />
    [NativeTypeName("#define STATUS_ISSUING_CA_UNTRUSTED ((NTSTATUS)0xC000038AL)")]
    public const int STATUS_ISSUING_CA_UNTRUSTED = unchecked((int)(0xC000038A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REVOCATION_OFFLINE_C"]/*' />
    [NativeTypeName("#define STATUS_REVOCATION_OFFLINE_C ((NTSTATUS)0xC000038BL)")]
    public const int STATUS_REVOCATION_OFFLINE_C = unchecked((int)(0xC000038B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PKINIT_CLIENT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_PKINIT_CLIENT_FAILURE ((NTSTATUS)0xC000038CL)")]
    public const int STATUS_PKINIT_CLIENT_FAILURE = unchecked((int)(0xC000038C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_CERT_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_CERT_EXPIRED ((NTSTATUS)0xC000038DL)")]
    public const int STATUS_SMARTCARD_CERT_EXPIRED = unchecked((int)(0xC000038D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_FAILED_PRIOR_UNLOAD"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_FAILED_PRIOR_UNLOAD ((NTSTATUS)0xC000038EL)")]
    public const int STATUS_DRIVER_FAILED_PRIOR_UNLOAD = unchecked((int)(0xC000038E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMARTCARD_SILENT_CONTEXT"]/*' />
    [NativeTypeName("#define STATUS_SMARTCARD_SILENT_CONTEXT ((NTSTATUS)0xC000038FL)")]
    public const int STATUS_SMARTCARD_SILENT_CONTEXT = unchecked((int)(0xC000038F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PER_USER_TRUST_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_PER_USER_TRUST_QUOTA_EXCEEDED ((NTSTATUS)0xC0000401L)")]
    public const int STATUS_PER_USER_TRUST_QUOTA_EXCEEDED = unchecked((int)(0xC0000401));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALL_USER_TRUST_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_ALL_USER_TRUST_QUOTA_EXCEEDED ((NTSTATUS)0xC0000402L)")]
    public const int STATUS_ALL_USER_TRUST_QUOTA_EXCEEDED = unchecked((int)(0xC0000402));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_USER_DELETE_TRUST_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_USER_DELETE_TRUST_QUOTA_EXCEEDED ((NTSTATUS)0xC0000403L)")]
    public const int STATUS_USER_DELETE_TRUST_QUOTA_EXCEEDED = unchecked((int)(0xC0000403));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_NAME_NOT_UNIQUE"]/*' />
    [NativeTypeName("#define STATUS_DS_NAME_NOT_UNIQUE ((NTSTATUS)0xC0000404L)")]
    public const int STATUS_DS_NAME_NOT_UNIQUE = unchecked((int)(0xC0000404));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_DUPLICATE_ID_FOUND"]/*' />
    [NativeTypeName("#define STATUS_DS_DUPLICATE_ID_FOUND ((NTSTATUS)0xC0000405L)")]
    public const int STATUS_DS_DUPLICATE_ID_FOUND = unchecked((int)(0xC0000405));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_GROUP_CONVERSION_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DS_GROUP_CONVERSION_ERROR ((NTSTATUS)0xC0000406L)")]
    public const int STATUS_DS_GROUP_CONVERSION_ERROR = unchecked((int)(0xC0000406));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLSNAP_PREPARE_HIBERNATE"]/*' />
    [NativeTypeName("#define STATUS_VOLSNAP_PREPARE_HIBERNATE ((NTSTATUS)0xC0000407L)")]
    public const int STATUS_VOLSNAP_PREPARE_HIBERNATE = unchecked((int)(0xC0000407));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_USER2USER_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_USER2USER_REQUIRED ((NTSTATUS)0xC0000408L)")]
    public const int STATUS_USER2USER_REQUIRED = unchecked((int)(0xC0000408));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_S4U_PROT_SUPPORT"]/*' />
    [NativeTypeName("#define STATUS_NO_S4U_PROT_SUPPORT ((NTSTATUS)0xC000040AL)")]
    public const int STATUS_NO_S4U_PROT_SUPPORT = unchecked((int)(0xC000040A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CROSSREALM_DELEGATION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_CROSSREALM_DELEGATION_FAILURE ((NTSTATUS)0xC000040BL)")]
    public const int STATUS_CROSSREALM_DELEGATION_FAILURE = unchecked((int)(0xC000040B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REVOCATION_OFFLINE_KDC"]/*' />
    [NativeTypeName("#define STATUS_REVOCATION_OFFLINE_KDC ((NTSTATUS)0xC000040CL)")]
    public const int STATUS_REVOCATION_OFFLINE_KDC = unchecked((int)(0xC000040C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ISSUING_CA_UNTRUSTED_KDC"]/*' />
    [NativeTypeName("#define STATUS_ISSUING_CA_UNTRUSTED_KDC ((NTSTATUS)0xC000040DL)")]
    public const int STATUS_ISSUING_CA_UNTRUSTED_KDC = unchecked((int)(0xC000040D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KDC_CERT_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_KDC_CERT_EXPIRED ((NTSTATUS)0xC000040EL)")]
    public const int STATUS_KDC_CERT_EXPIRED = unchecked((int)(0xC000040E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KDC_CERT_REVOKED"]/*' />
    [NativeTypeName("#define STATUS_KDC_CERT_REVOKED ((NTSTATUS)0xC000040FL)")]
    public const int STATUS_KDC_CERT_REVOKED = unchecked((int)(0xC000040F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PARAMETER_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_PARAMETER_QUOTA_EXCEEDED ((NTSTATUS)0xC0000410L)")]
    public const int STATUS_PARAMETER_QUOTA_EXCEEDED = unchecked((int)(0xC0000410));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HIBERNATION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_HIBERNATION_FAILURE ((NTSTATUS)0xC0000411L)")]
    public const int STATUS_HIBERNATION_FAILURE = unchecked((int)(0xC0000411));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DELAY_LOAD_FAILED"]/*' />
    [NativeTypeName("#define STATUS_DELAY_LOAD_FAILED ((NTSTATUS)0xC0000412L)")]
    public const int STATUS_DELAY_LOAD_FAILED = unchecked((int)(0xC0000412));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AUTHENTICATION_FIREWALL_FAILED"]/*' />
    [NativeTypeName("#define STATUS_AUTHENTICATION_FIREWALL_FAILED ((NTSTATUS)0xC0000413L)")]
    public const int STATUS_AUTHENTICATION_FIREWALL_FAILED = unchecked((int)(0xC0000413));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VDM_DISALLOWED"]/*' />
    [NativeTypeName("#define STATUS_VDM_DISALLOWED ((NTSTATUS)0xC0000414L)")]
    public const int STATUS_VDM_DISALLOWED = unchecked((int)(0xC0000414));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HUNG_DISPLAY_DRIVER_THREAD"]/*' />
    [NativeTypeName("#define STATUS_HUNG_DISPLAY_DRIVER_THREAD ((NTSTATUS)0xC0000415L)")]
    public const int STATUS_HUNG_DISPLAY_DRIVER_THREAD = unchecked((int)(0xC0000415));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE"]/*' />
    [NativeTypeName("#define STATUS_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE ((NTSTATUS)0xC0000416L)")]
    public const int STATUS_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE = unchecked((int)(0xC0000416));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NTLM_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_NTLM_BLOCKED ((NTSTATUS)0xC0000418L)")]
    public const int STATUS_NTLM_BLOCKED = unchecked((int)(0xC0000418));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_SRC_SID_EXISTS_IN_FOREST"]/*' />
    [NativeTypeName("#define STATUS_DS_SRC_SID_EXISTS_IN_FOREST ((NTSTATUS)0xC0000419L)")]
    public const int STATUS_DS_SRC_SID_EXISTS_IN_FOREST = unchecked((int)(0xC0000419));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_DOMAIN_NAME_EXISTS_IN_FOREST"]/*' />
    [NativeTypeName("#define STATUS_DS_DOMAIN_NAME_EXISTS_IN_FOREST ((NTSTATUS)0xC000041AL)")]
    public const int STATUS_DS_DOMAIN_NAME_EXISTS_IN_FOREST = unchecked((int)(0xC000041A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_FLAT_NAME_EXISTS_IN_FOREST"]/*' />
    [NativeTypeName("#define STATUS_DS_FLAT_NAME_EXISTS_IN_FOREST ((NTSTATUS)0xC000041BL)")]
    public const int STATUS_DS_FLAT_NAME_EXISTS_IN_FOREST = unchecked((int)(0xC000041B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_USER_PRINCIPAL_NAME"]/*' />
    [NativeTypeName("#define STATUS_INVALID_USER_PRINCIPAL_NAME ((NTSTATUS)0xC000041CL)")]
    public const int STATUS_INVALID_USER_PRINCIPAL_NAME = unchecked((int)(0xC000041C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FATAL_USER_CALLBACK_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_FATAL_USER_CALLBACK_EXCEPTION ((NTSTATUS)0xC000041DL)")]
    public const int STATUS_FATAL_USER_CALLBACK_EXCEPTION = unchecked((int)(0xC000041D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VERIFIER_STOP"]/*' />
    [NativeTypeName("#define STATUS_VERIFIER_STOP ((NTSTATUS)0xC0000421L)")]
    public const int STATUS_VERIFIER_STOP = unchecked((int)(0xC0000421));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_POP_STACK"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_POP_STACK ((NTSTATUS)0xC0000423L)")]
    public const int STATUS_CALLBACK_POP_STACK = unchecked((int)(0xC0000423));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INCOMPATIBLE_DRIVER_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_INCOMPATIBLE_DRIVER_BLOCKED ((NTSTATUS)0xC0000424L)")]
    public const int STATUS_INCOMPATIBLE_DRIVER_BLOCKED = unchecked((int)(0xC0000424));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HIVE_UNLOADED"]/*' />
    [NativeTypeName("#define STATUS_HIVE_UNLOADED ((NTSTATUS)0xC0000425L)")]
    public const int STATUS_HIVE_UNLOADED = unchecked((int)(0xC0000425));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COMPRESSION_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_COMPRESSION_DISABLED ((NTSTATUS)0xC0000426L)")]
    public const int STATUS_COMPRESSION_DISABLED = unchecked((int)(0xC0000426));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SYSTEM_LIMITATION"]/*' />
    [NativeTypeName("#define STATUS_FILE_SYSTEM_LIMITATION ((NTSTATUS)0xC0000427L)")]
    public const int STATUS_FILE_SYSTEM_LIMITATION = unchecked((int)(0xC0000427));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IMAGE_HASH"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IMAGE_HASH ((NTSTATUS)0xC0000428L)")]
    public const int STATUS_INVALID_IMAGE_HASH = unchecked((int)(0xC0000428));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_CAPABLE"]/*' />
    [NativeTypeName("#define STATUS_NOT_CAPABLE ((NTSTATUS)0xC0000429L)")]
    public const int STATUS_NOT_CAPABLE = unchecked((int)(0xC0000429));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REQUEST_OUT_OF_SEQUENCE"]/*' />
    [NativeTypeName("#define STATUS_REQUEST_OUT_OF_SEQUENCE ((NTSTATUS)0xC000042AL)")]
    public const int STATUS_REQUEST_OUT_OF_SEQUENCE = unchecked((int)(0xC000042A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMPLEMENTATION_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_IMPLEMENTATION_LIMIT ((NTSTATUS)0xC000042BL)")]
    public const int STATUS_IMPLEMENTATION_LIMIT = unchecked((int)(0xC000042B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ELEVATION_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_ELEVATION_REQUIRED ((NTSTATUS)0xC000042CL)")]
    public const int STATUS_ELEVATION_REQUIRED = unchecked((int)(0xC000042C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SECURITY_CONTEXT"]/*' />
    [NativeTypeName("#define STATUS_NO_SECURITY_CONTEXT ((NTSTATUS)0xC000042DL)")]
    public const int STATUS_NO_SECURITY_CONTEXT = unchecked((int)(0xC000042D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PKU2U_CERT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_PKU2U_CERT_FAILURE ((NTSTATUS)0xC000042FL)")]
    public const int STATUS_PKU2U_CERT_FAILURE = unchecked((int)(0xC000042F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BEYOND_VDL"]/*' />
    [NativeTypeName("#define STATUS_BEYOND_VDL ((NTSTATUS)0xC0000432L)")]
    public const int STATUS_BEYOND_VDL = unchecked((int)(0xC0000432));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCOUNTERED_WRITE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_ENCOUNTERED_WRITE_IN_PROGRESS ((NTSTATUS)0xC0000433L)")]
    public const int STATUS_ENCOUNTERED_WRITE_IN_PROGRESS = unchecked((int)(0xC0000433));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PTE_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_PTE_CHANGED ((NTSTATUS)0xC0000434L)")]
    public const int STATUS_PTE_CHANGED = unchecked((int)(0xC0000434));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PURGE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_PURGE_FAILED ((NTSTATUS)0xC0000435L)")]
    public const int STATUS_PURGE_FAILED = unchecked((int)(0xC0000435));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CRED_REQUIRES_CONFIRMATION"]/*' />
    [NativeTypeName("#define STATUS_CRED_REQUIRES_CONFIRMATION ((NTSTATUS)0xC0000440L)")]
    public const int STATUS_CRED_REQUIRES_CONFIRMATION = unchecked((int)(0xC0000440));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CS_ENCRYPTION_INVALID_SERVER_RESPONSE"]/*' />
    [NativeTypeName("#define STATUS_CS_ENCRYPTION_INVALID_SERVER_RESPONSE ((NTSTATUS)0xC0000441L)")]
    public const int STATUS_CS_ENCRYPTION_INVALID_SERVER_RESPONSE = unchecked((int)(0xC0000441));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CS_ENCRYPTION_UNSUPPORTED_SERVER"]/*' />
    [NativeTypeName("#define STATUS_CS_ENCRYPTION_UNSUPPORTED_SERVER ((NTSTATUS)0xC0000442L)")]
    public const int STATUS_CS_ENCRYPTION_UNSUPPORTED_SERVER = unchecked((int)(0xC0000442));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE"]/*' />
    [NativeTypeName("#define STATUS_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE ((NTSTATUS)0xC0000443L)")]
    public const int STATUS_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE = unchecked((int)(0xC0000443));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CS_ENCRYPTION_NEW_ENCRYPTED_FILE"]/*' />
    [NativeTypeName("#define STATUS_CS_ENCRYPTION_NEW_ENCRYPTED_FILE ((NTSTATUS)0xC0000444L)")]
    public const int STATUS_CS_ENCRYPTION_NEW_ENCRYPTED_FILE = unchecked((int)(0xC0000444));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CS_ENCRYPTION_FILE_NOT_CSE"]/*' />
    [NativeTypeName("#define STATUS_CS_ENCRYPTION_FILE_NOT_CSE ((NTSTATUS)0xC0000445L)")]
    public const int STATUS_CS_ENCRYPTION_FILE_NOT_CSE = unchecked((int)(0xC0000445));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_LABEL"]/*' />
    [NativeTypeName("#define STATUS_INVALID_LABEL ((NTSTATUS)0xC0000446L)")]
    public const int STATUS_INVALID_LABEL = unchecked((int)(0xC0000446));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRIVER_PROCESS_TERMINATED"]/*' />
    [NativeTypeName("#define STATUS_DRIVER_PROCESS_TERMINATED ((NTSTATUS)0xC0000450L)")]
    public const int STATUS_DRIVER_PROCESS_TERMINATED = unchecked((int)(0xC0000450));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AMBIGUOUS_SYSTEM_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_AMBIGUOUS_SYSTEM_DEVICE ((NTSTATUS)0xC0000451L)")]
    public const int STATUS_AMBIGUOUS_SYSTEM_DEVICE = unchecked((int)(0xC0000451));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_DEVICE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_DEVICE_NOT_FOUND ((NTSTATUS)0xC0000452L)")]
    public const int STATUS_SYSTEM_DEVICE_NOT_FOUND = unchecked((int)(0xC0000452));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESTART_BOOT_APPLICATION"]/*' />
    [NativeTypeName("#define STATUS_RESTART_BOOT_APPLICATION ((NTSTATUS)0xC0000453L)")]
    public const int STATUS_RESTART_BOOT_APPLICATION = unchecked((int)(0xC0000453));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSUFFICIENT_NVRAM_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_INSUFFICIENT_NVRAM_RESOURCES ((NTSTATUS)0xC0000454L)")]
    public const int STATUS_INSUFFICIENT_NVRAM_RESOURCES = unchecked((int)(0xC0000454));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_SESSION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_SESSION ((NTSTATUS)0xC0000455L)")]
    public const int STATUS_INVALID_SESSION = unchecked((int)(0xC0000455));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREAD_ALREADY_IN_SESSION"]/*' />
    [NativeTypeName("#define STATUS_THREAD_ALREADY_IN_SESSION ((NTSTATUS)0xC0000456L)")]
    public const int STATUS_THREAD_ALREADY_IN_SESSION = unchecked((int)(0xC0000456));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREAD_NOT_IN_SESSION"]/*' />
    [NativeTypeName("#define STATUS_THREAD_NOT_IN_SESSION ((NTSTATUS)0xC0000457L)")]
    public const int STATUS_THREAD_NOT_IN_SESSION = unchecked((int)(0xC0000457));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_WEIGHT"]/*' />
    [NativeTypeName("#define STATUS_INVALID_WEIGHT ((NTSTATUS)0xC0000458L)")]
    public const int STATUS_INVALID_WEIGHT = unchecked((int)(0xC0000458));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REQUEST_PAUSED"]/*' />
    [NativeTypeName("#define STATUS_REQUEST_PAUSED ((NTSTATUS)0xC0000459L)")]
    public const int STATUS_REQUEST_PAUSED = unchecked((int)(0xC0000459));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_RANGES_PROCESSED"]/*' />
    [NativeTypeName("#define STATUS_NO_RANGES_PROCESSED ((NTSTATUS)0xC0000460L)")]
    public const int STATUS_NO_RANGES_PROCESSED = unchecked((int)(0xC0000460));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_RESOURCES_EXHAUSTED"]/*' />
    [NativeTypeName("#define STATUS_DISK_RESOURCES_EXHAUSTED ((NTSTATUS)0xC0000461L)")]
    public const int STATUS_DISK_RESOURCES_EXHAUSTED = unchecked((int)(0xC0000461));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NEEDS_REMEDIATION"]/*' />
    [NativeTypeName("#define STATUS_NEEDS_REMEDIATION ((NTSTATUS)0xC0000462L)")]
    public const int STATUS_NEEDS_REMEDIATION = unchecked((int)(0xC0000462));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_FEATURE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_FEATURE_NOT_SUPPORTED ((NTSTATUS)0xC0000463L)")]
    public const int STATUS_DEVICE_FEATURE_NOT_SUPPORTED = unchecked((int)(0xC0000463));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_UNREACHABLE"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_UNREACHABLE ((NTSTATUS)0xC0000464L)")]
    public const int STATUS_DEVICE_UNREACHABLE = unchecked((int)(0xC0000464));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_TOKEN"]/*' />
    [NativeTypeName("#define STATUS_INVALID_TOKEN ((NTSTATUS)0xC0000465L)")]
    public const int STATUS_INVALID_TOKEN = unchecked((int)(0xC0000465));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVER_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_SERVER_UNAVAILABLE ((NTSTATUS)0xC0000466L)")]
    public const int STATUS_SERVER_UNAVAILABLE = unchecked((int)(0xC0000466));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_FILE_NOT_AVAILABLE ((NTSTATUS)0xC0000467L)")]
    public const int STATUS_FILE_NOT_AVAILABLE = unchecked((int)(0xC0000467));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_INSUFFICIENT_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_INSUFFICIENT_RESOURCES ((NTSTATUS)0xC0000468L)")]
    public const int STATUS_DEVICE_INSUFFICIENT_RESOURCES = unchecked((int)(0xC0000468));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PACKAGE_UPDATING"]/*' />
    [NativeTypeName("#define STATUS_PACKAGE_UPDATING ((NTSTATUS)0xC0000469L)")]
    public const int STATUS_PACKAGE_UPDATING = unchecked((int)(0xC0000469));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_READ_FROM_COPY"]/*' />
    [NativeTypeName("#define STATUS_NOT_READ_FROM_COPY ((NTSTATUS)0xC000046AL)")]
    public const int STATUS_NOT_READ_FROM_COPY = unchecked((int)(0xC000046A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_WRITE_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_FT_WRITE_FAILURE ((NTSTATUS)0xC000046BL)")]
    public const int STATUS_FT_WRITE_FAILURE = unchecked((int)(0xC000046B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_DI_SCAN_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_FT_DI_SCAN_REQUIRED ((NTSTATUS)0xC000046CL)")]
    public const int STATUS_FT_DI_SCAN_REQUIRED = unchecked((int)(0xC000046C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_NOT_EXTERNALLY_BACKED"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_NOT_EXTERNALLY_BACKED ((NTSTATUS)0xC000046DL)")]
    public const int STATUS_OBJECT_NOT_EXTERNALLY_BACKED = unchecked((int)(0xC000046D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EXTERNAL_BACKING_PROVIDER_UNKNOWN"]/*' />
    [NativeTypeName("#define STATUS_EXTERNAL_BACKING_PROVIDER_UNKNOWN ((NTSTATUS)0xC000046EL)")]
    public const int STATUS_EXTERNAL_BACKING_PROVIDER_UNKNOWN = unchecked((int)(0xC000046E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COMPRESSION_NOT_BENEFICIAL"]/*' />
    [NativeTypeName("#define STATUS_COMPRESSION_NOT_BENEFICIAL ((NTSTATUS)0xC000046FL)")]
    public const int STATUS_COMPRESSION_NOT_BENEFICIAL = unchecked((int)(0xC000046F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATA_CHECKSUM_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DATA_CHECKSUM_ERROR ((NTSTATUS)0xC0000470L)")]
    public const int STATUS_DATA_CHECKSUM_ERROR = unchecked((int)(0xC0000470));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTERMIXED_KERNEL_EA_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_INTERMIXED_KERNEL_EA_OPERATION ((NTSTATUS)0xC0000471L)")]
    public const int STATUS_INTERMIXED_KERNEL_EA_OPERATION = unchecked((int)(0xC0000471));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRIM_READ_ZERO_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_TRIM_READ_ZERO_NOT_SUPPORTED ((NTSTATUS)0xC0000472L)")]
    public const int STATUS_TRIM_READ_ZERO_NOT_SUPPORTED = unchecked((int)(0xC0000472));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TOO_MANY_SEGMENT_DESCRIPTORS"]/*' />
    [NativeTypeName("#define STATUS_TOO_MANY_SEGMENT_DESCRIPTORS ((NTSTATUS)0xC0000473L)")]
    public const int STATUS_TOO_MANY_SEGMENT_DESCRIPTORS = unchecked((int)(0xC0000473));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_OFFSET_ALIGNMENT"]/*' />
    [NativeTypeName("#define STATUS_INVALID_OFFSET_ALIGNMENT ((NTSTATUS)0xC0000474L)")]
    public const int STATUS_INVALID_OFFSET_ALIGNMENT = unchecked((int)(0xC0000474));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_FIELD_IN_PARAMETER_LIST"]/*' />
    [NativeTypeName("#define STATUS_INVALID_FIELD_IN_PARAMETER_LIST ((NTSTATUS)0xC0000475L)")]
    public const int STATUS_INVALID_FIELD_IN_PARAMETER_LIST = unchecked((int)(0xC0000475));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OPERATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_OPERATION_IN_PROGRESS ((NTSTATUS)0xC0000476L)")]
    public const int STATUS_OPERATION_IN_PROGRESS = unchecked((int)(0xC0000476));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_INITIATOR_TARGET_PATH"]/*' />
    [NativeTypeName("#define STATUS_INVALID_INITIATOR_TARGET_PATH ((NTSTATUS)0xC0000477L)")]
    public const int STATUS_INVALID_INITIATOR_TARGET_PATH = unchecked((int)(0xC0000477));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SCRUB_DATA_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_SCRUB_DATA_DISABLED ((NTSTATUS)0xC0000478L)")]
    public const int STATUS_SCRUB_DATA_DISABLED = unchecked((int)(0xC0000478));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_REDUNDANT_STORAGE"]/*' />
    [NativeTypeName("#define STATUS_NOT_REDUNDANT_STORAGE ((NTSTATUS)0xC0000479L)")]
    public const int STATUS_NOT_REDUNDANT_STORAGE = unchecked((int)(0xC0000479));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESIDENT_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_RESIDENT_FILE_NOT_SUPPORTED ((NTSTATUS)0xC000047AL)")]
    public const int STATUS_RESIDENT_FILE_NOT_SUPPORTED = unchecked((int)(0xC000047A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COMPRESSED_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_COMPRESSED_FILE_NOT_SUPPORTED ((NTSTATUS)0xC000047BL)")]
    public const int STATUS_COMPRESSED_FILE_NOT_SUPPORTED = unchecked((int)(0xC000047B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIRECTORY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_DIRECTORY_NOT_SUPPORTED ((NTSTATUS)0xC000047CL)")]
    public const int STATUS_DIRECTORY_NOT_SUPPORTED = unchecked((int)(0xC000047C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_OPERATION_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_IO_OPERATION_TIMEOUT ((NTSTATUS)0xC000047DL)")]
    public const int STATUS_IO_OPERATION_TIMEOUT = unchecked((int)(0xC000047D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_NEEDS_REMEDIATION"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_NEEDS_REMEDIATION ((NTSTATUS)0xC000047EL)")]
    public const int STATUS_SYSTEM_NEEDS_REMEDIATION = unchecked((int)(0xC000047E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPX_INTEGRITY_FAILURE_CLR_NGEN"]/*' />
    [NativeTypeName("#define STATUS_APPX_INTEGRITY_FAILURE_CLR_NGEN ((NTSTATUS)0xC000047FL)")]
    public const int STATUS_APPX_INTEGRITY_FAILURE_CLR_NGEN = unchecked((int)(0xC000047F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SHARE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_SHARE_UNAVAILABLE ((NTSTATUS)0xC0000480L)")]
    public const int STATUS_SHARE_UNAVAILABLE = unchecked((int)(0xC0000480));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APISET_NOT_HOSTED"]/*' />
    [NativeTypeName("#define STATUS_APISET_NOT_HOSTED ((NTSTATUS)0xC0000481L)")]
    public const int STATUS_APISET_NOT_HOSTED = unchecked((int)(0xC0000481));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APISET_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_APISET_NOT_PRESENT ((NTSTATUS)0xC0000482L)")]
    public const int STATUS_APISET_NOT_PRESENT = unchecked((int)(0xC0000482));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_HARDWARE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_HARDWARE_ERROR ((NTSTATUS)0xC0000483L)")]
    public const int STATUS_DEVICE_HARDWARE_ERROR = unchecked((int)(0xC0000483));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FIRMWARE_SLOT_INVALID"]/*' />
    [NativeTypeName("#define STATUS_FIRMWARE_SLOT_INVALID ((NTSTATUS)0xC0000484L)")]
    public const int STATUS_FIRMWARE_SLOT_INVALID = unchecked((int)(0xC0000484));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FIRMWARE_IMAGE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_FIRMWARE_IMAGE_INVALID ((NTSTATUS)0xC0000485L)")]
    public const int STATUS_FIRMWARE_IMAGE_INVALID = unchecked((int)(0xC0000485));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STORAGE_TOPOLOGY_ID_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_STORAGE_TOPOLOGY_ID_MISMATCH ((NTSTATUS)0xC0000486L)")]
    public const int STATUS_STORAGE_TOPOLOGY_ID_MISMATCH = unchecked((int)(0xC0000486));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WIM_NOT_BOOTABLE"]/*' />
    [NativeTypeName("#define STATUS_WIM_NOT_BOOTABLE ((NTSTATUS)0xC0000487L)")]
    public const int STATUS_WIM_NOT_BOOTABLE = unchecked((int)(0xC0000487));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BLOCKED_BY_PARENTAL_CONTROLS"]/*' />
    [NativeTypeName("#define STATUS_BLOCKED_BY_PARENTAL_CONTROLS ((NTSTATUS)0xC0000488L)")]
    public const int STATUS_BLOCKED_BY_PARENTAL_CONTROLS = unchecked((int)(0xC0000488));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NEEDS_REGISTRATION"]/*' />
    [NativeTypeName("#define STATUS_NEEDS_REGISTRATION ((NTSTATUS)0xC0000489L)")]
    public const int STATUS_NEEDS_REGISTRATION = unchecked((int)(0xC0000489));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUOTA_ACTIVITY"]/*' />
    [NativeTypeName("#define STATUS_QUOTA_ACTIVITY ((NTSTATUS)0xC000048AL)")]
    public const int STATUS_QUOTA_ACTIVITY = unchecked((int)(0xC000048A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_INVOKE_INLINE"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_INVOKE_INLINE ((NTSTATUS)0xC000048BL)")]
    public const int STATUS_CALLBACK_INVOKE_INLINE = unchecked((int)(0xC000048B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BLOCK_TOO_MANY_REFERENCES"]/*' />
    [NativeTypeName("#define STATUS_BLOCK_TOO_MANY_REFERENCES ((NTSTATUS)0xC000048CL)")]
    public const int STATUS_BLOCK_TOO_MANY_REFERENCES = unchecked((int)(0xC000048C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MARKED_TO_DISALLOW_WRITES"]/*' />
    [NativeTypeName("#define STATUS_MARKED_TO_DISALLOW_WRITES ((NTSTATUS)0xC000048DL)")]
    public const int STATUS_MARKED_TO_DISALLOW_WRITES = unchecked((int)(0xC000048D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_ACCESS_DENIED_EDP"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_ACCESS_DENIED_EDP ((NTSTATUS)0xC000048EL)")]
    public const int STATUS_NETWORK_ACCESS_DENIED_EDP = unchecked((int)(0xC000048E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCLAVE_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_ENCLAVE_FAILURE ((NTSTATUS)0xC000048FL)")]
    public const int STATUS_ENCLAVE_FAILURE = unchecked((int)(0xC000048F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_NO_COMPAT_DRIVERS"]/*' />
    [NativeTypeName("#define STATUS_PNP_NO_COMPAT_DRIVERS ((NTSTATUS)0xC0000490L)")]
    public const int STATUS_PNP_NO_COMPAT_DRIVERS = unchecked((int)(0xC0000490));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_DRIVER_PACKAGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PNP_DRIVER_PACKAGE_NOT_FOUND ((NTSTATUS)0xC0000491L)")]
    public const int STATUS_PNP_DRIVER_PACKAGE_NOT_FOUND = unchecked((int)(0xC0000491));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_DRIVER_CONFIGURATION_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PNP_DRIVER_CONFIGURATION_NOT_FOUND ((NTSTATUS)0xC0000492L)")]
    public const int STATUS_PNP_DRIVER_CONFIGURATION_NOT_FOUND = unchecked((int)(0xC0000492));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_DRIVER_CONFIGURATION_INCOMPLETE"]/*' />
    [NativeTypeName("#define STATUS_PNP_DRIVER_CONFIGURATION_INCOMPLETE ((NTSTATUS)0xC0000493L)")]
    public const int STATUS_PNP_DRIVER_CONFIGURATION_INCOMPLETE = unchecked((int)(0xC0000493));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_FUNCTION_DRIVER_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_PNP_FUNCTION_DRIVER_REQUIRED ((NTSTATUS)0xC0000494L)")]
    public const int STATUS_PNP_FUNCTION_DRIVER_REQUIRED = unchecked((int)(0xC0000494));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_DEVICE_CONFIGURATION_PENDING"]/*' />
    [NativeTypeName("#define STATUS_PNP_DEVICE_CONFIGURATION_PENDING ((NTSTATUS)0xC0000495L)")]
    public const int STATUS_PNP_DEVICE_CONFIGURATION_PENDING = unchecked((int)(0xC0000495));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_HINT_NAME_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_HINT_NAME_BUFFER_TOO_SMALL ((NTSTATUS)0xC0000496L)")]
    public const int STATUS_DEVICE_HINT_NAME_BUFFER_TOO_SMALL = unchecked((int)(0xC0000496));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PACKAGE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_PACKAGE_NOT_AVAILABLE ((NTSTATUS)0xC0000497L)")]
    public const int STATUS_PACKAGE_NOT_AVAILABLE = unchecked((int)(0xC0000497));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_IN_MAINTENANCE"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_IN_MAINTENANCE ((NTSTATUS)0xC0000499L)")]
    public const int STATUS_DEVICE_IN_MAINTENANCE = unchecked((int)(0xC0000499));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_ON_DAX"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_ON_DAX ((NTSTATUS)0xC000049AL)")]
    public const int STATUS_NOT_SUPPORTED_ON_DAX = unchecked((int)(0xC000049A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FREE_SPACE_TOO_FRAGMENTED"]/*' />
    [NativeTypeName("#define STATUS_FREE_SPACE_TOO_FRAGMENTED ((NTSTATUS)0xC000049BL)")]
    public const int STATUS_FREE_SPACE_TOO_FRAGMENTED = unchecked((int)(0xC000049B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DAX_MAPPING_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_DAX_MAPPING_EXISTS ((NTSTATUS)0xC000049CL)")]
    public const int STATUS_DAX_MAPPING_EXISTS = unchecked((int)(0xC000049C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CHILD_PROCESS_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_CHILD_PROCESS_BLOCKED ((NTSTATUS)0xC000049DL)")]
    public const int STATUS_CHILD_PROCESS_BLOCKED = unchecked((int)(0xC000049D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STORAGE_LOST_DATA_PERSISTENCE"]/*' />
    [NativeTypeName("#define STATUS_STORAGE_LOST_DATA_PERSISTENCE ((NTSTATUS)0xC000049EL)")]
    public const int STATUS_STORAGE_LOST_DATA_PERSISTENCE = unchecked((int)(0xC000049E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PARTITION_TERMINATING"]/*' />
    [NativeTypeName("#define STATUS_PARTITION_TERMINATING ((NTSTATUS)0xC00004A0L)")]
    public const int STATUS_PARTITION_TERMINATING = unchecked((int)(0xC00004A0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EXTERNAL_SYSKEY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_EXTERNAL_SYSKEY_NOT_SUPPORTED ((NTSTATUS)0xC00004A1L)")]
    public const int STATUS_EXTERNAL_SYSKEY_NOT_SUPPORTED = unchecked((int)(0xC00004A1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_PROTECTED_UNDER_DPL"]/*' />
    [NativeTypeName("#define STATUS_FILE_PROTECTED_UNDER_DPL ((NTSTATUS)0xC00004A3L)")]
    public const int STATUS_FILE_PROTECTED_UNDER_DPL = unchecked((int)(0xC00004A3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_NOT_CLUSTER_ALIGNED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_NOT_CLUSTER_ALIGNED ((NTSTATUS)0xC00004A4L)")]
    public const int STATUS_VOLUME_NOT_CLUSTER_ALIGNED = unchecked((int)(0xC00004A4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND"]/*' />
    [NativeTypeName("#define STATUS_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND ((NTSTATUS)0xC00004A5L)")]
    public const int STATUS_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND = unchecked((int)(0xC00004A5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPX_FILE_NOT_ENCRYPTED"]/*' />
    [NativeTypeName("#define STATUS_APPX_FILE_NOT_ENCRYPTED ((NTSTATUS)0xC00004A6L)")]
    public const int STATUS_APPX_FILE_NOT_ENCRYPTED = unchecked((int)(0xC00004A6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED"]/*' />
    [NativeTypeName("#define STATUS_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED ((NTSTATUS)0xC00004A7L)")]
    public const int STATUS_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED = unchecked((int)(0xC00004A7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET"]/*' />
    [NativeTypeName("#define STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET ((NTSTATUS)0xC00004A8L)")]
    public const int STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET = unchecked((int)(0xC00004A8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE"]/*' />
    [NativeTypeName("#define STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE ((NTSTATUS)0xC00004A9L)")]
    public const int STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE = unchecked((int)(0xC00004A9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER ((NTSTATUS)0xC00004AAL)")]
    public const int STATUS_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER = unchecked((int)(0xC00004AA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_READ_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_FT_READ_FAILURE ((NTSTATUS)0xC00004ABL)")]
    public const int STATUS_FT_READ_FAILURE = unchecked((int)(0xC00004AB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PATCH_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_PATCH_CONFLICT ((NTSTATUS)0xC00004ACL)")]
    public const int STATUS_PATCH_CONFLICT = unchecked((int)(0xC00004AC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STORAGE_RESERVE_ID_INVALID"]/*' />
    [NativeTypeName("#define STATUS_STORAGE_RESERVE_ID_INVALID ((NTSTATUS)0xC00004ADL)")]
    public const int STATUS_STORAGE_RESERVE_ID_INVALID = unchecked((int)(0xC00004AD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STORAGE_RESERVE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define STATUS_STORAGE_RESERVE_DOES_NOT_EXIST ((NTSTATUS)0xC00004AEL)")]
    public const int STATUS_STORAGE_RESERVE_DOES_NOT_EXIST = unchecked((int)(0xC00004AE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STORAGE_RESERVE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_STORAGE_RESERVE_ALREADY_EXISTS ((NTSTATUS)0xC00004AFL)")]
    public const int STATUS_STORAGE_RESERVE_ALREADY_EXISTS = unchecked((int)(0xC00004AF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STORAGE_RESERVE_NOT_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_STORAGE_RESERVE_NOT_EMPTY ((NTSTATUS)0xC00004B0L)")]
    public const int STATUS_STORAGE_RESERVE_NOT_EMPTY = unchecked((int)(0xC00004B0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_A_DAX_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_NOT_A_DAX_VOLUME ((NTSTATUS)0xC00004B1L)")]
    public const int STATUS_NOT_A_DAX_VOLUME = unchecked((int)(0xC00004B1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_DAX_MAPPABLE"]/*' />
    [NativeTypeName("#define STATUS_NOT_DAX_MAPPABLE ((NTSTATUS)0xC00004B2L)")]
    public const int STATUS_NOT_DAX_MAPPABLE = unchecked((int)(0xC00004B2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CASE_DIFFERING_NAMES_IN_DIR"]/*' />
    [NativeTypeName("#define STATUS_CASE_DIFFERING_NAMES_IN_DIR ((NTSTATUS)0xC00004B3L)")]
    public const int STATUS_CASE_DIFFERING_NAMES_IN_DIR = unchecked((int)(0xC00004B3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_FILE_NOT_SUPPORTED ((NTSTATUS)0xC00004B4L)")]
    public const int STATUS_FILE_NOT_SUPPORTED = unchecked((int)(0xC00004B4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_BTT"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_BTT ((NTSTATUS)0xC00004B5L)")]
    public const int STATUS_NOT_SUPPORTED_WITH_BTT = unchecked((int)(0xC00004B5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCRYPTION_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_ENCRYPTION_DISABLED ((NTSTATUS)0xC00004B6L)")]
    public const int STATUS_ENCRYPTION_DISABLED = unchecked((int)(0xC00004B6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCRYPTING_METADATA_DISALLOWED"]/*' />
    [NativeTypeName("#define STATUS_ENCRYPTING_METADATA_DISALLOWED ((NTSTATUS)0xC00004B7L)")]
    public const int STATUS_ENCRYPTING_METADATA_DISALLOWED = unchecked((int)(0xC00004B7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_CLEAR_ENCRYPTION_FLAG"]/*' />
    [NativeTypeName("#define STATUS_CANT_CLEAR_ENCRYPTION_FLAG ((NTSTATUS)0xC00004B8L)")]
    public const int STATUS_CANT_CLEAR_ENCRYPTION_FLAG = unchecked((int)(0xC00004B8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNSATISFIED_DEPENDENCIES"]/*' />
    [NativeTypeName("#define STATUS_UNSATISFIED_DEPENDENCIES ((NTSTATUS)0xC00004B9L)")]
    public const int STATUS_UNSATISFIED_DEPENDENCIES = unchecked((int)(0xC00004B9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CASE_SENSITIVE_PATH"]/*' />
    [NativeTypeName("#define STATUS_CASE_SENSITIVE_PATH ((NTSTATUS)0xC00004BAL)")]
    public const int STATUS_CASE_SENSITIVE_PATH = unchecked((int)(0xC00004BA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNSUPPORTED_PAGING_MODE"]/*' />
    [NativeTypeName("#define STATUS_UNSUPPORTED_PAGING_MODE ((NTSTATUS)0xC00004BBL)")]
    public const int STATUS_UNSUPPORTED_PAGING_MODE = unchecked((int)(0xC00004BB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNTRUSTED_MOUNT_POINT"]/*' />
    [NativeTypeName("#define STATUS_UNTRUSTED_MOUNT_POINT ((NTSTATUS)0xC00004BCL)")]
    public const int STATUS_UNTRUSTED_MOUNT_POINT = unchecked((int)(0xC00004BC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HAS_SYSTEM_CRITICAL_FILES"]/*' />
    [NativeTypeName("#define STATUS_HAS_SYSTEM_CRITICAL_FILES ((NTSTATUS)0xC00004BDL)")]
    public const int STATUS_HAS_SYSTEM_CRITICAL_FILES = unchecked((int)(0xC00004BD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_IS_IMMUTABLE"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_IS_IMMUTABLE ((NTSTATUS)0xC00004BEL)")]
    public const int STATUS_OBJECT_IS_IMMUTABLE = unchecked((int)(0xC00004BE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FT_READ_FROM_COPY_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_FT_READ_FROM_COPY_FAILURE ((NTSTATUS)0xC00004BFL)")]
    public const int STATUS_FT_READ_FROM_COPY_FAILURE = unchecked((int)(0xC00004BF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_LOADED_AS_PATCH_IMAGE"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_LOADED_AS_PATCH_IMAGE ((NTSTATUS)0xC00004C0L)")]
    public const int STATUS_IMAGE_LOADED_AS_PATCH_IMAGE = unchecked((int)(0xC00004C0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STORAGE_STACK_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_STORAGE_STACK_ACCESS_DENIED ((NTSTATUS)0xC00004C1L)")]
    public const int STATUS_STORAGE_STACK_ACCESS_DENIED = unchecked((int)(0xC00004C1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INSUFFICIENT_VIRTUAL_ADDR_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_INSUFFICIENT_VIRTUAL_ADDR_RESOURCES ((NTSTATUS)0xC00004C2L)")]
    public const int STATUS_INSUFFICIENT_VIRTUAL_ADDR_RESOURCES = unchecked((int)(0xC00004C2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCRYPTED_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_ENCRYPTED_FILE_NOT_SUPPORTED ((NTSTATUS)0xC00004C3L)")]
    public const int STATUS_ENCRYPTED_FILE_NOT_SUPPORTED = unchecked((int)(0xC00004C3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPARSE_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_SPARSE_FILE_NOT_SUPPORTED ((NTSTATUS)0xC00004C4L)")]
    public const int STATUS_SPARSE_FILE_NOT_SUPPORTED = unchecked((int)(0xC00004C4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PAGEFILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_PAGEFILE_NOT_SUPPORTED ((NTSTATUS)0xC00004C5L)")]
    public const int STATUS_PAGEFILE_NOT_SUPPORTED = unchecked((int)(0xC00004C5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_NOT_SUPPORTED ((NTSTATUS)0xC00004C6L)")]
    public const int STATUS_VOLUME_NOT_SUPPORTED = unchecked((int)(0xC00004C6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_BYPASSIO"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_BYPASSIO ((NTSTATUS)0xC00004C7L)")]
    public const int STATUS_NOT_SUPPORTED_WITH_BYPASSIO = unchecked((int)(0xC00004C7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_BYPASSIO_DRIVER_SUPPORT"]/*' />
    [NativeTypeName("#define STATUS_NO_BYPASSIO_DRIVER_SUPPORT ((NTSTATUS)0xC00004C8L)")]
    public const int STATUS_NO_BYPASSIO_DRIVER_SUPPORT = unchecked((int)(0xC00004C8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_ENCRYPTION"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_ENCRYPTION ((NTSTATUS)0xC00004C9L)")]
    public const int STATUS_NOT_SUPPORTED_WITH_ENCRYPTION = unchecked((int)(0xC00004C9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_COMPRESSION"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_COMPRESSION ((NTSTATUS)0xC00004CAL)")]
    public const int STATUS_NOT_SUPPORTED_WITH_COMPRESSION = unchecked((int)(0xC00004CA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_REPLICATION"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_REPLICATION ((NTSTATUS)0xC00004CBL)")]
    public const int STATUS_NOT_SUPPORTED_WITH_REPLICATION = unchecked((int)(0xC00004CB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_DEDUPLICATION"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_DEDUPLICATION ((NTSTATUS)0xC00004CCL)")]
    public const int STATUS_NOT_SUPPORTED_WITH_DEDUPLICATION = unchecked((int)(0xC00004CC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_AUDITING"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_AUDITING ((NTSTATUS)0xC00004CDL)")]
    public const int STATUS_NOT_SUPPORTED_WITH_AUDITING = unchecked((int)(0xC00004CD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_MONITORING"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_MONITORING ((NTSTATUS)0xC00004CEL)")]
    public const int STATUS_NOT_SUPPORTED_WITH_MONITORING = unchecked((int)(0xC00004CE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_SNAPSHOT"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_SNAPSHOT ((NTSTATUS)0xC00004CFL)")]
    public const int STATUS_NOT_SUPPORTED_WITH_SNAPSHOT = unchecked((int)(0xC00004CF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_VIRTUALIZATION"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_VIRTUALIZATION ((NTSTATUS)0xC00004D0L)")]
    public const int STATUS_NOT_SUPPORTED_WITH_VIRTUALIZATION = unchecked((int)(0xC00004D0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INDEX_OUT_OF_BOUNDS"]/*' />
    [NativeTypeName("#define STATUS_INDEX_OUT_OF_BOUNDS ((NTSTATUS)0xC00004D1L)")]
    public const int STATUS_INDEX_OUT_OF_BOUNDS = unchecked((int)(0xC00004D1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BYPASSIO_FLT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_BYPASSIO_FLT_NOT_SUPPORTED ((NTSTATUS)0xC00004D2L)")]
    public const int STATUS_BYPASSIO_FLT_NOT_SUPPORTED = unchecked((int)(0xC00004D2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_WRITE_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_WRITE_ACCESS_DENIED ((NTSTATUS)0xC00004D3L)")]
    public const int STATUS_VOLUME_WRITE_ACCESS_DENIED = unchecked((int)(0xC00004D3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PATCH_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_PATCH_NOT_REGISTERED ((NTSTATUS)0xC00004D4L)")]
    public const int STATUS_PATCH_NOT_REGISTERED = unchecked((int)(0xC00004D4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_WITH_CACHED_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_WITH_CACHED_HANDLE ((NTSTATUS)0xC00004D5L)")]
    public const int STATUS_NOT_SUPPORTED_WITH_CACHED_HANDLE = unchecked((int)(0xC00004D5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PDE_ENCRYPTION_UNAVAILABLE_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_PDE_ENCRYPTION_UNAVAILABLE_FAILURE ((NTSTATUS)0xC00004D6L)")]
    public const int STATUS_PDE_ENCRYPTION_UNAVAILABLE_FAILURE = unchecked((int)(0xC00004D6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PDE_DECRYPTION_UNAVAILABLE_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_PDE_DECRYPTION_UNAVAILABLE_FAILURE ((NTSTATUS)0xC00004D7L)")]
    public const int STATUS_PDE_DECRYPTION_UNAVAILABLE_FAILURE = unchecked((int)(0xC00004D7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PDE_DECRYPTION_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_PDE_DECRYPTION_UNAVAILABLE ((NTSTATUS)0xC00004D8L)")]
    public const int STATUS_PDE_DECRYPTION_UNAVAILABLE = unchecked((int)(0xC00004D8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_UPGRADE_NOT_NEEDED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_UPGRADE_NOT_NEEDED ((NTSTATUS)0x400004D9L)")]
    public const int STATUS_VOLUME_UPGRADE_NOT_NEEDED = ((int)(0x400004D9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_UPGRADE_PENDING"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_UPGRADE_PENDING ((NTSTATUS)0x400004DAL)")]
    public const int STATUS_VOLUME_UPGRADE_PENDING = ((int)(0x400004DA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_UPGRADE_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_UPGRADE_DISABLED ((NTSTATUS)0xC00004DBL)")]
    public const int STATUS_VOLUME_UPGRADE_DISABLED = unchecked((int)(0xC00004DB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_UPGRADE_DISABLED_TILL_OS_DOWNGRADE_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_UPGRADE_DISABLED_TILL_OS_DOWNGRADE_EXPIRED ((NTSTATUS)0xC00004DCL)")]
    public const int STATUS_VOLUME_UPGRADE_DISABLED_TILL_OS_DOWNGRADE_EXPIRED = unchecked((int)(0xC00004DC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_A_DEV_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_NOT_A_DEV_VOLUME ((NTSTATUS)0xC00004DDL)")]
    public const int STATUS_NOT_A_DEV_VOLUME = unchecked((int)(0xC00004DD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FS_GUID_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_FS_GUID_MISMATCH ((NTSTATUS)0xC00004DEL)")]
    public const int STATUS_FS_GUID_MISMATCH = unchecked((int)(0xC00004DE));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_ATTACH_TO_DEV_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_CANT_ATTACH_TO_DEV_VOLUME ((NTSTATUS)0xC00004DFL)")]
    public const int STATUS_CANT_ATTACH_TO_DEV_VOLUME = unchecked((int)(0xC00004DF));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEMORY_DECOMPRESSION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_MEMORY_DECOMPRESSION_FAILURE ((NTSTATUS)0xC00004E0L)")]
    public const int STATUS_MEMORY_DECOMPRESSION_FAILURE = unchecked((int)(0xC00004E0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_CONFIG_VALUE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_CONFIG_VALUE ((NTSTATUS)0xC00004E1L)")]
    public const int STATUS_INVALID_CONFIG_VALUE = unchecked((int)(0xC00004E1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MEMORY_DECOMPRESSION_HW_ERROR"]/*' />
    [NativeTypeName("#define STATUS_MEMORY_DECOMPRESSION_HW_ERROR ((NTSTATUS)0xC00004E2L)")]
    public const int STATUS_MEMORY_DECOMPRESSION_HW_ERROR = unchecked((int)(0xC00004E2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_ROLLBACK_DETECTED ((NTSTATUS)0xC00004E3L)")]
    public const int STATUS_VOLUME_ROLLBACK_DETECTED = unchecked((int)(0xC00004E3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_NACKED"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_NACKED ((NTSTATUS)0xC00004E5L)")]
    public const int STATUS_DEVICE_NACKED = unchecked((int)(0xC00004E5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_TASK_NAME"]/*' />
    [NativeTypeName("#define STATUS_INVALID_TASK_NAME ((NTSTATUS)0xC0000500L)")]
    public const int STATUS_INVALID_TASK_NAME = unchecked((int)(0xC0000500));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_TASK_INDEX"]/*' />
    [NativeTypeName("#define STATUS_INVALID_TASK_INDEX ((NTSTATUS)0xC0000501L)")]
    public const int STATUS_INVALID_TASK_INDEX = unchecked((int)(0xC0000501));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREAD_ALREADY_IN_TASK"]/*' />
    [NativeTypeName("#define STATUS_THREAD_ALREADY_IN_TASK ((NTSTATUS)0xC0000502L)")]
    public const int STATUS_THREAD_ALREADY_IN_TASK = unchecked((int)(0xC0000502));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_BYPASS"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_BYPASS ((NTSTATUS)0xC0000503L)")]
    public const int STATUS_CALLBACK_BYPASS = unchecked((int)(0xC0000503));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNDEFINED_SCOPE"]/*' />
    [NativeTypeName("#define STATUS_UNDEFINED_SCOPE ((NTSTATUS)0xC0000504L)")]
    public const int STATUS_UNDEFINED_SCOPE = unchecked((int)(0xC0000504));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_CAP"]/*' />
    [NativeTypeName("#define STATUS_INVALID_CAP ((NTSTATUS)0xC0000505L)")]
    public const int STATUS_INVALID_CAP = unchecked((int)(0xC0000505));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_GUI_PROCESS"]/*' />
    [NativeTypeName("#define STATUS_NOT_GUI_PROCESS ((NTSTATUS)0xC0000506L)")]
    public const int STATUS_NOT_GUI_PROCESS = unchecked((int)(0xC0000506));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_HUNG"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_HUNG ((NTSTATUS)0xC0000507L)")]
    public const int STATUS_DEVICE_HUNG = unchecked((int)(0xC0000507));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONTAINER_ASSIGNED"]/*' />
    [NativeTypeName("#define STATUS_CONTAINER_ASSIGNED ((NTSTATUS)0xC0000508L)")]
    public const int STATUS_CONTAINER_ASSIGNED = unchecked((int)(0xC0000508));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_JOB_NO_CONTAINER"]/*' />
    [NativeTypeName("#define STATUS_JOB_NO_CONTAINER ((NTSTATUS)0xC0000509L)")]
    public const int STATUS_JOB_NO_CONTAINER = unchecked((int)(0xC0000509));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DEVICE_UNRESPONSIVE"]/*' />
    [NativeTypeName("#define STATUS_DEVICE_UNRESPONSIVE ((NTSTATUS)0xC000050AL)")]
    public const int STATUS_DEVICE_UNRESPONSIVE = unchecked((int)(0xC000050A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REPARSE_POINT_ENCOUNTERED"]/*' />
    [NativeTypeName("#define STATUS_REPARSE_POINT_ENCOUNTERED ((NTSTATUS)0xC000050BL)")]
    public const int STATUS_REPARSE_POINT_ENCOUNTERED = unchecked((int)(0xC000050B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ATTRIBUTE_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_ATTRIBUTE_NOT_PRESENT ((NTSTATUS)0xC000050CL)")]
    public const int STATUS_ATTRIBUTE_NOT_PRESENT = unchecked((int)(0xC000050C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_A_TIERED_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_NOT_A_TIERED_VOLUME ((NTSTATUS)0xC000050DL)")]
    public const int STATUS_NOT_A_TIERED_VOLUME = unchecked((int)(0xC000050D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALREADY_HAS_STREAM_ID"]/*' />
    [NativeTypeName("#define STATUS_ALREADY_HAS_STREAM_ID ((NTSTATUS)0xC000050EL)")]
    public const int STATUS_ALREADY_HAS_STREAM_ID = unchecked((int)(0xC000050E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_JOB_NOT_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_JOB_NOT_EMPTY ((NTSTATUS)0xC000050FL)")]
    public const int STATUS_JOB_NOT_EMPTY = unchecked((int)(0xC000050F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALREADY_INITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_ALREADY_INITIALIZED ((NTSTATUS)0xC0000510L)")]
    public const int STATUS_ALREADY_INITIALIZED = unchecked((int)(0xC0000510));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCLAVE_NOT_TERMINATED"]/*' />
    [NativeTypeName("#define STATUS_ENCLAVE_NOT_TERMINATED ((NTSTATUS)0xC0000511L)")]
    public const int STATUS_ENCLAVE_NOT_TERMINATED = unchecked((int)(0xC0000511));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCLAVE_IS_TERMINATING"]/*' />
    [NativeTypeName("#define STATUS_ENCLAVE_IS_TERMINATING ((NTSTATUS)0xC0000512L)")]
    public const int STATUS_ENCLAVE_IS_TERMINATING = unchecked((int)(0xC0000512));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB1_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_SMB1_NOT_AVAILABLE ((NTSTATUS)0xC0000513L)")]
    public const int STATUS_SMB1_NOT_AVAILABLE = unchecked((int)(0xC0000513));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMR_GARBAGE_COLLECTION_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_SMR_GARBAGE_COLLECTION_REQUIRED ((NTSTATUS)0xC0000514L)")]
    public const int STATUS_SMR_GARBAGE_COLLECTION_REQUIRED = unchecked((int)(0xC0000514));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SESSION_KEY_TOO_SHORT"]/*' />
    [NativeTypeName("#define STATUS_SESSION_KEY_TOO_SHORT ((NTSTATUS)0xC0000517L)")]
    public const int STATUS_SESSION_KEY_TOO_SHORT = unchecked((int)(0xC0000517));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FS_METADATA_INCONSISTENT"]/*' />
    [NativeTypeName("#define STATUS_FS_METADATA_INCONSISTENT ((NTSTATUS)0xC0000518L)")]
    public const int STATUS_FS_METADATA_INCONSISTENT = unchecked((int)(0xC0000518));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_OPLOCK_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_INVALID_OPLOCK_REQUEST ((NTSTATUS)0xC0000519L)")]
    public const int STATUS_INVALID_OPLOCK_REQUEST = unchecked((int)(0xC0000519));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FAIL_FAST_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_FAIL_FAST_EXCEPTION ((NTSTATUS)0xC0000602L)")]
    public const int STATUS_FAIL_FAST_EXCEPTION = unchecked((int)(0xC0000602));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_CERT_REVOKED"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_CERT_REVOKED ((NTSTATUS)0xC0000603L)")]
    public const int STATUS_IMAGE_CERT_REVOKED = unchecked((int)(0xC0000603));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DYNAMIC_CODE_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_DYNAMIC_CODE_BLOCKED ((NTSTATUS)0xC0000604L)")]
    public const int STATUS_DYNAMIC_CODE_BLOCKED = unchecked((int)(0xC0000604));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IMAGE_CERT_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_IMAGE_CERT_EXPIRED ((NTSTATUS)0xC0000605L)")]
    public const int STATUS_IMAGE_CERT_EXPIRED = unchecked((int)(0xC0000605));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STRICT_CFG_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_STRICT_CFG_VIOLATION ((NTSTATUS)0xC0000606L)")]
    public const int STATUS_STRICT_CFG_VIOLATION = unchecked((int)(0xC0000606));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SET_CONTEXT_DENIED"]/*' />
    [NativeTypeName("#define STATUS_SET_CONTEXT_DENIED ((NTSTATUS)0xC000060AL)")]
    public const int STATUS_SET_CONTEXT_DENIED = unchecked((int)(0xC000060A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CROSS_PARTITION_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_CROSS_PARTITION_VIOLATION ((NTSTATUS)0xC000060BL)")]
    public const int STATUS_CROSS_PARTITION_VIOLATION = unchecked((int)(0xC000060B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_PORT_CLOSED ((NTSTATUS)0xC0000700L)")]
    public const int STATUS_PORT_CLOSED = unchecked((int)(0xC0000700));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MESSAGE_LOST"]/*' />
    [NativeTypeName("#define STATUS_MESSAGE_LOST ((NTSTATUS)0xC0000701L)")]
    public const int STATUS_MESSAGE_LOST = unchecked((int)(0xC0000701));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_MESSAGE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_MESSAGE ((NTSTATUS)0xC0000702L)")]
    public const int STATUS_INVALID_MESSAGE = unchecked((int)(0xC0000702));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REQUEST_CANCELED"]/*' />
    [NativeTypeName("#define STATUS_REQUEST_CANCELED ((NTSTATUS)0xC0000703L)")]
    public const int STATUS_REQUEST_CANCELED = unchecked((int)(0xC0000703));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RECURSIVE_DISPATCH"]/*' />
    [NativeTypeName("#define STATUS_RECURSIVE_DISPATCH ((NTSTATUS)0xC0000704L)")]
    public const int STATUS_RECURSIVE_DISPATCH = unchecked((int)(0xC0000704));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LPC_RECEIVE_BUFFER_EXPECTED"]/*' />
    [NativeTypeName("#define STATUS_LPC_RECEIVE_BUFFER_EXPECTED ((NTSTATUS)0xC0000705L)")]
    public const int STATUS_LPC_RECEIVE_BUFFER_EXPECTED = unchecked((int)(0xC0000705));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LPC_INVALID_CONNECTION_USAGE"]/*' />
    [NativeTypeName("#define STATUS_LPC_INVALID_CONNECTION_USAGE ((NTSTATUS)0xC0000706L)")]
    public const int STATUS_LPC_INVALID_CONNECTION_USAGE = unchecked((int)(0xC0000706));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LPC_REQUESTS_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_LPC_REQUESTS_NOT_ALLOWED ((NTSTATUS)0xC0000707L)")]
    public const int STATUS_LPC_REQUESTS_NOT_ALLOWED = unchecked((int)(0xC0000707));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCE_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_RESOURCE_IN_USE ((NTSTATUS)0xC0000708L)")]
    public const int STATUS_RESOURCE_IN_USE = unchecked((int)(0xC0000708));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HARDWARE_MEMORY_ERROR"]/*' />
    [NativeTypeName("#define STATUS_HARDWARE_MEMORY_ERROR ((NTSTATUS)0xC0000709L)")]
    public const int STATUS_HARDWARE_MEMORY_ERROR = unchecked((int)(0xC0000709));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREADPOOL_HANDLE_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_THREADPOOL_HANDLE_EXCEPTION ((NTSTATUS)0xC000070AL)")]
    public const int STATUS_THREADPOOL_HANDLE_EXCEPTION = unchecked((int)(0xC000070A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREADPOOL_SET_EVENT_ON_COMPLETION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_THREADPOOL_SET_EVENT_ON_COMPLETION_FAILED ((NTSTATUS)0xC000070BL)")]
    public const int STATUS_THREADPOOL_SET_EVENT_ON_COMPLETION_FAILED = unchecked((int)(0xC000070B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREADPOOL_RELEASE_SEMAPHORE_ON_COMPLETION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_THREADPOOL_RELEASE_SEMAPHORE_ON_COMPLETION_FAILED ((NTSTATUS)0xC000070CL)")]
    public const int STATUS_THREADPOOL_RELEASE_SEMAPHORE_ON_COMPLETION_FAILED = unchecked((int)(0xC000070C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREADPOOL_RELEASE_MUTEX_ON_COMPLETION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_THREADPOOL_RELEASE_MUTEX_ON_COMPLETION_FAILED ((NTSTATUS)0xC000070DL)")]
    public const int STATUS_THREADPOOL_RELEASE_MUTEX_ON_COMPLETION_FAILED = unchecked((int)(0xC000070D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREADPOOL_FREE_LIBRARY_ON_COMPLETION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_THREADPOOL_FREE_LIBRARY_ON_COMPLETION_FAILED ((NTSTATUS)0xC000070EL)")]
    public const int STATUS_THREADPOOL_FREE_LIBRARY_ON_COMPLETION_FAILED = unchecked((int)(0xC000070E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREADPOOL_RELEASED_DURING_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_THREADPOOL_RELEASED_DURING_OPERATION ((NTSTATUS)0xC000070FL)")]
    public const int STATUS_THREADPOOL_RELEASED_DURING_OPERATION = unchecked((int)(0xC000070F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_RETURNED_WHILE_IMPERSONATING"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_RETURNED_WHILE_IMPERSONATING ((NTSTATUS)0xC0000710L)")]
    public const int STATUS_CALLBACK_RETURNED_WHILE_IMPERSONATING = unchecked((int)(0xC0000710));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APC_RETURNED_WHILE_IMPERSONATING"]/*' />
    [NativeTypeName("#define STATUS_APC_RETURNED_WHILE_IMPERSONATING ((NTSTATUS)0xC0000711L)")]
    public const int STATUS_APC_RETURNED_WHILE_IMPERSONATING = unchecked((int)(0xC0000711));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROCESS_IS_PROTECTED"]/*' />
    [NativeTypeName("#define STATUS_PROCESS_IS_PROTECTED ((NTSTATUS)0xC0000712L)")]
    public const int STATUS_PROCESS_IS_PROTECTED = unchecked((int)(0xC0000712));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MCA_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_MCA_EXCEPTION ((NTSTATUS)0xC0000713L)")]
    public const int STATUS_MCA_EXCEPTION = unchecked((int)(0xC0000713));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CERTIFICATE_MAPPING_NOT_UNIQUE"]/*' />
    [NativeTypeName("#define STATUS_CERTIFICATE_MAPPING_NOT_UNIQUE ((NTSTATUS)0xC0000714L)")]
    public const int STATUS_CERTIFICATE_MAPPING_NOT_UNIQUE = unchecked((int)(0xC0000714));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYMLINK_CLASS_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_SYMLINK_CLASS_DISABLED ((NTSTATUS)0xC0000715L)")]
    public const int STATUS_SYMLINK_CLASS_DISABLED = unchecked((int)(0xC0000715));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_IDN_NORMALIZATION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_IDN_NORMALIZATION ((NTSTATUS)0xC0000716L)")]
    public const int STATUS_INVALID_IDN_NORMALIZATION = unchecked((int)(0xC0000716));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_UNICODE_TRANSLATION"]/*' />
    [NativeTypeName("#define STATUS_NO_UNICODE_TRANSLATION ((NTSTATUS)0xC0000717L)")]
    public const int STATUS_NO_UNICODE_TRANSLATION = unchecked((int)(0xC0000717));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONTEXT_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_CONTEXT_MISMATCH ((NTSTATUS)0xC0000719L)")]
    public const int STATUS_CONTEXT_MISMATCH = unchecked((int)(0xC0000719));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PORT_ALREADY_HAS_COMPLETION_LIST"]/*' />
    [NativeTypeName("#define STATUS_PORT_ALREADY_HAS_COMPLETION_LIST ((NTSTATUS)0xC000071AL)")]
    public const int STATUS_PORT_ALREADY_HAS_COMPLETION_LIST = unchecked((int)(0xC000071A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_RETURNED_THREAD_PRIORITY"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_RETURNED_THREAD_PRIORITY ((NTSTATUS)0xC000071BL)")]
    public const int STATUS_CALLBACK_RETURNED_THREAD_PRIORITY = unchecked((int)(0xC000071B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_THREAD"]/*' />
    [NativeTypeName("#define STATUS_INVALID_THREAD ((NTSTATUS)0xC000071CL)")]
    public const int STATUS_INVALID_THREAD = unchecked((int)(0xC000071C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_RETURNED_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_RETURNED_TRANSACTION ((NTSTATUS)0xC000071DL)")]
    public const int STATUS_CALLBACK_RETURNED_TRANSACTION = unchecked((int)(0xC000071D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_RETURNED_LDR_LOCK"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_RETURNED_LDR_LOCK ((NTSTATUS)0xC000071EL)")]
    public const int STATUS_CALLBACK_RETURNED_LDR_LOCK = unchecked((int)(0xC000071E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_RETURNED_LANG"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_RETURNED_LANG ((NTSTATUS)0xC000071FL)")]
    public const int STATUS_CALLBACK_RETURNED_LANG = unchecked((int)(0xC000071F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_RETURNED_PRI_BACK"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_RETURNED_PRI_BACK ((NTSTATUS)0xC0000720L)")]
    public const int STATUS_CALLBACK_RETURNED_PRI_BACK = unchecked((int)(0xC0000720));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CALLBACK_RETURNED_THREAD_AFFINITY"]/*' />
    [NativeTypeName("#define STATUS_CALLBACK_RETURNED_THREAD_AFFINITY ((NTSTATUS)0xC0000721L)")]
    public const int STATUS_CALLBACK_RETURNED_THREAD_AFFINITY = unchecked((int)(0xC0000721));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LPC_HANDLE_COUNT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_LPC_HANDLE_COUNT_EXCEEDED ((NTSTATUS)0xC0000722L)")]
    public const int STATUS_LPC_HANDLE_COUNT_EXCEEDED = unchecked((int)(0xC0000722));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EXECUTABLE_MEMORY_WRITE"]/*' />
    [NativeTypeName("#define STATUS_EXECUTABLE_MEMORY_WRITE ((NTSTATUS)0xC0000723L)")]
    public const int STATUS_EXECUTABLE_MEMORY_WRITE = unchecked((int)(0xC0000723));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_KERNEL_EXECUTABLE_MEMORY_WRITE"]/*' />
    [NativeTypeName("#define STATUS_KERNEL_EXECUTABLE_MEMORY_WRITE ((NTSTATUS)0xC0000724L)")]
    public const int STATUS_KERNEL_EXECUTABLE_MEMORY_WRITE = unchecked((int)(0xC0000724));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ATTACHED_EXECUTABLE_MEMORY_WRITE"]/*' />
    [NativeTypeName("#define STATUS_ATTACHED_EXECUTABLE_MEMORY_WRITE ((NTSTATUS)0xC0000725L)")]
    public const int STATUS_ATTACHED_EXECUTABLE_MEMORY_WRITE = unchecked((int)(0xC0000725));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRIGGERED_EXECUTABLE_MEMORY_WRITE"]/*' />
    [NativeTypeName("#define STATUS_TRIGGERED_EXECUTABLE_MEMORY_WRITE ((NTSTATUS)0xC0000726L)")]
    public const int STATUS_TRIGGERED_EXECUTABLE_MEMORY_WRITE = unchecked((int)(0xC0000726));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_REPAIR_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_DISK_REPAIR_DISABLED ((NTSTATUS)0xC0000800L)")]
    public const int STATUS_DISK_REPAIR_DISABLED = unchecked((int)(0xC0000800));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_DOMAIN_RENAME_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_DS_DOMAIN_RENAME_IN_PROGRESS ((NTSTATUS)0xC0000801L)")]
    public const int STATUS_DS_DOMAIN_RENAME_IN_PROGRESS = unchecked((int)(0xC0000801));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_DISK_QUOTA_EXCEEDED ((NTSTATUS)0xC0000802L)")]
    public const int STATUS_DISK_QUOTA_EXCEEDED = unchecked((int)(0xC0000802));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATA_LOST_REPAIR"]/*' />
    [NativeTypeName("#define STATUS_DATA_LOST_REPAIR ((NTSTATUS)0x80000803L)")]
    public const int STATUS_DATA_LOST_REPAIR = unchecked((int)(0x80000803));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONTENT_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_CONTENT_BLOCKED ((NTSTATUS)0xC0000804L)")]
    public const int STATUS_CONTENT_BLOCKED = unchecked((int)(0xC0000804));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_CLUSTERS"]/*' />
    [NativeTypeName("#define STATUS_BAD_CLUSTERS ((NTSTATUS)0xC0000805L)")]
    public const int STATUS_BAD_CLUSTERS = unchecked((int)(0xC0000805));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLUME_DIRTY"]/*' />
    [NativeTypeName("#define STATUS_VOLUME_DIRTY ((NTSTATUS)0xC0000806L)")]
    public const int STATUS_VOLUME_DIRTY = unchecked((int)(0xC0000806));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_REPAIR_REDIRECTED"]/*' />
    [NativeTypeName("#define STATUS_DISK_REPAIR_REDIRECTED ((NTSTATUS)0x40000807L)")]
    public const int STATUS_DISK_REPAIR_REDIRECTED = ((int)(0x40000807));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DISK_REPAIR_UNSUCCESSFUL"]/*' />
    [NativeTypeName("#define STATUS_DISK_REPAIR_UNSUCCESSFUL ((NTSTATUS)0xC0000808L)")]
    public const int STATUS_DISK_REPAIR_UNSUCCESSFUL = unchecked((int)(0xC0000808));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CORRUPT_LOG_OVERFULL"]/*' />
    [NativeTypeName("#define STATUS_CORRUPT_LOG_OVERFULL ((NTSTATUS)0xC0000809L)")]
    public const int STATUS_CORRUPT_LOG_OVERFULL = unchecked((int)(0xC0000809));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CORRUPT_LOG_CORRUPTED"]/*' />
    [NativeTypeName("#define STATUS_CORRUPT_LOG_CORRUPTED ((NTSTATUS)0xC000080AL)")]
    public const int STATUS_CORRUPT_LOG_CORRUPTED = unchecked((int)(0xC000080A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CORRUPT_LOG_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_CORRUPT_LOG_UNAVAILABLE ((NTSTATUS)0xC000080BL)")]
    public const int STATUS_CORRUPT_LOG_UNAVAILABLE = unchecked((int)(0xC000080B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CORRUPT_LOG_DELETED_FULL"]/*' />
    [NativeTypeName("#define STATUS_CORRUPT_LOG_DELETED_FULL ((NTSTATUS)0xC000080CL)")]
    public const int STATUS_CORRUPT_LOG_DELETED_FULL = unchecked((int)(0xC000080C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CORRUPT_LOG_CLEARED"]/*' />
    [NativeTypeName("#define STATUS_CORRUPT_LOG_CLEARED ((NTSTATUS)0xC000080DL)")]
    public const int STATUS_CORRUPT_LOG_CLEARED = unchecked((int)(0xC000080D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ORPHAN_NAME_EXHAUSTED"]/*' />
    [NativeTypeName("#define STATUS_ORPHAN_NAME_EXHAUSTED ((NTSTATUS)0xC000080EL)")]
    public const int STATUS_ORPHAN_NAME_EXHAUSTED = unchecked((int)(0xC000080E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROACTIVE_SCAN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_PROACTIVE_SCAN_IN_PROGRESS ((NTSTATUS)0xC000080FL)")]
    public const int STATUS_PROACTIVE_SCAN_IN_PROGRESS = unchecked((int)(0xC000080F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCRYPTED_IO_NOT_POSSIBLE"]/*' />
    [NativeTypeName("#define STATUS_ENCRYPTED_IO_NOT_POSSIBLE ((NTSTATUS)0xC0000810L)")]
    public const int STATUS_ENCRYPTED_IO_NOT_POSSIBLE = unchecked((int)(0xC0000810));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CORRUPT_LOG_UPLEVEL_RECORDS"]/*' />
    [NativeTypeName("#define STATUS_CORRUPT_LOG_UPLEVEL_RECORDS ((NTSTATUS)0xC0000811L)")]
    public const int STATUS_CORRUPT_LOG_UPLEVEL_RECORDS = unchecked((int)(0xC0000811));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_CHECKED_OUT"]/*' />
    [NativeTypeName("#define STATUS_FILE_CHECKED_OUT ((NTSTATUS)0xC0000901L)")]
    public const int STATUS_FILE_CHECKED_OUT = unchecked((int)(0xC0000901));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CHECKOUT_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_CHECKOUT_REQUIRED ((NTSTATUS)0xC0000902L)")]
    public const int STATUS_CHECKOUT_REQUIRED = unchecked((int)(0xC0000902));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_FILE_TYPE"]/*' />
    [NativeTypeName("#define STATUS_BAD_FILE_TYPE ((NTSTATUS)0xC0000903L)")]
    public const int STATUS_BAD_FILE_TYPE = unchecked((int)(0xC0000903));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_TOO_LARGE"]/*' />
    [NativeTypeName("#define STATUS_FILE_TOO_LARGE ((NTSTATUS)0xC0000904L)")]
    public const int STATUS_FILE_TOO_LARGE = unchecked((int)(0xC0000904));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FORMS_AUTH_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_FORMS_AUTH_REQUIRED ((NTSTATUS)0xC0000905L)")]
    public const int STATUS_FORMS_AUTH_REQUIRED = unchecked((int)(0xC0000905));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRUS_INFECTED"]/*' />
    [NativeTypeName("#define STATUS_VIRUS_INFECTED ((NTSTATUS)0xC0000906L)")]
    public const int STATUS_VIRUS_INFECTED = unchecked((int)(0xC0000906));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRUS_DELETED"]/*' />
    [NativeTypeName("#define STATUS_VIRUS_DELETED ((NTSTATUS)0xC0000907L)")]
    public const int STATUS_VIRUS_DELETED = unchecked((int)(0xC0000907));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_MCFG_TABLE"]/*' />
    [NativeTypeName("#define STATUS_BAD_MCFG_TABLE ((NTSTATUS)0xC0000908L)")]
    public const int STATUS_BAD_MCFG_TABLE = unchecked((int)(0xC0000908));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_BREAK_OPLOCK"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_BREAK_OPLOCK ((NTSTATUS)0xC0000909L)")]
    public const int STATUS_CANNOT_BREAK_OPLOCK = unchecked((int)(0xC0000909));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_KEY"]/*' />
    [NativeTypeName("#define STATUS_BAD_KEY ((NTSTATUS)0xC000090AL)")]
    public const int STATUS_BAD_KEY = unchecked((int)(0xC000090A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BAD_DATA"]/*' />
    [NativeTypeName("#define STATUS_BAD_DATA ((NTSTATUS)0xC000090BL)")]
    public const int STATUS_BAD_DATA = unchecked((int)(0xC000090B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_KEY"]/*' />
    [NativeTypeName("#define STATUS_NO_KEY ((NTSTATUS)0xC000090CL)")]
    public const int STATUS_NO_KEY = unchecked((int)(0xC000090C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_HANDLE_REVOKED"]/*' />
    [NativeTypeName("#define STATUS_FILE_HANDLE_REVOKED ((NTSTATUS)0xC0000910L)")]
    public const int STATUS_FILE_HANDLE_REVOKED = unchecked((int)(0xC0000910));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECTION_DIRECT_MAP_ONLY"]/*' />
    [NativeTypeName("#define STATUS_SECTION_DIRECT_MAP_ONLY ((NTSTATUS)0xC0000911L)")]
    public const int STATUS_SECTION_DIRECT_MAP_ONLY = unchecked((int)(0xC0000911));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BLOCK_WEAK_REFERENCE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_BLOCK_WEAK_REFERENCE_INVALID ((NTSTATUS)0xC0000912L)")]
    public const int STATUS_BLOCK_WEAK_REFERENCE_INVALID = unchecked((int)(0xC0000912));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BLOCK_SOURCE_WEAK_REFERENCE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_BLOCK_SOURCE_WEAK_REFERENCE_INVALID ((NTSTATUS)0xC0000913L)")]
    public const int STATUS_BLOCK_SOURCE_WEAK_REFERENCE_INVALID = unchecked((int)(0xC0000913));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BLOCK_TARGET_WEAK_REFERENCE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_BLOCK_TARGET_WEAK_REFERENCE_INVALID ((NTSTATUS)0xC0000914L)")]
    public const int STATUS_BLOCK_TARGET_WEAK_REFERENCE_INVALID = unchecked((int)(0xC0000914));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BLOCK_SHARED"]/*' />
    [NativeTypeName("#define STATUS_BLOCK_SHARED ((NTSTATUS)0xC0000915L)")]
    public const int STATUS_BLOCK_SHARED = unchecked((int)(0xC0000915));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_FILE_NOT_SUPPORTED ((NTSTATUS)0xC0000916L)")]
    public const int STATUS_SYSTEM_FILE_NOT_SUPPORTED = unchecked((int)(0xC0000916));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VRF_VOLATILE_CFG_AND_IO_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_VRF_VOLATILE_CFG_AND_IO_ENABLED ((NTSTATUS)0xC0000C08L)")]
    public const int STATUS_VRF_VOLATILE_CFG_AND_IO_ENABLED = unchecked((int)(0xC0000C08));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VRF_VOLATILE_NOT_STOPPABLE"]/*' />
    [NativeTypeName("#define STATUS_VRF_VOLATILE_NOT_STOPPABLE ((NTSTATUS)0xC0000C09L)")]
    public const int STATUS_VRF_VOLATILE_NOT_STOPPABLE = unchecked((int)(0xC0000C09));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VRF_VOLATILE_SAFE_MODE"]/*' />
    [NativeTypeName("#define STATUS_VRF_VOLATILE_SAFE_MODE ((NTSTATUS)0xC0000C0AL)")]
    public const int STATUS_VRF_VOLATILE_SAFE_MODE = unchecked((int)(0xC0000C0A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VRF_VOLATILE_NOT_RUNNABLE_SYSTEM"]/*' />
    [NativeTypeName("#define STATUS_VRF_VOLATILE_NOT_RUNNABLE_SYSTEM ((NTSTATUS)0xC0000C0BL)")]
    public const int STATUS_VRF_VOLATILE_NOT_RUNNABLE_SYSTEM = unchecked((int)(0xC0000C0B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VRF_VOLATILE_NOT_SUPPORTED_RULECLASS"]/*' />
    [NativeTypeName("#define STATUS_VRF_VOLATILE_NOT_SUPPORTED_RULECLASS ((NTSTATUS)0xC0000C0CL)")]
    public const int STATUS_VRF_VOLATILE_NOT_SUPPORTED_RULECLASS = unchecked((int)(0xC0000C0C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VRF_VOLATILE_PROTECTED_DRIVER"]/*' />
    [NativeTypeName("#define STATUS_VRF_VOLATILE_PROTECTED_DRIVER ((NTSTATUS)0xC0000C0DL)")]
    public const int STATUS_VRF_VOLATILE_PROTECTED_DRIVER = unchecked((int)(0xC0000C0D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VRF_VOLATILE_NMI_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_VRF_VOLATILE_NMI_REGISTERED ((NTSTATUS)0xC0000C0EL)")]
    public const int STATUS_VRF_VOLATILE_NMI_REGISTERED = unchecked((int)(0xC0000C0E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VRF_VOLATILE_SETTINGS_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_VRF_VOLATILE_SETTINGS_CONFLICT ((NTSTATUS)0xC0000C0FL)")]
    public const int STATUS_VRF_VOLATILE_SETTINGS_CONFLICT = unchecked((int)(0xC0000C0F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CAR_LKD_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_CAR_LKD_IN_PROGRESS ((NTSTATUS)0xC0000C10L)")]
    public const int STATUS_CAR_LKD_IN_PROGRESS = unchecked((int)(0xC0000C10));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_ZERO_SIZE_INFORMATION"]/*' />
    [NativeTypeName("#define STATUS_DIF_ZERO_SIZE_INFORMATION ((NTSTATUS)0xC0000C73L)")]
    public const int STATUS_DIF_ZERO_SIZE_INFORMATION = unchecked((int)(0xC0000C73));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_DRIVER_PLUGIN_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_DIF_DRIVER_PLUGIN_MISMATCH ((NTSTATUS)0xC0000C74L)")]
    public const int STATUS_DIF_DRIVER_PLUGIN_MISMATCH = unchecked((int)(0xC0000C74));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_DRIVER_THUNKS_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_DIF_DRIVER_THUNKS_NOT_ALLOWED ((NTSTATUS)0xC0000C75L)")]
    public const int STATUS_DIF_DRIVER_THUNKS_NOT_ALLOWED = unchecked((int)(0xC0000C75));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_IOCALLBACK_NOT_REPLACED"]/*' />
    [NativeTypeName("#define STATUS_DIF_IOCALLBACK_NOT_REPLACED ((NTSTATUS)0xC0000C76L)")]
    public const int STATUS_DIF_IOCALLBACK_NOT_REPLACED = unchecked((int)(0xC0000C76));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_LIVEDUMP_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_DIF_LIVEDUMP_LIMIT_EXCEEDED ((NTSTATUS)0xC0000C77L)")]
    public const int STATUS_DIF_LIVEDUMP_LIMIT_EXCEEDED = unchecked((int)(0xC0000C77));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_VOLATILE_SECTION_NOT_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_DIF_VOLATILE_SECTION_NOT_LOCKED ((NTSTATUS)0xC0000C78L)")]
    public const int STATUS_DIF_VOLATILE_SECTION_NOT_LOCKED = unchecked((int)(0xC0000C78));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_VOLATILE_DRIVER_HOTPATCHED"]/*' />
    [NativeTypeName("#define STATUS_DIF_VOLATILE_DRIVER_HOTPATCHED ((NTSTATUS)0xC0000C79L)")]
    public const int STATUS_DIF_VOLATILE_DRIVER_HOTPATCHED = unchecked((int)(0xC0000C79));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_VOLATILE_INVALID_INFO"]/*' />
    [NativeTypeName("#define STATUS_DIF_VOLATILE_INVALID_INFO ((NTSTATUS)0xC0000C7AL)")]
    public const int STATUS_DIF_VOLATILE_INVALID_INFO = unchecked((int)(0xC0000C7A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_VOLATILE_DRIVER_IS_NOT_RUNNING"]/*' />
    [NativeTypeName("#define STATUS_DIF_VOLATILE_DRIVER_IS_NOT_RUNNING ((NTSTATUS)0xC0000C7BL)")]
    public const int STATUS_DIF_VOLATILE_DRIVER_IS_NOT_RUNNING = unchecked((int)(0xC0000C7B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_VOLATILE_PLUGIN_IS_NOT_RUNNING"]/*' />
    [NativeTypeName("#define STATUS_DIF_VOLATILE_PLUGIN_IS_NOT_RUNNING ((NTSTATUS)0xC0000C7CL)")]
    public const int STATUS_DIF_VOLATILE_PLUGIN_IS_NOT_RUNNING = unchecked((int)(0xC0000C7C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_VOLATILE_PLUGIN_CHANGE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_DIF_VOLATILE_PLUGIN_CHANGE_NOT_ALLOWED ((NTSTATUS)0xC0000C7DL)")]
    public const int STATUS_DIF_VOLATILE_PLUGIN_CHANGE_NOT_ALLOWED = unchecked((int)(0xC0000C7D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_VOLATILE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_DIF_VOLATILE_NOT_ALLOWED ((NTSTATUS)0xC0000C7EL)")]
    public const int STATUS_DIF_VOLATILE_NOT_ALLOWED = unchecked((int)(0xC0000C7E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIF_BINDING_API_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_DIF_BINDING_API_NOT_FOUND ((NTSTATUS)0xC0000C7FL)")]
    public const int STATUS_DIF_BINDING_API_NOT_FOUND = unchecked((int)(0xC0000C7F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WOW_ASSERTION"]/*' />
    [NativeTypeName("#define STATUS_WOW_ASSERTION ((NTSTATUS)0xC0009898L)")]
    public const int STATUS_WOW_ASSERTION = unchecked((int)(0xC0009898));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_SIGNATURE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_SIGNATURE ((NTSTATUS)0xC000A000L)")]
    public const int STATUS_INVALID_SIGNATURE = unchecked((int)(0xC000A000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HMAC_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_HMAC_NOT_SUPPORTED ((NTSTATUS)0xC000A001L)")]
    public const int STATUS_HMAC_NOT_SUPPORTED = unchecked((int)(0xC000A001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AUTH_TAG_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_AUTH_TAG_MISMATCH ((NTSTATUS)0xC000A002L)")]
    public const int STATUS_AUTH_TAG_MISMATCH = unchecked((int)(0xC000A002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_STATE_TRANSITION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_STATE_TRANSITION ((NTSTATUS)0xC000A003L)")]
    public const int STATUS_INVALID_STATE_TRANSITION = unchecked((int)(0xC000A003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_KERNEL_INFO_VERSION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_KERNEL_INFO_VERSION ((NTSTATUS)0xC000A004L)")]
    public const int STATUS_INVALID_KERNEL_INFO_VERSION = unchecked((int)(0xC000A004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PEP_INFO_VERSION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PEP_INFO_VERSION ((NTSTATUS)0xC000A005L)")]
    public const int STATUS_INVALID_PEP_INFO_VERSION = unchecked((int)(0xC000A005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HANDLE_REVOKED"]/*' />
    [NativeTypeName("#define STATUS_HANDLE_REVOKED ((NTSTATUS)0xC000A006L)")]
    public const int STATUS_HANDLE_REVOKED = unchecked((int)(0xC000A006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EOF_ON_GHOSTED_RANGE"]/*' />
    [NativeTypeName("#define STATUS_EOF_ON_GHOSTED_RANGE ((NTSTATUS)0xC000A007L)")]
    public const int STATUS_EOF_ON_GHOSTED_RANGE = unchecked((int)(0xC000A007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CC_NEEDS_CALLBACK_SECTION_DRAIN"]/*' />
    [NativeTypeName("#define STATUS_CC_NEEDS_CALLBACK_SECTION_DRAIN ((NTSTATUS)0xC000A008L)")]
    public const int STATUS_CC_NEEDS_CALLBACK_SECTION_DRAIN = unchecked((int)(0xC000A008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FIPS_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_FIPS_FAILURE ((NTSTATUS)0xC000A009L)")]
    public const int STATUS_FIPS_FAILURE = unchecked((int)(0xC000A009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_QUEUE_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_QUEUE_OVERFLOW ((NTSTATUS)0xC000A010L)")]
    public const int STATUS_IPSEC_QUEUE_OVERFLOW = unchecked((int)(0xC000A010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ND_QUEUE_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_ND_QUEUE_OVERFLOW ((NTSTATUS)0xC000A011L)")]
    public const int STATUS_ND_QUEUE_OVERFLOW = unchecked((int)(0xC000A011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HOPLIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_HOPLIMIT_EXCEEDED ((NTSTATUS)0xC000A012L)")]
    public const int STATUS_HOPLIMIT_EXCEEDED = unchecked((int)(0xC000A012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PROTOCOL_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_PROTOCOL_NOT_SUPPORTED ((NTSTATUS)0xC000A013L)")]
    public const int STATUS_PROTOCOL_NOT_SUPPORTED = unchecked((int)(0xC000A013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FASTPATH_REJECTED"]/*' />
    [NativeTypeName("#define STATUS_FASTPATH_REJECTED ((NTSTATUS)0xC000A014L)")]
    public const int STATUS_FASTPATH_REJECTED = unchecked((int)(0xC000A014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED"]/*' />
    [NativeTypeName("#define STATUS_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED ((NTSTATUS)0xC000A080L)")]
    public const int STATUS_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED = unchecked((int)(0xC000A080));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR"]/*' />
    [NativeTypeName("#define STATUS_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR ((NTSTATUS)0xC000A081L)")]
    public const int STATUS_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR = unchecked((int)(0xC000A081));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR"]/*' />
    [NativeTypeName("#define STATUS_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR ((NTSTATUS)0xC000A082L)")]
    public const int STATUS_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR = unchecked((int)(0xC000A082));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_XML_PARSE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_XML_PARSE_ERROR ((NTSTATUS)0xC000A083L)")]
    public const int STATUS_XML_PARSE_ERROR = unchecked((int)(0xC000A083));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_XMLDSIG_ERROR"]/*' />
    [NativeTypeName("#define STATUS_XMLDSIG_ERROR ((NTSTATUS)0xC000A084L)")]
    public const int STATUS_XMLDSIG_ERROR = unchecked((int)(0xC000A084));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WRONG_COMPARTMENT"]/*' />
    [NativeTypeName("#define STATUS_WRONG_COMPARTMENT ((NTSTATUS)0xC000A085L)")]
    public const int STATUS_WRONG_COMPARTMENT = unchecked((int)(0xC000A085));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AUTHIP_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_AUTHIP_FAILURE ((NTSTATUS)0xC000A086L)")]
    public const int STATUS_AUTHIP_FAILURE = unchecked((int)(0xC000A086));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS"]/*' />
    [NativeTypeName("#define STATUS_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS ((NTSTATUS)0xC000A087L)")]
    public const int STATUS_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS = unchecked((int)(0xC000A087));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_OID_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_DS_OID_NOT_FOUND ((NTSTATUS)0xC000A088L)")]
    public const int STATUS_DS_OID_NOT_FOUND = unchecked((int)(0xC000A088));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INCORRECT_ACCOUNT_TYPE"]/*' />
    [NativeTypeName("#define STATUS_INCORRECT_ACCOUNT_TYPE ((NTSTATUS)0xC000A089L)")]
    public const int STATUS_INCORRECT_ACCOUNT_TYPE = unchecked((int)(0xC000A089));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOCAL_POLICY_MODIFICATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_LOCAL_POLICY_MODIFICATION_NOT_SUPPORTED ((NTSTATUS)0xC000A08AL)")]
    public const int STATUS_LOCAL_POLICY_MODIFICATION_NOT_SUPPORTED = unchecked((int)(0xC000A08A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_POLICY_CONTROLLED_ACCOUNT"]/*' />
    [NativeTypeName("#define STATUS_POLICY_CONTROLLED_ACCOUNT ((NTSTATUS)0xC000A08BL)")]
    public const int STATUS_POLICY_CONTROLLED_ACCOUNT = unchecked((int)(0xC000A08B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LAPS_LEGACY_SCHEMA_MISSING"]/*' />
    [NativeTypeName("#define STATUS_LAPS_LEGACY_SCHEMA_MISSING ((NTSTATUS)0xC000A08CL)")]
    public const int STATUS_LAPS_LEGACY_SCHEMA_MISSING = unchecked((int)(0xC000A08C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LAPS_SCHEMA_MISSING"]/*' />
    [NativeTypeName("#define STATUS_LAPS_SCHEMA_MISSING ((NTSTATUS)0xC000A08DL)")]
    public const int STATUS_LAPS_SCHEMA_MISSING = unchecked((int)(0xC000A08D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LAPS_ENCRYPTION_REQUIRES_2016_DFL"]/*' />
    [NativeTypeName("#define STATUS_LAPS_ENCRYPTION_REQUIRES_2016_DFL ((NTSTATUS)0xC000A08EL)")]
    public const int STATUS_LAPS_ENCRYPTION_REQUIRES_2016_DFL = unchecked((int)(0xC000A08E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LAPS_PROCESS_TERMINATED"]/*' />
    [NativeTypeName("#define STATUS_LAPS_PROCESS_TERMINATED ((NTSTATUS)0x8000A08FL)")]
    public const int STATUS_LAPS_PROCESS_TERMINATED = unchecked((int)(0x8000A08F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_JET_RECORD_TOO_BIG"]/*' />
    [NativeTypeName("#define STATUS_DS_JET_RECORD_TOO_BIG ((NTSTATUS)0xC000A090L)")]
    public const int STATUS_DS_JET_RECORD_TOO_BIG = unchecked((int)(0xC000A090));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DS_REPLICA_PAGE_SIZE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_DS_REPLICA_PAGE_SIZE_MISMATCH ((NTSTATUS)0xC000A091L)")]
    public const int STATUS_DS_REPLICA_PAGE_SIZE_MISMATCH = unchecked((int)(0xC000A091));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HASH_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_HASH_NOT_SUPPORTED ((NTSTATUS)0xC000A100L)")]
    public const int STATUS_HASH_NOT_SUPPORTED = unchecked((int)(0xC000A100));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HASH_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_HASH_NOT_PRESENT ((NTSTATUS)0xC000A101L)")]
    public const int STATUS_HASH_NOT_PRESENT = unchecked((int)(0xC000A101));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECONDARY_IC_PROVIDER_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_SECONDARY_IC_PROVIDER_NOT_REGISTERED ((NTSTATUS)0xC000A121L)")]
    public const int STATUS_SECONDARY_IC_PROVIDER_NOT_REGISTERED = unchecked((int)(0xC000A121));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GPIO_CLIENT_INFORMATION_INVALID"]/*' />
    [NativeTypeName("#define STATUS_GPIO_CLIENT_INFORMATION_INVALID ((NTSTATUS)0xC000A122L)")]
    public const int STATUS_GPIO_CLIENT_INFORMATION_INVALID = unchecked((int)(0xC000A122));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GPIO_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GPIO_VERSION_NOT_SUPPORTED ((NTSTATUS)0xC000A123L)")]
    public const int STATUS_GPIO_VERSION_NOT_SUPPORTED = unchecked((int)(0xC000A123));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GPIO_INVALID_REGISTRATION_PACKET"]/*' />
    [NativeTypeName("#define STATUS_GPIO_INVALID_REGISTRATION_PACKET ((NTSTATUS)0xC000A124L)")]
    public const int STATUS_GPIO_INVALID_REGISTRATION_PACKET = unchecked((int)(0xC000A124));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GPIO_OPERATION_DENIED"]/*' />
    [NativeTypeName("#define STATUS_GPIO_OPERATION_DENIED ((NTSTATUS)0xC000A125L)")]
    public const int STATUS_GPIO_OPERATION_DENIED = unchecked((int)(0xC000A125));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GPIO_INCOMPATIBLE_CONNECT_MODE"]/*' />
    [NativeTypeName("#define STATUS_GPIO_INCOMPATIBLE_CONNECT_MODE ((NTSTATUS)0xC000A126L)")]
    public const int STATUS_GPIO_INCOMPATIBLE_CONNECT_MODE = unchecked((int)(0xC000A126));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GPIO_INTERRUPT_ALREADY_UNMASKED"]/*' />
    [NativeTypeName("#define STATUS_GPIO_INTERRUPT_ALREADY_UNMASKED ((NTSTATUS)0x8000A127L)")]
    public const int STATUS_GPIO_INTERRUPT_ALREADY_UNMASKED = unchecked((int)(0x8000A127));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_SWITCH_RUNLEVEL"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_SWITCH_RUNLEVEL ((NTSTATUS)0xC000A141L)")]
    public const int STATUS_CANNOT_SWITCH_RUNLEVEL = unchecked((int)(0xC000A141));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_RUNLEVEL_SETTING"]/*' />
    [NativeTypeName("#define STATUS_INVALID_RUNLEVEL_SETTING ((NTSTATUS)0xC000A142L)")]
    public const int STATUS_INVALID_RUNLEVEL_SETTING = unchecked((int)(0xC000A142));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RUNLEVEL_SWITCH_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_RUNLEVEL_SWITCH_TIMEOUT ((NTSTATUS)0xC000A143L)")]
    public const int STATUS_RUNLEVEL_SWITCH_TIMEOUT = unchecked((int)(0xC000A143));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SERVICES_FAILED_AUTOSTART"]/*' />
    [NativeTypeName("#define STATUS_SERVICES_FAILED_AUTOSTART ((NTSTATUS)0x4000A144L)")]
    public const int STATUS_SERVICES_FAILED_AUTOSTART = ((int)(0x4000A144));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RUNLEVEL_SWITCH_AGENT_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_RUNLEVEL_SWITCH_AGENT_TIMEOUT ((NTSTATUS)0xC000A145L)")]
    public const int STATUS_RUNLEVEL_SWITCH_AGENT_TIMEOUT = unchecked((int)(0xC000A145));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RUNLEVEL_SWITCH_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_RUNLEVEL_SWITCH_IN_PROGRESS ((NTSTATUS)0xC000A146L)")]
    public const int STATUS_RUNLEVEL_SWITCH_IN_PROGRESS = unchecked((int)(0xC000A146));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APISET_COMPOSE_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_APISET_COMPOSE_FAILURE ((NTSTATUS)0xC000A161L)")]
    public const int STATUS_APISET_COMPOSE_FAILURE = unchecked((int)(0xC000A161));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APISET_SCHEMA_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_APISET_SCHEMA_VERSION_NOT_SUPPORTED ((NTSTATUS)0xC000A162L)")]
    public const int STATUS_APISET_SCHEMA_VERSION_NOT_SUPPORTED = unchecked((int)(0xC000A162));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_APPCONTAINER"]/*' />
    [NativeTypeName("#define STATUS_NOT_APPCONTAINER ((NTSTATUS)0xC000A200L)")]
    public const int STATUS_NOT_APPCONTAINER = unchecked((int)(0xC000A200));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SUPPORTED_IN_APPCONTAINER"]/*' />
    [NativeTypeName("#define STATUS_NOT_SUPPORTED_IN_APPCONTAINER ((NTSTATUS)0xC000A201L)")]
    public const int STATUS_NOT_SUPPORTED_IN_APPCONTAINER = unchecked((int)(0xC000A201));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PACKAGE_SID_LENGTH"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PACKAGE_SID_LENGTH ((NTSTATUS)0xC000A202L)")]
    public const int STATUS_INVALID_PACKAGE_SID_LENGTH = unchecked((int)(0xC000A202));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LPAC_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_LPAC_ACCESS_DENIED ((NTSTATUS)0xC000A203L)")]
    public const int STATUS_LPAC_ACCESS_DENIED = unchecked((int)(0xC000A203));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APP_DATA_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_APP_DATA_NOT_FOUND ((NTSTATUS)0xC000A281L)")]
    public const int STATUS_APP_DATA_NOT_FOUND = unchecked((int)(0xC000A281));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APP_DATA_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_APP_DATA_EXPIRED ((NTSTATUS)0xC000A282L)")]
    public const int STATUS_APP_DATA_EXPIRED = unchecked((int)(0xC000A282));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APP_DATA_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_APP_DATA_CORRUPT ((NTSTATUS)0xC000A283L)")]
    public const int STATUS_APP_DATA_CORRUPT = unchecked((int)(0xC000A283));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APP_DATA_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_APP_DATA_LIMIT_EXCEEDED ((NTSTATUS)0xC000A284L)")]
    public const int STATUS_APP_DATA_LIMIT_EXCEEDED = unchecked((int)(0xC000A284));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APP_DATA_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_APP_DATA_REBOOT_REQUIRED ((NTSTATUS)0xC000A285L)")]
    public const int STATUS_APP_DATA_REBOOT_REQUIRED = unchecked((int)(0xC000A285));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OFFLOAD_READ_FLT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_OFFLOAD_READ_FLT_NOT_SUPPORTED ((NTSTATUS)0xC000A2A1L)")]
    public const int STATUS_OFFLOAD_READ_FLT_NOT_SUPPORTED = unchecked((int)(0xC000A2A1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OFFLOAD_WRITE_FLT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_OFFLOAD_WRITE_FLT_NOT_SUPPORTED ((NTSTATUS)0xC000A2A2L)")]
    public const int STATUS_OFFLOAD_WRITE_FLT_NOT_SUPPORTED = unchecked((int)(0xC000A2A2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OFFLOAD_READ_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_OFFLOAD_READ_FILE_NOT_SUPPORTED ((NTSTATUS)0xC000A2A3L)")]
    public const int STATUS_OFFLOAD_READ_FILE_NOT_SUPPORTED = unchecked((int)(0xC000A2A3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OFFLOAD_WRITE_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_OFFLOAD_WRITE_FILE_NOT_SUPPORTED ((NTSTATUS)0xC000A2A4L)")]
    public const int STATUS_OFFLOAD_WRITE_FILE_NOT_SUPPORTED = unchecked((int)(0xC000A2A4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WOF_WIM_HEADER_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_WOF_WIM_HEADER_CORRUPT ((NTSTATUS)0xC000A2A5L)")]
    public const int STATUS_WOF_WIM_HEADER_CORRUPT = unchecked((int)(0xC000A2A5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WOF_WIM_RESOURCE_TABLE_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_WOF_WIM_RESOURCE_TABLE_CORRUPT ((NTSTATUS)0xC000A2A6L)")]
    public const int STATUS_WOF_WIM_RESOURCE_TABLE_CORRUPT = unchecked((int)(0xC000A2A6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WOF_FILE_RESOURCE_TABLE_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_WOF_FILE_RESOURCE_TABLE_CORRUPT ((NTSTATUS)0xC000A2A7L)")]
    public const int STATUS_WOF_FILE_RESOURCE_TABLE_CORRUPT = unchecked((int)(0xC000A2A7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CIMFS_IMAGE_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_CIMFS_IMAGE_CORRUPT ((NTSTATUS)0xC000C001L)")]
    public const int STATUS_CIMFS_IMAGE_CORRUPT = unchecked((int)(0xC000C001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CIMFS_IMAGE_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_CIMFS_IMAGE_VERSION_NOT_SUPPORTED ((NTSTATUS)0xC000C002L)")]
    public const int STATUS_CIMFS_IMAGE_VERSION_NOT_SUPPORTED = unchecked((int)(0xC000C002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CIMFS_VERIFICATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_CIMFS_VERIFICATION_FAILED ((NTSTATUS)0xC000C003L)")]
    public const int STATUS_CIMFS_VERIFICATION_FAILED = unchecked((int)(0xC000C003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE ((NTSTATUS)0xC000CE01L)")]
    public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE = unchecked((int)(0xC000CE01));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT ((NTSTATUS)0xC000CE02L)")]
    public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT = unchecked((int)(0xC000CE02));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SYSTEM_VIRTUALIZATION_BUSY"]/*' />
    [NativeTypeName("#define STATUS_FILE_SYSTEM_VIRTUALIZATION_BUSY ((NTSTATUS)0xC000CE03L)")]
    public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_BUSY = unchecked((int)(0xC000CE03));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN"]/*' />
    [NativeTypeName("#define STATUS_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN ((NTSTATUS)0xC000CE04L)")]
    public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN = unchecked((int)(0xC000CE04));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION ((NTSTATUS)0xC000CE05L)")]
    public const int STATUS_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION = unchecked((int)(0xC000CE05));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT ((NTSTATUS)0xC000CF00L)")]
    public const int STATUS_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT = unchecked((int)(0xC000CF00));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_PROVIDER_NOT_RUNNING"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_PROVIDER_NOT_RUNNING ((NTSTATUS)0xC000CF01L)")]
    public const int STATUS_CLOUD_FILE_PROVIDER_NOT_RUNNING = unchecked((int)(0xC000CF01));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_METADATA_CORRUPT ((NTSTATUS)0xC000CF02L)")]
    public const int STATUS_CLOUD_FILE_METADATA_CORRUPT = unchecked((int)(0xC000CF02));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_METADATA_TOO_LARGE"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_METADATA_TOO_LARGE ((NTSTATUS)0xC000CF03L)")]
    public const int STATUS_CLOUD_FILE_METADATA_TOO_LARGE = unchecked((int)(0xC000CF03));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE ((NTSTATUS)0x8000CF04L)")]
    public const int STATUS_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE = unchecked((int)(0x8000CF04));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS ((NTSTATUS)0x8000CF05L)")]
    public const int STATUS_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS = unchecked((int)(0x8000CF05));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED ((NTSTATUS)0xC000CF06L)")]
    public const int STATUS_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED = unchecked((int)(0xC000CF06));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_A_CLOUD_FILE"]/*' />
    [NativeTypeName("#define STATUS_NOT_A_CLOUD_FILE ((NTSTATUS)0xC000CF07L)")]
    public const int STATUS_NOT_A_CLOUD_FILE = unchecked((int)(0xC000CF07));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_NOT_IN_SYNC"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_NOT_IN_SYNC ((NTSTATUS)0xC000CF08L)")]
    public const int STATUS_CLOUD_FILE_NOT_IN_SYNC = unchecked((int)(0xC000CF08));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_ALREADY_CONNECTED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_ALREADY_CONNECTED ((NTSTATUS)0xC000CF09L)")]
    public const int STATUS_CLOUD_FILE_ALREADY_CONNECTED = unchecked((int)(0xC000CF09));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_NOT_SUPPORTED ((NTSTATUS)0xC000CF0AL)")]
    public const int STATUS_CLOUD_FILE_NOT_SUPPORTED = unchecked((int)(0xC000CF0A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_INVALID_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_INVALID_REQUEST ((NTSTATUS)0xC000CF0BL)")]
    public const int STATUS_CLOUD_FILE_INVALID_REQUEST = unchecked((int)(0xC000CF0B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_READ_ONLY_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_READ_ONLY_VOLUME ((NTSTATUS)0xC000CF0CL)")]
    public const int STATUS_CLOUD_FILE_READ_ONLY_VOLUME = unchecked((int)(0xC000CF0C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_CONNECTED_PROVIDER_ONLY"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_CONNECTED_PROVIDER_ONLY ((NTSTATUS)0xC000CF0DL)")]
    public const int STATUS_CLOUD_FILE_CONNECTED_PROVIDER_ONLY = unchecked((int)(0xC000CF0D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_VALIDATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_VALIDATION_FAILED ((NTSTATUS)0xC000CF0EL)")]
    public const int STATUS_CLOUD_FILE_VALIDATION_FAILED = unchecked((int)(0xC000CF0E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_AUTHENTICATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_AUTHENTICATION_FAILED ((NTSTATUS)0xC000CF0FL)")]
    public const int STATUS_CLOUD_FILE_AUTHENTICATION_FAILED = unchecked((int)(0xC000CF0F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_INSUFFICIENT_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_INSUFFICIENT_RESOURCES ((NTSTATUS)0xC000CF10L)")]
    public const int STATUS_CLOUD_FILE_INSUFFICIENT_RESOURCES = unchecked((int)(0xC000CF10));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_NETWORK_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_NETWORK_UNAVAILABLE ((NTSTATUS)0xC000CF11L)")]
    public const int STATUS_CLOUD_FILE_NETWORK_UNAVAILABLE = unchecked((int)(0xC000CF11));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_UNSUCCESSFUL"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_UNSUCCESSFUL ((NTSTATUS)0xC000CF12L)")]
    public const int STATUS_CLOUD_FILE_UNSUCCESSFUL = unchecked((int)(0xC000CF12));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_NOT_UNDER_SYNC_ROOT"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_NOT_UNDER_SYNC_ROOT ((NTSTATUS)0xC000CF13L)")]
    public const int STATUS_CLOUD_FILE_NOT_UNDER_SYNC_ROOT = unchecked((int)(0xC000CF13));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_IN_USE ((NTSTATUS)0xC000CF14L)")]
    public const int STATUS_CLOUD_FILE_IN_USE = unchecked((int)(0xC000CF14));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_PINNED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_PINNED ((NTSTATUS)0xC000CF15L)")]
    public const int STATUS_CLOUD_FILE_PINNED = unchecked((int)(0xC000CF15));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_REQUEST_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_REQUEST_ABORTED ((NTSTATUS)0xC000CF16L)")]
    public const int STATUS_CLOUD_FILE_REQUEST_ABORTED = unchecked((int)(0xC000CF16));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_PROPERTY_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_PROPERTY_CORRUPT ((NTSTATUS)0xC000CF17L)")]
    public const int STATUS_CLOUD_FILE_PROPERTY_CORRUPT = unchecked((int)(0xC000CF17));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_ACCESS_DENIED ((NTSTATUS)0xC000CF18L)")]
    public const int STATUS_CLOUD_FILE_ACCESS_DENIED = unchecked((int)(0xC000CF18));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_INCOMPATIBLE_HARDLINKS"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_INCOMPATIBLE_HARDLINKS ((NTSTATUS)0xC000CF19L)")]
    public const int STATUS_CLOUD_FILE_INCOMPATIBLE_HARDLINKS = unchecked((int)(0xC000CF19));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_PROPERTY_LOCK_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_PROPERTY_LOCK_CONFLICT ((NTSTATUS)0xC000CF1AL)")]
    public const int STATUS_CLOUD_FILE_PROPERTY_LOCK_CONFLICT = unchecked((int)(0xC000CF1A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_REQUEST_CANCELED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_REQUEST_CANCELED ((NTSTATUS)0xC000CF1BL)")]
    public const int STATUS_CLOUD_FILE_REQUEST_CANCELED = unchecked((int)(0xC000CF1B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_PROVIDER_TERMINATED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_PROVIDER_TERMINATED ((NTSTATUS)0xC000CF1DL)")]
    public const int STATUS_CLOUD_FILE_PROVIDER_TERMINATED = unchecked((int)(0xC000CF1D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_A_CLOUD_SYNC_ROOT"]/*' />
    [NativeTypeName("#define STATUS_NOT_A_CLOUD_SYNC_ROOT ((NTSTATUS)0xC000CF1EL)")]
    public const int STATUS_NOT_A_CLOUD_SYNC_ROOT = unchecked((int)(0xC000CF1E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_REQUEST_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_REQUEST_TIMEOUT ((NTSTATUS)0xC000CF1FL)")]
    public const int STATUS_CLOUD_FILE_REQUEST_TIMEOUT = unchecked((int)(0xC000CF1F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_DEHYDRATION_DISALLOWED"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_DEHYDRATION_DISALLOWED ((NTSTATUS)0xC000CF20L)")]
    public const int STATUS_CLOUD_FILE_DEHYDRATION_DISALLOWED = unchecked((int)(0xC000CF20));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_US_MESSAGE_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_US_MESSAGE_TIMEOUT ((NTSTATUS)0xC000CF21L)")]
    public const int STATUS_CLOUD_FILE_US_MESSAGE_TIMEOUT = unchecked((int)(0xC000CF21));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLOUD_FILE_HYDRATION_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_CLOUD_FILE_HYDRATION_NOT_AVAILABLE ((NTSTATUS)0xC000CF22L)")]
    public const int STATUS_CLOUD_FILE_HYDRATION_NOT_AVAILABLE = unchecked((int)(0xC000CF22));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SNAP_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_FILE_SNAP_IN_PROGRESS ((NTSTATUS)0xC000F500L)")]
    public const int STATUS_FILE_SNAP_IN_PROGRESS = unchecked((int)(0xC000F500));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SNAP_USER_SECTION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_FILE_SNAP_USER_SECTION_NOT_SUPPORTED ((NTSTATUS)0xC000F501L)")]
    public const int STATUS_FILE_SNAP_USER_SECTION_NOT_SUPPORTED = unchecked((int)(0xC000F501));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SNAP_MODIFY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_FILE_SNAP_MODIFY_NOT_SUPPORTED ((NTSTATUS)0xC000F502L)")]
    public const int STATUS_FILE_SNAP_MODIFY_NOT_SUPPORTED = unchecked((int)(0xC000F502));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SNAP_IO_NOT_COORDINATED"]/*' />
    [NativeTypeName("#define STATUS_FILE_SNAP_IO_NOT_COORDINATED ((NTSTATUS)0xC000F503L)")]
    public const int STATUS_FILE_SNAP_IO_NOT_COORDINATED = unchecked((int)(0xC000F503));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SNAP_UNEXPECTED_ERROR"]/*' />
    [NativeTypeName("#define STATUS_FILE_SNAP_UNEXPECTED_ERROR ((NTSTATUS)0xC000F504L)")]
    public const int STATUS_FILE_SNAP_UNEXPECTED_ERROR = unchecked((int)(0xC000F504));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_SNAP_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_FILE_SNAP_INVALID_PARAMETER ((NTSTATUS)0xC000F505L)")]
    public const int STATUS_FILE_SNAP_INVALID_PARAMETER = unchecked((int)(0xC000F505));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_CANNOT_CROSS_UNION"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_CANNOT_CROSS_UNION ((NTSTATUS)0xC0ED0001L)")]
    public const int STATUS_UNIONFS_CANNOT_CROSS_UNION = unchecked((int)(0xC0ED0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_CANNOT_EXIT_UNION"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_CANNOT_EXIT_UNION ((NTSTATUS)0xC0ED0002L)")]
    public const int STATUS_UNIONFS_CANNOT_EXIT_UNION = unchecked((int)(0xC0ED0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_CANNOT_PRESERVE_LINK"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_CANNOT_PRESERVE_LINK ((NTSTATUS)0xC0ED0003L)")]
    public const int STATUS_UNIONFS_CANNOT_PRESERVE_LINK = unchecked((int)(0xC0ED0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_INVALID_TOMBSTONE_STATE"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_INVALID_TOMBSTONE_STATE ((NTSTATUS)0xC0ED0004L)")]
    public const int STATUS_UNIONFS_INVALID_TOMBSTONE_STATE = unchecked((int)(0xC0ED0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_LAYERS_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_LAYERS_PRESENT ((NTSTATUS)0xC0ED0005L)")]
    public const int STATUS_UNIONFS_LAYERS_PRESENT = unchecked((int)(0xC0ED0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_NESTED_LAYER"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_NESTED_LAYER ((NTSTATUS)0xC0ED0006L)")]
    public const int STATUS_UNIONFS_NESTED_LAYER = unchecked((int)(0xC0ED0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_UNION_DUPLICATE_ID"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_UNION_DUPLICATE_ID ((NTSTATUS)0xC0ED0007L)")]
    public const int STATUS_UNIONFS_UNION_DUPLICATE_ID = unchecked((int)(0xC0ED0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_INACTIVE_UNION"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_INACTIVE_UNION ((NTSTATUS)0xC0ED0008L)")]
    public const int STATUS_UNIONFS_INACTIVE_UNION = unchecked((int)(0xC0ED0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_TOO_MANY_LAYERS"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_TOO_MANY_LAYERS ((NTSTATUS)0xC0ED0009L)")]
    public const int STATUS_UNIONFS_TOO_MANY_LAYERS = unchecked((int)(0xC0ED0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_TOO_LATE"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_TOO_LATE ((NTSTATUS)0xC0ED000AL)")]
    public const int STATUS_UNIONFS_TOO_LATE = unchecked((int)(0xC0ED000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_NESTED_UNION"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_NESTED_UNION ((NTSTATUS)0xC0ED000BL)")]
    public const int STATUS_UNIONFS_NESTED_UNION = unchecked((int)(0xC0ED000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_NESTED_UNION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_NESTED_UNION_NOT_ALLOWED ((NTSTATUS)0xC0ED000CL)")]
    public const int STATUS_UNIONFS_NESTED_UNION_NOT_ALLOWED = unchecked((int)(0xC0ED000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNIONFS_BOOT_LAYER_NOT_ATTACHED"]/*' />
    [NativeTypeName("#define STATUS_UNIONFS_BOOT_LAYER_NOT_ATTACHED ((NTSTATUS)0xC0ED000DL)")]
    public const int STATUS_UNIONFS_BOOT_LAYER_NOT_ATTACHED = unchecked((int)(0xC0ED000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_OPCODE"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_OPCODE ((NTSTATUS)0xC0140001L)")]
    public const int STATUS_ACPI_INVALID_OPCODE = unchecked((int)(0xC0140001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_STACK_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_ACPI_STACK_OVERFLOW ((NTSTATUS)0xC0140002L)")]
    public const int STATUS_ACPI_STACK_OVERFLOW = unchecked((int)(0xC0140002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_ASSERT_FAILED"]/*' />
    [NativeTypeName("#define STATUS_ACPI_ASSERT_FAILED ((NTSTATUS)0xC0140003L)")]
    public const int STATUS_ACPI_ASSERT_FAILED = unchecked((int)(0xC0140003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_INDEX"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_INDEX ((NTSTATUS)0xC0140004L)")]
    public const int STATUS_ACPI_INVALID_INDEX = unchecked((int)(0xC0140004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_ARGUMENT"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_ARGUMENT ((NTSTATUS)0xC0140005L)")]
    public const int STATUS_ACPI_INVALID_ARGUMENT = unchecked((int)(0xC0140005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_FATAL"]/*' />
    [NativeTypeName("#define STATUS_ACPI_FATAL ((NTSTATUS)0xC0140006L)")]
    public const int STATUS_ACPI_FATAL = unchecked((int)(0xC0140006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_SUPERNAME"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_SUPERNAME ((NTSTATUS)0xC0140007L)")]
    public const int STATUS_ACPI_INVALID_SUPERNAME = unchecked((int)(0xC0140007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_ARGTYPE"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_ARGTYPE ((NTSTATUS)0xC0140008L)")]
    public const int STATUS_ACPI_INVALID_ARGTYPE = unchecked((int)(0xC0140008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_OBJTYPE"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_OBJTYPE ((NTSTATUS)0xC0140009L)")]
    public const int STATUS_ACPI_INVALID_OBJTYPE = unchecked((int)(0xC0140009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_TARGETTYPE"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_TARGETTYPE ((NTSTATUS)0xC014000AL)")]
    public const int STATUS_ACPI_INVALID_TARGETTYPE = unchecked((int)(0xC014000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INCORRECT_ARGUMENT_COUNT"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INCORRECT_ARGUMENT_COUNT ((NTSTATUS)0xC014000BL)")]
    public const int STATUS_ACPI_INCORRECT_ARGUMENT_COUNT = unchecked((int)(0xC014000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_ADDRESS_NOT_MAPPED"]/*' />
    [NativeTypeName("#define STATUS_ACPI_ADDRESS_NOT_MAPPED ((NTSTATUS)0xC014000CL)")]
    public const int STATUS_ACPI_ADDRESS_NOT_MAPPED = unchecked((int)(0xC014000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_EVENTTYPE"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_EVENTTYPE ((NTSTATUS)0xC014000DL)")]
    public const int STATUS_ACPI_INVALID_EVENTTYPE = unchecked((int)(0xC014000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_HANDLER_COLLISION"]/*' />
    [NativeTypeName("#define STATUS_ACPI_HANDLER_COLLISION ((NTSTATUS)0xC014000EL)")]
    public const int STATUS_ACPI_HANDLER_COLLISION = unchecked((int)(0xC014000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_DATA"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_DATA ((NTSTATUS)0xC014000FL)")]
    public const int STATUS_ACPI_INVALID_DATA = unchecked((int)(0xC014000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_REGION"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_REGION ((NTSTATUS)0xC0140010L)")]
    public const int STATUS_ACPI_INVALID_REGION = unchecked((int)(0xC0140010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_ACCESS_SIZE"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_ACCESS_SIZE ((NTSTATUS)0xC0140011L)")]
    public const int STATUS_ACPI_INVALID_ACCESS_SIZE = unchecked((int)(0xC0140011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_ACQUIRE_GLOBAL_LOCK"]/*' />
    [NativeTypeName("#define STATUS_ACPI_ACQUIRE_GLOBAL_LOCK ((NTSTATUS)0xC0140012L)")]
    public const int STATUS_ACPI_ACQUIRE_GLOBAL_LOCK = unchecked((int)(0xC0140012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_ALREADY_INITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_ACPI_ALREADY_INITIALIZED ((NTSTATUS)0xC0140013L)")]
    public const int STATUS_ACPI_ALREADY_INITIALIZED = unchecked((int)(0xC0140013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_ACPI_NOT_INITIALIZED ((NTSTATUS)0xC0140014L)")]
    public const int STATUS_ACPI_NOT_INITIALIZED = unchecked((int)(0xC0140014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_MUTEX_LEVEL"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_MUTEX_LEVEL ((NTSTATUS)0xC0140015L)")]
    public const int STATUS_ACPI_INVALID_MUTEX_LEVEL = unchecked((int)(0xC0140015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_MUTEX_NOT_OWNED"]/*' />
    [NativeTypeName("#define STATUS_ACPI_MUTEX_NOT_OWNED ((NTSTATUS)0xC0140016L)")]
    public const int STATUS_ACPI_MUTEX_NOT_OWNED = unchecked((int)(0xC0140016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_MUTEX_NOT_OWNER"]/*' />
    [NativeTypeName("#define STATUS_ACPI_MUTEX_NOT_OWNER ((NTSTATUS)0xC0140017L)")]
    public const int STATUS_ACPI_MUTEX_NOT_OWNER = unchecked((int)(0xC0140017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_RS_ACCESS"]/*' />
    [NativeTypeName("#define STATUS_ACPI_RS_ACCESS ((NTSTATUS)0xC0140018L)")]
    public const int STATUS_ACPI_RS_ACCESS = unchecked((int)(0xC0140018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_INVALID_TABLE"]/*' />
    [NativeTypeName("#define STATUS_ACPI_INVALID_TABLE ((NTSTATUS)0xC0140019L)")]
    public const int STATUS_ACPI_INVALID_TABLE = unchecked((int)(0xC0140019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_REG_HANDLER_FAILED"]/*' />
    [NativeTypeName("#define STATUS_ACPI_REG_HANDLER_FAILED ((NTSTATUS)0xC0140020L)")]
    public const int STATUS_ACPI_REG_HANDLER_FAILED = unchecked((int)(0xC0140020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACPI_POWER_REQUEST_FAILED"]/*' />
    [NativeTypeName("#define STATUS_ACPI_POWER_REQUEST_FAILED ((NTSTATUS)0xC0140021L)")]
    public const int STATUS_ACPI_POWER_REQUEST_FAILED = unchecked((int)(0xC0140021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_WINSTATION_NAME_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CTX_WINSTATION_NAME_INVALID ((NTSTATUS)0xC00A0001L)")]
    public const int STATUS_CTX_WINSTATION_NAME_INVALID = unchecked((int)(0xC00A0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_INVALID_PD"]/*' />
    [NativeTypeName("#define STATUS_CTX_INVALID_PD ((NTSTATUS)0xC00A0002L)")]
    public const int STATUS_CTX_INVALID_PD = unchecked((int)(0xC00A0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_PD_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CTX_PD_NOT_FOUND ((NTSTATUS)0xC00A0003L)")]
    public const int STATUS_CTX_PD_NOT_FOUND = unchecked((int)(0xC00A0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_CDM_CONNECT"]/*' />
    [NativeTypeName("#define STATUS_CTX_CDM_CONNECT ((NTSTATUS)0x400A0004L)")]
    public const int STATUS_CTX_CDM_CONNECT = ((int)(0x400A0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_CDM_DISCONNECT"]/*' />
    [NativeTypeName("#define STATUS_CTX_CDM_DISCONNECT ((NTSTATUS)0x400A0005L)")]
    public const int STATUS_CTX_CDM_DISCONNECT = ((int)(0x400A0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_CLOSE_PENDING"]/*' />
    [NativeTypeName("#define STATUS_CTX_CLOSE_PENDING ((NTSTATUS)0xC00A0006L)")]
    public const int STATUS_CTX_CLOSE_PENDING = unchecked((int)(0xC00A0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_NO_OUTBUF"]/*' />
    [NativeTypeName("#define STATUS_CTX_NO_OUTBUF ((NTSTATUS)0xC00A0007L)")]
    public const int STATUS_CTX_NO_OUTBUF = unchecked((int)(0xC00A0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_MODEM_INF_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CTX_MODEM_INF_NOT_FOUND ((NTSTATUS)0xC00A0008L)")]
    public const int STATUS_CTX_MODEM_INF_NOT_FOUND = unchecked((int)(0xC00A0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_INVALID_MODEMNAME"]/*' />
    [NativeTypeName("#define STATUS_CTX_INVALID_MODEMNAME ((NTSTATUS)0xC00A0009L)")]
    public const int STATUS_CTX_INVALID_MODEMNAME = unchecked((int)(0xC00A0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_RESPONSE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_CTX_RESPONSE_ERROR ((NTSTATUS)0xC00A000AL)")]
    public const int STATUS_CTX_RESPONSE_ERROR = unchecked((int)(0xC00A000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_MODEM_RESPONSE_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_CTX_MODEM_RESPONSE_TIMEOUT ((NTSTATUS)0xC00A000BL)")]
    public const int STATUS_CTX_MODEM_RESPONSE_TIMEOUT = unchecked((int)(0xC00A000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_MODEM_RESPONSE_NO_CARRIER"]/*' />
    [NativeTypeName("#define STATUS_CTX_MODEM_RESPONSE_NO_CARRIER ((NTSTATUS)0xC00A000CL)")]
    public const int STATUS_CTX_MODEM_RESPONSE_NO_CARRIER = unchecked((int)(0xC00A000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_MODEM_RESPONSE_NO_DIALTONE"]/*' />
    [NativeTypeName("#define STATUS_CTX_MODEM_RESPONSE_NO_DIALTONE ((NTSTATUS)0xC00A000DL)")]
    public const int STATUS_CTX_MODEM_RESPONSE_NO_DIALTONE = unchecked((int)(0xC00A000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_MODEM_RESPONSE_BUSY"]/*' />
    [NativeTypeName("#define STATUS_CTX_MODEM_RESPONSE_BUSY ((NTSTATUS)0xC00A000EL)")]
    public const int STATUS_CTX_MODEM_RESPONSE_BUSY = unchecked((int)(0xC00A000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_MODEM_RESPONSE_VOICE"]/*' />
    [NativeTypeName("#define STATUS_CTX_MODEM_RESPONSE_VOICE ((NTSTATUS)0xC00A000FL)")]
    public const int STATUS_CTX_MODEM_RESPONSE_VOICE = unchecked((int)(0xC00A000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_TD_ERROR"]/*' />
    [NativeTypeName("#define STATUS_CTX_TD_ERROR ((NTSTATUS)0xC00A0010L)")]
    public const int STATUS_CTX_TD_ERROR = unchecked((int)(0xC00A0010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_LICENSE_CLIENT_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CTX_LICENSE_CLIENT_INVALID ((NTSTATUS)0xC00A0012L)")]
    public const int STATUS_CTX_LICENSE_CLIENT_INVALID = unchecked((int)(0xC00A0012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_LICENSE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_CTX_LICENSE_NOT_AVAILABLE ((NTSTATUS)0xC00A0013L)")]
    public const int STATUS_CTX_LICENSE_NOT_AVAILABLE = unchecked((int)(0xC00A0013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_LICENSE_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_CTX_LICENSE_EXPIRED ((NTSTATUS)0xC00A0014L)")]
    public const int STATUS_CTX_LICENSE_EXPIRED = unchecked((int)(0xC00A0014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_WINSTATION_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CTX_WINSTATION_NOT_FOUND ((NTSTATUS)0xC00A0015L)")]
    public const int STATUS_CTX_WINSTATION_NOT_FOUND = unchecked((int)(0xC00A0015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_WINSTATION_NAME_COLLISION"]/*' />
    [NativeTypeName("#define STATUS_CTX_WINSTATION_NAME_COLLISION ((NTSTATUS)0xC00A0016L)")]
    public const int STATUS_CTX_WINSTATION_NAME_COLLISION = unchecked((int)(0xC00A0016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_WINSTATION_BUSY"]/*' />
    [NativeTypeName("#define STATUS_CTX_WINSTATION_BUSY ((NTSTATUS)0xC00A0017L)")]
    public const int STATUS_CTX_WINSTATION_BUSY = unchecked((int)(0xC00A0017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_BAD_VIDEO_MODE"]/*' />
    [NativeTypeName("#define STATUS_CTX_BAD_VIDEO_MODE ((NTSTATUS)0xC00A0018L)")]
    public const int STATUS_CTX_BAD_VIDEO_MODE = unchecked((int)(0xC00A0018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_GRAPHICS_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CTX_GRAPHICS_INVALID ((NTSTATUS)0xC00A0022L)")]
    public const int STATUS_CTX_GRAPHICS_INVALID = unchecked((int)(0xC00A0022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_NOT_CONSOLE"]/*' />
    [NativeTypeName("#define STATUS_CTX_NOT_CONSOLE ((NTSTATUS)0xC00A0024L)")]
    public const int STATUS_CTX_NOT_CONSOLE = unchecked((int)(0xC00A0024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_CLIENT_QUERY_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_CTX_CLIENT_QUERY_TIMEOUT ((NTSTATUS)0xC00A0026L)")]
    public const int STATUS_CTX_CLIENT_QUERY_TIMEOUT = unchecked((int)(0xC00A0026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_CONSOLE_DISCONNECT"]/*' />
    [NativeTypeName("#define STATUS_CTX_CONSOLE_DISCONNECT ((NTSTATUS)0xC00A0027L)")]
    public const int STATUS_CTX_CONSOLE_DISCONNECT = unchecked((int)(0xC00A0027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_CONSOLE_CONNECT"]/*' />
    [NativeTypeName("#define STATUS_CTX_CONSOLE_CONNECT ((NTSTATUS)0xC00A0028L)")]
    public const int STATUS_CTX_CONSOLE_CONNECT = unchecked((int)(0xC00A0028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_SHADOW_DENIED"]/*' />
    [NativeTypeName("#define STATUS_CTX_SHADOW_DENIED ((NTSTATUS)0xC00A002AL)")]
    public const int STATUS_CTX_SHADOW_DENIED = unchecked((int)(0xC00A002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_WINSTATION_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_CTX_WINSTATION_ACCESS_DENIED ((NTSTATUS)0xC00A002BL)")]
    public const int STATUS_CTX_WINSTATION_ACCESS_DENIED = unchecked((int)(0xC00A002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_INVALID_WD"]/*' />
    [NativeTypeName("#define STATUS_CTX_INVALID_WD ((NTSTATUS)0xC00A002EL)")]
    public const int STATUS_CTX_INVALID_WD = unchecked((int)(0xC00A002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_WD_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CTX_WD_NOT_FOUND ((NTSTATUS)0xC00A002FL)")]
    public const int STATUS_CTX_WD_NOT_FOUND = unchecked((int)(0xC00A002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_SHADOW_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CTX_SHADOW_INVALID ((NTSTATUS)0xC00A0030L)")]
    public const int STATUS_CTX_SHADOW_INVALID = unchecked((int)(0xC00A0030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_SHADOW_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_CTX_SHADOW_DISABLED ((NTSTATUS)0xC00A0031L)")]
    public const int STATUS_CTX_SHADOW_DISABLED = unchecked((int)(0xC00A0031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RDP_PROTOCOL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_RDP_PROTOCOL_ERROR ((NTSTATUS)0xC00A0032L)")]
    public const int STATUS_RDP_PROTOCOL_ERROR = unchecked((int)(0xC00A0032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_CLIENT_LICENSE_NOT_SET"]/*' />
    [NativeTypeName("#define STATUS_CTX_CLIENT_LICENSE_NOT_SET ((NTSTATUS)0xC00A0033L)")]
    public const int STATUS_CTX_CLIENT_LICENSE_NOT_SET = unchecked((int)(0xC00A0033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_CLIENT_LICENSE_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_CTX_CLIENT_LICENSE_IN_USE ((NTSTATUS)0xC00A0034L)")]
    public const int STATUS_CTX_CLIENT_LICENSE_IN_USE = unchecked((int)(0xC00A0034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_SHADOW_ENDED_BY_MODE_CHANGE"]/*' />
    [NativeTypeName("#define STATUS_CTX_SHADOW_ENDED_BY_MODE_CHANGE ((NTSTATUS)0xC00A0035L)")]
    public const int STATUS_CTX_SHADOW_ENDED_BY_MODE_CHANGE = unchecked((int)(0xC00A0035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_SHADOW_NOT_RUNNING"]/*' />
    [NativeTypeName("#define STATUS_CTX_SHADOW_NOT_RUNNING ((NTSTATUS)0xC00A0036L)")]
    public const int STATUS_CTX_SHADOW_NOT_RUNNING = unchecked((int)(0xC00A0036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_LOGON_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_CTX_LOGON_DISABLED ((NTSTATUS)0xC00A0037L)")]
    public const int STATUS_CTX_LOGON_DISABLED = unchecked((int)(0xC00A0037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTX_SECURITY_LAYER_ERROR"]/*' />
    [NativeTypeName("#define STATUS_CTX_SECURITY_LAYER_ERROR ((NTSTATUS)0xC00A0038L)")]
    public const int STATUS_CTX_SECURITY_LAYER_ERROR = unchecked((int)(0xC00A0038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TS_INCOMPATIBLE_SESSIONS"]/*' />
    [NativeTypeName("#define STATUS_TS_INCOMPATIBLE_SESSIONS ((NTSTATUS)0xC00A0039L)")]
    public const int STATUS_TS_INCOMPATIBLE_SESSIONS = unchecked((int)(0xC00A0039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TS_VIDEO_SUBSYSTEM_ERROR"]/*' />
    [NativeTypeName("#define STATUS_TS_VIDEO_SUBSYSTEM_ERROR ((NTSTATUS)0xC00A003AL)")]
    public const int STATUS_TS_VIDEO_SUBSYSTEM_ERROR = unchecked((int)(0xC00A003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_BAD_MPS_TABLE"]/*' />
    [NativeTypeName("#define STATUS_PNP_BAD_MPS_TABLE ((NTSTATUS)0xC0040035L)")]
    public const int STATUS_PNP_BAD_MPS_TABLE = unchecked((int)(0xC0040035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_TRANSLATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_PNP_TRANSLATION_FAILED ((NTSTATUS)0xC0040036L)")]
    public const int STATUS_PNP_TRANSLATION_FAILED = unchecked((int)(0xC0040036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_IRQ_TRANSLATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_PNP_IRQ_TRANSLATION_FAILED ((NTSTATUS)0xC0040037L)")]
    public const int STATUS_PNP_IRQ_TRANSLATION_FAILED = unchecked((int)(0xC0040037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PNP_INVALID_ID"]/*' />
    [NativeTypeName("#define STATUS_PNP_INVALID_ID ((NTSTATUS)0xC0040038L)")]
    public const int STATUS_PNP_INVALID_ID = unchecked((int)(0xC0040038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_REISSUE_AS_CACHED"]/*' />
    [NativeTypeName("#define STATUS_IO_REISSUE_AS_CACHED ((NTSTATUS)0xC0040039L)")]
    public const int STATUS_IO_REISSUE_AS_CACHED = unchecked((int)(0xC0040039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUI_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_MUI_FILE_NOT_FOUND ((NTSTATUS)0xC00B0001L)")]
    public const int STATUS_MUI_FILE_NOT_FOUND = unchecked((int)(0xC00B0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUI_INVALID_FILE"]/*' />
    [NativeTypeName("#define STATUS_MUI_INVALID_FILE ((NTSTATUS)0xC00B0002L)")]
    public const int STATUS_MUI_INVALID_FILE = unchecked((int)(0xC00B0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUI_INVALID_RC_CONFIG"]/*' />
    [NativeTypeName("#define STATUS_MUI_INVALID_RC_CONFIG ((NTSTATUS)0xC00B0003L)")]
    public const int STATUS_MUI_INVALID_RC_CONFIG = unchecked((int)(0xC00B0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUI_INVALID_LOCALE_NAME"]/*' />
    [NativeTypeName("#define STATUS_MUI_INVALID_LOCALE_NAME ((NTSTATUS)0xC00B0004L)")]
    public const int STATUS_MUI_INVALID_LOCALE_NAME = unchecked((int)(0xC00B0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUI_INVALID_ULTIMATEFALLBACK_NAME"]/*' />
    [NativeTypeName("#define STATUS_MUI_INVALID_ULTIMATEFALLBACK_NAME ((NTSTATUS)0xC00B0005L)")]
    public const int STATUS_MUI_INVALID_ULTIMATEFALLBACK_NAME = unchecked((int)(0xC00B0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MUI_FILE_NOT_LOADED"]/*' />
    [NativeTypeName("#define STATUS_MUI_FILE_NOT_LOADED ((NTSTATUS)0xC00B0006L)")]
    public const int STATUS_MUI_FILE_NOT_LOADED = unchecked((int)(0xC00B0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCE_ENUM_USER_STOP"]/*' />
    [NativeTypeName("#define STATUS_RESOURCE_ENUM_USER_STOP ((NTSTATUS)0xC00B0007L)")]
    public const int STATUS_RESOURCE_ENUM_USER_STOP = unchecked((int)(0xC00B0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_NO_HANDLER_DEFINED"]/*' />
    [NativeTypeName("#define STATUS_FLT_NO_HANDLER_DEFINED ((NTSTATUS)0xC01C0001L)")]
    public const int STATUS_FLT_NO_HANDLER_DEFINED = unchecked((int)(0xC01C0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_CONTEXT_ALREADY_DEFINED"]/*' />
    [NativeTypeName("#define STATUS_FLT_CONTEXT_ALREADY_DEFINED ((NTSTATUS)0xC01C0002L)")]
    public const int STATUS_FLT_CONTEXT_ALREADY_DEFINED = unchecked((int)(0xC01C0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_INVALID_ASYNCHRONOUS_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_FLT_INVALID_ASYNCHRONOUS_REQUEST ((NTSTATUS)0xC01C0003L)")]
    public const int STATUS_FLT_INVALID_ASYNCHRONOUS_REQUEST = unchecked((int)(0xC01C0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_DISALLOW_FAST_IO"]/*' />
    [NativeTypeName("#define STATUS_FLT_DISALLOW_FAST_IO ((NTSTATUS)0xC01C0004L)")]
    public const int STATUS_FLT_DISALLOW_FAST_IO = unchecked((int)(0xC01C0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_DISALLOW_FSFILTER_IO"]/*' />
    [NativeTypeName("#define STATUS_FLT_DISALLOW_FSFILTER_IO STATUS_FLT_DISALLOW_FAST_IO")]
    public const int STATUS_FLT_DISALLOW_FSFILTER_IO = unchecked((int)(0xC01C0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_INVALID_NAME_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_FLT_INVALID_NAME_REQUEST ((NTSTATUS)0xC01C0005L)")]
    public const int STATUS_FLT_INVALID_NAME_REQUEST = unchecked((int)(0xC01C0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_NOT_SAFE_TO_POST_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_FLT_NOT_SAFE_TO_POST_OPERATION ((NTSTATUS)0xC01C0006L)")]
    public const int STATUS_FLT_NOT_SAFE_TO_POST_OPERATION = unchecked((int)(0xC01C0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_FLT_NOT_INITIALIZED ((NTSTATUS)0xC01C0007L)")]
    public const int STATUS_FLT_NOT_INITIALIZED = unchecked((int)(0xC01C0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_FILTER_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_FLT_FILTER_NOT_READY ((NTSTATUS)0xC01C0008L)")]
    public const int STATUS_FLT_FILTER_NOT_READY = unchecked((int)(0xC01C0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_POST_OPERATION_CLEANUP"]/*' />
    [NativeTypeName("#define STATUS_FLT_POST_OPERATION_CLEANUP ((NTSTATUS)0xC01C0009L)")]
    public const int STATUS_FLT_POST_OPERATION_CLEANUP = unchecked((int)(0xC01C0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_FLT_INTERNAL_ERROR ((NTSTATUS)0xC01C000AL)")]
    public const int STATUS_FLT_INTERNAL_ERROR = unchecked((int)(0xC01C000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_DELETING_OBJECT"]/*' />
    [NativeTypeName("#define STATUS_FLT_DELETING_OBJECT ((NTSTATUS)0xC01C000BL)")]
    public const int STATUS_FLT_DELETING_OBJECT = unchecked((int)(0xC01C000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_MUST_BE_NONPAGED_POOL"]/*' />
    [NativeTypeName("#define STATUS_FLT_MUST_BE_NONPAGED_POOL ((NTSTATUS)0xC01C000CL)")]
    public const int STATUS_FLT_MUST_BE_NONPAGED_POOL = unchecked((int)(0xC01C000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_DUPLICATE_ENTRY"]/*' />
    [NativeTypeName("#define STATUS_FLT_DUPLICATE_ENTRY ((NTSTATUS)0xC01C000DL)")]
    public const int STATUS_FLT_DUPLICATE_ENTRY = unchecked((int)(0xC01C000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_CBDQ_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_FLT_CBDQ_DISABLED ((NTSTATUS)0xC01C000EL)")]
    public const int STATUS_FLT_CBDQ_DISABLED = unchecked((int)(0xC01C000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_DO_NOT_ATTACH"]/*' />
    [NativeTypeName("#define STATUS_FLT_DO_NOT_ATTACH ((NTSTATUS)0xC01C000FL)")]
    public const int STATUS_FLT_DO_NOT_ATTACH = unchecked((int)(0xC01C000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_DO_NOT_DETACH"]/*' />
    [NativeTypeName("#define STATUS_FLT_DO_NOT_DETACH ((NTSTATUS)0xC01C0010L)")]
    public const int STATUS_FLT_DO_NOT_DETACH = unchecked((int)(0xC01C0010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_INSTANCE_ALTITUDE_COLLISION"]/*' />
    [NativeTypeName("#define STATUS_FLT_INSTANCE_ALTITUDE_COLLISION ((NTSTATUS)0xC01C0011L)")]
    public const int STATUS_FLT_INSTANCE_ALTITUDE_COLLISION = unchecked((int)(0xC01C0011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_INSTANCE_NAME_COLLISION"]/*' />
    [NativeTypeName("#define STATUS_FLT_INSTANCE_NAME_COLLISION ((NTSTATUS)0xC01C0012L)")]
    public const int STATUS_FLT_INSTANCE_NAME_COLLISION = unchecked((int)(0xC01C0012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_FILTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FLT_FILTER_NOT_FOUND ((NTSTATUS)0xC01C0013L)")]
    public const int STATUS_FLT_FILTER_NOT_FOUND = unchecked((int)(0xC01C0013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_VOLUME_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FLT_VOLUME_NOT_FOUND ((NTSTATUS)0xC01C0014L)")]
    public const int STATUS_FLT_VOLUME_NOT_FOUND = unchecked((int)(0xC01C0014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_INSTANCE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FLT_INSTANCE_NOT_FOUND ((NTSTATUS)0xC01C0015L)")]
    public const int STATUS_FLT_INSTANCE_NOT_FOUND = unchecked((int)(0xC01C0015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_CONTEXT_ALLOCATION_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FLT_CONTEXT_ALLOCATION_NOT_FOUND ((NTSTATUS)0xC01C0016L)")]
    public const int STATUS_FLT_CONTEXT_ALLOCATION_NOT_FOUND = unchecked((int)(0xC01C0016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_INVALID_CONTEXT_REGISTRATION"]/*' />
    [NativeTypeName("#define STATUS_FLT_INVALID_CONTEXT_REGISTRATION ((NTSTATUS)0xC01C0017L)")]
    public const int STATUS_FLT_INVALID_CONTEXT_REGISTRATION = unchecked((int)(0xC01C0017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_NAME_CACHE_MISS"]/*' />
    [NativeTypeName("#define STATUS_FLT_NAME_CACHE_MISS ((NTSTATUS)0xC01C0018L)")]
    public const int STATUS_FLT_NAME_CACHE_MISS = unchecked((int)(0xC01C0018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_NO_DEVICE_OBJECT"]/*' />
    [NativeTypeName("#define STATUS_FLT_NO_DEVICE_OBJECT ((NTSTATUS)0xC01C0019L)")]
    public const int STATUS_FLT_NO_DEVICE_OBJECT = unchecked((int)(0xC01C0019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_VOLUME_ALREADY_MOUNTED"]/*' />
    [NativeTypeName("#define STATUS_FLT_VOLUME_ALREADY_MOUNTED ((NTSTATUS)0xC01C001AL)")]
    public const int STATUS_FLT_VOLUME_ALREADY_MOUNTED = unchecked((int)(0xC01C001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_ALREADY_ENLISTED"]/*' />
    [NativeTypeName("#define STATUS_FLT_ALREADY_ENLISTED ((NTSTATUS)0xC01C001BL)")]
    public const int STATUS_FLT_ALREADY_ENLISTED = unchecked((int)(0xC01C001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_CONTEXT_ALREADY_LINKED"]/*' />
    [NativeTypeName("#define STATUS_FLT_CONTEXT_ALREADY_LINKED ((NTSTATUS)0xC01C001CL)")]
    public const int STATUS_FLT_CONTEXT_ALREADY_LINKED = unchecked((int)(0xC01C001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_NO_WAITER_FOR_REPLY"]/*' />
    [NativeTypeName("#define STATUS_FLT_NO_WAITER_FOR_REPLY ((NTSTATUS)0xC01C0020L)")]
    public const int STATUS_FLT_NO_WAITER_FOR_REPLY = unchecked((int)(0xC01C0020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_REGISTRATION_BUSY"]/*' />
    [NativeTypeName("#define STATUS_FLT_REGISTRATION_BUSY ((NTSTATUS)0xC01C0023L)")]
    public const int STATUS_FLT_REGISTRATION_BUSY = unchecked((int)(0xC01C0023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLT_WCOS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_FLT_WCOS_NOT_SUPPORTED ((NTSTATUS)0xC01C0024L)")]
    public const int STATUS_FLT_WCOS_NOT_SUPPORTED = unchecked((int)(0xC01C0024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_SECTION_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_SXS_SECTION_NOT_FOUND ((NTSTATUS)0xC0150001L)")]
    public const int STATUS_SXS_SECTION_NOT_FOUND = unchecked((int)(0xC0150001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_CANT_GEN_ACTCTX"]/*' />
    [NativeTypeName("#define STATUS_SXS_CANT_GEN_ACTCTX ((NTSTATUS)0xC0150002L)")]
    public const int STATUS_SXS_CANT_GEN_ACTCTX = unchecked((int)(0xC0150002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_INVALID_ACTCTXDATA_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_SXS_INVALID_ACTCTXDATA_FORMAT ((NTSTATUS)0xC0150003L)")]
    public const int STATUS_SXS_INVALID_ACTCTXDATA_FORMAT = unchecked((int)(0xC0150003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_ASSEMBLY_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_SXS_ASSEMBLY_NOT_FOUND ((NTSTATUS)0xC0150004L)")]
    public const int STATUS_SXS_ASSEMBLY_NOT_FOUND = unchecked((int)(0xC0150004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_MANIFEST_FORMAT_ERROR"]/*' />
    [NativeTypeName("#define STATUS_SXS_MANIFEST_FORMAT_ERROR ((NTSTATUS)0xC0150005L)")]
    public const int STATUS_SXS_MANIFEST_FORMAT_ERROR = unchecked((int)(0xC0150005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_MANIFEST_PARSE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_SXS_MANIFEST_PARSE_ERROR ((NTSTATUS)0xC0150006L)")]
    public const int STATUS_SXS_MANIFEST_PARSE_ERROR = unchecked((int)(0xC0150006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_ACTIVATION_CONTEXT_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_SXS_ACTIVATION_CONTEXT_DISABLED ((NTSTATUS)0xC0150007L)")]
    public const int STATUS_SXS_ACTIVATION_CONTEXT_DISABLED = unchecked((int)(0xC0150007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_KEY_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_SXS_KEY_NOT_FOUND ((NTSTATUS)0xC0150008L)")]
    public const int STATUS_SXS_KEY_NOT_FOUND = unchecked((int)(0xC0150008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_VERSION_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_SXS_VERSION_CONFLICT ((NTSTATUS)0xC0150009L)")]
    public const int STATUS_SXS_VERSION_CONFLICT = unchecked((int)(0xC0150009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_WRONG_SECTION_TYPE"]/*' />
    [NativeTypeName("#define STATUS_SXS_WRONG_SECTION_TYPE ((NTSTATUS)0xC015000AL)")]
    public const int STATUS_SXS_WRONG_SECTION_TYPE = unchecked((int)(0xC015000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_THREAD_QUERIES_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_SXS_THREAD_QUERIES_DISABLED ((NTSTATUS)0xC015000BL)")]
    public const int STATUS_SXS_THREAD_QUERIES_DISABLED = unchecked((int)(0xC015000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_ASSEMBLY_MISSING"]/*' />
    [NativeTypeName("#define STATUS_SXS_ASSEMBLY_MISSING ((NTSTATUS)0xC015000CL)")]
    public const int STATUS_SXS_ASSEMBLY_MISSING = unchecked((int)(0xC015000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_RELEASE_ACTIVATION_CONTEXT"]/*' />
    [NativeTypeName("#define STATUS_SXS_RELEASE_ACTIVATION_CONTEXT ((NTSTATUS)0x4015000DL)")]
    public const int STATUS_SXS_RELEASE_ACTIVATION_CONTEXT = ((int)(0x4015000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_PROCESS_DEFAULT_ALREADY_SET"]/*' />
    [NativeTypeName("#define STATUS_SXS_PROCESS_DEFAULT_ALREADY_SET ((NTSTATUS)0xC015000EL)")]
    public const int STATUS_SXS_PROCESS_DEFAULT_ALREADY_SET = unchecked((int)(0xC015000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_MULTIPLE_DEACTIVATION"]/*' />
    [NativeTypeName("#define STATUS_SXS_MULTIPLE_DEACTIVATION ((NTSTATUS)0xC0150011L)")]
    public const int STATUS_SXS_MULTIPLE_DEACTIVATION = unchecked((int)(0xC0150011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY ((NTSTATUS)0xC0150012L)")]
    public const int STATUS_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY = unchecked((int)(0xC0150012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_PROCESS_TERMINATION_REQUESTED"]/*' />
    [NativeTypeName("#define STATUS_SXS_PROCESS_TERMINATION_REQUESTED ((NTSTATUS)0xC0150013L)")]
    public const int STATUS_SXS_PROCESS_TERMINATION_REQUESTED = unchecked((int)(0xC0150013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_CORRUPT_ACTIVATION_STACK"]/*' />
    [NativeTypeName("#define STATUS_SXS_CORRUPT_ACTIVATION_STACK ((NTSTATUS)0xC0150014L)")]
    public const int STATUS_SXS_CORRUPT_ACTIVATION_STACK = unchecked((int)(0xC0150014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_CORRUPTION"]/*' />
    [NativeTypeName("#define STATUS_SXS_CORRUPTION ((NTSTATUS)0xC0150015L)")]
    public const int STATUS_SXS_CORRUPTION = unchecked((int)(0xC0150015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE"]/*' />
    [NativeTypeName("#define STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE ((NTSTATUS)0xC0150016L)")]
    public const int STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE = unchecked((int)(0xC0150016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME"]/*' />
    [NativeTypeName("#define STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME ((NTSTATUS)0xC0150017L)")]
    public const int STATUS_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME = unchecked((int)(0xC0150017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_IDENTITY_DUPLICATE_ATTRIBUTE"]/*' />
    [NativeTypeName("#define STATUS_SXS_IDENTITY_DUPLICATE_ATTRIBUTE ((NTSTATUS)0xC0150018L)")]
    public const int STATUS_SXS_IDENTITY_DUPLICATE_ATTRIBUTE = unchecked((int)(0xC0150018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_IDENTITY_PARSE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_SXS_IDENTITY_PARSE_ERROR ((NTSTATUS)0xC0150019L)")]
    public const int STATUS_SXS_IDENTITY_PARSE_ERROR = unchecked((int)(0xC0150019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_COMPONENT_STORE_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_SXS_COMPONENT_STORE_CORRUPT ((NTSTATUS)0xC015001AL)")]
    public const int STATUS_SXS_COMPONENT_STORE_CORRUPT = unchecked((int)(0xC015001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_FILE_HASH_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_SXS_FILE_HASH_MISMATCH ((NTSTATUS)0xC015001BL)")]
    public const int STATUS_SXS_FILE_HASH_MISMATCH = unchecked((int)(0xC015001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT"]/*' />
    [NativeTypeName("#define STATUS_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT ((NTSTATUS)0xC015001CL)")]
    public const int STATUS_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT = unchecked((int)(0xC015001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_IDENTITIES_DIFFERENT"]/*' />
    [NativeTypeName("#define STATUS_SXS_IDENTITIES_DIFFERENT ((NTSTATUS)0xC015001DL)")]
    public const int STATUS_SXS_IDENTITIES_DIFFERENT = unchecked((int)(0xC015001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT"]/*' />
    [NativeTypeName("#define STATUS_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT ((NTSTATUS)0xC015001EL)")]
    public const int STATUS_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT = unchecked((int)(0xC015001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_FILE_NOT_PART_OF_ASSEMBLY"]/*' />
    [NativeTypeName("#define STATUS_SXS_FILE_NOT_PART_OF_ASSEMBLY ((NTSTATUS)0xC015001FL)")]
    public const int STATUS_SXS_FILE_NOT_PART_OF_ASSEMBLY = unchecked((int)(0xC015001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ADVANCED_INSTALLER_FAILED"]/*' />
    [NativeTypeName("#define STATUS_ADVANCED_INSTALLER_FAILED ((NTSTATUS)0xC0150020L)")]
    public const int STATUS_ADVANCED_INSTALLER_FAILED = unchecked((int)(0xC0150020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_XML_ENCODING_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_XML_ENCODING_MISMATCH ((NTSTATUS)0xC0150021L)")]
    public const int STATUS_XML_ENCODING_MISMATCH = unchecked((int)(0xC0150021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_MANIFEST_TOO_BIG"]/*' />
    [NativeTypeName("#define STATUS_SXS_MANIFEST_TOO_BIG ((NTSTATUS)0xC0150022L)")]
    public const int STATUS_SXS_MANIFEST_TOO_BIG = unchecked((int)(0xC0150022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_SETTING_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_SXS_SETTING_NOT_REGISTERED ((NTSTATUS)0xC0150023L)")]
    public const int STATUS_SXS_SETTING_NOT_REGISTERED = unchecked((int)(0xC0150023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_TRANSACTION_CLOSURE_INCOMPLETE"]/*' />
    [NativeTypeName("#define STATUS_SXS_TRANSACTION_CLOSURE_INCOMPLETE ((NTSTATUS)0xC0150024L)")]
    public const int STATUS_SXS_TRANSACTION_CLOSURE_INCOMPLETE = unchecked((int)(0xC0150024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMI_PRIMITIVE_INSTALLER_FAILED"]/*' />
    [NativeTypeName("#define STATUS_SMI_PRIMITIVE_INSTALLER_FAILED ((NTSTATUS)0xC0150025L)")]
    public const int STATUS_SMI_PRIMITIVE_INSTALLER_FAILED = unchecked((int)(0xC0150025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GENERIC_COMMAND_FAILED"]/*' />
    [NativeTypeName("#define STATUS_GENERIC_COMMAND_FAILED ((NTSTATUS)0xC0150026L)")]
    public const int STATUS_GENERIC_COMMAND_FAILED = unchecked((int)(0xC0150026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_FILE_HASH_MISSING"]/*' />
    [NativeTypeName("#define STATUS_SXS_FILE_HASH_MISSING ((NTSTATUS)0xC0150027L)")]
    public const int STATUS_SXS_FILE_HASH_MISSING = unchecked((int)(0xC0150027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_INVALID_NODE"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_INVALID_NODE ((NTSTATUS)0xC0130001L)")]
    public const int STATUS_CLUSTER_INVALID_NODE = unchecked((int)(0xC0130001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_EXISTS ((NTSTATUS)0xC0130002L)")]
    public const int STATUS_CLUSTER_NODE_EXISTS = unchecked((int)(0xC0130002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_JOIN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_JOIN_IN_PROGRESS ((NTSTATUS)0xC0130003L)")]
    public const int STATUS_CLUSTER_JOIN_IN_PROGRESS = unchecked((int)(0xC0130003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_NOT_FOUND ((NTSTATUS)0xC0130004L)")]
    public const int STATUS_CLUSTER_NODE_NOT_FOUND = unchecked((int)(0xC0130004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_LOCAL_NODE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_LOCAL_NODE_NOT_FOUND ((NTSTATUS)0xC0130005L)")]
    public const int STATUS_CLUSTER_LOCAL_NODE_NOT_FOUND = unchecked((int)(0xC0130005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NETWORK_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NETWORK_EXISTS ((NTSTATUS)0xC0130006L)")]
    public const int STATUS_CLUSTER_NETWORK_EXISTS = unchecked((int)(0xC0130006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NETWORK_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NETWORK_NOT_FOUND ((NTSTATUS)0xC0130007L)")]
    public const int STATUS_CLUSTER_NETWORK_NOT_FOUND = unchecked((int)(0xC0130007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NETINTERFACE_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NETINTERFACE_EXISTS ((NTSTATUS)0xC0130008L)")]
    public const int STATUS_CLUSTER_NETINTERFACE_EXISTS = unchecked((int)(0xC0130008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NETINTERFACE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NETINTERFACE_NOT_FOUND ((NTSTATUS)0xC0130009L)")]
    public const int STATUS_CLUSTER_NETINTERFACE_NOT_FOUND = unchecked((int)(0xC0130009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_INVALID_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_INVALID_REQUEST ((NTSTATUS)0xC013000AL)")]
    public const int STATUS_CLUSTER_INVALID_REQUEST = unchecked((int)(0xC013000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_INVALID_NETWORK_PROVIDER"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_INVALID_NETWORK_PROVIDER ((NTSTATUS)0xC013000BL)")]
    public const int STATUS_CLUSTER_INVALID_NETWORK_PROVIDER = unchecked((int)(0xC013000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_DOWN"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_DOWN ((NTSTATUS)0xC013000CL)")]
    public const int STATUS_CLUSTER_NODE_DOWN = unchecked((int)(0xC013000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_UNREACHABLE"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_UNREACHABLE ((NTSTATUS)0xC013000DL)")]
    public const int STATUS_CLUSTER_NODE_UNREACHABLE = unchecked((int)(0xC013000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_NOT_MEMBER"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_NOT_MEMBER ((NTSTATUS)0xC013000EL)")]
    public const int STATUS_CLUSTER_NODE_NOT_MEMBER = unchecked((int)(0xC013000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_JOIN_NOT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_JOIN_NOT_IN_PROGRESS ((NTSTATUS)0xC013000FL)")]
    public const int STATUS_CLUSTER_JOIN_NOT_IN_PROGRESS = unchecked((int)(0xC013000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_INVALID_NETWORK"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_INVALID_NETWORK ((NTSTATUS)0xC0130010L)")]
    public const int STATUS_CLUSTER_INVALID_NETWORK = unchecked((int)(0xC0130010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NO_NET_ADAPTERS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NO_NET_ADAPTERS ((NTSTATUS)0xC0130011L)")]
    public const int STATUS_CLUSTER_NO_NET_ADAPTERS = unchecked((int)(0xC0130011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_UP"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_UP ((NTSTATUS)0xC0130012L)")]
    public const int STATUS_CLUSTER_NODE_UP = unchecked((int)(0xC0130012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_PAUSED"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_PAUSED ((NTSTATUS)0xC0130013L)")]
    public const int STATUS_CLUSTER_NODE_PAUSED = unchecked((int)(0xC0130013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NODE_NOT_PAUSED"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NODE_NOT_PAUSED ((NTSTATUS)0xC0130014L)")]
    public const int STATUS_CLUSTER_NODE_NOT_PAUSED = unchecked((int)(0xC0130014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NO_SECURITY_CONTEXT"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NO_SECURITY_CONTEXT ((NTSTATUS)0xC0130015L)")]
    public const int STATUS_CLUSTER_NO_SECURITY_CONTEXT = unchecked((int)(0xC0130015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NETWORK_NOT_INTERNAL"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NETWORK_NOT_INTERNAL ((NTSTATUS)0xC0130016L)")]
    public const int STATUS_CLUSTER_NETWORK_NOT_INTERNAL = unchecked((int)(0xC0130016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_POISONED"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_POISONED ((NTSTATUS)0xC0130017L)")]
    public const int STATUS_CLUSTER_POISONED = unchecked((int)(0xC0130017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_NON_CSV_PATH"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_NON_CSV_PATH ((NTSTATUS)0xC0130018L)")]
    public const int STATUS_CLUSTER_NON_CSV_PATH = unchecked((int)(0xC0130018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_VOLUME_NOT_LOCAL"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_VOLUME_NOT_LOCAL ((NTSTATUS)0xC0130019L)")]
    public const int STATUS_CLUSTER_CSV_VOLUME_NOT_LOCAL = unchecked((int)(0xC0130019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_READ_OPLOCK_BREAK_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_READ_OPLOCK_BREAK_IN_PROGRESS ((NTSTATUS)0xC0130020L)")]
    public const int STATUS_CLUSTER_CSV_READ_OPLOCK_BREAK_IN_PROGRESS = unchecked((int)(0xC0130020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_AUTO_PAUSE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_AUTO_PAUSE_ERROR ((NTSTATUS)0xC0130021L)")]
    public const int STATUS_CLUSTER_CSV_AUTO_PAUSE_ERROR = unchecked((int)(0xC0130021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_REDIRECTED"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_REDIRECTED ((NTSTATUS)0xC0130022L)")]
    public const int STATUS_CLUSTER_CSV_REDIRECTED = unchecked((int)(0xC0130022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_NOT_REDIRECTED"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_NOT_REDIRECTED ((NTSTATUS)0xC0130023L)")]
    public const int STATUS_CLUSTER_CSV_NOT_REDIRECTED = unchecked((int)(0xC0130023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_VOLUME_DRAINING"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_VOLUME_DRAINING ((NTSTATUS)0xC0130024L)")]
    public const int STATUS_CLUSTER_CSV_VOLUME_DRAINING = unchecked((int)(0xC0130024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_SNAPSHOT_CREATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_SNAPSHOT_CREATION_IN_PROGRESS ((NTSTATUS)0xC0130025L)")]
    public const int STATUS_CLUSTER_CSV_SNAPSHOT_CREATION_IN_PROGRESS = unchecked((int)(0xC0130025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_VOLUME_DRAINING_SUCCEEDED_DOWNLEVEL"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_VOLUME_DRAINING_SUCCEEDED_DOWNLEVEL ((NTSTATUS)0xC0130026L)")]
    public const int STATUS_CLUSTER_CSV_VOLUME_DRAINING_SUCCEEDED_DOWNLEVEL = unchecked((int)(0xC0130026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_NO_SNAPSHOTS"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_NO_SNAPSHOTS ((NTSTATUS)0xC0130027L)")]
    public const int STATUS_CLUSTER_CSV_NO_SNAPSHOTS = unchecked((int)(0xC0130027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CSV_IO_PAUSE_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_CSV_IO_PAUSE_TIMEOUT ((NTSTATUS)0xC0130028L)")]
    public const int STATUS_CSV_IO_PAUSE_TIMEOUT = unchecked((int)(0xC0130028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_INVALID_HANDLE ((NTSTATUS)0xC0130029L)")]
    public const int STATUS_CLUSTER_CSV_INVALID_HANDLE = unchecked((int)(0xC0130029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR ((NTSTATUS)0xC0130030L)")]
    public const int STATUS_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR = unchecked((int)(0xC0130030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLUSTER_CAM_TICKET_REPLAY_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_CLUSTER_CAM_TICKET_REPLAY_DETECTED ((NTSTATUS)0xC0130031L)")]
    public const int STATUS_CLUSTER_CAM_TICKET_REPLAY_DETECTED = unchecked((int)(0xC0130031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTIONAL_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTIONAL_CONFLICT ((NTSTATUS)0xC0190001L)")]
    public const int STATUS_TRANSACTIONAL_CONFLICT = unchecked((int)(0xC0190001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_TRANSACTION ((NTSTATUS)0xC0190002L)")]
    public const int STATUS_INVALID_TRANSACTION = unchecked((int)(0xC0190002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NOT_ACTIVE ((NTSTATUS)0xC0190003L)")]
    public const int STATUS_TRANSACTION_NOT_ACTIVE = unchecked((int)(0xC0190003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TM_INITIALIZATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_TM_INITIALIZATION_FAILED ((NTSTATUS)0xC0190004L)")]
    public const int STATUS_TM_INITIALIZATION_FAILED = unchecked((int)(0xC0190004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RM_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_RM_NOT_ACTIVE ((NTSTATUS)0xC0190005L)")]
    public const int STATUS_RM_NOT_ACTIVE = unchecked((int)(0xC0190005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RM_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_RM_METADATA_CORRUPT ((NTSTATUS)0xC0190006L)")]
    public const int STATUS_RM_METADATA_CORRUPT = unchecked((int)(0xC0190006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NOT_JOINED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NOT_JOINED ((NTSTATUS)0xC0190007L)")]
    public const int STATUS_TRANSACTION_NOT_JOINED = unchecked((int)(0xC0190007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DIRECTORY_NOT_RM"]/*' />
    [NativeTypeName("#define STATUS_DIRECTORY_NOT_RM ((NTSTATUS)0xC0190008L)")]
    public const int STATUS_DIRECTORY_NOT_RM = unchecked((int)(0xC0190008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COULD_NOT_RESIZE_LOG"]/*' />
    [NativeTypeName("#define STATUS_COULD_NOT_RESIZE_LOG ((NTSTATUS)0x80190009L)")]
    public const int STATUS_COULD_NOT_RESIZE_LOG = unchecked((int)(0x80190009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTIONS_UNSUPPORTED_REMOTE"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTIONS_UNSUPPORTED_REMOTE ((NTSTATUS)0xC019000AL)")]
    public const int STATUS_TRANSACTIONS_UNSUPPORTED_REMOTE = unchecked((int)(0xC019000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_RESIZE_INVALID_SIZE"]/*' />
    [NativeTypeName("#define STATUS_LOG_RESIZE_INVALID_SIZE ((NTSTATUS)0xC019000BL)")]
    public const int STATUS_LOG_RESIZE_INVALID_SIZE = unchecked((int)(0xC019000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REMOTE_FILE_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_REMOTE_FILE_VERSION_MISMATCH ((NTSTATUS)0xC019000CL)")]
    public const int STATUS_REMOTE_FILE_VERSION_MISMATCH = unchecked((int)(0xC019000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CRM_PROTOCOL_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_CRM_PROTOCOL_ALREADY_EXISTS ((NTSTATUS)0xC019000FL)")]
    public const int STATUS_CRM_PROTOCOL_ALREADY_EXISTS = unchecked((int)(0xC019000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_PROPAGATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_PROPAGATION_FAILED ((NTSTATUS)0xC0190010L)")]
    public const int STATUS_TRANSACTION_PROPAGATION_FAILED = unchecked((int)(0xC0190010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CRM_PROTOCOL_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CRM_PROTOCOL_NOT_FOUND ((NTSTATUS)0xC0190011L)")]
    public const int STATUS_CRM_PROTOCOL_NOT_FOUND = unchecked((int)(0xC0190011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_SUPERIOR_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_SUPERIOR_EXISTS ((NTSTATUS)0xC0190012L)")]
    public const int STATUS_TRANSACTION_SUPERIOR_EXISTS = unchecked((int)(0xC0190012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_REQUEST_NOT_VALID"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_REQUEST_NOT_VALID ((NTSTATUS)0xC0190013L)")]
    public const int STATUS_TRANSACTION_REQUEST_NOT_VALID = unchecked((int)(0xC0190013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NOT_REQUESTED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NOT_REQUESTED ((NTSTATUS)0xC0190014L)")]
    public const int STATUS_TRANSACTION_NOT_REQUESTED = unchecked((int)(0xC0190014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_ALREADY_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_ALREADY_ABORTED ((NTSTATUS)0xC0190015L)")]
    public const int STATUS_TRANSACTION_ALREADY_ABORTED = unchecked((int)(0xC0190015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_ALREADY_COMMITTED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_ALREADY_COMMITTED ((NTSTATUS)0xC0190016L)")]
    public const int STATUS_TRANSACTION_ALREADY_COMMITTED = unchecked((int)(0xC0190016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_INVALID_MARSHALL_BUFFER"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_INVALID_MARSHALL_BUFFER ((NTSTATUS)0xC0190017L)")]
    public const int STATUS_TRANSACTION_INVALID_MARSHALL_BUFFER = unchecked((int)(0xC0190017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CURRENT_TRANSACTION_NOT_VALID"]/*' />
    [NativeTypeName("#define STATUS_CURRENT_TRANSACTION_NOT_VALID ((NTSTATUS)0xC0190018L)")]
    public const int STATUS_CURRENT_TRANSACTION_NOT_VALID = unchecked((int)(0xC0190018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_GROWTH_FAILED"]/*' />
    [NativeTypeName("#define STATUS_LOG_GROWTH_FAILED ((NTSTATUS)0xC0190019L)")]
    public const int STATUS_LOG_GROWTH_FAILED = unchecked((int)(0xC0190019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OBJECT_NO_LONGER_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_OBJECT_NO_LONGER_EXISTS ((NTSTATUS)0xC0190021L)")]
    public const int STATUS_OBJECT_NO_LONGER_EXISTS = unchecked((int)(0xC0190021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STREAM_MINIVERSION_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_STREAM_MINIVERSION_NOT_FOUND ((NTSTATUS)0xC0190022L)")]
    public const int STATUS_STREAM_MINIVERSION_NOT_FOUND = unchecked((int)(0xC0190022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STREAM_MINIVERSION_NOT_VALID"]/*' />
    [NativeTypeName("#define STATUS_STREAM_MINIVERSION_NOT_VALID ((NTSTATUS)0xC0190023L)")]
    public const int STATUS_STREAM_MINIVERSION_NOT_VALID = unchecked((int)(0xC0190023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION ((NTSTATUS)0xC0190024L)")]
    public const int STATUS_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION = unchecked((int)(0xC0190024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT"]/*' />
    [NativeTypeName("#define STATUS_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT ((NTSTATUS)0xC0190025L)")]
    public const int STATUS_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT = unchecked((int)(0xC0190025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_CREATE_MORE_STREAM_MINIVERSIONS"]/*' />
    [NativeTypeName("#define STATUS_CANT_CREATE_MORE_STREAM_MINIVERSIONS ((NTSTATUS)0xC0190026L)")]
    public const int STATUS_CANT_CREATE_MORE_STREAM_MINIVERSIONS = unchecked((int)(0xC0190026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HANDLE_NO_LONGER_VALID"]/*' />
    [NativeTypeName("#define STATUS_HANDLE_NO_LONGER_VALID ((NTSTATUS)0xC0190028L)")]
    public const int STATUS_HANDLE_NO_LONGER_VALID = unchecked((int)(0xC0190028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_TXF_METADATA"]/*' />
    [NativeTypeName("#define STATUS_NO_TXF_METADATA ((NTSTATUS)0x80190029L)")]
    public const int STATUS_NO_TXF_METADATA = unchecked((int)(0x80190029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CORRUPTION_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_LOG_CORRUPTION_DETECTED ((NTSTATUS)0xC0190030L)")]
    public const int STATUS_LOG_CORRUPTION_DETECTED = unchecked((int)(0xC0190030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_RECOVER_WITH_HANDLE_OPEN"]/*' />
    [NativeTypeName("#define STATUS_CANT_RECOVER_WITH_HANDLE_OPEN ((NTSTATUS)0x80190031L)")]
    public const int STATUS_CANT_RECOVER_WITH_HANDLE_OPEN = unchecked((int)(0x80190031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RM_DISCONNECTED"]/*' />
    [NativeTypeName("#define STATUS_RM_DISCONNECTED ((NTSTATUS)0xC0190032L)")]
    public const int STATUS_RM_DISCONNECTED = unchecked((int)(0xC0190032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENLISTMENT_NOT_SUPERIOR"]/*' />
    [NativeTypeName("#define STATUS_ENLISTMENT_NOT_SUPERIOR ((NTSTATUS)0xC0190033L)")]
    public const int STATUS_ENLISTMENT_NOT_SUPERIOR = unchecked((int)(0xC0190033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RECOVERY_NOT_NEEDED"]/*' />
    [NativeTypeName("#define STATUS_RECOVERY_NOT_NEEDED ((NTSTATUS)0x40190034L)")]
    public const int STATUS_RECOVERY_NOT_NEEDED = ((int)(0x40190034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RM_ALREADY_STARTED"]/*' />
    [NativeTypeName("#define STATUS_RM_ALREADY_STARTED ((NTSTATUS)0x40190035L)")]
    public const int STATUS_RM_ALREADY_STARTED = ((int)(0x40190035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FILE_IDENTITY_NOT_PERSISTENT"]/*' />
    [NativeTypeName("#define STATUS_FILE_IDENTITY_NOT_PERSISTENT ((NTSTATUS)0xC0190036L)")]
    public const int STATUS_FILE_IDENTITY_NOT_PERSISTENT = unchecked((int)(0xC0190036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_BREAK_TRANSACTIONAL_DEPENDENCY"]/*' />
    [NativeTypeName("#define STATUS_CANT_BREAK_TRANSACTIONAL_DEPENDENCY ((NTSTATUS)0xC0190037L)")]
    public const int STATUS_CANT_BREAK_TRANSACTIONAL_DEPENDENCY = unchecked((int)(0xC0190037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANT_CROSS_RM_BOUNDARY"]/*' />
    [NativeTypeName("#define STATUS_CANT_CROSS_RM_BOUNDARY ((NTSTATUS)0xC0190038L)")]
    public const int STATUS_CANT_CROSS_RM_BOUNDARY = unchecked((int)(0xC0190038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TXF_DIR_NOT_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_TXF_DIR_NOT_EMPTY ((NTSTATUS)0xC0190039L)")]
    public const int STATUS_TXF_DIR_NOT_EMPTY = unchecked((int)(0xC0190039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INDOUBT_TRANSACTIONS_EXIST"]/*' />
    [NativeTypeName("#define STATUS_INDOUBT_TRANSACTIONS_EXIST ((NTSTATUS)0xC019003AL)")]
    public const int STATUS_INDOUBT_TRANSACTIONS_EXIST = unchecked((int)(0xC019003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TM_VOLATILE"]/*' />
    [NativeTypeName("#define STATUS_TM_VOLATILE ((NTSTATUS)0xC019003BL)")]
    public const int STATUS_TM_VOLATILE = unchecked((int)(0xC019003B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ROLLBACK_TIMER_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_ROLLBACK_TIMER_EXPIRED ((NTSTATUS)0xC019003CL)")]
    public const int STATUS_ROLLBACK_TIMER_EXPIRED = unchecked((int)(0xC019003C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TXF_ATTRIBUTE_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_TXF_ATTRIBUTE_CORRUPT ((NTSTATUS)0xC019003DL)")]
    public const int STATUS_TXF_ATTRIBUTE_CORRUPT = unchecked((int)(0xC019003D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EFS_NOT_ALLOWED_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_EFS_NOT_ALLOWED_IN_TRANSACTION ((NTSTATUS)0xC019003EL)")]
    public const int STATUS_EFS_NOT_ALLOWED_IN_TRANSACTION = unchecked((int)(0xC019003E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTIONAL_OPEN_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTIONAL_OPEN_NOT_ALLOWED ((NTSTATUS)0xC019003FL)")]
    public const int STATUS_TRANSACTIONAL_OPEN_NOT_ALLOWED = unchecked((int)(0xC019003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE ((NTSTATUS)0xC0190040L)")]
    public const int STATUS_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE = unchecked((int)(0xC0190040));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TXF_METADATA_ALREADY_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_TXF_METADATA_ALREADY_PRESENT ((NTSTATUS)0x80190041L)")]
    public const int STATUS_TXF_METADATA_ALREADY_PRESENT = unchecked((int)(0x80190041));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_SCOPE_CALLBACKS_NOT_SET"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_SCOPE_CALLBACKS_NOT_SET ((NTSTATUS)0x80190042L)")]
    public const int STATUS_TRANSACTION_SCOPE_CALLBACKS_NOT_SET = unchecked((int)(0x80190042));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_REQUIRED_PROMOTION"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_REQUIRED_PROMOTION ((NTSTATUS)0xC0190043L)")]
    public const int STATUS_TRANSACTION_REQUIRED_PROMOTION = unchecked((int)(0xC0190043));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_EXECUTE_FILE_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_EXECUTE_FILE_IN_TRANSACTION ((NTSTATUS)0xC0190044L)")]
    public const int STATUS_CANNOT_EXECUTE_FILE_IN_TRANSACTION = unchecked((int)(0xC0190044));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTIONS_NOT_FROZEN"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTIONS_NOT_FROZEN ((NTSTATUS)0xC0190045L)")]
    public const int STATUS_TRANSACTIONS_NOT_FROZEN = unchecked((int)(0xC0190045));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_FREEZE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_FREEZE_IN_PROGRESS ((NTSTATUS)0xC0190046L)")]
    public const int STATUS_TRANSACTION_FREEZE_IN_PROGRESS = unchecked((int)(0xC0190046));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NOT_SNAPSHOT_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_NOT_SNAPSHOT_VOLUME ((NTSTATUS)0xC0190047L)")]
    public const int STATUS_NOT_SNAPSHOT_VOLUME = unchecked((int)(0xC0190047));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_SAVEPOINT_WITH_OPEN_FILES"]/*' />
    [NativeTypeName("#define STATUS_NO_SAVEPOINT_WITH_OPEN_FILES ((NTSTATUS)0xC0190048L)")]
    public const int STATUS_NO_SAVEPOINT_WITH_OPEN_FILES = unchecked((int)(0xC0190048));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPARSE_NOT_ALLOWED_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_SPARSE_NOT_ALLOWED_IN_TRANSACTION ((NTSTATUS)0xC0190049L)")]
    public const int STATUS_SPARSE_NOT_ALLOWED_IN_TRANSACTION = unchecked((int)(0xC0190049));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TM_IDENTITY_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_TM_IDENTITY_MISMATCH ((NTSTATUS)0xC019004AL)")]
    public const int STATUS_TM_IDENTITY_MISMATCH = unchecked((int)(0xC019004A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOATED_SECTION"]/*' />
    [NativeTypeName("#define STATUS_FLOATED_SECTION ((NTSTATUS)0xC019004BL)")]
    public const int STATUS_FLOATED_SECTION = unchecked((int)(0xC019004B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_ACCEPT_TRANSACTED_WORK"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_ACCEPT_TRANSACTED_WORK ((NTSTATUS)0xC019004CL)")]
    public const int STATUS_CANNOT_ACCEPT_TRANSACTED_WORK = unchecked((int)(0xC019004C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CANNOT_ABORT_TRANSACTIONS"]/*' />
    [NativeTypeName("#define STATUS_CANNOT_ABORT_TRANSACTIONS ((NTSTATUS)0xC019004DL)")]
    public const int STATUS_CANNOT_ABORT_TRANSACTIONS = unchecked((int)(0xC019004D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NOT_FOUND ((NTSTATUS)0xC019004EL)")]
    public const int STATUS_TRANSACTION_NOT_FOUND = unchecked((int)(0xC019004E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RESOURCEMANAGER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_RESOURCEMANAGER_NOT_FOUND ((NTSTATUS)0xC019004FL)")]
    public const int STATUS_RESOURCEMANAGER_NOT_FOUND = unchecked((int)(0xC019004F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENLISTMENT_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_ENLISTMENT_NOT_FOUND ((NTSTATUS)0xC0190050L)")]
    public const int STATUS_ENLISTMENT_NOT_FOUND = unchecked((int)(0xC0190050));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTIONMANAGER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTIONMANAGER_NOT_FOUND ((NTSTATUS)0xC0190051L)")]
    public const int STATUS_TRANSACTIONMANAGER_NOT_FOUND = unchecked((int)(0xC0190051));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTIONMANAGER_NOT_ONLINE"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTIONMANAGER_NOT_ONLINE ((NTSTATUS)0xC0190052L)")]
    public const int STATUS_TRANSACTIONMANAGER_NOT_ONLINE = unchecked((int)(0xC0190052));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION ((NTSTATUS)0xC0190053L)")]
    public const int STATUS_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION = unchecked((int)(0xC0190053));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NOT_ROOT"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NOT_ROOT ((NTSTATUS)0xC0190054L)")]
    public const int STATUS_TRANSACTION_NOT_ROOT = unchecked((int)(0xC0190054));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_OBJECT_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_OBJECT_EXPIRED ((NTSTATUS)0xC0190055L)")]
    public const int STATUS_TRANSACTION_OBJECT_EXPIRED = unchecked((int)(0xC0190055));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION ((NTSTATUS)0xC0190056L)")]
    public const int STATUS_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION = unchecked((int)(0xC0190056));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_RESPONSE_NOT_ENLISTED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_RESPONSE_NOT_ENLISTED ((NTSTATUS)0xC0190057L)")]
    public const int STATUS_TRANSACTION_RESPONSE_NOT_ENLISTED = unchecked((int)(0xC0190057));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_RECORD_TOO_LONG"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_RECORD_TOO_LONG ((NTSTATUS)0xC0190058L)")]
    public const int STATUS_TRANSACTION_RECORD_TOO_LONG = unchecked((int)(0xC0190058));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_LINK_TRACKING_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_NO_LINK_TRACKING_IN_TRANSACTION ((NTSTATUS)0xC0190059L)")]
    public const int STATUS_NO_LINK_TRACKING_IN_TRANSACTION = unchecked((int)(0xC0190059));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_OPERATION_NOT_SUPPORTED_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define STATUS_OPERATION_NOT_SUPPORTED_IN_TRANSACTION ((NTSTATUS)0xC019005AL)")]
    public const int STATUS_OPERATION_NOT_SUPPORTED_IN_TRANSACTION = unchecked((int)(0xC019005A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_INTEGRITY_VIOLATED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_INTEGRITY_VIOLATED ((NTSTATUS)0xC019005BL)")]
    public const int STATUS_TRANSACTION_INTEGRITY_VIOLATED = unchecked((int)(0xC019005B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTIONMANAGER_IDENTITY_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTIONMANAGER_IDENTITY_MISMATCH ((NTSTATUS)0xC019005CL)")]
    public const int STATUS_TRANSACTIONMANAGER_IDENTITY_MISMATCH = unchecked((int)(0xC019005C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT"]/*' />
    [NativeTypeName("#define STATUS_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT ((NTSTATUS)0xC019005DL)")]
    public const int STATUS_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT = unchecked((int)(0xC019005D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_MUST_WRITETHROUGH"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_MUST_WRITETHROUGH ((NTSTATUS)0xC019005EL)")]
    public const int STATUS_TRANSACTION_MUST_WRITETHROUGH = unchecked((int)(0xC019005E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NO_SUPERIOR"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NO_SUPERIOR ((NTSTATUS)0xC019005FL)")]
    public const int STATUS_TRANSACTION_NO_SUPERIOR = unchecked((int)(0xC019005F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_EXPIRED_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_EXPIRED_HANDLE ((NTSTATUS)0xC0190060L)")]
    public const int STATUS_EXPIRED_HANDLE = unchecked((int)(0xC0190060));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TRANSACTION_NOT_ENLISTED"]/*' />
    [NativeTypeName("#define STATUS_TRANSACTION_NOT_ENLISTED ((NTSTATUS)0xC0190061L)")]
    public const int STATUS_TRANSACTION_NOT_ENLISTED = unchecked((int)(0xC0190061));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENLISTMENT_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_ENLISTMENT_NOT_INITIALIZED ((NTSTATUS)0xC0190062L)")]
    public const int STATUS_ENLISTMENT_NOT_INITIALIZED = unchecked((int)(0xC0190062));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_SECTOR_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_SECTOR_INVALID ((NTSTATUS)0xC01A0001L)")]
    public const int STATUS_LOG_SECTOR_INVALID = unchecked((int)(0xC01A0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_SECTOR_PARITY_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_SECTOR_PARITY_INVALID ((NTSTATUS)0xC01A0002L)")]
    public const int STATUS_LOG_SECTOR_PARITY_INVALID = unchecked((int)(0xC01A0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_SECTOR_REMAPPED"]/*' />
    [NativeTypeName("#define STATUS_LOG_SECTOR_REMAPPED ((NTSTATUS)0xC01A0003L)")]
    public const int STATUS_LOG_SECTOR_REMAPPED = unchecked((int)(0xC01A0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_BLOCK_INCOMPLETE"]/*' />
    [NativeTypeName("#define STATUS_LOG_BLOCK_INCOMPLETE ((NTSTATUS)0xC01A0004L)")]
    public const int STATUS_LOG_BLOCK_INCOMPLETE = unchecked((int)(0xC01A0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_INVALID_RANGE"]/*' />
    [NativeTypeName("#define STATUS_LOG_INVALID_RANGE ((NTSTATUS)0xC01A0005L)")]
    public const int STATUS_LOG_INVALID_RANGE = unchecked((int)(0xC01A0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_BLOCKS_EXHAUSTED"]/*' />
    [NativeTypeName("#define STATUS_LOG_BLOCKS_EXHAUSTED ((NTSTATUS)0xC01A0006L)")]
    public const int STATUS_LOG_BLOCKS_EXHAUSTED = unchecked((int)(0xC01A0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_READ_CONTEXT_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_READ_CONTEXT_INVALID ((NTSTATUS)0xC01A0007L)")]
    public const int STATUS_LOG_READ_CONTEXT_INVALID = unchecked((int)(0xC01A0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_RESTART_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_RESTART_INVALID ((NTSTATUS)0xC01A0008L)")]
    public const int STATUS_LOG_RESTART_INVALID = unchecked((int)(0xC01A0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_BLOCK_VERSION"]/*' />
    [NativeTypeName("#define STATUS_LOG_BLOCK_VERSION ((NTSTATUS)0xC01A0009L)")]
    public const int STATUS_LOG_BLOCK_VERSION = unchecked((int)(0xC01A0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_BLOCK_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_BLOCK_INVALID ((NTSTATUS)0xC01A000AL)")]
    public const int STATUS_LOG_BLOCK_INVALID = unchecked((int)(0xC01A000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_READ_MODE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_READ_MODE_INVALID ((NTSTATUS)0xC01A000BL)")]
    public const int STATUS_LOG_READ_MODE_INVALID = unchecked((int)(0xC01A000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_NO_RESTART"]/*' />
    [NativeTypeName("#define STATUS_LOG_NO_RESTART ((NTSTATUS)0x401A000CL)")]
    public const int STATUS_LOG_NO_RESTART = ((int)(0x401A000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_LOG_METADATA_CORRUPT ((NTSTATUS)0xC01A000DL)")]
    public const int STATUS_LOG_METADATA_CORRUPT = unchecked((int)(0xC01A000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_METADATA_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_METADATA_INVALID ((NTSTATUS)0xC01A000EL)")]
    public const int STATUS_LOG_METADATA_INVALID = unchecked((int)(0xC01A000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_METADATA_INCONSISTENT"]/*' />
    [NativeTypeName("#define STATUS_LOG_METADATA_INCONSISTENT ((NTSTATUS)0xC01A000FL)")]
    public const int STATUS_LOG_METADATA_INCONSISTENT = unchecked((int)(0xC01A000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_RESERVATION_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_RESERVATION_INVALID ((NTSTATUS)0xC01A0010L)")]
    public const int STATUS_LOG_RESERVATION_INVALID = unchecked((int)(0xC01A0010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CANT_DELETE"]/*' />
    [NativeTypeName("#define STATUS_LOG_CANT_DELETE ((NTSTATUS)0xC01A0011L)")]
    public const int STATUS_LOG_CANT_DELETE = unchecked((int)(0xC01A0011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CONTAINER_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_LOG_CONTAINER_LIMIT_EXCEEDED ((NTSTATUS)0xC01A0012L)")]
    public const int STATUS_LOG_CONTAINER_LIMIT_EXCEEDED = unchecked((int)(0xC01A0012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_START_OF_LOG"]/*' />
    [NativeTypeName("#define STATUS_LOG_START_OF_LOG ((NTSTATUS)0xC01A0013L)")]
    public const int STATUS_LOG_START_OF_LOG = unchecked((int)(0xC01A0013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_POLICY_ALREADY_INSTALLED"]/*' />
    [NativeTypeName("#define STATUS_LOG_POLICY_ALREADY_INSTALLED ((NTSTATUS)0xC01A0014L)")]
    public const int STATUS_LOG_POLICY_ALREADY_INSTALLED = unchecked((int)(0xC01A0014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_POLICY_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define STATUS_LOG_POLICY_NOT_INSTALLED ((NTSTATUS)0xC01A0015L)")]
    public const int STATUS_LOG_POLICY_NOT_INSTALLED = unchecked((int)(0xC01A0015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_POLICY_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_POLICY_INVALID ((NTSTATUS)0xC01A0016L)")]
    public const int STATUS_LOG_POLICY_INVALID = unchecked((int)(0xC01A0016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_POLICY_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_LOG_POLICY_CONFLICT ((NTSTATUS)0xC01A0017L)")]
    public const int STATUS_LOG_POLICY_CONFLICT = unchecked((int)(0xC01A0017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_PINNED_ARCHIVE_TAIL"]/*' />
    [NativeTypeName("#define STATUS_LOG_PINNED_ARCHIVE_TAIL ((NTSTATUS)0xC01A0018L)")]
    public const int STATUS_LOG_PINNED_ARCHIVE_TAIL = unchecked((int)(0xC01A0018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_RECORD_NONEXISTENT"]/*' />
    [NativeTypeName("#define STATUS_LOG_RECORD_NONEXISTENT ((NTSTATUS)0xC01A0019L)")]
    public const int STATUS_LOG_RECORD_NONEXISTENT = unchecked((int)(0xC01A0019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_RECORDS_RESERVED_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_RECORDS_RESERVED_INVALID ((NTSTATUS)0xC01A001AL)")]
    public const int STATUS_LOG_RECORDS_RESERVED_INVALID = unchecked((int)(0xC01A001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_SPACE_RESERVED_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_SPACE_RESERVED_INVALID ((NTSTATUS)0xC01A001BL)")]
    public const int STATUS_LOG_SPACE_RESERVED_INVALID = unchecked((int)(0xC01A001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_TAIL_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_TAIL_INVALID ((NTSTATUS)0xC01A001CL)")]
    public const int STATUS_LOG_TAIL_INVALID = unchecked((int)(0xC01A001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_FULL"]/*' />
    [NativeTypeName("#define STATUS_LOG_FULL ((NTSTATUS)0xC01A001DL)")]
    public const int STATUS_LOG_FULL = unchecked((int)(0xC01A001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_MULTIPLEXED"]/*' />
    [NativeTypeName("#define STATUS_LOG_MULTIPLEXED ((NTSTATUS)0xC01A001EL)")]
    public const int STATUS_LOG_MULTIPLEXED = unchecked((int)(0xC01A001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_DEDICATED"]/*' />
    [NativeTypeName("#define STATUS_LOG_DEDICATED ((NTSTATUS)0xC01A001FL)")]
    public const int STATUS_LOG_DEDICATED = unchecked((int)(0xC01A001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_ARCHIVE_NOT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_LOG_ARCHIVE_NOT_IN_PROGRESS ((NTSTATUS)0xC01A0020L)")]
    public const int STATUS_LOG_ARCHIVE_NOT_IN_PROGRESS = unchecked((int)(0xC01A0020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_ARCHIVE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_LOG_ARCHIVE_IN_PROGRESS ((NTSTATUS)0xC01A0021L)")]
    public const int STATUS_LOG_ARCHIVE_IN_PROGRESS = unchecked((int)(0xC01A0021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_EPHEMERAL"]/*' />
    [NativeTypeName("#define STATUS_LOG_EPHEMERAL ((NTSTATUS)0xC01A0022L)")]
    public const int STATUS_LOG_EPHEMERAL = unchecked((int)(0xC01A0022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_NOT_ENOUGH_CONTAINERS"]/*' />
    [NativeTypeName("#define STATUS_LOG_NOT_ENOUGH_CONTAINERS ((NTSTATUS)0xC01A0023L)")]
    public const int STATUS_LOG_NOT_ENOUGH_CONTAINERS = unchecked((int)(0xC01A0023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CLIENT_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_LOG_CLIENT_ALREADY_REGISTERED ((NTSTATUS)0xC01A0024L)")]
    public const int STATUS_LOG_CLIENT_ALREADY_REGISTERED = unchecked((int)(0xC01A0024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CLIENT_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_LOG_CLIENT_NOT_REGISTERED ((NTSTATUS)0xC01A0025L)")]
    public const int STATUS_LOG_CLIENT_NOT_REGISTERED = unchecked((int)(0xC01A0025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_FULL_HANDLER_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_LOG_FULL_HANDLER_IN_PROGRESS ((NTSTATUS)0xC01A0026L)")]
    public const int STATUS_LOG_FULL_HANDLER_IN_PROGRESS = unchecked((int)(0xC01A0026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CONTAINER_READ_FAILED"]/*' />
    [NativeTypeName("#define STATUS_LOG_CONTAINER_READ_FAILED ((NTSTATUS)0xC01A0027L)")]
    public const int STATUS_LOG_CONTAINER_READ_FAILED = unchecked((int)(0xC01A0027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CONTAINER_WRITE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_LOG_CONTAINER_WRITE_FAILED ((NTSTATUS)0xC01A0028L)")]
    public const int STATUS_LOG_CONTAINER_WRITE_FAILED = unchecked((int)(0xC01A0028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CONTAINER_OPEN_FAILED"]/*' />
    [NativeTypeName("#define STATUS_LOG_CONTAINER_OPEN_FAILED ((NTSTATUS)0xC01A0029L)")]
    public const int STATUS_LOG_CONTAINER_OPEN_FAILED = unchecked((int)(0xC01A0029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_CONTAINER_STATE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_CONTAINER_STATE_INVALID ((NTSTATUS)0xC01A002AL)")]
    public const int STATUS_LOG_CONTAINER_STATE_INVALID = unchecked((int)(0xC01A002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_STATE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_LOG_STATE_INVALID ((NTSTATUS)0xC01A002BL)")]
    public const int STATUS_LOG_STATE_INVALID = unchecked((int)(0xC01A002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_PINNED"]/*' />
    [NativeTypeName("#define STATUS_LOG_PINNED ((NTSTATUS)0xC01A002CL)")]
    public const int STATUS_LOG_PINNED = unchecked((int)(0xC01A002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_METADATA_FLUSH_FAILED"]/*' />
    [NativeTypeName("#define STATUS_LOG_METADATA_FLUSH_FAILED ((NTSTATUS)0xC01A002DL)")]
    public const int STATUS_LOG_METADATA_FLUSH_FAILED = unchecked((int)(0xC01A002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_INCONSISTENT_SECURITY"]/*' />
    [NativeTypeName("#define STATUS_LOG_INCONSISTENT_SECURITY ((NTSTATUS)0xC01A002EL)")]
    public const int STATUS_LOG_INCONSISTENT_SECURITY = unchecked((int)(0xC01A002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_APPENDED_FLUSH_FAILED"]/*' />
    [NativeTypeName("#define STATUS_LOG_APPENDED_FLUSH_FAILED ((NTSTATUS)0xC01A002FL)")]
    public const int STATUS_LOG_APPENDED_FLUSH_FAILED = unchecked((int)(0xC01A002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LOG_PINNED_RESERVATION"]/*' />
    [NativeTypeName("#define STATUS_LOG_PINNED_RESERVATION ((NTSTATUS)0xC01A0030L)")]
    public const int STATUS_LOG_PINNED_RESERVATION = unchecked((int)(0xC01A0030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD"]/*' />
    [NativeTypeName("#define STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD ((NTSTATUS)0xC01B00EAL)")]
    public const int STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD = unchecked((int)(0xC01B00EA));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD_RECOVERED"]/*' />
    [NativeTypeName("#define STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD_RECOVERED ((NTSTATUS)0x801B00EBL)")]
    public const int STATUS_VIDEO_HUNG_DISPLAY_DRIVER_THREAD_RECOVERED = unchecked((int)(0x801B00EB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIDEO_DRIVER_DEBUG_REPORT_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_VIDEO_DRIVER_DEBUG_REPORT_REQUEST ((NTSTATUS)0x401B00ECL)")]
    public const int STATUS_VIDEO_DRIVER_DEBUG_REPORT_REQUEST = ((int)(0x401B00EC));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_NO_DESCRIPTOR"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_NO_DESCRIPTOR ((NTSTATUS)0xC01D0001L)")]
    public const int STATUS_MONITOR_NO_DESCRIPTOR = unchecked((int)(0xC01D0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT ((NTSTATUS)0xC01D0002L)")]
    public const int STATUS_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT = unchecked((int)(0xC01D0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_INVALID_DESCRIPTOR_CHECKSUM"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_INVALID_DESCRIPTOR_CHECKSUM ((NTSTATUS)0xC01D0003L)")]
    public const int STATUS_MONITOR_INVALID_DESCRIPTOR_CHECKSUM = unchecked((int)(0xC01D0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_INVALID_STANDARD_TIMING_BLOCK"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_INVALID_STANDARD_TIMING_BLOCK ((NTSTATUS)0xC01D0004L)")]
    public const int STATUS_MONITOR_INVALID_STANDARD_TIMING_BLOCK = unchecked((int)(0xC01D0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED ((NTSTATUS)0xC01D0005L)")]
    public const int STATUS_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED = unchecked((int)(0xC01D0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK ((NTSTATUS)0xC01D0006L)")]
    public const int STATUS_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK = unchecked((int)(0xC01D0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK ((NTSTATUS)0xC01D0007L)")]
    public const int STATUS_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK = unchecked((int)(0xC01D0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_NO_MORE_DESCRIPTOR_DATA"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_NO_MORE_DESCRIPTOR_DATA ((NTSTATUS)0xC01D0008L)")]
    public const int STATUS_MONITOR_NO_MORE_DESCRIPTOR_DATA = unchecked((int)(0xC01D0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_INVALID_DETAILED_TIMING_BLOCK"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_INVALID_DETAILED_TIMING_BLOCK ((NTSTATUS)0xC01D0009L)")]
    public const int STATUS_MONITOR_INVALID_DETAILED_TIMING_BLOCK = unchecked((int)(0xC01D0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_MONITOR_INVALID_MANUFACTURE_DATE"]/*' />
    [NativeTypeName("#define STATUS_MONITOR_INVALID_MANUFACTURE_DATE ((NTSTATUS)0xC01D000AL)")]
    public const int STATUS_MONITOR_INVALID_MANUFACTURE_DATE = unchecked((int)(0xC01D000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER ((NTSTATUS)0xC01E0000L)")]
    public const int STATUS_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER = unchecked((int)(0xC01E0000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INSUFFICIENT_DMA_BUFFER"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INSUFFICIENT_DMA_BUFFER ((NTSTATUS)0xC01E0001L)")]
    public const int STATUS_GRAPHICS_INSUFFICIENT_DMA_BUFFER = unchecked((int)(0xC01E0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_DISPLAY_ADAPTER"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_DISPLAY_ADAPTER ((NTSTATUS)0xC01E0002L)")]
    public const int STATUS_GRAPHICS_INVALID_DISPLAY_ADAPTER = unchecked((int)(0xC01E0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ADAPTER_WAS_RESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ADAPTER_WAS_RESET ((NTSTATUS)0xC01E0003L)")]
    public const int STATUS_GRAPHICS_ADAPTER_WAS_RESET = unchecked((int)(0xC01E0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_DRIVER_MODEL"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_DRIVER_MODEL ((NTSTATUS)0xC01E0004L)")]
    public const int STATUS_GRAPHICS_INVALID_DRIVER_MODEL = unchecked((int)(0xC01E0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PRESENT_MODE_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PRESENT_MODE_CHANGED ((NTSTATUS)0xC01E0005L)")]
    public const int STATUS_GRAPHICS_PRESENT_MODE_CHANGED = unchecked((int)(0xC01E0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PRESENT_OCCLUDED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PRESENT_OCCLUDED ((NTSTATUS)0xC01E0006L)")]
    public const int STATUS_GRAPHICS_PRESENT_OCCLUDED = unchecked((int)(0xC01E0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PRESENT_DENIED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PRESENT_DENIED ((NTSTATUS)0xC01E0007L)")]
    public const int STATUS_GRAPHICS_PRESENT_DENIED = unchecked((int)(0xC01E0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CANNOTCOLORCONVERT"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CANNOTCOLORCONVERT ((NTSTATUS)0xC01E0008L)")]
    public const int STATUS_GRAPHICS_CANNOTCOLORCONVERT = unchecked((int)(0xC01E0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DRIVER_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DRIVER_MISMATCH ((NTSTATUS)0xC01E0009L)")]
    public const int STATUS_GRAPHICS_DRIVER_MISMATCH = unchecked((int)(0xC01E0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PARTIAL_DATA_POPULATED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PARTIAL_DATA_POPULATED ((NTSTATUS)0x401E000AL)")]
    public const int STATUS_GRAPHICS_PARTIAL_DATA_POPULATED = ((int)(0x401E000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PRESENT_REDIRECTION_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PRESENT_REDIRECTION_DISABLED ((NTSTATUS)0xC01E000BL)")]
    public const int STATUS_GRAPHICS_PRESENT_REDIRECTION_DISABLED = unchecked((int)(0xC01E000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PRESENT_UNOCCLUDED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PRESENT_UNOCCLUDED ((NTSTATUS)0xC01E000CL)")]
    public const int STATUS_GRAPHICS_PRESENT_UNOCCLUDED = unchecked((int)(0xC01E000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_WINDOWDC_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_WINDOWDC_NOT_AVAILABLE ((NTSTATUS)0xC01E000DL)")]
    public const int STATUS_GRAPHICS_WINDOWDC_NOT_AVAILABLE = unchecked((int)(0xC01E000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_WINDOWLESS_PRESENT_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_WINDOWLESS_PRESENT_DISABLED ((NTSTATUS)0xC01E000EL)")]
    public const int STATUS_GRAPHICS_WINDOWLESS_PRESENT_DISABLED = unchecked((int)(0xC01E000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PRESENT_INVALID_WINDOW"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PRESENT_INVALID_WINDOW ((NTSTATUS)0xC01E000FL)")]
    public const int STATUS_GRAPHICS_PRESENT_INVALID_WINDOW = unchecked((int)(0xC01E000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PRESENT_BUFFER_NOT_BOUND"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PRESENT_BUFFER_NOT_BOUND ((NTSTATUS)0xC01E0010L)")]
    public const int STATUS_GRAPHICS_PRESENT_BUFFER_NOT_BOUND = unchecked((int)(0xC01E0010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_VAIL_STATE_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_VAIL_STATE_CHANGED ((NTSTATUS)0xC01E0011L)")]
    public const int STATUS_GRAPHICS_VAIL_STATE_CHANGED = unchecked((int)(0xC01E0011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INDIRECT_DISPLAY_ABANDON_SWAPCHAIN"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INDIRECT_DISPLAY_ABANDON_SWAPCHAIN ((NTSTATUS)0xC01E0012L)")]
    public const int STATUS_GRAPHICS_INDIRECT_DISPLAY_ABANDON_SWAPCHAIN = unchecked((int)(0xC01E0012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INDIRECT_DISPLAY_DEVICE_STOPPED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INDIRECT_DISPLAY_DEVICE_STOPPED ((NTSTATUS)0xC01E0013L)")]
    public const int STATUS_GRAPHICS_INDIRECT_DISPLAY_DEVICE_STOPPED = unchecked((int)(0xC01E0013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MPO_ALLOCATION_UNPINNED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MPO_ALLOCATION_UNPINNED ((NTSTATUS)0xC01E0018L)")]
    public const int STATUS_GRAPHICS_MPO_ALLOCATION_UNPINNED = unchecked((int)(0xC01E0018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_SETDISPLAYMODE_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_SETDISPLAYMODE_REQUIRED ((NTSTATUS)0xC01E0019L)")]
    public const int STATUS_GRAPHICS_SETDISPLAYMODE_REQUIRED = unchecked((int)(0xC01E0019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_VIDEO_MEMORY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_VIDEO_MEMORY ((NTSTATUS)0xC01E0100L)")]
    public const int STATUS_GRAPHICS_NO_VIDEO_MEMORY = unchecked((int)(0xC01E0100));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CANT_LOCK_MEMORY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CANT_LOCK_MEMORY ((NTSTATUS)0xC01E0101L)")]
    public const int STATUS_GRAPHICS_CANT_LOCK_MEMORY = unchecked((int)(0xC01E0101));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ALLOCATION_BUSY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ALLOCATION_BUSY ((NTSTATUS)0xC01E0102L)")]
    public const int STATUS_GRAPHICS_ALLOCATION_BUSY = unchecked((int)(0xC01E0102));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_TOO_MANY_REFERENCES"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_TOO_MANY_REFERENCES ((NTSTATUS)0xC01E0103L)")]
    public const int STATUS_GRAPHICS_TOO_MANY_REFERENCES = unchecked((int)(0xC01E0103));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_TRY_AGAIN_LATER"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_TRY_AGAIN_LATER ((NTSTATUS)0xC01E0104L)")]
    public const int STATUS_GRAPHICS_TRY_AGAIN_LATER = unchecked((int)(0xC01E0104));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_TRY_AGAIN_NOW"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_TRY_AGAIN_NOW ((NTSTATUS)0xC01E0105L)")]
    public const int STATUS_GRAPHICS_TRY_AGAIN_NOW = unchecked((int)(0xC01E0105));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ALLOCATION_INVALID"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ALLOCATION_INVALID ((NTSTATUS)0xC01E0106L)")]
    public const int STATUS_GRAPHICS_ALLOCATION_INVALID = unchecked((int)(0xC01E0106));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE ((NTSTATUS)0xC01E0107L)")]
    public const int STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE = unchecked((int)(0xC01E0107));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED ((NTSTATUS)0xC01E0108L)")]
    public const int STATUS_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED = unchecked((int)(0xC01E0108));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION ((NTSTATUS)0xC01E0109L)")]
    public const int STATUS_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION = unchecked((int)(0xC01E0109));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_ALLOCATION_USAGE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_ALLOCATION_USAGE ((NTSTATUS)0xC01E0110L)")]
    public const int STATUS_GRAPHICS_INVALID_ALLOCATION_USAGE = unchecked((int)(0xC01E0110));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION ((NTSTATUS)0xC01E0111L)")]
    public const int STATUS_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION = unchecked((int)(0xC01E0111));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ALLOCATION_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ALLOCATION_CLOSED ((NTSTATUS)0xC01E0112L)")]
    public const int STATUS_GRAPHICS_ALLOCATION_CLOSED = unchecked((int)(0xC01E0112));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_ALLOCATION_INSTANCE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_ALLOCATION_INSTANCE ((NTSTATUS)0xC01E0113L)")]
    public const int STATUS_GRAPHICS_INVALID_ALLOCATION_INSTANCE = unchecked((int)(0xC01E0113));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_ALLOCATION_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_ALLOCATION_HANDLE ((NTSTATUS)0xC01E0114L)")]
    public const int STATUS_GRAPHICS_INVALID_ALLOCATION_HANDLE = unchecked((int)(0xC01E0114));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_WRONG_ALLOCATION_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_WRONG_ALLOCATION_DEVICE ((NTSTATUS)0xC01E0115L)")]
    public const int STATUS_GRAPHICS_WRONG_ALLOCATION_DEVICE = unchecked((int)(0xC01E0115));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ALLOCATION_CONTENT_LOST"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ALLOCATION_CONTENT_LOST ((NTSTATUS)0xC01E0116L)")]
    public const int STATUS_GRAPHICS_ALLOCATION_CONTENT_LOST = unchecked((int)(0xC01E0116));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_GPU_EXCEPTION_ON_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_GPU_EXCEPTION_ON_DEVICE ((NTSTATUS)0xC01E0200L)")]
    public const int STATUS_GRAPHICS_GPU_EXCEPTION_ON_DEVICE = unchecked((int)(0xC01E0200));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_SKIP_ALLOCATION_PREPARATION"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_SKIP_ALLOCATION_PREPARATION ((NTSTATUS)0x401E0201L)")]
    public const int STATUS_GRAPHICS_SKIP_ALLOCATION_PREPARATION = ((int)(0x401E0201));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY ((NTSTATUS)0xC01E0300L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY = unchecked((int)(0xC01E0300));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED ((NTSTATUS)0xC01E0301L)")]
    public const int STATUS_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED = unchecked((int)(0xC01E0301));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED ((NTSTATUS)0xC01E0302L)")]
    public const int STATUS_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED = unchecked((int)(0xC01E0302));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDPN"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDPN ((NTSTATUS)0xC01E0303L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDPN = unchecked((int)(0xC01E0303));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE ((NTSTATUS)0xC01E0304L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE = unchecked((int)(0xC01E0304));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET ((NTSTATUS)0xC01E0305L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET = unchecked((int)(0xC01E0305));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED ((NTSTATUS)0xC01E0306L)")]
    public const int STATUS_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED = unchecked((int)(0xC01E0306));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MODE_NOT_PINNED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MODE_NOT_PINNED ((NTSTATUS)0x401E0307L)")]
    public const int STATUS_GRAPHICS_MODE_NOT_PINNED = ((int)(0x401E0307));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDPN_SOURCEMODESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDPN_SOURCEMODESET ((NTSTATUS)0xC01E0308L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDPN_SOURCEMODESET = unchecked((int)(0xC01E0308));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDPN_TARGETMODESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDPN_TARGETMODESET ((NTSTATUS)0xC01E0309L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDPN_TARGETMODESET = unchecked((int)(0xC01E0309));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_FREQUENCY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_FREQUENCY ((NTSTATUS)0xC01E030AL)")]
    public const int STATUS_GRAPHICS_INVALID_FREQUENCY = unchecked((int)(0xC01E030A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_ACTIVE_REGION"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_ACTIVE_REGION ((NTSTATUS)0xC01E030BL)")]
    public const int STATUS_GRAPHICS_INVALID_ACTIVE_REGION = unchecked((int)(0xC01E030B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_TOTAL_REGION"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_TOTAL_REGION ((NTSTATUS)0xC01E030CL)")]
    public const int STATUS_GRAPHICS_INVALID_TOTAL_REGION = unchecked((int)(0xC01E030C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE ((NTSTATUS)0xC01E0310L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE = unchecked((int)(0xC01E0310));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE ((NTSTATUS)0xC01E0311L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE = unchecked((int)(0xC01E0311));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET ((NTSTATUS)0xC01E0312L)")]
    public const int STATUS_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET = unchecked((int)(0xC01E0312));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY ((NTSTATUS)0xC01E0313L)")]
    public const int STATUS_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY = unchecked((int)(0xC01E0313));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MODE_ALREADY_IN_MODESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MODE_ALREADY_IN_MODESET ((NTSTATUS)0xC01E0314L)")]
    public const int STATUS_GRAPHICS_MODE_ALREADY_IN_MODESET = unchecked((int)(0xC01E0314));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET ((NTSTATUS)0xC01E0315L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET = unchecked((int)(0xC01E0315));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET ((NTSTATUS)0xC01E0316L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET = unchecked((int)(0xC01E0316));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_SOURCE_ALREADY_IN_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_SOURCE_ALREADY_IN_SET ((NTSTATUS)0xC01E0317L)")]
    public const int STATUS_GRAPHICS_SOURCE_ALREADY_IN_SET = unchecked((int)(0xC01E0317));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_TARGET_ALREADY_IN_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_TARGET_ALREADY_IN_SET ((NTSTATUS)0xC01E0318L)")]
    public const int STATUS_GRAPHICS_TARGET_ALREADY_IN_SET = unchecked((int)(0xC01E0318));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDPN_PRESENT_PATH"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDPN_PRESENT_PATH ((NTSTATUS)0xC01E0319L)")]
    public const int STATUS_GRAPHICS_INVALID_VIDPN_PRESENT_PATH = unchecked((int)(0xC01E0319));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY ((NTSTATUS)0xC01E031AL)")]
    public const int STATUS_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY = unchecked((int)(0xC01E031A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET ((NTSTATUS)0xC01E031BL)")]
    public const int STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET = unchecked((int)(0xC01E031B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE ((NTSTATUS)0xC01E031CL)")]
    public const int STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE = unchecked((int)(0xC01E031C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET ((NTSTATUS)0xC01E031DL)")]
    public const int STATUS_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET = unchecked((int)(0xC01E031D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_PREFERRED_MODE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_PREFERRED_MODE ((NTSTATUS)0x401E031EL)")]
    public const int STATUS_GRAPHICS_NO_PREFERRED_MODE = ((int)(0x401E031E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET ((NTSTATUS)0xC01E031FL)")]
    public const int STATUS_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET = unchecked((int)(0xC01E031F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_STALE_MODESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_STALE_MODESET ((NTSTATUS)0xC01E0320L)")]
    public const int STATUS_GRAPHICS_STALE_MODESET = unchecked((int)(0xC01E0320));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MONITOR_SOURCEMODESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MONITOR_SOURCEMODESET ((NTSTATUS)0xC01E0321L)")]
    public const int STATUS_GRAPHICS_INVALID_MONITOR_SOURCEMODESET = unchecked((int)(0xC01E0321));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MONITOR_SOURCE_MODE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MONITOR_SOURCE_MODE ((NTSTATUS)0xC01E0322L)")]
    public const int STATUS_GRAPHICS_INVALID_MONITOR_SOURCE_MODE = unchecked((int)(0xC01E0322));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN ((NTSTATUS)0xC01E0323L)")]
    public const int STATUS_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN = unchecked((int)(0xC01E0323));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MODE_ID_MUST_BE_UNIQUE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MODE_ID_MUST_BE_UNIQUE ((NTSTATUS)0xC01E0324L)")]
    public const int STATUS_GRAPHICS_MODE_ID_MUST_BE_UNIQUE = unchecked((int)(0xC01E0324));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION ((NTSTATUS)0xC01E0325L)")]
    public const int STATUS_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION = unchecked((int)(0xC01E0325));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES ((NTSTATUS)0xC01E0326L)")]
    public const int STATUS_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES = unchecked((int)(0xC01E0326));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PATH_NOT_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PATH_NOT_IN_TOPOLOGY ((NTSTATUS)0xC01E0327L)")]
    public const int STATUS_GRAPHICS_PATH_NOT_IN_TOPOLOGY = unchecked((int)(0xC01E0327));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE ((NTSTATUS)0xC01E0328L)")]
    public const int STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE = unchecked((int)(0xC01E0328));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET ((NTSTATUS)0xC01E0329L)")]
    public const int STATUS_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET = unchecked((int)(0xC01E0329));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MONITORDESCRIPTORSET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MONITORDESCRIPTORSET ((NTSTATUS)0xC01E032AL)")]
    public const int STATUS_GRAPHICS_INVALID_MONITORDESCRIPTORSET = unchecked((int)(0xC01E032A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MONITORDESCRIPTOR"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MONITORDESCRIPTOR ((NTSTATUS)0xC01E032BL)")]
    public const int STATUS_GRAPHICS_INVALID_MONITORDESCRIPTOR = unchecked((int)(0xC01E032B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET ((NTSTATUS)0xC01E032CL)")]
    public const int STATUS_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET = unchecked((int)(0xC01E032C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET ((NTSTATUS)0xC01E032DL)")]
    public const int STATUS_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET = unchecked((int)(0xC01E032D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE ((NTSTATUS)0xC01E032EL)")]
    public const int STATUS_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE = unchecked((int)(0xC01E032E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE ((NTSTATUS)0xC01E032FL)")]
    public const int STATUS_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE = unchecked((int)(0xC01E032F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_RESOURCES_NOT_RELATED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_RESOURCES_NOT_RELATED ((NTSTATUS)0xC01E0330L)")]
    public const int STATUS_GRAPHICS_RESOURCES_NOT_RELATED = unchecked((int)(0xC01E0330));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE ((NTSTATUS)0xC01E0331L)")]
    public const int STATUS_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE = unchecked((int)(0xC01E0331));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE ((NTSTATUS)0xC01E0332L)")]
    public const int STATUS_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE = unchecked((int)(0xC01E0332));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET ((NTSTATUS)0xC01E0333L)")]
    public const int STATUS_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET = unchecked((int)(0xC01E0333));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER ((NTSTATUS)0xC01E0334L)")]
    public const int STATUS_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER = unchecked((int)(0xC01E0334));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_VIDPNMGR"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_VIDPNMGR ((NTSTATUS)0xC01E0335L)")]
    public const int STATUS_GRAPHICS_NO_VIDPNMGR = unchecked((int)(0xC01E0335));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_ACTIVE_VIDPN"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_ACTIVE_VIDPN ((NTSTATUS)0xC01E0336L)")]
    public const int STATUS_GRAPHICS_NO_ACTIVE_VIDPN = unchecked((int)(0xC01E0336));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_STALE_VIDPN_TOPOLOGY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_STALE_VIDPN_TOPOLOGY ((NTSTATUS)0xC01E0337L)")]
    public const int STATUS_GRAPHICS_STALE_VIDPN_TOPOLOGY = unchecked((int)(0xC01E0337));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MONITOR_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MONITOR_NOT_CONNECTED ((NTSTATUS)0xC01E0338L)")]
    public const int STATUS_GRAPHICS_MONITOR_NOT_CONNECTED = unchecked((int)(0xC01E0338));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY ((NTSTATUS)0xC01E0339L)")]
    public const int STATUS_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY = unchecked((int)(0xC01E0339));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE ((NTSTATUS)0xC01E033AL)")]
    public const int STATUS_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE = unchecked((int)(0xC01E033A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VISIBLEREGION_SIZE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VISIBLEREGION_SIZE ((NTSTATUS)0xC01E033BL)")]
    public const int STATUS_GRAPHICS_INVALID_VISIBLEREGION_SIZE = unchecked((int)(0xC01E033B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_STRIDE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_STRIDE ((NTSTATUS)0xC01E033CL)")]
    public const int STATUS_GRAPHICS_INVALID_STRIDE = unchecked((int)(0xC01E033C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_PIXELFORMAT"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_PIXELFORMAT ((NTSTATUS)0xC01E033DL)")]
    public const int STATUS_GRAPHICS_INVALID_PIXELFORMAT = unchecked((int)(0xC01E033D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_COLORBASIS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_COLORBASIS ((NTSTATUS)0xC01E033EL)")]
    public const int STATUS_GRAPHICS_INVALID_COLORBASIS = unchecked((int)(0xC01E033E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_PIXELVALUEACCESSMODE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_PIXELVALUEACCESSMODE ((NTSTATUS)0xC01E033FL)")]
    public const int STATUS_GRAPHICS_INVALID_PIXELVALUEACCESSMODE = unchecked((int)(0xC01E033F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_TARGET_NOT_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_TARGET_NOT_IN_TOPOLOGY ((NTSTATUS)0xC01E0340L)")]
    public const int STATUS_GRAPHICS_TARGET_NOT_IN_TOPOLOGY = unchecked((int)(0xC01E0340));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT ((NTSTATUS)0xC01E0341L)")]
    public const int STATUS_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT = unchecked((int)(0xC01E0341));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE ((NTSTATUS)0xC01E0342L)")]
    public const int STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)(0xC01E0342));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN ((NTSTATUS)0xC01E0343L)")]
    public const int STATUS_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN = unchecked((int)(0xC01E0343));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL ((NTSTATUS)0xC01E0344L)")]
    public const int STATUS_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL = unchecked((int)(0xC01E0344));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION ((NTSTATUS)0xC01E0345L)")]
    public const int STATUS_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION = unchecked((int)(0xC01E0345));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED ((NTSTATUS)0xC01E0346L)")]
    public const int STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED = unchecked((int)(0xC01E0346));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_GAMMA_RAMP"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_GAMMA_RAMP ((NTSTATUS)0xC01E0347L)")]
    public const int STATUS_GRAPHICS_INVALID_GAMMA_RAMP = unchecked((int)(0xC01E0347));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED ((NTSTATUS)0xC01E0348L)")]
    public const int STATUS_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED = unchecked((int)(0xC01E0348));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED ((NTSTATUS)0xC01E0349L)")]
    public const int STATUS_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED = unchecked((int)(0xC01E0349));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MODE_NOT_IN_MODESET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MODE_NOT_IN_MODESET ((NTSTATUS)0xC01E034AL)")]
    public const int STATUS_GRAPHICS_MODE_NOT_IN_MODESET = unchecked((int)(0xC01E034A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DATASET_IS_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DATASET_IS_EMPTY ((NTSTATUS)0x401E034BL)")]
    public const int STATUS_GRAPHICS_DATASET_IS_EMPTY = ((int)(0x401E034B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET ((NTSTATUS)0x401E034CL)")]
    public const int STATUS_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET = ((int)(0x401E034C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON ((NTSTATUS)0xC01E034DL)")]
    public const int STATUS_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON = unchecked((int)(0xC01E034D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_PATH_CONTENT_TYPE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_PATH_CONTENT_TYPE ((NTSTATUS)0xC01E034EL)")]
    public const int STATUS_GRAPHICS_INVALID_PATH_CONTENT_TYPE = unchecked((int)(0xC01E034E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_COPYPROTECTION_TYPE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_COPYPROTECTION_TYPE ((NTSTATUS)0xC01E034FL)")]
    public const int STATUS_GRAPHICS_INVALID_COPYPROTECTION_TYPE = unchecked((int)(0xC01E034F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS ((NTSTATUS)0xC01E0350L)")]
    public const int STATUS_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS = unchecked((int)(0xC01E0350));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED ((NTSTATUS)0x401E0351L)")]
    public const int STATUS_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED = ((int)(0x401E0351));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_SCANLINE_ORDERING"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_SCANLINE_ORDERING ((NTSTATUS)0xC01E0352L)")]
    public const int STATUS_GRAPHICS_INVALID_SCANLINE_ORDERING = unchecked((int)(0xC01E0352));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED ((NTSTATUS)0xC01E0353L)")]
    public const int STATUS_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED = unchecked((int)(0xC01E0353));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS ((NTSTATUS)0xC01E0354L)")]
    public const int STATUS_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS = unchecked((int)(0xC01E0354));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT ((NTSTATUS)0xC01E0355L)")]
    public const int STATUS_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT = unchecked((int)(0xC01E0355));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM ((NTSTATUS)0xC01E0356L)")]
    public const int STATUS_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM = unchecked((int)(0xC01E0356));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN ((NTSTATUS)0xC01E0357L)")]
    public const int STATUS_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN = unchecked((int)(0xC01E0357));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT ((NTSTATUS)0xC01E0358L)")]
    public const int STATUS_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT = unchecked((int)(0xC01E0358));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MAX_NUM_PATHS_REACHED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MAX_NUM_PATHS_REACHED ((NTSTATUS)0xC01E0359L)")]
    public const int STATUS_GRAPHICS_MAX_NUM_PATHS_REACHED = unchecked((int)(0xC01E0359));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION ((NTSTATUS)0xC01E035AL)")]
    public const int STATUS_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION = unchecked((int)(0xC01E035A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_CLIENT_TYPE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_CLIENT_TYPE ((NTSTATUS)0xC01E035BL)")]
    public const int STATUS_GRAPHICS_INVALID_CLIENT_TYPE = unchecked((int)(0xC01E035B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CLIENTVIDPN_NOT_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CLIENTVIDPN_NOT_SET ((NTSTATUS)0xC01E035CL)")]
    public const int STATUS_GRAPHICS_CLIENTVIDPN_NOT_SET = unchecked((int)(0xC01E035C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED ((NTSTATUS)0xC01E0400L)")]
    public const int STATUS_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED = unchecked((int)(0xC01E0400));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED ((NTSTATUS)0xC01E0401L)")]
    public const int STATUS_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED = unchecked((int)(0xC01E0401));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_UNKNOWN_CHILD_STATUS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_UNKNOWN_CHILD_STATUS ((NTSTATUS)0x401E042FL)")]
    public const int STATUS_GRAPHICS_UNKNOWN_CHILD_STATUS = ((int)(0x401E042F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NOT_A_LINKED_ADAPTER"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NOT_A_LINKED_ADAPTER ((NTSTATUS)0xC01E0430L)")]
    public const int STATUS_GRAPHICS_NOT_A_LINKED_ADAPTER = unchecked((int)(0xC01E0430));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_LEADLINK_NOT_ENUMERATED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_LEADLINK_NOT_ENUMERATED ((NTSTATUS)0xC01E0431L)")]
    public const int STATUS_GRAPHICS_LEADLINK_NOT_ENUMERATED = unchecked((int)(0xC01E0431));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CHAINLINKS_NOT_ENUMERATED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CHAINLINKS_NOT_ENUMERATED ((NTSTATUS)0xC01E0432L)")]
    public const int STATUS_GRAPHICS_CHAINLINKS_NOT_ENUMERATED = unchecked((int)(0xC01E0432));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ADAPTER_CHAIN_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ADAPTER_CHAIN_NOT_READY ((NTSTATUS)0xC01E0433L)")]
    public const int STATUS_GRAPHICS_ADAPTER_CHAIN_NOT_READY = unchecked((int)(0xC01E0433));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CHAINLINKS_NOT_STARTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CHAINLINKS_NOT_STARTED ((NTSTATUS)0xC01E0434L)")]
    public const int STATUS_GRAPHICS_CHAINLINKS_NOT_STARTED = unchecked((int)(0xC01E0434));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_CHAINLINKS_NOT_POWERED_ON"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_CHAINLINKS_NOT_POWERED_ON ((NTSTATUS)0xC01E0435L)")]
    public const int STATUS_GRAPHICS_CHAINLINKS_NOT_POWERED_ON = unchecked((int)(0xC01E0435));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE ((NTSTATUS)0xC01E0436L)")]
    public const int STATUS_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE = unchecked((int)(0xC01E0436));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_LEADLINK_START_DEFERRED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_LEADLINK_START_DEFERRED ((NTSTATUS)0x401E0437L)")]
    public const int STATUS_GRAPHICS_LEADLINK_START_DEFERRED = ((int)(0x401E0437));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NOT_POST_DEVICE_DRIVER"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NOT_POST_DEVICE_DRIVER ((NTSTATUS)0xC01E0438L)")]
    public const int STATUS_GRAPHICS_NOT_POST_DEVICE_DRIVER = unchecked((int)(0xC01E0438));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_POLLING_TOO_FREQUENTLY"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_POLLING_TOO_FREQUENTLY ((NTSTATUS)0x401E0439L)")]
    public const int STATUS_GRAPHICS_POLLING_TOO_FREQUENTLY = ((int)(0x401E0439));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_START_DEFERRED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_START_DEFERRED ((NTSTATUS)0x401E043AL)")]
    public const int STATUS_GRAPHICS_START_DEFERRED = ((int)(0x401E043A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED ((NTSTATUS)0xC01E043BL)")]
    public const int STATUS_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED = unchecked((int)(0xC01E043B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DEPENDABLE_CHILD_STATUS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DEPENDABLE_CHILD_STATUS ((NTSTATUS)0x401E043CL)")]
    public const int STATUS_GRAPHICS_DEPENDABLE_CHILD_STATUS = ((int)(0x401E043C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_NOT_SUPPORTED ((NTSTATUS)0xC01E0500L)")]
    public const int STATUS_GRAPHICS_OPM_NOT_SUPPORTED = unchecked((int)(0xC01E0500));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_COPP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_COPP_NOT_SUPPORTED ((NTSTATUS)0xC01E0501L)")]
    public const int STATUS_GRAPHICS_COPP_NOT_SUPPORTED = unchecked((int)(0xC01E0501));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_UAB_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_UAB_NOT_SUPPORTED ((NTSTATUS)0xC01E0502L)")]
    public const int STATUS_GRAPHICS_UAB_NOT_SUPPORTED = unchecked((int)(0xC01E0502));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS ((NTSTATUS)0xC01E0503L)")]
    public const int STATUS_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS = unchecked((int)(0xC01E0503));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_NO_PROTECTED_OUTPUTS_EXIST"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_NO_PROTECTED_OUTPUTS_EXIST ((NTSTATUS)0xC01E0505L)")]
    public const int STATUS_GRAPHICS_OPM_NO_PROTECTED_OUTPUTS_EXIST = unchecked((int)(0xC01E0505));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_INTERNAL_ERROR ((NTSTATUS)0xC01E050BL)")]
    public const int STATUS_GRAPHICS_OPM_INTERNAL_ERROR = unchecked((int)(0xC01E050B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_INVALID_HANDLE ((NTSTATUS)0xC01E050CL)")]
    public const int STATUS_GRAPHICS_OPM_INVALID_HANDLE = unchecked((int)(0xC01E050C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH ((NTSTATUS)0xC01E050EL)")]
    public const int STATUS_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH = unchecked((int)(0xC01E050E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_SPANNING_MODE_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_SPANNING_MODE_ENABLED ((NTSTATUS)0xC01E050FL)")]
    public const int STATUS_GRAPHICS_OPM_SPANNING_MODE_ENABLED = unchecked((int)(0xC01E050F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_THEATER_MODE_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_THEATER_MODE_ENABLED ((NTSTATUS)0xC01E0510L)")]
    public const int STATUS_GRAPHICS_OPM_THEATER_MODE_ENABLED = unchecked((int)(0xC01E0510));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PVP_HFS_FAILED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PVP_HFS_FAILED ((NTSTATUS)0xC01E0511L)")]
    public const int STATUS_GRAPHICS_PVP_HFS_FAILED = unchecked((int)(0xC01E0511));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_INVALID_SRM"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_INVALID_SRM ((NTSTATUS)0xC01E0512L)")]
    public const int STATUS_GRAPHICS_OPM_INVALID_SRM = unchecked((int)(0xC01E0512));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP ((NTSTATUS)0xC01E0513L)")]
    public const int STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP = unchecked((int)(0xC01E0513));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP ((NTSTATUS)0xC01E0514L)")]
    public const int STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP = unchecked((int)(0xC01E0514));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA ((NTSTATUS)0xC01E0515L)")]
    public const int STATUS_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA = unchecked((int)(0xC01E0515));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_HDCP_SRM_NEVER_SET"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_HDCP_SRM_NEVER_SET ((NTSTATUS)0xC01E0516L)")]
    public const int STATUS_GRAPHICS_OPM_HDCP_SRM_NEVER_SET = unchecked((int)(0xC01E0516));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_RESOLUTION_TOO_HIGH"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_RESOLUTION_TOO_HIGH ((NTSTATUS)0xC01E0517L)")]
    public const int STATUS_GRAPHICS_OPM_RESOLUTION_TOO_HIGH = unchecked((int)(0xC01E0517));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE ((NTSTATUS)0xC01E0518L)")]
    public const int STATUS_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE = unchecked((int)(0xC01E0518));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_NO_LONGER_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_NO_LONGER_EXISTS ((NTSTATUS)0xC01E051AL)")]
    public const int STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_NO_LONGER_EXISTS = unchecked((int)(0xC01E051A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS ((NTSTATUS)0xC01E051CL)")]
    public const int STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS = unchecked((int)(0xC01E051C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST ((NTSTATUS)0xC01E051DL)")]
    public const int STATUS_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST = unchecked((int)(0xC01E051D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR ((NTSTATUS)0xC01E051EL)")]
    public const int STATUS_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR = unchecked((int)(0xC01E051E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS ((NTSTATUS)0xC01E051FL)")]
    public const int STATUS_GRAPHICS_OPM_PROTECTED_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS = unchecked((int)(0xC01E051F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED ((NTSTATUS)0xC01E0520L)")]
    public const int STATUS_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED = unchecked((int)(0xC01E0520));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST ((NTSTATUS)0xC01E0521L)")]
    public const int STATUS_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST = unchecked((int)(0xC01E0521));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_I2C_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_I2C_NOT_SUPPORTED ((NTSTATUS)0xC01E0580L)")]
    public const int STATUS_GRAPHICS_I2C_NOT_SUPPORTED = unchecked((int)(0xC01E0580));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST ((NTSTATUS)0xC01E0581L)")]
    public const int STATUS_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST = unchecked((int)(0xC01E0581));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA ((NTSTATUS)0xC01E0582L)")]
    public const int STATUS_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA = unchecked((int)(0xC01E0582));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_I2C_ERROR_RECEIVING_DATA"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_I2C_ERROR_RECEIVING_DATA ((NTSTATUS)0xC01E0583L)")]
    public const int STATUS_GRAPHICS_I2C_ERROR_RECEIVING_DATA = unchecked((int)(0xC01E0583));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED ((NTSTATUS)0xC01E0584L)")]
    public const int STATUS_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED = unchecked((int)(0xC01E0584));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DDCCI_INVALID_DATA"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DDCCI_INVALID_DATA ((NTSTATUS)0xC01E0585L)")]
    public const int STATUS_GRAPHICS_DDCCI_INVALID_DATA = unchecked((int)(0xC01E0585));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE ((NTSTATUS)0xC01E0586L)")]
    public const int STATUS_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE = unchecked((int)(0xC01E0586));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DDCCI_INVALID_CAPABILITIES_STRING"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DDCCI_INVALID_CAPABILITIES_STRING ((NTSTATUS)0xC01E0587L)")]
    public const int STATUS_GRAPHICS_DDCCI_INVALID_CAPABILITIES_STRING = unchecked((int)(0xC01E0587));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MCA_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MCA_INTERNAL_ERROR ((NTSTATUS)0xC01E0588L)")]
    public const int STATUS_GRAPHICS_MCA_INTERNAL_ERROR = unchecked((int)(0xC01E0588));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND ((NTSTATUS)0xC01E0589L)")]
    public const int STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND = unchecked((int)(0xC01E0589));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH ((NTSTATUS)0xC01E058AL)")]
    public const int STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH = unchecked((int)(0xC01E058A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM ((NTSTATUS)0xC01E058BL)")]
    public const int STATUS_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM = unchecked((int)(0xC01E058B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE ((NTSTATUS)0xC01E058CL)")]
    public const int STATUS_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE = unchecked((int)(0xC01E058C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MONITOR_NO_LONGER_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MONITOR_NO_LONGER_EXISTS ((NTSTATUS)0xC01E058DL)")]
    public const int STATUS_GRAPHICS_MONITOR_NO_LONGER_EXISTS = unchecked((int)(0xC01E058D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED ((NTSTATUS)0xC01E05E0L)")]
    public const int STATUS_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED = unchecked((int)(0xC01E05E0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME ((NTSTATUS)0xC01E05E1L)")]
    public const int STATUS_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME = unchecked((int)(0xC01E05E1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP ((NTSTATUS)0xC01E05E2L)")]
    public const int STATUS_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP = unchecked((int)(0xC01E05E2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED ((NTSTATUS)0xC01E05E3L)")]
    public const int STATUS_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED = unchecked((int)(0xC01E05E3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INVALID_POINTER"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INVALID_POINTER ((NTSTATUS)0xC01E05E4L)")]
    public const int STATUS_GRAPHICS_INVALID_POINTER = unchecked((int)(0xC01E05E4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE ((NTSTATUS)0xC01E05E5L)")]
    public const int STATUS_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE = unchecked((int)(0xC01E05E5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL ((NTSTATUS)0xC01E05E6L)")]
    public const int STATUS_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL = unchecked((int)(0xC01E05E6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_INTERNAL_ERROR ((NTSTATUS)0xC01E05E7L)")]
    public const int STATUS_GRAPHICS_INTERNAL_ERROR = unchecked((int)(0xC01E05E7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS ((NTSTATUS)0xC01E05E8L)")]
    public const int STATUS_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS = unchecked((int)(0xC01E05E8));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_UNKNOWN_BIOS_FRAME_BUFFER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_UNKNOWN_BIOS_FRAME_BUFFER_NOT_FOUND ((NTSTATUS)0xC01E0600L)")]
    public const int STATUS_GRAPHICS_UNKNOWN_BIOS_FRAME_BUFFER_NOT_FOUND = unchecked((int)(0xC01E0600));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GRAPHICS_UEFI_FRAME_BUFFER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_GRAPHICS_UEFI_FRAME_BUFFER_NOT_FOUND ((NTSTATUS)0xC01E0601L)")]
    public const int STATUS_GRAPHICS_UEFI_FRAME_BUFFER_NOT_FOUND = unchecked((int)(0xC01E0601));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CAMERA_INVALID_CONFIGURATION"]/*' />
    [NativeTypeName("#define STATUS_CAMERA_INVALID_CONFIGURATION ((NTSTATUS)0xC01F0000L)")]
    public const int STATUS_CAMERA_INVALID_CONFIGURATION = unchecked((int)(0xC01F0000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CAMERA_INSUFFICIENT_BANDWIDTH"]/*' />
    [NativeTypeName("#define STATUS_CAMERA_INSUFFICIENT_BANDWIDTH ((NTSTATUS)0xC01F0001L)")]
    public const int STATUS_CAMERA_INSUFFICIENT_BANDWIDTH = unchecked((int)(0xC01F0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_LOCKED_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_FVE_LOCKED_VOLUME ((NTSTATUS)0xC0210000L)")]
    public const int STATUS_FVE_LOCKED_VOLUME = unchecked((int)(0xC0210000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NOT_ENCRYPTED"]/*' />
    [NativeTypeName("#define STATUS_FVE_NOT_ENCRYPTED ((NTSTATUS)0xC0210001L)")]
    public const int STATUS_FVE_NOT_ENCRYPTED = unchecked((int)(0xC0210001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_BAD_INFORMATION"]/*' />
    [NativeTypeName("#define STATUS_FVE_BAD_INFORMATION ((NTSTATUS)0xC0210002L)")]
    public const int STATUS_FVE_BAD_INFORMATION = unchecked((int)(0xC0210002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_FVE_TOO_SMALL ((NTSTATUS)0xC0210003L)")]
    public const int STATUS_FVE_TOO_SMALL = unchecked((int)(0xC0210003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FAILED_WRONG_FS"]/*' />
    [NativeTypeName("#define STATUS_FVE_FAILED_WRONG_FS ((NTSTATUS)0xC0210004L)")]
    public const int STATUS_FVE_FAILED_WRONG_FS = unchecked((int)(0xC0210004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_BAD_PARTITION_SIZE"]/*' />
    [NativeTypeName("#define STATUS_FVE_BAD_PARTITION_SIZE ((NTSTATUS)0xC0210005L)")]
    public const int STATUS_FVE_BAD_PARTITION_SIZE = unchecked((int)(0xC0210005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FS_NOT_EXTENDED"]/*' />
    [NativeTypeName("#define STATUS_FVE_FS_NOT_EXTENDED ((NTSTATUS)0xC0210006L)")]
    public const int STATUS_FVE_FS_NOT_EXTENDED = unchecked((int)(0xC0210006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FS_MOUNTED"]/*' />
    [NativeTypeName("#define STATUS_FVE_FS_MOUNTED ((NTSTATUS)0xC0210007L)")]
    public const int STATUS_FVE_FS_MOUNTED = unchecked((int)(0xC0210007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NO_LICENSE"]/*' />
    [NativeTypeName("#define STATUS_FVE_NO_LICENSE ((NTSTATUS)0xC0210008L)")]
    public const int STATUS_FVE_NO_LICENSE = unchecked((int)(0xC0210008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_ACTION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_FVE_ACTION_NOT_ALLOWED ((NTSTATUS)0xC0210009L)")]
    public const int STATUS_FVE_ACTION_NOT_ALLOWED = unchecked((int)(0xC0210009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_BAD_DATA"]/*' />
    [NativeTypeName("#define STATUS_FVE_BAD_DATA ((NTSTATUS)0xC021000AL)")]
    public const int STATUS_FVE_BAD_DATA = unchecked((int)(0xC021000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_VOLUME_NOT_BOUND"]/*' />
    [NativeTypeName("#define STATUS_FVE_VOLUME_NOT_BOUND ((NTSTATUS)0xC021000BL)")]
    public const int STATUS_FVE_VOLUME_NOT_BOUND = unchecked((int)(0xC021000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NOT_DATA_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_FVE_NOT_DATA_VOLUME ((NTSTATUS)0xC021000CL)")]
    public const int STATUS_FVE_NOT_DATA_VOLUME = unchecked((int)(0xC021000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_CONV_READ_ERROR"]/*' />
    [NativeTypeName("#define STATUS_FVE_CONV_READ_ERROR ((NTSTATUS)0xC021000DL)")]
    public const int STATUS_FVE_CONV_READ_ERROR = unchecked((int)(0xC021000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_CONV_WRITE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_FVE_CONV_WRITE_ERROR ((NTSTATUS)0xC021000EL)")]
    public const int STATUS_FVE_CONV_WRITE_ERROR = unchecked((int)(0xC021000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_OVERLAPPED_UPDATE"]/*' />
    [NativeTypeName("#define STATUS_FVE_OVERLAPPED_UPDATE ((NTSTATUS)0xC021000FL)")]
    public const int STATUS_FVE_OVERLAPPED_UPDATE = unchecked((int)(0xC021000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FAILED_SECTOR_SIZE"]/*' />
    [NativeTypeName("#define STATUS_FVE_FAILED_SECTOR_SIZE ((NTSTATUS)0xC0210010L)")]
    public const int STATUS_FVE_FAILED_SECTOR_SIZE = unchecked((int)(0xC0210010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FAILED_AUTHENTICATION"]/*' />
    [NativeTypeName("#define STATUS_FVE_FAILED_AUTHENTICATION ((NTSTATUS)0xC0210011L)")]
    public const int STATUS_FVE_FAILED_AUTHENTICATION = unchecked((int)(0xC0210011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NOT_OS_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_FVE_NOT_OS_VOLUME ((NTSTATUS)0xC0210012L)")]
    public const int STATUS_FVE_NOT_OS_VOLUME = unchecked((int)(0xC0210012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_KEYFILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FVE_KEYFILE_NOT_FOUND ((NTSTATUS)0xC0210013L)")]
    public const int STATUS_FVE_KEYFILE_NOT_FOUND = unchecked((int)(0xC0210013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_KEYFILE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_FVE_KEYFILE_INVALID ((NTSTATUS)0xC0210014L)")]
    public const int STATUS_FVE_KEYFILE_INVALID = unchecked((int)(0xC0210014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_KEYFILE_NO_VMK"]/*' />
    [NativeTypeName("#define STATUS_FVE_KEYFILE_NO_VMK ((NTSTATUS)0xC0210015L)")]
    public const int STATUS_FVE_KEYFILE_NO_VMK = unchecked((int)(0xC0210015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TPM_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_FVE_TPM_DISABLED ((NTSTATUS)0xC0210016L)")]
    public const int STATUS_FVE_TPM_DISABLED = unchecked((int)(0xC0210016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TPM_SRK_AUTH_NOT_ZERO"]/*' />
    [NativeTypeName("#define STATUS_FVE_TPM_SRK_AUTH_NOT_ZERO ((NTSTATUS)0xC0210017L)")]
    public const int STATUS_FVE_TPM_SRK_AUTH_NOT_ZERO = unchecked((int)(0xC0210017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TPM_INVALID_PCR"]/*' />
    [NativeTypeName("#define STATUS_FVE_TPM_INVALID_PCR ((NTSTATUS)0xC0210018L)")]
    public const int STATUS_FVE_TPM_INVALID_PCR = unchecked((int)(0xC0210018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TPM_NO_VMK"]/*' />
    [NativeTypeName("#define STATUS_FVE_TPM_NO_VMK ((NTSTATUS)0xC0210019L)")]
    public const int STATUS_FVE_TPM_NO_VMK = unchecked((int)(0xC0210019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_PIN_INVALID"]/*' />
    [NativeTypeName("#define STATUS_FVE_PIN_INVALID ((NTSTATUS)0xC021001AL)")]
    public const int STATUS_FVE_PIN_INVALID = unchecked((int)(0xC021001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_AUTH_INVALID_APPLICATION"]/*' />
    [NativeTypeName("#define STATUS_FVE_AUTH_INVALID_APPLICATION ((NTSTATUS)0xC021001BL)")]
    public const int STATUS_FVE_AUTH_INVALID_APPLICATION = unchecked((int)(0xC021001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_AUTH_INVALID_CONFIG"]/*' />
    [NativeTypeName("#define STATUS_FVE_AUTH_INVALID_CONFIG ((NTSTATUS)0xC021001CL)")]
    public const int STATUS_FVE_AUTH_INVALID_CONFIG = unchecked((int)(0xC021001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_DEBUGGER_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_FVE_DEBUGGER_ENABLED ((NTSTATUS)0xC021001DL)")]
    public const int STATUS_FVE_DEBUGGER_ENABLED = unchecked((int)(0xC021001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_DRY_RUN_FAILED"]/*' />
    [NativeTypeName("#define STATUS_FVE_DRY_RUN_FAILED ((NTSTATUS)0xC021001EL)")]
    public const int STATUS_FVE_DRY_RUN_FAILED = unchecked((int)(0xC021001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_BAD_METADATA_POINTER"]/*' />
    [NativeTypeName("#define STATUS_FVE_BAD_METADATA_POINTER ((NTSTATUS)0xC021001FL)")]
    public const int STATUS_FVE_BAD_METADATA_POINTER = unchecked((int)(0xC021001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_OLD_METADATA_COPY"]/*' />
    [NativeTypeName("#define STATUS_FVE_OLD_METADATA_COPY ((NTSTATUS)0xC0210020L)")]
    public const int STATUS_FVE_OLD_METADATA_COPY = unchecked((int)(0xC0210020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_FVE_REBOOT_REQUIRED ((NTSTATUS)0xC0210021L)")]
    public const int STATUS_FVE_REBOOT_REQUIRED = unchecked((int)(0xC0210021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_RAW_ACCESS"]/*' />
    [NativeTypeName("#define STATUS_FVE_RAW_ACCESS ((NTSTATUS)0xC0210022L)")]
    public const int STATUS_FVE_RAW_ACCESS = unchecked((int)(0xC0210022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_RAW_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_FVE_RAW_BLOCKED ((NTSTATUS)0xC0210023L)")]
    public const int STATUS_FVE_RAW_BLOCKED = unchecked((int)(0xC0210023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NO_AUTOUNLOCK_MASTER_KEY"]/*' />
    [NativeTypeName("#define STATUS_FVE_NO_AUTOUNLOCK_MASTER_KEY ((NTSTATUS)0xC0210024L)")]
    public const int STATUS_FVE_NO_AUTOUNLOCK_MASTER_KEY = unchecked((int)(0xC0210024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_MOR_FAILED"]/*' />
    [NativeTypeName("#define STATUS_FVE_MOR_FAILED ((NTSTATUS)0xC0210025L)")]
    public const int STATUS_FVE_MOR_FAILED = unchecked((int)(0xC0210025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NO_FEATURE_LICENSE"]/*' />
    [NativeTypeName("#define STATUS_FVE_NO_FEATURE_LICENSE ((NTSTATUS)0xC0210026L)")]
    public const int STATUS_FVE_NO_FEATURE_LICENSE = unchecked((int)(0xC0210026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_POLICY_USER_DISABLE_RDV_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_FVE_POLICY_USER_DISABLE_RDV_NOT_ALLOWED ((NTSTATUS)0xC0210027L)")]
    public const int STATUS_FVE_POLICY_USER_DISABLE_RDV_NOT_ALLOWED = unchecked((int)(0xC0210027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_CONV_RECOVERY_FAILED"]/*' />
    [NativeTypeName("#define STATUS_FVE_CONV_RECOVERY_FAILED ((NTSTATUS)0xC0210028L)")]
    public const int STATUS_FVE_CONV_RECOVERY_FAILED = unchecked((int)(0xC0210028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_VIRTUALIZED_SPACE_TOO_BIG"]/*' />
    [NativeTypeName("#define STATUS_FVE_VIRTUALIZED_SPACE_TOO_BIG ((NTSTATUS)0xC0210029L)")]
    public const int STATUS_FVE_VIRTUALIZED_SPACE_TOO_BIG = unchecked((int)(0xC0210029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_INVALID_DATUM_TYPE"]/*' />
    [NativeTypeName("#define STATUS_FVE_INVALID_DATUM_TYPE ((NTSTATUS)0xC021002AL)")]
    public const int STATUS_FVE_INVALID_DATUM_TYPE = unchecked((int)(0xC021002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_VOLUME_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_FVE_VOLUME_TOO_SMALL ((NTSTATUS)0xC0210030L)")]
    public const int STATUS_FVE_VOLUME_TOO_SMALL = unchecked((int)(0xC0210030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_ENH_PIN_INVALID"]/*' />
    [NativeTypeName("#define STATUS_FVE_ENH_PIN_INVALID ((NTSTATUS)0xC0210031L)")]
    public const int STATUS_FVE_ENH_PIN_INVALID = unchecked((int)(0xC0210031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE"]/*' />
    [NativeTypeName("#define STATUS_FVE_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE ((NTSTATUS)0xC0210032L)")]
    public const int STATUS_FVE_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)(0xC0210032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_WIPE_NOT_ALLOWED_ON_TP_STORAGE"]/*' />
    [NativeTypeName("#define STATUS_FVE_WIPE_NOT_ALLOWED_ON_TP_STORAGE ((NTSTATUS)0xC0210033L)")]
    public const int STATUS_FVE_WIPE_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)(0xC0210033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NOT_ALLOWED_ON_CSV_STACK"]/*' />
    [NativeTypeName("#define STATUS_FVE_NOT_ALLOWED_ON_CSV_STACK ((NTSTATUS)0xC0210034L)")]
    public const int STATUS_FVE_NOT_ALLOWED_ON_CSV_STACK = unchecked((int)(0xC0210034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NOT_ALLOWED_ON_CLUSTER"]/*' />
    [NativeTypeName("#define STATUS_FVE_NOT_ALLOWED_ON_CLUSTER ((NTSTATUS)0xC0210035L)")]
    public const int STATUS_FVE_NOT_ALLOWED_ON_CLUSTER = unchecked((int)(0xC0210035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING"]/*' />
    [NativeTypeName("#define STATUS_FVE_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING ((NTSTATUS)0xC0210036L)")]
    public const int STATUS_FVE_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING = unchecked((int)(0xC0210036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_WIPE_CANCEL_NOT_APPLICABLE"]/*' />
    [NativeTypeName("#define STATUS_FVE_WIPE_CANCEL_NOT_APPLICABLE ((NTSTATUS)0xC0210037L)")]
    public const int STATUS_FVE_WIPE_CANCEL_NOT_APPLICABLE = unchecked((int)(0xC0210037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_EDRIVE_DRY_RUN_FAILED"]/*' />
    [NativeTypeName("#define STATUS_FVE_EDRIVE_DRY_RUN_FAILED ((NTSTATUS)0xC0210038L)")]
    public const int STATUS_FVE_EDRIVE_DRY_RUN_FAILED = unchecked((int)(0xC0210038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_SECUREBOOT_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_FVE_SECUREBOOT_DISABLED ((NTSTATUS)0xC0210039L)")]
    public const int STATUS_FVE_SECUREBOOT_DISABLED = unchecked((int)(0xC0210039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_SECUREBOOT_CONFIG_CHANGE"]/*' />
    [NativeTypeName("#define STATUS_FVE_SECUREBOOT_CONFIG_CHANGE ((NTSTATUS)0xC021003AL)")]
    public const int STATUS_FVE_SECUREBOOT_CONFIG_CHANGE = unchecked((int)(0xC021003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_DEVICE_LOCKEDOUT"]/*' />
    [NativeTypeName("#define STATUS_FVE_DEVICE_LOCKEDOUT ((NTSTATUS)0xC021003BL)")]
    public const int STATUS_FVE_DEVICE_LOCKEDOUT = unchecked((int)(0xC021003B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT"]/*' />
    [NativeTypeName("#define STATUS_FVE_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT ((NTSTATUS)0xC021003CL)")]
    public const int STATUS_FVE_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT = unchecked((int)(0xC021003C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NOT_DE_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_FVE_NOT_DE_VOLUME ((NTSTATUS)0xC021003DL)")]
    public const int STATUS_FVE_NOT_DE_VOLUME = unchecked((int)(0xC021003D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_PROTECTION_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_FVE_PROTECTION_DISABLED ((NTSTATUS)0xC021003EL)")]
    public const int STATUS_FVE_PROTECTION_DISABLED = unchecked((int)(0xC021003E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_PROTECTION_CANNOT_BE_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_FVE_PROTECTION_CANNOT_BE_DISABLED ((NTSTATUS)0xC021003FL)")]
    public const int STATUS_FVE_PROTECTION_CANNOT_BE_DISABLED = unchecked((int)(0xC021003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_OSV_KSR_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_FVE_OSV_KSR_NOT_ALLOWED ((NTSTATUS)0xC0210040L)")]
    public const int STATUS_FVE_OSV_KSR_NOT_ALLOWED = unchecked((int)(0xC0210040));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_EDRIVE_BAND_ENUMERATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_FVE_EDRIVE_BAND_ENUMERATION_FAILED ((NTSTATUS)0xC0210041L)")]
    public const int STATUS_FVE_EDRIVE_BAND_ENUMERATION_FAILED = unchecked((int)(0xC0210041));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_POLICY_ON_RDV_EXCLUSION_LIST"]/*' />
    [NativeTypeName("#define STATUS_FVE_POLICY_ON_RDV_EXCLUSION_LIST ((NTSTATUS)0xC0210042L)")]
    public const int STATUS_FVE_POLICY_ON_RDV_EXCLUSION_LIST = unchecked((int)(0xC0210042));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_DATASET_FULL"]/*' />
    [NativeTypeName("#define STATUS_FVE_DATASET_FULL ((NTSTATUS)0xC0210043L)")]
    public const int STATUS_FVE_DATASET_FULL = unchecked((int)(0xC0210043));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_METADATA_FULL"]/*' />
    [NativeTypeName("#define STATUS_FVE_METADATA_FULL ((NTSTATUS)0xC0210044L)")]
    public const int STATUS_FVE_METADATA_FULL = unchecked((int)(0xC0210044));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_SUSPEND_PROTECTION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_FVE_SUSPEND_PROTECTION_NOT_ALLOWED ((NTSTATUS)0xC0210045L)")]
    public const int STATUS_FVE_SUSPEND_PROTECTION_NOT_ALLOWED = unchecked((int)(0xC0210045));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_DATUM_PARTIALLY_INVALID"]/*' />
    [NativeTypeName("#define STATUS_FVE_DATUM_PARTIALLY_INVALID ((NTSTATUS)0xC0210046L)")]
    public const int STATUS_FVE_DATUM_PARTIALLY_INVALID = unchecked((int)(0xC0210046));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_DATASET_TPM_DATUMS_INCONSISTENT"]/*' />
    [NativeTypeName("#define STATUS_FVE_DATASET_TPM_DATUMS_INCONSISTENT ((NTSTATUS)0xC0210047L)")]
    public const int STATUS_FVE_DATASET_TPM_DATUMS_INCONSISTENT = unchecked((int)(0xC0210047));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_SECURE_BOOT_BINDINGS_OUT_OF_SYNC"]/*' />
    [NativeTypeName("#define STATUS_FVE_SECURE_BOOT_BINDINGS_OUT_OF_SYNC ((NTSTATUS)0xC0210048L)")]
    public const int STATUS_FVE_SECURE_BOOT_BINDINGS_OUT_OF_SYNC = unchecked((int)(0xC0210048));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_SECURE_BOOT_BINDING_DATA_OUT_OF_SYNC"]/*' />
    [NativeTypeName("#define STATUS_FVE_SECURE_BOOT_BINDING_DATA_OUT_OF_SYNC ((NTSTATUS)0xC0210049L)")]
    public const int STATUS_FVE_SECURE_BOOT_BINDING_DATA_OUT_OF_SYNC = unchecked((int)(0xC0210049));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_ORPHANED_TPM_BINDING_DATUM"]/*' />
    [NativeTypeName("#define STATUS_FVE_ORPHANED_TPM_BINDING_DATUM ((NTSTATUS)0xC021004AL)")]
    public const int STATUS_FVE_ORPHANED_TPM_BINDING_DATUM = unchecked((int)(0xC021004A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_BAD_TPM_DATUM_ASSOCIATION"]/*' />
    [NativeTypeName("#define STATUS_FVE_BAD_TPM_DATUM_ASSOCIATION ((NTSTATUS)0xC021004BL)")]
    public const int STATUS_FVE_BAD_TPM_DATUM_ASSOCIATION = unchecked((int)(0xC021004B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FINAL_TPM_PCR_VALUES_MATCH"]/*' />
    [NativeTypeName("#define STATUS_FVE_FINAL_TPM_PCR_VALUES_MATCH ((NTSTATUS)0xC021004CL)")]
    public const int STATUS_FVE_FINAL_TPM_PCR_VALUES_MATCH = unchecked((int)(0xC021004C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_MATCHING_PCRS_TPM_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_FVE_MATCHING_PCRS_TPM_FAILURE ((NTSTATUS)0xC021004DL)")]
    public const int STATUS_FVE_MATCHING_PCRS_TPM_FAILURE = unchecked((int)(0xC021004D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_GENERAL_TPM_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_FVE_GENERAL_TPM_FAILURE ((NTSTATUS)0xC021004EL)")]
    public const int STATUS_FVE_GENERAL_TPM_FAILURE = unchecked((int)(0xC021004E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TPM_NONEXISTENT"]/*' />
    [NativeTypeName("#define STATUS_FVE_TPM_NONEXISTENT ((NTSTATUS)0xC021004FL)")]
    public const int STATUS_FVE_TPM_NONEXISTENT = unchecked((int)(0xC021004F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NO_PCR_BOOT_LOCK_BOUNDARY"]/*' />
    [NativeTypeName("#define STATUS_FVE_NO_PCR_BOOT_LOCK_BOUNDARY ((NTSTATUS)0xC0210050L)")]
    public const int STATUS_FVE_NO_PCR_BOOT_LOCK_BOUNDARY = unchecked((int)(0xC0210050));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_PCR_BOOT_LOCK_BOUNDARY"]/*' />
    [NativeTypeName("#define STATUS_FVE_PCR_BOOT_LOCK_BOUNDARY ((NTSTATUS)0xC0210051L)")]
    public const int STATUS_FVE_PCR_BOOT_LOCK_BOUNDARY = unchecked((int)(0xC0210051));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FW_UPDATE_TPM_BINDINGS_NOT_REFRESHED"]/*' />
    [NativeTypeName("#define STATUS_FVE_FW_UPDATE_TPM_BINDINGS_NOT_REFRESHED ((NTSTATUS)0xC0210052L)")]
    public const int STATUS_FVE_FW_UPDATE_TPM_BINDINGS_NOT_REFRESHED = unchecked((int)(0xC0210052));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_INVALID_TPM_BINDING_CONFIGURATION"]/*' />
    [NativeTypeName("#define STATUS_FVE_INVALID_TPM_BINDING_CONFIGURATION ((NTSTATUS)0xC0210053L)")]
    public const int STATUS_FVE_INVALID_TPM_BINDING_CONFIGURATION = unchecked((int)(0xC0210053));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TOO_MANY_TPM_BINDINGS"]/*' />
    [NativeTypeName("#define STATUS_FVE_TOO_MANY_TPM_BINDINGS ((NTSTATUS)0xC0210054L)")]
    public const int STATUS_FVE_TOO_MANY_TPM_BINDINGS = unchecked((int)(0xC0210054));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TPM_BINDING_ASSOCIATION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_FVE_TPM_BINDING_ASSOCIATION_FAILURE ((NTSTATUS)0xC0210055L)")]
    public const int STATUS_FVE_TPM_BINDING_ASSOCIATION_FAILURE = unchecked((int)(0xC0210055));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_ORPHANED_PCR_DIGEST_DATUM"]/*' />
    [NativeTypeName("#define STATUS_FVE_ORPHANED_PCR_DIGEST_DATUM ((NTSTATUS)0xC0210056L)")]
    public const int STATUS_FVE_ORPHANED_PCR_DIGEST_DATUM = unchecked((int)(0xC0210056));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_HW_ACCELERATED_ENCRYPTION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_FVE_HW_ACCELERATED_ENCRYPTION_NOT_ALLOWED ((NTSTATUS)0xC0210057L)")]
    public const int STATUS_FVE_HW_ACCELERATED_ENCRYPTION_NOT_ALLOWED = unchecked((int)(0xC0210057));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NO_MATCHING_TPM_BINDINGS"]/*' />
    [NativeTypeName("#define STATUS_FVE_NO_MATCHING_TPM_BINDINGS ((NTSTATUS)0xC0210058L)")]
    public const int STATUS_FVE_NO_MATCHING_TPM_BINDINGS = unchecked((int)(0xC0210058));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TPMPV2_USED_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_FVE_TPMPV2_USED_FAILURE ((NTSTATUS)0xC0210059L)")]
    public const int STATUS_FVE_TPMPV2_USED_FAILURE = unchecked((int)(0xC0210059));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NO_TPM_BINDINGS"]/*' />
    [NativeTypeName("#define STATUS_FVE_NO_TPM_BINDINGS ((NTSTATUS)0xC021005AL)")]
    public const int STATUS_FVE_NO_TPM_BINDINGS = unchecked((int)(0xC021005A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_BOOT_CRIT_DEVICE_UNEXPECTED_BEHAVIOR"]/*' />
    [NativeTypeName("#define STATUS_FVE_BOOT_CRIT_DEVICE_UNEXPECTED_BEHAVIOR ((NTSTATUS)0xC021005BL)")]
    public const int STATUS_FVE_BOOT_CRIT_DEVICE_UNEXPECTED_BEHAVIOR = unchecked((int)(0xC021005B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FW_UPDATE_PCRS_BLOCK"]/*' />
    [NativeTypeName("#define STATUS_FVE_FW_UPDATE_PCRS_BLOCK ((NTSTATUS)0xC021005CL)")]
    public const int STATUS_FVE_FW_UPDATE_PCRS_BLOCK = unchecked((int)(0xC021005C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FW_UPDATE_PCRS_NOT_EXCLUDED"]/*' />
    [NativeTypeName("#define STATUS_FVE_FW_UPDATE_PCRS_NOT_EXCLUDED ((NTSTATUS)0xC021005DL)")]
    public const int STATUS_FVE_FW_UPDATE_PCRS_NOT_EXCLUDED = unchecked((int)(0xC021005D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_FAILED_TO_UNWRAP_HW_WRAPPED_KEY"]/*' />
    [NativeTypeName("#define STATUS_FVE_FAILED_TO_UNWRAP_HW_WRAPPED_KEY ((NTSTATUS)0xC021005EL)")]
    public const int STATUS_FVE_FAILED_TO_UNWRAP_HW_WRAPPED_KEY = unchecked((int)(0xC021005E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_HARDWARE_CRYPTO_ACCELERATOR_NOT_FIPS_COMPLIANT"]/*' />
    [NativeTypeName("#define STATUS_FVE_HARDWARE_CRYPTO_ACCELERATOR_NOT_FIPS_COMPLIANT ((NTSTATUS)0xC021005FL)")]
    public const int STATUS_FVE_HARDWARE_CRYPTO_ACCELERATOR_NOT_FIPS_COMPLIANT = unchecked((int)(0xC021005F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_HARDWARE_CRYPTO_KEY_MANAGER_NOT_FIPS_COMPLIANT"]/*' />
    [NativeTypeName("#define STATUS_FVE_HARDWARE_CRYPTO_KEY_MANAGER_NOT_FIPS_COMPLIANT ((NTSTATUS)0xC0210060L)")]
    public const int STATUS_FVE_HARDWARE_CRYPTO_KEY_MANAGER_NOT_FIPS_COMPLIANT = unchecked((int)(0xC0210060));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_NOT_ALLOWED_ON_EPHEMERAL_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_FVE_NOT_ALLOWED_ON_EPHEMERAL_VOLUME ((NTSTATUS)0xC0210061L)")]
    public const int STATUS_FVE_NOT_ALLOWED_ON_EPHEMERAL_VOLUME = unchecked((int)(0xC0210061));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_UNTRUSTED_OFFLOAD_STORAGE"]/*' />
    [NativeTypeName("#define STATUS_FVE_UNTRUSTED_OFFLOAD_STORAGE ((NTSTATUS)0xC0210062L)")]
    public const int STATUS_FVE_UNTRUSTED_OFFLOAD_STORAGE = unchecked((int)(0xC0210062));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_TPM_PCRS_DO_NOT_MATCH_LOG"]/*' />
    [NativeTypeName("#define STATUS_FVE_TPM_PCRS_DO_NOT_MATCH_LOG ((NTSTATUS)0xC0210063L)")]
    public const int STATUS_FVE_TPM_PCRS_DO_NOT_MATCH_LOG = unchecked((int)(0xC0210063));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_MISSING_PROTECTORS"]/*' />
    [NativeTypeName("#define STATUS_FVE_MISSING_PROTECTORS ((NTSTATUS)0xC0210064L)")]
    public const int STATUS_FVE_MISSING_PROTECTORS = unchecked((int)(0xC0210064));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FVE_VOLUME_HANDLE_OPEN"]/*' />
    [NativeTypeName("#define STATUS_FVE_VOLUME_HANDLE_OPEN ((NTSTATUS)0xC0210065L)")]
    public const int STATUS_FVE_VOLUME_HANDLE_OPEN = unchecked((int)(0xC0210065));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_CALLOUT_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FWP_CALLOUT_NOT_FOUND ((NTSTATUS)0xC0220001L)")]
    public const int STATUS_FWP_CALLOUT_NOT_FOUND = unchecked((int)(0xC0220001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_CONDITION_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FWP_CONDITION_NOT_FOUND ((NTSTATUS)0xC0220002L)")]
    public const int STATUS_FWP_CONDITION_NOT_FOUND = unchecked((int)(0xC0220002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_FILTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FWP_FILTER_NOT_FOUND ((NTSTATUS)0xC0220003L)")]
    public const int STATUS_FWP_FILTER_NOT_FOUND = unchecked((int)(0xC0220003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_LAYER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FWP_LAYER_NOT_FOUND ((NTSTATUS)0xC0220004L)")]
    public const int STATUS_FWP_LAYER_NOT_FOUND = unchecked((int)(0xC0220004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_PROVIDER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FWP_PROVIDER_NOT_FOUND ((NTSTATUS)0xC0220005L)")]
    public const int STATUS_FWP_PROVIDER_NOT_FOUND = unchecked((int)(0xC0220005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_PROVIDER_CONTEXT_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FWP_PROVIDER_CONTEXT_NOT_FOUND ((NTSTATUS)0xC0220006L)")]
    public const int STATUS_FWP_PROVIDER_CONTEXT_NOT_FOUND = unchecked((int)(0xC0220006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_SUBLAYER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FWP_SUBLAYER_NOT_FOUND ((NTSTATUS)0xC0220007L)")]
    public const int STATUS_FWP_SUBLAYER_NOT_FOUND = unchecked((int)(0xC0220007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_FWP_NOT_FOUND ((NTSTATUS)0xC0220008L)")]
    public const int STATUS_FWP_NOT_FOUND = unchecked((int)(0xC0220008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_FWP_ALREADY_EXISTS ((NTSTATUS)0xC0220009L)")]
    public const int STATUS_FWP_ALREADY_EXISTS = unchecked((int)(0xC0220009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_FWP_IN_USE ((NTSTATUS)0xC022000AL)")]
    public const int STATUS_FWP_IN_USE = unchecked((int)(0xC022000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_DYNAMIC_SESSION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_FWP_DYNAMIC_SESSION_IN_PROGRESS ((NTSTATUS)0xC022000BL)")]
    public const int STATUS_FWP_DYNAMIC_SESSION_IN_PROGRESS = unchecked((int)(0xC022000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_WRONG_SESSION"]/*' />
    [NativeTypeName("#define STATUS_FWP_WRONG_SESSION ((NTSTATUS)0xC022000CL)")]
    public const int STATUS_FWP_WRONG_SESSION = unchecked((int)(0xC022000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_NO_TXN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_FWP_NO_TXN_IN_PROGRESS ((NTSTATUS)0xC022000DL)")]
    public const int STATUS_FWP_NO_TXN_IN_PROGRESS = unchecked((int)(0xC022000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_TXN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_FWP_TXN_IN_PROGRESS ((NTSTATUS)0xC022000EL)")]
    public const int STATUS_FWP_TXN_IN_PROGRESS = unchecked((int)(0xC022000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_TXN_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_FWP_TXN_ABORTED ((NTSTATUS)0xC022000FL)")]
    public const int STATUS_FWP_TXN_ABORTED = unchecked((int)(0xC022000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_SESSION_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_FWP_SESSION_ABORTED ((NTSTATUS)0xC0220010L)")]
    public const int STATUS_FWP_SESSION_ABORTED = unchecked((int)(0xC0220010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INCOMPATIBLE_TXN"]/*' />
    [NativeTypeName("#define STATUS_FWP_INCOMPATIBLE_TXN ((NTSTATUS)0xC0220011L)")]
    public const int STATUS_FWP_INCOMPATIBLE_TXN = unchecked((int)(0xC0220011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_FWP_TIMEOUT ((NTSTATUS)0xC0220012L)")]
    public const int STATUS_FWP_TIMEOUT = unchecked((int)(0xC0220012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_NET_EVENTS_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_FWP_NET_EVENTS_DISABLED ((NTSTATUS)0xC0220013L)")]
    public const int STATUS_FWP_NET_EVENTS_DISABLED = unchecked((int)(0xC0220013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INCOMPATIBLE_LAYER"]/*' />
    [NativeTypeName("#define STATUS_FWP_INCOMPATIBLE_LAYER ((NTSTATUS)0xC0220014L)")]
    public const int STATUS_FWP_INCOMPATIBLE_LAYER = unchecked((int)(0xC0220014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_KM_CLIENTS_ONLY"]/*' />
    [NativeTypeName("#define STATUS_FWP_KM_CLIENTS_ONLY ((NTSTATUS)0xC0220015L)")]
    public const int STATUS_FWP_KM_CLIENTS_ONLY = unchecked((int)(0xC0220015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_LIFETIME_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_FWP_LIFETIME_MISMATCH ((NTSTATUS)0xC0220016L)")]
    public const int STATUS_FWP_LIFETIME_MISMATCH = unchecked((int)(0xC0220016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_BUILTIN_OBJECT"]/*' />
    [NativeTypeName("#define STATUS_FWP_BUILTIN_OBJECT ((NTSTATUS)0xC0220017L)")]
    public const int STATUS_FWP_BUILTIN_OBJECT = unchecked((int)(0xC0220017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_TOO_MANY_CALLOUTS"]/*' />
    [NativeTypeName("#define STATUS_FWP_TOO_MANY_CALLOUTS ((NTSTATUS)0xC0220018L)")]
    public const int STATUS_FWP_TOO_MANY_CALLOUTS = unchecked((int)(0xC0220018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_NOTIFICATION_DROPPED"]/*' />
    [NativeTypeName("#define STATUS_FWP_NOTIFICATION_DROPPED ((NTSTATUS)0xC0220019L)")]
    public const int STATUS_FWP_NOTIFICATION_DROPPED = unchecked((int)(0xC0220019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_TRAFFIC_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_FWP_TRAFFIC_MISMATCH ((NTSTATUS)0xC022001AL)")]
    public const int STATUS_FWP_TRAFFIC_MISMATCH = unchecked((int)(0xC022001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INCOMPATIBLE_SA_STATE"]/*' />
    [NativeTypeName("#define STATUS_FWP_INCOMPATIBLE_SA_STATE ((NTSTATUS)0xC022001BL)")]
    public const int STATUS_FWP_INCOMPATIBLE_SA_STATE = unchecked((int)(0xC022001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_NULL_POINTER"]/*' />
    [NativeTypeName("#define STATUS_FWP_NULL_POINTER ((NTSTATUS)0xC022001CL)")]
    public const int STATUS_FWP_NULL_POINTER = unchecked((int)(0xC022001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_ENUMERATOR"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_ENUMERATOR ((NTSTATUS)0xC022001DL)")]
    public const int STATUS_FWP_INVALID_ENUMERATOR = unchecked((int)(0xC022001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_FLAGS"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_FLAGS ((NTSTATUS)0xC022001EL)")]
    public const int STATUS_FWP_INVALID_FLAGS = unchecked((int)(0xC022001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_NET_MASK"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_NET_MASK ((NTSTATUS)0xC022001FL)")]
    public const int STATUS_FWP_INVALID_NET_MASK = unchecked((int)(0xC022001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_RANGE"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_RANGE ((NTSTATUS)0xC0220020L)")]
    public const int STATUS_FWP_INVALID_RANGE = unchecked((int)(0xC0220020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_INTERVAL"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_INTERVAL ((NTSTATUS)0xC0220021L)")]
    public const int STATUS_FWP_INVALID_INTERVAL = unchecked((int)(0xC0220021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_ZERO_LENGTH_ARRAY"]/*' />
    [NativeTypeName("#define STATUS_FWP_ZERO_LENGTH_ARRAY ((NTSTATUS)0xC0220022L)")]
    public const int STATUS_FWP_ZERO_LENGTH_ARRAY = unchecked((int)(0xC0220022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_NULL_DISPLAY_NAME"]/*' />
    [NativeTypeName("#define STATUS_FWP_NULL_DISPLAY_NAME ((NTSTATUS)0xC0220023L)")]
    public const int STATUS_FWP_NULL_DISPLAY_NAME = unchecked((int)(0xC0220023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_ACTION_TYPE"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_ACTION_TYPE ((NTSTATUS)0xC0220024L)")]
    public const int STATUS_FWP_INVALID_ACTION_TYPE = unchecked((int)(0xC0220024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_WEIGHT"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_WEIGHT ((NTSTATUS)0xC0220025L)")]
    public const int STATUS_FWP_INVALID_WEIGHT = unchecked((int)(0xC0220025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_MATCH_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_FWP_MATCH_TYPE_MISMATCH ((NTSTATUS)0xC0220026L)")]
    public const int STATUS_FWP_MATCH_TYPE_MISMATCH = unchecked((int)(0xC0220026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_FWP_TYPE_MISMATCH ((NTSTATUS)0xC0220027L)")]
    public const int STATUS_FWP_TYPE_MISMATCH = unchecked((int)(0xC0220027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_OUT_OF_BOUNDS"]/*' />
    [NativeTypeName("#define STATUS_FWP_OUT_OF_BOUNDS ((NTSTATUS)0xC0220028L)")]
    public const int STATUS_FWP_OUT_OF_BOUNDS = unchecked((int)(0xC0220028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_RESERVED"]/*' />
    [NativeTypeName("#define STATUS_FWP_RESERVED ((NTSTATUS)0xC0220029L)")]
    public const int STATUS_FWP_RESERVED = unchecked((int)(0xC0220029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_DUPLICATE_CONDITION"]/*' />
    [NativeTypeName("#define STATUS_FWP_DUPLICATE_CONDITION ((NTSTATUS)0xC022002AL)")]
    public const int STATUS_FWP_DUPLICATE_CONDITION = unchecked((int)(0xC022002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_DUPLICATE_KEYMOD"]/*' />
    [NativeTypeName("#define STATUS_FWP_DUPLICATE_KEYMOD ((NTSTATUS)0xC022002BL)")]
    public const int STATUS_FWP_DUPLICATE_KEYMOD = unchecked((int)(0xC022002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_ACTION_INCOMPATIBLE_WITH_LAYER"]/*' />
    [NativeTypeName("#define STATUS_FWP_ACTION_INCOMPATIBLE_WITH_LAYER ((NTSTATUS)0xC022002CL)")]
    public const int STATUS_FWP_ACTION_INCOMPATIBLE_WITH_LAYER = unchecked((int)(0xC022002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_ACTION_INCOMPATIBLE_WITH_SUBLAYER"]/*' />
    [NativeTypeName("#define STATUS_FWP_ACTION_INCOMPATIBLE_WITH_SUBLAYER ((NTSTATUS)0xC022002DL)")]
    public const int STATUS_FWP_ACTION_INCOMPATIBLE_WITH_SUBLAYER = unchecked((int)(0xC022002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_LAYER"]/*' />
    [NativeTypeName("#define STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_LAYER ((NTSTATUS)0xC022002EL)")]
    public const int STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_LAYER = unchecked((int)(0xC022002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_CALLOUT"]/*' />
    [NativeTypeName("#define STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_CALLOUT ((NTSTATUS)0xC022002FL)")]
    public const int STATUS_FWP_CONTEXT_INCOMPATIBLE_WITH_CALLOUT = unchecked((int)(0xC022002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INCOMPATIBLE_AUTH_METHOD"]/*' />
    [NativeTypeName("#define STATUS_FWP_INCOMPATIBLE_AUTH_METHOD ((NTSTATUS)0xC0220030L)")]
    public const int STATUS_FWP_INCOMPATIBLE_AUTH_METHOD = unchecked((int)(0xC0220030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INCOMPATIBLE_DH_GROUP"]/*' />
    [NativeTypeName("#define STATUS_FWP_INCOMPATIBLE_DH_GROUP ((NTSTATUS)0xC0220031L)")]
    public const int STATUS_FWP_INCOMPATIBLE_DH_GROUP = unchecked((int)(0xC0220031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_EM_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_FWP_EM_NOT_SUPPORTED ((NTSTATUS)0xC0220032L)")]
    public const int STATUS_FWP_EM_NOT_SUPPORTED = unchecked((int)(0xC0220032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_NEVER_MATCH"]/*' />
    [NativeTypeName("#define STATUS_FWP_NEVER_MATCH ((NTSTATUS)0xC0220033L)")]
    public const int STATUS_FWP_NEVER_MATCH = unchecked((int)(0xC0220033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_PROVIDER_CONTEXT_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_FWP_PROVIDER_CONTEXT_MISMATCH ((NTSTATUS)0xC0220034L)")]
    public const int STATUS_FWP_PROVIDER_CONTEXT_MISMATCH = unchecked((int)(0xC0220034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_PARAMETER ((NTSTATUS)0xC0220035L)")]
    public const int STATUS_FWP_INVALID_PARAMETER = unchecked((int)(0xC0220035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_TOO_MANY_SUBLAYERS"]/*' />
    [NativeTypeName("#define STATUS_FWP_TOO_MANY_SUBLAYERS ((NTSTATUS)0xC0220036L)")]
    public const int STATUS_FWP_TOO_MANY_SUBLAYERS = unchecked((int)(0xC0220036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_CALLOUT_NOTIFICATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_FWP_CALLOUT_NOTIFICATION_FAILED ((NTSTATUS)0xC0220037L)")]
    public const int STATUS_FWP_CALLOUT_NOTIFICATION_FAILED = unchecked((int)(0xC0220037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_AUTH_TRANSFORM"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_AUTH_TRANSFORM ((NTSTATUS)0xC0220038L)")]
    public const int STATUS_FWP_INVALID_AUTH_TRANSFORM = unchecked((int)(0xC0220038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_CIPHER_TRANSFORM"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_CIPHER_TRANSFORM ((NTSTATUS)0xC0220039L)")]
    public const int STATUS_FWP_INVALID_CIPHER_TRANSFORM = unchecked((int)(0xC0220039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INCOMPATIBLE_CIPHER_TRANSFORM"]/*' />
    [NativeTypeName("#define STATUS_FWP_INCOMPATIBLE_CIPHER_TRANSFORM ((NTSTATUS)0xC022003AL)")]
    public const int STATUS_FWP_INCOMPATIBLE_CIPHER_TRANSFORM = unchecked((int)(0xC022003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_TRANSFORM_COMBINATION"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_TRANSFORM_COMBINATION ((NTSTATUS)0xC022003BL)")]
    public const int STATUS_FWP_INVALID_TRANSFORM_COMBINATION = unchecked((int)(0xC022003B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_DUPLICATE_AUTH_METHOD"]/*' />
    [NativeTypeName("#define STATUS_FWP_DUPLICATE_AUTH_METHOD ((NTSTATUS)0xC022003CL)")]
    public const int STATUS_FWP_DUPLICATE_AUTH_METHOD = unchecked((int)(0xC022003C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_TUNNEL_ENDPOINT"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_TUNNEL_ENDPOINT ((NTSTATUS)0xC022003DL)")]
    public const int STATUS_FWP_INVALID_TUNNEL_ENDPOINT = unchecked((int)(0xC022003D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_L2_DRIVER_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_FWP_L2_DRIVER_NOT_READY ((NTSTATUS)0xC022003EL)")]
    public const int STATUS_FWP_L2_DRIVER_NOT_READY = unchecked((int)(0xC022003E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_KEY_DICTATOR_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_FWP_KEY_DICTATOR_ALREADY_REGISTERED ((NTSTATUS)0xC022003FL)")]
    public const int STATUS_FWP_KEY_DICTATOR_ALREADY_REGISTERED = unchecked((int)(0xC022003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_KEY_DICTATION_INVALID_KEYING_MATERIAL"]/*' />
    [NativeTypeName("#define STATUS_FWP_KEY_DICTATION_INVALID_KEYING_MATERIAL ((NTSTATUS)0xC0220040L)")]
    public const int STATUS_FWP_KEY_DICTATION_INVALID_KEYING_MATERIAL = unchecked((int)(0xC0220040));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_CONNECTIONS_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_FWP_CONNECTIONS_DISABLED ((NTSTATUS)0xC0220041L)")]
    public const int STATUS_FWP_CONNECTIONS_DISABLED = unchecked((int)(0xC0220041));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INVALID_DNS_NAME"]/*' />
    [NativeTypeName("#define STATUS_FWP_INVALID_DNS_NAME ((NTSTATUS)0xC0220042L)")]
    public const int STATUS_FWP_INVALID_DNS_NAME = unchecked((int)(0xC0220042));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_STILL_ON"]/*' />
    [NativeTypeName("#define STATUS_FWP_STILL_ON ((NTSTATUS)0xC0220043L)")]
    public const int STATUS_FWP_STILL_ON = unchecked((int)(0xC0220043));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_IKEEXT_NOT_RUNNING"]/*' />
    [NativeTypeName("#define STATUS_FWP_IKEEXT_NOT_RUNNING ((NTSTATUS)0xC0220044L)")]
    public const int STATUS_FWP_IKEEXT_NOT_RUNNING = unchecked((int)(0xC0220044));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_TCPIP_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_FWP_TCPIP_NOT_READY ((NTSTATUS)0xC0220100L)")]
    public const int STATUS_FWP_TCPIP_NOT_READY = unchecked((int)(0xC0220100));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INJECT_HANDLE_CLOSING"]/*' />
    [NativeTypeName("#define STATUS_FWP_INJECT_HANDLE_CLOSING ((NTSTATUS)0xC0220101L)")]
    public const int STATUS_FWP_INJECT_HANDLE_CLOSING = unchecked((int)(0xC0220101));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_INJECT_HANDLE_STALE"]/*' />
    [NativeTypeName("#define STATUS_FWP_INJECT_HANDLE_STALE ((NTSTATUS)0xC0220102L)")]
    public const int STATUS_FWP_INJECT_HANDLE_STALE = unchecked((int)(0xC0220102));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_CANNOT_PEND"]/*' />
    [NativeTypeName("#define STATUS_FWP_CANNOT_PEND ((NTSTATUS)0xC0220103L)")]
    public const int STATUS_FWP_CANNOT_PEND = unchecked((int)(0xC0220103));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FWP_DROP_NOICMP"]/*' />
    [NativeTypeName("#define STATUS_FWP_DROP_NOICMP ((NTSTATUS)0xC0220104L)")]
    public const int STATUS_FWP_DROP_NOICMP = unchecked((int)(0xC0220104));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_CLOSING"]/*' />
    [NativeTypeName("#define STATUS_NDIS_CLOSING ((NTSTATUS)0xC0230002L)")]
    public const int STATUS_NDIS_CLOSING = unchecked((int)(0xC0230002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_BAD_VERSION"]/*' />
    [NativeTypeName("#define STATUS_NDIS_BAD_VERSION ((NTSTATUS)0xC0230004L)")]
    public const int STATUS_NDIS_BAD_VERSION = unchecked((int)(0xC0230004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_BAD_CHARACTERISTICS"]/*' />
    [NativeTypeName("#define STATUS_NDIS_BAD_CHARACTERISTICS ((NTSTATUS)0xC0230005L)")]
    public const int STATUS_NDIS_BAD_CHARACTERISTICS = unchecked((int)(0xC0230005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_ADAPTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_NDIS_ADAPTER_NOT_FOUND ((NTSTATUS)0xC0230006L)")]
    public const int STATUS_NDIS_ADAPTER_NOT_FOUND = unchecked((int)(0xC0230006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_OPEN_FAILED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_OPEN_FAILED ((NTSTATUS)0xC0230007L)")]
    public const int STATUS_NDIS_OPEN_FAILED = unchecked((int)(0xC0230007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DEVICE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DEVICE_FAILED ((NTSTATUS)0xC0230008L)")]
    public const int STATUS_NDIS_DEVICE_FAILED = unchecked((int)(0xC0230008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_MULTICAST_FULL"]/*' />
    [NativeTypeName("#define STATUS_NDIS_MULTICAST_FULL ((NTSTATUS)0xC0230009L)")]
    public const int STATUS_NDIS_MULTICAST_FULL = unchecked((int)(0xC0230009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_MULTICAST_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_NDIS_MULTICAST_EXISTS ((NTSTATUS)0xC023000AL)")]
    public const int STATUS_NDIS_MULTICAST_EXISTS = unchecked((int)(0xC023000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_MULTICAST_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_NDIS_MULTICAST_NOT_FOUND ((NTSTATUS)0xC023000BL)")]
    public const int STATUS_NDIS_MULTICAST_NOT_FOUND = unchecked((int)(0xC023000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_REQUEST_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_REQUEST_ABORTED ((NTSTATUS)0xC023000CL)")]
    public const int STATUS_NDIS_REQUEST_ABORTED = unchecked((int)(0xC023000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_RESET_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_NDIS_RESET_IN_PROGRESS ((NTSTATUS)0xC023000DL)")]
    public const int STATUS_NDIS_RESET_IN_PROGRESS = unchecked((int)(0xC023000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_NOT_SUPPORTED ((NTSTATUS)0xC02300BBL)")]
    public const int STATUS_NDIS_NOT_SUPPORTED = unchecked((int)(0xC02300BB));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INVALID_PACKET"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INVALID_PACKET ((NTSTATUS)0xC023000FL)")]
    public const int STATUS_NDIS_INVALID_PACKET = unchecked((int)(0xC023000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_ADAPTER_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_NDIS_ADAPTER_NOT_READY ((NTSTATUS)0xC0230011L)")]
    public const int STATUS_NDIS_ADAPTER_NOT_READY = unchecked((int)(0xC0230011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INVALID_LENGTH"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INVALID_LENGTH ((NTSTATUS)0xC0230014L)")]
    public const int STATUS_NDIS_INVALID_LENGTH = unchecked((int)(0xC0230014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INVALID_DATA"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INVALID_DATA ((NTSTATUS)0xC0230015L)")]
    public const int STATUS_NDIS_INVALID_DATA = unchecked((int)(0xC0230015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_BUFFER_TOO_SHORT"]/*' />
    [NativeTypeName("#define STATUS_NDIS_BUFFER_TOO_SHORT ((NTSTATUS)0xC0230016L)")]
    public const int STATUS_NDIS_BUFFER_TOO_SHORT = unchecked((int)(0xC0230016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INVALID_OID"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INVALID_OID ((NTSTATUS)0xC0230017L)")]
    public const int STATUS_NDIS_INVALID_OID = unchecked((int)(0xC0230017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_ADAPTER_REMOVED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_ADAPTER_REMOVED ((NTSTATUS)0xC0230018L)")]
    public const int STATUS_NDIS_ADAPTER_REMOVED = unchecked((int)(0xC0230018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_UNSUPPORTED_MEDIA"]/*' />
    [NativeTypeName("#define STATUS_NDIS_UNSUPPORTED_MEDIA ((NTSTATUS)0xC0230019L)")]
    public const int STATUS_NDIS_UNSUPPORTED_MEDIA = unchecked((int)(0xC0230019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_GROUP_ADDRESS_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_NDIS_GROUP_ADDRESS_IN_USE ((NTSTATUS)0xC023001AL)")]
    public const int STATUS_NDIS_GROUP_ADDRESS_IN_USE = unchecked((int)(0xC023001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_NDIS_FILE_NOT_FOUND ((NTSTATUS)0xC023001BL)")]
    public const int STATUS_NDIS_FILE_NOT_FOUND = unchecked((int)(0xC023001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_ERROR_READING_FILE"]/*' />
    [NativeTypeName("#define STATUS_NDIS_ERROR_READING_FILE ((NTSTATUS)0xC023001CL)")]
    public const int STATUS_NDIS_ERROR_READING_FILE = unchecked((int)(0xC023001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_ALREADY_MAPPED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_ALREADY_MAPPED ((NTSTATUS)0xC023001DL)")]
    public const int STATUS_NDIS_ALREADY_MAPPED = unchecked((int)(0xC023001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_RESOURCE_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_NDIS_RESOURCE_CONFLICT ((NTSTATUS)0xC023001EL)")]
    public const int STATUS_NDIS_RESOURCE_CONFLICT = unchecked((int)(0xC023001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_MEDIA_DISCONNECTED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_MEDIA_DISCONNECTED ((NTSTATUS)0xC023001FL)")]
    public const int STATUS_NDIS_MEDIA_DISCONNECTED = unchecked((int)(0xC023001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INVALID_ADDRESS"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INVALID_ADDRESS ((NTSTATUS)0xC0230022L)")]
    public const int STATUS_NDIS_INVALID_ADDRESS = unchecked((int)(0xC0230022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INVALID_DEVICE_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INVALID_DEVICE_REQUEST ((NTSTATUS)0xC0230010L)")]
    public const int STATUS_NDIS_INVALID_DEVICE_REQUEST = unchecked((int)(0xC0230010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_PAUSED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_PAUSED ((NTSTATUS)0xC023002AL)")]
    public const int STATUS_NDIS_PAUSED = unchecked((int)(0xC023002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INTERFACE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INTERFACE_NOT_FOUND ((NTSTATUS)0xC023002BL)")]
    public const int STATUS_NDIS_INTERFACE_NOT_FOUND = unchecked((int)(0xC023002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_UNSUPPORTED_REVISION"]/*' />
    [NativeTypeName("#define STATUS_NDIS_UNSUPPORTED_REVISION ((NTSTATUS)0xC023002CL)")]
    public const int STATUS_NDIS_UNSUPPORTED_REVISION = unchecked((int)(0xC023002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INVALID_PORT"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INVALID_PORT ((NTSTATUS)0xC023002DL)")]
    public const int STATUS_NDIS_INVALID_PORT = unchecked((int)(0xC023002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INVALID_PORT_STATE"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INVALID_PORT_STATE ((NTSTATUS)0xC023002EL)")]
    public const int STATUS_NDIS_INVALID_PORT_STATE = unchecked((int)(0xC023002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_LOW_POWER_STATE"]/*' />
    [NativeTypeName("#define STATUS_NDIS_LOW_POWER_STATE ((NTSTATUS)0xC023002FL)")]
    public const int STATUS_NDIS_LOW_POWER_STATE = unchecked((int)(0xC023002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_REINIT_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_REINIT_REQUIRED ((NTSTATUS)0xC0230030L)")]
    public const int STATUS_NDIS_REINIT_REQUIRED = unchecked((int)(0xC0230030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_NO_QUEUES"]/*' />
    [NativeTypeName("#define STATUS_NDIS_NO_QUEUES ((NTSTATUS)0xC0230031L)")]
    public const int STATUS_NDIS_NO_QUEUES = unchecked((int)(0xC0230031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DOT11_AUTO_CONFIG_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DOT11_AUTO_CONFIG_ENABLED ((NTSTATUS)0xC0232000L)")]
    public const int STATUS_NDIS_DOT11_AUTO_CONFIG_ENABLED = unchecked((int)(0xC0232000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DOT11_MEDIA_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DOT11_MEDIA_IN_USE ((NTSTATUS)0xC0232001L)")]
    public const int STATUS_NDIS_DOT11_MEDIA_IN_USE = unchecked((int)(0xC0232001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DOT11_POWER_STATE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DOT11_POWER_STATE_INVALID ((NTSTATUS)0xC0232002L)")]
    public const int STATUS_NDIS_DOT11_POWER_STATE_INVALID = unchecked((int)(0xC0232002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_PM_WOL_PATTERN_LIST_FULL"]/*' />
    [NativeTypeName("#define STATUS_NDIS_PM_WOL_PATTERN_LIST_FULL ((NTSTATUS)0xC0232003L)")]
    public const int STATUS_NDIS_PM_WOL_PATTERN_LIST_FULL = unchecked((int)(0xC0232003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL"]/*' />
    [NativeTypeName("#define STATUS_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL ((NTSTATUS)0xC0232004L)")]
    public const int STATUS_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL = unchecked((int)(0xC0232004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE ((NTSTATUS)0xC0232005L)")]
    public const int STATUS_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE = unchecked((int)(0xC0232005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE ((NTSTATUS)0xC0232006L)")]
    public const int STATUS_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE = unchecked((int)(0xC0232006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED ((NTSTATUS)0xC0232007L)")]
    public const int STATUS_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED = unchecked((int)(0xC0232007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DOT11_AP_BAND_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DOT11_AP_BAND_NOT_ALLOWED ((NTSTATUS)0xC0232008L)")]
    public const int STATUS_NDIS_DOT11_AP_BAND_NOT_ALLOWED = unchecked((int)(0xC0232008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_DOT11_AP_RADIO_RESTRICTION"]/*' />
    [NativeTypeName("#define STATUS_NDIS_DOT11_AP_RADIO_RESTRICTION ((NTSTATUS)0xC0232009L)")]
    public const int STATUS_NDIS_DOT11_AP_RADIO_RESTRICTION = unchecked((int)(0xC0232009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_INDICATION_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_INDICATION_REQUIRED ((NTSTATUS)0x40230001L)")]
    public const int STATUS_NDIS_INDICATION_REQUIRED = ((int)(0x40230001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_OFFLOAD_POLICY"]/*' />
    [NativeTypeName("#define STATUS_NDIS_OFFLOAD_POLICY ((NTSTATUS)0xC023100FL)")]
    public const int STATUS_NDIS_OFFLOAD_POLICY = unchecked((int)(0xC023100F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_OFFLOAD_CONNECTION_REJECTED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_OFFLOAD_CONNECTION_REJECTED ((NTSTATUS)0xC0231012L)")]
    public const int STATUS_NDIS_OFFLOAD_CONNECTION_REJECTED = unchecked((int)(0xC0231012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NDIS_OFFLOAD_PATH_REJECTED"]/*' />
    [NativeTypeName("#define STATUS_NDIS_OFFLOAD_PATH_REJECTED ((NTSTATUS)0xC0231013L)")]
    public const int STATUS_NDIS_OFFLOAD_PATH_REJECTED = unchecked((int)(0xC0231013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_ERROR_MASK"]/*' />
    [NativeTypeName("#define STATUS_TPM_ERROR_MASK ((NTSTATUS)0xC0290000L)")]
    public const int STATUS_TPM_ERROR_MASK = unchecked((int)(0xC0290000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_AUTHFAIL"]/*' />
    [NativeTypeName("#define STATUS_TPM_AUTHFAIL ((NTSTATUS)0xC0290001L)")]
    public const int STATUS_TPM_AUTHFAIL = unchecked((int)(0xC0290001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BADINDEX"]/*' />
    [NativeTypeName("#define STATUS_TPM_BADINDEX ((NTSTATUS)0xC0290002L)")]
    public const int STATUS_TPM_BADINDEX = unchecked((int)(0xC0290002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_PARAMETER ((NTSTATUS)0xC0290003L)")]
    public const int STATUS_TPM_BAD_PARAMETER = unchecked((int)(0xC0290003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_AUDITFAILURE"]/*' />
    [NativeTypeName("#define STATUS_TPM_AUDITFAILURE ((NTSTATUS)0xC0290004L)")]
    public const int STATUS_TPM_AUDITFAILURE = unchecked((int)(0xC0290004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_CLEAR_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_TPM_CLEAR_DISABLED ((NTSTATUS)0xC0290005L)")]
    public const int STATUS_TPM_CLEAR_DISABLED = unchecked((int)(0xC0290005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DEACTIVATED"]/*' />
    [NativeTypeName("#define STATUS_TPM_DEACTIVATED ((NTSTATUS)0xC0290006L)")]
    public const int STATUS_TPM_DEACTIVATED = unchecked((int)(0xC0290006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_TPM_DISABLED ((NTSTATUS)0xC0290007L)")]
    public const int STATUS_TPM_DISABLED = unchecked((int)(0xC0290007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DISABLED_CMD"]/*' />
    [NativeTypeName("#define STATUS_TPM_DISABLED_CMD ((NTSTATUS)0xC0290008L)")]
    public const int STATUS_TPM_DISABLED_CMD = unchecked((int)(0xC0290008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_FAIL"]/*' />
    [NativeTypeName("#define STATUS_TPM_FAIL ((NTSTATUS)0xC0290009L)")]
    public const int STATUS_TPM_FAIL = unchecked((int)(0xC0290009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_ORDINAL"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_ORDINAL ((NTSTATUS)0xC029000AL)")]
    public const int STATUS_TPM_BAD_ORDINAL = unchecked((int)(0xC029000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INSTALL_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_TPM_INSTALL_DISABLED ((NTSTATUS)0xC029000BL)")]
    public const int STATUS_TPM_INSTALL_DISABLED = unchecked((int)(0xC029000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_KEYHANDLE"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_KEYHANDLE ((NTSTATUS)0xC029000CL)")]
    public const int STATUS_TPM_INVALID_KEYHANDLE = unchecked((int)(0xC029000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_KEYNOTFOUND"]/*' />
    [NativeTypeName("#define STATUS_TPM_KEYNOTFOUND ((NTSTATUS)0xC029000DL)")]
    public const int STATUS_TPM_KEYNOTFOUND = unchecked((int)(0xC029000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INAPPROPRIATE_ENC"]/*' />
    [NativeTypeName("#define STATUS_TPM_INAPPROPRIATE_ENC ((NTSTATUS)0xC029000EL)")]
    public const int STATUS_TPM_INAPPROPRIATE_ENC = unchecked((int)(0xC029000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_MIGRATEFAIL"]/*' />
    [NativeTypeName("#define STATUS_TPM_MIGRATEFAIL ((NTSTATUS)0xC029000FL)")]
    public const int STATUS_TPM_MIGRATEFAIL = unchecked((int)(0xC029000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_PCR_INFO"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_PCR_INFO ((NTSTATUS)0xC0290010L)")]
    public const int STATUS_TPM_INVALID_PCR_INFO = unchecked((int)(0xC0290010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOSPACE"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOSPACE ((NTSTATUS)0xC0290011L)")]
    public const int STATUS_TPM_NOSPACE = unchecked((int)(0xC0290011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOSRK"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOSRK ((NTSTATUS)0xC0290012L)")]
    public const int STATUS_TPM_NOSRK = unchecked((int)(0xC0290012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOTSEALED_BLOB"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOTSEALED_BLOB ((NTSTATUS)0xC0290013L)")]
    public const int STATUS_TPM_NOTSEALED_BLOB = unchecked((int)(0xC0290013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_OWNER_SET"]/*' />
    [NativeTypeName("#define STATUS_TPM_OWNER_SET ((NTSTATUS)0xC0290014L)")]
    public const int STATUS_TPM_OWNER_SET = unchecked((int)(0xC0290014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_TPM_RESOURCES ((NTSTATUS)0xC0290015L)")]
    public const int STATUS_TPM_RESOURCES = unchecked((int)(0xC0290015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_SHORTRANDOM"]/*' />
    [NativeTypeName("#define STATUS_TPM_SHORTRANDOM ((NTSTATUS)0xC0290016L)")]
    public const int STATUS_TPM_SHORTRANDOM = unchecked((int)(0xC0290016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_SIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_SIZE ((NTSTATUS)0xC0290017L)")]
    public const int STATUS_TPM_SIZE = unchecked((int)(0xC0290017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_WRONGPCRVAL"]/*' />
    [NativeTypeName("#define STATUS_TPM_WRONGPCRVAL ((NTSTATUS)0xC0290018L)")]
    public const int STATUS_TPM_WRONGPCRVAL = unchecked((int)(0xC0290018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_PARAM_SIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_PARAM_SIZE ((NTSTATUS)0xC0290019L)")]
    public const int STATUS_TPM_BAD_PARAM_SIZE = unchecked((int)(0xC0290019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_SHA_THREAD"]/*' />
    [NativeTypeName("#define STATUS_TPM_SHA_THREAD ((NTSTATUS)0xC029001AL)")]
    public const int STATUS_TPM_SHA_THREAD = unchecked((int)(0xC029001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_SHA_ERROR"]/*' />
    [NativeTypeName("#define STATUS_TPM_SHA_ERROR ((NTSTATUS)0xC029001BL)")]
    public const int STATUS_TPM_SHA_ERROR = unchecked((int)(0xC029001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_FAILEDSELFTEST"]/*' />
    [NativeTypeName("#define STATUS_TPM_FAILEDSELFTEST ((NTSTATUS)0xC029001CL)")]
    public const int STATUS_TPM_FAILEDSELFTEST = unchecked((int)(0xC029001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_AUTH2FAIL"]/*' />
    [NativeTypeName("#define STATUS_TPM_AUTH2FAIL ((NTSTATUS)0xC029001DL)")]
    public const int STATUS_TPM_AUTH2FAIL = unchecked((int)(0xC029001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BADTAG"]/*' />
    [NativeTypeName("#define STATUS_TPM_BADTAG ((NTSTATUS)0xC029001EL)")]
    public const int STATUS_TPM_BADTAG = unchecked((int)(0xC029001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_IOERROR"]/*' />
    [NativeTypeName("#define STATUS_TPM_IOERROR ((NTSTATUS)0xC029001FL)")]
    public const int STATUS_TPM_IOERROR = unchecked((int)(0xC029001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_ENCRYPT_ERROR"]/*' />
    [NativeTypeName("#define STATUS_TPM_ENCRYPT_ERROR ((NTSTATUS)0xC0290020L)")]
    public const int STATUS_TPM_ENCRYPT_ERROR = unchecked((int)(0xC0290020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DECRYPT_ERROR"]/*' />
    [NativeTypeName("#define STATUS_TPM_DECRYPT_ERROR ((NTSTATUS)0xC0290021L)")]
    public const int STATUS_TPM_DECRYPT_ERROR = unchecked((int)(0xC0290021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_AUTHHANDLE"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_AUTHHANDLE ((NTSTATUS)0xC0290022L)")]
    public const int STATUS_TPM_INVALID_AUTHHANDLE = unchecked((int)(0xC0290022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NO_ENDORSEMENT"]/*' />
    [NativeTypeName("#define STATUS_TPM_NO_ENDORSEMENT ((NTSTATUS)0xC0290023L)")]
    public const int STATUS_TPM_NO_ENDORSEMENT = unchecked((int)(0xC0290023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_KEYUSAGE"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_KEYUSAGE ((NTSTATUS)0xC0290024L)")]
    public const int STATUS_TPM_INVALID_KEYUSAGE = unchecked((int)(0xC0290024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_WRONG_ENTITYTYPE"]/*' />
    [NativeTypeName("#define STATUS_TPM_WRONG_ENTITYTYPE ((NTSTATUS)0xC0290025L)")]
    public const int STATUS_TPM_WRONG_ENTITYTYPE = unchecked((int)(0xC0290025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_POSTINIT"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_POSTINIT ((NTSTATUS)0xC0290026L)")]
    public const int STATUS_TPM_INVALID_POSTINIT = unchecked((int)(0xC0290026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INAPPROPRIATE_SIG"]/*' />
    [NativeTypeName("#define STATUS_TPM_INAPPROPRIATE_SIG ((NTSTATUS)0xC0290027L)")]
    public const int STATUS_TPM_INAPPROPRIATE_SIG = unchecked((int)(0xC0290027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_KEY_PROPERTY"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_KEY_PROPERTY ((NTSTATUS)0xC0290028L)")]
    public const int STATUS_TPM_BAD_KEY_PROPERTY = unchecked((int)(0xC0290028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_MIGRATION"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_MIGRATION ((NTSTATUS)0xC0290029L)")]
    public const int STATUS_TPM_BAD_MIGRATION = unchecked((int)(0xC0290029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_SCHEME"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_SCHEME ((NTSTATUS)0xC029002AL)")]
    public const int STATUS_TPM_BAD_SCHEME = unchecked((int)(0xC029002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_DATASIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_DATASIZE ((NTSTATUS)0xC029002BL)")]
    public const int STATUS_TPM_BAD_DATASIZE = unchecked((int)(0xC029002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_MODE"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_MODE ((NTSTATUS)0xC029002CL)")]
    public const int STATUS_TPM_BAD_MODE = unchecked((int)(0xC029002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_PRESENCE"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_PRESENCE ((NTSTATUS)0xC029002DL)")]
    public const int STATUS_TPM_BAD_PRESENCE = unchecked((int)(0xC029002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_VERSION"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_VERSION ((NTSTATUS)0xC029002EL)")]
    public const int STATUS_TPM_BAD_VERSION = unchecked((int)(0xC029002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NO_WRAP_TRANSPORT"]/*' />
    [NativeTypeName("#define STATUS_TPM_NO_WRAP_TRANSPORT ((NTSTATUS)0xC029002FL)")]
    public const int STATUS_TPM_NO_WRAP_TRANSPORT = unchecked((int)(0xC029002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_AUDITFAIL_UNSUCCESSFUL"]/*' />
    [NativeTypeName("#define STATUS_TPM_AUDITFAIL_UNSUCCESSFUL ((NTSTATUS)0xC0290030L)")]
    public const int STATUS_TPM_AUDITFAIL_UNSUCCESSFUL = unchecked((int)(0xC0290030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_AUDITFAIL_SUCCESSFUL"]/*' />
    [NativeTypeName("#define STATUS_TPM_AUDITFAIL_SUCCESSFUL ((NTSTATUS)0xC0290031L)")]
    public const int STATUS_TPM_AUDITFAIL_SUCCESSFUL = unchecked((int)(0xC0290031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOTRESETABLE"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOTRESETABLE ((NTSTATUS)0xC0290032L)")]
    public const int STATUS_TPM_NOTRESETABLE = unchecked((int)(0xC0290032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOTLOCAL"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOTLOCAL ((NTSTATUS)0xC0290033L)")]
    public const int STATUS_TPM_NOTLOCAL = unchecked((int)(0xC0290033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_TYPE"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_TYPE ((NTSTATUS)0xC0290034L)")]
    public const int STATUS_TPM_BAD_TYPE = unchecked((int)(0xC0290034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_RESOURCE"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_RESOURCE ((NTSTATUS)0xC0290035L)")]
    public const int STATUS_TPM_INVALID_RESOURCE = unchecked((int)(0xC0290035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOTFIPS"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOTFIPS ((NTSTATUS)0xC0290036L)")]
    public const int STATUS_TPM_NOTFIPS = unchecked((int)(0xC0290036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_FAMILY"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_FAMILY ((NTSTATUS)0xC0290037L)")]
    public const int STATUS_TPM_INVALID_FAMILY = unchecked((int)(0xC0290037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NO_NV_PERMISSION"]/*' />
    [NativeTypeName("#define STATUS_TPM_NO_NV_PERMISSION ((NTSTATUS)0xC0290038L)")]
    public const int STATUS_TPM_NO_NV_PERMISSION = unchecked((int)(0xC0290038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_REQUIRES_SIGN"]/*' />
    [NativeTypeName("#define STATUS_TPM_REQUIRES_SIGN ((NTSTATUS)0xC0290039L)")]
    public const int STATUS_TPM_REQUIRES_SIGN = unchecked((int)(0xC0290039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_KEY_NOTSUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_TPM_KEY_NOTSUPPORTED ((NTSTATUS)0xC029003AL)")]
    public const int STATUS_TPM_KEY_NOTSUPPORTED = unchecked((int)(0xC029003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_AUTH_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_TPM_AUTH_CONFLICT ((NTSTATUS)0xC029003BL)")]
    public const int STATUS_TPM_AUTH_CONFLICT = unchecked((int)(0xC029003B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_AREA_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_TPM_AREA_LOCKED ((NTSTATUS)0xC029003CL)")]
    public const int STATUS_TPM_AREA_LOCKED = unchecked((int)(0xC029003C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_LOCALITY"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_LOCALITY ((NTSTATUS)0xC029003DL)")]
    public const int STATUS_TPM_BAD_LOCALITY = unchecked((int)(0xC029003D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_READ_ONLY"]/*' />
    [NativeTypeName("#define STATUS_TPM_READ_ONLY ((NTSTATUS)0xC029003EL)")]
    public const int STATUS_TPM_READ_ONLY = unchecked((int)(0xC029003E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_PER_NOWRITE"]/*' />
    [NativeTypeName("#define STATUS_TPM_PER_NOWRITE ((NTSTATUS)0xC029003FL)")]
    public const int STATUS_TPM_PER_NOWRITE = unchecked((int)(0xC029003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_FAMILYCOUNT"]/*' />
    [NativeTypeName("#define STATUS_TPM_FAMILYCOUNT ((NTSTATUS)0xC0290040L)")]
    public const int STATUS_TPM_FAMILYCOUNT = unchecked((int)(0xC0290040));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_WRITE_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_TPM_WRITE_LOCKED ((NTSTATUS)0xC0290041L)")]
    public const int STATUS_TPM_WRITE_LOCKED = unchecked((int)(0xC0290041));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_ATTRIBUTES"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_ATTRIBUTES ((NTSTATUS)0xC0290042L)")]
    public const int STATUS_TPM_BAD_ATTRIBUTES = unchecked((int)(0xC0290042));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_STRUCTURE"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_STRUCTURE ((NTSTATUS)0xC0290043L)")]
    public const int STATUS_TPM_INVALID_STRUCTURE = unchecked((int)(0xC0290043));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_KEY_OWNER_CONTROL"]/*' />
    [NativeTypeName("#define STATUS_TPM_KEY_OWNER_CONTROL ((NTSTATUS)0xC0290044L)")]
    public const int STATUS_TPM_KEY_OWNER_CONTROL = unchecked((int)(0xC0290044));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_COUNTER"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_COUNTER ((NTSTATUS)0xC0290045L)")]
    public const int STATUS_TPM_BAD_COUNTER = unchecked((int)(0xC0290045));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOT_FULLWRITE"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOT_FULLWRITE ((NTSTATUS)0xC0290046L)")]
    public const int STATUS_TPM_NOT_FULLWRITE = unchecked((int)(0xC0290046));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_CONTEXT_GAP"]/*' />
    [NativeTypeName("#define STATUS_TPM_CONTEXT_GAP ((NTSTATUS)0xC0290047L)")]
    public const int STATUS_TPM_CONTEXT_GAP = unchecked((int)(0xC0290047));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_MAXNVWRITES"]/*' />
    [NativeTypeName("#define STATUS_TPM_MAXNVWRITES ((NTSTATUS)0xC0290048L)")]
    public const int STATUS_TPM_MAXNVWRITES = unchecked((int)(0xC0290048));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOOPERATOR"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOOPERATOR ((NTSTATUS)0xC0290049L)")]
    public const int STATUS_TPM_NOOPERATOR = unchecked((int)(0xC0290049));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_RESOURCEMISSING"]/*' />
    [NativeTypeName("#define STATUS_TPM_RESOURCEMISSING ((NTSTATUS)0xC029004AL)")]
    public const int STATUS_TPM_RESOURCEMISSING = unchecked((int)(0xC029004A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DELEGATE_LOCK"]/*' />
    [NativeTypeName("#define STATUS_TPM_DELEGATE_LOCK ((NTSTATUS)0xC029004BL)")]
    public const int STATUS_TPM_DELEGATE_LOCK = unchecked((int)(0xC029004B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DELEGATE_FAMILY"]/*' />
    [NativeTypeName("#define STATUS_TPM_DELEGATE_FAMILY ((NTSTATUS)0xC029004CL)")]
    public const int STATUS_TPM_DELEGATE_FAMILY = unchecked((int)(0xC029004C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DELEGATE_ADMIN"]/*' />
    [NativeTypeName("#define STATUS_TPM_DELEGATE_ADMIN ((NTSTATUS)0xC029004DL)")]
    public const int STATUS_TPM_DELEGATE_ADMIN = unchecked((int)(0xC029004D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_TRANSPORT_NOTEXCLUSIVE"]/*' />
    [NativeTypeName("#define STATUS_TPM_TRANSPORT_NOTEXCLUSIVE ((NTSTATUS)0xC029004EL)")]
    public const int STATUS_TPM_TRANSPORT_NOTEXCLUSIVE = unchecked((int)(0xC029004E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_OWNER_CONTROL"]/*' />
    [NativeTypeName("#define STATUS_TPM_OWNER_CONTROL ((NTSTATUS)0xC029004FL)")]
    public const int STATUS_TPM_OWNER_CONTROL = unchecked((int)(0xC029004F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DAA_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_TPM_DAA_RESOURCES ((NTSTATUS)0xC0290050L)")]
    public const int STATUS_TPM_DAA_RESOURCES = unchecked((int)(0xC0290050));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DAA_INPUT_DATA0"]/*' />
    [NativeTypeName("#define STATUS_TPM_DAA_INPUT_DATA0 ((NTSTATUS)0xC0290051L)")]
    public const int STATUS_TPM_DAA_INPUT_DATA0 = unchecked((int)(0xC0290051));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DAA_INPUT_DATA1"]/*' />
    [NativeTypeName("#define STATUS_TPM_DAA_INPUT_DATA1 ((NTSTATUS)0xC0290052L)")]
    public const int STATUS_TPM_DAA_INPUT_DATA1 = unchecked((int)(0xC0290052));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DAA_ISSUER_SETTINGS"]/*' />
    [NativeTypeName("#define STATUS_TPM_DAA_ISSUER_SETTINGS ((NTSTATUS)0xC0290053L)")]
    public const int STATUS_TPM_DAA_ISSUER_SETTINGS = unchecked((int)(0xC0290053));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DAA_TPM_SETTINGS"]/*' />
    [NativeTypeName("#define STATUS_TPM_DAA_TPM_SETTINGS ((NTSTATUS)0xC0290054L)")]
    public const int STATUS_TPM_DAA_TPM_SETTINGS = unchecked((int)(0xC0290054));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DAA_STAGE"]/*' />
    [NativeTypeName("#define STATUS_TPM_DAA_STAGE ((NTSTATUS)0xC0290055L)")]
    public const int STATUS_TPM_DAA_STAGE = unchecked((int)(0xC0290055));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DAA_ISSUER_VALIDITY"]/*' />
    [NativeTypeName("#define STATUS_TPM_DAA_ISSUER_VALIDITY ((NTSTATUS)0xC0290056L)")]
    public const int STATUS_TPM_DAA_ISSUER_VALIDITY = unchecked((int)(0xC0290056));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DAA_WRONG_W"]/*' />
    [NativeTypeName("#define STATUS_TPM_DAA_WRONG_W ((NTSTATUS)0xC0290057L)")]
    public const int STATUS_TPM_DAA_WRONG_W = unchecked((int)(0xC0290057));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_HANDLE ((NTSTATUS)0xC0290058L)")]
    public const int STATUS_TPM_BAD_HANDLE = unchecked((int)(0xC0290058));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_DELEGATE"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_DELEGATE ((NTSTATUS)0xC0290059L)")]
    public const int STATUS_TPM_BAD_DELEGATE = unchecked((int)(0xC0290059));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BADCONTEXT"]/*' />
    [NativeTypeName("#define STATUS_TPM_BADCONTEXT ((NTSTATUS)0xC029005AL)")]
    public const int STATUS_TPM_BADCONTEXT = unchecked((int)(0xC029005A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_TOOMANYCONTEXTS"]/*' />
    [NativeTypeName("#define STATUS_TPM_TOOMANYCONTEXTS ((NTSTATUS)0xC029005BL)")]
    public const int STATUS_TPM_TOOMANYCONTEXTS = unchecked((int)(0xC029005B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_MA_TICKET_SIGNATURE"]/*' />
    [NativeTypeName("#define STATUS_TPM_MA_TICKET_SIGNATURE ((NTSTATUS)0xC029005CL)")]
    public const int STATUS_TPM_MA_TICKET_SIGNATURE = unchecked((int)(0xC029005C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_MA_DESTINATION"]/*' />
    [NativeTypeName("#define STATUS_TPM_MA_DESTINATION ((NTSTATUS)0xC029005DL)")]
    public const int STATUS_TPM_MA_DESTINATION = unchecked((int)(0xC029005D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_MA_SOURCE"]/*' />
    [NativeTypeName("#define STATUS_TPM_MA_SOURCE ((NTSTATUS)0xC029005EL)")]
    public const int STATUS_TPM_MA_SOURCE = unchecked((int)(0xC029005E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_MA_AUTHORITY"]/*' />
    [NativeTypeName("#define STATUS_TPM_MA_AUTHORITY ((NTSTATUS)0xC029005FL)")]
    public const int STATUS_TPM_MA_AUTHORITY = unchecked((int)(0xC029005F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_PERMANENTEK"]/*' />
    [NativeTypeName("#define STATUS_TPM_PERMANENTEK ((NTSTATUS)0xC0290061L)")]
    public const int STATUS_TPM_PERMANENTEK = unchecked((int)(0xC0290061));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_BAD_SIGNATURE"]/*' />
    [NativeTypeName("#define STATUS_TPM_BAD_SIGNATURE ((NTSTATUS)0xC0290062L)")]
    public const int STATUS_TPM_BAD_SIGNATURE = unchecked((int)(0xC0290062));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOCONTEXTSPACE"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOCONTEXTSPACE ((NTSTATUS)0xC0290063L)")]
    public const int STATUS_TPM_NOCONTEXTSPACE = unchecked((int)(0xC0290063));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_ASYMMETRIC"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_ASYMMETRIC ((NTSTATUS)0xC0290081L)")]
    public const int STATUS_TPM_20_E_ASYMMETRIC = unchecked((int)(0xC0290081));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_ATTRIBUTES"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_ATTRIBUTES ((NTSTATUS)0xC0290082L)")]
    public const int STATUS_TPM_20_E_ATTRIBUTES = unchecked((int)(0xC0290082));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_HASH"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_HASH ((NTSTATUS)0xC0290083L)")]
    public const int STATUS_TPM_20_E_HASH = unchecked((int)(0xC0290083));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_VALUE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_VALUE ((NTSTATUS)0xC0290084L)")]
    public const int STATUS_TPM_20_E_VALUE = unchecked((int)(0xC0290084));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_HIERARCHY"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_HIERARCHY ((NTSTATUS)0xC0290085L)")]
    public const int STATUS_TPM_20_E_HIERARCHY = unchecked((int)(0xC0290085));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_KEY_SIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_KEY_SIZE ((NTSTATUS)0xC0290087L)")]
    public const int STATUS_TPM_20_E_KEY_SIZE = unchecked((int)(0xC0290087));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_MGF"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_MGF ((NTSTATUS)0xC0290088L)")]
    public const int STATUS_TPM_20_E_MGF = unchecked((int)(0xC0290088));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_MODE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_MODE ((NTSTATUS)0xC0290089L)")]
    public const int STATUS_TPM_20_E_MODE = unchecked((int)(0xC0290089));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_TYPE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_TYPE ((NTSTATUS)0xC029008AL)")]
    public const int STATUS_TPM_20_E_TYPE = unchecked((int)(0xC029008A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_HANDLE ((NTSTATUS)0xC029008BL)")]
    public const int STATUS_TPM_20_E_HANDLE = unchecked((int)(0xC029008B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_KDF"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_KDF ((NTSTATUS)0xC029008CL)")]
    public const int STATUS_TPM_20_E_KDF = unchecked((int)(0xC029008C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_RANGE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_RANGE ((NTSTATUS)0xC029008DL)")]
    public const int STATUS_TPM_20_E_RANGE = unchecked((int)(0xC029008D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_AUTH_FAIL"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_AUTH_FAIL ((NTSTATUS)0xC029008EL)")]
    public const int STATUS_TPM_20_E_AUTH_FAIL = unchecked((int)(0xC029008E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NONCE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NONCE ((NTSTATUS)0xC029008FL)")]
    public const int STATUS_TPM_20_E_NONCE = unchecked((int)(0xC029008F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_PP"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_PP ((NTSTATUS)0xC0290090L)")]
    public const int STATUS_TPM_20_E_PP = unchecked((int)(0xC0290090));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_SCHEME"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_SCHEME ((NTSTATUS)0xC0290092L)")]
    public const int STATUS_TPM_20_E_SCHEME = unchecked((int)(0xC0290092));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_SIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_SIZE ((NTSTATUS)0xC0290095L)")]
    public const int STATUS_TPM_20_E_SIZE = unchecked((int)(0xC0290095));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_SYMMETRIC"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_SYMMETRIC ((NTSTATUS)0xC0290096L)")]
    public const int STATUS_TPM_20_E_SYMMETRIC = unchecked((int)(0xC0290096));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_TAG"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_TAG ((NTSTATUS)0xC0290097L)")]
    public const int STATUS_TPM_20_E_TAG = unchecked((int)(0xC0290097));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_SELECTOR"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_SELECTOR ((NTSTATUS)0xC0290098L)")]
    public const int STATUS_TPM_20_E_SELECTOR = unchecked((int)(0xC0290098));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_INSUFFICIENT"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_INSUFFICIENT ((NTSTATUS)0xC029009AL)")]
    public const int STATUS_TPM_20_E_INSUFFICIENT = unchecked((int)(0xC029009A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_SIGNATURE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_SIGNATURE ((NTSTATUS)0xC029009BL)")]
    public const int STATUS_TPM_20_E_SIGNATURE = unchecked((int)(0xC029009B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_KEY"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_KEY ((NTSTATUS)0xC029009CL)")]
    public const int STATUS_TPM_20_E_KEY = unchecked((int)(0xC029009C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_POLICY_FAIL"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_POLICY_FAIL ((NTSTATUS)0xC029009DL)")]
    public const int STATUS_TPM_20_E_POLICY_FAIL = unchecked((int)(0xC029009D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_INTEGRITY"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_INTEGRITY ((NTSTATUS)0xC029009FL)")]
    public const int STATUS_TPM_20_E_INTEGRITY = unchecked((int)(0xC029009F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_TICKET"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_TICKET ((NTSTATUS)0xC02900A0L)")]
    public const int STATUS_TPM_20_E_TICKET = unchecked((int)(0xC02900A0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_RESERVED_BITS"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_RESERVED_BITS ((NTSTATUS)0xC02900A1L)")]
    public const int STATUS_TPM_20_E_RESERVED_BITS = unchecked((int)(0xC02900A1));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_BAD_AUTH"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_BAD_AUTH ((NTSTATUS)0xC02900A2L)")]
    public const int STATUS_TPM_20_E_BAD_AUTH = unchecked((int)(0xC02900A2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_EXPIRED ((NTSTATUS)0xC02900A3L)")]
    public const int STATUS_TPM_20_E_EXPIRED = unchecked((int)(0xC02900A3));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_POLICY_CC"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_POLICY_CC ((NTSTATUS)0xC02900A4L)")]
    public const int STATUS_TPM_20_E_POLICY_CC = unchecked((int)(0xC02900A4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_BINDING"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_BINDING ((NTSTATUS)0xC02900A5L)")]
    public const int STATUS_TPM_20_E_BINDING = unchecked((int)(0xC02900A5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_CURVE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_CURVE ((NTSTATUS)0xC02900A6L)")]
    public const int STATUS_TPM_20_E_CURVE = unchecked((int)(0xC02900A6));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_ECC_POINT"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_ECC_POINT ((NTSTATUS)0xC02900A7L)")]
    public const int STATUS_TPM_20_E_ECC_POINT = unchecked((int)(0xC02900A7));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_INITIALIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_INITIALIZE ((NTSTATUS)0xC0290100L)")]
    public const int STATUS_TPM_20_E_INITIALIZE = unchecked((int)(0xC0290100));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_FAILURE ((NTSTATUS)0xC0290101L)")]
    public const int STATUS_TPM_20_E_FAILURE = unchecked((int)(0xC0290101));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_SEQUENCE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_SEQUENCE ((NTSTATUS)0xC0290103L)")]
    public const int STATUS_TPM_20_E_SEQUENCE = unchecked((int)(0xC0290103));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_PRIVATE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_PRIVATE ((NTSTATUS)0xC029010BL)")]
    public const int STATUS_TPM_20_E_PRIVATE = unchecked((int)(0xC029010B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_HMAC"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_HMAC ((NTSTATUS)0xC0290119L)")]
    public const int STATUS_TPM_20_E_HMAC = unchecked((int)(0xC0290119));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_DISABLED ((NTSTATUS)0xC0290120L)")]
    public const int STATUS_TPM_20_E_DISABLED = unchecked((int)(0xC0290120));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_EXCLUSIVE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_EXCLUSIVE ((NTSTATUS)0xC0290121L)")]
    public const int STATUS_TPM_20_E_EXCLUSIVE = unchecked((int)(0xC0290121));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_ECC_CURVE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_ECC_CURVE ((NTSTATUS)0xC0290123L)")]
    public const int STATUS_TPM_20_E_ECC_CURVE = unchecked((int)(0xC0290123));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_AUTH_TYPE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_AUTH_TYPE ((NTSTATUS)0xC0290124L)")]
    public const int STATUS_TPM_20_E_AUTH_TYPE = unchecked((int)(0xC0290124));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_AUTH_MISSING"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_AUTH_MISSING ((NTSTATUS)0xC0290125L)")]
    public const int STATUS_TPM_20_E_AUTH_MISSING = unchecked((int)(0xC0290125));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_POLICY"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_POLICY ((NTSTATUS)0xC0290126L)")]
    public const int STATUS_TPM_20_E_POLICY = unchecked((int)(0xC0290126));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_PCR"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_PCR ((NTSTATUS)0xC0290127L)")]
    public const int STATUS_TPM_20_E_PCR = unchecked((int)(0xC0290127));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_PCR_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_PCR_CHANGED ((NTSTATUS)0xC0290128L)")]
    public const int STATUS_TPM_20_E_PCR_CHANGED = unchecked((int)(0xC0290128));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_UPGRADE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_UPGRADE ((NTSTATUS)0xC029012DL)")]
    public const int STATUS_TPM_20_E_UPGRADE = unchecked((int)(0xC029012D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_TOO_MANY_CONTEXTS"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_TOO_MANY_CONTEXTS ((NTSTATUS)0xC029012EL)")]
    public const int STATUS_TPM_20_E_TOO_MANY_CONTEXTS = unchecked((int)(0xC029012E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_AUTH_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_AUTH_UNAVAILABLE ((NTSTATUS)0xC029012FL)")]
    public const int STATUS_TPM_20_E_AUTH_UNAVAILABLE = unchecked((int)(0xC029012F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_REBOOT"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_REBOOT ((NTSTATUS)0xC0290130L)")]
    public const int STATUS_TPM_20_E_REBOOT = unchecked((int)(0xC0290130));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_UNBALANCED"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_UNBALANCED ((NTSTATUS)0xC0290131L)")]
    public const int STATUS_TPM_20_E_UNBALANCED = unchecked((int)(0xC0290131));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_COMMAND_SIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_COMMAND_SIZE ((NTSTATUS)0xC0290142L)")]
    public const int STATUS_TPM_20_E_COMMAND_SIZE = unchecked((int)(0xC0290142));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_COMMAND_CODE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_COMMAND_CODE ((NTSTATUS)0xC0290143L)")]
    public const int STATUS_TPM_20_E_COMMAND_CODE = unchecked((int)(0xC0290143));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_AUTHSIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_AUTHSIZE ((NTSTATUS)0xC0290144L)")]
    public const int STATUS_TPM_20_E_AUTHSIZE = unchecked((int)(0xC0290144));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_AUTH_CONTEXT"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_AUTH_CONTEXT ((NTSTATUS)0xC0290145L)")]
    public const int STATUS_TPM_20_E_AUTH_CONTEXT = unchecked((int)(0xC0290145));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NV_RANGE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NV_RANGE ((NTSTATUS)0xC0290146L)")]
    public const int STATUS_TPM_20_E_NV_RANGE = unchecked((int)(0xC0290146));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NV_SIZE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NV_SIZE ((NTSTATUS)0xC0290147L)")]
    public const int STATUS_TPM_20_E_NV_SIZE = unchecked((int)(0xC0290147));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NV_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NV_LOCKED ((NTSTATUS)0xC0290148L)")]
    public const int STATUS_TPM_20_E_NV_LOCKED = unchecked((int)(0xC0290148));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NV_AUTHORIZATION"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NV_AUTHORIZATION ((NTSTATUS)0xC0290149L)")]
    public const int STATUS_TPM_20_E_NV_AUTHORIZATION = unchecked((int)(0xC0290149));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NV_UNINITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NV_UNINITIALIZED ((NTSTATUS)0xC029014AL)")]
    public const int STATUS_TPM_20_E_NV_UNINITIALIZED = unchecked((int)(0xC029014A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NV_SPACE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NV_SPACE ((NTSTATUS)0xC029014BL)")]
    public const int STATUS_TPM_20_E_NV_SPACE = unchecked((int)(0xC029014B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NV_DEFINED"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NV_DEFINED ((NTSTATUS)0xC029014CL)")]
    public const int STATUS_TPM_20_E_NV_DEFINED = unchecked((int)(0xC029014C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_BAD_CONTEXT"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_BAD_CONTEXT ((NTSTATUS)0xC0290150L)")]
    public const int STATUS_TPM_20_E_BAD_CONTEXT = unchecked((int)(0xC0290150));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_CPHASH"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_CPHASH ((NTSTATUS)0xC0290151L)")]
    public const int STATUS_TPM_20_E_CPHASH = unchecked((int)(0xC0290151));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_PARENT"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_PARENT ((NTSTATUS)0xC0290152L)")]
    public const int STATUS_TPM_20_E_PARENT = unchecked((int)(0xC0290152));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NEEDS_TEST"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NEEDS_TEST ((NTSTATUS)0xC0290153L)")]
    public const int STATUS_TPM_20_E_NEEDS_TEST = unchecked((int)(0xC0290153));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_NO_RESULT"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_NO_RESULT ((NTSTATUS)0xC0290154L)")]
    public const int STATUS_TPM_20_E_NO_RESULT = unchecked((int)(0xC0290154));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_20_E_SENSITIVE"]/*' />
    [NativeTypeName("#define STATUS_TPM_20_E_SENSITIVE ((NTSTATUS)0xC0290155L)")]
    public const int STATUS_TPM_20_E_SENSITIVE = unchecked((int)(0xC0290155));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_COMMAND_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_TPM_COMMAND_BLOCKED ((NTSTATUS)0xC0290400L)")]
    public const int STATUS_TPM_COMMAND_BLOCKED = unchecked((int)(0xC0290400));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_TPM_INVALID_HANDLE ((NTSTATUS)0xC0290401L)")]
    public const int STATUS_TPM_INVALID_HANDLE = unchecked((int)(0xC0290401));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DUPLICATE_VHANDLE"]/*' />
    [NativeTypeName("#define STATUS_TPM_DUPLICATE_VHANDLE ((NTSTATUS)0xC0290402L)")]
    public const int STATUS_TPM_DUPLICATE_VHANDLE = unchecked((int)(0xC0290402));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_EMBEDDED_COMMAND_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_TPM_EMBEDDED_COMMAND_BLOCKED ((NTSTATUS)0xC0290403L)")]
    public const int STATUS_TPM_EMBEDDED_COMMAND_BLOCKED = unchecked((int)(0xC0290403));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_EMBEDDED_COMMAND_UNSUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_TPM_EMBEDDED_COMMAND_UNSUPPORTED ((NTSTATUS)0xC0290404L)")]
    public const int STATUS_TPM_EMBEDDED_COMMAND_UNSUPPORTED = unchecked((int)(0xC0290404));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_RETRY"]/*' />
    [NativeTypeName("#define STATUS_TPM_RETRY ((NTSTATUS)0xC0290800L)")]
    public const int STATUS_TPM_RETRY = unchecked((int)(0xC0290800));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NEEDS_SELFTEST"]/*' />
    [NativeTypeName("#define STATUS_TPM_NEEDS_SELFTEST ((NTSTATUS)0xC0290801L)")]
    public const int STATUS_TPM_NEEDS_SELFTEST = unchecked((int)(0xC0290801));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DOING_SELFTEST"]/*' />
    [NativeTypeName("#define STATUS_TPM_DOING_SELFTEST ((NTSTATUS)0xC0290802L)")]
    public const int STATUS_TPM_DOING_SELFTEST = unchecked((int)(0xC0290802));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_DEFEND_LOCK_RUNNING"]/*' />
    [NativeTypeName("#define STATUS_TPM_DEFEND_LOCK_RUNNING ((NTSTATUS)0xC0290803L)")]
    public const int STATUS_TPM_DEFEND_LOCK_RUNNING = unchecked((int)(0xC0290803));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_COMMAND_CANCELED"]/*' />
    [NativeTypeName("#define STATUS_TPM_COMMAND_CANCELED ((NTSTATUS)0xC0291001L)")]
    public const int STATUS_TPM_COMMAND_CANCELED = unchecked((int)(0xC0291001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_TOO_MANY_CONTEXTS"]/*' />
    [NativeTypeName("#define STATUS_TPM_TOO_MANY_CONTEXTS ((NTSTATUS)0xC0291002L)")]
    public const int STATUS_TPM_TOO_MANY_CONTEXTS = unchecked((int)(0xC0291002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_TPM_NOT_FOUND ((NTSTATUS)0xC0291003L)")]
    public const int STATUS_TPM_NOT_FOUND = unchecked((int)(0xC0291003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_TPM_ACCESS_DENIED ((NTSTATUS)0xC0291004L)")]
    public const int STATUS_TPM_ACCESS_DENIED = unchecked((int)(0xC0291004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_INSUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define STATUS_TPM_INSUFFICIENT_BUFFER ((NTSTATUS)0xC0291005L)")]
    public const int STATUS_TPM_INSUFFICIENT_BUFFER = unchecked((int)(0xC0291005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_PPI_FUNCTION_UNSUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_TPM_PPI_FUNCTION_UNSUPPORTED ((NTSTATUS)0xC0291006L)")]
    public const int STATUS_TPM_PPI_FUNCTION_UNSUPPORTED = unchecked((int)(0xC0291006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_IN_EXCLUSIVE_MODE"]/*' />
    [NativeTypeName("#define STATUS_TPM_IN_EXCLUSIVE_MODE ((NTSTATUS)0xC0291007L)")]
    public const int STATUS_TPM_IN_EXCLUSIVE_MODE = unchecked((int)(0xC0291007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_TPM_REBOOT_REQUIRED ((NTSTATUS)0xC0291008L)")]
    public const int STATUS_TPM_REBOOT_REQUIRED = unchecked((int)(0xC0291008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_ERROR_MASK"]/*' />
    [NativeTypeName("#define STATUS_PCP_ERROR_MASK ((NTSTATUS)0xC0292000L)")]
    public const int STATUS_PCP_ERROR_MASK = unchecked((int)(0xC0292000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_DEVICE_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_PCP_DEVICE_NOT_READY ((NTSTATUS)0xC0292001L)")]
    public const int STATUS_PCP_DEVICE_NOT_READY = unchecked((int)(0xC0292001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_PCP_INVALID_HANDLE ((NTSTATUS)0xC0292002L)")]
    public const int STATUS_PCP_INVALID_HANDLE = unchecked((int)(0xC0292002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_PCP_INVALID_PARAMETER ((NTSTATUS)0xC0292003L)")]
    public const int STATUS_PCP_INVALID_PARAMETER = unchecked((int)(0xC0292003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_FLAG_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_PCP_FLAG_NOT_SUPPORTED ((NTSTATUS)0xC0292004L)")]
    public const int STATUS_PCP_FLAG_NOT_SUPPORTED = unchecked((int)(0xC0292004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_PCP_NOT_SUPPORTED ((NTSTATUS)0xC0292005L)")]
    public const int STATUS_PCP_NOT_SUPPORTED = unchecked((int)(0xC0292005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_PCP_BUFFER_TOO_SMALL ((NTSTATUS)0xC0292006L)")]
    public const int STATUS_PCP_BUFFER_TOO_SMALL = unchecked((int)(0xC0292006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_PCP_INTERNAL_ERROR ((NTSTATUS)0xC0292007L)")]
    public const int STATUS_PCP_INTERNAL_ERROR = unchecked((int)(0xC0292007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_AUTHENTICATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_PCP_AUTHENTICATION_FAILED ((NTSTATUS)0xC0292008L)")]
    public const int STATUS_PCP_AUTHENTICATION_FAILED = unchecked((int)(0xC0292008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_AUTHENTICATION_IGNORED"]/*' />
    [NativeTypeName("#define STATUS_PCP_AUTHENTICATION_IGNORED ((NTSTATUS)0xC0292009L)")]
    public const int STATUS_PCP_AUTHENTICATION_IGNORED = unchecked((int)(0xC0292009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_POLICY_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PCP_POLICY_NOT_FOUND ((NTSTATUS)0xC029200AL)")]
    public const int STATUS_PCP_POLICY_NOT_FOUND = unchecked((int)(0xC029200A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_PROFILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PCP_PROFILE_NOT_FOUND ((NTSTATUS)0xC029200BL)")]
    public const int STATUS_PCP_PROFILE_NOT_FOUND = unchecked((int)(0xC029200B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_VALIDATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_PCP_VALIDATION_FAILED ((NTSTATUS)0xC029200CL)")]
    public const int STATUS_PCP_VALIDATION_FAILED = unchecked((int)(0xC029200C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_DEVICE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PCP_DEVICE_NOT_FOUND ((NTSTATUS)0xC029200DL)")]
    public const int STATUS_PCP_DEVICE_NOT_FOUND = unchecked((int)(0xC029200D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_WRONG_PARENT"]/*' />
    [NativeTypeName("#define STATUS_PCP_WRONG_PARENT ((NTSTATUS)0xC029200EL)")]
    public const int STATUS_PCP_WRONG_PARENT = unchecked((int)(0xC029200E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_NOT_LOADED"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_NOT_LOADED ((NTSTATUS)0xC029200FL)")]
    public const int STATUS_PCP_KEY_NOT_LOADED = unchecked((int)(0xC029200F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_NO_KEY_CERTIFICATION"]/*' />
    [NativeTypeName("#define STATUS_PCP_NO_KEY_CERTIFICATION ((NTSTATUS)0xC0292010L)")]
    public const int STATUS_PCP_NO_KEY_CERTIFICATION = unchecked((int)(0xC0292010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_NOT_FINALIZED"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_NOT_FINALIZED ((NTSTATUS)0xC0292011L)")]
    public const int STATUS_PCP_KEY_NOT_FINALIZED = unchecked((int)(0xC0292011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_ATTESTATION_CHALLENGE_NOT_SET"]/*' />
    [NativeTypeName("#define STATUS_PCP_ATTESTATION_CHALLENGE_NOT_SET ((NTSTATUS)0xC0292012L)")]
    public const int STATUS_PCP_ATTESTATION_CHALLENGE_NOT_SET = unchecked((int)(0xC0292012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_NOT_PCR_BOUND"]/*' />
    [NativeTypeName("#define STATUS_PCP_NOT_PCR_BOUND ((NTSTATUS)0xC0292013L)")]
    public const int STATUS_PCP_NOT_PCR_BOUND = unchecked((int)(0xC0292013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_ALREADY_FINALIZED"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_ALREADY_FINALIZED ((NTSTATUS)0xC0292014L)")]
    public const int STATUS_PCP_KEY_ALREADY_FINALIZED = unchecked((int)(0xC0292014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_USAGE_POLICY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_USAGE_POLICY_NOT_SUPPORTED ((NTSTATUS)0xC0292015L)")]
    public const int STATUS_PCP_KEY_USAGE_POLICY_NOT_SUPPORTED = unchecked((int)(0xC0292015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_USAGE_POLICY_INVALID"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_USAGE_POLICY_INVALID ((NTSTATUS)0xC0292016L)")]
    public const int STATUS_PCP_KEY_USAGE_POLICY_INVALID = unchecked((int)(0xC0292016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_SOFT_KEY_ERROR"]/*' />
    [NativeTypeName("#define STATUS_PCP_SOFT_KEY_ERROR ((NTSTATUS)0xC0292017L)")]
    public const int STATUS_PCP_SOFT_KEY_ERROR = unchecked((int)(0xC0292017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_NOT_AUTHENTICATED"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_NOT_AUTHENTICATED ((NTSTATUS)0xC0292018L)")]
    public const int STATUS_PCP_KEY_NOT_AUTHENTICATED = unchecked((int)(0xC0292018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_NOT_AIK"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_NOT_AIK ((NTSTATUS)0xC0292019L)")]
    public const int STATUS_PCP_KEY_NOT_AIK = unchecked((int)(0xC0292019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_NOT_SIGNING_KEY"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_NOT_SIGNING_KEY ((NTSTATUS)0xC029201AL)")]
    public const int STATUS_PCP_KEY_NOT_SIGNING_KEY = unchecked((int)(0xC029201A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_LOCKED_OUT"]/*' />
    [NativeTypeName("#define STATUS_PCP_LOCKED_OUT ((NTSTATUS)0xC029201BL)")]
    public const int STATUS_PCP_LOCKED_OUT = unchecked((int)(0xC029201B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_CLAIM_TYPE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_PCP_CLAIM_TYPE_NOT_SUPPORTED ((NTSTATUS)0xC029201CL)")]
    public const int STATUS_PCP_CLAIM_TYPE_NOT_SUPPORTED = unchecked((int)(0xC029201C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_TPM_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_PCP_TPM_VERSION_NOT_SUPPORTED ((NTSTATUS)0xC029201DL)")]
    public const int STATUS_PCP_TPM_VERSION_NOT_SUPPORTED = unchecked((int)(0xC029201D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_BUFFER_LENGTH_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_PCP_BUFFER_LENGTH_MISMATCH ((NTSTATUS)0xC029201EL)")]
    public const int STATUS_PCP_BUFFER_LENGTH_MISMATCH = unchecked((int)(0xC029201E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_IFX_RSA_KEY_CREATION_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_PCP_IFX_RSA_KEY_CREATION_BLOCKED ((NTSTATUS)0xC029201FL)")]
    public const int STATUS_PCP_IFX_RSA_KEY_CREATION_BLOCKED = unchecked((int)(0xC029201F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_TICKET_MISSING"]/*' />
    [NativeTypeName("#define STATUS_PCP_TICKET_MISSING ((NTSTATUS)0xC0292020L)")]
    public const int STATUS_PCP_TICKET_MISSING = unchecked((int)(0xC0292020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_RAW_POLICY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_PCP_RAW_POLICY_NOT_SUPPORTED ((NTSTATUS)0xC0292021L)")]
    public const int STATUS_PCP_RAW_POLICY_NOT_SUPPORTED = unchecked((int)(0xC0292021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_KEY_HANDLE_INVALIDATED"]/*' />
    [NativeTypeName("#define STATUS_PCP_KEY_HANDLE_INVALIDATED ((NTSTATUS)0xC0292022L)")]
    public const int STATUS_PCP_KEY_HANDLE_INVALIDATED = unchecked((int)(0xC0292022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PCP_UNSUPPORTED_PSS_SALT"]/*' />
    [NativeTypeName("#define STATUS_PCP_UNSUPPORTED_PSS_SALT ((NTSTATUS)0x40292023L)")]
    public const int STATUS_PCP_UNSUPPORTED_PSS_SALT = ((int)(0x40292023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RTPM_CONTEXT_CONTINUE"]/*' />
    [NativeTypeName("#define STATUS_RTPM_CONTEXT_CONTINUE ((NTSTATUS)0x00293000L)")]
    public const int STATUS_RTPM_CONTEXT_CONTINUE = ((int)(0x00293000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RTPM_CONTEXT_COMPLETE"]/*' />
    [NativeTypeName("#define STATUS_RTPM_CONTEXT_COMPLETE ((NTSTATUS)0x00293001L)")]
    public const int STATUS_RTPM_CONTEXT_COMPLETE = ((int)(0x00293001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RTPM_NO_RESULT"]/*' />
    [NativeTypeName("#define STATUS_RTPM_NO_RESULT ((NTSTATUS)0xC0293002L)")]
    public const int STATUS_RTPM_NO_RESULT = unchecked((int)(0xC0293002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RTPM_PCR_READ_INCOMPLETE"]/*' />
    [NativeTypeName("#define STATUS_RTPM_PCR_READ_INCOMPLETE ((NTSTATUS)0xC0293003L)")]
    public const int STATUS_RTPM_PCR_READ_INCOMPLETE = unchecked((int)(0xC0293003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RTPM_INVALID_CONTEXT"]/*' />
    [NativeTypeName("#define STATUS_RTPM_INVALID_CONTEXT ((NTSTATUS)0xC0293004L)")]
    public const int STATUS_RTPM_INVALID_CONTEXT = unchecked((int)(0xC0293004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RTPM_UNSUPPORTED_CMD"]/*' />
    [NativeTypeName("#define STATUS_RTPM_UNSUPPORTED_CMD ((NTSTATUS)0xC0293005L)")]
    public const int STATUS_RTPM_UNSUPPORTED_CMD = unchecked((int)(0xC0293005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TPM_ZERO_EXHAUST_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_TPM_ZERO_EXHAUST_ENABLED ((NTSTATUS)0xC0294000L)")]
    public const int STATUS_TPM_ZERO_EXHAUST_ENABLED = unchecked((int)(0xC0294000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRTM_ENVIRONMENT_UNSAFE"]/*' />
    [NativeTypeName("#define STATUS_DRTM_ENVIRONMENT_UNSAFE ((NTSTATUS)0xC0295000L)")]
    public const int STATUS_DRTM_ENVIRONMENT_UNSAFE = unchecked((int)(0xC0295000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DRTM_NO_DIRECT_AUTH_FOR_CURRENT_MLE"]/*' />
    [NativeTypeName("#define STATUS_DRTM_NO_DIRECT_AUTH_FOR_CURRENT_MLE ((NTSTATUS)0xC0295001L)")]
    public const int STATUS_DRTM_NO_DIRECT_AUTH_FOR_CURRENT_MLE = unchecked((int)(0xC0295001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_HYPERCALL_CODE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_HYPERCALL_CODE ((NTSTATUS)0xC0350002L)")]
    public const int STATUS_HV_INVALID_HYPERCALL_CODE = unchecked((int)(0xC0350002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_HYPERCALL_INPUT"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_HYPERCALL_INPUT ((NTSTATUS)0xC0350003L)")]
    public const int STATUS_HV_INVALID_HYPERCALL_INPUT = unchecked((int)(0xC0350003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_ALIGNMENT"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_ALIGNMENT ((NTSTATUS)0xC0350004L)")]
    public const int STATUS_HV_INVALID_ALIGNMENT = unchecked((int)(0xC0350004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_PARAMETER ((NTSTATUS)0xC0350005L)")]
    public const int STATUS_HV_INVALID_PARAMETER = unchecked((int)(0xC0350005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_HV_ACCESS_DENIED ((NTSTATUS)0xC0350006L)")]
    public const int STATUS_HV_ACCESS_DENIED = unchecked((int)(0xC0350006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_PARTITION_STATE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_PARTITION_STATE ((NTSTATUS)0xC0350007L)")]
    public const int STATUS_HV_INVALID_PARTITION_STATE = unchecked((int)(0xC0350007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_OPERATION_DENIED"]/*' />
    [NativeTypeName("#define STATUS_HV_OPERATION_DENIED ((NTSTATUS)0xC0350008L)")]
    public const int STATUS_HV_OPERATION_DENIED = unchecked((int)(0xC0350008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_UNKNOWN_PROPERTY"]/*' />
    [NativeTypeName("#define STATUS_HV_UNKNOWN_PROPERTY ((NTSTATUS)0xC0350009L)")]
    public const int STATUS_HV_UNKNOWN_PROPERTY = unchecked((int)(0xC0350009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_PROPERTY_VALUE_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define STATUS_HV_PROPERTY_VALUE_OUT_OF_RANGE ((NTSTATUS)0xC035000AL)")]
    public const int STATUS_HV_PROPERTY_VALUE_OUT_OF_RANGE = unchecked((int)(0xC035000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_MEMORY"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_MEMORY ((NTSTATUS)0xC035000BL)")]
    public const int STATUS_HV_INSUFFICIENT_MEMORY = unchecked((int)(0xC035000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_PARTITION_TOO_DEEP"]/*' />
    [NativeTypeName("#define STATUS_HV_PARTITION_TOO_DEEP ((NTSTATUS)0xC035000CL)")]
    public const int STATUS_HV_PARTITION_TOO_DEEP = unchecked((int)(0xC035000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_PARTITION_ID"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_PARTITION_ID ((NTSTATUS)0xC035000DL)")]
    public const int STATUS_HV_INVALID_PARTITION_ID = unchecked((int)(0xC035000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_VP_INDEX"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_VP_INDEX ((NTSTATUS)0xC035000EL)")]
    public const int STATUS_HV_INVALID_VP_INDEX = unchecked((int)(0xC035000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_PORT_ID"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_PORT_ID ((NTSTATUS)0xC0350011L)")]
    public const int STATUS_HV_INVALID_PORT_ID = unchecked((int)(0xC0350011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_CONNECTION_ID"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_CONNECTION_ID ((NTSTATUS)0xC0350012L)")]
    public const int STATUS_HV_INVALID_CONNECTION_ID = unchecked((int)(0xC0350012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_BUFFERS"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_BUFFERS ((NTSTATUS)0xC0350013L)")]
    public const int STATUS_HV_INSUFFICIENT_BUFFERS = unchecked((int)(0xC0350013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_NOT_ACKNOWLEDGED"]/*' />
    [NativeTypeName("#define STATUS_HV_NOT_ACKNOWLEDGED ((NTSTATUS)0xC0350014L)")]
    public const int STATUS_HV_NOT_ACKNOWLEDGED = unchecked((int)(0xC0350014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_VP_STATE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_VP_STATE ((NTSTATUS)0xC0350015L)")]
    public const int STATUS_HV_INVALID_VP_STATE = unchecked((int)(0xC0350015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_ACKNOWLEDGED"]/*' />
    [NativeTypeName("#define STATUS_HV_ACKNOWLEDGED ((NTSTATUS)0xC0350016L)")]
    public const int STATUS_HV_ACKNOWLEDGED = unchecked((int)(0xC0350016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_SAVE_RESTORE_STATE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_SAVE_RESTORE_STATE ((NTSTATUS)0xC0350017L)")]
    public const int STATUS_HV_INVALID_SAVE_RESTORE_STATE = unchecked((int)(0xC0350017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_SYNIC_STATE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_SYNIC_STATE ((NTSTATUS)0xC0350018L)")]
    public const int STATUS_HV_INVALID_SYNIC_STATE = unchecked((int)(0xC0350018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_OBJECT_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_HV_OBJECT_IN_USE ((NTSTATUS)0xC0350019L)")]
    public const int STATUS_HV_OBJECT_IN_USE = unchecked((int)(0xC0350019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_PROXIMITY_DOMAIN_INFO"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_PROXIMITY_DOMAIN_INFO ((NTSTATUS)0xC035001AL)")]
    public const int STATUS_HV_INVALID_PROXIMITY_DOMAIN_INFO = unchecked((int)(0xC035001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_NO_DATA"]/*' />
    [NativeTypeName("#define STATUS_HV_NO_DATA ((NTSTATUS)0xC035001BL)")]
    public const int STATUS_HV_NO_DATA = unchecked((int)(0xC035001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INACTIVE"]/*' />
    [NativeTypeName("#define STATUS_HV_INACTIVE ((NTSTATUS)0xC035001CL)")]
    public const int STATUS_HV_INACTIVE = unchecked((int)(0xC035001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_NO_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_HV_NO_RESOURCES ((NTSTATUS)0xC035001DL)")]
    public const int STATUS_HV_NO_RESOURCES = unchecked((int)(0xC035001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_FEATURE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_HV_FEATURE_UNAVAILABLE ((NTSTATUS)0xC035001EL)")]
    public const int STATUS_HV_FEATURE_UNAVAILABLE = unchecked((int)(0xC035001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_BUFFER ((NTSTATUS)0xC0350033L)")]
    public const int STATUS_HV_INSUFFICIENT_BUFFER = unchecked((int)(0xC0350033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_DEVICE_DOMAINS"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_DEVICE_DOMAINS ((NTSTATUS)0xC0350038L)")]
    public const int STATUS_HV_INSUFFICIENT_DEVICE_DOMAINS = unchecked((int)(0xC0350038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_CPUID_FEATURE_VALIDATION_ERROR"]/*' />
    [NativeTypeName("#define STATUS_HV_CPUID_FEATURE_VALIDATION_ERROR ((NTSTATUS)0xC035003CL)")]
    public const int STATUS_HV_CPUID_FEATURE_VALIDATION_ERROR = unchecked((int)(0xC035003C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_CPUID_XSAVE_FEATURE_VALIDATION_ERROR"]/*' />
    [NativeTypeName("#define STATUS_HV_CPUID_XSAVE_FEATURE_VALIDATION_ERROR ((NTSTATUS)0xC035003DL)")]
    public const int STATUS_HV_CPUID_XSAVE_FEATURE_VALIDATION_ERROR = unchecked((int)(0xC035003D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_PROCESSOR_STARTUP_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_HV_PROCESSOR_STARTUP_TIMEOUT ((NTSTATUS)0xC035003EL)")]
    public const int STATUS_HV_PROCESSOR_STARTUP_TIMEOUT = unchecked((int)(0xC035003E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_SMX_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_HV_SMX_ENABLED ((NTSTATUS)0xC035003FL)")]
    public const int STATUS_HV_SMX_ENABLED = unchecked((int)(0xC035003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_LP_INDEX"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_LP_INDEX ((NTSTATUS)0xC0350041L)")]
    public const int STATUS_HV_INVALID_LP_INDEX = unchecked((int)(0xC0350041));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_REGISTER_VALUE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_REGISTER_VALUE ((NTSTATUS)0xC0350050L)")]
    public const int STATUS_HV_INVALID_REGISTER_VALUE = unchecked((int)(0xC0350050));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_VTL_STATE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_VTL_STATE ((NTSTATUS)0xC0350051L)")]
    public const int STATUS_HV_INVALID_VTL_STATE = unchecked((int)(0xC0350051));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_NX_NOT_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_HV_NX_NOT_DETECTED ((NTSTATUS)0xC0350055L)")]
    public const int STATUS_HV_NX_NOT_DETECTED = unchecked((int)(0xC0350055));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_DEVICE_ID"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_DEVICE_ID ((NTSTATUS)0xC0350057L)")]
    public const int STATUS_HV_INVALID_DEVICE_ID = unchecked((int)(0xC0350057));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_DEVICE_STATE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_DEVICE_STATE ((NTSTATUS)0xC0350058L)")]
    public const int STATUS_HV_INVALID_DEVICE_STATE = unchecked((int)(0xC0350058));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_PENDING_PAGE_REQUESTS"]/*' />
    [NativeTypeName("#define STATUS_HV_PENDING_PAGE_REQUESTS ((NTSTATUS)0x00350059L)")]
    public const int STATUS_HV_PENDING_PAGE_REQUESTS = ((int)(0x00350059));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_PAGE_REQUEST_INVALID"]/*' />
    [NativeTypeName("#define STATUS_HV_PAGE_REQUEST_INVALID ((NTSTATUS)0xC0350060L)")]
    public const int STATUS_HV_PAGE_REQUEST_INVALID = unchecked((int)(0xC0350060));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_DEVICE_ALREADY_IN_DOMAIN"]/*' />
    [NativeTypeName("#define STATUS_HV_DEVICE_ALREADY_IN_DOMAIN ((NTSTATUS)0xC0350066L)")]
    public const int STATUS_HV_DEVICE_ALREADY_IN_DOMAIN = unchecked((int)(0xC0350066));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_CPU_GROUP_ID"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_CPU_GROUP_ID ((NTSTATUS)0xC035006FL)")]
    public const int STATUS_HV_INVALID_CPU_GROUP_ID = unchecked((int)(0xC035006F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INVALID_CPU_GROUP_STATE"]/*' />
    [NativeTypeName("#define STATUS_HV_INVALID_CPU_GROUP_STATE ((NTSTATUS)0xC0350070L)")]
    public const int STATUS_HV_INVALID_CPU_GROUP_STATE = unchecked((int)(0xC0350070));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_OPERATION_FAILED"]/*' />
    [NativeTypeName("#define STATUS_HV_OPERATION_FAILED ((NTSTATUS)0xC0350071L)")]
    public const int STATUS_HV_OPERATION_FAILED = unchecked((int)(0xC0350071));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE ((NTSTATUS)0xC0350072L)")]
    public const int STATUS_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE = unchecked((int)(0xC0350072));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_ROOT_MEMORY"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_ROOT_MEMORY ((NTSTATUS)0xC0350073L)")]
    public const int STATUS_HV_INSUFFICIENT_ROOT_MEMORY = unchecked((int)(0xC0350073));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_EVENT_BUFFER_ALREADY_FREED"]/*' />
    [NativeTypeName("#define STATUS_HV_EVENT_BUFFER_ALREADY_FREED ((NTSTATUS)0xC0350074L)")]
    public const int STATUS_HV_EVENT_BUFFER_ALREADY_FREED = unchecked((int)(0xC0350074));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_CONTIGUOUS_MEMORY"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_CONTIGUOUS_MEMORY ((NTSTATUS)0xC0350075L)")]
    public const int STATUS_HV_INSUFFICIENT_CONTIGUOUS_MEMORY = unchecked((int)(0xC0350075));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_DEVICE_NOT_IN_DOMAIN"]/*' />
    [NativeTypeName("#define STATUS_HV_DEVICE_NOT_IN_DOMAIN ((NTSTATUS)0xC0350076L)")]
    public const int STATUS_HV_DEVICE_NOT_IN_DOMAIN = unchecked((int)(0xC0350076));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_NESTED_VM_EXIT"]/*' />
    [NativeTypeName("#define STATUS_HV_NESTED_VM_EXIT ((NTSTATUS)0xC0350077L)")]
    public const int STATUS_HV_NESTED_VM_EXIT = unchecked((int)(0xC0350077));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_CALL_PENDING"]/*' />
    [NativeTypeName("#define STATUS_HV_CALL_PENDING ((NTSTATUS)0xC0350079L)")]
    public const int STATUS_HV_CALL_PENDING = unchecked((int)(0xC0350079));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_MSR_ACCESS_FAILED"]/*' />
    [NativeTypeName("#define STATUS_HV_MSR_ACCESS_FAILED ((NTSTATUS)0xC0350080L)")]
    public const int STATUS_HV_MSR_ACCESS_FAILED = unchecked((int)(0xC0350080));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_MEMORY_MIRRORING"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_MEMORY_MIRRORING ((NTSTATUS)0xC0350081L)")]
    public const int STATUS_HV_INSUFFICIENT_MEMORY_MIRRORING = unchecked((int)(0xC0350081));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_CONTIGUOUS_MEMORY_MIRRORING"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_CONTIGUOUS_MEMORY_MIRRORING ((NTSTATUS)0xC0350082L)")]
    public const int STATUS_HV_INSUFFICIENT_CONTIGUOUS_MEMORY_MIRRORING = unchecked((int)(0xC0350082));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY ((NTSTATUS)0xC0350083L)")]
    public const int STATUS_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY = unchecked((int)(0xC0350083));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_ROOT_MEMORY_MIRRORING"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_ROOT_MEMORY_MIRRORING ((NTSTATUS)0xC0350084L)")]
    public const int STATUS_HV_INSUFFICIENT_ROOT_MEMORY_MIRRORING = unchecked((int)(0xC0350084));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY_MIRRORING"]/*' />
    [NativeTypeName("#define STATUS_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY_MIRRORING ((NTSTATUS)0xC0350085L)")]
    public const int STATUS_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY_MIRRORING = unchecked((int)(0xC0350085));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_VTL_ALREADY_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_HV_VTL_ALREADY_ENABLED ((NTSTATUS)0xC0350086L)")]
    public const int STATUS_HV_VTL_ALREADY_ENABLED = unchecked((int)(0xC0350086));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_SPDM_REQUEST"]/*' />
    [NativeTypeName("#define STATUS_HV_SPDM_REQUEST ((NTSTATUS)0xC0350088L)")]
    public const int STATUS_HV_SPDM_REQUEST = unchecked((int)(0xC0350088));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HV_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_HV_NOT_PRESENT ((NTSTATUS)0xC0351000L)")]
    public const int STATUS_HV_NOT_PRESENT = unchecked((int)(0xC0351000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_DUPLICATE_HANDLER"]/*' />
    [NativeTypeName("#define STATUS_VID_DUPLICATE_HANDLER ((NTSTATUS)0xC0370001L)")]
    public const int STATUS_VID_DUPLICATE_HANDLER = unchecked((int)(0xC0370001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_TOO_MANY_HANDLERS"]/*' />
    [NativeTypeName("#define STATUS_VID_TOO_MANY_HANDLERS ((NTSTATUS)0xC0370002L)")]
    public const int STATUS_VID_TOO_MANY_HANDLERS = unchecked((int)(0xC0370002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_QUEUE_FULL"]/*' />
    [NativeTypeName("#define STATUS_VID_QUEUE_FULL ((NTSTATUS)0xC0370003L)")]
    public const int STATUS_VID_QUEUE_FULL = unchecked((int)(0xC0370003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_HANDLER_NOT_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_VID_HANDLER_NOT_PRESENT ((NTSTATUS)0xC0370004L)")]
    public const int STATUS_VID_HANDLER_NOT_PRESENT = unchecked((int)(0xC0370004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_OBJECT_NAME"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_OBJECT_NAME ((NTSTATUS)0xC0370005L)")]
    public const int STATUS_VID_INVALID_OBJECT_NAME = unchecked((int)(0xC0370005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_PARTITION_NAME_TOO_LONG"]/*' />
    [NativeTypeName("#define STATUS_VID_PARTITION_NAME_TOO_LONG ((NTSTATUS)0xC0370006L)")]
    public const int STATUS_VID_PARTITION_NAME_TOO_LONG = unchecked((int)(0xC0370006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MESSAGE_QUEUE_NAME_TOO_LONG"]/*' />
    [NativeTypeName("#define STATUS_VID_MESSAGE_QUEUE_NAME_TOO_LONG ((NTSTATUS)0xC0370007L)")]
    public const int STATUS_VID_MESSAGE_QUEUE_NAME_TOO_LONG = unchecked((int)(0xC0370007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_PARTITION_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_VID_PARTITION_ALREADY_EXISTS ((NTSTATUS)0xC0370008L)")]
    public const int STATUS_VID_PARTITION_ALREADY_EXISTS = unchecked((int)(0xC0370008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_PARTITION_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define STATUS_VID_PARTITION_DOES_NOT_EXIST ((NTSTATUS)0xC0370009L)")]
    public const int STATUS_VID_PARTITION_DOES_NOT_EXIST = unchecked((int)(0xC0370009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_PARTITION_NAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_VID_PARTITION_NAME_NOT_FOUND ((NTSTATUS)0xC037000AL)")]
    public const int STATUS_VID_PARTITION_NAME_NOT_FOUND = unchecked((int)(0xC037000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MESSAGE_QUEUE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define STATUS_VID_MESSAGE_QUEUE_ALREADY_EXISTS ((NTSTATUS)0xC037000BL)")]
    public const int STATUS_VID_MESSAGE_QUEUE_ALREADY_EXISTS = unchecked((int)(0xC037000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT ((NTSTATUS)0xC037000CL)")]
    public const int STATUS_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT = unchecked((int)(0xC037000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MB_STILL_REFERENCED"]/*' />
    [NativeTypeName("#define STATUS_VID_MB_STILL_REFERENCED ((NTSTATUS)0xC037000DL)")]
    public const int STATUS_VID_MB_STILL_REFERENCED = unchecked((int)(0xC037000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_CHILD_GPA_PAGE_SET_CORRUPTED"]/*' />
    [NativeTypeName("#define STATUS_VID_CHILD_GPA_PAGE_SET_CORRUPTED ((NTSTATUS)0xC037000EL)")]
    public const int STATUS_VID_CHILD_GPA_PAGE_SET_CORRUPTED = unchecked((int)(0xC037000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_NUMA_SETTINGS"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_NUMA_SETTINGS ((NTSTATUS)0xC037000FL)")]
    public const int STATUS_VID_INVALID_NUMA_SETTINGS = unchecked((int)(0xC037000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_NUMA_NODE_INDEX"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_NUMA_NODE_INDEX ((NTSTATUS)0xC0370010L)")]
    public const int STATUS_VID_INVALID_NUMA_NODE_INDEX = unchecked((int)(0xC0370010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED"]/*' />
    [NativeTypeName("#define STATUS_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED ((NTSTATUS)0xC0370011L)")]
    public const int STATUS_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED = unchecked((int)(0xC0370011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_MEMORY_BLOCK_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_MEMORY_BLOCK_HANDLE ((NTSTATUS)0xC0370012L)")]
    public const int STATUS_VID_INVALID_MEMORY_BLOCK_HANDLE = unchecked((int)(0xC0370012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_PAGE_RANGE_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_VID_PAGE_RANGE_OVERFLOW ((NTSTATUS)0xC0370013L)")]
    public const int STATUS_VID_PAGE_RANGE_OVERFLOW = unchecked((int)(0xC0370013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_MESSAGE_QUEUE_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_MESSAGE_QUEUE_HANDLE ((NTSTATUS)0xC0370014L)")]
    public const int STATUS_VID_INVALID_MESSAGE_QUEUE_HANDLE = unchecked((int)(0xC0370014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_GPA_RANGE_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_GPA_RANGE_HANDLE ((NTSTATUS)0xC0370015L)")]
    public const int STATUS_VID_INVALID_GPA_RANGE_HANDLE = unchecked((int)(0xC0370015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE"]/*' />
    [NativeTypeName("#define STATUS_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE ((NTSTATUS)0xC0370016L)")]
    public const int STATUS_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE = unchecked((int)(0xC0370016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED ((NTSTATUS)0xC0370017L)")]
    public const int STATUS_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED = unchecked((int)(0xC0370017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_PPM_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_PPM_HANDLE ((NTSTATUS)0xC0370018L)")]
    public const int STATUS_VID_INVALID_PPM_HANDLE = unchecked((int)(0xC0370018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MBPS_ARE_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_VID_MBPS_ARE_LOCKED ((NTSTATUS)0xC0370019L)")]
    public const int STATUS_VID_MBPS_ARE_LOCKED = unchecked((int)(0xC0370019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MESSAGE_QUEUE_CLOSED"]/*' />
    [NativeTypeName("#define STATUS_VID_MESSAGE_QUEUE_CLOSED ((NTSTATUS)0xC037001AL)")]
    public const int STATUS_VID_MESSAGE_QUEUE_CLOSED = unchecked((int)(0xC037001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED ((NTSTATUS)0xC037001BL)")]
    public const int STATUS_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED = unchecked((int)(0xC037001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_STOP_PENDING"]/*' />
    [NativeTypeName("#define STATUS_VID_STOP_PENDING ((NTSTATUS)0xC037001CL)")]
    public const int STATUS_VID_STOP_PENDING = unchecked((int)(0xC037001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_PROCESSOR_STATE"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_PROCESSOR_STATE ((NTSTATUS)0xC037001DL)")]
    public const int STATUS_VID_INVALID_PROCESSOR_STATE = unchecked((int)(0xC037001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT ((NTSTATUS)0xC037001EL)")]
    public const int STATUS_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT = unchecked((int)(0xC037001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KM_INTERFACE_ALREADY_INITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_VID_KM_INTERFACE_ALREADY_INITIALIZED ((NTSTATUS)0xC037001FL)")]
    public const int STATUS_VID_KM_INTERFACE_ALREADY_INITIALIZED = unchecked((int)(0xC037001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MB_PROPERTY_ALREADY_SET_RESET"]/*' />
    [NativeTypeName("#define STATUS_VID_MB_PROPERTY_ALREADY_SET_RESET ((NTSTATUS)0xC0370020L)")]
    public const int STATUS_VID_MB_PROPERTY_ALREADY_SET_RESET = unchecked((int)(0xC0370020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MMIO_RANGE_DESTROYED"]/*' />
    [NativeTypeName("#define STATUS_VID_MMIO_RANGE_DESTROYED ((NTSTATUS)0xC0370021L)")]
    public const int STATUS_VID_MMIO_RANGE_DESTROYED = unchecked((int)(0xC0370021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INVALID_CHILD_GPA_PAGE_SET"]/*' />
    [NativeTypeName("#define STATUS_VID_INVALID_CHILD_GPA_PAGE_SET ((NTSTATUS)0xC0370022L)")]
    public const int STATUS_VID_INVALID_CHILD_GPA_PAGE_SET = unchecked((int)(0xC0370022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_RESERVE_PAGE_SET_IS_BEING_USED"]/*' />
    [NativeTypeName("#define STATUS_VID_RESERVE_PAGE_SET_IS_BEING_USED ((NTSTATUS)0xC0370023L)")]
    public const int STATUS_VID_RESERVE_PAGE_SET_IS_BEING_USED = unchecked((int)(0xC0370023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_RESERVE_PAGE_SET_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_VID_RESERVE_PAGE_SET_TOO_SMALL ((NTSTATUS)0xC0370024L)")]
    public const int STATUS_VID_RESERVE_PAGE_SET_TOO_SMALL = unchecked((int)(0xC0370024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE"]/*' />
    [NativeTypeName("#define STATUS_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE ((NTSTATUS)0xC0370025L)")]
    public const int STATUS_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE = unchecked((int)(0xC0370025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MBP_COUNT_EXCEEDED_LIMIT"]/*' />
    [NativeTypeName("#define STATUS_VID_MBP_COUNT_EXCEEDED_LIMIT ((NTSTATUS)0xC0370026L)")]
    public const int STATUS_VID_MBP_COUNT_EXCEEDED_LIMIT = unchecked((int)(0xC0370026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_SAVED_STATE_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_VID_SAVED_STATE_CORRUPT ((NTSTATUS)0xC0370027L)")]
    public const int STATUS_VID_SAVED_STATE_CORRUPT = unchecked((int)(0xC0370027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_SAVED_STATE_UNRECOGNIZED_ITEM"]/*' />
    [NativeTypeName("#define STATUS_VID_SAVED_STATE_UNRECOGNIZED_ITEM ((NTSTATUS)0xC0370028L)")]
    public const int STATUS_VID_SAVED_STATE_UNRECOGNIZED_ITEM = unchecked((int)(0xC0370028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_SAVED_STATE_INCOMPATIBLE"]/*' />
    [NativeTypeName("#define STATUS_VID_SAVED_STATE_INCOMPATIBLE ((NTSTATUS)0xC0370029L)")]
    public const int STATUS_VID_SAVED_STATE_INCOMPATIBLE = unchecked((int)(0xC0370029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_VTL_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_VID_VTL_ACCESS_DENIED ((NTSTATUS)0xC037002AL)")]
    public const int STATUS_VID_VTL_ACCESS_DENIED = unchecked((int)(0xC037002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INSUFFICIENT_RESOURCES_RESERVE"]/*' />
    [NativeTypeName("#define STATUS_VID_INSUFFICIENT_RESOURCES_RESERVE ((NTSTATUS)0xC037002BL)")]
    public const int STATUS_VID_INSUFFICIENT_RESOURCES_RESERVE = unchecked((int)(0xC037002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INSUFFICIENT_RESOURCES_PHYSICAL_BUFFER"]/*' />
    [NativeTypeName("#define STATUS_VID_INSUFFICIENT_RESOURCES_PHYSICAL_BUFFER ((NTSTATUS)0xC037002CL)")]
    public const int STATUS_VID_INSUFFICIENT_RESOURCES_PHYSICAL_BUFFER = unchecked((int)(0xC037002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INSUFFICIENT_RESOURCES_HV_DEPOSIT"]/*' />
    [NativeTypeName("#define STATUS_VID_INSUFFICIENT_RESOURCES_HV_DEPOSIT ((NTSTATUS)0xC037002DL)")]
    public const int STATUS_VID_INSUFFICIENT_RESOURCES_HV_DEPOSIT = unchecked((int)(0xC037002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MEMORY_TYPE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_VID_MEMORY_TYPE_NOT_SUPPORTED ((NTSTATUS)0xC037002EL)")]
    public const int STATUS_VID_MEMORY_TYPE_NOT_SUPPORTED = unchecked((int)(0xC037002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_INSUFFICIENT_RESOURCES_WITHDRAW"]/*' />
    [NativeTypeName("#define STATUS_VID_INSUFFICIENT_RESOURCES_WITHDRAW ((NTSTATUS)0xC037002FL)")]
    public const int STATUS_VID_INSUFFICIENT_RESOURCES_WITHDRAW = unchecked((int)(0xC037002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_PROCESS_ALREADY_SET"]/*' />
    [NativeTypeName("#define STATUS_VID_PROCESS_ALREADY_SET ((NTSTATUS)0xC0370030L)")]
    public const int STATUS_VID_PROCESS_ALREADY_SET = unchecked((int)(0xC0370030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_PARTITION_INVARIANTS_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_PARTITION_INVARIANTS_MISMATCH ((NTSTATUS)0xC0370031L)")]
    public const int STATUS_VID_PARTITION_INVARIANTS_MISMATCH = unchecked((int)(0xC0370031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MEMORY_BLOCK_INVARIANTS_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_MEMORY_BLOCK_INVARIANTS_MISMATCH ((NTSTATUS)0xC0370032L)")]
    public const int STATUS_VID_MEMORY_BLOCK_INVARIANTS_MISMATCH = unchecked((int)(0xC0370032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MEMORY_BLOCK_RESTORE_STATE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_MEMORY_BLOCK_RESTORE_STATE_MISMATCH ((NTSTATUS)0xC0370033L)")]
    public const int STATUS_VID_MEMORY_BLOCK_RESTORE_STATE_MISMATCH = unchecked((int)(0xC0370033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_PERSISTED_ITEMS_STILL_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_PERSISTED_ITEMS_STILL_REGISTERED ((NTSTATUS)0xC0370034L)")]
    public const int STATUS_VID_KSR_PERSISTED_ITEMS_STILL_REGISTERED = unchecked((int)(0xC0370034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MEMORY_PARTITION_SETUP_FAILED"]/*' />
    [NativeTypeName("#define STATUS_VID_MEMORY_PARTITION_SETUP_FAILED ((NTSTATUS)0xC0370035L)")]
    public const int STATUS_VID_MEMORY_PARTITION_SETUP_FAILED = unchecked((int)(0xC0370035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MEMORY_RESERVE_NOT_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_VID_MEMORY_RESERVE_NOT_ENABLED ((NTSTATUS)0xC0370036L)")]
    public const int STATUS_VID_MEMORY_RESERVE_NOT_ENABLED = unchecked((int)(0xC0370036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MEMORY_BLOCK_PAGECOUNT_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_MEMORY_BLOCK_PAGECOUNT_MISMATCH ((NTSTATUS)0xC0370037L)")]
    public const int STATUS_VID_MEMORY_BLOCK_PAGECOUNT_MISMATCH = unchecked((int)(0xC0370037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_IOHANDLER_PROPERTY_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_IOHANDLER_PROPERTY_MISMATCH ((NTSTATUS)0xC0370038L)")]
    public const int STATUS_VID_KSR_IOHANDLER_PROPERTY_MISMATCH = unchecked((int)(0xC0370038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_MSR_HANDLER_PROPERTY_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_MSR_HANDLER_PROPERTY_MISMATCH ((NTSTATUS)0xC0370039L)")]
    public const int STATUS_VID_KSR_MSR_HANDLER_PROPERTY_MISMATCH = unchecked((int)(0xC0370039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_MEMORY_PARTITION_STATE_SIZE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_MEMORY_PARTITION_STATE_SIZE_MISMATCH ((NTSTATUS)0xC037003AL)")]
    public const int STATUS_VID_KSR_MEMORY_PARTITION_STATE_SIZE_MISMATCH = unchecked((int)(0xC037003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_METADATA_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_METADATA_MISMATCH ((NTSTATUS)0xC037003BL)")]
    public const int STATUS_VID_KSR_METADATA_MISMATCH = unchecked((int)(0xC037003B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_TOTAL_PAGE_COUNT_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_TOTAL_PAGE_COUNT_MISMATCH ((NTSTATUS)0xC037003CL)")]
    public const int STATUS_VID_KSR_TOTAL_PAGE_COUNT_MISMATCH = unchecked((int)(0xC037003C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MBP_ARRAY_NOT_PERSISTED"]/*' />
    [NativeTypeName("#define STATUS_VID_MBP_ARRAY_NOT_PERSISTED ((NTSTATUS)0xC037003DL)")]
    public const int STATUS_VID_MBP_ARRAY_NOT_PERSISTED = unchecked((int)(0xC037003D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_INVALID_PERSIST_ID"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_INVALID_PERSIST_ID ((NTSTATUS)0xC037003EL)")]
    public const int STATUS_VID_KSR_INVALID_PERSIST_ID = unchecked((int)(0xC037003E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_INVALID_PERSISTENCE_OPTIONS"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_INVALID_PERSISTENCE_OPTIONS ((NTSTATUS)0xC037003FL)")]
    public const int STATUS_VID_KSR_INVALID_PERSISTENCE_OPTIONS = unchecked((int)(0xC037003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_GPA_RANGE_INVALID_FLAGS"]/*' />
    [NativeTypeName("#define STATUS_VID_GPA_RANGE_INVALID_FLAGS ((NTSTATUS)0xC0370040L)")]
    public const int STATUS_VID_GPA_RANGE_INVALID_FLAGS = unchecked((int)(0xC0370040));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_MEMORY_BLOCK_INVALID_FLAGS"]/*' />
    [NativeTypeName("#define STATUS_VID_MEMORY_BLOCK_INVALID_FLAGS ((NTSTATUS)0xC0370041L)")]
    public const int STATUS_VID_MEMORY_BLOCK_INVALID_FLAGS = unchecked((int)(0xC0370041));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_ALREADY_PERSISTED"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_ALREADY_PERSISTED ((NTSTATUS)0xC0370042L)")]
    public const int STATUS_VID_KSR_ALREADY_PERSISTED = unchecked((int)(0xC0370042));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_ALREADY_UNPERSISTED"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_ALREADY_UNPERSISTED ((NTSTATUS)0xC0370043L)")]
    public const int STATUS_VID_KSR_ALREADY_UNPERSISTED = unchecked((int)(0xC0370043));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_PERSISTENCE_DISALLOWED"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_PERSISTENCE_DISALLOWED ((NTSTATUS)0xC0370044L)")]
    public const int STATUS_VID_KSR_PERSISTENCE_DISALLOWED = unchecked((int)(0xC0370044));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_CLIENT_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_CLIENT_TYPE_MISMATCH ((NTSTATUS)0xC0370045L)")]
    public const int STATUS_VID_KSR_CLIENT_TYPE_MISMATCH = unchecked((int)(0xC0370045));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_INVALID_STATE"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_INVALID_STATE ((NTSTATUS)0xC0370046L)")]
    public const int STATUS_VID_KSR_INVALID_STATE = unchecked((int)(0xC0370046));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_NOT_READY ((NTSTATUS)0xC0370047L)")]
    public const int STATUS_VID_KSR_NOT_READY = unchecked((int)(0xC0370047));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_GPA_RANGE_OVERLAP_PROHIBITED"]/*' />
    [NativeTypeName("#define STATUS_VID_GPA_RANGE_OVERLAP_PROHIBITED ((NTSTATUS)0xC0370048L)")]
    public const int STATUS_VID_GPA_RANGE_OVERLAP_PROHIBITED = unchecked((int)(0xC0370048));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_PARTITION_NOT_HIERARCHICAL_HOST"]/*' />
    [NativeTypeName("#define STATUS_VID_PARTITION_NOT_HIERARCHICAL_HOST ((NTSTATUS)0xC0370049L)")]
    public const int STATUS_VID_PARTITION_NOT_HIERARCHICAL_HOST = unchecked((int)(0xC0370049));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_GPA_RANGE_INVARIANTS_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_GPA_RANGE_INVARIANTS_MISMATCH ((NTSTATUS)0xC037004AL)")]
    public const int STATUS_VID_GPA_RANGE_INVARIANTS_MISMATCH = unchecked((int)(0xC037004A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_KSR_PSCI_HANDLER_PROPERTY_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VID_KSR_PSCI_HANDLER_PROPERTY_MISMATCH ((NTSTATUS)0xC037004BL)")]
    public const int STATUS_VID_KSR_PSCI_HANDLER_PROPERTY_MISMATCH = unchecked((int)(0xC037004B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DM_OPERATION_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_DM_OPERATION_LIMIT_EXCEEDED ((NTSTATUS)0xC0370600L)")]
    public const int STATUS_DM_OPERATION_LIMIT_EXCEEDED = unchecked((int)(0xC0370600));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED"]/*' />
    [NativeTypeName("#define STATUS_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED ((NTSTATUS)0x80370001L)")]
    public const int STATUS_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED = unchecked((int)(0x80370001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_BAD_SPI"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_BAD_SPI ((NTSTATUS)0xC0360001L)")]
    public const int STATUS_IPSEC_BAD_SPI = unchecked((int)(0xC0360001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_SA_LIFETIME_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_SA_LIFETIME_EXPIRED ((NTSTATUS)0xC0360002L)")]
    public const int STATUS_IPSEC_SA_LIFETIME_EXPIRED = unchecked((int)(0xC0360002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_WRONG_SA"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_WRONG_SA ((NTSTATUS)0xC0360003L)")]
    public const int STATUS_IPSEC_WRONG_SA = unchecked((int)(0xC0360003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_REPLAY_CHECK_FAILED"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_REPLAY_CHECK_FAILED ((NTSTATUS)0xC0360004L)")]
    public const int STATUS_IPSEC_REPLAY_CHECK_FAILED = unchecked((int)(0xC0360004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_INVALID_PACKET"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_INVALID_PACKET ((NTSTATUS)0xC0360005L)")]
    public const int STATUS_IPSEC_INVALID_PACKET = unchecked((int)(0xC0360005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_INTEGRITY_CHECK_FAILED"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_INTEGRITY_CHECK_FAILED ((NTSTATUS)0xC0360006L)")]
    public const int STATUS_IPSEC_INTEGRITY_CHECK_FAILED = unchecked((int)(0xC0360006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_CLEAR_TEXT_DROP"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_CLEAR_TEXT_DROP ((NTSTATUS)0xC0360007L)")]
    public const int STATUS_IPSEC_CLEAR_TEXT_DROP = unchecked((int)(0xC0360007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_AUTH_FIREWALL_DROP"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_AUTH_FIREWALL_DROP ((NTSTATUS)0xC0360008L)")]
    public const int STATUS_IPSEC_AUTH_FIREWALL_DROP = unchecked((int)(0xC0360008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_THROTTLE_DROP"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_THROTTLE_DROP ((NTSTATUS)0xC0360009L)")]
    public const int STATUS_IPSEC_THROTTLE_DROP = unchecked((int)(0xC0360009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_DOSP_BLOCK"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_DOSP_BLOCK ((NTSTATUS)0xC0368000L)")]
    public const int STATUS_IPSEC_DOSP_BLOCK = unchecked((int)(0xC0368000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_DOSP_RECEIVED_MULTICAST"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_DOSP_RECEIVED_MULTICAST ((NTSTATUS)0xC0368001L)")]
    public const int STATUS_IPSEC_DOSP_RECEIVED_MULTICAST = unchecked((int)(0xC0368001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_DOSP_INVALID_PACKET"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_DOSP_INVALID_PACKET ((NTSTATUS)0xC0368002L)")]
    public const int STATUS_IPSEC_DOSP_INVALID_PACKET = unchecked((int)(0xC0368002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_DOSP_STATE_LOOKUP_FAILED"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_DOSP_STATE_LOOKUP_FAILED ((NTSTATUS)0xC0368003L)")]
    public const int STATUS_IPSEC_DOSP_STATE_LOOKUP_FAILED = unchecked((int)(0xC0368003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_DOSP_MAX_ENTRIES"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_DOSP_MAX_ENTRIES ((NTSTATUS)0xC0368004L)")]
    public const int STATUS_IPSEC_DOSP_MAX_ENTRIES = unchecked((int)(0xC0368004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_DOSP_KEYMOD_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_DOSP_KEYMOD_NOT_ALLOWED ((NTSTATUS)0xC0368005L)")]
    public const int STATUS_IPSEC_DOSP_KEYMOD_NOT_ALLOWED = unchecked((int)(0xC0368005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES"]/*' />
    [NativeTypeName("#define STATUS_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES ((NTSTATUS)0xC0368006L)")]
    public const int STATUS_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES = unchecked((int)(0xC0368006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_INCOMPLETE_REGENERATION"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_INCOMPLETE_REGENERATION ((NTSTATUS)0x80380001L)")]
    public const int STATUS_VOLMGR_INCOMPLETE_REGENERATION = unchecked((int)(0x80380001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_INCOMPLETE_DISK_MIGRATION"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_INCOMPLETE_DISK_MIGRATION ((NTSTATUS)0x80380002L)")]
    public const int STATUS_VOLMGR_INCOMPLETE_DISK_MIGRATION = unchecked((int)(0x80380002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DATABASE_FULL"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DATABASE_FULL ((NTSTATUS)0xC0380001L)")]
    public const int STATUS_VOLMGR_DATABASE_FULL = unchecked((int)(0xC0380001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_CONFIGURATION_CORRUPTED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_CONFIGURATION_CORRUPTED ((NTSTATUS)0xC0380002L)")]
    public const int STATUS_VOLMGR_DISK_CONFIGURATION_CORRUPTED = unchecked((int)(0xC0380002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC ((NTSTATUS)0xC0380003L)")]
    public const int STATUS_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC = unchecked((int)(0xC0380003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_CONFIG_UPDATE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_CONFIG_UPDATE_FAILED ((NTSTATUS)0xC0380004L)")]
    public const int STATUS_VOLMGR_PACK_CONFIG_UPDATE_FAILED = unchecked((int)(0xC0380004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME ((NTSTATUS)0xC0380005L)")]
    public const int STATUS_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME = unchecked((int)(0xC0380005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_DUPLICATE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_DUPLICATE ((NTSTATUS)0xC0380006L)")]
    public const int STATUS_VOLMGR_DISK_DUPLICATE = unchecked((int)(0xC0380006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_DYNAMIC"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_DYNAMIC ((NTSTATUS)0xC0380007L)")]
    public const int STATUS_VOLMGR_DISK_DYNAMIC = unchecked((int)(0xC0380007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_ID_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_ID_INVALID ((NTSTATUS)0xC0380008L)")]
    public const int STATUS_VOLMGR_DISK_ID_INVALID = unchecked((int)(0xC0380008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_INVALID ((NTSTATUS)0xC0380009L)")]
    public const int STATUS_VOLMGR_DISK_INVALID = unchecked((int)(0xC0380009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_LAST_VOTER"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_LAST_VOTER ((NTSTATUS)0xC038000AL)")]
    public const int STATUS_VOLMGR_DISK_LAST_VOTER = unchecked((int)(0xC038000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_LAYOUT_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_LAYOUT_INVALID ((NTSTATUS)0xC038000BL)")]
    public const int STATUS_VOLMGR_DISK_LAYOUT_INVALID = unchecked((int)(0xC038000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS ((NTSTATUS)0xC038000CL)")]
    public const int STATUS_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS = unchecked((int)(0xC038000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED ((NTSTATUS)0xC038000DL)")]
    public const int STATUS_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED = unchecked((int)(0xC038000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL ((NTSTATUS)0xC038000EL)")]
    public const int STATUS_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL = unchecked((int)(0xC038000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS ((NTSTATUS)0xC038000FL)")]
    public const int STATUS_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS = unchecked((int)(0xC038000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS ((NTSTATUS)0xC0380010L)")]
    public const int STATUS_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS = unchecked((int)(0xC0380010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_MISSING"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_MISSING ((NTSTATUS)0xC0380011L)")]
    public const int STATUS_VOLMGR_DISK_MISSING = unchecked((int)(0xC0380011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_NOT_EMPTY"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_NOT_EMPTY ((NTSTATUS)0xC0380012L)")]
    public const int STATUS_VOLMGR_DISK_NOT_EMPTY = unchecked((int)(0xC0380012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_NOT_ENOUGH_SPACE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_NOT_ENOUGH_SPACE ((NTSTATUS)0xC0380013L)")]
    public const int STATUS_VOLMGR_DISK_NOT_ENOUGH_SPACE = unchecked((int)(0xC0380013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_REVECTORING_FAILED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_REVECTORING_FAILED ((NTSTATUS)0xC0380014L)")]
    public const int STATUS_VOLMGR_DISK_REVECTORING_FAILED = unchecked((int)(0xC0380014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_SECTOR_SIZE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_SECTOR_SIZE_INVALID ((NTSTATUS)0xC0380015L)")]
    public const int STATUS_VOLMGR_DISK_SECTOR_SIZE_INVALID = unchecked((int)(0xC0380015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_SET_NOT_CONTAINED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_SET_NOT_CONTAINED ((NTSTATUS)0xC0380016L)")]
    public const int STATUS_VOLMGR_DISK_SET_NOT_CONTAINED = unchecked((int)(0xC0380016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS ((NTSTATUS)0xC0380017L)")]
    public const int STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS = unchecked((int)(0xC0380017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES ((NTSTATUS)0xC0380018L)")]
    public const int STATUS_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES = unchecked((int)(0xC0380018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED ((NTSTATUS)0xC0380019L)")]
    public const int STATUS_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED = unchecked((int)(0xC0380019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_EXTENT_ALREADY_USED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_EXTENT_ALREADY_USED ((NTSTATUS)0xC038001AL)")]
    public const int STATUS_VOLMGR_EXTENT_ALREADY_USED = unchecked((int)(0xC038001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_EXTENT_NOT_CONTIGUOUS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_EXTENT_NOT_CONTIGUOUS ((NTSTATUS)0xC038001BL)")]
    public const int STATUS_VOLMGR_EXTENT_NOT_CONTIGUOUS = unchecked((int)(0xC038001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION ((NTSTATUS)0xC038001CL)")]
    public const int STATUS_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION = unchecked((int)(0xC038001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED ((NTSTATUS)0xC038001DL)")]
    public const int STATUS_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED = unchecked((int)(0xC038001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION ((NTSTATUS)0xC038001EL)")]
    public const int STATUS_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION = unchecked((int)(0xC038001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH ((NTSTATUS)0xC038001FL)")]
    public const int STATUS_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH = unchecked((int)(0xC038001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED ((NTSTATUS)0xC0380020L)")]
    public const int STATUS_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED = unchecked((int)(0xC0380020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_INTERLEAVE_LENGTH_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_INTERLEAVE_LENGTH_INVALID ((NTSTATUS)0xC0380021L)")]
    public const int STATUS_VOLMGR_INTERLEAVE_LENGTH_INVALID = unchecked((int)(0xC0380021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_MAXIMUM_REGISTERED_USERS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_MAXIMUM_REGISTERED_USERS ((NTSTATUS)0xC0380022L)")]
    public const int STATUS_VOLMGR_MAXIMUM_REGISTERED_USERS = unchecked((int)(0xC0380022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_MEMBER_IN_SYNC"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_MEMBER_IN_SYNC ((NTSTATUS)0xC0380023L)")]
    public const int STATUS_VOLMGR_MEMBER_IN_SYNC = unchecked((int)(0xC0380023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_MEMBER_INDEX_DUPLICATE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_MEMBER_INDEX_DUPLICATE ((NTSTATUS)0xC0380024L)")]
    public const int STATUS_VOLMGR_MEMBER_INDEX_DUPLICATE = unchecked((int)(0xC0380024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_MEMBER_INDEX_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_MEMBER_INDEX_INVALID ((NTSTATUS)0xC0380025L)")]
    public const int STATUS_VOLMGR_MEMBER_INDEX_INVALID = unchecked((int)(0xC0380025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_MEMBER_MISSING"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_MEMBER_MISSING ((NTSTATUS)0xC0380026L)")]
    public const int STATUS_VOLMGR_MEMBER_MISSING = unchecked((int)(0xC0380026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_MEMBER_NOT_DETACHED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_MEMBER_NOT_DETACHED ((NTSTATUS)0xC0380027L)")]
    public const int STATUS_VOLMGR_MEMBER_NOT_DETACHED = unchecked((int)(0xC0380027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_MEMBER_REGENERATING"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_MEMBER_REGENERATING ((NTSTATUS)0xC0380028L)")]
    public const int STATUS_VOLMGR_MEMBER_REGENERATING = unchecked((int)(0xC0380028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_ALL_DISKS_FAILED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_ALL_DISKS_FAILED ((NTSTATUS)0xC0380029L)")]
    public const int STATUS_VOLMGR_ALL_DISKS_FAILED = unchecked((int)(0xC0380029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NO_REGISTERED_USERS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NO_REGISTERED_USERS ((NTSTATUS)0xC038002AL)")]
    public const int STATUS_VOLMGR_NO_REGISTERED_USERS = unchecked((int)(0xC038002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NO_SUCH_USER"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NO_SUCH_USER ((NTSTATUS)0xC038002BL)")]
    public const int STATUS_VOLMGR_NO_SUCH_USER = unchecked((int)(0xC038002B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NOTIFICATION_RESET"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NOTIFICATION_RESET ((NTSTATUS)0xC038002CL)")]
    public const int STATUS_VOLMGR_NOTIFICATION_RESET = unchecked((int)(0xC038002C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NUMBER_OF_MEMBERS_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NUMBER_OF_MEMBERS_INVALID ((NTSTATUS)0xC038002DL)")]
    public const int STATUS_VOLMGR_NUMBER_OF_MEMBERS_INVALID = unchecked((int)(0xC038002D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NUMBER_OF_PLEXES_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NUMBER_OF_PLEXES_INVALID ((NTSTATUS)0xC038002EL)")]
    public const int STATUS_VOLMGR_NUMBER_OF_PLEXES_INVALID = unchecked((int)(0xC038002E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_DUPLICATE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_DUPLICATE ((NTSTATUS)0xC038002FL)")]
    public const int STATUS_VOLMGR_PACK_DUPLICATE = unchecked((int)(0xC038002F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_ID_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_ID_INVALID ((NTSTATUS)0xC0380030L)")]
    public const int STATUS_VOLMGR_PACK_ID_INVALID = unchecked((int)(0xC0380030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_INVALID ((NTSTATUS)0xC0380031L)")]
    public const int STATUS_VOLMGR_PACK_INVALID = unchecked((int)(0xC0380031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_NAME_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_NAME_INVALID ((NTSTATUS)0xC0380032L)")]
    public const int STATUS_VOLMGR_PACK_NAME_INVALID = unchecked((int)(0xC0380032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_OFFLINE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_OFFLINE ((NTSTATUS)0xC0380033L)")]
    public const int STATUS_VOLMGR_PACK_OFFLINE = unchecked((int)(0xC0380033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_HAS_QUORUM"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_HAS_QUORUM ((NTSTATUS)0xC0380034L)")]
    public const int STATUS_VOLMGR_PACK_HAS_QUORUM = unchecked((int)(0xC0380034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_WITHOUT_QUORUM"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_WITHOUT_QUORUM ((NTSTATUS)0xC0380035L)")]
    public const int STATUS_VOLMGR_PACK_WITHOUT_QUORUM = unchecked((int)(0xC0380035));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PARTITION_STYLE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PARTITION_STYLE_INVALID ((NTSTATUS)0xC0380036L)")]
    public const int STATUS_VOLMGR_PARTITION_STYLE_INVALID = unchecked((int)(0xC0380036));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PARTITION_UPDATE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PARTITION_UPDATE_FAILED ((NTSTATUS)0xC0380037L)")]
    public const int STATUS_VOLMGR_PARTITION_UPDATE_FAILED = unchecked((int)(0xC0380037));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_IN_SYNC"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_IN_SYNC ((NTSTATUS)0xC0380038L)")]
    public const int STATUS_VOLMGR_PLEX_IN_SYNC = unchecked((int)(0xC0380038));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_INDEX_DUPLICATE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_INDEX_DUPLICATE ((NTSTATUS)0xC0380039L)")]
    public const int STATUS_VOLMGR_PLEX_INDEX_DUPLICATE = unchecked((int)(0xC0380039));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_INDEX_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_INDEX_INVALID ((NTSTATUS)0xC038003AL)")]
    public const int STATUS_VOLMGR_PLEX_INDEX_INVALID = unchecked((int)(0xC038003A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_LAST_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_LAST_ACTIVE ((NTSTATUS)0xC038003BL)")]
    public const int STATUS_VOLMGR_PLEX_LAST_ACTIVE = unchecked((int)(0xC038003B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_MISSING"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_MISSING ((NTSTATUS)0xC038003CL)")]
    public const int STATUS_VOLMGR_PLEX_MISSING = unchecked((int)(0xC038003C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_REGENERATING"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_REGENERATING ((NTSTATUS)0xC038003DL)")]
    public const int STATUS_VOLMGR_PLEX_REGENERATING = unchecked((int)(0xC038003D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_TYPE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_TYPE_INVALID ((NTSTATUS)0xC038003EL)")]
    public const int STATUS_VOLMGR_PLEX_TYPE_INVALID = unchecked((int)(0xC038003E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_NOT_RAID5"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_NOT_RAID5 ((NTSTATUS)0xC038003FL)")]
    public const int STATUS_VOLMGR_PLEX_NOT_RAID5 = unchecked((int)(0xC038003F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_NOT_SIMPLE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_NOT_SIMPLE ((NTSTATUS)0xC0380040L)")]
    public const int STATUS_VOLMGR_PLEX_NOT_SIMPLE = unchecked((int)(0xC0380040));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_STRUCTURE_SIZE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_STRUCTURE_SIZE_INVALID ((NTSTATUS)0xC0380041L)")]
    public const int STATUS_VOLMGR_STRUCTURE_SIZE_INVALID = unchecked((int)(0xC0380041));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS ((NTSTATUS)0xC0380042L)")]
    public const int STATUS_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS = unchecked((int)(0xC0380042));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_TRANSACTION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_TRANSACTION_IN_PROGRESS ((NTSTATUS)0xC0380043L)")]
    public const int STATUS_VOLMGR_TRANSACTION_IN_PROGRESS = unchecked((int)(0xC0380043));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE ((NTSTATUS)0xC0380044L)")]
    public const int STATUS_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE = unchecked((int)(0xC0380044));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_CONTAINS_MISSING_DISK"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_CONTAINS_MISSING_DISK ((NTSTATUS)0xC0380045L)")]
    public const int STATUS_VOLMGR_VOLUME_CONTAINS_MISSING_DISK = unchecked((int)(0xC0380045));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_ID_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_ID_INVALID ((NTSTATUS)0xC0380046L)")]
    public const int STATUS_VOLMGR_VOLUME_ID_INVALID = unchecked((int)(0xC0380046));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_LENGTH_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_LENGTH_INVALID ((NTSTATUS)0xC0380047L)")]
    public const int STATUS_VOLMGR_VOLUME_LENGTH_INVALID = unchecked((int)(0xC0380047));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE ((NTSTATUS)0xC0380048L)")]
    public const int STATUS_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE = unchecked((int)(0xC0380048));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_NOT_MIRRORED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_NOT_MIRRORED ((NTSTATUS)0xC0380049L)")]
    public const int STATUS_VOLMGR_VOLUME_NOT_MIRRORED = unchecked((int)(0xC0380049));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_NOT_RETAINED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_NOT_RETAINED ((NTSTATUS)0xC038004AL)")]
    public const int STATUS_VOLMGR_VOLUME_NOT_RETAINED = unchecked((int)(0xC038004A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_OFFLINE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_OFFLINE ((NTSTATUS)0xC038004BL)")]
    public const int STATUS_VOLMGR_VOLUME_OFFLINE = unchecked((int)(0xC038004B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_RETAINED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_RETAINED ((NTSTATUS)0xC038004CL)")]
    public const int STATUS_VOLMGR_VOLUME_RETAINED = unchecked((int)(0xC038004C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NUMBER_OF_EXTENTS_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NUMBER_OF_EXTENTS_INVALID ((NTSTATUS)0xC038004DL)")]
    public const int STATUS_VOLMGR_NUMBER_OF_EXTENTS_INVALID = unchecked((int)(0xC038004D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_DIFFERENT_SECTOR_SIZE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_DIFFERENT_SECTOR_SIZE ((NTSTATUS)0xC038004EL)")]
    public const int STATUS_VOLMGR_DIFFERENT_SECTOR_SIZE = unchecked((int)(0xC038004E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_BAD_BOOT_DISK"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_BAD_BOOT_DISK ((NTSTATUS)0xC038004FL)")]
    public const int STATUS_VOLMGR_BAD_BOOT_DISK = unchecked((int)(0xC038004F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_CONFIG_OFFLINE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_CONFIG_OFFLINE ((NTSTATUS)0xC0380050L)")]
    public const int STATUS_VOLMGR_PACK_CONFIG_OFFLINE = unchecked((int)(0xC0380050));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_CONFIG_ONLINE"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_CONFIG_ONLINE ((NTSTATUS)0xC0380051L)")]
    public const int STATUS_VOLMGR_PACK_CONFIG_ONLINE = unchecked((int)(0xC0380051));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NOT_PRIMARY_PACK"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NOT_PRIMARY_PACK ((NTSTATUS)0xC0380052L)")]
    public const int STATUS_VOLMGR_NOT_PRIMARY_PACK = unchecked((int)(0xC0380052));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PACK_LOG_UPDATE_FAILED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PACK_LOG_UPDATE_FAILED ((NTSTATUS)0xC0380053L)")]
    public const int STATUS_VOLMGR_PACK_LOG_UPDATE_FAILED = unchecked((int)(0xC0380053));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID ((NTSTATUS)0xC0380054L)")]
    public const int STATUS_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID = unchecked((int)(0xC0380054));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID ((NTSTATUS)0xC0380055L)")]
    public const int STATUS_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID = unchecked((int)(0xC0380055));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_VOLUME_MIRRORED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_VOLUME_MIRRORED ((NTSTATUS)0xC0380056L)")]
    public const int STATUS_VOLMGR_VOLUME_MIRRORED = unchecked((int)(0xC0380056));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PLEX_NOT_SIMPLE_SPANNED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PLEX_NOT_SIMPLE_SPANNED ((NTSTATUS)0xC0380057L)")]
    public const int STATUS_VOLMGR_PLEX_NOT_SIMPLE_SPANNED = unchecked((int)(0xC0380057));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NO_VALID_LOG_COPIES"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NO_VALID_LOG_COPIES ((NTSTATUS)0xC0380058L)")]
    public const int STATUS_VOLMGR_NO_VALID_LOG_COPIES = unchecked((int)(0xC0380058));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_PRIMARY_PACK_PRESENT"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_PRIMARY_PACK_PRESENT ((NTSTATUS)0xC0380059L)")]
    public const int STATUS_VOLMGR_PRIMARY_PACK_PRESENT = unchecked((int)(0xC0380059));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_NUMBER_OF_DISKS_INVALID"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_NUMBER_OF_DISKS_INVALID ((NTSTATUS)0xC038005AL)")]
    public const int STATUS_VOLMGR_NUMBER_OF_DISKS_INVALID = unchecked((int)(0xC038005A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_MIRROR_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_MIRROR_NOT_SUPPORTED ((NTSTATUS)0xC038005BL)")]
    public const int STATUS_VOLMGR_MIRROR_NOT_SUPPORTED = unchecked((int)(0xC038005B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLMGR_RAID5_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_VOLMGR_RAID5_NOT_SUPPORTED ((NTSTATUS)0xC038005CL)")]
    public const int STATUS_VOLMGR_RAID5_NOT_SUPPORTED = unchecked((int)(0xC038005C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BCD_NOT_ALL_ENTRIES_IMPORTED"]/*' />
    [NativeTypeName("#define STATUS_BCD_NOT_ALL_ENTRIES_IMPORTED ((NTSTATUS)0x80390001L)")]
    public const int STATUS_BCD_NOT_ALL_ENTRIES_IMPORTED = unchecked((int)(0x80390001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BCD_TOO_MANY_ELEMENTS"]/*' />
    [NativeTypeName("#define STATUS_BCD_TOO_MANY_ELEMENTS ((NTSTATUS)0xC0390002L)")]
    public const int STATUS_BCD_TOO_MANY_ELEMENTS = unchecked((int)(0xC0390002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED"]/*' />
    [NativeTypeName("#define STATUS_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED ((NTSTATUS)0x80390003L)")]
    public const int STATUS_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED = unchecked((int)(0x80390003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_DRIVE_FOOTER_MISSING"]/*' />
    [NativeTypeName("#define STATUS_VHD_DRIVE_FOOTER_MISSING ((NTSTATUS)0xC03A0001L)")]
    public const int STATUS_VHD_DRIVE_FOOTER_MISSING = unchecked((int)(0xC03A0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH ((NTSTATUS)0xC03A0002L)")]
    public const int STATUS_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH = unchecked((int)(0xC03A0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_DRIVE_FOOTER_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_VHD_DRIVE_FOOTER_CORRUPT ((NTSTATUS)0xC03A0003L)")]
    public const int STATUS_VHD_DRIVE_FOOTER_CORRUPT = unchecked((int)(0xC03A0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_FORMAT_UNKNOWN"]/*' />
    [NativeTypeName("#define STATUS_VHD_FORMAT_UNKNOWN ((NTSTATUS)0xC03A0004L)")]
    public const int STATUS_VHD_FORMAT_UNKNOWN = unchecked((int)(0xC03A0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_FORMAT_UNSUPPORTED_VERSION"]/*' />
    [NativeTypeName("#define STATUS_VHD_FORMAT_UNSUPPORTED_VERSION ((NTSTATUS)0xC03A0005L)")]
    public const int STATUS_VHD_FORMAT_UNSUPPORTED_VERSION = unchecked((int)(0xC03A0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH ((NTSTATUS)0xC03A0006L)")]
    public const int STATUS_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH = unchecked((int)(0xC03A0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION"]/*' />
    [NativeTypeName("#define STATUS_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION ((NTSTATUS)0xC03A0007L)")]
    public const int STATUS_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION = unchecked((int)(0xC03A0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_SPARSE_HEADER_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_VHD_SPARSE_HEADER_CORRUPT ((NTSTATUS)0xC03A0008L)")]
    public const int STATUS_VHD_SPARSE_HEADER_CORRUPT = unchecked((int)(0xC03A0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_BLOCK_ALLOCATION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_VHD_BLOCK_ALLOCATION_FAILURE ((NTSTATUS)0xC03A0009L)")]
    public const int STATUS_VHD_BLOCK_ALLOCATION_FAILURE = unchecked((int)(0xC03A0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT ((NTSTATUS)0xC03A000AL)")]
    public const int STATUS_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT = unchecked((int)(0xC03A000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_INVALID_BLOCK_SIZE"]/*' />
    [NativeTypeName("#define STATUS_VHD_INVALID_BLOCK_SIZE ((NTSTATUS)0xC03A000BL)")]
    public const int STATUS_VHD_INVALID_BLOCK_SIZE = unchecked((int)(0xC03A000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_BITMAP_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VHD_BITMAP_MISMATCH ((NTSTATUS)0xC03A000CL)")]
    public const int STATUS_VHD_BITMAP_MISMATCH = unchecked((int)(0xC03A000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_PARENT_VHD_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_VHD_PARENT_VHD_NOT_FOUND ((NTSTATUS)0xC03A000DL)")]
    public const int STATUS_VHD_PARENT_VHD_NOT_FOUND = unchecked((int)(0xC03A000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_CHILD_PARENT_ID_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VHD_CHILD_PARENT_ID_MISMATCH ((NTSTATUS)0xC03A000EL)")]
    public const int STATUS_VHD_CHILD_PARENT_ID_MISMATCH = unchecked((int)(0xC03A000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH ((NTSTATUS)0xC03A000FL)")]
    public const int STATUS_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH = unchecked((int)(0xC03A000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_METADATA_READ_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_VHD_METADATA_READ_FAILURE ((NTSTATUS)0xC03A0010L)")]
    public const int STATUS_VHD_METADATA_READ_FAILURE = unchecked((int)(0xC03A0010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_METADATA_WRITE_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_VHD_METADATA_WRITE_FAILURE ((NTSTATUS)0xC03A0011L)")]
    public const int STATUS_VHD_METADATA_WRITE_FAILURE = unchecked((int)(0xC03A0011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_INVALID_SIZE"]/*' />
    [NativeTypeName("#define STATUS_VHD_INVALID_SIZE ((NTSTATUS)0xC03A0012L)")]
    public const int STATUS_VHD_INVALID_SIZE = unchecked((int)(0xC03A0012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_INVALID_FILE_SIZE"]/*' />
    [NativeTypeName("#define STATUS_VHD_INVALID_FILE_SIZE ((NTSTATUS)0xC03A0013L)")]
    public const int STATUS_VHD_INVALID_FILE_SIZE = unchecked((int)(0xC03A0013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRTDISK_PROVIDER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_VIRTDISK_PROVIDER_NOT_FOUND ((NTSTATUS)0xC03A0014L)")]
    public const int STATUS_VIRTDISK_PROVIDER_NOT_FOUND = unchecked((int)(0xC03A0014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRTDISK_NOT_VIRTUAL_DISK"]/*' />
    [NativeTypeName("#define STATUS_VIRTDISK_NOT_VIRTUAL_DISK ((NTSTATUS)0xC03A0015L)")]
    public const int STATUS_VIRTDISK_NOT_VIRTUAL_DISK = unchecked((int)(0xC03A0015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_PARENT_VHD_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_VHD_PARENT_VHD_ACCESS_DENIED ((NTSTATUS)0xC03A0016L)")]
    public const int STATUS_VHD_PARENT_VHD_ACCESS_DENIED = unchecked((int)(0xC03A0016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_CHILD_PARENT_SIZE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VHD_CHILD_PARENT_SIZE_MISMATCH ((NTSTATUS)0xC03A0017L)")]
    public const int STATUS_VHD_CHILD_PARENT_SIZE_MISMATCH = unchecked((int)(0xC03A0017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED ((NTSTATUS)0xC03A0018L)")]
    public const int STATUS_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED = unchecked((int)(0xC03A0018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT"]/*' />
    [NativeTypeName("#define STATUS_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT ((NTSTATUS)0xC03A0019L)")]
    public const int STATUS_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT = unchecked((int)(0xC03A0019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRTUAL_DISK_LIMITATION"]/*' />
    [NativeTypeName("#define STATUS_VIRTUAL_DISK_LIMITATION ((NTSTATUS)0xC03A001AL)")]
    public const int STATUS_VIRTUAL_DISK_LIMITATION = unchecked((int)(0xC03A001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_INVALID_TYPE"]/*' />
    [NativeTypeName("#define STATUS_VHD_INVALID_TYPE ((NTSTATUS)0xC03A001BL)")]
    public const int STATUS_VHD_INVALID_TYPE = unchecked((int)(0xC03A001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_INVALID_STATE"]/*' />
    [NativeTypeName("#define STATUS_VHD_INVALID_STATE ((NTSTATUS)0xC03A001CL)")]
    public const int STATUS_VHD_INVALID_STATE = unchecked((int)(0xC03A001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE"]/*' />
    [NativeTypeName("#define STATUS_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE ((NTSTATUS)0xC03A001DL)")]
    public const int STATUS_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE = unchecked((int)(0xC03A001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRTDISK_DISK_ALREADY_OWNED"]/*' />
    [NativeTypeName("#define STATUS_VIRTDISK_DISK_ALREADY_OWNED ((NTSTATUS)0xC03A001EL)")]
    public const int STATUS_VIRTDISK_DISK_ALREADY_OWNED = unchecked((int)(0xC03A001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VIRTDISK_DISK_ONLINE_AND_WRITABLE"]/*' />
    [NativeTypeName("#define STATUS_VIRTDISK_DISK_ONLINE_AND_WRITABLE ((NTSTATUS)0xC03A001FL)")]
    public const int STATUS_VIRTDISK_DISK_ONLINE_AND_WRITABLE = unchecked((int)(0xC03A001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTLOG_TRACKING_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_CTLOG_TRACKING_NOT_INITIALIZED ((NTSTATUS)0xC03A0020L)")]
    public const int STATUS_CTLOG_TRACKING_NOT_INITIALIZED = unchecked((int)(0xC03A0020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE"]/*' />
    [NativeTypeName("#define STATUS_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE ((NTSTATUS)0xC03A0021L)")]
    public const int STATUS_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE = unchecked((int)(0xC03A0021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTLOG_VHD_CHANGED_OFFLINE"]/*' />
    [NativeTypeName("#define STATUS_CTLOG_VHD_CHANGED_OFFLINE ((NTSTATUS)0xC03A0022L)")]
    public const int STATUS_CTLOG_VHD_CHANGED_OFFLINE = unchecked((int)(0xC03A0022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTLOG_INVALID_TRACKING_STATE"]/*' />
    [NativeTypeName("#define STATUS_CTLOG_INVALID_TRACKING_STATE ((NTSTATUS)0xC03A0023L)")]
    public const int STATUS_CTLOG_INVALID_TRACKING_STATE = unchecked((int)(0xC03A0023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CTLOG_INCONSISTENT_TRACKING_FILE"]/*' />
    [NativeTypeName("#define STATUS_CTLOG_INCONSISTENT_TRACKING_FILE ((NTSTATUS)0xC03A0024L)")]
    public const int STATUS_CTLOG_INCONSISTENT_TRACKING_FILE = unchecked((int)(0xC03A0024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_METADATA_FULL"]/*' />
    [NativeTypeName("#define STATUS_VHD_METADATA_FULL ((NTSTATUS)0xC03A0028L)")]
    public const int STATUS_VHD_METADATA_FULL = unchecked((int)(0xC03A0028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_INVALID_CHANGE_TRACKING_ID"]/*' />
    [NativeTypeName("#define STATUS_VHD_INVALID_CHANGE_TRACKING_ID ((NTSTATUS)0xC03A0029L)")]
    public const int STATUS_VHD_INVALID_CHANGE_TRACKING_ID = unchecked((int)(0xC03A0029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_CHANGE_TRACKING_DISABLED"]/*' />
    [NativeTypeName("#define STATUS_VHD_CHANGE_TRACKING_DISABLED ((NTSTATUS)0xC03A002AL)")]
    public const int STATUS_VHD_CHANGE_TRACKING_DISABLED = unchecked((int)(0xC03A002A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_MISSING_CHANGE_TRACKING_INFORMATION"]/*' />
    [NativeTypeName("#define STATUS_VHD_MISSING_CHANGE_TRACKING_INFORMATION ((NTSTATUS)0xC03A0030L)")]
    public const int STATUS_VHD_MISSING_CHANGE_TRACKING_INFORMATION = unchecked((int)(0xC03A0030));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_RESIZE_WOULD_TRUNCATE_DATA"]/*' />
    [NativeTypeName("#define STATUS_VHD_RESIZE_WOULD_TRUNCATE_DATA ((NTSTATUS)0xC03A0031L)")]
    public const int STATUS_VHD_RESIZE_WOULD_TRUNCATE_DATA = unchecked((int)(0xC03A0031));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE"]/*' />
    [NativeTypeName("#define STATUS_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE ((NTSTATUS)0xC03A0032L)")]
    public const int STATUS_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE = unchecked((int)(0xC03A0032));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE"]/*' />
    [NativeTypeName("#define STATUS_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE ((NTSTATUS)0xC03A0033L)")]
    public const int STATUS_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE = unchecked((int)(0xC03A0033));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_UNEXPECTED_ID"]/*' />
    [NativeTypeName("#define STATUS_VHD_UNEXPECTED_ID ((NTSTATUS)0xC03A0034L)")]
    public const int STATUS_VHD_UNEXPECTED_ID = unchecked((int)(0xC03A0034));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUERY_STORAGE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_QUERY_STORAGE_ERROR ((NTSTATUS)0x803A0001L)")]
    public const int STATUS_QUERY_STORAGE_ERROR = unchecked((int)(0x803A0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GDI_HANDLE_LEAK"]/*' />
    [NativeTypeName("#define STATUS_GDI_HANDLE_LEAK ((NTSTATUS)0x803F0001L)")]
    public const int STATUS_GDI_HANDLE_LEAK = unchecked((int)(0x803F0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RKF_KEY_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_RKF_KEY_NOT_FOUND ((NTSTATUS)0xC0400001L)")]
    public const int STATUS_RKF_KEY_NOT_FOUND = unchecked((int)(0xC0400001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RKF_DUPLICATE_KEY"]/*' />
    [NativeTypeName("#define STATUS_RKF_DUPLICATE_KEY ((NTSTATUS)0xC0400002L)")]
    public const int STATUS_RKF_DUPLICATE_KEY = unchecked((int)(0xC0400002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RKF_BLOB_FULL"]/*' />
    [NativeTypeName("#define STATUS_RKF_BLOB_FULL ((NTSTATUS)0xC0400003L)")]
    public const int STATUS_RKF_BLOB_FULL = unchecked((int)(0xC0400003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RKF_STORE_FULL"]/*' />
    [NativeTypeName("#define STATUS_RKF_STORE_FULL ((NTSTATUS)0xC0400004L)")]
    public const int STATUS_RKF_STORE_FULL = unchecked((int)(0xC0400004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RKF_FILE_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_RKF_FILE_BLOCKED ((NTSTATUS)0xC0400005L)")]
    public const int STATUS_RKF_FILE_BLOCKED = unchecked((int)(0xC0400005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RKF_ACTIVE_KEY"]/*' />
    [NativeTypeName("#define STATUS_RKF_ACTIVE_KEY ((NTSTATUS)0xC0400006L)")]
    public const int STATUS_RKF_ACTIVE_KEY = unchecked((int)(0xC0400006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RDBSS_RESTART_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_RDBSS_RESTART_OPERATION ((NTSTATUS)0xC0410001L)")]
    public const int STATUS_RDBSS_RESTART_OPERATION = unchecked((int)(0xC0410001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RDBSS_CONTINUE_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_RDBSS_CONTINUE_OPERATION ((NTSTATUS)0xC0410002L)")]
    public const int STATUS_RDBSS_CONTINUE_OPERATION = unchecked((int)(0xC0410002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RDBSS_POST_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_RDBSS_POST_OPERATION ((NTSTATUS)0xC0410003L)")]
    public const int STATUS_RDBSS_POST_OPERATION = unchecked((int)(0xC0410003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_RDBSS_RETRY_LOOKUP"]/*' />
    [NativeTypeName("#define STATUS_RDBSS_RETRY_LOOKUP ((NTSTATUS)0xC0410004L)")]
    public const int STATUS_RDBSS_RETRY_LOOKUP = unchecked((int)(0xC0410004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INVALID_HANDLE ((NTSTATUS)0xC0420001L)")]
    public const int STATUS_BTH_ATT_INVALID_HANDLE = unchecked((int)(0xC0420001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_READ_NOT_PERMITTED"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_READ_NOT_PERMITTED ((NTSTATUS)0xC0420002L)")]
    public const int STATUS_BTH_ATT_READ_NOT_PERMITTED = unchecked((int)(0xC0420002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_WRITE_NOT_PERMITTED"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_WRITE_NOT_PERMITTED ((NTSTATUS)0xC0420003L)")]
    public const int STATUS_BTH_ATT_WRITE_NOT_PERMITTED = unchecked((int)(0xC0420003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INVALID_PDU"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INVALID_PDU ((NTSTATUS)0xC0420004L)")]
    public const int STATUS_BTH_ATT_INVALID_PDU = unchecked((int)(0xC0420004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INSUFFICIENT_AUTHENTICATION"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INSUFFICIENT_AUTHENTICATION ((NTSTATUS)0xC0420005L)")]
    public const int STATUS_BTH_ATT_INSUFFICIENT_AUTHENTICATION = unchecked((int)(0xC0420005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_REQUEST_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_REQUEST_NOT_SUPPORTED ((NTSTATUS)0xC0420006L)")]
    public const int STATUS_BTH_ATT_REQUEST_NOT_SUPPORTED = unchecked((int)(0xC0420006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INVALID_OFFSET"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INVALID_OFFSET ((NTSTATUS)0xC0420007L)")]
    public const int STATUS_BTH_ATT_INVALID_OFFSET = unchecked((int)(0xC0420007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INSUFFICIENT_AUTHORIZATION"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INSUFFICIENT_AUTHORIZATION ((NTSTATUS)0xC0420008L)")]
    public const int STATUS_BTH_ATT_INSUFFICIENT_AUTHORIZATION = unchecked((int)(0xC0420008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_PREPARE_QUEUE_FULL"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_PREPARE_QUEUE_FULL ((NTSTATUS)0xC0420009L)")]
    public const int STATUS_BTH_ATT_PREPARE_QUEUE_FULL = unchecked((int)(0xC0420009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_ATTRIBUTE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_ATTRIBUTE_NOT_FOUND ((NTSTATUS)0xC042000AL)")]
    public const int STATUS_BTH_ATT_ATTRIBUTE_NOT_FOUND = unchecked((int)(0xC042000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_ATTRIBUTE_NOT_LONG"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_ATTRIBUTE_NOT_LONG ((NTSTATUS)0xC042000BL)")]
    public const int STATUS_BTH_ATT_ATTRIBUTE_NOT_LONG = unchecked((int)(0xC042000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE ((NTSTATUS)0xC042000CL)")]
    public const int STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE = unchecked((int)(0xC042000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH ((NTSTATUS)0xC042000DL)")]
    public const int STATUS_BTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH = unchecked((int)(0xC042000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_UNLIKELY"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_UNLIKELY ((NTSTATUS)0xC042000EL)")]
    public const int STATUS_BTH_ATT_UNLIKELY = unchecked((int)(0xC042000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION ((NTSTATUS)0xC042000FL)")]
    public const int STATUS_BTH_ATT_INSUFFICIENT_ENCRYPTION = unchecked((int)(0xC042000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_UNSUPPORTED_GROUP_TYPE"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_UNSUPPORTED_GROUP_TYPE ((NTSTATUS)0xC0420010L)")]
    public const int STATUS_BTH_ATT_UNSUPPORTED_GROUP_TYPE = unchecked((int)(0xC0420010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_INSUFFICIENT_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_INSUFFICIENT_RESOURCES ((NTSTATUS)0xC0420011L)")]
    public const int STATUS_BTH_ATT_INSUFFICIENT_RESOURCES = unchecked((int)(0xC0420011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BTH_ATT_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define STATUS_BTH_ATT_UNKNOWN_ERROR ((NTSTATUS)0xC0421000L)")]
    public const int STATUS_BTH_ATT_UNKNOWN_ERROR = unchecked((int)(0xC0421000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_ROLLBACK_DETECTED ((NTSTATUS)0xC0430001L)")]
    public const int STATUS_SECUREBOOT_ROLLBACK_DETECTED = unchecked((int)(0xC0430001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_POLICY_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_POLICY_VIOLATION ((NTSTATUS)0xC0430002L)")]
    public const int STATUS_SECUREBOOT_POLICY_VIOLATION = unchecked((int)(0xC0430002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_INVALID_POLICY"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_INVALID_POLICY ((NTSTATUS)0xC0430003L)")]
    public const int STATUS_SECUREBOOT_INVALID_POLICY = unchecked((int)(0xC0430003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND ((NTSTATUS)0xC0430004L)")]
    public const int STATUS_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND = unchecked((int)(0xC0430004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_POLICY_NOT_SIGNED"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_POLICY_NOT_SIGNED ((NTSTATUS)0xC0430005L)")]
    public const int STATUS_SECUREBOOT_POLICY_NOT_SIGNED = unchecked((int)(0xC0430005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_NOT_ENABLED"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_NOT_ENABLED ((NTSTATUS)0x80430006L)")]
    public const int STATUS_SECUREBOOT_NOT_ENABLED = unchecked((int)(0x80430006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_FILE_REPLACED"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_FILE_REPLACED ((NTSTATUS)0xC0430007L)")]
    public const int STATUS_SECUREBOOT_FILE_REPLACED = unchecked((int)(0xC0430007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_POLICY_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_POLICY_NOT_AUTHORIZED ((NTSTATUS)0xC0430008L)")]
    public const int STATUS_SECUREBOOT_POLICY_NOT_AUTHORIZED = unchecked((int)(0xC0430008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_POLICY_UNKNOWN"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_POLICY_UNKNOWN ((NTSTATUS)0xC0430009L)")]
    public const int STATUS_SECUREBOOT_POLICY_UNKNOWN = unchecked((int)(0xC0430009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION ((NTSTATUS)0xC043000AL)")]
    public const int STATUS_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION = unchecked((int)(0xC043000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_PLATFORM_ID_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_PLATFORM_ID_MISMATCH ((NTSTATUS)0xC043000BL)")]
    public const int STATUS_SECUREBOOT_PLATFORM_ID_MISMATCH = unchecked((int)(0xC043000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_POLICY_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_POLICY_ROLLBACK_DETECTED ((NTSTATUS)0xC043000CL)")]
    public const int STATUS_SECUREBOOT_POLICY_ROLLBACK_DETECTED = unchecked((int)(0xC043000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_POLICY_UPGRADE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_POLICY_UPGRADE_MISMATCH ((NTSTATUS)0xC043000DL)")]
    public const int STATUS_SECUREBOOT_POLICY_UPGRADE_MISMATCH = unchecked((int)(0xC043000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING ((NTSTATUS)0xC043000EL)")]
    public const int STATUS_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING = unchecked((int)(0xC043000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_NOT_BASE_POLICY"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_NOT_BASE_POLICY ((NTSTATUS)0xC043000FL)")]
    public const int STATUS_SECUREBOOT_NOT_BASE_POLICY = unchecked((int)(0xC043000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY"]/*' />
    [NativeTypeName("#define STATUS_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY ((NTSTATUS)0xC0430010L)")]
    public const int STATUS_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY = unchecked((int)(0xC0430010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLATFORM_MANIFEST_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define STATUS_PLATFORM_MANIFEST_NOT_AUTHORIZED ((NTSTATUS)0xC0EB0001L)")]
    public const int STATUS_PLATFORM_MANIFEST_NOT_AUTHORIZED = unchecked((int)(0xC0EB0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLATFORM_MANIFEST_INVALID"]/*' />
    [NativeTypeName("#define STATUS_PLATFORM_MANIFEST_INVALID ((NTSTATUS)0xC0EB0002L)")]
    public const int STATUS_PLATFORM_MANIFEST_INVALID = unchecked((int)(0xC0EB0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define STATUS_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED ((NTSTATUS)0xC0EB0003L)")]
    public const int STATUS_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED = unchecked((int)(0xC0EB0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define STATUS_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED ((NTSTATUS)0xC0EB0004L)")]
    public const int STATUS_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED = unchecked((int)(0xC0EB0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND ((NTSTATUS)0xC0EB0005L)")]
    public const int STATUS_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND = unchecked((int)(0xC0EB0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLATFORM_MANIFEST_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define STATUS_PLATFORM_MANIFEST_NOT_ACTIVE ((NTSTATUS)0xC0EB0006L)")]
    public const int STATUS_PLATFORM_MANIFEST_NOT_ACTIVE = unchecked((int)(0xC0EB0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PLATFORM_MANIFEST_NOT_SIGNED"]/*' />
    [NativeTypeName("#define STATUS_PLATFORM_MANIFEST_NOT_SIGNED ((NTSTATUS)0xC0EB0007L)")]
    public const int STATUS_PLATFORM_MANIFEST_NOT_SIGNED = unchecked((int)(0xC0EB0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_ROLLBACK_DETECTED ((NTSTATUS)0xC0E90001L)")]
    public const int STATUS_SYSTEM_INTEGRITY_ROLLBACK_DETECTED = unchecked((int)(0xC0E90001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_POLICY_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_POLICY_VIOLATION ((NTSTATUS)0xC0E90002L)")]
    public const int STATUS_SYSTEM_INTEGRITY_POLICY_VIOLATION = unchecked((int)(0xC0E90002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_INVALID_POLICY"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_INVALID_POLICY ((NTSTATUS)0xC0E90003L)")]
    public const int STATUS_SYSTEM_INTEGRITY_INVALID_POLICY = unchecked((int)(0xC0E90003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED ((NTSTATUS)0xC0E90004L)")]
    public const int STATUS_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED = unchecked((int)(0xC0E90004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_TOO_MANY_POLICIES"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_TOO_MANY_POLICIES ((NTSTATUS)0xC0E90005L)")]
    public const int STATUS_SYSTEM_INTEGRITY_TOO_MANY_POLICIES = unchecked((int)(0xC0E90005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_SUPPLEMENTAL_POLICY_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_SUPPLEMENTAL_POLICY_NOT_AUTHORIZED ((NTSTATUS)0xC0E90006L)")]
    public const int STATUS_SYSTEM_INTEGRITY_SUPPLEMENTAL_POLICY_NOT_AUTHORIZED = unchecked((int)(0xC0E90006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_REPUTATION_MALICIOUS"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_REPUTATION_MALICIOUS ((NTSTATUS)0xC0E90007L)")]
    public const int STATUS_SYSTEM_INTEGRITY_REPUTATION_MALICIOUS = unchecked((int)(0xC0E90007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_REPUTATION_PUA"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_REPUTATION_PUA ((NTSTATUS)0xC0E90008L)")]
    public const int STATUS_SYSTEM_INTEGRITY_REPUTATION_PUA = unchecked((int)(0xC0E90008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_REPUTATION_DANGEROUS_EXT"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_REPUTATION_DANGEROUS_EXT ((NTSTATUS)0xC0E90009L)")]
    public const int STATUS_SYSTEM_INTEGRITY_REPUTATION_DANGEROUS_EXT = unchecked((int)(0xC0E90009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_REPUTATION_OFFLINE"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_REPUTATION_OFFLINE ((NTSTATUS)0xC0E9000AL)")]
    public const int STATUS_SYSTEM_INTEGRITY_REPUTATION_OFFLINE = unchecked((int)(0xC0E9000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_REPUTATION_UNFRIENDLY_FILE"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_REPUTATION_UNFRIENDLY_FILE ((NTSTATUS)0xC0E9000BL)")]
    public const int STATUS_SYSTEM_INTEGRITY_REPUTATION_UNFRIENDLY_FILE = unchecked((int)(0xC0E9000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_REPUTATION_UNATTAINABLE"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_REPUTATION_UNATTAINABLE ((NTSTATUS)0xC0E9000CL)")]
    public const int STATUS_SYSTEM_INTEGRITY_REPUTATION_UNATTAINABLE = unchecked((int)(0xC0E9000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_REPUTATION_EXPLICIT_DENY_FILE"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_REPUTATION_EXPLICIT_DENY_FILE ((NTSTATUS)0xC0E9000DL)")]
    public const int STATUS_SYSTEM_INTEGRITY_REPUTATION_EXPLICIT_DENY_FILE = unchecked((int)(0xC0E9000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SYSTEM_INTEGRITY_WHQL_NOT_SATISFIED"]/*' />
    [NativeTypeName("#define STATUS_SYSTEM_INTEGRITY_WHQL_NOT_SATISFIED ((NTSTATUS)0xC0E9000EL)")]
    public const int STATUS_SYSTEM_INTEGRITY_WHQL_NOT_SATISFIED = unchecked((int)(0xC0E9000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_APPLICABLE_APP_LICENSES_FOUND"]/*' />
    [NativeTypeName("#define STATUS_NO_APPLICABLE_APP_LICENSES_FOUND ((NTSTATUS)0xC0EA0001L)")]
    public const int STATUS_NO_APPLICABLE_APP_LICENSES_FOUND = unchecked((int)(0xC0EA0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_LICENSE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_CLIP_LICENSE_NOT_FOUND ((NTSTATUS)0xC0EA0002L)")]
    public const int STATUS_CLIP_LICENSE_NOT_FOUND = unchecked((int)(0xC0EA0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_DEVICE_LICENSE_MISSING"]/*' />
    [NativeTypeName("#define STATUS_CLIP_DEVICE_LICENSE_MISSING ((NTSTATUS)0xC0EA0003L)")]
    public const int STATUS_CLIP_DEVICE_LICENSE_MISSING = unchecked((int)(0xC0EA0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_LICENSE_INVALID_SIGNATURE"]/*' />
    [NativeTypeName("#define STATUS_CLIP_LICENSE_INVALID_SIGNATURE ((NTSTATUS)0xC0EA0004L)")]
    public const int STATUS_CLIP_LICENSE_INVALID_SIGNATURE = unchecked((int)(0xC0EA0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID"]/*' />
    [NativeTypeName("#define STATUS_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID ((NTSTATUS)0xC0EA0005L)")]
    public const int STATUS_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID = unchecked((int)(0xC0EA0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_LICENSE_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_CLIP_LICENSE_EXPIRED ((NTSTATUS)0xC0EA0006L)")]
    public const int STATUS_CLIP_LICENSE_EXPIRED = unchecked((int)(0xC0EA0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE"]/*' />
    [NativeTypeName("#define STATUS_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE ((NTSTATUS)0xC0EA0007L)")]
    public const int STATUS_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE = unchecked((int)(0xC0EA0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_LICENSE_NOT_SIGNED"]/*' />
    [NativeTypeName("#define STATUS_CLIP_LICENSE_NOT_SIGNED ((NTSTATUS)0xC0EA0008L)")]
    public const int STATUS_CLIP_LICENSE_NOT_SIGNED = unchecked((int)(0xC0EA0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE"]/*' />
    [NativeTypeName("#define STATUS_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE ((NTSTATUS)0xC0EA0009L)")]
    public const int STATUS_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE = unchecked((int)(0xC0EA0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CLIP_LICENSE_DEVICE_ID_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_CLIP_LICENSE_DEVICE_ID_MISMATCH ((NTSTATUS)0xC0EA000AL)")]
    public const int STATUS_CLIP_LICENSE_DEVICE_ID_MISMATCH = unchecked((int)(0xC0EA000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AUDIO_ENGINE_NODE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_AUDIO_ENGINE_NODE_NOT_FOUND ((NTSTATUS)0xC0440001L)")]
    public const int STATUS_AUDIO_ENGINE_NODE_NOT_FOUND = unchecked((int)(0xC0440001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HDAUDIO_EMPTY_CONNECTION_LIST"]/*' />
    [NativeTypeName("#define STATUS_HDAUDIO_EMPTY_CONNECTION_LIST ((NTSTATUS)0xC0440002L)")]
    public const int STATUS_HDAUDIO_EMPTY_CONNECTION_LIST = unchecked((int)(0xC0440002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED ((NTSTATUS)0xC0440003L)")]
    public const int STATUS_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED = unchecked((int)(0xC0440003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HDAUDIO_NO_LOGICAL_DEVICES_CREATED"]/*' />
    [NativeTypeName("#define STATUS_HDAUDIO_NO_LOGICAL_DEVICES_CREATED ((NTSTATUS)0xC0440004L)")]
    public const int STATUS_HDAUDIO_NO_LOGICAL_DEVICES_CREATED = unchecked((int)(0xC0440004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HDAUDIO_NULL_LINKED_LIST_ENTRY"]/*' />
    [NativeTypeName("#define STATUS_HDAUDIO_NULL_LINKED_LIST_ENTRY ((NTSTATUS)0xC0440005L)")]
    public const int STATUS_HDAUDIO_NULL_LINKED_LIST_ENTRY = unchecked((int)(0xC0440005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SOUNDWIRE_COMMAND_ABORTED"]/*' />
    [NativeTypeName("#define STATUS_SOUNDWIRE_COMMAND_ABORTED ((NTSTATUS)0xC0440006L)")]
    public const int STATUS_SOUNDWIRE_COMMAND_ABORTED = unchecked((int)(0xC0440006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SOUNDWIRE_COMMAND_IGNORED"]/*' />
    [NativeTypeName("#define STATUS_SOUNDWIRE_COMMAND_IGNORED ((NTSTATUS)0xC0440007L)")]
    public const int STATUS_SOUNDWIRE_COMMAND_IGNORED = unchecked((int)(0xC0440007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SOUNDWIRE_COMMAND_FAILED"]/*' />
    [NativeTypeName("#define STATUS_SOUNDWIRE_COMMAND_FAILED ((NTSTATUS)0xC0440008L)")]
    public const int STATUS_SOUNDWIRE_COMMAND_FAILED = unchecked((int)(0xC0440008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_REPAIRED"]/*' />
    [NativeTypeName("#define STATUS_SPACES_REPAIRED ((NTSTATUS)0x00E70000L)")]
    public const int STATUS_SPACES_REPAIRED = ((int)(0x00E70000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_PAUSE"]/*' />
    [NativeTypeName("#define STATUS_SPACES_PAUSE ((NTSTATUS)0x00E70001L)")]
    public const int STATUS_SPACES_PAUSE = ((int)(0x00E70001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_COMPLETE"]/*' />
    [NativeTypeName("#define STATUS_SPACES_COMPLETE ((NTSTATUS)0x00E70002L)")]
    public const int STATUS_SPACES_COMPLETE = ((int)(0x00E70002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_REDIRECT"]/*' />
    [NativeTypeName("#define STATUS_SPACES_REDIRECT ((NTSTATUS)0x00E70003L)")]
    public const int STATUS_SPACES_REDIRECT = ((int)(0x00E70003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_FAULT_DOMAIN_TYPE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_FAULT_DOMAIN_TYPE_INVALID ((NTSTATUS)0xC0E70001L)")]
    public const int STATUS_SPACES_FAULT_DOMAIN_TYPE_INVALID = unchecked((int)(0xC0E70001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_RESILIENCY_TYPE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_RESILIENCY_TYPE_INVALID ((NTSTATUS)0xC0E70003L)")]
    public const int STATUS_SPACES_RESILIENCY_TYPE_INVALID = unchecked((int)(0xC0E70003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_DRIVE_SECTOR_SIZE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_DRIVE_SECTOR_SIZE_INVALID ((NTSTATUS)0xC0E70004L)")]
    public const int STATUS_SPACES_DRIVE_SECTOR_SIZE_INVALID = unchecked((int)(0xC0E70004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_DRIVE_REDUNDANCY_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_DRIVE_REDUNDANCY_INVALID ((NTSTATUS)0xC0E70006L)")]
    public const int STATUS_SPACES_DRIVE_REDUNDANCY_INVALID = unchecked((int)(0xC0E70006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_NUMBER_OF_DATA_COPIES_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_NUMBER_OF_DATA_COPIES_INVALID ((NTSTATUS)0xC0E70007L)")]
    public const int STATUS_SPACES_NUMBER_OF_DATA_COPIES_INVALID = unchecked((int)(0xC0E70007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_INTERLEAVE_LENGTH_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_INTERLEAVE_LENGTH_INVALID ((NTSTATUS)0xC0E70009L)")]
    public const int STATUS_SPACES_INTERLEAVE_LENGTH_INVALID = unchecked((int)(0xC0E70009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_NUMBER_OF_COLUMNS_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_NUMBER_OF_COLUMNS_INVALID ((NTSTATUS)0xC0E7000AL)")]
    public const int STATUS_SPACES_NUMBER_OF_COLUMNS_INVALID = unchecked((int)(0xC0E7000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_NOT_ENOUGH_DRIVES"]/*' />
    [NativeTypeName("#define STATUS_SPACES_NOT_ENOUGH_DRIVES ((NTSTATUS)0xC0E7000BL)")]
    public const int STATUS_SPACES_NOT_ENOUGH_DRIVES = unchecked((int)(0xC0E7000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_EXTENDED_ERROR"]/*' />
    [NativeTypeName("#define STATUS_SPACES_EXTENDED_ERROR ((NTSTATUS)0xC0E7000CL)")]
    public const int STATUS_SPACES_EXTENDED_ERROR = unchecked((int)(0xC0E7000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_PROVISIONING_TYPE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_PROVISIONING_TYPE_INVALID ((NTSTATUS)0xC0E7000DL)")]
    public const int STATUS_SPACES_PROVISIONING_TYPE_INVALID = unchecked((int)(0xC0E7000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_ALLOCATION_SIZE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_ALLOCATION_SIZE_INVALID ((NTSTATUS)0xC0E7000EL)")]
    public const int STATUS_SPACES_ALLOCATION_SIZE_INVALID = unchecked((int)(0xC0E7000E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_ENCLOSURE_AWARE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_ENCLOSURE_AWARE_INVALID ((NTSTATUS)0xC0E7000FL)")]
    public const int STATUS_SPACES_ENCLOSURE_AWARE_INVALID = unchecked((int)(0xC0E7000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_WRITE_CACHE_SIZE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_WRITE_CACHE_SIZE_INVALID ((NTSTATUS)0xC0E70010L)")]
    public const int STATUS_SPACES_WRITE_CACHE_SIZE_INVALID = unchecked((int)(0xC0E70010));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_NUMBER_OF_GROUPS_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_NUMBER_OF_GROUPS_INVALID ((NTSTATUS)0xC0E70011L)")]
    public const int STATUS_SPACES_NUMBER_OF_GROUPS_INVALID = unchecked((int)(0xC0E70011));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_DRIVE_OPERATIONAL_STATE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_DRIVE_OPERATIONAL_STATE_INVALID ((NTSTATUS)0xC0E70012L)")]
    public const int STATUS_SPACES_DRIVE_OPERATIONAL_STATE_INVALID = unchecked((int)(0xC0E70012));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_UPDATE_COLUMN_STATE"]/*' />
    [NativeTypeName("#define STATUS_SPACES_UPDATE_COLUMN_STATE ((NTSTATUS)0xC0E70013L)")]
    public const int STATUS_SPACES_UPDATE_COLUMN_STATE = unchecked((int)(0xC0E70013));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_MAP_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_SPACES_MAP_REQUIRED ((NTSTATUS)0xC0E70014L)")]
    public const int STATUS_SPACES_MAP_REQUIRED = unchecked((int)(0xC0E70014));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_UNSUPPORTED_VERSION"]/*' />
    [NativeTypeName("#define STATUS_SPACES_UNSUPPORTED_VERSION ((NTSTATUS)0xC0E70015L)")]
    public const int STATUS_SPACES_UNSUPPORTED_VERSION = unchecked((int)(0xC0E70015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_CORRUPT_METADATA"]/*' />
    [NativeTypeName("#define STATUS_SPACES_CORRUPT_METADATA ((NTSTATUS)0xC0E70016L)")]
    public const int STATUS_SPACES_CORRUPT_METADATA = unchecked((int)(0xC0E70016));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_DRT_FULL"]/*' />
    [NativeTypeName("#define STATUS_SPACES_DRT_FULL ((NTSTATUS)0xC0E70017L)")]
    public const int STATUS_SPACES_DRT_FULL = unchecked((int)(0xC0E70017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_INCONSISTENCY"]/*' />
    [NativeTypeName("#define STATUS_SPACES_INCONSISTENCY ((NTSTATUS)0xC0E70018L)")]
    public const int STATUS_SPACES_INCONSISTENCY = unchecked((int)(0xC0E70018));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_LOG_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_SPACES_LOG_NOT_READY ((NTSTATUS)0xC0E70019L)")]
    public const int STATUS_SPACES_LOG_NOT_READY = unchecked((int)(0xC0E70019));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_NO_REDUNDANCY"]/*' />
    [NativeTypeName("#define STATUS_SPACES_NO_REDUNDANCY ((NTSTATUS)0xC0E7001AL)")]
    public const int STATUS_SPACES_NO_REDUNDANCY = unchecked((int)(0xC0E7001A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_DRIVE_NOT_READY"]/*' />
    [NativeTypeName("#define STATUS_SPACES_DRIVE_NOT_READY ((NTSTATUS)0xC0E7001BL)")]
    public const int STATUS_SPACES_DRIVE_NOT_READY = unchecked((int)(0xC0E7001B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_DRIVE_SPLIT"]/*' />
    [NativeTypeName("#define STATUS_SPACES_DRIVE_SPLIT ((NTSTATUS)0xC0E7001CL)")]
    public const int STATUS_SPACES_DRIVE_SPLIT = unchecked((int)(0xC0E7001C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_DRIVE_LOST_DATA"]/*' />
    [NativeTypeName("#define STATUS_SPACES_DRIVE_LOST_DATA ((NTSTATUS)0xC0E7001DL)")]
    public const int STATUS_SPACES_DRIVE_LOST_DATA = unchecked((int)(0xC0E7001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_ENTRY_INCOMPLETE"]/*' />
    [NativeTypeName("#define STATUS_SPACES_ENTRY_INCOMPLETE ((NTSTATUS)0xC0E7001EL)")]
    public const int STATUS_SPACES_ENTRY_INCOMPLETE = unchecked((int)(0xC0E7001E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_ENTRY_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_ENTRY_INVALID ((NTSTATUS)0xC0E7001FL)")]
    public const int STATUS_SPACES_ENTRY_INVALID = unchecked((int)(0xC0E7001F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_MARK_DIRTY"]/*' />
    [NativeTypeName("#define STATUS_SPACES_MARK_DIRTY ((NTSTATUS)0xC0E70020L)")]
    public const int STATUS_SPACES_MARK_DIRTY = unchecked((int)(0xC0E70020));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_PD_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_SPACES_PD_NOT_FOUND ((NTSTATUS)0xC0E70021L)")]
    public const int STATUS_SPACES_PD_NOT_FOUND = unchecked((int)(0xC0E70021));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_PD_LENGTH_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_SPACES_PD_LENGTH_MISMATCH ((NTSTATUS)0xC0E70022L)")]
    public const int STATUS_SPACES_PD_LENGTH_MISMATCH = unchecked((int)(0xC0E70022));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_PD_UNSUPPORTED_VERSION"]/*' />
    [NativeTypeName("#define STATUS_SPACES_PD_UNSUPPORTED_VERSION ((NTSTATUS)0xC0E70023L)")]
    public const int STATUS_SPACES_PD_UNSUPPORTED_VERSION = unchecked((int)(0xC0E70023));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_PD_INVALID_DATA"]/*' />
    [NativeTypeName("#define STATUS_SPACES_PD_INVALID_DATA ((NTSTATUS)0xC0E70024L)")]
    public const int STATUS_SPACES_PD_INVALID_DATA = unchecked((int)(0xC0E70024));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_FLUSH_METADATA"]/*' />
    [NativeTypeName("#define STATUS_SPACES_FLUSH_METADATA ((NTSTATUS)0xC0E70025L)")]
    public const int STATUS_SPACES_FLUSH_METADATA = unchecked((int)(0xC0E70025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_CACHE_FULL"]/*' />
    [NativeTypeName("#define STATUS_SPACES_CACHE_FULL ((NTSTATUS)0xC0E70026L)")]
    public const int STATUS_SPACES_CACHE_FULL = unchecked((int)(0xC0E70026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_REPAIR_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_SPACES_REPAIR_IN_PROGRESS ((NTSTATUS)0xC0E70027L)")]
    public const int STATUS_SPACES_REPAIR_IN_PROGRESS = unchecked((int)(0xC0E70027));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_API_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_SPACES_API_VERSION_MISMATCH ((NTSTATUS)0xC0E70028L)")]
    public const int STATUS_SPACES_API_VERSION_MISMATCH = unchecked((int)(0xC0E70028));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SPACES_METADATA_SIZE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_SPACES_METADATA_SIZE_INVALID ((NTSTATUS)0xC0E70029L)")]
    public const int STATUS_SPACES_METADATA_SIZE_INVALID = unchecked((int)(0xC0E70029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLSNAP_BOOTFILE_NOT_VALID"]/*' />
    [NativeTypeName("#define STATUS_VOLSNAP_BOOTFILE_NOT_VALID ((NTSTATUS)0xC0500003L)")]
    public const int STATUS_VOLSNAP_BOOTFILE_NOT_VALID = unchecked((int)(0xC0500003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLSNAP_ACTIVATION_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_VOLSNAP_ACTIVATION_TIMEOUT ((NTSTATUS)0xC0500004L)")]
    public const int STATUS_VOLSNAP_ACTIVATION_TIMEOUT = unchecked((int)(0xC0500004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VOLSNAP_NO_BYPASSIO_WITH_SNAPSHOT"]/*' />
    [NativeTypeName("#define STATUS_VOLSNAP_NO_BYPASSIO_WITH_SNAPSHOT ((NTSTATUS)0xC0500005L)")]
    public const int STATUS_VOLSNAP_NO_BYPASSIO_WITH_SNAPSHOT = unchecked((int)(0xC0500005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IO_PREEMPTED"]/*' />
    [NativeTypeName("#define STATUS_IO_PREEMPTED ((NTSTATUS)0xC0510001L)")]
    public const int STATUS_IO_PREEMPTED = unchecked((int)(0xC0510001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_ERROR_STORED"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_ERROR_STORED ((NTSTATUS)0xC05C0000L)")]
    public const int STATUS_SVHDX_ERROR_STORED = unchecked((int)(0xC05C0000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_ERROR_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_ERROR_NOT_AVAILABLE ((NTSTATUS)0xC05CFF00L)")]
    public const int STATUS_SVHDX_ERROR_NOT_AVAILABLE = unchecked((int)(0xC05CFF00));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_UNIT_ATTENTION_AVAILABLE"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_UNIT_ATTENTION_AVAILABLE ((NTSTATUS)0xC05CFF01L)")]
    public const int STATUS_SVHDX_UNIT_ATTENTION_AVAILABLE = unchecked((int)(0xC05CFF01));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED ((NTSTATUS)0xC05CFF02L)")]
    public const int STATUS_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED = unchecked((int)(0xC05CFF02));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED ((NTSTATUS)0xC05CFF03L)")]
    public const int STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED = unchecked((int)(0xC05CFF03));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED ((NTSTATUS)0xC05CFF04L)")]
    public const int STATUS_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED = unchecked((int)(0xC05CFF04));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED ((NTSTATUS)0xC05CFF05L)")]
    public const int STATUS_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED = unchecked((int)(0xC05CFF05));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED ((NTSTATUS)0xC05CFF06L)")]
    public const int STATUS_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED = unchecked((int)(0xC05CFF06));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_RESERVATION_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_RESERVATION_CONFLICT ((NTSTATUS)0xC05CFF07L)")]
    public const int STATUS_SVHDX_RESERVATION_CONFLICT = unchecked((int)(0xC05CFF07));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_WRONG_FILE_TYPE"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_WRONG_FILE_TYPE ((NTSTATUS)0xC05CFF08L)")]
    public const int STATUS_SVHDX_WRONG_FILE_TYPE = unchecked((int)(0xC05CFF08));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_VERSION_MISMATCH ((NTSTATUS)0xC05CFF09L)")]
    public const int STATUS_SVHDX_VERSION_MISMATCH = unchecked((int)(0xC05CFF09));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHD_SHARED"]/*' />
    [NativeTypeName("#define STATUS_VHD_SHARED ((NTSTATUS)0xC05CFF0AL)")]
    public const int STATUS_VHD_SHARED = unchecked((int)(0xC05CFF0A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SVHDX_NO_INITIATOR"]/*' />
    [NativeTypeName("#define STATUS_SVHDX_NO_INITIATOR ((NTSTATUS)0xC05CFF0BL)")]
    public const int STATUS_SVHDX_NO_INITIATOR = unchecked((int)(0xC05CFF0B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VHDSET_BACKING_STORAGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_VHDSET_BACKING_STORAGE_NOT_FOUND ((NTSTATUS)0xC05CFF0CL)")]
    public const int STATUS_VHDSET_BACKING_STORAGE_NOT_FOUND = unchecked((int)(0xC05CFF0C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP"]/*' />
    [NativeTypeName("#define STATUS_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP ((NTSTATUS)0xC05D0000L)")]
    public const int STATUS_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP = unchecked((int)(0xC05D0000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_BAD_CLUSTER_DIALECT"]/*' />
    [NativeTypeName("#define STATUS_SMB_BAD_CLUSTER_DIALECT ((NTSTATUS)0xC05D0001L)")]
    public const int STATUS_SMB_BAD_CLUSTER_DIALECT = unchecked((int)(0xC05D0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_GUEST_LOGON_BLOCKED"]/*' />
    [NativeTypeName("#define STATUS_SMB_GUEST_LOGON_BLOCKED ((NTSTATUS)0xC05D0002L)")]
    public const int STATUS_SMB_GUEST_LOGON_BLOCKED = unchecked((int)(0xC05D0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_NO_SIGNING_ALGORITHM_OVERLAP"]/*' />
    [NativeTypeName("#define STATUS_SMB_NO_SIGNING_ALGORITHM_OVERLAP ((NTSTATUS)0xC05D0003L)")]
    public const int STATUS_SMB_NO_SIGNING_ALGORITHM_OVERLAP = unchecked((int)(0xC05D0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NETWORK_AUTHENTICATION_PROMPT_CANCELED"]/*' />
    [NativeTypeName("#define STATUS_NETWORK_AUTHENTICATION_PROMPT_CANCELED ((NTSTATUS)0xC05D0004L)")]
    public const int STATUS_NETWORK_AUTHENTICATION_PROMPT_CANCELED = unchecked((int)(0xC05D0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REMOTE_MAILSLOTS_DEPRECATED"]/*' />
    [NativeTypeName("#define STATUS_REMOTE_MAILSLOTS_DEPRECATED ((NTSTATUS)0xC05D0005L)")]
    public const int STATUS_REMOTE_MAILSLOTS_DEPRECATED = unchecked((int)(0xC05D0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_GUEST_LOGON_BLOCKED_SIGNING_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_SMB_GUEST_LOGON_BLOCKED_SIGNING_REQUIRED ((NTSTATUS)0xC05D0006L)")]
    public const int STATUS_SMB_GUEST_LOGON_BLOCKED_SIGNING_REQUIRED = unchecked((int)(0xC05D0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_GUEST_ENCRYPTION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_SMB_GUEST_ENCRYPTION_NOT_SUPPORTED ((NTSTATUS)0xC05D0007L)")]
    public const int STATUS_SMB_GUEST_ENCRYPTION_NOT_SUPPORTED = unchecked((int)(0xC05D0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_ENCRYPTION_NOT_SUPPORTED_BY_PEER"]/*' />
    [NativeTypeName("#define STATUS_SMB_ENCRYPTION_NOT_SUPPORTED_BY_PEER ((NTSTATUS)0xC05D0008L)")]
    public const int STATUS_SMB_ENCRYPTION_NOT_SUPPORTED_BY_PEER = unchecked((int)(0xC05D0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_TLS_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_SMB_TLS_ACCESS_DENIED ((NTSTATUS)0xC05D0009L)")]
    public const int STATUS_SMB_TLS_ACCESS_DENIED = unchecked((int)(0xC05D0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SMB_ALTERNATIVE_PORT_CONFLICT"]/*' />
    [NativeTypeName("#define STATUS_SMB_ALTERNATIVE_PORT_CONFLICT ((NTSTATUS)0xC05D000DL)")]
    public const int STATUS_SMB_ALTERNATIVE_PORT_CONFLICT = unchecked((int)(0xC05D000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SECCORE_INVALID_COMMAND"]/*' />
    [NativeTypeName("#define STATUS_SECCORE_INVALID_COMMAND ((NTSTATUS)0xC0E80000L)")]
    public const int STATUS_SECCORE_INVALID_COMMAND = unchecked((int)(0xC0E80000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VSM_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define STATUS_VSM_NOT_INITIALIZED ((NTSTATUS)0xC0450000L)")]
    public const int STATUS_VSM_NOT_INITIALIZED = unchecked((int)(0xC0450000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VSM_DMA_PROTECTION_NOT_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_VSM_DMA_PROTECTION_NOT_IN_USE ((NTSTATUS)0xC0450001L)")]
    public const int STATUS_VSM_DMA_PROTECTION_NOT_IN_USE = unchecked((int)(0xC0450001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VSM_KEY_CI_POLICY_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define STATUS_VSM_KEY_CI_POLICY_ROLLBACK_DETECTED ((NTSTATUS)0xC0450002L)")]
    public const int STATUS_VSM_KEY_CI_POLICY_ROLLBACK_DETECTED = unchecked((int)(0xC0450002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VSMIDK_KEYGEN_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_VSMIDK_KEYGEN_FAILURE ((NTSTATUS)0xC0450003L)")]
    public const int STATUS_VSMIDK_KEYGEN_FAILURE = unchecked((int)(0xC0450003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VSMIDK_EXPORT_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_VSMIDK_EXPORT_FAILURE ((NTSTATUS)0xC0450004L)")]
    public const int STATUS_VSMIDK_EXPORT_FAILURE = unchecked((int)(0xC0450004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VSMIDK_MODULUS_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_VSMIDK_MODULUS_MISMATCH ((NTSTATUS)0xC0450005L)")]
    public const int STATUS_VSMIDK_MODULUS_MISMATCH = unchecked((int)(0xC0450005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_VSM_FW_MEASUREMENTS_SEAL_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_VSM_FW_MEASUREMENTS_SEAL_FAILURE ((NTSTATUS)0xC0450006L)")]
    public const int STATUS_VSM_FW_MEASUREMENTS_SEAL_FAILURE = unchecked((int)(0xC0450006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_CONDITION_NOT_SATISFIED"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_CONDITION_NOT_SATISFIED ((NTSTATUS)0xC0EC0000L)")]
    public const int STATUS_APPEXEC_CONDITION_NOT_SATISFIED = unchecked((int)(0xC0EC0000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_HANDLE_INVALIDATED"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_HANDLE_INVALIDATED ((NTSTATUS)0xC0EC0001L)")]
    public const int STATUS_APPEXEC_HANDLE_INVALIDATED = unchecked((int)(0xC0EC0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_INVALID_HOST_GENERATION"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_INVALID_HOST_GENERATION ((NTSTATUS)0xC0EC0002L)")]
    public const int STATUS_APPEXEC_INVALID_HOST_GENERATION = unchecked((int)(0xC0EC0002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION ((NTSTATUS)0xC0EC0003L)")]
    public const int STATUS_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION = unchecked((int)(0xC0EC0003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_INVALID_HOST_STATE"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_INVALID_HOST_STATE ((NTSTATUS)0xC0EC0004L)")]
    public const int STATUS_APPEXEC_INVALID_HOST_STATE = unchecked((int)(0xC0EC0004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_NO_DONOR"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_NO_DONOR ((NTSTATUS)0xC0EC0005L)")]
    public const int STATUS_APPEXEC_NO_DONOR = unchecked((int)(0xC0EC0005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_HOST_ID_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_HOST_ID_MISMATCH ((NTSTATUS)0xC0EC0006L)")]
    public const int STATUS_APPEXEC_HOST_ID_MISMATCH = unchecked((int)(0xC0EC0006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_UNKNOWN_USER"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_UNKNOWN_USER ((NTSTATUS)0xC0EC0007L)")]
    public const int STATUS_APPEXEC_UNKNOWN_USER = unchecked((int)(0xC0EC0007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_APP_COMPAT_BLOCK"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_APP_COMPAT_BLOCK ((NTSTATUS)0xC0EC0008L)")]
    public const int STATUS_APPEXEC_APP_COMPAT_BLOCK = unchecked((int)(0xC0EC0008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_CALLER_WAIT_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_CALLER_WAIT_TIMEOUT ((NTSTATUS)0xC0EC0009L)")]
    public const int STATUS_APPEXEC_CALLER_WAIT_TIMEOUT = unchecked((int)(0xC0EC0009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_TERMINATION"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_TERMINATION ((NTSTATUS)0xC0EC000AL)")]
    public const int STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_TERMINATION = unchecked((int)(0xC0EC000A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_LICENSING"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_LICENSING ((NTSTATUS)0xC0EC000BL)")]
    public const int STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_LICENSING = unchecked((int)(0xC0EC000B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_RESOURCES"]/*' />
    [NativeTypeName("#define STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_RESOURCES ((NTSTATUS)0xC0EC000CL)")]
    public const int STATUS_APPEXEC_CALLER_WAIT_TIMEOUT_RESOURCES = unchecked((int)(0xC0EC000C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_HANDSHAKE_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_QUIC_HANDSHAKE_FAILURE ((NTSTATUS)0xC0240000L)")]
    public const int STATUS_QUIC_HANDSHAKE_FAILURE = unchecked((int)(0xC0240000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_VER_NEG_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_QUIC_VER_NEG_FAILURE ((NTSTATUS)0xC0240001L)")]
    public const int STATUS_QUIC_VER_NEG_FAILURE = unchecked((int)(0xC0240001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_USER_CANCELED"]/*' />
    [NativeTypeName("#define STATUS_QUIC_USER_CANCELED ((NTSTATUS)0xC0240002L)")]
    public const int STATUS_QUIC_USER_CANCELED = unchecked((int)(0xC0240002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_QUIC_INTERNAL_ERROR ((NTSTATUS)0xC0240003L)")]
    public const int STATUS_QUIC_INTERNAL_ERROR = unchecked((int)(0xC0240003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_PROTOCOL_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_QUIC_PROTOCOL_VIOLATION ((NTSTATUS)0xC0240004L)")]
    public const int STATUS_QUIC_PROTOCOL_VIOLATION = unchecked((int)(0xC0240004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_CONNECTION_IDLE"]/*' />
    [NativeTypeName("#define STATUS_QUIC_CONNECTION_IDLE ((NTSTATUS)0xC0240005L)")]
    public const int STATUS_QUIC_CONNECTION_IDLE = unchecked((int)(0xC0240005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_CONNECTION_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_QUIC_CONNECTION_TIMEOUT ((NTSTATUS)0xC0240006L)")]
    public const int STATUS_QUIC_CONNECTION_TIMEOUT = unchecked((int)(0xC0240006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_ALPN_NEG_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_QUIC_ALPN_NEG_FAILURE ((NTSTATUS)0xC0240007L)")]
    public const int STATUS_QUIC_ALPN_NEG_FAILURE = unchecked((int)(0xC0240007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_STREAM_LIMIT_REACHED"]/*' />
    [NativeTypeName("#define STATUS_QUIC_STREAM_LIMIT_REACHED ((NTSTATUS)0xC0240008L)")]
    public const int STATUS_QUIC_STREAM_LIMIT_REACHED = unchecked((int)(0xC0240008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_ALPN_IN_USE"]/*' />
    [NativeTypeName("#define STATUS_QUIC_ALPN_IN_USE ((NTSTATUS)0xC0240009L)")]
    public const int STATUS_QUIC_ALPN_IN_USE = unchecked((int)(0xC0240009));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_UNEXPECTED_MESSAGE"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_UNEXPECTED_MESSAGE ((NTSTATUS)0xC024010AL)")]
    public const int STATUS_QUIC_TLS_UNEXPECTED_MESSAGE = unchecked((int)(0xC024010A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_BAD_CERTIFICATE"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_BAD_CERTIFICATE ((NTSTATUS)0xC024012AL)")]
    public const int STATUS_QUIC_TLS_BAD_CERTIFICATE = unchecked((int)(0xC024012A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_UNSUPPORTED_CERTIFICATE"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_UNSUPPORTED_CERTIFICATE ((NTSTATUS)0xC024012BL)")]
    public const int STATUS_QUIC_TLS_UNSUPPORTED_CERTIFICATE = unchecked((int)(0xC024012B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_CERTIFICATE_REVOKED"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_CERTIFICATE_REVOKED ((NTSTATUS)0xC024012CL)")]
    public const int STATUS_QUIC_TLS_CERTIFICATE_REVOKED = unchecked((int)(0xC024012C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_CERTIFICATE_EXPIRED"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_CERTIFICATE_EXPIRED ((NTSTATUS)0xC024012DL)")]
    public const int STATUS_QUIC_TLS_CERTIFICATE_EXPIRED = unchecked((int)(0xC024012D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_CERTIFICATE_UNKNOWN"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_CERTIFICATE_UNKNOWN ((NTSTATUS)0xC024012EL)")]
    public const int STATUS_QUIC_TLS_CERTIFICATE_UNKNOWN = unchecked((int)(0xC024012E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_ILLEGAL_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_ILLEGAL_PARAMETER ((NTSTATUS)0xC024012FL)")]
    public const int STATUS_QUIC_TLS_ILLEGAL_PARAMETER = unchecked((int)(0xC024012F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_UNKNOWN_CA"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_UNKNOWN_CA ((NTSTATUS)0xC0240130L)")]
    public const int STATUS_QUIC_TLS_UNKNOWN_CA = unchecked((int)(0xC0240130));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_ACCESS_DENIED ((NTSTATUS)0xC0240131L)")]
    public const int STATUS_QUIC_TLS_ACCESS_DENIED = unchecked((int)(0xC0240131));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_INSUFFICIENT_SECURITY"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_INSUFFICIENT_SECURITY ((NTSTATUS)0xC0240147L)")]
    public const int STATUS_QUIC_TLS_INSUFFICIENT_SECURITY = unchecked((int)(0xC0240147));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_INTERNAL_ERROR ((NTSTATUS)0xC0240150L)")]
    public const int STATUS_QUIC_TLS_INTERNAL_ERROR = unchecked((int)(0xC0240150));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_USER_CANCELED"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_USER_CANCELED ((NTSTATUS)0xC024015AL)")]
    public const int STATUS_QUIC_TLS_USER_CANCELED = unchecked((int)(0xC024015A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_QUIC_TLS_CERTIFICATE_REQUIRED"]/*' />
    [NativeTypeName("#define STATUS_QUIC_TLS_CERTIFICATE_REQUIRED ((NTSTATUS)0xC0240174L)")]
    public const int STATUS_QUIC_TLS_CERTIFICATE_REQUIRED = unchecked((int)(0xC0240174));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IORING_REQUIRED_FLAG_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_IORING_REQUIRED_FLAG_NOT_SUPPORTED ((NTSTATUS)0xC0460001L)")]
    public const int STATUS_IORING_REQUIRED_FLAG_NOT_SUPPORTED = unchecked((int)(0xC0460001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IORING_SUBMISSION_QUEUE_FULL"]/*' />
    [NativeTypeName("#define STATUS_IORING_SUBMISSION_QUEUE_FULL ((NTSTATUS)0xC0460002L)")]
    public const int STATUS_IORING_SUBMISSION_QUEUE_FULL = unchecked((int)(0xC0460002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IORING_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define STATUS_IORING_VERSION_NOT_SUPPORTED ((NTSTATUS)0xC0460003L)")]
    public const int STATUS_IORING_VERSION_NOT_SUPPORTED = unchecked((int)(0xC0460003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IORING_SUBMISSION_QUEUE_TOO_BIG"]/*' />
    [NativeTypeName("#define STATUS_IORING_SUBMISSION_QUEUE_TOO_BIG ((NTSTATUS)0xC0460004L)")]
    public const int STATUS_IORING_SUBMISSION_QUEUE_TOO_BIG = unchecked((int)(0xC0460004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IORING_COMPLETION_QUEUE_TOO_BIG"]/*' />
    [NativeTypeName("#define STATUS_IORING_COMPLETION_QUEUE_TOO_BIG ((NTSTATUS)0xC0460005L)")]
    public const int STATUS_IORING_COMPLETION_QUEUE_TOO_BIG = unchecked((int)(0xC0460005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IORING_SUBMIT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define STATUS_IORING_SUBMIT_IN_PROGRESS ((NTSTATUS)0xC0460006L)")]
    public const int STATUS_IORING_SUBMIT_IN_PROGRESS = unchecked((int)(0xC0460006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IORING_CORRUPT"]/*' />
    [NativeTypeName("#define STATUS_IORING_CORRUPT ((NTSTATUS)0xC0460007L)")]
    public const int STATUS_IORING_CORRUPT = unchecked((int)(0xC0460007));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IORING_COMPLETION_QUEUE_TOO_FULL"]/*' />
    [NativeTypeName("#define STATUS_IORING_COMPLETION_QUEUE_TOO_FULL ((NTSTATUS)0xC0460008L)")]
    public const int STATUS_IORING_COMPLETION_QUEUE_TOO_FULL = unchecked((int)(0xC0460008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_HANDLER_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PRM_HANDLER_NOT_FOUND ((NTSTATUS)0xC0EE0200L)")]
    public const int STATUS_PRM_HANDLER_NOT_FOUND = unchecked((int)(0xC0EE0200));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_CONCURRENT_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_PRM_CONCURRENT_OPERATION ((NTSTATUS)0xC0EE0202L)")]
    public const int STATUS_PRM_CONCURRENT_OPERATION = unchecked((int)(0xC0EE0202));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_MODULE_UPDATE_PENDING"]/*' />
    [NativeTypeName("#define STATUS_PRM_MODULE_UPDATE_PENDING ((NTSTATUS)0xC0EE0203L)")]
    public const int STATUS_PRM_MODULE_UPDATE_PENDING = unchecked((int)(0xC0EE0203));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_MODULE_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_PRM_MODULE_LOCKED ((NTSTATUS)0xC0EE0204L)")]
    public const int STATUS_PRM_MODULE_LOCKED = unchecked((int)(0xC0EE0204));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_UPDATE_INCOMPATIBLE_VERSION"]/*' />
    [NativeTypeName("#define STATUS_PRM_UPDATE_INCOMPATIBLE_VERSION ((NTSTATUS)0xC0EE0205L)")]
    public const int STATUS_PRM_UPDATE_INCOMPATIBLE_VERSION = unchecked((int)(0xC0EE0205));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_UPDATE_MODULE_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_PRM_UPDATE_MODULE_MISMATCH ((NTSTATUS)0xC0EE0206L)")]
    public const int STATUS_PRM_UPDATE_MODULE_MISMATCH = unchecked((int)(0xC0EE0206));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_UPDATE_MODULE_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_PRM_UPDATE_MODULE_NOT_FOUND ((NTSTATUS)0xC0EE0207L)")]
    public const int STATUS_PRM_UPDATE_MODULE_NOT_FOUND = unchecked((int)(0xC0EE0207));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_UPDATE_MISSING_EXPORT"]/*' />
    [NativeTypeName("#define STATUS_PRM_UPDATE_MISSING_EXPORT ((NTSTATUS)0xC0EE0208L)")]
    public const int STATUS_PRM_UPDATE_MISSING_EXPORT = unchecked((int)(0xC0EE0208));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_UPDATE_MODULE_LOCKED"]/*' />
    [NativeTypeName("#define STATUS_PRM_UPDATE_MODULE_LOCKED ((NTSTATUS)0xC0EE0209L)")]
    public const int STATUS_PRM_UPDATE_MODULE_LOCKED = unchecked((int)(0xC0EE0209));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_UPDATE_BAD_SIGNATURE"]/*' />
    [NativeTypeName("#define STATUS_PRM_UPDATE_BAD_SIGNATURE ((NTSTATUS)0xC0EE020AL)")]
    public const int STATUS_PRM_UPDATE_BAD_SIGNATURE = unchecked((int)(0xC0EE020A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_UPDATE_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_PRM_UPDATE_VERSION_MISMATCH ((NTSTATUS)0xC0EE020BL)")]
    public const int STATUS_PRM_UPDATE_VERSION_MISMATCH = unchecked((int)(0xC0EE020B));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_MODULE_UNLOCKED"]/*' />
    [NativeTypeName("#define STATUS_PRM_MODULE_UNLOCKED ((NTSTATUS)0xC0EE020CL)")]
    public const int STATUS_PRM_MODULE_UNLOCKED = unchecked((int)(0xC0EE020C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRM_INTERFACE_INACCESSIBLE"]/*' />
    [NativeTypeName("#define STATUS_PRM_INTERFACE_INACCESSIBLE ((NTSTATUS)0xC0EE020DL)")]
    public const int STATUS_PRM_INTERFACE_INACCESSIBLE = unchecked((int)(0xC0EE020D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCELERATOR_SUBMISSION_QUEUE_FULL"]/*' />
    [NativeTypeName("#define STATUS_ACCELERATOR_SUBMISSION_QUEUE_FULL ((NTSTATUS)0xC0EF0001L)")]
    public const int STATUS_ACCELERATOR_SUBMISSION_QUEUE_FULL = unchecked((int)(0xC0EF0001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_APNONCE_INVALID"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_APNONCE_INVALID ((NTSTATUS)0xC0048550L)")]
    public const int STATUS_AAD_CLOUDAP_E_APNONCE_INVALID = unchecked((int)(0xC0048550));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_BAD_DEVICE_ACCESS_TOKEN_FORMAT"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_BAD_DEVICE_ACCESS_TOKEN_FORMAT ((NTSTATUS)0xC0048551L)")]
    public const int STATUS_AAD_CLOUDAP_E_BAD_DEVICE_ACCESS_TOKEN_FORMAT = unchecked((int)(0xC0048551));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_ASSERTION_MALFORMED"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_ASSERTION_MALFORMED ((NTSTATUS)0xC0048552L)")]
    public const int STATUS_AAD_CLOUDAP_E_ASSERTION_MALFORMED = unchecked((int)(0xC0048552));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_INVALID_TENANT"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_INVALID_TENANT ((NTSTATUS)0xC0048553L)")]
    public const int STATUS_AAD_CLOUDAP_E_INVALID_TENANT = unchecked((int)(0xC0048553));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_INVALID_DEVICE"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_INVALID_DEVICE ((NTSTATUS)0xC0048554L)")]
    public const int STATUS_AAD_CLOUDAP_E_INVALID_DEVICE = unchecked((int)(0xC0048554));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_INVALID_ACCESS_TOKEN"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_INVALID_ACCESS_TOKEN ((NTSTATUS)0xC0048556L)")]
    public const int STATUS_AAD_CLOUDAP_E_INVALID_ACCESS_TOKEN = unchecked((int)(0xC0048556));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_INVALID_BINDING_KEY_ID"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_INVALID_BINDING_KEY_ID ((NTSTATUS)0xC0048557L)")]
    public const int STATUS_AAD_CLOUDAP_E_INVALID_BINDING_KEY_ID = unchecked((int)(0xC0048557));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_CANT_FIND_ROOT_CERT"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_CANT_FIND_ROOT_CERT ((NTSTATUS)0xC0048559L)")]
    public const int STATUS_AAD_CLOUDAP_E_CANT_FIND_ROOT_CERT = unchecked((int)(0xC0048559));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_ASSERTION_INVALID"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_ASSERTION_INVALID ((NTSTATUS)0xC004855AL)")]
    public const int STATUS_AAD_CLOUDAP_E_ASSERTION_INVALID = unchecked((int)(0xC004855A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_AAD_CLOUDAP_E_CALLER_MISMATCH"]/*' />
    [NativeTypeName("#define STATUS_AAD_CLOUDAP_E_CALLER_MISMATCH ((NTSTATUS)0xC004855BL)")]
    public const int STATUS_AAD_CLOUDAP_E_CALLER_MISMATCH = unchecked((int)(0xC004855B));
}
