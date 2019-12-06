// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Kernel32
    {
        public const uint RTL_RUN_ONCE_CHECK_ONLY = 0x00000001;

        public const uint RTL_RUN_ONCE_ASYNC = 0x00000002;

        public const uint RTL_RUN_ONCE_INIT_FAILED = 0x00000004;

        public const uint RTL_RUN_ONCE_CTX_RESERVED_BITS = 2;
    }
}
