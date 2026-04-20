// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CONTEXT
{
    [NativeTypeName("#define CONTEXT_EXCEPTION_ACTIVE 0x08000000L")]
    public const int CONTEXT_EXCEPTION_ACTIVE = 0x08000000;

    [NativeTypeName("#define CONTEXT_SERVICE_ACTIVE 0x10000000L")]
    public const int CONTEXT_SERVICE_ACTIVE = 0x10000000;

    [NativeTypeName("#define CONTEXT_EXCEPTION_REQUEST 0x40000000L")]
    public const int CONTEXT_EXCEPTION_REQUEST = 0x40000000;

    [NativeTypeName("#define CONTEXT_EXCEPTION_REPORTING 0x80000000L")]
    public const uint CONTEXT_EXCEPTION_REPORTING = 0x80000000;

    [NativeTypeName("#define CONTEXT_ARM64_XSTATE (CONTEXT_ARM64 | 0x20L)")]
    public const int CONTEXT_ARM64_XSTATE = (0x00400000 | 0x20);

    [NativeTypeName("#define CONTEXT_ARM64_FLOATING_POINT_LOW (CONTEXT_ARM64 | 0x40L)")]
    public const int CONTEXT_ARM64_FLOATING_POINT_LOW = (0x00400000 | 0x40);

    [NativeTypeName("#define CONTEXT_ARM64_FLOATING_POINT_HIGH (CONTEXT_ARM64 | 0x80L)")]
    public const int CONTEXT_ARM64_FLOATING_POINT_HIGH = (0x00400000 | 0x80);
}
