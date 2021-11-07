// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public unsafe partial struct SECURITY_CAPABILITIES
    {
        [NativeTypeName("PSID")]
        public void* AppContainerSid;

        [NativeTypeName("PSID_AND_ATTRIBUTES")]
        public SID_AND_ATTRIBUTES* Capabilities;

        [NativeTypeName("DWORD")]
        public uint CapabilityCount;

        [NativeTypeName("DWORD")]
        public uint Reserved;
    }
}
