// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FORMAT
{
    /// <include file='FORMAT.xml' path='doc/member[@name="FORMAT.FORMAT_MESSAGE_ALLOCATE_BUFFER"]/*' />
    [NativeTypeName("#define FORMAT_MESSAGE_ALLOCATE_BUFFER 0x00000100")]
    public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;

    /// <include file='FORMAT.xml' path='doc/member[@name="FORMAT.FORMAT_MESSAGE_IGNORE_INSERTS"]/*' />
    [NativeTypeName("#define FORMAT_MESSAGE_IGNORE_INSERTS 0x00000200")]
    public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;

    /// <include file='FORMAT.xml' path='doc/member[@name="FORMAT.FORMAT_MESSAGE_FROM_STRING"]/*' />
    [NativeTypeName("#define FORMAT_MESSAGE_FROM_STRING 0x00000400")]
    public const int FORMAT_MESSAGE_FROM_STRING = 0x00000400;

    /// <include file='FORMAT.xml' path='doc/member[@name="FORMAT.FORMAT_MESSAGE_FROM_HMODULE"]/*' />
    [NativeTypeName("#define FORMAT_MESSAGE_FROM_HMODULE 0x00000800")]
    public const int FORMAT_MESSAGE_FROM_HMODULE = 0x00000800;

    /// <include file='FORMAT.xml' path='doc/member[@name="FORMAT.FORMAT_MESSAGE_FROM_SYSTEM"]/*' />
    [NativeTypeName("#define FORMAT_MESSAGE_FROM_SYSTEM 0x00001000")]
    public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;

    /// <include file='FORMAT.xml' path='doc/member[@name="FORMAT.FORMAT_MESSAGE_ARGUMENT_ARRAY"]/*' />
    [NativeTypeName("#define FORMAT_MESSAGE_ARGUMENT_ARRAY 0x00002000")]
    public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000;

    /// <include file='FORMAT.xml' path='doc/member[@name="FORMAT.FORMAT_MESSAGE_MAX_WIDTH_MASK"]/*' />
    [NativeTypeName("#define FORMAT_MESSAGE_MAX_WIDTH_MASK 0x000000FF")]
    public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF;
}
