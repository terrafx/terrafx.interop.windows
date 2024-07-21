// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProtectionPolicyRequestAccessBehavior.xml' path='doc/member[@name="ProtectionPolicyRequestAccessBehavior"]/*' />
public enum ProtectionPolicyRequestAccessBehavior
{
    /// <include file='ProtectionPolicyRequestAccessBehavior.xml' path='doc/member[@name="ProtectionPolicyRequestAccessBehavior.ProtectionPolicyRequestAccessBehavior_Decrypt"]/*' />
    ProtectionPolicyRequestAccessBehavior_Decrypt = 0,

    /// <include file='ProtectionPolicyRequestAccessBehavior.xml' path='doc/member[@name="ProtectionPolicyRequestAccessBehavior.ProtectionPolicyRequestAccessBehavior_TreatOverridePolicyAsBlock"]/*' />
    ProtectionPolicyRequestAccessBehavior_TreatOverridePolicyAsBlock = 1,
}
