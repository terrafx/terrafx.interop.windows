// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct KTMOBJECT_CURSOR
    {
        [NativeTypeName("GUID")]
        public Guid LastQuery;

        [NativeTypeName("DWORD")]
        public uint ObjectIdCount;

        [NativeTypeName("GUID [1]")]
        public _ObjectIds_e__FixedBuffer ObjectIds;

        public partial struct _ObjectIds_e__FixedBuffer
        {
            public Guid e0;

            public unsafe ref Guid this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<Guid> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<Guid>((Guid*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
