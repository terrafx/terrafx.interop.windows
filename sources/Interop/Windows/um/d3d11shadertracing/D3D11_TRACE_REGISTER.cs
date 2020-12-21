// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_TRACE_REGISTER
    {
        public D3D11_TRACE_REGISTER_TYPE RegType;

        [NativeTypeName("D3D11_TRACE_REGISTER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11shadertracing.h:226:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref ushort Index1D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Index1D, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Index1D;
#endif
            }
        }

        public unsafe Span<ushort> Index2D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref Anonymous.Index2D[0], 2);
#else
                return new Span<ushort>(((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Index2D, 2);
#endif
            }
        }

        [NativeTypeName("UINT8")]
        public byte OperandIndex;

        [NativeTypeName("UINT8")]
        public byte Flags;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT16")]
            public ushort Index1D;

            [FieldOffset(0)]
            [NativeTypeName("UINT16 [2]")]
            public fixed ushort Index2D[2];
        }
    }
}
