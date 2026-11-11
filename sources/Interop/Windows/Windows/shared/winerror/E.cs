// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class E
{
    /// <include file='E.xml' path='doc/member[@name="E.E_CAMERA_ERROR_MIN"]/*' />
    [NativeTypeName("#define E_CAMERA_ERROR_MIN HRESULT_FROM_WIN32(6350)")]
    public const int E_CAMERA_ERROR_MIN = -2147018546;

    /// <include file='E.xml' path='doc/member[@name="E.E_CAMERA_ERROR_MAX"]/*' />
    [NativeTypeName("#define E_CAMERA_ERROR_MAX HRESULT_FROM_WIN32(6399)")]
    public const int E_CAMERA_ERROR_MAX = -2147018497;

    /// <include file='E.xml' path='doc/member[@name="E.E_NOT_SET"]/*' />
    [NativeTypeName("#define E_NOT_SET HRESULT_FROM_WIN32(ERROR_NOT_FOUND)")]
    public const int E_NOT_SET = -2147023728;

    /// <include file='E.xml' path='doc/member[@name="E.E_NOT_VALID_STATE"]/*' />
    [NativeTypeName("#define E_NOT_VALID_STATE HRESULT_FROM_WIN32(ERROR_INVALID_STATE)")]
    public const int E_NOT_VALID_STATE = -2147019873;

    /// <include file='E.xml' path='doc/member[@name="E.E_NOT_SUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define E_NOT_SUFFICIENT_BUFFER HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER)")]
    public const int E_NOT_SUFFICIENT_BUFFER = -2147024774;

    /// <include file='E.xml' path='doc/member[@name="E.E_TIME_SENSITIVE_THREAD"]/*' />
    [NativeTypeName("#define E_TIME_SENSITIVE_THREAD HRESULT_FROM_WIN32(ERROR_TIME_SENSITIVE_THREAD)")]
    public const int E_TIME_SENSITIVE_THREAD = -2147024474;

    /// <include file='E.xml' path='doc/member[@name="E.E_NO_TASK_QUEUE"]/*' />
    [NativeTypeName("#define E_NO_TASK_QUEUE HRESULT_FROM_WIN32(ERROR_NO_TASK_QUEUE)")]
    public const int E_NO_TASK_QUEUE = -2147024469;

    /// <include file='E.xml' path='doc/member[@name="E.E_UNEXPECTED"]/*' />
    [NativeTypeName("#define E_UNEXPECTED _HRESULT_TYPEDEF_(0x8000FFFFL)")]
    public const int E_UNEXPECTED = unchecked((int)(0x8000FFFF));

    /// <include file='E.xml' path='doc/member[@name="E.E_NOTIMPL"]/*' />
    [NativeTypeName("#define E_NOTIMPL _HRESULT_TYPEDEF_(0x80004001L)")]
    public const int E_NOTIMPL = unchecked((int)(0x80004001));

    /// <include file='E.xml' path='doc/member[@name="E.E_OUTOFMEMORY"]/*' />
    [NativeTypeName("#define E_OUTOFMEMORY _HRESULT_TYPEDEF_(0x8007000EL)")]
    public const int E_OUTOFMEMORY = unchecked((int)(0x8007000E));

    /// <include file='E.xml' path='doc/member[@name="E.E_INVALIDARG"]/*' />
    [NativeTypeName("#define E_INVALIDARG _HRESULT_TYPEDEF_(0x80070057L)")]
    public const int E_INVALIDARG = unchecked((int)(0x80070057));

    /// <include file='E.xml' path='doc/member[@name="E.E_NOINTERFACE"]/*' />
    [NativeTypeName("#define E_NOINTERFACE _HRESULT_TYPEDEF_(0x80004002L)")]
    public const int E_NOINTERFACE = unchecked((int)(0x80004002));

    /// <include file='E.xml' path='doc/member[@name="E.E_POINTER"]/*' />
    [NativeTypeName("#define E_POINTER _HRESULT_TYPEDEF_(0x80004003L)")]
    public const int E_POINTER = unchecked((int)(0x80004003));

    /// <include file='E.xml' path='doc/member[@name="E.E_HANDLE"]/*' />
    [NativeTypeName("#define E_HANDLE _HRESULT_TYPEDEF_(0x80070006L)")]
    public const int E_HANDLE = unchecked((int)(0x80070006));

    /// <include file='E.xml' path='doc/member[@name="E.E_ABORT"]/*' />
    [NativeTypeName("#define E_ABORT _HRESULT_TYPEDEF_(0x80004004L)")]
    public const int E_ABORT = unchecked((int)(0x80004004));

    /// <include file='E.xml' path='doc/member[@name="E.E_FAIL"]/*' />
    [NativeTypeName("#define E_FAIL _HRESULT_TYPEDEF_(0x80004005L)")]
    public const int E_FAIL = unchecked((int)(0x80004005));

    /// <include file='E.xml' path='doc/member[@name="E.E_ACCESSDENIED"]/*' />
    [NativeTypeName("#define E_ACCESSDENIED _HRESULT_TYPEDEF_(0x80070005L)")]
    public const int E_ACCESSDENIED = unchecked((int)(0x80070005));

    /// <include file='E.xml' path='doc/member[@name="E.E_PENDING"]/*' />
    [NativeTypeName("#define E_PENDING _HRESULT_TYPEDEF_(0x8000000AL)")]
    public const int E_PENDING = unchecked((int)(0x8000000A));

    /// <include file='E.xml' path='doc/member[@name="E.E_BOUNDS"]/*' />
    [NativeTypeName("#define E_BOUNDS _HRESULT_TYPEDEF_(0x8000000BL)")]
    public const int E_BOUNDS = unchecked((int)(0x8000000B));

    /// <include file='E.xml' path='doc/member[@name="E.E_CHANGED_STATE"]/*' />
    [NativeTypeName("#define E_CHANGED_STATE _HRESULT_TYPEDEF_(0x8000000CL)")]
    public const int E_CHANGED_STATE = unchecked((int)(0x8000000C));

    /// <include file='E.xml' path='doc/member[@name="E.E_ILLEGAL_STATE_CHANGE"]/*' />
    [NativeTypeName("#define E_ILLEGAL_STATE_CHANGE _HRESULT_TYPEDEF_(0x8000000DL)")]
    public const int E_ILLEGAL_STATE_CHANGE = unchecked((int)(0x8000000D));

    /// <include file='E.xml' path='doc/member[@name="E.E_ILLEGAL_METHOD_CALL"]/*' />
    [NativeTypeName("#define E_ILLEGAL_METHOD_CALL _HRESULT_TYPEDEF_(0x8000000EL)")]
    public const int E_ILLEGAL_METHOD_CALL = unchecked((int)(0x8000000E));

    /// <include file='E.xml' path='doc/member[@name="E.E_STRING_NOT_NULL_TERMINATED"]/*' />
    [NativeTypeName("#define E_STRING_NOT_NULL_TERMINATED _HRESULT_TYPEDEF_(0x80000017L)")]
    public const int E_STRING_NOT_NULL_TERMINATED = unchecked((int)(0x80000017));

    /// <include file='E.xml' path='doc/member[@name="E.E_ILLEGAL_DELEGATE_ASSIGNMENT"]/*' />
    [NativeTypeName("#define E_ILLEGAL_DELEGATE_ASSIGNMENT _HRESULT_TYPEDEF_(0x80000018L)")]
    public const int E_ILLEGAL_DELEGATE_ASSIGNMENT = unchecked((int)(0x80000018));

    /// <include file='E.xml' path='doc/member[@name="E.E_ASYNC_OPERATION_NOT_STARTED"]/*' />
    [NativeTypeName("#define E_ASYNC_OPERATION_NOT_STARTED _HRESULT_TYPEDEF_(0x80000019L)")]
    public const int E_ASYNC_OPERATION_NOT_STARTED = unchecked((int)(0x80000019));

    /// <include file='E.xml' path='doc/member[@name="E.E_APPLICATION_EXITING"]/*' />
    [NativeTypeName("#define E_APPLICATION_EXITING _HRESULT_TYPEDEF_(0x8000001AL)")]
    public const int E_APPLICATION_EXITING = unchecked((int)(0x8000001A));

    /// <include file='E.xml' path='doc/member[@name="E.E_APPLICATION_VIEW_EXITING"]/*' />
    [NativeTypeName("#define E_APPLICATION_VIEW_EXITING _HRESULT_TYPEDEF_(0x8000001BL)")]
    public const int E_APPLICATION_VIEW_EXITING = unchecked((int)(0x8000001B));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_CONTEXT_NOT_ACTIVATED"]/*' />
    [NativeTypeName("#define E_MBN_CONTEXT_NOT_ACTIVATED _HRESULT_TYPEDEF_(0x80548201L)")]
    public const int E_MBN_CONTEXT_NOT_ACTIVATED = unchecked((int)(0x80548201));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_BAD_SIM"]/*' />
    [NativeTypeName("#define E_MBN_BAD_SIM _HRESULT_TYPEDEF_(0x80548202L)")]
    public const int E_MBN_BAD_SIM = unchecked((int)(0x80548202));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_DATA_CLASS_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define E_MBN_DATA_CLASS_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80548203L)")]
    public const int E_MBN_DATA_CLASS_NOT_AVAILABLE = unchecked((int)(0x80548203));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_INVALID_ACCESS_STRING"]/*' />
    [NativeTypeName("#define E_MBN_INVALID_ACCESS_STRING _HRESULT_TYPEDEF_(0x80548204L)")]
    public const int E_MBN_INVALID_ACCESS_STRING = unchecked((int)(0x80548204));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_MAX_ACTIVATED_CONTEXTS"]/*' />
    [NativeTypeName("#define E_MBN_MAX_ACTIVATED_CONTEXTS _HRESULT_TYPEDEF_(0x80548205L)")]
    public const int E_MBN_MAX_ACTIVATED_CONTEXTS = unchecked((int)(0x80548205));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_PACKET_SVC_DETACHED"]/*' />
    [NativeTypeName("#define E_MBN_PACKET_SVC_DETACHED _HRESULT_TYPEDEF_(0x80548206L)")]
    public const int E_MBN_PACKET_SVC_DETACHED = unchecked((int)(0x80548206));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_PROVIDER_NOT_VISIBLE"]/*' />
    [NativeTypeName("#define E_MBN_PROVIDER_NOT_VISIBLE _HRESULT_TYPEDEF_(0x80548207L)")]
    public const int E_MBN_PROVIDER_NOT_VISIBLE = unchecked((int)(0x80548207));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_RADIO_POWER_OFF"]/*' />
    [NativeTypeName("#define E_MBN_RADIO_POWER_OFF _HRESULT_TYPEDEF_(0x80548208L)")]
    public const int E_MBN_RADIO_POWER_OFF = unchecked((int)(0x80548208));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SERVICE_NOT_ACTIVATED"]/*' />
    [NativeTypeName("#define E_MBN_SERVICE_NOT_ACTIVATED _HRESULT_TYPEDEF_(0x80548209L)")]
    public const int E_MBN_SERVICE_NOT_ACTIVATED = unchecked((int)(0x80548209));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SIM_NOT_INSERTED"]/*' />
    [NativeTypeName("#define E_MBN_SIM_NOT_INSERTED _HRESULT_TYPEDEF_(0x8054820AL)")]
    public const int E_MBN_SIM_NOT_INSERTED = unchecked((int)(0x8054820A));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_VOICE_CALL_IN_PROGRESS"]/*' />
    [NativeTypeName("#define E_MBN_VOICE_CALL_IN_PROGRESS _HRESULT_TYPEDEF_(0x8054820BL)")]
    public const int E_MBN_VOICE_CALL_IN_PROGRESS = unchecked((int)(0x8054820B));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_INVALID_CACHE"]/*' />
    [NativeTypeName("#define E_MBN_INVALID_CACHE _HRESULT_TYPEDEF_(0x8054820CL)")]
    public const int E_MBN_INVALID_CACHE = unchecked((int)(0x8054820C));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define E_MBN_NOT_REGISTERED _HRESULT_TYPEDEF_(0x8054820DL)")]
    public const int E_MBN_NOT_REGISTERED = unchecked((int)(0x8054820D));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_PROVIDERS_NOT_FOUND"]/*' />
    [NativeTypeName("#define E_MBN_PROVIDERS_NOT_FOUND _HRESULT_TYPEDEF_(0x8054820EL)")]
    public const int E_MBN_PROVIDERS_NOT_FOUND = unchecked((int)(0x8054820E));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_PIN_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_MBN_PIN_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8054820FL)")]
    public const int E_MBN_PIN_NOT_SUPPORTED = unchecked((int)(0x8054820F));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_PIN_REQUIRED"]/*' />
    [NativeTypeName("#define E_MBN_PIN_REQUIRED _HRESULT_TYPEDEF_(0x80548210L)")]
    public const int E_MBN_PIN_REQUIRED = unchecked((int)(0x80548210));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_PIN_DISABLED"]/*' />
    [NativeTypeName("#define E_MBN_PIN_DISABLED _HRESULT_TYPEDEF_(0x80548211L)")]
    public const int E_MBN_PIN_DISABLED = unchecked((int)(0x80548211));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_FAILURE"]/*' />
    [NativeTypeName("#define E_MBN_FAILURE _HRESULT_TYPEDEF_(0x80548212L)")]
    public const int E_MBN_FAILURE = unchecked((int)(0x80548212));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_INVALID_PROFILE"]/*' />
    [NativeTypeName("#define E_MBN_INVALID_PROFILE _HRESULT_TYPEDEF_(0x80548218L)")]
    public const int E_MBN_INVALID_PROFILE = unchecked((int)(0x80548218));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_DEFAULT_PROFILE_EXIST"]/*' />
    [NativeTypeName("#define E_MBN_DEFAULT_PROFILE_EXIST _HRESULT_TYPEDEF_(0x80548219L)")]
    public const int E_MBN_DEFAULT_PROFILE_EXIST = unchecked((int)(0x80548219));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_ENCODING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_MBN_SMS_ENCODING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80548220L)")]
    public const int E_MBN_SMS_ENCODING_NOT_SUPPORTED = unchecked((int)(0x80548220));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_FILTER_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_MBN_SMS_FILTER_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80548221L)")]
    public const int E_MBN_SMS_FILTER_NOT_SUPPORTED = unchecked((int)(0x80548221));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_INVALID_MEMORY_INDEX"]/*' />
    [NativeTypeName("#define E_MBN_SMS_INVALID_MEMORY_INDEX _HRESULT_TYPEDEF_(0x80548222L)")]
    public const int E_MBN_SMS_INVALID_MEMORY_INDEX = unchecked((int)(0x80548222));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_LANG_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_MBN_SMS_LANG_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80548223L)")]
    public const int E_MBN_SMS_LANG_NOT_SUPPORTED = unchecked((int)(0x80548223));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_MEMORY_FAILURE"]/*' />
    [NativeTypeName("#define E_MBN_SMS_MEMORY_FAILURE _HRESULT_TYPEDEF_(0x80548224L)")]
    public const int E_MBN_SMS_MEMORY_FAILURE = unchecked((int)(0x80548224));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_NETWORK_TIMEOUT"]/*' />
    [NativeTypeName("#define E_MBN_SMS_NETWORK_TIMEOUT _HRESULT_TYPEDEF_(0x80548225L)")]
    public const int E_MBN_SMS_NETWORK_TIMEOUT = unchecked((int)(0x80548225));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_UNKNOWN_SMSC_ADDRESS"]/*' />
    [NativeTypeName("#define E_MBN_SMS_UNKNOWN_SMSC_ADDRESS _HRESULT_TYPEDEF_(0x80548226L)")]
    public const int E_MBN_SMS_UNKNOWN_SMSC_ADDRESS = unchecked((int)(0x80548226));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_FORMAT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_MBN_SMS_FORMAT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80548227L)")]
    public const int E_MBN_SMS_FORMAT_NOT_SUPPORTED = unchecked((int)(0x80548227));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_OPERATION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define E_MBN_SMS_OPERATION_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80548228L)")]
    public const int E_MBN_SMS_OPERATION_NOT_ALLOWED = unchecked((int)(0x80548228));

    /// <include file='E.xml' path='doc/member[@name="E.E_MBN_SMS_MEMORY_FULL"]/*' />
    [NativeTypeName("#define E_MBN_SMS_MEMORY_FULL _HRESULT_TYPEDEF_(0x80548229L)")]
    public const int E_MBN_SMS_MEMORY_FULL = unchecked((int)(0x80548229));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80650001L)")]
    public const int E_BLUETOOTH_ATT_INVALID_HANDLE = unchecked((int)(0x80650001));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_READ_NOT_PERMITTED"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_READ_NOT_PERMITTED _HRESULT_TYPEDEF_(0x80650002L)")]
    public const int E_BLUETOOTH_ATT_READ_NOT_PERMITTED = unchecked((int)(0x80650002));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_WRITE_NOT_PERMITTED"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_WRITE_NOT_PERMITTED _HRESULT_TYPEDEF_(0x80650003L)")]
    public const int E_BLUETOOTH_ATT_WRITE_NOT_PERMITTED = unchecked((int)(0x80650003));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INVALID_PDU"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INVALID_PDU _HRESULT_TYPEDEF_(0x80650004L)")]
    public const int E_BLUETOOTH_ATT_INVALID_PDU = unchecked((int)(0x80650004));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INSUFFICIENT_AUTHENTICATION"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_AUTHENTICATION _HRESULT_TYPEDEF_(0x80650005L)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_AUTHENTICATION = unchecked((int)(0x80650005));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_REQUEST_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_REQUEST_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80650006L)")]
    public const int E_BLUETOOTH_ATT_REQUEST_NOT_SUPPORTED = unchecked((int)(0x80650006));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INVALID_OFFSET"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INVALID_OFFSET _HRESULT_TYPEDEF_(0x80650007L)")]
    public const int E_BLUETOOTH_ATT_INVALID_OFFSET = unchecked((int)(0x80650007));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INSUFFICIENT_AUTHORIZATION"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_AUTHORIZATION _HRESULT_TYPEDEF_(0x80650008L)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_AUTHORIZATION = unchecked((int)(0x80650008));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_PREPARE_QUEUE_FULL"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_PREPARE_QUEUE_FULL _HRESULT_TYPEDEF_(0x80650009L)")]
    public const int E_BLUETOOTH_ATT_PREPARE_QUEUE_FULL = unchecked((int)(0x80650009));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_ATTRIBUTE_NOT_FOUND"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_ATTRIBUTE_NOT_FOUND _HRESULT_TYPEDEF_(0x8065000AL)")]
    public const int E_BLUETOOTH_ATT_ATTRIBUTE_NOT_FOUND = unchecked((int)(0x8065000A));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_ATTRIBUTE_NOT_LONG"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_ATTRIBUTE_NOT_LONG _HRESULT_TYPEDEF_(0x8065000BL)")]
    public const int E_BLUETOOTH_ATT_ATTRIBUTE_NOT_LONG = unchecked((int)(0x8065000B));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE _HRESULT_TYPEDEF_(0x8065000CL)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE = unchecked((int)(0x8065000C));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH _HRESULT_TYPEDEF_(0x8065000DL)")]
    public const int E_BLUETOOTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH = unchecked((int)(0x8065000D));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_UNLIKELY"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_UNLIKELY _HRESULT_TYPEDEF_(0x8065000EL)")]
    public const int E_BLUETOOTH_ATT_UNLIKELY = unchecked((int)(0x8065000E));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION _HRESULT_TYPEDEF_(0x8065000FL)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION = unchecked((int)(0x8065000F));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_UNSUPPORTED_GROUP_TYPE"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_UNSUPPORTED_GROUP_TYPE _HRESULT_TYPEDEF_(0x80650010L)")]
    public const int E_BLUETOOTH_ATT_UNSUPPORTED_GROUP_TYPE = unchecked((int)(0x80650010));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_INSUFFICIENT_RESOURCES"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_RESOURCES _HRESULT_TYPEDEF_(0x80650011L)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_RESOURCES = unchecked((int)(0x80650011));

    /// <include file='E.xml' path='doc/member[@name="E.E_BLUETOOTH_ATT_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define E_BLUETOOTH_ATT_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x80651000L)")]
    public const int E_BLUETOOTH_ATT_UNKNOWN_ERROR = unchecked((int)(0x80651000));

    /// <include file='E.xml' path='doc/member[@name="E.E_AUDIO_ENGINE_NODE_NOT_FOUND"]/*' />
    [NativeTypeName("#define E_AUDIO_ENGINE_NODE_NOT_FOUND _HRESULT_TYPEDEF_(0x80660001L)")]
    public const int E_AUDIO_ENGINE_NODE_NOT_FOUND = unchecked((int)(0x80660001));

    /// <include file='E.xml' path='doc/member[@name="E.E_HDAUDIO_EMPTY_CONNECTION_LIST"]/*' />
    [NativeTypeName("#define E_HDAUDIO_EMPTY_CONNECTION_LIST _HRESULT_TYPEDEF_(0x80660002L)")]
    public const int E_HDAUDIO_EMPTY_CONNECTION_LIST = unchecked((int)(0x80660002));

    /// <include file='E.xml' path='doc/member[@name="E.E_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80660003L)")]
    public const int E_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED = unchecked((int)(0x80660003));

    /// <include file='E.xml' path='doc/member[@name="E.E_HDAUDIO_NO_LOGICAL_DEVICES_CREATED"]/*' />
    [NativeTypeName("#define E_HDAUDIO_NO_LOGICAL_DEVICES_CREATED _HRESULT_TYPEDEF_(0x80660004L)")]
    public const int E_HDAUDIO_NO_LOGICAL_DEVICES_CREATED = unchecked((int)(0x80660004));

    /// <include file='E.xml' path='doc/member[@name="E.E_HDAUDIO_NULL_LINKED_LIST_ENTRY"]/*' />
    [NativeTypeName("#define E_HDAUDIO_NULL_LINKED_LIST_ENTRY _HRESULT_TYPEDEF_(0x80660005L)")]
    public const int E_HDAUDIO_NULL_LINKED_LIST_ENTRY = unchecked((int)(0x80660005));

    /// <include file='E.xml' path='doc/member[@name="E.E_SOUNDWIRE_COMMAND_ABORTED"]/*' />
    [NativeTypeName("#define E_SOUNDWIRE_COMMAND_ABORTED _HRESULT_TYPEDEF_(0x80660006L)")]
    public const int E_SOUNDWIRE_COMMAND_ABORTED = unchecked((int)(0x80660006));

    /// <include file='E.xml' path='doc/member[@name="E.E_SOUNDWIRE_COMMAND_IGNORED"]/*' />
    [NativeTypeName("#define E_SOUNDWIRE_COMMAND_IGNORED _HRESULT_TYPEDEF_(0x80660007L)")]
    public const int E_SOUNDWIRE_COMMAND_IGNORED = unchecked((int)(0x80660007));

    /// <include file='E.xml' path='doc/member[@name="E.E_SOUNDWIRE_COMMAND_FAILED"]/*' />
    [NativeTypeName("#define E_SOUNDWIRE_COMMAND_FAILED _HRESULT_TYPEDEF_(0x80660008L)")]
    public const int E_SOUNDWIRE_COMMAND_FAILED = unchecked((int)(0x80660008));

    /// <include file='E.xml' path='doc/member[@name="E.E_MONITOR_RESOLUTION_TOO_LOW"]/*' />
    [NativeTypeName("#define E_MONITOR_RESOLUTION_TOO_LOW _HRESULT_TYPEDEF_(0x80270250L)")]
    public const int E_MONITOR_RESOLUTION_TOO_LOW = unchecked((int)(0x80270250));

    /// <include file='E.xml' path='doc/member[@name="E.E_ELEVATED_ACTIVATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_ELEVATED_ACTIVATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80270251L)")]
    public const int E_ELEVATED_ACTIVATION_NOT_SUPPORTED = unchecked((int)(0x80270251));

    /// <include file='E.xml' path='doc/member[@name="E.E_UAC_DISABLED"]/*' />
    [NativeTypeName("#define E_UAC_DISABLED _HRESULT_TYPEDEF_(0x80270252L)")]
    public const int E_UAC_DISABLED = unchecked((int)(0x80270252));

    /// <include file='E.xml' path='doc/member[@name="E.E_FULL_ADMIN_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_FULL_ADMIN_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80270253L)")]
    public const int E_FULL_ADMIN_NOT_SUPPORTED = unchecked((int)(0x80270253));

    /// <include file='E.xml' path='doc/member[@name="E.E_APPLICATION_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define E_APPLICATION_NOT_REGISTERED _HRESULT_TYPEDEF_(0x80270254L)")]
    public const int E_APPLICATION_NOT_REGISTERED = unchecked((int)(0x80270254));

    /// <include file='E.xml' path='doc/member[@name="E.E_MULTIPLE_EXTENSIONS_FOR_APPLICATION"]/*' />
    [NativeTypeName("#define E_MULTIPLE_EXTENSIONS_FOR_APPLICATION _HRESULT_TYPEDEF_(0x80270255L)")]
    public const int E_MULTIPLE_EXTENSIONS_FOR_APPLICATION = unchecked((int)(0x80270255));

    /// <include file='E.xml' path='doc/member[@name="E.E_MULTIPLE_PACKAGES_FOR_FAMILY"]/*' />
    [NativeTypeName("#define E_MULTIPLE_PACKAGES_FOR_FAMILY _HRESULT_TYPEDEF_(0x80270256L)")]
    public const int E_MULTIPLE_PACKAGES_FOR_FAMILY = unchecked((int)(0x80270256));

    /// <include file='E.xml' path='doc/member[@name="E.E_APPLICATION_MANAGER_NOT_RUNNING"]/*' />
    [NativeTypeName("#define E_APPLICATION_MANAGER_NOT_RUNNING _HRESULT_TYPEDEF_(0x80270257L)")]
    public const int E_APPLICATION_MANAGER_NOT_RUNNING = unchecked((int)(0x80270257));

    /// <include file='E.xml' path='doc/member[@name="E.E_APPLICATION_ACTIVATION_TIMED_OUT"]/*' />
    [NativeTypeName("#define E_APPLICATION_ACTIVATION_TIMED_OUT _HRESULT_TYPEDEF_(0x8027025AL)")]
    public const int E_APPLICATION_ACTIVATION_TIMED_OUT = unchecked((int)(0x8027025A));

    /// <include file='E.xml' path='doc/member[@name="E.E_APPLICATION_ACTIVATION_EXEC_FAILURE"]/*' />
    [NativeTypeName("#define E_APPLICATION_ACTIVATION_EXEC_FAILURE _HRESULT_TYPEDEF_(0x8027025BL)")]
    public const int E_APPLICATION_ACTIVATION_EXEC_FAILURE = unchecked((int)(0x8027025B));

    /// <include file='E.xml' path='doc/member[@name="E.E_APPLICATION_TEMPORARY_LICENSE_ERROR"]/*' />
    [NativeTypeName("#define E_APPLICATION_TEMPORARY_LICENSE_ERROR _HRESULT_TYPEDEF_(0x8027025CL)")]
    public const int E_APPLICATION_TEMPORARY_LICENSE_ERROR = unchecked((int)(0x8027025C));

    /// <include file='E.xml' path='doc/member[@name="E.E_APPLICATION_TRIAL_LICENSE_EXPIRED"]/*' />
    [NativeTypeName("#define E_APPLICATION_TRIAL_LICENSE_EXPIRED _HRESULT_TYPEDEF_(0x8027025DL)")]
    public const int E_APPLICATION_TRIAL_LICENSE_EXPIRED = unchecked((int)(0x8027025D));

    /// <include file='E.xml' path='doc/member[@name="E.E_SKYDRIVE_ROOT_TARGET_FILE_SYSTEM_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_SKYDRIVE_ROOT_TARGET_FILE_SYSTEM_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80270260L)")]
    public const int E_SKYDRIVE_ROOT_TARGET_FILE_SYSTEM_NOT_SUPPORTED = unchecked((int)(0x80270260));

    /// <include file='E.xml' path='doc/member[@name="E.E_SKYDRIVE_ROOT_TARGET_OVERLAP"]/*' />
    [NativeTypeName("#define E_SKYDRIVE_ROOT_TARGET_OVERLAP _HRESULT_TYPEDEF_(0x80270261L)")]
    public const int E_SKYDRIVE_ROOT_TARGET_OVERLAP = unchecked((int)(0x80270261));

    /// <include file='E.xml' path='doc/member[@name="E.E_SKYDRIVE_ROOT_TARGET_CANNOT_INDEX"]/*' />
    [NativeTypeName("#define E_SKYDRIVE_ROOT_TARGET_CANNOT_INDEX _HRESULT_TYPEDEF_(0x80270262L)")]
    public const int E_SKYDRIVE_ROOT_TARGET_CANNOT_INDEX = unchecked((int)(0x80270262));

    /// <include file='E.xml' path='doc/member[@name="E.E_SKYDRIVE_FILE_NOT_UPLOADED"]/*' />
    [NativeTypeName("#define E_SKYDRIVE_FILE_NOT_UPLOADED _HRESULT_TYPEDEF_(0x80270263L)")]
    public const int E_SKYDRIVE_FILE_NOT_UPLOADED = unchecked((int)(0x80270263));

    /// <include file='E.xml' path='doc/member[@name="E.E_SKYDRIVE_UPDATE_AVAILABILITY_FAIL"]/*' />
    [NativeTypeName("#define E_SKYDRIVE_UPDATE_AVAILABILITY_FAIL _HRESULT_TYPEDEF_(0x80270264L)")]
    public const int E_SKYDRIVE_UPDATE_AVAILABILITY_FAIL = unchecked((int)(0x80270264));

    /// <include file='E.xml' path='doc/member[@name="E.E_SKYDRIVE_ROOT_TARGET_VOLUME_ROOT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_SKYDRIVE_ROOT_TARGET_VOLUME_ROOT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80270265L)")]
    public const int E_SKYDRIVE_ROOT_TARGET_VOLUME_ROOT_NOT_SUPPORTED = unchecked((int)(0x80270265));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_FILE_SIZE_OVER_LIMIT"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_FILE_SIZE_OVER_LIMIT _HRESULT_TYPEDEF_(0x8802B001L)")]
    public const int E_SYNCENGINE_FILE_SIZE_OVER_LIMIT = unchecked((int)(0x8802B001));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_FILE_SIZE_EXCEEDS_REMAINING_QUOTA"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_FILE_SIZE_EXCEEDS_REMAINING_QUOTA _HRESULT_TYPEDEF_(0x8802B002L)")]
    public const int E_SYNCENGINE_FILE_SIZE_EXCEEDS_REMAINING_QUOTA = unchecked((int)(0x8802B002));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_UNSUPPORTED_FILE_NAME"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_UNSUPPORTED_FILE_NAME _HRESULT_TYPEDEF_(0x8802B003L)")]
    public const int E_SYNCENGINE_UNSUPPORTED_FILE_NAME = unchecked((int)(0x8802B003));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_FOLDER_ITEM_COUNT_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_FOLDER_ITEM_COUNT_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x8802B004L)")]
    public const int E_SYNCENGINE_FOLDER_ITEM_COUNT_LIMIT_EXCEEDED = unchecked((int)(0x8802B004));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_FILE_SYNC_PARTNER_ERROR"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_FILE_SYNC_PARTNER_ERROR _HRESULT_TYPEDEF_(0x8802B005L)")]
    public const int E_SYNCENGINE_FILE_SYNC_PARTNER_ERROR = unchecked((int)(0x8802B005));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_SYNC_PAUSED_BY_SERVICE"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_SYNC_PAUSED_BY_SERVICE _HRESULT_TYPEDEF_(0x8802B006L)")]
    public const int E_SYNCENGINE_SYNC_PAUSED_BY_SERVICE = unchecked((int)(0x8802B006));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_FILE_IDENTIFIER_UNKNOWN"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_FILE_IDENTIFIER_UNKNOWN _HRESULT_TYPEDEF_(0x8802C002L)")]
    public const int E_SYNCENGINE_FILE_IDENTIFIER_UNKNOWN = unchecked((int)(0x8802C002));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_SERVICE_AUTHENTICATION_FAILED"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_SERVICE_AUTHENTICATION_FAILED _HRESULT_TYPEDEF_(0x8802C003L)")]
    public const int E_SYNCENGINE_SERVICE_AUTHENTICATION_FAILED = unchecked((int)(0x8802C003));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_UNKNOWN_SERVICE_ERROR"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_UNKNOWN_SERVICE_ERROR _HRESULT_TYPEDEF_(0x8802C004L)")]
    public const int E_SYNCENGINE_UNKNOWN_SERVICE_ERROR = unchecked((int)(0x8802C004));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_SERVICE_RETURNED_UNEXPECTED_SIZE"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_SERVICE_RETURNED_UNEXPECTED_SIZE _HRESULT_TYPEDEF_(0x8802C005L)")]
    public const int E_SYNCENGINE_SERVICE_RETURNED_UNEXPECTED_SIZE = unchecked((int)(0x8802C005));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_REQUEST_BLOCKED_BY_SERVICE"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_REQUEST_BLOCKED_BY_SERVICE _HRESULT_TYPEDEF_(0x8802C006L)")]
    public const int E_SYNCENGINE_REQUEST_BLOCKED_BY_SERVICE = unchecked((int)(0x8802C006));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_REQUEST_BLOCKED_DUE_TO_CLIENT_ERROR"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_REQUEST_BLOCKED_DUE_TO_CLIENT_ERROR _HRESULT_TYPEDEF_(0x8802C007L)")]
    public const int E_SYNCENGINE_REQUEST_BLOCKED_DUE_TO_CLIENT_ERROR = unchecked((int)(0x8802C007));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_FOLDER_INACCESSIBLE"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_FOLDER_INACCESSIBLE _HRESULT_TYPEDEF_(0x8802D001L)")]
    public const int E_SYNCENGINE_FOLDER_INACCESSIBLE = unchecked((int)(0x8802D001));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_UNSUPPORTED_FOLDER_NAME"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_UNSUPPORTED_FOLDER_NAME _HRESULT_TYPEDEF_(0x8802D002L)")]
    public const int E_SYNCENGINE_UNSUPPORTED_FOLDER_NAME = unchecked((int)(0x8802D002));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_UNSUPPORTED_MARKET"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_UNSUPPORTED_MARKET _HRESULT_TYPEDEF_(0x8802D003L)")]
    public const int E_SYNCENGINE_UNSUPPORTED_MARKET = unchecked((int)(0x8802D003));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_PATH_LENGTH_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_PATH_LENGTH_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x8802D004L)")]
    public const int E_SYNCENGINE_PATH_LENGTH_LIMIT_EXCEEDED = unchecked((int)(0x8802D004));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_REMOTE_PATH_LENGTH_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_REMOTE_PATH_LENGTH_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x8802D005L)")]
    public const int E_SYNCENGINE_REMOTE_PATH_LENGTH_LIMIT_EXCEEDED = unchecked((int)(0x8802D005));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_CLIENT_UPDATE_NEEDED"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_CLIENT_UPDATE_NEEDED _HRESULT_TYPEDEF_(0x8802D006L)")]
    public const int E_SYNCENGINE_CLIENT_UPDATE_NEEDED = unchecked((int)(0x8802D006));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_PROXY_AUTHENTICATION_REQUIRED"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_PROXY_AUTHENTICATION_REQUIRED _HRESULT_TYPEDEF_(0x8802D007L)")]
    public const int E_SYNCENGINE_PROXY_AUTHENTICATION_REQUIRED = unchecked((int)(0x8802D007));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_STORAGE_SERVICE_PROVISIONING_FAILED"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_STORAGE_SERVICE_PROVISIONING_FAILED _HRESULT_TYPEDEF_(0x8802D008L)")]
    public const int E_SYNCENGINE_STORAGE_SERVICE_PROVISIONING_FAILED = unchecked((int)(0x8802D008));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_UNSUPPORTED_REPARSE_POINT"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_UNSUPPORTED_REPARSE_POINT _HRESULT_TYPEDEF_(0x8802D009L)")]
    public const int E_SYNCENGINE_UNSUPPORTED_REPARSE_POINT = unchecked((int)(0x8802D009));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_STORAGE_SERVICE_BLOCKED"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_STORAGE_SERVICE_BLOCKED _HRESULT_TYPEDEF_(0x8802D00AL)")]
    public const int E_SYNCENGINE_STORAGE_SERVICE_BLOCKED = unchecked((int)(0x8802D00A));

    /// <include file='E.xml' path='doc/member[@name="E.E_SYNCENGINE_FOLDER_IN_REDIRECTION"]/*' />
    [NativeTypeName("#define E_SYNCENGINE_FOLDER_IN_REDIRECTION _HRESULT_TYPEDEF_(0x8802D00BL)")]
    public const int E_SYNCENGINE_FOLDER_IN_REDIRECTION = unchecked((int)(0x8802D00B));

    /// <include file='E.xml' path='doc/member[@name="E.E_INVALID_PROTOCOL_OPERATION"]/*' />
    [NativeTypeName("#define E_INVALID_PROTOCOL_OPERATION _HRESULT_TYPEDEF_(0x83760001L)")]
    public const int E_INVALID_PROTOCOL_OPERATION = unchecked((int)(0x83760001));

    /// <include file='E.xml' path='doc/member[@name="E.E_INVALID_PROTOCOL_FORMAT"]/*' />
    [NativeTypeName("#define E_INVALID_PROTOCOL_FORMAT _HRESULT_TYPEDEF_(0x83760002L)")]
    public const int E_INVALID_PROTOCOL_FORMAT = unchecked((int)(0x83760002));

    /// <include file='E.xml' path='doc/member[@name="E.E_PROTOCOL_EXTENSIONS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_PROTOCOL_EXTENSIONS_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x83760003L)")]
    public const int E_PROTOCOL_EXTENSIONS_NOT_SUPPORTED = unchecked((int)(0x83760003));

    /// <include file='E.xml' path='doc/member[@name="E.E_SUBPROTOCOL_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_SUBPROTOCOL_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x83760004L)")]
    public const int E_SUBPROTOCOL_NOT_SUPPORTED = unchecked((int)(0x83760004));

    /// <include file='E.xml' path='doc/member[@name="E.E_PROTOCOL_VERSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define E_PROTOCOL_VERSION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x83760005L)")]
    public const int E_PROTOCOL_VERSION_NOT_SUPPORTED = unchecked((int)(0x83760005));
}
