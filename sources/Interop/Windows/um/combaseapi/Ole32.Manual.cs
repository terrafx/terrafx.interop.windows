// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.CLSCTX;

namespace TerraFX.Interop
{
    public static partial class Ole32
    {
        public const CLSCTX CLSCTX_INPROC = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER;
        public const CLSCTX CLSCTX_ALL = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER | CLSCTX_LOCAL_SERVER | CLSCTX_REMOTE_SERVER;
        public const CLSCTX CLSCTX_SERVER = CLSCTX_INPROC_SERVER | CLSCTX_LOCAL_SERVER | CLSCTX_REMOTE_SERVER;

        public const uint COM_RIGHTS_EXECUTE = 1;
        public const uint COM_RIGHTS_EXECUTE_LOCAL = 2;
        public const uint COM_RIGHTS_EXECUTE_REMOTE = 4;
        public const uint COM_RIGHTS_ACTIVATE_LOCAL = 8;
        public const uint COM_RIGHTS_ACTIVATE_REMOTE = 16;
        public const uint COM_RIGHTS_RESERVED1 = 32;
        public const uint COM_RIGHTS_RESERVED2 = 64;

        public const uint CWMO_MAX_HANDLES = 56;
    }
}
