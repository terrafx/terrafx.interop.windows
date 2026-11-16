// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SCARD
{
    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_S_SUCCESS"]/*' />
    [NativeTypeName("#define SCARD_S_SUCCESS NO_ERROR")]
    public const int SCARD_S_SUCCESS = 0;

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_F_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define SCARD_F_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80100001L)")]
    public const int SCARD_F_INTERNAL_ERROR = unchecked((int)(0x80100001));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_CANCELLED"]/*' />
    [NativeTypeName("#define SCARD_E_CANCELLED _HRESULT_TYPEDEF_(0x80100002L)")]
    public const int SCARD_E_CANCELLED = unchecked((int)(0x80100002));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define SCARD_E_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80100003L)")]
    public const int SCARD_E_INVALID_HANDLE = unchecked((int)(0x80100003));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define SCARD_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80100004L)")]
    public const int SCARD_E_INVALID_PARAMETER = unchecked((int)(0x80100004));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_INVALID_TARGET"]/*' />
    [NativeTypeName("#define SCARD_E_INVALID_TARGET _HRESULT_TYPEDEF_(0x80100005L)")]
    public const int SCARD_E_INVALID_TARGET = unchecked((int)(0x80100005));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_MEMORY"]/*' />
    [NativeTypeName("#define SCARD_E_NO_MEMORY _HRESULT_TYPEDEF_(0x80100006L)")]
    public const int SCARD_E_NO_MEMORY = unchecked((int)(0x80100006));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_F_WAITED_TOO_LONG"]/*' />
    [NativeTypeName("#define SCARD_F_WAITED_TOO_LONG _HRESULT_TYPEDEF_(0x80100007L)")]
    public const int SCARD_F_WAITED_TOO_LONG = unchecked((int)(0x80100007));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_INSUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define SCARD_E_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x80100008L)")]
    public const int SCARD_E_INSUFFICIENT_BUFFER = unchecked((int)(0x80100008));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_UNKNOWN_READER"]/*' />
    [NativeTypeName("#define SCARD_E_UNKNOWN_READER _HRESULT_TYPEDEF_(0x80100009L)")]
    public const int SCARD_E_UNKNOWN_READER = unchecked((int)(0x80100009));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_TIMEOUT"]/*' />
    [NativeTypeName("#define SCARD_E_TIMEOUT _HRESULT_TYPEDEF_(0x8010000AL)")]
    public const int SCARD_E_TIMEOUT = unchecked((int)(0x8010000A));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_SHARING_VIOLATION"]/*' />
    [NativeTypeName("#define SCARD_E_SHARING_VIOLATION _HRESULT_TYPEDEF_(0x8010000BL)")]
    public const int SCARD_E_SHARING_VIOLATION = unchecked((int)(0x8010000B));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_SMARTCARD"]/*' />
    [NativeTypeName("#define SCARD_E_NO_SMARTCARD _HRESULT_TYPEDEF_(0x8010000CL)")]
    public const int SCARD_E_NO_SMARTCARD = unchecked((int)(0x8010000C));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_UNKNOWN_CARD"]/*' />
    [NativeTypeName("#define SCARD_E_UNKNOWN_CARD _HRESULT_TYPEDEF_(0x8010000DL)")]
    public const int SCARD_E_UNKNOWN_CARD = unchecked((int)(0x8010000D));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_CANT_DISPOSE"]/*' />
    [NativeTypeName("#define SCARD_E_CANT_DISPOSE _HRESULT_TYPEDEF_(0x8010000EL)")]
    public const int SCARD_E_CANT_DISPOSE = unchecked((int)(0x8010000E));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_PROTO_MISMATCH"]/*' />
    [NativeTypeName("#define SCARD_E_PROTO_MISMATCH _HRESULT_TYPEDEF_(0x8010000FL)")]
    public const int SCARD_E_PROTO_MISMATCH = unchecked((int)(0x8010000F));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NOT_READY"]/*' />
    [NativeTypeName("#define SCARD_E_NOT_READY _HRESULT_TYPEDEF_(0x80100010L)")]
    public const int SCARD_E_NOT_READY = unchecked((int)(0x80100010));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_INVALID_VALUE"]/*' />
    [NativeTypeName("#define SCARD_E_INVALID_VALUE _HRESULT_TYPEDEF_(0x80100011L)")]
    public const int SCARD_E_INVALID_VALUE = unchecked((int)(0x80100011));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_SYSTEM_CANCELLED"]/*' />
    [NativeTypeName("#define SCARD_E_SYSTEM_CANCELLED _HRESULT_TYPEDEF_(0x80100012L)")]
    public const int SCARD_E_SYSTEM_CANCELLED = unchecked((int)(0x80100012));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_F_COMM_ERROR"]/*' />
    [NativeTypeName("#define SCARD_F_COMM_ERROR _HRESULT_TYPEDEF_(0x80100013L)")]
    public const int SCARD_F_COMM_ERROR = unchecked((int)(0x80100013));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_F_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define SCARD_F_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x80100014L)")]
    public const int SCARD_F_UNKNOWN_ERROR = unchecked((int)(0x80100014));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_INVALID_ATR"]/*' />
    [NativeTypeName("#define SCARD_E_INVALID_ATR _HRESULT_TYPEDEF_(0x80100015L)")]
    public const int SCARD_E_INVALID_ATR = unchecked((int)(0x80100015));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NOT_TRANSACTED"]/*' />
    [NativeTypeName("#define SCARD_E_NOT_TRANSACTED _HRESULT_TYPEDEF_(0x80100016L)")]
    public const int SCARD_E_NOT_TRANSACTED = unchecked((int)(0x80100016));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_READER_UNAVAILABLE"]/*' />
    [NativeTypeName("#define SCARD_E_READER_UNAVAILABLE _HRESULT_TYPEDEF_(0x80100017L)")]
    public const int SCARD_E_READER_UNAVAILABLE = unchecked((int)(0x80100017));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_P_SHUTDOWN"]/*' />
    [NativeTypeName("#define SCARD_P_SHUTDOWN _HRESULT_TYPEDEF_(0x80100018L)")]
    public const int SCARD_P_SHUTDOWN = unchecked((int)(0x80100018));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_PCI_TOO_SMALL"]/*' />
    [NativeTypeName("#define SCARD_E_PCI_TOO_SMALL _HRESULT_TYPEDEF_(0x80100019L)")]
    public const int SCARD_E_PCI_TOO_SMALL = unchecked((int)(0x80100019));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_READER_UNSUPPORTED"]/*' />
    [NativeTypeName("#define SCARD_E_READER_UNSUPPORTED _HRESULT_TYPEDEF_(0x8010001AL)")]
    public const int SCARD_E_READER_UNSUPPORTED = unchecked((int)(0x8010001A));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_DUPLICATE_READER"]/*' />
    [NativeTypeName("#define SCARD_E_DUPLICATE_READER _HRESULT_TYPEDEF_(0x8010001BL)")]
    public const int SCARD_E_DUPLICATE_READER = unchecked((int)(0x8010001B));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_CARD_UNSUPPORTED"]/*' />
    [NativeTypeName("#define SCARD_E_CARD_UNSUPPORTED _HRESULT_TYPEDEF_(0x8010001CL)")]
    public const int SCARD_E_CARD_UNSUPPORTED = unchecked((int)(0x8010001C));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_SERVICE"]/*' />
    [NativeTypeName("#define SCARD_E_NO_SERVICE _HRESULT_TYPEDEF_(0x8010001DL)")]
    public const int SCARD_E_NO_SERVICE = unchecked((int)(0x8010001D));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_SERVICE_STOPPED"]/*' />
    [NativeTypeName("#define SCARD_E_SERVICE_STOPPED _HRESULT_TYPEDEF_(0x8010001EL)")]
    public const int SCARD_E_SERVICE_STOPPED = unchecked((int)(0x8010001E));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_UNEXPECTED"]/*' />
    [NativeTypeName("#define SCARD_E_UNEXPECTED _HRESULT_TYPEDEF_(0x8010001FL)")]
    public const int SCARD_E_UNEXPECTED = unchecked((int)(0x8010001F));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_ICC_INSTALLATION"]/*' />
    [NativeTypeName("#define SCARD_E_ICC_INSTALLATION _HRESULT_TYPEDEF_(0x80100020L)")]
    public const int SCARD_E_ICC_INSTALLATION = unchecked((int)(0x80100020));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_ICC_CREATEORDER"]/*' />
    [NativeTypeName("#define SCARD_E_ICC_CREATEORDER _HRESULT_TYPEDEF_(0x80100021L)")]
    public const int SCARD_E_ICC_CREATEORDER = unchecked((int)(0x80100021));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_UNSUPPORTED_FEATURE"]/*' />
    [NativeTypeName("#define SCARD_E_UNSUPPORTED_FEATURE _HRESULT_TYPEDEF_(0x80100022L)")]
    public const int SCARD_E_UNSUPPORTED_FEATURE = unchecked((int)(0x80100022));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_DIR_NOT_FOUND"]/*' />
    [NativeTypeName("#define SCARD_E_DIR_NOT_FOUND _HRESULT_TYPEDEF_(0x80100023L)")]
    public const int SCARD_E_DIR_NOT_FOUND = unchecked((int)(0x80100023));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_FILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define SCARD_E_FILE_NOT_FOUND _HRESULT_TYPEDEF_(0x80100024L)")]
    public const int SCARD_E_FILE_NOT_FOUND = unchecked((int)(0x80100024));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_DIR"]/*' />
    [NativeTypeName("#define SCARD_E_NO_DIR _HRESULT_TYPEDEF_(0x80100025L)")]
    public const int SCARD_E_NO_DIR = unchecked((int)(0x80100025));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_FILE"]/*' />
    [NativeTypeName("#define SCARD_E_NO_FILE _HRESULT_TYPEDEF_(0x80100026L)")]
    public const int SCARD_E_NO_FILE = unchecked((int)(0x80100026));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_ACCESS"]/*' />
    [NativeTypeName("#define SCARD_E_NO_ACCESS _HRESULT_TYPEDEF_(0x80100027L)")]
    public const int SCARD_E_NO_ACCESS = unchecked((int)(0x80100027));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_WRITE_TOO_MANY"]/*' />
    [NativeTypeName("#define SCARD_E_WRITE_TOO_MANY _HRESULT_TYPEDEF_(0x80100028L)")]
    public const int SCARD_E_WRITE_TOO_MANY = unchecked((int)(0x80100028));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_BAD_SEEK"]/*' />
    [NativeTypeName("#define SCARD_E_BAD_SEEK _HRESULT_TYPEDEF_(0x80100029L)")]
    public const int SCARD_E_BAD_SEEK = unchecked((int)(0x80100029));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_INVALID_CHV"]/*' />
    [NativeTypeName("#define SCARD_E_INVALID_CHV _HRESULT_TYPEDEF_(0x8010002AL)")]
    public const int SCARD_E_INVALID_CHV = unchecked((int)(0x8010002A));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_UNKNOWN_RES_MNG"]/*' />
    [NativeTypeName("#define SCARD_E_UNKNOWN_RES_MNG _HRESULT_TYPEDEF_(0x8010002BL)")]
    public const int SCARD_E_UNKNOWN_RES_MNG = unchecked((int)(0x8010002B));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_SUCH_CERTIFICATE"]/*' />
    [NativeTypeName("#define SCARD_E_NO_SUCH_CERTIFICATE _HRESULT_TYPEDEF_(0x8010002CL)")]
    public const int SCARD_E_NO_SUCH_CERTIFICATE = unchecked((int)(0x8010002C));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_CERTIFICATE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define SCARD_E_CERTIFICATE_UNAVAILABLE _HRESULT_TYPEDEF_(0x8010002DL)")]
    public const int SCARD_E_CERTIFICATE_UNAVAILABLE = unchecked((int)(0x8010002D));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_READERS_AVAILABLE"]/*' />
    [NativeTypeName("#define SCARD_E_NO_READERS_AVAILABLE _HRESULT_TYPEDEF_(0x8010002EL)")]
    public const int SCARD_E_NO_READERS_AVAILABLE = unchecked((int)(0x8010002E));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_COMM_DATA_LOST"]/*' />
    [NativeTypeName("#define SCARD_E_COMM_DATA_LOST _HRESULT_TYPEDEF_(0x8010002FL)")]
    public const int SCARD_E_COMM_DATA_LOST = unchecked((int)(0x8010002F));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_KEY_CONTAINER"]/*' />
    [NativeTypeName("#define SCARD_E_NO_KEY_CONTAINER _HRESULT_TYPEDEF_(0x80100030L)")]
    public const int SCARD_E_NO_KEY_CONTAINER = unchecked((int)(0x80100030));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_SERVER_TOO_BUSY"]/*' />
    [NativeTypeName("#define SCARD_E_SERVER_TOO_BUSY _HRESULT_TYPEDEF_(0x80100031L)")]
    public const int SCARD_E_SERVER_TOO_BUSY = unchecked((int)(0x80100031));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_PIN_CACHE_EXPIRED"]/*' />
    [NativeTypeName("#define SCARD_E_PIN_CACHE_EXPIRED _HRESULT_TYPEDEF_(0x80100032L)")]
    public const int SCARD_E_PIN_CACHE_EXPIRED = unchecked((int)(0x80100032));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_NO_PIN_CACHE"]/*' />
    [NativeTypeName("#define SCARD_E_NO_PIN_CACHE _HRESULT_TYPEDEF_(0x80100033L)")]
    public const int SCARD_E_NO_PIN_CACHE = unchecked((int)(0x80100033));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_E_READ_ONLY_CARD"]/*' />
    [NativeTypeName("#define SCARD_E_READ_ONLY_CARD _HRESULT_TYPEDEF_(0x80100034L)")]
    public const int SCARD_E_READ_ONLY_CARD = unchecked((int)(0x80100034));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_UNSUPPORTED_CARD"]/*' />
    [NativeTypeName("#define SCARD_W_UNSUPPORTED_CARD _HRESULT_TYPEDEF_(0x80100065L)")]
    public const int SCARD_W_UNSUPPORTED_CARD = unchecked((int)(0x80100065));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_UNRESPONSIVE_CARD"]/*' />
    [NativeTypeName("#define SCARD_W_UNRESPONSIVE_CARD _HRESULT_TYPEDEF_(0x80100066L)")]
    public const int SCARD_W_UNRESPONSIVE_CARD = unchecked((int)(0x80100066));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_UNPOWERED_CARD"]/*' />
    [NativeTypeName("#define SCARD_W_UNPOWERED_CARD _HRESULT_TYPEDEF_(0x80100067L)")]
    public const int SCARD_W_UNPOWERED_CARD = unchecked((int)(0x80100067));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_RESET_CARD"]/*' />
    [NativeTypeName("#define SCARD_W_RESET_CARD _HRESULT_TYPEDEF_(0x80100068L)")]
    public const int SCARD_W_RESET_CARD = unchecked((int)(0x80100068));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_REMOVED_CARD"]/*' />
    [NativeTypeName("#define SCARD_W_REMOVED_CARD _HRESULT_TYPEDEF_(0x80100069L)")]
    public const int SCARD_W_REMOVED_CARD = unchecked((int)(0x80100069));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_SECURITY_VIOLATION"]/*' />
    [NativeTypeName("#define SCARD_W_SECURITY_VIOLATION _HRESULT_TYPEDEF_(0x8010006AL)")]
    public const int SCARD_W_SECURITY_VIOLATION = unchecked((int)(0x8010006A));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_WRONG_CHV"]/*' />
    [NativeTypeName("#define SCARD_W_WRONG_CHV _HRESULT_TYPEDEF_(0x8010006BL)")]
    public const int SCARD_W_WRONG_CHV = unchecked((int)(0x8010006B));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_CHV_BLOCKED"]/*' />
    [NativeTypeName("#define SCARD_W_CHV_BLOCKED _HRESULT_TYPEDEF_(0x8010006CL)")]
    public const int SCARD_W_CHV_BLOCKED = unchecked((int)(0x8010006C));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_EOF"]/*' />
    [NativeTypeName("#define SCARD_W_EOF _HRESULT_TYPEDEF_(0x8010006DL)")]
    public const int SCARD_W_EOF = unchecked((int)(0x8010006D));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_CANCELLED_BY_USER"]/*' />
    [NativeTypeName("#define SCARD_W_CANCELLED_BY_USER _HRESULT_TYPEDEF_(0x8010006EL)")]
    public const int SCARD_W_CANCELLED_BY_USER = unchecked((int)(0x8010006E));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_CARD_NOT_AUTHENTICATED"]/*' />
    [NativeTypeName("#define SCARD_W_CARD_NOT_AUTHENTICATED _HRESULT_TYPEDEF_(0x8010006FL)")]
    public const int SCARD_W_CARD_NOT_AUTHENTICATED = unchecked((int)(0x8010006F));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_CACHE_ITEM_NOT_FOUND"]/*' />
    [NativeTypeName("#define SCARD_W_CACHE_ITEM_NOT_FOUND _HRESULT_TYPEDEF_(0x80100070L)")]
    public const int SCARD_W_CACHE_ITEM_NOT_FOUND = unchecked((int)(0x80100070));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_CACHE_ITEM_STALE"]/*' />
    [NativeTypeName("#define SCARD_W_CACHE_ITEM_STALE _HRESULT_TYPEDEF_(0x80100071L)")]
    public const int SCARD_W_CACHE_ITEM_STALE = unchecked((int)(0x80100071));

    /// <include file='SCARD.xml' path='doc/member[@name="SCARD.SCARD_W_CACHE_ITEM_TOO_BIG"]/*' />
    [NativeTypeName("#define SCARD_W_CACHE_ITEM_TOO_BIG _HRESULT_TYPEDEF_(0x80100072L)")]
    public const int SCARD_W_CACHE_ITEM_TOO_BIG = unchecked((int)(0x80100072));
}
