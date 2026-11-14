// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SQLITE
{
    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_ERROR"]/*' />
    [NativeTypeName("#define SQLITE_E_ERROR _HRESULT_TYPEDEF_(0x87AF0001L)")]
    public const int SQLITE_E_ERROR = unchecked((int)(0x87AF0001));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_INTERNAL"]/*' />
    [NativeTypeName("#define SQLITE_E_INTERNAL _HRESULT_TYPEDEF_(0x87AF0002L)")]
    public const int SQLITE_E_INTERNAL = unchecked((int)(0x87AF0002));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_PERM"]/*' />
    [NativeTypeName("#define SQLITE_E_PERM _HRESULT_TYPEDEF_(0x87AF0003L)")]
    public const int SQLITE_E_PERM = unchecked((int)(0x87AF0003));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_ABORT"]/*' />
    [NativeTypeName("#define SQLITE_E_ABORT _HRESULT_TYPEDEF_(0x87AF0004L)")]
    public const int SQLITE_E_ABORT = unchecked((int)(0x87AF0004));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_BUSY"]/*' />
    [NativeTypeName("#define SQLITE_E_BUSY _HRESULT_TYPEDEF_(0x87AF0005L)")]
    public const int SQLITE_E_BUSY = unchecked((int)(0x87AF0005));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_LOCKED"]/*' />
    [NativeTypeName("#define SQLITE_E_LOCKED _HRESULT_TYPEDEF_(0x87AF0006L)")]
    public const int SQLITE_E_LOCKED = unchecked((int)(0x87AF0006));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_NOMEM"]/*' />
    [NativeTypeName("#define SQLITE_E_NOMEM _HRESULT_TYPEDEF_(0x87AF0007L)")]
    public const int SQLITE_E_NOMEM = unchecked((int)(0x87AF0007));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_READONLY"]/*' />
    [NativeTypeName("#define SQLITE_E_READONLY _HRESULT_TYPEDEF_(0x87AF0008L)")]
    public const int SQLITE_E_READONLY = unchecked((int)(0x87AF0008));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_INTERRUPT"]/*' />
    [NativeTypeName("#define SQLITE_E_INTERRUPT _HRESULT_TYPEDEF_(0x87AF0009L)")]
    public const int SQLITE_E_INTERRUPT = unchecked((int)(0x87AF0009));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR _HRESULT_TYPEDEF_(0x87AF000AL)")]
    public const int SQLITE_E_IOERR = unchecked((int)(0x87AF000A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CORRUPT"]/*' />
    [NativeTypeName("#define SQLITE_E_CORRUPT _HRESULT_TYPEDEF_(0x87AF000BL)")]
    public const int SQLITE_E_CORRUPT = unchecked((int)(0x87AF000B));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_NOTFOUND"]/*' />
    [NativeTypeName("#define SQLITE_E_NOTFOUND _HRESULT_TYPEDEF_(0x87AF000CL)")]
    public const int SQLITE_E_NOTFOUND = unchecked((int)(0x87AF000C));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_FULL"]/*' />
    [NativeTypeName("#define SQLITE_E_FULL _HRESULT_TYPEDEF_(0x87AF000DL)")]
    public const int SQLITE_E_FULL = unchecked((int)(0x87AF000D));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CANTOPEN"]/*' />
    [NativeTypeName("#define SQLITE_E_CANTOPEN _HRESULT_TYPEDEF_(0x87AF000EL)")]
    public const int SQLITE_E_CANTOPEN = unchecked((int)(0x87AF000E));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_PROTOCOL"]/*' />
    [NativeTypeName("#define SQLITE_E_PROTOCOL _HRESULT_TYPEDEF_(0x87AF000FL)")]
    public const int SQLITE_E_PROTOCOL = unchecked((int)(0x87AF000F));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_EMPTY"]/*' />
    [NativeTypeName("#define SQLITE_E_EMPTY _HRESULT_TYPEDEF_(0x87AF0010L)")]
    public const int SQLITE_E_EMPTY = unchecked((int)(0x87AF0010));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_SCHEMA"]/*' />
    [NativeTypeName("#define SQLITE_E_SCHEMA _HRESULT_TYPEDEF_(0x87AF0011L)")]
    public const int SQLITE_E_SCHEMA = unchecked((int)(0x87AF0011));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_TOOBIG"]/*' />
    [NativeTypeName("#define SQLITE_E_TOOBIG _HRESULT_TYPEDEF_(0x87AF0012L)")]
    public const int SQLITE_E_TOOBIG = unchecked((int)(0x87AF0012));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT _HRESULT_TYPEDEF_(0x87AF0013L)")]
    public const int SQLITE_E_CONSTRAINT = unchecked((int)(0x87AF0013));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_MISMATCH"]/*' />
    [NativeTypeName("#define SQLITE_E_MISMATCH _HRESULT_TYPEDEF_(0x87AF0014L)")]
    public const int SQLITE_E_MISMATCH = unchecked((int)(0x87AF0014));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_MISUSE"]/*' />
    [NativeTypeName("#define SQLITE_E_MISUSE _HRESULT_TYPEDEF_(0x87AF0015L)")]
    public const int SQLITE_E_MISUSE = unchecked((int)(0x87AF0015));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_NOLFS"]/*' />
    [NativeTypeName("#define SQLITE_E_NOLFS _HRESULT_TYPEDEF_(0x87AF0016L)")]
    public const int SQLITE_E_NOLFS = unchecked((int)(0x87AF0016));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_AUTH"]/*' />
    [NativeTypeName("#define SQLITE_E_AUTH _HRESULT_TYPEDEF_(0x87AF0017L)")]
    public const int SQLITE_E_AUTH = unchecked((int)(0x87AF0017));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_FORMAT"]/*' />
    [NativeTypeName("#define SQLITE_E_FORMAT _HRESULT_TYPEDEF_(0x87AF0018L)")]
    public const int SQLITE_E_FORMAT = unchecked((int)(0x87AF0018));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_RANGE"]/*' />
    [NativeTypeName("#define SQLITE_E_RANGE _HRESULT_TYPEDEF_(0x87AF0019L)")]
    public const int SQLITE_E_RANGE = unchecked((int)(0x87AF0019));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_NOTADB"]/*' />
    [NativeTypeName("#define SQLITE_E_NOTADB _HRESULT_TYPEDEF_(0x87AF001AL)")]
    public const int SQLITE_E_NOTADB = unchecked((int)(0x87AF001A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_NOTICE"]/*' />
    [NativeTypeName("#define SQLITE_E_NOTICE _HRESULT_TYPEDEF_(0x87AF001BL)")]
    public const int SQLITE_E_NOTICE = unchecked((int)(0x87AF001B));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_WARNING"]/*' />
    [NativeTypeName("#define SQLITE_E_WARNING _HRESULT_TYPEDEF_(0x87AF001CL)")]
    public const int SQLITE_E_WARNING = unchecked((int)(0x87AF001C));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_ROW"]/*' />
    [NativeTypeName("#define SQLITE_E_ROW _HRESULT_TYPEDEF_(0x87AF0064L)")]
    public const int SQLITE_E_ROW = unchecked((int)(0x87AF0064));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_DONE"]/*' />
    [NativeTypeName("#define SQLITE_E_DONE _HRESULT_TYPEDEF_(0x87AF0065L)")]
    public const int SQLITE_E_DONE = unchecked((int)(0x87AF0065));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_READ"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_READ _HRESULT_TYPEDEF_(0x87AF010AL)")]
    public const int SQLITE_E_IOERR_READ = unchecked((int)(0x87AF010A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_SHORT_READ"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_SHORT_READ _HRESULT_TYPEDEF_(0x87AF020AL)")]
    public const int SQLITE_E_IOERR_SHORT_READ = unchecked((int)(0x87AF020A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_WRITE"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_WRITE _HRESULT_TYPEDEF_(0x87AF030AL)")]
    public const int SQLITE_E_IOERR_WRITE = unchecked((int)(0x87AF030A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_FSYNC"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_FSYNC _HRESULT_TYPEDEF_(0x87AF040AL)")]
    public const int SQLITE_E_IOERR_FSYNC = unchecked((int)(0x87AF040A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_DIR_FSYNC"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_DIR_FSYNC _HRESULT_TYPEDEF_(0x87AF050AL)")]
    public const int SQLITE_E_IOERR_DIR_FSYNC = unchecked((int)(0x87AF050A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_TRUNCATE"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_TRUNCATE _HRESULT_TYPEDEF_(0x87AF060AL)")]
    public const int SQLITE_E_IOERR_TRUNCATE = unchecked((int)(0x87AF060A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_FSTAT"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_FSTAT _HRESULT_TYPEDEF_(0x87AF070AL)")]
    public const int SQLITE_E_IOERR_FSTAT = unchecked((int)(0x87AF070A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_UNLOCK"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_UNLOCK _HRESULT_TYPEDEF_(0x87AF080AL)")]
    public const int SQLITE_E_IOERR_UNLOCK = unchecked((int)(0x87AF080A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_RDLOCK"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_RDLOCK _HRESULT_TYPEDEF_(0x87AF090AL)")]
    public const int SQLITE_E_IOERR_RDLOCK = unchecked((int)(0x87AF090A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_DELETE"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_DELETE _HRESULT_TYPEDEF_(0x87AF0A0AL)")]
    public const int SQLITE_E_IOERR_DELETE = unchecked((int)(0x87AF0A0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_BLOCKED"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_BLOCKED _HRESULT_TYPEDEF_(0x87AF0B0AL)")]
    public const int SQLITE_E_IOERR_BLOCKED = unchecked((int)(0x87AF0B0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_NOMEM"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_NOMEM _HRESULT_TYPEDEF_(0x87AF0C0AL)")]
    public const int SQLITE_E_IOERR_NOMEM = unchecked((int)(0x87AF0C0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_ACCESS"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_ACCESS _HRESULT_TYPEDEF_(0x87AF0D0AL)")]
    public const int SQLITE_E_IOERR_ACCESS = unchecked((int)(0x87AF0D0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_CHECKRESERVEDLOCK"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_CHECKRESERVEDLOCK _HRESULT_TYPEDEF_(0x87AF0E0AL)")]
    public const int SQLITE_E_IOERR_CHECKRESERVEDLOCK = unchecked((int)(0x87AF0E0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_LOCK"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_LOCK _HRESULT_TYPEDEF_(0x87AF0F0AL)")]
    public const int SQLITE_E_IOERR_LOCK = unchecked((int)(0x87AF0F0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_CLOSE"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_CLOSE _HRESULT_TYPEDEF_(0x87AF100AL)")]
    public const int SQLITE_E_IOERR_CLOSE = unchecked((int)(0x87AF100A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_DIR_CLOSE"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_DIR_CLOSE _HRESULT_TYPEDEF_(0x87AF110AL)")]
    public const int SQLITE_E_IOERR_DIR_CLOSE = unchecked((int)(0x87AF110A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_SHMOPEN"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_SHMOPEN _HRESULT_TYPEDEF_(0x87AF120AL)")]
    public const int SQLITE_E_IOERR_SHMOPEN = unchecked((int)(0x87AF120A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_SHMSIZE"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_SHMSIZE _HRESULT_TYPEDEF_(0x87AF130AL)")]
    public const int SQLITE_E_IOERR_SHMSIZE = unchecked((int)(0x87AF130A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_SHMLOCK"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_SHMLOCK _HRESULT_TYPEDEF_(0x87AF140AL)")]
    public const int SQLITE_E_IOERR_SHMLOCK = unchecked((int)(0x87AF140A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_SHMMAP"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_SHMMAP _HRESULT_TYPEDEF_(0x87AF150AL)")]
    public const int SQLITE_E_IOERR_SHMMAP = unchecked((int)(0x87AF150A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_SEEK"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_SEEK _HRESULT_TYPEDEF_(0x87AF160AL)")]
    public const int SQLITE_E_IOERR_SEEK = unchecked((int)(0x87AF160A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_DELETE_NOENT"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_DELETE_NOENT _HRESULT_TYPEDEF_(0x87AF170AL)")]
    public const int SQLITE_E_IOERR_DELETE_NOENT = unchecked((int)(0x87AF170A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_MMAP"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_MMAP _HRESULT_TYPEDEF_(0x87AF180AL)")]
    public const int SQLITE_E_IOERR_MMAP = unchecked((int)(0x87AF180A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_GETTEMPPATH"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_GETTEMPPATH _HRESULT_TYPEDEF_(0x87AF190AL)")]
    public const int SQLITE_E_IOERR_GETTEMPPATH = unchecked((int)(0x87AF190A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_CONVPATH"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_CONVPATH _HRESULT_TYPEDEF_(0x87AF1A0AL)")]
    public const int SQLITE_E_IOERR_CONVPATH = unchecked((int)(0x87AF1A0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_VNODE"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_VNODE _HRESULT_TYPEDEF_(0x87AF1B0AL)")]
    public const int SQLITE_E_IOERR_VNODE = unchecked((int)(0x87AF1B0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_AUTH"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_AUTH _HRESULT_TYPEDEF_(0x87AF1C0AL)")]
    public const int SQLITE_E_IOERR_AUTH = unchecked((int)(0x87AF1C0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_BEGIN_ATOMIC"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_BEGIN_ATOMIC _HRESULT_TYPEDEF_(0x87AF1D0AL)")]
    public const int SQLITE_E_IOERR_BEGIN_ATOMIC = unchecked((int)(0x87AF1D0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_COMMIT_ATOMIC"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_COMMIT_ATOMIC _HRESULT_TYPEDEF_(0x87AF1E0AL)")]
    public const int SQLITE_E_IOERR_COMMIT_ATOMIC = unchecked((int)(0x87AF1E0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_ROLLBACK_ATOMIC"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_ROLLBACK_ATOMIC _HRESULT_TYPEDEF_(0x87AF1F0AL)")]
    public const int SQLITE_E_IOERR_ROLLBACK_ATOMIC = unchecked((int)(0x87AF1F0A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_DATA"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_DATA _HRESULT_TYPEDEF_(0x87AF200AL)")]
    public const int SQLITE_E_IOERR_DATA = unchecked((int)(0x87AF200A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_CORRUPTFS"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_CORRUPTFS _HRESULT_TYPEDEF_(0x87AF210AL)")]
    public const int SQLITE_E_IOERR_CORRUPTFS = unchecked((int)(0x87AF210A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_IOERR_IN_PAGE"]/*' />
    [NativeTypeName("#define SQLITE_E_IOERR_IN_PAGE _HRESULT_TYPEDEF_(0x87AF220AL)")]
    public const int SQLITE_E_IOERR_IN_PAGE = unchecked((int)(0x87AF220A));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_LOCKED_SHAREDCACHE"]/*' />
    [NativeTypeName("#define SQLITE_E_LOCKED_SHAREDCACHE _HRESULT_TYPEDEF_(0x87AF0106L)")]
    public const int SQLITE_E_LOCKED_SHAREDCACHE = unchecked((int)(0x87AF0106));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_LOCKED_VTAB"]/*' />
    [NativeTypeName("#define SQLITE_E_LOCKED_VTAB _HRESULT_TYPEDEF_(0x87AF0206L)")]
    public const int SQLITE_E_LOCKED_VTAB = unchecked((int)(0x87AF0206));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_BUSY_RECOVERY"]/*' />
    [NativeTypeName("#define SQLITE_E_BUSY_RECOVERY _HRESULT_TYPEDEF_(0x87AF0105L)")]
    public const int SQLITE_E_BUSY_RECOVERY = unchecked((int)(0x87AF0105));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_BUSY_SNAPSHOT"]/*' />
    [NativeTypeName("#define SQLITE_E_BUSY_SNAPSHOT _HRESULT_TYPEDEF_(0x87AF0205L)")]
    public const int SQLITE_E_BUSY_SNAPSHOT = unchecked((int)(0x87AF0205));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_BUSY_TIMEOUT"]/*' />
    [NativeTypeName("#define SQLITE_E_BUSY_TIMEOUT _HRESULT_TYPEDEF_(0x87AF0305L)")]
    public const int SQLITE_E_BUSY_TIMEOUT = unchecked((int)(0x87AF0305));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CANTOPEN_NOTEMPDIR"]/*' />
    [NativeTypeName("#define SQLITE_E_CANTOPEN_NOTEMPDIR _HRESULT_TYPEDEF_(0x87AF010EL)")]
    public const int SQLITE_E_CANTOPEN_NOTEMPDIR = unchecked((int)(0x87AF010E));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CANTOPEN_ISDIR"]/*' />
    [NativeTypeName("#define SQLITE_E_CANTOPEN_ISDIR _HRESULT_TYPEDEF_(0x87AF020EL)")]
    public const int SQLITE_E_CANTOPEN_ISDIR = unchecked((int)(0x87AF020E));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CANTOPEN_FULLPATH"]/*' />
    [NativeTypeName("#define SQLITE_E_CANTOPEN_FULLPATH _HRESULT_TYPEDEF_(0x87AF030EL)")]
    public const int SQLITE_E_CANTOPEN_FULLPATH = unchecked((int)(0x87AF030E));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CANTOPEN_CONVPATH"]/*' />
    [NativeTypeName("#define SQLITE_E_CANTOPEN_CONVPATH _HRESULT_TYPEDEF_(0x87AF040EL)")]
    public const int SQLITE_E_CANTOPEN_CONVPATH = unchecked((int)(0x87AF040E));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CANTOPEN_DIRTYWAL"]/*' />
    [NativeTypeName("#define SQLITE_E_CANTOPEN_DIRTYWAL _HRESULT_TYPEDEF_(0x87AF050EL)")]
    public const int SQLITE_E_CANTOPEN_DIRTYWAL = unchecked((int)(0x87AF050E));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CANTOPEN_SYMLINK"]/*' />
    [NativeTypeName("#define SQLITE_E_CANTOPEN_SYMLINK _HRESULT_TYPEDEF_(0x87AF060EL)")]
    public const int SQLITE_E_CANTOPEN_SYMLINK = unchecked((int)(0x87AF060E));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CORRUPT_VTAB"]/*' />
    [NativeTypeName("#define SQLITE_E_CORRUPT_VTAB _HRESULT_TYPEDEF_(0x87AF010BL)")]
    public const int SQLITE_E_CORRUPT_VTAB = unchecked((int)(0x87AF010B));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CORRUPT_SEQUENCE"]/*' />
    [NativeTypeName("#define SQLITE_E_CORRUPT_SEQUENCE _HRESULT_TYPEDEF_(0x87AF020BL)")]
    public const int SQLITE_E_CORRUPT_SEQUENCE = unchecked((int)(0x87AF020B));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CORRUPT_INDEX"]/*' />
    [NativeTypeName("#define SQLITE_E_CORRUPT_INDEX _HRESULT_TYPEDEF_(0x87AF030BL)")]
    public const int SQLITE_E_CORRUPT_INDEX = unchecked((int)(0x87AF030B));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_READONLY_RECOVERY"]/*' />
    [NativeTypeName("#define SQLITE_E_READONLY_RECOVERY _HRESULT_TYPEDEF_(0x87AF0108L)")]
    public const int SQLITE_E_READONLY_RECOVERY = unchecked((int)(0x87AF0108));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_READONLY_CANTLOCK"]/*' />
    [NativeTypeName("#define SQLITE_E_READONLY_CANTLOCK _HRESULT_TYPEDEF_(0x87AF0208L)")]
    public const int SQLITE_E_READONLY_CANTLOCK = unchecked((int)(0x87AF0208));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_READONLY_ROLLBACK"]/*' />
    [NativeTypeName("#define SQLITE_E_READONLY_ROLLBACK _HRESULT_TYPEDEF_(0x87AF0308L)")]
    public const int SQLITE_E_READONLY_ROLLBACK = unchecked((int)(0x87AF0308));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_READONLY_DBMOVED"]/*' />
    [NativeTypeName("#define SQLITE_E_READONLY_DBMOVED _HRESULT_TYPEDEF_(0x87AF0408L)")]
    public const int SQLITE_E_READONLY_DBMOVED = unchecked((int)(0x87AF0408));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_READONLY_CANTINIT"]/*' />
    [NativeTypeName("#define SQLITE_E_READONLY_CANTINIT _HRESULT_TYPEDEF_(0x87AF0508L)")]
    public const int SQLITE_E_READONLY_CANTINIT = unchecked((int)(0x87AF0508));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_READONLY_DIRECTORY"]/*' />
    [NativeTypeName("#define SQLITE_E_READONLY_DIRECTORY _HRESULT_TYPEDEF_(0x87AF0608L)")]
    public const int SQLITE_E_READONLY_DIRECTORY = unchecked((int)(0x87AF0608));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_ABORT_ROLLBACK"]/*' />
    [NativeTypeName("#define SQLITE_E_ABORT_ROLLBACK _HRESULT_TYPEDEF_(0x87AF0204L)")]
    public const int SQLITE_E_ABORT_ROLLBACK = unchecked((int)(0x87AF0204));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_CHECK"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_CHECK _HRESULT_TYPEDEF_(0x87AF0113L)")]
    public const int SQLITE_E_CONSTRAINT_CHECK = unchecked((int)(0x87AF0113));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_COMMITHOOK"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_COMMITHOOK _HRESULT_TYPEDEF_(0x87AF0213L)")]
    public const int SQLITE_E_CONSTRAINT_COMMITHOOK = unchecked((int)(0x87AF0213));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_FOREIGNKEY"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_FOREIGNKEY _HRESULT_TYPEDEF_(0x87AF0313L)")]
    public const int SQLITE_E_CONSTRAINT_FOREIGNKEY = unchecked((int)(0x87AF0313));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_FUNCTION"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_FUNCTION _HRESULT_TYPEDEF_(0x87AF0413L)")]
    public const int SQLITE_E_CONSTRAINT_FUNCTION = unchecked((int)(0x87AF0413));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_NOTNULL"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_NOTNULL _HRESULT_TYPEDEF_(0x87AF0513L)")]
    public const int SQLITE_E_CONSTRAINT_NOTNULL = unchecked((int)(0x87AF0513));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_PRIMARYKEY"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_PRIMARYKEY _HRESULT_TYPEDEF_(0x87AF0613L)")]
    public const int SQLITE_E_CONSTRAINT_PRIMARYKEY = unchecked((int)(0x87AF0613));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_TRIGGER"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_TRIGGER _HRESULT_TYPEDEF_(0x87AF0713L)")]
    public const int SQLITE_E_CONSTRAINT_TRIGGER = unchecked((int)(0x87AF0713));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_UNIQUE"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_UNIQUE _HRESULT_TYPEDEF_(0x87AF0813L)")]
    public const int SQLITE_E_CONSTRAINT_UNIQUE = unchecked((int)(0x87AF0813));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_VTAB"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_VTAB _HRESULT_TYPEDEF_(0x87AF0913L)")]
    public const int SQLITE_E_CONSTRAINT_VTAB = unchecked((int)(0x87AF0913));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_ROWID"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_ROWID _HRESULT_TYPEDEF_(0x87AF0A13L)")]
    public const int SQLITE_E_CONSTRAINT_ROWID = unchecked((int)(0x87AF0A13));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_PINNED"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_PINNED _HRESULT_TYPEDEF_(0x87AF0B13L)")]
    public const int SQLITE_E_CONSTRAINT_PINNED = unchecked((int)(0x87AF0B13));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_CONSTRAINT_DATATYPE"]/*' />
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_DATATYPE _HRESULT_TYPEDEF_(0x87AF0C13L)")]
    public const int SQLITE_E_CONSTRAINT_DATATYPE = unchecked((int)(0x87AF0C13));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_NOTICE_RECOVER_WAL"]/*' />
    [NativeTypeName("#define SQLITE_E_NOTICE_RECOVER_WAL _HRESULT_TYPEDEF_(0x87AF011BL)")]
    public const int SQLITE_E_NOTICE_RECOVER_WAL = unchecked((int)(0x87AF011B));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_NOTICE_RECOVER_ROLLBACK"]/*' />
    [NativeTypeName("#define SQLITE_E_NOTICE_RECOVER_ROLLBACK _HRESULT_TYPEDEF_(0x87AF021BL)")]
    public const int SQLITE_E_NOTICE_RECOVER_ROLLBACK = unchecked((int)(0x87AF021B));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_NOTICE_RECOVER_RBU"]/*' />
    [NativeTypeName("#define SQLITE_E_NOTICE_RECOVER_RBU _HRESULT_TYPEDEF_(0x87AF031BL)")]
    public const int SQLITE_E_NOTICE_RECOVER_RBU = unchecked((int)(0x87AF031B));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_WARNING_AUTOINDEX"]/*' />
    [NativeTypeName("#define SQLITE_E_WARNING_AUTOINDEX _HRESULT_TYPEDEF_(0x87AF011CL)")]
    public const int SQLITE_E_WARNING_AUTOINDEX = unchecked((int)(0x87AF011C));

    /// <include file='SQLITE.xml' path='doc/member[@name="SQLITE.SQLITE_E_AUTH_USER"]/*' />
    [NativeTypeName("#define SQLITE_E_AUTH_USER _HRESULT_TYPEDEF_(0x87AF0117L)")]
    public const int SQLITE_E_AUTH_USER = unchecked((int)(0x87AF0117));
}
