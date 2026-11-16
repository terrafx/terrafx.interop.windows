// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CLAIM
{
    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID 0x00")]
    public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID = 0x00;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 0x01")]
    public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 = 0x01;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 0x02")]
    public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 = 0x02;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING 0x03")]
    public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING = 0x03;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN 0x04")]
    public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN = 0x04;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_TYPE_SID"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_SID 0x05")]
    public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_SID = 0x05;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN 0x06")]
    public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = 0x06;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING 0x10")]
    public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = 0x10;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE 0x0001")]
    public const int CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE = 0x0001;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE 0x0002")]
    public const int CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = 0x0002;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY 0x0004")]
    public const int CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY = 0x0004;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT 0x0008")]
    public const int CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT = 0x0008;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_DISABLED"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_DISABLED 0x0010")]
    public const int CLAIM_SECURITY_ATTRIBUTE_DISABLED = 0x0010;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_MANDATORY"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_MANDATORY 0x0020")]
    public const int CLAIM_SECURITY_ATTRIBUTE_MANDATORY = 0x0020;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS (    \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE       |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE  |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY     |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT   |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_DISABLED              |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_MANDATORY )")]
    public const int CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS = (0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010 | 0x0020);

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS 0xFFFF0000")]
    public const uint CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS = 0xFFFF0000;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 1")]
    public const int CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 = 1;

    /// <include file='CLAIM.xml' path='doc/member[@name="CLAIM.CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION"]/*' />
    [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1")]
    public const int CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION = 1;
}
