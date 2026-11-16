// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class TIMESTAMP
{
    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_REQUEST"]/*' />
    [NativeTypeName("#define TIMESTAMP_REQUEST ((LPCSTR) 78)")]
    public static sbyte* TIMESTAMP_REQUEST => ((sbyte*)(78));

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_RESPONSE"]/*' />
    [NativeTypeName("#define TIMESTAMP_RESPONSE ((LPCSTR) 79)")]
    public static sbyte* TIMESTAMP_RESPONSE => ((sbyte*)(79));

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_INFO"]/*' />
    [NativeTypeName("#define TIMESTAMP_INFO ((LPCSTR) 80)")]
    public static sbyte* TIMESTAMP_INFO => ((sbyte*)(80));

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_VERSION"]/*' />
    [NativeTypeName("#define TIMESTAMP_VERSION 1")]
    public const int TIMESTAMP_VERSION = 1;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_STATUS_GRANTED"]/*' />
    [NativeTypeName("#define TIMESTAMP_STATUS_GRANTED 0")]
    public const int TIMESTAMP_STATUS_GRANTED = 0;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_STATUS_GRANTED_WITH_MODS"]/*' />
    [NativeTypeName("#define TIMESTAMP_STATUS_GRANTED_WITH_MODS 1")]
    public const int TIMESTAMP_STATUS_GRANTED_WITH_MODS = 1;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_STATUS_REJECTED"]/*' />
    [NativeTypeName("#define TIMESTAMP_STATUS_REJECTED 2")]
    public const int TIMESTAMP_STATUS_REJECTED = 2;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_STATUS_WAITING"]/*' />
    [NativeTypeName("#define TIMESTAMP_STATUS_WAITING 3")]
    public const int TIMESTAMP_STATUS_WAITING = 3;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_STATUS_REVOCATION_WARNING"]/*' />
    [NativeTypeName("#define TIMESTAMP_STATUS_REVOCATION_WARNING 4")]
    public const int TIMESTAMP_STATUS_REVOCATION_WARNING = 4;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_STATUS_REVOKED"]/*' />
    [NativeTypeName("#define TIMESTAMP_STATUS_REVOKED 5")]
    public const int TIMESTAMP_STATUS_REVOKED = 5;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_FAILURE_BAD_ALG"]/*' />
    [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_ALG 0")]
    public const int TIMESTAMP_FAILURE_BAD_ALG = 0;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_FAILURE_BAD_REQUEST"]/*' />
    [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_REQUEST 2")]
    public const int TIMESTAMP_FAILURE_BAD_REQUEST = 2;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_FAILURE_BAD_FORMAT"]/*' />
    [NativeTypeName("#define TIMESTAMP_FAILURE_BAD_FORMAT 5")]
    public const int TIMESTAMP_FAILURE_BAD_FORMAT = 5;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_FAILURE_TIME_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define TIMESTAMP_FAILURE_TIME_NOT_AVAILABLE 14")]
    public const int TIMESTAMP_FAILURE_TIME_NOT_AVAILABLE = 14;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_FAILURE_POLICY_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TIMESTAMP_FAILURE_POLICY_NOT_SUPPORTED 15")]
    public const int TIMESTAMP_FAILURE_POLICY_NOT_SUPPORTED = 15;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_FAILURE_EXTENSION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define TIMESTAMP_FAILURE_EXTENSION_NOT_SUPPORTED 16")]
    public const int TIMESTAMP_FAILURE_EXTENSION_NOT_SUPPORTED = 16;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_FAILURE_INFO_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define TIMESTAMP_FAILURE_INFO_NOT_AVAILABLE 17")]
    public const int TIMESTAMP_FAILURE_INFO_NOT_AVAILABLE = 17;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_FAILURE_SYSTEM_FAILURE"]/*' />
    [NativeTypeName("#define TIMESTAMP_FAILURE_SYSTEM_FAILURE 25")]
    public const int TIMESTAMP_FAILURE_SYSTEM_FAILURE = 25;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_DONT_HASH_DATA"]/*' />
    [NativeTypeName("#define TIMESTAMP_DONT_HASH_DATA 0x00000001")]
    public const int TIMESTAMP_DONT_HASH_DATA = 0x00000001;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_VERIFY_CONTEXT_SIGNATURE"]/*' />
    [NativeTypeName("#define TIMESTAMP_VERIFY_CONTEXT_SIGNATURE 0x00000020")]
    public const int TIMESTAMP_VERIFY_CONTEXT_SIGNATURE = 0x00000020;

    /// <include file='TIMESTAMP.xml' path='doc/member[@name="TIMESTAMP.TIMESTAMP_NO_AUTH_RETRIEVAL"]/*' />
    [NativeTypeName("#define TIMESTAMP_NO_AUTH_RETRIEVAL 0x00020000")]
    public const int TIMESTAMP_NO_AUTH_RETRIEVAL = 0x00020000;
}
