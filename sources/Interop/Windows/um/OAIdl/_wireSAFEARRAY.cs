// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct _wireSAFEARRAY
    {
        [NativeTypeName("USHORT")]
        public ushort cDims;

        [NativeTypeName("USHORT")]
        public ushort fFeatures;

        [NativeTypeName("ULONG")]
        public uint cbElements;

        [NativeTypeName("ULONG")]
        public uint cLocks;

        [NativeTypeName("SAFEARRAYUNION")]
        public _wireSAFEARRAY_UNION uArrayStructs;

        [NativeTypeName("SAFEARRAYBOUND [1]")]
        public _rgsabound_e__FixedBuffer rgsabound;

        public partial struct _rgsabound_e__FixedBuffer
        {
            internal SAFEARRAYBOUND e0;

            public ref SAFEARRAYBOUND this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<SAFEARRAYBOUND> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
