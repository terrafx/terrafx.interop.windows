// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardActivationPolicyChangeResult.xml' path='doc/member[@name="SmartCardActivationPolicyChangeResult"]/*' />
public enum SmartCardActivationPolicyChangeResult
{
    /// <include file='SmartCardActivationPolicyChangeResult.xml' path='doc/member[@name="SmartCardActivationPolicyChangeResult.SmartCardActivationPolicyChangeResult_Denied"]/*' />
    SmartCardActivationPolicyChangeResult_Denied = 0,

    /// <include file='SmartCardActivationPolicyChangeResult.xml' path='doc/member[@name="SmartCardActivationPolicyChangeResult.SmartCardActivationPolicyChangeResult_Allowed"]/*' />
    SmartCardActivationPolicyChangeResult_Allowed = 1,
}
