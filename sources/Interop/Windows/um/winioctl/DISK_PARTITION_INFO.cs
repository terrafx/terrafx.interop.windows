// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISK_PARTITION_INFO
    {
        [NativeTypeName("DWORD")]
        public uint SizeOfPartitionInfo;

        public PARTITION_STYLE PartitionStyle;

        [NativeTypeName("_DISK_PARTITION_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8651:9)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref _Anonymous_e__Union._Mbr_e__Struct Mbr
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

        public unsafe ref _Anonymous_e__Union._Gpt_e__Struct Gpt
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
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8652:17)")]
            public _Mbr_e__Struct Mbr;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:8656:17)")]
            public _Gpt_e__Struct Gpt;

            public partial struct _Mbr_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint Signature;

                [NativeTypeName("DWORD")]
                public uint CheckSum;
            }

            public partial struct _Gpt_e__Struct
            {
                [NativeTypeName("GUID")]
                public Guid DiskId;
            }
        }
    }
}
