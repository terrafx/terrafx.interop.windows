// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IS
{
    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_ASCII16"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_ASCII16 0x0001")]
    public const int IS_TEXT_UNICODE_ASCII16 = 0x0001;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_REVERSE_ASCII16"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_ASCII16 0x0010")]
    public const int IS_TEXT_UNICODE_REVERSE_ASCII16 = 0x0010;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_STATISTICS"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_STATISTICS 0x0002")]
    public const int IS_TEXT_UNICODE_STATISTICS = 0x0002;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_REVERSE_STATISTICS"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_STATISTICS 0x0020")]
    public const int IS_TEXT_UNICODE_REVERSE_STATISTICS = 0x0020;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_CONTROLS"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_CONTROLS 0x0004")]
    public const int IS_TEXT_UNICODE_CONTROLS = 0x0004;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_REVERSE_CONTROLS"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_CONTROLS 0x0040")]
    public const int IS_TEXT_UNICODE_REVERSE_CONTROLS = 0x0040;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_SIGNATURE"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_SIGNATURE 0x0008")]
    public const int IS_TEXT_UNICODE_SIGNATURE = 0x0008;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_REVERSE_SIGNATURE"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_SIGNATURE 0x0080")]
    public const int IS_TEXT_UNICODE_REVERSE_SIGNATURE = 0x0080;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_ILLEGAL_CHARS"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_ILLEGAL_CHARS 0x0100")]
    public const int IS_TEXT_UNICODE_ILLEGAL_CHARS = 0x0100;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_ODD_LENGTH"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_ODD_LENGTH 0x0200")]
    public const int IS_TEXT_UNICODE_ODD_LENGTH = 0x0200;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_DBCS_LEADBYTE"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_DBCS_LEADBYTE 0x0400")]
    public const int IS_TEXT_UNICODE_DBCS_LEADBYTE = 0x0400;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_UTF8"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_UTF8 0x0800")]
    public const int IS_TEXT_UNICODE_UTF8 = 0x0800;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_NULL_BYTES"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_NULL_BYTES 0x1000")]
    public const int IS_TEXT_UNICODE_NULL_BYTES = 0x1000;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_UNICODE_MASK"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_UNICODE_MASK 0x000F")]
    public const int IS_TEXT_UNICODE_UNICODE_MASK = 0x000F;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_REVERSE_MASK"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_MASK 0x00F0")]
    public const int IS_TEXT_UNICODE_REVERSE_MASK = 0x00F0;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_NOT_UNICODE_MASK"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_NOT_UNICODE_MASK 0x0F00")]
    public const int IS_TEXT_UNICODE_NOT_UNICODE_MASK = 0x0F00;

    /// <include file='IS.xml' path='doc/member[@name="IS.IS_TEXT_UNICODE_NOT_ASCII_MASK"]/*' />
    [NativeTypeName("#define IS_TEXT_UNICODE_NOT_ASCII_MASK 0xF000")]
    public const int IS_TEXT_UNICODE_NOT_ASCII_MASK = 0xF000;
}
