// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Capi1KdfTargetAlgorithm.xml' path='doc/member[@name="Capi1KdfTargetAlgorithm"]/*' />
public enum Capi1KdfTargetAlgorithm
{
    /// <include file='Capi1KdfTargetAlgorithm.xml' path='doc/member[@name="Capi1KdfTargetAlgorithm.Capi1KdfTargetAlgorithm_NotAes"]/*' />
    Capi1KdfTargetAlgorithm_NotAes = 0,

    /// <include file='Capi1KdfTargetAlgorithm.xml' path='doc/member[@name="Capi1KdfTargetAlgorithm.Capi1KdfTargetAlgorithm_Aes"]/*' />
    Capi1KdfTargetAlgorithm_Aes = 1,
}
