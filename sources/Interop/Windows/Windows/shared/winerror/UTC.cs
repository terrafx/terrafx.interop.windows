// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class UTC
{
    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TOGGLE_TRACE_STARTED"]/*' />
    [NativeTypeName("#define UTC_E_TOGGLE_TRACE_STARTED _HRESULT_TYPEDEF_(0x87C51001L)")]
    public const int UTC_E_TOGGLE_TRACE_STARTED = unchecked((int)(0x87C51001));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_ALTERNATIVE_TRACE_CANNOT_PREEMPT"]/*' />
    [NativeTypeName("#define UTC_E_ALTERNATIVE_TRACE_CANNOT_PREEMPT _HRESULT_TYPEDEF_(0x87C51002L)")]
    public const int UTC_E_ALTERNATIVE_TRACE_CANNOT_PREEMPT = unchecked((int)(0x87C51002));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_AOT_NOT_RUNNING"]/*' />
    [NativeTypeName("#define UTC_E_AOT_NOT_RUNNING _HRESULT_TYPEDEF_(0x87C51003L)")]
    public const int UTC_E_AOT_NOT_RUNNING = unchecked((int)(0x87C51003));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SCRIPT_TYPE_INVALID"]/*' />
    [NativeTypeName("#define UTC_E_SCRIPT_TYPE_INVALID _HRESULT_TYPEDEF_(0x87C51004L)")]
    public const int UTC_E_SCRIPT_TYPE_INVALID = unchecked((int)(0x87C51004));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SCENARIODEF_NOT_FOUND"]/*' />
    [NativeTypeName("#define UTC_E_SCENARIODEF_NOT_FOUND _HRESULT_TYPEDEF_(0x87C51005L)")]
    public const int UTC_E_SCENARIODEF_NOT_FOUND = unchecked((int)(0x87C51005));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRACEPROFILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define UTC_E_TRACEPROFILE_NOT_FOUND _HRESULT_TYPEDEF_(0x87C51006L)")]
    public const int UTC_E_TRACEPROFILE_NOT_FOUND = unchecked((int)(0x87C51006));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FORWARDER_ALREADY_ENABLED"]/*' />
    [NativeTypeName("#define UTC_E_FORWARDER_ALREADY_ENABLED _HRESULT_TYPEDEF_(0x87C51007L)")]
    public const int UTC_E_FORWARDER_ALREADY_ENABLED = unchecked((int)(0x87C51007));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FORWARDER_ALREADY_DISABLED"]/*' />
    [NativeTypeName("#define UTC_E_FORWARDER_ALREADY_DISABLED _HRESULT_TYPEDEF_(0x87C51008L)")]
    public const int UTC_E_FORWARDER_ALREADY_DISABLED = unchecked((int)(0x87C51008));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_EVENTLOG_ENTRY_MALFORMED"]/*' />
    [NativeTypeName("#define UTC_E_EVENTLOG_ENTRY_MALFORMED _HRESULT_TYPEDEF_(0x87C51009L)")]
    public const int UTC_E_EVENTLOG_ENTRY_MALFORMED = unchecked((int)(0x87C51009));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_DIAGRULES_SCHEMAVERSION_MISMATCH"]/*' />
    [NativeTypeName("#define UTC_E_DIAGRULES_SCHEMAVERSION_MISMATCH _HRESULT_TYPEDEF_(0x87C5100AL)")]
    public const int UTC_E_DIAGRULES_SCHEMAVERSION_MISMATCH = unchecked((int)(0x87C5100A));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SCRIPT_TERMINATED"]/*' />
    [NativeTypeName("#define UTC_E_SCRIPT_TERMINATED _HRESULT_TYPEDEF_(0x87C5100BL)")]
    public const int UTC_E_SCRIPT_TERMINATED = unchecked((int)(0x87C5100B));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_INVALID_CUSTOM_FILTER"]/*' />
    [NativeTypeName("#define UTC_E_INVALID_CUSTOM_FILTER _HRESULT_TYPEDEF_(0x87C5100CL)")]
    public const int UTC_E_INVALID_CUSTOM_FILTER = unchecked((int)(0x87C5100C));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRACE_NOT_RUNNING"]/*' />
    [NativeTypeName("#define UTC_E_TRACE_NOT_RUNNING _HRESULT_TYPEDEF_(0x87C5100DL)")]
    public const int UTC_E_TRACE_NOT_RUNNING = unchecked((int)(0x87C5100D));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_REESCALATED_TOO_QUICKLY"]/*' />
    [NativeTypeName("#define UTC_E_REESCALATED_TOO_QUICKLY _HRESULT_TYPEDEF_(0x87C5100EL)")]
    public const int UTC_E_REESCALATED_TOO_QUICKLY = unchecked((int)(0x87C5100E));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_ESCALATION_ALREADY_RUNNING"]/*' />
    [NativeTypeName("#define UTC_E_ESCALATION_ALREADY_RUNNING _HRESULT_TYPEDEF_(0x87C5100FL)")]
    public const int UTC_E_ESCALATION_ALREADY_RUNNING = unchecked((int)(0x87C5100F));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_PERFTRACK_ALREADY_TRACING"]/*' />
    [NativeTypeName("#define UTC_E_PERFTRACK_ALREADY_TRACING _HRESULT_TYPEDEF_(0x87C51010L)")]
    public const int UTC_E_PERFTRACK_ALREADY_TRACING = unchecked((int)(0x87C51010));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_REACHED_MAX_ESCALATIONS"]/*' />
    [NativeTypeName("#define UTC_E_REACHED_MAX_ESCALATIONS _HRESULT_TYPEDEF_(0x87C51011L)")]
    public const int UTC_E_REACHED_MAX_ESCALATIONS = unchecked((int)(0x87C51011));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FORWARDER_PRODUCER_MISMATCH"]/*' />
    [NativeTypeName("#define UTC_E_FORWARDER_PRODUCER_MISMATCH _HRESULT_TYPEDEF_(0x87C51012L)")]
    public const int UTC_E_FORWARDER_PRODUCER_MISMATCH = unchecked((int)(0x87C51012));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_INTENTIONAL_SCRIPT_FAILURE"]/*' />
    [NativeTypeName("#define UTC_E_INTENTIONAL_SCRIPT_FAILURE _HRESULT_TYPEDEF_(0x87C51013L)")]
    public const int UTC_E_INTENTIONAL_SCRIPT_FAILURE = unchecked((int)(0x87C51013));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SQM_INIT_FAILED"]/*' />
    [NativeTypeName("#define UTC_E_SQM_INIT_FAILED _HRESULT_TYPEDEF_(0x87C51014L)")]
    public const int UTC_E_SQM_INIT_FAILED = unchecked((int)(0x87C51014));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_NO_WER_LOGGER_SUPPORTED"]/*' />
    [NativeTypeName("#define UTC_E_NO_WER_LOGGER_SUPPORTED _HRESULT_TYPEDEF_(0x87C51015L)")]
    public const int UTC_E_NO_WER_LOGGER_SUPPORTED = unchecked((int)(0x87C51015));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRACERS_DONT_EXIST"]/*' />
    [NativeTypeName("#define UTC_E_TRACERS_DONT_EXIST _HRESULT_TYPEDEF_(0x87C51016L)")]
    public const int UTC_E_TRACERS_DONT_EXIST = unchecked((int)(0x87C51016));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_WINRT_INIT_FAILED"]/*' />
    [NativeTypeName("#define UTC_E_WINRT_INIT_FAILED _HRESULT_TYPEDEF_(0x87C51017L)")]
    public const int UTC_E_WINRT_INIT_FAILED = unchecked((int)(0x87C51017));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SCENARIODEF_SCHEMAVERSION_MISMATCH"]/*' />
    [NativeTypeName("#define UTC_E_SCENARIODEF_SCHEMAVERSION_MISMATCH _HRESULT_TYPEDEF_(0x87C51018L)")]
    public const int UTC_E_SCENARIODEF_SCHEMAVERSION_MISMATCH = unchecked((int)(0x87C51018));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_INVALID_FILTER"]/*' />
    [NativeTypeName("#define UTC_E_INVALID_FILTER _HRESULT_TYPEDEF_(0x87C51019L)")]
    public const int UTC_E_INVALID_FILTER = unchecked((int)(0x87C51019));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_EXE_TERMINATED"]/*' />
    [NativeTypeName("#define UTC_E_EXE_TERMINATED _HRESULT_TYPEDEF_(0x87C5101AL)")]
    public const int UTC_E_EXE_TERMINATED = unchecked((int)(0x87C5101A));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_ESCALATION_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define UTC_E_ESCALATION_NOT_AUTHORIZED _HRESULT_TYPEDEF_(0x87C5101BL)")]
    public const int UTC_E_ESCALATION_NOT_AUTHORIZED = unchecked((int)(0x87C5101B));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SETUP_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define UTC_E_SETUP_NOT_AUTHORIZED _HRESULT_TYPEDEF_(0x87C5101CL)")]
    public const int UTC_E_SETUP_NOT_AUTHORIZED = unchecked((int)(0x87C5101C));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_CHILD_PROCESS_FAILED"]/*' />
    [NativeTypeName("#define UTC_E_CHILD_PROCESS_FAILED _HRESULT_TYPEDEF_(0x87C5101DL)")]
    public const int UTC_E_CHILD_PROCESS_FAILED = unchecked((int)(0x87C5101D));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_COMMAND_LINE_NOT_AUTHORIZED"]/*' />
    [NativeTypeName("#define UTC_E_COMMAND_LINE_NOT_AUTHORIZED _HRESULT_TYPEDEF_(0x87C5101EL)")]
    public const int UTC_E_COMMAND_LINE_NOT_AUTHORIZED = unchecked((int)(0x87C5101E));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_CANNOT_LOAD_SCENARIO_EDITOR_XML"]/*' />
    [NativeTypeName("#define UTC_E_CANNOT_LOAD_SCENARIO_EDITOR_XML _HRESULT_TYPEDEF_(0x87C5101FL)")]
    public const int UTC_E_CANNOT_LOAD_SCENARIO_EDITOR_XML = unchecked((int)(0x87C5101F));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_ESCALATION_TIMED_OUT"]/*' />
    [NativeTypeName("#define UTC_E_ESCALATION_TIMED_OUT _HRESULT_TYPEDEF_(0x87C51020L)")]
    public const int UTC_E_ESCALATION_TIMED_OUT = unchecked((int)(0x87C51020));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SETUP_TIMED_OUT"]/*' />
    [NativeTypeName("#define UTC_E_SETUP_TIMED_OUT _HRESULT_TYPEDEF_(0x87C51021L)")]
    public const int UTC_E_SETUP_TIMED_OUT = unchecked((int)(0x87C51021));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRIGGER_MISMATCH"]/*' />
    [NativeTypeName("#define UTC_E_TRIGGER_MISMATCH _HRESULT_TYPEDEF_(0x87C51022L)")]
    public const int UTC_E_TRIGGER_MISMATCH = unchecked((int)(0x87C51022));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRIGGER_NOT_FOUND"]/*' />
    [NativeTypeName("#define UTC_E_TRIGGER_NOT_FOUND _HRESULT_TYPEDEF_(0x87C51023L)")]
    public const int UTC_E_TRIGGER_NOT_FOUND = unchecked((int)(0x87C51023));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SIF_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define UTC_E_SIF_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x87C51024L)")]
    public const int UTC_E_SIF_NOT_SUPPORTED = unchecked((int)(0x87C51024));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_DELAY_TERMINATED"]/*' />
    [NativeTypeName("#define UTC_E_DELAY_TERMINATED _HRESULT_TYPEDEF_(0x87C51025L)")]
    public const int UTC_E_DELAY_TERMINATED = unchecked((int)(0x87C51025));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_DEVICE_TICKET_ERROR"]/*' />
    [NativeTypeName("#define UTC_E_DEVICE_TICKET_ERROR _HRESULT_TYPEDEF_(0x87C51026L)")]
    public const int UTC_E_DEVICE_TICKET_ERROR = unchecked((int)(0x87C51026));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRACE_BUFFER_LIMIT_EXCEEDED"]/*' />
    [NativeTypeName("#define UTC_E_TRACE_BUFFER_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x87C51027L)")]
    public const int UTC_E_TRACE_BUFFER_LIMIT_EXCEEDED = unchecked((int)(0x87C51027));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_API_RESULT_UNAVAILABLE"]/*' />
    [NativeTypeName("#define UTC_E_API_RESULT_UNAVAILABLE _HRESULT_TYPEDEF_(0x87C51028L)")]
    public const int UTC_E_API_RESULT_UNAVAILABLE = unchecked((int)(0x87C51028));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_RPC_TIMEOUT"]/*' />
    [NativeTypeName("#define UTC_E_RPC_TIMEOUT _HRESULT_TYPEDEF_(0x87C51029L)")]
    public const int UTC_E_RPC_TIMEOUT = unchecked((int)(0x87C51029));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_RPC_WAIT_FAILED"]/*' />
    [NativeTypeName("#define UTC_E_RPC_WAIT_FAILED _HRESULT_TYPEDEF_(0x87C5102AL)")]
    public const int UTC_E_RPC_WAIT_FAILED = unchecked((int)(0x87C5102A));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_API_BUSY"]/*' />
    [NativeTypeName("#define UTC_E_API_BUSY _HRESULT_TYPEDEF_(0x87C5102BL)")]
    public const int UTC_E_API_BUSY = unchecked((int)(0x87C5102B));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRACE_MIN_DURATION_REQUIREMENT_NOT_MET"]/*' />
    [NativeTypeName("#define UTC_E_TRACE_MIN_DURATION_REQUIREMENT_NOT_MET _HRESULT_TYPEDEF_(0x87C5102CL)")]
    public const int UTC_E_TRACE_MIN_DURATION_REQUIREMENT_NOT_MET = unchecked((int)(0x87C5102C));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_EXCLUSIVITY_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define UTC_E_EXCLUSIVITY_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x87C5102DL)")]
    public const int UTC_E_EXCLUSIVITY_NOT_AVAILABLE = unchecked((int)(0x87C5102D));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_GETFILE_FILE_PATH_NOT_APPROVED"]/*' />
    [NativeTypeName("#define UTC_E_GETFILE_FILE_PATH_NOT_APPROVED _HRESULT_TYPEDEF_(0x87C5102EL)")]
    public const int UTC_E_GETFILE_FILE_PATH_NOT_APPROVED = unchecked((int)(0x87C5102E));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_ESCALATION_DIRECTORY_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define UTC_E_ESCALATION_DIRECTORY_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x87C5102FL)")]
    public const int UTC_E_ESCALATION_DIRECTORY_ALREADY_EXISTS = unchecked((int)(0x87C5102F));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TIME_TRIGGER_ON_START_INVALID"]/*' />
    [NativeTypeName("#define UTC_E_TIME_TRIGGER_ON_START_INVALID _HRESULT_TYPEDEF_(0x87C51030L)")]
    public const int UTC_E_TIME_TRIGGER_ON_START_INVALID = unchecked((int)(0x87C51030));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TIME_TRIGGER_ONLY_VALID_ON_SINGLE_TRANSITION"]/*' />
    [NativeTypeName("#define UTC_E_TIME_TRIGGER_ONLY_VALID_ON_SINGLE_TRANSITION _HRESULT_TYPEDEF_(0x87C51031L)")]
    public const int UTC_E_TIME_TRIGGER_ONLY_VALID_ON_SINGLE_TRANSITION = unchecked((int)(0x87C51031));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TIME_TRIGGER_INVALID_TIME_RANGE"]/*' />
    [NativeTypeName("#define UTC_E_TIME_TRIGGER_INVALID_TIME_RANGE _HRESULT_TYPEDEF_(0x87C51032L)")]
    public const int UTC_E_TIME_TRIGGER_INVALID_TIME_RANGE = unchecked((int)(0x87C51032));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_MULTIPLE_TIME_TRIGGER_ON_SINGLE_STATE"]/*' />
    [NativeTypeName("#define UTC_E_MULTIPLE_TIME_TRIGGER_ON_SINGLE_STATE _HRESULT_TYPEDEF_(0x87C51033L)")]
    public const int UTC_E_MULTIPLE_TIME_TRIGGER_ON_SINGLE_STATE = unchecked((int)(0x87C51033));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_BINARY_MISSING"]/*' />
    [NativeTypeName("#define UTC_E_BINARY_MISSING _HRESULT_TYPEDEF_(0x87C51034L)")]
    public const int UTC_E_BINARY_MISSING = unchecked((int)(0x87C51034));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FAILED_TO_RESOLVE_CONTAINER_ID"]/*' />
    [NativeTypeName("#define UTC_E_FAILED_TO_RESOLVE_CONTAINER_ID _HRESULT_TYPEDEF_(0x87C51036L)")]
    public const int UTC_E_FAILED_TO_RESOLVE_CONTAINER_ID = unchecked((int)(0x87C51036));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_UNABLE_TO_RESOLVE_SESSION"]/*' />
    [NativeTypeName("#define UTC_E_UNABLE_TO_RESOLVE_SESSION _HRESULT_TYPEDEF_(0x87C51037L)")]
    public const int UTC_E_UNABLE_TO_RESOLVE_SESSION = unchecked((int)(0x87C51037));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_THROTTLED"]/*' />
    [NativeTypeName("#define UTC_E_THROTTLED _HRESULT_TYPEDEF_(0x87C51038L)")]
    public const int UTC_E_THROTTLED = unchecked((int)(0x87C51038));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_UNAPPROVED_SCRIPT"]/*' />
    [NativeTypeName("#define UTC_E_UNAPPROVED_SCRIPT _HRESULT_TYPEDEF_(0x87C51039L)")]
    public const int UTC_E_UNAPPROVED_SCRIPT = unchecked((int)(0x87C51039));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SCRIPT_MISSING"]/*' />
    [NativeTypeName("#define UTC_E_SCRIPT_MISSING _HRESULT_TYPEDEF_(0x87C5103AL)")]
    public const int UTC_E_SCRIPT_MISSING = unchecked((int)(0x87C5103A));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SCENARIO_THROTTLED"]/*' />
    [NativeTypeName("#define UTC_E_SCENARIO_THROTTLED _HRESULT_TYPEDEF_(0x87C5103BL)")]
    public const int UTC_E_SCENARIO_THROTTLED = unchecked((int)(0x87C5103B));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_API_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define UTC_E_API_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x87C5103CL)")]
    public const int UTC_E_API_NOT_SUPPORTED = unchecked((int)(0x87C5103C));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_GETFILE_EXTERNAL_PATH_NOT_APPROVED"]/*' />
    [NativeTypeName("#define UTC_E_GETFILE_EXTERNAL_PATH_NOT_APPROVED _HRESULT_TYPEDEF_(0x87C5103DL)")]
    public const int UTC_E_GETFILE_EXTERNAL_PATH_NOT_APPROVED = unchecked((int)(0x87C5103D));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRY_GET_SCENARIO_TIMEOUT_EXCEEDED"]/*' />
    [NativeTypeName("#define UTC_E_TRY_GET_SCENARIO_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x87C5103EL)")]
    public const int UTC_E_TRY_GET_SCENARIO_TIMEOUT_EXCEEDED = unchecked((int)(0x87C5103E));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_CERT_REV_FAILED"]/*' />
    [NativeTypeName("#define UTC_E_CERT_REV_FAILED _HRESULT_TYPEDEF_(0x87C5103FL)")]
    public const int UTC_E_CERT_REV_FAILED = unchecked((int)(0x87C5103F));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FAILED_TO_START_NDISCAP"]/*' />
    [NativeTypeName("#define UTC_E_FAILED_TO_START_NDISCAP _HRESULT_TYPEDEF_(0x87C51040L)")]
    public const int UTC_E_FAILED_TO_START_NDISCAP = unchecked((int)(0x87C51040));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_KERNELDUMP_LIMIT_REACHED"]/*' />
    [NativeTypeName("#define UTC_E_KERNELDUMP_LIMIT_REACHED _HRESULT_TYPEDEF_(0x87C51041L)")]
    public const int UTC_E_KERNELDUMP_LIMIT_REACHED = unchecked((int)(0x87C51041));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_MISSING_AGGREGATE_EVENT_TAG"]/*' />
    [NativeTypeName("#define UTC_E_MISSING_AGGREGATE_EVENT_TAG _HRESULT_TYPEDEF_(0x87C51042L)")]
    public const int UTC_E_MISSING_AGGREGATE_EVENT_TAG = unchecked((int)(0x87C51042));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_INVALID_AGGREGATION_STRUCT"]/*' />
    [NativeTypeName("#define UTC_E_INVALID_AGGREGATION_STRUCT _HRESULT_TYPEDEF_(0x87C51043L)")]
    public const int UTC_E_INVALID_AGGREGATION_STRUCT = unchecked((int)(0x87C51043));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_ACTION_NOT_SUPPORTED_IN_DESTINATION"]/*' />
    [NativeTypeName("#define UTC_E_ACTION_NOT_SUPPORTED_IN_DESTINATION _HRESULT_TYPEDEF_(0x87C51044L)")]
    public const int UTC_E_ACTION_NOT_SUPPORTED_IN_DESTINATION = unchecked((int)(0x87C51044));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_MISSING_ATTRIBUTE"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_MISSING_ATTRIBUTE _HRESULT_TYPEDEF_(0x87C51045L)")]
    public const int UTC_E_FILTER_MISSING_ATTRIBUTE = unchecked((int)(0x87C51045));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_INVALID_TYPE"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_INVALID_TYPE _HRESULT_TYPEDEF_(0x87C51046L)")]
    public const int UTC_E_FILTER_INVALID_TYPE = unchecked((int)(0x87C51046));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_VARIABLE_NOT_FOUND"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_VARIABLE_NOT_FOUND _HRESULT_TYPEDEF_(0x87C51047L)")]
    public const int UTC_E_FILTER_VARIABLE_NOT_FOUND = unchecked((int)(0x87C51047));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_FUNCTION_RESTRICTED"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_FUNCTION_RESTRICTED _HRESULT_TYPEDEF_(0x87C51048L)")]
    public const int UTC_E_FILTER_FUNCTION_RESTRICTED = unchecked((int)(0x87C51048));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_VERSION_MISMATCH"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x87C51049L)")]
    public const int UTC_E_FILTER_VERSION_MISMATCH = unchecked((int)(0x87C51049));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_INVALID_FUNCTION"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_INVALID_FUNCTION _HRESULT_TYPEDEF_(0x87C51050L)")]
    public const int UTC_E_FILTER_INVALID_FUNCTION = unchecked((int)(0x87C51050));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_INVALID_FUNCTION_PARAMS"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_INVALID_FUNCTION_PARAMS _HRESULT_TYPEDEF_(0x87C51051L)")]
    public const int UTC_E_FILTER_INVALID_FUNCTION_PARAMS = unchecked((int)(0x87C51051));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_INVALID_COMMAND"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_INVALID_COMMAND _HRESULT_TYPEDEF_(0x87C51052L)")]
    public const int UTC_E_FILTER_INVALID_COMMAND = unchecked((int)(0x87C51052));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FILTER_ILLEGAL_EVAL"]/*' />
    [NativeTypeName("#define UTC_E_FILTER_ILLEGAL_EVAL _HRESULT_TYPEDEF_(0x87C51053L)")]
    public const int UTC_E_FILTER_ILLEGAL_EVAL = unchecked((int)(0x87C51053));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TTTRACER_RETURNED_ERROR"]/*' />
    [NativeTypeName("#define UTC_E_TTTRACER_RETURNED_ERROR _HRESULT_TYPEDEF_(0x87C51054L)")]
    public const int UTC_E_TTTRACER_RETURNED_ERROR = unchecked((int)(0x87C51054));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_AGENT_DIAGNOSTICS_TOO_LARGE"]/*' />
    [NativeTypeName("#define UTC_E_AGENT_DIAGNOSTICS_TOO_LARGE _HRESULT_TYPEDEF_(0x87C51055L)")]
    public const int UTC_E_AGENT_DIAGNOSTICS_TOO_LARGE = unchecked((int)(0x87C51055));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_FAILED_TO_RECEIVE_AGENT_DIAGNOSTICS"]/*' />
    [NativeTypeName("#define UTC_E_FAILED_TO_RECEIVE_AGENT_DIAGNOSTICS _HRESULT_TYPEDEF_(0x87C51056L)")]
    public const int UTC_E_FAILED_TO_RECEIVE_AGENT_DIAGNOSTICS = unchecked((int)(0x87C51056));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SCENARIO_HAS_NO_ACTIONS"]/*' />
    [NativeTypeName("#define UTC_E_SCENARIO_HAS_NO_ACTIONS _HRESULT_TYPEDEF_(0x87C51057L)")]
    public const int UTC_E_SCENARIO_HAS_NO_ACTIONS = unchecked((int)(0x87C51057));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TTTRACER_STORAGE_FULL"]/*' />
    [NativeTypeName("#define UTC_E_TTTRACER_STORAGE_FULL _HRESULT_TYPEDEF_(0x87C51058L)")]
    public const int UTC_E_TTTRACER_STORAGE_FULL = unchecked((int)(0x87C51058));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_INSUFFICIENT_SPACE_TO_START_TRACE"]/*' />
    [NativeTypeName("#define UTC_E_INSUFFICIENT_SPACE_TO_START_TRACE _HRESULT_TYPEDEF_(0x87C51059L)")]
    public const int UTC_E_INSUFFICIENT_SPACE_TO_START_TRACE = unchecked((int)(0x87C51059));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_ESCALATION_CANCELLED_AT_SHUTDOWN"]/*' />
    [NativeTypeName("#define UTC_E_ESCALATION_CANCELLED_AT_SHUTDOWN _HRESULT_TYPEDEF_(0x87C5105AL)")]
    public const int UTC_E_ESCALATION_CANCELLED_AT_SHUTDOWN = unchecked((int)(0x87C5105A));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_GETFILEINFOACTION_FILE_NOT_APPROVED"]/*' />
    [NativeTypeName("#define UTC_E_GETFILEINFOACTION_FILE_NOT_APPROVED _HRESULT_TYPEDEF_(0x87C5105BL)")]
    public const int UTC_E_GETFILEINFOACTION_FILE_NOT_APPROVED = unchecked((int)(0x87C5105B));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_SETREGKEYACTION_TYPE_NOT_APPROVED"]/*' />
    [NativeTypeName("#define UTC_E_SETREGKEYACTION_TYPE_NOT_APPROVED _HRESULT_TYPEDEF_(0x87C5105CL)")]
    public const int UTC_E_SETREGKEYACTION_TYPE_NOT_APPROVED = unchecked((int)(0x87C5105C));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_TRACE_THROTTLED"]/*' />
    [NativeTypeName("#define UTC_E_TRACE_THROTTLED _HRESULT_TYPEDEF_(0x87C5105DL)")]
    public const int UTC_E_TRACE_THROTTLED = unchecked((int)(0x87C5105D));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_WINRE_COMPLIANCE_CAPTURE_FAILED"]/*' />
    [NativeTypeName("#define UTC_E_WINRE_COMPLIANCE_CAPTURE_FAILED _HRESULT_TYPEDEF_(0x87C5105EL)")]
    public const int UTC_E_WINRE_COMPLIANCE_CAPTURE_FAILED = unchecked((int)(0x87C5105E));

    /// <include file='UTC.xml' path='doc/member[@name="UTC.UTC_E_WINRE_ETM_ENABLED"]/*' />
    [NativeTypeName("#define UTC_E_WINRE_ETM_ENABLED _HRESULT_TYPEDEF_(0x87C5105FL)")]
    public const int UTC_E_WINRE_ETM_ENABLED = unchecked((int)(0x87C5105F));
}
