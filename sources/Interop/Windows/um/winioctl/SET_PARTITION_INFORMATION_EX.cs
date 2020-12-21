// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SET_PARTITION_INFORMATION_EX
    {
        public PARTITION_STYLE PartitionStyle;

        [NativeTypeName("_SET_PARTITION_INFORMATION_EX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8432:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref SET_PARTITION_INFORMATION Mbr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Mbr, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Mbr;
#endif
            }
        }

        public unsafe ref PARTITION_INFORMATION_GPT Gpt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Gpt, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Gpt;
#endif
            }
        }

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
