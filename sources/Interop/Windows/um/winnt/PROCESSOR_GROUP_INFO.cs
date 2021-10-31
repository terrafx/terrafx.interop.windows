// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESSOR_GROUP_INFO
    {
        public byte MaximumProcessorCount;

        public byte ActiveProcessorCount;

        [NativeTypeName("BYTE [38]")]
        public fixed byte Reserved[38];

        [NativeTypeName("KAFFINITY")]
        public nuint ActiveProcessorMask;
    }
}
