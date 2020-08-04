// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SET_PARTITION_INFORMATION_EX
    {
        public PARTITION_STYLE PartitionStyle;

        [NativeTypeName("_SET_PARTITION_INFORMATION_EX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8432:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref SET_PARTITION_INFORMATION Mbr => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Mbr, 1));

        public ref PARTITION_INFORMATION_GPT Gpt => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Gpt, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("SET_PARTITION_INFORMATION_MBR")]
            public SET_PARTITION_INFORMATION Mbr;

            [FieldOffset(0)]
            [NativeTypeName("SET_PARTITION_INFORMATION_GPT")]
            public PARTITION_INFORMATION_GPT Gpt;
        }
    }
}
