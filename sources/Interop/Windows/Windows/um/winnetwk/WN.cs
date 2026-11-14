// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WN
{
    /// <include file='WN.xml' path='doc/member[@name="WN.WN_SUCCESS"]/*' />
    [NativeTypeName("#define WN_SUCCESS NO_ERROR")]
    public const int WN_SUCCESS = 0;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NO_ERROR"]/*' />
    [NativeTypeName("#define WN_NO_ERROR NO_ERROR")]
    public const int WN_NO_ERROR = 0;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define WN_NOT_SUPPORTED ERROR_NOT_SUPPORTED")]
    public const int WN_NOT_SUPPORTED = 50;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_CANCEL"]/*' />
    [NativeTypeName("#define WN_CANCEL ERROR_CANCELLED")]
    public const int WN_CANCEL = 1223;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_RETRY"]/*' />
    [NativeTypeName("#define WN_RETRY ERROR_RETRY")]
    public const int WN_RETRY = 1237;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NET_ERROR"]/*' />
    [NativeTypeName("#define WN_NET_ERROR ERROR_UNEXP_NET_ERR")]
    public const int WN_NET_ERROR = 59;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_MORE_DATA"]/*' />
    [NativeTypeName("#define WN_MORE_DATA ERROR_MORE_DATA")]
    public const int WN_MORE_DATA = 234;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_POINTER"]/*' />
    [NativeTypeName("#define WN_BAD_POINTER ERROR_INVALID_ADDRESS")]
    public const int WN_BAD_POINTER = 487;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_VALUE"]/*' />
    [NativeTypeName("#define WN_BAD_VALUE ERROR_INVALID_PARAMETER")]
    public const int WN_BAD_VALUE = 87;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_USER"]/*' />
    [NativeTypeName("#define WN_BAD_USER ERROR_BAD_USERNAME")]
    public const int WN_BAD_USER = 2202;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_PASSWORD"]/*' />
    [NativeTypeName("#define WN_BAD_PASSWORD ERROR_INVALID_PASSWORD")]
    public const int WN_BAD_PASSWORD = 86;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define WN_ACCESS_DENIED ERROR_ACCESS_DENIED")]
    public const int WN_ACCESS_DENIED = 5;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_FUNCTION_BUSY"]/*' />
    [NativeTypeName("#define WN_FUNCTION_BUSY ERROR_BUSY")]
    public const int WN_FUNCTION_BUSY = 170;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_WINDOWS_ERROR"]/*' />
    [NativeTypeName("#define WN_WINDOWS_ERROR ERROR_UNEXP_NET_ERR")]
    public const int WN_WINDOWS_ERROR = 59;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_OUT_OF_MEMORY"]/*' />
    [NativeTypeName("#define WN_OUT_OF_MEMORY ERROR_NOT_ENOUGH_MEMORY")]
    public const int WN_OUT_OF_MEMORY = 8;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NO_NETWORK"]/*' />
    [NativeTypeName("#define WN_NO_NETWORK ERROR_NO_NETWORK")]
    public const int WN_NO_NETWORK = 1222;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_EXTENDED_ERROR"]/*' />
    [NativeTypeName("#define WN_EXTENDED_ERROR ERROR_EXTENDED_ERROR")]
    public const int WN_EXTENDED_ERROR = 1208;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_LEVEL"]/*' />
    [NativeTypeName("#define WN_BAD_LEVEL ERROR_INVALID_LEVEL")]
    public const int WN_BAD_LEVEL = 124;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_HANDLE"]/*' />
    [NativeTypeName("#define WN_BAD_HANDLE ERROR_INVALID_HANDLE")]
    public const int WN_BAD_HANDLE = 6;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NOT_INITIALIZING"]/*' />
    [NativeTypeName("#define WN_NOT_INITIALIZING ERROR_ALREADY_INITIALIZED")]
    public const int WN_NOT_INITIALIZING = 1247;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NO_MORE_DEVICES"]/*' />
    [NativeTypeName("#define WN_NO_MORE_DEVICES ERROR_NO_MORE_DEVICES")]
    public const int WN_NO_MORE_DEVICES = 1248;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define WN_NOT_CONNECTED ERROR_NOT_CONNECTED")]
    public const int WN_NOT_CONNECTED = 2250;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_OPEN_FILES"]/*' />
    [NativeTypeName("#define WN_OPEN_FILES ERROR_OPEN_FILES")]
    public const int WN_OPEN_FILES = 2401;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_DEVICE_IN_USE"]/*' />
    [NativeTypeName("#define WN_DEVICE_IN_USE ERROR_DEVICE_IN_USE")]
    public const int WN_DEVICE_IN_USE = 2404;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_NETNAME"]/*' />
    [NativeTypeName("#define WN_BAD_NETNAME ERROR_BAD_NET_NAME")]
    public const int WN_BAD_NETNAME = 67;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_LOCALNAME"]/*' />
    [NativeTypeName("#define WN_BAD_LOCALNAME ERROR_BAD_DEVICE")]
    public const int WN_BAD_LOCALNAME = 1200;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_ALREADY_CONNECTED"]/*' />
    [NativeTypeName("#define WN_ALREADY_CONNECTED ERROR_ALREADY_ASSIGNED")]
    public const int WN_ALREADY_CONNECTED = 85;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_DEVICE_ERROR"]/*' />
    [NativeTypeName("#define WN_DEVICE_ERROR ERROR_GEN_FAILURE")]
    public const int WN_DEVICE_ERROR = 31;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_CONNECTION_CLOSED"]/*' />
    [NativeTypeName("#define WN_CONNECTION_CLOSED ERROR_CONNECTION_UNAVAIL")]
    public const int WN_CONNECTION_CLOSED = 1201;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NO_NET_OR_BAD_PATH"]/*' />
    [NativeTypeName("#define WN_NO_NET_OR_BAD_PATH ERROR_NO_NET_OR_BAD_PATH")]
    public const int WN_NO_NET_OR_BAD_PATH = 1203;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_PROVIDER"]/*' />
    [NativeTypeName("#define WN_BAD_PROVIDER ERROR_BAD_PROVIDER")]
    public const int WN_BAD_PROVIDER = 1204;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_CANNOT_OPEN_PROFILE"]/*' />
    [NativeTypeName("#define WN_CANNOT_OPEN_PROFILE ERROR_CANNOT_OPEN_PROFILE")]
    public const int WN_CANNOT_OPEN_PROFILE = 1205;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_PROFILE"]/*' />
    [NativeTypeName("#define WN_BAD_PROFILE ERROR_BAD_PROFILE")]
    public const int WN_BAD_PROFILE = 1206;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_BAD_DEV_TYPE"]/*' />
    [NativeTypeName("#define WN_BAD_DEV_TYPE ERROR_BAD_DEV_TYPE")]
    public const int WN_BAD_DEV_TYPE = 66;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_DEVICE_ALREADY_REMEMBERED"]/*' />
    [NativeTypeName("#define WN_DEVICE_ALREADY_REMEMBERED ERROR_DEVICE_ALREADY_REMEMBERED")]
    public const int WN_DEVICE_ALREADY_REMEMBERED = 1202;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_CONNECTED_OTHER_PASSWORD"]/*' />
    [NativeTypeName("#define WN_CONNECTED_OTHER_PASSWORD ERROR_CONNECTED_OTHER_PASSWORD")]
    public const int WN_CONNECTED_OTHER_PASSWORD = 2108;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_CONNECTED_OTHER_PASSWORD_DEFAULT"]/*' />
    [NativeTypeName("#define WN_CONNECTED_OTHER_PASSWORD_DEFAULT ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT")]
    public const int WN_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NO_MORE_ENTRIES"]/*' />
    [NativeTypeName("#define WN_NO_MORE_ENTRIES ERROR_NO_MORE_ITEMS")]
    public const int WN_NO_MORE_ENTRIES = 259;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NOT_CONTAINER"]/*' />
    [NativeTypeName("#define WN_NOT_CONTAINER ERROR_NOT_CONTAINER")]
    public const int WN_NOT_CONTAINER = 1207;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NOT_AUTHENTICATED"]/*' />
    [NativeTypeName("#define WN_NOT_AUTHENTICATED ERROR_NOT_AUTHENTICATED")]
    public const int WN_NOT_AUTHENTICATED = 1244;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NOT_LOGGED_ON"]/*' />
    [NativeTypeName("#define WN_NOT_LOGGED_ON ERROR_NOT_LOGGED_ON")]
    public const int WN_NOT_LOGGED_ON = 1245;

    /// <include file='WN.xml' path='doc/member[@name="WN.WN_NOT_VALIDATED"]/*' />
    [NativeTypeName("#define WN_NOT_VALIDATED ERROR_NO_LOGON_SERVERS")]
    public const int WN_NOT_VALIDATED = 1311;
}
