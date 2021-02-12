// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PARTITION_INFORMATION_EX
    {
        public PARTITION_STYLE PartitionStyle;

        public LARGE_INTEGER StartingOffset;

        public LARGE_INTEGER PartitionLength;

        [NativeTypeName("DWORD")]
        public uint PartitionNumber;

        [NativeTypeName("BOOLEAN")]
        public byte RewritePartition;

        [NativeTypeName("BOOLEAN")]
        public byte IsServicePartition;

        [NativeTypeName("_PARTITION_INFORMATION_EX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8506:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref PARTITION_INFORMATION_MBR Mbr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Mbr, 1));
            }
        }

        public ref PARTITION_INFORMATION_GPT Gpt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Gpt, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public PARTITION_INFORMATION_MBR Mbr;

            [FieldOffset(0)]
            public PARTITION_INFORMATION_GPT Gpt;
        }
    }
}
