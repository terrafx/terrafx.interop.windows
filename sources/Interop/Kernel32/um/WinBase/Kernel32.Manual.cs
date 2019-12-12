// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        public const uint FILE_BEGIN = 0;

        public const uint FILE_CURRENT = 1;

        public const uint FILE_END = 2;

        public const uint WAIT_FAILED = 0xFFFFFFFF;

        public const uint WAIT_OBJECT_0 = STATUS_WAIT_0 + 0;

        public const uint WAIT_ABANDONED = STATUS_ABANDONED_WAIT_0 + 0;

        public const uint WAIT_ABANDONED_0 = STATUS_ABANDONED_WAIT_0 + 0;

        public const uint WAIT_IO_COMPLETION = STATUS_USER_APC;
    }
}
