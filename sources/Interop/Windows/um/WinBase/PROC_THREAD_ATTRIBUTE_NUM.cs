// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PROC_THREAD_ATTRIBUTE_NUM
    {
        ProcThreadAttributeParentProcess = 0,
        ProcThreadAttributeHandleList = 2,
        ProcThreadAttributeGroupAffinity = 3,
        ProcThreadAttributePreferredNode = 4,
        ProcThreadAttributeIdealProcessor = 5,
        ProcThreadAttributeUmsThread = 6,
        ProcThreadAttributeMitigationPolicy = 7,
        ProcThreadAttributeSecurityCapabilities = 9,
        ProcThreadAttributeProtectionLevel = 11,
        ProcThreadAttributeJobList = 13,
        ProcThreadAttributeChildProcessPolicy = 14,
        ProcThreadAttributeAllApplicationPackagesPolicy = 15,
        ProcThreadAttributeWin32kFilter = 16,
        ProcThreadAttributeSafeOpenPromptOriginClaim = 17,
        ProcThreadAttributeDesktopAppPolicy = 18,
        ProcThreadAttributePseudoConsole = 22,
        ProcThreadAttributeMitigationAuditPolicy = 24,
    }
}
