// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CREATE_DISK
    {
        public PARTITION_STYLE PartitionStyle;

        [NativeTypeName("_CREATE_DISK::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8461:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref CREATE_DISK_MBR Mbr => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Mbr, 1));

        public ref CREATE_DISK_GPT Gpt => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Gpt, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public CREATE_DISK_MBR Mbr;

            [FieldOffset(0)]
            public CREATE_DISK_GPT Gpt;
        }
    }
}
