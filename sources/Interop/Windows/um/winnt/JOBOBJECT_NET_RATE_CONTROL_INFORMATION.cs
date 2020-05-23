// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct JOBOBJECT_NET_RATE_CONTROL_INFORMATION
    {
        [NativeTypeName("DWORD64")]
        public ulong MaxBandwidth;

        public JOB_OBJECT_NET_RATE_CONTROL_FLAGS ControlFlags;

        [NativeTypeName("BYTE")]
        public byte DscpTag;
    }
}
