// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D10_SHADER_DEBUG_OUTPUTREG_INFO
    {
        public D3D10_SHADER_DEBUG_REGTYPE OutputRegisterSet;

        [NativeTypeName("UINT")]
        public uint OutputReg;

        [NativeTypeName("UINT")]
        public uint TempArrayReg;

        [NativeTypeName("UINT [4]")]
        public fixed uint OutputComponents[4];

        [NativeTypeName("D3D10_SHADER_DEBUG_OUTPUTVAR [4]")]
        public _OutputVars_e__FixedBuffer OutputVars;

        [NativeTypeName("UINT")]
        public uint IndexReg;

        [NativeTypeName("UINT")]
        public uint IndexComp;

        public partial struct _OutputVars_e__FixedBuffer
        {
            public D3D10_SHADER_DEBUG_OUTPUTVAR e0;
            public D3D10_SHADER_DEBUG_OUTPUTVAR e1;
            public D3D10_SHADER_DEBUG_OUTPUTVAR e2;
            public D3D10_SHADER_DEBUG_OUTPUTVAR e3;

            public ref D3D10_SHADER_DEBUG_OUTPUTVAR this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3D10_SHADER_DEBUG_OUTPUTVAR> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
        }
    }
}
