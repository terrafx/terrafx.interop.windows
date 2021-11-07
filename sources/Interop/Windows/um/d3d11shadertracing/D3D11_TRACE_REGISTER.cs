// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public unsafe partial struct D3D11_TRACE_REGISTER
    {
        public D3D11_TRACE_REGISTER_TYPE RegType;

        [NativeTypeName("D3D11_TRACE_REGISTER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/d3d11shadertracing.h:234:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT8")]
        public byte OperandIndex;

        [NativeTypeName("UINT8")]
        public byte Flags;

        public ref ushort Index1D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Index1D, 1));
            }
        }

        public Span<ushort> Index2D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.Index2D[0], 2);
            }
        }

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
