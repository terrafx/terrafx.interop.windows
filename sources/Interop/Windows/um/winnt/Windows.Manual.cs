// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static uint MAX_NATURAL_ALIGNMENT => unchecked((uint)(sizeof(nint)));

        public static int MEMORY_ALLOCATION_ALIGNMENT
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return 8;
                }
                else
                {
                    return 16;
                }
            }
        }

        public static int SYSTEM_CACHE_ALIGNMENT_SIZE
        {
            get
            {
                if (X86Base.IsSupported)
                {
                    return 64;
                }
                else
                {
                    return 128;
                }
            }
        }

        public static int MAXIMUM_PROC_PER_GROUP
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return 32;
                }
                else
                {
                    return 64;
                }
            }
        }

        [NativeTypeName("#define MAXIMUM_PROCESSORS MAXIMUM_PROC_PER_GROUP")]
        public static int MAXIMUM_PROCESSORS => MAXIMUM_PROC_PER_GROUP;

        [NativeTypeName("#define CONTEXT_AMD64 0x00100000L")]
        public const int CONTEXT_AMD64 = 0x00100000;

        [NativeTypeName("#define CONTEXT_CONTROL (CONTEXT_AMD64 | 0x00000001L)")]
        public const int CONTEXT_AMD64_CONTROL = (0x00100000 | 0x00000001);

        [NativeTypeName("#define CONTEXT_INTEGER (CONTEXT_AMD64 | 0x00000002L)")]
        public const int CONTEXT_AMD64_INTEGER = (0x00100000 | 0x00000002);

        [NativeTypeName("#define CONTEXT_SEGMENTS (CONTEXT_AMD64 | 0x00000004L)")]
        public const int CONTEXT_AMD64_SEGMENTS = (0x00100000 | 0x00000004);

        [NativeTypeName("#define CONTEXT_FLOATING_POINT (CONTEXT_AMD64 | 0x00000008L)")]
        public const int CONTEXT_AMD64_FLOATING_POINT = (0x00100000 | 0x00000008);

        [NativeTypeName("#define CONTEXT_DEBUG_REGISTERS (CONTEXT_AMD64 | 0x00000010L)")]
        public const int CONTEXT_AMD64_DEBUG_REGISTERS = (0x00100000 | 0x00000010);

        [NativeTypeName("#define CONTEXT_FULL (CONTEXT_CONTROL | CONTEXT_INTEGER | \\\r\n                                 CONTEXT_FLOATING_POINT)")]
        public const int CONTEXT_AMD64_FULL = ((0x00100000 | 0x00000001) | (0x00100000 | 0x00000002) | (0x00100000 | 0x00000008));

        [NativeTypeName("#define CONTEXT_ALL (CONTEXT_CONTROL | CONTEXT_INTEGER | \\\r\n                                 CONTEXT_SEGMENTS | CONTEXT_FLOATING_POINT | \\\r\n                                 CONTEXT_DEBUG_REGISTERS)")]
        public const int CONTEXT_AMD64_ALL = ((0x00100000 | 0x00000001) | (0x00100000 | 0x00000002) | (0x00100000 | 0x00000004) | (0x00100000 | 0x00000008) | (0x00100000 | 0x00000010));

        [NativeTypeName("#define CONTEXT_XSTATE (CONTEXT_AMD64 | 0x00000040L)")]
        public const int CONTEXT_AMD64_XSTATE = (0x00100000 | 0x00000040);

        [NativeTypeName("#define CONTEXT_KERNEL_CET (CONTEXT_AMD64 | 0x00000080L)")]
        public const int CONTEXT_AMD64_KERNEL_CET = (0x00100000 | 0x00000080);

        [NativeTypeName("#define MAXIMUM_SUPPORTED_EXTENSION 512")]
        public const int MAXIMUM_SUPPORTED_EXTENSION = 512;

        [NativeTypeName("#define CONTEXT_UNWOUND_TO_CALL 0x20000000")]
        public const int CONTEXT_AMD64_UNWOUND_TO_CALL = 0x20000000;

        [NativeTypeName("#define INITIAL_MXCSR 0x1f80")]
        public const int INITIAL_MXCSR = 0x1f80;

        [NativeTypeName("#define INITIAL_FPCSR 0x027f")]
        public const int INITIAL_FPCSR = 0x027f;

        [NativeTypeName("#define RUNTIME_FUNCTION_INDIRECT 0x1")]
        public const int RUNTIME_FUNCTION_INDIRECT = 0x1;

        [NativeTypeName("#define UNW_FLAG_NHANDLER 0x0")]
        public const int UNW_FLAG_NHANDLER = 0x0;

        [NativeTypeName("#define UNW_FLAG_EHANDLER 0x1")]
        public const int UNW_FLAG_EHANDLER = 0x1;

        [NativeTypeName("#define UNW_FLAG_UHANDLER 0x2")]
        public const int UNW_FLAG_UHANDLER = 0x2;

        [NativeTypeName("#define UNW_FLAG_CHAININFO 0x4")]
        public const int UNW_FLAG_CHAININFO = 0x4;

        [NativeTypeName("#define UNW_FLAG_NO_EPILOGUE 0x80000000UL")]
        public const uint UNW_FLAG_NO_EPILOGUE = 0x80000000U;

        [NativeTypeName("#define UNWIND_CHAIN_LIMIT 32")]
        public const int UNWIND_CHAIN_LIMIT = 32;

        [NativeTypeName("#define OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME \"OutOfProcessFunctionTableCallback\"")]
        public static ReadOnlySpan<byte> OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME => new byte[] { 0x4F, 0x75, 0x74, 0x4F, 0x66, 0x50, 0x72, 0x6F, 0x63, 0x65, 0x73, 0x73, 0x46, 0x75, 0x6E, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x54, 0x61, 0x62, 0x6C, 0x65, 0x43, 0x61, 0x6C, 0x6C, 0x62, 0x61, 0x63, 0x6B, 0x00 };

        [NativeTypeName("#define CONTEXT_ARM64 0x00400000L")]
        public const int CONTEXT_ARM64 = 0x00400000;

        [NativeTypeName("#define CONTEXT_ARM64_CONTROL (CONTEXT_ARM64 | 0x1L)")]
        public const int CONTEXT_ARM64_CONTROL = (0x00400000 | 0x1);

        [NativeTypeName("#define CONTEXT_ARM64_INTEGER (CONTEXT_ARM64 | 0x2L)")]
        public const int CONTEXT_ARM64_INTEGER = (0x00400000 | 0x2);

        [NativeTypeName("#define CONTEXT_ARM64_FLOATING_POINT (CONTEXT_ARM64 | 0x4L)")]
        public const int CONTEXT_ARM64_FLOATING_POINT = (0x00400000 | 0x4);

        [NativeTypeName("#define CONTEXT_ARM64_DEBUG_REGISTERS (CONTEXT_ARM64 | 0x8L)")]
        public const int CONTEXT_ARM64_DEBUG_REGISTERS = (0x00400000 | 0x8);

        [NativeTypeName("#define CONTEXT_ARM64_X18 (CONTEXT_ARM64 | 0x10L)")]
        public const int CONTEXT_ARM64_X18 = (0x00400000 | 0x10);

        [NativeTypeName("#define CONTEXT_ARM64_FULL (CONTEXT_ARM64_CONTROL | CONTEXT_ARM64_INTEGER | CONTEXT_ARM64_FLOATING_POINT)")]
        public const int CONTEXT_ARM64_FULL = ((0x00400000 | 0x1) | (0x00400000 | 0x2) | (0x00400000 | 0x4));

        [NativeTypeName("#define CONTEXT_ARM64_ALL (CONTEXT_ARM64_CONTROL | CONTEXT_ARM64_INTEGER | CONTEXT_ARM64_FLOATING_POINT | CONTEXT_ARM64_DEBUG_REGISTERS | CONTEXT_ARM64_X18)")]
        public const int CONTEXT_ARM64_ALL = ((0x00400000 | 0x1) | (0x00400000 | 0x2) | (0x00400000 | 0x4) | (0x00400000 | 0x8) | (0x00400000 | 0x10));

        [NativeTypeName("#define CONTEXT_ARM64_UNWOUND_TO_CALL 0x20000000")]
        public const int CONTEXT_ARM64_UNWOUND_TO_CALL = 0x20000000;

        [NativeTypeName("#define CONTEXT_ARM64_RET_TO_GUEST 0x04000000")]
        public const int CONTEXT_ARM64_RET_TO_GUEST = 0x04000000;

        [NativeTypeName("#define CONTEXT_UNWOUND_TO_CALL CONTEXT_ARM64_UNWOUND_TO_CALL")]
        public static int CONTEXT_UNWOUND_TO_CALL
        {
            get
            {
                if (ArmBase.Arm64.IsSupported)
                {
                    return CONTEXT_ARM64_UNWOUND_TO_CALL;
                }
                else
                {
                    return 0;
                }
            }
        }

        [NativeTypeName("#define CONTEXT_RET_TO_GUEST CONTEXT_ARM64_RET_TO_GUEST")]
        public static int CONTEXT_RET_TO_GUEST
        {
            get
            {
                if (ArmBase.Arm64.IsSupported)
                {
                    return 0x04000000;
                }
                else
                {
                    return 0;
                }
            }
        }

        [NativeTypeName("#define ARM64_MAX_BREAKPOINTS 8")]
        public const int ARM64_MAX_BREAKPOINTS = 8;

        [NativeTypeName("#define ARM64_MAX_WATCHPOINTS 2")]
        public const int ARM64_MAX_WATCHPOINTS = 2;

        [NativeTypeName("#define NONVOL_INT_NUMREG_ARM64 (11)")]
        public const int NONVOL_INT_NUMREG_ARM64 = (11);

        [NativeTypeName("#define NONVOL_FP_NUMREG_ARM64 (8)")]
        public const int NONVOL_FP_NUMREG_ARM64 = (8);

        [NativeTypeName("#define NONVOL_INT_SIZE_ARM64 (NONVOL_INT_NUMREG_ARM64 * sizeof(DWORD64))")]
        public const uint NONVOL_INT_SIZE_ARM64 = ((11) * 8);

        [NativeTypeName("#define NONVOL_FP_SIZE_ARM64 (NONVOL_FP_NUMREG_ARM64 * sizeof(double))")]
        public const uint NONVOL_FP_SIZE_ARM64 = ((8) * 8);

        [NativeTypeName("#define SIZE_OF_80387_REGISTERS 80")]
        public const int SIZE_OF_80387_REGISTERS = 80;

        [NativeTypeName("#define CONTEXT_i386 0x00010000L")]
        public const int CONTEXT_i386 = 0x00010000;

        [NativeTypeName("#define CONTEXT_i486 0x00010000L")]
        public const int CONTEXT_i486 = 0x00010000;

        [NativeTypeName("#define CONTEXT_CONTROL (CONTEXT_i386 | 0x00000001L)")]
        public const int CONTEXT_i386_CONTROL = (0x00010000 | 0x00000001);

        [NativeTypeName("#define CONTEXT_INTEGER (CONTEXT_i386 | 0x00000002L)")]
        public const int CONTEXT_i386_INTEGER = (0x00010000 | 0x00000002);

        [NativeTypeName("#define CONTEXT_SEGMENTS (CONTEXT_i386 | 0x00000004L)")]
        public const int CONTEXT_i386_SEGMENTS = (0x00010000 | 0x00000004);

        [NativeTypeName("#define CONTEXT_FLOATING_POINT (CONTEXT_i386 | 0x00000008L)")]
        public const int CONTEXT_i386_FLOATING_POINT = (0x00010000 | 0x00000008);

        [NativeTypeName("#define CONTEXT_DEBUG_REGISTERS (CONTEXT_i386 | 0x00000010L)")]
        public const int CONTEXT_i386_DEBUG_REGISTERS = (0x00010000 | 0x00000010);

        [NativeTypeName("#define CONTEXT_EXTENDED_REGISTERS (CONTEXT_i386 | 0x00000020L)")]
        public const int CONTEXT_i386_EXTENDED_REGISTERS = (0x00010000 | 0x00000020);

        [NativeTypeName("#define CONTEXT_FULL (CONTEXT_CONTROL | CONTEXT_INTEGER |\\\r\n                      CONTEXT_SEGMENTS)")]
        public const int CONTEXT_i386_FULL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004));

        [NativeTypeName("#define CONTEXT_ALL (CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS | \\\r\n                                 CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS | \\\r\n                                 CONTEXT_EXTENDED_REGISTERS)")]
        public const int CONTEXT_i386_ALL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004) | (0x00010000 | 0x00000008) | (0x00010000 | 0x00000010) | (0x00010000 | 0x00000020));

        [NativeTypeName("#define CONTEXT_XSTATE (CONTEXT_i386 | 0x00000040L)")]
        public const int CONTEXT_i386_XSTATE = (0x00010000 | 0x00000040);

        public static ulong XSTATE_MASK_ALLOWED
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (XSTATE_MASK_LEGACY |
                            XSTATE_MASK_AVX |
                            XSTATE_MASK_MPX |
                            XSTATE_MASK_AVX512 |
                            XSTATE_MASK_IPT |
                            XSTATE_MASK_CET_U |
                            XSTATE_MASK_LWP);
                }
                else
                {
                    return (XSTATE_MASK_LEGACY |
                            XSTATE_MASK_AVX |
                            XSTATE_MASK_MPX |
                            XSTATE_MASK_AVX512 |
                            XSTATE_MASK_IPT |
                            XSTATE_MASK_CET_U |
                            XSTATE_MASK_AMX_TILE_CONFIG |
                            XSTATE_MASK_AMX_TILE_DATA |
                            XSTATE_MASK_LWP);
                }
            }
        }

        public static int IMAGE_NT_OPTIONAL_HDR_MAGIC
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return IMAGE_NT_OPTIONAL_HDR32_MAGIC;
                }
                else
                {
                    return IMAGE_NT_OPTIONAL_HDR64_MAGIC;
                }
            }
        }

        public static nuint IMAGE_ORDINAL_FLAG
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return IMAGE_ORDINAL_FLAG32;
                }
                else
                {
                    return unchecked((nuint)(IMAGE_ORDINAL_FLAG64));
                }
            }
        }
    }
}
