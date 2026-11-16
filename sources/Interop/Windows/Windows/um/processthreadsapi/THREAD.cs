// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class THREAD
{
    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_POWER_THROTTLING_CURRENT_VERSION"]/*' />
    [NativeTypeName("#define THREAD_POWER_THROTTLING_CURRENT_VERSION 1")]
    public const int THREAD_POWER_THROTTLING_CURRENT_VERSION = 1;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_POWER_THROTTLING_EXECUTION_SPEED"]/*' />
    [NativeTypeName("#define THREAD_POWER_THROTTLING_EXECUTION_SPEED 0x1")]
    public const int THREAD_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_POWER_THROTTLING_VALID_FLAGS"]/*' />
    [NativeTypeName("#define THREAD_POWER_THROTTLING_VALID_FLAGS (THREAD_POWER_THROTTLING_EXECUTION_SPEED)")]
    public const int THREAD_POWER_THROTTLING_VALID_FLAGS = (0x1);
}
