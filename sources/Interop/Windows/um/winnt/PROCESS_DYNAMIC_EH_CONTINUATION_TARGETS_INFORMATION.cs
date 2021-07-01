// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESS_DYNAMIC_EH_CONTINUATION_TARGETS_INFORMATION
    {
        [NativeTypeName("WORD")]
        public ushort NumberOfTargets;

        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("DWORD")]
        public uint Reserved2;

        [NativeTypeName("PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET")]
        public PROCESS_DYNAMIC_EH_CONTINUATION_TARGET* Targets;
    }
}
