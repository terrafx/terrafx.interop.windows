// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mferror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MF
{
    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PLATFORM_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define MF_E_PLATFORM_NOT_INITIALIZED _HRESULT_TYPEDEF_(0xC00D36B0L)")]
    public const int MF_E_PLATFORM_NOT_INITIALIZED = unchecked((int)(0xC00D36B0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_BUFFERTOOSMALL"]/*' />
    [NativeTypeName("#define MF_E_BUFFERTOOSMALL _HRESULT_TYPEDEF_(0xC00D36B1L)")]
    public const int MF_E_BUFFERTOOSMALL = unchecked((int)(0xC00D36B1));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALIDREQUEST"]/*' />
    [NativeTypeName("#define MF_E_INVALIDREQUEST _HRESULT_TYPEDEF_(0xC00D36B2L)")]
    public const int MF_E_INVALIDREQUEST = unchecked((int)(0xC00D36B2));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALIDSTREAMNUMBER"]/*' />
    [NativeTypeName("#define MF_E_INVALIDSTREAMNUMBER _HRESULT_TYPEDEF_(0xC00D36B3L)")]
    public const int MF_E_INVALIDSTREAMNUMBER = unchecked((int)(0xC00D36B3));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALIDMEDIATYPE"]/*' />
    [NativeTypeName("#define MF_E_INVALIDMEDIATYPE _HRESULT_TYPEDEF_(0xC00D36B4L)")]
    public const int MF_E_INVALIDMEDIATYPE = unchecked((int)(0xC00D36B4));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NOTACCEPTING"]/*' />
    [NativeTypeName("#define MF_E_NOTACCEPTING _HRESULT_TYPEDEF_(0xC00D36B5L)")]
    public const int MF_E_NOTACCEPTING = unchecked((int)(0xC00D36B5));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define MF_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0xC00D36B6L)")]
    public const int MF_E_NOT_INITIALIZED = unchecked((int)(0xC00D36B6));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_REPRESENTATION"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_REPRESENTATION _HRESULT_TYPEDEF_(0xC00D36B7L)")]
    public const int MF_E_UNSUPPORTED_REPRESENTATION = unchecked((int)(0xC00D36B7));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_MORE_TYPES"]/*' />
    [NativeTypeName("#define MF_E_NO_MORE_TYPES _HRESULT_TYPEDEF_(0xC00D36B9L)")]
    public const int MF_E_NO_MORE_TYPES = unchecked((int)(0xC00D36B9));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_SERVICE"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_SERVICE _HRESULT_TYPEDEF_(0xC00D36BAL)")]
    public const int MF_E_UNSUPPORTED_SERVICE = unchecked((int)(0xC00D36BA));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNEXPECTED"]/*' />
    [NativeTypeName("#define MF_E_UNEXPECTED _HRESULT_TYPEDEF_(0xC00D36BBL)")]
    public const int MF_E_UNEXPECTED = unchecked((int)(0xC00D36BB));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALIDNAME"]/*' />
    [NativeTypeName("#define MF_E_INVALIDNAME _HRESULT_TYPEDEF_(0xC00D36BCL)")]
    public const int MF_E_INVALIDNAME = unchecked((int)(0xC00D36BC));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALIDTYPE"]/*' />
    [NativeTypeName("#define MF_E_INVALIDTYPE _HRESULT_TYPEDEF_(0xC00D36BDL)")]
    public const int MF_E_INVALIDTYPE = unchecked((int)(0xC00D36BD));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_FILE_FORMAT"]/*' />
    [NativeTypeName("#define MF_E_INVALID_FILE_FORMAT _HRESULT_TYPEDEF_(0xC00D36BEL)")]
    public const int MF_E_INVALID_FILE_FORMAT = unchecked((int)(0xC00D36BE));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALIDINDEX"]/*' />
    [NativeTypeName("#define MF_E_INVALIDINDEX _HRESULT_TYPEDEF_(0xC00D36BFL)")]
    public const int MF_E_INVALIDINDEX = unchecked((int)(0xC00D36BF));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_TIMESTAMP"]/*' />
    [NativeTypeName("#define MF_E_INVALID_TIMESTAMP _HRESULT_TYPEDEF_(0xC00D36C0L)")]
    public const int MF_E_INVALID_TIMESTAMP = unchecked((int)(0xC00D36C0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_SCHEME"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_SCHEME _HRESULT_TYPEDEF_(0xC00D36C3L)")]
    public const int MF_E_UNSUPPORTED_SCHEME = unchecked((int)(0xC00D36C3));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_BYTESTREAM_TYPE"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_BYTESTREAM_TYPE _HRESULT_TYPEDEF_(0xC00D36C4L)")]
    public const int MF_E_UNSUPPORTED_BYTESTREAM_TYPE = unchecked((int)(0xC00D36C4));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_TIME_FORMAT"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_TIME_FORMAT _HRESULT_TYPEDEF_(0xC00D36C5L)")]
    public const int MF_E_UNSUPPORTED_TIME_FORMAT = unchecked((int)(0xC00D36C5));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_SAMPLE_TIMESTAMP"]/*' />
    [NativeTypeName("#define MF_E_NO_SAMPLE_TIMESTAMP _HRESULT_TYPEDEF_(0xC00D36C8L)")]
    public const int MF_E_NO_SAMPLE_TIMESTAMP = unchecked((int)(0xC00D36C8));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_SAMPLE_DURATION"]/*' />
    [NativeTypeName("#define MF_E_NO_SAMPLE_DURATION _HRESULT_TYPEDEF_(0xC00D36C9L)")]
    public const int MF_E_NO_SAMPLE_DURATION = unchecked((int)(0xC00D36C9));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_STREAM_DATA"]/*' />
    [NativeTypeName("#define MF_E_INVALID_STREAM_DATA _HRESULT_TYPEDEF_(0xC00D36CBL)")]
    public const int MF_E_INVALID_STREAM_DATA = unchecked((int)(0xC00D36CB));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_RT_UNAVAILABLE"]/*' />
    [NativeTypeName("#define MF_E_RT_UNAVAILABLE _HRESULT_TYPEDEF_(0xC00D36CFL)")]
    public const int MF_E_RT_UNAVAILABLE = unchecked((int)(0xC00D36CF));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_RATE"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_RATE _HRESULT_TYPEDEF_(0xC00D36D0L)")]
    public const int MF_E_UNSUPPORTED_RATE = unchecked((int)(0xC00D36D0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_THINNING_UNSUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_THINNING_UNSUPPORTED _HRESULT_TYPEDEF_(0xC00D36D1L)")]
    public const int MF_E_THINNING_UNSUPPORTED = unchecked((int)(0xC00D36D1));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_REVERSE_UNSUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_REVERSE_UNSUPPORTED _HRESULT_TYPEDEF_(0xC00D36D2L)")]
    public const int MF_E_REVERSE_UNSUPPORTED = unchecked((int)(0xC00D36D2));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_RATE_TRANSITION"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_RATE_TRANSITION _HRESULT_TYPEDEF_(0xC00D36D3L)")]
    public const int MF_E_UNSUPPORTED_RATE_TRANSITION = unchecked((int)(0xC00D36D3));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_RATE_CHANGE_PREEMPTED"]/*' />
    [NativeTypeName("#define MF_E_RATE_CHANGE_PREEMPTED _HRESULT_TYPEDEF_(0xC00D36D4L)")]
    public const int MF_E_RATE_CHANGE_PREEMPTED = unchecked((int)(0xC00D36D4));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NOT_FOUND"]/*' />
    [NativeTypeName("#define MF_E_NOT_FOUND _HRESULT_TYPEDEF_(0xC00D36D5L)")]
    public const int MF_E_NOT_FOUND = unchecked((int)(0xC00D36D5));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define MF_E_NOT_AVAILABLE _HRESULT_TYPEDEF_(0xC00D36D6L)")]
    public const int MF_E_NOT_AVAILABLE = unchecked((int)(0xC00D36D6));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_CLOCK"]/*' />
    [NativeTypeName("#define MF_E_NO_CLOCK _HRESULT_TYPEDEF_(0xC00D36D7L)")]
    public const int MF_E_NO_CLOCK = unchecked((int)(0xC00D36D7));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_MULTIPLE_BEGIN"]/*' />
    [NativeTypeName("#define MF_S_MULTIPLE_BEGIN _HRESULT_TYPEDEF_(0x000D36D8L)")]
    public const int MF_S_MULTIPLE_BEGIN = ((int)(0x000D36D8));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MULTIPLE_BEGIN"]/*' />
    [NativeTypeName("#define MF_E_MULTIPLE_BEGIN _HRESULT_TYPEDEF_(0xC00D36D9L)")]
    public const int MF_E_MULTIPLE_BEGIN = unchecked((int)(0xC00D36D9));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MULTIPLE_SUBSCRIBERS"]/*' />
    [NativeTypeName("#define MF_E_MULTIPLE_SUBSCRIBERS _HRESULT_TYPEDEF_(0xC00D36DAL)")]
    public const int MF_E_MULTIPLE_SUBSCRIBERS = unchecked((int)(0xC00D36DA));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TIMER_ORPHANED"]/*' />
    [NativeTypeName("#define MF_E_TIMER_ORPHANED _HRESULT_TYPEDEF_(0xC00D36DBL)")]
    public const int MF_E_TIMER_ORPHANED = unchecked((int)(0xC00D36DB));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_STATE_TRANSITION_PENDING"]/*' />
    [NativeTypeName("#define MF_E_STATE_TRANSITION_PENDING _HRESULT_TYPEDEF_(0xC00D36DCL)")]
    public const int MF_E_STATE_TRANSITION_PENDING = unchecked((int)(0xC00D36DC));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_STATE_TRANSITION"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_STATE_TRANSITION _HRESULT_TYPEDEF_(0xC00D36DDL)")]
    public const int MF_E_UNSUPPORTED_STATE_TRANSITION = unchecked((int)(0xC00D36DD));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNRECOVERABLE_ERROR_OCCURRED"]/*' />
    [NativeTypeName("#define MF_E_UNRECOVERABLE_ERROR_OCCURRED _HRESULT_TYPEDEF_(0xC00D36DEL)")]
    public const int MF_E_UNRECOVERABLE_ERROR_OCCURRED = unchecked((int)(0xC00D36DE));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SAMPLE_HAS_TOO_MANY_BUFFERS"]/*' />
    [NativeTypeName("#define MF_E_SAMPLE_HAS_TOO_MANY_BUFFERS _HRESULT_TYPEDEF_(0xC00D36DFL)")]
    public const int MF_E_SAMPLE_HAS_TOO_MANY_BUFFERS = unchecked((int)(0xC00D36DF));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SAMPLE_NOT_WRITABLE"]/*' />
    [NativeTypeName("#define MF_E_SAMPLE_NOT_WRITABLE _HRESULT_TYPEDEF_(0xC00D36E0L)")]
    public const int MF_E_SAMPLE_NOT_WRITABLE = unchecked((int)(0xC00D36E0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_KEY"]/*' />
    [NativeTypeName("#define MF_E_INVALID_KEY _HRESULT_TYPEDEF_(0xC00D36E2L)")]
    public const int MF_E_INVALID_KEY = unchecked((int)(0xC00D36E2));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_BAD_STARTUP_VERSION"]/*' />
    [NativeTypeName("#define MF_E_BAD_STARTUP_VERSION _HRESULT_TYPEDEF_(0xC00D36E3L)")]
    public const int MF_E_BAD_STARTUP_VERSION = unchecked((int)(0xC00D36E3));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_CAPTION"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_CAPTION _HRESULT_TYPEDEF_(0xC00D36E4L)")]
    public const int MF_E_UNSUPPORTED_CAPTION = unchecked((int)(0xC00D36E4));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_POSITION"]/*' />
    [NativeTypeName("#define MF_E_INVALID_POSITION _HRESULT_TYPEDEF_(0xC00D36E5L)")]
    public const int MF_E_INVALID_POSITION = unchecked((int)(0xC00D36E5));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ATTRIBUTENOTFOUND"]/*' />
    [NativeTypeName("#define MF_E_ATTRIBUTENOTFOUND _HRESULT_TYPEDEF_(0xC00D36E6L)")]
    public const int MF_E_ATTRIBUTENOTFOUND = unchecked((int)(0xC00D36E6));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_TYPE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_TYPE_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC00D36E7L)")]
    public const int MF_E_PROPERTY_TYPE_NOT_ALLOWED = unchecked((int)(0xC00D36E7));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_TYPE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_TYPE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D36E8L)")]
    public const int MF_E_PROPERTY_TYPE_NOT_SUPPORTED = unchecked((int)(0xC00D36E8));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_EMPTY"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_EMPTY _HRESULT_TYPEDEF_(0xC00D36E9L)")]
    public const int MF_E_PROPERTY_EMPTY = unchecked((int)(0xC00D36E9));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_NOT_EMPTY"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_NOT_EMPTY _HRESULT_TYPEDEF_(0xC00D36EAL)")]
    public const int MF_E_PROPERTY_NOT_EMPTY = unchecked((int)(0xC00D36EA));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_VECTOR_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_VECTOR_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC00D36EBL)")]
    public const int MF_E_PROPERTY_VECTOR_NOT_ALLOWED = unchecked((int)(0xC00D36EB));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_VECTOR_REQUIRED"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_VECTOR_REQUIRED _HRESULT_TYPEDEF_(0xC00D36ECL)")]
    public const int MF_E_PROPERTY_VECTOR_REQUIRED = unchecked((int)(0xC00D36EC));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_OPERATION_CANCELLED"]/*' />
    [NativeTypeName("#define MF_E_OPERATION_CANCELLED _HRESULT_TYPEDEF_(0xC00D36EDL)")]
    public const int MF_E_OPERATION_CANCELLED = unchecked((int)(0xC00D36ED));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_BYTESTREAM_NOT_SEEKABLE"]/*' />
    [NativeTypeName("#define MF_E_BYTESTREAM_NOT_SEEKABLE _HRESULT_TYPEDEF_(0xC00D36EEL)")]
    public const int MF_E_BYTESTREAM_NOT_SEEKABLE = unchecked((int)(0xC00D36EE));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_DISABLED_IN_SAFEMODE"]/*' />
    [NativeTypeName("#define MF_E_DISABLED_IN_SAFEMODE _HRESULT_TYPEDEF_(0xC00D36EFL)")]
    public const int MF_E_DISABLED_IN_SAFEMODE = unchecked((int)(0xC00D36EF));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CANNOT_PARSE_BYTESTREAM"]/*' />
    [NativeTypeName("#define MF_E_CANNOT_PARSE_BYTESTREAM _HRESULT_TYPEDEF_(0xC00D36F0L)")]
    public const int MF_E_CANNOT_PARSE_BYTESTREAM = unchecked((int)(0xC00D36F0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS"]/*' />
    [NativeTypeName("#define MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS _HRESULT_TYPEDEF_(0xC00D36F1L)")]
    public const int MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS = unchecked((int)(0xC00D36F1));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIAPROC_WRONGSTATE"]/*' />
    [NativeTypeName("#define MF_E_MEDIAPROC_WRONGSTATE _HRESULT_TYPEDEF_(0xC00D36F2L)")]
    public const int MF_E_MEDIAPROC_WRONGSTATE = unchecked((int)(0xC00D36F2));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_RT_THROUGHPUT_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define MF_E_RT_THROUGHPUT_NOT_AVAILABLE _HRESULT_TYPEDEF_(0xC00D36F3L)")]
    public const int MF_E_RT_THROUGHPUT_NOT_AVAILABLE = unchecked((int)(0xC00D36F3));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_RT_TOO_MANY_CLASSES"]/*' />
    [NativeTypeName("#define MF_E_RT_TOO_MANY_CLASSES _HRESULT_TYPEDEF_(0xC00D36F4L)")]
    public const int MF_E_RT_TOO_MANY_CLASSES = unchecked((int)(0xC00D36F4));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_RT_WOULDBLOCK"]/*' />
    [NativeTypeName("#define MF_E_RT_WOULDBLOCK _HRESULT_TYPEDEF_(0xC00D36F5L)")]
    public const int MF_E_RT_WOULDBLOCK = unchecked((int)(0xC00D36F5));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_BITPUMP"]/*' />
    [NativeTypeName("#define MF_E_NO_BITPUMP _HRESULT_TYPEDEF_(0xC00D36F6L)")]
    public const int MF_E_NO_BITPUMP = unchecked((int)(0xC00D36F6));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_RT_OUTOFMEMORY"]/*' />
    [NativeTypeName("#define MF_E_RT_OUTOFMEMORY _HRESULT_TYPEDEF_(0xC00D36F7L)")]
    public const int MF_E_RT_OUTOFMEMORY = unchecked((int)(0xC00D36F7));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_RT_WORKQUEUE_CLASS_NOT_SPECIFIED"]/*' />
    [NativeTypeName("#define MF_E_RT_WORKQUEUE_CLASS_NOT_SPECIFIED _HRESULT_TYPEDEF_(0xC00D36F8L)")]
    public const int MF_E_RT_WORKQUEUE_CLASS_NOT_SPECIFIED = unchecked((int)(0xC00D36F8));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INSUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define MF_E_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0xC00D7170L)")]
    public const int MF_E_INSUFFICIENT_BUFFER = unchecked((int)(0xC00D7170));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CANNOT_CREATE_SINK"]/*' />
    [NativeTypeName("#define MF_E_CANNOT_CREATE_SINK _HRESULT_TYPEDEF_(0xC00D36FAL)")]
    public const int MF_E_CANNOT_CREATE_SINK = unchecked((int)(0xC00D36FA));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_BYTESTREAM_UNKNOWN_LENGTH"]/*' />
    [NativeTypeName("#define MF_E_BYTESTREAM_UNKNOWN_LENGTH _HRESULT_TYPEDEF_(0xC00D36FBL)")]
    public const int MF_E_BYTESTREAM_UNKNOWN_LENGTH = unchecked((int)(0xC00D36FB));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SESSION_PAUSEWHILESTOPPED"]/*' />
    [NativeTypeName("#define MF_E_SESSION_PAUSEWHILESTOPPED _HRESULT_TYPEDEF_(0xC00D36FCL)")]
    public const int MF_E_SESSION_PAUSEWHILESTOPPED = unchecked((int)(0xC00D36FC));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_ACTIVATE_REPLACED"]/*' />
    [NativeTypeName("#define MF_S_ACTIVATE_REPLACED _HRESULT_TYPEDEF_(0x000D36FDL)")]
    public const int MF_S_ACTIVATE_REPLACED = ((int)(0x000D36FD));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_FORMAT_CHANGE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_FORMAT_CHANGE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D36FEL)")]
    public const int MF_E_FORMAT_CHANGE_NOT_SUPPORTED = unchecked((int)(0xC00D36FE));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_WORKQUEUE"]/*' />
    [NativeTypeName("#define MF_E_INVALID_WORKQUEUE _HRESULT_TYPEDEF_(0xC00D36FFL)")]
    public const int MF_E_INVALID_WORKQUEUE = unchecked((int)(0xC00D36FF));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_DRM_UNSUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_DRM_UNSUPPORTED _HRESULT_TYPEDEF_(0xC00D3700L)")]
    public const int MF_E_DRM_UNSUPPORTED = unchecked((int)(0xC00D3700));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNAUTHORIZED"]/*' />
    [NativeTypeName("#define MF_E_UNAUTHORIZED _HRESULT_TYPEDEF_(0xC00D3701L)")]
    public const int MF_E_UNAUTHORIZED = unchecked((int)(0xC00D3701));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define MF_E_OUT_OF_RANGE _HRESULT_TYPEDEF_(0xC00D3702L)")]
    public const int MF_E_OUT_OF_RANGE = unchecked((int)(0xC00D3702));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_CODEC_MERIT"]/*' />
    [NativeTypeName("#define MF_E_INVALID_CODEC_MERIT _HRESULT_TYPEDEF_(0xC00D3703L)")]
    public const int MF_E_INVALID_CODEC_MERIT = unchecked((int)(0xC00D3703));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_HW_MFT_FAILED_START_STREAMING"]/*' />
    [NativeTypeName("#define MF_E_HW_MFT_FAILED_START_STREAMING _HRESULT_TYPEDEF_(0xC00D3704L)")]
    public const int MF_E_HW_MFT_FAILED_START_STREAMING = unchecked((int)(0xC00D3704));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_OPERATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define MF_E_OPERATION_IN_PROGRESS _HRESULT_TYPEDEF_(0xC00D3705L)")]
    public const int MF_E_OPERATION_IN_PROGRESS = unchecked((int)(0xC00D3705));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_HARDWARE_DRM_UNSUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_HARDWARE_DRM_UNSUPPORTED _HRESULT_TYPEDEF_(0xC00D3706L)")]
    public const int MF_E_HARDWARE_DRM_UNSUPPORTED = unchecked((int)(0xC00D3706));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_DURATION_TOO_LONG"]/*' />
    [NativeTypeName("#define MF_E_DURATION_TOO_LONG _HRESULT_TYPEDEF_(0xC00D3707L)")]
    public const int MF_E_DURATION_TOO_LONG = unchecked((int)(0xC00D3707));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_OPERATION_UNSUPPORTED_AT_D3D_FEATURE_LEVEL"]/*' />
    [NativeTypeName("#define MF_E_OPERATION_UNSUPPORTED_AT_D3D_FEATURE_LEVEL _HRESULT_TYPEDEF_(0xC00D3708L)")]
    public const int MF_E_OPERATION_UNSUPPORTED_AT_D3D_FEATURE_LEVEL = unchecked((int)(0xC00D3708));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_MEDIATYPE_AT_D3D_FEATURE_LEVEL"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_MEDIATYPE_AT_D3D_FEATURE_LEVEL _HRESULT_TYPEDEF_(0xC00D3709L)")]
    public const int MF_E_UNSUPPORTED_MEDIATYPE_AT_D3D_FEATURE_LEVEL = unchecked((int)(0xC00D3709));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_ASF_PARSEINPROGRESS"]/*' />
    [NativeTypeName("#define MF_S_ASF_PARSEINPROGRESS _HRESULT_TYPEDEF_(0x400D3A98L)")]
    public const int MF_S_ASF_PARSEINPROGRESS = ((int)(0x400D3A98));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_PARSINGINCOMPLETE"]/*' />
    [NativeTypeName("#define MF_E_ASF_PARSINGINCOMPLETE _HRESULT_TYPEDEF_(0xC00D3A98L)")]
    public const int MF_E_ASF_PARSINGINCOMPLETE = unchecked((int)(0xC00D3A98));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_MISSINGDATA"]/*' />
    [NativeTypeName("#define MF_E_ASF_MISSINGDATA _HRESULT_TYPEDEF_(0xC00D3A99L)")]
    public const int MF_E_ASF_MISSINGDATA = unchecked((int)(0xC00D3A99));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_INVALIDDATA"]/*' />
    [NativeTypeName("#define MF_E_ASF_INVALIDDATA _HRESULT_TYPEDEF_(0xC00D3A9AL)")]
    public const int MF_E_ASF_INVALIDDATA = unchecked((int)(0xC00D3A9A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_OPAQUEPACKET"]/*' />
    [NativeTypeName("#define MF_E_ASF_OPAQUEPACKET _HRESULT_TYPEDEF_(0xC00D3A9BL)")]
    public const int MF_E_ASF_OPAQUEPACKET = unchecked((int)(0xC00D3A9B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_NOINDEX"]/*' />
    [NativeTypeName("#define MF_E_ASF_NOINDEX _HRESULT_TYPEDEF_(0xC00D3A9CL)")]
    public const int MF_E_ASF_NOINDEX = unchecked((int)(0xC00D3A9C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_OUTOFRANGE"]/*' />
    [NativeTypeName("#define MF_E_ASF_OUTOFRANGE _HRESULT_TYPEDEF_(0xC00D3A9DL)")]
    public const int MF_E_ASF_OUTOFRANGE = unchecked((int)(0xC00D3A9D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_INDEXNOTLOADED"]/*' />
    [NativeTypeName("#define MF_E_ASF_INDEXNOTLOADED _HRESULT_TYPEDEF_(0xC00D3A9EL)")]
    public const int MF_E_ASF_INDEXNOTLOADED = unchecked((int)(0xC00D3A9E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_TOO_MANY_PAYLOADS"]/*' />
    [NativeTypeName("#define MF_E_ASF_TOO_MANY_PAYLOADS _HRESULT_TYPEDEF_(0xC00D3A9FL)")]
    public const int MF_E_ASF_TOO_MANY_PAYLOADS = unchecked((int)(0xC00D3A9F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_UNSUPPORTED_STREAM_TYPE"]/*' />
    [NativeTypeName("#define MF_E_ASF_UNSUPPORTED_STREAM_TYPE _HRESULT_TYPEDEF_(0xC00D3AA0L)")]
    public const int MF_E_ASF_UNSUPPORTED_STREAM_TYPE = unchecked((int)(0xC00D3AA0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_DROPPED_PACKET"]/*' />
    [NativeTypeName("#define MF_E_ASF_DROPPED_PACKET _HRESULT_TYPEDEF_(0xC00D3AA1L)")]
    public const int MF_E_ASF_DROPPED_PACKET = unchecked((int)(0xC00D3AA1));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_EVENTS_AVAILABLE"]/*' />
    [NativeTypeName("#define MF_E_NO_EVENTS_AVAILABLE _HRESULT_TYPEDEF_(0xC00D3E80L)")]
    public const int MF_E_NO_EVENTS_AVAILABLE = unchecked((int)(0xC00D3E80));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_STATE_TRANSITION"]/*' />
    [NativeTypeName("#define MF_E_INVALID_STATE_TRANSITION _HRESULT_TYPEDEF_(0xC00D3E82L)")]
    public const int MF_E_INVALID_STATE_TRANSITION = unchecked((int)(0xC00D3E82));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_END_OF_STREAM"]/*' />
    [NativeTypeName("#define MF_E_END_OF_STREAM _HRESULT_TYPEDEF_(0xC00D3E84L)")]
    public const int MF_E_END_OF_STREAM = unchecked((int)(0xC00D3E84));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SHUTDOWN"]/*' />
    [NativeTypeName("#define MF_E_SHUTDOWN _HRESULT_TYPEDEF_(0xC00D3E85L)")]
    public const int MF_E_SHUTDOWN = unchecked((int)(0xC00D3E85));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MP3_NOTFOUND"]/*' />
    [NativeTypeName("#define MF_E_MP3_NOTFOUND _HRESULT_TYPEDEF_(0xC00D3E86L)")]
    public const int MF_E_MP3_NOTFOUND = unchecked((int)(0xC00D3E86));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MP3_OUTOFDATA"]/*' />
    [NativeTypeName("#define MF_E_MP3_OUTOFDATA _HRESULT_TYPEDEF_(0xC00D3E87L)")]
    public const int MF_E_MP3_OUTOFDATA = unchecked((int)(0xC00D3E87));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MP3_NOTMP3"]/*' />
    [NativeTypeName("#define MF_E_MP3_NOTMP3 _HRESULT_TYPEDEF_(0xC00D3E88L)")]
    public const int MF_E_MP3_NOTMP3 = unchecked((int)(0xC00D3E88));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MP3_NOTSUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_MP3_NOTSUPPORTED _HRESULT_TYPEDEF_(0xC00D3E89L)")]
    public const int MF_E_MP3_NOTSUPPORTED = unchecked((int)(0xC00D3E89));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_DURATION"]/*' />
    [NativeTypeName("#define MF_E_NO_DURATION _HRESULT_TYPEDEF_(0xC00D3E8AL)")]
    public const int MF_E_NO_DURATION = unchecked((int)(0xC00D3E8A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_FORMAT"]/*' />
    [NativeTypeName("#define MF_E_INVALID_FORMAT _HRESULT_TYPEDEF_(0xC00D3E8CL)")]
    public const int MF_E_INVALID_FORMAT = unchecked((int)(0xC00D3E8C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_NOT_FOUND"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_NOT_FOUND _HRESULT_TYPEDEF_(0xC00D3E8DL)")]
    public const int MF_E_PROPERTY_NOT_FOUND = unchecked((int)(0xC00D3E8D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_READ_ONLY"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_READ_ONLY _HRESULT_TYPEDEF_(0xC00D3E8EL)")]
    public const int MF_E_PROPERTY_READ_ONLY = unchecked((int)(0xC00D3E8E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROPERTY_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define MF_E_PROPERTY_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC00D3E8FL)")]
    public const int MF_E_PROPERTY_NOT_ALLOWED = unchecked((int)(0xC00D3E8F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIA_SOURCE_NOT_STARTED"]/*' />
    [NativeTypeName("#define MF_E_MEDIA_SOURCE_NOT_STARTED _HRESULT_TYPEDEF_(0xC00D3E91L)")]
    public const int MF_E_MEDIA_SOURCE_NOT_STARTED = unchecked((int)(0xC00D3E91));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_FORMAT"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_FORMAT _HRESULT_TYPEDEF_(0xC00D3E98L)")]
    public const int MF_E_UNSUPPORTED_FORMAT = unchecked((int)(0xC00D3E98));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MP3_BAD_CRC"]/*' />
    [NativeTypeName("#define MF_E_MP3_BAD_CRC _HRESULT_TYPEDEF_(0xC00D3E99L)")]
    public const int MF_E_MP3_BAD_CRC = unchecked((int)(0xC00D3E99));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NOT_PROTECTED"]/*' />
    [NativeTypeName("#define MF_E_NOT_PROTECTED _HRESULT_TYPEDEF_(0xC00D3E9AL)")]
    public const int MF_E_NOT_PROTECTED = unchecked((int)(0xC00D3E9A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIA_SOURCE_WRONGSTATE"]/*' />
    [NativeTypeName("#define MF_E_MEDIA_SOURCE_WRONGSTATE _HRESULT_TYPEDEF_(0xC00D3E9BL)")]
    public const int MF_E_MEDIA_SOURCE_WRONGSTATE = unchecked((int)(0xC00D3E9B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIA_SOURCE_NO_STREAMS_SELECTED"]/*' />
    [NativeTypeName("#define MF_E_MEDIA_SOURCE_NO_STREAMS_SELECTED _HRESULT_TYPEDEF_(0xC00D3E9CL)")]
    public const int MF_E_MEDIA_SOURCE_NO_STREAMS_SELECTED = unchecked((int)(0xC00D3E9C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CANNOT_FIND_KEYFRAME_SAMPLE"]/*' />
    [NativeTypeName("#define MF_E_CANNOT_FIND_KEYFRAME_SAMPLE _HRESULT_TYPEDEF_(0xC00D3E9DL)")]
    public const int MF_E_CANNOT_FIND_KEYFRAME_SAMPLE = unchecked((int)(0xC00D3E9D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_CHARACTERISTICS"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_CHARACTERISTICS _HRESULT_TYPEDEF_(0xC00D3E9EL)")]
    public const int MF_E_UNSUPPORTED_CHARACTERISTICS = unchecked((int)(0xC00D3E9E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_AUDIO_RECORDING_DEVICE"]/*' />
    [NativeTypeName("#define MF_E_NO_AUDIO_RECORDING_DEVICE _HRESULT_TYPEDEF_(0xC00D3E9FL)")]
    public const int MF_E_NO_AUDIO_RECORDING_DEVICE = unchecked((int)(0xC00D3E9F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_AUDIO_RECORDING_DEVICE_IN_USE"]/*' />
    [NativeTypeName("#define MF_E_AUDIO_RECORDING_DEVICE_IN_USE _HRESULT_TYPEDEF_(0xC00D3EA0L)")]
    public const int MF_E_AUDIO_RECORDING_DEVICE_IN_USE = unchecked((int)(0xC00D3EA0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_AUDIO_RECORDING_DEVICE_INVALIDATED"]/*' />
    [NativeTypeName("#define MF_E_AUDIO_RECORDING_DEVICE_INVALIDATED _HRESULT_TYPEDEF_(0xC00D3EA1L)")]
    public const int MF_E_AUDIO_RECORDING_DEVICE_INVALIDATED = unchecked((int)(0xC00D3EA1));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_VIDEO_RECORDING_DEVICE_INVALIDATED"]/*' />
    [NativeTypeName("#define MF_E_VIDEO_RECORDING_DEVICE_INVALIDATED _HRESULT_TYPEDEF_(0xC00D3EA2L)")]
    public const int MF_E_VIDEO_RECORDING_DEVICE_INVALIDATED = unchecked((int)(0xC00D3EA2));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_VIDEO_RECORDING_DEVICE_PREEMPTED"]/*' />
    [NativeTypeName("#define MF_E_VIDEO_RECORDING_DEVICE_PREEMPTED _HRESULT_TYPEDEF_(0xC00D3EA3L)")]
    public const int MF_E_VIDEO_RECORDING_DEVICE_PREEMPTED = unchecked((int)(0xC00D3EA3));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NETWORK_RESOURCE_FAILURE"]/*' />
    [NativeTypeName("#define MF_E_NETWORK_RESOURCE_FAILURE _HRESULT_TYPEDEF_(0xC00D4268L)")]
    public const int MF_E_NETWORK_RESOURCE_FAILURE = unchecked((int)(0xC00D4268));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_WRITE"]/*' />
    [NativeTypeName("#define MF_E_NET_WRITE _HRESULT_TYPEDEF_(0xC00D4269L)")]
    public const int MF_E_NET_WRITE = unchecked((int)(0xC00D4269));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_READ"]/*' />
    [NativeTypeName("#define MF_E_NET_READ _HRESULT_TYPEDEF_(0xC00D426AL)")]
    public const int MF_E_NET_READ = unchecked((int)(0xC00D426A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_REQUIRE_NETWORK"]/*' />
    [NativeTypeName("#define MF_E_NET_REQUIRE_NETWORK _HRESULT_TYPEDEF_(0xC00D426BL)")]
    public const int MF_E_NET_REQUIRE_NETWORK = unchecked((int)(0xC00D426B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_REQUIRE_ASYNC"]/*' />
    [NativeTypeName("#define MF_E_NET_REQUIRE_ASYNC _HRESULT_TYPEDEF_(0xC00D426CL)")]
    public const int MF_E_NET_REQUIRE_ASYNC = unchecked((int)(0xC00D426C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_BWLEVEL_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_NET_BWLEVEL_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D426DL)")]
    public const int MF_E_NET_BWLEVEL_NOT_SUPPORTED = unchecked((int)(0xC00D426D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_STREAMGROUPS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_NET_STREAMGROUPS_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D426EL)")]
    public const int MF_E_NET_STREAMGROUPS_NOT_SUPPORTED = unchecked((int)(0xC00D426E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_MANUALSS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_NET_MANUALSS_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D426FL)")]
    public const int MF_E_NET_MANUALSS_NOT_SUPPORTED = unchecked((int)(0xC00D426F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_INVALID_PRESENTATION_DESCRIPTOR"]/*' />
    [NativeTypeName("#define MF_E_NET_INVALID_PRESENTATION_DESCRIPTOR _HRESULT_TYPEDEF_(0xC00D4270L)")]
    public const int MF_E_NET_INVALID_PRESENTATION_DESCRIPTOR = unchecked((int)(0xC00D4270));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_CACHESTREAM_NOT_FOUND"]/*' />
    [NativeTypeName("#define MF_E_NET_CACHESTREAM_NOT_FOUND _HRESULT_TYPEDEF_(0xC00D4271L)")]
    public const int MF_E_NET_CACHESTREAM_NOT_FOUND = unchecked((int)(0xC00D4271));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_I_MANUAL_PROXY"]/*' />
    [NativeTypeName("#define MF_I_MANUAL_PROXY _HRESULT_TYPEDEF_(0x400D4272L)")]
    public const int MF_I_MANUAL_PROXY = ((int)(0x400D4272));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_REQUIRE_INPUT"]/*' />
    [NativeTypeName("#define MF_E_NET_REQUIRE_INPUT _HRESULT_TYPEDEF_(0xC00D4274L)")]
    public const int MF_E_NET_REQUIRE_INPUT = unchecked((int)(0xC00D4274));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_REDIRECT"]/*' />
    [NativeTypeName("#define MF_E_NET_REDIRECT _HRESULT_TYPEDEF_(0xC00D4275L)")]
    public const int MF_E_NET_REDIRECT = unchecked((int)(0xC00D4275));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_REDIRECT_TO_PROXY"]/*' />
    [NativeTypeName("#define MF_E_NET_REDIRECT_TO_PROXY _HRESULT_TYPEDEF_(0xC00D4276L)")]
    public const int MF_E_NET_REDIRECT_TO_PROXY = unchecked((int)(0xC00D4276));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_TOO_MANY_REDIRECTS"]/*' />
    [NativeTypeName("#define MF_E_NET_TOO_MANY_REDIRECTS _HRESULT_TYPEDEF_(0xC00D4277L)")]
    public const int MF_E_NET_TOO_MANY_REDIRECTS = unchecked((int)(0xC00D4277));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_TIMEOUT"]/*' />
    [NativeTypeName("#define MF_E_NET_TIMEOUT _HRESULT_TYPEDEF_(0xC00D4278L)")]
    public const int MF_E_NET_TIMEOUT = unchecked((int)(0xC00D4278));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_CLIENT_CLOSE"]/*' />
    [NativeTypeName("#define MF_E_NET_CLIENT_CLOSE _HRESULT_TYPEDEF_(0xC00D4279L)")]
    public const int MF_E_NET_CLIENT_CLOSE = unchecked((int)(0xC00D4279));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_BAD_CONTROL_DATA"]/*' />
    [NativeTypeName("#define MF_E_NET_BAD_CONTROL_DATA _HRESULT_TYPEDEF_(0xC00D427AL)")]
    public const int MF_E_NET_BAD_CONTROL_DATA = unchecked((int)(0xC00D427A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_INCOMPATIBLE_SERVER"]/*' />
    [NativeTypeName("#define MF_E_NET_INCOMPATIBLE_SERVER _HRESULT_TYPEDEF_(0xC00D427BL)")]
    public const int MF_E_NET_INCOMPATIBLE_SERVER = unchecked((int)(0xC00D427B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_UNSAFE_URL"]/*' />
    [NativeTypeName("#define MF_E_NET_UNSAFE_URL _HRESULT_TYPEDEF_(0xC00D427CL)")]
    public const int MF_E_NET_UNSAFE_URL = unchecked((int)(0xC00D427C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_CACHE_NO_DATA"]/*' />
    [NativeTypeName("#define MF_E_NET_CACHE_NO_DATA _HRESULT_TYPEDEF_(0xC00D427DL)")]
    public const int MF_E_NET_CACHE_NO_DATA = unchecked((int)(0xC00D427D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_EOL"]/*' />
    [NativeTypeName("#define MF_E_NET_EOL _HRESULT_TYPEDEF_(0xC00D427EL)")]
    public const int MF_E_NET_EOL = unchecked((int)(0xC00D427E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_BAD_REQUEST"]/*' />
    [NativeTypeName("#define MF_E_NET_BAD_REQUEST _HRESULT_TYPEDEF_(0xC00D427FL)")]
    public const int MF_E_NET_BAD_REQUEST = unchecked((int)(0xC00D427F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_INTERNAL_SERVER_ERROR"]/*' />
    [NativeTypeName("#define MF_E_NET_INTERNAL_SERVER_ERROR _HRESULT_TYPEDEF_(0xC00D4280L)")]
    public const int MF_E_NET_INTERNAL_SERVER_ERROR = unchecked((int)(0xC00D4280));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_SESSION_NOT_FOUND"]/*' />
    [NativeTypeName("#define MF_E_NET_SESSION_NOT_FOUND _HRESULT_TYPEDEF_(0xC00D4281L)")]
    public const int MF_E_NET_SESSION_NOT_FOUND = unchecked((int)(0xC00D4281));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_NOCONNECTION"]/*' />
    [NativeTypeName("#define MF_E_NET_NOCONNECTION _HRESULT_TYPEDEF_(0xC00D4282L)")]
    public const int MF_E_NET_NOCONNECTION = unchecked((int)(0xC00D4282));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_CONNECTION_FAILURE"]/*' />
    [NativeTypeName("#define MF_E_NET_CONNECTION_FAILURE _HRESULT_TYPEDEF_(0xC00D4283L)")]
    public const int MF_E_NET_CONNECTION_FAILURE = unchecked((int)(0xC00D4283));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_INCOMPATIBLE_PUSHSERVER"]/*' />
    [NativeTypeName("#define MF_E_NET_INCOMPATIBLE_PUSHSERVER _HRESULT_TYPEDEF_(0xC00D4284L)")]
    public const int MF_E_NET_INCOMPATIBLE_PUSHSERVER = unchecked((int)(0xC00D4284));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_SERVER_ACCESSDENIED"]/*' />
    [NativeTypeName("#define MF_E_NET_SERVER_ACCESSDENIED _HRESULT_TYPEDEF_(0xC00D4285L)")]
    public const int MF_E_NET_SERVER_ACCESSDENIED = unchecked((int)(0xC00D4285));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_PROXY_ACCESSDENIED"]/*' />
    [NativeTypeName("#define MF_E_NET_PROXY_ACCESSDENIED _HRESULT_TYPEDEF_(0xC00D4286L)")]
    public const int MF_E_NET_PROXY_ACCESSDENIED = unchecked((int)(0xC00D4286));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_CANNOTCONNECT"]/*' />
    [NativeTypeName("#define MF_E_NET_CANNOTCONNECT _HRESULT_TYPEDEF_(0xC00D4287L)")]
    public const int MF_E_NET_CANNOTCONNECT = unchecked((int)(0xC00D4287));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_INVALID_PUSH_TEMPLATE"]/*' />
    [NativeTypeName("#define MF_E_NET_INVALID_PUSH_TEMPLATE _HRESULT_TYPEDEF_(0xC00D4288L)")]
    public const int MF_E_NET_INVALID_PUSH_TEMPLATE = unchecked((int)(0xC00D4288));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_INVALID_PUSH_PUBLISHING_POINT"]/*' />
    [NativeTypeName("#define MF_E_NET_INVALID_PUSH_PUBLISHING_POINT _HRESULT_TYPEDEF_(0xC00D4289L)")]
    public const int MF_E_NET_INVALID_PUSH_PUBLISHING_POINT = unchecked((int)(0xC00D4289));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_BUSY"]/*' />
    [NativeTypeName("#define MF_E_NET_BUSY _HRESULT_TYPEDEF_(0xC00D428AL)")]
    public const int MF_E_NET_BUSY = unchecked((int)(0xC00D428A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_RESOURCE_GONE"]/*' />
    [NativeTypeName("#define MF_E_NET_RESOURCE_GONE _HRESULT_TYPEDEF_(0xC00D428BL)")]
    public const int MF_E_NET_RESOURCE_GONE = unchecked((int)(0xC00D428B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_ERROR_FROM_PROXY"]/*' />
    [NativeTypeName("#define MF_E_NET_ERROR_FROM_PROXY _HRESULT_TYPEDEF_(0xC00D428CL)")]
    public const int MF_E_NET_ERROR_FROM_PROXY = unchecked((int)(0xC00D428C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_PROXY_TIMEOUT"]/*' />
    [NativeTypeName("#define MF_E_NET_PROXY_TIMEOUT _HRESULT_TYPEDEF_(0xC00D428DL)")]
    public const int MF_E_NET_PROXY_TIMEOUT = unchecked((int)(0xC00D428D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_SERVER_UNAVAILABLE"]/*' />
    [NativeTypeName("#define MF_E_NET_SERVER_UNAVAILABLE _HRESULT_TYPEDEF_(0xC00D428EL)")]
    public const int MF_E_NET_SERVER_UNAVAILABLE = unchecked((int)(0xC00D428E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_TOO_MUCH_DATA"]/*' />
    [NativeTypeName("#define MF_E_NET_TOO_MUCH_DATA _HRESULT_TYPEDEF_(0xC00D428FL)")]
    public const int MF_E_NET_TOO_MUCH_DATA = unchecked((int)(0xC00D428F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_SESSION_INVALID"]/*' />
    [NativeTypeName("#define MF_E_NET_SESSION_INVALID _HRESULT_TYPEDEF_(0xC00D4290L)")]
    public const int MF_E_NET_SESSION_INVALID = unchecked((int)(0xC00D4290));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_OFFLINE_MODE"]/*' />
    [NativeTypeName("#define MF_E_OFFLINE_MODE _HRESULT_TYPEDEF_(0xC00D4291L)")]
    public const int MF_E_OFFLINE_MODE = unchecked((int)(0xC00D4291));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_UDP_BLOCKED"]/*' />
    [NativeTypeName("#define MF_E_NET_UDP_BLOCKED _HRESULT_TYPEDEF_(0xC00D4292L)")]
    public const int MF_E_NET_UDP_BLOCKED = unchecked((int)(0xC00D4292));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_UNSUPPORTED_CONFIGURATION"]/*' />
    [NativeTypeName("#define MF_E_NET_UNSUPPORTED_CONFIGURATION _HRESULT_TYPEDEF_(0xC00D4293L)")]
    public const int MF_E_NET_UNSUPPORTED_CONFIGURATION = unchecked((int)(0xC00D4293));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_PROTOCOL_DISABLED"]/*' />
    [NativeTypeName("#define MF_E_NET_PROTOCOL_DISABLED _HRESULT_TYPEDEF_(0xC00D4294L)")]
    public const int MF_E_NET_PROTOCOL_DISABLED = unchecked((int)(0xC00D4294));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NET_COMPANION_DRIVER_DISCONNECT"]/*' />
    [NativeTypeName("#define MF_E_NET_COMPANION_DRIVER_DISCONNECT _HRESULT_TYPEDEF_(0xC00D4295L)")]
    public const int MF_E_NET_COMPANION_DRIVER_DISCONNECT = unchecked((int)(0xC00D4295));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ALREADY_INITIALIZED"]/*' />
    [NativeTypeName("#define MF_E_ALREADY_INITIALIZED _HRESULT_TYPEDEF_(0xC00D4650L)")]
    public const int MF_E_ALREADY_INITIALIZED = unchecked((int)(0xC00D4650));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_BANDWIDTH_OVERRUN"]/*' />
    [NativeTypeName("#define MF_E_BANDWIDTH_OVERRUN _HRESULT_TYPEDEF_(0xC00D4651L)")]
    public const int MF_E_BANDWIDTH_OVERRUN = unchecked((int)(0xC00D4651));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_LATE_SAMPLE"]/*' />
    [NativeTypeName("#define MF_E_LATE_SAMPLE _HRESULT_TYPEDEF_(0xC00D4652L)")]
    public const int MF_E_LATE_SAMPLE = unchecked((int)(0xC00D4652));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_FLUSH_NEEDED"]/*' />
    [NativeTypeName("#define MF_E_FLUSH_NEEDED _HRESULT_TYPEDEF_(0xC00D4653L)")]
    public const int MF_E_FLUSH_NEEDED = unchecked((int)(0xC00D4653));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_PROFILE"]/*' />
    [NativeTypeName("#define MF_E_INVALID_PROFILE _HRESULT_TYPEDEF_(0xC00D4654L)")]
    public const int MF_E_INVALID_PROFILE = unchecked((int)(0xC00D4654));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INDEX_NOT_COMMITTED"]/*' />
    [NativeTypeName("#define MF_E_INDEX_NOT_COMMITTED _HRESULT_TYPEDEF_(0xC00D4655L)")]
    public const int MF_E_INDEX_NOT_COMMITTED = unchecked((int)(0xC00D4655));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_INDEX"]/*' />
    [NativeTypeName("#define MF_E_NO_INDEX _HRESULT_TYPEDEF_(0xC00D4656L)")]
    public const int MF_E_NO_INDEX = unchecked((int)(0xC00D4656));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CANNOT_INDEX_IN_PLACE"]/*' />
    [NativeTypeName("#define MF_E_CANNOT_INDEX_IN_PLACE _HRESULT_TYPEDEF_(0xC00D4657L)")]
    public const int MF_E_CANNOT_INDEX_IN_PLACE = unchecked((int)(0xC00D4657));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MISSING_ASF_LEAKYBUCKET"]/*' />
    [NativeTypeName("#define MF_E_MISSING_ASF_LEAKYBUCKET _HRESULT_TYPEDEF_(0xC00D4658L)")]
    public const int MF_E_MISSING_ASF_LEAKYBUCKET = unchecked((int)(0xC00D4658));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_ASF_STREAMID"]/*' />
    [NativeTypeName("#define MF_E_INVALID_ASF_STREAMID _HRESULT_TYPEDEF_(0xC00D4659L)")]
    public const int MF_E_INVALID_ASF_STREAMID = unchecked((int)(0xC00D4659));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_STREAMSINK_REMOVED"]/*' />
    [NativeTypeName("#define MF_E_STREAMSINK_REMOVED _HRESULT_TYPEDEF_(0xC00D4A38L)")]
    public const int MF_E_STREAMSINK_REMOVED = unchecked((int)(0xC00D4A38));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_STREAMSINKS_OUT_OF_SYNC"]/*' />
    [NativeTypeName("#define MF_E_STREAMSINKS_OUT_OF_SYNC _HRESULT_TYPEDEF_(0xC00D4A3AL)")]
    public const int MF_E_STREAMSINKS_OUT_OF_SYNC = unchecked((int)(0xC00D4A3A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_STREAMSINKS_FIXED"]/*' />
    [NativeTypeName("#define MF_E_STREAMSINKS_FIXED _HRESULT_TYPEDEF_(0xC00D4A3BL)")]
    public const int MF_E_STREAMSINKS_FIXED = unchecked((int)(0xC00D4A3B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_STREAMSINK_EXISTS"]/*' />
    [NativeTypeName("#define MF_E_STREAMSINK_EXISTS _HRESULT_TYPEDEF_(0xC00D4A3CL)")]
    public const int MF_E_STREAMSINK_EXISTS = unchecked((int)(0xC00D4A3C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SAMPLEALLOCATOR_CANCELED"]/*' />
    [NativeTypeName("#define MF_E_SAMPLEALLOCATOR_CANCELED _HRESULT_TYPEDEF_(0xC00D4A3DL)")]
    public const int MF_E_SAMPLEALLOCATOR_CANCELED = unchecked((int)(0xC00D4A3D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SAMPLEALLOCATOR_EMPTY"]/*' />
    [NativeTypeName("#define MF_E_SAMPLEALLOCATOR_EMPTY _HRESULT_TYPEDEF_(0xC00D4A3EL)")]
    public const int MF_E_SAMPLEALLOCATOR_EMPTY = unchecked((int)(0xC00D4A3E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SINK_ALREADYSTOPPED"]/*' />
    [NativeTypeName("#define MF_E_SINK_ALREADYSTOPPED _HRESULT_TYPEDEF_(0xC00D4A3FL)")]
    public const int MF_E_SINK_ALREADYSTOPPED = unchecked((int)(0xC00D4A3F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ASF_FILESINK_BITRATE_UNKNOWN"]/*' />
    [NativeTypeName("#define MF_E_ASF_FILESINK_BITRATE_UNKNOWN _HRESULT_TYPEDEF_(0xC00D4A40L)")]
    public const int MF_E_ASF_FILESINK_BITRATE_UNKNOWN = unchecked((int)(0xC00D4A40));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SINK_NO_STREAMS"]/*' />
    [NativeTypeName("#define MF_E_SINK_NO_STREAMS _HRESULT_TYPEDEF_(0xC00D4A41L)")]
    public const int MF_E_SINK_NO_STREAMS = unchecked((int)(0xC00D4A41));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_SINK_NOT_FINALIZED"]/*' />
    [NativeTypeName("#define MF_S_SINK_NOT_FINALIZED _HRESULT_TYPEDEF_(0x000D4A42L)")]
    public const int MF_S_SINK_NOT_FINALIZED = ((int)(0x000D4A42));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_METADATA_TOO_LONG"]/*' />
    [NativeTypeName("#define MF_E_METADATA_TOO_LONG _HRESULT_TYPEDEF_(0xC00D4A43L)")]
    public const int MF_E_METADATA_TOO_LONG = unchecked((int)(0xC00D4A43));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SINK_NO_SAMPLES_PROCESSED"]/*' />
    [NativeTypeName("#define MF_E_SINK_NO_SAMPLES_PROCESSED _HRESULT_TYPEDEF_(0xC00D4A44L)")]
    public const int MF_E_SINK_NO_SAMPLES_PROCESSED = unchecked((int)(0xC00D4A44));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SINK_HEADERS_NOT_FOUND"]/*' />
    [NativeTypeName("#define MF_E_SINK_HEADERS_NOT_FOUND _HRESULT_TYPEDEF_(0xC00D4A45L)")]
    public const int MF_E_SINK_HEADERS_NOT_FOUND = unchecked((int)(0xC00D4A45));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_VIDEO_REN_NO_PROCAMP_HW"]/*' />
    [NativeTypeName("#define MF_E_VIDEO_REN_NO_PROCAMP_HW _HRESULT_TYPEDEF_(0xC00D4E20L)")]
    public const int MF_E_VIDEO_REN_NO_PROCAMP_HW = unchecked((int)(0xC00D4E20));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_VIDEO_REN_NO_DEINTERLACE_HW"]/*' />
    [NativeTypeName("#define MF_E_VIDEO_REN_NO_DEINTERLACE_HW _HRESULT_TYPEDEF_(0xC00D4E21L)")]
    public const int MF_E_VIDEO_REN_NO_DEINTERLACE_HW = unchecked((int)(0xC00D4E21));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_VIDEO_REN_COPYPROT_FAILED"]/*' />
    [NativeTypeName("#define MF_E_VIDEO_REN_COPYPROT_FAILED _HRESULT_TYPEDEF_(0xC00D4E22L)")]
    public const int MF_E_VIDEO_REN_COPYPROT_FAILED = unchecked((int)(0xC00D4E22));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_VIDEO_REN_SURFACE_NOT_SHARED"]/*' />
    [NativeTypeName("#define MF_E_VIDEO_REN_SURFACE_NOT_SHARED _HRESULT_TYPEDEF_(0xC00D4E23L)")]
    public const int MF_E_VIDEO_REN_SURFACE_NOT_SHARED = unchecked((int)(0xC00D4E23));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_VIDEO_DEVICE_LOCKED"]/*' />
    [NativeTypeName("#define MF_E_VIDEO_DEVICE_LOCKED _HRESULT_TYPEDEF_(0xC00D4E24L)")]
    public const int MF_E_VIDEO_DEVICE_LOCKED = unchecked((int)(0xC00D4E24));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NEW_VIDEO_DEVICE"]/*' />
    [NativeTypeName("#define MF_E_NEW_VIDEO_DEVICE _HRESULT_TYPEDEF_(0xC00D4E25L)")]
    public const int MF_E_NEW_VIDEO_DEVICE = unchecked((int)(0xC00D4E25));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_VIDEO_SAMPLE_AVAILABLE"]/*' />
    [NativeTypeName("#define MF_E_NO_VIDEO_SAMPLE_AVAILABLE _HRESULT_TYPEDEF_(0xC00D4E26L)")]
    public const int MF_E_NO_VIDEO_SAMPLE_AVAILABLE = unchecked((int)(0xC00D4E26));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_AUDIO_PLAYBACK_DEVICE"]/*' />
    [NativeTypeName("#define MF_E_NO_AUDIO_PLAYBACK_DEVICE _HRESULT_TYPEDEF_(0xC00D4E84L)")]
    public const int MF_E_NO_AUDIO_PLAYBACK_DEVICE = unchecked((int)(0xC00D4E84));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_AUDIO_PLAYBACK_DEVICE_IN_USE"]/*' />
    [NativeTypeName("#define MF_E_AUDIO_PLAYBACK_DEVICE_IN_USE _HRESULT_TYPEDEF_(0xC00D4E85L)")]
    public const int MF_E_AUDIO_PLAYBACK_DEVICE_IN_USE = unchecked((int)(0xC00D4E85));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_AUDIO_PLAYBACK_DEVICE_INVALIDATED"]/*' />
    [NativeTypeName("#define MF_E_AUDIO_PLAYBACK_DEVICE_INVALIDATED _HRESULT_TYPEDEF_(0xC00D4E86L)")]
    public const int MF_E_AUDIO_PLAYBACK_DEVICE_INVALIDATED = unchecked((int)(0xC00D4E86));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_AUDIO_SERVICE_NOT_RUNNING"]/*' />
    [NativeTypeName("#define MF_E_AUDIO_SERVICE_NOT_RUNNING _HRESULT_TYPEDEF_(0xC00D4E87L)")]
    public const int MF_E_AUDIO_SERVICE_NOT_RUNNING = unchecked((int)(0xC00D4E87));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_AUDIO_BUFFER_SIZE_ERROR"]/*' />
    [NativeTypeName("#define MF_E_AUDIO_BUFFER_SIZE_ERROR _HRESULT_TYPEDEF_(0xC00D4E88L)")]
    public const int MF_E_AUDIO_BUFFER_SIZE_ERROR = unchecked((int)(0xC00D4E88));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_AUDIO_CLIENT_WRAPPER_SPOOF_ERROR"]/*' />
    [NativeTypeName("#define MF_E_AUDIO_CLIENT_WRAPPER_SPOOF_ERROR _HRESULT_TYPEDEF_(0xC00D4E89L)")]
    public const int MF_E_AUDIO_CLIENT_WRAPPER_SPOOF_ERROR = unchecked((int)(0xC00D4E89));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_INVALID_OPTIONAL_NODE"]/*' />
    [NativeTypeName("#define MF_E_TOPO_INVALID_OPTIONAL_NODE _HRESULT_TYPEDEF_(0xC00D520EL)")]
    public const int MF_E_TOPO_INVALID_OPTIONAL_NODE = unchecked((int)(0xC00D520E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_CANNOT_FIND_DECRYPTOR"]/*' />
    [NativeTypeName("#define MF_E_TOPO_CANNOT_FIND_DECRYPTOR _HRESULT_TYPEDEF_(0xC00D5211L)")]
    public const int MF_E_TOPO_CANNOT_FIND_DECRYPTOR = unchecked((int)(0xC00D5211));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_CODEC_NOT_FOUND"]/*' />
    [NativeTypeName("#define MF_E_TOPO_CODEC_NOT_FOUND _HRESULT_TYPEDEF_(0xC00D5212L)")]
    public const int MF_E_TOPO_CODEC_NOT_FOUND = unchecked((int)(0xC00D5212));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_CANNOT_CONNECT"]/*' />
    [NativeTypeName("#define MF_E_TOPO_CANNOT_CONNECT _HRESULT_TYPEDEF_(0xC00D5213L)")]
    public const int MF_E_TOPO_CANNOT_CONNECT = unchecked((int)(0xC00D5213));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_UNSUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_TOPO_UNSUPPORTED _HRESULT_TYPEDEF_(0xC00D5214L)")]
    public const int MF_E_TOPO_UNSUPPORTED = unchecked((int)(0xC00D5214));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_INVALID_TIME_ATTRIBUTES"]/*' />
    [NativeTypeName("#define MF_E_TOPO_INVALID_TIME_ATTRIBUTES _HRESULT_TYPEDEF_(0xC00D5215L)")]
    public const int MF_E_TOPO_INVALID_TIME_ATTRIBUTES = unchecked((int)(0xC00D5215));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_LOOPS_IN_TOPOLOGY"]/*' />
    [NativeTypeName("#define MF_E_TOPO_LOOPS_IN_TOPOLOGY _HRESULT_TYPEDEF_(0xC00D5216L)")]
    public const int MF_E_TOPO_LOOPS_IN_TOPOLOGY = unchecked((int)(0xC00D5216));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_MISSING_PRESENTATION_DESCRIPTOR"]/*' />
    [NativeTypeName("#define MF_E_TOPO_MISSING_PRESENTATION_DESCRIPTOR _HRESULT_TYPEDEF_(0xC00D5217L)")]
    public const int MF_E_TOPO_MISSING_PRESENTATION_DESCRIPTOR = unchecked((int)(0xC00D5217));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_MISSING_STREAM_DESCRIPTOR"]/*' />
    [NativeTypeName("#define MF_E_TOPO_MISSING_STREAM_DESCRIPTOR _HRESULT_TYPEDEF_(0xC00D5218L)")]
    public const int MF_E_TOPO_MISSING_STREAM_DESCRIPTOR = unchecked((int)(0xC00D5218));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_STREAM_DESCRIPTOR_NOT_SELECTED"]/*' />
    [NativeTypeName("#define MF_E_TOPO_STREAM_DESCRIPTOR_NOT_SELECTED _HRESULT_TYPEDEF_(0xC00D5219L)")]
    public const int MF_E_TOPO_STREAM_DESCRIPTOR_NOT_SELECTED = unchecked((int)(0xC00D5219));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_MISSING_SOURCE"]/*' />
    [NativeTypeName("#define MF_E_TOPO_MISSING_SOURCE _HRESULT_TYPEDEF_(0xC00D521AL)")]
    public const int MF_E_TOPO_MISSING_SOURCE = unchecked((int)(0xC00D521A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPO_SINK_ACTIVATES_UNSUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_TOPO_SINK_ACTIVATES_UNSUPPORTED _HRESULT_TYPEDEF_(0xC00D521BL)")]
    public const int MF_E_TOPO_SINK_ACTIVATES_UNSUPPORTED = unchecked((int)(0xC00D521B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SEQUENCER_UNKNOWN_SEGMENT_ID"]/*' />
    [NativeTypeName("#define MF_E_SEQUENCER_UNKNOWN_SEGMENT_ID _HRESULT_TYPEDEF_(0xC00D61ACL)")]
    public const int MF_E_SEQUENCER_UNKNOWN_SEGMENT_ID = unchecked((int)(0xC00D61AC));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_SEQUENCER_CONTEXT_CANCELED"]/*' />
    [NativeTypeName("#define MF_S_SEQUENCER_CONTEXT_CANCELED _HRESULT_TYPEDEF_(0x000D61ADL)")]
    public const int MF_S_SEQUENCER_CONTEXT_CANCELED = ((int)(0x000D61AD));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_SOURCE_IN_CACHE"]/*' />
    [NativeTypeName("#define MF_E_NO_SOURCE_IN_CACHE _HRESULT_TYPEDEF_(0xC00D61AEL)")]
    public const int MF_E_NO_SOURCE_IN_CACHE = unchecked((int)(0xC00D61AE));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_SEQUENCER_SEGMENT_AT_END_OF_STREAM"]/*' />
    [NativeTypeName("#define MF_S_SEQUENCER_SEGMENT_AT_END_OF_STREAM _HRESULT_TYPEDEF_(0x000D61AFL)")]
    public const int MF_S_SEQUENCER_SEGMENT_AT_END_OF_STREAM = ((int)(0x000D61AF));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_TYPE_NOT_SET"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_TYPE_NOT_SET _HRESULT_TYPEDEF_(0xC00D6D60L)")]
    public const int MF_E_TRANSFORM_TYPE_NOT_SET = unchecked((int)(0xC00D6D60));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_STREAM_CHANGE"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_STREAM_CHANGE _HRESULT_TYPEDEF_(0xC00D6D61L)")]
    public const int MF_E_TRANSFORM_STREAM_CHANGE = unchecked((int)(0xC00D6D61));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_INPUT_REMAINING"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_INPUT_REMAINING _HRESULT_TYPEDEF_(0xC00D6D62L)")]
    public const int MF_E_TRANSFORM_INPUT_REMAINING = unchecked((int)(0xC00D6D62));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROFILE_MISSING"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROFILE_MISSING _HRESULT_TYPEDEF_(0xC00D6D63L)")]
    public const int MF_E_TRANSFORM_PROFILE_MISSING = unchecked((int)(0xC00D6D63));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROFILE_INVALID_OR_CORRUPT"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROFILE_INVALID_OR_CORRUPT _HRESULT_TYPEDEF_(0xC00D6D64L)")]
    public const int MF_E_TRANSFORM_PROFILE_INVALID_OR_CORRUPT = unchecked((int)(0xC00D6D64));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROFILE_TRUNCATED"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROFILE_TRUNCATED _HRESULT_TYPEDEF_(0xC00D6D65L)")]
    public const int MF_E_TRANSFORM_PROFILE_TRUNCATED = unchecked((int)(0xC00D6D65));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROPERTY_PID_NOT_RECOGNIZED"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROPERTY_PID_NOT_RECOGNIZED _HRESULT_TYPEDEF_(0xC00D6D66L)")]
    public const int MF_E_TRANSFORM_PROPERTY_PID_NOT_RECOGNIZED = unchecked((int)(0xC00D6D66));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROPERTY_VARIANT_TYPE_WRONG"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROPERTY_VARIANT_TYPE_WRONG _HRESULT_TYPEDEF_(0xC00D6D67L)")]
    public const int MF_E_TRANSFORM_PROPERTY_VARIANT_TYPE_WRONG = unchecked((int)(0xC00D6D67));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROPERTY_NOT_WRITEABLE"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROPERTY_NOT_WRITEABLE _HRESULT_TYPEDEF_(0xC00D6D68L)")]
    public const int MF_E_TRANSFORM_PROPERTY_NOT_WRITEABLE = unchecked((int)(0xC00D6D68));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROPERTY_ARRAY_VALUE_WRONG_NUM_DIM"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROPERTY_ARRAY_VALUE_WRONG_NUM_DIM _HRESULT_TYPEDEF_(0xC00D6D69L)")]
    public const int MF_E_TRANSFORM_PROPERTY_ARRAY_VALUE_WRONG_NUM_DIM = unchecked((int)(0xC00D6D69));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROPERTY_VALUE_SIZE_WRONG"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROPERTY_VALUE_SIZE_WRONG _HRESULT_TYPEDEF_(0xC00D6D6AL)")]
    public const int MF_E_TRANSFORM_PROPERTY_VALUE_SIZE_WRONG = unchecked((int)(0xC00D6D6A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROPERTY_VALUE_OUT_OF_RANGE"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROPERTY_VALUE_OUT_OF_RANGE _HRESULT_TYPEDEF_(0xC00D6D6BL)")]
    public const int MF_E_TRANSFORM_PROPERTY_VALUE_OUT_OF_RANGE = unchecked((int)(0xC00D6D6B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_PROPERTY_VALUE_INCOMPATIBLE"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_PROPERTY_VALUE_INCOMPATIBLE _HRESULT_TYPEDEF_(0xC00D6D6CL)")]
    public const int MF_E_TRANSFORM_PROPERTY_VALUE_INCOMPATIBLE = unchecked((int)(0xC00D6D6C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_OUTPUT_MEDIATYPE"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_OUTPUT_MEDIATYPE _HRESULT_TYPEDEF_(0xC00D6D6DL)")]
    public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_OUTPUT_MEDIATYPE = unchecked((int)(0xC00D6D6D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_INPUT_MEDIATYPE"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_INPUT_MEDIATYPE _HRESULT_TYPEDEF_(0xC00D6D6EL)")]
    public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_INPUT_MEDIATYPE = unchecked((int)(0xC00D6D6E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_MEDIATYPE_COMBINATION"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_MEDIATYPE_COMBINATION _HRESULT_TYPEDEF_(0xC00D6D6FL)")]
    public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_MEDIATYPE_COMBINATION = unchecked((int)(0xC00D6D6F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_CONFLICTS_WITH_OTHER_CURRENTLY_ENABLED_FEATURES"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_CONFLICTS_WITH_OTHER_CURRENTLY_ENABLED_FEATURES _HRESULT_TYPEDEF_(0xC00D6D70L)")]
    public const int MF_E_TRANSFORM_CONFLICTS_WITH_OTHER_CURRENTLY_ENABLED_FEATURES = unchecked((int)(0xC00D6D70));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_NEED_MORE_INPUT"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_NEED_MORE_INPUT _HRESULT_TYPEDEF_(0xC00D6D72L)")]
    public const int MF_E_TRANSFORM_NEED_MORE_INPUT = unchecked((int)(0xC00D6D72));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_SPKR_CONFIG"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_SPKR_CONFIG _HRESULT_TYPEDEF_(0xC00D6D73L)")]
    public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_SPKR_CONFIG = unchecked((int)(0xC00D6D73));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_CANNOT_CHANGE_MEDIATYPE_WHILE_PROCESSING"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_CANNOT_CHANGE_MEDIATYPE_WHILE_PROCESSING _HRESULT_TYPEDEF_(0xC00D6D74L)")]
    public const int MF_E_TRANSFORM_CANNOT_CHANGE_MEDIATYPE_WHILE_PROCESSING = unchecked((int)(0xC00D6D74));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_TRANSFORM_DO_NOT_PROPAGATE_EVENT"]/*' />
    [NativeTypeName("#define MF_S_TRANSFORM_DO_NOT_PROPAGATE_EVENT _HRESULT_TYPEDEF_(0x000D6D75L)")]
    public const int MF_S_TRANSFORM_DO_NOT_PROPAGATE_EVENT = ((int)(0x000D6D75));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_D3D_TYPE"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_D3D_TYPE _HRESULT_TYPEDEF_(0xC00D6D76L)")]
    public const int MF_E_UNSUPPORTED_D3D_TYPE = unchecked((int)(0xC00D6D76));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_ASYNC_LOCKED"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_ASYNC_LOCKED _HRESULT_TYPEDEF_(0xC00D6D77L)")]
    public const int MF_E_TRANSFORM_ASYNC_LOCKED = unchecked((int)(0xC00D6D77));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_CANNOT_INITIALIZE_ACM_DRIVER"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_CANNOT_INITIALIZE_ACM_DRIVER _HRESULT_TYPEDEF_(0xC00D6D78L)")]
    public const int MF_E_TRANSFORM_CANNOT_INITIALIZE_ACM_DRIVER = unchecked((int)(0xC00D6D78));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_STREAM_INVALID_RESOLUTION"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_STREAM_INVALID_RESOLUTION _HRESULT_TYPEDEF_(0xC00D6D79L)")]
    public const int MF_E_TRANSFORM_STREAM_INVALID_RESOLUTION = unchecked((int)(0xC00D6D79));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_ASYNC_MFT_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_ASYNC_MFT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D6D7AL)")]
    public const int MF_E_TRANSFORM_ASYNC_MFT_NOT_SUPPORTED = unchecked((int)(0xC00D6D7A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSFORM_EXATTRIBUTE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_TRANSFORM_EXATTRIBUTE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D6D7CL)")]
    public const int MF_E_TRANSFORM_EXATTRIBUTE_NOT_SUPPORTED = unchecked((int)(0xC00D6D7C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_LICENSE_INCORRECT_RIGHTS"]/*' />
    [NativeTypeName("#define MF_E_LICENSE_INCORRECT_RIGHTS _HRESULT_TYPEDEF_(0xC00D7148L)")]
    public const int MF_E_LICENSE_INCORRECT_RIGHTS = unchecked((int)(0xC00D7148));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_LICENSE_OUTOFDATE"]/*' />
    [NativeTypeName("#define MF_E_LICENSE_OUTOFDATE _HRESULT_TYPEDEF_(0xC00D7149L)")]
    public const int MF_E_LICENSE_OUTOFDATE = unchecked((int)(0xC00D7149));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_LICENSE_REQUIRED"]/*' />
    [NativeTypeName("#define MF_E_LICENSE_REQUIRED _HRESULT_TYPEDEF_(0xC00D714AL)")]
    public const int MF_E_LICENSE_REQUIRED = unchecked((int)(0xC00D714A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_DRM_HARDWARE_INCONSISTENT"]/*' />
    [NativeTypeName("#define MF_E_DRM_HARDWARE_INCONSISTENT _HRESULT_TYPEDEF_(0xC00D714BL)")]
    public const int MF_E_DRM_HARDWARE_INCONSISTENT = unchecked((int)(0xC00D714B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_CONTENT_PROTECTION_MANAGER"]/*' />
    [NativeTypeName("#define MF_E_NO_CONTENT_PROTECTION_MANAGER _HRESULT_TYPEDEF_(0xC00D714CL)")]
    public const int MF_E_NO_CONTENT_PROTECTION_MANAGER = unchecked((int)(0xC00D714C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_LICENSE_RESTORE_NO_RIGHTS"]/*' />
    [NativeTypeName("#define MF_E_LICENSE_RESTORE_NO_RIGHTS _HRESULT_TYPEDEF_(0xC00D714DL)")]
    public const int MF_E_LICENSE_RESTORE_NO_RIGHTS = unchecked((int)(0xC00D714D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_BACKUP_RESTRICTED_LICENSE"]/*' />
    [NativeTypeName("#define MF_E_BACKUP_RESTRICTED_LICENSE _HRESULT_TYPEDEF_(0xC00D714EL)")]
    public const int MF_E_BACKUP_RESTRICTED_LICENSE = unchecked((int)(0xC00D714E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_LICENSE_RESTORE_NEEDS_INDIVIDUALIZATION"]/*' />
    [NativeTypeName("#define MF_E_LICENSE_RESTORE_NEEDS_INDIVIDUALIZATION _HRESULT_TYPEDEF_(0xC00D714FL)")]
    public const int MF_E_LICENSE_RESTORE_NEEDS_INDIVIDUALIZATION = unchecked((int)(0xC00D714F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_PROTECTION_NOT_REQUIRED"]/*' />
    [NativeTypeName("#define MF_S_PROTECTION_NOT_REQUIRED _HRESULT_TYPEDEF_(0x000D7150L)")]
    public const int MF_S_PROTECTION_NOT_REQUIRED = ((int)(0x000D7150));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_COMPONENT_REVOKED"]/*' />
    [NativeTypeName("#define MF_E_COMPONENT_REVOKED _HRESULT_TYPEDEF_(0xC00D7151L)")]
    public const int MF_E_COMPONENT_REVOKED = unchecked((int)(0xC00D7151));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRUST_DISABLED"]/*' />
    [NativeTypeName("#define MF_E_TRUST_DISABLED _HRESULT_TYPEDEF_(0xC00D7152L)")]
    public const int MF_E_TRUST_DISABLED = unchecked((int)(0xC00D7152));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_WMDRMOTA_NO_ACTION"]/*' />
    [NativeTypeName("#define MF_E_WMDRMOTA_NO_ACTION _HRESULT_TYPEDEF_(0xC00D7153L)")]
    public const int MF_E_WMDRMOTA_NO_ACTION = unchecked((int)(0xC00D7153));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_WMDRMOTA_ACTION_ALREADY_SET"]/*' />
    [NativeTypeName("#define MF_E_WMDRMOTA_ACTION_ALREADY_SET _HRESULT_TYPEDEF_(0xC00D7154L)")]
    public const int MF_E_WMDRMOTA_ACTION_ALREADY_SET = unchecked((int)(0xC00D7154));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_WMDRMOTA_DRM_HEADER_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define MF_E_WMDRMOTA_DRM_HEADER_NOT_AVAILABLE _HRESULT_TYPEDEF_(0xC00D7155L)")]
    public const int MF_E_WMDRMOTA_DRM_HEADER_NOT_AVAILABLE = unchecked((int)(0xC00D7155));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_WMDRMOTA_DRM_ENCRYPTION_SCHEME_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_WMDRMOTA_DRM_ENCRYPTION_SCHEME_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D7156L)")]
    public const int MF_E_WMDRMOTA_DRM_ENCRYPTION_SCHEME_NOT_SUPPORTED = unchecked((int)(0xC00D7156));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_WMDRMOTA_ACTION_MISMATCH"]/*' />
    [NativeTypeName("#define MF_E_WMDRMOTA_ACTION_MISMATCH _HRESULT_TYPEDEF_(0xC00D7157L)")]
    public const int MF_E_WMDRMOTA_ACTION_MISMATCH = unchecked((int)(0xC00D7157));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_WMDRMOTA_INVALID_POLICY"]/*' />
    [NativeTypeName("#define MF_E_WMDRMOTA_INVALID_POLICY _HRESULT_TYPEDEF_(0xC00D7158L)")]
    public const int MF_E_WMDRMOTA_INVALID_POLICY = unchecked((int)(0xC00D7158));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_POLICY_UNSUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_POLICY_UNSUPPORTED _HRESULT_TYPEDEF_(0xC00D7159L)")]
    public const int MF_E_POLICY_UNSUPPORTED = unchecked((int)(0xC00D7159));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_OPL_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_OPL_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D715AL)")]
    public const int MF_E_OPL_NOT_SUPPORTED = unchecked((int)(0xC00D715A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TOPOLOGY_VERIFICATION_FAILED"]/*' />
    [NativeTypeName("#define MF_E_TOPOLOGY_VERIFICATION_FAILED _HRESULT_TYPEDEF_(0xC00D715BL)")]
    public const int MF_E_TOPOLOGY_VERIFICATION_FAILED = unchecked((int)(0xC00D715B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_SIGNATURE_VERIFICATION_FAILED"]/*' />
    [NativeTypeName("#define MF_E_SIGNATURE_VERIFICATION_FAILED _HRESULT_TYPEDEF_(0xC00D715CL)")]
    public const int MF_E_SIGNATURE_VERIFICATION_FAILED = unchecked((int)(0xC00D715C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_DEBUGGING_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define MF_E_DEBUGGING_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC00D715DL)")]
    public const int MF_E_DEBUGGING_NOT_ALLOWED = unchecked((int)(0xC00D715D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CODE_EXPIRED"]/*' />
    [NativeTypeName("#define MF_E_CODE_EXPIRED _HRESULT_TYPEDEF_(0xC00D715EL)")]
    public const int MF_E_CODE_EXPIRED = unchecked((int)(0xC00D715E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_GRL_VERSION_TOO_LOW"]/*' />
    [NativeTypeName("#define MF_E_GRL_VERSION_TOO_LOW _HRESULT_TYPEDEF_(0xC00D715FL)")]
    public const int MF_E_GRL_VERSION_TOO_LOW = unchecked((int)(0xC00D715F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_GRL_RENEWAL_NOT_FOUND"]/*' />
    [NativeTypeName("#define MF_E_GRL_RENEWAL_NOT_FOUND _HRESULT_TYPEDEF_(0xC00D7160L)")]
    public const int MF_E_GRL_RENEWAL_NOT_FOUND = unchecked((int)(0xC00D7160));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_GRL_EXTENSIBLE_ENTRY_NOT_FOUND"]/*' />
    [NativeTypeName("#define MF_E_GRL_EXTENSIBLE_ENTRY_NOT_FOUND _HRESULT_TYPEDEF_(0xC00D7161L)")]
    public const int MF_E_GRL_EXTENSIBLE_ENTRY_NOT_FOUND = unchecked((int)(0xC00D7161));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_KERNEL_UNTRUSTED"]/*' />
    [NativeTypeName("#define MF_E_KERNEL_UNTRUSTED _HRESULT_TYPEDEF_(0xC00D7162L)")]
    public const int MF_E_KERNEL_UNTRUSTED = unchecked((int)(0xC00D7162));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PEAUTH_UNTRUSTED"]/*' />
    [NativeTypeName("#define MF_E_PEAUTH_UNTRUSTED _HRESULT_TYPEDEF_(0xC00D7163L)")]
    public const int MF_E_PEAUTH_UNTRUSTED = unchecked((int)(0xC00D7163));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NON_PE_PROCESS"]/*' />
    [NativeTypeName("#define MF_E_NON_PE_PROCESS _HRESULT_TYPEDEF_(0xC00D7165L)")]
    public const int MF_E_NON_PE_PROCESS = unchecked((int)(0xC00D7165));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define MF_E_REBOOT_REQUIRED _HRESULT_TYPEDEF_(0xC00D7167L)")]
    public const int MF_E_REBOOT_REQUIRED = unchecked((int)(0xC00D7167));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_WAIT_FOR_POLICY_SET"]/*' />
    [NativeTypeName("#define MF_S_WAIT_FOR_POLICY_SET _HRESULT_TYPEDEF_(0x000D7168L)")]
    public const int MF_S_WAIT_FOR_POLICY_SET = ((int)(0x000D7168));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_VIDEO_DISABLED_WITH_UNKNOWN_SOFTWARE_OUTPUT"]/*' />
    [NativeTypeName("#define MF_S_VIDEO_DISABLED_WITH_UNKNOWN_SOFTWARE_OUTPUT _HRESULT_TYPEDEF_(0x000D7169L)")]
    public const int MF_S_VIDEO_DISABLED_WITH_UNKNOWN_SOFTWARE_OUTPUT = ((int)(0x000D7169));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_GRL_INVALID_FORMAT"]/*' />
    [NativeTypeName("#define MF_E_GRL_INVALID_FORMAT _HRESULT_TYPEDEF_(0xC00D716AL)")]
    public const int MF_E_GRL_INVALID_FORMAT = unchecked((int)(0xC00D716A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_GRL_UNRECOGNIZED_FORMAT"]/*' />
    [NativeTypeName("#define MF_E_GRL_UNRECOGNIZED_FORMAT _HRESULT_TYPEDEF_(0xC00D716BL)")]
    public const int MF_E_GRL_UNRECOGNIZED_FORMAT = unchecked((int)(0xC00D716B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ALL_PROCESS_RESTART_REQUIRED"]/*' />
    [NativeTypeName("#define MF_E_ALL_PROCESS_RESTART_REQUIRED _HRESULT_TYPEDEF_(0xC00D716CL)")]
    public const int MF_E_ALL_PROCESS_RESTART_REQUIRED = unchecked((int)(0xC00D716C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PROCESS_RESTART_REQUIRED"]/*' />
    [NativeTypeName("#define MF_E_PROCESS_RESTART_REQUIRED _HRESULT_TYPEDEF_(0xC00D716DL)")]
    public const int MF_E_PROCESS_RESTART_REQUIRED = unchecked((int)(0xC00D716D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_USERMODE_UNTRUSTED"]/*' />
    [NativeTypeName("#define MF_E_USERMODE_UNTRUSTED _HRESULT_TYPEDEF_(0xC00D716EL)")]
    public const int MF_E_USERMODE_UNTRUSTED = unchecked((int)(0xC00D716E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PEAUTH_SESSION_NOT_STARTED"]/*' />
    [NativeTypeName("#define MF_E_PEAUTH_SESSION_NOT_STARTED _HRESULT_TYPEDEF_(0xC00D716FL)")]
    public const int MF_E_PEAUTH_SESSION_NOT_STARTED = unchecked((int)(0xC00D716F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PEAUTH_PUBLICKEY_REVOKED"]/*' />
    [NativeTypeName("#define MF_E_PEAUTH_PUBLICKEY_REVOKED _HRESULT_TYPEDEF_(0xC00D7171L)")]
    public const int MF_E_PEAUTH_PUBLICKEY_REVOKED = unchecked((int)(0xC00D7171));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_GRL_ABSENT"]/*' />
    [NativeTypeName("#define MF_E_GRL_ABSENT _HRESULT_TYPEDEF_(0xC00D7172L)")]
    public const int MF_E_GRL_ABSENT = unchecked((int)(0xC00D7172));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_PE_TRUSTED"]/*' />
    [NativeTypeName("#define MF_S_PE_TRUSTED _HRESULT_TYPEDEF_(0x000D7173L)")]
    public const int MF_S_PE_TRUSTED = ((int)(0x000D7173));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PE_UNTRUSTED"]/*' />
    [NativeTypeName("#define MF_E_PE_UNTRUSTED _HRESULT_TYPEDEF_(0xC00D7174L)")]
    public const int MF_E_PE_UNTRUSTED = unchecked((int)(0xC00D7174));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PEAUTH_NOT_STARTED"]/*' />
    [NativeTypeName("#define MF_E_PEAUTH_NOT_STARTED _HRESULT_TYPEDEF_(0xC00D7175L)")]
    public const int MF_E_PEAUTH_NOT_STARTED = unchecked((int)(0xC00D7175));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INCOMPATIBLE_SAMPLE_PROTECTION"]/*' />
    [NativeTypeName("#define MF_E_INCOMPATIBLE_SAMPLE_PROTECTION _HRESULT_TYPEDEF_(0xC00D7176L)")]
    public const int MF_E_INCOMPATIBLE_SAMPLE_PROTECTION = unchecked((int)(0xC00D7176));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_PE_SESSIONS_MAXED"]/*' />
    [NativeTypeName("#define MF_E_PE_SESSIONS_MAXED _HRESULT_TYPEDEF_(0xC00D7177L)")]
    public const int MF_E_PE_SESSIONS_MAXED = unchecked((int)(0xC00D7177));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_HIGH_SECURITY_LEVEL_CONTENT_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define MF_E_HIGH_SECURITY_LEVEL_CONTENT_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC00D7178L)")]
    public const int MF_E_HIGH_SECURITY_LEVEL_CONTENT_NOT_ALLOWED = unchecked((int)(0xC00D7178));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TEST_SIGNED_COMPONENTS_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define MF_E_TEST_SIGNED_COMPONENTS_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC00D7179L)")]
    public const int MF_E_TEST_SIGNED_COMPONENTS_NOT_ALLOWED = unchecked((int)(0xC00D7179));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ITA_UNSUPPORTED_ACTION"]/*' />
    [NativeTypeName("#define MF_E_ITA_UNSUPPORTED_ACTION _HRESULT_TYPEDEF_(0xC00D717AL)")]
    public const int MF_E_ITA_UNSUPPORTED_ACTION = unchecked((int)(0xC00D717A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ITA_ERROR_PARSING_SAP_PARAMETERS"]/*' />
    [NativeTypeName("#define MF_E_ITA_ERROR_PARSING_SAP_PARAMETERS _HRESULT_TYPEDEF_(0xC00D717BL)")]
    public const int MF_E_ITA_ERROR_PARSING_SAP_PARAMETERS = unchecked((int)(0xC00D717B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_POLICY_MGR_ACTION_OUTOFBOUNDS"]/*' />
    [NativeTypeName("#define MF_E_POLICY_MGR_ACTION_OUTOFBOUNDS _HRESULT_TYPEDEF_(0xC00D717CL)")]
    public const int MF_E_POLICY_MGR_ACTION_OUTOFBOUNDS = unchecked((int)(0xC00D717C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_BAD_OPL_STRUCTURE_FORMAT"]/*' />
    [NativeTypeName("#define MF_E_BAD_OPL_STRUCTURE_FORMAT _HRESULT_TYPEDEF_(0xC00D717DL)")]
    public const int MF_E_BAD_OPL_STRUCTURE_FORMAT = unchecked((int)(0xC00D717D));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_PROTECTION_GUID"]/*' />
    [NativeTypeName("#define MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_PROTECTION_GUID _HRESULT_TYPEDEF_(0xC00D717EL)")]
    public const int MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_PROTECTION_GUID = unchecked((int)(0xC00D717E));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_PMP_HOST"]/*' />
    [NativeTypeName("#define MF_E_NO_PMP_HOST _HRESULT_TYPEDEF_(0xC00D717FL)")]
    public const int MF_E_NO_PMP_HOST = unchecked((int)(0xC00D717F));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ITA_OPL_DATA_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define MF_E_ITA_OPL_DATA_NOT_INITIALIZED _HRESULT_TYPEDEF_(0xC00D7180L)")]
    public const int MF_E_ITA_OPL_DATA_NOT_INITIALIZED = unchecked((int)(0xC00D7180));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_OUTPUT"]/*' />
    [NativeTypeName("#define MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_OUTPUT _HRESULT_TYPEDEF_(0xC00D7181L)")]
    public const int MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_OUTPUT = unchecked((int)(0xC00D7181));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ITA_UNRECOGNIZED_DIGITAL_VIDEO_OUTPUT"]/*' />
    [NativeTypeName("#define MF_E_ITA_UNRECOGNIZED_DIGITAL_VIDEO_OUTPUT _HRESULT_TYPEDEF_(0xC00D7182L)")]
    public const int MF_E_ITA_UNRECOGNIZED_DIGITAL_VIDEO_OUTPUT = unchecked((int)(0xC00D7182));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_RESOLUTION_REQUIRES_PMP_CREATION_CALLBACK"]/*' />
    [NativeTypeName("#define MF_E_RESOLUTION_REQUIRES_PMP_CREATION_CALLBACK _HRESULT_TYPEDEF_(0xC00D7183L)")]
    public const int MF_E_RESOLUTION_REQUIRES_PMP_CREATION_CALLBACK = unchecked((int)(0xC00D7183));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_AKE_CHANNEL_PARAMETERS"]/*' />
    [NativeTypeName("#define MF_E_INVALID_AKE_CHANNEL_PARAMETERS _HRESULT_TYPEDEF_(0xC00D7184L)")]
    public const int MF_E_INVALID_AKE_CHANNEL_PARAMETERS = unchecked((int)(0xC00D7184));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CONTENT_PROTECTION_SYSTEM_NOT_ENABLED"]/*' />
    [NativeTypeName("#define MF_E_CONTENT_PROTECTION_SYSTEM_NOT_ENABLED _HRESULT_TYPEDEF_(0xC00D7185L)")]
    public const int MF_E_CONTENT_PROTECTION_SYSTEM_NOT_ENABLED = unchecked((int)(0xC00D7185));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_CONTENT_PROTECTION_SYSTEM"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_CONTENT_PROTECTION_SYSTEM _HRESULT_TYPEDEF_(0xC00D7186L)")]
    public const int MF_E_UNSUPPORTED_CONTENT_PROTECTION_SYSTEM = unchecked((int)(0xC00D7186));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_DRM_MIGRATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_DRM_MIGRATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00D7187L)")]
    public const int MF_E_DRM_MIGRATION_NOT_SUPPORTED = unchecked((int)(0xC00D7187));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_HDCP_AUTHENTICATION_FAILURE"]/*' />
    [NativeTypeName("#define MF_E_HDCP_AUTHENTICATION_FAILURE _HRESULT_TYPEDEF_(0xC00D7188L)")]
    public const int MF_E_HDCP_AUTHENTICATION_FAILURE = unchecked((int)(0xC00D7188));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_HDCP_LINK_FAILURE"]/*' />
    [NativeTypeName("#define MF_E_HDCP_LINK_FAILURE _HRESULT_TYPEDEF_(0xC00D7189L)")]
    public const int MF_E_HDCP_LINK_FAILURE = unchecked((int)(0xC00D7189));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CLOCK_INVALID_CONTINUITY_KEY"]/*' />
    [NativeTypeName("#define MF_E_CLOCK_INVALID_CONTINUITY_KEY _HRESULT_TYPEDEF_(0xC00D9C40L)")]
    public const int MF_E_CLOCK_INVALID_CONTINUITY_KEY = unchecked((int)(0xC00D9C40));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CLOCK_NO_TIME_SOURCE"]/*' />
    [NativeTypeName("#define MF_E_CLOCK_NO_TIME_SOURCE _HRESULT_TYPEDEF_(0xC00D9C41L)")]
    public const int MF_E_CLOCK_NO_TIME_SOURCE = unchecked((int)(0xC00D9C41));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CLOCK_STATE_ALREADY_SET"]/*' />
    [NativeTypeName("#define MF_E_CLOCK_STATE_ALREADY_SET _HRESULT_TYPEDEF_(0xC00D9C42L)")]
    public const int MF_E_CLOCK_STATE_ALREADY_SET = unchecked((int)(0xC00D9C42));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CLOCK_NOT_SIMPLE"]/*' />
    [NativeTypeName("#define MF_E_CLOCK_NOT_SIMPLE _HRESULT_TYPEDEF_(0xC00D9C43L)")]
    public const int MF_E_CLOCK_NOT_SIMPLE = unchecked((int)(0xC00D9C43));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_S_CLOCK_STOPPED"]/*' />
    [NativeTypeName("#define MF_S_CLOCK_STOPPED _HRESULT_TYPEDEF_(0x000D9C44L)")]
    public const int MF_S_CLOCK_STOPPED = ((int)(0x000D9C44));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CLOCK_AUDIO_DEVICE_POSITION_UNEXPECTED"]/*' />
    [NativeTypeName("#define MF_E_CLOCK_AUDIO_DEVICE_POSITION_UNEXPECTED _HRESULT_TYPEDEF_(0x000D9C45L)")]
    public const int MF_E_CLOCK_AUDIO_DEVICE_POSITION_UNEXPECTED = ((int)(0x000D9C45));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CLOCK_AUDIO_RENDER_POSITION_UNEXPECTED"]/*' />
    [NativeTypeName("#define MF_E_CLOCK_AUDIO_RENDER_POSITION_UNEXPECTED _HRESULT_TYPEDEF_(0x000D9C46L)")]
    public const int MF_E_CLOCK_AUDIO_RENDER_POSITION_UNEXPECTED = ((int)(0x000D9C46));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CLOCK_AUDIO_RENDER_TIME_UNEXPECTED"]/*' />
    [NativeTypeName("#define MF_E_CLOCK_AUDIO_RENDER_TIME_UNEXPECTED _HRESULT_TYPEDEF_(0x000D9C47L)")]
    public const int MF_E_CLOCK_AUDIO_RENDER_TIME_UNEXPECTED = ((int)(0x000D9C47));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_MORE_DROP_MODES"]/*' />
    [NativeTypeName("#define MF_E_NO_MORE_DROP_MODES _HRESULT_TYPEDEF_(0xC00DA028L)")]
    public const int MF_E_NO_MORE_DROP_MODES = unchecked((int)(0xC00DA028));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_MORE_QUALITY_LEVELS"]/*' />
    [NativeTypeName("#define MF_E_NO_MORE_QUALITY_LEVELS _HRESULT_TYPEDEF_(0xC00DA029L)")]
    public const int MF_E_NO_MORE_QUALITY_LEVELS = unchecked((int)(0xC00DA029));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_DROPTIME_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_DROPTIME_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00DA02AL)")]
    public const int MF_E_DROPTIME_NOT_SUPPORTED = unchecked((int)(0xC00DA02A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_QUALITYKNOB_WAIT_LONGER"]/*' />
    [NativeTypeName("#define MF_E_QUALITYKNOB_WAIT_LONGER _HRESULT_TYPEDEF_(0xC00DA02BL)")]
    public const int MF_E_QUALITYKNOB_WAIT_LONGER = unchecked((int)(0xC00DA02B));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_QM_INVALIDSTATE"]/*' />
    [NativeTypeName("#define MF_E_QM_INVALIDSTATE _HRESULT_TYPEDEF_(0xC00DA02CL)")]
    public const int MF_E_QM_INVALIDSTATE = unchecked((int)(0xC00DA02C));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSCODE_NO_CONTAINERTYPE"]/*' />
    [NativeTypeName("#define MF_E_TRANSCODE_NO_CONTAINERTYPE _HRESULT_TYPEDEF_(0xC00DA410L)")]
    public const int MF_E_TRANSCODE_NO_CONTAINERTYPE = unchecked((int)(0xC00DA410));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSCODE_PROFILE_NO_MATCHING_STREAMS"]/*' />
    [NativeTypeName("#define MF_E_TRANSCODE_PROFILE_NO_MATCHING_STREAMS _HRESULT_TYPEDEF_(0xC00DA411L)")]
    public const int MF_E_TRANSCODE_PROFILE_NO_MATCHING_STREAMS = unchecked((int)(0xC00DA411));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSCODE_NO_MATCHING_ENCODER"]/*' />
    [NativeTypeName("#define MF_E_TRANSCODE_NO_MATCHING_ENCODER _HRESULT_TYPEDEF_(0xC00DA412L)")]
    public const int MF_E_TRANSCODE_NO_MATCHING_ENCODER = unchecked((int)(0xC00DA412));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TRANSCODE_INVALID_PROFILE"]/*' />
    [NativeTypeName("#define MF_E_TRANSCODE_INVALID_PROFILE _HRESULT_TYPEDEF_(0xC00DA413L)")]
    public const int MF_E_TRANSCODE_INVALID_PROFILE = unchecked((int)(0xC00DA413));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ALLOCATOR_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define MF_E_ALLOCATOR_NOT_INITIALIZED _HRESULT_TYPEDEF_(0xC00DA7F8L)")]
    public const int MF_E_ALLOCATOR_NOT_INITIALIZED = unchecked((int)(0xC00DA7F8));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ALLOCATOR_NOT_COMMITED"]/*' />
    [NativeTypeName("#define MF_E_ALLOCATOR_NOT_COMMITED _HRESULT_TYPEDEF_(0xC00DA7F9L)")]
    public const int MF_E_ALLOCATOR_NOT_COMMITED = unchecked((int)(0xC00DA7F9));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_ALLOCATOR_ALREADY_COMMITED"]/*' />
    [NativeTypeName("#define MF_E_ALLOCATOR_ALREADY_COMMITED _HRESULT_TYPEDEF_(0xC00DA7FAL)")]
    public const int MF_E_ALLOCATOR_ALREADY_COMMITED = unchecked((int)(0xC00DA7FA));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_STREAM_ERROR"]/*' />
    [NativeTypeName("#define MF_E_STREAM_ERROR _HRESULT_TYPEDEF_(0xC00DA7FBL)")]
    public const int MF_E_STREAM_ERROR = unchecked((int)(0xC00DA7FB));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_INVALID_STREAM_STATE"]/*' />
    [NativeTypeName("#define MF_E_INVALID_STREAM_STATE _HRESULT_TYPEDEF_(0xC00DA7FCL)")]
    public const int MF_E_INVALID_STREAM_STATE = unchecked((int)(0xC00DA7FC));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_HW_STREAM_NOT_CONNECTED"]/*' />
    [NativeTypeName("#define MF_E_HW_STREAM_NOT_CONNECTED _HRESULT_TYPEDEF_(0xC00DA7FDL)")]
    public const int MF_E_HW_STREAM_NOT_CONNECTED = unchecked((int)(0xC00DA7FD));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_NO_CAPTURE_DEVICES_AVAILABLE"]/*' />
    [NativeTypeName("#define MF_E_NO_CAPTURE_DEVICES_AVAILABLE _HRESULT_TYPEDEF_(0xC00DABE0L)")]
    public const int MF_E_NO_CAPTURE_DEVICES_AVAILABLE = unchecked((int)(0xC00DABE0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_SINK_OUTPUT_NOT_SET"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_SINK_OUTPUT_NOT_SET _HRESULT_TYPEDEF_(0xC00DABE1L)")]
    public const int MF_E_CAPTURE_SINK_OUTPUT_NOT_SET = unchecked((int)(0xC00DABE1));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_SINK_MIRROR_ERROR"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_SINK_MIRROR_ERROR _HRESULT_TYPEDEF_(0xC00DABE2L)")]
    public const int MF_E_CAPTURE_SINK_MIRROR_ERROR = unchecked((int)(0xC00DABE2));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_SINK_ROTATE_ERROR"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_SINK_ROTATE_ERROR _HRESULT_TYPEDEF_(0xC00DABE3L)")]
    public const int MF_E_CAPTURE_SINK_ROTATE_ERROR = unchecked((int)(0xC00DABE3));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_ENGINE_INVALID_OP"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_ENGINE_INVALID_OP _HRESULT_TYPEDEF_(0xC00DABE4L)")]
    public const int MF_E_CAPTURE_ENGINE_INVALID_OP = unchecked((int)(0xC00DABE4));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_ENGINE_ALL_EFFECTS_REMOVED"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_ENGINE_ALL_EFFECTS_REMOVED _HRESULT_TYPEDEF_(0xC00DABE5L)")]
    public const int MF_E_CAPTURE_ENGINE_ALL_EFFECTS_REMOVED = unchecked((int)(0xC00DABE5));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_SOURCE_NO_INDEPENDENT_PHOTO_STREAM_PRESENT"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_SOURCE_NO_INDEPENDENT_PHOTO_STREAM_PRESENT _HRESULT_TYPEDEF_(0xC00DABE6L)")]
    public const int MF_E_CAPTURE_SOURCE_NO_INDEPENDENT_PHOTO_STREAM_PRESENT = unchecked((int)(0xC00DABE6));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_SOURCE_NO_VIDEO_STREAM_PRESENT"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_SOURCE_NO_VIDEO_STREAM_PRESENT _HRESULT_TYPEDEF_(0xC00DABE7L)")]
    public const int MF_E_CAPTURE_SOURCE_NO_VIDEO_STREAM_PRESENT = unchecked((int)(0xC00DABE7));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_SOURCE_NO_AUDIO_STREAM_PRESENT"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_SOURCE_NO_AUDIO_STREAM_PRESENT _HRESULT_TYPEDEF_(0xC00DABE8L)")]
    public const int MF_E_CAPTURE_SOURCE_NO_AUDIO_STREAM_PRESENT = unchecked((int)(0xC00DABE8));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_SOURCE_DEVICE_EXTENDEDPROP_OP_IN_PROGRESS"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_SOURCE_DEVICE_EXTENDEDPROP_OP_IN_PROGRESS _HRESULT_TYPEDEF_(0xC00DABE9L)")]
    public const int MF_E_CAPTURE_SOURCE_DEVICE_EXTENDEDPROP_OP_IN_PROGRESS = unchecked((int)(0xC00DABE9));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_PROPERTY_SET_DURING_PHOTO"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_PROPERTY_SET_DURING_PHOTO _HRESULT_TYPEDEF_(0xC00DABEAL)")]
    public const int MF_E_CAPTURE_PROPERTY_SET_DURING_PHOTO = unchecked((int)(0xC00DABEA));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAPTURE_NO_SAMPLES_IN_QUEUE"]/*' />
    [NativeTypeName("#define MF_E_CAPTURE_NO_SAMPLES_IN_QUEUE _HRESULT_TYPEDEF_(0xC00DABEBL)")]
    public const int MF_E_CAPTURE_NO_SAMPLES_IN_QUEUE = unchecked((int)(0xC00DABEB));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_HW_ACCELERATED_THUMBNAIL_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MF_E_HW_ACCELERATED_THUMBNAIL_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC00DABECL)")]
    public const int MF_E_HW_ACCELERATED_THUMBNAIL_NOT_SUPPORTED = unchecked((int)(0xC00DABEC));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_UNSUPPORTED_CAPTURE_DEVICE_PRESENT"]/*' />
    [NativeTypeName("#define MF_E_UNSUPPORTED_CAPTURE_DEVICE_PRESENT _HRESULT_TYPEDEF_(0xC00DABEDL)")]
    public const int MF_E_UNSUPPORTED_CAPTURE_DEVICE_PRESENT = unchecked((int)(0xC00DABED));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TIMELINECONTROLLER_UNSUPPORTED_SOURCE_TYPE"]/*' />
    [NativeTypeName("#define MF_E_TIMELINECONTROLLER_UNSUPPORTED_SOURCE_TYPE _HRESULT_TYPEDEF_(0xC00DAFC8L)")]
    public const int MF_E_TIMELINECONTROLLER_UNSUPPORTED_SOURCE_TYPE = unchecked((int)(0xC00DAFC8));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TIMELINECONTROLLER_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define MF_E_TIMELINECONTROLLER_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC00DAFC9L)")]
    public const int MF_E_TIMELINECONTROLLER_NOT_ALLOWED = unchecked((int)(0xC00DAFC9));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_TIMELINECONTROLLER_CANNOT_ATTACH"]/*' />
    [NativeTypeName("#define MF_E_TIMELINECONTROLLER_CANNOT_ATTACH _HRESULT_TYPEDEF_(0xC00DAFCAL)")]
    public const int MF_E_TIMELINECONTROLLER_CANNOT_ATTACH = unchecked((int)(0xC00DAFCA));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIA_EXTENSION_APPSERVICE_CONNECTION_FAILED"]/*' />
    [NativeTypeName("#define MF_E_MEDIA_EXTENSION_APPSERVICE_CONNECTION_FAILED _HRESULT_TYPEDEF_(0xC00DB3B0L)")]
    public const int MF_E_MEDIA_EXTENSION_APPSERVICE_CONNECTION_FAILED = unchecked((int)(0xC00DB3B0));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIA_EXTENSION_APPSERVICE_REQUEST_FAILED"]/*' />
    [NativeTypeName("#define MF_E_MEDIA_EXTENSION_APPSERVICE_REQUEST_FAILED _HRESULT_TYPEDEF_(0xC00DB3B1L)")]
    public const int MF_E_MEDIA_EXTENSION_APPSERVICE_REQUEST_FAILED = unchecked((int)(0xC00DB3B1));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIA_EXTENSION_PACKAGE_INTEGRITY_CHECK_FAILED"]/*' />
    [NativeTypeName("#define MF_E_MEDIA_EXTENSION_PACKAGE_INTEGRITY_CHECK_FAILED _HRESULT_TYPEDEF_(0xC00DB3B2L)")]
    public const int MF_E_MEDIA_EXTENSION_PACKAGE_INTEGRITY_CHECK_FAILED = unchecked((int)(0xC00DB3B2));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIA_EXTENSION_PACKAGE_LICENSE_INVALID"]/*' />
    [NativeTypeName("#define MF_E_MEDIA_EXTENSION_PACKAGE_LICENSE_INVALID _HRESULT_TYPEDEF_(0xC00DB3B3L)")]
    public const int MF_E_MEDIA_EXTENSION_PACKAGE_LICENSE_INVALID = unchecked((int)(0xC00DB3B3));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_MEDIA_EXTENSION_PACKAGE_BAD_STATUS"]/*' />
    [NativeTypeName("#define MF_E_MEDIA_EXTENSION_PACKAGE_BAD_STATUS _HRESULT_TYPEDEF_(0xC00DB3B4L)")]
    public const int MF_E_MEDIA_EXTENSION_PACKAGE_BAD_STATUS = unchecked((int)(0xC00DB3B4));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAMERA_PRIVACY_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define MF_E_CAMERA_PRIVACY_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC00DB798L)")]
    public const int MF_E_CAMERA_PRIVACY_NOT_ALLOWED = unchecked((int)(0xC00DB798));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_E_CAMERA_FSPROFILE_INVALID"]/*' />
    [NativeTypeName("#define MF_E_CAMERA_FSPROFILE_INVALID _HRESULT_TYPEDEF_(0xC00DB79AL)")]
    public const int MF_E_CAMERA_FSPROFILE_INVALID = unchecked((int)(0xC00DB79A));

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_INDEX_SIZE_ERR"]/*' />
    [NativeTypeName("#define MF_INDEX_SIZE_ERR 0x80700001")]
    public const uint MF_INDEX_SIZE_ERR = 0x80700001;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_NOT_FOUND_ERR"]/*' />
    [NativeTypeName("#define MF_NOT_FOUND_ERR 0x80700008")]
    public const uint MF_NOT_FOUND_ERR = 0x80700008;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_NOT_SUPPORTED_ERR"]/*' />
    [NativeTypeName("#define MF_NOT_SUPPORTED_ERR 0x80700009")]
    public const uint MF_NOT_SUPPORTED_ERR = 0x80700009;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_INVALID_STATE_ERR"]/*' />
    [NativeTypeName("#define MF_INVALID_STATE_ERR 0x8070000B")]
    public const uint MF_INVALID_STATE_ERR = 0x8070000B;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_SYNTAX_ERR"]/*' />
    [NativeTypeName("#define MF_SYNTAX_ERR 0x8070000C")]
    public const uint MF_SYNTAX_ERR = 0x8070000C;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_INVALID_ACCESS_ERR"]/*' />
    [NativeTypeName("#define MF_INVALID_ACCESS_ERR 0x8070000F")]
    public const uint MF_INVALID_ACCESS_ERR = 0x8070000F;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_QUOTA_EXCEEDED_ERR"]/*' />
    [NativeTypeName("#define MF_QUOTA_EXCEEDED_ERR 0x80700016")]
    public const uint MF_QUOTA_EXCEEDED_ERR = 0x80700016;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_PARSE_ERR"]/*' />
    [NativeTypeName("#define MF_PARSE_ERR 0x80700051")]
    public const uint MF_PARSE_ERR = 0x80700051;

    /// <include file='MF.xml' path='doc/member[@name="MF.MF_TYPE_ERR"]/*' />
    [NativeTypeName("#define MF_TYPE_ERR 0x80704005")]
    public const uint MF_TYPE_ERR = 0x80704005;
}
