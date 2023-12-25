// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProtectionCapabilityResult.xml' path='doc/member[@name="ProtectionCapabilityResult"]/*' />
public enum ProtectionCapabilityResult
{
    /// <include file='ProtectionCapabilityResult.xml' path='doc/member[@name="ProtectionCapabilityResult.ProtectionCapabilityResult_NotSupported"]/*' />
    ProtectionCapabilityResult_NotSupported = 0,

    /// <include file='ProtectionCapabilityResult.xml' path='doc/member[@name="ProtectionCapabilityResult.ProtectionCapabilityResult_Maybe"]/*' />
    ProtectionCapabilityResult_Maybe = 1,

    /// <include file='ProtectionCapabilityResult.xml' path='doc/member[@name="ProtectionCapabilityResult.ProtectionCapabilityResult_Probably"]/*' />
    ProtectionCapabilityResult_Probably = 2,
}
