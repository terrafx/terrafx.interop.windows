// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.CLSCTX;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define ROTREGFLAGS_ALLOWANYCLIENT 0x1")]
        public const int ROTREGFLAGS_ALLOWANYCLIENT = 0x1;

        [NativeTypeName("#define APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP 0x1")]
        public const int APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP = 0x1;

        [NativeTypeName("#define APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND 0x2")]
        public const int APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND = 0x2;

        [NativeTypeName("#define APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY 0x4")]
        public const int APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY = 0x4;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN 0x8")]
        public const int APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN = 0x8;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION 0x10")]
        public const int APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION = 0x10;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY 0x20")]
        public const int APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY = 0x20;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED1 0x40")]
        public const int APPIDREGFLAGS_RESERVED1 = 0x40;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED2 0x80")]
        public const int APPIDREGFLAGS_RESERVED2 = 0x80;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED3 0x100")]
        public const int APPIDREGFLAGS_RESERVED3 = 0x100;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED4 0x200")]
        public const int APPIDREGFLAGS_RESERVED4 = 0x200;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED5 0x400")]
        public const int APPIDREGFLAGS_RESERVED5 = 0x400;

        [NativeTypeName("#define APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU 0x800")]
        public const int APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU = 0x800;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED7 0x1000")]
        public const int APPIDREGFLAGS_RESERVED7 = 0x1000;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED8 0x2000")]
        public const int APPIDREGFLAGS_RESERVED8 = 0x2000;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED9 0x4000")]
        public const int APPIDREGFLAGS_RESERVED9 = 0x4000;

        [NativeTypeName("#define DCOMSCM_ACTIVATION_USE_ALL_AUTHNSERVICES 0x1")]
        public const int DCOMSCM_ACTIVATION_USE_ALL_AUTHNSERVICES = 0x1;

        [NativeTypeName("#define DCOMSCM_ACTIVATION_DISALLOW_UNSECURE_CALL 0x2")]
        public const int DCOMSCM_ACTIVATION_DISALLOW_UNSECURE_CALL = 0x2;

        [NativeTypeName("#define DCOMSCM_RESOLVE_USE_ALL_AUTHNSERVICES 0x4")]
        public const int DCOMSCM_RESOLVE_USE_ALL_AUTHNSERVICES = 0x4;

        [NativeTypeName("#define DCOMSCM_RESOLVE_DISALLOW_UNSECURE_CALL 0x8")]
        public const int DCOMSCM_RESOLVE_DISALLOW_UNSECURE_CALL = 0x8;

        [NativeTypeName("#define DCOMSCM_PING_USE_MID_AUTHNSERVICE 0x10")]
        public const int DCOMSCM_PING_USE_MID_AUTHNSERVICE = 0x10;

        [NativeTypeName("#define DCOMSCM_PING_DISALLOW_UNSECURE_CALL 0x20")]
        public const int DCOMSCM_PING_DISALLOW_UNSECURE_CALL = 0x20;

        [NativeTypeName("#define CLSCTX_VALID_MASK (CLSCTX_INPROC_SERVER | \\\r\n    CLSCTX_INPROC_HANDLER | \\\r\n    CLSCTX_LOCAL_SERVER | \\\r\n    CLSCTX_INPROC_SERVER16 | \\\r\n    CLSCTX_REMOTE_SERVER | \\\r\n    CLSCTX_NO_CODE_DOWNLOAD | \\\r\n    CLSCTX_NO_CUSTOM_MARSHAL | \\\r\n    CLSCTX_ENABLE_CODE_DOWNLOAD | \\\r\n    CLSCTX_NO_FAILURE_LOG | \\\r\n    CLSCTX_DISABLE_AAA | \\\r\n    CLSCTX_ENABLE_AAA | \\\r\n    CLSCTX_FROM_DEFAULT_CONTEXT | \\\r\n    CLSCTX_ACTIVATE_X86_SERVER | \\\r\n    CLSCTX_ACTIVATE_64_BIT_SERVER | \\\r\n    CLSCTX_ENABLE_CLOAKING | \\\r\n    CLSCTX_APPCONTAINER | \\\r\n    CLSCTX_ACTIVATE_AAA_AS_IU | \\\r\n    CLSCTX_RESERVED6 | \\\r\n    CLSCTX_ACTIVATE_ARM32_SERVER | \\\r\n    CLSCTX_PS_DLL)")]
        public const int CLSCTX_VALID_MASK = ((int)(CLSCTX_INPROC_SERVER) | (int)(CLSCTX_INPROC_HANDLER) | (int)(CLSCTX_LOCAL_SERVER) | (int)(CLSCTX_INPROC_SERVER16) | (int)(CLSCTX_REMOTE_SERVER) | (int)(CLSCTX_NO_CODE_DOWNLOAD) | (int)(CLSCTX_NO_CUSTOM_MARSHAL) | (int)(CLSCTX_ENABLE_CODE_DOWNLOAD) | (int)(CLSCTX_NO_FAILURE_LOG) | (int)(CLSCTX_DISABLE_AAA) | (int)(CLSCTX_ENABLE_AAA) | (int)(CLSCTX_FROM_DEFAULT_CONTEXT) | (int)(CLSCTX_ACTIVATE_X86_SERVER) | (int)(CLSCTX_ACTIVATE_64_BIT_SERVER) | (int)(CLSCTX_ENABLE_CLOAKING) | (int)(CLSCTX_APPCONTAINER) | (int)(CLSCTX_ACTIVATE_AAA_AS_IU) | (int)(CLSCTX_RESERVED6) | (int)(CLSCTX_ACTIVATE_ARM32_SERVER) | (int)(CLSCTX_PS_DLL));
    }
}
