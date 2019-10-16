// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct ARRAYDESC
    {
        public TYPEDESC tdescElem;

        [NativeTypeName("USHORT")]
        public ushort cDims;

        [NativeTypeName("SAFEARRAYBOUND[1]")]
        public _rgbounds_e__FixedBuffer rgbounds;

        public unsafe partial struct _rgbounds_e__FixedBuffer
        {
            public SAFEARRAYBOUND e0;

            public ref SAFEARRAYBOUND this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<SAFEARRAYBOUND> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
