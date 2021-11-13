// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct PPM_PERFSTATE_DOMAIN_EVENT
    {
        [NativeTypeName("DWORD")]
        public uint State;

        [NativeTypeName("DWORD")]
        public uint Latency;

        [NativeTypeName("DWORD")]
        public uint Speed;

        [NativeTypeName("DWORD64")]
        public ulong Processors;
    }
}
