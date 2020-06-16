// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wtypesbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.CLSCTX;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int ROTREGFLAGS_ALLOWANYCLIENT = 0x1;

        public const int APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP = 0x1;

        public const int APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND = 0x2;

        public const int APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY = 0x4;

        public const int APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN = 0x8;

        public const int APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION = 0x10;

        public const int APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY = 0x20;

        public const int APPIDREGFLAGS_RESERVED1 = 0x40;

        public const int APPIDREGFLAGS_RESERVED2 = 0x80;

	    public const int APPIDREGFLAGS_RESERVED3 = 0x100;

	    public const int APPIDREGFLAGS_RESERVED4 = 0x200;

        public const int APPIDREGFLAGS_RESERVED5 = 0x400;

        public const int APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU = 0x800;

        public const int APPIDREGFLAGS_RESERVED7 = 0x1000;

        public const int APPIDREGFLAGS_RESERVED8 = 0x2000;

        public const int APPIDREGFLAGS_RESERVED9 = 0x4000;

        public const int DCOMSCM_ACTIVATION_USE_ALL_AUTHNSERVICES = 0x1;

        public const int DCOMSCM_ACTIVATION_DISALLOW_UNSECURE_CALL = 0x2;

        public const int DCOMSCM_RESOLVE_USE_ALL_AUTHNSERVICES = 0x4;

        public const int DCOMSCM_RESOLVE_DISALLOW_UNSECURE_CALL = 0x8;

        public const int DCOMSCM_PING_USE_MID_AUTHNSERVICE = 0x10;

        public const int DCOMSCM_PING_DISALLOW_UNSECURE_CALL = 0x20;

        public const CLSCTX CLSCTX_VALID_MASK = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER | CLSCTX_LOCAL_SERVER | CLSCTX_INPROC_SERVER16 | CLSCTX_REMOTE_SERVER | CLSCTX_NO_CODE_DOWNLOAD | CLSCTX_NO_CUSTOM_MARSHAL | CLSCTX_ENABLE_CODE_DOWNLOAD | CLSCTX_NO_FAILURE_LOG | CLSCTX_DISABLE_AAA | CLSCTX_ENABLE_AAA | CLSCTX_FROM_DEFAULT_CONTEXT | CLSCTX_ACTIVATE_X86_SERVER | CLSCTX_ACTIVATE_64_BIT_SERVER | CLSCTX_ENABLE_CLOAKING | CLSCTX_APPCONTAINER | CLSCTX_ACTIVATE_AAA_AS_IU | CLSCTX_RESERVED6 | CLSCTX_ACTIVATE_ARM32_SERVER | CLSCTX_PS_DLL;
    }
}
