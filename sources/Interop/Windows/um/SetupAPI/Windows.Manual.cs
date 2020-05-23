// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int LINE_LEN = 256;

        public const int MAX_INF_STRING_LENGTH = 4096;

        public const int MAX_INF_SECTION_NAME_LENGTH = 255;

        public const int MAX_TITLE_LEN = 60;

        public const int MAX_INSTRUCTION_LEN = 256;

        public const int MAX_LABEL_LEN = 30;

        public const int MAX_SERVICE_NAME_LEN = 256;

        public const int MAX_SUBTITLE_LEN = 256;

        public const uint INF_STYLE_NONE = 0x00000000;

        public const uint INF_STYLE_OLDNT = 0x00000001;

        public const uint INF_STYLE_WIN4 = 0x00000002;

        public const uint INF_STYLE_CACHE_ENABLE = 0x00000010;

        public const uint INF_STYLE_CACHE_DISABLE = 0x00000020;

        public const uint INF_STYLE_CACHE_IGNORE = 0x00000040;

        public const int DIRID_ABSOLUTE = -1;

        public const int DIRID_ABSOLUTE_16BIT = 0xFFFF;

        public const int DIRID_NULL = 0;

        public const int DIRID_SRCPATH = 1;

        public const int DIRID_WINDOWS = 10;

        public const int DIRID_SYSTEM = 11;

        public const int DIRID_DRIVERS = 12;

        public const int DIRID_DRIVER_STORE = 13;

        public const int DIRID_INF = 17;

        public const int DIRID_HELP = 18;

        public const int DIRID_FONTS = 20;

        public const int DIRID_VIEWERS = 21;

        public const int DIRID_COLOR = 23;

        public const int DIRID_APPS = 24;

        public const int DIRID_SHARED = 25;

        public const int DIRID_BOOT = 30;

        public const int DIRID_SYSTEM16 = 50;

        public const int DIRID_SPOOL = 51;

        public const int DIRID_SPOOLDRIVERS = 52;

        public const int DIRID_USERPROFILE = 53;

        public const int DIRID_LOADER = 54;

        public const int DIRID_PRINTPROCESSOR = 55;

        public const int DIRID_COMMON_STARTMENU = 16406;

        public const int DIRID_COMMON_PROGRAMS = 16407;

        public const int DIRID_COMMON_STARTUP = 16408;

        public const int DIRID_COMMON_DESKTOPDIRECTORY = 16409;

        public const int DIRID_COMMON_FAVORITES = 16415;

        public const int DIRID_COMMON_APPDATA = 16419;

        public const int DIRID_PROGRAM_FILES = 16422;

        public const int DIRID_SYSTEM_X86 = 16425;

        public const int DIRID_PROGRAM_FILES_X86 = 16426;

        public const int DIRID_PROGRAM_FILES_COMMON = 16427;

        public const int DIRID_PROGRAM_FILES_COMMONX86 = 16428;

        public const int DIRID_COMMON_TEMPLATES = 16429;

        public const int DIRID_COMMON_DOCUMENTS = 16430;

        public const int DIRID_USER = 0x8000;

        public const uint SPFILENOTIFY_STARTQUEUE = 0x00000001;

        public const uint SPFILENOTIFY_ENDQUEUE = 0x00000002;

        public const uint SPFILENOTIFY_STARTSUBQUEUE = 0x00000003;

        public const uint SPFILENOTIFY_ENDSUBQUEUE = 0x00000004;

        public const uint SPFILENOTIFY_STARTDELETE = 0x00000005;

        public const uint SPFILENOTIFY_ENDDELETE = 0x00000006;

        public const uint SPFILENOTIFY_DELETEERROR = 0x00000007;

        public const uint SPFILENOTIFY_STARTRENAME = 0x00000008;

        public const uint SPFILENOTIFY_ENDRENAME = 0x00000009;

        public const uint SPFILENOTIFY_RENAMEERROR = 0x0000000A;

        public const uint SPFILENOTIFY_STARTCOPY = 0x0000000B;

        public const uint SPFILENOTIFY_ENDCOPY = 0x0000000C;

        public const uint SPFILENOTIFY_COPYERROR = 0x0000000D;

        public const uint SPFILENOTIFY_NEEDMEDIA = 0x0000000E;

        public const uint SPFILENOTIFY_QUEUESCAN = 0x0000000F;

        public const uint SPFILENOTIFY_CABINETINFO = 0x00000010;

        public const uint SPFILENOTIFY_FILEINCABINET = 0x00000011;

        public const uint SPFILENOTIFY_NEEDNEWCABINET = 0x00000012;

        public const uint SPFILENOTIFY_FILEEXTRACTED = 0x00000013;

        public const uint SPFILENOTIFY_FILEOPDELAYED = 0x00000014;

        public const uint SPFILENOTIFY_STARTBACKUP = 0x00000015;

        public const uint SPFILENOTIFY_BACKUPERROR = 0x00000016;

        public const uint SPFILENOTIFY_ENDBACKUP = 0x00000017;

        public const uint SPFILENOTIFY_QUEUESCAN_EX = 0x00000018;

        public const uint SPFILENOTIFY_STARTREGISTRATION = 0x00000019;

        public const uint SPFILENOTIFY_ENDREGISTRATION = 0x00000020;

        public const uint SPFILENOTIFY_QUEUESCAN_SIGNERINFO = 0x00000040;

        public const uint SPFILENOTIFY_LANGMISMATCH = 0x00010000;

        public const uint SPFILENOTIFY_TARGETEXISTS = 0x00020000;

        public const uint SPFILENOTIFY_TARGETNEWER = 0x00040000;

        public const int FILEOP_COPY = 0;

        public const int FILEOP_RENAME = 1;

        public const int FILEOP_DELETE = 2;

        public const int FILEOP_BACKUP = 3;

        public const int FILEOP_ABORT = 0;

        public const int FILEOP_DOIT = 1;

        public const int FILEOP_SKIP = 2;

        public const int FILEOP_NEWPATH = 4;

        public const uint COPYFLG_WARN_IF_SKIP = 0x00000001;

        public const uint COPYFLG_NOSKIP = 0x00000002;

        public const uint COPYFLG_NOVERSIONCHECK = 0x00000004;

        public const uint COPYFLG_FORCE_FILE_IN_USE = 0x00000008;

        public const uint COPYFLG_NO_OVERWRITE = 0x00000010;

        public const uint COPYFLG_NO_VERSION_DIALOG = 0x00000020;

        public const uint COPYFLG_OVERWRITE_OLDER_ONLY = 0x00000040;

        public const uint COPYFLG_PROTECTED_WINDOWS_DRIVER_FILE = 0x00000100;

        public const uint COPYFLG_REPLACEONLY = 0x00000400;

        public const uint COPYFLG_NODECOMP = 0x00000800;

        public const uint COPYFLG_REPLACE_BOOT_FILE = 0x00001000;

        public const uint COPYFLG_NOPRUNE = 0x00002000;

        public const uint COPYFLG_IN_USE_TRY_RENAME = 0x00004000;

        public const uint DELFLG_IN_USE = 0x00000001;

        public const uint DELFLG_IN_USE1 = 0x00010000;

        public const uint SPREG_SUCCESS = 0x00000000;

        public const uint SPREG_LOADLIBRARY = 0x00000001;

        public const uint SPREG_GETPROCADDR = 0x00000002;

        public const uint SPREG_REGSVR = 0x00000003;

        public const uint SPREG_DLLINSTALL = 0x00000004;

        public const uint SPREG_TIMEOUT = 0x00000005;

        public const uint SPREG_UNKNOWN = 0xFFFFFFFF;

        public const uint SPINT_ACTIVE = 0x00000001;

        public const uint SPINT_DEFAULT = 0x00000002;

        public const uint SPINT_REMOVED = 0x00000004;

        public const uint DIF_SELECTDEVICE = 0x00000001;

        public const uint DIF_INSTALLDEVICE = 0x00000002;

        public const uint DIF_ASSIGNRESOURCES = 0x00000003;

        public const uint DIF_PROPERTIES = 0x00000004;

        public const uint DIF_REMOVE = 0x00000005;

        public const uint DIF_FIRSTTIMESETUP = 0x00000006;

        public const uint DIF_FOUNDDEVICE = 0x00000007;

        public const uint DIF_SELECTCLASSDRIVERS = 0x00000008;

        public const uint DIF_VALIDATECLASSDRIVERS = 0x00000009;

        public const uint DIF_INSTALLCLASSDRIVERS = 0x0000000A;

        public const uint DIF_CALCDISKSPACE = 0x0000000B;

        public const uint DIF_DESTROYPRIVATEDATA = 0x0000000C;

        public const uint DIF_VALIDATEDRIVER = 0x0000000D;

        public const uint DIF_DETECT = 0x0000000F;

        public const uint DIF_INSTALLWIZARD = 0x00000010;

        public const uint DIF_DESTROYWIZARDDATA = 0x00000011;

        public const uint DIF_PROPERTYCHANGE = 0x00000012;

        public const uint DIF_ENABLECLASS = 0x00000013;

        public const uint DIF_DETECTVERIFY = 0x00000014;

        public const uint DIF_INSTALLDEVICEFILES = 0x00000015;

        public const uint DIF_UNREMOVE = 0x00000016;

        public const uint DIF_SELECTBESTCOMPATDRV = 0x00000017;

        public const uint DIF_ALLOW_INSTALL = 0x00000018;

        public const uint DIF_REGISTERDEVICE = 0x00000019;

        public const uint DIF_NEWDEVICEWIZARD_PRESELECT = 0x0000001A;

        public const uint DIF_NEWDEVICEWIZARD_SELECT = 0x0000001B;

        public const uint DIF_NEWDEVICEWIZARD_PREANALYZE = 0x0000001C;

        public const uint DIF_NEWDEVICEWIZARD_POSTANALYZE = 0x0000001D;

        public const uint DIF_NEWDEVICEWIZARD_FINISHINSTALL = 0x0000001E;

        public const uint DIF_UNUSED1 = 0x0000001F;

        public const uint DIF_INSTALLINTERFACES = 0x00000020;

        public const uint DIF_DETECTCANCEL = 0x00000021;

        public const uint DIF_REGISTER_COINSTALLERS = 0x00000022;

        public const uint DIF_ADDPROPERTYPAGE_ADVANCED = 0x00000023;

        public const uint DIF_ADDPROPERTYPAGE_BASIC = 0x00000024;

        public const uint DIF_RESERVED1 = 0x00000025;

        public const uint DIF_TROUBLESHOOTER = 0x00000026;

        public const uint DIF_POWERMESSAGEWAKE = 0x00000027;

        public const uint DIF_ADDREMOTEPROPERTYPAGE_ADVANCED = 0x00000028;

        public const uint DIF_UPDATEDRIVER_UI = 0x00000029;

        public const uint DIF_FINISHINSTALL_ACTION = 0x0000002A;

        public const uint DIF_RESERVED2 = 0x00000030;

        public const uint DIF_MOVEDEVICE = 0x0000000E;

        public const uint DI_SHOWOEM = 0x00000001;

        public const uint DI_SHOWCOMPAT = 0x00000002;

        public const uint DI_SHOWCLASS = 0x00000004;

        public const uint DI_SHOWALL = 0x00000007;

        public const uint DI_NOVCP = 0x00000008;

        public const uint DI_DIDCOMPAT = 0x00000010;

        public const uint DI_DIDCLASS = 0x00000020;

        public const uint DI_AUTOASSIGNRES = 0x00000040;

        public const uint DI_NEEDRESTART = 0x00000080;

        public const uint DI_NEEDREBOOT = 0x00000100;

        public const uint DI_NOBROWSE = 0x00000200;

        public const uint DI_MULTMFGS = 0x00000400;

        public const uint DI_DISABLED = 0x00000800;

        public const uint DI_GENERALPAGE_ADDED = 0x00001000;

        public const uint DI_RESOURCEPAGE_ADDED = 0x00002000;

        public const uint DI_PROPERTIES_CHANGE = 0x00004000;

        public const uint DI_INF_IS_SORTED = 0x00008000;

        public const uint DI_ENUMSINGLEINF = 0x00010000;

        public const uint DI_DONOTCALLCONFIGMG = 0x00020000;

        public const uint DI_INSTALLDISABLED = 0x00040000;

        public const uint DI_COMPAT_FROM_CLASS = 0x00080000;

        public const uint DI_CLASSINSTALLPARAMS = 0x00100000;

        public const uint DI_NODI_DEFAULTACTION = 0x00200000;

        public const uint DI_QUIETINSTALL = 0x00800000;

        public const uint DI_NOFILECOPY = 0x01000000;

        public const uint DI_FORCECOPY = 0x02000000;

        public const uint DI_DRIVERPAGE_ADDED = 0x04000000;

        public const uint DI_USECI_SELECTSTRINGS = 0x08000000;

        public const uint DI_OVERRIDE_INFFLAGS = 0x10000000;

        public const uint DI_PROPS_NOCHANGEUSAGE = 0x20000000;

        public const uint DI_NOSELECTICONS = 0x40000000;

        public const uint DI_NOWRITE_IDS = 0x80000000;

        public const uint DI_FLAGSEX_RESERVED2 = 0x00000001;

        public const uint DI_FLAGSEX_RESERVED3 = 0x00000002;

        public const uint DI_FLAGSEX_CI_FAILED = 0x00000004;

        public const uint DI_FLAGSEX_FINISHINSTALL_ACTION = 0x00000008;

        public const uint DI_FLAGSEX_DIDINFOLIST = 0x00000010;

        public const uint DI_FLAGSEX_DIDCOMPATINFO = 0x00000020;

        public const uint DI_FLAGSEX_FILTERCLASSES = 0x00000040;

        public const uint DI_FLAGSEX_SETFAILEDINSTALL = 0x00000080;

        public const uint DI_FLAGSEX_DEVICECHANGE = 0x00000100;

        public const uint DI_FLAGSEX_ALWAYSWRITEIDS = 0x00000200;

        public const uint DI_FLAGSEX_PROPCHANGE_PENDING = 0x00000400;

        public const uint DI_FLAGSEX_ALLOWEXCLUDEDDRVS = 0x00000800;

        public const uint DI_FLAGSEX_NOUIONQUERYREMOVE = 0x00001000;

        public const uint DI_FLAGSEX_USECLASSFORCOMPAT = 0x00002000;

        public const uint DI_FLAGSEX_RESERVED4 = 0x00004000;

        public const uint DI_FLAGSEX_NO_DRVREG_MODIFY = 0x00008000;

        public const uint DI_FLAGSEX_IN_SYSTEM_SETUP = 0x00010000;

        public const uint DI_FLAGSEX_INET_DRIVER = 0x00020000;

        public const uint DI_FLAGSEX_APPENDDRIVERLIST = 0x00040000;

        public const uint DI_FLAGSEX_PREINSTALLBACKUP = 0x00080000;

        public const uint DI_FLAGSEX_BACKUPONREPLACE = 0x00100000;

        public const uint DI_FLAGSEX_DRIVERLIST_FROM_URL = 0x00200000;

        public const uint DI_FLAGSEX_RESERVED1 = 0x00400000;

        public const uint DI_FLAGSEX_EXCLUDE_OLD_INET_DRIVERS = 0x00800000;

        public const uint DI_FLAGSEX_POWERPAGE_ADDED = 0x01000000;

        public const uint DI_FLAGSEX_FILTERSIMILARDRIVERS = 0x02000000;

        public const uint DI_FLAGSEX_INSTALLEDDRIVER = 0x04000000;

        public const uint DI_FLAGSEX_NO_CLASSLIST_NODE_MERGE = 0x08000000;

        public const uint DI_FLAGSEX_ALTPLATFORM_DRVSEARCH = 0x10000000;

        public const uint DI_FLAGSEX_RESTART_DEVICE_ONLY = 0x20000000;

        public const uint DI_FLAGSEX_RECURSIVESEARCH = 0x40000000;

        public const uint DI_FLAGSEX_SEARCH_PUBLISHED_INFS = 0x80000000;

        public const int ENABLECLASS_QUERY = 0;

        public const int ENABLECLASS_SUCCESS = 1;

        public const int ENABLECLASS_FAILURE = 2;

        public const uint DICS_ENABLE = 0x00000001;

        public const uint DICS_DISABLE = 0x00000002;

        public const uint DICS_PROPCHANGE = 0x00000003;

        public const uint DICS_START = 0x00000004;

        public const uint DICS_STOP = 0x00000005;

        public const uint DICS_FLAG_GLOBAL = 0x00000001;

        public const uint DICS_FLAG_CONFIGSPECIFIC = 0x00000002;

        public const uint DICS_FLAG_CONFIGGENERAL = 0x00000004;

        public const uint DI_REMOVEDEVICE_GLOBAL = 0x00000001;

        public const uint DI_REMOVEDEVICE_CONFIGSPECIFIC = 0x00000002;

        public const uint DI_UNREMOVEDEVICE_CONFIGSPECIFIC = 0x00000002;

        public const uint MAX_INSTALLWIZARD_DYNAPAGES = 20;

        public const uint NDW_INSTALLFLAG_DIDFACTDEFS = 0x00000001;

        public const uint NDW_INSTALLFLAG_HARDWAREALLREADYIN = 0x00000002;

        public const uint NDW_INSTALLFLAG_NEEDSHUTDOWN = 0x00000200;

        public const uint NDW_INSTALLFLAG_EXPRESSINTRO = 0x00000400;

        public const uint NDW_INSTALLFLAG_SKIPISDEVINSTALLED = 0x00000800;

        public const uint NDW_INSTALLFLAG_NODETECTEDDEVS = 0x00001000;

        public const uint NDW_INSTALLFLAG_INSTALLSPECIFIC = 0x00002000;

        public const uint NDW_INSTALLFLAG_SKIPCLASSLIST = 0x00004000;

        public const uint NDW_INSTALLFLAG_CI_PICKED_OEM = 0x00008000;

        public const uint NDW_INSTALLFLAG_PCMCIAMODE = 0x00010000;

        public const uint NDW_INSTALLFLAG_PCMCIADEVICE = 0x00020000;

        public const uint NDW_INSTALLFLAG_USERCANCEL = 0x00040000;

        public const uint NDW_INSTALLFLAG_KNOWNCLASS = 0x00080000;

        public const uint DYNAWIZ_FLAG_PAGESADDED = 0x00000001;

        public const uint DYNAWIZ_FLAG_ANALYZE_HANDLECONFLICT = 0x00000008;

        public const uint DYNAWIZ_FLAG_INSTALLDET_NEXT = 0x00000002;

        public const uint DYNAWIZ_FLAG_INSTALLDET_PREV = 0x00000004;

        public const int MIN_IDD_DYNAWIZ_RESOURCE_ID = 10000;

        public const int MAX_IDD_DYNAWIZ_RESOURCE_ID = 11000;

        public const int IDD_DYNAWIZ_FIRSTPAGE = 10000;

        public const int IDD_DYNAWIZ_SELECT_PREVPAGE = 10001;

        public const int IDD_DYNAWIZ_SELECT_NEXTPAGE = 10002;

        public const int IDD_DYNAWIZ_ANALYZE_PREVPAGE = 10003;

        public const int IDD_DYNAWIZ_ANALYZE_NEXTPAGE = 10004;

        public const int IDD_DYNAWIZ_SELECTDEV_PAGE = 10009;

        public const int IDD_DYNAWIZ_ANALYZEDEV_PAGE = 10010;

        public const int IDD_DYNAWIZ_INSTALLDETECTEDDEVS_PAGE = 10011;

        public const int IDD_DYNAWIZ_SELECTCLASS_PAGE = 10012;

        public const int IDD_DYNAWIZ_INSTALLDETECTED_PREVPAGE = 10006;

        public const int IDD_DYNAWIZ_INSTALLDETECTED_NEXTPAGE = 10007;

        public const int IDD_DYNAWIZ_INSTALLDETECTED_NODEVS = 10008;

        public const uint DNF_DUPDESC = 0x00000001;

        public const uint DNF_OLDDRIVER = 0x00000002;

        public const uint DNF_EXCLUDEFROMLIST = 0x00000004;

        public const uint DNF_NODRIVER = 0x00000008;

        public const uint DNF_LEGACYINF = 0x00000010;

        public const uint DNF_CLASS_DRIVER = 0x00000020;

        public const uint DNF_COMPATIBLE_DRIVER = 0x00000040;

        public const uint DNF_INET_DRIVER = 0x00000080;

        public const uint DNF_UNUSED1 = 0x00000100;

        public const uint DNF_UNUSED2 = 0x00000200;

        public const uint DNF_OLD_INET_DRIVER = 0x00000400;

        public const uint DNF_BAD_DRIVER = 0x00000800;

        public const uint DNF_DUPPROVIDER = 0x00001000;

        public const uint DNF_INF_IS_SIGNED = 0x00002000;

        public const uint DNF_OEM_F6_INF = 0x00004000;

        public const uint DNF_DUPDRIVERVER = 0x00008000;

        public const uint DNF_BASIC_DRIVER = 0x00010000;

        public const uint DNF_AUTHENTICODE_SIGNED = 0x00020000;

        public const uint DNF_INSTALLEDDRIVER = 0x00040000;

        public const uint DNF_ALWAYSEXCLUDEFROMLIST = 0x00080000;

        public const uint DNF_INBOX_DRIVER = 0x00100000;

        public const uint DNF_REQUESTADDITIONALSOFTWARE = 0x00200000;

        public const uint DNF_UNUSED_22 = 0x00400000;

        public const uint DNF_UNUSED_23 = 0x00800000;

        public const uint DNF_UNUSED_24 = 0x01000000;

        public const uint DNF_UNUSED_25 = 0x02000000;

        public const uint DNF_UNUSED_26 = 0x04000000;

        public const uint DNF_UNUSED_27 = 0x08000000;

        public const uint DNF_UNUSED_28 = 0x10000000;

        public const uint DNF_UNUSED_29 = 0x20000000;

        public const uint DNF_UNUSED_30 = 0x40000000;

        public const uint DNF_UNUSED_31 = 0x80000000;

        public const uint DRIVER_HARDWAREID_RANK = 0x00000FFF;

        public const uint DRIVER_HARDWAREID_MASK = 0x80000FFF;

        public const uint DRIVER_UNTRUSTED_RANK = 0x80000000;

        public const int SPPSR_SELECT_DEVICE_RESOURCES = 1;

        public const int SPPSR_ENUM_BASIC_DEVICE_PROPERTIES = 2;

        public const int SPPSR_ENUM_ADV_DEVICE_PROPERTIES = 3;

        public const int INFINFO_INF_SPEC_IS_HINF = 1;

        public const int INFINFO_INF_NAME_IS_ABSOLUTE = 2;

        public const int INFINFO_DEFAULT_SEARCH = 3;

        public const int INFINFO_REVERSE_DEFAULT_SEARCH = 4;

        public const int INFINFO_INF_PATH_LIST_SEARCH = 5;

        public const int FILE_COMPRESSION_NONE = 0;

        public const int FILE_COMPRESSION_WINLZA = 1;

        public const int FILE_COMPRESSION_MSZIP = 2;

        public const int FILE_COMPRESSION_NTCAB = 3;

        public const uint SRCLIST_TEMPORARY = 0x00000001;

        public const uint SRCLIST_NOBROWSE = 0x00000002;

        public const uint SRCLIST_SYSTEM = 0x00000010;

        public const uint SRCLIST_USER = 0x00000020;

        public const uint SRCLIST_SYSIFADMIN = 0x00000040;

        public const uint SRCLIST_SUBDIRS = 0x00000100;

        public const uint SRCLIST_APPEND = 0x00000200;

        public const uint SRCLIST_NOSTRIPPLATFORM = 0x00000400;

        public const uint IDF_NOBROWSE = 0x00000001;

        public const uint IDF_NOSKIP = 0x00000002;

        public const uint IDF_NODETAILS = 0x00000004;

        public const uint IDF_NOCOMPRESSED = 0x00000008;

        public const uint IDF_CHECKFIRST = 0x00000100;

        public const uint IDF_NOBEEP = 0x00000200;

        public const uint IDF_NOFOREGROUND = 0x00000400;

        public const uint IDF_WARNIFSKIP = 0x00000800;

        public const uint IDF_NOREMOVABLEMEDIAPROMPT = 0x00001000;

        public const uint IDF_USEDISKNAMEASPROMPT = 0x00002000;

        public const uint IDF_OEMDISK = 0x80000000;

        public const int DPROMPT_SUCCESS = 0;

        public const int DPROMPT_CANCEL = 1;

        public const int DPROMPT_SKIPFILE = 2;

        public const int DPROMPT_BUFFERTOOSMALL = 3;

        public const int DPROMPT_OUTOFMEMORY = 4;

        public const uint SETDIRID_NOT_FULL_PATH = 0x00000001;

        public const int SRCINFO_PATH = 1;

        public const int SRCINFO_TAGFILE = 2;

        public const int SRCINFO_DESCRIPTION = 3;

        public const int SRCINFO_FLAGS = 4;

        public const int SRCINFO_TAGFILE2 = 5;

        public const uint SP_COPY_DELETESOURCE = 0x0000001;

        public const uint SP_COPY_REPLACEONLY = 0x0000002;

        public const uint SP_COPY_NEWER = 0x0000004;

        public const uint SP_COPY_NOOVERWRITE = 0x0000008;

        public const uint SP_COPY_NODECOMP = 0x0000010;

        public const uint SP_COPY_LANGUAGEAWARE = 0x0000020;

        public const uint SP_COPY_SOURCE_ABSOLUTE = 0x0000040;

        public const uint SP_COPY_SOURCEPATH_ABSOLUTE = 0x0000080;

        public const uint SP_COPY_IN_USE_NEEDS_REBOOT = 0x0000100;

        public const uint SP_COPY_FORCE_IN_USE = 0x0000200;

        public const uint SP_COPY_NOSKIP = 0x0000400;

        public const uint SP_FLAG_CABINETCONTINUATION = 0x0000800;

        public const uint SP_COPY_FORCE_NOOVERWRITE = 0x0001000;

        public const uint SP_COPY_FORCE_NEWER = 0x0002000;

        public const uint SP_COPY_WARNIFSKIP = 0x0004000;

        public const uint SP_COPY_NOBROWSE = 0x0008000;

        public const uint SP_COPY_NEWER_ONLY = 0x0010000;

        public const uint SP_COPY_RESERVED = 0x0020000;

        public const uint SP_COPY_OEMINF_CATALOG_ONLY = 0x0040000;

        public const uint SP_COPY_REPLACE_BOOT_FILE = 0x0080000;

        public const uint SP_COPY_NOPRUNE = 0x0100000;

        public const uint SP_COPY_OEM_F6_INF = 0x0200000;

        public const uint SP_COPY_ALREADYDECOMP = 0x0400000;

        public const uint SP_COPY_WINDOWS_SIGNED = 0x1000000;

        public const uint SP_COPY_PNPLOCKED = 0x2000000;

        public const uint SP_COPY_IN_USE_TRY_RENAME = 0x4000000;

        public const uint SP_COPY_INBOX_INF = 0x8000000;

        public const uint SP_COPY_HARDLINK = 0x10000000;

        public const uint SP_BACKUP_BACKUPPASS = 0x00000001;

        public const uint SP_BACKUP_DEMANDPASS = 0x00000002;

        public const uint SP_BACKUP_SPECIAL = 0x00000004;

        public const uint SP_BACKUP_BOOTFILE = 0x00000008;

        public const uint SPQ_SCAN_FILE_PRESENCE = 0x00000001;

        public const uint SPQ_SCAN_FILE_VALIDITY = 0x00000002;

        public const uint SPQ_SCAN_USE_CALLBACK = 0x00000004;

        public const uint SPQ_SCAN_USE_CALLBACKEX = 0x00000008;

        public const uint SPQ_SCAN_INFORM_USER = 0x00000010;

        public const uint SPQ_SCAN_PRUNE_COPY_QUEUE = 0x00000020;

        public const uint SPQ_SCAN_USE_CALLBACK_SIGNERINFO = 0x00000040;

        public const uint SPQ_SCAN_PRUNE_DELREN = 0x00000080;

        public const uint SPQ_SCAN_FILE_PRESENCE_WITHOUT_SOURCE = 0x00000100;

        public const uint SPQ_SCAN_FILE_COMPARISON = 0x00000200;

        public const uint SPQ_SCAN_ACTIVATE_DRP = 0x00000400;

        public const uint SPQ_DELAYED_COPY = 0x00000001;

        public const uint SPQ_FLAG_BACKUP_AWARE = 0x00000001;

        public const uint SPQ_FLAG_ABORT_IF_UNSIGNED = 0x00000002;

        public const uint SPQ_FLAG_FILES_MODIFIED = 0x00000004;

        public const uint SPQ_FLAG_DO_SHUFFLEMOVE = 0x00000008;

        public const uint SPQ_FLAG_VALID = 0x0000000F;

        public const int SPOST_NONE = 0;

        public const int SPOST_PATH = 1;

        public const int SPOST_URL = 2;

        public const int SPOST_MAX = 3;

        public const int SUOI_FORCEDELETE = 0x00000001;

        public const int SUOI_INTERNAL1 = 0x00000002;

        public const int SPDSL_IGNORE_DISK = 0x00000001;

        public const int SPDSL_DISALLOW_NEGATIVE_ADJUST = 0x00000002;

        public const int SPFILEQ_FILE_IN_USE = 0x00000001;

        public const int SPFILEQ_REBOOT_RECOMMENDED = 0x00000002;

        public const int SPFILEQ_REBOOT_IN_PROGRESS = 0x00000004;

        public const int SPINST_LOGCONFIG = 0x00000001;

        public const int SPINST_INIFILES = 0x00000002;

        public const int SPINST_REGISTRY = 0x00000004;

        public const int SPINST_INI2REG = 0x00000008;

        public const int SPINST_FILES = 0x00000010;

        public const int SPINST_BITREG = 0x00000020;

        public const int SPINST_REGSVR = 0x00000040;

        public const int SPINST_UNREGSVR = 0x00000080;

        public const int SPINST_PROFILEITEMS = 0x00000100;

        public const int SPINST_COPYINF = 0x00000200;

        public const int SPINST_PROPERTIES = 0x00000400;

        public const int SPINST_ALL = 0x000007FF;

        public const int SPINST_SINGLESECTION = 0x00010000;

        public const int SPINST_LOGCONFIG_IS_FORCED = 0x00020000;

        public const int SPINST_LOGCONFIGS_ARE_OVERRIDES = 0x00040000;

        public const int SPINST_REGISTERCALLBACKAWARE = 0x00080000;

        public const int SPINST_DEVICEINSTALL = 0x00100000;

        public const int SPFILELOG_SYSTEMLOG = 0x00000001;

        public const int SPFILELOG_FORCENEW = 0x00000002;

        public const int SPFILELOG_QUERYONLY = 0x00000004;

        public const int SPFILELOG_OEMFILE = 0x00000001;

        public const int LogSevInformation = 0x00000000;

        public const int LogSevWarning = 0x00000001;

        public const int LogSevError = 0x00000002;

        public const int LogSevFatalError = 0x00000003;

        public const int LogSevMaximum = 0x00000004;

        public const int DICD_GENERATE_ID = 0x00000001;

        public const int DICD_INHERIT_CLASSDRVS = 0x00000002;

        public const int DIOD_INHERIT_CLASSDRVS = 0x00000002;

        public const int DIOD_CANCEL_REMOVE = 0x00000004;

        public const int DIODI_NO_ADD = 0x00000001;

        public const int SPRDI_FIND_DUPS = 0x00000001;

        public const int SPDIT_NODRIVER = 0x00000000;

        public const int SPDIT_CLASSDRIVER = 0x00000001;

        public const int SPDIT_COMPATDRIVER = 0x00000002;

        public const int DIGCF_DEFAULT = 0x00000001;

        public const int DIGCF_PRESENT = 0x00000002;

        public const int DIGCF_ALLCLASSES = 0x00000004;

        public const int DIGCF_PROFILE = 0x00000008;

        public const int DIGCF_DEVICEINTERFACE = 0x00000010;

        public const int DIBCI_NOINSTALLCLASS = 0x00000001;

        public const int DIBCI_NODISPLAYCLASS = 0x00000002;

        public const int DIOCR_INSTALLER = 0x00000001;

        public const int DIOCR_INTERFACE = 0x00000002;

        public const int DIREG_DEV = 0x00000001;

        public const int DIREG_DRV = 0x00000002;

        public const int DIREG_BOTH = 0x00000004;

        public const int DICLASSPROP_INSTALLER = 0x00000001;

        public const int DICLASSPROP_INTERFACE = 0x00000002;

        public const int DMI_MASK = 0x00000001;

        public const int DMI_BKCOLOR = 0x00000002;

        public const int DMI_USERECT = 0x00000004;

        public const uint DIGCDP_FLAG_BASIC = 0x00000001;

        public const uint DIGCDP_FLAG_ADVANCED = 0x00000002;

        public const uint DIGCDP_FLAG_REMOTE_BASIC = 0x00000003;

        public const uint DIGCDP_FLAG_REMOTE_ADVANCED = 0x00000004;

        public const int IDI_RESOURCEFIRST = 159;

        public const int IDI_RESOURCE = 159;

        public const int IDI_RESOURCELAST = 161;

        public const int IDI_RESOURCEOVERLAYFIRST = 161;

        public const int IDI_RESOURCEOVERLAYLAST = 161;

        public const int IDI_CONFLICT = 161;

        public const int IDI_CLASSICON_OVERLAYFIRST = 500;

        public const int IDI_CLASSICON_OVERLAYLAST = 502;

        public const int IDI_PROBLEM_OVL = 500;

        public const int IDI_DISABLED_OVL = 501;

        public const int IDI_FORCED_OVL = 502;

        public const int SPWPT_SELECTDEVICE = 0x00000001;

        public const int SPWP_USE_DEVINFO_DATA = 0x00000001;

        public const uint SIGNERSCORE_UNKNOWN = 0xFF000000;

        public const uint SIGNERSCORE_W9X_SUSPECT = 0xC0000000;

        public const uint SIGNERSCORE_UNSIGNED = 0x80000000;

        public const uint SIGNERSCORE_AUTHENTICODE = 0x0F000000;

        public const uint SIGNERSCORE_WHQL = 0x0D000005;

        public const uint SIGNERSCORE_UNCLASSIFIED = 0x0D000004;

        public const uint SIGNERSCORE_INBOX = 0x0D000003;

        public const uint SIGNERSCORE_LOGO_STANDARD = 0x0D000002;

        public const uint SIGNERSCORE_LOGO_PREMIUM = 0x0D000001;

        public const uint SIGNERSCORE_MASK = 0xFF000000;

        public const uint SIGNERSCORE_SIGNED_MASK = 0xF0000000;

        public const int DICUSTOMDEVPROP_MERGE_MULTISZ = 0x00000001;

        public const int SCWMI_CLOBBER_SECURITY = 0x00000001;

        public const int SP_MAX_MACHINENAME_LENGTH = MAX_PATH + 3;

        public const int SP_ALTPLATFORM_FLAGS_VERSION_RANGE = 0x0001;

        public const int SP_ALTPLATFORM_FLAGS_SUITE_MASK = 0x0002;

        public const int DIRID_IOSUBSYS = DIRID_DRIVERS;

        public const int DIRID_DEFAULT = DIRID_SYSTEM;

        public const int FILEOP_RETRY = FILEOP_DOIT;

        public const uint SPID_ACTIVE = SPINT_ACTIVE;

        public const uint SPID_DEFAULT = SPINT_DEFAULT;

        public const uint SPID_REMOVED = SPINT_REMOVED;

        public const uint NDW_INSTALLFLAG_NEEDRESTART = DI_NEEDRESTART;

        public const uint NDW_INSTALLFLAG_NEEDREBOOT = DI_NEEDREBOOT;

        public const uint ERROR_EXPECTED_SECTION_NAME = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0;

        public const uint ERROR_BAD_SECTION_NAME_LINE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 1;

        public const uint ERROR_SECTION_NAME_TOO_LONG = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 2;

        public const uint ERROR_GENERAL_SYNTAX = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 3;

        public const uint ERROR_WRONG_INF_STYLE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x100;

        public const uint ERROR_SECTION_NOT_FOUND = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x101;

        public const uint ERROR_LINE_NOT_FOUND = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x102;

        public const uint ERROR_NO_BACKUP = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x103;

        public const uint ERROR_NO_ASSOCIATED_CLASS = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x200;

        public const uint ERROR_CLASS_MISMATCH = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x201;

        public const uint ERROR_DUPLICATE_FOUND = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x202;

        public const uint ERROR_NO_DRIVER_SELECTED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x203;

        public const uint ERROR_KEY_DOES_NOT_EXIST = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x204;

        public const uint ERROR_INVALID_DEVINST_NAME = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x205;

        public const uint ERROR_INVALID_CLASS = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x206;

        public const uint ERROR_DEVINST_ALREADY_EXISTS = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x207;

        public const uint ERROR_DEVINFO_NOT_REGISTERED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x208;

        public const uint ERROR_INVALID_REG_PROPERTY = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x209;

        public const uint ERROR_NO_INF = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x20A;

        public const uint ERROR_NO_SUCH_DEVINST = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x20B;

        public const uint ERROR_CANT_LOAD_CLASS_ICON = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x20C;

        public const uint ERROR_INVALID_CLASS_INSTALLER = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x20D;

        public const uint ERROR_DI_DO_DEFAULT = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x20E;

        public const uint ERROR_DI_NOFILECOPY = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x20F;

        public const uint ERROR_INVALID_HWPROFILE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x210;

        public const uint ERROR_NO_DEVICE_SELECTED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x211;

        public const uint ERROR_DEVINFO_LIST_LOCKED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x212;

        public const uint ERROR_DEVINFO_DATA_LOCKED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x213;

        public const uint ERROR_DI_BAD_PATH = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x214;

        public const uint ERROR_NO_CLASSINSTALL_PARAMS = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x215;

        public const uint ERROR_FILEQUEUE_LOCKED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x216;

        public const uint ERROR_BAD_SERVICE_INSTALLSECT = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x217;

        public const uint ERROR_NO_CLASS_DRIVER_LIST = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x218;

        public const uint ERROR_NO_ASSOCIATED_SERVICE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x219;

        public const uint ERROR_NO_DEFAULT_DEVICE_INTERFACE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x21A;

        public const uint ERROR_DEVICE_INTERFACE_ACTIVE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x21B;

        public const uint ERROR_DEVICE_INTERFACE_REMOVED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x21C;

        public const uint ERROR_BAD_INTERFACE_INSTALLSECT = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x21D;

        public const uint ERROR_NO_SUCH_INTERFACE_CLASS = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x21E;

        public const uint ERROR_INVALID_REFERENCE_STRING = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x21F;

        public const uint ERROR_INVALID_MACHINENAME = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x220;

        public const uint ERROR_REMOTE_COMM_FAILURE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x221;

        public const uint ERROR_MACHINE_UNAVAILABLE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x222;

        public const uint ERROR_NO_CONFIGMGR_SERVICES = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x223;

        public const uint ERROR_INVALID_PROPPAGE_PROVIDER = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x224;

        public const uint ERROR_NO_SUCH_DEVICE_INTERFACE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x225;

        public const uint ERROR_DI_POSTPROCESSING_REQUIRED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x226;

        public const uint ERROR_INVALID_COINSTALLER = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x227;

        public const uint ERROR_NO_COMPAT_DRIVERS = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x228;

        public const uint ERROR_NO_DEVICE_ICON = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x229;

        public const uint ERROR_INVALID_INF_LOGCONFIG = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x22A;

        public const uint ERROR_DI_DONT_INSTALL = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x22B;

        public const uint ERROR_INVALID_FILTER_DRIVER = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x22C;

        public const uint ERROR_NON_WINDOWS_NT_DRIVER = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x22D;

        public const uint ERROR_NON_WINDOWS_DRIVER = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x22E;

        public const uint ERROR_NO_CATALOG_FOR_OEM_INF = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x22F;

        public const uint ERROR_DEVINSTALL_QUEUE_NONNATIVE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x230;

        public const uint ERROR_NOT_DISABLEABLE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x231;

        public const uint ERROR_CANT_REMOVE_DEVINST = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x232;

        public const uint ERROR_INVALID_TARGET = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x233;

        public const uint ERROR_DRIVER_NONNATIVE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x234;

        public const uint ERROR_IN_WOW64 = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x235;

        public const uint ERROR_SET_SYSTEM_RESTORE_POINT = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x236;

        public const uint ERROR_SCE_DISABLED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x238;

        public const uint ERROR_UNKNOWN_EXCEPTION = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x239;

        public const uint ERROR_PNP_REGISTRY_ERROR = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x23A;

        public const uint ERROR_REMOTE_REQUEST_UNSUPPORTED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x23B;

        public const uint ERROR_NOT_AN_INSTALLED_OEM_INF = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x23C;

        public const uint ERROR_INF_IN_USE_BY_DEVICES = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x23D;

        public const uint ERROR_DI_FUNCTION_OBSOLETE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x23E;

        public const uint ERROR_NO_AUTHENTICODE_CATALOG = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x23F;

        public const uint ERROR_AUTHENTICODE_DISALLOWED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x240;

        public const uint ERROR_AUTHENTICODE_TRUSTED_PUBLISHER = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x241;

        public const uint ERROR_AUTHENTICODE_TRUST_NOT_ESTABLISHED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x242;

        public const uint ERROR_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x243;

        public const uint ERROR_SIGNATURE_OSATTRIBUTE_MISMATCH = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x244;

        public const uint ERROR_ONLY_VALIDATE_VIA_AUTHENTICODE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x245;

        public const uint ERROR_DEVICE_INSTALLER_NOT_READY = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x246;

        public const uint ERROR_DRIVER_STORE_ADD_FAILED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x247;

        public const uint ERROR_DEVICE_INSTALL_BLOCKED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x248;

        public const uint ERROR_DRIVER_INSTALL_BLOCKED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x249;

        public const uint ERROR_WRONG_INF_TYPE = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x24A;

        public const uint ERROR_FILE_HASH_NOT_IN_CATALOG = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x24B;

        public const uint ERROR_DRIVER_STORE_DELETE_FAILED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x24C;

        public const uint ERROR_UNRECOVERABLE_STACK_OVERFLOW = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x300;

        public const uint EXCEPTION_SPAPI_UNRECOVERABLE_STACK_OVERFLOW = ERROR_UNRECOVERABLE_STACK_OVERFLOW;

        public const uint ERROR_NO_DEFAULT_INTERFACE_DEVICE = ERROR_NO_DEFAULT_DEVICE_INTERFACE;

        public const uint ERROR_INTERFACE_DEVICE_ACTIVE = ERROR_DEVICE_INTERFACE_ACTIVE;

        public const uint ERROR_INTERFACE_DEVICE_REMOVED = ERROR_DEVICE_INTERFACE_REMOVED;

        public const uint ERROR_NO_SUCH_INTERFACE_DEVICE = ERROR_NO_SUCH_DEVICE_INTERFACE;

        public const uint ERROR_NOT_INSTALLED = APPLICATION_ERROR_MASK | ERROR_SEVERITY_ERROR | 0x1000;

        public const uint SRC_FLAGS_CABFILE = 0x0010;

        public const uint SP_COPY_NEWER_OR_SAME = SP_COPY_NEWER;

        public const uint FLG_ADDREG_DELREG_BIT = 0x00008000;

        public const uint FLG_ADDREG_BINVALUETYPE = 0x00000001;

        public const uint FLG_ADDREG_NOCLOBBER = 0x00000002;

        public const uint FLG_ADDREG_DELVAL = 0x00000004;

        public const uint FLG_ADDREG_APPEND = 0x00000008;

        public const uint FLG_ADDREG_KEYONLY = 0x00000010;

        public const uint FLG_ADDREG_OVERWRITEONLY = 0x00000020;

        public const uint FLG_ADDREG_64BITKEY = 0x00001000;

        public const uint FLG_ADDREG_KEYONLY_COMMON = 0x00002000;

        public const uint FLG_ADDREG_32BITKEY = 0x00004000;

        public const uint FLG_ADDREG_TYPE_MASK = 0xFFFF0000 | FLG_ADDREG_BINVALUETYPE;

        public const uint FLG_ADDREG_TYPE_SZ = 0x00000000;

        public const uint FLG_ADDREG_TYPE_MULTI_SZ = 0x00010000;

        public const uint FLG_ADDREG_TYPE_EXPAND_SZ = 0x00020000;

        public const uint FLG_ADDREG_TYPE_BINARY = 0x00000000 | FLG_ADDREG_BINVALUETYPE;

        public const uint FLG_ADDREG_TYPE_DWORD = 0x00010000 | FLG_ADDREG_BINVALUETYPE;

        public const uint FLG_ADDREG_TYPE_NONE = 0x00020000 | FLG_ADDREG_BINVALUETYPE;

        public const uint FLG_ADDREG_TYPE_QWORD = 0x000B0000 | FLG_ADDREG_BINVALUETYPE;

        public const uint FLG_DELREG_VALUE = 0x00000000;

        public const uint FLG_DELREG_TYPE_MASK = FLG_ADDREG_TYPE_MASK;

        public const uint FLG_DELREG_TYPE_SZ = FLG_ADDREG_TYPE_SZ;

        public const uint FLG_DELREG_TYPE_MULTI_SZ = FLG_ADDREG_TYPE_MULTI_SZ;

        public const uint FLG_DELREG_TYPE_EXPAND_SZ = FLG_ADDREG_TYPE_EXPAND_SZ;

        public const uint FLG_DELREG_TYPE_BINARY = FLG_ADDREG_TYPE_BINARY;

        public const uint FLG_DELREG_TYPE_DWORD = FLG_ADDREG_TYPE_DWORD;

        public const uint FLG_DELREG_TYPE_NONE = FLG_ADDREG_TYPE_NONE;

        public const uint FLG_DELREG_64BITKEY = FLG_ADDREG_64BITKEY;

        public const uint FLG_DELREG_KEYONLY_COMMON = FLG_ADDREG_KEYONLY_COMMON;

        public const uint FLG_DELREG_32BITKEY = FLG_ADDREG_32BITKEY;

        public const uint FLG_DELREG_OPERATION_MASK = 0x000000FE;

        public const uint FLG_DELREG_MULTI_SZ_DELSTRING = FLG_DELREG_TYPE_MULTI_SZ | FLG_ADDREG_DELREG_BIT | 0x00000002;

        public const uint FLG_DELREG_TYPE_QWORD = FLG_ADDREG_TYPE_QWORD;

        public const uint FLG_BITREG_CLEARBITS = 0x00000000;

        public const uint FLG_BITREG_SETBITS = 0x00000001;

        public const uint FLG_BITREG_64BITKEY = 0x00001000;

        public const uint FLG_BITREG_32BITKEY = 0x00004000;

        public const uint FLG_INI2REG_64BITKEY = 0x00001000;

        public const uint FLG_INI2REG_32BITKEY = 0x00004000;

        public const uint FLG_REGSVR_DLLREGISTER = 0x00000001;

        public const uint FLG_REGSVR_DLLINSTALL = 0x00000002;

        public const uint FLG_PROFITEM_CURRENTUSER = 0x00000001;

        public const uint FLG_PROFITEM_DELETE = 0x00000002;

        public const uint FLG_PROFITEM_GROUP = 0x00000004;

        public const uint FLG_PROFITEM_CSIDL = 0x00000008;

        public const uint FLG_ADDPROPERTY_NOCLOBBER = 0x00000001;

        public const uint FLG_ADDPROPERTY_OVERWRITEONLY = 0x00000002;

        public const uint FLG_ADDPROPERTY_APPEND = 0x00000004;

        public const uint FLG_ADDPROPERTY_OR = 0x00000008;

        public const uint FLG_ADDPROPERTY_AND = 0x00000010;

        public const uint FLG_DELPROPERTY_MULTI_SZ_DELSTRING = 0x00000001;

        public const uint SPSVCINST_TAGTOFRONT = 0x00000001;

        public const uint SPSVCINST_ASSOCSERVICE = 0x00000002;

        public const uint SPSVCINST_DELETEEVENTLOGENTRY = 0x00000004;

        public const uint SPSVCINST_NOCLOBBER_DISPLAYNAME = 0x00000008;

        public const uint SPSVCINST_NOCLOBBER_STARTTYPE = 0x00000010;

        public const uint SPSVCINST_NOCLOBBER_ERRORCONTROL = 0x00000020;

        public const uint SPSVCINST_NOCLOBBER_LOADORDERGROUP = 0x00000040;

        public const uint SPSVCINST_NOCLOBBER_DEPENDENCIES = 0x00000080;

        public const uint SPSVCINST_NOCLOBBER_DESCRIPTION = 0x00000100;

        public const uint SPSVCINST_STOPSERVICE = 0x00000200;

        public const uint SPSVCINST_CLOBBER_SECURITY = 0x00000400;

        public const uint SPSVCINST_STARTSERVICE = 0x00000800;

        public const uint SPSVCINST_NOCLOBBER_REQUIREDPRIVILEGES = 0x00001000;

        public const uint SPSVCINST_NOCLOBBER_TRIGGERS = 0x00002000;

        public const uint SPDRP_DEVICEDESC = 0x00000000;

        public const uint SPDRP_HARDWAREID = 0x00000001;

        public const uint SPDRP_COMPATIBLEIDS = 0x00000002;

        public const uint SPDRP_UNUSED0 = 0x00000003;

        public const uint SPDRP_SERVICE = 0x00000004;

        public const uint SPDRP_UNUSED1 = 0x00000005;

        public const uint SPDRP_UNUSED2 = 0x00000006;

        public const uint SPDRP_CLASS = 0x00000007;

        public const uint SPDRP_CLASSGUID = 0x00000008;

        public const uint SPDRP_DRIVER = 0x00000009;

        public const uint SPDRP_CONFIGFLAGS = 0x0000000A;

        public const uint SPDRP_MFG = 0x0000000B;

        public const uint SPDRP_FRIENDLYNAME = 0x0000000C;

        public const uint SPDRP_LOCATION_INFORMATION = 0x0000000D;

        public const uint SPDRP_PHYSICAL_DEVICE_OBJECT_NAME = 0x0000000E;

        public const uint SPDRP_CAPABILITIES = 0x0000000F;

        public const uint SPDRP_UI_NUMBER = 0x00000010;

        public const uint SPDRP_UPPERFILTERS = 0x00000011;

        public const uint SPDRP_LOWERFILTERS = 0x00000012;

        public const uint SPDRP_BUSTYPEGUID = 0x00000013;

        public const uint SPDRP_LEGACYBUSTYPE = 0x00000014;

        public const uint SPDRP_BUSNUMBER = 0x00000015;

        public const uint SPDRP_ENUMERATOR_NAME = 0x00000016;

        public const uint SPDRP_SECURITY = 0x00000017;

        public const uint SPDRP_SECURITY_SDS = 0x00000018;

        public const uint SPDRP_DEVTYPE = 0x00000019;

        public const uint SPDRP_EXCLUSIVE = 0x0000001A;

        public const uint SPDRP_CHARACTERISTICS = 0x0000001B;

        public const uint SPDRP_ADDRESS = 0x0000001C;

        public const uint SPDRP_UI_NUMBER_DESC_FORMAT = 0X0000001D;

        public const uint SPDRP_DEVICE_POWER_DATA = 0x0000001E;

        public const uint SPDRP_REMOVAL_POLICY = 0x0000001F;

        public const uint SPDRP_REMOVAL_POLICY_HW_DEFAULT = 0x00000020;

        public const uint SPDRP_REMOVAL_POLICY_OVERRIDE = 0x00000021;

        public const uint SPDRP_INSTALL_STATE = 0x00000022;

        public const uint SPDRP_LOCATION_PATHS = 0x00000023;

        public const uint SPDRP_BASE_CONTAINERID = 0x00000024;

        public const uint SPDRP_MAXIMUM_PROPERTY = 0x00000025;

        public const uint SPCRP_UPPERFILTERS = 0x00000011;

        public const uint SPCRP_LOWERFILTERS = 0x00000012;

        public const uint SPCRP_SECURITY = 0x00000017;

        public const uint SPCRP_SECURITY_SDS = 0x00000018;

        public const uint SPCRP_DEVTYPE = 0x00000019;

        public const uint SPCRP_EXCLUSIVE = 0x0000001A;

        public const uint SPCRP_CHARACTERISTICS = 0x0000001B;

        public const uint SPCRP_MAXIMUM_PROPERTY = 0x0000001C;
    }
}
