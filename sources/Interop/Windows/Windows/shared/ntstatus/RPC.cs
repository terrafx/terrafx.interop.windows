// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RPC
{
    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_STRING_BINDING"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_STRING_BINDING ((NTSTATUS)0xC0020001L)")]
    public const int RPC_NT_INVALID_STRING_BINDING = unchecked((int)(0xC0020001));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_WRONG_KIND_OF_BINDING"]/*' />
    [NativeTypeName("#define RPC_NT_WRONG_KIND_OF_BINDING ((NTSTATUS)0xC0020002L)")]
    public const int RPC_NT_WRONG_KIND_OF_BINDING = unchecked((int)(0xC0020002));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_BINDING"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_BINDING ((NTSTATUS)0xC0020003L)")]
    public const int RPC_NT_INVALID_BINDING = unchecked((int)(0xC0020003));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_PROTSEQ_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define RPC_NT_PROTSEQ_NOT_SUPPORTED ((NTSTATUS)0xC0020004L)")]
    public const int RPC_NT_PROTSEQ_NOT_SUPPORTED = unchecked((int)(0xC0020004));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_RPC_PROTSEQ"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_RPC_PROTSEQ ((NTSTATUS)0xC0020005L)")]
    public const int RPC_NT_INVALID_RPC_PROTSEQ = unchecked((int)(0xC0020005));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_STRING_UUID"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_STRING_UUID ((NTSTATUS)0xC0020006L)")]
    public const int RPC_NT_INVALID_STRING_UUID = unchecked((int)(0xC0020006));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_ENDPOINT_FORMAT"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_ENDPOINT_FORMAT ((NTSTATUS)0xC0020007L)")]
    public const int RPC_NT_INVALID_ENDPOINT_FORMAT = unchecked((int)(0xC0020007));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_NET_ADDR"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_NET_ADDR ((NTSTATUS)0xC0020008L)")]
    public const int RPC_NT_INVALID_NET_ADDR = unchecked((int)(0xC0020008));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_ENDPOINT_FOUND"]/*' />
    [NativeTypeName("#define RPC_NT_NO_ENDPOINT_FOUND ((NTSTATUS)0xC0020009L)")]
    public const int RPC_NT_NO_ENDPOINT_FOUND = unchecked((int)(0xC0020009));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_TIMEOUT ((NTSTATUS)0xC002000AL)")]
    public const int RPC_NT_INVALID_TIMEOUT = unchecked((int)(0xC002000A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_OBJECT_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_NT_OBJECT_NOT_FOUND ((NTSTATUS)0xC002000BL)")]
    public const int RPC_NT_OBJECT_NOT_FOUND = unchecked((int)(0xC002000B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define RPC_NT_ALREADY_REGISTERED ((NTSTATUS)0xC002000CL)")]
    public const int RPC_NT_ALREADY_REGISTERED = unchecked((int)(0xC002000C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_TYPE_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define RPC_NT_TYPE_ALREADY_REGISTERED ((NTSTATUS)0xC002000DL)")]
    public const int RPC_NT_TYPE_ALREADY_REGISTERED = unchecked((int)(0xC002000D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_ALREADY_LISTENING"]/*' />
    [NativeTypeName("#define RPC_NT_ALREADY_LISTENING ((NTSTATUS)0xC002000EL)")]
    public const int RPC_NT_ALREADY_LISTENING = unchecked((int)(0xC002000E));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_PROTSEQS_REGISTERED"]/*' />
    [NativeTypeName("#define RPC_NT_NO_PROTSEQS_REGISTERED ((NTSTATUS)0xC002000FL)")]
    public const int RPC_NT_NO_PROTSEQS_REGISTERED = unchecked((int)(0xC002000F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NOT_LISTENING"]/*' />
    [NativeTypeName("#define RPC_NT_NOT_LISTENING ((NTSTATUS)0xC0020010L)")]
    public const int RPC_NT_NOT_LISTENING = unchecked((int)(0xC0020010));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNKNOWN_MGR_TYPE"]/*' />
    [NativeTypeName("#define RPC_NT_UNKNOWN_MGR_TYPE ((NTSTATUS)0xC0020011L)")]
    public const int RPC_NT_UNKNOWN_MGR_TYPE = unchecked((int)(0xC0020011));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNKNOWN_IF"]/*' />
    [NativeTypeName("#define RPC_NT_UNKNOWN_IF ((NTSTATUS)0xC0020012L)")]
    public const int RPC_NT_UNKNOWN_IF = unchecked((int)(0xC0020012));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_BINDINGS"]/*' />
    [NativeTypeName("#define RPC_NT_NO_BINDINGS ((NTSTATUS)0xC0020013L)")]
    public const int RPC_NT_NO_BINDINGS = unchecked((int)(0xC0020013));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_PROTSEQS"]/*' />
    [NativeTypeName("#define RPC_NT_NO_PROTSEQS ((NTSTATUS)0xC0020014L)")]
    public const int RPC_NT_NO_PROTSEQS = unchecked((int)(0xC0020014));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_CANT_CREATE_ENDPOINT"]/*' />
    [NativeTypeName("#define RPC_NT_CANT_CREATE_ENDPOINT ((NTSTATUS)0xC0020015L)")]
    public const int RPC_NT_CANT_CREATE_ENDPOINT = unchecked((int)(0xC0020015));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_OUT_OF_RESOURCES"]/*' />
    [NativeTypeName("#define RPC_NT_OUT_OF_RESOURCES ((NTSTATUS)0xC0020016L)")]
    public const int RPC_NT_OUT_OF_RESOURCES = unchecked((int)(0xC0020016));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SERVER_UNAVAILABLE"]/*' />
    [NativeTypeName("#define RPC_NT_SERVER_UNAVAILABLE ((NTSTATUS)0xC0020017L)")]
    public const int RPC_NT_SERVER_UNAVAILABLE = unchecked((int)(0xC0020017));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SERVER_TOO_BUSY"]/*' />
    [NativeTypeName("#define RPC_NT_SERVER_TOO_BUSY ((NTSTATUS)0xC0020018L)")]
    public const int RPC_NT_SERVER_TOO_BUSY = unchecked((int)(0xC0020018));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_NETWORK_OPTIONS"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_NETWORK_OPTIONS ((NTSTATUS)0xC0020019L)")]
    public const int RPC_NT_INVALID_NETWORK_OPTIONS = unchecked((int)(0xC0020019));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_CALL_ACTIVE"]/*' />
    [NativeTypeName("#define RPC_NT_NO_CALL_ACTIVE ((NTSTATUS)0xC002001AL)")]
    public const int RPC_NT_NO_CALL_ACTIVE = unchecked((int)(0xC002001A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_CALL_FAILED"]/*' />
    [NativeTypeName("#define RPC_NT_CALL_FAILED ((NTSTATUS)0xC002001BL)")]
    public const int RPC_NT_CALL_FAILED = unchecked((int)(0xC002001B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_CALL_FAILED_DNE"]/*' />
    [NativeTypeName("#define RPC_NT_CALL_FAILED_DNE ((NTSTATUS)0xC002001CL)")]
    public const int RPC_NT_CALL_FAILED_DNE = unchecked((int)(0xC002001C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_PROTOCOL_ERROR"]/*' />
    [NativeTypeName("#define RPC_NT_PROTOCOL_ERROR ((NTSTATUS)0xC002001DL)")]
    public const int RPC_NT_PROTOCOL_ERROR = unchecked((int)(0xC002001D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNSUPPORTED_TRANS_SYN"]/*' />
    [NativeTypeName("#define RPC_NT_UNSUPPORTED_TRANS_SYN ((NTSTATUS)0xC002001FL)")]
    public const int RPC_NT_UNSUPPORTED_TRANS_SYN = unchecked((int)(0xC002001F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNSUPPORTED_TYPE"]/*' />
    [NativeTypeName("#define RPC_NT_UNSUPPORTED_TYPE ((NTSTATUS)0xC0020021L)")]
    public const int RPC_NT_UNSUPPORTED_TYPE = unchecked((int)(0xC0020021));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_TAG"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_TAG ((NTSTATUS)0xC0020022L)")]
    public const int RPC_NT_INVALID_TAG = unchecked((int)(0xC0020022));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_BOUND"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_BOUND ((NTSTATUS)0xC0020023L)")]
    public const int RPC_NT_INVALID_BOUND = unchecked((int)(0xC0020023));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_ENTRY_NAME"]/*' />
    [NativeTypeName("#define RPC_NT_NO_ENTRY_NAME ((NTSTATUS)0xC0020024L)")]
    public const int RPC_NT_NO_ENTRY_NAME = unchecked((int)(0xC0020024));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_NAME_SYNTAX"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_NAME_SYNTAX ((NTSTATUS)0xC0020025L)")]
    public const int RPC_NT_INVALID_NAME_SYNTAX = unchecked((int)(0xC0020025));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNSUPPORTED_NAME_SYNTAX"]/*' />
    [NativeTypeName("#define RPC_NT_UNSUPPORTED_NAME_SYNTAX ((NTSTATUS)0xC0020026L)")]
    public const int RPC_NT_UNSUPPORTED_NAME_SYNTAX = unchecked((int)(0xC0020026));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UUID_NO_ADDRESS"]/*' />
    [NativeTypeName("#define RPC_NT_UUID_NO_ADDRESS ((NTSTATUS)0xC0020028L)")]
    public const int RPC_NT_UUID_NO_ADDRESS = unchecked((int)(0xC0020028));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_DUPLICATE_ENDPOINT"]/*' />
    [NativeTypeName("#define RPC_NT_DUPLICATE_ENDPOINT ((NTSTATUS)0xC0020029L)")]
    public const int RPC_NT_DUPLICATE_ENDPOINT = unchecked((int)(0xC0020029));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNKNOWN_AUTHN_TYPE"]/*' />
    [NativeTypeName("#define RPC_NT_UNKNOWN_AUTHN_TYPE ((NTSTATUS)0xC002002AL)")]
    public const int RPC_NT_UNKNOWN_AUTHN_TYPE = unchecked((int)(0xC002002A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_MAX_CALLS_TOO_SMALL"]/*' />
    [NativeTypeName("#define RPC_NT_MAX_CALLS_TOO_SMALL ((NTSTATUS)0xC002002BL)")]
    public const int RPC_NT_MAX_CALLS_TOO_SMALL = unchecked((int)(0xC002002B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_STRING_TOO_LONG"]/*' />
    [NativeTypeName("#define RPC_NT_STRING_TOO_LONG ((NTSTATUS)0xC002002CL)")]
    public const int RPC_NT_STRING_TOO_LONG = unchecked((int)(0xC002002C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_PROTSEQ_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_NT_PROTSEQ_NOT_FOUND ((NTSTATUS)0xC002002DL)")]
    public const int RPC_NT_PROTSEQ_NOT_FOUND = unchecked((int)(0xC002002D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_PROCNUM_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define RPC_NT_PROCNUM_OUT_OF_RANGE ((NTSTATUS)0xC002002EL)")]
    public const int RPC_NT_PROCNUM_OUT_OF_RANGE = unchecked((int)(0xC002002E));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_BINDING_HAS_NO_AUTH"]/*' />
    [NativeTypeName("#define RPC_NT_BINDING_HAS_NO_AUTH ((NTSTATUS)0xC002002FL)")]
    public const int RPC_NT_BINDING_HAS_NO_AUTH = unchecked((int)(0xC002002F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNKNOWN_AUTHN_SERVICE"]/*' />
    [NativeTypeName("#define RPC_NT_UNKNOWN_AUTHN_SERVICE ((NTSTATUS)0xC0020030L)")]
    public const int RPC_NT_UNKNOWN_AUTHN_SERVICE = unchecked((int)(0xC0020030));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNKNOWN_AUTHN_LEVEL"]/*' />
    [NativeTypeName("#define RPC_NT_UNKNOWN_AUTHN_LEVEL ((NTSTATUS)0xC0020031L)")]
    public const int RPC_NT_UNKNOWN_AUTHN_LEVEL = unchecked((int)(0xC0020031));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_AUTH_IDENTITY"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_AUTH_IDENTITY ((NTSTATUS)0xC0020032L)")]
    public const int RPC_NT_INVALID_AUTH_IDENTITY = unchecked((int)(0xC0020032));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNKNOWN_AUTHZ_SERVICE"]/*' />
    [NativeTypeName("#define RPC_NT_UNKNOWN_AUTHZ_SERVICE ((NTSTATUS)0xC0020033L)")]
    public const int RPC_NT_UNKNOWN_AUTHZ_SERVICE = unchecked((int)(0xC0020033));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NOTHING_TO_EXPORT"]/*' />
    [NativeTypeName("#define RPC_NT_NOTHING_TO_EXPORT ((NTSTATUS)0xC0020037L)")]
    public const int RPC_NT_NOTHING_TO_EXPORT = unchecked((int)(0xC0020037));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INCOMPLETE_NAME"]/*' />
    [NativeTypeName("#define RPC_NT_INCOMPLETE_NAME ((NTSTATUS)0xC0020038L)")]
    public const int RPC_NT_INCOMPLETE_NAME = unchecked((int)(0xC0020038));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_VERS_OPTION"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_VERS_OPTION ((NTSTATUS)0xC0020039L)")]
    public const int RPC_NT_INVALID_VERS_OPTION = unchecked((int)(0xC0020039));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_MORE_MEMBERS"]/*' />
    [NativeTypeName("#define RPC_NT_NO_MORE_MEMBERS ((NTSTATUS)0xC002003AL)")]
    public const int RPC_NT_NO_MORE_MEMBERS = unchecked((int)(0xC002003A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NOT_ALL_OBJS_UNEXPORTED"]/*' />
    [NativeTypeName("#define RPC_NT_NOT_ALL_OBJS_UNEXPORTED ((NTSTATUS)0xC002003BL)")]
    public const int RPC_NT_NOT_ALL_OBJS_UNEXPORTED = unchecked((int)(0xC002003B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INTERFACE_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_NT_INTERFACE_NOT_FOUND ((NTSTATUS)0xC002003CL)")]
    public const int RPC_NT_INTERFACE_NOT_FOUND = unchecked((int)(0xC002003C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_ENTRY_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define RPC_NT_ENTRY_ALREADY_EXISTS ((NTSTATUS)0xC002003DL)")]
    public const int RPC_NT_ENTRY_ALREADY_EXISTS = unchecked((int)(0xC002003D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_ENTRY_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_NT_ENTRY_NOT_FOUND ((NTSTATUS)0xC002003EL)")]
    public const int RPC_NT_ENTRY_NOT_FOUND = unchecked((int)(0xC002003E));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NAME_SERVICE_UNAVAILABLE"]/*' />
    [NativeTypeName("#define RPC_NT_NAME_SERVICE_UNAVAILABLE ((NTSTATUS)0xC002003FL)")]
    public const int RPC_NT_NAME_SERVICE_UNAVAILABLE = unchecked((int)(0xC002003F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_NAF_ID"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_NAF_ID ((NTSTATUS)0xC0020040L)")]
    public const int RPC_NT_INVALID_NAF_ID = unchecked((int)(0xC0020040));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_CANNOT_SUPPORT"]/*' />
    [NativeTypeName("#define RPC_NT_CANNOT_SUPPORT ((NTSTATUS)0xC0020041L)")]
    public const int RPC_NT_CANNOT_SUPPORT = unchecked((int)(0xC0020041));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_CONTEXT_AVAILABLE"]/*' />
    [NativeTypeName("#define RPC_NT_NO_CONTEXT_AVAILABLE ((NTSTATUS)0xC0020042L)")]
    public const int RPC_NT_NO_CONTEXT_AVAILABLE = unchecked((int)(0xC0020042));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define RPC_NT_INTERNAL_ERROR ((NTSTATUS)0xC0020043L)")]
    public const int RPC_NT_INTERNAL_ERROR = unchecked((int)(0xC0020043));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_ZERO_DIVIDE"]/*' />
    [NativeTypeName("#define RPC_NT_ZERO_DIVIDE ((NTSTATUS)0xC0020044L)")]
    public const int RPC_NT_ZERO_DIVIDE = unchecked((int)(0xC0020044));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_ADDRESS_ERROR"]/*' />
    [NativeTypeName("#define RPC_NT_ADDRESS_ERROR ((NTSTATUS)0xC0020045L)")]
    public const int RPC_NT_ADDRESS_ERROR = unchecked((int)(0xC0020045));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_FP_DIV_ZERO"]/*' />
    [NativeTypeName("#define RPC_NT_FP_DIV_ZERO ((NTSTATUS)0xC0020046L)")]
    public const int RPC_NT_FP_DIV_ZERO = unchecked((int)(0xC0020046));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_FP_UNDERFLOW"]/*' />
    [NativeTypeName("#define RPC_NT_FP_UNDERFLOW ((NTSTATUS)0xC0020047L)")]
    public const int RPC_NT_FP_UNDERFLOW = unchecked((int)(0xC0020047));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_FP_OVERFLOW"]/*' />
    [NativeTypeName("#define RPC_NT_FP_OVERFLOW ((NTSTATUS)0xC0020048L)")]
    public const int RPC_NT_FP_OVERFLOW = unchecked((int)(0xC0020048));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_MORE_ENTRIES"]/*' />
    [NativeTypeName("#define RPC_NT_NO_MORE_ENTRIES ((NTSTATUS)0xC0030001L)")]
    public const int RPC_NT_NO_MORE_ENTRIES = unchecked((int)(0xC0030001));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SS_CHAR_TRANS_OPEN_FAIL"]/*' />
    [NativeTypeName("#define RPC_NT_SS_CHAR_TRANS_OPEN_FAIL ((NTSTATUS)0xC0030002L)")]
    public const int RPC_NT_SS_CHAR_TRANS_OPEN_FAIL = unchecked((int)(0xC0030002));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SS_CHAR_TRANS_SHORT_FILE"]/*' />
    [NativeTypeName("#define RPC_NT_SS_CHAR_TRANS_SHORT_FILE ((NTSTATUS)0xC0030003L)")]
    public const int RPC_NT_SS_CHAR_TRANS_SHORT_FILE = unchecked((int)(0xC0030003));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SS_IN_NULL_CONTEXT"]/*' />
    [NativeTypeName("#define RPC_NT_SS_IN_NULL_CONTEXT ((NTSTATUS)0xC0030004L)")]
    public const int RPC_NT_SS_IN_NULL_CONTEXT = unchecked((int)(0xC0030004));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SS_CONTEXT_MISMATCH"]/*' />
    [NativeTypeName("#define RPC_NT_SS_CONTEXT_MISMATCH ((NTSTATUS)0xC0030005L)")]
    public const int RPC_NT_SS_CONTEXT_MISMATCH = unchecked((int)(0xC0030005));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SS_CONTEXT_DAMAGED"]/*' />
    [NativeTypeName("#define RPC_NT_SS_CONTEXT_DAMAGED ((NTSTATUS)0xC0030006L)")]
    public const int RPC_NT_SS_CONTEXT_DAMAGED = unchecked((int)(0xC0030006));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SS_HANDLES_MISMATCH"]/*' />
    [NativeTypeName("#define RPC_NT_SS_HANDLES_MISMATCH ((NTSTATUS)0xC0030007L)")]
    public const int RPC_NT_SS_HANDLES_MISMATCH = unchecked((int)(0xC0030007));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SS_CANNOT_GET_CALL_HANDLE"]/*' />
    [NativeTypeName("#define RPC_NT_SS_CANNOT_GET_CALL_HANDLE ((NTSTATUS)0xC0030008L)")]
    public const int RPC_NT_SS_CANNOT_GET_CALL_HANDLE = unchecked((int)(0xC0030008));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NULL_REF_POINTER"]/*' />
    [NativeTypeName("#define RPC_NT_NULL_REF_POINTER ((NTSTATUS)0xC0030009L)")]
    public const int RPC_NT_NULL_REF_POINTER = unchecked((int)(0xC0030009));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_ENUM_VALUE_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define RPC_NT_ENUM_VALUE_OUT_OF_RANGE ((NTSTATUS)0xC003000AL)")]
    public const int RPC_NT_ENUM_VALUE_OUT_OF_RANGE = unchecked((int)(0xC003000A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_BYTE_COUNT_TOO_SMALL"]/*' />
    [NativeTypeName("#define RPC_NT_BYTE_COUNT_TOO_SMALL ((NTSTATUS)0xC003000BL)")]
    public const int RPC_NT_BYTE_COUNT_TOO_SMALL = unchecked((int)(0xC003000B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_BAD_STUB_DATA"]/*' />
    [NativeTypeName("#define RPC_NT_BAD_STUB_DATA ((NTSTATUS)0xC003000CL)")]
    public const int RPC_NT_BAD_STUB_DATA = unchecked((int)(0xC003000C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_CALL_IN_PROGRESS"]/*' />
    [NativeTypeName("#define RPC_NT_CALL_IN_PROGRESS ((NTSTATUS)0xC0020049L)")]
    public const int RPC_NT_CALL_IN_PROGRESS = unchecked((int)(0xC0020049));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_MORE_BINDINGS"]/*' />
    [NativeTypeName("#define RPC_NT_NO_MORE_BINDINGS ((NTSTATUS)0xC002004AL)")]
    public const int RPC_NT_NO_MORE_BINDINGS = unchecked((int)(0xC002004A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_GROUP_MEMBER_NOT_FOUND"]/*' />
    [NativeTypeName("#define RPC_NT_GROUP_MEMBER_NOT_FOUND ((NTSTATUS)0xC002004BL)")]
    public const int RPC_NT_GROUP_MEMBER_NOT_FOUND = unchecked((int)(0xC002004B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_OBJECT"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_OBJECT ((NTSTATUS)0xC002004DL)")]
    public const int RPC_NT_INVALID_OBJECT = unchecked((int)(0xC002004D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_INTERFACES"]/*' />
    [NativeTypeName("#define RPC_NT_NO_INTERFACES ((NTSTATUS)0xC002004FL)")]
    public const int RPC_NT_NO_INTERFACES = unchecked((int)(0xC002004F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_CALL_CANCELLED"]/*' />
    [NativeTypeName("#define RPC_NT_CALL_CANCELLED ((NTSTATUS)0xC0020050L)")]
    public const int RPC_NT_CALL_CANCELLED = unchecked((int)(0xC0020050));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_BINDING_INCOMPLETE"]/*' />
    [NativeTypeName("#define RPC_NT_BINDING_INCOMPLETE ((NTSTATUS)0xC0020051L)")]
    public const int RPC_NT_BINDING_INCOMPLETE = unchecked((int)(0xC0020051));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_COMM_FAILURE"]/*' />
    [NativeTypeName("#define RPC_NT_COMM_FAILURE ((NTSTATUS)0xC0020052L)")]
    public const int RPC_NT_COMM_FAILURE = unchecked((int)(0xC0020052));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UNSUPPORTED_AUTHN_LEVEL"]/*' />
    [NativeTypeName("#define RPC_NT_UNSUPPORTED_AUTHN_LEVEL ((NTSTATUS)0xC0020053L)")]
    public const int RPC_NT_UNSUPPORTED_AUTHN_LEVEL = unchecked((int)(0xC0020053));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NO_PRINC_NAME"]/*' />
    [NativeTypeName("#define RPC_NT_NO_PRINC_NAME ((NTSTATUS)0xC0020054L)")]
    public const int RPC_NT_NO_PRINC_NAME = unchecked((int)(0xC0020054));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NOT_RPC_ERROR"]/*' />
    [NativeTypeName("#define RPC_NT_NOT_RPC_ERROR ((NTSTATUS)0xC0020055L)")]
    public const int RPC_NT_NOT_RPC_ERROR = unchecked((int)(0xC0020055));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_UUID_LOCAL_ONLY"]/*' />
    [NativeTypeName("#define RPC_NT_UUID_LOCAL_ONLY ((NTSTATUS)0x40020056L)")]
    public const int RPC_NT_UUID_LOCAL_ONLY = ((int)(0x40020056));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SEC_PKG_ERROR"]/*' />
    [NativeTypeName("#define RPC_NT_SEC_PKG_ERROR ((NTSTATUS)0xC0020057L)")]
    public const int RPC_NT_SEC_PKG_ERROR = unchecked((int)(0xC0020057));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_NOT_CANCELLED"]/*' />
    [NativeTypeName("#define RPC_NT_NOT_CANCELLED ((NTSTATUS)0xC0020058L)")]
    public const int RPC_NT_NOT_CANCELLED = unchecked((int)(0xC0020058));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_ES_ACTION"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_ES_ACTION ((NTSTATUS)0xC0030059L)")]
    public const int RPC_NT_INVALID_ES_ACTION = unchecked((int)(0xC0030059));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_WRONG_ES_VERSION"]/*' />
    [NativeTypeName("#define RPC_NT_WRONG_ES_VERSION ((NTSTATUS)0xC003005AL)")]
    public const int RPC_NT_WRONG_ES_VERSION = unchecked((int)(0xC003005A));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_WRONG_STUB_VERSION"]/*' />
    [NativeTypeName("#define RPC_NT_WRONG_STUB_VERSION ((NTSTATUS)0xC003005BL)")]
    public const int RPC_NT_WRONG_STUB_VERSION = unchecked((int)(0xC003005B));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_PIPE_OBJECT"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_PIPE_OBJECT ((NTSTATUS)0xC003005CL)")]
    public const int RPC_NT_INVALID_PIPE_OBJECT = unchecked((int)(0xC003005C));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_PIPE_OPERATION"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_PIPE_OPERATION ((NTSTATUS)0xC003005DL)")]
    public const int RPC_NT_INVALID_PIPE_OPERATION = unchecked((int)(0xC003005D));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_WRONG_PIPE_VERSION"]/*' />
    [NativeTypeName("#define RPC_NT_WRONG_PIPE_VERSION ((NTSTATUS)0xC003005EL)")]
    public const int RPC_NT_WRONG_PIPE_VERSION = unchecked((int)(0xC003005E));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_PIPE_CLOSED"]/*' />
    [NativeTypeName("#define RPC_NT_PIPE_CLOSED ((NTSTATUS)0xC003005FL)")]
    public const int RPC_NT_PIPE_CLOSED = unchecked((int)(0xC003005F));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_PIPE_DISCIPLINE_ERROR"]/*' />
    [NativeTypeName("#define RPC_NT_PIPE_DISCIPLINE_ERROR ((NTSTATUS)0xC0030060L)")]
    public const int RPC_NT_PIPE_DISCIPLINE_ERROR = unchecked((int)(0xC0030060));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_PIPE_EMPTY"]/*' />
    [NativeTypeName("#define RPC_NT_PIPE_EMPTY ((NTSTATUS)0xC0030061L)")]
    public const int RPC_NT_PIPE_EMPTY = unchecked((int)(0xC0030061));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_ASYNC_HANDLE"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_ASYNC_HANDLE ((NTSTATUS)0xC0020062L)")]
    public const int RPC_NT_INVALID_ASYNC_HANDLE = unchecked((int)(0xC0020062));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_INVALID_ASYNC_CALL"]/*' />
    [NativeTypeName("#define RPC_NT_INVALID_ASYNC_CALL ((NTSTATUS)0xC0020063L)")]
    public const int RPC_NT_INVALID_ASYNC_CALL = unchecked((int)(0xC0020063));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_PROXY_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define RPC_NT_PROXY_ACCESS_DENIED ((NTSTATUS)0xC0020064L)")]
    public const int RPC_NT_PROXY_ACCESS_DENIED = unchecked((int)(0xC0020064));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_COOKIE_AUTH_FAILED"]/*' />
    [NativeTypeName("#define RPC_NT_COOKIE_AUTH_FAILED ((NTSTATUS)0xC0020065L)")]
    public const int RPC_NT_COOKIE_AUTH_FAILED = unchecked((int)(0xC0020065));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_NT_SEND_INCOMPLETE"]/*' />
    [NativeTypeName("#define RPC_NT_SEND_INCOMPLETE ((NTSTATUS)0x400200AFL)")]
    public const int RPC_NT_SEND_INCOMPLETE = ((int)(0x400200AF));
}
