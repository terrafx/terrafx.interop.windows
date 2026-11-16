// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PER_USER
{
    /// <include file='PER_USER.xml' path='doc/member[@name="PER_USER.PER_USER_POLICY_UNCHANGED"]/*' />
    [NativeTypeName("#define PER_USER_POLICY_UNCHANGED (0x00)")]
    public const int PER_USER_POLICY_UNCHANGED = (0x00);

    /// <include file='PER_USER.xml' path='doc/member[@name="PER_USER.PER_USER_AUDIT_SUCCESS_INCLUDE"]/*' />
    [NativeTypeName("#define PER_USER_AUDIT_SUCCESS_INCLUDE (0x01)")]
    public const int PER_USER_AUDIT_SUCCESS_INCLUDE = (0x01);

    /// <include file='PER_USER.xml' path='doc/member[@name="PER_USER.PER_USER_AUDIT_SUCCESS_EXCLUDE"]/*' />
    [NativeTypeName("#define PER_USER_AUDIT_SUCCESS_EXCLUDE (0x02)")]
    public const int PER_USER_AUDIT_SUCCESS_EXCLUDE = (0x02);

    /// <include file='PER_USER.xml' path='doc/member[@name="PER_USER.PER_USER_AUDIT_FAILURE_INCLUDE"]/*' />
    [NativeTypeName("#define PER_USER_AUDIT_FAILURE_INCLUDE (0x04)")]
    public const int PER_USER_AUDIT_FAILURE_INCLUDE = (0x04);

    /// <include file='PER_USER.xml' path='doc/member[@name="PER_USER.PER_USER_AUDIT_FAILURE_EXCLUDE"]/*' />
    [NativeTypeName("#define PER_USER_AUDIT_FAILURE_EXCLUDE (0x08)")]
    public const int PER_USER_AUDIT_FAILURE_EXCLUDE = (0x08);

    /// <include file='PER_USER.xml' path='doc/member[@name="PER_USER.PER_USER_AUDIT_NONE"]/*' />
    [NativeTypeName("#define PER_USER_AUDIT_NONE (0x10)")]
    public const int PER_USER_AUDIT_NONE = (0x10);
}
