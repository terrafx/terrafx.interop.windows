// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct STRRET
    {
        public uint uType;

        [NativeTypeName("_STRRET::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/shtypes.h:285:36)")]
        public _Anonymous_e__Union Anonymous;

        public ref ushort* pOleStr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pOleStr;
            }
        }

        public ref uint uOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.uOffset, 1));
            }
        }

        public Span<sbyte> cStr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.cStr[0], 260);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pOleStr;

            [FieldOffset(0)]
            public uint uOffset;

            [FieldOffset(0)]
            [NativeTypeName("char [260]")]
            public fixed sbyte cStr[260];
        }
    }
}
