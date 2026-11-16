// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ERROR
{
    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SUCCESS"]/*' />
    [NativeTypeName("#define ERROR_SUCCESS 0L")]
    public const int ERROR_SUCCESS = 0;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FUNCTION"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FUNCTION 1L")]
    public const int ERROR_INVALID_FUNCTION = 1;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_FILE_NOT_FOUND 2L")]
    public const int ERROR_FILE_NOT_FOUND = 2;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATH_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PATH_NOT_FOUND 3L")]
    public const int ERROR_PATH_NOT_FOUND = 3;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_OPEN_FILES"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_OPEN_FILES 4L")]
    public const int ERROR_TOO_MANY_OPEN_FILES = 4;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_ACCESS_DENIED 5L")]
    public const int ERROR_ACCESS_DENIED = 5;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_HANDLE 6L")]
    public const int ERROR_INVALID_HANDLE = 6;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ARENA_TRASHED"]/*' />
    [NativeTypeName("#define ERROR_ARENA_TRASHED 7L")]
    public const int ERROR_ARENA_TRASHED = 7;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_ENOUGH_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_NOT_ENOUGH_MEMORY 8L")]
    public const int ERROR_NOT_ENOUGH_MEMORY = 8;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_BLOCK"]/*' />
    [NativeTypeName("#define ERROR_INVALID_BLOCK 9L")]
    public const int ERROR_INVALID_BLOCK = 9;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_ENVIRONMENT"]/*' />
    [NativeTypeName("#define ERROR_BAD_ENVIRONMENT 10L")]
    public const int ERROR_BAD_ENVIRONMENT = 10;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_BAD_FORMAT 11L")]
    public const int ERROR_BAD_FORMAT = 11;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ACCESS"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ACCESS 12L")]
    public const int ERROR_INVALID_ACCESS = 12;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DATA"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DATA 13L")]
    public const int ERROR_INVALID_DATA = 13;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OUTOFMEMORY"]/*' />
    [NativeTypeName("#define ERROR_OUTOFMEMORY 14L")]
    public const int ERROR_OUTOFMEMORY = 14;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DRIVE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DRIVE 15L")]
    public const int ERROR_INVALID_DRIVE = 15;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CURRENT_DIRECTORY"]/*' />
    [NativeTypeName("#define ERROR_CURRENT_DIRECTORY 16L")]
    public const int ERROR_CURRENT_DIRECTORY = 16;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SAME_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_NOT_SAME_DEVICE 17L")]
    public const int ERROR_NOT_SAME_DEVICE = 17;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_MORE_FILES"]/*' />
    [NativeTypeName("#define ERROR_NO_MORE_FILES 18L")]
    public const int ERROR_NO_MORE_FILES = 18;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRITE_PROTECT"]/*' />
    [NativeTypeName("#define ERROR_WRITE_PROTECT 19L")]
    public const int ERROR_WRITE_PROTECT = 19;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_UNIT"]/*' />
    [NativeTypeName("#define ERROR_BAD_UNIT 20L")]
    public const int ERROR_BAD_UNIT = 20;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_NOT_READY 21L")]
    public const int ERROR_NOT_READY = 21;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_COMMAND"]/*' />
    [NativeTypeName("#define ERROR_BAD_COMMAND 22L")]
    public const int ERROR_BAD_COMMAND = 22;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CRC"]/*' />
    [NativeTypeName("#define ERROR_CRC 23L")]
    public const int ERROR_CRC = 23;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_LENGTH"]/*' />
    [NativeTypeName("#define ERROR_BAD_LENGTH 24L")]
    public const int ERROR_BAD_LENGTH = 24;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SEEK"]/*' />
    [NativeTypeName("#define ERROR_SEEK 25L")]
    public const int ERROR_SEEK = 25;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_DOS_DISK"]/*' />
    [NativeTypeName("#define ERROR_NOT_DOS_DISK 26L")]
    public const int ERROR_NOT_DOS_DISK = 26;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECTOR_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SECTOR_NOT_FOUND 27L")]
    public const int ERROR_SECTOR_NOT_FOUND = 27;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OUT_OF_PAPER"]/*' />
    [NativeTypeName("#define ERROR_OUT_OF_PAPER 28L")]
    public const int ERROR_OUT_OF_PAPER = 28;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRITE_FAULT"]/*' />
    [NativeTypeName("#define ERROR_WRITE_FAULT 29L")]
    public const int ERROR_WRITE_FAULT = 29;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_READ_FAULT"]/*' />
    [NativeTypeName("#define ERROR_READ_FAULT 30L")]
    public const int ERROR_READ_FAULT = 30;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GEN_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_GEN_FAILURE 31L")]
    public const int ERROR_GEN_FAILURE = 31;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHARING_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_SHARING_VIOLATION 32L")]
    public const int ERROR_SHARING_VIOLATION = 32;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOCK_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_LOCK_VIOLATION 33L")]
    public const int ERROR_LOCK_VIOLATION = 33;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRONG_DISK"]/*' />
    [NativeTypeName("#define ERROR_WRONG_DISK 34L")]
    public const int ERROR_WRONG_DISK = 34;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHARING_BUFFER_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_SHARING_BUFFER_EXCEEDED 36L")]
    public const int ERROR_SHARING_BUFFER_EXCEEDED = 36;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HANDLE_EOF"]/*' />
    [NativeTypeName("#define ERROR_HANDLE_EOF 38L")]
    public const int ERROR_HANDLE_EOF = 38;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HANDLE_DISK_FULL"]/*' />
    [NativeTypeName("#define ERROR_HANDLE_DISK_FULL 39L")]
    public const int ERROR_HANDLE_DISK_FULL = 39;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED 50L")]
    public const int ERROR_NOT_SUPPORTED = 50;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REM_NOT_LIST"]/*' />
    [NativeTypeName("#define ERROR_REM_NOT_LIST 51L")]
    public const int ERROR_REM_NOT_LIST = 51;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DUP_NAME"]/*' />
    [NativeTypeName("#define ERROR_DUP_NAME 52L")]
    public const int ERROR_DUP_NAME = 52;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_NETPATH"]/*' />
    [NativeTypeName("#define ERROR_BAD_NETPATH 53L")]
    public const int ERROR_BAD_NETPATH = 53;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NETWORK_BUSY"]/*' />
    [NativeTypeName("#define ERROR_NETWORK_BUSY 54L")]
    public const int ERROR_NETWORK_BUSY = 54;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEV_NOT_EXIST"]/*' />
    [NativeTypeName("#define ERROR_DEV_NOT_EXIST 55L")]
    public const int ERROR_DEV_NOT_EXIST = 55;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_CMDS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_CMDS 56L")]
    public const int ERROR_TOO_MANY_CMDS = 56;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ADAP_HDW_ERR"]/*' />
    [NativeTypeName("#define ERROR_ADAP_HDW_ERR 57L")]
    public const int ERROR_ADAP_HDW_ERR = 57;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_NET_RESP"]/*' />
    [NativeTypeName("#define ERROR_BAD_NET_RESP 58L")]
    public const int ERROR_BAD_NET_RESP = 58;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNEXP_NET_ERR"]/*' />
    [NativeTypeName("#define ERROR_UNEXP_NET_ERR 59L")]
    public const int ERROR_UNEXP_NET_ERR = 59;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_REM_ADAP"]/*' />
    [NativeTypeName("#define ERROR_BAD_REM_ADAP 60L")]
    public const int ERROR_BAD_REM_ADAP = 60;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTQ_FULL"]/*' />
    [NativeTypeName("#define ERROR_PRINTQ_FULL 61L")]
    public const int ERROR_PRINTQ_FULL = 61;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SPOOL_SPACE"]/*' />
    [NativeTypeName("#define ERROR_NO_SPOOL_SPACE 62L")]
    public const int ERROR_NO_SPOOL_SPACE = 62;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINT_CANCELLED"]/*' />
    [NativeTypeName("#define ERROR_PRINT_CANCELLED 63L")]
    public const int ERROR_PRINT_CANCELLED = 63;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NETNAME_DELETED"]/*' />
    [NativeTypeName("#define ERROR_NETNAME_DELETED 64L")]
    public const int ERROR_NETNAME_DELETED = 64;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NETWORK_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_NETWORK_ACCESS_DENIED 65L")]
    public const int ERROR_NETWORK_ACCESS_DENIED = 65;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_DEV_TYPE"]/*' />
    [NativeTypeName("#define ERROR_BAD_DEV_TYPE 66L")]
    public const int ERROR_BAD_DEV_TYPE = 66;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_NET_NAME"]/*' />
    [NativeTypeName("#define ERROR_BAD_NET_NAME 67L")]
    public const int ERROR_BAD_NET_NAME = 67;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_NAMES"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_NAMES 68L")]
    public const int ERROR_TOO_MANY_NAMES = 68;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_SESS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_SESS 69L")]
    public const int ERROR_TOO_MANY_SESS = 69;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHARING_PAUSED"]/*' />
    [NativeTypeName("#define ERROR_SHARING_PAUSED 70L")]
    public const int ERROR_SHARING_PAUSED = 70;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REQ_NOT_ACCEP"]/*' />
    [NativeTypeName("#define ERROR_REQ_NOT_ACCEP 71L")]
    public const int ERROR_REQ_NOT_ACCEP = 71;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REDIR_PAUSED"]/*' />
    [NativeTypeName("#define ERROR_REDIR_PAUSED 72L")]
    public const int ERROR_REDIR_PAUSED = 72;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_FILE_EXISTS 80L")]
    public const int ERROR_FILE_EXISTS = 80;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_MAKE"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_MAKE 82L")]
    public const int ERROR_CANNOT_MAKE = 82;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAIL_I24"]/*' />
    [NativeTypeName("#define ERROR_FAIL_I24 83L")]
    public const int ERROR_FAIL_I24 = 83;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OUT_OF_STRUCTURES"]/*' />
    [NativeTypeName("#define ERROR_OUT_OF_STRUCTURES 84L")]
    public const int ERROR_OUT_OF_STRUCTURES = 84;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_ASSIGNED"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_ASSIGNED 85L")]
    public const int ERROR_ALREADY_ASSIGNED = 85;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PASSWORD"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PASSWORD 86L")]
    public const int ERROR_INVALID_PASSWORD = 86;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PARAMETER 87L")]
    public const int ERROR_INVALID_PARAMETER = 87;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NET_WRITE_FAULT"]/*' />
    [NativeTypeName("#define ERROR_NET_WRITE_FAULT 88L")]
    public const int ERROR_NET_WRITE_FAULT = 88;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_PROC_SLOTS"]/*' />
    [NativeTypeName("#define ERROR_NO_PROC_SLOTS 89L")]
    public const int ERROR_NO_PROC_SLOTS = 89;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_SEMAPHORES"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_SEMAPHORES 100L")]
    public const int ERROR_TOO_MANY_SEMAPHORES = 100;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXCL_SEM_ALREADY_OWNED"]/*' />
    [NativeTypeName("#define ERROR_EXCL_SEM_ALREADY_OWNED 101L")]
    public const int ERROR_EXCL_SEM_ALREADY_OWNED = 101;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SEM_IS_SET"]/*' />
    [NativeTypeName("#define ERROR_SEM_IS_SET 102L")]
    public const int ERROR_SEM_IS_SET = 102;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_SEM_REQUESTS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_SEM_REQUESTS 103L")]
    public const int ERROR_TOO_MANY_SEM_REQUESTS = 103;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_AT_INTERRUPT_TIME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_AT_INTERRUPT_TIME 104L")]
    public const int ERROR_INVALID_AT_INTERRUPT_TIME = 104;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SEM_OWNER_DIED"]/*' />
    [NativeTypeName("#define ERROR_SEM_OWNER_DIED 105L")]
    public const int ERROR_SEM_OWNER_DIED = 105;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SEM_USER_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_SEM_USER_LIMIT 106L")]
    public const int ERROR_SEM_USER_LIMIT = 106;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_CHANGE"]/*' />
    [NativeTypeName("#define ERROR_DISK_CHANGE 107L")]
    public const int ERROR_DISK_CHANGE = 107;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVE_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_DRIVE_LOCKED 108L")]
    public const int ERROR_DRIVE_LOCKED = 108;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BROKEN_PIPE"]/*' />
    [NativeTypeName("#define ERROR_BROKEN_PIPE 109L")]
    public const int ERROR_BROKEN_PIPE = 109;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPEN_FAILED"]/*' />
    [NativeTypeName("#define ERROR_OPEN_FAILED 110L")]
    public const int ERROR_OPEN_FAILED = 110;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BUFFER_OVERFLOW"]/*' />
    [NativeTypeName("#define ERROR_BUFFER_OVERFLOW 111L")]
    public const int ERROR_BUFFER_OVERFLOW = 111;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_FULL"]/*' />
    [NativeTypeName("#define ERROR_DISK_FULL 112L")]
    public const int ERROR_DISK_FULL = 112;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_MORE_SEARCH_HANDLES"]/*' />
    [NativeTypeName("#define ERROR_NO_MORE_SEARCH_HANDLES 113L")]
    public const int ERROR_NO_MORE_SEARCH_HANDLES = 113;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TARGET_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TARGET_HANDLE 114L")]
    public const int ERROR_INVALID_TARGET_HANDLE = 114;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CATEGORY"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CATEGORY 117L")]
    public const int ERROR_INVALID_CATEGORY = 117;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_VERIFY_SWITCH"]/*' />
    [NativeTypeName("#define ERROR_INVALID_VERIFY_SWITCH 118L")]
    public const int ERROR_INVALID_VERIFY_SWITCH = 118;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_DRIVER_LEVEL"]/*' />
    [NativeTypeName("#define ERROR_BAD_DRIVER_LEVEL 119L")]
    public const int ERROR_BAD_DRIVER_LEVEL = 119;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CALL_NOT_IMPLEMENTED"]/*' />
    [NativeTypeName("#define ERROR_CALL_NOT_IMPLEMENTED 120L")]
    public const int ERROR_CALL_NOT_IMPLEMENTED = 120;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SEM_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_SEM_TIMEOUT 121L")]
    public const int ERROR_SEM_TIMEOUT = 121;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define ERROR_INSUFFICIENT_BUFFER 122L")]
    public const int ERROR_INSUFFICIENT_BUFFER = 122;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_NAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_NAME 123L")]
    public const int ERROR_INVALID_NAME = 123;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LEVEL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LEVEL 124L")]
    public const int ERROR_INVALID_LEVEL = 124;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_VOLUME_LABEL"]/*' />
    [NativeTypeName("#define ERROR_NO_VOLUME_LABEL 125L")]
    public const int ERROR_NO_VOLUME_LABEL = 125;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MOD_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_MOD_NOT_FOUND 126L")]
    public const int ERROR_MOD_NOT_FOUND = 126;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROC_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PROC_NOT_FOUND 127L")]
    public const int ERROR_PROC_NOT_FOUND = 127;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAIT_NO_CHILDREN"]/*' />
    [NativeTypeName("#define ERROR_WAIT_NO_CHILDREN 128L")]
    public const int ERROR_WAIT_NO_CHILDREN = 128;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CHILD_NOT_COMPLETE"]/*' />
    [NativeTypeName("#define ERROR_CHILD_NOT_COMPLETE 129L")]
    public const int ERROR_CHILD_NOT_COMPLETE = 129;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIRECT_ACCESS_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_DIRECT_ACCESS_HANDLE 130L")]
    public const int ERROR_DIRECT_ACCESS_HANDLE = 130;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NEGATIVE_SEEK"]/*' />
    [NativeTypeName("#define ERROR_NEGATIVE_SEEK 131L")]
    public const int ERROR_NEGATIVE_SEEK = 131;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SEEK_ON_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_SEEK_ON_DEVICE 132L")]
    public const int ERROR_SEEK_ON_DEVICE = 132;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IS_JOIN_TARGET"]/*' />
    [NativeTypeName("#define ERROR_IS_JOIN_TARGET 133L")]
    public const int ERROR_IS_JOIN_TARGET = 133;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IS_JOINED"]/*' />
    [NativeTypeName("#define ERROR_IS_JOINED 134L")]
    public const int ERROR_IS_JOINED = 134;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IS_SUBSTED"]/*' />
    [NativeTypeName("#define ERROR_IS_SUBSTED 135L")]
    public const int ERROR_IS_SUBSTED = 135;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_JOINED"]/*' />
    [NativeTypeName("#define ERROR_NOT_JOINED 136L")]
    public const int ERROR_NOT_JOINED = 136;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUBSTED"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUBSTED 137L")]
    public const int ERROR_NOT_SUBSTED = 137;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_JOIN_TO_JOIN"]/*' />
    [NativeTypeName("#define ERROR_JOIN_TO_JOIN 138L")]
    public const int ERROR_JOIN_TO_JOIN = 138;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SUBST_TO_SUBST"]/*' />
    [NativeTypeName("#define ERROR_SUBST_TO_SUBST 139L")]
    public const int ERROR_SUBST_TO_SUBST = 139;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_JOIN_TO_SUBST"]/*' />
    [NativeTypeName("#define ERROR_JOIN_TO_SUBST 140L")]
    public const int ERROR_JOIN_TO_SUBST = 140;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SUBST_TO_JOIN"]/*' />
    [NativeTypeName("#define ERROR_SUBST_TO_JOIN 141L")]
    public const int ERROR_SUBST_TO_JOIN = 141;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BUSY_DRIVE"]/*' />
    [NativeTypeName("#define ERROR_BUSY_DRIVE 142L")]
    public const int ERROR_BUSY_DRIVE = 142;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SAME_DRIVE"]/*' />
    [NativeTypeName("#define ERROR_SAME_DRIVE 143L")]
    public const int ERROR_SAME_DRIVE = 143;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIR_NOT_ROOT"]/*' />
    [NativeTypeName("#define ERROR_DIR_NOT_ROOT 144L")]
    public const int ERROR_DIR_NOT_ROOT = 144;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIR_NOT_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_DIR_NOT_EMPTY 145L")]
    public const int ERROR_DIR_NOT_EMPTY = 145;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IS_SUBST_PATH"]/*' />
    [NativeTypeName("#define ERROR_IS_SUBST_PATH 146L")]
    public const int ERROR_IS_SUBST_PATH = 146;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IS_JOIN_PATH"]/*' />
    [NativeTypeName("#define ERROR_IS_JOIN_PATH 147L")]
    public const int ERROR_IS_JOIN_PATH = 147;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATH_BUSY"]/*' />
    [NativeTypeName("#define ERROR_PATH_BUSY 148L")]
    public const int ERROR_PATH_BUSY = 148;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IS_SUBST_TARGET"]/*' />
    [NativeTypeName("#define ERROR_IS_SUBST_TARGET 149L")]
    public const int ERROR_IS_SUBST_TARGET = 149;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_TRACE"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_TRACE 150L")]
    public const int ERROR_SYSTEM_TRACE = 150;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_EVENT_COUNT"]/*' />
    [NativeTypeName("#define ERROR_INVALID_EVENT_COUNT 151L")]
    public const int ERROR_INVALID_EVENT_COUNT = 151;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_MUXWAITERS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_MUXWAITERS 152L")]
    public const int ERROR_TOO_MANY_MUXWAITERS = 152;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LIST_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LIST_FORMAT 153L")]
    public const int ERROR_INVALID_LIST_FORMAT = 153;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LABEL_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_LABEL_TOO_LONG 154L")]
    public const int ERROR_LABEL_TOO_LONG = 154;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_TCBS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_TCBS 155L")]
    public const int ERROR_TOO_MANY_TCBS = 155;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SIGNAL_REFUSED"]/*' />
    [NativeTypeName("#define ERROR_SIGNAL_REFUSED 156L")]
    public const int ERROR_SIGNAL_REFUSED = 156;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISCARDED"]/*' />
    [NativeTypeName("#define ERROR_DISCARDED 157L")]
    public const int ERROR_DISCARDED = 157;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_NOT_LOCKED 158L")]
    public const int ERROR_NOT_LOCKED = 158;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_THREADID_ADDR"]/*' />
    [NativeTypeName("#define ERROR_BAD_THREADID_ADDR 159L")]
    public const int ERROR_BAD_THREADID_ADDR = 159;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_ARGUMENTS"]/*' />
    [NativeTypeName("#define ERROR_BAD_ARGUMENTS 160L")]
    public const int ERROR_BAD_ARGUMENTS = 160;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_PATHNAME"]/*' />
    [NativeTypeName("#define ERROR_BAD_PATHNAME 161L")]
    public const int ERROR_BAD_PATHNAME = 161;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SIGNAL_PENDING"]/*' />
    [NativeTypeName("#define ERROR_SIGNAL_PENDING 162L")]
    public const int ERROR_SIGNAL_PENDING = 162;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MAX_THRDS_REACHED"]/*' />
    [NativeTypeName("#define ERROR_MAX_THRDS_REACHED 164L")]
    public const int ERROR_MAX_THRDS_REACHED = 164;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOCK_FAILED"]/*' />
    [NativeTypeName("#define ERROR_LOCK_FAILED 167L")]
    public const int ERROR_LOCK_FAILED = 167;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BUSY"]/*' />
    [NativeTypeName("#define ERROR_BUSY 170L")]
    public const int ERROR_BUSY = 170;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_SUPPORT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_SUPPORT_IN_PROGRESS 171L")]
    public const int ERROR_DEVICE_SUPPORT_IN_PROGRESS = 171;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANCEL_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_CANCEL_VIOLATION 173L")]
    public const int ERROR_CANCEL_VIOLATION = 173;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ATOMIC_LOCKS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_ATOMIC_LOCKS_NOT_SUPPORTED 174L")]
    public const int ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SEGMENT_NUMBER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SEGMENT_NUMBER 180L")]
    public const int ERROR_INVALID_SEGMENT_NUMBER = 180;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ORDINAL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ORDINAL 182L")]
    public const int ERROR_INVALID_ORDINAL = 182;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_EXISTS 183L")]
    public const int ERROR_ALREADY_EXISTS = 183;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FLAG_NUMBER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FLAG_NUMBER 186L")]
    public const int ERROR_INVALID_FLAG_NUMBER = 186;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SEM_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SEM_NOT_FOUND 187L")]
    public const int ERROR_SEM_NOT_FOUND = 187;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_STARTING_CODESEG"]/*' />
    [NativeTypeName("#define ERROR_INVALID_STARTING_CODESEG 188L")]
    public const int ERROR_INVALID_STARTING_CODESEG = 188;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_STACKSEG"]/*' />
    [NativeTypeName("#define ERROR_INVALID_STACKSEG 189L")]
    public const int ERROR_INVALID_STACKSEG = 189;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MODULETYPE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MODULETYPE 190L")]
    public const int ERROR_INVALID_MODULETYPE = 190;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_EXE_SIGNATURE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_EXE_SIGNATURE 191L")]
    public const int ERROR_INVALID_EXE_SIGNATURE = 191;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXE_MARKED_INVALID"]/*' />
    [NativeTypeName("#define ERROR_EXE_MARKED_INVALID 192L")]
    public const int ERROR_EXE_MARKED_INVALID = 192;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_EXE_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_BAD_EXE_FORMAT 193L")]
    public const int ERROR_BAD_EXE_FORMAT = 193;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ITERATED_DATA_EXCEEDS_64k"]/*' />
    [NativeTypeName("#define ERROR_ITERATED_DATA_EXCEEDS_64k 194L")]
    public const int ERROR_ITERATED_DATA_EXCEEDS_64k = 194;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MINALLOCSIZE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MINALLOCSIZE 195L")]
    public const int ERROR_INVALID_MINALLOCSIZE = 195;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DYNLINK_FROM_INVALID_RING"]/*' />
    [NativeTypeName("#define ERROR_DYNLINK_FROM_INVALID_RING 196L")]
    public const int ERROR_DYNLINK_FROM_INVALID_RING = 196;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IOPL_NOT_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_IOPL_NOT_ENABLED 197L")]
    public const int ERROR_IOPL_NOT_ENABLED = 197;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SEGDPL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SEGDPL 198L")]
    public const int ERROR_INVALID_SEGDPL = 198;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUTODATASEG_EXCEEDS_64k"]/*' />
    [NativeTypeName("#define ERROR_AUTODATASEG_EXCEEDS_64k 199L")]
    public const int ERROR_AUTODATASEG_EXCEEDS_64k = 199;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RING2SEG_MUST_BE_MOVABLE"]/*' />
    [NativeTypeName("#define ERROR_RING2SEG_MUST_BE_MOVABLE 200L")]
    public const int ERROR_RING2SEG_MUST_BE_MOVABLE = 200;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RELOC_CHAIN_XEEDS_SEGLIM"]/*' />
    [NativeTypeName("#define ERROR_RELOC_CHAIN_XEEDS_SEGLIM 201L")]
    public const int ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INFLOOP_IN_RELOC_CHAIN"]/*' />
    [NativeTypeName("#define ERROR_INFLOOP_IN_RELOC_CHAIN 202L")]
    public const int ERROR_INFLOOP_IN_RELOC_CHAIN = 202;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENVVAR_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_ENVVAR_NOT_FOUND 203L")]
    public const int ERROR_ENVVAR_NOT_FOUND = 203;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SIGNAL_SENT"]/*' />
    [NativeTypeName("#define ERROR_NO_SIGNAL_SENT 205L")]
    public const int ERROR_NO_SIGNAL_SENT = 205;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILENAME_EXCED_RANGE"]/*' />
    [NativeTypeName("#define ERROR_FILENAME_EXCED_RANGE 206L")]
    public const int ERROR_FILENAME_EXCED_RANGE = 206;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RING2_STACK_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_RING2_STACK_IN_USE 207L")]
    public const int ERROR_RING2_STACK_IN_USE = 207;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_META_EXPANSION_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_META_EXPANSION_TOO_LONG 208L")]
    public const int ERROR_META_EXPANSION_TOO_LONG = 208;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SIGNAL_NUMBER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SIGNAL_NUMBER 209L")]
    public const int ERROR_INVALID_SIGNAL_NUMBER = 209;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_THREAD_1_INACTIVE"]/*' />
    [NativeTypeName("#define ERROR_THREAD_1_INACTIVE 210L")]
    public const int ERROR_THREAD_1_INACTIVE = 210;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_LOCKED 212L")]
    public const int ERROR_LOCKED = 212;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_MODULES"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_MODULES 214L")]
    public const int ERROR_TOO_MANY_MODULES = 214;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NESTING_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_NESTING_NOT_ALLOWED 215L")]
    public const int ERROR_NESTING_NOT_ALLOWED = 215;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXE_MACHINE_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_EXE_MACHINE_TYPE_MISMATCH 216L")]
    public const int ERROR_EXE_MACHINE_TYPE_MISMATCH = 216;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY"]/*' />
    [NativeTypeName("#define ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY 217L")]
    public const int ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY"]/*' />
    [NativeTypeName("#define ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY 218L")]
    public const int ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_CHECKED_OUT"]/*' />
    [NativeTypeName("#define ERROR_FILE_CHECKED_OUT 220L")]
    public const int ERROR_FILE_CHECKED_OUT = 220;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CHECKOUT_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_CHECKOUT_REQUIRED 221L")]
    public const int ERROR_CHECKOUT_REQUIRED = 221;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_FILE_TYPE"]/*' />
    [NativeTypeName("#define ERROR_BAD_FILE_TYPE 222L")]
    public const int ERROR_BAD_FILE_TYPE = 222;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_TOO_LARGE"]/*' />
    [NativeTypeName("#define ERROR_FILE_TOO_LARGE 223L")]
    public const int ERROR_FILE_TOO_LARGE = 223;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FORMS_AUTH_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_FORMS_AUTH_REQUIRED 224L")]
    public const int ERROR_FORMS_AUTH_REQUIRED = 224;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VIRUS_INFECTED"]/*' />
    [NativeTypeName("#define ERROR_VIRUS_INFECTED 225L")]
    public const int ERROR_VIRUS_INFECTED = 225;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VIRUS_DELETED"]/*' />
    [NativeTypeName("#define ERROR_VIRUS_DELETED 226L")]
    public const int ERROR_VIRUS_DELETED = 226;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PIPE_LOCAL"]/*' />
    [NativeTypeName("#define ERROR_PIPE_LOCAL 229L")]
    public const int ERROR_PIPE_LOCAL = 229;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_PIPE"]/*' />
    [NativeTypeName("#define ERROR_BAD_PIPE 230L")]
    public const int ERROR_BAD_PIPE = 230;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PIPE_BUSY"]/*' />
    [NativeTypeName("#define ERROR_PIPE_BUSY 231L")]
    public const int ERROR_PIPE_BUSY = 231;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_DATA"]/*' />
    [NativeTypeName("#define ERROR_NO_DATA 232L")]
    public const int ERROR_NO_DATA = 232;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PIPE_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_PIPE_NOT_CONNECTED 233L")]
    public const int ERROR_PIPE_NOT_CONNECTED = 233;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MORE_DATA"]/*' />
    [NativeTypeName("#define ERROR_MORE_DATA 234L")]
    public const int ERROR_MORE_DATA = 234;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_WORK_DONE"]/*' />
    [NativeTypeName("#define ERROR_NO_WORK_DONE 235L")]
    public const int ERROR_NO_WORK_DONE = 235;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VC_DISCONNECTED"]/*' />
    [NativeTypeName("#define ERROR_VC_DISCONNECTED 240L")]
    public const int ERROR_VC_DISCONNECTED = 240;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_EA_NAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_EA_NAME 254L")]
    public const int ERROR_INVALID_EA_NAME = 254;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EA_LIST_INCONSISTENT"]/*' />
    [NativeTypeName("#define ERROR_EA_LIST_INCONSISTENT 255L")]
    public const int ERROR_EA_LIST_INCONSISTENT = 255;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_MORE_ITEMS"]/*' />
    [NativeTypeName("#define ERROR_NO_MORE_ITEMS 259L")]
    public const int ERROR_NO_MORE_ITEMS = 259;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_COPY"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_COPY 266L")]
    public const int ERROR_CANNOT_COPY = 266;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIRECTORY"]/*' />
    [NativeTypeName("#define ERROR_DIRECTORY 267L")]
    public const int ERROR_DIRECTORY = 267;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EAS_DIDNT_FIT"]/*' />
    [NativeTypeName("#define ERROR_EAS_DIDNT_FIT 275L")]
    public const int ERROR_EAS_DIDNT_FIT = 275;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EA_FILE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_EA_FILE_CORRUPT 276L")]
    public const int ERROR_EA_FILE_CORRUPT = 276;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EA_TABLE_FULL"]/*' />
    [NativeTypeName("#define ERROR_EA_TABLE_FULL 277L")]
    public const int ERROR_EA_TABLE_FULL = 277;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_EA_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_EA_HANDLE 278L")]
    public const int ERROR_INVALID_EA_HANDLE = 278;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EAS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_EAS_NOT_SUPPORTED 282L")]
    public const int ERROR_EAS_NOT_SUPPORTED = 282;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_OWNER"]/*' />
    [NativeTypeName("#define ERROR_NOT_OWNER 288L")]
    public const int ERROR_NOT_OWNER = 288;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_POSTS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_POSTS 298L")]
    public const int ERROR_TOO_MANY_POSTS = 298;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PARTIAL_COPY"]/*' />
    [NativeTypeName("#define ERROR_PARTIAL_COPY 299L")]
    public const int ERROR_PARTIAL_COPY = 299;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPLOCK_NOT_GRANTED"]/*' />
    [NativeTypeName("#define ERROR_OPLOCK_NOT_GRANTED 300L")]
    public const int ERROR_OPLOCK_NOT_GRANTED = 300;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_OPLOCK_PROTOCOL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_OPLOCK_PROTOCOL 301L")]
    public const int ERROR_INVALID_OPLOCK_PROTOCOL = 301;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_TOO_FRAGMENTED"]/*' />
    [NativeTypeName("#define ERROR_DISK_TOO_FRAGMENTED 302L")]
    public const int ERROR_DISK_TOO_FRAGMENTED = 302;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DELETE_PENDING"]/*' />
    [NativeTypeName("#define ERROR_DELETE_PENDING 303L")]
    public const int ERROR_DELETE_PENDING = 303;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING"]/*' />
    [NativeTypeName("#define ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING 304L")]
    public const int ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 304;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME 305L")]
    public const int ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 305;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECURITY_STREAM_IS_INCONSISTENT"]/*' />
    [NativeTypeName("#define ERROR_SECURITY_STREAM_IS_INCONSISTENT 306L")]
    public const int ERROR_SECURITY_STREAM_IS_INCONSISTENT = 306;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LOCK_RANGE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LOCK_RANGE 307L")]
    public const int ERROR_INVALID_LOCK_RANGE = 307;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT 308L")]
    public const int ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT = 308;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOTIFICATION_GUID_ALREADY_DEFINED"]/*' />
    [NativeTypeName("#define ERROR_NOTIFICATION_GUID_ALREADY_DEFINED 309L")]
    public const int ERROR_NOTIFICATION_GUID_ALREADY_DEFINED = 309;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_EXCEPTION_HANDLER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_EXCEPTION_HANDLER 310L")]
    public const int ERROR_INVALID_EXCEPTION_HANDLER = 310;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DUPLICATE_PRIVILEGES"]/*' />
    [NativeTypeName("#define ERROR_DUPLICATE_PRIVILEGES 311L")]
    public const int ERROR_DUPLICATE_PRIVILEGES = 311;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_RANGES_PROCESSED"]/*' />
    [NativeTypeName("#define ERROR_NO_RANGES_PROCESSED 312L")]
    public const int ERROR_NO_RANGES_PROCESSED = 312;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_ALLOWED_ON_SYSTEM_FILE"]/*' />
    [NativeTypeName("#define ERROR_NOT_ALLOWED_ON_SYSTEM_FILE 313L")]
    public const int ERROR_NOT_ALLOWED_ON_SYSTEM_FILE = 313;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_RESOURCES_EXHAUSTED"]/*' />
    [NativeTypeName("#define ERROR_DISK_RESOURCES_EXHAUSTED 314L")]
    public const int ERROR_DISK_RESOURCES_EXHAUSTED = 314;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TOKEN"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TOKEN 315L")]
    public const int ERROR_INVALID_TOKEN = 315;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_FEATURE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_FEATURE_NOT_SUPPORTED 316L")]
    public const int ERROR_DEVICE_FEATURE_NOT_SUPPORTED = 316;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MR_MID_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_MR_MID_NOT_FOUND 317L")]
    public const int ERROR_MR_MID_NOT_FOUND = 317;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SCOPE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SCOPE_NOT_FOUND 318L")]
    public const int ERROR_SCOPE_NOT_FOUND = 318;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNDEFINED_SCOPE"]/*' />
    [NativeTypeName("#define ERROR_UNDEFINED_SCOPE 319L")]
    public const int ERROR_UNDEFINED_SCOPE = 319;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CAP"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CAP 320L")]
    public const int ERROR_INVALID_CAP = 320;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_UNREACHABLE"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_UNREACHABLE 321L")]
    public const int ERROR_DEVICE_UNREACHABLE = 321;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_NO_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_NO_RESOURCES 322L")]
    public const int ERROR_DEVICE_NO_RESOURCES = 322;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DATA_CHECKSUM_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DATA_CHECKSUM_ERROR 323L")]
    public const int ERROR_DATA_CHECKSUM_ERROR = 323;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INTERMIXED_KERNEL_EA_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_INTERMIXED_KERNEL_EA_OPERATION 324L")]
    public const int ERROR_INTERMIXED_KERNEL_EA_OPERATION = 324;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED 326L")]
    public const int ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED = 326;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OFFSET_ALIGNMENT_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_OFFSET_ALIGNMENT_VIOLATION 327L")]
    public const int ERROR_OFFSET_ALIGNMENT_VIOLATION = 327;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FIELD_IN_PARAMETER_LIST"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FIELD_IN_PARAMETER_LIST 328L")]
    public const int ERROR_INVALID_FIELD_IN_PARAMETER_LIST = 328;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPERATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_OPERATION_IN_PROGRESS 329L")]
    public const int ERROR_OPERATION_IN_PROGRESS = 329;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_DEVICE_PATH"]/*' />
    [NativeTypeName("#define ERROR_BAD_DEVICE_PATH 330L")]
    public const int ERROR_BAD_DEVICE_PATH = 330;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_DESCRIPTORS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_DESCRIPTORS 331L")]
    public const int ERROR_TOO_MANY_DESCRIPTORS = 331;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SCRUB_DATA_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_SCRUB_DATA_DISABLED 332L")]
    public const int ERROR_SCRUB_DATA_DISABLED = 332;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_REDUNDANT_STORAGE"]/*' />
    [NativeTypeName("#define ERROR_NOT_REDUNDANT_STORAGE 333L")]
    public const int ERROR_NOT_REDUNDANT_STORAGE = 333;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESIDENT_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_RESIDENT_FILE_NOT_SUPPORTED 334L")]
    public const int ERROR_RESIDENT_FILE_NOT_SUPPORTED = 334;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COMPRESSED_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_COMPRESSED_FILE_NOT_SUPPORTED 335L")]
    public const int ERROR_COMPRESSED_FILE_NOT_SUPPORTED = 335;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIRECTORY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_DIRECTORY_NOT_SUPPORTED 336L")]
    public const int ERROR_DIRECTORY_NOT_SUPPORTED = 336;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_READ_FROM_COPY"]/*' />
    [NativeTypeName("#define ERROR_NOT_READ_FROM_COPY 337L")]
    public const int ERROR_NOT_READ_FROM_COPY = 337;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FT_WRITE_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_FT_WRITE_FAILURE 338L")]
    public const int ERROR_FT_WRITE_FAILURE = 338;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FT_DI_SCAN_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_FT_DI_SCAN_REQUIRED 339L")]
    public const int ERROR_FT_DI_SCAN_REQUIRED = 339;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_KERNEL_INFO_VERSION"]/*' />
    [NativeTypeName("#define ERROR_INVALID_KERNEL_INFO_VERSION 340L")]
    public const int ERROR_INVALID_KERNEL_INFO_VERSION = 340;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PEP_INFO_VERSION"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PEP_INFO_VERSION 341L")]
    public const int ERROR_INVALID_PEP_INFO_VERSION = 341;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OBJECT_NOT_EXTERNALLY_BACKED"]/*' />
    [NativeTypeName("#define ERROR_OBJECT_NOT_EXTERNALLY_BACKED 342L")]
    public const int ERROR_OBJECT_NOT_EXTERNALLY_BACKED = 342;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXTERNAL_BACKING_PROVIDER_UNKNOWN"]/*' />
    [NativeTypeName("#define ERROR_EXTERNAL_BACKING_PROVIDER_UNKNOWN 343L")]
    public const int ERROR_EXTERNAL_BACKING_PROVIDER_UNKNOWN = 343;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COMPRESSION_NOT_BENEFICIAL"]/*' />
    [NativeTypeName("#define ERROR_COMPRESSION_NOT_BENEFICIAL 344L")]
    public const int ERROR_COMPRESSION_NOT_BENEFICIAL = 344;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STORAGE_TOPOLOGY_ID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_STORAGE_TOPOLOGY_ID_MISMATCH 345L")]
    public const int ERROR_STORAGE_TOPOLOGY_ID_MISMATCH = 345;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BLOCKED_BY_PARENTAL_CONTROLS"]/*' />
    [NativeTypeName("#define ERROR_BLOCKED_BY_PARENTAL_CONTROLS 346L")]
    public const int ERROR_BLOCKED_BY_PARENTAL_CONTROLS = 346;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BLOCK_TOO_MANY_REFERENCES"]/*' />
    [NativeTypeName("#define ERROR_BLOCK_TOO_MANY_REFERENCES 347L")]
    public const int ERROR_BLOCK_TOO_MANY_REFERENCES = 347;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MARKED_TO_DISALLOW_WRITES"]/*' />
    [NativeTypeName("#define ERROR_MARKED_TO_DISALLOW_WRITES 348L")]
    public const int ERROR_MARKED_TO_DISALLOW_WRITES = 348;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCLAVE_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_ENCLAVE_FAILURE 349L")]
    public const int ERROR_ENCLAVE_FAILURE = 349;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAIL_NOACTION_REBOOT"]/*' />
    [NativeTypeName("#define ERROR_FAIL_NOACTION_REBOOT 350L")]
    public const int ERROR_FAIL_NOACTION_REBOOT = 350;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAIL_SHUTDOWN"]/*' />
    [NativeTypeName("#define ERROR_FAIL_SHUTDOWN 351L")]
    public const int ERROR_FAIL_SHUTDOWN = 351;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAIL_RESTART"]/*' />
    [NativeTypeName("#define ERROR_FAIL_RESTART 352L")]
    public const int ERROR_FAIL_RESTART = 352;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MAX_SESSIONS_REACHED"]/*' />
    [NativeTypeName("#define ERROR_MAX_SESSIONS_REACHED 353L")]
    public const int ERROR_MAX_SESSIONS_REACHED = 353;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NETWORK_ACCESS_DENIED_EDP"]/*' />
    [NativeTypeName("#define ERROR_NETWORK_ACCESS_DENIED_EDP 354L")]
    public const int ERROR_NETWORK_ACCESS_DENIED_EDP = 354;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_HINT_NAME_BUFFER_TOO_SMALL"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_HINT_NAME_BUFFER_TOO_SMALL 355L")]
    public const int ERROR_DEVICE_HINT_NAME_BUFFER_TOO_SMALL = 355;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EDP_POLICY_DENIES_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_EDP_POLICY_DENIES_OPERATION 356L")]
    public const int ERROR_EDP_POLICY_DENIES_OPERATION = 356;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EDP_DPL_POLICY_CANT_BE_SATISFIED"]/*' />
    [NativeTypeName("#define ERROR_EDP_DPL_POLICY_CANT_BE_SATISFIED 357L")]
    public const int ERROR_EDP_DPL_POLICY_CANT_BE_SATISFIED = 357;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT 358L")]
    public const int ERROR_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT = 358;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_IN_MAINTENANCE"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_IN_MAINTENANCE 359L")]
    public const int ERROR_DEVICE_IN_MAINTENANCE = 359;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_ON_DAX"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_ON_DAX 360L")]
    public const int ERROR_NOT_SUPPORTED_ON_DAX = 360;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DAX_MAPPING_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DAX_MAPPING_EXISTS 361L")]
    public const int ERROR_DAX_MAPPING_EXISTS = 361;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_PROVIDER_NOT_RUNNING"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_PROVIDER_NOT_RUNNING 362L")]
    public const int ERROR_CLOUD_FILE_PROVIDER_NOT_RUNNING = 362;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_METADATA_CORRUPT 363L")]
    public const int ERROR_CLOUD_FILE_METADATA_CORRUPT = 363;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_METADATA_TOO_LARGE"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_METADATA_TOO_LARGE 364L")]
    public const int ERROR_CLOUD_FILE_METADATA_TOO_LARGE = 364;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE 365L")]
    public const int ERROR_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE = 365;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH 366L")]
    public const int ERROR_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH = 366;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CHILD_PROCESS_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_CHILD_PROCESS_BLOCKED 367L")]
    public const int ERROR_CHILD_PROCESS_BLOCKED = 367;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STORAGE_LOST_DATA_PERSISTENCE"]/*' />
    [NativeTypeName("#define ERROR_STORAGE_LOST_DATA_PERSISTENCE 368L")]
    public const int ERROR_STORAGE_LOST_DATA_PERSISTENCE = 368;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE 369L")]
    public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE = 369;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT 370L")]
    public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT = 370;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SYSTEM_VIRTUALIZATION_BUSY"]/*' />
    [NativeTypeName("#define ERROR_FILE_SYSTEM_VIRTUALIZATION_BUSY 371L")]
    public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_BUSY = 371;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN"]/*' />
    [NativeTypeName("#define ERROR_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN 372L")]
    public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN = 372;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GDI_HANDLE_LEAK"]/*' />
    [NativeTypeName("#define ERROR_GDI_HANDLE_LEAK 373L")]
    public const int ERROR_GDI_HANDLE_LEAK = 373;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS 374L")]
    public const int ERROR_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS = 374;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED 375L")]
    public const int ERROR_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED = 375;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_A_CLOUD_FILE"]/*' />
    [NativeTypeName("#define ERROR_NOT_A_CLOUD_FILE 376L")]
    public const int ERROR_NOT_A_CLOUD_FILE = 376;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_NOT_IN_SYNC"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_NOT_IN_SYNC 377L")]
    public const int ERROR_CLOUD_FILE_NOT_IN_SYNC = 377;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_ALREADY_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_ALREADY_CONNECTED 378L")]
    public const int ERROR_CLOUD_FILE_ALREADY_CONNECTED = 378;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_NOT_SUPPORTED 379L")]
    public const int ERROR_CLOUD_FILE_NOT_SUPPORTED = 379;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_INVALID_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_INVALID_REQUEST 380L")]
    public const int ERROR_CLOUD_FILE_INVALID_REQUEST = 380;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_READ_ONLY_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_READ_ONLY_VOLUME 381L")]
    public const int ERROR_CLOUD_FILE_READ_ONLY_VOLUME = 381;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_CONNECTED_PROVIDER_ONLY"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_CONNECTED_PROVIDER_ONLY 382L")]
    public const int ERROR_CLOUD_FILE_CONNECTED_PROVIDER_ONLY = 382;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_VALIDATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_VALIDATION_FAILED 383L")]
    public const int ERROR_CLOUD_FILE_VALIDATION_FAILED = 383;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB1_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_SMB1_NOT_AVAILABLE 384L")]
    public const int ERROR_SMB1_NOT_AVAILABLE = 384;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION 385L")]
    public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION = 385;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_AUTHENTICATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_AUTHENTICATION_FAILED 386L")]
    public const int ERROR_CLOUD_FILE_AUTHENTICATION_FAILED = 386;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_INSUFFICIENT_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_INSUFFICIENT_RESOURCES 387L")]
    public const int ERROR_CLOUD_FILE_INSUFFICIENT_RESOURCES = 387;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_NETWORK_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_NETWORK_UNAVAILABLE 388L")]
    public const int ERROR_CLOUD_FILE_NETWORK_UNAVAILABLE = 388;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_UNSUCCESSFUL"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_UNSUCCESSFUL 389L")]
    public const int ERROR_CLOUD_FILE_UNSUCCESSFUL = 389;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_NOT_UNDER_SYNC_ROOT"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_NOT_UNDER_SYNC_ROOT 390L")]
    public const int ERROR_CLOUD_FILE_NOT_UNDER_SYNC_ROOT = 390;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_IN_USE 391L")]
    public const int ERROR_CLOUD_FILE_IN_USE = 391;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_PINNED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_PINNED 392L")]
    public const int ERROR_CLOUD_FILE_PINNED = 392;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_REQUEST_ABORTED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_REQUEST_ABORTED 393L")]
    public const int ERROR_CLOUD_FILE_REQUEST_ABORTED = 393;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_PROPERTY_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_PROPERTY_CORRUPT 394L")]
    public const int ERROR_CLOUD_FILE_PROPERTY_CORRUPT = 394;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_ACCESS_DENIED 395L")]
    public const int ERROR_CLOUD_FILE_ACCESS_DENIED = 395;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_INCOMPATIBLE_HARDLINKS"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_INCOMPATIBLE_HARDLINKS 396L")]
    public const int ERROR_CLOUD_FILE_INCOMPATIBLE_HARDLINKS = 396;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_PROPERTY_LOCK_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_PROPERTY_LOCK_CONFLICT 397L")]
    public const int ERROR_CLOUD_FILE_PROPERTY_LOCK_CONFLICT = 397;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_REQUEST_CANCELED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_REQUEST_CANCELED 398L")]
    public const int ERROR_CLOUD_FILE_REQUEST_CANCELED = 398;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXTERNAL_SYSKEY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_EXTERNAL_SYSKEY_NOT_SUPPORTED 399L")]
    public const int ERROR_EXTERNAL_SYSKEY_NOT_SUPPORTED = 399;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_THREAD_MODE_ALREADY_BACKGROUND"]/*' />
    [NativeTypeName("#define ERROR_THREAD_MODE_ALREADY_BACKGROUND 400L")]
    public const int ERROR_THREAD_MODE_ALREADY_BACKGROUND = 400;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_THREAD_MODE_NOT_BACKGROUND"]/*' />
    [NativeTypeName("#define ERROR_THREAD_MODE_NOT_BACKGROUND 401L")]
    public const int ERROR_THREAD_MODE_NOT_BACKGROUND = 401;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROCESS_MODE_ALREADY_BACKGROUND"]/*' />
    [NativeTypeName("#define ERROR_PROCESS_MODE_ALREADY_BACKGROUND 402L")]
    public const int ERROR_PROCESS_MODE_ALREADY_BACKGROUND = 402;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROCESS_MODE_NOT_BACKGROUND"]/*' />
    [NativeTypeName("#define ERROR_PROCESS_MODE_NOT_BACKGROUND 403L")]
    public const int ERROR_PROCESS_MODE_NOT_BACKGROUND = 403;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_PROVIDER_TERMINATED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_PROVIDER_TERMINATED 404L")]
    public const int ERROR_CLOUD_FILE_PROVIDER_TERMINATED = 404;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_A_CLOUD_SYNC_ROOT"]/*' />
    [NativeTypeName("#define ERROR_NOT_A_CLOUD_SYNC_ROOT 405L")]
    public const int ERROR_NOT_A_CLOUD_SYNC_ROOT = 405;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_PROTECTED_UNDER_DPL"]/*' />
    [NativeTypeName("#define ERROR_FILE_PROTECTED_UNDER_DPL 406L")]
    public const int ERROR_FILE_PROTECTED_UNDER_DPL = 406;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_NOT_CLUSTER_ALIGNED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_NOT_CLUSTER_ALIGNED 407L")]
    public const int ERROR_VOLUME_NOT_CLUSTER_ALIGNED = 407;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND 408L")]
    public const int ERROR_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND = 408;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPX_FILE_NOT_ENCRYPTED"]/*' />
    [NativeTypeName("#define ERROR_APPX_FILE_NOT_ENCRYPTED 409L")]
    public const int ERROR_APPX_FILE_NOT_ENCRYPTED = 409;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED"]/*' />
    [NativeTypeName("#define ERROR_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED 410L")]
    public const int ERROR_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED = 410;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET"]/*' />
    [NativeTypeName("#define ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET 411L")]
    public const int ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET = 411;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE"]/*' />
    [NativeTypeName("#define ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE 412L")]
    public const int ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE = 412;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER"]/*' />
    [NativeTypeName("#define ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER 413L")]
    public const int ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER = 413;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LINUX_SUBSYSTEM_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_LINUX_SUBSYSTEM_NOT_PRESENT 414L")]
    public const int ERROR_LINUX_SUBSYSTEM_NOT_PRESENT = 414;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FT_READ_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_FT_READ_FAILURE 415L")]
    public const int ERROR_FT_READ_FAILURE = 415;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STORAGE_RESERVE_ID_INVALID"]/*' />
    [NativeTypeName("#define ERROR_STORAGE_RESERVE_ID_INVALID 416L")]
    public const int ERROR_STORAGE_RESERVE_ID_INVALID = 416;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STORAGE_RESERVE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define ERROR_STORAGE_RESERVE_DOES_NOT_EXIST 417L")]
    public const int ERROR_STORAGE_RESERVE_DOES_NOT_EXIST = 417;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STORAGE_RESERVE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_STORAGE_RESERVE_ALREADY_EXISTS 418L")]
    public const int ERROR_STORAGE_RESERVE_ALREADY_EXISTS = 418;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STORAGE_RESERVE_NOT_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_STORAGE_RESERVE_NOT_EMPTY 419L")]
    public const int ERROR_STORAGE_RESERVE_NOT_EMPTY = 419;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_A_DAX_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_NOT_A_DAX_VOLUME 420L")]
    public const int ERROR_NOT_A_DAX_VOLUME = 420;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_DAX_MAPPABLE"]/*' />
    [NativeTypeName("#define ERROR_NOT_DAX_MAPPABLE 421L")]
    public const int ERROR_NOT_DAX_MAPPABLE = 421;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIME_SENSITIVE_THREAD"]/*' />
    [NativeTypeName("#define ERROR_TIME_SENSITIVE_THREAD 422L")]
    public const int ERROR_TIME_SENSITIVE_THREAD = 422;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DPL_NOT_SUPPORTED_FOR_USER"]/*' />
    [NativeTypeName("#define ERROR_DPL_NOT_SUPPORTED_FOR_USER 423L")]
    public const int ERROR_DPL_NOT_SUPPORTED_FOR_USER = 423;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CASE_DIFFERING_NAMES_IN_DIR"]/*' />
    [NativeTypeName("#define ERROR_CASE_DIFFERING_NAMES_IN_DIR 424L")]
    public const int ERROR_CASE_DIFFERING_NAMES_IN_DIR = 424;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_FILE_NOT_SUPPORTED 425L")]
    public const int ERROR_FILE_NOT_SUPPORTED = 425;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_REQUEST_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_REQUEST_TIMEOUT 426L")]
    public const int ERROR_CLOUD_FILE_REQUEST_TIMEOUT = 426;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_TASK_QUEUE"]/*' />
    [NativeTypeName("#define ERROR_NO_TASK_QUEUE 427L")]
    public const int ERROR_NO_TASK_QUEUE = 427;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SRC_SRV_DLL_LOAD_FAILED"]/*' />
    [NativeTypeName("#define ERROR_SRC_SRV_DLL_LOAD_FAILED 428L")]
    public const int ERROR_SRC_SRV_DLL_LOAD_FAILED = 428;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_BTT"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_BTT 429L")]
    public const int ERROR_NOT_SUPPORTED_WITH_BTT = 429;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCRYPTION_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_ENCRYPTION_DISABLED 430L")]
    public const int ERROR_ENCRYPTION_DISABLED = 430;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCRYPTING_METADATA_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_ENCRYPTING_METADATA_DISALLOWED 431L")]
    public const int ERROR_ENCRYPTING_METADATA_DISALLOWED = 431;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_CLEAR_ENCRYPTION_FLAG"]/*' />
    [NativeTypeName("#define ERROR_CANT_CLEAR_ENCRYPTION_FLAG 432L")]
    public const int ERROR_CANT_CLEAR_ENCRYPTION_FLAG = 432;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_DEVICE 433L")]
    public const int ERROR_NO_SUCH_DEVICE = 433;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_DEHYDRATION_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_DEHYDRATION_DISALLOWED 434L")]
    public const int ERROR_CLOUD_FILE_DEHYDRATION_DISALLOWED = 434;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SNAP_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_FILE_SNAP_IN_PROGRESS 435L")]
    public const int ERROR_FILE_SNAP_IN_PROGRESS = 435;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SNAP_USER_SECTION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_FILE_SNAP_USER_SECTION_NOT_SUPPORTED 436L")]
    public const int ERROR_FILE_SNAP_USER_SECTION_NOT_SUPPORTED = 436;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SNAP_MODIFY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_FILE_SNAP_MODIFY_NOT_SUPPORTED 437L")]
    public const int ERROR_FILE_SNAP_MODIFY_NOT_SUPPORTED = 437;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SNAP_IO_NOT_COORDINATED"]/*' />
    [NativeTypeName("#define ERROR_FILE_SNAP_IO_NOT_COORDINATED 438L")]
    public const int ERROR_FILE_SNAP_IO_NOT_COORDINATED = 438;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SNAP_UNEXPECTED_ERROR"]/*' />
    [NativeTypeName("#define ERROR_FILE_SNAP_UNEXPECTED_ERROR 439L")]
    public const int ERROR_FILE_SNAP_UNEXPECTED_ERROR = 439;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SNAP_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define ERROR_FILE_SNAP_INVALID_PARAMETER 440L")]
    public const int ERROR_FILE_SNAP_INVALID_PARAMETER = 440;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNSATISFIED_DEPENDENCIES"]/*' />
    [NativeTypeName("#define ERROR_UNSATISFIED_DEPENDENCIES 441L")]
    public const int ERROR_UNSATISFIED_DEPENDENCIES = 441;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CASE_SENSITIVE_PATH"]/*' />
    [NativeTypeName("#define ERROR_CASE_SENSITIVE_PATH 442L")]
    public const int ERROR_CASE_SENSITIVE_PATH = 442;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNEXPECTED_NTCACHEMANAGER_ERROR"]/*' />
    [NativeTypeName("#define ERROR_UNEXPECTED_NTCACHEMANAGER_ERROR 443L")]
    public const int ERROR_UNEXPECTED_NTCACHEMANAGER_ERROR = 443;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LINUX_SUBSYSTEM_UPDATE_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_LINUX_SUBSYSTEM_UPDATE_REQUIRED 444L")]
    public const int ERROR_LINUX_SUBSYSTEM_UPDATE_REQUIRED = 444;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DLP_POLICY_WARNS_AGAINST_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_DLP_POLICY_WARNS_AGAINST_OPERATION 445L")]
    public const int ERROR_DLP_POLICY_WARNS_AGAINST_OPERATION = 445;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DLP_POLICY_DENIES_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_DLP_POLICY_DENIES_OPERATION 446L")]
    public const int ERROR_DLP_POLICY_DENIES_OPERATION = 446;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECURITY_DENIES_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_SECURITY_DENIES_OPERATION 447L")]
    public const int ERROR_SECURITY_DENIES_OPERATION = 447;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNTRUSTED_MOUNT_POINT"]/*' />
    [NativeTypeName("#define ERROR_UNTRUSTED_MOUNT_POINT 448L")]
    public const int ERROR_UNTRUSTED_MOUNT_POINT = 448;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DLP_POLICY_SILENTLY_FAIL"]/*' />
    [NativeTypeName("#define ERROR_DLP_POLICY_SILENTLY_FAIL 449L")]
    public const int ERROR_DLP_POLICY_SILENTLY_FAIL = 449;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_NOT_DEVUNLOCKED"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_NOT_DEVUNLOCKED 450L")]
    public const int ERROR_CAPAUTHZ_NOT_DEVUNLOCKED = 450;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_CHANGE_TYPE"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_CHANGE_TYPE 451L")]
    public const int ERROR_CAPAUTHZ_CHANGE_TYPE = 451;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_NOT_PROVISIONED"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_NOT_PROVISIONED 452L")]
    public const int ERROR_CAPAUTHZ_NOT_PROVISIONED = 452;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_NOT_AUTHORIZED 453L")]
    public const int ERROR_CAPAUTHZ_NOT_AUTHORIZED = 453;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_NO_POLICY"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_NO_POLICY 454L")]
    public const int ERROR_CAPAUTHZ_NO_POLICY = 454;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_DB_CORRUPTED"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_DB_CORRUPTED 455L")]
    public const int ERROR_CAPAUTHZ_DB_CORRUPTED = 455;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_SCCD_INVALID_CATALOG"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_SCCD_INVALID_CATALOG 456L")]
    public const int ERROR_CAPAUTHZ_SCCD_INVALID_CATALOG = 456;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_SCCD_NO_AUTH_ENTITY"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_SCCD_NO_AUTH_ENTITY 457L")]
    public const int ERROR_CAPAUTHZ_SCCD_NO_AUTH_ENTITY = 457;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_SCCD_PARSE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_SCCD_PARSE_ERROR 458L")]
    public const int ERROR_CAPAUTHZ_SCCD_PARSE_ERROR = 458;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_SCCD_DEV_MODE_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_SCCD_DEV_MODE_REQUIRED 459L")]
    public const int ERROR_CAPAUTHZ_SCCD_DEV_MODE_REQUIRED = 459;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAPAUTHZ_SCCD_NO_CAPABILITY_MATCH"]/*' />
    [NativeTypeName("#define ERROR_CAPAUTHZ_SCCD_NO_CAPABILITY_MATCH 460L")]
    public const int ERROR_CAPAUTHZ_SCCD_NO_CAPABILITY_MATCH = 460;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CIMFS_IMAGE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_CIMFS_IMAGE_CORRUPT 470L")]
    public const int ERROR_CIMFS_IMAGE_CORRUPT = 470;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CIMFS_IMAGE_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_CIMFS_IMAGE_VERSION_NOT_SUPPORTED 471L")]
    public const int ERROR_CIMFS_IMAGE_VERSION_NOT_SUPPORTED = 471;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STORAGE_STACK_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_STORAGE_STACK_ACCESS_DENIED 472L")]
    public const int ERROR_STORAGE_STACK_ACCESS_DENIED = 472;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSUFFICIENT_VIRTUAL_ADDR_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_INSUFFICIENT_VIRTUAL_ADDR_RESOURCES 473L")]
    public const int ERROR_INSUFFICIENT_VIRTUAL_ADDR_RESOURCES = 473;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INDEX_OUT_OF_BOUNDS"]/*' />
    [NativeTypeName("#define ERROR_INDEX_OUT_OF_BOUNDS 474L")]
    public const int ERROR_INDEX_OUT_OF_BOUNDS = 474;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_US_MESSAGE_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_US_MESSAGE_TIMEOUT 475L")]
    public const int ERROR_CLOUD_FILE_US_MESSAGE_TIMEOUT = 475;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_A_DEV_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_NOT_A_DEV_VOLUME 476L")]
    public const int ERROR_NOT_A_DEV_VOLUME = 476;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FS_GUID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_FS_GUID_MISMATCH 477L")]
    public const int ERROR_FS_GUID_MISMATCH = 477;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_ATTACH_TO_DEV_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_CANT_ATTACH_TO_DEV_VOLUME 478L")]
    public const int ERROR_CANT_ATTACH_TO_DEV_VOLUME = 478;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEMORY_DECOMPRESSION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_MEMORY_DECOMPRESSION_FAILURE 479L")]
    public const int ERROR_MEMORY_DECOMPRESSION_FAILURE = 479;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_QUERY_REMOVE_DEVICE_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_PNP_QUERY_REMOVE_DEVICE_TIMEOUT 480L")]
    public const int ERROR_PNP_QUERY_REMOVE_DEVICE_TIMEOUT = 480;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_QUERY_REMOVE_RELATED_DEVICE_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_PNP_QUERY_REMOVE_RELATED_DEVICE_TIMEOUT 481L")]
    public const int ERROR_PNP_QUERY_REMOVE_RELATED_DEVICE_TIMEOUT = 481;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_QUERY_REMOVE_UNRELATED_DEVICE_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_PNP_QUERY_REMOVE_UNRELATED_DEVICE_TIMEOUT 482L")]
    public const int ERROR_PNP_QUERY_REMOVE_UNRELATED_DEVICE_TIMEOUT = 482;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_HARDWARE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_HARDWARE_ERROR 483L")]
    public const int ERROR_DEVICE_HARDWARE_ERROR = 483;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_NACKED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_NACKED 484L")]
    public const int ERROR_DEVICE_NACKED = 484;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ADDRESS"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ADDRESS 487L")]
    public const int ERROR_INVALID_ADDRESS = 487;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HAS_SYSTEM_CRITICAL_FILES"]/*' />
    [NativeTypeName("#define ERROR_HAS_SYSTEM_CRITICAL_FILES 488L")]
    public const int ERROR_HAS_SYSTEM_CRITICAL_FILES = 488;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCRYPTED_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_ENCRYPTED_FILE_NOT_SUPPORTED 489L")]
    public const int ERROR_ENCRYPTED_FILE_NOT_SUPPORTED = 489;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPARSE_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_SPARSE_FILE_NOT_SUPPORTED 490L")]
    public const int ERROR_SPARSE_FILE_NOT_SUPPORTED = 490;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGEFILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_PAGEFILE_NOT_SUPPORTED 491L")]
    public const int ERROR_PAGEFILE_NOT_SUPPORTED = 491;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_NOT_SUPPORTED 492L")]
    public const int ERROR_VOLUME_NOT_SUPPORTED = 492;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_BYPASSIO"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_BYPASSIO 493L")]
    public const int ERROR_NOT_SUPPORTED_WITH_BYPASSIO = 493;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_BYPASSIO_DRIVER_SUPPORT"]/*' />
    [NativeTypeName("#define ERROR_NO_BYPASSIO_DRIVER_SUPPORT 494L")]
    public const int ERROR_NO_BYPASSIO_DRIVER_SUPPORT = 494;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_ENCRYPTION"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_ENCRYPTION 495L")]
    public const int ERROR_NOT_SUPPORTED_WITH_ENCRYPTION = 495;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_COMPRESSION"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_COMPRESSION 496L")]
    public const int ERROR_NOT_SUPPORTED_WITH_COMPRESSION = 496;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_REPLICATION"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_REPLICATION 497L")]
    public const int ERROR_NOT_SUPPORTED_WITH_REPLICATION = 497;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_DEDUPLICATION"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_DEDUPLICATION 498L")]
    public const int ERROR_NOT_SUPPORTED_WITH_DEDUPLICATION = 498;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_AUDITING"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_AUDITING 499L")]
    public const int ERROR_NOT_SUPPORTED_WITH_AUDITING = 499;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_USER_PROFILE_LOAD"]/*' />
    [NativeTypeName("#define ERROR_USER_PROFILE_LOAD 500L")]
    public const int ERROR_USER_PROFILE_LOAD = 500;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SESSION_KEY_TOO_SHORT"]/*' />
    [NativeTypeName("#define ERROR_SESSION_KEY_TOO_SHORT 501L")]
    public const int ERROR_SESSION_KEY_TOO_SHORT = 501;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCESS_DENIED_APPDATA"]/*' />
    [NativeTypeName("#define ERROR_ACCESS_DENIED_APPDATA 502L")]
    public const int ERROR_ACCESS_DENIED_APPDATA = 502;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_MONITORING"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_MONITORING 503L")]
    public const int ERROR_NOT_SUPPORTED_WITH_MONITORING = 503;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_SNAPSHOT"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_SNAPSHOT 504L")]
    public const int ERROR_NOT_SUPPORTED_WITH_SNAPSHOT = 504;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_VIRTUALIZATION"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_VIRTUALIZATION 505L")]
    public const int ERROR_NOT_SUPPORTED_WITH_VIRTUALIZATION = 505;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BYPASSIO_FLT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_BYPASSIO_FLT_NOT_SUPPORTED 506L")]
    public const int ERROR_BYPASSIO_FLT_NOT_SUPPORTED = 506;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_RESET_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_RESET_REQUIRED 507L")]
    public const int ERROR_DEVICE_RESET_REQUIRED = 507;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_WRITE_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_WRITE_ACCESS_DENIED 508L")]
    public const int ERROR_VOLUME_WRITE_ACCESS_DENIED = 508;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_WITH_CACHED_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_WITH_CACHED_HANDLE 509L")]
    public const int ERROR_NOT_SUPPORTED_WITH_CACHED_HANDLE = 509;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FS_METADATA_INCONSISTENT"]/*' />
    [NativeTypeName("#define ERROR_FS_METADATA_INCONSISTENT 510L")]
    public const int ERROR_FS_METADATA_INCONSISTENT = 510;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BLOCK_WEAK_REFERENCE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_BLOCK_WEAK_REFERENCE_INVALID 511L")]
    public const int ERROR_BLOCK_WEAK_REFERENCE_INVALID = 511;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BLOCK_SOURCE_WEAK_REFERENCE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_BLOCK_SOURCE_WEAK_REFERENCE_INVALID 512L")]
    public const int ERROR_BLOCK_SOURCE_WEAK_REFERENCE_INVALID = 512;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BLOCK_TARGET_WEAK_REFERENCE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_BLOCK_TARGET_WEAK_REFERENCE_INVALID 513L")]
    public const int ERROR_BLOCK_TARGET_WEAK_REFERENCE_INVALID = 513;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BLOCK_SHARED"]/*' />
    [NativeTypeName("#define ERROR_BLOCK_SHARED 514L")]
    public const int ERROR_BLOCK_SHARED = 514;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_UPGRADE_NOT_NEEDED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_UPGRADE_NOT_NEEDED 515L")]
    public const int ERROR_VOLUME_UPGRADE_NOT_NEEDED = 515;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_UPGRADE_PENDING"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_UPGRADE_PENDING 516L")]
    public const int ERROR_VOLUME_UPGRADE_PENDING = 516;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_UPGRADE_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_UPGRADE_DISABLED 517L")]
    public const int ERROR_VOLUME_UPGRADE_DISABLED = 517;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_UPGRADE_DISABLED_TILL_OS_DOWNGRADE_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_UPGRADE_DISABLED_TILL_OS_DOWNGRADE_EXPIRED 518L")]
    public const int ERROR_VOLUME_UPGRADE_DISABLED_TILL_OS_DOWNGRADE_EXPIRED = 518;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CONFIG_VALUE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CONFIG_VALUE 519L")]
    public const int ERROR_INVALID_CONFIG_VALUE = 519;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEMORY_DECOMPRESSION_HW_ERROR"]/*' />
    [NativeTypeName("#define ERROR_MEMORY_DECOMPRESSION_HW_ERROR 520L")]
    public const int ERROR_MEMORY_DECOMPRESSION_HW_ERROR = 520;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_ROLLBACK_DETECTED 521L")]
    public const int ERROR_VOLUME_ROLLBACK_DETECTED = 521;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_OPLOCK_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_INVALID_OPLOCK_REQUEST 522L")]
    public const int ERROR_INVALID_OPLOCK_REQUEST = 522;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLOUD_FILE_HYDRATION_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_CLOUD_FILE_HYDRATION_NOT_AVAILABLE 523L")]
    public const int ERROR_CLOUD_FILE_HYDRATION_NOT_AVAILABLE = 523;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CIMFS_VERIFICATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CIMFS_VERIFICATION_FAILED 524L")]
    public const int ERROR_CIMFS_VERIFICATION_FAILED = 524;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_FILE_NOT_SUPPORTED 525L")]
    public const int ERROR_SYSTEM_FILE_NOT_SUPPORTED = 525;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ARITHMETIC_OVERFLOW"]/*' />
    [NativeTypeName("#define ERROR_ARITHMETIC_OVERFLOW 534L")]
    public const int ERROR_ARITHMETIC_OVERFLOW = 534;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PIPE_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_PIPE_CONNECTED 535L")]
    public const int ERROR_PIPE_CONNECTED = 535;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PIPE_LISTENING"]/*' />
    [NativeTypeName("#define ERROR_PIPE_LISTENING 536L")]
    public const int ERROR_PIPE_LISTENING = 536;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VERIFIER_STOP"]/*' />
    [NativeTypeName("#define ERROR_VERIFIER_STOP 537L")]
    public const int ERROR_VERIFIER_STOP = 537;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ABIOS_ERROR"]/*' />
    [NativeTypeName("#define ERROR_ABIOS_ERROR 538L")]
    public const int ERROR_ABIOS_ERROR = 538;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WX86_WARNING"]/*' />
    [NativeTypeName("#define ERROR_WX86_WARNING 539L")]
    public const int ERROR_WX86_WARNING = 539;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WX86_ERROR"]/*' />
    [NativeTypeName("#define ERROR_WX86_ERROR 540L")]
    public const int ERROR_WX86_ERROR = 540;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIMER_NOT_CANCELED"]/*' />
    [NativeTypeName("#define ERROR_TIMER_NOT_CANCELED 541L")]
    public const int ERROR_TIMER_NOT_CANCELED = 541;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNWIND"]/*' />
    [NativeTypeName("#define ERROR_UNWIND 542L")]
    public const int ERROR_UNWIND = 542;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_STACK"]/*' />
    [NativeTypeName("#define ERROR_BAD_STACK 543L")]
    public const int ERROR_BAD_STACK = 543;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_UNWIND_TARGET"]/*' />
    [NativeTypeName("#define ERROR_INVALID_UNWIND_TARGET 544L")]
    public const int ERROR_INVALID_UNWIND_TARGET = 544;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PORT_ATTRIBUTES"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PORT_ATTRIBUTES 545L")]
    public const int ERROR_INVALID_PORT_ATTRIBUTES = 545;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PORT_MESSAGE_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_PORT_MESSAGE_TOO_LONG 546L")]
    public const int ERROR_PORT_MESSAGE_TOO_LONG = 546;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_QUOTA_LOWER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_QUOTA_LOWER 547L")]
    public const int ERROR_INVALID_QUOTA_LOWER = 547;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_ALREADY_ATTACHED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_ALREADY_ATTACHED 548L")]
    public const int ERROR_DEVICE_ALREADY_ATTACHED = 548;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTRUCTION_MISALIGNMENT"]/*' />
    [NativeTypeName("#define ERROR_INSTRUCTION_MISALIGNMENT 549L")]
    public const int ERROR_INSTRUCTION_MISALIGNMENT = 549;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROFILING_NOT_STARTED"]/*' />
    [NativeTypeName("#define ERROR_PROFILING_NOT_STARTED 550L")]
    public const int ERROR_PROFILING_NOT_STARTED = 550;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROFILING_NOT_STOPPED"]/*' />
    [NativeTypeName("#define ERROR_PROFILING_NOT_STOPPED 551L")]
    public const int ERROR_PROFILING_NOT_STOPPED = 551;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COULD_NOT_INTERPRET"]/*' />
    [NativeTypeName("#define ERROR_COULD_NOT_INTERPRET 552L")]
    public const int ERROR_COULD_NOT_INTERPRET = 552;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROFILING_AT_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_PROFILING_AT_LIMIT 553L")]
    public const int ERROR_PROFILING_AT_LIMIT = 553;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_WAIT"]/*' />
    [NativeTypeName("#define ERROR_CANT_WAIT 554L")]
    public const int ERROR_CANT_WAIT = 554;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_TERMINATE_SELF"]/*' />
    [NativeTypeName("#define ERROR_CANT_TERMINATE_SELF 555L")]
    public const int ERROR_CANT_TERMINATE_SELF = 555;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNEXPECTED_MM_CREATE_ERR"]/*' />
    [NativeTypeName("#define ERROR_UNEXPECTED_MM_CREATE_ERR 556L")]
    public const int ERROR_UNEXPECTED_MM_CREATE_ERR = 556;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNEXPECTED_MM_MAP_ERROR"]/*' />
    [NativeTypeName("#define ERROR_UNEXPECTED_MM_MAP_ERROR 557L")]
    public const int ERROR_UNEXPECTED_MM_MAP_ERROR = 557;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNEXPECTED_MM_EXTEND_ERR"]/*' />
    [NativeTypeName("#define ERROR_UNEXPECTED_MM_EXTEND_ERR 558L")]
    public const int ERROR_UNEXPECTED_MM_EXTEND_ERR = 558;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_FUNCTION_TABLE"]/*' />
    [NativeTypeName("#define ERROR_BAD_FUNCTION_TABLE 559L")]
    public const int ERROR_BAD_FUNCTION_TABLE = 559;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_GUID_TRANSLATION"]/*' />
    [NativeTypeName("#define ERROR_NO_GUID_TRANSLATION 560L")]
    public const int ERROR_NO_GUID_TRANSLATION = 560;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LDT_SIZE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LDT_SIZE 561L")]
    public const int ERROR_INVALID_LDT_SIZE = 561;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LDT_OFFSET"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LDT_OFFSET 563L")]
    public const int ERROR_INVALID_LDT_OFFSET = 563;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LDT_DESCRIPTOR"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LDT_DESCRIPTOR 564L")]
    public const int ERROR_INVALID_LDT_DESCRIPTOR = 564;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_THREADS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_THREADS 565L")]
    public const int ERROR_TOO_MANY_THREADS = 565;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_THREAD_NOT_IN_PROCESS"]/*' />
    [NativeTypeName("#define ERROR_THREAD_NOT_IN_PROCESS 566L")]
    public const int ERROR_THREAD_NOT_IN_PROCESS = 566;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGEFILE_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_PAGEFILE_QUOTA_EXCEEDED 567L")]
    public const int ERROR_PAGEFILE_QUOTA_EXCEEDED = 567;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOGON_SERVER_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_LOGON_SERVER_CONFLICT 568L")]
    public const int ERROR_LOGON_SERVER_CONFLICT = 568;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYNCHRONIZATION_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_SYNCHRONIZATION_REQUIRED 569L")]
    public const int ERROR_SYNCHRONIZATION_REQUIRED = 569;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NET_OPEN_FAILED"]/*' />
    [NativeTypeName("#define ERROR_NET_OPEN_FAILED 570L")]
    public const int ERROR_NET_OPEN_FAILED = 570;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IO_PRIVILEGE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IO_PRIVILEGE_FAILED 571L")]
    public const int ERROR_IO_PRIVILEGE_FAILED = 571;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONTROL_C_EXIT"]/*' />
    [NativeTypeName("#define ERROR_CONTROL_C_EXIT 572L")]
    public const int ERROR_CONTROL_C_EXIT = 572;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MISSING_SYSTEMFILE"]/*' />
    [NativeTypeName("#define ERROR_MISSING_SYSTEMFILE 573L")]
    public const int ERROR_MISSING_SYSTEMFILE = 573;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNHANDLED_EXCEPTION"]/*' />
    [NativeTypeName("#define ERROR_UNHANDLED_EXCEPTION 574L")]
    public const int ERROR_UNHANDLED_EXCEPTION = 574;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APP_INIT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_APP_INIT_FAILURE 575L")]
    public const int ERROR_APP_INIT_FAILURE = 575;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGEFILE_CREATE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PAGEFILE_CREATE_FAILED 576L")]
    public const int ERROR_PAGEFILE_CREATE_FAILED = 576;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_IMAGE_HASH"]/*' />
    [NativeTypeName("#define ERROR_INVALID_IMAGE_HASH 577L")]
    public const int ERROR_INVALID_IMAGE_HASH = 577;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_PAGEFILE"]/*' />
    [NativeTypeName("#define ERROR_NO_PAGEFILE 578L")]
    public const int ERROR_NO_PAGEFILE = 578;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ILLEGAL_FLOAT_CONTEXT"]/*' />
    [NativeTypeName("#define ERROR_ILLEGAL_FLOAT_CONTEXT 579L")]
    public const int ERROR_ILLEGAL_FLOAT_CONTEXT = 579;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_EVENT_PAIR"]/*' />
    [NativeTypeName("#define ERROR_NO_EVENT_PAIR 580L")]
    public const int ERROR_NO_EVENT_PAIR = 580;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DOMAIN_CTRLR_CONFIG_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DOMAIN_CTRLR_CONFIG_ERROR 581L")]
    public const int ERROR_DOMAIN_CTRLR_CONFIG_ERROR = 581;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ILLEGAL_CHARACTER"]/*' />
    [NativeTypeName("#define ERROR_ILLEGAL_CHARACTER 582L")]
    public const int ERROR_ILLEGAL_CHARACTER = 582;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNDEFINED_CHARACTER"]/*' />
    [NativeTypeName("#define ERROR_UNDEFINED_CHARACTER 583L")]
    public const int ERROR_UNDEFINED_CHARACTER = 583;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLOPPY_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_FLOPPY_VOLUME 584L")]
    public const int ERROR_FLOPPY_VOLUME = 584;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT"]/*' />
    [NativeTypeName("#define ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT 585L")]
    public const int ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT = 585;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BACKUP_CONTROLLER"]/*' />
    [NativeTypeName("#define ERROR_BACKUP_CONTROLLER 586L")]
    public const int ERROR_BACKUP_CONTROLLER = 586;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUTANT_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_MUTANT_LIMIT_EXCEEDED 587L")]
    public const int ERROR_MUTANT_LIMIT_EXCEEDED = 587;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FS_DRIVER_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_FS_DRIVER_REQUIRED 588L")]
    public const int ERROR_FS_DRIVER_REQUIRED = 588;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_LOAD_REGISTRY_FILE"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_LOAD_REGISTRY_FILE 589L")]
    public const int ERROR_CANNOT_LOAD_REGISTRY_FILE = 589;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEBUG_ATTACH_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DEBUG_ATTACH_FAILED 590L")]
    public const int ERROR_DEBUG_ATTACH_FAILED = 590;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_PROCESS_TERMINATED"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_PROCESS_TERMINATED 591L")]
    public const int ERROR_SYSTEM_PROCESS_TERMINATED = 591;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DATA_NOT_ACCEPTED"]/*' />
    [NativeTypeName("#define ERROR_DATA_NOT_ACCEPTED 592L")]
    public const int ERROR_DATA_NOT_ACCEPTED = 592;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VDM_HARD_ERROR"]/*' />
    [NativeTypeName("#define ERROR_VDM_HARD_ERROR 593L")]
    public const int ERROR_VDM_HARD_ERROR = 593;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_CANCEL_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_CANCEL_TIMEOUT 594L")]
    public const int ERROR_DRIVER_CANCEL_TIMEOUT = 594;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REPLY_MESSAGE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_REPLY_MESSAGE_MISMATCH 595L")]
    public const int ERROR_REPLY_MESSAGE_MISMATCH = 595;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOST_WRITEBEHIND_DATA"]/*' />
    [NativeTypeName("#define ERROR_LOST_WRITEBEHIND_DATA 596L")]
    public const int ERROR_LOST_WRITEBEHIND_DATA = 596;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIENT_SERVER_PARAMETERS_INVALID"]/*' />
    [NativeTypeName("#define ERROR_CLIENT_SERVER_PARAMETERS_INVALID 597L")]
    public const int ERROR_CLIENT_SERVER_PARAMETERS_INVALID = 597;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_TINY_STREAM"]/*' />
    [NativeTypeName("#define ERROR_NOT_TINY_STREAM 598L")]
    public const int ERROR_NOT_TINY_STREAM = 598;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STACK_OVERFLOW_READ"]/*' />
    [NativeTypeName("#define ERROR_STACK_OVERFLOW_READ 599L")]
    public const int ERROR_STACK_OVERFLOW_READ = 599;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONVERT_TO_LARGE"]/*' />
    [NativeTypeName("#define ERROR_CONVERT_TO_LARGE 600L")]
    public const int ERROR_CONVERT_TO_LARGE = 600;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FOUND_OUT_OF_SCOPE"]/*' />
    [NativeTypeName("#define ERROR_FOUND_OUT_OF_SCOPE 601L")]
    public const int ERROR_FOUND_OUT_OF_SCOPE = 601;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALLOCATE_BUCKET"]/*' />
    [NativeTypeName("#define ERROR_ALLOCATE_BUCKET 602L")]
    public const int ERROR_ALLOCATE_BUCKET = 602;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MARSHALL_OVERFLOW"]/*' />
    [NativeTypeName("#define ERROR_MARSHALL_OVERFLOW 603L")]
    public const int ERROR_MARSHALL_OVERFLOW = 603;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_VARIANT"]/*' />
    [NativeTypeName("#define ERROR_INVALID_VARIANT 604L")]
    public const int ERROR_INVALID_VARIANT = 604;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_COMPRESSION_BUFFER"]/*' />
    [NativeTypeName("#define ERROR_BAD_COMPRESSION_BUFFER 605L")]
    public const int ERROR_BAD_COMPRESSION_BUFFER = 605;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUDIT_FAILED"]/*' />
    [NativeTypeName("#define ERROR_AUDIT_FAILED 606L")]
    public const int ERROR_AUDIT_FAILED = 606;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIMER_RESOLUTION_NOT_SET"]/*' />
    [NativeTypeName("#define ERROR_TIMER_RESOLUTION_NOT_SET 607L")]
    public const int ERROR_TIMER_RESOLUTION_NOT_SET = 607;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSUFFICIENT_LOGON_INFO"]/*' />
    [NativeTypeName("#define ERROR_INSUFFICIENT_LOGON_INFO 608L")]
    public const int ERROR_INSUFFICIENT_LOGON_INFO = 608;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_DLL_ENTRYPOINT"]/*' />
    [NativeTypeName("#define ERROR_BAD_DLL_ENTRYPOINT 609L")]
    public const int ERROR_BAD_DLL_ENTRYPOINT = 609;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_SERVICE_ENTRYPOINT"]/*' />
    [NativeTypeName("#define ERROR_BAD_SERVICE_ENTRYPOINT 610L")]
    public const int ERROR_BAD_SERVICE_ENTRYPOINT = 610;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IP_ADDRESS_CONFLICT1"]/*' />
    [NativeTypeName("#define ERROR_IP_ADDRESS_CONFLICT1 611L")]
    public const int ERROR_IP_ADDRESS_CONFLICT1 = 611;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IP_ADDRESS_CONFLICT2"]/*' />
    [NativeTypeName("#define ERROR_IP_ADDRESS_CONFLICT2 612L")]
    public const int ERROR_IP_ADDRESS_CONFLICT2 = 612;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REGISTRY_QUOTA_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_REGISTRY_QUOTA_LIMIT 613L")]
    public const int ERROR_REGISTRY_QUOTA_LIMIT = 613;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_CALLBACK_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_NO_CALLBACK_ACTIVE 614L")]
    public const int ERROR_NO_CALLBACK_ACTIVE = 614;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PWD_TOO_SHORT"]/*' />
    [NativeTypeName("#define ERROR_PWD_TOO_SHORT 615L")]
    public const int ERROR_PWD_TOO_SHORT = 615;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PWD_TOO_RECENT"]/*' />
    [NativeTypeName("#define ERROR_PWD_TOO_RECENT 616L")]
    public const int ERROR_PWD_TOO_RECENT = 616;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PWD_HISTORY_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_PWD_HISTORY_CONFLICT 617L")]
    public const int ERROR_PWD_HISTORY_CONFLICT = 617;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNSUPPORTED_COMPRESSION"]/*' />
    [NativeTypeName("#define ERROR_UNSUPPORTED_COMPRESSION 618L")]
    public const int ERROR_UNSUPPORTED_COMPRESSION = 618;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_HW_PROFILE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_HW_PROFILE 619L")]
    public const int ERROR_INVALID_HW_PROFILE = 619;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PLUGPLAY_DEVICE_PATH"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PLUGPLAY_DEVICE_PATH 620L")]
    public const int ERROR_INVALID_PLUGPLAY_DEVICE_PATH = 620;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUOTA_LIST_INCONSISTENT"]/*' />
    [NativeTypeName("#define ERROR_QUOTA_LIST_INCONSISTENT 621L")]
    public const int ERROR_QUOTA_LIST_INCONSISTENT = 621;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVALUATION_EXPIRATION"]/*' />
    [NativeTypeName("#define ERROR_EVALUATION_EXPIRATION 622L")]
    public const int ERROR_EVALUATION_EXPIRATION = 622;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ILLEGAL_DLL_RELOCATION"]/*' />
    [NativeTypeName("#define ERROR_ILLEGAL_DLL_RELOCATION 623L")]
    public const int ERROR_ILLEGAL_DLL_RELOCATION = 623;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DLL_INIT_FAILED_LOGOFF"]/*' />
    [NativeTypeName("#define ERROR_DLL_INIT_FAILED_LOGOFF 624L")]
    public const int ERROR_DLL_INIT_FAILED_LOGOFF = 624;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VALIDATE_CONTINUE"]/*' />
    [NativeTypeName("#define ERROR_VALIDATE_CONTINUE 625L")]
    public const int ERROR_VALIDATE_CONTINUE = 625;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_MORE_MATCHES"]/*' />
    [NativeTypeName("#define ERROR_NO_MORE_MATCHES 626L")]
    public const int ERROR_NO_MORE_MATCHES = 626;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RANGE_LIST_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_RANGE_LIST_CONFLICT 627L")]
    public const int ERROR_RANGE_LIST_CONFLICT = 627;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVER_SID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_SERVER_SID_MISMATCH 628L")]
    public const int ERROR_SERVER_SID_MISMATCH = 628;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_ENABLE_DENY_ONLY"]/*' />
    [NativeTypeName("#define ERROR_CANT_ENABLE_DENY_ONLY 629L")]
    public const int ERROR_CANT_ENABLE_DENY_ONLY = 629;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLOAT_MULTIPLE_FAULTS"]/*' />
    [NativeTypeName("#define ERROR_FLOAT_MULTIPLE_FAULTS 630L")]
    public const int ERROR_FLOAT_MULTIPLE_FAULTS = 630;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLOAT_MULTIPLE_TRAPS"]/*' />
    [NativeTypeName("#define ERROR_FLOAT_MULTIPLE_TRAPS 631L")]
    public const int ERROR_FLOAT_MULTIPLE_TRAPS = 631;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOINTERFACE"]/*' />
    [NativeTypeName("#define ERROR_NOINTERFACE 632L")]
    public const int ERROR_NOINTERFACE = 632;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_FAILED_SLEEP"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_FAILED_SLEEP 633L")]
    public const int ERROR_DRIVER_FAILED_SLEEP = 633;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CORRUPT_SYSTEM_FILE"]/*' />
    [NativeTypeName("#define ERROR_CORRUPT_SYSTEM_FILE 634L")]
    public const int ERROR_CORRUPT_SYSTEM_FILE = 634;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COMMITMENT_MINIMUM"]/*' />
    [NativeTypeName("#define ERROR_COMMITMENT_MINIMUM 635L")]
    public const int ERROR_COMMITMENT_MINIMUM = 635;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_RESTART_ENUMERATION"]/*' />
    [NativeTypeName("#define ERROR_PNP_RESTART_ENUMERATION 636L")]
    public const int ERROR_PNP_RESTART_ENUMERATION = 636;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_IMAGE_BAD_SIGNATURE"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_IMAGE_BAD_SIGNATURE 637L")]
    public const int ERROR_SYSTEM_IMAGE_BAD_SIGNATURE = 637;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_PNP_REBOOT_REQUIRED 638L")]
    public const int ERROR_PNP_REBOOT_REQUIRED = 638;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSUFFICIENT_POWER"]/*' />
    [NativeTypeName("#define ERROR_INSUFFICIENT_POWER 639L")]
    public const int ERROR_INSUFFICIENT_POWER = 639;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MULTIPLE_FAULT_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_MULTIPLE_FAULT_VIOLATION 640L")]
    public const int ERROR_MULTIPLE_FAULT_VIOLATION = 640;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_SHUTDOWN"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_SHUTDOWN 641L")]
    public const int ERROR_SYSTEM_SHUTDOWN = 641;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PORT_NOT_SET"]/*' />
    [NativeTypeName("#define ERROR_PORT_NOT_SET 642L")]
    public const int ERROR_PORT_NOT_SET = 642;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_VERSION_CHECK_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_DS_VERSION_CHECK_FAILURE 643L")]
    public const int ERROR_DS_VERSION_CHECK_FAILURE = 643;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RANGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_RANGE_NOT_FOUND 644L")]
    public const int ERROR_RANGE_NOT_FOUND = 644;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SAFE_MODE_DRIVER"]/*' />
    [NativeTypeName("#define ERROR_NOT_SAFE_MODE_DRIVER 646L")]
    public const int ERROR_NOT_SAFE_MODE_DRIVER = 646;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAILED_DRIVER_ENTRY"]/*' />
    [NativeTypeName("#define ERROR_FAILED_DRIVER_ENTRY 647L")]
    public const int ERROR_FAILED_DRIVER_ENTRY = 647;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_ENUMERATION_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_ENUMERATION_ERROR 648L")]
    public const int ERROR_DEVICE_ENUMERATION_ERROR = 648;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MOUNT_POINT_NOT_RESOLVED"]/*' />
    [NativeTypeName("#define ERROR_MOUNT_POINT_NOT_RESOLVED 649L")]
    public const int ERROR_MOUNT_POINT_NOT_RESOLVED = 649;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DEVICE_OBJECT_PARAMETER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DEVICE_OBJECT_PARAMETER 650L")]
    public const int ERROR_INVALID_DEVICE_OBJECT_PARAMETER = 650;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_OCCURED"]/*' />
    [NativeTypeName("#define ERROR_MCA_OCCURED 651L")]
    public const int ERROR_MCA_OCCURED = 651;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_DATABASE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_DATABASE_ERROR 652L")]
    public const int ERROR_DRIVER_DATABASE_ERROR = 652;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_HIVE_TOO_LARGE"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_HIVE_TOO_LARGE 653L")]
    public const int ERROR_SYSTEM_HIVE_TOO_LARGE = 653;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_FAILED_PRIOR_UNLOAD"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_FAILED_PRIOR_UNLOAD 654L")]
    public const int ERROR_DRIVER_FAILED_PRIOR_UNLOAD = 654;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLSNAP_PREPARE_HIBERNATE"]/*' />
    [NativeTypeName("#define ERROR_VOLSNAP_PREPARE_HIBERNATE 655L")]
    public const int ERROR_VOLSNAP_PREPARE_HIBERNATE = 655;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HIBERNATION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_HIBERNATION_FAILURE 656L")]
    public const int ERROR_HIBERNATION_FAILURE = 656;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PWD_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_PWD_TOO_LONG 657L")]
    public const int ERROR_PWD_TOO_LONG = 657;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SYSTEM_LIMITATION"]/*' />
    [NativeTypeName("#define ERROR_FILE_SYSTEM_LIMITATION 665L")]
    public const int ERROR_FILE_SYSTEM_LIMITATION = 665;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ASSERTION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_ASSERTION_FAILURE 668L")]
    public const int ERROR_ASSERTION_FAILURE = 668;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACPI_ERROR"]/*' />
    [NativeTypeName("#define ERROR_ACPI_ERROR 669L")]
    public const int ERROR_ACPI_ERROR = 669;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WOW_ASSERTION"]/*' />
    [NativeTypeName("#define ERROR_WOW_ASSERTION 670L")]
    public const int ERROR_WOW_ASSERTION = 670;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_BAD_MPS_TABLE"]/*' />
    [NativeTypeName("#define ERROR_PNP_BAD_MPS_TABLE 671L")]
    public const int ERROR_PNP_BAD_MPS_TABLE = 671;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_TRANSLATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PNP_TRANSLATION_FAILED 672L")]
    public const int ERROR_PNP_TRANSLATION_FAILED = 672;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_IRQ_TRANSLATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PNP_IRQ_TRANSLATION_FAILED 673L")]
    public const int ERROR_PNP_IRQ_TRANSLATION_FAILED = 673;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PNP_INVALID_ID"]/*' />
    [NativeTypeName("#define ERROR_PNP_INVALID_ID 674L")]
    public const int ERROR_PNP_INVALID_ID = 674;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAKE_SYSTEM_DEBUGGER"]/*' />
    [NativeTypeName("#define ERROR_WAKE_SYSTEM_DEBUGGER 675L")]
    public const int ERROR_WAKE_SYSTEM_DEBUGGER = 675;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HANDLES_CLOSED"]/*' />
    [NativeTypeName("#define ERROR_HANDLES_CLOSED 676L")]
    public const int ERROR_HANDLES_CLOSED = 676;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXTRANEOUS_INFORMATION"]/*' />
    [NativeTypeName("#define ERROR_EXTRANEOUS_INFORMATION 677L")]
    public const int ERROR_EXTRANEOUS_INFORMATION = 677;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RXACT_COMMIT_NECESSARY"]/*' />
    [NativeTypeName("#define ERROR_RXACT_COMMIT_NECESSARY 678L")]
    public const int ERROR_RXACT_COMMIT_NECESSARY = 678;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEDIA_CHECK"]/*' />
    [NativeTypeName("#define ERROR_MEDIA_CHECK 679L")]
    public const int ERROR_MEDIA_CHECK = 679;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GUID_SUBSTITUTION_MADE"]/*' />
    [NativeTypeName("#define ERROR_GUID_SUBSTITUTION_MADE 680L")]
    public const int ERROR_GUID_SUBSTITUTION_MADE = 680;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STOPPED_ON_SYMLINK"]/*' />
    [NativeTypeName("#define ERROR_STOPPED_ON_SYMLINK 681L")]
    public const int ERROR_STOPPED_ON_SYMLINK = 681;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LONGJUMP"]/*' />
    [NativeTypeName("#define ERROR_LONGJUMP 682L")]
    public const int ERROR_LONGJUMP = 682;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PLUGPLAY_QUERY_VETOED"]/*' />
    [NativeTypeName("#define ERROR_PLUGPLAY_QUERY_VETOED 683L")]
    public const int ERROR_PLUGPLAY_QUERY_VETOED = 683;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNWIND_CONSOLIDATE"]/*' />
    [NativeTypeName("#define ERROR_UNWIND_CONSOLIDATE 684L")]
    public const int ERROR_UNWIND_CONSOLIDATE = 684;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REGISTRY_HIVE_RECOVERED"]/*' />
    [NativeTypeName("#define ERROR_REGISTRY_HIVE_RECOVERED 685L")]
    public const int ERROR_REGISTRY_HIVE_RECOVERED = 685;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DLL_MIGHT_BE_INSECURE"]/*' />
    [NativeTypeName("#define ERROR_DLL_MIGHT_BE_INSECURE 686L")]
    public const int ERROR_DLL_MIGHT_BE_INSECURE = 686;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DLL_MIGHT_BE_INCOMPATIBLE"]/*' />
    [NativeTypeName("#define ERROR_DLL_MIGHT_BE_INCOMPATIBLE 687L")]
    public const int ERROR_DLL_MIGHT_BE_INCOMPATIBLE = 687;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_EXCEPTION_NOT_HANDLED"]/*' />
    [NativeTypeName("#define ERROR_DBG_EXCEPTION_NOT_HANDLED 688L")]
    public const int ERROR_DBG_EXCEPTION_NOT_HANDLED = 688;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_REPLY_LATER"]/*' />
    [NativeTypeName("#define ERROR_DBG_REPLY_LATER 689L")]
    public const int ERROR_DBG_REPLY_LATER = 689;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE 690L")]
    public const int ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE = 690;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_TERMINATE_THREAD"]/*' />
    [NativeTypeName("#define ERROR_DBG_TERMINATE_THREAD 691L")]
    public const int ERROR_DBG_TERMINATE_THREAD = 691;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_TERMINATE_PROCESS"]/*' />
    [NativeTypeName("#define ERROR_DBG_TERMINATE_PROCESS 692L")]
    public const int ERROR_DBG_TERMINATE_PROCESS = 692;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_CONTROL_C"]/*' />
    [NativeTypeName("#define ERROR_DBG_CONTROL_C 693L")]
    public const int ERROR_DBG_CONTROL_C = 693;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_PRINTEXCEPTION_C"]/*' />
    [NativeTypeName("#define ERROR_DBG_PRINTEXCEPTION_C 694L")]
    public const int ERROR_DBG_PRINTEXCEPTION_C = 694;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_RIPEXCEPTION"]/*' />
    [NativeTypeName("#define ERROR_DBG_RIPEXCEPTION 695L")]
    public const int ERROR_DBG_RIPEXCEPTION = 695;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_CONTROL_BREAK"]/*' />
    [NativeTypeName("#define ERROR_DBG_CONTROL_BREAK 696L")]
    public const int ERROR_DBG_CONTROL_BREAK = 696;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_COMMAND_EXCEPTION"]/*' />
    [NativeTypeName("#define ERROR_DBG_COMMAND_EXCEPTION 697L")]
    public const int ERROR_DBG_COMMAND_EXCEPTION = 697;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OBJECT_NAME_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_OBJECT_NAME_EXISTS 698L")]
    public const int ERROR_OBJECT_NAME_EXISTS = 698;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_THREAD_WAS_SUSPENDED"]/*' />
    [NativeTypeName("#define ERROR_THREAD_WAS_SUSPENDED 699L")]
    public const int ERROR_THREAD_WAS_SUSPENDED = 699;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IMAGE_NOT_AT_BASE"]/*' />
    [NativeTypeName("#define ERROR_IMAGE_NOT_AT_BASE 700L")]
    public const int ERROR_IMAGE_NOT_AT_BASE = 700;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RXACT_STATE_CREATED"]/*' />
    [NativeTypeName("#define ERROR_RXACT_STATE_CREATED 701L")]
    public const int ERROR_RXACT_STATE_CREATED = 701;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SEGMENT_NOTIFICATION"]/*' />
    [NativeTypeName("#define ERROR_SEGMENT_NOTIFICATION 702L")]
    public const int ERROR_SEGMENT_NOTIFICATION = 702;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_CURRENT_DIRECTORY"]/*' />
    [NativeTypeName("#define ERROR_BAD_CURRENT_DIRECTORY 703L")]
    public const int ERROR_BAD_CURRENT_DIRECTORY = 703;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FT_READ_RECOVERY_FROM_BACKUP"]/*' />
    [NativeTypeName("#define ERROR_FT_READ_RECOVERY_FROM_BACKUP 704L")]
    public const int ERROR_FT_READ_RECOVERY_FROM_BACKUP = 704;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FT_WRITE_RECOVERY"]/*' />
    [NativeTypeName("#define ERROR_FT_WRITE_RECOVERY 705L")]
    public const int ERROR_FT_WRITE_RECOVERY = 705;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IMAGE_MACHINE_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_IMAGE_MACHINE_TYPE_MISMATCH 706L")]
    public const int ERROR_IMAGE_MACHINE_TYPE_MISMATCH = 706;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RECEIVE_PARTIAL"]/*' />
    [NativeTypeName("#define ERROR_RECEIVE_PARTIAL 707L")]
    public const int ERROR_RECEIVE_PARTIAL = 707;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RECEIVE_EXPEDITED"]/*' />
    [NativeTypeName("#define ERROR_RECEIVE_EXPEDITED 708L")]
    public const int ERROR_RECEIVE_EXPEDITED = 708;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RECEIVE_PARTIAL_EXPEDITED"]/*' />
    [NativeTypeName("#define ERROR_RECEIVE_PARTIAL_EXPEDITED 709L")]
    public const int ERROR_RECEIVE_PARTIAL_EXPEDITED = 709;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVENT_DONE"]/*' />
    [NativeTypeName("#define ERROR_EVENT_DONE 710L")]
    public const int ERROR_EVENT_DONE = 710;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVENT_PENDING"]/*' />
    [NativeTypeName("#define ERROR_EVENT_PENDING 711L")]
    public const int ERROR_EVENT_PENDING = 711;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CHECKING_FILE_SYSTEM"]/*' />
    [NativeTypeName("#define ERROR_CHECKING_FILE_SYSTEM 712L")]
    public const int ERROR_CHECKING_FILE_SYSTEM = 712;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FATAL_APP_EXIT"]/*' />
    [NativeTypeName("#define ERROR_FATAL_APP_EXIT 713L")]
    public const int ERROR_FATAL_APP_EXIT = 713;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PREDEFINED_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_PREDEFINED_HANDLE 714L")]
    public const int ERROR_PREDEFINED_HANDLE = 714;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAS_UNLOCKED"]/*' />
    [NativeTypeName("#define ERROR_WAS_UNLOCKED 715L")]
    public const int ERROR_WAS_UNLOCKED = 715;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_NOTIFICATION"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_NOTIFICATION 716L")]
    public const int ERROR_SERVICE_NOTIFICATION = 716;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAS_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_WAS_LOCKED 717L")]
    public const int ERROR_WAS_LOCKED = 717;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_HARD_ERROR"]/*' />
    [NativeTypeName("#define ERROR_LOG_HARD_ERROR 718L")]
    public const int ERROR_LOG_HARD_ERROR = 718;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_WIN32"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_WIN32 719L")]
    public const int ERROR_ALREADY_WIN32 = 719;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE"]/*' />
    [NativeTypeName("#define ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE 720L")]
    public const int ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE = 720;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_YIELD_PERFORMED"]/*' />
    [NativeTypeName("#define ERROR_NO_YIELD_PERFORMED 721L")]
    public const int ERROR_NO_YIELD_PERFORMED = 721;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIMER_RESUME_IGNORED"]/*' />
    [NativeTypeName("#define ERROR_TIMER_RESUME_IGNORED 722L")]
    public const int ERROR_TIMER_RESUME_IGNORED = 722;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ARBITRATION_UNHANDLED"]/*' />
    [NativeTypeName("#define ERROR_ARBITRATION_UNHANDLED 723L")]
    public const int ERROR_ARBITRATION_UNHANDLED = 723;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CARDBUS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_CARDBUS_NOT_SUPPORTED 724L")]
    public const int ERROR_CARDBUS_NOT_SUPPORTED = 724;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MP_PROCESSOR_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_MP_PROCESSOR_MISMATCH 725L")]
    public const int ERROR_MP_PROCESSOR_MISMATCH = 725;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HIBERNATED"]/*' />
    [NativeTypeName("#define ERROR_HIBERNATED 726L")]
    public const int ERROR_HIBERNATED = 726;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESUME_HIBERNATION"]/*' />
    [NativeTypeName("#define ERROR_RESUME_HIBERNATION 727L")]
    public const int ERROR_RESUME_HIBERNATION = 727;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FIRMWARE_UPDATED"]/*' />
    [NativeTypeName("#define ERROR_FIRMWARE_UPDATED 728L")]
    public const int ERROR_FIRMWARE_UPDATED = 728;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVERS_LEAKING_LOCKED_PAGES"]/*' />
    [NativeTypeName("#define ERROR_DRIVERS_LEAKING_LOCKED_PAGES 729L")]
    public const int ERROR_DRIVERS_LEAKING_LOCKED_PAGES = 729;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAKE_SYSTEM"]/*' />
    [NativeTypeName("#define ERROR_WAKE_SYSTEM 730L")]
    public const int ERROR_WAKE_SYSTEM = 730;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAIT_1"]/*' />
    [NativeTypeName("#define ERROR_WAIT_1 731L")]
    public const int ERROR_WAIT_1 = 731;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAIT_2"]/*' />
    [NativeTypeName("#define ERROR_WAIT_2 732L")]
    public const int ERROR_WAIT_2 = 732;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAIT_3"]/*' />
    [NativeTypeName("#define ERROR_WAIT_3 733L")]
    public const int ERROR_WAIT_3 = 733;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAIT_63"]/*' />
    [NativeTypeName("#define ERROR_WAIT_63 734L")]
    public const int ERROR_WAIT_63 = 734;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ABANDONED_WAIT_0"]/*' />
    [NativeTypeName("#define ERROR_ABANDONED_WAIT_0 735L")]
    public const int ERROR_ABANDONED_WAIT_0 = 735;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ABANDONED_WAIT_63"]/*' />
    [NativeTypeName("#define ERROR_ABANDONED_WAIT_63 736L")]
    public const int ERROR_ABANDONED_WAIT_63 = 736;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_USER_APC"]/*' />
    [NativeTypeName("#define ERROR_USER_APC 737L")]
    public const int ERROR_USER_APC = 737;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_KERNEL_APC"]/*' />
    [NativeTypeName("#define ERROR_KERNEL_APC 738L")]
    public const int ERROR_KERNEL_APC = 738;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALERTED"]/*' />
    [NativeTypeName("#define ERROR_ALERTED 739L")]
    public const int ERROR_ALERTED = 739;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ELEVATION_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_ELEVATION_REQUIRED 740L")]
    public const int ERROR_ELEVATION_REQUIRED = 740;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REPARSE"]/*' />
    [NativeTypeName("#define ERROR_REPARSE 741L")]
    public const int ERROR_REPARSE = 741;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPLOCK_BREAK_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_OPLOCK_BREAK_IN_PROGRESS 742L")]
    public const int ERROR_OPLOCK_BREAK_IN_PROGRESS = 742;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_MOUNTED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_MOUNTED 743L")]
    public const int ERROR_VOLUME_MOUNTED = 743;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RXACT_COMMITTED"]/*' />
    [NativeTypeName("#define ERROR_RXACT_COMMITTED 744L")]
    public const int ERROR_RXACT_COMMITTED = 744;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOTIFY_CLEANUP"]/*' />
    [NativeTypeName("#define ERROR_NOTIFY_CLEANUP 745L")]
    public const int ERROR_NOTIFY_CLEANUP = 745;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED 746L")]
    public const int ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED = 746;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGE_FAULT_TRANSITION"]/*' />
    [NativeTypeName("#define ERROR_PAGE_FAULT_TRANSITION 747L")]
    public const int ERROR_PAGE_FAULT_TRANSITION = 747;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGE_FAULT_DEMAND_ZERO"]/*' />
    [NativeTypeName("#define ERROR_PAGE_FAULT_DEMAND_ZERO 748L")]
    public const int ERROR_PAGE_FAULT_DEMAND_ZERO = 748;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGE_FAULT_COPY_ON_WRITE"]/*' />
    [NativeTypeName("#define ERROR_PAGE_FAULT_COPY_ON_WRITE 749L")]
    public const int ERROR_PAGE_FAULT_COPY_ON_WRITE = 749;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGE_FAULT_GUARD_PAGE"]/*' />
    [NativeTypeName("#define ERROR_PAGE_FAULT_GUARD_PAGE 750L")]
    public const int ERROR_PAGE_FAULT_GUARD_PAGE = 750;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGE_FAULT_PAGING_FILE"]/*' />
    [NativeTypeName("#define ERROR_PAGE_FAULT_PAGING_FILE 751L")]
    public const int ERROR_PAGE_FAULT_PAGING_FILE = 751;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CACHE_PAGE_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_CACHE_PAGE_LOCKED 752L")]
    public const int ERROR_CACHE_PAGE_LOCKED = 752;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CRASH_DUMP"]/*' />
    [NativeTypeName("#define ERROR_CRASH_DUMP 753L")]
    public const int ERROR_CRASH_DUMP = 753;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BUFFER_ALL_ZEROS"]/*' />
    [NativeTypeName("#define ERROR_BUFFER_ALL_ZEROS 754L")]
    public const int ERROR_BUFFER_ALL_ZEROS = 754;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REPARSE_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_REPARSE_OBJECT 755L")]
    public const int ERROR_REPARSE_OBJECT = 755;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_REQUIREMENTS_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_REQUIREMENTS_CHANGED 756L")]
    public const int ERROR_RESOURCE_REQUIREMENTS_CHANGED = 756;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSLATION_COMPLETE"]/*' />
    [NativeTypeName("#define ERROR_TRANSLATION_COMPLETE 757L")]
    public const int ERROR_TRANSLATION_COMPLETE = 757;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOTHING_TO_TERMINATE"]/*' />
    [NativeTypeName("#define ERROR_NOTHING_TO_TERMINATE 758L")]
    public const int ERROR_NOTHING_TO_TERMINATE = 758;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROCESS_NOT_IN_JOB"]/*' />
    [NativeTypeName("#define ERROR_PROCESS_NOT_IN_JOB 759L")]
    public const int ERROR_PROCESS_NOT_IN_JOB = 759;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROCESS_IN_JOB"]/*' />
    [NativeTypeName("#define ERROR_PROCESS_IN_JOB 760L")]
    public const int ERROR_PROCESS_IN_JOB = 760;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLSNAP_HIBERNATE_READY"]/*' />
    [NativeTypeName("#define ERROR_VOLSNAP_HIBERNATE_READY 761L")]
    public const int ERROR_VOLSNAP_HIBERNATE_READY = 761;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY"]/*' />
    [NativeTypeName("#define ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY 762L")]
    public const int ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY = 762;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED 763L")]
    public const int ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED = 763;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INTERRUPT_STILL_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_INTERRUPT_STILL_CONNECTED 764L")]
    public const int ERROR_INTERRUPT_STILL_CONNECTED = 764;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WAIT_FOR_OPLOCK"]/*' />
    [NativeTypeName("#define ERROR_WAIT_FOR_OPLOCK 765L")]
    public const int ERROR_WAIT_FOR_OPLOCK = 765;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_EXCEPTION_HANDLED"]/*' />
    [NativeTypeName("#define ERROR_DBG_EXCEPTION_HANDLED 766L")]
    public const int ERROR_DBG_EXCEPTION_HANDLED = 766;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_CONTINUE"]/*' />
    [NativeTypeName("#define ERROR_DBG_CONTINUE 767L")]
    public const int ERROR_DBG_CONTINUE = 767;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CALLBACK_POP_STACK"]/*' />
    [NativeTypeName("#define ERROR_CALLBACK_POP_STACK 768L")]
    public const int ERROR_CALLBACK_POP_STACK = 768;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COMPRESSION_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_COMPRESSION_DISABLED 769L")]
    public const int ERROR_COMPRESSION_DISABLED = 769;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANTFETCHBACKWARDS"]/*' />
    [NativeTypeName("#define ERROR_CANTFETCHBACKWARDS 770L")]
    public const int ERROR_CANTFETCHBACKWARDS = 770;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANTSCROLLBACKWARDS"]/*' />
    [NativeTypeName("#define ERROR_CANTSCROLLBACKWARDS 771L")]
    public const int ERROR_CANTSCROLLBACKWARDS = 771;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ROWSNOTRELEASED"]/*' />
    [NativeTypeName("#define ERROR_ROWSNOTRELEASED 772L")]
    public const int ERROR_ROWSNOTRELEASED = 772;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_ACCESSOR_FLAGS"]/*' />
    [NativeTypeName("#define ERROR_BAD_ACCESSOR_FLAGS 773L")]
    public const int ERROR_BAD_ACCESSOR_FLAGS = 773;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ERRORS_ENCOUNTERED"]/*' />
    [NativeTypeName("#define ERROR_ERRORS_ENCOUNTERED 774L")]
    public const int ERROR_ERRORS_ENCOUNTERED = 774;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_CAPABLE"]/*' />
    [NativeTypeName("#define ERROR_NOT_CAPABLE 775L")]
    public const int ERROR_NOT_CAPABLE = 775;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REQUEST_OUT_OF_SEQUENCE"]/*' />
    [NativeTypeName("#define ERROR_REQUEST_OUT_OF_SEQUENCE 776L")]
    public const int ERROR_REQUEST_OUT_OF_SEQUENCE = 776;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VERSION_PARSE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_VERSION_PARSE_ERROR 777L")]
    public const int ERROR_VERSION_PARSE_ERROR = 777;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BADSTARTPOSITION"]/*' />
    [NativeTypeName("#define ERROR_BADSTARTPOSITION 778L")]
    public const int ERROR_BADSTARTPOSITION = 778;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEMORY_HARDWARE"]/*' />
    [NativeTypeName("#define ERROR_MEMORY_HARDWARE 779L")]
    public const int ERROR_MEMORY_HARDWARE = 779;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_REPAIR_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_DISK_REPAIR_DISABLED 780L")]
    public const int ERROR_DISK_REPAIR_DISABLED = 780;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE"]/*' />
    [NativeTypeName("#define ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE 781L")]
    public const int ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE = 781;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_POWERSTATE_TRANSITION"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_POWERSTATE_TRANSITION 782L")]
    public const int ERROR_SYSTEM_POWERSTATE_TRANSITION = 782;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION 783L")]
    public const int ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION = 783;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_EXCEPTION"]/*' />
    [NativeTypeName("#define ERROR_MCA_EXCEPTION 784L")]
    public const int ERROR_MCA_EXCEPTION = 784;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCESS_AUDIT_BY_POLICY"]/*' />
    [NativeTypeName("#define ERROR_ACCESS_AUDIT_BY_POLICY 785L")]
    public const int ERROR_ACCESS_AUDIT_BY_POLICY = 785;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY"]/*' />
    [NativeTypeName("#define ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY 786L")]
    public const int ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = 786;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ABANDON_HIBERFILE"]/*' />
    [NativeTypeName("#define ERROR_ABANDON_HIBERFILE 787L")]
    public const int ERROR_ABANDON_HIBERFILE = 787;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED"]/*' />
    [NativeTypeName("#define ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED 788L")]
    public const int ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED = 788;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR"]/*' />
    [NativeTypeName("#define ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR 789L")]
    public const int ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR = 789;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR"]/*' />
    [NativeTypeName("#define ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR 790L")]
    public const int ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR = 790;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_MCFG_TABLE"]/*' />
    [NativeTypeName("#define ERROR_BAD_MCFG_TABLE 791L")]
    public const int ERROR_BAD_MCFG_TABLE = 791;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_REPAIR_REDIRECTED"]/*' />
    [NativeTypeName("#define ERROR_DISK_REPAIR_REDIRECTED 792L")]
    public const int ERROR_DISK_REPAIR_REDIRECTED = 792;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_REPAIR_UNSUCCESSFUL"]/*' />
    [NativeTypeName("#define ERROR_DISK_REPAIR_UNSUCCESSFUL 793L")]
    public const int ERROR_DISK_REPAIR_UNSUCCESSFUL = 793;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CORRUPT_LOG_OVERFULL"]/*' />
    [NativeTypeName("#define ERROR_CORRUPT_LOG_OVERFULL 794L")]
    public const int ERROR_CORRUPT_LOG_OVERFULL = 794;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CORRUPT_LOG_CORRUPTED"]/*' />
    [NativeTypeName("#define ERROR_CORRUPT_LOG_CORRUPTED 795L")]
    public const int ERROR_CORRUPT_LOG_CORRUPTED = 795;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CORRUPT_LOG_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_CORRUPT_LOG_UNAVAILABLE 796L")]
    public const int ERROR_CORRUPT_LOG_UNAVAILABLE = 796;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CORRUPT_LOG_DELETED_FULL"]/*' />
    [NativeTypeName("#define ERROR_CORRUPT_LOG_DELETED_FULL 797L")]
    public const int ERROR_CORRUPT_LOG_DELETED_FULL = 797;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CORRUPT_LOG_CLEARED"]/*' />
    [NativeTypeName("#define ERROR_CORRUPT_LOG_CLEARED 798L")]
    public const int ERROR_CORRUPT_LOG_CLEARED = 798;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ORPHAN_NAME_EXHAUSTED"]/*' />
    [NativeTypeName("#define ERROR_ORPHAN_NAME_EXHAUSTED 799L")]
    public const int ERROR_ORPHAN_NAME_EXHAUSTED = 799;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE 800L")]
    public const int ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE = 800;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_GRANT_REQUESTED_OPLOCK"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_GRANT_REQUESTED_OPLOCK 801L")]
    public const int ERROR_CANNOT_GRANT_REQUESTED_OPLOCK = 801;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_BREAK_OPLOCK"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_BREAK_OPLOCK 802L")]
    public const int ERROR_CANNOT_BREAK_OPLOCK = 802;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPLOCK_HANDLE_CLOSED"]/*' />
    [NativeTypeName("#define ERROR_OPLOCK_HANDLE_CLOSED 803L")]
    public const int ERROR_OPLOCK_HANDLE_CLOSED = 803;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_ACE_CONDITION"]/*' />
    [NativeTypeName("#define ERROR_NO_ACE_CONDITION 804L")]
    public const int ERROR_NO_ACE_CONDITION = 804;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ACE_CONDITION"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ACE_CONDITION 805L")]
    public const int ERROR_INVALID_ACE_CONDITION = 805;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_HANDLE_REVOKED"]/*' />
    [NativeTypeName("#define ERROR_FILE_HANDLE_REVOKED 806L")]
    public const int ERROR_FILE_HANDLE_REVOKED = 806;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IMAGE_AT_DIFFERENT_BASE"]/*' />
    [NativeTypeName("#define ERROR_IMAGE_AT_DIFFERENT_BASE 807L")]
    public const int ERROR_IMAGE_AT_DIFFERENT_BASE = 807;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCRYPTED_IO_NOT_POSSIBLE"]/*' />
    [NativeTypeName("#define ERROR_ENCRYPTED_IO_NOT_POSSIBLE 808L")]
    public const int ERROR_ENCRYPTED_IO_NOT_POSSIBLE = 808;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_METADATA_OPTIMIZATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_FILE_METADATA_OPTIMIZATION_IN_PROGRESS 809L")]
    public const int ERROR_FILE_METADATA_OPTIMIZATION_IN_PROGRESS = 809;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUOTA_ACTIVITY"]/*' />
    [NativeTypeName("#define ERROR_QUOTA_ACTIVITY 810L")]
    public const int ERROR_QUOTA_ACTIVITY = 810;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HANDLE_REVOKED"]/*' />
    [NativeTypeName("#define ERROR_HANDLE_REVOKED 811L")]
    public const int ERROR_HANDLE_REVOKED = 811;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CALLBACK_INVOKE_INLINE"]/*' />
    [NativeTypeName("#define ERROR_CALLBACK_INVOKE_INLINE 812L")]
    public const int ERROR_CALLBACK_INVOKE_INLINE = 812;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CPU_SET_INVALID"]/*' />
    [NativeTypeName("#define ERROR_CPU_SET_INVALID 813L")]
    public const int ERROR_CPU_SET_INVALID = 813;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCLAVE_NOT_TERMINATED"]/*' />
    [NativeTypeName("#define ERROR_ENCLAVE_NOT_TERMINATED 814L")]
    public const int ERROR_ENCLAVE_NOT_TERMINATED = 814;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCLAVE_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_ENCLAVE_VIOLATION 815L")]
    public const int ERROR_ENCLAVE_VIOLATION = 815;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVER_TRANSPORT_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_SERVER_TRANSPORT_CONFLICT 816L")]
    public const int ERROR_SERVER_TRANSPORT_CONFLICT = 816;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CERTIFICATE_VALIDATION_PREFERENCE_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_CERTIFICATE_VALIDATION_PREFERENCE_CONFLICT 817L")]
    public const int ERROR_CERTIFICATE_VALIDATION_PREFERENCE_CONFLICT = 817;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FT_READ_FROM_COPY_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_FT_READ_FROM_COPY_FAILURE 818L")]
    public const int ERROR_FT_READ_FROM_COPY_FAILURE = 818;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECTION_DIRECT_MAP_ONLY"]/*' />
    [NativeTypeName("#define ERROR_SECTION_DIRECT_MAP_ONLY 819L")]
    public const int ERROR_SECTION_DIRECT_MAP_ONLY = 819;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LINUX_SUBSYSTEM_UPDATE_REQUIRED_LIFTED_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_LINUX_SUBSYSTEM_UPDATE_REQUIRED_LIFTED_REQUIRED 820L")]
    public const int ERROR_LINUX_SUBSYSTEM_UPDATE_REQUIRED_LIFTED_REQUIRED = 820;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EA_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_EA_ACCESS_DENIED 994L")]
    public const int ERROR_EA_ACCESS_DENIED = 994;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPERATION_ABORTED"]/*' />
    [NativeTypeName("#define ERROR_OPERATION_ABORTED 995L")]
    public const int ERROR_OPERATION_ABORTED = 995;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IO_INCOMPLETE"]/*' />
    [NativeTypeName("#define ERROR_IO_INCOMPLETE 996L")]
    public const int ERROR_IO_INCOMPLETE = 996;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IO_PENDING"]/*' />
    [NativeTypeName("#define ERROR_IO_PENDING 997L")]
    public const int ERROR_IO_PENDING = 997;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOACCESS"]/*' />
    [NativeTypeName("#define ERROR_NOACCESS 998L")]
    public const int ERROR_NOACCESS = 998;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SWAPERROR"]/*' />
    [NativeTypeName("#define ERROR_SWAPERROR 999L")]
    public const int ERROR_SWAPERROR = 999;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STACK_OVERFLOW"]/*' />
    [NativeTypeName("#define ERROR_STACK_OVERFLOW 1001L")]
    public const int ERROR_STACK_OVERFLOW = 1001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MESSAGE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MESSAGE 1002L")]
    public const int ERROR_INVALID_MESSAGE = 1002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAN_NOT_COMPLETE"]/*' />
    [NativeTypeName("#define ERROR_CAN_NOT_COMPLETE 1003L")]
    public const int ERROR_CAN_NOT_COMPLETE = 1003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FLAGS"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FLAGS 1004L")]
    public const int ERROR_INVALID_FLAGS = 1004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNRECOGNIZED_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_UNRECOGNIZED_VOLUME 1005L")]
    public const int ERROR_UNRECOGNIZED_VOLUME = 1005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_FILE_INVALID 1006L")]
    public const int ERROR_FILE_INVALID = 1006;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FULLSCREEN_MODE"]/*' />
    [NativeTypeName("#define ERROR_FULLSCREEN_MODE 1007L")]
    public const int ERROR_FULLSCREEN_MODE = 1007;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_TOKEN"]/*' />
    [NativeTypeName("#define ERROR_NO_TOKEN 1008L")]
    public const int ERROR_NO_TOKEN = 1008;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BADDB"]/*' />
    [NativeTypeName("#define ERROR_BADDB 1009L")]
    public const int ERROR_BADDB = 1009;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BADKEY"]/*' />
    [NativeTypeName("#define ERROR_BADKEY 1010L")]
    public const int ERROR_BADKEY = 1010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANTOPEN"]/*' />
    [NativeTypeName("#define ERROR_CANTOPEN 1011L")]
    public const int ERROR_CANTOPEN = 1011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANTREAD"]/*' />
    [NativeTypeName("#define ERROR_CANTREAD 1012L")]
    public const int ERROR_CANTREAD = 1012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANTWRITE"]/*' />
    [NativeTypeName("#define ERROR_CANTWRITE 1013L")]
    public const int ERROR_CANTWRITE = 1013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REGISTRY_RECOVERED"]/*' />
    [NativeTypeName("#define ERROR_REGISTRY_RECOVERED 1014L")]
    public const int ERROR_REGISTRY_RECOVERED = 1014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REGISTRY_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_REGISTRY_CORRUPT 1015L")]
    public const int ERROR_REGISTRY_CORRUPT = 1015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REGISTRY_IO_FAILED"]/*' />
    [NativeTypeName("#define ERROR_REGISTRY_IO_FAILED 1016L")]
    public const int ERROR_REGISTRY_IO_FAILED = 1016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_REGISTRY_FILE"]/*' />
    [NativeTypeName("#define ERROR_NOT_REGISTRY_FILE 1017L")]
    public const int ERROR_NOT_REGISTRY_FILE = 1017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_KEY_DELETED"]/*' />
    [NativeTypeName("#define ERROR_KEY_DELETED 1018L")]
    public const int ERROR_KEY_DELETED = 1018;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_LOG_SPACE"]/*' />
    [NativeTypeName("#define ERROR_NO_LOG_SPACE 1019L")]
    public const int ERROR_NO_LOG_SPACE = 1019;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_KEY_HAS_CHILDREN"]/*' />
    [NativeTypeName("#define ERROR_KEY_HAS_CHILDREN 1020L")]
    public const int ERROR_KEY_HAS_CHILDREN = 1020;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CHILD_MUST_BE_VOLATILE"]/*' />
    [NativeTypeName("#define ERROR_CHILD_MUST_BE_VOLATILE 1021L")]
    public const int ERROR_CHILD_MUST_BE_VOLATILE = 1021;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOTIFY_ENUM_DIR"]/*' />
    [NativeTypeName("#define ERROR_NOTIFY_ENUM_DIR 1022L")]
    public const int ERROR_NOTIFY_ENUM_DIR = 1022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPENDENT_SERVICES_RUNNING"]/*' />
    [NativeTypeName("#define ERROR_DEPENDENT_SERVICES_RUNNING 1051L")]
    public const int ERROR_DEPENDENT_SERVICES_RUNNING = 1051;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SERVICE_CONTROL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SERVICE_CONTROL 1052L")]
    public const int ERROR_INVALID_SERVICE_CONTROL = 1052;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_REQUEST_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_REQUEST_TIMEOUT 1053L")]
    public const int ERROR_SERVICE_REQUEST_TIMEOUT = 1053;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_NO_THREAD"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_NO_THREAD 1054L")]
    public const int ERROR_SERVICE_NO_THREAD = 1054;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_DATABASE_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_DATABASE_LOCKED 1055L")]
    public const int ERROR_SERVICE_DATABASE_LOCKED = 1055;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_ALREADY_RUNNING"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_ALREADY_RUNNING 1056L")]
    public const int ERROR_SERVICE_ALREADY_RUNNING = 1056;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SERVICE_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SERVICE_ACCOUNT 1057L")]
    public const int ERROR_INVALID_SERVICE_ACCOUNT = 1057;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_DISABLED 1058L")]
    public const int ERROR_SERVICE_DISABLED = 1058;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CIRCULAR_DEPENDENCY"]/*' />
    [NativeTypeName("#define ERROR_CIRCULAR_DEPENDENCY 1059L")]
    public const int ERROR_CIRCULAR_DEPENDENCY = 1059;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_DOES_NOT_EXIST 1060L")]
    public const int ERROR_SERVICE_DOES_NOT_EXIST = 1060;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_CANNOT_ACCEPT_CTRL"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_CANNOT_ACCEPT_CTRL 1061L")]
    public const int ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_NOT_ACTIVE 1062L")]
    public const int ERROR_SERVICE_NOT_ACTIVE = 1062;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAILED_SERVICE_CONTROLLER_CONNECT"]/*' />
    [NativeTypeName("#define ERROR_FAILED_SERVICE_CONTROLLER_CONNECT 1063L")]
    public const int ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXCEPTION_IN_SERVICE"]/*' />
    [NativeTypeName("#define ERROR_EXCEPTION_IN_SERVICE 1064L")]
    public const int ERROR_EXCEPTION_IN_SERVICE = 1064;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DATABASE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define ERROR_DATABASE_DOES_NOT_EXIST 1065L")]
    public const int ERROR_DATABASE_DOES_NOT_EXIST = 1065;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_SPECIFIC_ERROR"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_SPECIFIC_ERROR 1066L")]
    public const int ERROR_SERVICE_SPECIFIC_ERROR = 1066;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROCESS_ABORTED"]/*' />
    [NativeTypeName("#define ERROR_PROCESS_ABORTED 1067L")]
    public const int ERROR_PROCESS_ABORTED = 1067;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_DEPENDENCY_FAIL"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_DEPENDENCY_FAIL 1068L")]
    public const int ERROR_SERVICE_DEPENDENCY_FAIL = 1068;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_LOGON_FAILED"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_LOGON_FAILED 1069L")]
    public const int ERROR_SERVICE_LOGON_FAILED = 1069;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_START_HANG"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_START_HANG 1070L")]
    public const int ERROR_SERVICE_START_HANG = 1070;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SERVICE_LOCK"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SERVICE_LOCK 1071L")]
    public const int ERROR_INVALID_SERVICE_LOCK = 1071;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_MARKED_FOR_DELETE"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_MARKED_FOR_DELETE 1072L")]
    public const int ERROR_SERVICE_MARKED_FOR_DELETE = 1072;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_EXISTS 1073L")]
    public const int ERROR_SERVICE_EXISTS = 1073;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_RUNNING_LKG"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_RUNNING_LKG 1074L")]
    public const int ERROR_ALREADY_RUNNING_LKG = 1074;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_DEPENDENCY_DELETED"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_DEPENDENCY_DELETED 1075L")]
    public const int ERROR_SERVICE_DEPENDENCY_DELETED = 1075;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BOOT_ALREADY_ACCEPTED"]/*' />
    [NativeTypeName("#define ERROR_BOOT_ALREADY_ACCEPTED 1076L")]
    public const int ERROR_BOOT_ALREADY_ACCEPTED = 1076;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_NEVER_STARTED"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_NEVER_STARTED 1077L")]
    public const int ERROR_SERVICE_NEVER_STARTED = 1077;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DUPLICATE_SERVICE_NAME"]/*' />
    [NativeTypeName("#define ERROR_DUPLICATE_SERVICE_NAME 1078L")]
    public const int ERROR_DUPLICATE_SERVICE_NAME = 1078;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIFFERENT_SERVICE_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_DIFFERENT_SERVICE_ACCOUNT 1079L")]
    public const int ERROR_DIFFERENT_SERVICE_ACCOUNT = 1079;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_DETECT_DRIVER_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_DETECT_DRIVER_FAILURE 1080L")]
    public const int ERROR_CANNOT_DETECT_DRIVER_FAILURE = 1080;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_DETECT_PROCESS_ABORT"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_DETECT_PROCESS_ABORT 1081L")]
    public const int ERROR_CANNOT_DETECT_PROCESS_ABORT = 1081;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_RECOVERY_PROGRAM"]/*' />
    [NativeTypeName("#define ERROR_NO_RECOVERY_PROGRAM 1082L")]
    public const int ERROR_NO_RECOVERY_PROGRAM = 1082;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_NOT_IN_EXE"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_NOT_IN_EXE 1083L")]
    public const int ERROR_SERVICE_NOT_IN_EXE = 1083;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SAFEBOOT_SERVICE"]/*' />
    [NativeTypeName("#define ERROR_NOT_SAFEBOOT_SERVICE 1084L")]
    public const int ERROR_NOT_SAFEBOOT_SERVICE = 1084;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_END_OF_MEDIA"]/*' />
    [NativeTypeName("#define ERROR_END_OF_MEDIA 1100L")]
    public const int ERROR_END_OF_MEDIA = 1100;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILEMARK_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_FILEMARK_DETECTED 1101L")]
    public const int ERROR_FILEMARK_DETECTED = 1101;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BEGINNING_OF_MEDIA"]/*' />
    [NativeTypeName("#define ERROR_BEGINNING_OF_MEDIA 1102L")]
    public const int ERROR_BEGINNING_OF_MEDIA = 1102;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SETMARK_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_SETMARK_DETECTED 1103L")]
    public const int ERROR_SETMARK_DETECTED = 1103;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_DATA_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_NO_DATA_DETECTED 1104L")]
    public const int ERROR_NO_DATA_DETECTED = 1104;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PARTITION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_PARTITION_FAILURE 1105L")]
    public const int ERROR_PARTITION_FAILURE = 1105;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_BLOCK_LENGTH"]/*' />
    [NativeTypeName("#define ERROR_INVALID_BLOCK_LENGTH 1106L")]
    public const int ERROR_INVALID_BLOCK_LENGTH = 1106;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_NOT_PARTITIONED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_NOT_PARTITIONED 1107L")]
    public const int ERROR_DEVICE_NOT_PARTITIONED = 1107;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_LOCK_MEDIA"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_LOCK_MEDIA 1108L")]
    public const int ERROR_UNABLE_TO_LOCK_MEDIA = 1108;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_UNLOAD_MEDIA"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_UNLOAD_MEDIA 1109L")]
    public const int ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEDIA_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_MEDIA_CHANGED 1110L")]
    public const int ERROR_MEDIA_CHANGED = 1110;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BUS_RESET"]/*' />
    [NativeTypeName("#define ERROR_BUS_RESET 1111L")]
    public const int ERROR_BUS_RESET = 1111;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_MEDIA_IN_DRIVE"]/*' />
    [NativeTypeName("#define ERROR_NO_MEDIA_IN_DRIVE 1112L")]
    public const int ERROR_NO_MEDIA_IN_DRIVE = 1112;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_UNICODE_TRANSLATION"]/*' />
    [NativeTypeName("#define ERROR_NO_UNICODE_TRANSLATION 1113L")]
    public const int ERROR_NO_UNICODE_TRANSLATION = 1113;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DLL_INIT_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DLL_INIT_FAILED 1114L")]
    public const int ERROR_DLL_INIT_FAILED = 1114;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHUTDOWN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_SHUTDOWN_IN_PROGRESS 1115L")]
    public const int ERROR_SHUTDOWN_IN_PROGRESS = 1115;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SHUTDOWN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_NO_SHUTDOWN_IN_PROGRESS 1116L")]
    public const int ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IO_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_IO_DEVICE 1117L")]
    public const int ERROR_IO_DEVICE = 1117;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERIAL_NO_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_SERIAL_NO_DEVICE 1118L")]
    public const int ERROR_SERIAL_NO_DEVICE = 1118;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IRQ_BUSY"]/*' />
    [NativeTypeName("#define ERROR_IRQ_BUSY 1119L")]
    public const int ERROR_IRQ_BUSY = 1119;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MORE_WRITES"]/*' />
    [NativeTypeName("#define ERROR_MORE_WRITES 1120L")]
    public const int ERROR_MORE_WRITES = 1120;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COUNTER_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_COUNTER_TIMEOUT 1121L")]
    public const int ERROR_COUNTER_TIMEOUT = 1121;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLOPPY_ID_MARK_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_FLOPPY_ID_MARK_NOT_FOUND 1122L")]
    public const int ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLOPPY_WRONG_CYLINDER"]/*' />
    [NativeTypeName("#define ERROR_FLOPPY_WRONG_CYLINDER 1123L")]
    public const int ERROR_FLOPPY_WRONG_CYLINDER = 1123;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLOPPY_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define ERROR_FLOPPY_UNKNOWN_ERROR 1124L")]
    public const int ERROR_FLOPPY_UNKNOWN_ERROR = 1124;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLOPPY_BAD_REGISTERS"]/*' />
    [NativeTypeName("#define ERROR_FLOPPY_BAD_REGISTERS 1125L")]
    public const int ERROR_FLOPPY_BAD_REGISTERS = 1125;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_RECALIBRATE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DISK_RECALIBRATE_FAILED 1126L")]
    public const int ERROR_DISK_RECALIBRATE_FAILED = 1126;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_OPERATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DISK_OPERATION_FAILED 1127L")]
    public const int ERROR_DISK_OPERATION_FAILED = 1127;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_RESET_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DISK_RESET_FAILED 1128L")]
    public const int ERROR_DISK_RESET_FAILED = 1128;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EOM_OVERFLOW"]/*' />
    [NativeTypeName("#define ERROR_EOM_OVERFLOW 1129L")]
    public const int ERROR_EOM_OVERFLOW = 1129;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_ENOUGH_SERVER_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_NOT_ENOUGH_SERVER_MEMORY 1130L")]
    public const int ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_POSSIBLE_DEADLOCK"]/*' />
    [NativeTypeName("#define ERROR_POSSIBLE_DEADLOCK 1131L")]
    public const int ERROR_POSSIBLE_DEADLOCK = 1131;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MAPPED_ALIGNMENT"]/*' />
    [NativeTypeName("#define ERROR_MAPPED_ALIGNMENT 1132L")]
    public const int ERROR_MAPPED_ALIGNMENT = 1132;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SET_POWER_STATE_VETOED"]/*' />
    [NativeTypeName("#define ERROR_SET_POWER_STATE_VETOED 1140L")]
    public const int ERROR_SET_POWER_STATE_VETOED = 1140;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SET_POWER_STATE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_SET_POWER_STATE_FAILED 1141L")]
    public const int ERROR_SET_POWER_STATE_FAILED = 1141;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_LINKS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_LINKS 1142L")]
    public const int ERROR_TOO_MANY_LINKS = 1142;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OLD_WIN_VERSION"]/*' />
    [NativeTypeName("#define ERROR_OLD_WIN_VERSION 1150L")]
    public const int ERROR_OLD_WIN_VERSION = 1150;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APP_WRONG_OS"]/*' />
    [NativeTypeName("#define ERROR_APP_WRONG_OS 1151L")]
    public const int ERROR_APP_WRONG_OS = 1151;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SINGLE_INSTANCE_APP"]/*' />
    [NativeTypeName("#define ERROR_SINGLE_INSTANCE_APP 1152L")]
    public const int ERROR_SINGLE_INSTANCE_APP = 1152;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RMODE_APP"]/*' />
    [NativeTypeName("#define ERROR_RMODE_APP 1153L")]
    public const int ERROR_RMODE_APP = 1153;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DLL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DLL 1154L")]
    public const int ERROR_INVALID_DLL = 1154;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_ASSOCIATION"]/*' />
    [NativeTypeName("#define ERROR_NO_ASSOCIATION 1155L")]
    public const int ERROR_NO_ASSOCIATION = 1155;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DDE_FAIL"]/*' />
    [NativeTypeName("#define ERROR_DDE_FAIL 1156L")]
    public const int ERROR_DDE_FAIL = 1156;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DLL_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DLL_NOT_FOUND 1157L")]
    public const int ERROR_DLL_NOT_FOUND = 1157;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_MORE_USER_HANDLES"]/*' />
    [NativeTypeName("#define ERROR_NO_MORE_USER_HANDLES 1158L")]
    public const int ERROR_NO_MORE_USER_HANDLES = 1158;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MESSAGE_SYNC_ONLY"]/*' />
    [NativeTypeName("#define ERROR_MESSAGE_SYNC_ONLY 1159L")]
    public const int ERROR_MESSAGE_SYNC_ONLY = 1159;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SOURCE_ELEMENT_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_SOURCE_ELEMENT_EMPTY 1160L")]
    public const int ERROR_SOURCE_ELEMENT_EMPTY = 1160;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DESTINATION_ELEMENT_FULL"]/*' />
    [NativeTypeName("#define ERROR_DESTINATION_ELEMENT_FULL 1161L")]
    public const int ERROR_DESTINATION_ELEMENT_FULL = 1161;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ILLEGAL_ELEMENT_ADDRESS"]/*' />
    [NativeTypeName("#define ERROR_ILLEGAL_ELEMENT_ADDRESS 1162L")]
    public const int ERROR_ILLEGAL_ELEMENT_ADDRESS = 1162;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MAGAZINE_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_MAGAZINE_NOT_PRESENT 1163L")]
    public const int ERROR_MAGAZINE_NOT_PRESENT = 1163;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_REINITIALIZATION_NEEDED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_REINITIALIZATION_NEEDED 1164L")]
    public const int ERROR_DEVICE_REINITIALIZATION_NEEDED = 1164;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_REQUIRES_CLEANING"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_REQUIRES_CLEANING 1165L")]
    public const int ERROR_DEVICE_REQUIRES_CLEANING = 1165;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_DOOR_OPEN"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_DOOR_OPEN 1166L")]
    public const int ERROR_DEVICE_DOOR_OPEN = 1166;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_NOT_CONNECTED 1167L")]
    public const int ERROR_DEVICE_NOT_CONNECTED = 1167;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NOT_FOUND 1168L")]
    public const int ERROR_NOT_FOUND = 1168;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_MATCH"]/*' />
    [NativeTypeName("#define ERROR_NO_MATCH 1169L")]
    public const int ERROR_NO_MATCH = 1169;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SET_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SET_NOT_FOUND 1170L")]
    public const int ERROR_SET_NOT_FOUND = 1170;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_POINT_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_POINT_NOT_FOUND 1171L")]
    public const int ERROR_POINT_NOT_FOUND = 1171;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_TRACKING_SERVICE"]/*' />
    [NativeTypeName("#define ERROR_NO_TRACKING_SERVICE 1172L")]
    public const int ERROR_NO_TRACKING_SERVICE = 1172;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_VOLUME_ID"]/*' />
    [NativeTypeName("#define ERROR_NO_VOLUME_ID 1173L")]
    public const int ERROR_NO_VOLUME_ID = 1173;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_REMOVE_REPLACED"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_REMOVE_REPLACED 1175L")]
    public const int ERROR_UNABLE_TO_REMOVE_REPLACED = 1175;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_MOVE_REPLACEMENT"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_MOVE_REPLACEMENT 1176L")]
    public const int ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_MOVE_REPLACEMENT_2"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 1177L")]
    public const int ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_JOURNAL_DELETE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_JOURNAL_DELETE_IN_PROGRESS 1178L")]
    public const int ERROR_JOURNAL_DELETE_IN_PROGRESS = 1178;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_JOURNAL_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_JOURNAL_NOT_ACTIVE 1179L")]
    public const int ERROR_JOURNAL_NOT_ACTIVE = 1179;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_POTENTIAL_FILE_FOUND"]/*' />
    [NativeTypeName("#define ERROR_POTENTIAL_FILE_FOUND 1180L")]
    public const int ERROR_POTENTIAL_FILE_FOUND = 1180;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_JOURNAL_ENTRY_DELETED"]/*' />
    [NativeTypeName("#define ERROR_JOURNAL_ENTRY_DELETED 1181L")]
    public const int ERROR_JOURNAL_ENTRY_DELETED = 1181;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PARTITION_TERMINATING"]/*' />
    [NativeTypeName("#define ERROR_PARTITION_TERMINATING 1184L")]
    public const int ERROR_PARTITION_TERMINATING = 1184;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHUTDOWN_IS_SCHEDULED"]/*' />
    [NativeTypeName("#define ERROR_SHUTDOWN_IS_SCHEDULED 1190L")]
    public const int ERROR_SHUTDOWN_IS_SCHEDULED = 1190;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHUTDOWN_USERS_LOGGED_ON"]/*' />
    [NativeTypeName("#define ERROR_SHUTDOWN_USERS_LOGGED_ON 1191L")]
    public const int ERROR_SHUTDOWN_USERS_LOGGED_ON = 1191;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHUTDOWN_DISKS_NOT_IN_MAINTENANCE_MODE"]/*' />
    [NativeTypeName("#define ERROR_SHUTDOWN_DISKS_NOT_IN_MAINTENANCE_MODE 1192L")]
    public const int ERROR_SHUTDOWN_DISKS_NOT_IN_MAINTENANCE_MODE = 1192;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_BAD_DEVICE 1200L")]
    public const int ERROR_BAD_DEVICE = 1200;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONNECTION_UNAVAIL"]/*' />
    [NativeTypeName("#define ERROR_CONNECTION_UNAVAIL 1201L")]
    public const int ERROR_CONNECTION_UNAVAIL = 1201;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_ALREADY_REMEMBERED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_ALREADY_REMEMBERED 1202L")]
    public const int ERROR_DEVICE_ALREADY_REMEMBERED = 1202;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_NET_OR_BAD_PATH"]/*' />
    [NativeTypeName("#define ERROR_NO_NET_OR_BAD_PATH 1203L")]
    public const int ERROR_NO_NET_OR_BAD_PATH = 1203;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_PROVIDER"]/*' />
    [NativeTypeName("#define ERROR_BAD_PROVIDER 1204L")]
    public const int ERROR_BAD_PROVIDER = 1204;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_OPEN_PROFILE"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_OPEN_PROFILE 1205L")]
    public const int ERROR_CANNOT_OPEN_PROFILE = 1205;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_PROFILE"]/*' />
    [NativeTypeName("#define ERROR_BAD_PROFILE 1206L")]
    public const int ERROR_BAD_PROFILE = 1206;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_CONTAINER"]/*' />
    [NativeTypeName("#define ERROR_NOT_CONTAINER 1207L")]
    public const int ERROR_NOT_CONTAINER = 1207;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXTENDED_ERROR"]/*' />
    [NativeTypeName("#define ERROR_EXTENDED_ERROR 1208L")]
    public const int ERROR_EXTENDED_ERROR = 1208;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_GROUPNAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_GROUPNAME 1209L")]
    public const int ERROR_INVALID_GROUPNAME = 1209;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_COMPUTERNAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_COMPUTERNAME 1210L")]
    public const int ERROR_INVALID_COMPUTERNAME = 1210;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_EVENTNAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_EVENTNAME 1211L")]
    public const int ERROR_INVALID_EVENTNAME = 1211;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DOMAINNAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DOMAINNAME 1212L")]
    public const int ERROR_INVALID_DOMAINNAME = 1212;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SERVICENAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SERVICENAME 1213L")]
    public const int ERROR_INVALID_SERVICENAME = 1213;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_NETNAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_NETNAME 1214L")]
    public const int ERROR_INVALID_NETNAME = 1214;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SHARENAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SHARENAME 1215L")]
    public const int ERROR_INVALID_SHARENAME = 1215;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PASSWORDNAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PASSWORDNAME 1216L")]
    public const int ERROR_INVALID_PASSWORDNAME = 1216;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MESSAGENAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MESSAGENAME 1217L")]
    public const int ERROR_INVALID_MESSAGENAME = 1217;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MESSAGEDEST"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MESSAGEDEST 1218L")]
    public const int ERROR_INVALID_MESSAGEDEST = 1218;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SESSION_CREDENTIAL_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_SESSION_CREDENTIAL_CONFLICT 1219L")]
    public const int ERROR_SESSION_CREDENTIAL_CONFLICT = 1219;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOTE_SESSION_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_REMOTE_SESSION_LIMIT_EXCEEDED 1220L")]
    public const int ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DUP_DOMAINNAME"]/*' />
    [NativeTypeName("#define ERROR_DUP_DOMAINNAME 1221L")]
    public const int ERROR_DUP_DOMAINNAME = 1221;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_NETWORK"]/*' />
    [NativeTypeName("#define ERROR_NO_NETWORK 1222L")]
    public const int ERROR_NO_NETWORK = 1222;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANCELLED"]/*' />
    [NativeTypeName("#define ERROR_CANCELLED 1223L")]
    public const int ERROR_CANCELLED = 1223;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_USER_MAPPED_FILE"]/*' />
    [NativeTypeName("#define ERROR_USER_MAPPED_FILE 1224L")]
    public const int ERROR_USER_MAPPED_FILE = 1224;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONNECTION_REFUSED"]/*' />
    [NativeTypeName("#define ERROR_CONNECTION_REFUSED 1225L")]
    public const int ERROR_CONNECTION_REFUSED = 1225;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRACEFUL_DISCONNECT"]/*' />
    [NativeTypeName("#define ERROR_GRACEFUL_DISCONNECT 1226L")]
    public const int ERROR_GRACEFUL_DISCONNECT = 1226;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ADDRESS_ALREADY_ASSOCIATED"]/*' />
    [NativeTypeName("#define ERROR_ADDRESS_ALREADY_ASSOCIATED 1227L")]
    public const int ERROR_ADDRESS_ALREADY_ASSOCIATED = 1227;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ADDRESS_NOT_ASSOCIATED"]/*' />
    [NativeTypeName("#define ERROR_ADDRESS_NOT_ASSOCIATED 1228L")]
    public const int ERROR_ADDRESS_NOT_ASSOCIATED = 1228;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONNECTION_INVALID"]/*' />
    [NativeTypeName("#define ERROR_CONNECTION_INVALID 1229L")]
    public const int ERROR_CONNECTION_INVALID = 1229;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONNECTION_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_CONNECTION_ACTIVE 1230L")]
    public const int ERROR_CONNECTION_ACTIVE = 1230;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NETWORK_UNREACHABLE"]/*' />
    [NativeTypeName("#define ERROR_NETWORK_UNREACHABLE 1231L")]
    public const int ERROR_NETWORK_UNREACHABLE = 1231;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOST_UNREACHABLE"]/*' />
    [NativeTypeName("#define ERROR_HOST_UNREACHABLE 1232L")]
    public const int ERROR_HOST_UNREACHABLE = 1232;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROTOCOL_UNREACHABLE"]/*' />
    [NativeTypeName("#define ERROR_PROTOCOL_UNREACHABLE 1233L")]
    public const int ERROR_PROTOCOL_UNREACHABLE = 1233;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PORT_UNREACHABLE"]/*' />
    [NativeTypeName("#define ERROR_PORT_UNREACHABLE 1234L")]
    public const int ERROR_PORT_UNREACHABLE = 1234;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REQUEST_ABORTED"]/*' />
    [NativeTypeName("#define ERROR_REQUEST_ABORTED 1235L")]
    public const int ERROR_REQUEST_ABORTED = 1235;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONNECTION_ABORTED"]/*' />
    [NativeTypeName("#define ERROR_CONNECTION_ABORTED 1236L")]
    public const int ERROR_CONNECTION_ABORTED = 1236;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RETRY"]/*' />
    [NativeTypeName("#define ERROR_RETRY 1237L")]
    public const int ERROR_RETRY = 1237;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONNECTION_COUNT_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_CONNECTION_COUNT_LIMIT 1238L")]
    public const int ERROR_CONNECTION_COUNT_LIMIT = 1238;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOGIN_TIME_RESTRICTION"]/*' />
    [NativeTypeName("#define ERROR_LOGIN_TIME_RESTRICTION 1239L")]
    public const int ERROR_LOGIN_TIME_RESTRICTION = 1239;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOGIN_WKSTA_RESTRICTION"]/*' />
    [NativeTypeName("#define ERROR_LOGIN_WKSTA_RESTRICTION 1240L")]
    public const int ERROR_LOGIN_WKSTA_RESTRICTION = 1240;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INCORRECT_ADDRESS"]/*' />
    [NativeTypeName("#define ERROR_INCORRECT_ADDRESS 1241L")]
    public const int ERROR_INCORRECT_ADDRESS = 1241;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_REGISTERED 1242L")]
    public const int ERROR_ALREADY_REGISTERED = 1242;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_NOT_FOUND 1243L")]
    public const int ERROR_SERVICE_NOT_FOUND = 1243;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_AUTHENTICATED"]/*' />
    [NativeTypeName("#define ERROR_NOT_AUTHENTICATED 1244L")]
    public const int ERROR_NOT_AUTHENTICATED = 1244;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_LOGGED_ON"]/*' />
    [NativeTypeName("#define ERROR_NOT_LOGGED_ON 1245L")]
    public const int ERROR_NOT_LOGGED_ON = 1245;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONTINUE"]/*' />
    [NativeTypeName("#define ERROR_CONTINUE 1246L")]
    public const int ERROR_CONTINUE = 1246;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_INITIALIZED"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_INITIALIZED 1247L")]
    public const int ERROR_ALREADY_INITIALIZED = 1247;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_MORE_DEVICES"]/*' />
    [NativeTypeName("#define ERROR_NO_MORE_DEVICES 1248L")]
    public const int ERROR_NO_MORE_DEVICES = 1248;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_SITE"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_SITE 1249L")]
    public const int ERROR_NO_SUCH_SITE = 1249;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DOMAIN_CONTROLLER_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DOMAIN_CONTROLLER_EXISTS 1250L")]
    public const int ERROR_DOMAIN_CONTROLLER_EXISTS = 1250;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ONLY_IF_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_ONLY_IF_CONNECTED 1251L")]
    public const int ERROR_ONLY_IF_CONNECTED = 1251;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OVERRIDE_NOCHANGES"]/*' />
    [NativeTypeName("#define ERROR_OVERRIDE_NOCHANGES 1252L")]
    public const int ERROR_OVERRIDE_NOCHANGES = 1252;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_USER_PROFILE"]/*' />
    [NativeTypeName("#define ERROR_BAD_USER_PROFILE 1253L")]
    public const int ERROR_BAD_USER_PROFILE = 1253;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_ON_SBS"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_ON_SBS 1254L")]
    public const int ERROR_NOT_SUPPORTED_ON_SBS = 1254;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVER_SHUTDOWN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_SERVER_SHUTDOWN_IN_PROGRESS 1255L")]
    public const int ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 1255;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOST_DOWN"]/*' />
    [NativeTypeName("#define ERROR_HOST_DOWN 1256L")]
    public const int ERROR_HOST_DOWN = 1256;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NON_ACCOUNT_SID"]/*' />
    [NativeTypeName("#define ERROR_NON_ACCOUNT_SID 1257L")]
    public const int ERROR_NON_ACCOUNT_SID = 1257;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NON_DOMAIN_SID"]/*' />
    [NativeTypeName("#define ERROR_NON_DOMAIN_SID 1258L")]
    public const int ERROR_NON_DOMAIN_SID = 1258;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPHELP_BLOCK"]/*' />
    [NativeTypeName("#define ERROR_APPHELP_BLOCK 1259L")]
    public const int ERROR_APPHELP_BLOCK = 1259;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCESS_DISABLED_BY_POLICY"]/*' />
    [NativeTypeName("#define ERROR_ACCESS_DISABLED_BY_POLICY 1260L")]
    public const int ERROR_ACCESS_DISABLED_BY_POLICY = 1260;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REG_NAT_CONSUMPTION"]/*' />
    [NativeTypeName("#define ERROR_REG_NAT_CONSUMPTION 1261L")]
    public const int ERROR_REG_NAT_CONSUMPTION = 1261;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CSCSHARE_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_CSCSHARE_OFFLINE 1262L")]
    public const int ERROR_CSCSHARE_OFFLINE = 1262;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PKINIT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_PKINIT_FAILURE 1263L")]
    public const int ERROR_PKINIT_FAILURE = 1263;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMARTCARD_SUBSYSTEM_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_SMARTCARD_SUBSYSTEM_FAILURE 1264L")]
    public const int ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 1264;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DOWNGRADE_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_DOWNGRADE_DETECTED 1265L")]
    public const int ERROR_DOWNGRADE_DETECTED = 1265;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MACHINE_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_MACHINE_LOCKED 1271L")]
    public const int ERROR_MACHINE_LOCKED = 1271;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_GUEST_LOGON_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_SMB_GUEST_LOGON_BLOCKED 1272L")]
    public const int ERROR_SMB_GUEST_LOGON_BLOCKED = 1272;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CALLBACK_SUPPLIED_INVALID_DATA"]/*' />
    [NativeTypeName("#define ERROR_CALLBACK_SUPPLIED_INVALID_DATA 1273L")]
    public const int ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 1273;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED 1274L")]
    public const int ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 1274;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_BLOCKED 1275L")]
    public const int ERROR_DRIVER_BLOCKED = 1275;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_IMPORT_OF_NON_DLL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_IMPORT_OF_NON_DLL 1276L")]
    public const int ERROR_INVALID_IMPORT_OF_NON_DLL = 1276;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCESS_DISABLED_WEBBLADE"]/*' />
    [NativeTypeName("#define ERROR_ACCESS_DISABLED_WEBBLADE 1277L")]
    public const int ERROR_ACCESS_DISABLED_WEBBLADE = 1277;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER"]/*' />
    [NativeTypeName("#define ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER 1278L")]
    public const int ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 1278;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RECOVERY_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_RECOVERY_FAILURE 1279L")]
    public const int ERROR_RECOVERY_FAILURE = 1279;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_FIBER"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_FIBER 1280L")]
    public const int ERROR_ALREADY_FIBER = 1280;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_THREAD"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_THREAD 1281L")]
    public const int ERROR_ALREADY_THREAD = 1281;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STACK_BUFFER_OVERRUN"]/*' />
    [NativeTypeName("#define ERROR_STACK_BUFFER_OVERRUN 1282L")]
    public const int ERROR_STACK_BUFFER_OVERRUN = 1282;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PARAMETER_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_PARAMETER_QUOTA_EXCEEDED 1283L")]
    public const int ERROR_PARAMETER_QUOTA_EXCEEDED = 1283;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEBUGGER_INACTIVE"]/*' />
    [NativeTypeName("#define ERROR_DEBUGGER_INACTIVE 1284L")]
    public const int ERROR_DEBUGGER_INACTIVE = 1284;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DELAY_LOAD_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DELAY_LOAD_FAILED 1285L")]
    public const int ERROR_DELAY_LOAD_FAILED = 1285;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VDM_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_VDM_DISALLOWED 1286L")]
    public const int ERROR_VDM_DISALLOWED = 1286;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNIDENTIFIED_ERROR"]/*' />
    [NativeTypeName("#define ERROR_UNIDENTIFIED_ERROR 1287L")]
    public const int ERROR_UNIDENTIFIED_ERROR = 1287;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CRUNTIME_PARAMETER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CRUNTIME_PARAMETER 1288L")]
    public const int ERROR_INVALID_CRUNTIME_PARAMETER = 1288;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BEYOND_VDL"]/*' />
    [NativeTypeName("#define ERROR_BEYOND_VDL 1289L")]
    public const int ERROR_BEYOND_VDL = 1289;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INCOMPATIBLE_SERVICE_SID_TYPE"]/*' />
    [NativeTypeName("#define ERROR_INCOMPATIBLE_SERVICE_SID_TYPE 1290L")]
    public const int ERROR_INCOMPATIBLE_SERVICE_SID_TYPE = 1290;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVER_PROCESS_TERMINATED"]/*' />
    [NativeTypeName("#define ERROR_DRIVER_PROCESS_TERMINATED 1291L")]
    public const int ERROR_DRIVER_PROCESS_TERMINATED = 1291;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IMPLEMENTATION_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_IMPLEMENTATION_LIMIT 1292L")]
    public const int ERROR_IMPLEMENTATION_LIMIT = 1292;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROCESS_IS_PROTECTED"]/*' />
    [NativeTypeName("#define ERROR_PROCESS_IS_PROTECTED 1293L")]
    public const int ERROR_PROCESS_IS_PROTECTED = 1293;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_NOTIFY_CLIENT_LAGGING"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_NOTIFY_CLIENT_LAGGING 1294L")]
    public const int ERROR_SERVICE_NOTIFY_CLIENT_LAGGING = 1294;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DISK_QUOTA_EXCEEDED 1295L")]
    public const int ERROR_DISK_QUOTA_EXCEEDED = 1295;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONTENT_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_CONTENT_BLOCKED 1296L")]
    public const int ERROR_CONTENT_BLOCKED = 1296;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE"]/*' />
    [NativeTypeName("#define ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE 1297L")]
    public const int ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE = 1297;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APP_HANG"]/*' />
    [NativeTypeName("#define ERROR_APP_HANG 1298L")]
    public const int ERROR_APP_HANG = 1298;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LABEL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LABEL 1299L")]
    public const int ERROR_INVALID_LABEL = 1299;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_ALL_ASSIGNED"]/*' />
    [NativeTypeName("#define ERROR_NOT_ALL_ASSIGNED 1300L")]
    public const int ERROR_NOT_ALL_ASSIGNED = 1300;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SOME_NOT_MAPPED"]/*' />
    [NativeTypeName("#define ERROR_SOME_NOT_MAPPED 1301L")]
    public const int ERROR_SOME_NOT_MAPPED = 1301;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_QUOTAS_FOR_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_NO_QUOTAS_FOR_ACCOUNT 1302L")]
    public const int ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOCAL_USER_SESSION_KEY"]/*' />
    [NativeTypeName("#define ERROR_LOCAL_USER_SESSION_KEY 1303L")]
    public const int ERROR_LOCAL_USER_SESSION_KEY = 1303;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NULL_LM_PASSWORD"]/*' />
    [NativeTypeName("#define ERROR_NULL_LM_PASSWORD 1304L")]
    public const int ERROR_NULL_LM_PASSWORD = 1304;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_REVISION"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_REVISION 1305L")]
    public const int ERROR_UNKNOWN_REVISION = 1305;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REVISION_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_REVISION_MISMATCH 1306L")]
    public const int ERROR_REVISION_MISMATCH = 1306;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_OWNER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_OWNER 1307L")]
    public const int ERROR_INVALID_OWNER = 1307;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PRIMARY_GROUP"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PRIMARY_GROUP 1308L")]
    public const int ERROR_INVALID_PRIMARY_GROUP = 1308;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_IMPERSONATION_TOKEN"]/*' />
    [NativeTypeName("#define ERROR_NO_IMPERSONATION_TOKEN 1309L")]
    public const int ERROR_NO_IMPERSONATION_TOKEN = 1309;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_DISABLE_MANDATORY"]/*' />
    [NativeTypeName("#define ERROR_CANT_DISABLE_MANDATORY 1310L")]
    public const int ERROR_CANT_DISABLE_MANDATORY = 1310;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_LOGON_SERVERS"]/*' />
    [NativeTypeName("#define ERROR_NO_LOGON_SERVERS 1311L")]
    public const int ERROR_NO_LOGON_SERVERS = 1311;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_LOGON_SESSION"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_LOGON_SESSION 1312L")]
    public const int ERROR_NO_SUCH_LOGON_SESSION = 1312;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_PRIVILEGE"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_PRIVILEGE 1313L")]
    public const int ERROR_NO_SUCH_PRIVILEGE = 1313;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRIVILEGE_NOT_HELD"]/*' />
    [NativeTypeName("#define ERROR_PRIVILEGE_NOT_HELD 1314L")]
    public const int ERROR_PRIVILEGE_NOT_HELD = 1314;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ACCOUNT_NAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ACCOUNT_NAME 1315L")]
    public const int ERROR_INVALID_ACCOUNT_NAME = 1315;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_USER_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_USER_EXISTS 1316L")]
    public const int ERROR_USER_EXISTS = 1316;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_USER"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_USER 1317L")]
    public const int ERROR_NO_SUCH_USER = 1317;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GROUP_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_GROUP_EXISTS 1318L")]
    public const int ERROR_GROUP_EXISTS = 1318;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_GROUP"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_GROUP 1319L")]
    public const int ERROR_NO_SUCH_GROUP = 1319;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEMBER_IN_GROUP"]/*' />
    [NativeTypeName("#define ERROR_MEMBER_IN_GROUP 1320L")]
    public const int ERROR_MEMBER_IN_GROUP = 1320;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEMBER_NOT_IN_GROUP"]/*' />
    [NativeTypeName("#define ERROR_MEMBER_NOT_IN_GROUP 1321L")]
    public const int ERROR_MEMBER_NOT_IN_GROUP = 1321;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LAST_ADMIN"]/*' />
    [NativeTypeName("#define ERROR_LAST_ADMIN 1322L")]
    public const int ERROR_LAST_ADMIN = 1322;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRONG_PASSWORD"]/*' />
    [NativeTypeName("#define ERROR_WRONG_PASSWORD 1323L")]
    public const int ERROR_WRONG_PASSWORD = 1323;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ILL_FORMED_PASSWORD"]/*' />
    [NativeTypeName("#define ERROR_ILL_FORMED_PASSWORD 1324L")]
    public const int ERROR_ILL_FORMED_PASSWORD = 1324;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PASSWORD_RESTRICTION"]/*' />
    [NativeTypeName("#define ERROR_PASSWORD_RESTRICTION 1325L")]
    public const int ERROR_PASSWORD_RESTRICTION = 1325;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOGON_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_LOGON_FAILURE 1326L")]
    public const int ERROR_LOGON_FAILURE = 1326;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCOUNT_RESTRICTION"]/*' />
    [NativeTypeName("#define ERROR_ACCOUNT_RESTRICTION 1327L")]
    public const int ERROR_ACCOUNT_RESTRICTION = 1327;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LOGON_HOURS"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LOGON_HOURS 1328L")]
    public const int ERROR_INVALID_LOGON_HOURS = 1328;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_WORKSTATION"]/*' />
    [NativeTypeName("#define ERROR_INVALID_WORKSTATION 1329L")]
    public const int ERROR_INVALID_WORKSTATION = 1329;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PASSWORD_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_PASSWORD_EXPIRED 1330L")]
    public const int ERROR_PASSWORD_EXPIRED = 1330;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCOUNT_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_ACCOUNT_DISABLED 1331L")]
    public const int ERROR_ACCOUNT_DISABLED = 1331;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NONE_MAPPED"]/*' />
    [NativeTypeName("#define ERROR_NONE_MAPPED 1332L")]
    public const int ERROR_NONE_MAPPED = 1332;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_LUIDS_REQUESTED"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_LUIDS_REQUESTED 1333L")]
    public const int ERROR_TOO_MANY_LUIDS_REQUESTED = 1333;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LUIDS_EXHAUSTED"]/*' />
    [NativeTypeName("#define ERROR_LUIDS_EXHAUSTED 1334L")]
    public const int ERROR_LUIDS_EXHAUSTED = 1334;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SUB_AUTHORITY"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SUB_AUTHORITY 1335L")]
    public const int ERROR_INVALID_SUB_AUTHORITY = 1335;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ACL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ACL 1336L")]
    public const int ERROR_INVALID_ACL = 1336;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SID"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SID 1337L")]
    public const int ERROR_INVALID_SID = 1337;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SECURITY_DESCR"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SECURITY_DESCR 1338L")]
    public const int ERROR_INVALID_SECURITY_DESCR = 1338;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_INHERITANCE_ACL"]/*' />
    [NativeTypeName("#define ERROR_BAD_INHERITANCE_ACL 1340L")]
    public const int ERROR_BAD_INHERITANCE_ACL = 1340;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVER_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_SERVER_DISABLED 1341L")]
    public const int ERROR_SERVER_DISABLED = 1341;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVER_NOT_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_SERVER_NOT_DISABLED 1342L")]
    public const int ERROR_SERVER_NOT_DISABLED = 1342;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ID_AUTHORITY"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ID_AUTHORITY 1343L")]
    public const int ERROR_INVALID_ID_AUTHORITY = 1343;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALLOTTED_SPACE_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_ALLOTTED_SPACE_EXCEEDED 1344L")]
    public const int ERROR_ALLOTTED_SPACE_EXCEEDED = 1344;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_GROUP_ATTRIBUTES"]/*' />
    [NativeTypeName("#define ERROR_INVALID_GROUP_ATTRIBUTES 1345L")]
    public const int ERROR_INVALID_GROUP_ATTRIBUTES = 1345;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_IMPERSONATION_LEVEL"]/*' />
    [NativeTypeName("#define ERROR_BAD_IMPERSONATION_LEVEL 1346L")]
    public const int ERROR_BAD_IMPERSONATION_LEVEL = 1346;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_OPEN_ANONYMOUS"]/*' />
    [NativeTypeName("#define ERROR_CANT_OPEN_ANONYMOUS 1347L")]
    public const int ERROR_CANT_OPEN_ANONYMOUS = 1347;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_VALIDATION_CLASS"]/*' />
    [NativeTypeName("#define ERROR_BAD_VALIDATION_CLASS 1348L")]
    public const int ERROR_BAD_VALIDATION_CLASS = 1348;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_TOKEN_TYPE"]/*' />
    [NativeTypeName("#define ERROR_BAD_TOKEN_TYPE 1349L")]
    public const int ERROR_BAD_TOKEN_TYPE = 1349;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SECURITY_ON_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_NO_SECURITY_ON_OBJECT 1350L")]
    public const int ERROR_NO_SECURITY_ON_OBJECT = 1350;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_ACCESS_DOMAIN_INFO"]/*' />
    [NativeTypeName("#define ERROR_CANT_ACCESS_DOMAIN_INFO 1351L")]
    public const int ERROR_CANT_ACCESS_DOMAIN_INFO = 1351;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SERVER_STATE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SERVER_STATE 1352L")]
    public const int ERROR_INVALID_SERVER_STATE = 1352;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DOMAIN_STATE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DOMAIN_STATE 1353L")]
    public const int ERROR_INVALID_DOMAIN_STATE = 1353;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DOMAIN_ROLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DOMAIN_ROLE 1354L")]
    public const int ERROR_INVALID_DOMAIN_ROLE = 1354;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_DOMAIN"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_DOMAIN 1355L")]
    public const int ERROR_NO_SUCH_DOMAIN = 1355;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DOMAIN_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DOMAIN_EXISTS 1356L")]
    public const int ERROR_DOMAIN_EXISTS = 1356;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DOMAIN_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DOMAIN_LIMIT_EXCEEDED 1357L")]
    public const int ERROR_DOMAIN_LIMIT_EXCEEDED = 1357;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INTERNAL_DB_CORRUPTION"]/*' />
    [NativeTypeName("#define ERROR_INTERNAL_DB_CORRUPTION 1358L")]
    public const int ERROR_INTERNAL_DB_CORRUPTION = 1358;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_INTERNAL_ERROR 1359L")]
    public const int ERROR_INTERNAL_ERROR = 1359;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GENERIC_NOT_MAPPED"]/*' />
    [NativeTypeName("#define ERROR_GENERIC_NOT_MAPPED 1360L")]
    public const int ERROR_GENERIC_NOT_MAPPED = 1360;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_DESCRIPTOR_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_BAD_DESCRIPTOR_FORMAT 1361L")]
    public const int ERROR_BAD_DESCRIPTOR_FORMAT = 1361;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_LOGON_PROCESS"]/*' />
    [NativeTypeName("#define ERROR_NOT_LOGON_PROCESS 1362L")]
    public const int ERROR_NOT_LOGON_PROCESS = 1362;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOGON_SESSION_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_LOGON_SESSION_EXISTS 1363L")]
    public const int ERROR_LOGON_SESSION_EXISTS = 1363;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_PACKAGE"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_PACKAGE 1364L")]
    public const int ERROR_NO_SUCH_PACKAGE = 1364;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_LOGON_SESSION_STATE"]/*' />
    [NativeTypeName("#define ERROR_BAD_LOGON_SESSION_STATE 1365L")]
    public const int ERROR_BAD_LOGON_SESSION_STATE = 1365;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOGON_SESSION_COLLISION"]/*' />
    [NativeTypeName("#define ERROR_LOGON_SESSION_COLLISION 1366L")]
    public const int ERROR_LOGON_SESSION_COLLISION = 1366;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LOGON_TYPE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LOGON_TYPE 1367L")]
    public const int ERROR_INVALID_LOGON_TYPE = 1367;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_IMPERSONATE"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_IMPERSONATE 1368L")]
    public const int ERROR_CANNOT_IMPERSONATE = 1368;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RXACT_INVALID_STATE"]/*' />
    [NativeTypeName("#define ERROR_RXACT_INVALID_STATE 1369L")]
    public const int ERROR_RXACT_INVALID_STATE = 1369;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RXACT_COMMIT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_RXACT_COMMIT_FAILURE 1370L")]
    public const int ERROR_RXACT_COMMIT_FAILURE = 1370;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPECIAL_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_SPECIAL_ACCOUNT 1371L")]
    public const int ERROR_SPECIAL_ACCOUNT = 1371;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPECIAL_GROUP"]/*' />
    [NativeTypeName("#define ERROR_SPECIAL_GROUP 1372L")]
    public const int ERROR_SPECIAL_GROUP = 1372;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPECIAL_USER"]/*' />
    [NativeTypeName("#define ERROR_SPECIAL_USER 1373L")]
    public const int ERROR_SPECIAL_USER = 1373;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEMBERS_PRIMARY_GROUP"]/*' />
    [NativeTypeName("#define ERROR_MEMBERS_PRIMARY_GROUP 1374L")]
    public const int ERROR_MEMBERS_PRIMARY_GROUP = 1374;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOKEN_ALREADY_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_TOKEN_ALREADY_IN_USE 1375L")]
    public const int ERROR_TOKEN_ALREADY_IN_USE = 1375;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_ALIAS"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_ALIAS 1376L")]
    public const int ERROR_NO_SUCH_ALIAS = 1376;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEMBER_NOT_IN_ALIAS"]/*' />
    [NativeTypeName("#define ERROR_MEMBER_NOT_IN_ALIAS 1377L")]
    public const int ERROR_MEMBER_NOT_IN_ALIAS = 1377;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEMBER_IN_ALIAS"]/*' />
    [NativeTypeName("#define ERROR_MEMBER_IN_ALIAS 1378L")]
    public const int ERROR_MEMBER_IN_ALIAS = 1378;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALIAS_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_ALIAS_EXISTS 1379L")]
    public const int ERROR_ALIAS_EXISTS = 1379;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOGON_NOT_GRANTED"]/*' />
    [NativeTypeName("#define ERROR_LOGON_NOT_GRANTED 1380L")]
    public const int ERROR_LOGON_NOT_GRANTED = 1380;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_SECRETS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_SECRETS 1381L")]
    public const int ERROR_TOO_MANY_SECRETS = 1381;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECRET_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_SECRET_TOO_LONG 1382L")]
    public const int ERROR_SECRET_TOO_LONG = 1382;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INTERNAL_DB_ERROR"]/*' />
    [NativeTypeName("#define ERROR_INTERNAL_DB_ERROR 1383L")]
    public const int ERROR_INTERNAL_DB_ERROR = 1383;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_CONTEXT_IDS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_CONTEXT_IDS 1384L")]
    public const int ERROR_TOO_MANY_CONTEXT_IDS = 1384;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOGON_TYPE_NOT_GRANTED"]/*' />
    [NativeTypeName("#define ERROR_LOGON_TYPE_NOT_GRANTED 1385L")]
    public const int ERROR_LOGON_TYPE_NOT_GRANTED = 1385;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NT_CROSS_ENCRYPTION_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_NT_CROSS_ENCRYPTION_REQUIRED 1386L")]
    public const int ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUCH_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_NO_SUCH_MEMBER 1387L")]
    public const int ERROR_NO_SUCH_MEMBER = 1387;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MEMBER 1388L")]
    public const int ERROR_INVALID_MEMBER = 1388;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TOO_MANY_SIDS"]/*' />
    [NativeTypeName("#define ERROR_TOO_MANY_SIDS 1389L")]
    public const int ERROR_TOO_MANY_SIDS = 1389;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LM_CROSS_ENCRYPTION_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_LM_CROSS_ENCRYPTION_REQUIRED 1390L")]
    public const int ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_INHERITANCE"]/*' />
    [NativeTypeName("#define ERROR_NO_INHERITANCE 1391L")]
    public const int ERROR_NO_INHERITANCE = 1391;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_FILE_CORRUPT 1392L")]
    public const int ERROR_FILE_CORRUPT = 1392;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_DISK_CORRUPT 1393L")]
    public const int ERROR_DISK_CORRUPT = 1393;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_USER_SESSION_KEY"]/*' />
    [NativeTypeName("#define ERROR_NO_USER_SESSION_KEY 1394L")]
    public const int ERROR_NO_USER_SESSION_KEY = 1394;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LICENSE_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_LICENSE_QUOTA_EXCEEDED 1395L")]
    public const int ERROR_LICENSE_QUOTA_EXCEEDED = 1395;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRONG_TARGET_NAME"]/*' />
    [NativeTypeName("#define ERROR_WRONG_TARGET_NAME 1396L")]
    public const int ERROR_WRONG_TARGET_NAME = 1396;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUTUAL_AUTH_FAILED"]/*' />
    [NativeTypeName("#define ERROR_MUTUAL_AUTH_FAILED 1397L")]
    public const int ERROR_MUTUAL_AUTH_FAILED = 1397;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIME_SKEW"]/*' />
    [NativeTypeName("#define ERROR_TIME_SKEW 1398L")]
    public const int ERROR_TIME_SKEW = 1398;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CURRENT_DOMAIN_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_CURRENT_DOMAIN_NOT_ALLOWED 1399L")]
    public const int ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 1399;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_WINDOW_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_WINDOW_HANDLE 1400L")]
    public const int ERROR_INVALID_WINDOW_HANDLE = 1400;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MENU_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MENU_HANDLE 1401L")]
    public const int ERROR_INVALID_MENU_HANDLE = 1401;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CURSOR_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CURSOR_HANDLE 1402L")]
    public const int ERROR_INVALID_CURSOR_HANDLE = 1402;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ACCEL_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ACCEL_HANDLE 1403L")]
    public const int ERROR_INVALID_ACCEL_HANDLE = 1403;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_HOOK_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_HOOK_HANDLE 1404L")]
    public const int ERROR_INVALID_HOOK_HANDLE = 1404;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DWP_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DWP_HANDLE 1405L")]
    public const int ERROR_INVALID_DWP_HANDLE = 1405;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TLW_WITH_WSCHILD"]/*' />
    [NativeTypeName("#define ERROR_TLW_WITH_WSCHILD 1406L")]
    public const int ERROR_TLW_WITH_WSCHILD = 1406;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_FIND_WND_CLASS"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_FIND_WND_CLASS 1407L")]
    public const int ERROR_CANNOT_FIND_WND_CLASS = 1407;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WINDOW_OF_OTHER_THREAD"]/*' />
    [NativeTypeName("#define ERROR_WINDOW_OF_OTHER_THREAD 1408L")]
    public const int ERROR_WINDOW_OF_OTHER_THREAD = 1408;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOTKEY_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_HOTKEY_ALREADY_REGISTERED 1409L")]
    public const int ERROR_HOTKEY_ALREADY_REGISTERED = 1409;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLASS_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_CLASS_ALREADY_EXISTS 1410L")]
    public const int ERROR_CLASS_ALREADY_EXISTS = 1410;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLASS_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define ERROR_CLASS_DOES_NOT_EXIST 1411L")]
    public const int ERROR_CLASS_DOES_NOT_EXIST = 1411;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLASS_HAS_WINDOWS"]/*' />
    [NativeTypeName("#define ERROR_CLASS_HAS_WINDOWS 1412L")]
    public const int ERROR_CLASS_HAS_WINDOWS = 1412;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_INDEX"]/*' />
    [NativeTypeName("#define ERROR_INVALID_INDEX 1413L")]
    public const int ERROR_INVALID_INDEX = 1413;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ICON_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ICON_HANDLE 1414L")]
    public const int ERROR_INVALID_ICON_HANDLE = 1414;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRIVATE_DIALOG_INDEX"]/*' />
    [NativeTypeName("#define ERROR_PRIVATE_DIALOG_INDEX 1415L")]
    public const int ERROR_PRIVATE_DIALOG_INDEX = 1415;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LISTBOX_ID_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_LISTBOX_ID_NOT_FOUND 1416L")]
    public const int ERROR_LISTBOX_ID_NOT_FOUND = 1416;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_WILDCARD_CHARACTERS"]/*' />
    [NativeTypeName("#define ERROR_NO_WILDCARD_CHARACTERS 1417L")]
    public const int ERROR_NO_WILDCARD_CHARACTERS = 1417;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIPBOARD_NOT_OPEN"]/*' />
    [NativeTypeName("#define ERROR_CLIPBOARD_NOT_OPEN 1418L")]
    public const int ERROR_CLIPBOARD_NOT_OPEN = 1418;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOTKEY_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_HOTKEY_NOT_REGISTERED 1419L")]
    public const int ERROR_HOTKEY_NOT_REGISTERED = 1419;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WINDOW_NOT_DIALOG"]/*' />
    [NativeTypeName("#define ERROR_WINDOW_NOT_DIALOG 1420L")]
    public const int ERROR_WINDOW_NOT_DIALOG = 1420;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONTROL_ID_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CONTROL_ID_NOT_FOUND 1421L")]
    public const int ERROR_CONTROL_ID_NOT_FOUND = 1421;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_COMBOBOX_MESSAGE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_COMBOBOX_MESSAGE 1422L")]
    public const int ERROR_INVALID_COMBOBOX_MESSAGE = 1422;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WINDOW_NOT_COMBOBOX"]/*' />
    [NativeTypeName("#define ERROR_WINDOW_NOT_COMBOBOX 1423L")]
    public const int ERROR_WINDOW_NOT_COMBOBOX = 1423;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_EDIT_HEIGHT"]/*' />
    [NativeTypeName("#define ERROR_INVALID_EDIT_HEIGHT 1424L")]
    public const int ERROR_INVALID_EDIT_HEIGHT = 1424;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DC_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DC_NOT_FOUND 1425L")]
    public const int ERROR_DC_NOT_FOUND = 1425;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_HOOK_FILTER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_HOOK_FILTER 1426L")]
    public const int ERROR_INVALID_HOOK_FILTER = 1426;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FILTER_PROC"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FILTER_PROC 1427L")]
    public const int ERROR_INVALID_FILTER_PROC = 1427;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOOK_NEEDS_HMOD"]/*' />
    [NativeTypeName("#define ERROR_HOOK_NEEDS_HMOD 1428L")]
    public const int ERROR_HOOK_NEEDS_HMOD = 1428;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GLOBAL_ONLY_HOOK"]/*' />
    [NativeTypeName("#define ERROR_GLOBAL_ONLY_HOOK 1429L")]
    public const int ERROR_GLOBAL_ONLY_HOOK = 1429;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_JOURNAL_HOOK_SET"]/*' />
    [NativeTypeName("#define ERROR_JOURNAL_HOOK_SET 1430L")]
    public const int ERROR_JOURNAL_HOOK_SET = 1430;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOOK_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_HOOK_NOT_INSTALLED 1431L")]
    public const int ERROR_HOOK_NOT_INSTALLED = 1431;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LB_MESSAGE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LB_MESSAGE 1432L")]
    public const int ERROR_INVALID_LB_MESSAGE = 1432;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SETCOUNT_ON_BAD_LB"]/*' />
    [NativeTypeName("#define ERROR_SETCOUNT_ON_BAD_LB 1433L")]
    public const int ERROR_SETCOUNT_ON_BAD_LB = 1433;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LB_WITHOUT_TABSTOPS"]/*' />
    [NativeTypeName("#define ERROR_LB_WITHOUT_TABSTOPS 1434L")]
    public const int ERROR_LB_WITHOUT_TABSTOPS = 1434;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DESTROY_OBJECT_OF_OTHER_THREAD"]/*' />
    [NativeTypeName("#define ERROR_DESTROY_OBJECT_OF_OTHER_THREAD 1435L")]
    public const int ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CHILD_WINDOW_MENU"]/*' />
    [NativeTypeName("#define ERROR_CHILD_WINDOW_MENU 1436L")]
    public const int ERROR_CHILD_WINDOW_MENU = 1436;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SYSTEM_MENU"]/*' />
    [NativeTypeName("#define ERROR_NO_SYSTEM_MENU 1437L")]
    public const int ERROR_NO_SYSTEM_MENU = 1437;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MSGBOX_STYLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MSGBOX_STYLE 1438L")]
    public const int ERROR_INVALID_MSGBOX_STYLE = 1438;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SPI_VALUE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SPI_VALUE 1439L")]
    public const int ERROR_INVALID_SPI_VALUE = 1439;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SCREEN_ALREADY_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_SCREEN_ALREADY_LOCKED 1440L")]
    public const int ERROR_SCREEN_ALREADY_LOCKED = 1440;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HWNDS_HAVE_DIFF_PARENT"]/*' />
    [NativeTypeName("#define ERROR_HWNDS_HAVE_DIFF_PARENT 1441L")]
    public const int ERROR_HWNDS_HAVE_DIFF_PARENT = 1441;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_CHILD_WINDOW"]/*' />
    [NativeTypeName("#define ERROR_NOT_CHILD_WINDOW 1442L")]
    public const int ERROR_NOT_CHILD_WINDOW = 1442;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_GW_COMMAND"]/*' />
    [NativeTypeName("#define ERROR_INVALID_GW_COMMAND 1443L")]
    public const int ERROR_INVALID_GW_COMMAND = 1443;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_THREAD_ID"]/*' />
    [NativeTypeName("#define ERROR_INVALID_THREAD_ID 1444L")]
    public const int ERROR_INVALID_THREAD_ID = 1444;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NON_MDICHILD_WINDOW"]/*' />
    [NativeTypeName("#define ERROR_NON_MDICHILD_WINDOW 1445L")]
    public const int ERROR_NON_MDICHILD_WINDOW = 1445;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_POPUP_ALREADY_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_POPUP_ALREADY_ACTIVE 1446L")]
    public const int ERROR_POPUP_ALREADY_ACTIVE = 1446;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SCROLLBARS"]/*' />
    [NativeTypeName("#define ERROR_NO_SCROLLBARS 1447L")]
    public const int ERROR_NO_SCROLLBARS = 1447;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SCROLLBAR_RANGE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SCROLLBAR_RANGE 1448L")]
    public const int ERROR_INVALID_SCROLLBAR_RANGE = 1448;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SHOWWIN_COMMAND"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SHOWWIN_COMMAND 1449L")]
    public const int ERROR_INVALID_SHOWWIN_COMMAND = 1449;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SYSTEM_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_NO_SYSTEM_RESOURCES 1450L")]
    public const int ERROR_NO_SYSTEM_RESOURCES = 1450;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NONPAGED_SYSTEM_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_NONPAGED_SYSTEM_RESOURCES 1451L")]
    public const int ERROR_NONPAGED_SYSTEM_RESOURCES = 1451;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGED_SYSTEM_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_PAGED_SYSTEM_RESOURCES 1452L")]
    public const int ERROR_PAGED_SYSTEM_RESOURCES = 1452;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WORKING_SET_QUOTA"]/*' />
    [NativeTypeName("#define ERROR_WORKING_SET_QUOTA 1453L")]
    public const int ERROR_WORKING_SET_QUOTA = 1453;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PAGEFILE_QUOTA"]/*' />
    [NativeTypeName("#define ERROR_PAGEFILE_QUOTA 1454L")]
    public const int ERROR_PAGEFILE_QUOTA = 1454;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COMMITMENT_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_COMMITMENT_LIMIT 1455L")]
    public const int ERROR_COMMITMENT_LIMIT = 1455;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MENU_ITEM_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_MENU_ITEM_NOT_FOUND 1456L")]
    public const int ERROR_MENU_ITEM_NOT_FOUND = 1456;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_KEYBOARD_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_KEYBOARD_HANDLE 1457L")]
    public const int ERROR_INVALID_KEYBOARD_HANDLE = 1457;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOOK_TYPE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_HOOK_TYPE_NOT_ALLOWED 1458L")]
    public const int ERROR_HOOK_TYPE_NOT_ALLOWED = 1458;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION"]/*' />
    [NativeTypeName("#define ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION 1459L")]
    public const int ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 1459;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_TIMEOUT 1460L")]
    public const int ERROR_TIMEOUT = 1460;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MONITOR_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MONITOR_HANDLE 1461L")]
    public const int ERROR_INVALID_MONITOR_HANDLE = 1461;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INCORRECT_SIZE"]/*' />
    [NativeTypeName("#define ERROR_INCORRECT_SIZE 1462L")]
    public const int ERROR_INCORRECT_SIZE = 1462;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYMLINK_CLASS_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_SYMLINK_CLASS_DISABLED 1463L")]
    public const int ERROR_SYMLINK_CLASS_DISABLED = 1463;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYMLINK_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_SYMLINK_NOT_SUPPORTED 1464L")]
    public const int ERROR_SYMLINK_NOT_SUPPORTED = 1464;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_XML_PARSE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_XML_PARSE_ERROR 1465L")]
    public const int ERROR_XML_PARSE_ERROR = 1465;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_XMLDSIG_ERROR"]/*' />
    [NativeTypeName("#define ERROR_XMLDSIG_ERROR 1466L")]
    public const int ERROR_XMLDSIG_ERROR = 1466;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESTART_APPLICATION"]/*' />
    [NativeTypeName("#define ERROR_RESTART_APPLICATION 1467L")]
    public const int ERROR_RESTART_APPLICATION = 1467;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRONG_COMPARTMENT"]/*' />
    [NativeTypeName("#define ERROR_WRONG_COMPARTMENT 1468L")]
    public const int ERROR_WRONG_COMPARTMENT = 1468;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUTHIP_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_AUTHIP_FAILURE 1469L")]
    public const int ERROR_AUTHIP_FAILURE = 1469;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_NVRAM_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_NO_NVRAM_RESOURCES 1470L")]
    public const int ERROR_NO_NVRAM_RESOURCES = 1470;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_GUI_PROCESS"]/*' />
    [NativeTypeName("#define ERROR_NOT_GUI_PROCESS 1471L")]
    public const int ERROR_NOT_GUI_PROCESS = 1471;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVENTLOG_FILE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_EVENTLOG_FILE_CORRUPT 1500L")]
    public const int ERROR_EVENTLOG_FILE_CORRUPT = 1500;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVENTLOG_CANT_START"]/*' />
    [NativeTypeName("#define ERROR_EVENTLOG_CANT_START 1501L")]
    public const int ERROR_EVENTLOG_CANT_START = 1501;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_FILE_FULL"]/*' />
    [NativeTypeName("#define ERROR_LOG_FILE_FULL 1502L")]
    public const int ERROR_LOG_FILE_FULL = 1502;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVENTLOG_FILE_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_EVENTLOG_FILE_CHANGED 1503L")]
    public const int ERROR_EVENTLOG_FILE_CHANGED = 1503;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONTAINER_ASSIGNED"]/*' />
    [NativeTypeName("#define ERROR_CONTAINER_ASSIGNED 1504L")]
    public const int ERROR_CONTAINER_ASSIGNED = 1504;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_JOB_NO_CONTAINER"]/*' />
    [NativeTypeName("#define ERROR_JOB_NO_CONTAINER 1505L")]
    public const int ERROR_JOB_NO_CONTAINER = 1505;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TASK_NAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TASK_NAME 1550L")]
    public const int ERROR_INVALID_TASK_NAME = 1550;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TASK_INDEX"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TASK_INDEX 1551L")]
    public const int ERROR_INVALID_TASK_INDEX = 1551;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_THREAD_ALREADY_IN_TASK"]/*' />
    [NativeTypeName("#define ERROR_THREAD_ALREADY_IN_TASK 1552L")]
    public const int ERROR_THREAD_ALREADY_IN_TASK = 1552;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_SERVICE_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_SERVICE_FAILURE 1601L")]
    public const int ERROR_INSTALL_SERVICE_FAILURE = 1601;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_USEREXIT"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_USEREXIT 1602L")]
    public const int ERROR_INSTALL_USEREXIT = 1602;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_FAILURE 1603L")]
    public const int ERROR_INSTALL_FAILURE = 1603;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_SUSPEND"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_SUSPEND 1604L")]
    public const int ERROR_INSTALL_SUSPEND = 1604;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_PRODUCT"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_PRODUCT 1605L")]
    public const int ERROR_UNKNOWN_PRODUCT = 1605;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_FEATURE"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_FEATURE 1606L")]
    public const int ERROR_UNKNOWN_FEATURE = 1606;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_COMPONENT"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_COMPONENT 1607L")]
    public const int ERROR_UNKNOWN_COMPONENT = 1607;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_PROPERTY"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_PROPERTY 1608L")]
    public const int ERROR_UNKNOWN_PROPERTY = 1608;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_HANDLE_STATE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_HANDLE_STATE 1609L")]
    public const int ERROR_INVALID_HANDLE_STATE = 1609;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_CONFIGURATION"]/*' />
    [NativeTypeName("#define ERROR_BAD_CONFIGURATION 1610L")]
    public const int ERROR_BAD_CONFIGURATION = 1610;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INDEX_ABSENT"]/*' />
    [NativeTypeName("#define ERROR_INDEX_ABSENT 1611L")]
    public const int ERROR_INDEX_ABSENT = 1611;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_SOURCE_ABSENT"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_SOURCE_ABSENT 1612L")]
    public const int ERROR_INSTALL_SOURCE_ABSENT = 1612;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_PACKAGE_VERSION"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_PACKAGE_VERSION 1613L")]
    public const int ERROR_INSTALL_PACKAGE_VERSION = 1613;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRODUCT_UNINSTALLED"]/*' />
    [NativeTypeName("#define ERROR_PRODUCT_UNINSTALLED 1614L")]
    public const int ERROR_PRODUCT_UNINSTALLED = 1614;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_QUERY_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_BAD_QUERY_SYNTAX 1615L")]
    public const int ERROR_BAD_QUERY_SYNTAX = 1615;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FIELD"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FIELD 1616L")]
    public const int ERROR_INVALID_FIELD = 1616;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_REMOVED"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_REMOVED 1617L")]
    public const int ERROR_DEVICE_REMOVED = 1617;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_ALREADY_RUNNING"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_ALREADY_RUNNING 1618L")]
    public const int ERROR_INSTALL_ALREADY_RUNNING = 1618;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_PACKAGE_OPEN_FAILED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_PACKAGE_OPEN_FAILED 1619L")]
    public const int ERROR_INSTALL_PACKAGE_OPEN_FAILED = 1619;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_PACKAGE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_PACKAGE_INVALID 1620L")]
    public const int ERROR_INSTALL_PACKAGE_INVALID = 1620;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_UI_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_UI_FAILURE 1621L")]
    public const int ERROR_INSTALL_UI_FAILURE = 1621;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_LOG_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_LOG_FAILURE 1622L")]
    public const int ERROR_INSTALL_LOG_FAILURE = 1622;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_LANGUAGE_UNSUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_LANGUAGE_UNSUPPORTED 1623L")]
    public const int ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 1623;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_TRANSFORM_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_TRANSFORM_FAILURE 1624L")]
    public const int ERROR_INSTALL_TRANSFORM_FAILURE = 1624;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_PACKAGE_REJECTED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_PACKAGE_REJECTED 1625L")]
    public const int ERROR_INSTALL_PACKAGE_REJECTED = 1625;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FUNCTION_NOT_CALLED"]/*' />
    [NativeTypeName("#define ERROR_FUNCTION_NOT_CALLED 1626L")]
    public const int ERROR_FUNCTION_NOT_CALLED = 1626;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FUNCTION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_FUNCTION_FAILED 1627L")]
    public const int ERROR_FUNCTION_FAILED = 1627;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TABLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TABLE 1628L")]
    public const int ERROR_INVALID_TABLE = 1628;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DATATYPE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DATATYPE_MISMATCH 1629L")]
    public const int ERROR_DATATYPE_MISMATCH = 1629;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNSUPPORTED_TYPE"]/*' />
    [NativeTypeName("#define ERROR_UNSUPPORTED_TYPE 1630L")]
    public const int ERROR_UNSUPPORTED_TYPE = 1630;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CREATE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CREATE_FAILED 1631L")]
    public const int ERROR_CREATE_FAILED = 1631;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_TEMP_UNWRITABLE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_TEMP_UNWRITABLE 1632L")]
    public const int ERROR_INSTALL_TEMP_UNWRITABLE = 1632;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_PLATFORM_UNSUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_PLATFORM_UNSUPPORTED 1633L")]
    public const int ERROR_INSTALL_PLATFORM_UNSUPPORTED = 1633;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_NOTUSED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_NOTUSED 1634L")]
    public const int ERROR_INSTALL_NOTUSED = 1634;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_PACKAGE_OPEN_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PATCH_PACKAGE_OPEN_FAILED 1635L")]
    public const int ERROR_PATCH_PACKAGE_OPEN_FAILED = 1635;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_PACKAGE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_PATCH_PACKAGE_INVALID 1636L")]
    public const int ERROR_PATCH_PACKAGE_INVALID = 1636;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_PACKAGE_UNSUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_PATCH_PACKAGE_UNSUPPORTED 1637L")]
    public const int ERROR_PATCH_PACKAGE_UNSUPPORTED = 1637;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRODUCT_VERSION"]/*' />
    [NativeTypeName("#define ERROR_PRODUCT_VERSION 1638L")]
    public const int ERROR_PRODUCT_VERSION = 1638;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_COMMAND_LINE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_COMMAND_LINE 1639L")]
    public const int ERROR_INVALID_COMMAND_LINE = 1639;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_REMOTE_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_REMOTE_DISALLOWED 1640L")]
    public const int ERROR_INSTALL_REMOTE_DISALLOWED = 1640;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SUCCESS_REBOOT_INITIATED"]/*' />
    [NativeTypeName("#define ERROR_SUCCESS_REBOOT_INITIATED 1641L")]
    public const int ERROR_SUCCESS_REBOOT_INITIATED = 1641;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_TARGET_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PATCH_TARGET_NOT_FOUND 1642L")]
    public const int ERROR_PATCH_TARGET_NOT_FOUND = 1642;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_PACKAGE_REJECTED"]/*' />
    [NativeTypeName("#define ERROR_PATCH_PACKAGE_REJECTED 1643L")]
    public const int ERROR_PATCH_PACKAGE_REJECTED = 1643;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_TRANSFORM_REJECTED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_TRANSFORM_REJECTED 1644L")]
    public const int ERROR_INSTALL_TRANSFORM_REJECTED = 1644;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_REMOTE_PROHIBITED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_REMOTE_PROHIBITED 1645L")]
    public const int ERROR_INSTALL_REMOTE_PROHIBITED = 1645;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_REMOVAL_UNSUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_PATCH_REMOVAL_UNSUPPORTED 1646L")]
    public const int ERROR_PATCH_REMOVAL_UNSUPPORTED = 1646;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_PATCH"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_PATCH 1647L")]
    public const int ERROR_UNKNOWN_PATCH = 1647;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_NO_SEQUENCE"]/*' />
    [NativeTypeName("#define ERROR_PATCH_NO_SEQUENCE 1648L")]
    public const int ERROR_PATCH_NO_SEQUENCE = 1648;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_REMOVAL_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_PATCH_REMOVAL_DISALLOWED 1649L")]
    public const int ERROR_PATCH_REMOVAL_DISALLOWED = 1649;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PATCH_XML"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PATCH_XML 1650L")]
    public const int ERROR_INVALID_PATCH_XML = 1650;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT"]/*' />
    [NativeTypeName("#define ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT 1651L")]
    public const int ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT = 1651;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_SERVICE_SAFEBOOT"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_SERVICE_SAFEBOOT 1652L")]
    public const int ERROR_INSTALL_SERVICE_SAFEBOOT = 1652;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAIL_FAST_EXCEPTION"]/*' />
    [NativeTypeName("#define ERROR_FAIL_FAST_EXCEPTION 1653L")]
    public const int ERROR_FAIL_FAST_EXCEPTION = 1653;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_REJECTED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_REJECTED 1654L")]
    public const int ERROR_INSTALL_REJECTED = 1654;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DYNAMIC_CODE_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_DYNAMIC_CODE_BLOCKED 1655L")]
    public const int ERROR_DYNAMIC_CODE_BLOCKED = 1655;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SAME_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_NOT_SAME_OBJECT 1656L")]
    public const int ERROR_NOT_SAME_OBJECT = 1656;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STRICT_CFG_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_STRICT_CFG_VIOLATION 1657L")]
    public const int ERROR_STRICT_CFG_VIOLATION = 1657;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SET_CONTEXT_DENIED"]/*' />
    [NativeTypeName("#define ERROR_SET_CONTEXT_DENIED 1660L")]
    public const int ERROR_SET_CONTEXT_DENIED = 1660;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CROSS_PARTITION_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_CROSS_PARTITION_VIOLATION 1661L")]
    public const int ERROR_CROSS_PARTITION_VIOLATION = 1661;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RETURN_ADDRESS_HIJACK_ATTEMPT"]/*' />
    [NativeTypeName("#define ERROR_RETURN_ADDRESS_HIJACK_ATTEMPT 1662L")]
    public const int ERROR_RETURN_ADDRESS_HIJACK_ATTEMPT = 1662;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_USER_BUFFER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_USER_BUFFER 1784L")]
    public const int ERROR_INVALID_USER_BUFFER = 1784;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNRECOGNIZED_MEDIA"]/*' />
    [NativeTypeName("#define ERROR_UNRECOGNIZED_MEDIA 1785L")]
    public const int ERROR_UNRECOGNIZED_MEDIA = 1785;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_TRUST_LSA_SECRET"]/*' />
    [NativeTypeName("#define ERROR_NO_TRUST_LSA_SECRET 1786L")]
    public const int ERROR_NO_TRUST_LSA_SECRET = 1786;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_TRUST_SAM_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_NO_TRUST_SAM_ACCOUNT 1787L")]
    public const int ERROR_NO_TRUST_SAM_ACCOUNT = 1787;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRUSTED_DOMAIN_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_TRUSTED_DOMAIN_FAILURE 1788L")]
    public const int ERROR_TRUSTED_DOMAIN_FAILURE = 1788;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRUSTED_RELATIONSHIP_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_TRUSTED_RELATIONSHIP_FAILURE 1789L")]
    public const int ERROR_TRUSTED_RELATIONSHIP_FAILURE = 1789;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRUST_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_TRUST_FAILURE 1790L")]
    public const int ERROR_TRUST_FAILURE = 1790;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NETLOGON_NOT_STARTED"]/*' />
    [NativeTypeName("#define ERROR_NETLOGON_NOT_STARTED 1792L")]
    public const int ERROR_NETLOGON_NOT_STARTED = 1792;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCOUNT_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_ACCOUNT_EXPIRED 1793L")]
    public const int ERROR_ACCOUNT_EXPIRED = 1793;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REDIRECTOR_HAS_OPEN_HANDLES"]/*' />
    [NativeTypeName("#define ERROR_REDIRECTOR_HAS_OPEN_HANDLES 1794L")]
    public const int ERROR_REDIRECTOR_HAS_OPEN_HANDLES = 1794;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_DRIVER_ALREADY_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_DRIVER_ALREADY_INSTALLED 1795L")]
    public const int ERROR_PRINTER_DRIVER_ALREADY_INSTALLED = 1795;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_PORT"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_PORT 1796L")]
    public const int ERROR_UNKNOWN_PORT = 1796;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_PRINTER_DRIVER"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_PRINTER_DRIVER 1797L")]
    public const int ERROR_UNKNOWN_PRINTER_DRIVER = 1797;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_PRINTPROCESSOR"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_PRINTPROCESSOR 1798L")]
    public const int ERROR_UNKNOWN_PRINTPROCESSOR = 1798;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_SEPARATOR_FILE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_SEPARATOR_FILE 1799L")]
    public const int ERROR_INVALID_SEPARATOR_FILE = 1799;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PRIORITY"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PRIORITY 1800L")]
    public const int ERROR_INVALID_PRIORITY = 1800;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PRINTER_NAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PRINTER_NAME 1801L")]
    public const int ERROR_INVALID_PRINTER_NAME = 1801;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_ALREADY_EXISTS 1802L")]
    public const int ERROR_PRINTER_ALREADY_EXISTS = 1802;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PRINTER_COMMAND"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PRINTER_COMMAND 1803L")]
    public const int ERROR_INVALID_PRINTER_COMMAND = 1803;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DATATYPE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DATATYPE 1804L")]
    public const int ERROR_INVALID_DATATYPE = 1804;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_ENVIRONMENT"]/*' />
    [NativeTypeName("#define ERROR_INVALID_ENVIRONMENT 1805L")]
    public const int ERROR_INVALID_ENVIRONMENT = 1805;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT 1807L")]
    public const int ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 1807;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT 1808L")]
    public const int ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 1808;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOLOGON_SERVER_TRUST_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_NOLOGON_SERVER_TRUST_ACCOUNT 1809L")]
    public const int ERROR_NOLOGON_SERVER_TRUST_ACCOUNT = 1809;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DOMAIN_TRUST_INCONSISTENT"]/*' />
    [NativeTypeName("#define ERROR_DOMAIN_TRUST_INCONSISTENT 1810L")]
    public const int ERROR_DOMAIN_TRUST_INCONSISTENT = 1810;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVER_HAS_OPEN_HANDLES"]/*' />
    [NativeTypeName("#define ERROR_SERVER_HAS_OPEN_HANDLES 1811L")]
    public const int ERROR_SERVER_HAS_OPEN_HANDLES = 1811;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_DATA_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_DATA_NOT_FOUND 1812L")]
    public const int ERROR_RESOURCE_DATA_NOT_FOUND = 1812;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_TYPE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_TYPE_NOT_FOUND 1813L")]
    public const int ERROR_RESOURCE_TYPE_NOT_FOUND = 1813;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_NAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_NAME_NOT_FOUND 1814L")]
    public const int ERROR_RESOURCE_NAME_NOT_FOUND = 1814;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_LANG_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_LANG_NOT_FOUND 1815L")]
    public const int ERROR_RESOURCE_LANG_NOT_FOUND = 1815;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_ENOUGH_QUOTA"]/*' />
    [NativeTypeName("#define ERROR_NOT_ENOUGH_QUOTA 1816L")]
    public const int ERROR_NOT_ENOUGH_QUOTA = 1816;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TIME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TIME 1901L")]
    public const int ERROR_INVALID_TIME = 1901;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FORM_NAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FORM_NAME 1902L")]
    public const int ERROR_INVALID_FORM_NAME = 1902;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_FORM_SIZE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_FORM_SIZE 1903L")]
    public const int ERROR_INVALID_FORM_SIZE = 1903;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_WAITING"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_WAITING 1904L")]
    public const int ERROR_ALREADY_WAITING = 1904;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_DELETED"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_DELETED 1905L")]
    public const int ERROR_PRINTER_DELETED = 1905;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PRINTER_STATE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PRINTER_STATE 1906L")]
    public const int ERROR_INVALID_PRINTER_STATE = 1906;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PASSWORD_MUST_CHANGE"]/*' />
    [NativeTypeName("#define ERROR_PASSWORD_MUST_CHANGE 1907L")]
    public const int ERROR_PASSWORD_MUST_CHANGE = 1907;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DOMAIN_CONTROLLER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DOMAIN_CONTROLLER_NOT_FOUND 1908L")]
    public const int ERROR_DOMAIN_CONTROLLER_NOT_FOUND = 1908;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCOUNT_LOCKED_OUT"]/*' />
    [NativeTypeName("#define ERROR_ACCOUNT_LOCKED_OUT 1909L")]
    public const int ERROR_ACCOUNT_LOCKED_OUT = 1909;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SITENAME"]/*' />
    [NativeTypeName("#define ERROR_NO_SITENAME 1919L")]
    public const int ERROR_NO_SITENAME = 1919;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_ACCESS_FILE"]/*' />
    [NativeTypeName("#define ERROR_CANT_ACCESS_FILE 1920L")]
    public const int ERROR_CANT_ACCESS_FILE = 1920;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_RESOLVE_FILENAME"]/*' />
    [NativeTypeName("#define ERROR_CANT_RESOLVE_FILENAME 1921L")]
    public const int ERROR_CANT_RESOLVE_FILENAME = 1921;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_KM_DRIVER_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_KM_DRIVER_BLOCKED 1930L")]
    public const int ERROR_KM_DRIVER_BLOCKED = 1930;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONTEXT_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_CONTEXT_EXPIRED 1931L")]
    public const int ERROR_CONTEXT_EXPIRED = 1931;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PER_USER_TRUST_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_PER_USER_TRUST_QUOTA_EXCEEDED 1932L")]
    public const int ERROR_PER_USER_TRUST_QUOTA_EXCEEDED = 1932;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED 1933L")]
    public const int ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED = 1933;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED 1934L")]
    public const int ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED = 1934;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUTHENTICATION_FIREWALL_FAILED"]/*' />
    [NativeTypeName("#define ERROR_AUTHENTICATION_FIREWALL_FAILED 1935L")]
    public const int ERROR_AUTHENTICATION_FIREWALL_FAILED = 1935;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED 1936L")]
    public const int ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED = 1936;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NTLM_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_NTLM_BLOCKED 1937L")]
    public const int ERROR_NTLM_BLOCKED = 1937;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PASSWORD_CHANGE_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_PASSWORD_CHANGE_REQUIRED 1938L")]
    public const int ERROR_PASSWORD_CHANGE_REQUIRED = 1938;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOST_MODE_LOGON_RESTRICTION"]/*' />
    [NativeTypeName("#define ERROR_LOST_MODE_LOGON_RESTRICTION 1939L")]
    public const int ERROR_LOST_MODE_LOGON_RESTRICTION = 1939;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PIXEL_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PIXEL_FORMAT 2000L")]
    public const int ERROR_INVALID_PIXEL_FORMAT = 2000;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_DRIVER"]/*' />
    [NativeTypeName("#define ERROR_BAD_DRIVER 2001L")]
    public const int ERROR_BAD_DRIVER = 2001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_WINDOW_STYLE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_WINDOW_STYLE 2002L")]
    public const int ERROR_INVALID_WINDOW_STYLE = 2002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_METAFILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_METAFILE_NOT_SUPPORTED 2003L")]
    public const int ERROR_METAFILE_NOT_SUPPORTED = 2003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSFORM_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_TRANSFORM_NOT_SUPPORTED 2004L")]
    public const int ERROR_TRANSFORM_NOT_SUPPORTED = 2004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIPPING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_CLIPPING_NOT_SUPPORTED 2005L")]
    public const int ERROR_CLIPPING_NOT_SUPPORTED = 2005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CMM"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CMM 2010L")]
    public const int ERROR_INVALID_CMM = 2010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PROFILE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PROFILE 2011L")]
    public const int ERROR_INVALID_PROFILE = 2011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TAG_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_TAG_NOT_FOUND 2012L")]
    public const int ERROR_TAG_NOT_FOUND = 2012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TAG_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_TAG_NOT_PRESENT 2013L")]
    public const int ERROR_TAG_NOT_PRESENT = 2013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DUPLICATE_TAG"]/*' />
    [NativeTypeName("#define ERROR_DUPLICATE_TAG 2014L")]
    public const int ERROR_DUPLICATE_TAG = 2014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE 2015L")]
    public const int ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE = 2015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROFILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PROFILE_NOT_FOUND 2016L")]
    public const int ERROR_PROFILE_NOT_FOUND = 2016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_COLORSPACE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_COLORSPACE 2017L")]
    public const int ERROR_INVALID_COLORSPACE = 2017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ICM_NOT_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_ICM_NOT_ENABLED 2018L")]
    public const int ERROR_ICM_NOT_ENABLED = 2018;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DELETING_ICM_XFORM"]/*' />
    [NativeTypeName("#define ERROR_DELETING_ICM_XFORM 2019L")]
    public const int ERROR_DELETING_ICM_XFORM = 2019;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TRANSFORM"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TRANSFORM 2020L")]
    public const int ERROR_INVALID_TRANSFORM = 2020;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COLORSPACE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_COLORSPACE_MISMATCH 2021L")]
    public const int ERROR_COLORSPACE_MISMATCH = 2021;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_COLORINDEX"]/*' />
    [NativeTypeName("#define ERROR_INVALID_COLORINDEX 2022L")]
    public const int ERROR_INVALID_COLORINDEX = 2022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROFILE_DOES_NOT_MATCH_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_PROFILE_DOES_NOT_MATCH_DEVICE 2023L")]
    public const int ERROR_PROFILE_DOES_NOT_MATCH_DEVICE = 2023;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONNECTED_OTHER_PASSWORD"]/*' />
    [NativeTypeName("#define ERROR_CONNECTED_OTHER_PASSWORD 2108L")]
    public const int ERROR_CONNECTED_OTHER_PASSWORD = 2108;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT"]/*' />
    [NativeTypeName("#define ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT 2109L")]
    public const int ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_USERNAME"]/*' />
    [NativeTypeName("#define ERROR_BAD_USERNAME 2202L")]
    public const int ERROR_BAD_USERNAME = 2202;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_NOT_CONNECTED 2250L")]
    public const int ERROR_NOT_CONNECTED = 2250;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPEN_FILES"]/*' />
    [NativeTypeName("#define ERROR_OPEN_FILES 2401L")]
    public const int ERROR_OPEN_FILES = 2401;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACTIVE_CONNECTIONS"]/*' />
    [NativeTypeName("#define ERROR_ACTIVE_CONNECTIONS 2402L")]
    public const int ERROR_ACTIVE_CONNECTIONS = 2402;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_IN_USE 2404L")]
    public const int ERROR_DEVICE_IN_USE = 2404;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNKNOWN_PRINT_MONITOR"]/*' />
    [NativeTypeName("#define ERROR_UNKNOWN_PRINT_MONITOR 3000L")]
    public const int ERROR_UNKNOWN_PRINT_MONITOR = 3000;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_DRIVER_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_DRIVER_IN_USE 3001L")]
    public const int ERROR_PRINTER_DRIVER_IN_USE = 3001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPOOL_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SPOOL_FILE_NOT_FOUND 3002L")]
    public const int ERROR_SPOOL_FILE_NOT_FOUND = 3002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPL_NO_STARTDOC"]/*' />
    [NativeTypeName("#define ERROR_SPL_NO_STARTDOC 3003L")]
    public const int ERROR_SPL_NO_STARTDOC = 3003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPL_NO_ADDJOB"]/*' />
    [NativeTypeName("#define ERROR_SPL_NO_ADDJOB 3004L")]
    public const int ERROR_SPL_NO_ADDJOB = 3004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED 3005L")]
    public const int ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINT_MONITOR_ALREADY_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_PRINT_MONITOR_ALREADY_INSTALLED 3006L")]
    public const int ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PRINT_MONITOR"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PRINT_MONITOR 3007L")]
    public const int ERROR_INVALID_PRINT_MONITOR = 3007;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINT_MONITOR_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_PRINT_MONITOR_IN_USE 3008L")]
    public const int ERROR_PRINT_MONITOR_IN_USE = 3008;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_HAS_JOBS_QUEUED"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_HAS_JOBS_QUEUED 3009L")]
    public const int ERROR_PRINTER_HAS_JOBS_QUEUED = 3009;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SUCCESS_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_SUCCESS_REBOOT_REQUIRED 3010L")]
    public const int ERROR_SUCCESS_REBOOT_REQUIRED = 3010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SUCCESS_RESTART_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_SUCCESS_RESTART_REQUIRED 3011L")]
    public const int ERROR_SUCCESS_RESTART_REQUIRED = 3011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_NOT_FOUND 3012L")]
    public const int ERROR_PRINTER_NOT_FOUND = 3012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_DRIVER_WARNED"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_DRIVER_WARNED 3013L")]
    public const int ERROR_PRINTER_DRIVER_WARNED = 3013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_DRIVER_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_DRIVER_BLOCKED 3014L")]
    public const int ERROR_PRINTER_DRIVER_BLOCKED = 3014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_DRIVER_PACKAGE_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_DRIVER_PACKAGE_IN_USE 3015L")]
    public const int ERROR_PRINTER_DRIVER_PACKAGE_IN_USE = 3015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND 3016L")]
    public const int ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND = 3016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAIL_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_FAIL_REBOOT_REQUIRED 3017L")]
    public const int ERROR_FAIL_REBOOT_REQUIRED = 3017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FAIL_REBOOT_INITIATED"]/*' />
    [NativeTypeName("#define ERROR_FAIL_REBOOT_INITIATED 3018L")]
    public const int ERROR_FAIL_REBOOT_INITIATED = 3018;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED 3019L")]
    public const int ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED = 3019;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINT_JOB_RESTART_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_PRINT_JOB_RESTART_REQUIRED 3020L")]
    public const int ERROR_PRINT_JOB_RESTART_REQUIRED = 3020;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PRINTER_DRIVER_MANIFEST"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PRINTER_DRIVER_MANIFEST 3021L")]
    public const int ERROR_INVALID_PRINTER_DRIVER_MANIFEST = 3021;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRINTER_NOT_SHAREABLE"]/*' />
    [NativeTypeName("#define ERROR_PRINTER_NOT_SHAREABLE 3022L")]
    public const int ERROR_PRINTER_NOT_SHAREABLE = 3022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVER_SERVICE_CALL_REQUIRES_SMB1"]/*' />
    [NativeTypeName("#define ERROR_SERVER_SERVICE_CALL_REQUIRES_SMB1 3023L")]
    public const int ERROR_SERVER_SERVICE_CALL_REQUIRES_SMB1 = 3023;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NETWORK_AUTHENTICATION_PROMPT_CANCELED"]/*' />
    [NativeTypeName("#define ERROR_NETWORK_AUTHENTICATION_PROMPT_CANCELED 3024L")]
    public const int ERROR_NETWORK_AUTHENTICATION_PROMPT_CANCELED = 3024;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOTE_MAILSLOTS_DEPRECATED"]/*' />
    [NativeTypeName("#define ERROR_REMOTE_MAILSLOTS_DEPRECATED 3025L")]
    public const int ERROR_REMOTE_MAILSLOTS_DEPRECATED = 3025;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REQUEST_PAUSED"]/*' />
    [NativeTypeName("#define ERROR_REQUEST_PAUSED 3050L")]
    public const int ERROR_REQUEST_PAUSED = 3050;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_CONDITION_NOT_SATISFIED"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_CONDITION_NOT_SATISFIED 3060L")]
    public const int ERROR_APPEXEC_CONDITION_NOT_SATISFIED = 3060;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_HANDLE_INVALIDATED"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_HANDLE_INVALIDATED 3061L")]
    public const int ERROR_APPEXEC_HANDLE_INVALIDATED = 3061;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_INVALID_HOST_GENERATION"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_INVALID_HOST_GENERATION 3062L")]
    public const int ERROR_APPEXEC_INVALID_HOST_GENERATION = 3062;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION 3063L")]
    public const int ERROR_APPEXEC_UNEXPECTED_PROCESS_REGISTRATION = 3063;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_INVALID_HOST_STATE"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_INVALID_HOST_STATE 3064L")]
    public const int ERROR_APPEXEC_INVALID_HOST_STATE = 3064;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_NO_DONOR"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_NO_DONOR 3065L")]
    public const int ERROR_APPEXEC_NO_DONOR = 3065;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_HOST_ID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_HOST_ID_MISMATCH 3066L")]
    public const int ERROR_APPEXEC_HOST_ID_MISMATCH = 3066;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_UNKNOWN_USER"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_UNKNOWN_USER 3067L")]
    public const int ERROR_APPEXEC_UNKNOWN_USER = 3067;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_APP_COMPAT_BLOCK"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_APP_COMPAT_BLOCK 3068L")]
    public const int ERROR_APPEXEC_APP_COMPAT_BLOCK = 3068;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_CALLER_WAIT_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_CALLER_WAIT_TIMEOUT 3069L")]
    public const int ERROR_APPEXEC_CALLER_WAIT_TIMEOUT = 3069;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_TERMINATION"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_TERMINATION 3070L")]
    public const int ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_TERMINATION = 3070;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_LICENSING"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_LICENSING 3071L")]
    public const int ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_LICENSING = 3071;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_RESOURCES 3072L")]
    public const int ERROR_APPEXEC_CALLER_WAIT_TIMEOUT_RESOURCES = 3072;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VRF_VOLATILE_CFG_AND_IO_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_VRF_VOLATILE_CFG_AND_IO_ENABLED 3080L")]
    public const int ERROR_VRF_VOLATILE_CFG_AND_IO_ENABLED = 3080;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VRF_VOLATILE_NOT_STOPPABLE"]/*' />
    [NativeTypeName("#define ERROR_VRF_VOLATILE_NOT_STOPPABLE 3081L")]
    public const int ERROR_VRF_VOLATILE_NOT_STOPPABLE = 3081;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VRF_VOLATILE_SAFE_MODE"]/*' />
    [NativeTypeName("#define ERROR_VRF_VOLATILE_SAFE_MODE 3082L")]
    public const int ERROR_VRF_VOLATILE_SAFE_MODE = 3082;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VRF_VOLATILE_NOT_RUNNABLE_SYSTEM"]/*' />
    [NativeTypeName("#define ERROR_VRF_VOLATILE_NOT_RUNNABLE_SYSTEM 3083L")]
    public const int ERROR_VRF_VOLATILE_NOT_RUNNABLE_SYSTEM = 3083;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VRF_VOLATILE_NOT_SUPPORTED_RULECLASS"]/*' />
    [NativeTypeName("#define ERROR_VRF_VOLATILE_NOT_SUPPORTED_RULECLASS 3084L")]
    public const int ERROR_VRF_VOLATILE_NOT_SUPPORTED_RULECLASS = 3084;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VRF_VOLATILE_PROTECTED_DRIVER"]/*' />
    [NativeTypeName("#define ERROR_VRF_VOLATILE_PROTECTED_DRIVER 3085L")]
    public const int ERROR_VRF_VOLATILE_PROTECTED_DRIVER = 3085;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VRF_VOLATILE_NMI_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_VRF_VOLATILE_NMI_REGISTERED 3086L")]
    public const int ERROR_VRF_VOLATILE_NMI_REGISTERED = 3086;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VRF_VOLATILE_SETTINGS_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_VRF_VOLATILE_SETTINGS_CONFLICT 3087L")]
    public const int ERROR_VRF_VOLATILE_SETTINGS_CONFLICT = 3087;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAR_LKD_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CAR_LKD_IN_PROGRESS 3088L")]
    public const int ERROR_CAR_LKD_IN_PROGRESS = 3088;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_ZERO_SIZE_INFORMATION"]/*' />
    [NativeTypeName("#define ERROR_DIF_ZERO_SIZE_INFORMATION 3187L")]
    public const int ERROR_DIF_ZERO_SIZE_INFORMATION = 3187;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_DRIVER_PLUGIN_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DIF_DRIVER_PLUGIN_MISMATCH 3188L")]
    public const int ERROR_DIF_DRIVER_PLUGIN_MISMATCH = 3188;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_DRIVER_THUNKS_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_DIF_DRIVER_THUNKS_NOT_ALLOWED 3189L")]
    public const int ERROR_DIF_DRIVER_THUNKS_NOT_ALLOWED = 3189;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_IOCALLBACK_NOT_REPLACED"]/*' />
    [NativeTypeName("#define ERROR_DIF_IOCALLBACK_NOT_REPLACED 3190L")]
    public const int ERROR_DIF_IOCALLBACK_NOT_REPLACED = 3190;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_LIVEDUMP_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DIF_LIVEDUMP_LIMIT_EXCEEDED 3191L")]
    public const int ERROR_DIF_LIVEDUMP_LIMIT_EXCEEDED = 3191;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_VOLATILE_SECTION_NOT_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_DIF_VOLATILE_SECTION_NOT_LOCKED 3192L")]
    public const int ERROR_DIF_VOLATILE_SECTION_NOT_LOCKED = 3192;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_VOLATILE_DRIVER_HOTPATCHED"]/*' />
    [NativeTypeName("#define ERROR_DIF_VOLATILE_DRIVER_HOTPATCHED 3193L")]
    public const int ERROR_DIF_VOLATILE_DRIVER_HOTPATCHED = 3193;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_VOLATILE_INVALID_INFO"]/*' />
    [NativeTypeName("#define ERROR_DIF_VOLATILE_INVALID_INFO 3194L")]
    public const int ERROR_DIF_VOLATILE_INVALID_INFO = 3194;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_VOLATILE_DRIVER_IS_NOT_RUNNING"]/*' />
    [NativeTypeName("#define ERROR_DIF_VOLATILE_DRIVER_IS_NOT_RUNNING 3195L")]
    public const int ERROR_DIF_VOLATILE_DRIVER_IS_NOT_RUNNING = 3195;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_VOLATILE_PLUGIN_IS_NOT_RUNNING"]/*' />
    [NativeTypeName("#define ERROR_DIF_VOLATILE_PLUGIN_IS_NOT_RUNNING 3196L")]
    public const int ERROR_DIF_VOLATILE_PLUGIN_IS_NOT_RUNNING = 3196;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_VOLATILE_PLUGIN_CHANGE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_DIF_VOLATILE_PLUGIN_CHANGE_NOT_ALLOWED 3197L")]
    public const int ERROR_DIF_VOLATILE_PLUGIN_CHANGE_NOT_ALLOWED = 3197;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_VOLATILE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_DIF_VOLATILE_NOT_ALLOWED 3198L")]
    public const int ERROR_DIF_VOLATILE_NOT_ALLOWED = 3198;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIF_BINDING_API_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DIF_BINDING_API_NOT_FOUND 3199L")]
    public const int ERROR_DIF_BINDING_API_NOT_FOUND = 3199;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IO_REISSUE_AS_CACHED"]/*' />
    [NativeTypeName("#define ERROR_IO_REISSUE_AS_CACHED 3950L")]
    public const int ERROR_IO_REISSUE_AS_CACHED = 3950;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WINS_INTERNAL"]/*' />
    [NativeTypeName("#define ERROR_WINS_INTERNAL 4000L")]
    public const int ERROR_WINS_INTERNAL = 4000;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAN_NOT_DEL_LOCAL_WINS"]/*' />
    [NativeTypeName("#define ERROR_CAN_NOT_DEL_LOCAL_WINS 4001L")]
    public const int ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATIC_INIT"]/*' />
    [NativeTypeName("#define ERROR_STATIC_INIT 4002L")]
    public const int ERROR_STATIC_INIT = 4002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INC_BACKUP"]/*' />
    [NativeTypeName("#define ERROR_INC_BACKUP 4003L")]
    public const int ERROR_INC_BACKUP = 4003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FULL_BACKUP"]/*' />
    [NativeTypeName("#define ERROR_FULL_BACKUP 4004L")]
    public const int ERROR_FULL_BACKUP = 4004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REC_NON_EXISTENT"]/*' />
    [NativeTypeName("#define ERROR_REC_NON_EXISTENT 4005L")]
    public const int ERROR_REC_NON_EXISTENT = 4005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RPL_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_RPL_NOT_ALLOWED 4006L")]
    public const int ERROR_RPL_NOT_ALLOWED = 4006;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DHCP_ADDRESS_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_DHCP_ADDRESS_CONFLICT 4100L")]
    public const int ERROR_DHCP_ADDRESS_CONFLICT = 4100;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_GUID_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_WMI_GUID_NOT_FOUND 4200L")]
    public const int ERROR_WMI_GUID_NOT_FOUND = 4200;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_INSTANCE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_WMI_INSTANCE_NOT_FOUND 4201L")]
    public const int ERROR_WMI_INSTANCE_NOT_FOUND = 4201;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_ITEMID_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_WMI_ITEMID_NOT_FOUND 4202L")]
    public const int ERROR_WMI_ITEMID_NOT_FOUND = 4202;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_TRY_AGAIN"]/*' />
    [NativeTypeName("#define ERROR_WMI_TRY_AGAIN 4203L")]
    public const int ERROR_WMI_TRY_AGAIN = 4203;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_DP_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_WMI_DP_NOT_FOUND 4204L")]
    public const int ERROR_WMI_DP_NOT_FOUND = 4204;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_UNRESOLVED_INSTANCE_REF"]/*' />
    [NativeTypeName("#define ERROR_WMI_UNRESOLVED_INSTANCE_REF 4205L")]
    public const int ERROR_WMI_UNRESOLVED_INSTANCE_REF = 4205;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_ALREADY_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_WMI_ALREADY_ENABLED 4206L")]
    public const int ERROR_WMI_ALREADY_ENABLED = 4206;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_GUID_DISCONNECTED"]/*' />
    [NativeTypeName("#define ERROR_WMI_GUID_DISCONNECTED 4207L")]
    public const int ERROR_WMI_GUID_DISCONNECTED = 4207;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_SERVER_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_WMI_SERVER_UNAVAILABLE 4208L")]
    public const int ERROR_WMI_SERVER_UNAVAILABLE = 4208;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_DP_FAILED"]/*' />
    [NativeTypeName("#define ERROR_WMI_DP_FAILED 4209L")]
    public const int ERROR_WMI_DP_FAILED = 4209;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_INVALID_MOF"]/*' />
    [NativeTypeName("#define ERROR_WMI_INVALID_MOF 4210L")]
    public const int ERROR_WMI_INVALID_MOF = 4210;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_INVALID_REGINFO"]/*' />
    [NativeTypeName("#define ERROR_WMI_INVALID_REGINFO 4211L")]
    public const int ERROR_WMI_INVALID_REGINFO = 4211;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_ALREADY_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_WMI_ALREADY_DISABLED 4212L")]
    public const int ERROR_WMI_ALREADY_DISABLED = 4212;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_READ_ONLY"]/*' />
    [NativeTypeName("#define ERROR_WMI_READ_ONLY 4213L")]
    public const int ERROR_WMI_READ_ONLY = 4213;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WMI_SET_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_WMI_SET_FAILURE 4214L")]
    public const int ERROR_WMI_SET_FAILURE = 4214;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_APPCONTAINER"]/*' />
    [NativeTypeName("#define ERROR_NOT_APPCONTAINER 4250L")]
    public const int ERROR_NOT_APPCONTAINER = 4250;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPCONTAINER_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_APPCONTAINER_REQUIRED 4251L")]
    public const int ERROR_APPCONTAINER_REQUIRED = 4251;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_IN_APPCONTAINER"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_IN_APPCONTAINER 4252L")]
    public const int ERROR_NOT_SUPPORTED_IN_APPCONTAINER = 4252;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_PACKAGE_SID_LENGTH"]/*' />
    [NativeTypeName("#define ERROR_INVALID_PACKAGE_SID_LENGTH 4253L")]
    public const int ERROR_INVALID_PACKAGE_SID_LENGTH = 4253;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MEDIA"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MEDIA 4300L")]
    public const int ERROR_INVALID_MEDIA = 4300;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_LIBRARY"]/*' />
    [NativeTypeName("#define ERROR_INVALID_LIBRARY 4301L")]
    public const int ERROR_INVALID_LIBRARY = 4301;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_MEDIA_POOL"]/*' />
    [NativeTypeName("#define ERROR_INVALID_MEDIA_POOL 4302L")]
    public const int ERROR_INVALID_MEDIA_POOL = 4302;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DRIVE_MEDIA_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DRIVE_MEDIA_MISMATCH 4303L")]
    public const int ERROR_DRIVE_MEDIA_MISMATCH = 4303;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEDIA_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_MEDIA_OFFLINE 4304L")]
    public const int ERROR_MEDIA_OFFLINE = 4304;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LIBRARY_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_LIBRARY_OFFLINE 4305L")]
    public const int ERROR_LIBRARY_OFFLINE = 4305;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_EMPTY 4306L")]
    public const int ERROR_EMPTY = 4306;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_NOT_EMPTY 4307L")]
    public const int ERROR_NOT_EMPTY = 4307;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEDIA_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_MEDIA_UNAVAILABLE 4308L")]
    public const int ERROR_MEDIA_UNAVAILABLE = 4308;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_DISABLED 4309L")]
    public const int ERROR_RESOURCE_DISABLED = 4309;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CLEANER"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CLEANER 4310L")]
    public const int ERROR_INVALID_CLEANER = 4310;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_CLEAN"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_CLEAN 4311L")]
    public const int ERROR_UNABLE_TO_CLEAN = 4311;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OBJECT_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_OBJECT_NOT_FOUND 4312L")]
    public const int ERROR_OBJECT_NOT_FOUND = 4312;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DATABASE_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_DATABASE_FAILURE 4313L")]
    public const int ERROR_DATABASE_FAILURE = 4313;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DATABASE_FULL"]/*' />
    [NativeTypeName("#define ERROR_DATABASE_FULL 4314L")]
    public const int ERROR_DATABASE_FULL = 4314;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEDIA_INCOMPATIBLE"]/*' />
    [NativeTypeName("#define ERROR_MEDIA_INCOMPATIBLE 4315L")]
    public const int ERROR_MEDIA_INCOMPATIBLE = 4315;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_NOT_PRESENT 4316L")]
    public const int ERROR_RESOURCE_NOT_PRESENT = 4316;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_INVALID_OPERATION 4317L")]
    public const int ERROR_INVALID_OPERATION = 4317;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEDIA_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_MEDIA_NOT_AVAILABLE 4318L")]
    public const int ERROR_MEDIA_NOT_AVAILABLE = 4318;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEVICE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_DEVICE_NOT_AVAILABLE 4319L")]
    public const int ERROR_DEVICE_NOT_AVAILABLE = 4319;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REQUEST_REFUSED"]/*' />
    [NativeTypeName("#define ERROR_REQUEST_REFUSED 4320L")]
    public const int ERROR_REQUEST_REFUSED = 4320;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_DRIVE_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_INVALID_DRIVE_OBJECT 4321L")]
    public const int ERROR_INVALID_DRIVE_OBJECT = 4321;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LIBRARY_FULL"]/*' />
    [NativeTypeName("#define ERROR_LIBRARY_FULL 4322L")]
    public const int ERROR_LIBRARY_FULL = 4322;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MEDIUM_NOT_ACCESSIBLE"]/*' />
    [NativeTypeName("#define ERROR_MEDIUM_NOT_ACCESSIBLE 4323L")]
    public const int ERROR_MEDIUM_NOT_ACCESSIBLE = 4323;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_LOAD_MEDIUM"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_LOAD_MEDIUM 4324L")]
    public const int ERROR_UNABLE_TO_LOAD_MEDIUM = 4324;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_INVENTORY_DRIVE"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_INVENTORY_DRIVE 4325L")]
    public const int ERROR_UNABLE_TO_INVENTORY_DRIVE = 4325;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_INVENTORY_SLOT"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_INVENTORY_SLOT 4326L")]
    public const int ERROR_UNABLE_TO_INVENTORY_SLOT = 4326;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_INVENTORY_TRANSPORT"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_INVENTORY_TRANSPORT 4327L")]
    public const int ERROR_UNABLE_TO_INVENTORY_TRANSPORT = 4327;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSPORT_FULL"]/*' />
    [NativeTypeName("#define ERROR_TRANSPORT_FULL 4328L")]
    public const int ERROR_TRANSPORT_FULL = 4328;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CONTROLLING_IEPORT"]/*' />
    [NativeTypeName("#define ERROR_CONTROLLING_IEPORT 4329L")]
    public const int ERROR_CONTROLLING_IEPORT = 4329;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA"]/*' />
    [NativeTypeName("#define ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA 4330L")]
    public const int ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA = 4330;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLEANER_SLOT_SET"]/*' />
    [NativeTypeName("#define ERROR_CLEANER_SLOT_SET 4331L")]
    public const int ERROR_CLEANER_SLOT_SET = 4331;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLEANER_SLOT_NOT_SET"]/*' />
    [NativeTypeName("#define ERROR_CLEANER_SLOT_NOT_SET 4332L")]
    public const int ERROR_CLEANER_SLOT_NOT_SET = 4332;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLEANER_CARTRIDGE_SPENT"]/*' />
    [NativeTypeName("#define ERROR_CLEANER_CARTRIDGE_SPENT 4333L")]
    public const int ERROR_CLEANER_CARTRIDGE_SPENT = 4333;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNEXPECTED_OMID"]/*' />
    [NativeTypeName("#define ERROR_UNEXPECTED_OMID 4334L")]
    public const int ERROR_UNEXPECTED_OMID = 4334;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_DELETE_LAST_ITEM"]/*' />
    [NativeTypeName("#define ERROR_CANT_DELETE_LAST_ITEM 4335L")]
    public const int ERROR_CANT_DELETE_LAST_ITEM = 4335;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MESSAGE_EXCEEDS_MAX_SIZE"]/*' />
    [NativeTypeName("#define ERROR_MESSAGE_EXCEEDS_MAX_SIZE 4336L")]
    public const int ERROR_MESSAGE_EXCEEDS_MAX_SIZE = 4336;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_CONTAINS_SYS_FILES"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_CONTAINS_SYS_FILES 4337L")]
    public const int ERROR_VOLUME_CONTAINS_SYS_FILES = 4337;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INDIGENOUS_TYPE"]/*' />
    [NativeTypeName("#define ERROR_INDIGENOUS_TYPE 4338L")]
    public const int ERROR_INDIGENOUS_TYPE = 4338;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SUPPORTING_DRIVES"]/*' />
    [NativeTypeName("#define ERROR_NO_SUPPORTING_DRIVES 4339L")]
    public const int ERROR_NO_SUPPORTING_DRIVES = 4339;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLEANER_CARTRIDGE_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_CLEANER_CARTRIDGE_INSTALLED 4340L")]
    public const int ERROR_CLEANER_CARTRIDGE_INSTALLED = 4340;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IEPORT_FULL"]/*' />
    [NativeTypeName("#define ERROR_IEPORT_FULL 4341L")]
    public const int ERROR_IEPORT_FULL = 4341;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_FILE_OFFLINE 4350L")]
    public const int ERROR_FILE_OFFLINE = 4350;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOTE_STORAGE_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_REMOTE_STORAGE_NOT_ACTIVE 4351L")]
    public const int ERROR_REMOTE_STORAGE_NOT_ACTIVE = 4351;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOTE_STORAGE_MEDIA_ERROR"]/*' />
    [NativeTypeName("#define ERROR_REMOTE_STORAGE_MEDIA_ERROR 4352L")]
    public const int ERROR_REMOTE_STORAGE_MEDIA_ERROR = 4352;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_A_REPARSE_POINT"]/*' />
    [NativeTypeName("#define ERROR_NOT_A_REPARSE_POINT 4390L")]
    public const int ERROR_NOT_A_REPARSE_POINT = 4390;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REPARSE_ATTRIBUTE_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_REPARSE_ATTRIBUTE_CONFLICT 4391L")]
    public const int ERROR_REPARSE_ATTRIBUTE_CONFLICT = 4391;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_REPARSE_DATA"]/*' />
    [NativeTypeName("#define ERROR_INVALID_REPARSE_DATA 4392L")]
    public const int ERROR_INVALID_REPARSE_DATA = 4392;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REPARSE_TAG_INVALID"]/*' />
    [NativeTypeName("#define ERROR_REPARSE_TAG_INVALID 4393L")]
    public const int ERROR_REPARSE_TAG_INVALID = 4393;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REPARSE_TAG_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_REPARSE_TAG_MISMATCH 4394L")]
    public const int ERROR_REPARSE_TAG_MISMATCH = 4394;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REPARSE_POINT_ENCOUNTERED"]/*' />
    [NativeTypeName("#define ERROR_REPARSE_POINT_ENCOUNTERED 4395L")]
    public const int ERROR_REPARSE_POINT_ENCOUNTERED = 4395;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APP_DATA_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_APP_DATA_NOT_FOUND 4400L")]
    public const int ERROR_APP_DATA_NOT_FOUND = 4400;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APP_DATA_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_APP_DATA_EXPIRED 4401L")]
    public const int ERROR_APP_DATA_EXPIRED = 4401;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APP_DATA_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_APP_DATA_CORRUPT 4402L")]
    public const int ERROR_APP_DATA_CORRUPT = 4402;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APP_DATA_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_APP_DATA_LIMIT_EXCEEDED 4403L")]
    public const int ERROR_APP_DATA_LIMIT_EXCEEDED = 4403;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APP_DATA_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_APP_DATA_REBOOT_REQUIRED 4404L")]
    public const int ERROR_APP_DATA_REBOOT_REQUIRED = 4404;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_ROLLBACK_DETECTED 4420L")]
    public const int ERROR_SECUREBOOT_ROLLBACK_DETECTED = 4420;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_POLICY_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_POLICY_VIOLATION 4421L")]
    public const int ERROR_SECUREBOOT_POLICY_VIOLATION = 4421;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_INVALID_POLICY"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_INVALID_POLICY 4422L")]
    public const int ERROR_SECUREBOOT_INVALID_POLICY = 4422;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND 4423L")]
    public const int ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND = 4423;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_POLICY_NOT_SIGNED"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_POLICY_NOT_SIGNED 4424L")]
    public const int ERROR_SECUREBOOT_POLICY_NOT_SIGNED = 4424;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_NOT_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_NOT_ENABLED 4425L")]
    public const int ERROR_SECUREBOOT_NOT_ENABLED = 4425;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_FILE_REPLACED"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_FILE_REPLACED 4426L")]
    public const int ERROR_SECUREBOOT_FILE_REPLACED = 4426;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_POLICY_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_POLICY_NOT_AUTHORIZED 4427L")]
    public const int ERROR_SECUREBOOT_POLICY_NOT_AUTHORIZED = 4427;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_POLICY_UNKNOWN"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_POLICY_UNKNOWN 4428L")]
    public const int ERROR_SECUREBOOT_POLICY_UNKNOWN = 4428;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION 4429L")]
    public const int ERROR_SECUREBOOT_POLICY_MISSING_ANTIROLLBACKVERSION = 4429;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_PLATFORM_ID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_PLATFORM_ID_MISMATCH 4430L")]
    public const int ERROR_SECUREBOOT_PLATFORM_ID_MISMATCH = 4430;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_POLICY_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_POLICY_ROLLBACK_DETECTED 4431L")]
    public const int ERROR_SECUREBOOT_POLICY_ROLLBACK_DETECTED = 4431;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_POLICY_UPGRADE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_POLICY_UPGRADE_MISMATCH 4432L")]
    public const int ERROR_SECUREBOOT_POLICY_UPGRADE_MISMATCH = 4432;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING 4433L")]
    public const int ERROR_SECUREBOOT_REQUIRED_POLICY_FILE_MISSING = 4433;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_NOT_BASE_POLICY"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_NOT_BASE_POLICY 4434L")]
    public const int ERROR_SECUREBOOT_NOT_BASE_POLICY = 4434;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY"]/*' />
    [NativeTypeName("#define ERROR_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY 4435L")]
    public const int ERROR_SECUREBOOT_NOT_SUPPLEMENTAL_POLICY = 4435;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED 4440L")]
    public const int ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED = 4440;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED 4441L")]
    public const int ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED = 4441;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED 4442L")]
    public const int ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED = 4442;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED 4443L")]
    public const int ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED = 4443;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALREADY_HAS_STREAM_ID"]/*' />
    [NativeTypeName("#define ERROR_ALREADY_HAS_STREAM_ID 4444L")]
    public const int ERROR_ALREADY_HAS_STREAM_ID = 4444;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMR_GARBAGE_COLLECTION_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_SMR_GARBAGE_COLLECTION_REQUIRED 4445L")]
    public const int ERROR_SMR_GARBAGE_COLLECTION_REQUIRED = 4445;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WOF_WIM_HEADER_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_WOF_WIM_HEADER_CORRUPT 4446L")]
    public const int ERROR_WOF_WIM_HEADER_CORRUPT = 4446;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WOF_WIM_RESOURCE_TABLE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_WOF_WIM_RESOURCE_TABLE_CORRUPT 4447L")]
    public const int ERROR_WOF_WIM_RESOURCE_TABLE_CORRUPT = 4447;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WOF_FILE_RESOURCE_TABLE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_WOF_FILE_RESOURCE_TABLE_CORRUPT 4448L")]
    public const int ERROR_WOF_FILE_RESOURCE_TABLE_CORRUPT = 4448;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OBJECT_IS_IMMUTABLE"]/*' />
    [NativeTypeName("#define ERROR_OBJECT_IS_IMMUTABLE 4449L")]
    public const int ERROR_OBJECT_IS_IMMUTABLE = 4449;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_NOT_SIS_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_NOT_SIS_ENABLED 4500L")]
    public const int ERROR_VOLUME_NOT_SIS_ENABLED = 4500;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_ROLLBACK_DETECTED 4550L")]
    public const int ERROR_SYSTEM_INTEGRITY_ROLLBACK_DETECTED = 4550;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_POLICY_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_POLICY_VIOLATION 4551L")]
    public const int ERROR_SYSTEM_INTEGRITY_POLICY_VIOLATION = 4551;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_INVALID_POLICY"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_INVALID_POLICY 4552L")]
    public const int ERROR_SYSTEM_INTEGRITY_INVALID_POLICY = 4552;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED 4553L")]
    public const int ERROR_SYSTEM_INTEGRITY_POLICY_NOT_SIGNED = 4553;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_TOO_MANY_POLICIES"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_TOO_MANY_POLICIES 4554L")]
    public const int ERROR_SYSTEM_INTEGRITY_TOO_MANY_POLICIES = 4554;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_SUPPLEMENTAL_POLICY_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_SUPPLEMENTAL_POLICY_NOT_AUTHORIZED 4555L")]
    public const int ERROR_SYSTEM_INTEGRITY_SUPPLEMENTAL_POLICY_NOT_AUTHORIZED = 4555;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_REPUTATION_MALICIOUS"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_REPUTATION_MALICIOUS 4556L")]
    public const int ERROR_SYSTEM_INTEGRITY_REPUTATION_MALICIOUS = 4556;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_REPUTATION_PUA"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_REPUTATION_PUA 4557L")]
    public const int ERROR_SYSTEM_INTEGRITY_REPUTATION_PUA = 4557;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_REPUTATION_DANGEROUS_EXT"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_REPUTATION_DANGEROUS_EXT 4558L")]
    public const int ERROR_SYSTEM_INTEGRITY_REPUTATION_DANGEROUS_EXT = 4558;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_REPUTATION_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_REPUTATION_OFFLINE 4559L")]
    public const int ERROR_SYSTEM_INTEGRITY_REPUTATION_OFFLINE = 4559;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSM_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define ERROR_VSM_NOT_INITIALIZED 4560L")]
    public const int ERROR_VSM_NOT_INITIALIZED = 4560;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSM_DMA_PROTECTION_NOT_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_VSM_DMA_PROTECTION_NOT_IN_USE 4561L")]
    public const int ERROR_VSM_DMA_PROTECTION_NOT_IN_USE = 4561;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSM_KEY_CI_POLICY_ROLLBACK_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_VSM_KEY_CI_POLICY_ROLLBACK_DETECTED 4562L")]
    public const int ERROR_VSM_KEY_CI_POLICY_ROLLBACK_DETECTED = 4562;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSMIDK_KEYGEN_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_VSMIDK_KEYGEN_FAILURE 4563L")]
    public const int ERROR_VSMIDK_KEYGEN_FAILURE = 4563;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSMIDK_EXPORT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_VSMIDK_EXPORT_FAILURE 4564L")]
    public const int ERROR_VSMIDK_EXPORT_FAILURE = 4564;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSMIDK_MODULUS_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VSMIDK_MODULUS_MISMATCH 4565L")]
    public const int ERROR_VSMIDK_MODULUS_MISMATCH = 4565;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSM_FW_MEASUREMENTS_SEAL_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_VSM_FW_MEASUREMENTS_SEAL_FAILURE 4566L")]
    public const int ERROR_VSM_FW_MEASUREMENTS_SEAL_FAILURE = 4566;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PLATFORM_MANIFEST_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define ERROR_PLATFORM_MANIFEST_NOT_AUTHORIZED 4570L")]
    public const int ERROR_PLATFORM_MANIFEST_NOT_AUTHORIZED = 4570;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PLATFORM_MANIFEST_INVALID"]/*' />
    [NativeTypeName("#define ERROR_PLATFORM_MANIFEST_INVALID 4571L")]
    public const int ERROR_PLATFORM_MANIFEST_INVALID = 4571;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define ERROR_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED 4572L")]
    public const int ERROR_PLATFORM_MANIFEST_FILE_NOT_AUTHORIZED = 4572;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define ERROR_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED 4573L")]
    public const int ERROR_PLATFORM_MANIFEST_CATALOG_NOT_AUTHORIZED = 4573;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND 4574L")]
    public const int ERROR_PLATFORM_MANIFEST_BINARY_ID_NOT_FOUND = 4574;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PLATFORM_MANIFEST_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_PLATFORM_MANIFEST_NOT_ACTIVE 4575L")]
    public const int ERROR_PLATFORM_MANIFEST_NOT_ACTIVE = 4575;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PLATFORM_MANIFEST_NOT_SIGNED"]/*' />
    [NativeTypeName("#define ERROR_PLATFORM_MANIFEST_NOT_SIGNED 4576L")]
    public const int ERROR_PLATFORM_MANIFEST_NOT_SIGNED = 4576;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_REPUTATION_UNFRIENDLY_FILE"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_REPUTATION_UNFRIENDLY_FILE 4580L")]
    public const int ERROR_SYSTEM_INTEGRITY_REPUTATION_UNFRIENDLY_FILE = 4580;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_REPUTATION_UNATTAINABLE"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_REPUTATION_UNATTAINABLE 4581L")]
    public const int ERROR_SYSTEM_INTEGRITY_REPUTATION_UNATTAINABLE = 4581;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_REPUTATION_EXPLICIT_DENY_FILE"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_REPUTATION_EXPLICIT_DENY_FILE 4582L")]
    public const int ERROR_SYSTEM_INTEGRITY_REPUTATION_EXPLICIT_DENY_FILE = 4582;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_INTEGRITY_WHQL_NOT_SATISFIED"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_INTEGRITY_WHQL_NOT_SATISFIED 4583L")]
    public const int ERROR_SYSTEM_INTEGRITY_WHQL_NOT_SATISFIED = 4583;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPENDENT_RESOURCE_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DEPENDENT_RESOURCE_EXISTS 5001L")]
    public const int ERROR_DEPENDENT_RESOURCE_EXISTS = 5001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPENDENCY_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DEPENDENCY_NOT_FOUND 5002L")]
    public const int ERROR_DEPENDENCY_NOT_FOUND = 5002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPENDENCY_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DEPENDENCY_ALREADY_EXISTS 5003L")]
    public const int ERROR_DEPENDENCY_ALREADY_EXISTS = 5003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_NOT_ONLINE"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_NOT_ONLINE 5004L")]
    public const int ERROR_RESOURCE_NOT_ONLINE = 5004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOST_NODE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_HOST_NODE_NOT_AVAILABLE 5005L")]
    public const int ERROR_HOST_NODE_NOT_AVAILABLE = 5005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_NOT_AVAILABLE 5006L")]
    public const int ERROR_RESOURCE_NOT_AVAILABLE = 5006;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_NOT_FOUND 5007L")]
    public const int ERROR_RESOURCE_NOT_FOUND = 5007;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHUTDOWN_CLUSTER"]/*' />
    [NativeTypeName("#define ERROR_SHUTDOWN_CLUSTER 5008L")]
    public const int ERROR_SHUTDOWN_CLUSTER = 5008;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_EVICT_ACTIVE_NODE"]/*' />
    [NativeTypeName("#define ERROR_CANT_EVICT_ACTIVE_NODE 5009L")]
    public const int ERROR_CANT_EVICT_ACTIVE_NODE = 5009;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OBJECT_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_OBJECT_ALREADY_EXISTS 5010L")]
    public const int ERROR_OBJECT_ALREADY_EXISTS = 5010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OBJECT_IN_LIST"]/*' />
    [NativeTypeName("#define ERROR_OBJECT_IN_LIST 5011L")]
    public const int ERROR_OBJECT_IN_LIST = 5011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GROUP_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_GROUP_NOT_AVAILABLE 5012L")]
    public const int ERROR_GROUP_NOT_AVAILABLE = 5012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GROUP_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_GROUP_NOT_FOUND 5013L")]
    public const int ERROR_GROUP_NOT_FOUND = 5013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GROUP_NOT_ONLINE"]/*' />
    [NativeTypeName("#define ERROR_GROUP_NOT_ONLINE 5014L")]
    public const int ERROR_GROUP_NOT_ONLINE = 5014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOST_NODE_NOT_RESOURCE_OWNER"]/*' />
    [NativeTypeName("#define ERROR_HOST_NODE_NOT_RESOURCE_OWNER 5015L")]
    public const int ERROR_HOST_NODE_NOT_RESOURCE_OWNER = 5015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HOST_NODE_NOT_GROUP_OWNER"]/*' />
    [NativeTypeName("#define ERROR_HOST_NODE_NOT_GROUP_OWNER 5016L")]
    public const int ERROR_HOST_NODE_NOT_GROUP_OWNER = 5016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESMON_CREATE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_RESMON_CREATE_FAILED 5017L")]
    public const int ERROR_RESMON_CREATE_FAILED = 5017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESMON_ONLINE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_RESMON_ONLINE_FAILED 5018L")]
    public const int ERROR_RESMON_ONLINE_FAILED = 5018;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_ONLINE"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_ONLINE 5019L")]
    public const int ERROR_RESOURCE_ONLINE = 5019;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUORUM_RESOURCE"]/*' />
    [NativeTypeName("#define ERROR_QUORUM_RESOURCE 5020L")]
    public const int ERROR_QUORUM_RESOURCE = 5020;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_QUORUM_CAPABLE"]/*' />
    [NativeTypeName("#define ERROR_NOT_QUORUM_CAPABLE 5021L")]
    public const int ERROR_NOT_QUORUM_CAPABLE = 5021;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_SHUTTING_DOWN"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_SHUTTING_DOWN 5022L")]
    public const int ERROR_CLUSTER_SHUTTING_DOWN = 5022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_STATE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_STATE 5023L")]
    public const int ERROR_INVALID_STATE = 5023;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_PROPERTIES_STORED"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_PROPERTIES_STORED 5024L")]
    public const int ERROR_RESOURCE_PROPERTIES_STORED = 5024;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_QUORUM_CLASS"]/*' />
    [NativeTypeName("#define ERROR_NOT_QUORUM_CLASS 5025L")]
    public const int ERROR_NOT_QUORUM_CLASS = 5025;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CORE_RESOURCE"]/*' />
    [NativeTypeName("#define ERROR_CORE_RESOURCE 5026L")]
    public const int ERROR_CORE_RESOURCE = 5026;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUORUM_RESOURCE_ONLINE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_QUORUM_RESOURCE_ONLINE_FAILED 5027L")]
    public const int ERROR_QUORUM_RESOURCE_ONLINE_FAILED = 5027;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUORUMLOG_OPEN_FAILED"]/*' />
    [NativeTypeName("#define ERROR_QUORUMLOG_OPEN_FAILED 5028L")]
    public const int ERROR_QUORUMLOG_OPEN_FAILED = 5028;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTERLOG_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_CLUSTERLOG_CORRUPT 5029L")]
    public const int ERROR_CLUSTERLOG_CORRUPT = 5029;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE 5030L")]
    public const int ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE = 5030;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE 5031L")]
    public const int ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE = 5031;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND 5032L")]
    public const int ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND = 5032;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE 5033L")]
    public const int ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE = 5033;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUORUM_OWNER_ALIVE"]/*' />
    [NativeTypeName("#define ERROR_QUORUM_OWNER_ALIVE 5034L")]
    public const int ERROR_QUORUM_OWNER_ALIVE = 5034;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NETWORK_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_NETWORK_NOT_AVAILABLE 5035L")]
    public const int ERROR_NETWORK_NOT_AVAILABLE = 5035;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NODE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_NODE_NOT_AVAILABLE 5036L")]
    public const int ERROR_NODE_NOT_AVAILABLE = 5036;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALL_NODES_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_ALL_NODES_NOT_AVAILABLE 5037L")]
    public const int ERROR_ALL_NODES_NOT_AVAILABLE = 5037;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_FAILED 5038L")]
    public const int ERROR_RESOURCE_FAILED = 5038;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_NODE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_NODE 5039L")]
    public const int ERROR_CLUSTER_INVALID_NODE = 5039;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_EXISTS 5040L")]
    public const int ERROR_CLUSTER_NODE_EXISTS = 5040;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_JOIN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_JOIN_IN_PROGRESS 5041L")]
    public const int ERROR_CLUSTER_JOIN_IN_PROGRESS = 5041;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_NOT_FOUND 5042L")]
    public const int ERROR_CLUSTER_NODE_NOT_FOUND = 5042;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND 5043L")]
    public const int ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND = 5043;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETWORK_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETWORK_EXISTS 5044L")]
    public const int ERROR_CLUSTER_NETWORK_EXISTS = 5044;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETWORK_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETWORK_NOT_FOUND 5045L")]
    public const int ERROR_CLUSTER_NETWORK_NOT_FOUND = 5045;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETINTERFACE_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETINTERFACE_EXISTS 5046L")]
    public const int ERROR_CLUSTER_NETINTERFACE_EXISTS = 5046;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETINTERFACE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETINTERFACE_NOT_FOUND 5047L")]
    public const int ERROR_CLUSTER_NETINTERFACE_NOT_FOUND = 5047;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_REQUEST 5048L")]
    public const int ERROR_CLUSTER_INVALID_REQUEST = 5048;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_NETWORK_PROVIDER"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_NETWORK_PROVIDER 5049L")]
    public const int ERROR_CLUSTER_INVALID_NETWORK_PROVIDER = 5049;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_DOWN"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_DOWN 5050L")]
    public const int ERROR_CLUSTER_NODE_DOWN = 5050;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_UNREACHABLE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_UNREACHABLE 5051L")]
    public const int ERROR_CLUSTER_NODE_UNREACHABLE = 5051;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_NOT_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_NOT_MEMBER 5052L")]
    public const int ERROR_CLUSTER_NODE_NOT_MEMBER = 5052;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS 5053L")]
    public const int ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS = 5053;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_NETWORK"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_NETWORK 5054L")]
    public const int ERROR_CLUSTER_INVALID_NETWORK = 5054;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_UP"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_UP 5056L")]
    public const int ERROR_CLUSTER_NODE_UP = 5056;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_IPADDR_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_IPADDR_IN_USE 5057L")]
    public const int ERROR_CLUSTER_IPADDR_IN_USE = 5057;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_NOT_PAUSED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_NOT_PAUSED 5058L")]
    public const int ERROR_CLUSTER_NODE_NOT_PAUSED = 5058;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NO_SECURITY_CONTEXT"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NO_SECURITY_CONTEXT 5059L")]
    public const int ERROR_CLUSTER_NO_SECURITY_CONTEXT = 5059;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETWORK_NOT_INTERNAL"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETWORK_NOT_INTERNAL 5060L")]
    public const int ERROR_CLUSTER_NETWORK_NOT_INTERNAL = 5060;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_ALREADY_UP"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_ALREADY_UP 5061L")]
    public const int ERROR_CLUSTER_NODE_ALREADY_UP = 5061;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_ALREADY_DOWN"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_ALREADY_DOWN 5062L")]
    public const int ERROR_CLUSTER_NODE_ALREADY_DOWN = 5062;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETWORK_ALREADY_ONLINE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETWORK_ALREADY_ONLINE 5063L")]
    public const int ERROR_CLUSTER_NETWORK_ALREADY_ONLINE = 5063;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE 5064L")]
    public const int ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE = 5064;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_ALREADY_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_ALREADY_MEMBER 5065L")]
    public const int ERROR_CLUSTER_NODE_ALREADY_MEMBER = 5065;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_LAST_INTERNAL_NETWORK"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_LAST_INTERNAL_NETWORK 5066L")]
    public const int ERROR_CLUSTER_LAST_INTERNAL_NETWORK = 5066;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS 5067L")]
    public const int ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS = 5067;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_OPERATION_ON_QUORUM"]/*' />
    [NativeTypeName("#define ERROR_INVALID_OPERATION_ON_QUORUM 5068L")]
    public const int ERROR_INVALID_OPERATION_ON_QUORUM = 5068;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPENDENCY_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_DEPENDENCY_NOT_ALLOWED 5069L")]
    public const int ERROR_DEPENDENCY_NOT_ALLOWED = 5069;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_PAUSED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_PAUSED 5070L")]
    public const int ERROR_CLUSTER_NODE_PAUSED = 5070;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NODE_CANT_HOST_RESOURCE"]/*' />
    [NativeTypeName("#define ERROR_NODE_CANT_HOST_RESOURCE 5071L")]
    public const int ERROR_NODE_CANT_HOST_RESOURCE = 5071;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_NOT_READY 5072L")]
    public const int ERROR_CLUSTER_NODE_NOT_READY = 5072;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_SHUTTING_DOWN"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_SHUTTING_DOWN 5073L")]
    public const int ERROR_CLUSTER_NODE_SHUTTING_DOWN = 5073;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_JOIN_ABORTED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_JOIN_ABORTED 5074L")]
    public const int ERROR_CLUSTER_JOIN_ABORTED = 5074;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INCOMPATIBLE_VERSIONS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INCOMPATIBLE_VERSIONS 5075L")]
    public const int ERROR_CLUSTER_INCOMPATIBLE_VERSIONS = 5075;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED 5076L")]
    public const int ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED = 5076;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED 5077L")]
    public const int ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED = 5077;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND 5078L")]
    public const int ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND = 5078;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED 5079L")]
    public const int ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED = 5079;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESNAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESNAME_NOT_FOUND 5080L")]
    public const int ERROR_CLUSTER_RESNAME_NOT_FOUND = 5080;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED 5081L")]
    public const int ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED = 5081;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST 5082L")]
    public const int ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST = 5082;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_DATABASE_SEQMISMATCH"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_DATABASE_SEQMISMATCH 5083L")]
    public const int ERROR_CLUSTER_DATABASE_SEQMISMATCH = 5083;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESMON_INVALID_STATE"]/*' />
    [NativeTypeName("#define ERROR_RESMON_INVALID_STATE 5084L")]
    public const int ERROR_RESMON_INVALID_STATE = 5084;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_GUM_NOT_LOCKER"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_GUM_NOT_LOCKER 5085L")]
    public const int ERROR_CLUSTER_GUM_NOT_LOCKER = 5085;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUORUM_DISK_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_QUORUM_DISK_NOT_FOUND 5086L")]
    public const int ERROR_QUORUM_DISK_NOT_FOUND = 5086;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DATABASE_BACKUP_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_DATABASE_BACKUP_CORRUPT 5087L")]
    public const int ERROR_DATABASE_BACKUP_CORRUPT = 5087;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT 5088L")]
    public const int ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT = 5088;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_PROPERTY_UNCHANGEABLE"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_PROPERTY_UNCHANGEABLE 5089L")]
    public const int ERROR_RESOURCE_PROPERTY_UNCHANGEABLE = 5089;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_ADMIN_ACCESS_POINT"]/*' />
    [NativeTypeName("#define ERROR_NO_ADMIN_ACCESS_POINT 5090L")]
    public const int ERROR_NO_ADMIN_ACCESS_POINT = 5090;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE 5890L")]
    public const int ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE = 5890;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_QUORUMLOG_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_QUORUMLOG_NOT_FOUND 5891L")]
    public const int ERROR_CLUSTER_QUORUMLOG_NOT_FOUND = 5891;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_MEMBERSHIP_HALT"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_MEMBERSHIP_HALT 5892L")]
    public const int ERROR_CLUSTER_MEMBERSHIP_HALT = 5892;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INSTANCE_ID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INSTANCE_ID_MISMATCH 5893L")]
    public const int ERROR_CLUSTER_INSTANCE_ID_MISMATCH = 5893;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP 5894L")]
    public const int ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP = 5894;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH 5895L")]
    public const int ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH = 5895;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP 5896L")]
    public const int ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP = 5896;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_PARAMETER_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_PARAMETER_MISMATCH 5897L")]
    public const int ERROR_CLUSTER_PARAMETER_MISMATCH = 5897;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NODE_CANNOT_BE_CLUSTERED"]/*' />
    [NativeTypeName("#define ERROR_NODE_CANNOT_BE_CLUSTERED 5898L")]
    public const int ERROR_NODE_CANNOT_BE_CLUSTERED = 5898;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_WRONG_OS_VERSION"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_WRONG_OS_VERSION 5899L")]
    public const int ERROR_CLUSTER_WRONG_OS_VERSION = 5899;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME 5900L")]
    public const int ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME = 5900;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSCFG_ALREADY_COMMITTED"]/*' />
    [NativeTypeName("#define ERROR_CLUSCFG_ALREADY_COMMITTED 5901L")]
    public const int ERROR_CLUSCFG_ALREADY_COMMITTED = 5901;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSCFG_ROLLBACK_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CLUSCFG_ROLLBACK_FAILED 5902L")]
    public const int ERROR_CLUSCFG_ROLLBACK_FAILED = 5902;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT 5903L")]
    public const int ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT = 5903;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_OLD_VERSION"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_OLD_VERSION 5904L")]
    public const int ERROR_CLUSTER_OLD_VERSION = 5904;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME 5905L")]
    public const int ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME = 5905;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NO_NET_ADAPTERS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NO_NET_ADAPTERS 5906L")]
    public const int ERROR_CLUSTER_NO_NET_ADAPTERS = 5906;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_POISONED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_POISONED 5907L")]
    public const int ERROR_CLUSTER_POISONED = 5907;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_GROUP_MOVING"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_GROUP_MOVING 5908L")]
    public const int ERROR_CLUSTER_GROUP_MOVING = 5908;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_TYPE_BUSY"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_TYPE_BUSY 5909L")]
    public const int ERROR_CLUSTER_RESOURCE_TYPE_BUSY = 5909;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_CALL_TIMED_OUT"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_CALL_TIMED_OUT 5910L")]
    public const int ERROR_RESOURCE_CALL_TIMED_OUT = 5910;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_CLUSTER_IPV6_ADDRESS"]/*' />
    [NativeTypeName("#define ERROR_INVALID_CLUSTER_IPV6_ADDRESS 5911L")]
    public const int ERROR_INVALID_CLUSTER_IPV6_ADDRESS = 5911;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION 5912L")]
    public const int ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION = 5912;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS 5913L")]
    public const int ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS = 5913;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_PARTIAL_SEND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_PARTIAL_SEND 5914L")]
    public const int ERROR_CLUSTER_PARTIAL_SEND = 5914;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION 5915L")]
    public const int ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION = 5915;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_STRING_TERMINATION"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_STRING_TERMINATION 5916L")]
    public const int ERROR_CLUSTER_INVALID_STRING_TERMINATION = 5916;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_STRING_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_STRING_FORMAT 5917L")]
    public const int ERROR_CLUSTER_INVALID_STRING_FORMAT = 5917;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS 5918L")]
    public const int ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS = 5918;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS 5919L")]
    public const int ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS = 5919;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NULL_DATA"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NULL_DATA 5920L")]
    public const int ERROR_CLUSTER_NULL_DATA = 5920;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_PARTIAL_READ"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_PARTIAL_READ 5921L")]
    public const int ERROR_CLUSTER_PARTIAL_READ = 5921;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_PARTIAL_WRITE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_PARTIAL_WRITE 5922L")]
    public const int ERROR_CLUSTER_PARTIAL_WRITE = 5922;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_CANT_DESERIALIZE_DATA"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_CANT_DESERIALIZE_DATA 5923L")]
    public const int ERROR_CLUSTER_CANT_DESERIALIZE_DATA = 5923;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT 5924L")]
    public const int ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT = 5924;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NO_QUORUM"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NO_QUORUM 5925L")]
    public const int ERROR_CLUSTER_NO_QUORUM = 5925;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_IPV6_NETWORK"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_IPV6_NETWORK 5926L")]
    public const int ERROR_CLUSTER_INVALID_IPV6_NETWORK = 5926;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK 5927L")]
    public const int ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK = 5927;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP"]/*' />
    [NativeTypeName("#define ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP 5928L")]
    public const int ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP = 5928;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPENDENCY_TREE_TOO_COMPLEX"]/*' />
    [NativeTypeName("#define ERROR_DEPENDENCY_TREE_TOO_COMPLEX 5929L")]
    public const int ERROR_DEPENDENCY_TREE_TOO_COMPLEX = 5929;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXCEPTION_IN_RESOURCE_CALL"]/*' />
    [NativeTypeName("#define ERROR_EXCEPTION_IN_RESOURCE_CALL 5930L")]
    public const int ERROR_EXCEPTION_IN_RESOURCE_CALL = 5930;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RHS_FAILED_INITIALIZATION"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RHS_FAILED_INITIALIZATION 5931L")]
    public const int ERROR_CLUSTER_RHS_FAILED_INITIALIZATION = 5931;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NOT_INSTALLED 5932L")]
    public const int ERROR_CLUSTER_NOT_INSTALLED = 5932;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE 5933L")]
    public const int ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE = 5933;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_MAX_NODES_IN_CLUSTER"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_MAX_NODES_IN_CLUSTER 5934L")]
    public const int ERROR_CLUSTER_MAX_NODES_IN_CLUSTER = 5934;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_TOO_MANY_NODES"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_TOO_MANY_NODES 5935L")]
    public const int ERROR_CLUSTER_TOO_MANY_NODES = 5935;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_OBJECT_ALREADY_USED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_OBJECT_ALREADY_USED 5936L")]
    public const int ERROR_CLUSTER_OBJECT_ALREADY_USED = 5936;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NONCORE_GROUPS_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NONCORE_GROUPS_FOUND 5937L")]
    public const int ERROR_NONCORE_GROUPS_FOUND = 5937;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_SHARE_RESOURCE_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_FILE_SHARE_RESOURCE_CONFLICT 5938L")]
    public const int ERROR_FILE_SHARE_RESOURCE_CONFLICT = 5938;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_EVICT_INVALID_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_EVICT_INVALID_REQUEST 5939L")]
    public const int ERROR_CLUSTER_EVICT_INVALID_REQUEST = 5939;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_SINGLETON_RESOURCE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_SINGLETON_RESOURCE 5940L")]
    public const int ERROR_CLUSTER_SINGLETON_RESOURCE = 5940;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE 5941L")]
    public const int ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE = 5941;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED 5942L")]
    public const int ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED = 5942;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR 5943L")]
    public const int ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR = 5943;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_GROUP_BUSY"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_GROUP_BUSY 5944L")]
    public const int ERROR_CLUSTER_GROUP_BUSY = 5944;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NOT_SHARED_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NOT_SHARED_VOLUME 5945L")]
    public const int ERROR_CLUSTER_NOT_SHARED_VOLUME = 5945;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR 5946L")]
    public const int ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR = 5946;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_SHARED_VOLUMES_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_SHARED_VOLUMES_IN_USE 5947L")]
    public const int ERROR_CLUSTER_SHARED_VOLUMES_IN_USE = 5947;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_USE_SHARED_VOLUMES_API"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_USE_SHARED_VOLUMES_API 5948L")]
    public const int ERROR_CLUSTER_USE_SHARED_VOLUMES_API = 5948;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_BACKUP_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_BACKUP_IN_PROGRESS 5949L")]
    public const int ERROR_CLUSTER_BACKUP_IN_PROGRESS = 5949;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NON_CSV_PATH"]/*' />
    [NativeTypeName("#define ERROR_NON_CSV_PATH 5950L")]
    public const int ERROR_NON_CSV_PATH = 5950;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CSV_VOLUME_NOT_LOCAL"]/*' />
    [NativeTypeName("#define ERROR_CSV_VOLUME_NOT_LOCAL 5951L")]
    public const int ERROR_CSV_VOLUME_NOT_LOCAL = 5951;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_WATCHDOG_TERMINATING"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_WATCHDOG_TERMINATING 5952L")]
    public const int ERROR_CLUSTER_WATCHDOG_TERMINATING = 5952;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES 5953L")]
    public const int ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES = 5953;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_NODE_WEIGHT"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_NODE_WEIGHT 5954L")]
    public const int ERROR_CLUSTER_INVALID_NODE_WEIGHT = 5954;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_VETOED_CALL"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_VETOED_CALL 5955L")]
    public const int ERROR_CLUSTER_RESOURCE_VETOED_CALL = 5955;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESMON_SYSTEM_RESOURCES_LACKING"]/*' />
    [NativeTypeName("#define ERROR_RESMON_SYSTEM_RESOURCES_LACKING 5956L")]
    public const int ERROR_RESMON_SYSTEM_RESOURCES_LACKING = 5956;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION 5957L")]
    public const int ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION = 5957;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE 5958L")]
    public const int ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE = 5958;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_GROUP_QUEUED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_GROUP_QUEUED 5959L")]
    public const int ERROR_CLUSTER_GROUP_QUEUED = 5959;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_LOCKED_STATUS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_LOCKED_STATUS 5960L")]
    public const int ERROR_CLUSTER_RESOURCE_LOCKED_STATUS = 5960;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED 5961L")]
    public const int ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED = 5961;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS 5962L")]
    public const int ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS = 5962;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_DISK_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_DISK_NOT_CONNECTED 5963L")]
    public const int ERROR_CLUSTER_DISK_NOT_CONNECTED = 5963;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DISK_NOT_CSV_CAPABLE"]/*' />
    [NativeTypeName("#define ERROR_DISK_NOT_CSV_CAPABLE 5964L")]
    public const int ERROR_DISK_NOT_CSV_CAPABLE = 5964;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE 5965L")]
    public const int ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE = 5965;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED 5966L")]
    public const int ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED = 5966;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED 5967L")]
    public const int ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED = 5967;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES 5968L")]
    public const int ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES = 5968;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES 5969L")]
    public const int ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES = 5969;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE 5970L")]
    public const int ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE = 5970;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_AFFINITY_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_AFFINITY_CONFLICT 5971L")]
    public const int ERROR_CLUSTER_AFFINITY_CONFLICT = 5971;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE 5972L")]
    public const int ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE = 5972;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_UPGRADE_INCOMPATIBLE_VERSIONS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_UPGRADE_INCOMPATIBLE_VERSIONS 5973L")]
    public const int ERROR_CLUSTER_UPGRADE_INCOMPATIBLE_VERSIONS = 5973;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_UPGRADE_FIX_QUORUM_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_UPGRADE_FIX_QUORUM_NOT_SUPPORTED 5974L")]
    public const int ERROR_CLUSTER_UPGRADE_FIX_QUORUM_NOT_SUPPORTED = 5974;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_UPGRADE_RESTART_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_UPGRADE_RESTART_REQUIRED 5975L")]
    public const int ERROR_CLUSTER_UPGRADE_RESTART_REQUIRED = 5975;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_UPGRADE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_UPGRADE_IN_PROGRESS 5976L")]
    public const int ERROR_CLUSTER_UPGRADE_IN_PROGRESS = 5976;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_UPGRADE_INCOMPLETE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_UPGRADE_INCOMPLETE 5977L")]
    public const int ERROR_CLUSTER_UPGRADE_INCOMPLETE = 5977;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_IN_GRACE_PERIOD"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_IN_GRACE_PERIOD 5978L")]
    public const int ERROR_CLUSTER_NODE_IN_GRACE_PERIOD = 5978;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_CSV_IO_PAUSE_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_CSV_IO_PAUSE_TIMEOUT 5979L")]
    public const int ERROR_CLUSTER_CSV_IO_PAUSE_TIMEOUT = 5979;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NODE_NOT_ACTIVE_CLUSTER_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_NODE_NOT_ACTIVE_CLUSTER_MEMBER 5980L")]
    public const int ERROR_NODE_NOT_ACTIVE_CLUSTER_MEMBER = 5980;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_NOT_MONITORED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_NOT_MONITORED 5981L")]
    public const int ERROR_CLUSTER_RESOURCE_NOT_MONITORED = 5981;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_DOES_NOT_SUPPORT_UNMONITORED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_DOES_NOT_SUPPORT_UNMONITORED 5982L")]
    public const int ERROR_CLUSTER_RESOURCE_DOES_NOT_SUPPORT_UNMONITORED = 5982;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_RESOURCE_IS_REPLICATED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_RESOURCE_IS_REPLICATED 5983L")]
    public const int ERROR_CLUSTER_RESOURCE_IS_REPLICATED = 5983;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_ISOLATED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_ISOLATED 5984L")]
    public const int ERROR_CLUSTER_NODE_ISOLATED = 5984;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_NODE_QUARANTINED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_NODE_QUARANTINED 5985L")]
    public const int ERROR_CLUSTER_NODE_QUARANTINED = 5985;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_DATABASE_UPDATE_CONDITION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_DATABASE_UPDATE_CONDITION_FAILED 5986L")]
    public const int ERROR_CLUSTER_DATABASE_UPDATE_CONDITION_FAILED = 5986;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_SPACE_DEGRADED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_SPACE_DEGRADED 5987L")]
    public const int ERROR_CLUSTER_SPACE_DEGRADED = 5987;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_TOKEN_DELEGATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_TOKEN_DELEGATION_NOT_SUPPORTED 5988L")]
    public const int ERROR_CLUSTER_TOKEN_DELEGATION_NOT_SUPPORTED = 5988;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_CSV_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_CSV_INVALID_HANDLE 5989L")]
    public const int ERROR_CLUSTER_CSV_INVALID_HANDLE = 5989;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR 5990L")]
    public const int ERROR_CLUSTER_CSV_SUPPORTED_ONLY_ON_COORDINATOR = 5990;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GROUPSET_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_GROUPSET_NOT_AVAILABLE 5991L")]
    public const int ERROR_GROUPSET_NOT_AVAILABLE = 5991;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GROUPSET_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_GROUPSET_NOT_FOUND 5992L")]
    public const int ERROR_GROUPSET_NOT_FOUND = 5992;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GROUPSET_CANT_PROVIDE"]/*' />
    [NativeTypeName("#define ERROR_GROUPSET_CANT_PROVIDE 5993L")]
    public const int ERROR_GROUPSET_CANT_PROVIDE = 5993;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_FAULT_DOMAIN_PARENT_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_FAULT_DOMAIN_PARENT_NOT_FOUND 5994L")]
    public const int ERROR_CLUSTER_FAULT_DOMAIN_PARENT_NOT_FOUND = 5994;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_FAULT_DOMAIN_INVALID_HIERARCHY"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_FAULT_DOMAIN_INVALID_HIERARCHY 5995L")]
    public const int ERROR_CLUSTER_FAULT_DOMAIN_INVALID_HIERARCHY = 5995;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_FAULT_DOMAIN_FAILED_S2D_VALIDATION"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_FAULT_DOMAIN_FAILED_S2D_VALIDATION 5996L")]
    public const int ERROR_CLUSTER_FAULT_DOMAIN_FAILED_S2D_VALIDATION = 5996;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_FAULT_DOMAIN_S2D_CONNECTIVITY_LOSS"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_FAULT_DOMAIN_S2D_CONNECTIVITY_LOSS 5997L")]
    public const int ERROR_CLUSTER_FAULT_DOMAIN_S2D_CONNECTIVITY_LOSS = 5997;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_INVALID_INFRASTRUCTURE_FILESERVER_NAME"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_INVALID_INFRASTRUCTURE_FILESERVER_NAME 5998L")]
    public const int ERROR_CLUSTER_INVALID_INFRASTRUCTURE_FILESERVER_NAME = 5998;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTERSET_MANAGEMENT_CLUSTER_UNREACHABLE"]/*' />
    [NativeTypeName("#define ERROR_CLUSTERSET_MANAGEMENT_CLUSTER_UNREACHABLE 5999L")]
    public const int ERROR_CLUSTERSET_MANAGEMENT_CLUSTER_UNREACHABLE = 5999;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCRYPTION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_ENCRYPTION_FAILED 6000L")]
    public const int ERROR_ENCRYPTION_FAILED = 6000;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DECRYPTION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DECRYPTION_FAILED 6001L")]
    public const int ERROR_DECRYPTION_FAILED = 6001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_ENCRYPTED"]/*' />
    [NativeTypeName("#define ERROR_FILE_ENCRYPTED 6002L")]
    public const int ERROR_FILE_ENCRYPTED = 6002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_RECOVERY_POLICY"]/*' />
    [NativeTypeName("#define ERROR_NO_RECOVERY_POLICY 6003L")]
    public const int ERROR_NO_RECOVERY_POLICY = 6003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_EFS"]/*' />
    [NativeTypeName("#define ERROR_NO_EFS 6004L")]
    public const int ERROR_NO_EFS = 6004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WRONG_EFS"]/*' />
    [NativeTypeName("#define ERROR_WRONG_EFS 6005L")]
    public const int ERROR_WRONG_EFS = 6005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_USER_KEYS"]/*' />
    [NativeTypeName("#define ERROR_NO_USER_KEYS 6006L")]
    public const int ERROR_NO_USER_KEYS = 6006;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_NOT_ENCRYPTED"]/*' />
    [NativeTypeName("#define ERROR_FILE_NOT_ENCRYPTED 6007L")]
    public const int ERROR_FILE_NOT_ENCRYPTED = 6007;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_EXPORT_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_NOT_EXPORT_FORMAT 6008L")]
    public const int ERROR_NOT_EXPORT_FORMAT = 6008;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_READ_ONLY"]/*' />
    [NativeTypeName("#define ERROR_FILE_READ_ONLY 6009L")]
    public const int ERROR_FILE_READ_ONLY = 6009;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIR_EFS_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_DIR_EFS_DISALLOWED 6010L")]
    public const int ERROR_DIR_EFS_DISALLOWED = 6010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EFS_SERVER_NOT_TRUSTED"]/*' />
    [NativeTypeName("#define ERROR_EFS_SERVER_NOT_TRUSTED 6011L")]
    public const int ERROR_EFS_SERVER_NOT_TRUSTED = 6011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_RECOVERY_POLICY"]/*' />
    [NativeTypeName("#define ERROR_BAD_RECOVERY_POLICY 6012L")]
    public const int ERROR_BAD_RECOVERY_POLICY = 6012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EFS_ALG_BLOB_TOO_BIG"]/*' />
    [NativeTypeName("#define ERROR_EFS_ALG_BLOB_TOO_BIG 6013L")]
    public const int ERROR_EFS_ALG_BLOB_TOO_BIG = 6013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_NOT_SUPPORT_EFS"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_NOT_SUPPORT_EFS 6014L")]
    public const int ERROR_VOLUME_NOT_SUPPORT_EFS = 6014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EFS_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_EFS_DISABLED 6015L")]
    public const int ERROR_EFS_DISABLED = 6015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EFS_VERSION_NOT_SUPPORT"]/*' />
    [NativeTypeName("#define ERROR_EFS_VERSION_NOT_SUPPORT 6016L")]
    public const int ERROR_EFS_VERSION_NOT_SUPPORT = 6016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE"]/*' />
    [NativeTypeName("#define ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE 6017L")]
    public const int ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE = 6017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER"]/*' />
    [NativeTypeName("#define ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER 6018L")]
    public const int ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER = 6018;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE"]/*' />
    [NativeTypeName("#define ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE 6019L")]
    public const int ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE = 6019;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE"]/*' />
    [NativeTypeName("#define ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE 6020L")]
    public const int ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE = 6020;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CS_ENCRYPTION_FILE_NOT_CSE"]/*' />
    [NativeTypeName("#define ERROR_CS_ENCRYPTION_FILE_NOT_CSE 6021L")]
    public const int ERROR_CS_ENCRYPTION_FILE_NOT_CSE = 6021;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENCRYPTION_POLICY_DENIES_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_ENCRYPTION_POLICY_DENIES_OPERATION 6022L")]
    public const int ERROR_ENCRYPTION_POLICY_DENIES_OPERATION = 6022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WIP_ENCRYPTION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_WIP_ENCRYPTION_FAILED 6023L")]
    public const int ERROR_WIP_ENCRYPTION_FAILED = 6023;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PDE_ENCRYPTION_UNAVAILABLE_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_PDE_ENCRYPTION_UNAVAILABLE_FAILURE 6024L")]
    public const int ERROR_PDE_ENCRYPTION_UNAVAILABLE_FAILURE = 6024;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PDE_DECRYPTION_UNAVAILABLE_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_PDE_DECRYPTION_UNAVAILABLE_FAILURE 6025L")]
    public const int ERROR_PDE_DECRYPTION_UNAVAILABLE_FAILURE = 6025;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PDE_DECRYPTION_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_PDE_DECRYPTION_UNAVAILABLE 6026L")]
    public const int ERROR_PDE_DECRYPTION_UNAVAILABLE = 6026;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_BROWSER_SERVERS_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NO_BROWSER_SERVERS_FOUND 6118L")]
    public const int ERROR_NO_BROWSER_SERVERS_FOUND = 6118;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLUSTER_OBJECT_IS_CLUSTER_SET_VM"]/*' />
    [NativeTypeName("#define ERROR_CLUSTER_OBJECT_IS_CLUSTER_SET_VM 6250L")]
    public const int ERROR_CLUSTER_OBJECT_IS_CLUSTER_SET_VM = 6250;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_TEMPLATE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_CNU_TEMPLATE_ALREADY_EXISTS 6251L")]
    public const int ERROR_CNU_TEMPLATE_ALREADY_EXISTS = 6251;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_TEMPLATE_NAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CNU_TEMPLATE_NAME_NOT_FOUND 6252L")]
    public const int ERROR_CNU_TEMPLATE_NAME_NOT_FOUND = 6252;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_RUN_NAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CNU_RUN_NAME_NOT_FOUND 6253L")]
    public const int ERROR_CNU_RUN_NAME_NOT_FOUND = 6253;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_RUN_ALREADY_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CNU_RUN_ALREADY_IN_PROGRESS 6254L")]
    public const int ERROR_CNU_RUN_ALREADY_IN_PROGRESS = 6254;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_RUN_NOT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_CNU_RUN_NOT_IN_PROGRESS 6255L")]
    public const int ERROR_CNU_RUN_NOT_IN_PROGRESS = 6255;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_CNU_NOT_READY 6256L")]
    public const int ERROR_CNU_NOT_READY = 6256;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_RUN_INIT_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CNU_RUN_INIT_FAILED 6257L")]
    public const int ERROR_CNU_RUN_INIT_FAILED = 6257;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_RUN_PREPARE_CLUSTER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CNU_RUN_PREPARE_CLUSTER_FAILED 6258L")]
    public const int ERROR_CNU_RUN_PREPARE_CLUSTER_FAILED = 6258;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CNU_RUN_PROCESS_CLUSTER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_CNU_RUN_PROCESS_CLUSTER_FAILED 6259L")]
    public const int ERROR_CNU_RUN_PROCESS_CLUSTER_FAILED = 6259;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAMERA_INVALID_CONFIGURATION"]/*' />
    [NativeTypeName("#define ERROR_CAMERA_INVALID_CONFIGURATION 6350L")]
    public const int ERROR_CAMERA_INVALID_CONFIGURATION = 6350;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CAMERA_INSUFFICIENT_BANDWIDTH"]/*' />
    [NativeTypeName("#define ERROR_CAMERA_INSUFFICIENT_BANDWIDTH 6351L")]
    public const int ERROR_CAMERA_INSUFFICIENT_BANDWIDTH = 6351;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_SECTOR_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_SECTOR_INVALID 6600L")]
    public const int ERROR_LOG_SECTOR_INVALID = 6600;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_SECTOR_PARITY_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_SECTOR_PARITY_INVALID 6601L")]
    public const int ERROR_LOG_SECTOR_PARITY_INVALID = 6601;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_SECTOR_REMAPPED"]/*' />
    [NativeTypeName("#define ERROR_LOG_SECTOR_REMAPPED 6602L")]
    public const int ERROR_LOG_SECTOR_REMAPPED = 6602;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_BLOCK_INCOMPLETE"]/*' />
    [NativeTypeName("#define ERROR_LOG_BLOCK_INCOMPLETE 6603L")]
    public const int ERROR_LOG_BLOCK_INCOMPLETE = 6603;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_INVALID_RANGE"]/*' />
    [NativeTypeName("#define ERROR_LOG_INVALID_RANGE 6604L")]
    public const int ERROR_LOG_INVALID_RANGE = 6604;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_BLOCKS_EXHAUSTED"]/*' />
    [NativeTypeName("#define ERROR_LOG_BLOCKS_EXHAUSTED 6605L")]
    public const int ERROR_LOG_BLOCKS_EXHAUSTED = 6605;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_READ_CONTEXT_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_READ_CONTEXT_INVALID 6606L")]
    public const int ERROR_LOG_READ_CONTEXT_INVALID = 6606;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_RESTART_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_RESTART_INVALID 6607L")]
    public const int ERROR_LOG_RESTART_INVALID = 6607;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_BLOCK_VERSION"]/*' />
    [NativeTypeName("#define ERROR_LOG_BLOCK_VERSION 6608L")]
    public const int ERROR_LOG_BLOCK_VERSION = 6608;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_BLOCK_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_BLOCK_INVALID 6609L")]
    public const int ERROR_LOG_BLOCK_INVALID = 6609;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_READ_MODE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_READ_MODE_INVALID 6610L")]
    public const int ERROR_LOG_READ_MODE_INVALID = 6610;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_NO_RESTART"]/*' />
    [NativeTypeName("#define ERROR_LOG_NO_RESTART 6611L")]
    public const int ERROR_LOG_NO_RESTART = 6611;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_LOG_METADATA_CORRUPT 6612L")]
    public const int ERROR_LOG_METADATA_CORRUPT = 6612;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_METADATA_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_METADATA_INVALID 6613L")]
    public const int ERROR_LOG_METADATA_INVALID = 6613;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_METADATA_INCONSISTENT"]/*' />
    [NativeTypeName("#define ERROR_LOG_METADATA_INCONSISTENT 6614L")]
    public const int ERROR_LOG_METADATA_INCONSISTENT = 6614;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_RESERVATION_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_RESERVATION_INVALID 6615L")]
    public const int ERROR_LOG_RESERVATION_INVALID = 6615;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CANT_DELETE"]/*' />
    [NativeTypeName("#define ERROR_LOG_CANT_DELETE 6616L")]
    public const int ERROR_LOG_CANT_DELETE = 6616;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CONTAINER_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_LOG_CONTAINER_LIMIT_EXCEEDED 6617L")]
    public const int ERROR_LOG_CONTAINER_LIMIT_EXCEEDED = 6617;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_START_OF_LOG"]/*' />
    [NativeTypeName("#define ERROR_LOG_START_OF_LOG 6618L")]
    public const int ERROR_LOG_START_OF_LOG = 6618;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_POLICY_ALREADY_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_LOG_POLICY_ALREADY_INSTALLED 6619L")]
    public const int ERROR_LOG_POLICY_ALREADY_INSTALLED = 6619;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_POLICY_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_LOG_POLICY_NOT_INSTALLED 6620L")]
    public const int ERROR_LOG_POLICY_NOT_INSTALLED = 6620;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_POLICY_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_POLICY_INVALID 6621L")]
    public const int ERROR_LOG_POLICY_INVALID = 6621;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_POLICY_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_LOG_POLICY_CONFLICT 6622L")]
    public const int ERROR_LOG_POLICY_CONFLICT = 6622;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_PINNED_ARCHIVE_TAIL"]/*' />
    [NativeTypeName("#define ERROR_LOG_PINNED_ARCHIVE_TAIL 6623L")]
    public const int ERROR_LOG_PINNED_ARCHIVE_TAIL = 6623;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_RECORD_NONEXISTENT"]/*' />
    [NativeTypeName("#define ERROR_LOG_RECORD_NONEXISTENT 6624L")]
    public const int ERROR_LOG_RECORD_NONEXISTENT = 6624;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_RECORDS_RESERVED_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_RECORDS_RESERVED_INVALID 6625L")]
    public const int ERROR_LOG_RECORDS_RESERVED_INVALID = 6625;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_SPACE_RESERVED_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_SPACE_RESERVED_INVALID 6626L")]
    public const int ERROR_LOG_SPACE_RESERVED_INVALID = 6626;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_TAIL_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_TAIL_INVALID 6627L")]
    public const int ERROR_LOG_TAIL_INVALID = 6627;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_FULL"]/*' />
    [NativeTypeName("#define ERROR_LOG_FULL 6628L")]
    public const int ERROR_LOG_FULL = 6628;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COULD_NOT_RESIZE_LOG"]/*' />
    [NativeTypeName("#define ERROR_COULD_NOT_RESIZE_LOG 6629L")]
    public const int ERROR_COULD_NOT_RESIZE_LOG = 6629;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_MULTIPLEXED"]/*' />
    [NativeTypeName("#define ERROR_LOG_MULTIPLEXED 6630L")]
    public const int ERROR_LOG_MULTIPLEXED = 6630;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_DEDICATED"]/*' />
    [NativeTypeName("#define ERROR_LOG_DEDICATED 6631L")]
    public const int ERROR_LOG_DEDICATED = 6631;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS 6632L")]
    public const int ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS = 6632;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_ARCHIVE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_LOG_ARCHIVE_IN_PROGRESS 6633L")]
    public const int ERROR_LOG_ARCHIVE_IN_PROGRESS = 6633;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_EPHEMERAL"]/*' />
    [NativeTypeName("#define ERROR_LOG_EPHEMERAL 6634L")]
    public const int ERROR_LOG_EPHEMERAL = 6634;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_NOT_ENOUGH_CONTAINERS"]/*' />
    [NativeTypeName("#define ERROR_LOG_NOT_ENOUGH_CONTAINERS 6635L")]
    public const int ERROR_LOG_NOT_ENOUGH_CONTAINERS = 6635;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CLIENT_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_LOG_CLIENT_ALREADY_REGISTERED 6636L")]
    public const int ERROR_LOG_CLIENT_ALREADY_REGISTERED = 6636;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CLIENT_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_LOG_CLIENT_NOT_REGISTERED 6637L")]
    public const int ERROR_LOG_CLIENT_NOT_REGISTERED = 6637;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_FULL_HANDLER_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_LOG_FULL_HANDLER_IN_PROGRESS 6638L")]
    public const int ERROR_LOG_FULL_HANDLER_IN_PROGRESS = 6638;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CONTAINER_READ_FAILED"]/*' />
    [NativeTypeName("#define ERROR_LOG_CONTAINER_READ_FAILED 6639L")]
    public const int ERROR_LOG_CONTAINER_READ_FAILED = 6639;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CONTAINER_WRITE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_LOG_CONTAINER_WRITE_FAILED 6640L")]
    public const int ERROR_LOG_CONTAINER_WRITE_FAILED = 6640;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CONTAINER_OPEN_FAILED"]/*' />
    [NativeTypeName("#define ERROR_LOG_CONTAINER_OPEN_FAILED 6641L")]
    public const int ERROR_LOG_CONTAINER_OPEN_FAILED = 6641;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CONTAINER_STATE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_CONTAINER_STATE_INVALID 6642L")]
    public const int ERROR_LOG_CONTAINER_STATE_INVALID = 6642;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_STATE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_LOG_STATE_INVALID 6643L")]
    public const int ERROR_LOG_STATE_INVALID = 6643;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_PINNED"]/*' />
    [NativeTypeName("#define ERROR_LOG_PINNED 6644L")]
    public const int ERROR_LOG_PINNED = 6644;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_METADATA_FLUSH_FAILED"]/*' />
    [NativeTypeName("#define ERROR_LOG_METADATA_FLUSH_FAILED 6645L")]
    public const int ERROR_LOG_METADATA_FLUSH_FAILED = 6645;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_INCONSISTENT_SECURITY"]/*' />
    [NativeTypeName("#define ERROR_LOG_INCONSISTENT_SECURITY 6646L")]
    public const int ERROR_LOG_INCONSISTENT_SECURITY = 6646;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_APPENDED_FLUSH_FAILED"]/*' />
    [NativeTypeName("#define ERROR_LOG_APPENDED_FLUSH_FAILED 6647L")]
    public const int ERROR_LOG_APPENDED_FLUSH_FAILED = 6647;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_PINNED_RESERVATION"]/*' />
    [NativeTypeName("#define ERROR_LOG_PINNED_RESERVATION 6648L")]
    public const int ERROR_LOG_PINNED_RESERVATION = 6648;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_TRANSACTION"]/*' />
    [NativeTypeName("#define ERROR_INVALID_TRANSACTION 6700L")]
    public const int ERROR_INVALID_TRANSACTION = 6700;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_NOT_ACTIVE 6701L")]
    public const int ERROR_TRANSACTION_NOT_ACTIVE = 6701;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_REQUEST_NOT_VALID"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_REQUEST_NOT_VALID 6702L")]
    public const int ERROR_TRANSACTION_REQUEST_NOT_VALID = 6702;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_NOT_REQUESTED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_NOT_REQUESTED 6703L")]
    public const int ERROR_TRANSACTION_NOT_REQUESTED = 6703;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_ALREADY_ABORTED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_ALREADY_ABORTED 6704L")]
    public const int ERROR_TRANSACTION_ALREADY_ABORTED = 6704;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_ALREADY_COMMITTED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_ALREADY_COMMITTED 6705L")]
    public const int ERROR_TRANSACTION_ALREADY_COMMITTED = 6705;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TM_INITIALIZATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_TM_INITIALIZATION_FAILED 6706L")]
    public const int ERROR_TM_INITIALIZATION_FAILED = 6706;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCEMANAGER_READ_ONLY"]/*' />
    [NativeTypeName("#define ERROR_RESOURCEMANAGER_READ_ONLY 6707L")]
    public const int ERROR_RESOURCEMANAGER_READ_ONLY = 6707;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_NOT_JOINED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_NOT_JOINED 6708L")]
    public const int ERROR_TRANSACTION_NOT_JOINED = 6708;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_SUPERIOR_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_SUPERIOR_EXISTS 6709L")]
    public const int ERROR_TRANSACTION_SUPERIOR_EXISTS = 6709;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CRM_PROTOCOL_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_CRM_PROTOCOL_ALREADY_EXISTS 6710L")]
    public const int ERROR_CRM_PROTOCOL_ALREADY_EXISTS = 6710;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_PROPAGATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_PROPAGATION_FAILED 6711L")]
    public const int ERROR_TRANSACTION_PROPAGATION_FAILED = 6711;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CRM_PROTOCOL_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CRM_PROTOCOL_NOT_FOUND 6712L")]
    public const int ERROR_CRM_PROTOCOL_NOT_FOUND = 6712;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER 6713L")]
    public const int ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER = 6713;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CURRENT_TRANSACTION_NOT_VALID"]/*' />
    [NativeTypeName("#define ERROR_CURRENT_TRANSACTION_NOT_VALID 6714L")]
    public const int ERROR_CURRENT_TRANSACTION_NOT_VALID = 6714;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_NOT_FOUND 6715L")]
    public const int ERROR_TRANSACTION_NOT_FOUND = 6715;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCEMANAGER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_RESOURCEMANAGER_NOT_FOUND 6716L")]
    public const int ERROR_RESOURCEMANAGER_NOT_FOUND = 6716;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENLISTMENT_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_ENLISTMENT_NOT_FOUND 6717L")]
    public const int ERROR_ENLISTMENT_NOT_FOUND = 6717;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTIONMANAGER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTIONMANAGER_NOT_FOUND 6718L")]
    public const int ERROR_TRANSACTIONMANAGER_NOT_FOUND = 6718;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTIONMANAGER_NOT_ONLINE"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTIONMANAGER_NOT_ONLINE 6719L")]
    public const int ERROR_TRANSACTIONMANAGER_NOT_ONLINE = 6719;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION 6720L")]
    public const int ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION = 6720;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_NOT_ROOT"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_NOT_ROOT 6721L")]
    public const int ERROR_TRANSACTION_NOT_ROOT = 6721;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_OBJECT_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_OBJECT_EXPIRED 6722L")]
    public const int ERROR_TRANSACTION_OBJECT_EXPIRED = 6722;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED 6723L")]
    public const int ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED = 6723;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_RECORD_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_RECORD_TOO_LONG 6724L")]
    public const int ERROR_TRANSACTION_RECORD_TOO_LONG = 6724;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED 6725L")]
    public const int ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED = 6725;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_INTEGRITY_VIOLATED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_INTEGRITY_VIOLATED 6726L")]
    public const int ERROR_TRANSACTION_INTEGRITY_VIOLATED = 6726;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH 6727L")]
    public const int ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH = 6727;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT"]/*' />
    [NativeTypeName("#define ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT 6728L")]
    public const int ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT = 6728;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_MUST_WRITETHROUGH"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_MUST_WRITETHROUGH 6729L")]
    public const int ERROR_TRANSACTION_MUST_WRITETHROUGH = 6729;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_NO_SUPERIOR"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_NO_SUPERIOR 6730L")]
    public const int ERROR_TRANSACTION_NO_SUPERIOR = 6730;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HEURISTIC_DAMAGE_POSSIBLE"]/*' />
    [NativeTypeName("#define ERROR_HEURISTIC_DAMAGE_POSSIBLE 6731L")]
    public const int ERROR_HEURISTIC_DAMAGE_POSSIBLE = 6731;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTIONAL_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTIONAL_CONFLICT 6800L")]
    public const int ERROR_TRANSACTIONAL_CONFLICT = 6800;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RM_NOT_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_RM_NOT_ACTIVE 6801L")]
    public const int ERROR_RM_NOT_ACTIVE = 6801;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RM_METADATA_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_RM_METADATA_CORRUPT 6802L")]
    public const int ERROR_RM_METADATA_CORRUPT = 6802;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIRECTORY_NOT_RM"]/*' />
    [NativeTypeName("#define ERROR_DIRECTORY_NOT_RM 6803L")]
    public const int ERROR_DIRECTORY_NOT_RM = 6803;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE 6805L")]
    public const int ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE = 6805;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_RESIZE_INVALID_SIZE"]/*' />
    [NativeTypeName("#define ERROR_LOG_RESIZE_INVALID_SIZE 6806L")]
    public const int ERROR_LOG_RESIZE_INVALID_SIZE = 6806;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OBJECT_NO_LONGER_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_OBJECT_NO_LONGER_EXISTS 6807L")]
    public const int ERROR_OBJECT_NO_LONGER_EXISTS = 6807;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STREAM_MINIVERSION_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_STREAM_MINIVERSION_NOT_FOUND 6808L")]
    public const int ERROR_STREAM_MINIVERSION_NOT_FOUND = 6808;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STREAM_MINIVERSION_NOT_VALID"]/*' />
    [NativeTypeName("#define ERROR_STREAM_MINIVERSION_NOT_VALID 6809L")]
    public const int ERROR_STREAM_MINIVERSION_NOT_VALID = 6809;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION"]/*' />
    [NativeTypeName("#define ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION 6810L")]
    public const int ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION = 6810;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT"]/*' />
    [NativeTypeName("#define ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT 6811L")]
    public const int ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT = 6811;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS"]/*' />
    [NativeTypeName("#define ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS 6812L")]
    public const int ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS = 6812;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOTE_FILE_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_REMOTE_FILE_VERSION_MISMATCH 6814L")]
    public const int ERROR_REMOTE_FILE_VERSION_MISMATCH = 6814;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HANDLE_NO_LONGER_VALID"]/*' />
    [NativeTypeName("#define ERROR_HANDLE_NO_LONGER_VALID 6815L")]
    public const int ERROR_HANDLE_NO_LONGER_VALID = 6815;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_TXF_METADATA"]/*' />
    [NativeTypeName("#define ERROR_NO_TXF_METADATA 6816L")]
    public const int ERROR_NO_TXF_METADATA = 6816;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_CORRUPTION_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_LOG_CORRUPTION_DETECTED 6817L")]
    public const int ERROR_LOG_CORRUPTION_DETECTED = 6817;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_RECOVER_WITH_HANDLE_OPEN"]/*' />
    [NativeTypeName("#define ERROR_CANT_RECOVER_WITH_HANDLE_OPEN 6818L")]
    public const int ERROR_CANT_RECOVER_WITH_HANDLE_OPEN = 6818;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RM_DISCONNECTED"]/*' />
    [NativeTypeName("#define ERROR_RM_DISCONNECTED 6819L")]
    public const int ERROR_RM_DISCONNECTED = 6819;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENLISTMENT_NOT_SUPERIOR"]/*' />
    [NativeTypeName("#define ERROR_ENLISTMENT_NOT_SUPERIOR 6820L")]
    public const int ERROR_ENLISTMENT_NOT_SUPERIOR = 6820;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RECOVERY_NOT_NEEDED"]/*' />
    [NativeTypeName("#define ERROR_RECOVERY_NOT_NEEDED 6821L")]
    public const int ERROR_RECOVERY_NOT_NEEDED = 6821;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RM_ALREADY_STARTED"]/*' />
    [NativeTypeName("#define ERROR_RM_ALREADY_STARTED 6822L")]
    public const int ERROR_RM_ALREADY_STARTED = 6822;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FILE_IDENTITY_NOT_PERSISTENT"]/*' />
    [NativeTypeName("#define ERROR_FILE_IDENTITY_NOT_PERSISTENT 6823L")]
    public const int ERROR_FILE_IDENTITY_NOT_PERSISTENT = 6823;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY"]/*' />
    [NativeTypeName("#define ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY 6824L")]
    public const int ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY = 6824;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANT_CROSS_RM_BOUNDARY"]/*' />
    [NativeTypeName("#define ERROR_CANT_CROSS_RM_BOUNDARY 6825L")]
    public const int ERROR_CANT_CROSS_RM_BOUNDARY = 6825;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TXF_DIR_NOT_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_TXF_DIR_NOT_EMPTY 6826L")]
    public const int ERROR_TXF_DIR_NOT_EMPTY = 6826;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INDOUBT_TRANSACTIONS_EXIST"]/*' />
    [NativeTypeName("#define ERROR_INDOUBT_TRANSACTIONS_EXIST 6827L")]
    public const int ERROR_INDOUBT_TRANSACTIONS_EXIST = 6827;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TM_VOLATILE"]/*' />
    [NativeTypeName("#define ERROR_TM_VOLATILE 6828L")]
    public const int ERROR_TM_VOLATILE = 6828;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ROLLBACK_TIMER_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_ROLLBACK_TIMER_EXPIRED 6829L")]
    public const int ERROR_ROLLBACK_TIMER_EXPIRED = 6829;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TXF_ATTRIBUTE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_TXF_ATTRIBUTE_CORRUPT 6830L")]
    public const int ERROR_TXF_ATTRIBUTE_CORRUPT = 6830;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION 6831L")]
    public const int ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION = 6831;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED 6832L")]
    public const int ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED = 6832;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOG_GROWTH_FAILED"]/*' />
    [NativeTypeName("#define ERROR_LOG_GROWTH_FAILED 6833L")]
    public const int ERROR_LOG_GROWTH_FAILED = 6833;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE 6834L")]
    public const int ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE = 6834;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TXF_METADATA_ALREADY_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_TXF_METADATA_ALREADY_PRESENT 6835L")]
    public const int ERROR_TXF_METADATA_ALREADY_PRESENT = 6835;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET 6836L")]
    public const int ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET = 6836;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_REQUIRED_PROMOTION"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_REQUIRED_PROMOTION 6837L")]
    public const int ERROR_TRANSACTION_REQUIRED_PROMOTION = 6837;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION 6838L")]
    public const int ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION = 6838;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTIONS_NOT_FROZEN"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTIONS_NOT_FROZEN 6839L")]
    public const int ERROR_TRANSACTIONS_NOT_FROZEN = 6839;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_FREEZE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_FREEZE_IN_PROGRESS 6840L")]
    public const int ERROR_TRANSACTION_FREEZE_IN_PROGRESS = 6840;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SNAPSHOT_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_NOT_SNAPSHOT_VOLUME 6841L")]
    public const int ERROR_NOT_SNAPSHOT_VOLUME = 6841;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SAVEPOINT_WITH_OPEN_FILES"]/*' />
    [NativeTypeName("#define ERROR_NO_SAVEPOINT_WITH_OPEN_FILES 6842L")]
    public const int ERROR_NO_SAVEPOINT_WITH_OPEN_FILES = 6842;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DATA_LOST_REPAIR"]/*' />
    [NativeTypeName("#define ERROR_DATA_LOST_REPAIR 6843L")]
    public const int ERROR_DATA_LOST_REPAIR = 6843;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION 6844L")]
    public const int ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION = 6844;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TM_IDENTITY_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_TM_IDENTITY_MISMATCH 6845L")]
    public const int ERROR_TM_IDENTITY_MISMATCH = 6845;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLOATED_SECTION"]/*' />
    [NativeTypeName("#define ERROR_FLOATED_SECTION 6846L")]
    public const int ERROR_FLOATED_SECTION = 6846;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_ACCEPT_TRANSACTED_WORK"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_ACCEPT_TRANSACTED_WORK 6847L")]
    public const int ERROR_CANNOT_ACCEPT_TRANSACTED_WORK = 6847;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_ABORT_TRANSACTIONS"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_ABORT_TRANSACTIONS 6848L")]
    public const int ERROR_CANNOT_ABORT_TRANSACTIONS = 6848;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BAD_CLUSTERS"]/*' />
    [NativeTypeName("#define ERROR_BAD_CLUSTERS 6849L")]
    public const int ERROR_BAD_CLUSTERS = 6849;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION 6850L")]
    public const int ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION = 6850;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLUME_DIRTY"]/*' />
    [NativeTypeName("#define ERROR_VOLUME_DIRTY 6851L")]
    public const int ERROR_VOLUME_DIRTY = 6851;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_LINK_TRACKING_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define ERROR_NO_LINK_TRACKING_IN_TRANSACTION 6852L")]
    public const int ERROR_NO_LINK_TRACKING_IN_TRANSACTION = 6852;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION"]/*' />
    [NativeTypeName("#define ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION 6853L")]
    public const int ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION = 6853;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EXPIRED_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_EXPIRED_HANDLE 6854L")]
    public const int ERROR_EXPIRED_HANDLE = 6854;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TRANSACTION_NOT_ENLISTED"]/*' />
    [NativeTypeName("#define ERROR_TRANSACTION_NOT_ENLISTED 6855L")]
    public const int ERROR_TRANSACTION_NOT_ENLISTED = 6855;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ENLISTMENT_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define ERROR_ENLISTMENT_NOT_INITIALIZED 6856L")]
    public const int ERROR_ENLISTMENT_NOT_INITIALIZED = 6856;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_WINSTATION_NAME_INVALID"]/*' />
    [NativeTypeName("#define ERROR_CTX_WINSTATION_NAME_INVALID 7001L")]
    public const int ERROR_CTX_WINSTATION_NAME_INVALID = 7001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_INVALID_PD"]/*' />
    [NativeTypeName("#define ERROR_CTX_INVALID_PD 7002L")]
    public const int ERROR_CTX_INVALID_PD = 7002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_PD_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CTX_PD_NOT_FOUND 7003L")]
    public const int ERROR_CTX_PD_NOT_FOUND = 7003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_WD_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CTX_WD_NOT_FOUND 7004L")]
    public const int ERROR_CTX_WD_NOT_FOUND = 7004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY"]/*' />
    [NativeTypeName("#define ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY 7005L")]
    public const int ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY = 7005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_SERVICE_NAME_COLLISION"]/*' />
    [NativeTypeName("#define ERROR_CTX_SERVICE_NAME_COLLISION 7006L")]
    public const int ERROR_CTX_SERVICE_NAME_COLLISION = 7006;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CLOSE_PENDING"]/*' />
    [NativeTypeName("#define ERROR_CTX_CLOSE_PENDING 7007L")]
    public const int ERROR_CTX_CLOSE_PENDING = 7007;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_NO_OUTBUF"]/*' />
    [NativeTypeName("#define ERROR_CTX_NO_OUTBUF 7008L")]
    public const int ERROR_CTX_NO_OUTBUF = 7008;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_MODEM_INF_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CTX_MODEM_INF_NOT_FOUND 7009L")]
    public const int ERROR_CTX_MODEM_INF_NOT_FOUND = 7009;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_INVALID_MODEMNAME"]/*' />
    [NativeTypeName("#define ERROR_CTX_INVALID_MODEMNAME 7010L")]
    public const int ERROR_CTX_INVALID_MODEMNAME = 7010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_MODEM_RESPONSE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_CTX_MODEM_RESPONSE_ERROR 7011L")]
    public const int ERROR_CTX_MODEM_RESPONSE_ERROR = 7011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_MODEM_RESPONSE_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_CTX_MODEM_RESPONSE_TIMEOUT 7012L")]
    public const int ERROR_CTX_MODEM_RESPONSE_TIMEOUT = 7012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_MODEM_RESPONSE_NO_CARRIER"]/*' />
    [NativeTypeName("#define ERROR_CTX_MODEM_RESPONSE_NO_CARRIER 7013L")]
    public const int ERROR_CTX_MODEM_RESPONSE_NO_CARRIER = 7013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE"]/*' />
    [NativeTypeName("#define ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE 7014L")]
    public const int ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE = 7014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_MODEM_RESPONSE_BUSY"]/*' />
    [NativeTypeName("#define ERROR_CTX_MODEM_RESPONSE_BUSY 7015L")]
    public const int ERROR_CTX_MODEM_RESPONSE_BUSY = 7015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_MODEM_RESPONSE_VOICE"]/*' />
    [NativeTypeName("#define ERROR_CTX_MODEM_RESPONSE_VOICE 7016L")]
    public const int ERROR_CTX_MODEM_RESPONSE_VOICE = 7016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_TD_ERROR"]/*' />
    [NativeTypeName("#define ERROR_CTX_TD_ERROR 7017L")]
    public const int ERROR_CTX_TD_ERROR = 7017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_WINSTATION_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CTX_WINSTATION_NOT_FOUND 7022L")]
    public const int ERROR_CTX_WINSTATION_NOT_FOUND = 7022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_WINSTATION_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_CTX_WINSTATION_ALREADY_EXISTS 7023L")]
    public const int ERROR_CTX_WINSTATION_ALREADY_EXISTS = 7023;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_WINSTATION_BUSY"]/*' />
    [NativeTypeName("#define ERROR_CTX_WINSTATION_BUSY 7024L")]
    public const int ERROR_CTX_WINSTATION_BUSY = 7024;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_BAD_VIDEO_MODE"]/*' />
    [NativeTypeName("#define ERROR_CTX_BAD_VIDEO_MODE 7025L")]
    public const int ERROR_CTX_BAD_VIDEO_MODE = 7025;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_GRAPHICS_INVALID"]/*' />
    [NativeTypeName("#define ERROR_CTX_GRAPHICS_INVALID 7035L")]
    public const int ERROR_CTX_GRAPHICS_INVALID = 7035;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_LOGON_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_CTX_LOGON_DISABLED 7037L")]
    public const int ERROR_CTX_LOGON_DISABLED = 7037;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_NOT_CONSOLE"]/*' />
    [NativeTypeName("#define ERROR_CTX_NOT_CONSOLE 7038L")]
    public const int ERROR_CTX_NOT_CONSOLE = 7038;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CLIENT_QUERY_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_CTX_CLIENT_QUERY_TIMEOUT 7040L")]
    public const int ERROR_CTX_CLIENT_QUERY_TIMEOUT = 7040;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CONSOLE_DISCONNECT"]/*' />
    [NativeTypeName("#define ERROR_CTX_CONSOLE_DISCONNECT 7041L")]
    public const int ERROR_CTX_CONSOLE_DISCONNECT = 7041;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CONSOLE_CONNECT"]/*' />
    [NativeTypeName("#define ERROR_CTX_CONSOLE_CONNECT 7042L")]
    public const int ERROR_CTX_CONSOLE_CONNECT = 7042;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_SHADOW_DENIED"]/*' />
    [NativeTypeName("#define ERROR_CTX_SHADOW_DENIED 7044L")]
    public const int ERROR_CTX_SHADOW_DENIED = 7044;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_WINSTATION_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_CTX_WINSTATION_ACCESS_DENIED 7045L")]
    public const int ERROR_CTX_WINSTATION_ACCESS_DENIED = 7045;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_INVALID_WD"]/*' />
    [NativeTypeName("#define ERROR_CTX_INVALID_WD 7049L")]
    public const int ERROR_CTX_INVALID_WD = 7049;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_SHADOW_INVALID"]/*' />
    [NativeTypeName("#define ERROR_CTX_SHADOW_INVALID 7050L")]
    public const int ERROR_CTX_SHADOW_INVALID = 7050;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_SHADOW_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_CTX_SHADOW_DISABLED 7051L")]
    public const int ERROR_CTX_SHADOW_DISABLED = 7051;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CLIENT_LICENSE_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_CTX_CLIENT_LICENSE_IN_USE 7052L")]
    public const int ERROR_CTX_CLIENT_LICENSE_IN_USE = 7052;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CLIENT_LICENSE_NOT_SET"]/*' />
    [NativeTypeName("#define ERROR_CTX_CLIENT_LICENSE_NOT_SET 7053L")]
    public const int ERROR_CTX_CLIENT_LICENSE_NOT_SET = 7053;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_LICENSE_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_CTX_LICENSE_NOT_AVAILABLE 7054L")]
    public const int ERROR_CTX_LICENSE_NOT_AVAILABLE = 7054;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_LICENSE_CLIENT_INVALID"]/*' />
    [NativeTypeName("#define ERROR_CTX_LICENSE_CLIENT_INVALID 7055L")]
    public const int ERROR_CTX_LICENSE_CLIENT_INVALID = 7055;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_LICENSE_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_CTX_LICENSE_EXPIRED 7056L")]
    public const int ERROR_CTX_LICENSE_EXPIRED = 7056;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_SHADOW_NOT_RUNNING"]/*' />
    [NativeTypeName("#define ERROR_CTX_SHADOW_NOT_RUNNING 7057L")]
    public const int ERROR_CTX_SHADOW_NOT_RUNNING = 7057;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE"]/*' />
    [NativeTypeName("#define ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE 7058L")]
    public const int ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE = 7058;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACTIVATION_COUNT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_ACTIVATION_COUNT_EXCEEDED 7059L")]
    public const int ERROR_ACTIVATION_COUNT_EXCEEDED = 7059;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_WINSTATIONS_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_CTX_WINSTATIONS_DISABLED 7060L")]
    public const int ERROR_CTX_WINSTATIONS_DISABLED = 7060;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED 7061L")]
    public const int ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED = 7061;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_SESSION_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_CTX_SESSION_IN_USE 7062L")]
    public const int ERROR_CTX_SESSION_IN_USE = 7062;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_NO_FORCE_LOGOFF"]/*' />
    [NativeTypeName("#define ERROR_CTX_NO_FORCE_LOGOFF 7063L")]
    public const int ERROR_CTX_NO_FORCE_LOGOFF = 7063;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_ACCOUNT_RESTRICTION"]/*' />
    [NativeTypeName("#define ERROR_CTX_ACCOUNT_RESTRICTION 7064L")]
    public const int ERROR_CTX_ACCOUNT_RESTRICTION = 7064;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RDP_PROTOCOL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_RDP_PROTOCOL_ERROR 7065L")]
    public const int ERROR_RDP_PROTOCOL_ERROR = 7065;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CDM_CONNECT"]/*' />
    [NativeTypeName("#define ERROR_CTX_CDM_CONNECT 7066L")]
    public const int ERROR_CTX_CDM_CONNECT = 7066;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_CDM_DISCONNECT"]/*' />
    [NativeTypeName("#define ERROR_CTX_CDM_DISCONNECT 7067L")]
    public const int ERROR_CTX_CDM_DISCONNECT = 7067;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTX_SECURITY_LAYER_ERROR"]/*' />
    [NativeTypeName("#define ERROR_CTX_SECURITY_LAYER_ERROR 7068L")]
    public const int ERROR_CTX_SECURITY_LAYER_ERROR = 7068;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TS_INCOMPATIBLE_SESSIONS"]/*' />
    [NativeTypeName("#define ERROR_TS_INCOMPATIBLE_SESSIONS 7069L")]
    public const int ERROR_TS_INCOMPATIBLE_SESSIONS = 7069;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TS_VIDEO_SUBSYSTEM_ERROR"]/*' />
    [NativeTypeName("#define ERROR_TS_VIDEO_SUBSYSTEM_ERROR 7070L")]
    public const int ERROR_TS_VIDEO_SUBSYSTEM_ERROR = 7070;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_DS_NOT_INSTALLED 8200L")]
    public const int ERROR_DS_NOT_INSTALLED = 8200;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY"]/*' />
    [NativeTypeName("#define ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY 8201L")]
    public const int ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY = 8201;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_ATTRIBUTE_OR_VALUE"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_ATTRIBUTE_OR_VALUE 8202L")]
    public const int ERROR_DS_NO_ATTRIBUTE_OR_VALUE = 8202;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_ATTRIBUTE_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_ATTRIBUTE_SYNTAX 8203L")]
    public const int ERROR_DS_INVALID_ATTRIBUTE_SYNTAX = 8203;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED"]/*' />
    [NativeTypeName("#define ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED 8204L")]
    public const int ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED = 8204;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS 8205L")]
    public const int ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS = 8205;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_BUSY"]/*' />
    [NativeTypeName("#define ERROR_DS_BUSY 8206L")]
    public const int ERROR_DS_BUSY = 8206;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_DS_UNAVAILABLE 8207L")]
    public const int ERROR_DS_UNAVAILABLE = 8207;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_RIDS_ALLOCATED"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_RIDS_ALLOCATED 8208L")]
    public const int ERROR_DS_NO_RIDS_ALLOCATED = 8208;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_MORE_RIDS"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_MORE_RIDS 8209L")]
    public const int ERROR_DS_NO_MORE_RIDS = 8209;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INCORRECT_ROLE_OWNER"]/*' />
    [NativeTypeName("#define ERROR_DS_INCORRECT_ROLE_OWNER 8210L")]
    public const int ERROR_DS_INCORRECT_ROLE_OWNER = 8210;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_RIDMGR_INIT_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_RIDMGR_INIT_ERROR 8211L")]
    public const int ERROR_DS_RIDMGR_INIT_ERROR = 8211;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJ_CLASS_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJ_CLASS_VIOLATION 8212L")]
    public const int ERROR_DS_OBJ_CLASS_VIOLATION = 8212;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_ON_NON_LEAF"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_ON_NON_LEAF 8213L")]
    public const int ERROR_DS_CANT_ON_NON_LEAF = 8213;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_ON_RDN"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_ON_RDN 8214L")]
    public const int ERROR_DS_CANT_ON_RDN = 8214;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MOD_OBJ_CLASS"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MOD_OBJ_CLASS 8215L")]
    public const int ERROR_DS_CANT_MOD_OBJ_CLASS = 8215;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CROSS_DOM_MOVE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_CROSS_DOM_MOVE_ERROR 8216L")]
    public const int ERROR_DS_CROSS_DOM_MOVE_ERROR = 8216;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GC_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_DS_GC_NOT_AVAILABLE 8217L")]
    public const int ERROR_DS_GC_NOT_AVAILABLE = 8217;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SHARED_POLICY"]/*' />
    [NativeTypeName("#define ERROR_SHARED_POLICY 8218L")]
    public const int ERROR_SHARED_POLICY = 8218;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_POLICY_OBJECT_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_POLICY_OBJECT_NOT_FOUND 8219L")]
    public const int ERROR_POLICY_OBJECT_NOT_FOUND = 8219;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_POLICY_ONLY_IN_DS"]/*' />
    [NativeTypeName("#define ERROR_POLICY_ONLY_IN_DS 8220L")]
    public const int ERROR_POLICY_ONLY_IN_DS = 8220;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROMOTION_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_PROMOTION_ACTIVE 8221L")]
    public const int ERROR_PROMOTION_ACTIVE = 8221;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_PROMOTION_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_NO_PROMOTION_ACTIVE 8222L")]
    public const int ERROR_NO_PROMOTION_ACTIVE = 8222;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OPERATIONS_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_OPERATIONS_ERROR 8224L")]
    public const int ERROR_DS_OPERATIONS_ERROR = 8224;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_PROTOCOL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_PROTOCOL_ERROR 8225L")]
    public const int ERROR_DS_PROTOCOL_ERROR = 8225;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_TIMELIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DS_TIMELIMIT_EXCEEDED 8226L")]
    public const int ERROR_DS_TIMELIMIT_EXCEEDED = 8226;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SIZELIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DS_SIZELIMIT_EXCEEDED 8227L")]
    public const int ERROR_DS_SIZELIMIT_EXCEEDED = 8227;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ADMIN_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DS_ADMIN_LIMIT_EXCEEDED 8228L")]
    public const int ERROR_DS_ADMIN_LIMIT_EXCEEDED = 8228;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_COMPARE_FALSE"]/*' />
    [NativeTypeName("#define ERROR_DS_COMPARE_FALSE 8229L")]
    public const int ERROR_DS_COMPARE_FALSE = 8229;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_COMPARE_TRUE"]/*' />
    [NativeTypeName("#define ERROR_DS_COMPARE_TRUE 8230L")]
    public const int ERROR_DS_COMPARE_TRUE = 8230;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_AUTH_METHOD_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_DS_AUTH_METHOD_NOT_SUPPORTED 8231L")]
    public const int ERROR_DS_AUTH_METHOD_NOT_SUPPORTED = 8231;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_STRONG_AUTH_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_DS_STRONG_AUTH_REQUIRED 8232L")]
    public const int ERROR_DS_STRONG_AUTH_REQUIRED = 8232;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INAPPROPRIATE_AUTH"]/*' />
    [NativeTypeName("#define ERROR_DS_INAPPROPRIATE_AUTH 8233L")]
    public const int ERROR_DS_INAPPROPRIATE_AUTH = 8233;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_AUTH_UNKNOWN"]/*' />
    [NativeTypeName("#define ERROR_DS_AUTH_UNKNOWN 8234L")]
    public const int ERROR_DS_AUTH_UNKNOWN = 8234;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_REFERRAL"]/*' />
    [NativeTypeName("#define ERROR_DS_REFERRAL 8235L")]
    public const int ERROR_DS_REFERRAL = 8235;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNAVAILABLE_CRIT_EXTENSION"]/*' />
    [NativeTypeName("#define ERROR_DS_UNAVAILABLE_CRIT_EXTENSION 8236L")]
    public const int ERROR_DS_UNAVAILABLE_CRIT_EXTENSION = 8236;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CONFIDENTIALITY_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_DS_CONFIDENTIALITY_REQUIRED 8237L")]
    public const int ERROR_DS_CONFIDENTIALITY_REQUIRED = 8237;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INAPPROPRIATE_MATCHING"]/*' />
    [NativeTypeName("#define ERROR_DS_INAPPROPRIATE_MATCHING 8238L")]
    public const int ERROR_DS_INAPPROPRIATE_MATCHING = 8238;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CONSTRAINT_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_DS_CONSTRAINT_VIOLATION 8239L")]
    public const int ERROR_DS_CONSTRAINT_VIOLATION = 8239;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_SUCH_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_SUCH_OBJECT 8240L")]
    public const int ERROR_DS_NO_SUCH_OBJECT = 8240;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ALIAS_PROBLEM"]/*' />
    [NativeTypeName("#define ERROR_DS_ALIAS_PROBLEM 8241L")]
    public const int ERROR_DS_ALIAS_PROBLEM = 8241;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_DN_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_DN_SYNTAX 8242L")]
    public const int ERROR_DS_INVALID_DN_SYNTAX = 8242;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_IS_LEAF"]/*' />
    [NativeTypeName("#define ERROR_DS_IS_LEAF 8243L")]
    public const int ERROR_DS_IS_LEAF = 8243;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ALIAS_DEREF_PROBLEM"]/*' />
    [NativeTypeName("#define ERROR_DS_ALIAS_DEREF_PROBLEM 8244L")]
    public const int ERROR_DS_ALIAS_DEREF_PROBLEM = 8244;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNWILLING_TO_PERFORM"]/*' />
    [NativeTypeName("#define ERROR_DS_UNWILLING_TO_PERFORM 8245L")]
    public const int ERROR_DS_UNWILLING_TO_PERFORM = 8245;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_LOOP_DETECT"]/*' />
    [NativeTypeName("#define ERROR_DS_LOOP_DETECT 8246L")]
    public const int ERROR_DS_LOOP_DETECT = 8246;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAMING_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_DS_NAMING_VIOLATION 8247L")]
    public const int ERROR_DS_NAMING_VIOLATION = 8247;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJECT_RESULTS_TOO_LARGE"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJECT_RESULTS_TOO_LARGE 8248L")]
    public const int ERROR_DS_OBJECT_RESULTS_TOO_LARGE = 8248;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_AFFECTS_MULTIPLE_DSAS"]/*' />
    [NativeTypeName("#define ERROR_DS_AFFECTS_MULTIPLE_DSAS 8249L")]
    public const int ERROR_DS_AFFECTS_MULTIPLE_DSAS = 8249;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SERVER_DOWN"]/*' />
    [NativeTypeName("#define ERROR_DS_SERVER_DOWN 8250L")]
    public const int ERROR_DS_SERVER_DOWN = 8250;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_LOCAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_LOCAL_ERROR 8251L")]
    public const int ERROR_DS_LOCAL_ERROR = 8251;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ENCODING_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_ENCODING_ERROR 8252L")]
    public const int ERROR_DS_ENCODING_ERROR = 8252;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DECODING_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_DECODING_ERROR 8253L")]
    public const int ERROR_DS_DECODING_ERROR = 8253;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_FILTER_UNKNOWN"]/*' />
    [NativeTypeName("#define ERROR_DS_FILTER_UNKNOWN 8254L")]
    public const int ERROR_DS_FILTER_UNKNOWN = 8254;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_PARAM_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_PARAM_ERROR 8255L")]
    public const int ERROR_DS_PARAM_ERROR = 8255;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_DS_NOT_SUPPORTED 8256L")]
    public const int ERROR_DS_NOT_SUPPORTED = 8256;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_RESULTS_RETURNED"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_RESULTS_RETURNED 8257L")]
    public const int ERROR_DS_NO_RESULTS_RETURNED = 8257;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CONTROL_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DS_CONTROL_NOT_FOUND 8258L")]
    public const int ERROR_DS_CONTROL_NOT_FOUND = 8258;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CLIENT_LOOP"]/*' />
    [NativeTypeName("#define ERROR_DS_CLIENT_LOOP 8259L")]
    public const int ERROR_DS_CLIENT_LOOP = 8259;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_REFERRAL_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DS_REFERRAL_LIMIT_EXCEEDED 8260L")]
    public const int ERROR_DS_REFERRAL_LIMIT_EXCEEDED = 8260;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SORT_CONTROL_MISSING"]/*' />
    [NativeTypeName("#define ERROR_DS_SORT_CONTROL_MISSING 8261L")]
    public const int ERROR_DS_SORT_CONTROL_MISSING = 8261;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OFFSET_RANGE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_OFFSET_RANGE_ERROR 8262L")]
    public const int ERROR_DS_OFFSET_RANGE_ERROR = 8262;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_RIDMGR_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_DS_RIDMGR_DISABLED 8263L")]
    public const int ERROR_DS_RIDMGR_DISABLED = 8263;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ROOT_MUST_BE_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_ROOT_MUST_BE_NC 8301L")]
    public const int ERROR_DS_ROOT_MUST_BE_NC = 8301;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ADD_REPLICA_INHIBITED"]/*' />
    [NativeTypeName("#define ERROR_DS_ADD_REPLICA_INHIBITED 8302L")]
    public const int ERROR_DS_ADD_REPLICA_INHIBITED = 8302;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATT_NOT_DEF_IN_SCHEMA"]/*' />
    [NativeTypeName("#define ERROR_DS_ATT_NOT_DEF_IN_SCHEMA 8303L")]
    public const int ERROR_DS_ATT_NOT_DEF_IN_SCHEMA = 8303;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MAX_OBJ_SIZE_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DS_MAX_OBJ_SIZE_EXCEEDED 8304L")]
    public const int ERROR_DS_MAX_OBJ_SIZE_EXCEEDED = 8304;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJ_STRING_NAME_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJ_STRING_NAME_EXISTS 8305L")]
    public const int ERROR_DS_OBJ_STRING_NAME_EXISTS = 8305;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA 8306L")]
    public const int ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA = 8306;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_RDN_DOESNT_MATCH_SCHEMA"]/*' />
    [NativeTypeName("#define ERROR_DS_RDN_DOESNT_MATCH_SCHEMA 8307L")]
    public const int ERROR_DS_RDN_DOESNT_MATCH_SCHEMA = 8307;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_REQUESTED_ATTS_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_REQUESTED_ATTS_FOUND 8308L")]
    public const int ERROR_DS_NO_REQUESTED_ATTS_FOUND = 8308;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_USER_BUFFER_TO_SMALL"]/*' />
    [NativeTypeName("#define ERROR_DS_USER_BUFFER_TO_SMALL 8309L")]
    public const int ERROR_DS_USER_BUFFER_TO_SMALL = 8309;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATT_IS_NOT_ON_OBJ"]/*' />
    [NativeTypeName("#define ERROR_DS_ATT_IS_NOT_ON_OBJ 8310L")]
    public const int ERROR_DS_ATT_IS_NOT_ON_OBJ = 8310;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ILLEGAL_MOD_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_DS_ILLEGAL_MOD_OPERATION 8311L")]
    public const int ERROR_DS_ILLEGAL_MOD_OPERATION = 8311;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJ_TOO_LARGE"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJ_TOO_LARGE 8312L")]
    public const int ERROR_DS_OBJ_TOO_LARGE = 8312;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_BAD_INSTANCE_TYPE"]/*' />
    [NativeTypeName("#define ERROR_DS_BAD_INSTANCE_TYPE 8313L")]
    public const int ERROR_DS_BAD_INSTANCE_TYPE = 8313;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MASTERDSA_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_DS_MASTERDSA_REQUIRED 8314L")]
    public const int ERROR_DS_MASTERDSA_REQUIRED = 8314;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJECT_CLASS_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJECT_CLASS_REQUIRED 8315L")]
    public const int ERROR_DS_OBJECT_CLASS_REQUIRED = 8315;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MISSING_REQUIRED_ATT"]/*' />
    [NativeTypeName("#define ERROR_DS_MISSING_REQUIRED_ATT 8316L")]
    public const int ERROR_DS_MISSING_REQUIRED_ATT = 8316;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATT_NOT_DEF_FOR_CLASS"]/*' />
    [NativeTypeName("#define ERROR_DS_ATT_NOT_DEF_FOR_CLASS 8317L")]
    public const int ERROR_DS_ATT_NOT_DEF_FOR_CLASS = 8317;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATT_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DS_ATT_ALREADY_EXISTS 8318L")]
    public const int ERROR_DS_ATT_ALREADY_EXISTS = 8318;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_ADD_ATT_VALUES"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_ADD_ATT_VALUES 8320L")]
    public const int ERROR_DS_CANT_ADD_ATT_VALUES = 8320;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SINGLE_VALUE_CONSTRAINT"]/*' />
    [NativeTypeName("#define ERROR_DS_SINGLE_VALUE_CONSTRAINT 8321L")]
    public const int ERROR_DS_SINGLE_VALUE_CONSTRAINT = 8321;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_RANGE_CONSTRAINT"]/*' />
    [NativeTypeName("#define ERROR_DS_RANGE_CONSTRAINT 8322L")]
    public const int ERROR_DS_RANGE_CONSTRAINT = 8322;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATT_VAL_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DS_ATT_VAL_ALREADY_EXISTS 8323L")]
    public const int ERROR_DS_ATT_VAL_ALREADY_EXISTS = 8323;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_REM_MISSING_ATT"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_REM_MISSING_ATT 8324L")]
    public const int ERROR_DS_CANT_REM_MISSING_ATT = 8324;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_REM_MISSING_ATT_VAL"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_REM_MISSING_ATT_VAL 8325L")]
    public const int ERROR_DS_CANT_REM_MISSING_ATT_VAL = 8325;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ROOT_CANT_BE_SUBREF"]/*' />
    [NativeTypeName("#define ERROR_DS_ROOT_CANT_BE_SUBREF 8326L")]
    public const int ERROR_DS_ROOT_CANT_BE_SUBREF = 8326;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_CHAINING"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_CHAINING 8327L")]
    public const int ERROR_DS_NO_CHAINING = 8327;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_CHAINED_EVAL"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_CHAINED_EVAL 8328L")]
    public const int ERROR_DS_NO_CHAINED_EVAL = 8328;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_PARENT_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_PARENT_OBJECT 8329L")]
    public const int ERROR_DS_NO_PARENT_OBJECT = 8329;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_PARENT_IS_AN_ALIAS"]/*' />
    [NativeTypeName("#define ERROR_DS_PARENT_IS_AN_ALIAS 8330L")]
    public const int ERROR_DS_PARENT_IS_AN_ALIAS = 8330;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MIX_MASTER_AND_REPS"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MIX_MASTER_AND_REPS 8331L")]
    public const int ERROR_DS_CANT_MIX_MASTER_AND_REPS = 8331;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CHILDREN_EXIST"]/*' />
    [NativeTypeName("#define ERROR_DS_CHILDREN_EXIST 8332L")]
    public const int ERROR_DS_CHILDREN_EXIST = 8332;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJ_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJ_NOT_FOUND 8333L")]
    public const int ERROR_DS_OBJ_NOT_FOUND = 8333;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ALIASED_OBJ_MISSING"]/*' />
    [NativeTypeName("#define ERROR_DS_ALIASED_OBJ_MISSING 8334L")]
    public const int ERROR_DS_ALIASED_OBJ_MISSING = 8334;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_BAD_NAME_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_DS_BAD_NAME_SYNTAX 8335L")]
    public const int ERROR_DS_BAD_NAME_SYNTAX = 8335;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ALIAS_POINTS_TO_ALIAS"]/*' />
    [NativeTypeName("#define ERROR_DS_ALIAS_POINTS_TO_ALIAS 8336L")]
    public const int ERROR_DS_ALIAS_POINTS_TO_ALIAS = 8336;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_DEREF_ALIAS"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_DEREF_ALIAS 8337L")]
    public const int ERROR_DS_CANT_DEREF_ALIAS = 8337;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OUT_OF_SCOPE"]/*' />
    [NativeTypeName("#define ERROR_DS_OUT_OF_SCOPE 8338L")]
    public const int ERROR_DS_OUT_OF_SCOPE = 8338;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJECT_BEING_REMOVED"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJECT_BEING_REMOVED 8339L")]
    public const int ERROR_DS_OBJECT_BEING_REMOVED = 8339;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_DELETE_DSA_OBJ"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_DELETE_DSA_OBJ 8340L")]
    public const int ERROR_DS_CANT_DELETE_DSA_OBJ = 8340;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GENERIC_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_GENERIC_ERROR 8341L")]
    public const int ERROR_DS_GENERIC_ERROR = 8341;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DSA_MUST_BE_INT_MASTER"]/*' />
    [NativeTypeName("#define ERROR_DS_DSA_MUST_BE_INT_MASTER 8342L")]
    public const int ERROR_DS_DSA_MUST_BE_INT_MASTER = 8342;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CLASS_NOT_DSA"]/*' />
    [NativeTypeName("#define ERROR_DS_CLASS_NOT_DSA 8343L")]
    public const int ERROR_DS_CLASS_NOT_DSA = 8343;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INSUFF_ACCESS_RIGHTS"]/*' />
    [NativeTypeName("#define ERROR_DS_INSUFF_ACCESS_RIGHTS 8344L")]
    public const int ERROR_DS_INSUFF_ACCESS_RIGHTS = 8344;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ILLEGAL_SUPERIOR"]/*' />
    [NativeTypeName("#define ERROR_DS_ILLEGAL_SUPERIOR 8345L")]
    public const int ERROR_DS_ILLEGAL_SUPERIOR = 8345;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATTRIBUTE_OWNED_BY_SAM"]/*' />
    [NativeTypeName("#define ERROR_DS_ATTRIBUTE_OWNED_BY_SAM 8346L")]
    public const int ERROR_DS_ATTRIBUTE_OWNED_BY_SAM = 8346;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_TOO_MANY_PARTS"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_TOO_MANY_PARTS 8347L")]
    public const int ERROR_DS_NAME_TOO_MANY_PARTS = 8347;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_TOO_LONG 8348L")]
    public const int ERROR_DS_NAME_TOO_LONG = 8348;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_VALUE_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_VALUE_TOO_LONG 8349L")]
    public const int ERROR_DS_NAME_VALUE_TOO_LONG = 8349;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_UNPARSEABLE"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_UNPARSEABLE 8350L")]
    public const int ERROR_DS_NAME_UNPARSEABLE = 8350;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_TYPE_UNKNOWN"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_TYPE_UNKNOWN 8351L")]
    public const int ERROR_DS_NAME_TYPE_UNKNOWN = 8351;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NOT_AN_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_DS_NOT_AN_OBJECT 8352L")]
    public const int ERROR_DS_NOT_AN_OBJECT = 8352;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SEC_DESC_TOO_SHORT"]/*' />
    [NativeTypeName("#define ERROR_DS_SEC_DESC_TOO_SHORT 8353L")]
    public const int ERROR_DS_SEC_DESC_TOO_SHORT = 8353;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SEC_DESC_INVALID"]/*' />
    [NativeTypeName("#define ERROR_DS_SEC_DESC_INVALID 8354L")]
    public const int ERROR_DS_SEC_DESC_INVALID = 8354;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_DELETED_NAME"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_DELETED_NAME 8355L")]
    public const int ERROR_DS_NO_DELETED_NAME = 8355;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SUBREF_MUST_HAVE_PARENT"]/*' />
    [NativeTypeName("#define ERROR_DS_SUBREF_MUST_HAVE_PARENT 8356L")]
    public const int ERROR_DS_SUBREF_MUST_HAVE_PARENT = 8356;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NCNAME_MUST_BE_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_NCNAME_MUST_BE_NC 8357L")]
    public const int ERROR_DS_NCNAME_MUST_BE_NC = 8357;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_ADD_SYSTEM_ONLY"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_ADD_SYSTEM_ONLY 8358L")]
    public const int ERROR_DS_CANT_ADD_SYSTEM_ONLY = 8358;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CLASS_MUST_BE_CONCRETE"]/*' />
    [NativeTypeName("#define ERROR_DS_CLASS_MUST_BE_CONCRETE 8359L")]
    public const int ERROR_DS_CLASS_MUST_BE_CONCRETE = 8359;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_DMD"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_DMD 8360L")]
    public const int ERROR_DS_INVALID_DMD = 8360;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJ_GUID_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJ_GUID_EXISTS 8361L")]
    public const int ERROR_DS_OBJ_GUID_EXISTS = 8361;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NOT_ON_BACKLINK"]/*' />
    [NativeTypeName("#define ERROR_DS_NOT_ON_BACKLINK 8362L")]
    public const int ERROR_DS_NOT_ON_BACKLINK = 8362;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_CROSSREF_FOR_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_CROSSREF_FOR_NC 8363L")]
    public const int ERROR_DS_NO_CROSSREF_FOR_NC = 8363;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SHUTTING_DOWN"]/*' />
    [NativeTypeName("#define ERROR_DS_SHUTTING_DOWN 8364L")]
    public const int ERROR_DS_SHUTTING_DOWN = 8364;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNKNOWN_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_DS_UNKNOWN_OPERATION 8365L")]
    public const int ERROR_DS_UNKNOWN_OPERATION = 8365;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_ROLE_OWNER"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_ROLE_OWNER 8366L")]
    public const int ERROR_DS_INVALID_ROLE_OWNER = 8366;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_COULDNT_CONTACT_FSMO"]/*' />
    [NativeTypeName("#define ERROR_DS_COULDNT_CONTACT_FSMO 8367L")]
    public const int ERROR_DS_COULDNT_CONTACT_FSMO = 8367;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CROSS_NC_DN_RENAME"]/*' />
    [NativeTypeName("#define ERROR_DS_CROSS_NC_DN_RENAME 8368L")]
    public const int ERROR_DS_CROSS_NC_DN_RENAME = 8368;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MOD_SYSTEM_ONLY"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MOD_SYSTEM_ONLY 8369L")]
    public const int ERROR_DS_CANT_MOD_SYSTEM_ONLY = 8369;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_REPLICATOR_ONLY"]/*' />
    [NativeTypeName("#define ERROR_DS_REPLICATOR_ONLY 8370L")]
    public const int ERROR_DS_REPLICATOR_ONLY = 8370;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJ_CLASS_NOT_DEFINED"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJ_CLASS_NOT_DEFINED 8371L")]
    public const int ERROR_DS_OBJ_CLASS_NOT_DEFINED = 8371;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OBJ_CLASS_NOT_SUBCLASS"]/*' />
    [NativeTypeName("#define ERROR_DS_OBJ_CLASS_NOT_SUBCLASS 8372L")]
    public const int ERROR_DS_OBJ_CLASS_NOT_SUBCLASS = 8372;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_REFERENCE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_REFERENCE_INVALID 8373L")]
    public const int ERROR_DS_NAME_REFERENCE_INVALID = 8373;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CROSS_REF_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DS_CROSS_REF_EXISTS 8374L")]
    public const int ERROR_DS_CROSS_REF_EXISTS = 8374;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_DEL_MASTER_CROSSREF"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_DEL_MASTER_CROSSREF 8375L")]
    public const int ERROR_DS_CANT_DEL_MASTER_CROSSREF = 8375;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD"]/*' />
    [NativeTypeName("#define ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD 8376L")]
    public const int ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD = 8376;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX"]/*' />
    [NativeTypeName("#define ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX 8377L")]
    public const int ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX = 8377;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DUP_RDN"]/*' />
    [NativeTypeName("#define ERROR_DS_DUP_RDN 8378L")]
    public const int ERROR_DS_DUP_RDN = 8378;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DUP_OID"]/*' />
    [NativeTypeName("#define ERROR_DS_DUP_OID 8379L")]
    public const int ERROR_DS_DUP_OID = 8379;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DUP_MAPI_ID"]/*' />
    [NativeTypeName("#define ERROR_DS_DUP_MAPI_ID 8380L")]
    public const int ERROR_DS_DUP_MAPI_ID = 8380;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DUP_SCHEMA_ID_GUID"]/*' />
    [NativeTypeName("#define ERROR_DS_DUP_SCHEMA_ID_GUID 8381L")]
    public const int ERROR_DS_DUP_SCHEMA_ID_GUID = 8381;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DUP_LDAP_DISPLAY_NAME"]/*' />
    [NativeTypeName("#define ERROR_DS_DUP_LDAP_DISPLAY_NAME 8382L")]
    public const int ERROR_DS_DUP_LDAP_DISPLAY_NAME = 8382;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SEMANTIC_ATT_TEST"]/*' />
    [NativeTypeName("#define ERROR_DS_SEMANTIC_ATT_TEST 8383L")]
    public const int ERROR_DS_SEMANTIC_ATT_TEST = 8383;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SYNTAX_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_SYNTAX_MISMATCH 8384L")]
    public const int ERROR_DS_SYNTAX_MISMATCH = 8384;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_EXISTS_IN_MUST_HAVE"]/*' />
    [NativeTypeName("#define ERROR_DS_EXISTS_IN_MUST_HAVE 8385L")]
    public const int ERROR_DS_EXISTS_IN_MUST_HAVE = 8385;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_EXISTS_IN_MAY_HAVE"]/*' />
    [NativeTypeName("#define ERROR_DS_EXISTS_IN_MAY_HAVE 8386L")]
    public const int ERROR_DS_EXISTS_IN_MAY_HAVE = 8386;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NONEXISTENT_MAY_HAVE"]/*' />
    [NativeTypeName("#define ERROR_DS_NONEXISTENT_MAY_HAVE 8387L")]
    public const int ERROR_DS_NONEXISTENT_MAY_HAVE = 8387;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NONEXISTENT_MUST_HAVE"]/*' />
    [NativeTypeName("#define ERROR_DS_NONEXISTENT_MUST_HAVE 8388L")]
    public const int ERROR_DS_NONEXISTENT_MUST_HAVE = 8388;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_AUX_CLS_TEST_FAIL"]/*' />
    [NativeTypeName("#define ERROR_DS_AUX_CLS_TEST_FAIL 8389L")]
    public const int ERROR_DS_AUX_CLS_TEST_FAIL = 8389;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NONEXISTENT_POSS_SUP"]/*' />
    [NativeTypeName("#define ERROR_DS_NONEXISTENT_POSS_SUP 8390L")]
    public const int ERROR_DS_NONEXISTENT_POSS_SUP = 8390;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SUB_CLS_TEST_FAIL"]/*' />
    [NativeTypeName("#define ERROR_DS_SUB_CLS_TEST_FAIL 8391L")]
    public const int ERROR_DS_SUB_CLS_TEST_FAIL = 8391;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_BAD_RDN_ATT_ID_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_DS_BAD_RDN_ATT_ID_SYNTAX 8392L")]
    public const int ERROR_DS_BAD_RDN_ATT_ID_SYNTAX = 8392;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_EXISTS_IN_AUX_CLS"]/*' />
    [NativeTypeName("#define ERROR_DS_EXISTS_IN_AUX_CLS 8393L")]
    public const int ERROR_DS_EXISTS_IN_AUX_CLS = 8393;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_EXISTS_IN_SUB_CLS"]/*' />
    [NativeTypeName("#define ERROR_DS_EXISTS_IN_SUB_CLS 8394L")]
    public const int ERROR_DS_EXISTS_IN_SUB_CLS = 8394;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_EXISTS_IN_POSS_SUP"]/*' />
    [NativeTypeName("#define ERROR_DS_EXISTS_IN_POSS_SUP 8395L")]
    public const int ERROR_DS_EXISTS_IN_POSS_SUP = 8395;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_RECALCSCHEMA_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_RECALCSCHEMA_FAILED 8396L")]
    public const int ERROR_DS_RECALCSCHEMA_FAILED = 8396;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_TREE_DELETE_NOT_FINISHED"]/*' />
    [NativeTypeName("#define ERROR_DS_TREE_DELETE_NOT_FINISHED 8397L")]
    public const int ERROR_DS_TREE_DELETE_NOT_FINISHED = 8397;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_DELETE"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_DELETE 8398L")]
    public const int ERROR_DS_CANT_DELETE = 8398;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATT_SCHEMA_REQ_ID"]/*' />
    [NativeTypeName("#define ERROR_DS_ATT_SCHEMA_REQ_ID 8399L")]
    public const int ERROR_DS_ATT_SCHEMA_REQ_ID = 8399;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_BAD_ATT_SCHEMA_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_DS_BAD_ATT_SCHEMA_SYNTAX 8400L")]
    public const int ERROR_DS_BAD_ATT_SCHEMA_SYNTAX = 8400;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_CACHE_ATT"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_CACHE_ATT 8401L")]
    public const int ERROR_DS_CANT_CACHE_ATT = 8401;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_CACHE_CLASS"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_CACHE_CLASS 8402L")]
    public const int ERROR_DS_CANT_CACHE_CLASS = 8402;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_REMOVE_ATT_CACHE"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_REMOVE_ATT_CACHE 8403L")]
    public const int ERROR_DS_CANT_REMOVE_ATT_CACHE = 8403;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_REMOVE_CLASS_CACHE"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_REMOVE_CLASS_CACHE 8404L")]
    public const int ERROR_DS_CANT_REMOVE_CLASS_CACHE = 8404;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_RETRIEVE_DN"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_RETRIEVE_DN 8405L")]
    public const int ERROR_DS_CANT_RETRIEVE_DN = 8405;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MISSING_SUPREF"]/*' />
    [NativeTypeName("#define ERROR_DS_MISSING_SUPREF 8406L")]
    public const int ERROR_DS_MISSING_SUPREF = 8406;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_RETRIEVE_INSTANCE"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_RETRIEVE_INSTANCE 8407L")]
    public const int ERROR_DS_CANT_RETRIEVE_INSTANCE = 8407;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CODE_INCONSISTENCY"]/*' />
    [NativeTypeName("#define ERROR_DS_CODE_INCONSISTENCY 8408L")]
    public const int ERROR_DS_CODE_INCONSISTENCY = 8408;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DATABASE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_DATABASE_ERROR 8409L")]
    public const int ERROR_DS_DATABASE_ERROR = 8409;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GOVERNSID_MISSING"]/*' />
    [NativeTypeName("#define ERROR_DS_GOVERNSID_MISSING 8410L")]
    public const int ERROR_DS_GOVERNSID_MISSING = 8410;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MISSING_EXPECTED_ATT"]/*' />
    [NativeTypeName("#define ERROR_DS_MISSING_EXPECTED_ATT 8411L")]
    public const int ERROR_DS_MISSING_EXPECTED_ATT = 8411;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NCNAME_MISSING_CR_REF"]/*' />
    [NativeTypeName("#define ERROR_DS_NCNAME_MISSING_CR_REF 8412L")]
    public const int ERROR_DS_NCNAME_MISSING_CR_REF = 8412;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SECURITY_CHECKING_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_SECURITY_CHECKING_ERROR 8413L")]
    public const int ERROR_DS_SECURITY_CHECKING_ERROR = 8413;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SCHEMA_NOT_LOADED"]/*' />
    [NativeTypeName("#define ERROR_DS_SCHEMA_NOT_LOADED 8414L")]
    public const int ERROR_DS_SCHEMA_NOT_LOADED = 8414;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SCHEMA_ALLOC_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_SCHEMA_ALLOC_FAILED 8415L")]
    public const int ERROR_DS_SCHEMA_ALLOC_FAILED = 8415;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ATT_SCHEMA_REQ_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_DS_ATT_SCHEMA_REQ_SYNTAX 8416L")]
    public const int ERROR_DS_ATT_SCHEMA_REQ_SYNTAX = 8416;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GCVERIFY_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_GCVERIFY_ERROR 8417L")]
    public const int ERROR_DS_GCVERIFY_ERROR = 8417;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SCHEMA_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SCHEMA_MISMATCH 8418L")]
    public const int ERROR_DS_DRA_SCHEMA_MISMATCH = 8418;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_FIND_DSA_OBJ"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_FIND_DSA_OBJ 8419L")]
    public const int ERROR_DS_CANT_FIND_DSA_OBJ = 8419;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_FIND_EXPECTED_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_FIND_EXPECTED_NC 8420L")]
    public const int ERROR_DS_CANT_FIND_EXPECTED_NC = 8420;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_FIND_NC_IN_CACHE"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_FIND_NC_IN_CACHE 8421L")]
    public const int ERROR_DS_CANT_FIND_NC_IN_CACHE = 8421;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_RETRIEVE_CHILD"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_RETRIEVE_CHILD 8422L")]
    public const int ERROR_DS_CANT_RETRIEVE_CHILD = 8422;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SECURITY_ILLEGAL_MODIFY"]/*' />
    [NativeTypeName("#define ERROR_DS_SECURITY_ILLEGAL_MODIFY 8423L")]
    public const int ERROR_DS_SECURITY_ILLEGAL_MODIFY = 8423;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_REPLACE_HIDDEN_REC"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_REPLACE_HIDDEN_REC 8424L")]
    public const int ERROR_DS_CANT_REPLACE_HIDDEN_REC = 8424;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_BAD_HIERARCHY_FILE"]/*' />
    [NativeTypeName("#define ERROR_DS_BAD_HIERARCHY_FILE 8425L")]
    public const int ERROR_DS_BAD_HIERARCHY_FILE = 8425;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED 8426L")]
    public const int ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED = 8426;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CONFIG_PARAM_MISSING"]/*' />
    [NativeTypeName("#define ERROR_DS_CONFIG_PARAM_MISSING 8427L")]
    public const int ERROR_DS_CONFIG_PARAM_MISSING = 8427;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_COUNTING_AB_INDICES_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_COUNTING_AB_INDICES_FAILED 8428L")]
    public const int ERROR_DS_COUNTING_AB_INDICES_FAILED = 8428;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED 8429L")]
    public const int ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED = 8429;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INTERNAL_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_DS_INTERNAL_FAILURE 8430L")]
    public const int ERROR_DS_INTERNAL_FAILURE = 8430;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_UNKNOWN_ERROR 8431L")]
    public const int ERROR_DS_UNKNOWN_ERROR = 8431;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ROOT_REQUIRES_CLASS_TOP"]/*' />
    [NativeTypeName("#define ERROR_DS_ROOT_REQUIRES_CLASS_TOP 8432L")]
    public const int ERROR_DS_ROOT_REQUIRES_CLASS_TOP = 8432;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_REFUSING_FSMO_ROLES"]/*' />
    [NativeTypeName("#define ERROR_DS_REFUSING_FSMO_ROLES 8433L")]
    public const int ERROR_DS_REFUSING_FSMO_ROLES = 8433;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MISSING_FSMO_SETTINGS"]/*' />
    [NativeTypeName("#define ERROR_DS_MISSING_FSMO_SETTINGS 8434L")]
    public const int ERROR_DS_MISSING_FSMO_SETTINGS = 8434;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNABLE_TO_SURRENDER_ROLES"]/*' />
    [NativeTypeName("#define ERROR_DS_UNABLE_TO_SURRENDER_ROLES 8435L")]
    public const int ERROR_DS_UNABLE_TO_SURRENDER_ROLES = 8435;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_GENERIC"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_GENERIC 8436L")]
    public const int ERROR_DS_DRA_GENERIC = 8436;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_INVALID_PARAMETER 8437L")]
    public const int ERROR_DS_DRA_INVALID_PARAMETER = 8437;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_BUSY"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_BUSY 8438L")]
    public const int ERROR_DS_DRA_BUSY = 8438;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_BAD_DN"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_BAD_DN 8439L")]
    public const int ERROR_DS_DRA_BAD_DN = 8439;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_BAD_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_BAD_NC 8440L")]
    public const int ERROR_DS_DRA_BAD_NC = 8440;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_DN_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_DN_EXISTS 8441L")]
    public const int ERROR_DS_DRA_DN_EXISTS = 8441;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_INTERNAL_ERROR 8442L")]
    public const int ERROR_DS_DRA_INTERNAL_ERROR = 8442;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_INCONSISTENT_DIT"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_INCONSISTENT_DIT 8443L")]
    public const int ERROR_DS_DRA_INCONSISTENT_DIT = 8443;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_CONNECTION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_CONNECTION_FAILED 8444L")]
    public const int ERROR_DS_DRA_CONNECTION_FAILED = 8444;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_BAD_INSTANCE_TYPE"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_BAD_INSTANCE_TYPE 8445L")]
    public const int ERROR_DS_DRA_BAD_INSTANCE_TYPE = 8445;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_OUT_OF_MEM"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_OUT_OF_MEM 8446L")]
    public const int ERROR_DS_DRA_OUT_OF_MEM = 8446;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_MAIL_PROBLEM"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_MAIL_PROBLEM 8447L")]
    public const int ERROR_DS_DRA_MAIL_PROBLEM = 8447;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_REF_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_REF_ALREADY_EXISTS 8448L")]
    public const int ERROR_DS_DRA_REF_ALREADY_EXISTS = 8448;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_REF_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_REF_NOT_FOUND 8449L")]
    public const int ERROR_DS_DRA_REF_NOT_FOUND = 8449;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_OBJ_IS_REP_SOURCE"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_OBJ_IS_REP_SOURCE 8450L")]
    public const int ERROR_DS_DRA_OBJ_IS_REP_SOURCE = 8450;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_DB_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_DB_ERROR 8451L")]
    public const int ERROR_DS_DRA_DB_ERROR = 8451;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_NO_REPLICA"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_NO_REPLICA 8452L")]
    public const int ERROR_DS_DRA_NO_REPLICA = 8452;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_ACCESS_DENIED 8453L")]
    public const int ERROR_DS_DRA_ACCESS_DENIED = 8453;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_NOT_SUPPORTED 8454L")]
    public const int ERROR_DS_DRA_NOT_SUPPORTED = 8454;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_RPC_CANCELLED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_RPC_CANCELLED 8455L")]
    public const int ERROR_DS_DRA_RPC_CANCELLED = 8455;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SOURCE_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SOURCE_DISABLED 8456L")]
    public const int ERROR_DS_DRA_SOURCE_DISABLED = 8456;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SINK_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SINK_DISABLED 8457L")]
    public const int ERROR_DS_DRA_SINK_DISABLED = 8457;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_NAME_COLLISION"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_NAME_COLLISION 8458L")]
    public const int ERROR_DS_DRA_NAME_COLLISION = 8458;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SOURCE_REINSTALLED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SOURCE_REINSTALLED 8459L")]
    public const int ERROR_DS_DRA_SOURCE_REINSTALLED = 8459;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_MISSING_PARENT"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_MISSING_PARENT 8460L")]
    public const int ERROR_DS_DRA_MISSING_PARENT = 8460;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_PREEMPTED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_PREEMPTED 8461L")]
    public const int ERROR_DS_DRA_PREEMPTED = 8461;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_ABANDON_SYNC"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_ABANDON_SYNC 8462L")]
    public const int ERROR_DS_DRA_ABANDON_SYNC = 8462;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SHUTDOWN"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SHUTDOWN 8463L")]
    public const int ERROR_DS_DRA_SHUTDOWN = 8463;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET 8464L")]
    public const int ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET = 8464;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA 8465L")]
    public const int ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA = 8465;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_EXTN_CONNECTION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_EXTN_CONNECTION_FAILED 8466L")]
    public const int ERROR_DS_DRA_EXTN_CONNECTION_FAILED = 8466;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INSTALL_SCHEMA_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_INSTALL_SCHEMA_MISMATCH 8467L")]
    public const int ERROR_DS_INSTALL_SCHEMA_MISMATCH = 8467;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DUP_LINK_ID"]/*' />
    [NativeTypeName("#define ERROR_DS_DUP_LINK_ID 8468L")]
    public const int ERROR_DS_DUP_LINK_ID = 8468;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_ERROR_RESOLVING"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_ERROR_RESOLVING 8469L")]
    public const int ERROR_DS_NAME_ERROR_RESOLVING = 8469;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_ERROR_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_ERROR_NOT_FOUND 8470L")]
    public const int ERROR_DS_NAME_ERROR_NOT_FOUND = 8470;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_ERROR_NOT_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_ERROR_NOT_UNIQUE 8471L")]
    public const int ERROR_DS_NAME_ERROR_NOT_UNIQUE = 8471;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_ERROR_NO_MAPPING"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_ERROR_NO_MAPPING 8472L")]
    public const int ERROR_DS_NAME_ERROR_NO_MAPPING = 8472;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_ERROR_DOMAIN_ONLY"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_ERROR_DOMAIN_ONLY 8473L")]
    public const int ERROR_DS_NAME_ERROR_DOMAIN_ONLY = 8473;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING 8474L")]
    public const int ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING = 8474;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CONSTRUCTED_ATT_MOD"]/*' />
    [NativeTypeName("#define ERROR_DS_CONSTRUCTED_ATT_MOD 8475L")]
    public const int ERROR_DS_CONSTRUCTED_ATT_MOD = 8475;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_WRONG_OM_OBJ_CLASS"]/*' />
    [NativeTypeName("#define ERROR_DS_WRONG_OM_OBJ_CLASS 8476L")]
    public const int ERROR_DS_WRONG_OM_OBJ_CLASS = 8476;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_REPL_PENDING"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_REPL_PENDING 8477L")]
    public const int ERROR_DS_DRA_REPL_PENDING = 8477;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DS_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_DS_DS_REQUIRED 8478L")]
    public const int ERROR_DS_DS_REQUIRED = 8478;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_LDAP_DISPLAY_NAME"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_LDAP_DISPLAY_NAME 8479L")]
    public const int ERROR_DS_INVALID_LDAP_DISPLAY_NAME = 8479;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NON_BASE_SEARCH"]/*' />
    [NativeTypeName("#define ERROR_DS_NON_BASE_SEARCH 8480L")]
    public const int ERROR_DS_NON_BASE_SEARCH = 8480;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_RETRIEVE_ATTS"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_RETRIEVE_ATTS 8481L")]
    public const int ERROR_DS_CANT_RETRIEVE_ATTS = 8481;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_BACKLINK_WITHOUT_LINK"]/*' />
    [NativeTypeName("#define ERROR_DS_BACKLINK_WITHOUT_LINK 8482L")]
    public const int ERROR_DS_BACKLINK_WITHOUT_LINK = 8482;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_EPOCH_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_EPOCH_MISMATCH 8483L")]
    public const int ERROR_DS_EPOCH_MISMATCH = 8483;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SRC_NAME_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_SRC_NAME_MISMATCH 8484L")]
    public const int ERROR_DS_SRC_NAME_MISMATCH = 8484;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SRC_AND_DST_NC_IDENTICAL"]/*' />
    [NativeTypeName("#define ERROR_DS_SRC_AND_DST_NC_IDENTICAL 8485L")]
    public const int ERROR_DS_SRC_AND_DST_NC_IDENTICAL = 8485;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DST_NC_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_DST_NC_MISMATCH 8486L")]
    public const int ERROR_DS_DST_NC_MISMATCH = 8486;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC 8487L")]
    public const int ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC = 8487;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SRC_GUID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_SRC_GUID_MISMATCH 8488L")]
    public const int ERROR_DS_SRC_GUID_MISMATCH = 8488;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MOVE_DELETED_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MOVE_DELETED_OBJECT 8489L")]
    public const int ERROR_DS_CANT_MOVE_DELETED_OBJECT = 8489;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_PDC_OPERATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_DS_PDC_OPERATION_IN_PROGRESS 8490L")]
    public const int ERROR_DS_PDC_OPERATION_IN_PROGRESS = 8490;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD"]/*' />
    [NativeTypeName("#define ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD 8491L")]
    public const int ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD = 8491;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION 8492L")]
    public const int ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION = 8492;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS 8493L")]
    public const int ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS = 8493;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NC_MUST_HAVE_NC_PARENT"]/*' />
    [NativeTypeName("#define ERROR_DS_NC_MUST_HAVE_NC_PARENT 8494L")]
    public const int ERROR_DS_NC_MUST_HAVE_NC_PARENT = 8494;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE"]/*' />
    [NativeTypeName("#define ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE 8495L")]
    public const int ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE = 8495;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DST_DOMAIN_NOT_NATIVE"]/*' />
    [NativeTypeName("#define ERROR_DS_DST_DOMAIN_NOT_NATIVE 8496L")]
    public const int ERROR_DS_DST_DOMAIN_NOT_NATIVE = 8496;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER"]/*' />
    [NativeTypeName("#define ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER 8497L")]
    public const int ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER = 8497;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MOVE_ACCOUNT_GROUP"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MOVE_ACCOUNT_GROUP 8498L")]
    public const int ERROR_DS_CANT_MOVE_ACCOUNT_GROUP = 8498;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MOVE_RESOURCE_GROUP"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MOVE_RESOURCE_GROUP 8499L")]
    public const int ERROR_DS_CANT_MOVE_RESOURCE_GROUP = 8499;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_SEARCH_FLAG"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_SEARCH_FLAG 8500L")]
    public const int ERROR_DS_INVALID_SEARCH_FLAG = 8500;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_TREE_DELETE_ABOVE_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_TREE_DELETE_ABOVE_NC 8501L")]
    public const int ERROR_DS_NO_TREE_DELETE_ABOVE_NC = 8501;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE"]/*' />
    [NativeTypeName("#define ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE 8502L")]
    public const int ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE = 8502;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE"]/*' />
    [NativeTypeName("#define ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE 8503L")]
    public const int ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE = 8503;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SAM_INIT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_DS_SAM_INIT_FAILURE 8504L")]
    public const int ERROR_DS_SAM_INIT_FAILURE = 8504;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SENSITIVE_GROUP_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_DS_SENSITIVE_GROUP_VIOLATION 8505L")]
    public const int ERROR_DS_SENSITIVE_GROUP_VIOLATION = 8505;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MOD_PRIMARYGROUPID"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MOD_PRIMARYGROUPID 8506L")]
    public const int ERROR_DS_CANT_MOD_PRIMARYGROUPID = 8506;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD"]/*' />
    [NativeTypeName("#define ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD 8507L")]
    public const int ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD = 8507;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NONSAFE_SCHEMA_CHANGE"]/*' />
    [NativeTypeName("#define ERROR_DS_NONSAFE_SCHEMA_CHANGE 8508L")]
    public const int ERROR_DS_NONSAFE_SCHEMA_CHANGE = 8508;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SCHEMA_UPDATE_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_DS_SCHEMA_UPDATE_DISALLOWED 8509L")]
    public const int ERROR_DS_SCHEMA_UPDATE_DISALLOWED = 8509;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_CREATE_UNDER_SCHEMA"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_CREATE_UNDER_SCHEMA 8510L")]
    public const int ERROR_DS_CANT_CREATE_UNDER_SCHEMA = 8510;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INSTALL_NO_SRC_SCH_VERSION"]/*' />
    [NativeTypeName("#define ERROR_DS_INSTALL_NO_SRC_SCH_VERSION 8511L")]
    public const int ERROR_DS_INSTALL_NO_SRC_SCH_VERSION = 8511;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE"]/*' />
    [NativeTypeName("#define ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE 8512L")]
    public const int ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE = 8512;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_GROUP_TYPE"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_GROUP_TYPE 8513L")]
    public const int ERROR_DS_INVALID_GROUP_TYPE = 8513;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN 8514L")]
    public const int ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = 8514;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN 8515L")]
    public const int ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = 8515;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER 8516L")]
    public const int ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = 8516;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER 8517L")]
    public const int ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = 8517;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER 8518L")]
    public const int ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = 8518;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER 8519L")]
    public const int ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = 8519;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER 8520L")]
    public const int ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = 8520;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_HAVE_PRIMARY_MEMBERS"]/*' />
    [NativeTypeName("#define ERROR_DS_HAVE_PRIMARY_MEMBERS 8521L")]
    public const int ERROR_DS_HAVE_PRIMARY_MEMBERS = 8521;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_STRING_SD_CONVERSION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_STRING_SD_CONVERSION_FAILED 8522L")]
    public const int ERROR_DS_STRING_SD_CONVERSION_FAILED = 8522;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAMING_MASTER_GC"]/*' />
    [NativeTypeName("#define ERROR_DS_NAMING_MASTER_GC 8523L")]
    public const int ERROR_DS_NAMING_MASTER_GC = 8523;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DNS_LOOKUP_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_DS_DNS_LOOKUP_FAILURE 8524L")]
    public const int ERROR_DS_DNS_LOOKUP_FAILURE = 8524;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_COULDNT_UPDATE_SPNS"]/*' />
    [NativeTypeName("#define ERROR_DS_COULDNT_UPDATE_SPNS 8525L")]
    public const int ERROR_DS_COULDNT_UPDATE_SPNS = 8525;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_RETRIEVE_SD"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_RETRIEVE_SD 8526L")]
    public const int ERROR_DS_CANT_RETRIEVE_SD = 8526;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_KEY_NOT_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_DS_KEY_NOT_UNIQUE 8527L")]
    public const int ERROR_DS_KEY_NOT_UNIQUE = 8527;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_WRONG_LINKED_ATT_SYNTAX"]/*' />
    [NativeTypeName("#define ERROR_DS_WRONG_LINKED_ATT_SYNTAX 8528L")]
    public const int ERROR_DS_WRONG_LINKED_ATT_SYNTAX = 8528;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD"]/*' />
    [NativeTypeName("#define ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD 8529L")]
    public const int ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD = 8529;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY"]/*' />
    [NativeTypeName("#define ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY 8530L")]
    public const int ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY = 8530;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_START"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_START 8531L")]
    public const int ERROR_DS_CANT_START = 8531;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INIT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_DS_INIT_FAILURE 8532L")]
    public const int ERROR_DS_INIT_FAILURE = 8532;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION 8533L")]
    public const int ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION = 8533;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SOURCE_DOMAIN_IN_FOREST"]/*' />
    [NativeTypeName("#define ERROR_DS_SOURCE_DOMAIN_IN_FOREST 8534L")]
    public const int ERROR_DS_SOURCE_DOMAIN_IN_FOREST = 8534;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST"]/*' />
    [NativeTypeName("#define ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST 8535L")]
    public const int ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST = 8535;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED 8536L")]
    public const int ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED = 8536;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN 8537L")]
    public const int ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN = 8537;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER"]/*' />
    [NativeTypeName("#define ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER 8538L")]
    public const int ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER = 8538;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SRC_SID_EXISTS_IN_FOREST"]/*' />
    [NativeTypeName("#define ERROR_DS_SRC_SID_EXISTS_IN_FOREST 8539L")]
    public const int ERROR_DS_SRC_SID_EXISTS_IN_FOREST = 8539;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH 8540L")]
    public const int ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH = 8540;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SAM_INIT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_SAM_INIT_FAILURE 8541L")]
    public const int ERROR_SAM_INIT_FAILURE = 8541;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SCHEMA_INFO_SHIP"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SCHEMA_INFO_SHIP 8542L")]
    public const int ERROR_DS_DRA_SCHEMA_INFO_SHIP = 8542;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SCHEMA_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SCHEMA_CONFLICT 8543L")]
    public const int ERROR_DS_DRA_SCHEMA_CONFLICT = 8543;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT 8544L")]
    public const int ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT = 8544;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_OBJ_NC_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_OBJ_NC_MISMATCH 8545L")]
    public const int ERROR_DS_DRA_OBJ_NC_MISMATCH = 8545;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NC_STILL_HAS_DSAS"]/*' />
    [NativeTypeName("#define ERROR_DS_NC_STILL_HAS_DSAS 8546L")]
    public const int ERROR_DS_NC_STILL_HAS_DSAS = 8546;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GC_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_DS_GC_REQUIRED 8547L")]
    public const int ERROR_DS_GC_REQUIRED = 8547;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY"]/*' />
    [NativeTypeName("#define ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY 8548L")]
    public const int ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = 8548;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS 8549L")]
    public const int ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS = 8549;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_ADD_TO_GC"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_ADD_TO_GC 8550L")]
    public const int ERROR_DS_CANT_ADD_TO_GC = 8550;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_CHECKPOINT_WITH_PDC"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_CHECKPOINT_WITH_PDC 8551L")]
    public const int ERROR_DS_NO_CHECKPOINT_WITH_PDC = 8551;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SOURCE_AUDITING_NOT_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_DS_SOURCE_AUDITING_NOT_ENABLED 8552L")]
    public const int ERROR_DS_SOURCE_AUDITING_NOT_ENABLED = 8552;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC 8553L")]
    public const int ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC = 8553;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_NAME_FOR_SPN"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_NAME_FOR_SPN 8554L")]
    public const int ERROR_DS_INVALID_NAME_FOR_SPN = 8554;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS"]/*' />
    [NativeTypeName("#define ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS 8555L")]
    public const int ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS = 8555;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNICODEPWD_NOT_IN_QUOTES"]/*' />
    [NativeTypeName("#define ERROR_DS_UNICODEPWD_NOT_IN_QUOTES 8556L")]
    public const int ERROR_DS_UNICODEPWD_NOT_IN_QUOTES = 8556;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED 8557L")]
    public const int ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = 8557;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MUST_BE_RUN_ON_DST_DC"]/*' />
    [NativeTypeName("#define ERROR_DS_MUST_BE_RUN_ON_DST_DC 8558L")]
    public const int ERROR_DS_MUST_BE_RUN_ON_DST_DC = 8558;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER"]/*' />
    [NativeTypeName("#define ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER 8559L")]
    public const int ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER = 8559;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ 8560L")]
    public const int ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ = 8560;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INIT_FAILURE_CONSOLE"]/*' />
    [NativeTypeName("#define ERROR_DS_INIT_FAILURE_CONSOLE 8561L")]
    public const int ERROR_DS_INIT_FAILURE_CONSOLE = 8561;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SAM_INIT_FAILURE_CONSOLE"]/*' />
    [NativeTypeName("#define ERROR_DS_SAM_INIT_FAILURE_CONSOLE 8562L")]
    public const int ERROR_DS_SAM_INIT_FAILURE_CONSOLE = 8562;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_FOREST_VERSION_TOO_HIGH"]/*' />
    [NativeTypeName("#define ERROR_DS_FOREST_VERSION_TOO_HIGH 8563L")]
    public const int ERROR_DS_FOREST_VERSION_TOO_HIGH = 8563;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DOMAIN_VERSION_TOO_HIGH"]/*' />
    [NativeTypeName("#define ERROR_DS_DOMAIN_VERSION_TOO_HIGH 8564L")]
    public const int ERROR_DS_DOMAIN_VERSION_TOO_HIGH = 8564;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_FOREST_VERSION_TOO_LOW"]/*' />
    [NativeTypeName("#define ERROR_DS_FOREST_VERSION_TOO_LOW 8565L")]
    public const int ERROR_DS_FOREST_VERSION_TOO_LOW = 8565;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DOMAIN_VERSION_TOO_LOW"]/*' />
    [NativeTypeName("#define ERROR_DS_DOMAIN_VERSION_TOO_LOW 8566L")]
    public const int ERROR_DS_DOMAIN_VERSION_TOO_LOW = 8566;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INCOMPATIBLE_VERSION"]/*' />
    [NativeTypeName("#define ERROR_DS_INCOMPATIBLE_VERSION 8567L")]
    public const int ERROR_DS_INCOMPATIBLE_VERSION = 8567;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_LOW_DSA_VERSION"]/*' />
    [NativeTypeName("#define ERROR_DS_LOW_DSA_VERSION 8568L")]
    public const int ERROR_DS_LOW_DSA_VERSION = 8568;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN 8569L")]
    public const int ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN = 8569;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NOT_SUPPORTED_SORT_ORDER"]/*' />
    [NativeTypeName("#define ERROR_DS_NOT_SUPPORTED_SORT_ORDER 8570L")]
    public const int ERROR_DS_NOT_SUPPORTED_SORT_ORDER = 8570;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_NOT_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_NOT_UNIQUE 8571L")]
    public const int ERROR_DS_NAME_NOT_UNIQUE = 8571;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4"]/*' />
    [NativeTypeName("#define ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 8572L")]
    public const int ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 = 8572;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OUT_OF_VERSION_STORE"]/*' />
    [NativeTypeName("#define ERROR_DS_OUT_OF_VERSION_STORE 8573L")]
    public const int ERROR_DS_OUT_OF_VERSION_STORE = 8573;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INCOMPATIBLE_CONTROLS_USED"]/*' />
    [NativeTypeName("#define ERROR_DS_INCOMPATIBLE_CONTROLS_USED 8574L")]
    public const int ERROR_DS_INCOMPATIBLE_CONTROLS_USED = 8574;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_REF_DOMAIN"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_REF_DOMAIN 8575L")]
    public const int ERROR_DS_NO_REF_DOMAIN = 8575;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_RESERVED_LINK_ID"]/*' />
    [NativeTypeName("#define ERROR_DS_RESERVED_LINK_ID 8576L")]
    public const int ERROR_DS_RESERVED_LINK_ID = 8576;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_LINK_ID_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_DS_LINK_ID_NOT_AVAILABLE 8577L")]
    public const int ERROR_DS_LINK_ID_NOT_AVAILABLE = 8577;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER"]/*' />
    [NativeTypeName("#define ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER 8578L")]
    public const int ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = 8578;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE"]/*' />
    [NativeTypeName("#define ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE 8579L")]
    public const int ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE = 8579;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC 8580L")]
    public const int ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC = 8580;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG"]/*' />
    [NativeTypeName("#define ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG 8581L")]
    public const int ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG = 8581;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MODIFYDN_WRONG_GRANDPARENT"]/*' />
    [NativeTypeName("#define ERROR_DS_MODIFYDN_WRONG_GRANDPARENT 8582L")]
    public const int ERROR_DS_MODIFYDN_WRONG_GRANDPARENT = 8582;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NAME_ERROR_TRUST_REFERRAL"]/*' />
    [NativeTypeName("#define ERROR_DS_NAME_ERROR_TRUST_REFERRAL 8583L")]
    public const int ERROR_DS_NAME_ERROR_TRUST_REFERRAL = 8583;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER"]/*' />
    [NativeTypeName("#define ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER 8584L")]
    public const int ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER = 8584;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD 8585L")]
    public const int ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD = 8585;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2"]/*' />
    [NativeTypeName("#define ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 8586L")]
    public const int ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 = 8586;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_THREAD_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DS_THREAD_LIMIT_EXCEEDED 8587L")]
    public const int ERROR_DS_THREAD_LIMIT_EXCEEDED = 8587;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NOT_CLOSEST"]/*' />
    [NativeTypeName("#define ERROR_DS_NOT_CLOSEST 8588L")]
    public const int ERROR_DS_NOT_CLOSEST = 8588;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF 8589L")]
    public const int ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF = 8589;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SINGLE_USER_MODE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_SINGLE_USER_MODE_FAILED 8590L")]
    public const int ERROR_DS_SINGLE_USER_MODE_FAILED = 8590;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NTDSCRIPT_SYNTAX_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_NTDSCRIPT_SYNTAX_ERROR 8591L")]
    public const int ERROR_DS_NTDSCRIPT_SYNTAX_ERROR = 8591;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NTDSCRIPT_PROCESS_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_NTDSCRIPT_PROCESS_ERROR 8592L")]
    public const int ERROR_DS_NTDSCRIPT_PROCESS_ERROR = 8592;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DIFFERENT_REPL_EPOCHS"]/*' />
    [NativeTypeName("#define ERROR_DS_DIFFERENT_REPL_EPOCHS 8593L")]
    public const int ERROR_DS_DIFFERENT_REPL_EPOCHS = 8593;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRS_EXTENSIONS_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRS_EXTENSIONS_CHANGED 8594L")]
    public const int ERROR_DS_DRS_EXTENSIONS_CHANGED = 8594;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR"]/*' />
    [NativeTypeName("#define ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR 8595L")]
    public const int ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR = 8595;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_MSDS_INTID"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_MSDS_INTID 8596L")]
    public const int ERROR_DS_NO_MSDS_INTID = 8596;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DUP_MSDS_INTID"]/*' />
    [NativeTypeName("#define ERROR_DS_DUP_MSDS_INTID 8597L")]
    public const int ERROR_DS_DUP_MSDS_INTID = 8597;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_EXISTS_IN_RDNATTID"]/*' />
    [NativeTypeName("#define ERROR_DS_EXISTS_IN_RDNATTID 8598L")]
    public const int ERROR_DS_EXISTS_IN_RDNATTID = 8598;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_AUTHORIZATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_AUTHORIZATION_FAILED 8599L")]
    public const int ERROR_DS_AUTHORIZATION_FAILED = 8599;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_SCRIPT"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_SCRIPT 8600L")]
    public const int ERROR_DS_INVALID_SCRIPT = 8600;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_REMOTE_CROSSREF_OP_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_REMOTE_CROSSREF_OP_FAILED 8601L")]
    public const int ERROR_DS_REMOTE_CROSSREF_OP_FAILED = 8601;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CROSS_REF_BUSY"]/*' />
    [NativeTypeName("#define ERROR_DS_CROSS_REF_BUSY 8602L")]
    public const int ERROR_DS_CROSS_REF_BUSY = 8602;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN 8603L")]
    public const int ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN = 8603;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC 8604L")]
    public const int ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC = 8604;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DUPLICATE_ID_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DS_DUPLICATE_ID_FOUND 8605L")]
    public const int ERROR_DS_DUPLICATE_ID_FOUND = 8605;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT 8606L")]
    public const int ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT = 8606;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_GROUP_CONVERSION_ERROR"]/*' />
    [NativeTypeName("#define ERROR_DS_GROUP_CONVERSION_ERROR 8607L")]
    public const int ERROR_DS_GROUP_CONVERSION_ERROR = 8607;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MOVE_APP_BASIC_GROUP"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MOVE_APP_BASIC_GROUP 8608L")]
    public const int ERROR_DS_CANT_MOVE_APP_BASIC_GROUP = 8608;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_CANT_MOVE_APP_QUERY_GROUP"]/*' />
    [NativeTypeName("#define ERROR_DS_CANT_MOVE_APP_QUERY_GROUP 8609L")]
    public const int ERROR_DS_CANT_MOVE_APP_QUERY_GROUP = 8609;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_ROLE_NOT_VERIFIED"]/*' />
    [NativeTypeName("#define ERROR_DS_ROLE_NOT_VERIFIED 8610L")]
    public const int ERROR_DS_ROLE_NOT_VERIFIED = 8610;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL"]/*' />
    [NativeTypeName("#define ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL 8611L")]
    public const int ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL = 8611;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DOMAIN_RENAME_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_DS_DOMAIN_RENAME_IN_PROGRESS 8612L")]
    public const int ERROR_DS_DOMAIN_RENAME_IN_PROGRESS = 8612;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_EXISTING_AD_CHILD_NC"]/*' />
    [NativeTypeName("#define ERROR_DS_EXISTING_AD_CHILD_NC 8613L")]
    public const int ERROR_DS_EXISTING_AD_CHILD_NC = 8613;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_REPL_LIFETIME_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DS_REPL_LIFETIME_EXCEEDED 8614L")]
    public const int ERROR_DS_REPL_LIFETIME_EXCEEDED = 8614;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER"]/*' />
    [NativeTypeName("#define ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER 8615L")]
    public const int ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER = 8615;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_LDAP_SEND_QUEUE_FULL"]/*' />
    [NativeTypeName("#define ERROR_DS_LDAP_SEND_QUEUE_FULL 8616L")]
    public const int ERROR_DS_LDAP_SEND_QUEUE_FULL = 8616;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_OUT_SCHEDULE_WINDOW"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_OUT_SCHEDULE_WINDOW 8617L")]
    public const int ERROR_DS_DRA_OUT_SCHEDULE_WINDOW = 8617;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_POLICY_NOT_KNOWN"]/*' />
    [NativeTypeName("#define ERROR_DS_POLICY_NOT_KNOWN 8618L")]
    public const int ERROR_DS_POLICY_NOT_KNOWN = 8618;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SITE_SETTINGS_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_NO_SITE_SETTINGS_OBJECT 8619L")]
    public const int ERROR_NO_SITE_SETTINGS_OBJECT = 8619;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_SECRETS"]/*' />
    [NativeTypeName("#define ERROR_NO_SECRETS 8620L")]
    public const int ERROR_NO_SECRETS = 8620;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_WRITABLE_DC_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NO_WRITABLE_DC_FOUND 8621L")]
    public const int ERROR_NO_WRITABLE_DC_FOUND = 8621;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_SERVER_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_SERVER_OBJECT 8622L")]
    public const int ERROR_DS_NO_SERVER_OBJECT = 8622;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NO_NTDSA_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_DS_NO_NTDSA_OBJECT 8623L")]
    public const int ERROR_DS_NO_NTDSA_OBJECT = 8623;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_NON_ASQ_SEARCH"]/*' />
    [NativeTypeName("#define ERROR_DS_NON_ASQ_SEARCH 8624L")]
    public const int ERROR_DS_NON_ASQ_SEARCH = 8624;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_AUDIT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_DS_AUDIT_FAILURE 8625L")]
    public const int ERROR_DS_AUDIT_FAILURE = 8625;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE 8626L")]
    public const int ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE = 8626;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_INVALID_SEARCH_FLAG_TUPLE"]/*' />
    [NativeTypeName("#define ERROR_DS_INVALID_SEARCH_FLAG_TUPLE 8627L")]
    public const int ERROR_DS_INVALID_SEARCH_FLAG_TUPLE = 8627;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_HIERARCHY_TABLE_TOO_DEEP"]/*' />
    [NativeTypeName("#define ERROR_DS_HIERARCHY_TABLE_TOO_DEEP 8628L")]
    public const int ERROR_DS_HIERARCHY_TABLE_TOO_DEEP = 8628;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_CORRUPT_UTD_VECTOR"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_CORRUPT_UTD_VECTOR 8629L")]
    public const int ERROR_DS_DRA_CORRUPT_UTD_VECTOR = 8629;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_SECRETS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_SECRETS_DENIED 8630L")]
    public const int ERROR_DS_DRA_SECRETS_DENIED = 8630;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_RESERVED_MAPI_ID"]/*' />
    [NativeTypeName("#define ERROR_DS_RESERVED_MAPI_ID 8631L")]
    public const int ERROR_DS_RESERVED_MAPI_ID = 8631;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MAPI_ID_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_DS_MAPI_ID_NOT_AVAILABLE 8632L")]
    public const int ERROR_DS_MAPI_ID_NOT_AVAILABLE = 8632;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_MISSING_KRBTGT_SECRET"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_MISSING_KRBTGT_SECRET 8633L")]
    public const int ERROR_DS_DRA_MISSING_KRBTGT_SECRET = 8633;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST"]/*' />
    [NativeTypeName("#define ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST 8634L")]
    public const int ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST = 8634;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST"]/*' />
    [NativeTypeName("#define ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST 8635L")]
    public const int ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST = 8635;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_USER_PRINCIPAL_NAME"]/*' />
    [NativeTypeName("#define ERROR_INVALID_USER_PRINCIPAL_NAME 8636L")]
    public const int ERROR_INVALID_USER_PRINCIPAL_NAME = 8636;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS"]/*' />
    [NativeTypeName("#define ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS 8637L")]
    public const int ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS = 8637;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_OID_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_DS_OID_NOT_FOUND 8638L")]
    public const int ERROR_DS_OID_NOT_FOUND = 8638;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DRA_RECYCLED_TARGET"]/*' />
    [NativeTypeName("#define ERROR_DS_DRA_RECYCLED_TARGET 8639L")]
    public const int ERROR_DS_DRA_RECYCLED_TARGET = 8639;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_DISALLOWED_NC_REDIRECT"]/*' />
    [NativeTypeName("#define ERROR_DS_DISALLOWED_NC_REDIRECT 8640L")]
    public const int ERROR_DS_DISALLOWED_NC_REDIRECT = 8640;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_HIGH_ADLDS_FFL"]/*' />
    [NativeTypeName("#define ERROR_DS_HIGH_ADLDS_FFL 8641L")]
    public const int ERROR_DS_HIGH_ADLDS_FFL = 8641;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_HIGH_DSA_VERSION"]/*' />
    [NativeTypeName("#define ERROR_DS_HIGH_DSA_VERSION 8642L")]
    public const int ERROR_DS_HIGH_DSA_VERSION = 8642;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_LOW_ADLDS_FFL"]/*' />
    [NativeTypeName("#define ERROR_DS_LOW_ADLDS_FFL 8643L")]
    public const int ERROR_DS_LOW_ADLDS_FFL = 8643;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION"]/*' />
    [NativeTypeName("#define ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION 8644L")]
    public const int ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION = 8644;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED 8645L")]
    public const int ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED = 8645;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INCORRECT_ACCOUNT_TYPE"]/*' />
    [NativeTypeName("#define ERROR_INCORRECT_ACCOUNT_TYPE 8646L")]
    public const int ERROR_INCORRECT_ACCOUNT_TYPE = 8646;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_SPN_VALUE_NOT_UNIQUE_IN_FOREST"]/*' />
    [NativeTypeName("#define ERROR_DS_SPN_VALUE_NOT_UNIQUE_IN_FOREST 8647L")]
    public const int ERROR_DS_SPN_VALUE_NOT_UNIQUE_IN_FOREST = 8647;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_UPN_VALUE_NOT_UNIQUE_IN_FOREST"]/*' />
    [NativeTypeName("#define ERROR_DS_UPN_VALUE_NOT_UNIQUE_IN_FOREST 8648L")]
    public const int ERROR_DS_UPN_VALUE_NOT_UNIQUE_IN_FOREST = 8648;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_MISSING_FOREST_TRUST"]/*' />
    [NativeTypeName("#define ERROR_DS_MISSING_FOREST_TRUST 8649L")]
    public const int ERROR_DS_MISSING_FOREST_TRUST = 8649;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_VALUE_KEY_NOT_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_DS_VALUE_KEY_NOT_UNIQUE 8650L")]
    public const int ERROR_DS_VALUE_KEY_NOT_UNIQUE = 8650;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_WEAK_WHFBKEY_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_WEAK_WHFBKEY_BLOCKED 8651L")]
    public const int ERROR_WEAK_WHFBKEY_BLOCKED = 8651;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_PER_ATTRIBUTE_AUTHZ_FAILED_DURING_ADD"]/*' />
    [NativeTypeName("#define ERROR_DS_PER_ATTRIBUTE_AUTHZ_FAILED_DURING_ADD 8652L")]
    public const int ERROR_DS_PER_ATTRIBUTE_AUTHZ_FAILED_DURING_ADD = 8652;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LOCAL_POLICY_MODIFICATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_LOCAL_POLICY_MODIFICATION_NOT_SUPPORTED 8653L")]
    public const int ERROR_LOCAL_POLICY_MODIFICATION_NOT_SUPPORTED = 8653;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_POLICY_CONTROLLED_ACCOUNT"]/*' />
    [NativeTypeName("#define ERROR_POLICY_CONTROLLED_ACCOUNT 8654L")]
    public const int ERROR_POLICY_CONTROLLED_ACCOUNT = 8654;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LAPS_LEGACY_SCHEMA_MISSING"]/*' />
    [NativeTypeName("#define ERROR_LAPS_LEGACY_SCHEMA_MISSING 8655L")]
    public const int ERROR_LAPS_LEGACY_SCHEMA_MISSING = 8655;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LAPS_SCHEMA_MISSING"]/*' />
    [NativeTypeName("#define ERROR_LAPS_SCHEMA_MISSING 8656L")]
    public const int ERROR_LAPS_SCHEMA_MISSING = 8656;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LAPS_ENCRYPTION_REQUIRES_2016_DFL"]/*' />
    [NativeTypeName("#define ERROR_LAPS_ENCRYPTION_REQUIRES_2016_DFL 8657L")]
    public const int ERROR_LAPS_ENCRYPTION_REQUIRES_2016_DFL = 8657;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_LAPS_PROCESS_TERMINATED"]/*' />
    [NativeTypeName("#define ERROR_LAPS_PROCESS_TERMINATED 8658L")]
    public const int ERROR_LAPS_PROCESS_TERMINATED = 8658;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_JET_RECORD_TOO_BIG"]/*' />
    [NativeTypeName("#define ERROR_DS_JET_RECORD_TOO_BIG 8659L")]
    public const int ERROR_DS_JET_RECORD_TOO_BIG = 8659;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DS_REPLICA_PAGE_SIZE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_DS_REPLICA_PAGE_SIZE_MISMATCH 8660L")]
    public const int ERROR_DS_REPLICA_PAGE_SIZE_MISMATCH = 8660;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_QM_POLICY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_QM_POLICY_EXISTS 13000L")]
    public const int ERROR_IPSEC_QM_POLICY_EXISTS = 13000;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_QM_POLICY_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_QM_POLICY_NOT_FOUND 13001L")]
    public const int ERROR_IPSEC_QM_POLICY_NOT_FOUND = 13001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_QM_POLICY_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_QM_POLICY_IN_USE 13002L")]
    public const int ERROR_IPSEC_QM_POLICY_IN_USE = 13002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_POLICY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_POLICY_EXISTS 13003L")]
    public const int ERROR_IPSEC_MM_POLICY_EXISTS = 13003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_POLICY_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_POLICY_NOT_FOUND 13004L")]
    public const int ERROR_IPSEC_MM_POLICY_NOT_FOUND = 13004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_POLICY_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_POLICY_IN_USE 13005L")]
    public const int ERROR_IPSEC_MM_POLICY_IN_USE = 13005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_FILTER_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_FILTER_EXISTS 13006L")]
    public const int ERROR_IPSEC_MM_FILTER_EXISTS = 13006;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_FILTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_FILTER_NOT_FOUND 13007L")]
    public const int ERROR_IPSEC_MM_FILTER_NOT_FOUND = 13007;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_TRANSPORT_FILTER_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_TRANSPORT_FILTER_EXISTS 13008L")]
    public const int ERROR_IPSEC_TRANSPORT_FILTER_EXISTS = 13008;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND 13009L")]
    public const int ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND = 13009;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_AUTH_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_AUTH_EXISTS 13010L")]
    public const int ERROR_IPSEC_MM_AUTH_EXISTS = 13010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_AUTH_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_AUTH_NOT_FOUND 13011L")]
    public const int ERROR_IPSEC_MM_AUTH_NOT_FOUND = 13011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_AUTH_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_AUTH_IN_USE 13012L")]
    public const int ERROR_IPSEC_MM_AUTH_IN_USE = 13012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND 13013L")]
    public const int ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND = 13013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND 13014L")]
    public const int ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND = 13014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND 13015L")]
    public const int ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND = 13015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_TUNNEL_FILTER_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_TUNNEL_FILTER_EXISTS 13016L")]
    public const int ERROR_IPSEC_TUNNEL_FILTER_EXISTS = 13016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND 13017L")]
    public const int ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND = 13017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_FILTER_PENDING_DELETION"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_FILTER_PENDING_DELETION 13018L")]
    public const int ERROR_IPSEC_MM_FILTER_PENDING_DELETION = 13018;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION 13019L")]
    public const int ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION = 13019;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION 13020L")]
    public const int ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION = 13020;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_POLICY_PENDING_DELETION"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_POLICY_PENDING_DELETION 13021L")]
    public const int ERROR_IPSEC_MM_POLICY_PENDING_DELETION = 13021;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_MM_AUTH_PENDING_DELETION"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_MM_AUTH_PENDING_DELETION 13022L")]
    public const int ERROR_IPSEC_MM_AUTH_PENDING_DELETION = 13022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_QM_POLICY_PENDING_DELETION"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_QM_POLICY_PENDING_DELETION 13023L")]
    public const int ERROR_IPSEC_QM_POLICY_PENDING_DELETION = 13023;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NEG_STATUS_BEGIN"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NEG_STATUS_BEGIN 13800L")]
    public const int ERROR_IPSEC_IKE_NEG_STATUS_BEGIN = 13800;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_AUTH_FAIL"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_AUTH_FAIL 13801L")]
    public const int ERROR_IPSEC_IKE_AUTH_FAIL = 13801;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_ATTRIB_FAIL"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_ATTRIB_FAIL 13802L")]
    public const int ERROR_IPSEC_IKE_ATTRIB_FAIL = 13802;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NEGOTIATION_PENDING"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NEGOTIATION_PENDING 13803L")]
    public const int ERROR_IPSEC_IKE_NEGOTIATION_PENDING = 13803;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR 13804L")]
    public const int ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR = 13804;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_TIMED_OUT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_TIMED_OUT 13805L")]
    public const int ERROR_IPSEC_IKE_TIMED_OUT = 13805;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NO_CERT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NO_CERT 13806L")]
    public const int ERROR_IPSEC_IKE_NO_CERT = 13806;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_SA_DELETED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_SA_DELETED 13807L")]
    public const int ERROR_IPSEC_IKE_SA_DELETED = 13807;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_SA_REAPED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_SA_REAPED 13808L")]
    public const int ERROR_IPSEC_IKE_SA_REAPED = 13808;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_MM_ACQUIRE_DROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_MM_ACQUIRE_DROP 13809L")]
    public const int ERROR_IPSEC_IKE_MM_ACQUIRE_DROP = 13809;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_QM_ACQUIRE_DROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_QM_ACQUIRE_DROP 13810L")]
    public const int ERROR_IPSEC_IKE_QM_ACQUIRE_DROP = 13810;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_QUEUE_DROP_MM"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_QUEUE_DROP_MM 13811L")]
    public const int ERROR_IPSEC_IKE_QUEUE_DROP_MM = 13811;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM 13812L")]
    public const int ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM = 13812;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_DROP_NO_RESPONSE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_DROP_NO_RESPONSE 13813L")]
    public const int ERROR_IPSEC_IKE_DROP_NO_RESPONSE = 13813;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_MM_DELAY_DROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_MM_DELAY_DROP 13814L")]
    public const int ERROR_IPSEC_IKE_MM_DELAY_DROP = 13814;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_QM_DELAY_DROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_QM_DELAY_DROP 13815L")]
    public const int ERROR_IPSEC_IKE_QM_DELAY_DROP = 13815;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_ERROR 13816L")]
    public const int ERROR_IPSEC_IKE_ERROR = 13816;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_CRL_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_CRL_FAILED 13817L")]
    public const int ERROR_IPSEC_IKE_CRL_FAILED = 13817;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_KEY_USAGE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_KEY_USAGE 13818L")]
    public const int ERROR_IPSEC_IKE_INVALID_KEY_USAGE = 13818;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_CERT_TYPE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_CERT_TYPE 13819L")]
    public const int ERROR_IPSEC_IKE_INVALID_CERT_TYPE = 13819;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NO_PRIVATE_KEY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NO_PRIVATE_KEY 13820L")]
    public const int ERROR_IPSEC_IKE_NO_PRIVATE_KEY = 13820;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY 13821L")]
    public const int ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY = 13821;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_DH_FAIL"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_DH_FAIL 13822L")]
    public const int ERROR_IPSEC_IKE_DH_FAIL = 13822;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED 13823L")]
    public const int ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED = 13823;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_HEADER"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_HEADER 13824L")]
    public const int ERROR_IPSEC_IKE_INVALID_HEADER = 13824;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NO_POLICY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NO_POLICY 13825L")]
    public const int ERROR_IPSEC_IKE_NO_POLICY = 13825;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_SIGNATURE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_SIGNATURE 13826L")]
    public const int ERROR_IPSEC_IKE_INVALID_SIGNATURE = 13826;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_KERBEROS_ERROR"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_KERBEROS_ERROR 13827L")]
    public const int ERROR_IPSEC_IKE_KERBEROS_ERROR = 13827;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NO_PUBLIC_KEY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NO_PUBLIC_KEY 13828L")]
    public const int ERROR_IPSEC_IKE_NO_PUBLIC_KEY = 13828;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR 13829L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR = 13829;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_SA"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_SA 13830L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_SA = 13830;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_PROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_PROP 13831L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_PROP = 13831;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_TRANS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_TRANS 13832L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_TRANS = 13832;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_KE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_KE 13833L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_KE = 13833;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_ID"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_ID 13834L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_ID = 13834;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_CERT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_CERT 13835L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_CERT = 13835;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ 13836L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ = 13836;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_HASH"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_HASH 13837L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_HASH = 13837;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_SIG"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_SIG 13838L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_SIG = 13838;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_NONCE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_NONCE 13839L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_NONCE = 13839;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY 13840L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY = 13840;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_DELETE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_DELETE 13841L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_DELETE = 13841;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR 13842L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR = 13842;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_PAYLOAD"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_PAYLOAD 13843L")]
    public const int ERROR_IPSEC_IKE_INVALID_PAYLOAD = 13843;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_LOAD_SOFT_SA"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_LOAD_SOFT_SA 13844L")]
    public const int ERROR_IPSEC_IKE_LOAD_SOFT_SA = 13844;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN 13845L")]
    public const int ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN = 13845;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_COOKIE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_COOKIE 13846L")]
    public const int ERROR_IPSEC_IKE_INVALID_COOKIE = 13846;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NO_PEER_CERT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NO_PEER_CERT 13847L")]
    public const int ERROR_IPSEC_IKE_NO_PEER_CERT = 13847;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PEER_CRL_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PEER_CRL_FAILED 13848L")]
    public const int ERROR_IPSEC_IKE_PEER_CRL_FAILED = 13848;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_POLICY_CHANGE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_POLICY_CHANGE 13849L")]
    public const int ERROR_IPSEC_IKE_POLICY_CHANGE = 13849;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NO_MM_POLICY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NO_MM_POLICY 13850L")]
    public const int ERROR_IPSEC_IKE_NO_MM_POLICY = 13850;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NOTCBPRIV"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NOTCBPRIV 13851L")]
    public const int ERROR_IPSEC_IKE_NOTCBPRIV = 13851;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_SECLOADFAIL"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_SECLOADFAIL 13852L")]
    public const int ERROR_IPSEC_IKE_SECLOADFAIL = 13852;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_FAILSSPINIT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_FAILSSPINIT 13853L")]
    public const int ERROR_IPSEC_IKE_FAILSSPINIT = 13853;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_FAILQUERYSSP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_FAILQUERYSSP 13854L")]
    public const int ERROR_IPSEC_IKE_FAILQUERYSSP = 13854;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_SRVACQFAIL"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_SRVACQFAIL 13855L")]
    public const int ERROR_IPSEC_IKE_SRVACQFAIL = 13855;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_SRVQUERYCRED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_SRVQUERYCRED 13856L")]
    public const int ERROR_IPSEC_IKE_SRVQUERYCRED = 13856;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_GETSPIFAIL"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_GETSPIFAIL 13857L")]
    public const int ERROR_IPSEC_IKE_GETSPIFAIL = 13857;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_FILTER"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_FILTER 13858L")]
    public const int ERROR_IPSEC_IKE_INVALID_FILTER = 13858;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_OUT_OF_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_OUT_OF_MEMORY 13859L")]
    public const int ERROR_IPSEC_IKE_OUT_OF_MEMORY = 13859;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED 13860L")]
    public const int ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED = 13860;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_POLICY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_POLICY 13861L")]
    public const int ERROR_IPSEC_IKE_INVALID_POLICY = 13861;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_UNKNOWN_DOI"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_UNKNOWN_DOI 13862L")]
    public const int ERROR_IPSEC_IKE_UNKNOWN_DOI = 13862;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_SITUATION"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_SITUATION 13863L")]
    public const int ERROR_IPSEC_IKE_INVALID_SITUATION = 13863;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_DH_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_DH_FAILURE 13864L")]
    public const int ERROR_IPSEC_IKE_DH_FAILURE = 13864;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_GROUP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_GROUP 13865L")]
    public const int ERROR_IPSEC_IKE_INVALID_GROUP = 13865;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_ENCRYPT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_ENCRYPT 13866L")]
    public const int ERROR_IPSEC_IKE_ENCRYPT = 13866;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_DECRYPT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_DECRYPT 13867L")]
    public const int ERROR_IPSEC_IKE_DECRYPT = 13867;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_POLICY_MATCH"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_POLICY_MATCH 13868L")]
    public const int ERROR_IPSEC_IKE_POLICY_MATCH = 13868;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_UNSUPPORTED_ID"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_UNSUPPORTED_ID 13869L")]
    public const int ERROR_IPSEC_IKE_UNSUPPORTED_ID = 13869;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_HASH"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_HASH 13870L")]
    public const int ERROR_IPSEC_IKE_INVALID_HASH = 13870;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_HASH_ALG"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_HASH_ALG 13871L")]
    public const int ERROR_IPSEC_IKE_INVALID_HASH_ALG = 13871;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_HASH_SIZE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_HASH_SIZE 13872L")]
    public const int ERROR_IPSEC_IKE_INVALID_HASH_SIZE = 13872;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG 13873L")]
    public const int ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG = 13873;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_AUTH_ALG"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_AUTH_ALG 13874L")]
    public const int ERROR_IPSEC_IKE_INVALID_AUTH_ALG = 13874;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_SIG"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_SIG 13875L")]
    public const int ERROR_IPSEC_IKE_INVALID_SIG = 13875;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_LOAD_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_LOAD_FAILED 13876L")]
    public const int ERROR_IPSEC_IKE_LOAD_FAILED = 13876;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_RPC_DELETE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_RPC_DELETE 13877L")]
    public const int ERROR_IPSEC_IKE_RPC_DELETE = 13877;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_BENIGN_REINIT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_BENIGN_REINIT 13878L")]
    public const int ERROR_IPSEC_IKE_BENIGN_REINIT = 13878;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY 13879L")]
    public const int ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY = 13879;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION 13880L")]
    public const int ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION = 13880;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN 13881L")]
    public const int ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN = 13881;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_MM_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_MM_LIMIT 13882L")]
    public const int ERROR_IPSEC_IKE_MM_LIMIT = 13882;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NEGOTIATION_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NEGOTIATION_DISABLED 13883L")]
    public const int ERROR_IPSEC_IKE_NEGOTIATION_DISABLED = 13883;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_QM_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_QM_LIMIT 13884L")]
    public const int ERROR_IPSEC_IKE_QM_LIMIT = 13884;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_MM_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_MM_EXPIRED 13885L")]
    public const int ERROR_IPSEC_IKE_MM_EXPIRED = 13885;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID 13886L")]
    public const int ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID = 13886;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH 13887L")]
    public const int ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH = 13887;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID 13888L")]
    public const int ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID = 13888;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD 13889L")]
    public const int ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD = 13889;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_DOS_COOKIE_SENT"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_DOS_COOKIE_SENT 13890L")]
    public const int ERROR_IPSEC_IKE_DOS_COOKIE_SENT = 13890;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_SHUTTING_DOWN"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_SHUTTING_DOWN 13891L")]
    public const int ERROR_IPSEC_IKE_SHUTTING_DOWN = 13891;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_CGA_AUTH_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_CGA_AUTH_FAILED 13892L")]
    public const int ERROR_IPSEC_IKE_CGA_AUTH_FAILED = 13892;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PROCESS_ERR_NATOA"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PROCESS_ERR_NATOA 13893L")]
    public const int ERROR_IPSEC_IKE_PROCESS_ERR_NATOA = 13893;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INVALID_MM_FOR_QM"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INVALID_MM_FOR_QM 13894L")]
    public const int ERROR_IPSEC_IKE_INVALID_MM_FOR_QM = 13894;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_QM_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_QM_EXPIRED 13895L")]
    public const int ERROR_IPSEC_IKE_QM_EXPIRED = 13895;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_TOO_MANY_FILTERS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_TOO_MANY_FILTERS 13896L")]
    public const int ERROR_IPSEC_IKE_TOO_MANY_FILTERS = 13896;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NEG_STATUS_END"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NEG_STATUS_END 13897L")]
    public const int ERROR_IPSEC_IKE_NEG_STATUS_END = 13897;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL 13898L")]
    public const int ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL = 13898;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE 13899L")]
    public const int ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE = 13899;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING 13900L")]
    public const int ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING = 13900;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING 13901L")]
    public const int ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING = 13901;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS 13902L")]
    public const int ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS = 13902;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_RATELIMIT_DROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_RATELIMIT_DROP 13903L")]
    public const int ERROR_IPSEC_IKE_RATELIMIT_DROP = 13903;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE 13904L")]
    public const int ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE = 13904;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE 13905L")]
    public const int ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE = 13905;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE 13906L")]
    public const int ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE = 13906;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY 13907L")]
    public const int ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY = 13907;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE 13908L")]
    public const int ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE = 13908;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END 13909L")]
    public const int ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END = 13909;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_BAD_SPI"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_BAD_SPI 13910L")]
    public const int ERROR_IPSEC_BAD_SPI = 13910;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_SA_LIFETIME_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_SA_LIFETIME_EXPIRED 13911L")]
    public const int ERROR_IPSEC_SA_LIFETIME_EXPIRED = 13911;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_WRONG_SA"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_WRONG_SA 13912L")]
    public const int ERROR_IPSEC_WRONG_SA = 13912;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_REPLAY_CHECK_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_REPLAY_CHECK_FAILED 13913L")]
    public const int ERROR_IPSEC_REPLAY_CHECK_FAILED = 13913;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_INVALID_PACKET"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_INVALID_PACKET 13914L")]
    public const int ERROR_IPSEC_INVALID_PACKET = 13914;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_INTEGRITY_CHECK_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_INTEGRITY_CHECK_FAILED 13915L")]
    public const int ERROR_IPSEC_INTEGRITY_CHECK_FAILED = 13915;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_CLEAR_TEXT_DROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_CLEAR_TEXT_DROP 13916L")]
    public const int ERROR_IPSEC_CLEAR_TEXT_DROP = 13916;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_AUTH_FIREWALL_DROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_AUTH_FIREWALL_DROP 13917L")]
    public const int ERROR_IPSEC_AUTH_FIREWALL_DROP = 13917;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_THROTTLE_DROP"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_THROTTLE_DROP 13918L")]
    public const int ERROR_IPSEC_THROTTLE_DROP = 13918;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DOSP_BLOCK"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DOSP_BLOCK 13925L")]
    public const int ERROR_IPSEC_DOSP_BLOCK = 13925;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DOSP_RECEIVED_MULTICAST"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DOSP_RECEIVED_MULTICAST 13926L")]
    public const int ERROR_IPSEC_DOSP_RECEIVED_MULTICAST = 13926;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DOSP_INVALID_PACKET"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DOSP_INVALID_PACKET 13927L")]
    public const int ERROR_IPSEC_DOSP_INVALID_PACKET = 13927;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED 13928L")]
    public const int ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED = 13928;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DOSP_MAX_ENTRIES"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DOSP_MAX_ENTRIES 13929L")]
    public const int ERROR_IPSEC_DOSP_MAX_ENTRIES = 13929;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED 13930L")]
    public const int ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED = 13930;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DOSP_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DOSP_NOT_INSTALLED 13931L")]
    public const int ERROR_IPSEC_DOSP_NOT_INSTALLED = 13931;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES"]/*' />
    [NativeTypeName("#define ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES 13932L")]
    public const int ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES = 13932;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_SECTION_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SXS_SECTION_NOT_FOUND 14000L")]
    public const int ERROR_SXS_SECTION_NOT_FOUND = 14000;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_CANT_GEN_ACTCTX"]/*' />
    [NativeTypeName("#define ERROR_SXS_CANT_GEN_ACTCTX 14001L")]
    public const int ERROR_SXS_CANT_GEN_ACTCTX = 14001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_INVALID_ACTCTXDATA_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_SXS_INVALID_ACTCTXDATA_FORMAT 14002L")]
    public const int ERROR_SXS_INVALID_ACTCTXDATA_FORMAT = 14002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_ASSEMBLY_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SXS_ASSEMBLY_NOT_FOUND 14003L")]
    public const int ERROR_SXS_ASSEMBLY_NOT_FOUND = 14003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_MANIFEST_FORMAT_ERROR"]/*' />
    [NativeTypeName("#define ERROR_SXS_MANIFEST_FORMAT_ERROR 14004L")]
    public const int ERROR_SXS_MANIFEST_FORMAT_ERROR = 14004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_MANIFEST_PARSE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_SXS_MANIFEST_PARSE_ERROR 14005L")]
    public const int ERROR_SXS_MANIFEST_PARSE_ERROR = 14005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_ACTIVATION_CONTEXT_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_SXS_ACTIVATION_CONTEXT_DISABLED 14006L")]
    public const int ERROR_SXS_ACTIVATION_CONTEXT_DISABLED = 14006;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_KEY_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SXS_KEY_NOT_FOUND 14007L")]
    public const int ERROR_SXS_KEY_NOT_FOUND = 14007;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_VERSION_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_SXS_VERSION_CONFLICT 14008L")]
    public const int ERROR_SXS_VERSION_CONFLICT = 14008;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_WRONG_SECTION_TYPE"]/*' />
    [NativeTypeName("#define ERROR_SXS_WRONG_SECTION_TYPE 14009L")]
    public const int ERROR_SXS_WRONG_SECTION_TYPE = 14009;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_THREAD_QUERIES_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_SXS_THREAD_QUERIES_DISABLED 14010L")]
    public const int ERROR_SXS_THREAD_QUERIES_DISABLED = 14010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET"]/*' />
    [NativeTypeName("#define ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET 14011L")]
    public const int ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET = 14011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_UNKNOWN_ENCODING_GROUP"]/*' />
    [NativeTypeName("#define ERROR_SXS_UNKNOWN_ENCODING_GROUP 14012L")]
    public const int ERROR_SXS_UNKNOWN_ENCODING_GROUP = 14012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_UNKNOWN_ENCODING"]/*' />
    [NativeTypeName("#define ERROR_SXS_UNKNOWN_ENCODING 14013L")]
    public const int ERROR_SXS_UNKNOWN_ENCODING = 14013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_INVALID_XML_NAMESPACE_URI"]/*' />
    [NativeTypeName("#define ERROR_SXS_INVALID_XML_NAMESPACE_URI 14014L")]
    public const int ERROR_SXS_INVALID_XML_NAMESPACE_URI = 14014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED 14015L")]
    public const int ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED 14016L")]
    public const int ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE"]/*' />
    [NativeTypeName("#define ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE 14017L")]
    public const int ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE = 14017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE"]/*' />
    [NativeTypeName("#define ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE 14018L")]
    public const int ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE = 14018;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE"]/*' />
    [NativeTypeName("#define ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE 14019L")]
    public const int ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE = 14019;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT"]/*' />
    [NativeTypeName("#define ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT 14020L")]
    public const int ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT = 14020;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_DUPLICATE_DLL_NAME"]/*' />
    [NativeTypeName("#define ERROR_SXS_DUPLICATE_DLL_NAME 14021L")]
    public const int ERROR_SXS_DUPLICATE_DLL_NAME = 14021;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME"]/*' />
    [NativeTypeName("#define ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME 14022L")]
    public const int ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME = 14022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_DUPLICATE_CLSID"]/*' />
    [NativeTypeName("#define ERROR_SXS_DUPLICATE_CLSID 14023L")]
    public const int ERROR_SXS_DUPLICATE_CLSID = 14023;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_DUPLICATE_IID"]/*' />
    [NativeTypeName("#define ERROR_SXS_DUPLICATE_IID 14024L")]
    public const int ERROR_SXS_DUPLICATE_IID = 14024;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_DUPLICATE_TLBID"]/*' />
    [NativeTypeName("#define ERROR_SXS_DUPLICATE_TLBID 14025L")]
    public const int ERROR_SXS_DUPLICATE_TLBID = 14025;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_DUPLICATE_PROGID"]/*' />
    [NativeTypeName("#define ERROR_SXS_DUPLICATE_PROGID 14026L")]
    public const int ERROR_SXS_DUPLICATE_PROGID = 14026;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_DUPLICATE_ASSEMBLY_NAME"]/*' />
    [NativeTypeName("#define ERROR_SXS_DUPLICATE_ASSEMBLY_NAME 14027L")]
    public const int ERROR_SXS_DUPLICATE_ASSEMBLY_NAME = 14027;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_FILE_HASH_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_SXS_FILE_HASH_MISMATCH 14028L")]
    public const int ERROR_SXS_FILE_HASH_MISMATCH = 14028;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_POLICY_PARSE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_SXS_POLICY_PARSE_ERROR 14029L")]
    public const int ERROR_SXS_POLICY_PARSE_ERROR = 14029;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_MISSINGQUOTE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_MISSINGQUOTE 14030L")]
    public const int ERROR_SXS_XML_E_MISSINGQUOTE = 14030;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_COMMENTSYNTAX"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_COMMENTSYNTAX 14031L")]
    public const int ERROR_SXS_XML_E_COMMENTSYNTAX = 14031;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_BADSTARTNAMECHAR"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_BADSTARTNAMECHAR 14032L")]
    public const int ERROR_SXS_XML_E_BADSTARTNAMECHAR = 14032;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_BADNAMECHAR"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_BADNAMECHAR 14033L")]
    public const int ERROR_SXS_XML_E_BADNAMECHAR = 14033;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_BADCHARINSTRING"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_BADCHARINSTRING 14034L")]
    public const int ERROR_SXS_XML_E_BADCHARINSTRING = 14034;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_XMLDECLSYNTAX"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_XMLDECLSYNTAX 14035L")]
    public const int ERROR_SXS_XML_E_XMLDECLSYNTAX = 14035;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_BADCHARDATA"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_BADCHARDATA 14036L")]
    public const int ERROR_SXS_XML_E_BADCHARDATA = 14036;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_MISSINGWHITESPACE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_MISSINGWHITESPACE 14037L")]
    public const int ERROR_SXS_XML_E_MISSINGWHITESPACE = 14037;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_EXPECTINGTAGEND"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_EXPECTINGTAGEND 14038L")]
    public const int ERROR_SXS_XML_E_EXPECTINGTAGEND = 14038;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_MISSINGSEMICOLON"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_MISSINGSEMICOLON 14039L")]
    public const int ERROR_SXS_XML_E_MISSINGSEMICOLON = 14039;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNBALANCEDPAREN"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNBALANCEDPAREN 14040L")]
    public const int ERROR_SXS_XML_E_UNBALANCEDPAREN = 14040;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INTERNALERROR"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INTERNALERROR 14041L")]
    public const int ERROR_SXS_XML_E_INTERNALERROR = 14041;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE 14042L")]
    public const int ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE = 14042;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INCOMPLETE_ENCODING"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INCOMPLETE_ENCODING 14043L")]
    public const int ERROR_SXS_XML_E_INCOMPLETE_ENCODING = 14043;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_MISSING_PAREN"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_MISSING_PAREN 14044L")]
    public const int ERROR_SXS_XML_E_MISSING_PAREN = 14044;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE 14045L")]
    public const int ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE = 14045;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_MULTIPLE_COLONS"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_MULTIPLE_COLONS 14046L")]
    public const int ERROR_SXS_XML_E_MULTIPLE_COLONS = 14046;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INVALID_DECIMAL"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INVALID_DECIMAL 14047L")]
    public const int ERROR_SXS_XML_E_INVALID_DECIMAL = 14047;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INVALID_HEXIDECIMAL"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INVALID_HEXIDECIMAL 14048L")]
    public const int ERROR_SXS_XML_E_INVALID_HEXIDECIMAL = 14048;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INVALID_UNICODE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INVALID_UNICODE 14049L")]
    public const int ERROR_SXS_XML_E_INVALID_UNICODE = 14049;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK 14050L")]
    public const int ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK = 14050;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNEXPECTEDENDTAG"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNEXPECTEDENDTAG 14051L")]
    public const int ERROR_SXS_XML_E_UNEXPECTEDENDTAG = 14051;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNCLOSEDTAG"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNCLOSEDTAG 14052L")]
    public const int ERROR_SXS_XML_E_UNCLOSEDTAG = 14052;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_DUPLICATEATTRIBUTE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_DUPLICATEATTRIBUTE 14053L")]
    public const int ERROR_SXS_XML_E_DUPLICATEATTRIBUTE = 14053;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_MULTIPLEROOTS"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_MULTIPLEROOTS 14054L")]
    public const int ERROR_SXS_XML_E_MULTIPLEROOTS = 14054;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INVALIDATROOTLEVEL"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INVALIDATROOTLEVEL 14055L")]
    public const int ERROR_SXS_XML_E_INVALIDATROOTLEVEL = 14055;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_BADXMLDECL"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_BADXMLDECL 14056L")]
    public const int ERROR_SXS_XML_E_BADXMLDECL = 14056;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_MISSINGROOT"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_MISSINGROOT 14057L")]
    public const int ERROR_SXS_XML_E_MISSINGROOT = 14057;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNEXPECTEDEOF"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNEXPECTEDEOF 14058L")]
    public const int ERROR_SXS_XML_E_UNEXPECTEDEOF = 14058;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_BADPEREFINSUBSET"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_BADPEREFINSUBSET 14059L")]
    public const int ERROR_SXS_XML_E_BADPEREFINSUBSET = 14059;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNCLOSEDSTARTTAG"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNCLOSEDSTARTTAG 14060L")]
    public const int ERROR_SXS_XML_E_UNCLOSEDSTARTTAG = 14060;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNCLOSEDENDTAG"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNCLOSEDENDTAG 14061L")]
    public const int ERROR_SXS_XML_E_UNCLOSEDENDTAG = 14061;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNCLOSEDSTRING"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNCLOSEDSTRING 14062L")]
    public const int ERROR_SXS_XML_E_UNCLOSEDSTRING = 14062;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNCLOSEDCOMMENT"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNCLOSEDCOMMENT 14063L")]
    public const int ERROR_SXS_XML_E_UNCLOSEDCOMMENT = 14063;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNCLOSEDDECL"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNCLOSEDDECL 14064L")]
    public const int ERROR_SXS_XML_E_UNCLOSEDDECL = 14064;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNCLOSEDCDATA"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNCLOSEDCDATA 14065L")]
    public const int ERROR_SXS_XML_E_UNCLOSEDCDATA = 14065;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_RESERVEDNAMESPACE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_RESERVEDNAMESPACE 14066L")]
    public const int ERROR_SXS_XML_E_RESERVEDNAMESPACE = 14066;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INVALIDENCODING"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INVALIDENCODING 14067L")]
    public const int ERROR_SXS_XML_E_INVALIDENCODING = 14067;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INVALIDSWITCH"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INVALIDSWITCH 14068L")]
    public const int ERROR_SXS_XML_E_INVALIDSWITCH = 14068;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_BADXMLCASE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_BADXMLCASE 14069L")]
    public const int ERROR_SXS_XML_E_BADXMLCASE = 14069;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INVALID_STANDALONE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INVALID_STANDALONE 14070L")]
    public const int ERROR_SXS_XML_E_INVALID_STANDALONE = 14070;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_UNEXPECTED_STANDALONE"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_UNEXPECTED_STANDALONE 14071L")]
    public const int ERROR_SXS_XML_E_UNEXPECTED_STANDALONE = 14071;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_INVALID_VERSION"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_INVALID_VERSION 14072L")]
    public const int ERROR_SXS_XML_E_INVALID_VERSION = 14072;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_XML_E_MISSINGEQUALS"]/*' />
    [NativeTypeName("#define ERROR_SXS_XML_E_MISSINGEQUALS 14073L")]
    public const int ERROR_SXS_XML_E_MISSINGEQUALS = 14073;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_PROTECTION_RECOVERY_FAILED"]/*' />
    [NativeTypeName("#define ERROR_SXS_PROTECTION_RECOVERY_FAILED 14074L")]
    public const int ERROR_SXS_PROTECTION_RECOVERY_FAILED = 14074;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT"]/*' />
    [NativeTypeName("#define ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT 14075L")]
    public const int ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT = 14075;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_PROTECTION_CATALOG_NOT_VALID"]/*' />
    [NativeTypeName("#define ERROR_SXS_PROTECTION_CATALOG_NOT_VALID 14076L")]
    public const int ERROR_SXS_PROTECTION_CATALOG_NOT_VALID = 14076;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_UNTRANSLATABLE_HRESULT"]/*' />
    [NativeTypeName("#define ERROR_SXS_UNTRANSLATABLE_HRESULT 14077L")]
    public const int ERROR_SXS_UNTRANSLATABLE_HRESULT = 14077;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING"]/*' />
    [NativeTypeName("#define ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING 14078L")]
    public const int ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING = 14078;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE"]/*' />
    [NativeTypeName("#define ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE 14079L")]
    public const int ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE = 14079;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME"]/*' />
    [NativeTypeName("#define ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME 14080L")]
    public const int ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME = 14080;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_ASSEMBLY_MISSING"]/*' />
    [NativeTypeName("#define ERROR_SXS_ASSEMBLY_MISSING 14081L")]
    public const int ERROR_SXS_ASSEMBLY_MISSING = 14081;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_CORRUPT_ACTIVATION_STACK"]/*' />
    [NativeTypeName("#define ERROR_SXS_CORRUPT_ACTIVATION_STACK 14082L")]
    public const int ERROR_SXS_CORRUPT_ACTIVATION_STACK = 14082;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_CORRUPTION"]/*' />
    [NativeTypeName("#define ERROR_SXS_CORRUPTION 14083L")]
    public const int ERROR_SXS_CORRUPTION = 14083;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_EARLY_DEACTIVATION"]/*' />
    [NativeTypeName("#define ERROR_SXS_EARLY_DEACTIVATION 14084L")]
    public const int ERROR_SXS_EARLY_DEACTIVATION = 14084;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_INVALID_DEACTIVATION"]/*' />
    [NativeTypeName("#define ERROR_SXS_INVALID_DEACTIVATION 14085L")]
    public const int ERROR_SXS_INVALID_DEACTIVATION = 14085;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_MULTIPLE_DEACTIVATION"]/*' />
    [NativeTypeName("#define ERROR_SXS_MULTIPLE_DEACTIVATION 14086L")]
    public const int ERROR_SXS_MULTIPLE_DEACTIVATION = 14086;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_PROCESS_TERMINATION_REQUESTED"]/*' />
    [NativeTypeName("#define ERROR_SXS_PROCESS_TERMINATION_REQUESTED 14087L")]
    public const int ERROR_SXS_PROCESS_TERMINATION_REQUESTED = 14087;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_RELEASE_ACTIVATION_CONTEXT"]/*' />
    [NativeTypeName("#define ERROR_SXS_RELEASE_ACTIVATION_CONTEXT 14088L")]
    public const int ERROR_SXS_RELEASE_ACTIVATION_CONTEXT = 14088;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY 14089L")]
    public const int ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY = 14089;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE"]/*' />
    [NativeTypeName("#define ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE 14090L")]
    public const int ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE = 14090;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME"]/*' />
    [NativeTypeName("#define ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME 14091L")]
    public const int ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME = 14091;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE"]/*' />
    [NativeTypeName("#define ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE 14092L")]
    public const int ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE = 14092;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_IDENTITY_PARSE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_SXS_IDENTITY_PARSE_ERROR 14093L")]
    public const int ERROR_SXS_IDENTITY_PARSE_ERROR = 14093;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MALFORMED_SUBSTITUTION_STRING"]/*' />
    [NativeTypeName("#define ERROR_MALFORMED_SUBSTITUTION_STRING 14094L")]
    public const int ERROR_MALFORMED_SUBSTITUTION_STRING = 14094;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN"]/*' />
    [NativeTypeName("#define ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN 14095L")]
    public const int ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN = 14095;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNMAPPED_SUBSTITUTION_STRING"]/*' />
    [NativeTypeName("#define ERROR_UNMAPPED_SUBSTITUTION_STRING 14096L")]
    public const int ERROR_UNMAPPED_SUBSTITUTION_STRING = 14096;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_ASSEMBLY_NOT_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_SXS_ASSEMBLY_NOT_LOCKED 14097L")]
    public const int ERROR_SXS_ASSEMBLY_NOT_LOCKED = 14097;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_COMPONENT_STORE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_SXS_COMPONENT_STORE_CORRUPT 14098L")]
    public const int ERROR_SXS_COMPONENT_STORE_CORRUPT = 14098;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ADVANCED_INSTALLER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_ADVANCED_INSTALLER_FAILED 14099L")]
    public const int ERROR_ADVANCED_INSTALLER_FAILED = 14099;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_XML_ENCODING_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_XML_ENCODING_MISMATCH 14100L")]
    public const int ERROR_XML_ENCODING_MISMATCH = 14100;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT"]/*' />
    [NativeTypeName("#define ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT 14101L")]
    public const int ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT = 14101;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_IDENTITIES_DIFFERENT"]/*' />
    [NativeTypeName("#define ERROR_SXS_IDENTITIES_DIFFERENT 14102L")]
    public const int ERROR_SXS_IDENTITIES_DIFFERENT = 14102;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT"]/*' />
    [NativeTypeName("#define ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT 14103L")]
    public const int ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT = 14103;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY"]/*' />
    [NativeTypeName("#define ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY 14104L")]
    public const int ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY = 14104;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_MANIFEST_TOO_BIG"]/*' />
    [NativeTypeName("#define ERROR_SXS_MANIFEST_TOO_BIG 14105L")]
    public const int ERROR_SXS_MANIFEST_TOO_BIG = 14105;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_SETTING_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_SXS_SETTING_NOT_REGISTERED 14106L")]
    public const int ERROR_SXS_SETTING_NOT_REGISTERED = 14106;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE"]/*' />
    [NativeTypeName("#define ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE 14107L")]
    public const int ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE = 14107;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMI_PRIMITIVE_INSTALLER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_SMI_PRIMITIVE_INSTALLER_FAILED 14108L")]
    public const int ERROR_SMI_PRIMITIVE_INSTALLER_FAILED = 14108;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GENERIC_COMMAND_FAILED"]/*' />
    [NativeTypeName("#define ERROR_GENERIC_COMMAND_FAILED 14109L")]
    public const int ERROR_GENERIC_COMMAND_FAILED = 14109;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_FILE_HASH_MISSING"]/*' />
    [NativeTypeName("#define ERROR_SXS_FILE_HASH_MISSING 14110L")]
    public const int ERROR_SXS_FILE_HASH_MISSING = 14110;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SXS_DUPLICATE_ACTIVATABLE_CLASS"]/*' />
    [NativeTypeName("#define ERROR_SXS_DUPLICATE_ACTIVATABLE_CLASS 14111L")]
    public const int ERROR_SXS_DUPLICATE_ACTIVATABLE_CLASS = 14111;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_INVALID_CHANNEL_PATH"]/*' />
    [NativeTypeName("#define ERROR_EVT_INVALID_CHANNEL_PATH 15000L")]
    public const int ERROR_EVT_INVALID_CHANNEL_PATH = 15000;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_INVALID_QUERY"]/*' />
    [NativeTypeName("#define ERROR_EVT_INVALID_QUERY 15001L")]
    public const int ERROR_EVT_INVALID_QUERY = 15001;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND 15002L")]
    public const int ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND = 15002;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND 15003L")]
    public const int ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND = 15003;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_INVALID_PUBLISHER_NAME"]/*' />
    [NativeTypeName("#define ERROR_EVT_INVALID_PUBLISHER_NAME 15004L")]
    public const int ERROR_EVT_INVALID_PUBLISHER_NAME = 15004;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_INVALID_EVENT_DATA"]/*' />
    [NativeTypeName("#define ERROR_EVT_INVALID_EVENT_DATA 15005L")]
    public const int ERROR_EVT_INVALID_EVENT_DATA = 15005;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_CHANNEL_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_EVT_CHANNEL_NOT_FOUND 15007L")]
    public const int ERROR_EVT_CHANNEL_NOT_FOUND = 15007;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_MALFORMED_XML_TEXT"]/*' />
    [NativeTypeName("#define ERROR_EVT_MALFORMED_XML_TEXT 15008L")]
    public const int ERROR_EVT_MALFORMED_XML_TEXT = 15008;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL"]/*' />
    [NativeTypeName("#define ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL 15009L")]
    public const int ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL = 15009;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_CONFIGURATION_ERROR"]/*' />
    [NativeTypeName("#define ERROR_EVT_CONFIGURATION_ERROR 15010L")]
    public const int ERROR_EVT_CONFIGURATION_ERROR = 15010;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_QUERY_RESULT_STALE"]/*' />
    [NativeTypeName("#define ERROR_EVT_QUERY_RESULT_STALE 15011L")]
    public const int ERROR_EVT_QUERY_RESULT_STALE = 15011;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_QUERY_RESULT_INVALID_POSITION"]/*' />
    [NativeTypeName("#define ERROR_EVT_QUERY_RESULT_INVALID_POSITION 15012L")]
    public const int ERROR_EVT_QUERY_RESULT_INVALID_POSITION = 15012;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_NON_VALIDATING_MSXML"]/*' />
    [NativeTypeName("#define ERROR_EVT_NON_VALIDATING_MSXML 15013L")]
    public const int ERROR_EVT_NON_VALIDATING_MSXML = 15013;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_ALREADYSCOPED"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_ALREADYSCOPED 15014L")]
    public const int ERROR_EVT_FILTER_ALREADYSCOPED = 15014;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_NOTELTSET"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_NOTELTSET 15015L")]
    public const int ERROR_EVT_FILTER_NOTELTSET = 15015;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_INVARG"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_INVARG 15016L")]
    public const int ERROR_EVT_FILTER_INVARG = 15016;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_INVTEST"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_INVTEST 15017L")]
    public const int ERROR_EVT_FILTER_INVTEST = 15017;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_INVTYPE"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_INVTYPE 15018L")]
    public const int ERROR_EVT_FILTER_INVTYPE = 15018;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_PARSEERR"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_PARSEERR 15019L")]
    public const int ERROR_EVT_FILTER_PARSEERR = 15019;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_UNSUPPORTEDOP"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_UNSUPPORTEDOP 15020L")]
    public const int ERROR_EVT_FILTER_UNSUPPORTEDOP = 15020;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_UNEXPECTEDTOKEN"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_UNEXPECTEDTOKEN 15021L")]
    public const int ERROR_EVT_FILTER_UNEXPECTEDTOKEN = 15021;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL"]/*' />
    [NativeTypeName("#define ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL 15022L")]
    public const int ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL = 15022;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE"]/*' />
    [NativeTypeName("#define ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE 15023L")]
    public const int ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE = 15023;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE"]/*' />
    [NativeTypeName("#define ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE 15024L")]
    public const int ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE = 15024;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_CHANNEL_CANNOT_ACTIVATE"]/*' />
    [NativeTypeName("#define ERROR_EVT_CHANNEL_CANNOT_ACTIVATE 15025L")]
    public const int ERROR_EVT_CHANNEL_CANNOT_ACTIVATE = 15025;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_TOO_COMPLEX"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_TOO_COMPLEX 15026L")]
    public const int ERROR_EVT_FILTER_TOO_COMPLEX = 15026;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_MESSAGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_EVT_MESSAGE_NOT_FOUND 15027L")]
    public const int ERROR_EVT_MESSAGE_NOT_FOUND = 15027;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_MESSAGE_ID_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_EVT_MESSAGE_ID_NOT_FOUND 15028L")]
    public const int ERROR_EVT_MESSAGE_ID_NOT_FOUND = 15028;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_UNRESOLVED_VALUE_INSERT"]/*' />
    [NativeTypeName("#define ERROR_EVT_UNRESOLVED_VALUE_INSERT 15029L")]
    public const int ERROR_EVT_UNRESOLVED_VALUE_INSERT = 15029;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_UNRESOLVED_PARAMETER_INSERT"]/*' />
    [NativeTypeName("#define ERROR_EVT_UNRESOLVED_PARAMETER_INSERT 15030L")]
    public const int ERROR_EVT_UNRESOLVED_PARAMETER_INSERT = 15030;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_MAX_INSERTS_REACHED"]/*' />
    [NativeTypeName("#define ERROR_EVT_MAX_INSERTS_REACHED 15031L")]
    public const int ERROR_EVT_MAX_INSERTS_REACHED = 15031;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_EVENT_DEFINITION_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_EVT_EVENT_DEFINITION_NOT_FOUND 15032L")]
    public const int ERROR_EVT_EVENT_DEFINITION_NOT_FOUND = 15032;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND 15033L")]
    public const int ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND = 15033;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_VERSION_TOO_OLD"]/*' />
    [NativeTypeName("#define ERROR_EVT_VERSION_TOO_OLD 15034L")]
    public const int ERROR_EVT_VERSION_TOO_OLD = 15034;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_VERSION_TOO_NEW"]/*' />
    [NativeTypeName("#define ERROR_EVT_VERSION_TOO_NEW 15035L")]
    public const int ERROR_EVT_VERSION_TOO_NEW = 15035;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY"]/*' />
    [NativeTypeName("#define ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY 15036L")]
    public const int ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY = 15036;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_PUBLISHER_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_EVT_PUBLISHER_DISABLED 15037L")]
    public const int ERROR_EVT_PUBLISHER_DISABLED = 15037;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EVT_FILTER_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define ERROR_EVT_FILTER_OUT_OF_RANGE 15038L")]
    public const int ERROR_EVT_FILTER_OUT_OF_RANGE = 15038;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE"]/*' />
    [NativeTypeName("#define ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE 15080L")]
    public const int ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE = 15080;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EC_LOG_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_EC_LOG_DISABLED 15081L")]
    public const int ERROR_EC_LOG_DISABLED = 15081;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EC_CIRCULAR_FORWARDING"]/*' />
    [NativeTypeName("#define ERROR_EC_CIRCULAR_FORWARDING 15082L")]
    public const int ERROR_EC_CIRCULAR_FORWARDING = 15082;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EC_CREDSTORE_FULL"]/*' />
    [NativeTypeName("#define ERROR_EC_CREDSTORE_FULL 15083L")]
    public const int ERROR_EC_CREDSTORE_FULL = 15083;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EC_CRED_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_EC_CRED_NOT_FOUND 15084L")]
    public const int ERROR_EC_CRED_NOT_FOUND = 15084;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_EC_NO_ACTIVE_CHANNEL"]/*' />
    [NativeTypeName("#define ERROR_EC_NO_ACTIVE_CHANNEL 15085L")]
    public const int ERROR_EC_NO_ACTIVE_CHANNEL = 15085;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUI_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_MUI_FILE_NOT_FOUND 15100L")]
    public const int ERROR_MUI_FILE_NOT_FOUND = 15100;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUI_INVALID_FILE"]/*' />
    [NativeTypeName("#define ERROR_MUI_INVALID_FILE 15101L")]
    public const int ERROR_MUI_INVALID_FILE = 15101;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUI_INVALID_RC_CONFIG"]/*' />
    [NativeTypeName("#define ERROR_MUI_INVALID_RC_CONFIG 15102L")]
    public const int ERROR_MUI_INVALID_RC_CONFIG = 15102;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUI_INVALID_LOCALE_NAME"]/*' />
    [NativeTypeName("#define ERROR_MUI_INVALID_LOCALE_NAME 15103L")]
    public const int ERROR_MUI_INVALID_LOCALE_NAME = 15103;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME"]/*' />
    [NativeTypeName("#define ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME 15104L")]
    public const int ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME = 15104;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUI_FILE_NOT_LOADED"]/*' />
    [NativeTypeName("#define ERROR_MUI_FILE_NOT_LOADED 15105L")]
    public const int ERROR_MUI_FILE_NOT_LOADED = 15105;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESOURCE_ENUM_USER_STOP"]/*' />
    [NativeTypeName("#define ERROR_RESOURCE_ENUM_USER_STOP 15106L")]
    public const int ERROR_RESOURCE_ENUM_USER_STOP = 15106;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED 15107L")]
    public const int ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED = 15107;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME"]/*' />
    [NativeTypeName("#define ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME 15108L")]
    public const int ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME = 15108;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE"]/*' />
    [NativeTypeName("#define ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE 15110L")]
    public const int ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE = 15110;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_INVALID_PRICONFIG"]/*' />
    [NativeTypeName("#define ERROR_MRM_INVALID_PRICONFIG 15111L")]
    public const int ERROR_MRM_INVALID_PRICONFIG = 15111;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_INVALID_FILE_TYPE"]/*' />
    [NativeTypeName("#define ERROR_MRM_INVALID_FILE_TYPE 15112L")]
    public const int ERROR_MRM_INVALID_FILE_TYPE = 15112;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_UNKNOWN_QUALIFIER"]/*' />
    [NativeTypeName("#define ERROR_MRM_UNKNOWN_QUALIFIER 15113L")]
    public const int ERROR_MRM_UNKNOWN_QUALIFIER = 15113;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_INVALID_QUALIFIER_VALUE"]/*' />
    [NativeTypeName("#define ERROR_MRM_INVALID_QUALIFIER_VALUE 15114L")]
    public const int ERROR_MRM_INVALID_QUALIFIER_VALUE = 15114;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_NO_CANDIDATE"]/*' />
    [NativeTypeName("#define ERROR_MRM_NO_CANDIDATE 15115L")]
    public const int ERROR_MRM_NO_CANDIDATE = 15115;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE"]/*' />
    [NativeTypeName("#define ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE 15116L")]
    public const int ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE = 15116;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_RESOURCE_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_MRM_RESOURCE_TYPE_MISMATCH 15117L")]
    public const int ERROR_MRM_RESOURCE_TYPE_MISMATCH = 15117;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_DUPLICATE_MAP_NAME"]/*' />
    [NativeTypeName("#define ERROR_MRM_DUPLICATE_MAP_NAME 15118L")]
    public const int ERROR_MRM_DUPLICATE_MAP_NAME = 15118;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_DUPLICATE_ENTRY"]/*' />
    [NativeTypeName("#define ERROR_MRM_DUPLICATE_ENTRY 15119L")]
    public const int ERROR_MRM_DUPLICATE_ENTRY = 15119;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_INVALID_RESOURCE_IDENTIFIER"]/*' />
    [NativeTypeName("#define ERROR_MRM_INVALID_RESOURCE_IDENTIFIER 15120L")]
    public const int ERROR_MRM_INVALID_RESOURCE_IDENTIFIER = 15120;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_FILEPATH_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_MRM_FILEPATH_TOO_LONG 15121L")]
    public const int ERROR_MRM_FILEPATH_TOO_LONG = 15121;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE"]/*' />
    [NativeTypeName("#define ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE 15122L")]
    public const int ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE = 15122;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_INVALID_PRI_FILE"]/*' />
    [NativeTypeName("#define ERROR_MRM_INVALID_PRI_FILE 15126L")]
    public const int ERROR_MRM_INVALID_PRI_FILE = 15126;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_NAMED_RESOURCE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_MRM_NAMED_RESOURCE_NOT_FOUND 15127L")]
    public const int ERROR_MRM_NAMED_RESOURCE_NOT_FOUND = 15127;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_MAP_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_MRM_MAP_NOT_FOUND 15135L")]
    public const int ERROR_MRM_MAP_NOT_FOUND = 15135;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_UNSUPPORTED_PROFILE_TYPE"]/*' />
    [NativeTypeName("#define ERROR_MRM_UNSUPPORTED_PROFILE_TYPE 15136L")]
    public const int ERROR_MRM_UNSUPPORTED_PROFILE_TYPE = 15136;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_INVALID_QUALIFIER_OPERATOR"]/*' />
    [NativeTypeName("#define ERROR_MRM_INVALID_QUALIFIER_OPERATOR 15137L")]
    public const int ERROR_MRM_INVALID_QUALIFIER_OPERATOR = 15137;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE"]/*' />
    [NativeTypeName("#define ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE 15138L")]
    public const int ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE = 15138;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_AUTOMERGE_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_MRM_AUTOMERGE_ENABLED 15139L")]
    public const int ERROR_MRM_AUTOMERGE_ENABLED = 15139;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_TOO_MANY_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_MRM_TOO_MANY_RESOURCES 15140L")]
    public const int ERROR_MRM_TOO_MANY_RESOURCES = 15140;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_MERGE"]/*' />
    [NativeTypeName("#define ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_MERGE 15141L")]
    public const int ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_MERGE = 15141;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_LOAD_UNLOAD_PRI_FILE"]/*' />
    [NativeTypeName("#define ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_LOAD_UNLOAD_PRI_FILE 15142L")]
    public const int ERROR_MRM_UNSUPPORTED_FILE_TYPE_FOR_LOAD_UNLOAD_PRI_FILE = 15142;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_NO_CURRENT_VIEW_ON_THREAD"]/*' />
    [NativeTypeName("#define ERROR_MRM_NO_CURRENT_VIEW_ON_THREAD 15143L")]
    public const int ERROR_MRM_NO_CURRENT_VIEW_ON_THREAD = 15143;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIFFERENT_PROFILE_RESOURCE_MANAGER_EXIST"]/*' />
    [NativeTypeName("#define ERROR_DIFFERENT_PROFILE_RESOURCE_MANAGER_EXIST 15144L")]
    public const int ERROR_DIFFERENT_PROFILE_RESOURCE_MANAGER_EXIST = 15144;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_OPERATION_NOT_ALLOWED_FROM_SYSTEM_COMPONENT"]/*' />
    [NativeTypeName("#define ERROR_OPERATION_NOT_ALLOWED_FROM_SYSTEM_COMPONENT 15145L")]
    public const int ERROR_OPERATION_NOT_ALLOWED_FROM_SYSTEM_COMPONENT = 15145;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_DIRECT_REF_TO_NON_DEFAULT_RESOURCE"]/*' />
    [NativeTypeName("#define ERROR_MRM_DIRECT_REF_TO_NON_DEFAULT_RESOURCE 15146L")]
    public const int ERROR_MRM_DIRECT_REF_TO_NON_DEFAULT_RESOURCE = 15146;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_GENERATION_COUNT_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_MRM_GENERATION_COUNT_MISMATCH 15147L")]
    public const int ERROR_MRM_GENERATION_COUNT_MISMATCH = 15147;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_VERSION_MISMATCH 15148L")]
    public const int ERROR_PRI_MERGE_VERSION_MISMATCH = 15148;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_MISSING_SCHEMA"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_MISSING_SCHEMA 15149L")]
    public const int ERROR_PRI_MERGE_MISSING_SCHEMA = 15149;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_LOAD_FILE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_LOAD_FILE_FAILED 15150L")]
    public const int ERROR_PRI_MERGE_LOAD_FILE_FAILED = 15150;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_ADD_FILE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_ADD_FILE_FAILED 15151L")]
    public const int ERROR_PRI_MERGE_ADD_FILE_FAILED = 15151;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_WRITE_FILE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_WRITE_FILE_FAILED 15152L")]
    public const int ERROR_PRI_MERGE_WRITE_FILE_FAILED = 15152;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_MULTIPLE_PACKAGE_FAMILIES_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_MULTIPLE_PACKAGE_FAMILIES_NOT_ALLOWED 15153L")]
    public const int ERROR_PRI_MERGE_MULTIPLE_PACKAGE_FAMILIES_NOT_ALLOWED = 15153;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_MULTIPLE_MAIN_PACKAGES_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_MULTIPLE_MAIN_PACKAGES_NOT_ALLOWED 15154L")]
    public const int ERROR_PRI_MERGE_MULTIPLE_MAIN_PACKAGES_NOT_ALLOWED = 15154;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_BUNDLE_PACKAGES_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_BUNDLE_PACKAGES_NOT_ALLOWED 15155L")]
    public const int ERROR_PRI_MERGE_BUNDLE_PACKAGES_NOT_ALLOWED = 15155;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_MAIN_PACKAGE_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_MAIN_PACKAGE_REQUIRED 15156L")]
    public const int ERROR_PRI_MERGE_MAIN_PACKAGE_REQUIRED = 15156;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_RESOURCE_PACKAGE_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_RESOURCE_PACKAGE_REQUIRED 15157L")]
    public const int ERROR_PRI_MERGE_RESOURCE_PACKAGE_REQUIRED = 15157;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRI_MERGE_INVALID_FILE_NAME"]/*' />
    [NativeTypeName("#define ERROR_PRI_MERGE_INVALID_FILE_NAME 15158L")]
    public const int ERROR_PRI_MERGE_INVALID_FILE_NAME = 15158;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_PACKAGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_MRM_PACKAGE_NOT_FOUND 15159L")]
    public const int ERROR_MRM_PACKAGE_NOT_FOUND = 15159;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_MISSING_DEFAULT_LANGUAGE"]/*' />
    [NativeTypeName("#define ERROR_MRM_MISSING_DEFAULT_LANGUAGE 15160L")]
    public const int ERROR_MRM_MISSING_DEFAULT_LANGUAGE = 15160;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MRM_SCOPE_ITEM_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_MRM_SCOPE_ITEM_CONFLICT 15161L")]
    public const int ERROR_MRM_SCOPE_ITEM_CONFLICT = 15161;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_INVALID_CAPABILITIES_STRING"]/*' />
    [NativeTypeName("#define ERROR_MCA_INVALID_CAPABILITIES_STRING 15200L")]
    public const int ERROR_MCA_INVALID_CAPABILITIES_STRING = 15200;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_INVALID_VCP_VERSION"]/*' />
    [NativeTypeName("#define ERROR_MCA_INVALID_VCP_VERSION 15201L")]
    public const int ERROR_MCA_INVALID_VCP_VERSION = 15201;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION"]/*' />
    [NativeTypeName("#define ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION 15202L")]
    public const int ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION = 15202;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_MCCS_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_MCA_MCCS_VERSION_MISMATCH 15203L")]
    public const int ERROR_MCA_MCCS_VERSION_MISMATCH = 15203;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_UNSUPPORTED_MCCS_VERSION"]/*' />
    [NativeTypeName("#define ERROR_MCA_UNSUPPORTED_MCCS_VERSION 15204L")]
    public const int ERROR_MCA_UNSUPPORTED_MCCS_VERSION = 15204;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_MCA_INTERNAL_ERROR 15205L")]
    public const int ERROR_MCA_INTERNAL_ERROR = 15205;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED"]/*' />
    [NativeTypeName("#define ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED 15206L")]
    public const int ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED = 15206;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE"]/*' />
    [NativeTypeName("#define ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE 15207L")]
    public const int ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE = 15207;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AMBIGUOUS_SYSTEM_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_AMBIGUOUS_SYSTEM_DEVICE 15250L")]
    public const int ERROR_AMBIGUOUS_SYSTEM_DEVICE = 15250;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_DEVICE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_DEVICE_NOT_FOUND 15299L")]
    public const int ERROR_SYSTEM_DEVICE_NOT_FOUND = 15299;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HASH_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_HASH_NOT_SUPPORTED 15300L")]
    public const int ERROR_HASH_NOT_SUPPORTED = 15300;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HASH_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_HASH_NOT_PRESENT 15301L")]
    public const int ERROR_HASH_NOT_PRESENT = 15301;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED 15321L")]
    public const int ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED = 15321;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GPIO_CLIENT_INFORMATION_INVALID"]/*' />
    [NativeTypeName("#define ERROR_GPIO_CLIENT_INFORMATION_INVALID 15322L")]
    public const int ERROR_GPIO_CLIENT_INFORMATION_INVALID = 15322;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GPIO_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GPIO_VERSION_NOT_SUPPORTED 15323L")]
    public const int ERROR_GPIO_VERSION_NOT_SUPPORTED = 15323;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GPIO_INVALID_REGISTRATION_PACKET"]/*' />
    [NativeTypeName("#define ERROR_GPIO_INVALID_REGISTRATION_PACKET 15324L")]
    public const int ERROR_GPIO_INVALID_REGISTRATION_PACKET = 15324;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GPIO_OPERATION_DENIED"]/*' />
    [NativeTypeName("#define ERROR_GPIO_OPERATION_DENIED 15325L")]
    public const int ERROR_GPIO_OPERATION_DENIED = 15325;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE"]/*' />
    [NativeTypeName("#define ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE 15326L")]
    public const int ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE = 15326;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED"]/*' />
    [NativeTypeName("#define ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED 15327L")]
    public const int ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED = 15327;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_COMPOSE_APISET_EXTENSION"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_COMPOSE_APISET_EXTENSION 15380L")]
    public const int ERROR_CANNOT_COMPOSE_APISET_EXTENSION = 15380;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APISET_SCHEMA_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_APISET_SCHEMA_VERSION_NOT_SUPPORTED 15381L")]
    public const int ERROR_APISET_SCHEMA_VERSION_NOT_SUPPORTED = 15381;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CANNOT_SWITCH_RUNLEVEL"]/*' />
    [NativeTypeName("#define ERROR_CANNOT_SWITCH_RUNLEVEL 15400L")]
    public const int ERROR_CANNOT_SWITCH_RUNLEVEL = 15400;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_RUNLEVEL_SETTING"]/*' />
    [NativeTypeName("#define ERROR_INVALID_RUNLEVEL_SETTING 15401L")]
    public const int ERROR_INVALID_RUNLEVEL_SETTING = 15401;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RUNLEVEL_SWITCH_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_RUNLEVEL_SWITCH_TIMEOUT 15402L")]
    public const int ERROR_RUNLEVEL_SWITCH_TIMEOUT = 15402;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT 15403L")]
    public const int ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT = 15403;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RUNLEVEL_SWITCH_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_RUNLEVEL_SWITCH_IN_PROGRESS 15404L")]
    public const int ERROR_RUNLEVEL_SWITCH_IN_PROGRESS = 15404;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICES_FAILED_AUTOSTART"]/*' />
    [NativeTypeName("#define ERROR_SERVICES_FAILED_AUTOSTART 15405L")]
    public const int ERROR_SERVICES_FAILED_AUTOSTART = 15405;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_COM_TASK_STOP_PENDING"]/*' />
    [NativeTypeName("#define ERROR_COM_TASK_STOP_PENDING 15501L")]
    public const int ERROR_COM_TASK_STOP_PENDING = 15501;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_OPEN_PACKAGE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_OPEN_PACKAGE_FAILED 15600L")]
    public const int ERROR_INSTALL_OPEN_PACKAGE_FAILED = 15600;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_PACKAGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_PACKAGE_NOT_FOUND 15601L")]
    public const int ERROR_INSTALL_PACKAGE_NOT_FOUND = 15601;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_INVALID_PACKAGE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_INVALID_PACKAGE 15602L")]
    public const int ERROR_INSTALL_INVALID_PACKAGE = 15602;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED 15603L")]
    public const int ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED = 15603;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_OUT_OF_DISK_SPACE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_OUT_OF_DISK_SPACE 15604L")]
    public const int ERROR_INSTALL_OUT_OF_DISK_SPACE = 15604;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_NETWORK_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_NETWORK_FAILURE 15605L")]
    public const int ERROR_INSTALL_NETWORK_FAILURE = 15605;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_REGISTRATION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_REGISTRATION_FAILURE 15606L")]
    public const int ERROR_INSTALL_REGISTRATION_FAILURE = 15606;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_DEREGISTRATION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_DEREGISTRATION_FAILURE 15607L")]
    public const int ERROR_INSTALL_DEREGISTRATION_FAILURE = 15607;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_CANCEL"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_CANCEL 15608L")]
    public const int ERROR_INSTALL_CANCEL = 15608;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_FAILED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_FAILED 15609L")]
    public const int ERROR_INSTALL_FAILED = 15609;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REMOVE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_REMOVE_FAILED 15610L")]
    public const int ERROR_REMOVE_FAILED = 15610;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_ALREADY_EXISTS 15611L")]
    public const int ERROR_PACKAGE_ALREADY_EXISTS = 15611;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NEEDS_REMEDIATION"]/*' />
    [NativeTypeName("#define ERROR_NEEDS_REMEDIATION 15612L")]
    public const int ERROR_NEEDS_REMEDIATION = 15612;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_PREREQUISITE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_PREREQUISITE_FAILED 15613L")]
    public const int ERROR_INSTALL_PREREQUISITE_FAILED = 15613;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_REPOSITORY_CORRUPTED"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_REPOSITORY_CORRUPTED 15614L")]
    public const int ERROR_PACKAGE_REPOSITORY_CORRUPTED = 15614;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_POLICY_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_POLICY_FAILURE 15615L")]
    public const int ERROR_INSTALL_POLICY_FAILURE = 15615;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_UPDATING"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_UPDATING 15616L")]
    public const int ERROR_PACKAGE_UPDATING = 15616;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPLOYMENT_BLOCKED_BY_POLICY"]/*' />
    [NativeTypeName("#define ERROR_DEPLOYMENT_BLOCKED_BY_POLICY 15617L")]
    public const int ERROR_DEPLOYMENT_BLOCKED_BY_POLICY = 15617;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGES_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_PACKAGES_IN_USE 15618L")]
    public const int ERROR_PACKAGES_IN_USE = 15618;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RECOVERY_FILE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_RECOVERY_FILE_CORRUPT 15619L")]
    public const int ERROR_RECOVERY_FILE_CORRUPT = 15619;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INVALID_STAGED_SIGNATURE"]/*' />
    [NativeTypeName("#define ERROR_INVALID_STAGED_SIGNATURE 15620L")]
    public const int ERROR_INVALID_STAGED_SIGNATURE = 15620;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED 15621L")]
    public const int ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED = 15621;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_PACKAGE_DOWNGRADE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_PACKAGE_DOWNGRADE 15622L")]
    public const int ERROR_INSTALL_PACKAGE_DOWNGRADE = 15622;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SYSTEM_NEEDS_REMEDIATION"]/*' />
    [NativeTypeName("#define ERROR_SYSTEM_NEEDS_REMEDIATION 15623L")]
    public const int ERROR_SYSTEM_NEEDS_REMEDIATION = 15623;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN"]/*' />
    [NativeTypeName("#define ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN 15624L")]
    public const int ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN = 15624;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_RESILIENCY_FILE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_RESILIENCY_FILE_CORRUPT 15625L")]
    public const int ERROR_RESILIENCY_FILE_CORRUPT = 15625;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING 15626L")]
    public const int ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING = 15626;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_MOVE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_MOVE_FAILED 15627L")]
    public const int ERROR_PACKAGE_MOVE_FAILED = 15627;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_VOLUME_NOT_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_VOLUME_NOT_EMPTY 15628L")]
    public const int ERROR_INSTALL_VOLUME_NOT_EMPTY = 15628;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_VOLUME_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_VOLUME_OFFLINE 15629L")]
    public const int ERROR_INSTALL_VOLUME_OFFLINE = 15629;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_VOLUME_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_VOLUME_CORRUPT 15630L")]
    public const int ERROR_INSTALL_VOLUME_CORRUPT = 15630;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NEEDS_REGISTRATION"]/*' />
    [NativeTypeName("#define ERROR_NEEDS_REGISTRATION 15631L")]
    public const int ERROR_NEEDS_REGISTRATION = 15631;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_WRONG_PROCESSOR_ARCHITECTURE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_WRONG_PROCESSOR_ARCHITECTURE 15632L")]
    public const int ERROR_INSTALL_WRONG_PROCESSOR_ARCHITECTURE = 15632;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEV_SIDELOAD_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DEV_SIDELOAD_LIMIT_EXCEEDED 15633L")]
    public const int ERROR_DEV_SIDELOAD_LIMIT_EXCEEDED = 15633;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE 15634L")]
    public const int ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE = 15634;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_NOT_SUPPORTED_ON_FILESYSTEM"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_NOT_SUPPORTED_ON_FILESYSTEM 15635L")]
    public const int ERROR_PACKAGE_NOT_SUPPORTED_ON_FILESYSTEM = 15635;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_MOVE_BLOCKED_BY_STREAMING"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_MOVE_BLOCKED_BY_STREAMING 15636L")]
    public const int ERROR_PACKAGE_MOVE_BLOCKED_BY_STREAMING = 15636;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_OPTIONAL_PACKAGE_APPLICATIONID_NOT_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_OPTIONAL_PACKAGE_APPLICATIONID_NOT_UNIQUE 15637L")]
    public const int ERROR_INSTALL_OPTIONAL_PACKAGE_APPLICATIONID_NOT_UNIQUE = 15637;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_STAGING_ONHOLD"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_STAGING_ONHOLD 15638L")]
    public const int ERROR_PACKAGE_STAGING_ONHOLD = 15638;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_INVALID_RELATED_SET_UPDATE"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_INVALID_RELATED_SET_UPDATE 15639L")]
    public const int ERROR_INSTALL_INVALID_RELATED_SET_UPDATE = 15639;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_FULLTRUST_CAPABILITY"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_FULLTRUST_CAPABILITY 15640L")]
    public const int ERROR_INSTALL_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_FULLTRUST_CAPABILITY = 15640;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPLOYMENT_BLOCKED_BY_USER_LOG_OFF"]/*' />
    [NativeTypeName("#define ERROR_DEPLOYMENT_BLOCKED_BY_USER_LOG_OFF 15641L")]
    public const int ERROR_DEPLOYMENT_BLOCKED_BY_USER_LOG_OFF = 15641;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PROVISION_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_PROVISIONED"]/*' />
    [NativeTypeName("#define ERROR_PROVISION_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_PROVISIONED 15642L")]
    public const int ERROR_PROVISION_OPTIONAL_PACKAGE_REQUIRES_MAIN_PACKAGE_PROVISIONED = 15642;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGES_REPUTATION_CHECK_FAILED"]/*' />
    [NativeTypeName("#define ERROR_PACKAGES_REPUTATION_CHECK_FAILED 15643L")]
    public const int ERROR_PACKAGES_REPUTATION_CHECK_FAILED = 15643;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGES_REPUTATION_CHECK_TIMEDOUT"]/*' />
    [NativeTypeName("#define ERROR_PACKAGES_REPUTATION_CHECK_TIMEDOUT 15644L")]
    public const int ERROR_PACKAGES_REPUTATION_CHECK_TIMEDOUT = 15644;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPLOYMENT_OPTION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_DEPLOYMENT_OPTION_NOT_SUPPORTED 15645L")]
    public const int ERROR_DEPLOYMENT_OPTION_NOT_SUPPORTED = 15645;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPINSTALLER_ACTIVATION_BLOCKED"]/*' />
    [NativeTypeName("#define ERROR_APPINSTALLER_ACTIVATION_BLOCKED 15646L")]
    public const int ERROR_APPINSTALLER_ACTIVATION_BLOCKED = 15646;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REGISTRATION_FROM_REMOTE_DRIVE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_REGISTRATION_FROM_REMOTE_DRIVE_NOT_SUPPORTED 15647L")]
    public const int ERROR_REGISTRATION_FROM_REMOTE_DRIVE_NOT_SUPPORTED = 15647;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPX_RAW_DATA_WRITE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_APPX_RAW_DATA_WRITE_FAILED 15648L")]
    public const int ERROR_APPX_RAW_DATA_WRITE_FAILED = 15648;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPLOYMENT_BLOCKED_BY_VOLUME_POLICY_PACKAGE"]/*' />
    [NativeTypeName("#define ERROR_DEPLOYMENT_BLOCKED_BY_VOLUME_POLICY_PACKAGE 15649L")]
    public const int ERROR_DEPLOYMENT_BLOCKED_BY_VOLUME_POLICY_PACKAGE = 15649;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPLOYMENT_BLOCKED_BY_VOLUME_POLICY_MACHINE"]/*' />
    [NativeTypeName("#define ERROR_DEPLOYMENT_BLOCKED_BY_VOLUME_POLICY_MACHINE 15650L")]
    public const int ERROR_DEPLOYMENT_BLOCKED_BY_VOLUME_POLICY_MACHINE = 15650;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPLOYMENT_BLOCKED_BY_PROFILE_POLICY"]/*' />
    [NativeTypeName("#define ERROR_DEPLOYMENT_BLOCKED_BY_PROFILE_POLICY 15651L")]
    public const int ERROR_DEPLOYMENT_BLOCKED_BY_PROFILE_POLICY = 15651;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPLOYMENT_FAILED_CONFLICTING_MUTABLE_PACKAGE_DIRECTORY"]/*' />
    [NativeTypeName("#define ERROR_DEPLOYMENT_FAILED_CONFLICTING_MUTABLE_PACKAGE_DIRECTORY 15652L")]
    public const int ERROR_DEPLOYMENT_FAILED_CONFLICTING_MUTABLE_PACKAGE_DIRECTORY = 15652;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SINGLETON_RESOURCE_INSTALLED_IN_ACTIVE_USER"]/*' />
    [NativeTypeName("#define ERROR_SINGLETON_RESOURCE_INSTALLED_IN_ACTIVE_USER 15653L")]
    public const int ERROR_SINGLETON_RESOURCE_INSTALLED_IN_ACTIVE_USER = 15653;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DIFFERENT_VERSION_OF_PACKAGED_SERVICE_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_DIFFERENT_VERSION_OF_PACKAGED_SERVICE_INSTALLED 15654L")]
    public const int ERROR_DIFFERENT_VERSION_OF_PACKAGED_SERVICE_INSTALLED = 15654;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_EXISTS_AS_NON_PACKAGED_SERVICE"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_EXISTS_AS_NON_PACKAGED_SERVICE 15655L")]
    public const int ERROR_SERVICE_EXISTS_AS_NON_PACKAGED_SERVICE = 15655;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGED_SERVICE_REQUIRES_ADMIN_PRIVILEGES"]/*' />
    [NativeTypeName("#define ERROR_PACKAGED_SERVICE_REQUIRES_ADMIN_PRIVILEGES 15656L")]
    public const int ERROR_PACKAGED_SERVICE_REQUIRES_ADMIN_PRIVILEGES = 15656;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_REDIRECTION_TO_DEFAULT_ACCOUNT_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_REDIRECTION_TO_DEFAULT_ACCOUNT_NOT_ALLOWED 15657L")]
    public const int ERROR_REDIRECTION_TO_DEFAULT_ACCOUNT_NOT_ALLOWED = 15657;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_LACKS_CAPABILITY_TO_DEPLOY_ON_HOST"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_LACKS_CAPABILITY_TO_DEPLOY_ON_HOST 15658L")]
    public const int ERROR_PACKAGE_LACKS_CAPABILITY_TO_DEPLOY_ON_HOST = 15658;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNSIGNED_PACKAGE_INVALID_CONTENT"]/*' />
    [NativeTypeName("#define ERROR_UNSIGNED_PACKAGE_INVALID_CONTENT 15659L")]
    public const int ERROR_UNSIGNED_PACKAGE_INVALID_CONTENT = 15659;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNSIGNED_PACKAGE_INVALID_PUBLISHER_NAMESPACE"]/*' />
    [NativeTypeName("#define ERROR_UNSIGNED_PACKAGE_INVALID_PUBLISHER_NAMESPACE 15660L")]
    public const int ERROR_UNSIGNED_PACKAGE_INVALID_PUBLISHER_NAMESPACE = 15660;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SIGNED_PACKAGE_INVALID_PUBLISHER_NAMESPACE"]/*' />
    [NativeTypeName("#define ERROR_SIGNED_PACKAGE_INVALID_PUBLISHER_NAMESPACE 15661L")]
    public const int ERROR_SIGNED_PACKAGE_INVALID_PUBLISHER_NAMESPACE = 15661;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_EXTERNAL_LOCATION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_EXTERNAL_LOCATION_NOT_ALLOWED 15662L")]
    public const int ERROR_PACKAGE_EXTERNAL_LOCATION_NOT_ALLOWED = 15662;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_FULLTRUST_HOSTRUNTIME_REQUIRES_MAIN_PACKAGE_FULLTRUST_CAPABILITY"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_FULLTRUST_HOSTRUNTIME_REQUIRES_MAIN_PACKAGE_FULLTRUST_CAPABILITY 15663L")]
    public const int ERROR_INSTALL_FULLTRUST_HOSTRUNTIME_REQUIRES_MAIN_PACKAGE_FULLTRUST_CAPABILITY = 15663;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_LACKS_CAPABILITY_FOR_MANDATORY_STARTUPTASKS"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_LACKS_CAPABILITY_FOR_MANDATORY_STARTUPTASKS 15664L")]
    public const int ERROR_PACKAGE_LACKS_CAPABILITY_FOR_MANDATORY_STARTUPTASKS = 15664;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_INSTALL_RESOLVE_HOSTRUNTIME_DEPENDENCY_FAILED"]/*' />
    [NativeTypeName("#define ERROR_INSTALL_RESOLVE_HOSTRUNTIME_DEPENDENCY_FAILED 15665L")]
    public const int ERROR_INSTALL_RESOLVE_HOSTRUNTIME_DEPENDENCY_FAILED = 15665;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MACHINE_SCOPE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_MACHINE_SCOPE_NOT_ALLOWED 15666L")]
    public const int ERROR_MACHINE_SCOPE_NOT_ALLOWED = 15666;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLASSIC_COMPAT_MODE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_CLASSIC_COMPAT_MODE_NOT_ALLOWED 15667L")]
    public const int ERROR_CLASSIC_COMPAT_MODE_NOT_ALLOWED = 15667;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STAGEFROMUPDATEAGENT_PACKAGE_NOT_APPLICABLE"]/*' />
    [NativeTypeName("#define ERROR_STAGEFROMUPDATEAGENT_PACKAGE_NOT_APPLICABLE 15668L")]
    public const int ERROR_STAGEFROMUPDATEAGENT_PACKAGE_NOT_APPLICABLE = 15668;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_NOT_REGISTERED_FOR_USER"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_NOT_REGISTERED_FOR_USER 15669L")]
    public const int ERROR_PACKAGE_NOT_REGISTERED_FOR_USER = 15669;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_NAME_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_NAME_MISMATCH 15670L")]
    public const int ERROR_PACKAGE_NAME_MISMATCH = 15670;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPINSTALLER_URI_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_APPINSTALLER_URI_IN_USE 15671L")]
    public const int ERROR_APPINSTALLER_URI_IN_USE = 15671;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_APPINSTALLER_IS_MANAGED_BY_SYSTEM"]/*' />
    [NativeTypeName("#define ERROR_APPINSTALLER_IS_MANAGED_BY_SYSTEM 15672L")]
    public const int ERROR_APPINSTALLER_IS_MANAGED_BY_SYSTEM = 15672;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SERVICE_BLOCKED_BY_SYSPREP_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_SERVICE_BLOCKED_BY_SYSPREP_IN_PROGRESS 15673L")]
    public const int ERROR_SERVICE_BLOCKED_BY_SYSPREP_IN_PROGRESS = 15673;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UNSUPPORTED_ARM32_PACKAGE_REQUIRES_REMEDIAITON"]/*' />
    [NativeTypeName("#define ERROR_UNSUPPORTED_ARM32_PACKAGE_REQUIRES_REMEDIAITON 15674L")]
    public const int ERROR_UNSUPPORTED_ARM32_PACKAGE_REQUIRES_REMEDIAITON = 15674;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_UUP_PRODUCT_NOT_APPLICABLE"]/*' />
    [NativeTypeName("#define ERROR_UUP_PRODUCT_NOT_APPLICABLE 15675L")]
    public const int ERROR_UUP_PRODUCT_NOT_APPLICABLE = 15675;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BLOCKED_BY_PENDING_PACKAGE_REMOVAL"]/*' />
    [NativeTypeName("#define ERROR_BLOCKED_BY_PENDING_PACKAGE_REMOVAL 15676L")]
    public const int ERROR_BLOCKED_BY_PENDING_PACKAGE_REMOVAL = 15676;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_REPOSITORY_ROOT_CORRUPTED"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_REPOSITORY_ROOT_CORRUPTED 15677L")]
    public const int ERROR_PACKAGE_REPOSITORY_ROOT_CORRUPTED = 15677;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PACKAGE_MANIFEST_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PACKAGE_MANIFEST_NOT_FOUND 15678L")]
    public const int ERROR_PACKAGE_MANIFEST_NOT_FOUND = 15678;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DEPLOYMENT_BLOCKED_BY_REMOVEDEFAULTPACKAGES_POLICY"]/*' />
    [NativeTypeName("#define ERROR_DEPLOYMENT_BLOCKED_BY_REMOVEDEFAULTPACKAGES_POLICY 15679L")]
    public const int ERROR_DEPLOYMENT_BLOCKED_BY_REMOVEDEFAULTPACKAGES_POLICY = 15679;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_URI_BLOCKED_BY_POLICY_MSIXALLOWEDZONES"]/*' />
    [NativeTypeName("#define ERROR_URI_BLOCKED_BY_POLICY_MSIXALLOWEDZONES 15680L")]
    public const int ERROR_URI_BLOCKED_BY_POLICY_MSIXALLOWEDZONES = 15680;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_URI_RECOMMENDED_BLOCK_BY_SMARTSCREEN"]/*' />
    [NativeTypeName("#define ERROR_URI_RECOMMENDED_BLOCK_BY_SMARTSCREEN 15681L")]
    public const int ERROR_URI_RECOMMENDED_BLOCK_BY_SMARTSCREEN = 15681;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_LOAD_STORE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_LOAD_STORE_FAILED 15800L")]
    public const int ERROR_STATE_LOAD_STORE_FAILED = 15800;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_GET_VERSION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_GET_VERSION_FAILED 15801L")]
    public const int ERROR_STATE_GET_VERSION_FAILED = 15801;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_SET_VERSION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_SET_VERSION_FAILED 15802L")]
    public const int ERROR_STATE_SET_VERSION_FAILED = 15802;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_STRUCTURED_RESET_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_STRUCTURED_RESET_FAILED 15803L")]
    public const int ERROR_STATE_STRUCTURED_RESET_FAILED = 15803;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_OPEN_CONTAINER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_OPEN_CONTAINER_FAILED 15804L")]
    public const int ERROR_STATE_OPEN_CONTAINER_FAILED = 15804;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_CREATE_CONTAINER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_CREATE_CONTAINER_FAILED 15805L")]
    public const int ERROR_STATE_CREATE_CONTAINER_FAILED = 15805;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_DELETE_CONTAINER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_DELETE_CONTAINER_FAILED 15806L")]
    public const int ERROR_STATE_DELETE_CONTAINER_FAILED = 15806;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_READ_SETTING_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_READ_SETTING_FAILED 15807L")]
    public const int ERROR_STATE_READ_SETTING_FAILED = 15807;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_WRITE_SETTING_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_WRITE_SETTING_FAILED 15808L")]
    public const int ERROR_STATE_WRITE_SETTING_FAILED = 15808;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_DELETE_SETTING_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_DELETE_SETTING_FAILED 15809L")]
    public const int ERROR_STATE_DELETE_SETTING_FAILED = 15809;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_QUERY_SETTING_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_QUERY_SETTING_FAILED 15810L")]
    public const int ERROR_STATE_QUERY_SETTING_FAILED = 15810;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_READ_COMPOSITE_SETTING_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_READ_COMPOSITE_SETTING_FAILED 15811L")]
    public const int ERROR_STATE_READ_COMPOSITE_SETTING_FAILED = 15811;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED 15812L")]
    public const int ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED = 15812;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_ENUMERATE_CONTAINER_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_ENUMERATE_CONTAINER_FAILED 15813L")]
    public const int ERROR_STATE_ENUMERATE_CONTAINER_FAILED = 15813;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_ENUMERATE_SETTINGS_FAILED"]/*' />
    [NativeTypeName("#define ERROR_STATE_ENUMERATE_SETTINGS_FAILED 15814L")]
    public const int ERROR_STATE_ENUMERATE_SETTINGS_FAILED = 15814;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED 15815L")]
    public const int ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED = 15815;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED 15816L")]
    public const int ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED = 15816;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED 15817L")]
    public const int ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED = 15817;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED 15818L")]
    public const int ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED = 15818;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_API_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_API_UNAVAILABLE 15841L")]
    public const int ERROR_API_UNAVAILABLE = 15841;

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_AUDITING_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_AUDITING_DISABLED _HRESULT_TYPEDEF_(0xC0090001L)")]
    public const int ERROR_AUDITING_DISABLED = unchecked((int)(0xC0090001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ALL_SIDS_FILTERED"]/*' />
    [NativeTypeName("#define ERROR_ALL_SIDS_FILTERED _HRESULT_TYPEDEF_(0xC0090002L)")]
    public const int ERROR_ALL_SIDS_FILTERED = unchecked((int)(0xC0090002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BIZRULES_NOT_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_BIZRULES_NOT_ENABLED _HRESULT_TYPEDEF_(0xC0090003L)")]
    public const int ERROR_BIZRULES_NOT_ENABLED = unchecked((int)(0xC0090003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CRED_REQUIRES_CONFIRMATION"]/*' />
    [NativeTypeName("#define ERROR_CRED_REQUIRES_CONFIRMATION _HRESULT_TYPEDEF_(0x80097019L)")]
    public const int ERROR_CRED_REQUIRES_CONFIRMATION = unchecked((int)(0x80097019));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_IO_COMPLETE"]/*' />
    [NativeTypeName("#define ERROR_FLT_IO_COMPLETE _HRESULT_TYPEDEF_(0x001F0001L)")]
    public const int ERROR_FLT_IO_COMPLETE = ((int)(0x001F0001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_NO_HANDLER_DEFINED"]/*' />
    [NativeTypeName("#define ERROR_FLT_NO_HANDLER_DEFINED _HRESULT_TYPEDEF_(0x801F0001L)")]
    public const int ERROR_FLT_NO_HANDLER_DEFINED = unchecked((int)(0x801F0001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_CONTEXT_ALREADY_DEFINED"]/*' />
    [NativeTypeName("#define ERROR_FLT_CONTEXT_ALREADY_DEFINED _HRESULT_TYPEDEF_(0x801F0002L)")]
    public const int ERROR_FLT_CONTEXT_ALREADY_DEFINED = unchecked((int)(0x801F0002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_INVALID_ASYNCHRONOUS_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_FLT_INVALID_ASYNCHRONOUS_REQUEST _HRESULT_TYPEDEF_(0x801F0003L)")]
    public const int ERROR_FLT_INVALID_ASYNCHRONOUS_REQUEST = unchecked((int)(0x801F0003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_DISALLOW_FAST_IO"]/*' />
    [NativeTypeName("#define ERROR_FLT_DISALLOW_FAST_IO _HRESULT_TYPEDEF_(0x801F0004L)")]
    public const int ERROR_FLT_DISALLOW_FAST_IO = unchecked((int)(0x801F0004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_INVALID_NAME_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_FLT_INVALID_NAME_REQUEST _HRESULT_TYPEDEF_(0x801F0005L)")]
    public const int ERROR_FLT_INVALID_NAME_REQUEST = unchecked((int)(0x801F0005));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_NOT_SAFE_TO_POST_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_FLT_NOT_SAFE_TO_POST_OPERATION _HRESULT_TYPEDEF_(0x801F0006L)")]
    public const int ERROR_FLT_NOT_SAFE_TO_POST_OPERATION = unchecked((int)(0x801F0006));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define ERROR_FLT_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x801F0007L)")]
    public const int ERROR_FLT_NOT_INITIALIZED = unchecked((int)(0x801F0007));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_FILTER_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_FLT_FILTER_NOT_READY _HRESULT_TYPEDEF_(0x801F0008L)")]
    public const int ERROR_FLT_FILTER_NOT_READY = unchecked((int)(0x801F0008));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_POST_OPERATION_CLEANUP"]/*' />
    [NativeTypeName("#define ERROR_FLT_POST_OPERATION_CLEANUP _HRESULT_TYPEDEF_(0x801F0009L)")]
    public const int ERROR_FLT_POST_OPERATION_CLEANUP = unchecked((int)(0x801F0009));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_FLT_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x801F000AL)")]
    public const int ERROR_FLT_INTERNAL_ERROR = unchecked((int)(0x801F000A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_DELETING_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_FLT_DELETING_OBJECT _HRESULT_TYPEDEF_(0x801F000BL)")]
    public const int ERROR_FLT_DELETING_OBJECT = unchecked((int)(0x801F000B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_MUST_BE_NONPAGED_POOL"]/*' />
    [NativeTypeName("#define ERROR_FLT_MUST_BE_NONPAGED_POOL _HRESULT_TYPEDEF_(0x801F000CL)")]
    public const int ERROR_FLT_MUST_BE_NONPAGED_POOL = unchecked((int)(0x801F000C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_DUPLICATE_ENTRY"]/*' />
    [NativeTypeName("#define ERROR_FLT_DUPLICATE_ENTRY _HRESULT_TYPEDEF_(0x801F000DL)")]
    public const int ERROR_FLT_DUPLICATE_ENTRY = unchecked((int)(0x801F000D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_CBDQ_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_FLT_CBDQ_DISABLED _HRESULT_TYPEDEF_(0x801F000EL)")]
    public const int ERROR_FLT_CBDQ_DISABLED = unchecked((int)(0x801F000E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_DO_NOT_ATTACH"]/*' />
    [NativeTypeName("#define ERROR_FLT_DO_NOT_ATTACH _HRESULT_TYPEDEF_(0x801F000FL)")]
    public const int ERROR_FLT_DO_NOT_ATTACH = unchecked((int)(0x801F000F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_DO_NOT_DETACH"]/*' />
    [NativeTypeName("#define ERROR_FLT_DO_NOT_DETACH _HRESULT_TYPEDEF_(0x801F0010L)")]
    public const int ERROR_FLT_DO_NOT_DETACH = unchecked((int)(0x801F0010));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_INSTANCE_ALTITUDE_COLLISION"]/*' />
    [NativeTypeName("#define ERROR_FLT_INSTANCE_ALTITUDE_COLLISION _HRESULT_TYPEDEF_(0x801F0011L)")]
    public const int ERROR_FLT_INSTANCE_ALTITUDE_COLLISION = unchecked((int)(0x801F0011));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_INSTANCE_NAME_COLLISION"]/*' />
    [NativeTypeName("#define ERROR_FLT_INSTANCE_NAME_COLLISION _HRESULT_TYPEDEF_(0x801F0012L)")]
    public const int ERROR_FLT_INSTANCE_NAME_COLLISION = unchecked((int)(0x801F0012));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_FILTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_FLT_FILTER_NOT_FOUND _HRESULT_TYPEDEF_(0x801F0013L)")]
    public const int ERROR_FLT_FILTER_NOT_FOUND = unchecked((int)(0x801F0013));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_VOLUME_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_FLT_VOLUME_NOT_FOUND _HRESULT_TYPEDEF_(0x801F0014L)")]
    public const int ERROR_FLT_VOLUME_NOT_FOUND = unchecked((int)(0x801F0014));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_INSTANCE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_FLT_INSTANCE_NOT_FOUND _HRESULT_TYPEDEF_(0x801F0015L)")]
    public const int ERROR_FLT_INSTANCE_NOT_FOUND = unchecked((int)(0x801F0015));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_CONTEXT_ALLOCATION_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_FLT_CONTEXT_ALLOCATION_NOT_FOUND _HRESULT_TYPEDEF_(0x801F0016L)")]
    public const int ERROR_FLT_CONTEXT_ALLOCATION_NOT_FOUND = unchecked((int)(0x801F0016));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_INVALID_CONTEXT_REGISTRATION"]/*' />
    [NativeTypeName("#define ERROR_FLT_INVALID_CONTEXT_REGISTRATION _HRESULT_TYPEDEF_(0x801F0017L)")]
    public const int ERROR_FLT_INVALID_CONTEXT_REGISTRATION = unchecked((int)(0x801F0017));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_NAME_CACHE_MISS"]/*' />
    [NativeTypeName("#define ERROR_FLT_NAME_CACHE_MISS _HRESULT_TYPEDEF_(0x801F0018L)")]
    public const int ERROR_FLT_NAME_CACHE_MISS = unchecked((int)(0x801F0018));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_NO_DEVICE_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_FLT_NO_DEVICE_OBJECT _HRESULT_TYPEDEF_(0x801F0019L)")]
    public const int ERROR_FLT_NO_DEVICE_OBJECT = unchecked((int)(0x801F0019));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_VOLUME_ALREADY_MOUNTED"]/*' />
    [NativeTypeName("#define ERROR_FLT_VOLUME_ALREADY_MOUNTED _HRESULT_TYPEDEF_(0x801F001AL)")]
    public const int ERROR_FLT_VOLUME_ALREADY_MOUNTED = unchecked((int)(0x801F001A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_ALREADY_ENLISTED"]/*' />
    [NativeTypeName("#define ERROR_FLT_ALREADY_ENLISTED _HRESULT_TYPEDEF_(0x801F001BL)")]
    public const int ERROR_FLT_ALREADY_ENLISTED = unchecked((int)(0x801F001B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_CONTEXT_ALREADY_LINKED"]/*' />
    [NativeTypeName("#define ERROR_FLT_CONTEXT_ALREADY_LINKED _HRESULT_TYPEDEF_(0x801F001CL)")]
    public const int ERROR_FLT_CONTEXT_ALREADY_LINKED = unchecked((int)(0x801F001C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_NO_WAITER_FOR_REPLY"]/*' />
    [NativeTypeName("#define ERROR_FLT_NO_WAITER_FOR_REPLY _HRESULT_TYPEDEF_(0x801F0020L)")]
    public const int ERROR_FLT_NO_WAITER_FOR_REPLY = unchecked((int)(0x801F0020));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_REGISTRATION_BUSY"]/*' />
    [NativeTypeName("#define ERROR_FLT_REGISTRATION_BUSY _HRESULT_TYPEDEF_(0x801F0023L)")]
    public const int ERROR_FLT_REGISTRATION_BUSY = unchecked((int)(0x801F0023));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_FLT_WCOS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_FLT_WCOS_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x801F0024L)")]
    public const int ERROR_FLT_WCOS_NOT_SUPPORTED = unchecked((int)(0x801F0024));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HUNG_DISPLAY_DRIVER_THREAD"]/*' />
    [NativeTypeName("#define ERROR_HUNG_DISPLAY_DRIVER_THREAD _HRESULT_TYPEDEF_(0x80260001L)")]
    public const int ERROR_HUNG_DISPLAY_DRIVER_THREAD = unchecked((int)(0x80260001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_NO_DESCRIPTOR"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_NO_DESCRIPTOR _HRESULT_TYPEDEF_(0x00261001L)")]
    public const int ERROR_MONITOR_NO_DESCRIPTOR = ((int)(0x00261001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT _HRESULT_TYPEDEF_(0x00261002L)")]
    public const int ERROR_MONITOR_UNKNOWN_DESCRIPTOR_FORMAT = ((int)(0x00261002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_INVALID_DESCRIPTOR_CHECKSUM"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_INVALID_DESCRIPTOR_CHECKSUM _HRESULT_TYPEDEF_(0xC0261003L)")]
    public const int ERROR_MONITOR_INVALID_DESCRIPTOR_CHECKSUM = unchecked((int)(0xC0261003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_INVALID_STANDARD_TIMING_BLOCK"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_INVALID_STANDARD_TIMING_BLOCK _HRESULT_TYPEDEF_(0xC0261004L)")]
    public const int ERROR_MONITOR_INVALID_STANDARD_TIMING_BLOCK = unchecked((int)(0xC0261004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED _HRESULT_TYPEDEF_(0xC0261005L)")]
    public const int ERROR_MONITOR_WMI_DATABLOCK_REGISTRATION_FAILED = unchecked((int)(0xC0261005));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK _HRESULT_TYPEDEF_(0xC0261006L)")]
    public const int ERROR_MONITOR_INVALID_SERIAL_NUMBER_MONDSC_BLOCK = unchecked((int)(0xC0261006));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK _HRESULT_TYPEDEF_(0xC0261007L)")]
    public const int ERROR_MONITOR_INVALID_USER_FRIENDLY_MONDSC_BLOCK = unchecked((int)(0xC0261007));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_NO_MORE_DESCRIPTOR_DATA"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_NO_MORE_DESCRIPTOR_DATA _HRESULT_TYPEDEF_(0xC0261008L)")]
    public const int ERROR_MONITOR_NO_MORE_DESCRIPTOR_DATA = unchecked((int)(0xC0261008));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_INVALID_DETAILED_TIMING_BLOCK"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_INVALID_DETAILED_TIMING_BLOCK _HRESULT_TYPEDEF_(0xC0261009L)")]
    public const int ERROR_MONITOR_INVALID_DETAILED_TIMING_BLOCK = unchecked((int)(0xC0261009));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_MONITOR_INVALID_MANUFACTURE_DATE"]/*' />
    [NativeTypeName("#define ERROR_MONITOR_INVALID_MANUFACTURE_DATE _HRESULT_TYPEDEF_(0xC026100AL)")]
    public const int ERROR_MONITOR_INVALID_MANUFACTURE_DATE = unchecked((int)(0xC026100A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER _HRESULT_TYPEDEF_(0xC0262000L)")]
    public const int ERROR_GRAPHICS_NOT_EXCLUSIVE_MODE_OWNER = unchecked((int)(0xC0262000));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INSUFFICIENT_DMA_BUFFER"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INSUFFICIENT_DMA_BUFFER _HRESULT_TYPEDEF_(0xC0262001L)")]
    public const int ERROR_GRAPHICS_INSUFFICIENT_DMA_BUFFER = unchecked((int)(0xC0262001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_DISPLAY_ADAPTER"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_DISPLAY_ADAPTER _HRESULT_TYPEDEF_(0xC0262002L)")]
    public const int ERROR_GRAPHICS_INVALID_DISPLAY_ADAPTER = unchecked((int)(0xC0262002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ADAPTER_WAS_RESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ADAPTER_WAS_RESET _HRESULT_TYPEDEF_(0xC0262003L)")]
    public const int ERROR_GRAPHICS_ADAPTER_WAS_RESET = unchecked((int)(0xC0262003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_DRIVER_MODEL"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_DRIVER_MODEL _HRESULT_TYPEDEF_(0xC0262004L)")]
    public const int ERROR_GRAPHICS_INVALID_DRIVER_MODEL = unchecked((int)(0xC0262004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PRESENT_MODE_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PRESENT_MODE_CHANGED _HRESULT_TYPEDEF_(0xC0262005L)")]
    public const int ERROR_GRAPHICS_PRESENT_MODE_CHANGED = unchecked((int)(0xC0262005));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PRESENT_OCCLUDED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PRESENT_OCCLUDED _HRESULT_TYPEDEF_(0xC0262006L)")]
    public const int ERROR_GRAPHICS_PRESENT_OCCLUDED = unchecked((int)(0xC0262006));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PRESENT_DENIED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PRESENT_DENIED _HRESULT_TYPEDEF_(0xC0262007L)")]
    public const int ERROR_GRAPHICS_PRESENT_DENIED = unchecked((int)(0xC0262007));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CANNOTCOLORCONVERT"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CANNOTCOLORCONVERT _HRESULT_TYPEDEF_(0xC0262008L)")]
    public const int ERROR_GRAPHICS_CANNOTCOLORCONVERT = unchecked((int)(0xC0262008));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DRIVER_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DRIVER_MISMATCH _HRESULT_TYPEDEF_(0xC0262009L)")]
    public const int ERROR_GRAPHICS_DRIVER_MISMATCH = unchecked((int)(0xC0262009));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PARTIAL_DATA_POPULATED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PARTIAL_DATA_POPULATED _HRESULT_TYPEDEF_(0x4026200AL)")]
    public const int ERROR_GRAPHICS_PARTIAL_DATA_POPULATED = ((int)(0x4026200A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PRESENT_REDIRECTION_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PRESENT_REDIRECTION_DISABLED _HRESULT_TYPEDEF_(0xC026200BL)")]
    public const int ERROR_GRAPHICS_PRESENT_REDIRECTION_DISABLED = unchecked((int)(0xC026200B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PRESENT_UNOCCLUDED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PRESENT_UNOCCLUDED _HRESULT_TYPEDEF_(0xC026200CL)")]
    public const int ERROR_GRAPHICS_PRESENT_UNOCCLUDED = unchecked((int)(0xC026200C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_WINDOWDC_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_WINDOWDC_NOT_AVAILABLE _HRESULT_TYPEDEF_(0xC026200DL)")]
    public const int ERROR_GRAPHICS_WINDOWDC_NOT_AVAILABLE = unchecked((int)(0xC026200D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_WINDOWLESS_PRESENT_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_WINDOWLESS_PRESENT_DISABLED _HRESULT_TYPEDEF_(0xC026200EL)")]
    public const int ERROR_GRAPHICS_WINDOWLESS_PRESENT_DISABLED = unchecked((int)(0xC026200E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PRESENT_INVALID_WINDOW"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PRESENT_INVALID_WINDOW _HRESULT_TYPEDEF_(0xC026200FL)")]
    public const int ERROR_GRAPHICS_PRESENT_INVALID_WINDOW = unchecked((int)(0xC026200F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PRESENT_BUFFER_NOT_BOUND"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PRESENT_BUFFER_NOT_BOUND _HRESULT_TYPEDEF_(0xC0262010L)")]
    public const int ERROR_GRAPHICS_PRESENT_BUFFER_NOT_BOUND = unchecked((int)(0xC0262010));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VAIL_STATE_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VAIL_STATE_CHANGED _HRESULT_TYPEDEF_(0xC0262011L)")]
    public const int ERROR_GRAPHICS_VAIL_STATE_CHANGED = unchecked((int)(0xC0262011));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INDIRECT_DISPLAY_ABANDON_SWAPCHAIN"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INDIRECT_DISPLAY_ABANDON_SWAPCHAIN _HRESULT_TYPEDEF_(0xC0262012L)")]
    public const int ERROR_GRAPHICS_INDIRECT_DISPLAY_ABANDON_SWAPCHAIN = unchecked((int)(0xC0262012));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INDIRECT_DISPLAY_DEVICE_STOPPED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INDIRECT_DISPLAY_DEVICE_STOPPED _HRESULT_TYPEDEF_(0xC0262013L)")]
    public const int ERROR_GRAPHICS_INDIRECT_DISPLAY_DEVICE_STOPPED = unchecked((int)(0xC0262013));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_CREATE_SUPERWETINK_MESSAGE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_CREATE_SUPERWETINK_MESSAGE _HRESULT_TYPEDEF_(0xC0262014L)")]
    public const int ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_CREATE_SUPERWETINK_MESSAGE = unchecked((int)(0xC0262014));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_DESTROY_SUPERWETINK_MESSAGE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_DESTROY_SUPERWETINK_MESSAGE _HRESULT_TYPEDEF_(0xC0262015L)")]
    public const int ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_DESTROY_SUPERWETINK_MESSAGE = unchecked((int)(0xC0262015));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_COMPOSITION_WINDOW_DPI_MESSAGE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_COMPOSITION_WINDOW_DPI_MESSAGE _HRESULT_TYPEDEF_(0xC0262016L)")]
    public const int ERROR_GRAPHICS_VAIL_FAILED_TO_SEND_COMPOSITION_WINDOW_DPI_MESSAGE = unchecked((int)(0xC0262016));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_LINK_CONFIGURATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_LINK_CONFIGURATION_IN_PROGRESS _HRESULT_TYPEDEF_(0xC0262017L)")]
    public const int ERROR_GRAPHICS_LINK_CONFIGURATION_IN_PROGRESS = unchecked((int)(0xC0262017));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MPO_ALLOCATION_UNPINNED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MPO_ALLOCATION_UNPINNED _HRESULT_TYPEDEF_(0xC0262018L)")]
    public const int ERROR_GRAPHICS_MPO_ALLOCATION_UNPINNED = unchecked((int)(0xC0262018));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_SETDISPLAYMODE_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_SETDISPLAYMODE_REQUIRED _HRESULT_TYPEDEF_(0xC0262019L)")]
    public const int ERROR_GRAPHICS_SETDISPLAYMODE_REQUIRED = unchecked((int)(0xC0262019));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_VIDEO_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_VIDEO_MEMORY _HRESULT_TYPEDEF_(0xC0262100L)")]
    public const int ERROR_GRAPHICS_NO_VIDEO_MEMORY = unchecked((int)(0xC0262100));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CANT_LOCK_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CANT_LOCK_MEMORY _HRESULT_TYPEDEF_(0xC0262101L)")]
    public const int ERROR_GRAPHICS_CANT_LOCK_MEMORY = unchecked((int)(0xC0262101));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ALLOCATION_BUSY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ALLOCATION_BUSY _HRESULT_TYPEDEF_(0xC0262102L)")]
    public const int ERROR_GRAPHICS_ALLOCATION_BUSY = unchecked((int)(0xC0262102));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_TOO_MANY_REFERENCES"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_TOO_MANY_REFERENCES _HRESULT_TYPEDEF_(0xC0262103L)")]
    public const int ERROR_GRAPHICS_TOO_MANY_REFERENCES = unchecked((int)(0xC0262103));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_TRY_AGAIN_LATER"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_TRY_AGAIN_LATER _HRESULT_TYPEDEF_(0xC0262104L)")]
    public const int ERROR_GRAPHICS_TRY_AGAIN_LATER = unchecked((int)(0xC0262104));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_TRY_AGAIN_NOW"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_TRY_AGAIN_NOW _HRESULT_TYPEDEF_(0xC0262105L)")]
    public const int ERROR_GRAPHICS_TRY_AGAIN_NOW = unchecked((int)(0xC0262105));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ALLOCATION_INVALID"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ALLOCATION_INVALID _HRESULT_TYPEDEF_(0xC0262106L)")]
    public const int ERROR_GRAPHICS_ALLOCATION_INVALID = unchecked((int)(0xC0262106));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE _HRESULT_TYPEDEF_(0xC0262107L)")]
    public const int ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNAVAILABLE = unchecked((int)(0xC0262107));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED _HRESULT_TYPEDEF_(0xC0262108L)")]
    public const int ERROR_GRAPHICS_UNSWIZZLING_APERTURE_UNSUPPORTED = unchecked((int)(0xC0262108));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION _HRESULT_TYPEDEF_(0xC0262109L)")]
    public const int ERROR_GRAPHICS_CANT_EVICT_PINNED_ALLOCATION = unchecked((int)(0xC0262109));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_ALLOCATION_USAGE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_ALLOCATION_USAGE _HRESULT_TYPEDEF_(0xC0262110L)")]
    public const int ERROR_GRAPHICS_INVALID_ALLOCATION_USAGE = unchecked((int)(0xC0262110));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION _HRESULT_TYPEDEF_(0xC0262111L)")]
    public const int ERROR_GRAPHICS_CANT_RENDER_LOCKED_ALLOCATION = unchecked((int)(0xC0262111));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ALLOCATION_CLOSED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ALLOCATION_CLOSED _HRESULT_TYPEDEF_(0xC0262112L)")]
    public const int ERROR_GRAPHICS_ALLOCATION_CLOSED = unchecked((int)(0xC0262112));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_ALLOCATION_INSTANCE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_ALLOCATION_INSTANCE _HRESULT_TYPEDEF_(0xC0262113L)")]
    public const int ERROR_GRAPHICS_INVALID_ALLOCATION_INSTANCE = unchecked((int)(0xC0262113));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_ALLOCATION_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_ALLOCATION_HANDLE _HRESULT_TYPEDEF_(0xC0262114L)")]
    public const int ERROR_GRAPHICS_INVALID_ALLOCATION_HANDLE = unchecked((int)(0xC0262114));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_WRONG_ALLOCATION_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_WRONG_ALLOCATION_DEVICE _HRESULT_TYPEDEF_(0xC0262115L)")]
    public const int ERROR_GRAPHICS_WRONG_ALLOCATION_DEVICE = unchecked((int)(0xC0262115));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ALLOCATION_CONTENT_LOST"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ALLOCATION_CONTENT_LOST _HRESULT_TYPEDEF_(0xC0262116L)")]
    public const int ERROR_GRAPHICS_ALLOCATION_CONTENT_LOST = unchecked((int)(0xC0262116));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_GPU_EXCEPTION_ON_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_GPU_EXCEPTION_ON_DEVICE _HRESULT_TYPEDEF_(0xC0262200L)")]
    public const int ERROR_GRAPHICS_GPU_EXCEPTION_ON_DEVICE = unchecked((int)(0xC0262200));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_SKIP_ALLOCATION_PREPARATION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_SKIP_ALLOCATION_PREPARATION _HRESULT_TYPEDEF_(0x40262201L)")]
    public const int ERROR_GRAPHICS_SKIP_ALLOCATION_PREPARATION = ((int)(0x40262201));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY _HRESULT_TYPEDEF_(0xC0262300L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY = unchecked((int)(0xC0262300));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262301L)")]
    public const int ERROR_GRAPHICS_VIDPN_TOPOLOGY_NOT_SUPPORTED = unchecked((int)(0xC0262301));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262302L)")]
    public const int ERROR_GRAPHICS_VIDPN_TOPOLOGY_CURRENTLY_NOT_SUPPORTED = unchecked((int)(0xC0262302));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDPN"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDPN _HRESULT_TYPEDEF_(0xC0262303L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDPN = unchecked((int)(0xC0262303));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE _HRESULT_TYPEDEF_(0xC0262304L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE = unchecked((int)(0xC0262304));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET _HRESULT_TYPEDEF_(0xC0262305L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET = unchecked((int)(0xC0262305));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262306L)")]
    public const int ERROR_GRAPHICS_VIDPN_MODALITY_NOT_SUPPORTED = unchecked((int)(0xC0262306));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MODE_NOT_PINNED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MODE_NOT_PINNED _HRESULT_TYPEDEF_(0x00262307L)")]
    public const int ERROR_GRAPHICS_MODE_NOT_PINNED = ((int)(0x00262307));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDPN_SOURCEMODESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDPN_SOURCEMODESET _HRESULT_TYPEDEF_(0xC0262308L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDPN_SOURCEMODESET = unchecked((int)(0xC0262308));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDPN_TARGETMODESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDPN_TARGETMODESET _HRESULT_TYPEDEF_(0xC0262309L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDPN_TARGETMODESET = unchecked((int)(0xC0262309));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_FREQUENCY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_FREQUENCY _HRESULT_TYPEDEF_(0xC026230AL)")]
    public const int ERROR_GRAPHICS_INVALID_FREQUENCY = unchecked((int)(0xC026230A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_ACTIVE_REGION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_ACTIVE_REGION _HRESULT_TYPEDEF_(0xC026230BL)")]
    public const int ERROR_GRAPHICS_INVALID_ACTIVE_REGION = unchecked((int)(0xC026230B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_TOTAL_REGION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_TOTAL_REGION _HRESULT_TYPEDEF_(0xC026230CL)")]
    public const int ERROR_GRAPHICS_INVALID_TOTAL_REGION = unchecked((int)(0xC026230C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE _HRESULT_TYPEDEF_(0xC0262310L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_SOURCE_MODE = unchecked((int)(0xC0262310));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE _HRESULT_TYPEDEF_(0xC0262311L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDEO_PRESENT_TARGET_MODE = unchecked((int)(0xC0262311));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET _HRESULT_TYPEDEF_(0xC0262312L)")]
    public const int ERROR_GRAPHICS_PINNED_MODE_MUST_REMAIN_IN_SET = unchecked((int)(0xC0262312));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY _HRESULT_TYPEDEF_(0xC0262313L)")]
    public const int ERROR_GRAPHICS_PATH_ALREADY_IN_TOPOLOGY = unchecked((int)(0xC0262313));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MODE_ALREADY_IN_MODESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MODE_ALREADY_IN_MODESET _HRESULT_TYPEDEF_(0xC0262314L)")]
    public const int ERROR_GRAPHICS_MODE_ALREADY_IN_MODESET = unchecked((int)(0xC0262314));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET _HRESULT_TYPEDEF_(0xC0262315L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDEOPRESENTSOURCESET = unchecked((int)(0xC0262315));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET _HRESULT_TYPEDEF_(0xC0262316L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDEOPRESENTTARGETSET = unchecked((int)(0xC0262316));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_SOURCE_ALREADY_IN_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_SOURCE_ALREADY_IN_SET _HRESULT_TYPEDEF_(0xC0262317L)")]
    public const int ERROR_GRAPHICS_SOURCE_ALREADY_IN_SET = unchecked((int)(0xC0262317));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_TARGET_ALREADY_IN_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_TARGET_ALREADY_IN_SET _HRESULT_TYPEDEF_(0xC0262318L)")]
    public const int ERROR_GRAPHICS_TARGET_ALREADY_IN_SET = unchecked((int)(0xC0262318));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDPN_PRESENT_PATH"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDPN_PRESENT_PATH _HRESULT_TYPEDEF_(0xC0262319L)")]
    public const int ERROR_GRAPHICS_INVALID_VIDPN_PRESENT_PATH = unchecked((int)(0xC0262319));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY _HRESULT_TYPEDEF_(0xC026231AL)")]
    public const int ERROR_GRAPHICS_NO_RECOMMENDED_VIDPN_TOPOLOGY = unchecked((int)(0xC026231A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET _HRESULT_TYPEDEF_(0xC026231BL)")]
    public const int ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGESET = unchecked((int)(0xC026231B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE _HRESULT_TYPEDEF_(0xC026231CL)")]
    public const int ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE = unchecked((int)(0xC026231C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET _HRESULT_TYPEDEF_(0xC026231DL)")]
    public const int ERROR_GRAPHICS_FREQUENCYRANGE_NOT_IN_SET = unchecked((int)(0xC026231D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_PREFERRED_MODE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_PREFERRED_MODE _HRESULT_TYPEDEF_(0x0026231EL)")]
    public const int ERROR_GRAPHICS_NO_PREFERRED_MODE = ((int)(0x0026231E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET _HRESULT_TYPEDEF_(0xC026231FL)")]
    public const int ERROR_GRAPHICS_FREQUENCYRANGE_ALREADY_IN_SET = unchecked((int)(0xC026231F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_STALE_MODESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_STALE_MODESET _HRESULT_TYPEDEF_(0xC0262320L)")]
    public const int ERROR_GRAPHICS_STALE_MODESET = unchecked((int)(0xC0262320));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MONITOR_SOURCEMODESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MONITOR_SOURCEMODESET _HRESULT_TYPEDEF_(0xC0262321L)")]
    public const int ERROR_GRAPHICS_INVALID_MONITOR_SOURCEMODESET = unchecked((int)(0xC0262321));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MONITOR_SOURCE_MODE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MONITOR_SOURCE_MODE _HRESULT_TYPEDEF_(0xC0262322L)")]
    public const int ERROR_GRAPHICS_INVALID_MONITOR_SOURCE_MODE = unchecked((int)(0xC0262322));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN _HRESULT_TYPEDEF_(0xC0262323L)")]
    public const int ERROR_GRAPHICS_NO_RECOMMENDED_FUNCTIONAL_VIDPN = unchecked((int)(0xC0262323));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MODE_ID_MUST_BE_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MODE_ID_MUST_BE_UNIQUE _HRESULT_TYPEDEF_(0xC0262324L)")]
    public const int ERROR_GRAPHICS_MODE_ID_MUST_BE_UNIQUE = unchecked((int)(0xC0262324));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION _HRESULT_TYPEDEF_(0xC0262325L)")]
    public const int ERROR_GRAPHICS_EMPTY_ADAPTER_MONITOR_MODE_SUPPORT_INTERSECTION = unchecked((int)(0xC0262325));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES _HRESULT_TYPEDEF_(0xC0262326L)")]
    public const int ERROR_GRAPHICS_VIDEO_PRESENT_TARGETS_LESS_THAN_SOURCES = unchecked((int)(0xC0262326));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PATH_NOT_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PATH_NOT_IN_TOPOLOGY _HRESULT_TYPEDEF_(0xC0262327L)")]
    public const int ERROR_GRAPHICS_PATH_NOT_IN_TOPOLOGY = unchecked((int)(0xC0262327));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE _HRESULT_TYPEDEF_(0xC0262328L)")]
    public const int ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_SOURCE = unchecked((int)(0xC0262328));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET _HRESULT_TYPEDEF_(0xC0262329L)")]
    public const int ERROR_GRAPHICS_ADAPTER_MUST_HAVE_AT_LEAST_ONE_TARGET = unchecked((int)(0xC0262329));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MONITORDESCRIPTORSET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MONITORDESCRIPTORSET _HRESULT_TYPEDEF_(0xC026232AL)")]
    public const int ERROR_GRAPHICS_INVALID_MONITORDESCRIPTORSET = unchecked((int)(0xC026232A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MONITORDESCRIPTOR"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MONITORDESCRIPTOR _HRESULT_TYPEDEF_(0xC026232BL)")]
    public const int ERROR_GRAPHICS_INVALID_MONITORDESCRIPTOR = unchecked((int)(0xC026232B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET _HRESULT_TYPEDEF_(0xC026232CL)")]
    public const int ERROR_GRAPHICS_MONITORDESCRIPTOR_NOT_IN_SET = unchecked((int)(0xC026232C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET _HRESULT_TYPEDEF_(0xC026232DL)")]
    public const int ERROR_GRAPHICS_MONITORDESCRIPTOR_ALREADY_IN_SET = unchecked((int)(0xC026232D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE _HRESULT_TYPEDEF_(0xC026232EL)")]
    public const int ERROR_GRAPHICS_MONITORDESCRIPTOR_ID_MUST_BE_UNIQUE = unchecked((int)(0xC026232E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE _HRESULT_TYPEDEF_(0xC026232FL)")]
    public const int ERROR_GRAPHICS_INVALID_VIDPN_TARGET_SUBSET_TYPE = unchecked((int)(0xC026232F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_RESOURCES_NOT_RELATED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_RESOURCES_NOT_RELATED _HRESULT_TYPEDEF_(0xC0262330L)")]
    public const int ERROR_GRAPHICS_RESOURCES_NOT_RELATED = unchecked((int)(0xC0262330));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE _HRESULT_TYPEDEF_(0xC0262331L)")]
    public const int ERROR_GRAPHICS_SOURCE_ID_MUST_BE_UNIQUE = unchecked((int)(0xC0262331));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE _HRESULT_TYPEDEF_(0xC0262332L)")]
    public const int ERROR_GRAPHICS_TARGET_ID_MUST_BE_UNIQUE = unchecked((int)(0xC0262332));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET _HRESULT_TYPEDEF_(0xC0262333L)")]
    public const int ERROR_GRAPHICS_NO_AVAILABLE_VIDPN_TARGET = unchecked((int)(0xC0262333));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER _HRESULT_TYPEDEF_(0xC0262334L)")]
    public const int ERROR_GRAPHICS_MONITOR_COULD_NOT_BE_ASSOCIATED_WITH_ADAPTER = unchecked((int)(0xC0262334));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_VIDPNMGR"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_VIDPNMGR _HRESULT_TYPEDEF_(0xC0262335L)")]
    public const int ERROR_GRAPHICS_NO_VIDPNMGR = unchecked((int)(0xC0262335));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_ACTIVE_VIDPN"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_ACTIVE_VIDPN _HRESULT_TYPEDEF_(0xC0262336L)")]
    public const int ERROR_GRAPHICS_NO_ACTIVE_VIDPN = unchecked((int)(0xC0262336));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_STALE_VIDPN_TOPOLOGY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_STALE_VIDPN_TOPOLOGY _HRESULT_TYPEDEF_(0xC0262337L)")]
    public const int ERROR_GRAPHICS_STALE_VIDPN_TOPOLOGY = unchecked((int)(0xC0262337));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MONITOR_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MONITOR_NOT_CONNECTED _HRESULT_TYPEDEF_(0xC0262338L)")]
    public const int ERROR_GRAPHICS_MONITOR_NOT_CONNECTED = unchecked((int)(0xC0262338));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY _HRESULT_TYPEDEF_(0xC0262339L)")]
    public const int ERROR_GRAPHICS_SOURCE_NOT_IN_TOPOLOGY = unchecked((int)(0xC0262339));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE _HRESULT_TYPEDEF_(0xC026233AL)")]
    public const int ERROR_GRAPHICS_INVALID_PRIMARYSURFACE_SIZE = unchecked((int)(0xC026233A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VISIBLEREGION_SIZE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VISIBLEREGION_SIZE _HRESULT_TYPEDEF_(0xC026233BL)")]
    public const int ERROR_GRAPHICS_INVALID_VISIBLEREGION_SIZE = unchecked((int)(0xC026233B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_STRIDE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_STRIDE _HRESULT_TYPEDEF_(0xC026233CL)")]
    public const int ERROR_GRAPHICS_INVALID_STRIDE = unchecked((int)(0xC026233C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_PIXELFORMAT"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_PIXELFORMAT _HRESULT_TYPEDEF_(0xC026233DL)")]
    public const int ERROR_GRAPHICS_INVALID_PIXELFORMAT = unchecked((int)(0xC026233D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_COLORBASIS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_COLORBASIS _HRESULT_TYPEDEF_(0xC026233EL)")]
    public const int ERROR_GRAPHICS_INVALID_COLORBASIS = unchecked((int)(0xC026233E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_PIXELVALUEACCESSMODE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_PIXELVALUEACCESSMODE _HRESULT_TYPEDEF_(0xC026233FL)")]
    public const int ERROR_GRAPHICS_INVALID_PIXELVALUEACCESSMODE = unchecked((int)(0xC026233F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_TARGET_NOT_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_TARGET_NOT_IN_TOPOLOGY _HRESULT_TYPEDEF_(0xC0262340L)")]
    public const int ERROR_GRAPHICS_TARGET_NOT_IN_TOPOLOGY = unchecked((int)(0xC0262340));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT _HRESULT_TYPEDEF_(0xC0262341L)")]
    public const int ERROR_GRAPHICS_NO_DISPLAY_MODE_MANAGEMENT_SUPPORT = unchecked((int)(0xC0262341));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE _HRESULT_TYPEDEF_(0xC0262342L)")]
    public const int ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)(0xC0262342));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN _HRESULT_TYPEDEF_(0xC0262343L)")]
    public const int ERROR_GRAPHICS_CANT_ACCESS_ACTIVE_VIDPN = unchecked((int)(0xC0262343));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL _HRESULT_TYPEDEF_(0xC0262344L)")]
    public const int ERROR_GRAPHICS_INVALID_PATH_IMPORTANCE_ORDINAL = unchecked((int)(0xC0262344));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION _HRESULT_TYPEDEF_(0xC0262345L)")]
    public const int ERROR_GRAPHICS_INVALID_PATH_CONTENT_GEOMETRY_TRANSFORMATION = unchecked((int)(0xC0262345));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262346L)")]
    public const int ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_SUPPORTED = unchecked((int)(0xC0262346));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_GAMMA_RAMP"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_GAMMA_RAMP _HRESULT_TYPEDEF_(0xC0262347L)")]
    public const int ERROR_GRAPHICS_INVALID_GAMMA_RAMP = unchecked((int)(0xC0262347));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262348L)")]
    public const int ERROR_GRAPHICS_GAMMA_RAMP_NOT_SUPPORTED = unchecked((int)(0xC0262348));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262349L)")]
    public const int ERROR_GRAPHICS_MULTISAMPLING_NOT_SUPPORTED = unchecked((int)(0xC0262349));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MODE_NOT_IN_MODESET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MODE_NOT_IN_MODESET _HRESULT_TYPEDEF_(0xC026234AL)")]
    public const int ERROR_GRAPHICS_MODE_NOT_IN_MODESET = unchecked((int)(0xC026234A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DATASET_IS_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DATASET_IS_EMPTY _HRESULT_TYPEDEF_(0x0026234BL)")]
    public const int ERROR_GRAPHICS_DATASET_IS_EMPTY = ((int)(0x0026234B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET _HRESULT_TYPEDEF_(0x0026234CL)")]
    public const int ERROR_GRAPHICS_NO_MORE_ELEMENTS_IN_DATASET = ((int)(0x0026234C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON _HRESULT_TYPEDEF_(0xC026234DL)")]
    public const int ERROR_GRAPHICS_INVALID_VIDPN_TOPOLOGY_RECOMMENDATION_REASON = unchecked((int)(0xC026234D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_PATH_CONTENT_TYPE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_PATH_CONTENT_TYPE _HRESULT_TYPEDEF_(0xC026234EL)")]
    public const int ERROR_GRAPHICS_INVALID_PATH_CONTENT_TYPE = unchecked((int)(0xC026234E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_COPYPROTECTION_TYPE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_COPYPROTECTION_TYPE _HRESULT_TYPEDEF_(0xC026234FL)")]
    public const int ERROR_GRAPHICS_INVALID_COPYPROTECTION_TYPE = unchecked((int)(0xC026234F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS _HRESULT_TYPEDEF_(0xC0262350L)")]
    public const int ERROR_GRAPHICS_UNASSIGNED_MODESET_ALREADY_EXISTS = unchecked((int)(0xC0262350));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED _HRESULT_TYPEDEF_(0x00262351L)")]
    public const int ERROR_GRAPHICS_PATH_CONTENT_GEOMETRY_TRANSFORMATION_NOT_PINNED = ((int)(0x00262351));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_SCANLINE_ORDERING"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_SCANLINE_ORDERING _HRESULT_TYPEDEF_(0xC0262352L)")]
    public const int ERROR_GRAPHICS_INVALID_SCANLINE_ORDERING = unchecked((int)(0xC0262352));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC0262353L)")]
    public const int ERROR_GRAPHICS_TOPOLOGY_CHANGES_NOT_ALLOWED = unchecked((int)(0xC0262353));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS _HRESULT_TYPEDEF_(0xC0262354L)")]
    public const int ERROR_GRAPHICS_NO_AVAILABLE_IMPORTANCE_ORDINALS = unchecked((int)(0xC0262354));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT _HRESULT_TYPEDEF_(0xC0262355L)")]
    public const int ERROR_GRAPHICS_INCOMPATIBLE_PRIVATE_FORMAT = unchecked((int)(0xC0262355));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM _HRESULT_TYPEDEF_(0xC0262356L)")]
    public const int ERROR_GRAPHICS_INVALID_MODE_PRUNING_ALGORITHM = unchecked((int)(0xC0262356));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN _HRESULT_TYPEDEF_(0xC0262357L)")]
    public const int ERROR_GRAPHICS_INVALID_MONITOR_CAPABILITY_ORIGIN = unchecked((int)(0xC0262357));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT _HRESULT_TYPEDEF_(0xC0262358L)")]
    public const int ERROR_GRAPHICS_INVALID_MONITOR_FREQUENCYRANGE_CONSTRAINT = unchecked((int)(0xC0262358));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MAX_NUM_PATHS_REACHED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MAX_NUM_PATHS_REACHED _HRESULT_TYPEDEF_(0xC0262359L)")]
    public const int ERROR_GRAPHICS_MAX_NUM_PATHS_REACHED = unchecked((int)(0xC0262359));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION _HRESULT_TYPEDEF_(0xC026235AL)")]
    public const int ERROR_GRAPHICS_CANCEL_VIDPN_TOPOLOGY_AUGMENTATION = unchecked((int)(0xC026235A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_CLIENT_TYPE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_CLIENT_TYPE _HRESULT_TYPEDEF_(0xC026235BL)")]
    public const int ERROR_GRAPHICS_INVALID_CLIENT_TYPE = unchecked((int)(0xC026235B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CLIENTVIDPN_NOT_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CLIENTVIDPN_NOT_SET _HRESULT_TYPEDEF_(0xC026235CL)")]
    public const int ERROR_GRAPHICS_CLIENTVIDPN_NOT_SET = unchecked((int)(0xC026235C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED _HRESULT_TYPEDEF_(0xC0262400L)")]
    public const int ERROR_GRAPHICS_SPECIFIED_CHILD_ALREADY_CONNECTED = unchecked((int)(0xC0262400));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262401L)")]
    public const int ERROR_GRAPHICS_CHILD_DESCRIPTOR_NOT_SUPPORTED = unchecked((int)(0xC0262401));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_UNKNOWN_CHILD_STATUS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_UNKNOWN_CHILD_STATUS _HRESULT_TYPEDEF_(0x4026242FL)")]
    public const int ERROR_GRAPHICS_UNKNOWN_CHILD_STATUS = ((int)(0x4026242F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NOT_A_LINKED_ADAPTER"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NOT_A_LINKED_ADAPTER _HRESULT_TYPEDEF_(0xC0262430L)")]
    public const int ERROR_GRAPHICS_NOT_A_LINKED_ADAPTER = unchecked((int)(0xC0262430));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_LEADLINK_NOT_ENUMERATED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_LEADLINK_NOT_ENUMERATED _HRESULT_TYPEDEF_(0xC0262431L)")]
    public const int ERROR_GRAPHICS_LEADLINK_NOT_ENUMERATED = unchecked((int)(0xC0262431));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CHAINLINKS_NOT_ENUMERATED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CHAINLINKS_NOT_ENUMERATED _HRESULT_TYPEDEF_(0xC0262432L)")]
    public const int ERROR_GRAPHICS_CHAINLINKS_NOT_ENUMERATED = unchecked((int)(0xC0262432));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ADAPTER_CHAIN_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ADAPTER_CHAIN_NOT_READY _HRESULT_TYPEDEF_(0xC0262433L)")]
    public const int ERROR_GRAPHICS_ADAPTER_CHAIN_NOT_READY = unchecked((int)(0xC0262433));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CHAINLINKS_NOT_STARTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CHAINLINKS_NOT_STARTED _HRESULT_TYPEDEF_(0xC0262434L)")]
    public const int ERROR_GRAPHICS_CHAINLINKS_NOT_STARTED = unchecked((int)(0xC0262434));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_CHAINLINKS_NOT_POWERED_ON"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_CHAINLINKS_NOT_POWERED_ON _HRESULT_TYPEDEF_(0xC0262435L)")]
    public const int ERROR_GRAPHICS_CHAINLINKS_NOT_POWERED_ON = unchecked((int)(0xC0262435));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE _HRESULT_TYPEDEF_(0xC0262436L)")]
    public const int ERROR_GRAPHICS_INCONSISTENT_DEVICE_LINK_STATE = unchecked((int)(0xC0262436));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_LEADLINK_START_DEFERRED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_LEADLINK_START_DEFERRED _HRESULT_TYPEDEF_(0x40262437L)")]
    public const int ERROR_GRAPHICS_LEADLINK_START_DEFERRED = ((int)(0x40262437));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NOT_POST_DEVICE_DRIVER"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NOT_POST_DEVICE_DRIVER _HRESULT_TYPEDEF_(0xC0262438L)")]
    public const int ERROR_GRAPHICS_NOT_POST_DEVICE_DRIVER = unchecked((int)(0xC0262438));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_POLLING_TOO_FREQUENTLY"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_POLLING_TOO_FREQUENTLY _HRESULT_TYPEDEF_(0x40262439L)")]
    public const int ERROR_GRAPHICS_POLLING_TOO_FREQUENTLY = ((int)(0x40262439));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_START_DEFERRED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_START_DEFERRED _HRESULT_TYPEDEF_(0x4026243AL)")]
    public const int ERROR_GRAPHICS_START_DEFERRED = ((int)(0x4026243A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED _HRESULT_TYPEDEF_(0xC026243BL)")]
    public const int ERROR_GRAPHICS_ADAPTER_ACCESS_NOT_EXCLUDED = unchecked((int)(0xC026243B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DEPENDABLE_CHILD_STATUS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DEPENDABLE_CHILD_STATUS _HRESULT_TYPEDEF_(0x4026243CL)")]
    public const int ERROR_GRAPHICS_DEPENDABLE_CHILD_STATUS = ((int)(0x4026243C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262500L)")]
    public const int ERROR_GRAPHICS_OPM_NOT_SUPPORTED = unchecked((int)(0xC0262500));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_COPP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_COPP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262501L)")]
    public const int ERROR_GRAPHICS_COPP_NOT_SUPPORTED = unchecked((int)(0xC0262501));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_UAB_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_UAB_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262502L)")]
    public const int ERROR_GRAPHICS_UAB_NOT_SUPPORTED = unchecked((int)(0xC0262502));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS _HRESULT_TYPEDEF_(0xC0262503L)")]
    public const int ERROR_GRAPHICS_OPM_INVALID_ENCRYPTED_PARAMETERS = unchecked((int)(0xC0262503));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_NO_VIDEO_OUTPUTS_EXIST"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_NO_VIDEO_OUTPUTS_EXIST _HRESULT_TYPEDEF_(0xC0262505L)")]
    public const int ERROR_GRAPHICS_OPM_NO_VIDEO_OUTPUTS_EXIST = unchecked((int)(0xC0262505));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_INTERNAL_ERROR _HRESULT_TYPEDEF_(0xC026250BL)")]
    public const int ERROR_GRAPHICS_OPM_INTERNAL_ERROR = unchecked((int)(0xC026250B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_INVALID_HANDLE _HRESULT_TYPEDEF_(0xC026250CL)")]
    public const int ERROR_GRAPHICS_OPM_INVALID_HANDLE = unchecked((int)(0xC026250C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH _HRESULT_TYPEDEF_(0xC026250EL)")]
    public const int ERROR_GRAPHICS_PVP_INVALID_CERTIFICATE_LENGTH = unchecked((int)(0xC026250E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_SPANNING_MODE_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_SPANNING_MODE_ENABLED _HRESULT_TYPEDEF_(0xC026250FL)")]
    public const int ERROR_GRAPHICS_OPM_SPANNING_MODE_ENABLED = unchecked((int)(0xC026250F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_THEATER_MODE_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_THEATER_MODE_ENABLED _HRESULT_TYPEDEF_(0xC0262510L)")]
    public const int ERROR_GRAPHICS_OPM_THEATER_MODE_ENABLED = unchecked((int)(0xC0262510));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PVP_HFS_FAILED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PVP_HFS_FAILED _HRESULT_TYPEDEF_(0xC0262511L)")]
    public const int ERROR_GRAPHICS_PVP_HFS_FAILED = unchecked((int)(0xC0262511));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_INVALID_SRM"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_INVALID_SRM _HRESULT_TYPEDEF_(0xC0262512L)")]
    public const int ERROR_GRAPHICS_OPM_INVALID_SRM = unchecked((int)(0xC0262512));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP _HRESULT_TYPEDEF_(0xC0262513L)")]
    public const int ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_HDCP = unchecked((int)(0xC0262513));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP _HRESULT_TYPEDEF_(0xC0262514L)")]
    public const int ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_ACP = unchecked((int)(0xC0262514));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA _HRESULT_TYPEDEF_(0xC0262515L)")]
    public const int ERROR_GRAPHICS_OPM_OUTPUT_DOES_NOT_SUPPORT_CGMSA = unchecked((int)(0xC0262515));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_HDCP_SRM_NEVER_SET"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_HDCP_SRM_NEVER_SET _HRESULT_TYPEDEF_(0xC0262516L)")]
    public const int ERROR_GRAPHICS_OPM_HDCP_SRM_NEVER_SET = unchecked((int)(0xC0262516));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_RESOLUTION_TOO_HIGH"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_RESOLUTION_TOO_HIGH _HRESULT_TYPEDEF_(0xC0262517L)")]
    public const int ERROR_GRAPHICS_OPM_RESOLUTION_TOO_HIGH = unchecked((int)(0xC0262517));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE _HRESULT_TYPEDEF_(0xC0262518L)")]
    public const int ERROR_GRAPHICS_OPM_ALL_HDCP_HARDWARE_ALREADY_IN_USE = unchecked((int)(0xC0262518));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_NO_LONGER_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_NO_LONGER_EXISTS _HRESULT_TYPEDEF_(0xC026251AL)")]
    public const int ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_NO_LONGER_EXISTS = unchecked((int)(0xC026251A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_SESSION_TYPE_CHANGE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_SESSION_TYPE_CHANGE_IN_PROGRESS _HRESULT_TYPEDEF_(0xC026251BL)")]
    public const int ERROR_GRAPHICS_OPM_SESSION_TYPE_CHANGE_IN_PROGRESS = unchecked((int)(0xC026251B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS _HRESULT_TYPEDEF_(0xC026251CL)")]
    public const int ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_COPP_SEMANTICS = unchecked((int)(0xC026251C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST _HRESULT_TYPEDEF_(0xC026251DL)")]
    public const int ERROR_GRAPHICS_OPM_INVALID_INFORMATION_REQUEST = unchecked((int)(0xC026251D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR _HRESULT_TYPEDEF_(0xC026251EL)")]
    public const int ERROR_GRAPHICS_OPM_DRIVER_INTERNAL_ERROR = unchecked((int)(0xC026251E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS _HRESULT_TYPEDEF_(0xC026251FL)")]
    public const int ERROR_GRAPHICS_OPM_VIDEO_OUTPUT_DOES_NOT_HAVE_OPM_SEMANTICS = unchecked((int)(0xC026251F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262520L)")]
    public const int ERROR_GRAPHICS_OPM_SIGNALING_NOT_SUPPORTED = unchecked((int)(0xC0262520));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST _HRESULT_TYPEDEF_(0xC0262521L)")]
    public const int ERROR_GRAPHICS_OPM_INVALID_CONFIGURATION_REQUEST = unchecked((int)(0xC0262521));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_I2C_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_I2C_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262580L)")]
    public const int ERROR_GRAPHICS_I2C_NOT_SUPPORTED = unchecked((int)(0xC0262580));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST _HRESULT_TYPEDEF_(0xC0262581L)")]
    public const int ERROR_GRAPHICS_I2C_DEVICE_DOES_NOT_EXIST = unchecked((int)(0xC0262581));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA _HRESULT_TYPEDEF_(0xC0262582L)")]
    public const int ERROR_GRAPHICS_I2C_ERROR_TRANSMITTING_DATA = unchecked((int)(0xC0262582));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_I2C_ERROR_RECEIVING_DATA"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_I2C_ERROR_RECEIVING_DATA _HRESULT_TYPEDEF_(0xC0262583L)")]
    public const int ERROR_GRAPHICS_I2C_ERROR_RECEIVING_DATA = unchecked((int)(0xC0262583));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0262584L)")]
    public const int ERROR_GRAPHICS_DDCCI_VCP_NOT_SUPPORTED = unchecked((int)(0xC0262584));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DDCCI_INVALID_DATA"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DDCCI_INVALID_DATA _HRESULT_TYPEDEF_(0xC0262585L)")]
    public const int ERROR_GRAPHICS_DDCCI_INVALID_DATA = unchecked((int)(0xC0262585));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE _HRESULT_TYPEDEF_(0xC0262586L)")]
    public const int ERROR_GRAPHICS_DDCCI_MONITOR_RETURNED_INVALID_TIMING_STATUS_BYTE = unchecked((int)(0xC0262586));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MCA_INVALID_CAPABILITIES_STRING"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MCA_INVALID_CAPABILITIES_STRING _HRESULT_TYPEDEF_(0xC0262587L)")]
    public const int ERROR_GRAPHICS_MCA_INVALID_CAPABILITIES_STRING = unchecked((int)(0xC0262587));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MCA_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MCA_INTERNAL_ERROR _HRESULT_TYPEDEF_(0xC0262588L)")]
    public const int ERROR_GRAPHICS_MCA_INTERNAL_ERROR = unchecked((int)(0xC0262588));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND _HRESULT_TYPEDEF_(0xC0262589L)")]
    public const int ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_COMMAND = unchecked((int)(0xC0262589));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH _HRESULT_TYPEDEF_(0xC026258AL)")]
    public const int ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_LENGTH = unchecked((int)(0xC026258A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM _HRESULT_TYPEDEF_(0xC026258BL)")]
    public const int ERROR_GRAPHICS_DDCCI_INVALID_MESSAGE_CHECKSUM = unchecked((int)(0xC026258B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE _HRESULT_TYPEDEF_(0xC026258CL)")]
    public const int ERROR_GRAPHICS_INVALID_PHYSICAL_MONITOR_HANDLE = unchecked((int)(0xC026258C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MONITOR_NO_LONGER_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MONITOR_NO_LONGER_EXISTS _HRESULT_TYPEDEF_(0xC026258DL)")]
    public const int ERROR_GRAPHICS_MONITOR_NO_LONGER_EXISTS = unchecked((int)(0xC026258D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DDCCI_CURRENT_CURRENT_VALUE_GREATER_THAN_MAXIMUM_VALUE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DDCCI_CURRENT_CURRENT_VALUE_GREATER_THAN_MAXIMUM_VALUE _HRESULT_TYPEDEF_(0xC02625D8L)")]
    public const int ERROR_GRAPHICS_DDCCI_CURRENT_CURRENT_VALUE_GREATER_THAN_MAXIMUM_VALUE = unchecked((int)(0xC02625D8));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MCA_INVALID_VCP_VERSION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MCA_INVALID_VCP_VERSION _HRESULT_TYPEDEF_(0xC02625D9L)")]
    public const int ERROR_GRAPHICS_MCA_INVALID_VCP_VERSION = unchecked((int)(0xC02625D9));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION _HRESULT_TYPEDEF_(0xC02625DAL)")]
    public const int ERROR_GRAPHICS_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION = unchecked((int)(0xC02625DA));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MCA_MCCS_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MCA_MCCS_VERSION_MISMATCH _HRESULT_TYPEDEF_(0xC02625DBL)")]
    public const int ERROR_GRAPHICS_MCA_MCCS_VERSION_MISMATCH = unchecked((int)(0xC02625DB));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MCA_UNSUPPORTED_MCCS_VERSION"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MCA_UNSUPPORTED_MCCS_VERSION _HRESULT_TYPEDEF_(0xC02625DCL)")]
    public const int ERROR_GRAPHICS_MCA_UNSUPPORTED_MCCS_VERSION = unchecked((int)(0xC02625DC));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED _HRESULT_TYPEDEF_(0xC02625DEL)")]
    public const int ERROR_GRAPHICS_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED = unchecked((int)(0xC02625DE));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MCA_UNSUPPORTED_COLOR_TEMPERATURE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MCA_UNSUPPORTED_COLOR_TEMPERATURE _HRESULT_TYPEDEF_(0xC02625DFL)")]
    public const int ERROR_GRAPHICS_MCA_UNSUPPORTED_COLOR_TEMPERATURE = unchecked((int)(0xC02625DF));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED _HRESULT_TYPEDEF_(0xC02625E0L)")]
    public const int ERROR_GRAPHICS_ONLY_CONSOLE_SESSION_SUPPORTED = unchecked((int)(0xC02625E0));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME _HRESULT_TYPEDEF_(0xC02625E1L)")]
    public const int ERROR_GRAPHICS_NO_DISPLAY_DEVICE_CORRESPONDS_TO_NAME = unchecked((int)(0xC02625E1));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP _HRESULT_TYPEDEF_(0xC02625E2L)")]
    public const int ERROR_GRAPHICS_DISPLAY_DEVICE_NOT_ATTACHED_TO_DESKTOP = unchecked((int)(0xC02625E2));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC02625E3L)")]
    public const int ERROR_GRAPHICS_MIRRORING_DEVICES_NOT_SUPPORTED = unchecked((int)(0xC02625E3));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INVALID_POINTER"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INVALID_POINTER _HRESULT_TYPEDEF_(0xC02625E4L)")]
    public const int ERROR_GRAPHICS_INVALID_POINTER = unchecked((int)(0xC02625E4));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE _HRESULT_TYPEDEF_(0xC02625E5L)")]
    public const int ERROR_GRAPHICS_NO_MONITORS_CORRESPOND_TO_DISPLAY_DEVICE = unchecked((int)(0xC02625E5));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL _HRESULT_TYPEDEF_(0xC02625E6L)")]
    public const int ERROR_GRAPHICS_PARAMETER_ARRAY_TOO_SMALL = unchecked((int)(0xC02625E6));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_INTERNAL_ERROR _HRESULT_TYPEDEF_(0xC02625E7L)")]
    public const int ERROR_GRAPHICS_INTERNAL_ERROR = unchecked((int)(0xC02625E7));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS _HRESULT_TYPEDEF_(0xC02605E8L)")]
    public const int ERROR_GRAPHICS_SESSION_TYPE_CHANGE_IN_PROGRESS = unchecked((int)(0xC02605E8));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_UNKNOWN_BIOS_FRAME_BUFFER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_UNKNOWN_BIOS_FRAME_BUFFER_NOT_FOUND _HRESULT_TYPEDEF_(0xC0262600L)")]
    public const int ERROR_GRAPHICS_UNKNOWN_BIOS_FRAME_BUFFER_NOT_FOUND = unchecked((int)(0xC0262600));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_GRAPHICS_UEFI_FRAME_BUFFER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_GRAPHICS_UEFI_FRAME_BUFFER_NOT_FOUND _HRESULT_TYPEDEF_(0xC0262601L)")]
    public const int ERROR_GRAPHICS_UEFI_FRAME_BUFFER_NOT_FOUND = unchecked((int)(0xC0262601));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INTERFACE_CLOSING"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INTERFACE_CLOSING _NDIS_ERROR_TYPEDEF_(0x80340002L)")]
    public const uint ERROR_NDIS_INTERFACE_CLOSING = (uint)(0x80340002);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_BAD_VERSION"]/*' />
    [NativeTypeName("#define ERROR_NDIS_BAD_VERSION _NDIS_ERROR_TYPEDEF_(0x80340004L)")]
    public const uint ERROR_NDIS_BAD_VERSION = (uint)(0x80340004);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_BAD_CHARACTERISTICS"]/*' />
    [NativeTypeName("#define ERROR_NDIS_BAD_CHARACTERISTICS _NDIS_ERROR_TYPEDEF_(0x80340005L)")]
    public const uint ERROR_NDIS_BAD_CHARACTERISTICS = (uint)(0x80340005);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_ADAPTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NDIS_ADAPTER_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0x80340006L)")]
    public const uint ERROR_NDIS_ADAPTER_NOT_FOUND = (uint)(0x80340006);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_OPEN_FAILED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_OPEN_FAILED _NDIS_ERROR_TYPEDEF_(0x80340007L)")]
    public const uint ERROR_NDIS_OPEN_FAILED = (uint)(0x80340007);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DEVICE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DEVICE_FAILED _NDIS_ERROR_TYPEDEF_(0x80340008L)")]
    public const uint ERROR_NDIS_DEVICE_FAILED = (uint)(0x80340008);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_MULTICAST_FULL"]/*' />
    [NativeTypeName("#define ERROR_NDIS_MULTICAST_FULL _NDIS_ERROR_TYPEDEF_(0x80340009L)")]
    public const uint ERROR_NDIS_MULTICAST_FULL = (uint)(0x80340009);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_MULTICAST_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_NDIS_MULTICAST_EXISTS _NDIS_ERROR_TYPEDEF_(0x8034000AL)")]
    public const uint ERROR_NDIS_MULTICAST_EXISTS = (uint)(0x8034000A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_MULTICAST_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NDIS_MULTICAST_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0x8034000BL)")]
    public const uint ERROR_NDIS_MULTICAST_NOT_FOUND = (uint)(0x8034000B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_REQUEST_ABORTED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_REQUEST_ABORTED _NDIS_ERROR_TYPEDEF_(0x8034000CL)")]
    public const uint ERROR_NDIS_REQUEST_ABORTED = (uint)(0x8034000C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_RESET_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_NDIS_RESET_IN_PROGRESS _NDIS_ERROR_TYPEDEF_(0x8034000DL)")]
    public const uint ERROR_NDIS_RESET_IN_PROGRESS = (uint)(0x8034000D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_NOT_SUPPORTED _NDIS_ERROR_TYPEDEF_(0x803400BBL)")]
    public const uint ERROR_NDIS_NOT_SUPPORTED = (uint)(0x803400BB);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INVALID_PACKET"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INVALID_PACKET _NDIS_ERROR_TYPEDEF_(0x8034000FL)")]
    public const uint ERROR_NDIS_INVALID_PACKET = (uint)(0x8034000F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_ADAPTER_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_NDIS_ADAPTER_NOT_READY _NDIS_ERROR_TYPEDEF_(0x80340011L)")]
    public const uint ERROR_NDIS_ADAPTER_NOT_READY = (uint)(0x80340011);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INVALID_LENGTH"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INVALID_LENGTH _NDIS_ERROR_TYPEDEF_(0x80340014L)")]
    public const uint ERROR_NDIS_INVALID_LENGTH = (uint)(0x80340014);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INVALID_DATA"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INVALID_DATA _NDIS_ERROR_TYPEDEF_(0x80340015L)")]
    public const uint ERROR_NDIS_INVALID_DATA = (uint)(0x80340015);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_BUFFER_TOO_SHORT"]/*' />
    [NativeTypeName("#define ERROR_NDIS_BUFFER_TOO_SHORT _NDIS_ERROR_TYPEDEF_(0x80340016L)")]
    public const uint ERROR_NDIS_BUFFER_TOO_SHORT = (uint)(0x80340016);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INVALID_OID"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INVALID_OID _NDIS_ERROR_TYPEDEF_(0x80340017L)")]
    public const uint ERROR_NDIS_INVALID_OID = (uint)(0x80340017);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_ADAPTER_REMOVED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_ADAPTER_REMOVED _NDIS_ERROR_TYPEDEF_(0x80340018L)")]
    public const uint ERROR_NDIS_ADAPTER_REMOVED = (uint)(0x80340018);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_UNSUPPORTED_MEDIA"]/*' />
    [NativeTypeName("#define ERROR_NDIS_UNSUPPORTED_MEDIA _NDIS_ERROR_TYPEDEF_(0x80340019L)")]
    public const uint ERROR_NDIS_UNSUPPORTED_MEDIA = (uint)(0x80340019);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_GROUP_ADDRESS_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_NDIS_GROUP_ADDRESS_IN_USE _NDIS_ERROR_TYPEDEF_(0x8034001AL)")]
    public const uint ERROR_NDIS_GROUP_ADDRESS_IN_USE = (uint)(0x8034001A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NDIS_FILE_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0x8034001BL)")]
    public const uint ERROR_NDIS_FILE_NOT_FOUND = (uint)(0x8034001B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_ERROR_READING_FILE"]/*' />
    [NativeTypeName("#define ERROR_NDIS_ERROR_READING_FILE _NDIS_ERROR_TYPEDEF_(0x8034001CL)")]
    public const uint ERROR_NDIS_ERROR_READING_FILE = (uint)(0x8034001C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_ALREADY_MAPPED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_ALREADY_MAPPED _NDIS_ERROR_TYPEDEF_(0x8034001DL)")]
    public const uint ERROR_NDIS_ALREADY_MAPPED = (uint)(0x8034001D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_RESOURCE_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_NDIS_RESOURCE_CONFLICT _NDIS_ERROR_TYPEDEF_(0x8034001EL)")]
    public const uint ERROR_NDIS_RESOURCE_CONFLICT = (uint)(0x8034001E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_MEDIA_DISCONNECTED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_MEDIA_DISCONNECTED _NDIS_ERROR_TYPEDEF_(0x8034001FL)")]
    public const uint ERROR_NDIS_MEDIA_DISCONNECTED = (uint)(0x8034001F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INVALID_ADDRESS"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INVALID_ADDRESS _NDIS_ERROR_TYPEDEF_(0x80340022L)")]
    public const uint ERROR_NDIS_INVALID_ADDRESS = (uint)(0x80340022);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INVALID_DEVICE_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INVALID_DEVICE_REQUEST _NDIS_ERROR_TYPEDEF_(0x80340010L)")]
    public const uint ERROR_NDIS_INVALID_DEVICE_REQUEST = (uint)(0x80340010);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_PAUSED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_PAUSED _NDIS_ERROR_TYPEDEF_(0x8034002AL)")]
    public const uint ERROR_NDIS_PAUSED = (uint)(0x8034002A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INTERFACE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INTERFACE_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0x8034002BL)")]
    public const uint ERROR_NDIS_INTERFACE_NOT_FOUND = (uint)(0x8034002B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_UNSUPPORTED_REVISION"]/*' />
    [NativeTypeName("#define ERROR_NDIS_UNSUPPORTED_REVISION _NDIS_ERROR_TYPEDEF_(0x8034002CL)")]
    public const uint ERROR_NDIS_UNSUPPORTED_REVISION = (uint)(0x8034002C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INVALID_PORT"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INVALID_PORT _NDIS_ERROR_TYPEDEF_(0x8034002DL)")]
    public const uint ERROR_NDIS_INVALID_PORT = (uint)(0x8034002D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INVALID_PORT_STATE"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INVALID_PORT_STATE _NDIS_ERROR_TYPEDEF_(0x8034002EL)")]
    public const uint ERROR_NDIS_INVALID_PORT_STATE = (uint)(0x8034002E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_LOW_POWER_STATE"]/*' />
    [NativeTypeName("#define ERROR_NDIS_LOW_POWER_STATE _NDIS_ERROR_TYPEDEF_(0x8034002FL)")]
    public const uint ERROR_NDIS_LOW_POWER_STATE = (uint)(0x8034002F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_REINIT_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_REINIT_REQUIRED _NDIS_ERROR_TYPEDEF_(0x80340030L)")]
    public const uint ERROR_NDIS_REINIT_REQUIRED = (uint)(0x80340030);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_NO_QUEUES"]/*' />
    [NativeTypeName("#define ERROR_NDIS_NO_QUEUES _NDIS_ERROR_TYPEDEF_(0x80340031L)")]
    public const uint ERROR_NDIS_NO_QUEUES = (uint)(0x80340031);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DOT11_AUTO_CONFIG_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DOT11_AUTO_CONFIG_ENABLED _NDIS_ERROR_TYPEDEF_(0x80342000L)")]
    public const uint ERROR_NDIS_DOT11_AUTO_CONFIG_ENABLED = (uint)(0x80342000);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DOT11_MEDIA_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DOT11_MEDIA_IN_USE _NDIS_ERROR_TYPEDEF_(0x80342001L)")]
    public const uint ERROR_NDIS_DOT11_MEDIA_IN_USE = (uint)(0x80342001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DOT11_POWER_STATE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DOT11_POWER_STATE_INVALID _NDIS_ERROR_TYPEDEF_(0x80342002L)")]
    public const uint ERROR_NDIS_DOT11_POWER_STATE_INVALID = (uint)(0x80342002);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_PM_WOL_PATTERN_LIST_FULL"]/*' />
    [NativeTypeName("#define ERROR_NDIS_PM_WOL_PATTERN_LIST_FULL _NDIS_ERROR_TYPEDEF_(0x80342003L)")]
    public const uint ERROR_NDIS_PM_WOL_PATTERN_LIST_FULL = (uint)(0x80342003);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL"]/*' />
    [NativeTypeName("#define ERROR_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL _NDIS_ERROR_TYPEDEF_(0x80342004L)")]
    public const uint ERROR_NDIS_PM_PROTOCOL_OFFLOAD_LIST_FULL = (uint)(0x80342004);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE _NDIS_ERROR_TYPEDEF_(0x80342005L)")]
    public const uint ERROR_NDIS_DOT11_AP_CHANNEL_CURRENTLY_NOT_AVAILABLE = (uint)(0x80342005);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE _NDIS_ERROR_TYPEDEF_(0x80342006L)")]
    public const uint ERROR_NDIS_DOT11_AP_BAND_CURRENTLY_NOT_AVAILABLE = (uint)(0x80342006);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED _NDIS_ERROR_TYPEDEF_(0x80342007L)")]
    public const uint ERROR_NDIS_DOT11_AP_CHANNEL_NOT_ALLOWED = (uint)(0x80342007);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DOT11_AP_BAND_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DOT11_AP_BAND_NOT_ALLOWED _NDIS_ERROR_TYPEDEF_(0x80342008L)")]
    public const uint ERROR_NDIS_DOT11_AP_BAND_NOT_ALLOWED = (uint)(0x80342008);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_DOT11_AP_RADIO_RESTRICTION"]/*' />
    [NativeTypeName("#define ERROR_NDIS_DOT11_AP_RADIO_RESTRICTION _NDIS_ERROR_TYPEDEF_(0x80342009L)")]
    public const uint ERROR_NDIS_DOT11_AP_RADIO_RESTRICTION = (uint)(0x80342009);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_INDICATION_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_INDICATION_REQUIRED _NDIS_ERROR_TYPEDEF_(0x00340001L)")]
    public const uint ERROR_NDIS_INDICATION_REQUIRED = (uint)(0x00340001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_OFFLOAD_POLICY"]/*' />
    [NativeTypeName("#define ERROR_NDIS_OFFLOAD_POLICY _NDIS_ERROR_TYPEDEF_(0xC034100FL)")]
    public const uint ERROR_NDIS_OFFLOAD_POLICY = (uint)(0xC034100F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_OFFLOAD_CONNECTION_REJECTED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_OFFLOAD_CONNECTION_REJECTED _NDIS_ERROR_TYPEDEF_(0xC0341012L)")]
    public const uint ERROR_NDIS_OFFLOAD_CONNECTION_REJECTED = (uint)(0xC0341012);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NDIS_OFFLOAD_PATH_REJECTED"]/*' />
    [NativeTypeName("#define ERROR_NDIS_OFFLOAD_PATH_REJECTED _NDIS_ERROR_TYPEDEF_(0xC0341013L)")]
    public const uint ERROR_NDIS_OFFLOAD_PATH_REJECTED = (uint)(0xC0341013);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_HYPERCALL_CODE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_HYPERCALL_CODE _NDIS_ERROR_TYPEDEF_(0xC0350002L)")]
    public const uint ERROR_HV_INVALID_HYPERCALL_CODE = (uint)(0xC0350002);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_HYPERCALL_INPUT"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_HYPERCALL_INPUT _NDIS_ERROR_TYPEDEF_(0xC0350003L)")]
    public const uint ERROR_HV_INVALID_HYPERCALL_INPUT = (uint)(0xC0350003);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_ALIGNMENT"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_ALIGNMENT _NDIS_ERROR_TYPEDEF_(0xC0350004L)")]
    public const uint ERROR_HV_INVALID_ALIGNMENT = (uint)(0xC0350004);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_PARAMETER _NDIS_ERROR_TYPEDEF_(0xC0350005L)")]
    public const uint ERROR_HV_INVALID_PARAMETER = (uint)(0xC0350005);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_HV_ACCESS_DENIED _NDIS_ERROR_TYPEDEF_(0xC0350006L)")]
    public const uint ERROR_HV_ACCESS_DENIED = (uint)(0xC0350006);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_PARTITION_STATE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_PARTITION_STATE _NDIS_ERROR_TYPEDEF_(0xC0350007L)")]
    public const uint ERROR_HV_INVALID_PARTITION_STATE = (uint)(0xC0350007);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_OPERATION_DENIED"]/*' />
    [NativeTypeName("#define ERROR_HV_OPERATION_DENIED _NDIS_ERROR_TYPEDEF_(0xC0350008L)")]
    public const uint ERROR_HV_OPERATION_DENIED = (uint)(0xC0350008);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_UNKNOWN_PROPERTY"]/*' />
    [NativeTypeName("#define ERROR_HV_UNKNOWN_PROPERTY _NDIS_ERROR_TYPEDEF_(0xC0350009L)")]
    public const uint ERROR_HV_UNKNOWN_PROPERTY = (uint)(0xC0350009);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_PROPERTY_VALUE_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define ERROR_HV_PROPERTY_VALUE_OUT_OF_RANGE _NDIS_ERROR_TYPEDEF_(0xC035000AL)")]
    public const uint ERROR_HV_PROPERTY_VALUE_OUT_OF_RANGE = (uint)(0xC035000A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_MEMORY _NDIS_ERROR_TYPEDEF_(0xC035000BL)")]
    public const uint ERROR_HV_INSUFFICIENT_MEMORY = (uint)(0xC035000B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_PARTITION_TOO_DEEP"]/*' />
    [NativeTypeName("#define ERROR_HV_PARTITION_TOO_DEEP _NDIS_ERROR_TYPEDEF_(0xC035000CL)")]
    public const uint ERROR_HV_PARTITION_TOO_DEEP = (uint)(0xC035000C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_PARTITION_ID"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_PARTITION_ID _NDIS_ERROR_TYPEDEF_(0xC035000DL)")]
    public const uint ERROR_HV_INVALID_PARTITION_ID = (uint)(0xC035000D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_VP_INDEX"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_VP_INDEX _NDIS_ERROR_TYPEDEF_(0xC035000EL)")]
    public const uint ERROR_HV_INVALID_VP_INDEX = (uint)(0xC035000E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_PORT_ID"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_PORT_ID _NDIS_ERROR_TYPEDEF_(0xC0350011L)")]
    public const uint ERROR_HV_INVALID_PORT_ID = (uint)(0xC0350011);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_CONNECTION_ID"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_CONNECTION_ID _NDIS_ERROR_TYPEDEF_(0xC0350012L)")]
    public const uint ERROR_HV_INVALID_CONNECTION_ID = (uint)(0xC0350012);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_BUFFERS"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_BUFFERS _NDIS_ERROR_TYPEDEF_(0xC0350013L)")]
    public const uint ERROR_HV_INSUFFICIENT_BUFFERS = (uint)(0xC0350013);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_NOT_ACKNOWLEDGED"]/*' />
    [NativeTypeName("#define ERROR_HV_NOT_ACKNOWLEDGED _NDIS_ERROR_TYPEDEF_(0xC0350014L)")]
    public const uint ERROR_HV_NOT_ACKNOWLEDGED = (uint)(0xC0350014);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_VP_STATE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_VP_STATE _NDIS_ERROR_TYPEDEF_(0xC0350015L)")]
    public const uint ERROR_HV_INVALID_VP_STATE = (uint)(0xC0350015);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_ACKNOWLEDGED"]/*' />
    [NativeTypeName("#define ERROR_HV_ACKNOWLEDGED _NDIS_ERROR_TYPEDEF_(0xC0350016L)")]
    public const uint ERROR_HV_ACKNOWLEDGED = (uint)(0xC0350016);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_SAVE_RESTORE_STATE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_SAVE_RESTORE_STATE _NDIS_ERROR_TYPEDEF_(0xC0350017L)")]
    public const uint ERROR_HV_INVALID_SAVE_RESTORE_STATE = (uint)(0xC0350017);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_SYNIC_STATE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_SYNIC_STATE _NDIS_ERROR_TYPEDEF_(0xC0350018L)")]
    public const uint ERROR_HV_INVALID_SYNIC_STATE = (uint)(0xC0350018);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_OBJECT_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_HV_OBJECT_IN_USE _NDIS_ERROR_TYPEDEF_(0xC0350019L)")]
    public const uint ERROR_HV_OBJECT_IN_USE = (uint)(0xC0350019);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_PROXIMITY_DOMAIN_INFO"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_PROXIMITY_DOMAIN_INFO _NDIS_ERROR_TYPEDEF_(0xC035001AL)")]
    public const uint ERROR_HV_INVALID_PROXIMITY_DOMAIN_INFO = (uint)(0xC035001A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_NO_DATA"]/*' />
    [NativeTypeName("#define ERROR_HV_NO_DATA _NDIS_ERROR_TYPEDEF_(0xC035001BL)")]
    public const uint ERROR_HV_NO_DATA = (uint)(0xC035001B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INACTIVE"]/*' />
    [NativeTypeName("#define ERROR_HV_INACTIVE _NDIS_ERROR_TYPEDEF_(0xC035001CL)")]
    public const uint ERROR_HV_INACTIVE = (uint)(0xC035001C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_NO_RESOURCES"]/*' />
    [NativeTypeName("#define ERROR_HV_NO_RESOURCES _NDIS_ERROR_TYPEDEF_(0xC035001DL)")]
    public const uint ERROR_HV_NO_RESOURCES = (uint)(0xC035001D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_FEATURE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_HV_FEATURE_UNAVAILABLE _NDIS_ERROR_TYPEDEF_(0xC035001EL)")]
    public const uint ERROR_HV_FEATURE_UNAVAILABLE = (uint)(0xC035001E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_BUFFER _NDIS_ERROR_TYPEDEF_(0xC0350033L)")]
    public const uint ERROR_HV_INSUFFICIENT_BUFFER = (uint)(0xC0350033);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_DEVICE_DOMAINS"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_DEVICE_DOMAINS _NDIS_ERROR_TYPEDEF_(0xC0350038L)")]
    public const uint ERROR_HV_INSUFFICIENT_DEVICE_DOMAINS = (uint)(0xC0350038);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_CPUID_FEATURE_VALIDATION"]/*' />
    [NativeTypeName("#define ERROR_HV_CPUID_FEATURE_VALIDATION _NDIS_ERROR_TYPEDEF_(0xC035003CL)")]
    public const uint ERROR_HV_CPUID_FEATURE_VALIDATION = (uint)(0xC035003C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_CPUID_XSAVE_FEATURE_VALIDATION"]/*' />
    [NativeTypeName("#define ERROR_HV_CPUID_XSAVE_FEATURE_VALIDATION _NDIS_ERROR_TYPEDEF_(0xC035003DL)")]
    public const uint ERROR_HV_CPUID_XSAVE_FEATURE_VALIDATION = (uint)(0xC035003D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_PROCESSOR_STARTUP_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_HV_PROCESSOR_STARTUP_TIMEOUT _NDIS_ERROR_TYPEDEF_(0xC035003EL)")]
    public const uint ERROR_HV_PROCESSOR_STARTUP_TIMEOUT = (uint)(0xC035003E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_SMX_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_HV_SMX_ENABLED _NDIS_ERROR_TYPEDEF_(0xC035003FL)")]
    public const uint ERROR_HV_SMX_ENABLED = (uint)(0xC035003F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_LP_INDEX"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_LP_INDEX _NDIS_ERROR_TYPEDEF_(0xC0350041L)")]
    public const uint ERROR_HV_INVALID_LP_INDEX = (uint)(0xC0350041);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_REGISTER_VALUE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_REGISTER_VALUE _NDIS_ERROR_TYPEDEF_(0xC0350050L)")]
    public const uint ERROR_HV_INVALID_REGISTER_VALUE = (uint)(0xC0350050);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_VTL_STATE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_VTL_STATE _NDIS_ERROR_TYPEDEF_(0xC0350051L)")]
    public const uint ERROR_HV_INVALID_VTL_STATE = (uint)(0xC0350051);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_NX_NOT_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_HV_NX_NOT_DETECTED _NDIS_ERROR_TYPEDEF_(0xC0350055L)")]
    public const uint ERROR_HV_NX_NOT_DETECTED = (uint)(0xC0350055);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_DEVICE_ID"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_DEVICE_ID _NDIS_ERROR_TYPEDEF_(0xC0350057L)")]
    public const uint ERROR_HV_INVALID_DEVICE_ID = (uint)(0xC0350057);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_DEVICE_STATE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_DEVICE_STATE _NDIS_ERROR_TYPEDEF_(0xC0350058L)")]
    public const uint ERROR_HV_INVALID_DEVICE_STATE = (uint)(0xC0350058);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_PENDING_PAGE_REQUESTS"]/*' />
    [NativeTypeName("#define ERROR_HV_PENDING_PAGE_REQUESTS _NDIS_ERROR_TYPEDEF_(0x00350059L)")]
    public const uint ERROR_HV_PENDING_PAGE_REQUESTS = (uint)(0x00350059);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_PAGE_REQUEST_INVALID"]/*' />
    [NativeTypeName("#define ERROR_HV_PAGE_REQUEST_INVALID _NDIS_ERROR_TYPEDEF_(0xC0350060L)")]
    public const uint ERROR_HV_PAGE_REQUEST_INVALID = (uint)(0xC0350060);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_DEVICE_ALREADY_IN_DOMAIN"]/*' />
    [NativeTypeName("#define ERROR_HV_DEVICE_ALREADY_IN_DOMAIN _NDIS_ERROR_TYPEDEF_(0xC0350066L)")]
    public const uint ERROR_HV_DEVICE_ALREADY_IN_DOMAIN = (uint)(0xC0350066);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_CPU_GROUP_ID"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_CPU_GROUP_ID _NDIS_ERROR_TYPEDEF_(0xC035006FL)")]
    public const uint ERROR_HV_INVALID_CPU_GROUP_ID = (uint)(0xC035006F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INVALID_CPU_GROUP_STATE"]/*' />
    [NativeTypeName("#define ERROR_HV_INVALID_CPU_GROUP_STATE _NDIS_ERROR_TYPEDEF_(0xC0350070L)")]
    public const uint ERROR_HV_INVALID_CPU_GROUP_STATE = (uint)(0xC0350070);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_OPERATION_FAILED"]/*' />
    [NativeTypeName("#define ERROR_HV_OPERATION_FAILED _NDIS_ERROR_TYPEDEF_(0xC0350071L)")]
    public const uint ERROR_HV_OPERATION_FAILED = (uint)(0xC0350071);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE _NDIS_ERROR_TYPEDEF_(0xC0350072L)")]
    public const uint ERROR_HV_NOT_ALLOWED_WITH_NESTED_VIRT_ACTIVE = (uint)(0xC0350072);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_ROOT_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_ROOT_MEMORY _NDIS_ERROR_TYPEDEF_(0xC0350073L)")]
    public const uint ERROR_HV_INSUFFICIENT_ROOT_MEMORY = (uint)(0xC0350073);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_EVENT_BUFFER_ALREADY_FREED"]/*' />
    [NativeTypeName("#define ERROR_HV_EVENT_BUFFER_ALREADY_FREED _NDIS_ERROR_TYPEDEF_(0xC0350074L)")]
    public const uint ERROR_HV_EVENT_BUFFER_ALREADY_FREED = (uint)(0xC0350074);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_CONTIGUOUS_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_CONTIGUOUS_MEMORY _NDIS_ERROR_TYPEDEF_(0xC0350075L)")]
    public const uint ERROR_HV_INSUFFICIENT_CONTIGUOUS_MEMORY = (uint)(0xC0350075);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_DEVICE_NOT_IN_DOMAIN"]/*' />
    [NativeTypeName("#define ERROR_HV_DEVICE_NOT_IN_DOMAIN _NDIS_ERROR_TYPEDEF_(0xC0350076L)")]
    public const uint ERROR_HV_DEVICE_NOT_IN_DOMAIN = (uint)(0xC0350076);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_NESTED_VM_EXIT"]/*' />
    [NativeTypeName("#define ERROR_HV_NESTED_VM_EXIT _NDIS_ERROR_TYPEDEF_(0xC0350077L)")]
    public const uint ERROR_HV_NESTED_VM_EXIT = (uint)(0xC0350077);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_MSR_ACCESS_FAILED"]/*' />
    [NativeTypeName("#define ERROR_HV_MSR_ACCESS_FAILED _NDIS_ERROR_TYPEDEF_(0xC0350080L)")]
    public const uint ERROR_HV_MSR_ACCESS_FAILED = (uint)(0xC0350080);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_MEMORY_MIRRORING"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_MEMORY_MIRRORING _NDIS_ERROR_TYPEDEF_(0xC0350081L)")]
    public const uint ERROR_HV_INSUFFICIENT_MEMORY_MIRRORING = (uint)(0xC0350081);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_CONTIGUOUS_MEMORY_MIRRORING"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_CONTIGUOUS_MEMORY_MIRRORING _NDIS_ERROR_TYPEDEF_(0xC0350082L)")]
    public const uint ERROR_HV_INSUFFICIENT_CONTIGUOUS_MEMORY_MIRRORING = (uint)(0xC0350082);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY _NDIS_ERROR_TYPEDEF_(0xC0350083L)")]
    public const uint ERROR_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY = (uint)(0xC0350083);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_ROOT_MEMORY_MIRRORING"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_ROOT_MEMORY_MIRRORING _NDIS_ERROR_TYPEDEF_(0xC0350084L)")]
    public const uint ERROR_HV_INSUFFICIENT_ROOT_MEMORY_MIRRORING = (uint)(0xC0350084);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY_MIRRORING"]/*' />
    [NativeTypeName("#define ERROR_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY_MIRRORING _NDIS_ERROR_TYPEDEF_(0xC0350085L)")]
    public const uint ERROR_HV_INSUFFICIENT_CONTIGUOUS_ROOT_MEMORY_MIRRORING = (uint)(0xC0350085);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_VTL_ALREADY_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_HV_VTL_ALREADY_ENABLED _NDIS_ERROR_TYPEDEF_(0xC0350086L)")]
    public const uint ERROR_HV_VTL_ALREADY_ENABLED = (uint)(0xC0350086);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_SPDM_REQUEST"]/*' />
    [NativeTypeName("#define ERROR_HV_SPDM_REQUEST _NDIS_ERROR_TYPEDEF_(0xC0350088L)")]
    public const uint ERROR_HV_SPDM_REQUEST = (uint)(0xC0350088);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_HV_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_HV_NOT_PRESENT _NDIS_ERROR_TYPEDEF_(0xC0351000L)")]
    public const uint ERROR_HV_NOT_PRESENT = (uint)(0xC0351000);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_DUPLICATE_HANDLER"]/*' />
    [NativeTypeName("#define ERROR_VID_DUPLICATE_HANDLER _NDIS_ERROR_TYPEDEF_(0xC0370001L)")]
    public const uint ERROR_VID_DUPLICATE_HANDLER = (uint)(0xC0370001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_TOO_MANY_HANDLERS"]/*' />
    [NativeTypeName("#define ERROR_VID_TOO_MANY_HANDLERS _NDIS_ERROR_TYPEDEF_(0xC0370002L)")]
    public const uint ERROR_VID_TOO_MANY_HANDLERS = (uint)(0xC0370002);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_QUEUE_FULL"]/*' />
    [NativeTypeName("#define ERROR_VID_QUEUE_FULL _NDIS_ERROR_TYPEDEF_(0xC0370003L)")]
    public const uint ERROR_VID_QUEUE_FULL = (uint)(0xC0370003);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_HANDLER_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_VID_HANDLER_NOT_PRESENT _NDIS_ERROR_TYPEDEF_(0xC0370004L)")]
    public const uint ERROR_VID_HANDLER_NOT_PRESENT = (uint)(0xC0370004);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_OBJECT_NAME"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_OBJECT_NAME _NDIS_ERROR_TYPEDEF_(0xC0370005L)")]
    public const uint ERROR_VID_INVALID_OBJECT_NAME = (uint)(0xC0370005);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_PARTITION_NAME_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_VID_PARTITION_NAME_TOO_LONG _NDIS_ERROR_TYPEDEF_(0xC0370006L)")]
    public const uint ERROR_VID_PARTITION_NAME_TOO_LONG = (uint)(0xC0370006);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MESSAGE_QUEUE_NAME_TOO_LONG"]/*' />
    [NativeTypeName("#define ERROR_VID_MESSAGE_QUEUE_NAME_TOO_LONG _NDIS_ERROR_TYPEDEF_(0xC0370007L)")]
    public const uint ERROR_VID_MESSAGE_QUEUE_NAME_TOO_LONG = (uint)(0xC0370007);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_PARTITION_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_VID_PARTITION_ALREADY_EXISTS _NDIS_ERROR_TYPEDEF_(0xC0370008L)")]
    public const uint ERROR_VID_PARTITION_ALREADY_EXISTS = (uint)(0xC0370008);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_PARTITION_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define ERROR_VID_PARTITION_DOES_NOT_EXIST _NDIS_ERROR_TYPEDEF_(0xC0370009L)")]
    public const uint ERROR_VID_PARTITION_DOES_NOT_EXIST = (uint)(0xC0370009);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_PARTITION_NAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_VID_PARTITION_NAME_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0xC037000AL)")]
    public const uint ERROR_VID_PARTITION_NAME_NOT_FOUND = (uint)(0xC037000A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MESSAGE_QUEUE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_VID_MESSAGE_QUEUE_ALREADY_EXISTS _NDIS_ERROR_TYPEDEF_(0xC037000BL)")]
    public const uint ERROR_VID_MESSAGE_QUEUE_ALREADY_EXISTS = (uint)(0xC037000B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT _NDIS_ERROR_TYPEDEF_(0xC037000CL)")]
    public const uint ERROR_VID_EXCEEDED_MBP_ENTRY_MAP_LIMIT = (uint)(0xC037000C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MB_STILL_REFERENCED"]/*' />
    [NativeTypeName("#define ERROR_VID_MB_STILL_REFERENCED _NDIS_ERROR_TYPEDEF_(0xC037000DL)")]
    public const uint ERROR_VID_MB_STILL_REFERENCED = (uint)(0xC037000D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_CHILD_GPA_PAGE_SET_CORRUPTED"]/*' />
    [NativeTypeName("#define ERROR_VID_CHILD_GPA_PAGE_SET_CORRUPTED _NDIS_ERROR_TYPEDEF_(0xC037000EL)")]
    public const uint ERROR_VID_CHILD_GPA_PAGE_SET_CORRUPTED = (uint)(0xC037000E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_NUMA_SETTINGS"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_NUMA_SETTINGS _NDIS_ERROR_TYPEDEF_(0xC037000FL)")]
    public const uint ERROR_VID_INVALID_NUMA_SETTINGS = (uint)(0xC037000F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_NUMA_NODE_INDEX"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_NUMA_NODE_INDEX _NDIS_ERROR_TYPEDEF_(0xC0370010L)")]
    public const uint ERROR_VID_INVALID_NUMA_NODE_INDEX = (uint)(0xC0370010);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED"]/*' />
    [NativeTypeName("#define ERROR_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED _NDIS_ERROR_TYPEDEF_(0xC0370011L)")]
    public const uint ERROR_VID_NOTIFICATION_QUEUE_ALREADY_ASSOCIATED = (uint)(0xC0370011);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_MEMORY_BLOCK_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_MEMORY_BLOCK_HANDLE _NDIS_ERROR_TYPEDEF_(0xC0370012L)")]
    public const uint ERROR_VID_INVALID_MEMORY_BLOCK_HANDLE = (uint)(0xC0370012);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_PAGE_RANGE_OVERFLOW"]/*' />
    [NativeTypeName("#define ERROR_VID_PAGE_RANGE_OVERFLOW _NDIS_ERROR_TYPEDEF_(0xC0370013L)")]
    public const uint ERROR_VID_PAGE_RANGE_OVERFLOW = (uint)(0xC0370013);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_MESSAGE_QUEUE_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_MESSAGE_QUEUE_HANDLE _NDIS_ERROR_TYPEDEF_(0xC0370014L)")]
    public const uint ERROR_VID_INVALID_MESSAGE_QUEUE_HANDLE = (uint)(0xC0370014);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_GPA_RANGE_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_GPA_RANGE_HANDLE _NDIS_ERROR_TYPEDEF_(0xC0370015L)")]
    public const uint ERROR_VID_INVALID_GPA_RANGE_HANDLE = (uint)(0xC0370015);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE"]/*' />
    [NativeTypeName("#define ERROR_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE _NDIS_ERROR_TYPEDEF_(0xC0370016L)")]
    public const uint ERROR_VID_NO_MEMORY_BLOCK_NOTIFICATION_QUEUE = (uint)(0xC0370016);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED _NDIS_ERROR_TYPEDEF_(0xC0370017L)")]
    public const uint ERROR_VID_MEMORY_BLOCK_LOCK_COUNT_EXCEEDED = (uint)(0xC0370017);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_PPM_HANDLE"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_PPM_HANDLE _NDIS_ERROR_TYPEDEF_(0xC0370018L)")]
    public const uint ERROR_VID_INVALID_PPM_HANDLE = (uint)(0xC0370018);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MBPS_ARE_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_VID_MBPS_ARE_LOCKED _NDIS_ERROR_TYPEDEF_(0xC0370019L)")]
    public const uint ERROR_VID_MBPS_ARE_LOCKED = (uint)(0xC0370019);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MESSAGE_QUEUE_CLOSED"]/*' />
    [NativeTypeName("#define ERROR_VID_MESSAGE_QUEUE_CLOSED _NDIS_ERROR_TYPEDEF_(0xC037001AL)")]
    public const uint ERROR_VID_MESSAGE_QUEUE_CLOSED = (uint)(0xC037001A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED _NDIS_ERROR_TYPEDEF_(0xC037001BL)")]
    public const uint ERROR_VID_VIRTUAL_PROCESSOR_LIMIT_EXCEEDED = (uint)(0xC037001B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_STOP_PENDING"]/*' />
    [NativeTypeName("#define ERROR_VID_STOP_PENDING _NDIS_ERROR_TYPEDEF_(0xC037001CL)")]
    public const uint ERROR_VID_STOP_PENDING = (uint)(0xC037001C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_PROCESSOR_STATE"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_PROCESSOR_STATE _NDIS_ERROR_TYPEDEF_(0xC037001DL)")]
    public const uint ERROR_VID_INVALID_PROCESSOR_STATE = (uint)(0xC037001D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT _NDIS_ERROR_TYPEDEF_(0xC037001EL)")]
    public const uint ERROR_VID_EXCEEDED_KM_CONTEXT_COUNT_LIMIT = (uint)(0xC037001E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KM_INTERFACE_ALREADY_INITIALIZED"]/*' />
    [NativeTypeName("#define ERROR_VID_KM_INTERFACE_ALREADY_INITIALIZED _NDIS_ERROR_TYPEDEF_(0xC037001FL)")]
    public const uint ERROR_VID_KM_INTERFACE_ALREADY_INITIALIZED = (uint)(0xC037001F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MB_PROPERTY_ALREADY_SET_RESET"]/*' />
    [NativeTypeName("#define ERROR_VID_MB_PROPERTY_ALREADY_SET_RESET _NDIS_ERROR_TYPEDEF_(0xC0370020L)")]
    public const uint ERROR_VID_MB_PROPERTY_ALREADY_SET_RESET = (uint)(0xC0370020);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MMIO_RANGE_DESTROYED"]/*' />
    [NativeTypeName("#define ERROR_VID_MMIO_RANGE_DESTROYED _NDIS_ERROR_TYPEDEF_(0xC0370021L)")]
    public const uint ERROR_VID_MMIO_RANGE_DESTROYED = (uint)(0xC0370021);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INVALID_CHILD_GPA_PAGE_SET"]/*' />
    [NativeTypeName("#define ERROR_VID_INVALID_CHILD_GPA_PAGE_SET _NDIS_ERROR_TYPEDEF_(0xC0370022L)")]
    public const uint ERROR_VID_INVALID_CHILD_GPA_PAGE_SET = (uint)(0xC0370022);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_RESERVE_PAGE_SET_IS_BEING_USED"]/*' />
    [NativeTypeName("#define ERROR_VID_RESERVE_PAGE_SET_IS_BEING_USED _NDIS_ERROR_TYPEDEF_(0xC0370023L)")]
    public const uint ERROR_VID_RESERVE_PAGE_SET_IS_BEING_USED = (uint)(0xC0370023);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_RESERVE_PAGE_SET_TOO_SMALL"]/*' />
    [NativeTypeName("#define ERROR_VID_RESERVE_PAGE_SET_TOO_SMALL _NDIS_ERROR_TYPEDEF_(0xC0370024L)")]
    public const uint ERROR_VID_RESERVE_PAGE_SET_TOO_SMALL = (uint)(0xC0370024);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE"]/*' />
    [NativeTypeName("#define ERROR_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE _NDIS_ERROR_TYPEDEF_(0xC0370025L)")]
    public const uint ERROR_VID_MBP_ALREADY_LOCKED_USING_RESERVED_PAGE = (uint)(0xC0370025);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MBP_COUNT_EXCEEDED_LIMIT"]/*' />
    [NativeTypeName("#define ERROR_VID_MBP_COUNT_EXCEEDED_LIMIT _NDIS_ERROR_TYPEDEF_(0xC0370026L)")]
    public const uint ERROR_VID_MBP_COUNT_EXCEEDED_LIMIT = (uint)(0xC0370026);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_SAVED_STATE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_VID_SAVED_STATE_CORRUPT _NDIS_ERROR_TYPEDEF_(0xC0370027L)")]
    public const uint ERROR_VID_SAVED_STATE_CORRUPT = (uint)(0xC0370027);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_SAVED_STATE_UNRECOGNIZED_ITEM"]/*' />
    [NativeTypeName("#define ERROR_VID_SAVED_STATE_UNRECOGNIZED_ITEM _NDIS_ERROR_TYPEDEF_(0xC0370028L)")]
    public const uint ERROR_VID_SAVED_STATE_UNRECOGNIZED_ITEM = (uint)(0xC0370028);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_SAVED_STATE_INCOMPATIBLE"]/*' />
    [NativeTypeName("#define ERROR_VID_SAVED_STATE_INCOMPATIBLE _NDIS_ERROR_TYPEDEF_(0xC0370029L)")]
    public const uint ERROR_VID_SAVED_STATE_INCOMPATIBLE = (uint)(0xC0370029);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_VTL_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_VID_VTL_ACCESS_DENIED _NDIS_ERROR_TYPEDEF_(0xC037002AL)")]
    public const uint ERROR_VID_VTL_ACCESS_DENIED = (uint)(0xC037002A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INSUFFICIENT_RESOURCES_RESERVE"]/*' />
    [NativeTypeName("#define ERROR_VID_INSUFFICIENT_RESOURCES_RESERVE _NDIS_ERROR_TYPEDEF_(0xC037002BL)")]
    public const uint ERROR_VID_INSUFFICIENT_RESOURCES_RESERVE = (uint)(0xC037002B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INSUFFICIENT_RESOURCES_PHYSICAL_BUFFER"]/*' />
    [NativeTypeName("#define ERROR_VID_INSUFFICIENT_RESOURCES_PHYSICAL_BUFFER _NDIS_ERROR_TYPEDEF_(0xC037002CL)")]
    public const uint ERROR_VID_INSUFFICIENT_RESOURCES_PHYSICAL_BUFFER = (uint)(0xC037002C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INSUFFICIENT_RESOURCES_HV_DEPOSIT"]/*' />
    [NativeTypeName("#define ERROR_VID_INSUFFICIENT_RESOURCES_HV_DEPOSIT _NDIS_ERROR_TYPEDEF_(0xC037002DL)")]
    public const uint ERROR_VID_INSUFFICIENT_RESOURCES_HV_DEPOSIT = (uint)(0xC037002D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MEMORY_TYPE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_VID_MEMORY_TYPE_NOT_SUPPORTED _NDIS_ERROR_TYPEDEF_(0xC037002EL)")]
    public const uint ERROR_VID_MEMORY_TYPE_NOT_SUPPORTED = (uint)(0xC037002E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_INSUFFICIENT_RESOURCES_WITHDRAW"]/*' />
    [NativeTypeName("#define ERROR_VID_INSUFFICIENT_RESOURCES_WITHDRAW _NDIS_ERROR_TYPEDEF_(0xC037002FL)")]
    public const uint ERROR_VID_INSUFFICIENT_RESOURCES_WITHDRAW = (uint)(0xC037002F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_PROCESS_ALREADY_SET"]/*' />
    [NativeTypeName("#define ERROR_VID_PROCESS_ALREADY_SET _NDIS_ERROR_TYPEDEF_(0xC0370030L)")]
    public const uint ERROR_VID_PROCESS_ALREADY_SET = (uint)(0xC0370030);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_PARTITION_INVARIANTS_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_PARTITION_INVARIANTS_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC0370031L)")]
    public const uint ERROR_VID_PARTITION_INVARIANTS_MISMATCH = (uint)(0xC0370031);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MEMORY_BLOCK_INVARIANTS_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_MEMORY_BLOCK_INVARIANTS_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC0370032L)")]
    public const uint ERROR_VID_MEMORY_BLOCK_INVARIANTS_MISMATCH = (uint)(0xC0370032);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MEMORY_BLOCK_RESTORE_STATE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_MEMORY_BLOCK_RESTORE_STATE_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC0370033L)")]
    public const uint ERROR_VID_MEMORY_BLOCK_RESTORE_STATE_MISMATCH = (uint)(0xC0370033);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_PERSISTED_ITEMS_STILL_REGISTERED"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_PERSISTED_ITEMS_STILL_REGISTERED _NDIS_ERROR_TYPEDEF_(0xC0370034L)")]
    public const uint ERROR_VID_KSR_PERSISTED_ITEMS_STILL_REGISTERED = (uint)(0xC0370034);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MEMORY_PARTITION_SETUP_FAILED"]/*' />
    [NativeTypeName("#define ERROR_VID_MEMORY_PARTITION_SETUP_FAILED _NDIS_ERROR_TYPEDEF_(0xC0370035L)")]
    public const uint ERROR_VID_MEMORY_PARTITION_SETUP_FAILED = (uint)(0xC0370035);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MEMORY_RESERVE_NOT_ENABLED"]/*' />
    [NativeTypeName("#define ERROR_VID_MEMORY_RESERVE_NOT_ENABLED _NDIS_ERROR_TYPEDEF_(0xC0370036L)")]
    public const uint ERROR_VID_MEMORY_RESERVE_NOT_ENABLED = (uint)(0xC0370036);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MEMORY_BLOCK_PAGECOUNT_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_MEMORY_BLOCK_PAGECOUNT_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC0370037L)")]
    public const uint ERROR_VID_MEMORY_BLOCK_PAGECOUNT_MISMATCH = (uint)(0xC0370037);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_IOHANDLER_PROPERTY_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_IOHANDLER_PROPERTY_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC0370038L)")]
    public const uint ERROR_VID_KSR_IOHANDLER_PROPERTY_MISMATCH = (uint)(0xC0370038);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_MSR_HANDLER_PROPERTY_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_MSR_HANDLER_PROPERTY_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC0370039L)")]
    public const uint ERROR_VID_KSR_MSR_HANDLER_PROPERTY_MISMATCH = (uint)(0xC0370039);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_MEMORY_PARTITION_STATE_SIZE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_MEMORY_PARTITION_STATE_SIZE_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC037003AL)")]
    public const uint ERROR_VID_KSR_MEMORY_PARTITION_STATE_SIZE_MISMATCH = (uint)(0xC037003A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_METADATA_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_METADATA_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC037003BL)")]
    public const uint ERROR_VID_KSR_METADATA_MISMATCH = (uint)(0xC037003B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_TOTAL_PAGE_COUNT_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_TOTAL_PAGE_COUNT_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC037003CL)")]
    public const uint ERROR_VID_KSR_TOTAL_PAGE_COUNT_MISMATCH = (uint)(0xC037003C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MBP_ARRAY_NOT_PERSISTED"]/*' />
    [NativeTypeName("#define ERROR_VID_MBP_ARRAY_NOT_PERSISTED _NDIS_ERROR_TYPEDEF_(0xC037003DL)")]
    public const uint ERROR_VID_MBP_ARRAY_NOT_PERSISTED = (uint)(0xC037003D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_INVALID_PERSIST_ID"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_INVALID_PERSIST_ID _NDIS_ERROR_TYPEDEF_(0xC037003EL)")]
    public const uint ERROR_VID_KSR_INVALID_PERSIST_ID = (uint)(0xC037003E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_INVALID_PERSISTENCE_OPTIONS"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_INVALID_PERSISTENCE_OPTIONS _NDIS_ERROR_TYPEDEF_(0xC037003FL)")]
    public const uint ERROR_VID_KSR_INVALID_PERSISTENCE_OPTIONS = (uint)(0xC037003F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_GPA_RANGE_INVALID_FLAGS"]/*' />
    [NativeTypeName("#define ERROR_VID_GPA_RANGE_INVALID_FLAGS _NDIS_ERROR_TYPEDEF_(0xC0370040L)")]
    public const uint ERROR_VID_GPA_RANGE_INVALID_FLAGS = (uint)(0xC0370040);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_MEMORY_BLOCK_INVALID_FLAGS"]/*' />
    [NativeTypeName("#define ERROR_VID_MEMORY_BLOCK_INVALID_FLAGS _NDIS_ERROR_TYPEDEF_(0xC0370041L)")]
    public const uint ERROR_VID_MEMORY_BLOCK_INVALID_FLAGS = (uint)(0xC0370041);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_ALREADY_PERSISTED"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_ALREADY_PERSISTED _NDIS_ERROR_TYPEDEF_(0xC0370042L)")]
    public const uint ERROR_VID_KSR_ALREADY_PERSISTED = (uint)(0xC0370042);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_ALREADY_UNPERSISTED"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_ALREADY_UNPERSISTED _NDIS_ERROR_TYPEDEF_(0xC0370043L)")]
    public const uint ERROR_VID_KSR_ALREADY_UNPERSISTED = (uint)(0xC0370043);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_PERSISTENCE_DISALLOWED"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_PERSISTENCE_DISALLOWED _NDIS_ERROR_TYPEDEF_(0xC0370044L)")]
    public const uint ERROR_VID_KSR_PERSISTENCE_DISALLOWED = (uint)(0xC0370044);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_CLIENT_TYPE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_CLIENT_TYPE_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC0370045L)")]
    public const uint ERROR_VID_KSR_CLIENT_TYPE_MISMATCH = (uint)(0xC0370045);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_INVALID_STATE"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_INVALID_STATE _NDIS_ERROR_TYPEDEF_(0xC0370046L)")]
    public const uint ERROR_VID_KSR_INVALID_STATE = (uint)(0xC0370046);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_NOT_READY _NDIS_ERROR_TYPEDEF_(0xC0370047L)")]
    public const uint ERROR_VID_KSR_NOT_READY = (uint)(0xC0370047);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_GPA_RANGE_OVERLAP_PROHIBITED"]/*' />
    [NativeTypeName("#define ERROR_VID_GPA_RANGE_OVERLAP_PROHIBITED _NDIS_ERROR_TYPEDEF_(0xC0370048L)")]
    public const uint ERROR_VID_GPA_RANGE_OVERLAP_PROHIBITED = (uint)(0xC0370048);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_PARTITION_NOT_HIERARCHICAL_HOST"]/*' />
    [NativeTypeName("#define ERROR_VID_PARTITION_NOT_HIERARCHICAL_HOST _NDIS_ERROR_TYPEDEF_(0xC0370049L)")]
    public const uint ERROR_VID_PARTITION_NOT_HIERARCHICAL_HOST = (uint)(0xC0370049);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_GPA_RANGE_INVARIANTS_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_GPA_RANGE_INVARIANTS_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC037004AL)")]
    public const uint ERROR_VID_GPA_RANGE_INVARIANTS_MISMATCH = (uint)(0xC037004A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_KSR_PSCI_HANDLER_PROPERTY_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VID_KSR_PSCI_HANDLER_PROPERTY_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC037004BL)")]
    public const uint ERROR_VID_KSR_PSCI_HANDLER_PROPERTY_MISMATCH = (uint)(0xC037004B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_TERMINATED_DURING_START"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_TERMINATED_DURING_START _NDIS_ERROR_TYPEDEF_(0xC0370100L)")]
    public const uint ERROR_VMCOMPUTE_TERMINATED_DURING_START = (uint)(0xC0370100);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_IMAGE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_IMAGE_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC0370101L)")]
    public const uint ERROR_VMCOMPUTE_IMAGE_MISMATCH = (uint)(0xC0370101);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_HYPERV_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_HYPERV_NOT_INSTALLED _NDIS_ERROR_TYPEDEF_(0xC0370102L)")]
    public const uint ERROR_VMCOMPUTE_HYPERV_NOT_INSTALLED = (uint)(0xC0370102);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_OPERATION_PENDING"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_OPERATION_PENDING _NDIS_ERROR_TYPEDEF_(0xC0370103L)")]
    public const uint ERROR_VMCOMPUTE_OPERATION_PENDING = (uint)(0xC0370103);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_TOO_MANY_NOTIFICATIONS"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_TOO_MANY_NOTIFICATIONS _NDIS_ERROR_TYPEDEF_(0xC0370104L)")]
    public const uint ERROR_VMCOMPUTE_TOO_MANY_NOTIFICATIONS = (uint)(0xC0370104);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_INVALID_STATE"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_INVALID_STATE _NDIS_ERROR_TYPEDEF_(0xC0370105L)")]
    public const uint ERROR_VMCOMPUTE_INVALID_STATE = (uint)(0xC0370105);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_UNEXPECTED_EXIT"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_UNEXPECTED_EXIT _NDIS_ERROR_TYPEDEF_(0xC0370106L)")]
    public const uint ERROR_VMCOMPUTE_UNEXPECTED_EXIT = (uint)(0xC0370106);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_TERMINATED"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_TERMINATED _NDIS_ERROR_TYPEDEF_(0xC0370107L)")]
    public const uint ERROR_VMCOMPUTE_TERMINATED = (uint)(0xC0370107);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_CONNECT_FAILED"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_CONNECT_FAILED _NDIS_ERROR_TYPEDEF_(0xC0370108L)")]
    public const uint ERROR_VMCOMPUTE_CONNECT_FAILED = (uint)(0xC0370108);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_TIMEOUT _NDIS_ERROR_TYPEDEF_(0xC0370109L)")]
    public const uint ERROR_VMCOMPUTE_TIMEOUT = (uint)(0xC0370109);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_CONNECTION_CLOSED"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_CONNECTION_CLOSED _NDIS_ERROR_TYPEDEF_(0xC037010AL)")]
    public const uint ERROR_VMCOMPUTE_CONNECTION_CLOSED = (uint)(0xC037010A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_UNKNOWN_MESSAGE"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_UNKNOWN_MESSAGE _NDIS_ERROR_TYPEDEF_(0xC037010BL)")]
    public const uint ERROR_VMCOMPUTE_UNKNOWN_MESSAGE = (uint)(0xC037010B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_UNSUPPORTED_PROTOCOL_VERSION"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_UNSUPPORTED_PROTOCOL_VERSION _NDIS_ERROR_TYPEDEF_(0xC037010CL)")]
    public const uint ERROR_VMCOMPUTE_UNSUPPORTED_PROTOCOL_VERSION = (uint)(0xC037010C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_INVALID_JSON"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_INVALID_JSON _NDIS_ERROR_TYPEDEF_(0xC037010DL)")]
    public const uint ERROR_VMCOMPUTE_INVALID_JSON = (uint)(0xC037010D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_SYSTEM_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_SYSTEM_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0xC037010EL)")]
    public const uint ERROR_VMCOMPUTE_SYSTEM_NOT_FOUND = (uint)(0xC037010E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_SYSTEM_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_SYSTEM_ALREADY_EXISTS _NDIS_ERROR_TYPEDEF_(0xC037010FL)")]
    public const uint ERROR_VMCOMPUTE_SYSTEM_ALREADY_EXISTS = (uint)(0xC037010F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_SYSTEM_ALREADY_STOPPED"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_SYSTEM_ALREADY_STOPPED _NDIS_ERROR_TYPEDEF_(0xC0370110L)")]
    public const uint ERROR_VMCOMPUTE_SYSTEM_ALREADY_STOPPED = (uint)(0xC0370110);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_PROTOCOL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_PROTOCOL_ERROR _NDIS_ERROR_TYPEDEF_(0xC0370111L)")]
    public const uint ERROR_VMCOMPUTE_PROTOCOL_ERROR = (uint)(0xC0370111);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_INVALID_LAYER"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_INVALID_LAYER _NDIS_ERROR_TYPEDEF_(0xC0370112L)")]
    public const uint ERROR_VMCOMPUTE_INVALID_LAYER = (uint)(0xC0370112);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VMCOMPUTE_WINDOWS_INSIDER_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_VMCOMPUTE_WINDOWS_INSIDER_REQUIRED _NDIS_ERROR_TYPEDEF_(0xC0370113L)")]
    public const uint ERROR_VMCOMPUTE_WINDOWS_INSIDER_REQUIRED = (uint)(0xC0370113);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VNET_VIRTUAL_SWITCH_NAME_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_VNET_VIRTUAL_SWITCH_NAME_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0xC0370200L)")]
    public const uint ERROR_VNET_VIRTUAL_SWITCH_NAME_NOT_FOUND = (uint)(0xC0370200);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED"]/*' />
    [NativeTypeName("#define ERROR_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED _NDIS_ERROR_TYPEDEF_(0x80370001L)")]
    public const uint ERROR_VID_REMOTE_NODE_PARENT_GPA_PAGES_USED = (uint)(0x80370001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSMB_SAVED_STATE_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_VSMB_SAVED_STATE_FILE_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0xC0370400L)")]
    public const uint ERROR_VSMB_SAVED_STATE_FILE_NOT_FOUND = (uint)(0xC0370400);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VSMB_SAVED_STATE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_VSMB_SAVED_STATE_CORRUPT _NDIS_ERROR_TYPEDEF_(0xC0370401L)")]
    public const uint ERROR_VSMB_SAVED_STATE_CORRUPT = (uint)(0xC0370401);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DM_OPERATION_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define ERROR_DM_OPERATION_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0xC0370600L)")]
    public const int ERROR_DM_OPERATION_LIMIT_EXCEEDED = unchecked((int)(0xC0370600));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_INCOMPLETE_REGENERATION"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_INCOMPLETE_REGENERATION _NDIS_ERROR_TYPEDEF_(0x80380001L)")]
    public const uint ERROR_VOLMGR_INCOMPLETE_REGENERATION = (uint)(0x80380001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_INCOMPLETE_DISK_MIGRATION"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_INCOMPLETE_DISK_MIGRATION _NDIS_ERROR_TYPEDEF_(0x80380002L)")]
    public const uint ERROR_VOLMGR_INCOMPLETE_DISK_MIGRATION = (uint)(0x80380002);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DATABASE_FULL"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DATABASE_FULL _NDIS_ERROR_TYPEDEF_(0xC0380001L)")]
    public const uint ERROR_VOLMGR_DATABASE_FULL = (uint)(0xC0380001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_CONFIGURATION_CORRUPTED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_CONFIGURATION_CORRUPTED _NDIS_ERROR_TYPEDEF_(0xC0380002L)")]
    public const uint ERROR_VOLMGR_DISK_CONFIGURATION_CORRUPTED = (uint)(0xC0380002);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC _NDIS_ERROR_TYPEDEF_(0xC0380003L)")]
    public const uint ERROR_VOLMGR_DISK_CONFIGURATION_NOT_IN_SYNC = (uint)(0xC0380003);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_CONFIG_UPDATE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_CONFIG_UPDATE_FAILED _NDIS_ERROR_TYPEDEF_(0xC0380004L)")]
    public const uint ERROR_VOLMGR_PACK_CONFIG_UPDATE_FAILED = (uint)(0xC0380004);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME _NDIS_ERROR_TYPEDEF_(0xC0380005L)")]
    public const uint ERROR_VOLMGR_DISK_CONTAINS_NON_SIMPLE_VOLUME = (uint)(0xC0380005);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_DUPLICATE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_DUPLICATE _NDIS_ERROR_TYPEDEF_(0xC0380006L)")]
    public const uint ERROR_VOLMGR_DISK_DUPLICATE = (uint)(0xC0380006);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_DYNAMIC"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_DYNAMIC _NDIS_ERROR_TYPEDEF_(0xC0380007L)")]
    public const uint ERROR_VOLMGR_DISK_DYNAMIC = (uint)(0xC0380007);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_ID_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_ID_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380008L)")]
    public const uint ERROR_VOLMGR_DISK_ID_INVALID = (uint)(0xC0380008);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380009L)")]
    public const uint ERROR_VOLMGR_DISK_INVALID = (uint)(0xC0380009);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_LAST_VOTER"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_LAST_VOTER _NDIS_ERROR_TYPEDEF_(0xC038000AL)")]
    public const uint ERROR_VOLMGR_DISK_LAST_VOTER = (uint)(0xC038000A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_LAYOUT_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_LAYOUT_INVALID _NDIS_ERROR_TYPEDEF_(0xC038000BL)")]
    public const uint ERROR_VOLMGR_DISK_LAYOUT_INVALID = (uint)(0xC038000B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS _NDIS_ERROR_TYPEDEF_(0xC038000CL)")]
    public const uint ERROR_VOLMGR_DISK_LAYOUT_NON_BASIC_BETWEEN_BASIC_PARTITIONS = (uint)(0xC038000C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED _NDIS_ERROR_TYPEDEF_(0xC038000DL)")]
    public const uint ERROR_VOLMGR_DISK_LAYOUT_NOT_CYLINDER_ALIGNED = (uint)(0xC038000D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL _NDIS_ERROR_TYPEDEF_(0xC038000EL)")]
    public const uint ERROR_VOLMGR_DISK_LAYOUT_PARTITIONS_TOO_SMALL = (uint)(0xC038000E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS _NDIS_ERROR_TYPEDEF_(0xC038000FL)")]
    public const uint ERROR_VOLMGR_DISK_LAYOUT_PRIMARY_BETWEEN_LOGICAL_PARTITIONS = (uint)(0xC038000F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS _NDIS_ERROR_TYPEDEF_(0xC0380010L)")]
    public const uint ERROR_VOLMGR_DISK_LAYOUT_TOO_MANY_PARTITIONS = (uint)(0xC0380010);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_MISSING"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_MISSING _NDIS_ERROR_TYPEDEF_(0xC0380011L)")]
    public const uint ERROR_VOLMGR_DISK_MISSING = (uint)(0xC0380011);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_NOT_EMPTY"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_NOT_EMPTY _NDIS_ERROR_TYPEDEF_(0xC0380012L)")]
    public const uint ERROR_VOLMGR_DISK_NOT_EMPTY = (uint)(0xC0380012);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_NOT_ENOUGH_SPACE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_NOT_ENOUGH_SPACE _NDIS_ERROR_TYPEDEF_(0xC0380013L)")]
    public const uint ERROR_VOLMGR_DISK_NOT_ENOUGH_SPACE = (uint)(0xC0380013);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_REVECTORING_FAILED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_REVECTORING_FAILED _NDIS_ERROR_TYPEDEF_(0xC0380014L)")]
    public const uint ERROR_VOLMGR_DISK_REVECTORING_FAILED = (uint)(0xC0380014);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_SECTOR_SIZE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_SECTOR_SIZE_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380015L)")]
    public const uint ERROR_VOLMGR_DISK_SECTOR_SIZE_INVALID = (uint)(0xC0380015);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_SET_NOT_CONTAINED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_SET_NOT_CONTAINED _NDIS_ERROR_TYPEDEF_(0xC0380016L)")]
    public const uint ERROR_VOLMGR_DISK_SET_NOT_CONTAINED = (uint)(0xC0380016);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS _NDIS_ERROR_TYPEDEF_(0xC0380017L)")]
    public const uint ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_MEMBERS = (uint)(0xC0380017);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES _NDIS_ERROR_TYPEDEF_(0xC0380018L)")]
    public const uint ERROR_VOLMGR_DISK_USED_BY_MULTIPLE_PLEXES = (uint)(0xC0380018);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED _NDIS_ERROR_TYPEDEF_(0xC0380019L)")]
    public const uint ERROR_VOLMGR_DYNAMIC_DISK_NOT_SUPPORTED = (uint)(0xC0380019);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_EXTENT_ALREADY_USED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_EXTENT_ALREADY_USED _NDIS_ERROR_TYPEDEF_(0xC038001AL)")]
    public const uint ERROR_VOLMGR_EXTENT_ALREADY_USED = (uint)(0xC038001A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_EXTENT_NOT_CONTIGUOUS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_EXTENT_NOT_CONTIGUOUS _NDIS_ERROR_TYPEDEF_(0xC038001BL)")]
    public const uint ERROR_VOLMGR_EXTENT_NOT_CONTIGUOUS = (uint)(0xC038001B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION _NDIS_ERROR_TYPEDEF_(0xC038001CL)")]
    public const uint ERROR_VOLMGR_EXTENT_NOT_IN_PUBLIC_REGION = (uint)(0xC038001C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED _NDIS_ERROR_TYPEDEF_(0xC038001DL)")]
    public const uint ERROR_VOLMGR_EXTENT_NOT_SECTOR_ALIGNED = (uint)(0xC038001D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION _NDIS_ERROR_TYPEDEF_(0xC038001EL)")]
    public const uint ERROR_VOLMGR_EXTENT_OVERLAPS_EBR_PARTITION = (uint)(0xC038001E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH _NDIS_ERROR_TYPEDEF_(0xC038001FL)")]
    public const uint ERROR_VOLMGR_EXTENT_VOLUME_LENGTHS_DO_NOT_MATCH = (uint)(0xC038001F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED _NDIS_ERROR_TYPEDEF_(0xC0380020L)")]
    public const uint ERROR_VOLMGR_FAULT_TOLERANT_NOT_SUPPORTED = (uint)(0xC0380020);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_INTERLEAVE_LENGTH_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_INTERLEAVE_LENGTH_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380021L)")]
    public const uint ERROR_VOLMGR_INTERLEAVE_LENGTH_INVALID = (uint)(0xC0380021);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_MAXIMUM_REGISTERED_USERS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_MAXIMUM_REGISTERED_USERS _NDIS_ERROR_TYPEDEF_(0xC0380022L)")]
    public const uint ERROR_VOLMGR_MAXIMUM_REGISTERED_USERS = (uint)(0xC0380022);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_MEMBER_IN_SYNC"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_MEMBER_IN_SYNC _NDIS_ERROR_TYPEDEF_(0xC0380023L)")]
    public const uint ERROR_VOLMGR_MEMBER_IN_SYNC = (uint)(0xC0380023);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_MEMBER_INDEX_DUPLICATE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_MEMBER_INDEX_DUPLICATE _NDIS_ERROR_TYPEDEF_(0xC0380024L)")]
    public const uint ERROR_VOLMGR_MEMBER_INDEX_DUPLICATE = (uint)(0xC0380024);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_MEMBER_INDEX_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_MEMBER_INDEX_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380025L)")]
    public const uint ERROR_VOLMGR_MEMBER_INDEX_INVALID = (uint)(0xC0380025);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_MEMBER_MISSING"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_MEMBER_MISSING _NDIS_ERROR_TYPEDEF_(0xC0380026L)")]
    public const uint ERROR_VOLMGR_MEMBER_MISSING = (uint)(0xC0380026);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_MEMBER_NOT_DETACHED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_MEMBER_NOT_DETACHED _NDIS_ERROR_TYPEDEF_(0xC0380027L)")]
    public const uint ERROR_VOLMGR_MEMBER_NOT_DETACHED = (uint)(0xC0380027);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_MEMBER_REGENERATING"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_MEMBER_REGENERATING _NDIS_ERROR_TYPEDEF_(0xC0380028L)")]
    public const uint ERROR_VOLMGR_MEMBER_REGENERATING = (uint)(0xC0380028);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_ALL_DISKS_FAILED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_ALL_DISKS_FAILED _NDIS_ERROR_TYPEDEF_(0xC0380029L)")]
    public const uint ERROR_VOLMGR_ALL_DISKS_FAILED = (uint)(0xC0380029);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NO_REGISTERED_USERS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NO_REGISTERED_USERS _NDIS_ERROR_TYPEDEF_(0xC038002AL)")]
    public const uint ERROR_VOLMGR_NO_REGISTERED_USERS = (uint)(0xC038002A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NO_SUCH_USER"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NO_SUCH_USER _NDIS_ERROR_TYPEDEF_(0xC038002BL)")]
    public const uint ERROR_VOLMGR_NO_SUCH_USER = (uint)(0xC038002B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NOTIFICATION_RESET"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NOTIFICATION_RESET _NDIS_ERROR_TYPEDEF_(0xC038002CL)")]
    public const uint ERROR_VOLMGR_NOTIFICATION_RESET = (uint)(0xC038002C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NUMBER_OF_MEMBERS_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NUMBER_OF_MEMBERS_INVALID _NDIS_ERROR_TYPEDEF_(0xC038002DL)")]
    public const uint ERROR_VOLMGR_NUMBER_OF_MEMBERS_INVALID = (uint)(0xC038002D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NUMBER_OF_PLEXES_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NUMBER_OF_PLEXES_INVALID _NDIS_ERROR_TYPEDEF_(0xC038002EL)")]
    public const uint ERROR_VOLMGR_NUMBER_OF_PLEXES_INVALID = (uint)(0xC038002E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_DUPLICATE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_DUPLICATE _NDIS_ERROR_TYPEDEF_(0xC038002FL)")]
    public const uint ERROR_VOLMGR_PACK_DUPLICATE = (uint)(0xC038002F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_ID_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_ID_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380030L)")]
    public const uint ERROR_VOLMGR_PACK_ID_INVALID = (uint)(0xC0380030);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380031L)")]
    public const uint ERROR_VOLMGR_PACK_INVALID = (uint)(0xC0380031);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_NAME_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_NAME_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380032L)")]
    public const uint ERROR_VOLMGR_PACK_NAME_INVALID = (uint)(0xC0380032);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_OFFLINE _NDIS_ERROR_TYPEDEF_(0xC0380033L)")]
    public const uint ERROR_VOLMGR_PACK_OFFLINE = (uint)(0xC0380033);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_HAS_QUORUM"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_HAS_QUORUM _NDIS_ERROR_TYPEDEF_(0xC0380034L)")]
    public const uint ERROR_VOLMGR_PACK_HAS_QUORUM = (uint)(0xC0380034);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_WITHOUT_QUORUM"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_WITHOUT_QUORUM _NDIS_ERROR_TYPEDEF_(0xC0380035L)")]
    public const uint ERROR_VOLMGR_PACK_WITHOUT_QUORUM = (uint)(0xC0380035);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PARTITION_STYLE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PARTITION_STYLE_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380036L)")]
    public const uint ERROR_VOLMGR_PARTITION_STYLE_INVALID = (uint)(0xC0380036);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PARTITION_UPDATE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PARTITION_UPDATE_FAILED _NDIS_ERROR_TYPEDEF_(0xC0380037L)")]
    public const uint ERROR_VOLMGR_PARTITION_UPDATE_FAILED = (uint)(0xC0380037);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_IN_SYNC"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_IN_SYNC _NDIS_ERROR_TYPEDEF_(0xC0380038L)")]
    public const uint ERROR_VOLMGR_PLEX_IN_SYNC = (uint)(0xC0380038);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_INDEX_DUPLICATE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_INDEX_DUPLICATE _NDIS_ERROR_TYPEDEF_(0xC0380039L)")]
    public const uint ERROR_VOLMGR_PLEX_INDEX_DUPLICATE = (uint)(0xC0380039);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_INDEX_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_INDEX_INVALID _NDIS_ERROR_TYPEDEF_(0xC038003AL)")]
    public const uint ERROR_VOLMGR_PLEX_INDEX_INVALID = (uint)(0xC038003A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_LAST_ACTIVE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_LAST_ACTIVE _NDIS_ERROR_TYPEDEF_(0xC038003BL)")]
    public const uint ERROR_VOLMGR_PLEX_LAST_ACTIVE = (uint)(0xC038003B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_MISSING"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_MISSING _NDIS_ERROR_TYPEDEF_(0xC038003CL)")]
    public const uint ERROR_VOLMGR_PLEX_MISSING = (uint)(0xC038003C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_REGENERATING"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_REGENERATING _NDIS_ERROR_TYPEDEF_(0xC038003DL)")]
    public const uint ERROR_VOLMGR_PLEX_REGENERATING = (uint)(0xC038003D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_TYPE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_TYPE_INVALID _NDIS_ERROR_TYPEDEF_(0xC038003EL)")]
    public const uint ERROR_VOLMGR_PLEX_TYPE_INVALID = (uint)(0xC038003E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_NOT_RAID5"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_NOT_RAID5 _NDIS_ERROR_TYPEDEF_(0xC038003FL)")]
    public const uint ERROR_VOLMGR_PLEX_NOT_RAID5 = (uint)(0xC038003F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_NOT_SIMPLE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_NOT_SIMPLE _NDIS_ERROR_TYPEDEF_(0xC0380040L)")]
    public const uint ERROR_VOLMGR_PLEX_NOT_SIMPLE = (uint)(0xC0380040);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_STRUCTURE_SIZE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_STRUCTURE_SIZE_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380041L)")]
    public const uint ERROR_VOLMGR_STRUCTURE_SIZE_INVALID = (uint)(0xC0380041);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS _NDIS_ERROR_TYPEDEF_(0xC0380042L)")]
    public const uint ERROR_VOLMGR_TOO_MANY_NOTIFICATION_REQUESTS = (uint)(0xC0380042);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_TRANSACTION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_TRANSACTION_IN_PROGRESS _NDIS_ERROR_TYPEDEF_(0xC0380043L)")]
    public const uint ERROR_VOLMGR_TRANSACTION_IN_PROGRESS = (uint)(0xC0380043);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE _NDIS_ERROR_TYPEDEF_(0xC0380044L)")]
    public const uint ERROR_VOLMGR_UNEXPECTED_DISK_LAYOUT_CHANGE = (uint)(0xC0380044);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_CONTAINS_MISSING_DISK"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_CONTAINS_MISSING_DISK _NDIS_ERROR_TYPEDEF_(0xC0380045L)")]
    public const uint ERROR_VOLMGR_VOLUME_CONTAINS_MISSING_DISK = (uint)(0xC0380045);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_ID_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_ID_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380046L)")]
    public const uint ERROR_VOLMGR_VOLUME_ID_INVALID = (uint)(0xC0380046);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_LENGTH_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_LENGTH_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380047L)")]
    public const uint ERROR_VOLMGR_VOLUME_LENGTH_INVALID = (uint)(0xC0380047);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE _NDIS_ERROR_TYPEDEF_(0xC0380048L)")]
    public const uint ERROR_VOLMGR_VOLUME_LENGTH_NOT_SECTOR_SIZE_MULTIPLE = (uint)(0xC0380048);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_NOT_MIRRORED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_NOT_MIRRORED _NDIS_ERROR_TYPEDEF_(0xC0380049L)")]
    public const uint ERROR_VOLMGR_VOLUME_NOT_MIRRORED = (uint)(0xC0380049);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_NOT_RETAINED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_NOT_RETAINED _NDIS_ERROR_TYPEDEF_(0xC038004AL)")]
    public const uint ERROR_VOLMGR_VOLUME_NOT_RETAINED = (uint)(0xC038004A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_OFFLINE _NDIS_ERROR_TYPEDEF_(0xC038004BL)")]
    public const uint ERROR_VOLMGR_VOLUME_OFFLINE = (uint)(0xC038004B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_RETAINED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_RETAINED _NDIS_ERROR_TYPEDEF_(0xC038004CL)")]
    public const uint ERROR_VOLMGR_VOLUME_RETAINED = (uint)(0xC038004C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NUMBER_OF_EXTENTS_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NUMBER_OF_EXTENTS_INVALID _NDIS_ERROR_TYPEDEF_(0xC038004DL)")]
    public const uint ERROR_VOLMGR_NUMBER_OF_EXTENTS_INVALID = (uint)(0xC038004D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_DIFFERENT_SECTOR_SIZE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_DIFFERENT_SECTOR_SIZE _NDIS_ERROR_TYPEDEF_(0xC038004EL)")]
    public const uint ERROR_VOLMGR_DIFFERENT_SECTOR_SIZE = (uint)(0xC038004E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_BAD_BOOT_DISK"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_BAD_BOOT_DISK _NDIS_ERROR_TYPEDEF_(0xC038004FL)")]
    public const uint ERROR_VOLMGR_BAD_BOOT_DISK = (uint)(0xC038004F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_CONFIG_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_CONFIG_OFFLINE _NDIS_ERROR_TYPEDEF_(0xC0380050L)")]
    public const uint ERROR_VOLMGR_PACK_CONFIG_OFFLINE = (uint)(0xC0380050);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_CONFIG_ONLINE"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_CONFIG_ONLINE _NDIS_ERROR_TYPEDEF_(0xC0380051L)")]
    public const uint ERROR_VOLMGR_PACK_CONFIG_ONLINE = (uint)(0xC0380051);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NOT_PRIMARY_PACK"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NOT_PRIMARY_PACK _NDIS_ERROR_TYPEDEF_(0xC0380052L)")]
    public const uint ERROR_VOLMGR_NOT_PRIMARY_PACK = (uint)(0xC0380052);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PACK_LOG_UPDATE_FAILED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PACK_LOG_UPDATE_FAILED _NDIS_ERROR_TYPEDEF_(0xC0380053L)")]
    public const uint ERROR_VOLMGR_PACK_LOG_UPDATE_FAILED = (uint)(0xC0380053);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380054L)")]
    public const uint ERROR_VOLMGR_NUMBER_OF_DISKS_IN_PLEX_INVALID = (uint)(0xC0380054);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID _NDIS_ERROR_TYPEDEF_(0xC0380055L)")]
    public const uint ERROR_VOLMGR_NUMBER_OF_DISKS_IN_MEMBER_INVALID = (uint)(0xC0380055);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_VOLUME_MIRRORED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_VOLUME_MIRRORED _NDIS_ERROR_TYPEDEF_(0xC0380056L)")]
    public const uint ERROR_VOLMGR_VOLUME_MIRRORED = (uint)(0xC0380056);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PLEX_NOT_SIMPLE_SPANNED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PLEX_NOT_SIMPLE_SPANNED _NDIS_ERROR_TYPEDEF_(0xC0380057L)")]
    public const uint ERROR_VOLMGR_PLEX_NOT_SIMPLE_SPANNED = (uint)(0xC0380057);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NO_VALID_LOG_COPIES"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NO_VALID_LOG_COPIES _NDIS_ERROR_TYPEDEF_(0xC0380058L)")]
    public const uint ERROR_VOLMGR_NO_VALID_LOG_COPIES = (uint)(0xC0380058);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_PRIMARY_PACK_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_PRIMARY_PACK_PRESENT _NDIS_ERROR_TYPEDEF_(0xC0380059L)")]
    public const uint ERROR_VOLMGR_PRIMARY_PACK_PRESENT = (uint)(0xC0380059);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_NUMBER_OF_DISKS_INVALID"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_NUMBER_OF_DISKS_INVALID _NDIS_ERROR_TYPEDEF_(0xC038005AL)")]
    public const uint ERROR_VOLMGR_NUMBER_OF_DISKS_INVALID = (uint)(0xC038005A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_MIRROR_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_MIRROR_NOT_SUPPORTED _NDIS_ERROR_TYPEDEF_(0xC038005BL)")]
    public const uint ERROR_VOLMGR_MIRROR_NOT_SUPPORTED = (uint)(0xC038005B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLMGR_RAID5_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_VOLMGR_RAID5_NOT_SUPPORTED _NDIS_ERROR_TYPEDEF_(0xC038005CL)")]
    public const uint ERROR_VOLMGR_RAID5_NOT_SUPPORTED = (uint)(0xC038005C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BCD_NOT_ALL_ENTRIES_IMPORTED"]/*' />
    [NativeTypeName("#define ERROR_BCD_NOT_ALL_ENTRIES_IMPORTED _NDIS_ERROR_TYPEDEF_(0x80390001L)")]
    public const uint ERROR_BCD_NOT_ALL_ENTRIES_IMPORTED = (uint)(0x80390001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BCD_TOO_MANY_ELEMENTS"]/*' />
    [NativeTypeName("#define ERROR_BCD_TOO_MANY_ELEMENTS _NDIS_ERROR_TYPEDEF_(0xC0390002L)")]
    public const uint ERROR_BCD_TOO_MANY_ELEMENTS = (uint)(0xC0390002);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED"]/*' />
    [NativeTypeName("#define ERROR_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED _NDIS_ERROR_TYPEDEF_(0x80390003L)")]
    public const uint ERROR_BCD_NOT_ALL_ENTRIES_SYNCHRONIZED = (uint)(0x80390003);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_DRIVE_FOOTER_MISSING"]/*' />
    [NativeTypeName("#define ERROR_VHD_DRIVE_FOOTER_MISSING _NDIS_ERROR_TYPEDEF_(0xC03A0001L)")]
    public const uint ERROR_VHD_DRIVE_FOOTER_MISSING = (uint)(0xC03A0001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC03A0002L)")]
    public const uint ERROR_VHD_DRIVE_FOOTER_CHECKSUM_MISMATCH = (uint)(0xC03A0002);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_DRIVE_FOOTER_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_VHD_DRIVE_FOOTER_CORRUPT _NDIS_ERROR_TYPEDEF_(0xC03A0003L)")]
    public const uint ERROR_VHD_DRIVE_FOOTER_CORRUPT = (uint)(0xC03A0003);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_FORMAT_UNKNOWN"]/*' />
    [NativeTypeName("#define ERROR_VHD_FORMAT_UNKNOWN _NDIS_ERROR_TYPEDEF_(0xC03A0004L)")]
    public const uint ERROR_VHD_FORMAT_UNKNOWN = (uint)(0xC03A0004);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_FORMAT_UNSUPPORTED_VERSION"]/*' />
    [NativeTypeName("#define ERROR_VHD_FORMAT_UNSUPPORTED_VERSION _NDIS_ERROR_TYPEDEF_(0xC03A0005L)")]
    public const uint ERROR_VHD_FORMAT_UNSUPPORTED_VERSION = (uint)(0xC03A0005);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC03A0006L)")]
    public const uint ERROR_VHD_SPARSE_HEADER_CHECKSUM_MISMATCH = (uint)(0xC03A0006);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION"]/*' />
    [NativeTypeName("#define ERROR_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION _NDIS_ERROR_TYPEDEF_(0xC03A0007L)")]
    public const uint ERROR_VHD_SPARSE_HEADER_UNSUPPORTED_VERSION = (uint)(0xC03A0007);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_SPARSE_HEADER_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_VHD_SPARSE_HEADER_CORRUPT _NDIS_ERROR_TYPEDEF_(0xC03A0008L)")]
    public const uint ERROR_VHD_SPARSE_HEADER_CORRUPT = (uint)(0xC03A0008);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_BLOCK_ALLOCATION_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_VHD_BLOCK_ALLOCATION_FAILURE _NDIS_ERROR_TYPEDEF_(0xC03A0009L)")]
    public const uint ERROR_VHD_BLOCK_ALLOCATION_FAILURE = (uint)(0xC03A0009);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT"]/*' />
    [NativeTypeName("#define ERROR_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT _NDIS_ERROR_TYPEDEF_(0xC03A000AL)")]
    public const uint ERROR_VHD_BLOCK_ALLOCATION_TABLE_CORRUPT = (uint)(0xC03A000A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_INVALID_BLOCK_SIZE"]/*' />
    [NativeTypeName("#define ERROR_VHD_INVALID_BLOCK_SIZE _NDIS_ERROR_TYPEDEF_(0xC03A000BL)")]
    public const uint ERROR_VHD_INVALID_BLOCK_SIZE = (uint)(0xC03A000B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_BITMAP_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VHD_BITMAP_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC03A000CL)")]
    public const uint ERROR_VHD_BITMAP_MISMATCH = (uint)(0xC03A000C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_PARENT_VHD_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_VHD_PARENT_VHD_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0xC03A000DL)")]
    public const uint ERROR_VHD_PARENT_VHD_NOT_FOUND = (uint)(0xC03A000D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_CHILD_PARENT_ID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VHD_CHILD_PARENT_ID_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC03A000EL)")]
    public const uint ERROR_VHD_CHILD_PARENT_ID_MISMATCH = (uint)(0xC03A000E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC03A000FL)")]
    public const uint ERROR_VHD_CHILD_PARENT_TIMESTAMP_MISMATCH = (uint)(0xC03A000F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_METADATA_READ_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_VHD_METADATA_READ_FAILURE _NDIS_ERROR_TYPEDEF_(0xC03A0010L)")]
    public const uint ERROR_VHD_METADATA_READ_FAILURE = (uint)(0xC03A0010);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_METADATA_WRITE_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_VHD_METADATA_WRITE_FAILURE _NDIS_ERROR_TYPEDEF_(0xC03A0011L)")]
    public const uint ERROR_VHD_METADATA_WRITE_FAILURE = (uint)(0xC03A0011);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_INVALID_SIZE"]/*' />
    [NativeTypeName("#define ERROR_VHD_INVALID_SIZE _NDIS_ERROR_TYPEDEF_(0xC03A0012L)")]
    public const uint ERROR_VHD_INVALID_SIZE = (uint)(0xC03A0012);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_INVALID_FILE_SIZE"]/*' />
    [NativeTypeName("#define ERROR_VHD_INVALID_FILE_SIZE _NDIS_ERROR_TYPEDEF_(0xC03A0013L)")]
    public const uint ERROR_VHD_INVALID_FILE_SIZE = (uint)(0xC03A0013);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VIRTDISK_PROVIDER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_VIRTDISK_PROVIDER_NOT_FOUND _NDIS_ERROR_TYPEDEF_(0xC03A0014L)")]
    public const uint ERROR_VIRTDISK_PROVIDER_NOT_FOUND = (uint)(0xC03A0014);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VIRTDISK_NOT_VIRTUAL_DISK"]/*' />
    [NativeTypeName("#define ERROR_VIRTDISK_NOT_VIRTUAL_DISK _NDIS_ERROR_TYPEDEF_(0xC03A0015L)")]
    public const uint ERROR_VIRTDISK_NOT_VIRTUAL_DISK = (uint)(0xC03A0015);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_PARENT_VHD_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_VHD_PARENT_VHD_ACCESS_DENIED _NDIS_ERROR_TYPEDEF_(0xC03A0016L)")]
    public const uint ERROR_VHD_PARENT_VHD_ACCESS_DENIED = (uint)(0xC03A0016);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_CHILD_PARENT_SIZE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_VHD_CHILD_PARENT_SIZE_MISMATCH _NDIS_ERROR_TYPEDEF_(0xC03A0017L)")]
    public const uint ERROR_VHD_CHILD_PARENT_SIZE_MISMATCH = (uint)(0xC03A0017);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED"]/*' />
    [NativeTypeName("#define ERROR_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED _NDIS_ERROR_TYPEDEF_(0xC03A0018L)")]
    public const uint ERROR_VHD_DIFFERENCING_CHAIN_CYCLE_DETECTED = (uint)(0xC03A0018);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT"]/*' />
    [NativeTypeName("#define ERROR_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT _NDIS_ERROR_TYPEDEF_(0xC03A0019L)")]
    public const uint ERROR_VHD_DIFFERENCING_CHAIN_ERROR_IN_PARENT = (uint)(0xC03A0019);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VIRTUAL_DISK_LIMITATION"]/*' />
    [NativeTypeName("#define ERROR_VIRTUAL_DISK_LIMITATION _NDIS_ERROR_TYPEDEF_(0xC03A001AL)")]
    public const uint ERROR_VIRTUAL_DISK_LIMITATION = (uint)(0xC03A001A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_INVALID_TYPE"]/*' />
    [NativeTypeName("#define ERROR_VHD_INVALID_TYPE _NDIS_ERROR_TYPEDEF_(0xC03A001BL)")]
    public const uint ERROR_VHD_INVALID_TYPE = (uint)(0xC03A001B);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_INVALID_STATE"]/*' />
    [NativeTypeName("#define ERROR_VHD_INVALID_STATE _NDIS_ERROR_TYPEDEF_(0xC03A001CL)")]
    public const uint ERROR_VHD_INVALID_STATE = (uint)(0xC03A001C);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE"]/*' />
    [NativeTypeName("#define ERROR_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE _NDIS_ERROR_TYPEDEF_(0xC03A001DL)")]
    public const uint ERROR_VIRTDISK_UNSUPPORTED_DISK_SECTOR_SIZE = (uint)(0xC03A001D);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VIRTDISK_DISK_ALREADY_OWNED"]/*' />
    [NativeTypeName("#define ERROR_VIRTDISK_DISK_ALREADY_OWNED _NDIS_ERROR_TYPEDEF_(0xC03A001EL)")]
    public const uint ERROR_VIRTDISK_DISK_ALREADY_OWNED = (uint)(0xC03A001E);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VIRTDISK_DISK_ONLINE_AND_WRITABLE"]/*' />
    [NativeTypeName("#define ERROR_VIRTDISK_DISK_ONLINE_AND_WRITABLE _NDIS_ERROR_TYPEDEF_(0xC03A001FL)")]
    public const uint ERROR_VIRTDISK_DISK_ONLINE_AND_WRITABLE = (uint)(0xC03A001F);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTLOG_TRACKING_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define ERROR_CTLOG_TRACKING_NOT_INITIALIZED _NDIS_ERROR_TYPEDEF_(0xC03A0020L)")]
    public const uint ERROR_CTLOG_TRACKING_NOT_INITIALIZED = (uint)(0xC03A0020);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE"]/*' />
    [NativeTypeName("#define ERROR_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE _NDIS_ERROR_TYPEDEF_(0xC03A0021L)")]
    public const uint ERROR_CTLOG_LOGFILE_SIZE_EXCEEDED_MAXSIZE = (uint)(0xC03A0021);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTLOG_VHD_CHANGED_OFFLINE"]/*' />
    [NativeTypeName("#define ERROR_CTLOG_VHD_CHANGED_OFFLINE _NDIS_ERROR_TYPEDEF_(0xC03A0022L)")]
    public const uint ERROR_CTLOG_VHD_CHANGED_OFFLINE = (uint)(0xC03A0022);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTLOG_INVALID_TRACKING_STATE"]/*' />
    [NativeTypeName("#define ERROR_CTLOG_INVALID_TRACKING_STATE _NDIS_ERROR_TYPEDEF_(0xC03A0023L)")]
    public const uint ERROR_CTLOG_INVALID_TRACKING_STATE = (uint)(0xC03A0023);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CTLOG_INCONSISTENT_TRACKING_FILE"]/*' />
    [NativeTypeName("#define ERROR_CTLOG_INCONSISTENT_TRACKING_FILE _NDIS_ERROR_TYPEDEF_(0xC03A0024L)")]
    public const uint ERROR_CTLOG_INCONSISTENT_TRACKING_FILE = (uint)(0xC03A0024);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_RESIZE_WOULD_TRUNCATE_DATA"]/*' />
    [NativeTypeName("#define ERROR_VHD_RESIZE_WOULD_TRUNCATE_DATA _NDIS_ERROR_TYPEDEF_(0xC03A0025L)")]
    public const uint ERROR_VHD_RESIZE_WOULD_TRUNCATE_DATA = (uint)(0xC03A0025);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE"]/*' />
    [NativeTypeName("#define ERROR_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE _NDIS_ERROR_TYPEDEF_(0xC03A0026L)")]
    public const uint ERROR_VHD_COULD_NOT_COMPUTE_MINIMUM_VIRTUAL_SIZE = (uint)(0xC03A0026);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE"]/*' />
    [NativeTypeName("#define ERROR_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE _NDIS_ERROR_TYPEDEF_(0xC03A0027L)")]
    public const uint ERROR_VHD_ALREADY_AT_OR_BELOW_MINIMUM_VIRTUAL_SIZE = (uint)(0xC03A0027);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_METADATA_FULL"]/*' />
    [NativeTypeName("#define ERROR_VHD_METADATA_FULL _NDIS_ERROR_TYPEDEF_(0xC03A0028L)")]
    public const uint ERROR_VHD_METADATA_FULL = (uint)(0xC03A0028);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_INVALID_CHANGE_TRACKING_ID"]/*' />
    [NativeTypeName("#define ERROR_VHD_INVALID_CHANGE_TRACKING_ID _NDIS_ERROR_TYPEDEF_(0xC03A0029L)")]
    public const uint ERROR_VHD_INVALID_CHANGE_TRACKING_ID = (uint)(0xC03A0029);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_CHANGE_TRACKING_DISABLED"]/*' />
    [NativeTypeName("#define ERROR_VHD_CHANGE_TRACKING_DISABLED _NDIS_ERROR_TYPEDEF_(0xC03A002AL)")]
    public const uint ERROR_VHD_CHANGE_TRACKING_DISABLED = (uint)(0xC03A002A);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_MISSING_CHANGE_TRACKING_INFORMATION"]/*' />
    [NativeTypeName("#define ERROR_VHD_MISSING_CHANGE_TRACKING_INFORMATION _NDIS_ERROR_TYPEDEF_(0xC03A0030L)")]
    public const uint ERROR_VHD_MISSING_CHANGE_TRACKING_INFORMATION = (uint)(0xC03A0030);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_UNEXPECTED_ID"]/*' />
    [NativeTypeName("#define ERROR_VHD_UNEXPECTED_ID _NDIS_ERROR_TYPEDEF_(0xC03A0034L)")]
    public const uint ERROR_VHD_UNEXPECTED_ID = (uint)(0xC03A0034);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUERY_STORAGE_ERROR"]/*' />
    [NativeTypeName("#define ERROR_QUERY_STORAGE_ERROR _NDIS_ERROR_TYPEDEF_(0x803A0001L)")]
    public const uint ERROR_QUERY_STORAGE_ERROR = (uint)(0x803A0001);

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_POOL_WAS_DELETED"]/*' />
    [NativeTypeName("#define ERROR_SPACES_POOL_WAS_DELETED _HRESULT_TYPEDEF_(0x00E70001L)")]
    public const int ERROR_SPACES_POOL_WAS_DELETED = ((int)(0x00E70001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_FAULT_DOMAIN_TYPE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_FAULT_DOMAIN_TYPE_INVALID _HRESULT_TYPEDEF_(0x80E70001L)")]
    public const int ERROR_SPACES_FAULT_DOMAIN_TYPE_INVALID = unchecked((int)(0x80E70001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_SPACES_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80E70002L)")]
    public const int ERROR_SPACES_INTERNAL_ERROR = unchecked((int)(0x80E70002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_RESILIENCY_TYPE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_RESILIENCY_TYPE_INVALID _HRESULT_TYPEDEF_(0x80E70003L)")]
    public const int ERROR_SPACES_RESILIENCY_TYPE_INVALID = unchecked((int)(0x80E70003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_DRIVE_SECTOR_SIZE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_DRIVE_SECTOR_SIZE_INVALID _HRESULT_TYPEDEF_(0x80E70004L)")]
    public const int ERROR_SPACES_DRIVE_SECTOR_SIZE_INVALID = unchecked((int)(0x80E70004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_DRIVE_REDUNDANCY_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_DRIVE_REDUNDANCY_INVALID _HRESULT_TYPEDEF_(0x80E70006L)")]
    public const int ERROR_SPACES_DRIVE_REDUNDANCY_INVALID = unchecked((int)(0x80E70006));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_NUMBER_OF_DATA_COPIES_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_NUMBER_OF_DATA_COPIES_INVALID _HRESULT_TYPEDEF_(0x80E70007L)")]
    public const int ERROR_SPACES_NUMBER_OF_DATA_COPIES_INVALID = unchecked((int)(0x80E70007));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_PARITY_LAYOUT_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_PARITY_LAYOUT_INVALID _HRESULT_TYPEDEF_(0x80E70008L)")]
    public const int ERROR_SPACES_PARITY_LAYOUT_INVALID = unchecked((int)(0x80E70008));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_INTERLEAVE_LENGTH_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_INTERLEAVE_LENGTH_INVALID _HRESULT_TYPEDEF_(0x80E70009L)")]
    public const int ERROR_SPACES_INTERLEAVE_LENGTH_INVALID = unchecked((int)(0x80E70009));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_NUMBER_OF_COLUMNS_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_NUMBER_OF_COLUMNS_INVALID _HRESULT_TYPEDEF_(0x80E7000AL)")]
    public const int ERROR_SPACES_NUMBER_OF_COLUMNS_INVALID = unchecked((int)(0x80E7000A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_NOT_ENOUGH_DRIVES"]/*' />
    [NativeTypeName("#define ERROR_SPACES_NOT_ENOUGH_DRIVES _HRESULT_TYPEDEF_(0x80E7000BL)")]
    public const int ERROR_SPACES_NOT_ENOUGH_DRIVES = unchecked((int)(0x80E7000B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_EXTENDED_ERROR"]/*' />
    [NativeTypeName("#define ERROR_SPACES_EXTENDED_ERROR _HRESULT_TYPEDEF_(0x80E7000CL)")]
    public const int ERROR_SPACES_EXTENDED_ERROR = unchecked((int)(0x80E7000C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_PROVISIONING_TYPE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_PROVISIONING_TYPE_INVALID _HRESULT_TYPEDEF_(0x80E7000DL)")]
    public const int ERROR_SPACES_PROVISIONING_TYPE_INVALID = unchecked((int)(0x80E7000D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_ALLOCATION_SIZE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_ALLOCATION_SIZE_INVALID _HRESULT_TYPEDEF_(0x80E7000EL)")]
    public const int ERROR_SPACES_ALLOCATION_SIZE_INVALID = unchecked((int)(0x80E7000E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_ENCLOSURE_AWARE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_ENCLOSURE_AWARE_INVALID _HRESULT_TYPEDEF_(0x80E7000FL)")]
    public const int ERROR_SPACES_ENCLOSURE_AWARE_INVALID = unchecked((int)(0x80E7000F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_WRITE_CACHE_SIZE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_WRITE_CACHE_SIZE_INVALID _HRESULT_TYPEDEF_(0x80E70010L)")]
    public const int ERROR_SPACES_WRITE_CACHE_SIZE_INVALID = unchecked((int)(0x80E70010));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_NUMBER_OF_GROUPS_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_NUMBER_OF_GROUPS_INVALID _HRESULT_TYPEDEF_(0x80E70011L)")]
    public const int ERROR_SPACES_NUMBER_OF_GROUPS_INVALID = unchecked((int)(0x80E70011));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_DRIVE_OPERATIONAL_STATE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_DRIVE_OPERATIONAL_STATE_INVALID _HRESULT_TYPEDEF_(0x80E70012L)")]
    public const int ERROR_SPACES_DRIVE_OPERATIONAL_STATE_INVALID = unchecked((int)(0x80E70012));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_ENTRY_INCOMPLETE"]/*' />
    [NativeTypeName("#define ERROR_SPACES_ENTRY_INCOMPLETE _HRESULT_TYPEDEF_(0x80E70013L)")]
    public const int ERROR_SPACES_ENTRY_INCOMPLETE = unchecked((int)(0x80E70013));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_ENTRY_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_ENTRY_INVALID _HRESULT_TYPEDEF_(0x80E70014L)")]
    public const int ERROR_SPACES_ENTRY_INVALID = unchecked((int)(0x80E70014));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_UPDATE_COLUMN_STATE"]/*' />
    [NativeTypeName("#define ERROR_SPACES_UPDATE_COLUMN_STATE _HRESULT_TYPEDEF_(0x80E70015L)")]
    public const int ERROR_SPACES_UPDATE_COLUMN_STATE = unchecked((int)(0x80E70015));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_MAP_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_SPACES_MAP_REQUIRED _HRESULT_TYPEDEF_(0x80E70016L)")]
    public const int ERROR_SPACES_MAP_REQUIRED = unchecked((int)(0x80E70016));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_UNSUPPORTED_VERSION"]/*' />
    [NativeTypeName("#define ERROR_SPACES_UNSUPPORTED_VERSION _HRESULT_TYPEDEF_(0x80E70017L)")]
    public const int ERROR_SPACES_UNSUPPORTED_VERSION = unchecked((int)(0x80E70017));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_CORRUPT_METADATA"]/*' />
    [NativeTypeName("#define ERROR_SPACES_CORRUPT_METADATA _HRESULT_TYPEDEF_(0x80E70018L)")]
    public const int ERROR_SPACES_CORRUPT_METADATA = unchecked((int)(0x80E70018));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_DRT_FULL"]/*' />
    [NativeTypeName("#define ERROR_SPACES_DRT_FULL _HRESULT_TYPEDEF_(0x80E70019L)")]
    public const int ERROR_SPACES_DRT_FULL = unchecked((int)(0x80E70019));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_INCONSISTENCY"]/*' />
    [NativeTypeName("#define ERROR_SPACES_INCONSISTENCY _HRESULT_TYPEDEF_(0x80E7001AL)")]
    public const int ERROR_SPACES_INCONSISTENCY = unchecked((int)(0x80E7001A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_LOG_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_SPACES_LOG_NOT_READY _HRESULT_TYPEDEF_(0x80E7001BL)")]
    public const int ERROR_SPACES_LOG_NOT_READY = unchecked((int)(0x80E7001B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_NO_REDUNDANCY"]/*' />
    [NativeTypeName("#define ERROR_SPACES_NO_REDUNDANCY _HRESULT_TYPEDEF_(0x80E7001CL)")]
    public const int ERROR_SPACES_NO_REDUNDANCY = unchecked((int)(0x80E7001C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_DRIVE_NOT_READY"]/*' />
    [NativeTypeName("#define ERROR_SPACES_DRIVE_NOT_READY _HRESULT_TYPEDEF_(0x80E7001DL)")]
    public const int ERROR_SPACES_DRIVE_NOT_READY = unchecked((int)(0x80E7001D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_DRIVE_SPLIT"]/*' />
    [NativeTypeName("#define ERROR_SPACES_DRIVE_SPLIT _HRESULT_TYPEDEF_(0x80E7001EL)")]
    public const int ERROR_SPACES_DRIVE_SPLIT = unchecked((int)(0x80E7001E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_DRIVE_LOST_DATA"]/*' />
    [NativeTypeName("#define ERROR_SPACES_DRIVE_LOST_DATA _HRESULT_TYPEDEF_(0x80E7001FL)")]
    public const int ERROR_SPACES_DRIVE_LOST_DATA = unchecked((int)(0x80E7001F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_MARK_DIRTY"]/*' />
    [NativeTypeName("#define ERROR_SPACES_MARK_DIRTY _HRESULT_TYPEDEF_(0x80E70020L)")]
    public const int ERROR_SPACES_MARK_DIRTY = unchecked((int)(0x80E70020));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_FLUSH_METADATA"]/*' />
    [NativeTypeName("#define ERROR_SPACES_FLUSH_METADATA _HRESULT_TYPEDEF_(0x80E70025L)")]
    public const int ERROR_SPACES_FLUSH_METADATA = unchecked((int)(0x80E70025));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_CACHE_FULL"]/*' />
    [NativeTypeName("#define ERROR_SPACES_CACHE_FULL _HRESULT_TYPEDEF_(0x80E70026L)")]
    public const int ERROR_SPACES_CACHE_FULL = unchecked((int)(0x80E70026));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_REPAIR_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_SPACES_REPAIR_IN_PROGRESS _HRESULT_TYPEDEF_(0x80E70027L)")]
    public const int ERROR_SPACES_REPAIR_IN_PROGRESS = unchecked((int)(0x80E70027));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_API_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_SPACES_API_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x80E70028L)")]
    public const int ERROR_SPACES_API_VERSION_MISMATCH = unchecked((int)(0x80E70028));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SPACES_METADATA_SIZE_INVALID"]/*' />
    [NativeTypeName("#define ERROR_SPACES_METADATA_SIZE_INVALID _HRESULT_TYPEDEF_(0x80E70029L)")]
    public const int ERROR_SPACES_METADATA_SIZE_INVALID = unchecked((int)(0x80E70029));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLSNAP_BOOTFILE_NOT_VALID"]/*' />
    [NativeTypeName("#define ERROR_VOLSNAP_BOOTFILE_NOT_VALID _HRESULT_TYPEDEF_(0x80820001L)")]
    public const int ERROR_VOLSNAP_BOOTFILE_NOT_VALID = unchecked((int)(0x80820001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLSNAP_ACTIVATION_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_VOLSNAP_ACTIVATION_TIMEOUT _HRESULT_TYPEDEF_(0x80820002L)")]
    public const int ERROR_VOLSNAP_ACTIVATION_TIMEOUT = unchecked((int)(0x80820002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VOLSNAP_NO_BYPASSIO_WITH_SNAPSHOT"]/*' />
    [NativeTypeName("#define ERROR_VOLSNAP_NO_BYPASSIO_WITH_SNAPSHOT _HRESULT_TYPEDEF_(0x80820003L)")]
    public const int ERROR_VOLSNAP_NO_BYPASSIO_WITH_SNAPSHOT = unchecked((int)(0x80820003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIERING_NOT_SUPPORTED_ON_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_TIERING_NOT_SUPPORTED_ON_VOLUME _HRESULT_TYPEDEF_(0x80830001L)")]
    public const int ERROR_TIERING_NOT_SUPPORTED_ON_VOLUME = unchecked((int)(0x80830001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIERING_VOLUME_DISMOUNT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define ERROR_TIERING_VOLUME_DISMOUNT_IN_PROGRESS _HRESULT_TYPEDEF_(0x80830002L)")]
    public const int ERROR_TIERING_VOLUME_DISMOUNT_IN_PROGRESS = unchecked((int)(0x80830002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIERING_STORAGE_TIER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_TIERING_STORAGE_TIER_NOT_FOUND _HRESULT_TYPEDEF_(0x80830003L)")]
    public const int ERROR_TIERING_STORAGE_TIER_NOT_FOUND = unchecked((int)(0x80830003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIERING_INVALID_FILE_ID"]/*' />
    [NativeTypeName("#define ERROR_TIERING_INVALID_FILE_ID _HRESULT_TYPEDEF_(0x80830004L)")]
    public const int ERROR_TIERING_INVALID_FILE_ID = unchecked((int)(0x80830004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIERING_WRONG_CLUSTER_NODE"]/*' />
    [NativeTypeName("#define ERROR_TIERING_WRONG_CLUSTER_NODE _HRESULT_TYPEDEF_(0x80830005L)")]
    public const int ERROR_TIERING_WRONG_CLUSTER_NODE = unchecked((int)(0x80830005));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIERING_ALREADY_PROCESSING"]/*' />
    [NativeTypeName("#define ERROR_TIERING_ALREADY_PROCESSING _HRESULT_TYPEDEF_(0x80830006L)")]
    public const int ERROR_TIERING_ALREADY_PROCESSING = unchecked((int)(0x80830006));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIERING_CANNOT_PIN_OBJECT"]/*' />
    [NativeTypeName("#define ERROR_TIERING_CANNOT_PIN_OBJECT _HRESULT_TYPEDEF_(0x80830007L)")]
    public const int ERROR_TIERING_CANNOT_PIN_OBJECT = unchecked((int)(0x80830007));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_TIERING_FILE_IS_NOT_PINNED"]/*' />
    [NativeTypeName("#define ERROR_TIERING_FILE_IS_NOT_PINNED _HRESULT_TYPEDEF_(0x80830008L)")]
    public const int ERROR_TIERING_FILE_IS_NOT_PINNED = unchecked((int)(0x80830008));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NOT_A_TIERED_VOLUME"]/*' />
    [NativeTypeName("#define ERROR_NOT_A_TIERED_VOLUME _HRESULT_TYPEDEF_(0x80830009L)")]
    public const int ERROR_NOT_A_TIERED_VOLUME = unchecked((int)(0x80830009));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ATTRIBUTE_NOT_PRESENT"]/*' />
    [NativeTypeName("#define ERROR_ATTRIBUTE_NOT_PRESENT _HRESULT_TYPEDEF_(0x8083000AL)")]
    public const int ERROR_ATTRIBUTE_NOT_PRESENT = unchecked((int)(0x8083000A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SECCORE_INVALID_COMMAND"]/*' />
    [NativeTypeName("#define ERROR_SECCORE_INVALID_COMMAND _HRESULT_TYPEDEF_(0xC0E80000L)")]
    public const int ERROR_SECCORE_INVALID_COMMAND = unchecked((int)(0xC0E80000));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_NO_APPLICABLE_APP_LICENSES_FOUND"]/*' />
    [NativeTypeName("#define ERROR_NO_APPLICABLE_APP_LICENSES_FOUND _HRESULT_TYPEDEF_(0xC0EA0001L)")]
    public const int ERROR_NO_APPLICABLE_APP_LICENSES_FOUND = unchecked((int)(0xC0EA0001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_LICENSE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_CLIP_LICENSE_NOT_FOUND _HRESULT_TYPEDEF_(0xC0EA0002L)")]
    public const int ERROR_CLIP_LICENSE_NOT_FOUND = unchecked((int)(0xC0EA0002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_DEVICE_LICENSE_MISSING"]/*' />
    [NativeTypeName("#define ERROR_CLIP_DEVICE_LICENSE_MISSING _HRESULT_TYPEDEF_(0xC0EA0003L)")]
    public const int ERROR_CLIP_DEVICE_LICENSE_MISSING = unchecked((int)(0xC0EA0003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_LICENSE_INVALID_SIGNATURE"]/*' />
    [NativeTypeName("#define ERROR_CLIP_LICENSE_INVALID_SIGNATURE _HRESULT_TYPEDEF_(0xC0EA0004L)")]
    public const int ERROR_CLIP_LICENSE_INVALID_SIGNATURE = unchecked((int)(0xC0EA0004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID"]/*' />
    [NativeTypeName("#define ERROR_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID _HRESULT_TYPEDEF_(0xC0EA0005L)")]
    public const int ERROR_CLIP_KEYHOLDER_LICENSE_MISSING_OR_INVALID = unchecked((int)(0xC0EA0005));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_LICENSE_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_CLIP_LICENSE_EXPIRED _HRESULT_TYPEDEF_(0xC0EA0006L)")]
    public const int ERROR_CLIP_LICENSE_EXPIRED = unchecked((int)(0xC0EA0006));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE"]/*' />
    [NativeTypeName("#define ERROR_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE _HRESULT_TYPEDEF_(0xC0EA0007L)")]
    public const int ERROR_CLIP_LICENSE_SIGNED_BY_UNKNOWN_SOURCE = unchecked((int)(0xC0EA0007));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_LICENSE_NOT_SIGNED"]/*' />
    [NativeTypeName("#define ERROR_CLIP_LICENSE_NOT_SIGNED _HRESULT_TYPEDEF_(0xC0EA0008L)")]
    public const int ERROR_CLIP_LICENSE_NOT_SIGNED = unchecked((int)(0xC0EA0008));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE"]/*' />
    [NativeTypeName("#define ERROR_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE _HRESULT_TYPEDEF_(0xC0EA0009L)")]
    public const int ERROR_CLIP_LICENSE_HARDWARE_ID_OUT_OF_TOLERANCE = unchecked((int)(0xC0EA0009));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_CLIP_LICENSE_DEVICE_ID_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_CLIP_LICENSE_DEVICE_ID_MISMATCH _HRESULT_TYPEDEF_(0xC0EA000AL)")]
    public const int ERROR_CLIP_LICENSE_DEVICE_ID_MISMATCH = unchecked((int)(0xC0EA000A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_CREATE_PROCESS_FAILURE_LOCKDOWN"]/*' />
    [NativeTypeName("#define ERROR_DBG_CREATE_PROCESS_FAILURE_LOCKDOWN _HRESULT_TYPEDEF_(0x80B00001L)")]
    public const int ERROR_DBG_CREATE_PROCESS_FAILURE_LOCKDOWN = unchecked((int)(0x80B00001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_ATTACH_PROCESS_FAILURE_LOCKDOWN"]/*' />
    [NativeTypeName("#define ERROR_DBG_ATTACH_PROCESS_FAILURE_LOCKDOWN _HRESULT_TYPEDEF_(0x80B00002L)")]
    public const int ERROR_DBG_ATTACH_PROCESS_FAILURE_LOCKDOWN = unchecked((int)(0x80B00002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_CONNECT_SERVER_FAILURE_LOCKDOWN"]/*' />
    [NativeTypeName("#define ERROR_DBG_CONNECT_SERVER_FAILURE_LOCKDOWN _HRESULT_TYPEDEF_(0x80B00003L)")]
    public const int ERROR_DBG_CONNECT_SERVER_FAILURE_LOCKDOWN = unchecked((int)(0x80B00003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_DBG_START_SERVER_FAILURE_LOCKDOWN"]/*' />
    [NativeTypeName("#define ERROR_DBG_START_SERVER_FAILURE_LOCKDOWN _HRESULT_TYPEDEF_(0x80B00004L)")]
    public const int ERROR_DBG_START_SERVER_FAILURE_LOCKDOWN = unchecked((int)(0x80B00004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_IO_PREEMPTED"]/*' />
    [NativeTypeName("#define ERROR_IO_PREEMPTED _HRESULT_TYPEDEF_(0x89010001L)")]
    public const int ERROR_IO_PREEMPTED = unchecked((int)(0x89010001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_ERROR_STORED"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_ERROR_STORED _HRESULT_TYPEDEF_(0xC05C0000L)")]
    public const int ERROR_SVHDX_ERROR_STORED = unchecked((int)(0xC05C0000));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_ERROR_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_ERROR_NOT_AVAILABLE _HRESULT_TYPEDEF_(0xC05CFF00L)")]
    public const int ERROR_SVHDX_ERROR_NOT_AVAILABLE = unchecked((int)(0xC05CFF00));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_UNIT_ATTENTION_AVAILABLE"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_UNIT_ATTENTION_AVAILABLE _HRESULT_TYPEDEF_(0xC05CFF01L)")]
    public const int ERROR_SVHDX_UNIT_ATTENTION_AVAILABLE = unchecked((int)(0xC05CFF01));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED _HRESULT_TYPEDEF_(0xC05CFF02L)")]
    public const int ERROR_SVHDX_UNIT_ATTENTION_CAPACITY_DATA_CHANGED = unchecked((int)(0xC05CFF02));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED _HRESULT_TYPEDEF_(0xC05CFF03L)")]
    public const int ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_PREEMPTED = unchecked((int)(0xC05CFF03));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED _HRESULT_TYPEDEF_(0xC05CFF04L)")]
    public const int ERROR_SVHDX_UNIT_ATTENTION_RESERVATIONS_RELEASED = unchecked((int)(0xC05CFF04));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED _HRESULT_TYPEDEF_(0xC05CFF05L)")]
    public const int ERROR_SVHDX_UNIT_ATTENTION_REGISTRATIONS_PREEMPTED = unchecked((int)(0xC05CFF05));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED _HRESULT_TYPEDEF_(0xC05CFF06L)")]
    public const int ERROR_SVHDX_UNIT_ATTENTION_OPERATING_DEFINITION_CHANGED = unchecked((int)(0xC05CFF06));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_RESERVATION_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_RESERVATION_CONFLICT _HRESULT_TYPEDEF_(0xC05CFF07L)")]
    public const int ERROR_SVHDX_RESERVATION_CONFLICT = unchecked((int)(0xC05CFF07));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_WRONG_FILE_TYPE"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_WRONG_FILE_TYPE _HRESULT_TYPEDEF_(0xC05CFF08L)")]
    public const int ERROR_SVHDX_WRONG_FILE_TYPE = unchecked((int)(0xC05CFF08));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_VERSION_MISMATCH _HRESULT_TYPEDEF_(0xC05CFF09L)")]
    public const int ERROR_SVHDX_VERSION_MISMATCH = unchecked((int)(0xC05CFF09));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHD_SHARED"]/*' />
    [NativeTypeName("#define ERROR_VHD_SHARED _HRESULT_TYPEDEF_(0xC05CFF0AL)")]
    public const int ERROR_VHD_SHARED = unchecked((int)(0xC05CFF0A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SVHDX_NO_INITIATOR"]/*' />
    [NativeTypeName("#define ERROR_SVHDX_NO_INITIATOR _HRESULT_TYPEDEF_(0xC05CFF0BL)")]
    public const int ERROR_SVHDX_NO_INITIATOR = unchecked((int)(0xC05CFF0B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_VHDSET_BACKING_STORAGE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_VHDSET_BACKING_STORAGE_NOT_FOUND _HRESULT_TYPEDEF_(0xC05CFF0CL)")]
    public const int ERROR_VHDSET_BACKING_STORAGE_NOT_FOUND = unchecked((int)(0xC05CFF0C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP"]/*' />
    [NativeTypeName("#define ERROR_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP _HRESULT_TYPEDEF_(0xC05D0000L)")]
    public const int ERROR_SMB_NO_PREAUTH_INTEGRITY_HASH_OVERLAP = unchecked((int)(0xC05D0000));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_BAD_CLUSTER_DIALECT"]/*' />
    [NativeTypeName("#define ERROR_SMB_BAD_CLUSTER_DIALECT _HRESULT_TYPEDEF_(0xC05D0001L)")]
    public const int ERROR_SMB_BAD_CLUSTER_DIALECT = unchecked((int)(0xC05D0001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_NO_SIGNING_ALGORITHM_OVERLAP"]/*' />
    [NativeTypeName("#define ERROR_SMB_NO_SIGNING_ALGORITHM_OVERLAP _HRESULT_TYPEDEF_(0xC05D0002L)")]
    public const int ERROR_SMB_NO_SIGNING_ALGORITHM_OVERLAP = unchecked((int)(0xC05D0002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_GUEST_LOGON_BLOCKED_SIGNING_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_SMB_GUEST_LOGON_BLOCKED_SIGNING_REQUIRED _HRESULT_TYPEDEF_(0xC05D0003L)")]
    public const int ERROR_SMB_GUEST_LOGON_BLOCKED_SIGNING_REQUIRED = unchecked((int)(0xC05D0003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_GUEST_ENCRYPTION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define ERROR_SMB_GUEST_ENCRYPTION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC05D0004L)")]
    public const int ERROR_SMB_GUEST_ENCRYPTION_NOT_SUPPORTED = unchecked((int)(0xC05D0004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_ENCRYPTION_NOT_SUPPORTED_BY_PEER"]/*' />
    [NativeTypeName("#define ERROR_SMB_ENCRYPTION_NOT_SUPPORTED_BY_PEER _HRESULT_TYPEDEF_(0xC05D0005L)")]
    public const int ERROR_SMB_ENCRYPTION_NOT_SUPPORTED_BY_PEER = unchecked((int)(0xC05D0005));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_CERT_NO_PRIVATE_KEY"]/*' />
    [NativeTypeName("#define ERROR_SMB_CERT_NO_PRIVATE_KEY _HRESULT_TYPEDEF_(0xC05D0006L)")]
    public const int ERROR_SMB_CERT_NO_PRIVATE_KEY = unchecked((int)(0xC05D0006));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_TLS_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_SMB_TLS_ACCESS_DENIED _HRESULT_TYPEDEF_(0xC05D0007L)")]
    public const int ERROR_SMB_TLS_ACCESS_DENIED = unchecked((int)(0xC05D0007));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_SMB_ALTERNATIVE_PORT_CONFLICT"]/*' />
    [NativeTypeName("#define ERROR_SMB_ALTERNATIVE_PORT_CONFLICT _HRESULT_TYPEDEF_(0xC05D000BL)")]
    public const int ERROR_SMB_ALTERNATIVE_PORT_CONFLICT = unchecked((int)(0xC05D000B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_HANDSHAKE_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_QUIC_HANDSHAKE_FAILURE _HRESULT_TYPEDEF_(0x80410000L)")]
    public const int ERROR_QUIC_HANDSHAKE_FAILURE = unchecked((int)(0x80410000));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_VER_NEG_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_QUIC_VER_NEG_FAILURE _HRESULT_TYPEDEF_(0x80410001L)")]
    public const int ERROR_QUIC_VER_NEG_FAILURE = unchecked((int)(0x80410001));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_USER_CANCELED"]/*' />
    [NativeTypeName("#define ERROR_QUIC_USER_CANCELED _HRESULT_TYPEDEF_(0x80410002L)")]
    public const int ERROR_QUIC_USER_CANCELED = unchecked((int)(0x80410002));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_QUIC_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80410003L)")]
    public const int ERROR_QUIC_INTERNAL_ERROR = unchecked((int)(0x80410003));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_PROTOCOL_VIOLATION"]/*' />
    [NativeTypeName("#define ERROR_QUIC_PROTOCOL_VIOLATION _HRESULT_TYPEDEF_(0x80410004L)")]
    public const int ERROR_QUIC_PROTOCOL_VIOLATION = unchecked((int)(0x80410004));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_CONNECTION_IDLE"]/*' />
    [NativeTypeName("#define ERROR_QUIC_CONNECTION_IDLE _HRESULT_TYPEDEF_(0x80410005L)")]
    public const int ERROR_QUIC_CONNECTION_IDLE = unchecked((int)(0x80410005));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_CONNECTION_TIMEOUT"]/*' />
    [NativeTypeName("#define ERROR_QUIC_CONNECTION_TIMEOUT _HRESULT_TYPEDEF_(0x80410006L)")]
    public const int ERROR_QUIC_CONNECTION_TIMEOUT = unchecked((int)(0x80410006));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_ALPN_NEG_FAILURE"]/*' />
    [NativeTypeName("#define ERROR_QUIC_ALPN_NEG_FAILURE _HRESULT_TYPEDEF_(0x80410007L)")]
    public const int ERROR_QUIC_ALPN_NEG_FAILURE = unchecked((int)(0x80410007));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_STREAM_LIMIT_REACHED"]/*' />
    [NativeTypeName("#define ERROR_QUIC_STREAM_LIMIT_REACHED _HRESULT_TYPEDEF_(0x80410008L)")]
    public const int ERROR_QUIC_STREAM_LIMIT_REACHED = unchecked((int)(0x80410008));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_ALPN_IN_USE"]/*' />
    [NativeTypeName("#define ERROR_QUIC_ALPN_IN_USE _HRESULT_TYPEDEF_(0x80410009L)")]
    public const int ERROR_QUIC_ALPN_IN_USE = unchecked((int)(0x80410009));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_UNEXPECTED_MESSAGE"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_UNEXPECTED_MESSAGE _HRESULT_TYPEDEF_(0x8041010AL)")]
    public const int ERROR_QUIC_TLS_UNEXPECTED_MESSAGE = unchecked((int)(0x8041010A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_BAD_CERTIFICATE"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_BAD_CERTIFICATE _HRESULT_TYPEDEF_(0x8041012AL)")]
    public const int ERROR_QUIC_TLS_BAD_CERTIFICATE = unchecked((int)(0x8041012A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_UNSUPPORTED_CERTIFICATE"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_UNSUPPORTED_CERTIFICATE _HRESULT_TYPEDEF_(0x8041012BL)")]
    public const int ERROR_QUIC_TLS_UNSUPPORTED_CERTIFICATE = unchecked((int)(0x8041012B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_CERTIFICATE_REVOKED"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_CERTIFICATE_REVOKED _HRESULT_TYPEDEF_(0x8041012CL)")]
    public const int ERROR_QUIC_TLS_CERTIFICATE_REVOKED = unchecked((int)(0x8041012C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_CERTIFICATE_EXPIRED"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_CERTIFICATE_EXPIRED _HRESULT_TYPEDEF_(0x8041012DL)")]
    public const int ERROR_QUIC_TLS_CERTIFICATE_EXPIRED = unchecked((int)(0x8041012D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_CERTIFICATE_UNKNOWN"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_CERTIFICATE_UNKNOWN _HRESULT_TYPEDEF_(0x8041012EL)")]
    public const int ERROR_QUIC_TLS_CERTIFICATE_UNKNOWN = unchecked((int)(0x8041012E));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_ILLEGAL_PARAMETER"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_ILLEGAL_PARAMETER _HRESULT_TYPEDEF_(0x8041012FL)")]
    public const int ERROR_QUIC_TLS_ILLEGAL_PARAMETER = unchecked((int)(0x8041012F));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_UNKNOWN_CA"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_UNKNOWN_CA _HRESULT_TYPEDEF_(0x80410130L)")]
    public const int ERROR_QUIC_TLS_UNKNOWN_CA = unchecked((int)(0x80410130));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_ACCESS_DENIED _HRESULT_TYPEDEF_(0x80410131L)")]
    public const int ERROR_QUIC_TLS_ACCESS_DENIED = unchecked((int)(0x80410131));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_INSUFFICIENT_SECURITY"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_INSUFFICIENT_SECURITY _HRESULT_TYPEDEF_(0x80410147L)")]
    public const int ERROR_QUIC_TLS_INSUFFICIENT_SECURITY = unchecked((int)(0x80410147));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80410150L)")]
    public const int ERROR_QUIC_TLS_INTERNAL_ERROR = unchecked((int)(0x80410150));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_USER_CANCELED"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_USER_CANCELED _HRESULT_TYPEDEF_(0x8041015AL)")]
    public const int ERROR_QUIC_TLS_USER_CANCELED = unchecked((int)(0x8041015A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_QUIC_TLS_CERTIFICATE_REQUIRED"]/*' />
    [NativeTypeName("#define ERROR_QUIC_TLS_CERTIFICATE_REQUIRED _HRESULT_TYPEDEF_(0x80410174L)")]
    public const int ERROR_QUIC_TLS_CERTIFICATE_REQUIRED = unchecked((int)(0x80410174));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_HANDLER_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PRM_HANDLER_NOT_FOUND _HRESULT_TYPEDEF_(0xC9260200L)")]
    public const int ERROR_PRM_HANDLER_NOT_FOUND = unchecked((int)(0xC9260200));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_CONCURRENT_OPERATION"]/*' />
    [NativeTypeName("#define ERROR_PRM_CONCURRENT_OPERATION _HRESULT_TYPEDEF_(0xC9260202L)")]
    public const int ERROR_PRM_CONCURRENT_OPERATION = unchecked((int)(0xC9260202));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_MODULE_UPDATE_PENDING"]/*' />
    [NativeTypeName("#define ERROR_PRM_MODULE_UPDATE_PENDING _HRESULT_TYPEDEF_(0xC9260203L)")]
    public const int ERROR_PRM_MODULE_UPDATE_PENDING = unchecked((int)(0xC9260203));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_MODULE_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_PRM_MODULE_LOCKED _HRESULT_TYPEDEF_(0xC9260204L)")]
    public const int ERROR_PRM_MODULE_LOCKED = unchecked((int)(0xC9260204));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_UPDATE_INCOMPATIBLE_VERSION"]/*' />
    [NativeTypeName("#define ERROR_PRM_UPDATE_INCOMPATIBLE_VERSION _HRESULT_TYPEDEF_(0xC9260205L)")]
    public const int ERROR_PRM_UPDATE_INCOMPATIBLE_VERSION = unchecked((int)(0xC9260205));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_UPDATE_MODULE_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_PRM_UPDATE_MODULE_MISMATCH _HRESULT_TYPEDEF_(0xC9260206L)")]
    public const int ERROR_PRM_UPDATE_MODULE_MISMATCH = unchecked((int)(0xC9260206));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_UPDATE_MODULE_NOT_FOUND"]/*' />
    [NativeTypeName("#define ERROR_PRM_UPDATE_MODULE_NOT_FOUND _HRESULT_TYPEDEF_(0xC9260207L)")]
    public const int ERROR_PRM_UPDATE_MODULE_NOT_FOUND = unchecked((int)(0xC9260207));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_UPDATE_MISSING_EXPORT"]/*' />
    [NativeTypeName("#define ERROR_PRM_UPDATE_MISSING_EXPORT _HRESULT_TYPEDEF_(0xC9260208L)")]
    public const int ERROR_PRM_UPDATE_MISSING_EXPORT = unchecked((int)(0xC9260208));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_UPDATE_MODULE_LOCKED"]/*' />
    [NativeTypeName("#define ERROR_PRM_UPDATE_MODULE_LOCKED _HRESULT_TYPEDEF_(0xC9260209L)")]
    public const int ERROR_PRM_UPDATE_MODULE_LOCKED = unchecked((int)(0xC9260209));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_UPDATE_BAD_SIGNATURE"]/*' />
    [NativeTypeName("#define ERROR_PRM_UPDATE_BAD_SIGNATURE _HRESULT_TYPEDEF_(0xC926020AL)")]
    public const int ERROR_PRM_UPDATE_BAD_SIGNATURE = unchecked((int)(0xC926020A));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_UPDATE_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define ERROR_PRM_UPDATE_VERSION_MISMATCH _HRESULT_TYPEDEF_(0xC926020BL)")]
    public const int ERROR_PRM_UPDATE_VERSION_MISMATCH = unchecked((int)(0xC926020B));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_MODULE_UNLOCKED"]/*' />
    [NativeTypeName("#define ERROR_PRM_MODULE_UNLOCKED _HRESULT_TYPEDEF_(0xC926020CL)")]
    public const int ERROR_PRM_MODULE_UNLOCKED = unchecked((int)(0xC926020C));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_PRM_INTERFACE_INACCESSIBLE"]/*' />
    [NativeTypeName("#define ERROR_PRM_INTERFACE_INACCESSIBLE _HRESULT_TYPEDEF_(0xC926020DL)")]
    public const int ERROR_PRM_INTERFACE_INACCESSIBLE = unchecked((int)(0xC926020D));

    /// <include file='ERROR.xml' path='doc/member[@name="ERROR.ERROR_ACCELERATOR_SUBMISSION_QUEUE_FULL"]/*' />
    [NativeTypeName("#define ERROR_ACCELERATOR_SUBMISSION_QUEUE_FULL _HRESULT_TYPEDEF_(0xC9270000L)")]
    public const int ERROR_ACCELERATOR_SUBMISSION_QUEUE_FULL = unchecked((int)(0xC9270000));
}
