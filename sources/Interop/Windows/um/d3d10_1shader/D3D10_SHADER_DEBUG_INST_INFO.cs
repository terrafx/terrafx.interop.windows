// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D10_SHADER_DEBUG_INST_INFO
    {
        [NativeTypeName("UINT")]
        public uint Id;

        [NativeTypeName("UINT")]
        public uint Opcode;

        [NativeTypeName("UINT")]
        public uint uOutputs;

        [NativeTypeName("D3D10_SHADER_DEBUG_OUTPUTREG_INFO [2]")]
        public _pOutputs_e__FixedBuffer pOutputs;

        [NativeTypeName("UINT")]
        public uint TokenId;

        [NativeTypeName("UINT")]
        public uint NestingLevel;

        [NativeTypeName("UINT")]
        public uint Scopes;

        [NativeTypeName("UINT")]
        public uint ScopeInfo;

        [NativeTypeName("UINT")]
        public uint AccessedVars;

        [NativeTypeName("UINT")]
        public uint AccessedVarsInfo;

        public partial struct _pOutputs_e__FixedBuffer
        {
            public D3D10_SHADER_DEBUG_OUTPUTREG_INFO e0;
            public D3D10_SHADER_DEBUG_OUTPUTREG_INFO e1;

            public ref D3D10_SHADER_DEBUG_OUTPUTREG_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<D3D10_SHADER_DEBUG_OUTPUTREG_INFO> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}
