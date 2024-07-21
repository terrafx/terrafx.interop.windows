// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ProtectionPolicyEvaluationResult.xml' path='doc/member[@name="ProtectionPolicyEvaluationResult"]/*' />
public enum ProtectionPolicyEvaluationResult
{
    /// <include file='ProtectionPolicyEvaluationResult.xml' path='doc/member[@name="ProtectionPolicyEvaluationResult.ProtectionPolicyEvaluationResult_Allowed"]/*' />
    ProtectionPolicyEvaluationResult_Allowed = 0,

    /// <include file='ProtectionPolicyEvaluationResult.xml' path='doc/member[@name="ProtectionPolicyEvaluationResult.ProtectionPolicyEvaluationResult_Blocked"]/*' />
    ProtectionPolicyEvaluationResult_Blocked = 1,

    /// <include file='ProtectionPolicyEvaluationResult.xml' path='doc/member[@name="ProtectionPolicyEvaluationResult.ProtectionPolicyEvaluationResult_ConsentRequired"]/*' />
    ProtectionPolicyEvaluationResult_ConsentRequired = 2,
}
