// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
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

            public ref Guid this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<Guid> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
