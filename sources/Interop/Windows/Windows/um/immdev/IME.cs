// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IME
{
    /// <include file='IME.xml' path='doc/member[@name="IME.IME_SYSINFO_WINLOGON"]/*' />
    [NativeTypeName("#define IME_SYSINFO_WINLOGON 0x0001")]
    public const int IME_SYSINFO_WINLOGON = 0x0001;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_END_UNLOAD"]/*' />
    [NativeTypeName("#define IME_PROP_END_UNLOAD 0x00000001")]
    public const int IME_PROP_END_UNLOAD = 0x00000001;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_KBD_CHAR_FIRST"]/*' />
    [NativeTypeName("#define IME_PROP_KBD_CHAR_FIRST 0x00000002")]
    public const int IME_PROP_KBD_CHAR_FIRST = 0x00000002;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_IGNORE_UPKEYS"]/*' />
    [NativeTypeName("#define IME_PROP_IGNORE_UPKEYS 0x00000004")]
    public const int IME_PROP_IGNORE_UPKEYS = 0x00000004;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_NEED_ALTKEY"]/*' />
    [NativeTypeName("#define IME_PROP_NEED_ALTKEY 0x00000008")]
    public const int IME_PROP_NEED_ALTKEY = 0x00000008;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_NO_KEYS_ON_CLOSE"]/*' />
    [NativeTypeName("#define IME_PROP_NO_KEYS_ON_CLOSE 0x00000010")]
    public const int IME_PROP_NO_KEYS_ON_CLOSE = 0x00000010;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_PROP_ACCEPT_WIDE_VKEY"]/*' />
    [NativeTypeName("#define IME_PROP_ACCEPT_WIDE_VKEY 0x00000020")]
    public const int IME_PROP_ACCEPT_WIDE_VKEY = 0x00000020;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_UI_CLASS_NAME_SIZE"]/*' />
    [NativeTypeName("#define IME_UI_CLASS_NAME_SIZE 16")]
    public const int IME_UI_CLASS_NAME_SIZE = 16;

    /// <include file='IME.xml' path='doc/member[@name="IME.IME_ESC_STRING_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define IME_ESC_STRING_BUFFER_SIZE 80")]
    public const int IME_ESC_STRING_BUFFER_SIZE = 80;
}
