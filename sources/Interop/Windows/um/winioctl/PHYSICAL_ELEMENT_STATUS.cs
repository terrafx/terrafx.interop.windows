// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PHYSICAL_ELEMENT_STATUS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint DescriptorCount;

        [NativeTypeName("DWORD")]
        public uint ReturnedDescriptorCount;

        [NativeTypeName("DWORD")]
        public uint ElementIdentifierBeingDepoped;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("PHYSICAL_ELEMENT_STATUS_DESCRIPTOR [1]")]
        public _Descriptors_e__FixedBuffer Descriptors;

        public partial struct _Descriptors_e__FixedBuffer
        {
            public PHYSICAL_ELEMENT_STATUS_DESCRIPTOR e0;

            public unsafe ref PHYSICAL_ELEMENT_STATUS_DESCRIPTOR this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<PHYSICAL_ELEMENT_STATUS_DESCRIPTOR> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<PHYSICAL_ELEMENT_STATUS_DESCRIPTOR>((PHYSICAL_ELEMENT_STATUS_DESCRIPTOR*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
