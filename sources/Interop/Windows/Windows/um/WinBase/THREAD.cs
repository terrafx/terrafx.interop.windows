// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class THREAD
{
    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PRIORITY_LOWEST"]/*' />
    [NativeTypeName("#define THREAD_PRIORITY_LOWEST THREAD_BASE_PRIORITY_MIN")]
    public const int THREAD_PRIORITY_LOWEST = (-2);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PRIORITY_BELOW_NORMAL"]/*' />
    [NativeTypeName("#define THREAD_PRIORITY_BELOW_NORMAL (THREAD_PRIORITY_LOWEST+1)")]
    public const int THREAD_PRIORITY_BELOW_NORMAL = ((-2) + 1);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PRIORITY_NORMAL"]/*' />
    [NativeTypeName("#define THREAD_PRIORITY_NORMAL 0")]
    public const int THREAD_PRIORITY_NORMAL = 0;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PRIORITY_HIGHEST"]/*' />
    [NativeTypeName("#define THREAD_PRIORITY_HIGHEST THREAD_BASE_PRIORITY_MAX")]
    public const int THREAD_PRIORITY_HIGHEST = 2;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PRIORITY_ABOVE_NORMAL"]/*' />
    [NativeTypeName("#define THREAD_PRIORITY_ABOVE_NORMAL (THREAD_PRIORITY_HIGHEST-1)")]
    public const int THREAD_PRIORITY_ABOVE_NORMAL = (2 - 1);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PRIORITY_ERROR_RETURN"]/*' />
    [NativeTypeName("#define THREAD_PRIORITY_ERROR_RETURN (MAXLONG)")]
    public const int THREAD_PRIORITY_ERROR_RETURN = (0x7fffffff);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PRIORITY_TIME_CRITICAL"]/*' />
    [NativeTypeName("#define THREAD_PRIORITY_TIME_CRITICAL THREAD_BASE_PRIORITY_LOWRT")]
    public const int THREAD_PRIORITY_TIME_CRITICAL = 15;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PRIORITY_IDLE"]/*' />
    [NativeTypeName("#define THREAD_PRIORITY_IDLE THREAD_BASE_PRIORITY_IDLE")]
    public const int THREAD_PRIORITY_IDLE = (-15);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_MODE_BACKGROUND_BEGIN"]/*' />
    [NativeTypeName("#define THREAD_MODE_BACKGROUND_BEGIN 0x00010000")]
    public const int THREAD_MODE_BACKGROUND_BEGIN = 0x00010000;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_MODE_BACKGROUND_END"]/*' />
    [NativeTypeName("#define THREAD_MODE_BACKGROUND_END 0x00020000")]
    public const int THREAD_MODE_BACKGROUND_END = 0x00020000;
}
