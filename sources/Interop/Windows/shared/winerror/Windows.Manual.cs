// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int FACILITY_NULL = 0;

        public const int FACILITY_RPC = 1;

        public const int FACILITY_DISPATCH = 2;

        public const int FACILITY_STORAGE = 3;

        public const int FACILITY_ITF = 4;

        public const int FACILITY_WIN32 = 7;

        public const int FACILITY_WINDOWS = 8;

        public const int FACILITY_SSPI = 9;

        public const int FACILITY_SECURITY = 9;

        public const int FACILITY_CONTROL = 10;

        public const int FACILITY_CERT = 11;

        public const int FACILITY_INTERNET = 12;

        public const int FACILITY_MEDIASERVER = 13;

        public const int FACILITY_MSMQ = 14;

        public const int FACILITY_SETUPAPI = 15;

        public const int FACILITY_SCARD = 16;

        public const int FACILITY_COMPLUS = 17;

        public const int FACILITY_AAF = 18;

        public const int FACILITY_URT = 19;

        public const int FACILITY_ACS = 20;

        public const int FACILITY_DPLAY = 21;

        public const int FACILITY_UMI = 22;

        public const int FACILITY_SXS = 23;

        public const int FACILITY_WINDOWS_CE = 24;

        public const int FACILITY_HTTP = 25;

        public const int FACILITY_USERMODE_COMMONLOG = 26;

        public const int FACILITY_WER = 27;

        public const int FACILITY_USERMODE_FILTER_MANAGER = 31;

        public const int FACILITY_BACKGROUNDCOPY = 32;

        public const int FACILITY_CONFIGURATION = 33;

        public const int FACILITY_WIA = 33;

        public const int FACILITY_STATE_MANAGEMENT = 34;

        public const int FACILITY_METADIRECTORY = 35;

        public const int FACILITY_WINDOWSUPDATE = 36;

        public const int FACILITY_DIRECTORYSERVICE = 37;

        public const int FACILITY_GRAPHICS = 38;

        public const int FACILITY_SHELL = 39;

        public const int FACILITY_NAP = 39;

        public const int FACILITY_TPM_SERVICES = 40;

        public const int FACILITY_TPM_SOFTWARE = 41;

        public const int FACILITY_UI = 42;

        public const int FACILITY_XAML = 43;

        public const int FACILITY_ACTION_QUEUE = 44;

        public const int FACILITY_PLA = 48;

        public const int FACILITY_WINDOWS_SETUP = 48;

        public const int FACILITY_FVE = 49;

        public const int FACILITY_FWP = 50;

        public const int FACILITY_WINRM = 51;

        public const int FACILITY_NDIS = 52;

        public const int FACILITY_USERMODE_HYPERVISOR = 53;

        public const int FACILITY_CMI = 54;

        public const int FACILITY_USERMODE_VIRTUALIZATION = 55;

        public const int FACILITY_USERMODE_VOLMGR = 56;

        public const int FACILITY_BCD = 57;

        public const int FACILITY_USERMODE_VHD = 58;

        public const int FACILITY_USERMODE_HNS = 59;

        public const int FACILITY_SDIAG = 60;

        public const int FACILITY_WEBSERVICES = 61;

        public const int FACILITY_WINPE = 61;

        public const int FACILITY_WPN = 62;

        public const int FACILITY_WINDOWS_STORE = 63;

        public const int FACILITY_INPUT = 64;

        public const int FACILITY_EAP = 66;

        public const int FACILITY_WINDOWS_DEFENDER = 80;

        public const int FACILITY_OPC = 81;

        public const int FACILITY_XPS = 82;

        public const int FACILITY_MBN = 84;

        public const int FACILITY_POWERSHELL = 84;

        public const int FACILITY_RAS = 83;

        public const int FACILITY_P2P_INT = 98;

        public const int FACILITY_P2P = 99;

        public const int FACILITY_DAF = 100;

        public const int FACILITY_BLUETOOTH_ATT = 101;

        public const int FACILITY_AUDIO = 102;

        public const int FACILITY_STATEREPOSITORY = 103;

        public const int FACILITY_VISUALCPP = 109;

        public const int FACILITY_SCRIPT = 112;

        public const int FACILITY_PARSE = 113;

        public const int FACILITY_BLB = 120;

        public const int FACILITY_BLB_CLI = 121;

        public const int FACILITY_WSBAPP = 122;

        public const int FACILITY_BLBUI = 128;

        public const int FACILITY_USN = 129;

        public const int FACILITY_USERMODE_VOLSNAP = 130;

        public const int FACILITY_TIERING = 131;

        public const int FACILITY_WSB_ONLINE = 133;

        public const int FACILITY_ONLINE_ID = 134;

        public const int FACILITY_DEVICE_UPDATE_AGENT = 135;

        public const int FACILITY_DRVSERVICING = 136;

        public const int FACILITY_DLS = 153;

        public const int FACILITY_DELIVERY_OPTIMIZATION = 208;

        public const int FACILITY_USERMODE_SPACES = 231;

        public const int FACILITY_USER_MODE_SECURITY_CORE = 232;

        public const int FACILITY_USERMODE_LICENSING = 234;

        public const int FACILITY_SOS = 160;

        public const int FACILITY_DEBUGGERS = 176;

        public const int FACILITY_SPP = 256;

        public const int FACILITY_RESTORE = 256;

        public const int FACILITY_DMSERVER = 256;

        public const int FACILITY_DEPLOYMENT_SERVICES_SERVER = 257;

        public const int FACILITY_DEPLOYMENT_SERVICES_IMAGING = 258;

        public const int FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT = 259;

        public const int FACILITY_DEPLOYMENT_SERVICES_UTIL = 260;

        public const int FACILITY_DEPLOYMENT_SERVICES_BINLSVC = 261;

        public const int FACILITY_DEPLOYMENT_SERVICES_PXE = 263;

        public const int FACILITY_DEPLOYMENT_SERVICES_TFTP = 264;

        public const int FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT = 272;

        public const int FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING = 278;

        public const int FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER = 289;

        public const int FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT = 290;

        public const int FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER = 293;

        public const int FACILITY_LINGUISTIC_SERVICES = 305;

        public const int FACILITY_AUDIOSTREAMING = 1094;

        public const int FACILITY_ACCELERATOR = 1536;

        public const int FACILITY_WMAAECMA = 1996;

        public const int FACILITY_DIRECTMUSIC = 2168;

        public const int FACILITY_DIRECT3D10 = 2169;

        public const int FACILITY_DXGI = 2170;

        public const int FACILITY_DXGI_DDI = 2171;

        public const int FACILITY_DIRECT3D11 = 2172;

        public const int FACILITY_DIRECT3D11_DEBUG = 2173;

        public const int FACILITY_DIRECT3D12 = 2174;

        public const int FACILITY_DIRECT3D12_DEBUG = 2175;

        public const int FACILITY_LEAP = 2184;

        public const int FACILITY_AUDCLNT = 2185;

        public const int FACILITY_WINCODEC_DWRITE_DWM = 2200;

        public const int FACILITY_WINML = 2192;

        public const int FACILITY_DIRECT2D = 2201;

        public const int FACILITY_DEFRAG = 2304;

        public const int FACILITY_USERMODE_SDBUS = 2305;

        public const int FACILITY_JSCRIPT = 2306;

        public const int FACILITY_PIDGENX = 2561;

        public const int FACILITY_EAS = 85;

        public const int FACILITY_WEB = 885;

        public const int FACILITY_WEB_SOCKET = 886;

        public const int FACILITY_MOBILE = 1793;

        public const int FACILITY_SQLITE = 1967;

        public const int FACILITY_UTC = 1989;

        public const int FACILITY_WEP = 2049;

        public const int FACILITY_SYNCENGINE = 2050;

        public const int FACILITY_XBOX = 2339;

        public const int FACILITY_GAME = 2340;

        public const int FACILITY_PIX = 2748;

        public const int ERROR_SUCCESS = 0;

        public const int NO_ERROR = 0;

        public const int SEC_E_OK = 0x00000000;

        public const int ERROR_INVALID_FUNCTION = 1;

        public const int ERROR_FILE_NOT_FOUND = 2;

        public const int ERROR_PATH_NOT_FOUND = 3;

        public const int ERROR_TOO_MANY_OPEN_FILES = 4;

        public const int ERROR_ACCESS_DENIED = 5;

        public const int ERROR_INVALID_HANDLE = 6;

        public const int ERROR_ARENA_TRASHED = 7;

        public const int ERROR_NOT_ENOUGH_MEMORY = 8;

        public const int ERROR_INVALID_BLOCK = 9;

        public const int ERROR_BAD_ENVIRONMENT = 10;

        public const int ERROR_BAD_FORMAT = 11;

        public const int ERROR_INVALID_ACCESS = 12;

        public const int ERROR_INVALID_DATA = 13;

        public const int ERROR_OUTOFMEMORY = 14;

        public const int ERROR_INVALID_DRIVE = 15;

        public const int ERROR_CURRENT_DIRECTORY = 16;

        public const int ERROR_NOT_SAME_DEVICE = 17;

        public const int ERROR_NO_MORE_FILES = 18;

        public const int ERROR_WRITE_PROTECT = 19;

        public const int ERROR_BAD_UNIT = 20;

        public const int ERROR_NOT_READY = 21;

        public const int ERROR_BAD_COMMAND = 22;

        public const int ERROR_CRC = 23;

        public const int ERROR_BAD_LENGTH = 24;

        public const int ERROR_SEEK = 25;

        public const int ERROR_NOT_DOS_DISK = 26;

        public const int ERROR_SECTOR_NOT_FOUND = 27;

        public const int ERROR_OUT_OF_PAPER = 28;

        public const int ERROR_WRITE_FAULT = 29;

        public const int ERROR_READ_FAULT = 30;

        public const int ERROR_GEN_FAILURE = 31;

        public const int ERROR_SHARING_VIOLATION = 32;

        public const int ERROR_LOCK_VIOLATION = 33;

        public const int ERROR_WRONG_DISK = 34;

        public const int ERROR_SHARING_BUFFER_EXCEEDED = 36;

        public const int ERROR_HANDLE_EOF = 38;

        public const int ERROR_HANDLE_DISK_FULL = 39;

        public const int ERROR_NOT_SUPPORTED = 50;

        public const int ERROR_REM_NOT_LIST = 51;

        public const int ERROR_DUP_NAME = 52;

        public const int ERROR_BAD_NETPATH = 53;

        public const int ERROR_NETWORK_BUSY = 54;

        public const int ERROR_DEV_NOT_EXIST = 55;

        public const int ERROR_TOO_MANY_CMDS = 56;

        public const int ERROR_ADAP_HDW_ERR = 57;

        public const int ERROR_BAD_NET_RESP = 58;

        public const int ERROR_UNEXP_NET_ERR = 59;

        public const int ERROR_BAD_REM_ADAP = 60;

        public const int ERROR_PRINTQ_FULL = 61;

        public const int ERROR_NO_SPOOL_SPACE = 62;

        public const int ERROR_PRINT_CANCELLED = 63;

        public const int ERROR_NETNAME_DELETED = 64;

        public const int ERROR_NETWORK_ACCESS_DENIED = 65;

        public const int ERROR_BAD_DEV_TYPE = 66;

        public const int ERROR_BAD_NET_NAME = 67;

        public const int ERROR_TOO_MANY_NAMES = 68;

        public const int ERROR_TOO_MANY_SESS = 69;

        public const int ERROR_SHARING_PAUSED = 70;

        public const int ERROR_REQ_NOT_ACCEP = 71;

        public const int ERROR_REDIR_PAUSED = 72;

        public const int ERROR_FILE_EXISTS = 80;

        public const int ERROR_CANNOT_MAKE = 82;

        public const int ERROR_FAIL_I24 = 83;

        public const int ERROR_OUT_OF_STRUCTURES = 84;

        public const int ERROR_ALREADY_ASSIGNED = 85;

        public const int ERROR_INVALID_PASSWORD = 86;

        public const int ERROR_INVALID_PARAMETER = 87;

        public const int ERROR_NET_WRITE_FAULT = 88;

        public const int ERROR_NO_PROC_SLOTS = 89;

        public const int ERROR_TOO_MANY_SEMAPHORES = 100;

        public const int ERROR_EXCL_SEM_ALREADY_OWNED = 101;

        public const int ERROR_SEM_IS_SET = 102;

        public const int ERROR_TOO_MANY_SEM_REQUESTS = 103;

        public const int ERROR_INVALID_AT_INTERRUPT_TIME = 104;

        public const int ERROR_SEM_OWNER_DIED = 105;

        public const int ERROR_SEM_USER_LIMIT = 106;

        public const int ERROR_DISK_CHANGE = 107;

        public const int ERROR_DRIVE_LOCKED = 108;

        public const int ERROR_BROKEN_PIPE = 109;

        public const int ERROR_OPEN_FAILED = 110;

        public const int ERROR_BUFFER_OVERFLOW = 111;

        public const int ERROR_DISK_FULL = 112;

        public const int ERROR_NO_MORE_SEARCH_HANDLES = 113;

        public const int ERROR_INVALID_TARGET_HANDLE = 114;

        public const int ERROR_INVALID_CATEGORY = 117;

        public const int ERROR_INVALID_VERIFY_SWITCH = 118;

        public const int ERROR_BAD_DRIVER_LEVEL = 119;

        public const int ERROR_CALL_NOT_IMPLEMENTED = 120;

        public const int ERROR_SEM_TIMEOUT = 121;

        public const int ERROR_INSUFFICIENT_BUFFER = 122;

        public const int ERROR_INVALID_NAME = 123;

        public const int ERROR_INVALID_LEVEL = 124;

        public const int ERROR_NO_VOLUME_LABEL = 125;

        public const int ERROR_MOD_NOT_FOUND = 126;

        public const int ERROR_PROC_NOT_FOUND = 127;

        public const int ERROR_WAIT_NO_CHILDREN = 128;

        public const int ERROR_CHILD_NOT_COMPLETE = 129;

        public const int ERROR_DIRECT_ACCESS_HANDLE = 130;

        public const int ERROR_NEGATIVE_SEEK = 131;

        public const int ERROR_SEEK_ON_DEVICE = 132;

        public const int ERROR_IS_JOIN_TARGET = 133;

        public const int ERROR_IS_JOINED = 134;

        public const int ERROR_IS_SUBSTED = 135;

        public const int ERROR_NOT_JOINED = 136;

        public const int ERROR_NOT_SUBSTED = 137;

        public const int ERROR_JOIN_TO_JOIN = 138;

        public const int ERROR_SUBST_TO_SUBST = 139;

        public const int ERROR_JOIN_TO_SUBST = 140;

        public const int ERROR_SUBST_TO_JOIN = 141;

        public const int ERROR_BUSY_DRIVE = 142;

        public const int ERROR_SAME_DRIVE = 143;

        public const int ERROR_DIR_NOT_ROOT = 144;

        public const int ERROR_DIR_NOT_EMPTY = 145;

        public const int ERROR_IS_SUBST_PATH = 146;

        public const int ERROR_IS_JOIN_PATH = 147;

        public const int ERROR_PATH_BUSY = 148;

        public const int ERROR_IS_SUBST_TARGET = 149;

        public const int ERROR_SYSTEM_TRACE = 150;

        public const int ERROR_INVALID_EVENT_COUNT = 151;

        public const int ERROR_TOO_MANY_MUXWAITERS = 152;

        public const int ERROR_INVALID_LIST_FORMAT = 153;

        public const int ERROR_LABEL_TOO_LONG = 154;

        public const int ERROR_TOO_MANY_TCBS = 155;

        public const int ERROR_SIGNAL_REFUSED = 156;

        public const int ERROR_DISCARDED = 157;

        public const int ERROR_NOT_LOCKED = 158;

        public const int ERROR_BAD_THREADID_ADDR = 159;

        public const int ERROR_BAD_ARGUMENTS = 160;

        public const int ERROR_BAD_PATHNAME = 161;

        public const int ERROR_SIGNAL_PENDING = 162;

        public const int ERROR_MAX_THRDS_REACHED = 164;

        public const int ERROR_LOCK_FAILED = 167;

        public const int ERROR_BUSY = 170;

        public const int ERROR_DEVICE_SUPPORT_IN_PROGRESS = 171;

        public const int ERROR_CANCEL_VIOLATION = 173;

        public const int ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174;

        public const int ERROR_INVALID_SEGMENT_NUMBER = 180;

        public const int ERROR_INVALID_ORDINAL = 182;

        public const int ERROR_ALREADY_EXISTS = 183;

        public const int ERROR_INVALID_FLAG_NUMBER = 186;

        public const int ERROR_SEM_NOT_FOUND = 187;

        public const int ERROR_INVALID_STARTING_CODESEG = 188;

        public const int ERROR_INVALID_STACKSEG = 189;

        public const int ERROR_INVALID_MODULETYPE = 190;

        public const int ERROR_INVALID_EXE_SIGNATURE = 191;

        public const int ERROR_EXE_MARKED_INVALID = 192;

        // %1 is not a valid Win32 application.;

        public const int ERROR_BAD_EXE_FORMAT = 193;

        public const int ERROR_ITERATED_DATA_EXCEEDS_64k = 194;

        public const int ERROR_INVALID_MINALLOCSIZE = 195;

        public const int ERROR_DYNLINK_FROM_INVALID_RING = 196;

        public const int ERROR_IOPL_NOT_ENABLED = 197;

        public const int ERROR_INVALID_SEGDPL = 198;

        public const int ERROR_AUTODATASEG_EXCEEDS_64k = 199;

        public const int ERROR_RING2SEG_MUST_BE_MOVABLE = 200;

        public const int ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201;

        public const int ERROR_INFLOOP_IN_RELOC_CHAIN = 202;

        public const int ERROR_ENVVAR_NOT_FOUND = 203;

        public const int ERROR_NO_SIGNAL_SENT = 205;

        public const int ERROR_FILENAME_EXCED_RANGE = 206;

        public const int ERROR_RING2_STACK_IN_USE = 207;

        public const int ERROR_META_EXPANSION_TOO_LONG = 208;

        public const int ERROR_INVALID_SIGNAL_NUMBER = 209;

        public const int ERROR_THREAD_1_INACTIVE = 210;

        public const int ERROR_LOCKED = 212;

        public const int ERROR_TOO_MANY_MODULES = 214;

        public const int ERROR_NESTING_NOT_ALLOWED = 215;

        public const int ERROR_EXE_MACHINE_TYPE_MISMATCH = 216;

        public const int ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217;

        public const int ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218;

        public const int ERROR_FILE_CHECKED_OUT = 220;

        public const int ERROR_CHECKOUT_REQUIRED = 221;

        public const int ERROR_BAD_FILE_TYPE = 222;

        public const int ERROR_FILE_TOO_LARGE = 223;

        public const int ERROR_FORMS_AUTH_REQUIRED = 224;

        public const int ERROR_VIRUS_INFECTED = 225;

        public const int ERROR_VIRUS_DELETED = 226;

        public const int ERROR_PIPE_LOCAL = 229;

        public const int ERROR_BAD_PIPE = 230;

        public const int ERROR_PIPE_BUSY = 231;

        public const int ERROR_NO_DATA = 232;

        public const int ERROR_PIPE_NOT_CONNECTED = 233;

        public const int ERROR_MORE_DATA = 234;

        public const int ERROR_NO_WORK_DONE = 235;

        public const int ERROR_VC_DISCONNECTED = 240;

        public const int ERROR_INVALID_EA_NAME = 254;

        public const int ERROR_EA_LIST_INCONSISTENT = 255;

        public const int WAIT_TIMEOUT = 258;

        public const int ERROR_NO_MORE_ITEMS = 259;

        public const int ERROR_CANNOT_COPY = 266;

        public const int ERROR_DIRECTORY = 267;

        public const int ERROR_EAS_DIDNT_FIT = 275;

        public const int ERROR_EA_FILE_CORRUPT = 276;

        public const int ERROR_EA_TABLE_FULL = 277;

        public const int ERROR_INVALID_EA_HANDLE = 278;

        public const int ERROR_EAS_NOT_SUPPORTED = 282;

        public const int ERROR_NOT_OWNER = 288;

        public const int ERROR_TOO_MANY_POSTS = 298;

        public const int ERROR_PARTIAL_COPY = 299;

        public const int ERROR_OPLOCK_NOT_GRANTED = 300;

        public const int ERROR_INVALID_OPLOCK_PROTOCOL = 301;

        public const int ERROR_DISK_TOO_FRAGMENTED = 302;

        public const int ERROR_DELETE_PENDING = 303;

        public const int ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 304;

        public const int ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 305;

        public const int ERROR_SECURITY_STREAM_IS_INCONSISTENT = 306;

        public const int ERROR_INVALID_LOCK_RANGE = 307;

        public const int ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT = 308;

        public const int ERROR_NOTIFICATION_GUID_ALREADY_DEFINED = 309;

        public const int ERROR_INVALID_EXCEPTION_HANDLER = 310;

        public const int ERROR_DUPLICATE_PRIVILEGES = 311;

        public const int ERROR_NO_RANGES_PROCESSED = 312;

        public const int ERROR_NOT_ALLOWED_ON_SYSTEM_FILE = 313;

        public const int ERROR_DISK_RESOURCES_EXHAUSTED = 314;

        public const int ERROR_INVALID_TOKEN = 315;

        public const int ERROR_DEVICE_FEATURE_NOT_SUPPORTED = 316;

        public const int ERROR_MR_MID_NOT_FOUND = 317;

        public const int ERROR_SCOPE_NOT_FOUND = 318;

        public const int ERROR_UNDEFINED_SCOPE = 319;

        public const int ERROR_INVALID_CAP = 320;

        public const int ERROR_DEVICE_UNREACHABLE = 321;

        public const int ERROR_DEVICE_NO_RESOURCES = 322;

        public const int ERROR_DATA_CHECKSUM_ERROR = 323;

        public const int ERROR_INTERMIXED_KERNEL_EA_OPERATION = 324;

        public const int ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED = 326;

        public const int ERROR_OFFSET_ALIGNMENT_VIOLATION = 327;

        public const int ERROR_INVALID_FIELD_IN_PARAMETER_LIST = 328;

        public const int ERROR_OPERATION_IN_PROGRESS = 329;

        public const int ERROR_BAD_DEVICE_PATH = 330;

        public const int ERROR_TOO_MANY_DESCRIPTORS = 331;

        public const int ERROR_SCRUB_DATA_DISABLED = 332;

        public const int ERROR_NOT_REDUNDANT_STORAGE = 333;

        public const int ERROR_RESIDENT_FILE_NOT_SUPPORTED = 334;

        public const int ERROR_COMPRESSED_FILE_NOT_SUPPORTED = 335;

        public const int ERROR_DIRECTORY_NOT_SUPPORTED = 336;

        public const int ERROR_NOT_READ_FROM_COPY = 337;

        public const int ERROR_FT_WRITE_FAILURE = 338;

        public const int ERROR_FT_DI_SCAN_REQUIRED = 339;

        public const int ERROR_INVALID_KERNEL_INFO_VERSION = 340;

        public const int ERROR_INVALID_PEP_INFO_VERSION = 341;

        public const int ERROR_OBJECT_NOT_EXTERNALLY_BACKED = 342;

        public const int ERROR_EXTERNAL_BACKING_PROVIDER_UNKNOWN = 343;

        public const int ERROR_COMPRESSION_NOT_BENEFICIAL = 344;

        public const int ERROR_STORAGE_TOPOLOGY_ID_MISMATCH = 345;

        public const int ERROR_BLOCKED_BY_PARENTAL_CONTROLS = 346;

        public const int ERROR_BLOCK_TOO_MANY_REFERENCES = 347;

        public const int ERROR_MARKED_TO_DISALLOW_WRITES = 348;

        public const int ERROR_ENCLAVE_FAILURE = 349;

        public const int ERROR_FAIL_NOACTION_REBOOT = 350;

        public const int ERROR_FAIL_SHUTDOWN = 351;

        public const int ERROR_FAIL_RESTART = 352;

        public const int ERROR_MAX_SESSIONS_REACHED = 353;

        public const int ERROR_NETWORK_ACCESS_DENIED_EDP = 354;

        public const int ERROR_DEVICE_HINT_NAME_BUFFER_TOO_SMALL = 355;

        public const int ERROR_EDP_POLICY_DENIES_OPERATION = 356;

        public const int ERROR_EDP_DPL_POLICY_CANT_BE_SATISFIED = 357;

        public const int ERROR_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT = 358;

        public const int ERROR_DEVICE_IN_MAINTENANCE = 359;

        public const int ERROR_NOT_SUPPORTED_ON_DAX = 360;

        public const int ERROR_DAX_MAPPING_EXISTS = 361;

        public const int ERROR_CLOUD_FILE_PROVIDER_NOT_RUNNING = 362;

        public const int ERROR_CLOUD_FILE_METADATA_CORRUPT = 363;

        public const int ERROR_CLOUD_FILE_METADATA_TOO_LARGE = 364;

        public const int ERROR_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE = 365;

        public const int ERROR_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH = 366;

        public const int ERROR_CHILD_PROCESS_BLOCKED = 367;

        public const int ERROR_STORAGE_LOST_DATA_PERSISTENCE = 368;

        public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_UNAVAILABLE = 369;

        public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_METADATA_CORRUPT = 370;

        public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_BUSY = 371;

        public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_PROVIDER_UNKNOWN = 372;

        public const int ERROR_GDI_HANDLE_LEAK = 373;

        public const int ERROR_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS = 374;

        public const int ERROR_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED = 375;

        public const int ERROR_NOT_A_CLOUD_FILE = 376;

        public const int ERROR_CLOUD_FILE_NOT_IN_SYNC = 377;

        public const int ERROR_CLOUD_FILE_ALREADY_CONNECTED = 378;

        public const int ERROR_CLOUD_FILE_NOT_SUPPORTED = 379;

        public const int ERROR_CLOUD_FILE_INVALID_REQUEST = 380;

        public const int ERROR_CLOUD_FILE_READ_ONLY_VOLUME = 381;

        public const int ERROR_CLOUD_FILE_CONNECTED_PROVIDER_ONLY = 382;

        public const int ERROR_CLOUD_FILE_VALIDATION_FAILED = 383;

        public const int ERROR_SMB1_NOT_AVAILABLE = 384;

        public const int ERROR_FILE_SYSTEM_VIRTUALIZATION_INVALID_OPERATION = 385;

        public const int ERROR_CLOUD_FILE_AUTHENTICATION_FAILED = 386;

        public const int ERROR_CLOUD_FILE_INSUFFICIENT_RESOURCES = 387;

        public const int ERROR_CLOUD_FILE_NETWORK_UNAVAILABLE = 388;

        public const int ERROR_CLOUD_FILE_UNSUCCESSFUL = 389;

        public const int ERROR_CLOUD_FILE_NOT_UNDER_SYNC_ROOT = 390;

        public const int ERROR_CLOUD_FILE_IN_USE = 391;

        public const int ERROR_CLOUD_FILE_PINNED = 392;

        public const int ERROR_CLOUD_FILE_REQUEST_ABORTED = 393;

        public const int ERROR_CLOUD_FILE_PROPERTY_CORRUPT = 394;

        public const int ERROR_CLOUD_FILE_ACCESS_DENIED = 395;

        public const int ERROR_CLOUD_FILE_INCOMPATIBLE_HARDLINKS = 396;

        public const int ERROR_CLOUD_FILE_PROPERTY_LOCK_CONFLICT = 397;

        public const int ERROR_CLOUD_FILE_REQUEST_CANCELED = 398;

        public const int ERROR_EXTERNAL_SYSKEY_NOT_SUPPORTED = 399;

        public const int ERROR_THREAD_MODE_ALREADY_BACKGROUND = 400;

        public const int ERROR_THREAD_MODE_NOT_BACKGROUND = 401;

        public const int ERROR_PROCESS_MODE_ALREADY_BACKGROUND = 402;

        public const int ERROR_PROCESS_MODE_NOT_BACKGROUND = 403;

        public const int ERROR_CLOUD_FILE_PROVIDER_TERMINATED = 404;

        public const int ERROR_NOT_A_CLOUD_SYNC_ROOT = 405;

        public const int ERROR_FILE_PROTECTED_UNDER_DPL = 406;

        public const int ERROR_VOLUME_NOT_CLUSTER_ALIGNED = 407;

        public const int ERROR_NO_PHYSICALLY_ALIGNED_FREE_SPACE_FOUND = 408;

        public const int ERROR_APPX_FILE_NOT_ENCRYPTED = 409;

        public const int ERROR_RWRAW_ENCRYPTED_FILE_NOT_ENCRYPTED = 410;

        public const int ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILEOFFSET = 411;

        public const int ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_FILERANGE = 412;

        public const int ERROR_RWRAW_ENCRYPTED_INVALID_EDATAINFO_PARAMETER = 413;

        public const int ERROR_LINUX_SUBSYSTEM_NOT_PRESENT = 414;

        public const int ERROR_FT_READ_FAILURE = 415;

        public const int ERROR_STORAGE_RESERVE_ID_INVALID = 416;

        public const int ERROR_STORAGE_RESERVE_DOES_NOT_EXIST = 417;

        public const int ERROR_STORAGE_RESERVE_ALREADY_EXISTS = 418;

        public const int ERROR_STORAGE_RESERVE_NOT_EMPTY = 419;

        public const int ERROR_NOT_A_DAX_VOLUME = 420;

        public const int ERROR_NOT_DAX_MAPPABLE = 421;

        public const int ERROR_TIME_SENSITIVE_THREAD = 422;

        public const int ERROR_DPL_NOT_SUPPORTED_FOR_USER = 423;

        public const int ERROR_CASE_DIFFERING_NAMES_IN_DIR = 424;

        public const int ERROR_FILE_NOT_SUPPORTED = 425;

        public const int ERROR_CLOUD_FILE_REQUEST_TIMEOUT = 426;

        public const int ERROR_NO_TASK_QUEUE = 427;

        public const int ERROR_SRC_SRV_DLL_LOAD_FAILED = 428;

        public const int ERROR_NOT_SUPPORTED_WITH_BTT = 429;

        public const int ERROR_ENCRYPTION_DISABLED = 430;

        public const int ERROR_ENCRYPTING_METADATA_DISALLOWED = 431;

        public const int ERROR_CANT_CLEAR_ENCRYPTION_FLAG = 432;

        public const int ERROR_NO_SUCH_DEVICE = 433;

        public const int ERROR_ARITHMETIC_OVERFLOW = 534;

        public const int SEVERITY_SUCCESS = 0;

        public const int SEVERITY_ERROR = 1;

        public const int E_UNEXPECTED = unchecked((int)0x8000FFFF);

        public const int E_NOTIMPL = unchecked((int)0x80004001);

        public const int E_OUTOFMEMORY = unchecked((int)0x8007000E);

        public const int E_INVALIDARG = unchecked((int)0x80070057);

        public const int E_NOINTERFACE = unchecked((int)0x80004002);

        public const int E_POINTER = unchecked((int)0x80004003);

        public const int E_HANDLE = unchecked((int)0x80070006);

        public const int E_ABORT = unchecked((int)0x80004004);

        public const int E_FAIL = unchecked((int)0x80004005);

        public const int E_ACCESSDENIED = unchecked((int)0x80070005);

        public const int S_OK = 0;

        public const int S_FALSE = 1;

        public const int DXGI_STATUS_OCCLUDED = 0x087A0001;

        public const int DXGI_STATUS_CLIPPED = 0x087A0002;

        public const int DXGI_STATUS_NO_REDIRECTION = 0x087A0004;

        public const int DXGI_STATUS_NO_DESKTOP_ACCESS = 0x087A0005;

        public const int DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = 0x087A0006;

        public const int DXGI_STATUS_MODE_CHANGED = 0x087A0007;

        public const int DXGI_STATUS_MODE_CHANGE_IN_PROGRESS = 0x087A0008;

        public const int DXGI_STATUS_UNOCCLUDED = 0x087A0009;

        public const int DXGI_STATUS_DDA_WAS_STILL_DRAWING = 0x087A000A;

        public const int DXGI_STATUS_PRESENT_REQUIRED = 0x087A002F;

        public const int DXGI_ERROR_INVALID_CALL = unchecked((int)0x887A0001);

        public const int DXGI_ERROR_NOT_FOUND = unchecked((int)0x887A0002);

        public const int DXGI_ERROR_MORE_DATA = unchecked((int)0x887A0003);

        public const int DXGI_ERROR_UNSUPPORTED = unchecked((int)0x887A0004);

        public const int DXGI_ERROR_DEVICE_REMOVED = unchecked((int)0x887A0005);

        public const int DXGI_ERROR_DEVICE_HUNG = unchecked((int)0x887A0006);

        public const int DXGI_ERROR_DEVICE_RESET = unchecked((int)0x887A0007);

        public const int DXGI_ERROR_WAS_STILL_DRAWING = unchecked((int)0x887A000A);

        public const int DXGI_ERROR_FRAME_STATISTICS_DISJOINT = unchecked((int)0x887A000B);

        public const int DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)0x887A000C);

        public const int DXGI_ERROR_DRIVER_INTERNAL_ERROR = unchecked((int)0x887A0020);

        public const int DXGI_ERROR_NONEXCLUSIVE = unchecked((int)0x887A0021);

        public const int DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = unchecked((int)0x887A0022);

        public const int DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = unchecked((int)0x887A0023);

        public const int DXGI_ERROR_REMOTE_OUTOFMEMORY = unchecked((int)0x887A0024);

        public const int DXGI_ERROR_ACCESS_LOST = unchecked((int)0x887A0026);

        public const int DXGI_ERROR_WAIT_TIMEOUT = unchecked((int)0x887A0027);

        public const int DXGI_ERROR_SESSION_DISCONNECTED = unchecked((int)0x887A0028);

        public const int DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = unchecked((int)0x887A0029);

        public const int DXGI_ERROR_CANNOT_PROTECT_CONTENT = unchecked((int)0x887A002A);

        public const int DXGI_ERROR_ACCESS_DENIED = unchecked((int)0x887A002B);

        public const int DXGI_ERROR_NAME_ALREADY_EXISTS = unchecked((int)0x887A002C);

        public const int DXGI_ERROR_SDK_COMPONENT_MISSING = unchecked((int)0x887A002D);

        public const int DXGI_ERROR_NOT_CURRENT = unchecked((int)0x887A002E);

        public const int DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = unchecked((int)0x887A0030);

        public const int DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION = unchecked((int)0x887A0031);

        public const int DXGI_ERROR_NON_COMPOSITED_UI = unchecked((int)0x887A0032);

        public const int DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = unchecked((int)0x887A0025);

        public const int DXGI_ERROR_CACHE_CORRUPT = unchecked((int)0x887A0033);

        public const int DXGI_ERROR_CACHE_FULL = unchecked((int)0x887A0034);

        public const int DXGI_ERROR_CACHE_HASH_COLLISION = unchecked((int)0x887A0035);

        public const int DXGI_ERROR_ALREADY_EXISTS = unchecked((int)0x887A0036);

        public const int D3D12_ERROR_ADAPTER_NOT_FOUND = unchecked((int)0x887E0001);

        public const int D3D12_ERROR_DRIVER_VERSION_MISMATCH = unchecked((int)0x887E0002);

        public const int D2DERR_WRONG_STATE = unchecked((int)0x88990001);

        public const int D2DERR_NOT_INITIALIZED = unchecked((int)0x88990002);

        public const int D2DERR_UNSUPPORTED_OPERATION = unchecked((int)0x88990003);

        public const int D2DERR_SCANNER_FAILED = unchecked((int)0x88990004);

        public const int D2DERR_SCREEN_ACCESS_DENIED = unchecked((int)0x88990005);

        public const int D2DERR_DISPLAY_STATE_INVALID = unchecked((int)0x88990006);

        public const int D2DERR_ZERO_VECTOR = unchecked((int)0x88990007);

        public const int D2DERR_INTERNAL_ERROR = unchecked((int)0x88990008);

        public const int D2DERR_DISPLAY_FORMAT_NOT_SUPPORTED = unchecked((int)0x88990009);

        public const int D2DERR_INVALID_CALL = unchecked((int)0x8899000A);

        public const int D2DERR_NO_HARDWARE_DEVICE = unchecked((int)0x8899000B);

        public const int D2DERR_RECREATE_TARGET = unchecked((int)0x8899000C);

        public const int D2DERR_TOO_MANY_SHADER_ELEMENTS = unchecked((int)0x8899000D);

        public const int D2DERR_SHADER_COMPILE_FAILED = unchecked((int)0x8899000E);

        public const int D2DERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)0x8899000F);

        public const int D2DERR_UNSUPPORTED_VERSION = unchecked((int)0x88990010);

        public const int D2DERR_BAD_NUMBER = unchecked((int)0x88990011);

        public const int D2DERR_WRONG_FACTORY = unchecked((int)0x88990012);

        public const int D2DERR_LAYER_ALREADY_IN_USE = unchecked((int)0x88990013);

        public const int D2DERR_POP_CALL_DID_NOT_MATCH_PUSH = unchecked((int)0x88990014);

        public const int D2DERR_WRONG_RESOURCE_DOMAIN = unchecked((int)0x88990015);

        public const int D2DERR_PUSH_POP_UNBALANCED = unchecked((int)0x88990016);

        public const int D2DERR_RENDER_TARGET_HAS_LAYER_OR_CLIPRECT = unchecked((int)0x88990017);

        public const int D2DERR_INCOMPATIBLE_BRUSH_TYPES = unchecked((int)0x88990018);

        public const int D2DERR_WIN32_ERROR = unchecked((int)0x88990019);

        public const int D2DERR_TARGET_NOT_GDI_COMPATIBLE = unchecked((int)0x8899001A);

        public const int D2DERR_TEXT_EFFECT_IS_WRONG_TYPE = unchecked((int)0x8899001B);

        public const int D2DERR_TEXT_RENDERER_NOT_RELEASED = unchecked((int)0x8899001C);

        public const int D2DERR_EXCEEDS_MAX_BITMAP_SIZE = unchecked((int)0x8899001D);

        public const int D2DERR_INVALID_GRAPH_CONFIGURATION = unchecked((int)0x8899001E);

        public const int D2DERR_INVALID_INTERNAL_GRAPH_CONFIGURATION = unchecked((int)0x8899001F);

        public const int D2DERR_CYCLIC_GRAPH = unchecked((int)0x88990020);

        public const int D2DERR_BITMAP_CANNOT_DRAW = unchecked((int)0x88990021);

        public const int D2DERR_OUTSTANDING_BITMAP_REFERENCES = unchecked((int)0x88990022);

        public const int D2DERR_ORIGINAL_TARGET_NOT_BOUND = unchecked((int)0x88990023);

        public const int D2DERR_INVALID_TARGET = unchecked((int)0x88990024);

        public const int D2DERR_BITMAP_BOUND_AS_TARGET = unchecked((int)0x88990025);

        public const int D2DERR_INSUFFICIENT_DEVICE_CAPABILITIES = unchecked((int)0x88990026);

        public const int D2DERR_INTERMEDIATE_TOO_LARGE = unchecked((int)0x88990027);

        public const int D2DERR_EFFECT_IS_NOT_REGISTERED = unchecked((int)0x88990028);

        public const int D2DERR_INVALID_PROPERTY = unchecked((int)0x88990029);

        public const int D2DERR_NO_SUBPROPERTIES = unchecked((int)0x8899002A);

        public const int D2DERR_PRINT_JOB_CLOSED = unchecked((int)0x8899002B);

        public const int D2DERR_PRINT_FORMAT_NOT_SUPPORTED = unchecked((int)0x8899002C);

        public const int D2DERR_TOO_MANY_TRANSFORM_INPUTS = unchecked((int)0x8899002D);

        public const int D2DERR_INVALID_GLYPH_IMAGE = unchecked((int)0x8899002E);

        public const int WINCODEC_ERR_WRONGSTATE = unchecked((int)0x88982F04);

        public const int WINCODEC_ERR_VALUEOUTOFRANGE = unchecked((int)0x88982F05);

        public const int WINCODEC_ERR_UNKNOWNIMAGEFORMAT = unchecked((int)0x88982F07);

        public const int WINCODEC_ERR_UNSUPPORTEDVERSION = unchecked((int)0x88982F0B);

        public const int WINCODEC_ERR_NOTINITIALIZED = unchecked((int)0x88982F0C);

        public const int WINCODEC_ERR_ALREADYLOCKED = unchecked((int)0x88982F0D);

        public const int WINCODEC_ERR_PROPERTYNOTFOUND = unchecked((int)0x88982F40);

        public const int WINCODEC_ERR_PROPERTYNOTSUPPORTED = unchecked((int)0x88982F41);

        public const int WINCODEC_ERR_PROPERTYSIZE = unchecked((int)0x88982F42);

        public const int WINCODEC_ERR_CODECPRESENT = unchecked((int)0x88982F43);

        public const int WINCODEC_ERR_CODECNOTHUMBNAIL = unchecked((int)0x88982F44);

        public const int WINCODEC_ERR_PALETTEUNAVAILABLE = unchecked((int)0x88982F45);

        public const int WINCODEC_ERR_CODECTOOMANYSCANLINES = unchecked((int)0x88982F46);

        public const int WINCODEC_ERR_INTERNALERROR = unchecked((int)0x88982F48);

        public const int WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS = unchecked((int)0x88982F49);

        public const int WINCODEC_ERR_COMPONENTNOTFOUND = unchecked((int)0x88982F50);

        public const int WINCODEC_ERR_IMAGESIZEOUTOFRANGE = unchecked((int)0x88982F51);

        public const int WINCODEC_ERR_TOOMUCHMETADATA = unchecked((int)0x88982F52);

        public const int WINCODEC_ERR_BADIMAGE = unchecked((int)0x88982F60);

        public const int WINCODEC_ERR_BADHEADER = unchecked((int)0x88982F61);

        public const int WINCODEC_ERR_FRAMEMISSING = unchecked((int)0x88982F62);

        public const int WINCODEC_ERR_BADMETADATAHEADER = unchecked((int)0x88982F63);

        public const int WINCODEC_ERR_BADSTREAMDATA = unchecked((int)0x88982F70);

        public const int WINCODEC_ERR_STREAMWRITE = unchecked((int)0x88982F71);

        public const int WINCODEC_ERR_STREAMREAD = unchecked((int)0x88982F72);

        public const int WINCODEC_ERR_STREAMNOTAVAILABLE = unchecked((int)0x88982F73);

        public const int WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT = unchecked((int)0x88982F80);

        public const int WINCODEC_ERR_UNSUPPORTEDOPERATION = unchecked((int)0x88982F81);

        public const int WINCODEC_ERR_INVALIDREGISTRATION = unchecked((int)0x88982F8A);

        public const int WINCODEC_ERR_COMPONENTINITIALIZEFAILURE = unchecked((int)0x88982F8B);

        public const int WINCODEC_ERR_INSUFFICIENTBUFFER = unchecked((int)0x88982F8C);

        public const int WINCODEC_ERR_DUPLICATEMETADATAPRESENT = unchecked((int)0x88982F8D);

        public const int WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE = unchecked((int)0x88982F8E);

        public const int WINCODEC_ERR_UNEXPECTEDSIZE = unchecked((int)0x88982F8F);

        public const int WINCODEC_ERR_INVALIDQUERYREQUEST = unchecked((int)0x88982F90);

        public const int WINCODEC_ERR_UNEXPECTEDMETADATATYPE = unchecked((int)0x88982F91);

        public const int WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT = unchecked((int)0x88982F92);

        public const int WINCODEC_ERR_INVALIDQUERYCHARACTER = unchecked((int)0x88982F93);

        public const int WINCODEC_ERR_WIN32ERROR = unchecked((int)0x88982F94);

        public const int WINCODEC_ERR_INVALIDPROGRESSIVELEVEL = unchecked((int)0x88982F95);

        public const int WINCODEC_ERR_INVALIDJPEGSCANINDEX = unchecked((int)0x88982F96);

        public static bool SUCCEEDED(int hr)
        {
            return hr >= 0;
        }

        public static bool FAILED(int hr)
        {
            return hr < 0;
        }

        public static bool IS_ERROR(int Status)
        {
            return ((uint)Status >> 31) == SEVERITY_ERROR;
        }

        public static int HRESULT_CODE(int hr)
        {
            return hr & 0xFFFF;
        }

        public static int SCODE_CODE(int sc)
        {
            return sc & 0xFFFF;
        }

        public static int HRESULT_FACILITY(int hr)
        {
            return (hr >> 16) & 0x1FFF;
        }

        public static int SCODE_FACILITY(int sc)
        {
            return (sc >> 16) & 0x1FFF;
        }

        public static int HRESULT_SEVERITY(int hr)
        {
            return (hr >> 31) & 0x1;
        }

        public static int SCODE_SEVERITY(int sc)
        {
            return (sc >> 31) & 0x1;
        }

        public static int MAKE_HRESULT(int sev, int fac, int code)
        {
            return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
        }

        public static int MAKE_SCODE(int sev, int fac, int code)
        {
            return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
        }

        public static int __HRESULT_FROM_WIN32(int x)
        {
            return (x <= 0) ? x : ((x & 0x0000FFFF) | (FACILITY_WIN32 << 16) | unchecked((int)0x80000000));
        }

        public static int HRESULT_FROM_WIN32(int x)
        {
            return __HRESULT_FROM_WIN32(x);
        }
    }
}
