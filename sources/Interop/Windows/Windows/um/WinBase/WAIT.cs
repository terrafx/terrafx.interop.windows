// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WAIT
{
    /// <include file='WAIT.xml' path='doc/member[@name="WAIT.WAIT_FAILED"]/*' />
    [NativeTypeName("#define WAIT_FAILED ((DWORD)0xFFFFFFFF)")]
    public const uint WAIT_FAILED = ((uint)(0xFFFFFFFF));

    /// <include file='WAIT.xml' path='doc/member[@name="WAIT.WAIT_OBJECT_0"]/*' />
    [NativeTypeName("#define WAIT_OBJECT_0 ((STATUS_WAIT_0 ) + 0 )")]
    public const uint WAIT_OBJECT_0 = ((((uint)(0x00000000))) + 0);

    /// <include file='WAIT.xml' path='doc/member[@name="WAIT.WAIT_ABANDONED"]/*' />
    [NativeTypeName("#define WAIT_ABANDONED ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
    public const uint WAIT_ABANDONED = ((((uint)(0x00000080))) + 0);

    /// <include file='WAIT.xml' path='doc/member[@name="WAIT.WAIT_ABANDONED_0"]/*' />
    [NativeTypeName("#define WAIT_ABANDONED_0 ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
    public const uint WAIT_ABANDONED_0 = ((((uint)(0x00000080))) + 0);

    /// <include file='WAIT.xml' path='doc/member[@name="WAIT.WAIT_IO_COMPLETION"]/*' />
    [NativeTypeName("#define WAIT_IO_COMPLETION STATUS_USER_APC")]
    public const uint WAIT_IO_COMPLETION = ((uint)(0x000000C0));
}
