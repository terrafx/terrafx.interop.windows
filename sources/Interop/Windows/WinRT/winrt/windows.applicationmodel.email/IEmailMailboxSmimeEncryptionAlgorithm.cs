// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeEncryptionAlgorithm"]/*' />
public enum IEmailMailboxSmimeEncryptionAlgorithm
{
    /// <include file='IEmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_Any"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_Any = 0,

    /// <include file='IEmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_TripleDes"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_TripleDes = 1,

    /// <include file='IEmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_Des"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_Des = 2,

    /// <include file='IEmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_RC2128Bit"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_RC2128Bit = 3,

    /// <include file='IEmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_RC264Bit"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_RC264Bit = 4,

    /// <include file='IEmailMailboxSmimeEncryptionAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeEncryptionAlgorithm.EmailMailboxSmimeEncryptionAlgorithm_RC240Bit"]/*' />
    EmailMailboxSmimeEncryptionAlgorithm_RC240Bit = 5,
}
