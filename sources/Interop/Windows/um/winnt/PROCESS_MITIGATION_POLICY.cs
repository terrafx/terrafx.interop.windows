// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PROCESS_MITIGATION_POLICY
    {
        ProcessDEPPolicy,
        ProcessASLRPolicy,
        ProcessDynamicCodePolicy,
        ProcessStrictHandleCheckPolicy,
        ProcessSystemCallDisablePolicy,
        ProcessMitigationOptionsMask,
        ProcessExtensionPointDisablePolicy,
        ProcessControlFlowGuardPolicy,
        ProcessSignaturePolicy,
        ProcessFontDisablePolicy,
        ProcessImageLoadPolicy,
        ProcessSystemCallFilterPolicy,
        ProcessPayloadRestrictionPolicy,
        ProcessChildProcessPolicy,
        ProcessSideChannelIsolationPolicy,
        ProcessUserShadowStackPolicy,
        ProcessRedirectionTrustPolicy,
        MaxProcessMitigationPolicy,
    }
}
