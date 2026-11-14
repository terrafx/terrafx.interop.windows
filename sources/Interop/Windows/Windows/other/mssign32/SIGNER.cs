// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

public static partial class SIGNER
{
    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_SUBJECT_FILE"]/*' />
    [NativeTypeName("#define SIGNER_SUBJECT_FILE 0x01")]
    public const int SIGNER_SUBJECT_FILE = 0x01;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_SUBJECT_BLOB"]/*' />
    [NativeTypeName("#define SIGNER_SUBJECT_BLOB 0x02")]
    public const int SIGNER_SUBJECT_BLOB = 0x02;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_NO_ATTR"]/*' />
    [NativeTypeName("#define SIGNER_NO_ATTR 0x00")]
    public const int SIGNER_NO_ATTR = 0x00;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_AUTHCODE_ATTR"]/*' />
    [NativeTypeName("#define SIGNER_AUTHCODE_ATTR 0x01")]
    public const int SIGNER_AUTHCODE_ATTR = 0x01;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_CERT_POLICY_STORE"]/*' />
    [NativeTypeName("#define SIGNER_CERT_POLICY_STORE 0x01")]
    public const int SIGNER_CERT_POLICY_STORE = 0x01;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_CERT_POLICY_CHAIN"]/*' />
    [NativeTypeName("#define SIGNER_CERT_POLICY_CHAIN 0x02")]
    public const int SIGNER_CERT_POLICY_CHAIN = 0x02;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_CERT_POLICY_SPC"]/*' />
    [NativeTypeName("#define SIGNER_CERT_POLICY_SPC 0x04")]
    public const int SIGNER_CERT_POLICY_SPC = 0x04;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_CERT_POLICY_CHAIN_NO_ROOT"]/*' />
    [NativeTypeName("#define SIGNER_CERT_POLICY_CHAIN_NO_ROOT 0x08")]
    public const int SIGNER_CERT_POLICY_CHAIN_NO_ROOT = 0x08;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_CERT_SPC_FILE"]/*' />
    [NativeTypeName("#define SIGNER_CERT_SPC_FILE 0x01")]
    public const int SIGNER_CERT_SPC_FILE = 0x01;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_CERT_STORE"]/*' />
    [NativeTypeName("#define SIGNER_CERT_STORE 0x02")]
    public const int SIGNER_CERT_STORE = 0x02;

    /// <include file='SIGNER.xml' path='doc/member[@name="SIGNER.SIGNER_CERT_SPC_CHAIN"]/*' />
    [NativeTypeName("#define SIGNER_CERT_SPC_CHAIN 0x03")]
    public const int SIGNER_CERT_SPC_CHAIN = 0x03;
}
