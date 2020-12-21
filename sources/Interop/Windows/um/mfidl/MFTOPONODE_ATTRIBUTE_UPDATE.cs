// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MFTOPONODE_ATTRIBUTE_UPDATE
    {
        [NativeTypeName("TOPOID")]
        public ulong NodeId;

        [NativeTypeName("GUID")]
        public Guid guidAttributeKey;

        public MF_ATTRIBUTE_TYPE attrType;

        [NativeTypeName("_MFTOPONODE_ATTRIBUTE_UPDATE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mfidl.h:10826:36)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint u32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.u32, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->u32;
#endif
            }
        }

        public unsafe ref ulong u64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.u64, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->u64;
#endif
            }
        }

        public unsafe ref double d
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.d, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->d;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint u32;

            [FieldOffset(0)]
            [NativeTypeName("UINT64")]
            public ulong u64;

            [FieldOffset(0)]
            public double d;
        }
    }
}
