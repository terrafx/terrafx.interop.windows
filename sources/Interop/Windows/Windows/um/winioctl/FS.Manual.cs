// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class FS
{
    [NativeTypeName("#define FS_BPIO_OUTPUT_ENABLE_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,Enable))")]
    public static nuint FS_BPIO_OUTPUT_ENABLE_SIZE => unchecked(((nuint)((nint)(Marshal.OffsetOf<FS_BPIO_OUTPUT>("Anonymous")))) + (328));

    [NativeTypeName("#define FS_BPIO_OUTPUT_QUERY_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,Query))")]
    public static nuint FS_BPIO_OUTPUT_QUERY_SIZE => unchecked(((nuint)((nint)(Marshal.OffsetOf<FS_BPIO_OUTPUT>("Anonymous")))) + (328));

    [NativeTypeName("#define FS_BPIO_OUTPUT_DISABLE_SIZE ((size_t)FIELD_OFFSET(FS_BPIO_OUTPUT, Enable))")]
    public static nuint FS_BPIO_OUTPUT_DISABLE_SIZE => unchecked((nuint)((nint)(Marshal.OffsetOf<FS_BPIO_OUTPUT>("Anonymous"))));

    [NativeTypeName("#define FS_BPIO_OUTPUT_VOLUME_STACK_PAUSE_SIZE ((size_t)FIELD_OFFSET(FS_BPIO_OUTPUT, Enable))")]
    public static nuint FS_BPIO_OUTPUT_VOLUME_STACK_PAUSE_SIZE => unchecked((nuint)((nint)(Marshal.OffsetOf<FS_BPIO_OUTPUT>("Anonymous"))));

    [NativeTypeName("#define FS_BPIO_OUTPUT_VOLUME_STACK_RESUME_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,VolumeStackResume))")]
    public static nuint FS_BPIO_OUTPUT_VOLUME_STACK_RESUME_SIZE => unchecked(((nuint)((nint)(Marshal.OffsetOf<FS_BPIO_OUTPUT>("Anonymous")))) + (328));

    [NativeTypeName("#define FS_BPIO_OUTPUT_STREAM_PAUSE_SIZE ((size_t)FIELD_OFFSET(FS_BPIO_OUTPUT, Enable))")]
    public static nuint FS_BPIO_OUTPUT_STREAM_PAUSE_SIZE => unchecked((nuint)((nint)(Marshal.OffsetOf<FS_BPIO_OUTPUT>("Anonymous"))));

    [NativeTypeName("#define FS_BPIO_OUTPUT_STREAM_RESUME_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,StreamResume))")]
    public static nuint FS_BPIO_OUTPUT_STREAM_RESUME_SIZE => unchecked(((nuint)((nint)(Marshal.OffsetOf<FS_BPIO_OUTPUT>("Anonymous")))) + (328));

    [NativeTypeName("#define FS_BPIO_OUTPUT_GET_INFO_SIZE (RTL_SIZEOF_THROUGH_FIELD(FS_BPIO_OUTPUT,GetInfo))")]
    public static nuint FS_BPIO_OUTPUT_GET_INFO_SIZE => unchecked(((nuint)((nint)(Marshal.OffsetOf<FS_BPIO_OUTPUT>("Anonymous")))) + (72));
}
