// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public unsafe partial struct REPAIR_COPIES_INPUT
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        public LARGE_INTEGER FileOffset;

        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("DWORD")]
        public uint SourceCopy;

        [NativeTypeName("DWORD")]
        public uint NumberOfRepairCopies;

        [NativeTypeName("DWORD [1]")]
        public fixed uint RepairCopies[1];
    }
}
