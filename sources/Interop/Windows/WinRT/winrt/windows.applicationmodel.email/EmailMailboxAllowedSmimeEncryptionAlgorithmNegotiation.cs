// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation.xml' path='doc/member[@name="EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation"]/*' />
public enum EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation
{
    /// <include file='EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation.xml' path='doc/member[@name="EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation.EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation_None"]/*' />
    EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation_None = 0,

    /// <include file='EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation.xml' path='doc/member[@name="EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation.EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation_StrongAlgorithm"]/*' />
    EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation_StrongAlgorithm = 1,

    /// <include file='EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation.xml' path='doc/member[@name="EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation.EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation_AnyAlgorithm"]/*' />
    EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation_AnyAlgorithm = 2,
}
