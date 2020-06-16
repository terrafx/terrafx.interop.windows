// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const uint TLS_OUT_OF_INDEXES = 0xFFFFFFFF;

        public const int PROC_THREAD_ATTRIBUTE_REPLACE_VALUE = 0x00000001;

        public const uint PROCESS_AFFINITY_ENABLE_AUTO_UPDATE = 0x00000001;

        public const int THREAD_POWER_THROTTLING_CURRENT_VERSION = 1;

        public const int THREAD_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

        public const int THREAD_POWER_THROTTLING_VALID_FLAGS = THREAD_POWER_THROTTLING_EXECUTION_SPEED;

        public const int PME_CURRENT_VERSION = 1;

        public const int PME_FAILFAST_ON_COMMIT_FAIL_DISABLE = 0x0;

        public const int PME_FAILFAST_ON_COMMIT_FAIL_ENABLE = 0x1;

        public const int PROCESS_POWER_THROTTLING_CURRENT_VERSION = 1;

        public const int PROCESS_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

        public const int PROCESS_POWER_THROTTLING_VALID_FLAGS = PROCESS_POWER_THROTTLING_EXECUTION_SPEED;

        public const int PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND = 0x1;

        public const int PROCESS_LEAP_SECOND_INFO_VALID_FLAGS = PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND;
    }
}
