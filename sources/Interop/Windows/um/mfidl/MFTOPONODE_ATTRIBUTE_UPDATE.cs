// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
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

        public Guid guidAttributeKey;

        public MF_ATTRIBUTE_TYPE attrType;

        [NativeTypeName("_MFTOPONODE_ATTRIBUTE_UPDATE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mfidl.h:11434:36)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint u32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.u32, 1));
            }
        }

        public ref ulong u64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.u64, 1));
            }
        }

        public ref double d
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.d, 1));
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
