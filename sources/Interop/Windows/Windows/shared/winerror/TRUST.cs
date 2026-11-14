// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TRUST
{
    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_SYSTEM_ERROR"]/*' />
    [NativeTypeName("#define TRUST_E_SYSTEM_ERROR _HRESULT_TYPEDEF_(0x80096001L)")]
    public const int TRUST_E_SYSTEM_ERROR = unchecked((int)(0x80096001));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_NO_SIGNER_CERT"]/*' />
    [NativeTypeName("#define TRUST_E_NO_SIGNER_CERT _HRESULT_TYPEDEF_(0x80096002L)")]
    public const int TRUST_E_NO_SIGNER_CERT = unchecked((int)(0x80096002));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_COUNTER_SIGNER"]/*' />
    [NativeTypeName("#define TRUST_E_COUNTER_SIGNER _HRESULT_TYPEDEF_(0x80096003L)")]
    public const int TRUST_E_COUNTER_SIGNER = unchecked((int)(0x80096003));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_CERT_SIGNATURE"]/*' />
    [NativeTypeName("#define TRUST_E_CERT_SIGNATURE _HRESULT_TYPEDEF_(0x80096004L)")]
    public const int TRUST_E_CERT_SIGNATURE = unchecked((int)(0x80096004));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_TIME_STAMP"]/*' />
    [NativeTypeName("#define TRUST_E_TIME_STAMP _HRESULT_TYPEDEF_(0x80096005L)")]
    public const int TRUST_E_TIME_STAMP = unchecked((int)(0x80096005));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_BAD_DIGEST"]/*' />
    [NativeTypeName("#define TRUST_E_BAD_DIGEST _HRESULT_TYPEDEF_(0x80096010L)")]
    public const int TRUST_E_BAD_DIGEST = unchecked((int)(0x80096010));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_MALFORMED_SIGNATURE"]/*' />
    [NativeTypeName("#define TRUST_E_MALFORMED_SIGNATURE _HRESULT_TYPEDEF_(0x80096011L)")]
    public const int TRUST_E_MALFORMED_SIGNATURE = unchecked((int)(0x80096011));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_BASIC_CONSTRAINTS"]/*' />
    [NativeTypeName("#define TRUST_E_BASIC_CONSTRAINTS _HRESULT_TYPEDEF_(0x80096019L)")]
    public const int TRUST_E_BASIC_CONSTRAINTS = unchecked((int)(0x80096019));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_FINANCIAL_CRITERIA"]/*' />
    [NativeTypeName("#define TRUST_E_FINANCIAL_CRITERIA _HRESULT_TYPEDEF_(0x8009601EL)")]
    public const int TRUST_E_FINANCIAL_CRITERIA = unchecked((int)(0x8009601E));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_PROVIDER_UNKNOWN"]/*' />
    [NativeTypeName("#define TRUST_E_PROVIDER_UNKNOWN _HRESULT_TYPEDEF_(0x800B0001L)")]
    public const int TRUST_E_PROVIDER_UNKNOWN = unchecked((int)(0x800B0001));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_ACTION_UNKNOWN"]/*' />
    [NativeTypeName("#define TRUST_E_ACTION_UNKNOWN _HRESULT_TYPEDEF_(0x800B0002L)")]
    public const int TRUST_E_ACTION_UNKNOWN = unchecked((int)(0x800B0002));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_SUBJECT_FORM_UNKNOWN"]/*' />
    [NativeTypeName("#define TRUST_E_SUBJECT_FORM_UNKNOWN _HRESULT_TYPEDEF_(0x800B0003L)")]
    public const int TRUST_E_SUBJECT_FORM_UNKNOWN = unchecked((int)(0x800B0003));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_SUBJECT_NOT_TRUSTED"]/*' />
    [NativeTypeName("#define TRUST_E_SUBJECT_NOT_TRUSTED _HRESULT_TYPEDEF_(0x800B0004L)")]
    public const int TRUST_E_SUBJECT_NOT_TRUSTED = unchecked((int)(0x800B0004));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_NOSIGNATURE"]/*' />
    [NativeTypeName("#define TRUST_E_NOSIGNATURE _HRESULT_TYPEDEF_(0x800B0100L)")]
    public const int TRUST_E_NOSIGNATURE = unchecked((int)(0x800B0100));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_FAIL"]/*' />
    [NativeTypeName("#define TRUST_E_FAIL _HRESULT_TYPEDEF_(0x800B010BL)")]
    public const int TRUST_E_FAIL = unchecked((int)(0x800B010B));

    /// <include file='TRUST.xml' path='doc/member[@name="TRUST.TRUST_E_EXPLICIT_DISTRUST"]/*' />
    [NativeTypeName("#define TRUST_E_EXPLICIT_DISTRUST _HRESULT_TYPEDEF_(0x800B0111L)")]
    public const int TRUST_E_EXPLICIT_DISTRUST = unchecked((int)(0x800B0111));
}
