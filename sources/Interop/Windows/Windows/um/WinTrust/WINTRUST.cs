// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WINTRUST
{
    /// <include file='WINTRUST.xml' path='doc/member[@name="WINTRUST.WINTRUST_CONFIG_REGPATH"]/*' />
    [NativeTypeName("#define WINTRUST_CONFIG_REGPATH L\"Software\\Microsoft\\Cryptography\\Wintrust\\Config\"")]
    public const string WINTRUST_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\Wintrust\\Config";

    /// <include file='WINTRUST.xml' path='doc/member[@name="WINTRUST.WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME"]/*' />
    [NativeTypeName("#define WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME L\"MaxHeaderBytesToMap\"")]
    public const string WINTRUST_MAX_HEADER_BYTES_TO_MAP_VALUE_NAME = "MaxHeaderBytesToMap";

    /// <include file='WINTRUST.xml' path='doc/member[@name="WINTRUST.WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT"]/*' />
    [NativeTypeName("#define WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT 0x00A00000")]
    public const int WINTRUST_MAX_HEADER_BYTES_TO_MAP_DEFAULT = 0x00A00000;

    /// <include file='WINTRUST.xml' path='doc/member[@name="WINTRUST.WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME"]/*' />
    [NativeTypeName("#define WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME L\"MaxHashBytesToMap\"")]
    public const string WINTRUST_MAX_HASH_BYTES_TO_MAP_VALUE_NAME = "MaxHashBytesToMap";

    /// <include file='WINTRUST.xml' path='doc/member[@name="WINTRUST.WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT"]/*' />
    [NativeTypeName("#define WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT 0x00100000")]
    public const int WINTRUST_MAX_HASH_BYTES_TO_MAP_DEFAULT = 0x00100000;

    /// <include file='WINTRUST.xml' path='doc/member[@name="WINTRUST.WINTRUST_DETACHED_SIG_CHOICE_HANDLE"]/*' />
    [NativeTypeName("#define WINTRUST_DETACHED_SIG_CHOICE_HANDLE 1")]
    public const int WINTRUST_DETACHED_SIG_CHOICE_HANDLE = 1;

    /// <include file='WINTRUST.xml' path='doc/member[@name="WINTRUST.WINTRUST_DETACHED_SIG_CHOICE_BLOB"]/*' />
    [NativeTypeName("#define WINTRUST_DETACHED_SIG_CHOICE_BLOB 2")]
    public const int WINTRUST_DETACHED_SIG_CHOICE_BLOB = 2;
}
