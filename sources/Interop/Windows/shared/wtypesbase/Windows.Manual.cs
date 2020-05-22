// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wtypesbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.CLSCTX;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const CLSCTX CLSCTX_VALID_MASK = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER | CLSCTX_LOCAL_SERVER | CLSCTX_INPROC_SERVER16 | CLSCTX_REMOTE_SERVER | CLSCTX_NO_CODE_DOWNLOAD | CLSCTX_NO_CUSTOM_MARSHAL | CLSCTX_ENABLE_CODE_DOWNLOAD | CLSCTX_NO_FAILURE_LOG | CLSCTX_DISABLE_AAA | CLSCTX_ENABLE_AAA | CLSCTX_FROM_DEFAULT_CONTEXT | CLSCTX_ACTIVATE_X86_SERVER | CLSCTX_ACTIVATE_64_BIT_SERVER | CLSCTX_ENABLE_CLOAKING | CLSCTX_APPCONTAINER | CLSCTX_ACTIVATE_AAA_AS_IU | CLSCTX_RESERVED6 | CLSCTX_ACTIVATE_ARM32_SERVER | CLSCTX_PS_DLL;
    }
}
