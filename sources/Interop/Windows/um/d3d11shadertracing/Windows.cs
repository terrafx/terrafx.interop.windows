// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d11sdklayers", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassemble11Trace([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3D11ShaderTrace* pTrace, [NativeTypeName("UINT")] uint StartStep, [NativeTypeName("UINT")] uint NumSteps, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("struct ID3D10Blob **")] ID3DBlob** ppDisassembly);

        [NativeTypeName("#define D3D11_TRACE_COMPONENT_X 0x1")]
        public const int D3D11_TRACE_COMPONENT_X = 0x1;

        [NativeTypeName("#define D3D11_TRACE_COMPONENT_Y 0x2")]
        public const int D3D11_TRACE_COMPONENT_Y = 0x2;

        [NativeTypeName("#define D3D11_TRACE_COMPONENT_Z 0x4")]
        public const int D3D11_TRACE_COMPONENT_Z = 0x4;

        [NativeTypeName("#define D3D11_TRACE_COMPONENT_W 0x8")]
        public const int D3D11_TRACE_COMPONENT_W = 0x8;

        [NativeTypeName("#define D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_WRITES 0x1")]
        public const int D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_WRITES = 0x1;

        [NativeTypeName("#define D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_READS 0x2")]
        public const int D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_READS = 0x2;

        [NativeTypeName("#define D3D11_TRACE_REGISTER_FLAGS_RELATIVE_INDEXING 0x1")]
        public const int D3D11_TRACE_REGISTER_FLAGS_RELATIVE_INDEXING = 0x1;

        [NativeTypeName("#define D3D11_TRACE_MISC_GS_EMIT 0x1")]
        public const int D3D11_TRACE_MISC_GS_EMIT = 0x1;

        [NativeTypeName("#define D3D11_TRACE_MISC_GS_CUT 0x2")]
        public const int D3D11_TRACE_MISC_GS_CUT = 0x2;

        [NativeTypeName("#define D3D11_TRACE_MISC_PS_DISCARD 0x4")]
        public const int D3D11_TRACE_MISC_PS_DISCARD = 0x4;

        [NativeTypeName("#define D3D11_TRACE_MISC_GS_EMIT_STREAM 0x8")]
        public const int D3D11_TRACE_MISC_GS_EMIT_STREAM = 0x8;

        [NativeTypeName("#define D3D11_TRACE_MISC_GS_CUT_STREAM 0x10")]
        public const int D3D11_TRACE_MISC_GS_CUT_STREAM = 0x10;

        [NativeTypeName("#define D3D11_TRACE_MISC_HALT 0x20")]
        public const int D3D11_TRACE_MISC_HALT = 0x20;

        [NativeTypeName("#define D3D11_TRACE_MISC_MESSAGE 0x40")]
        public const int D3D11_TRACE_MISC_MESSAGE = 0x40;

        public static ref readonly Guid IID_ID3D11ShaderTrace
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x13, 0xB0, 0x36,
                    0x11, 0x28,
                    0x45, 0x48,
                    0xBA,
                    0xA7,
                    0xD6,
                    0x23,
                    0xFE,
                    0x0D,
                    0xF1,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID3D11ShaderTraceFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0xD4, 0xBA, 0x1F,
                    0xAB, 0x66,
                    0xCC, 0x41,
                    0x96,
                    0x17,
                    0x66,
                    0x7A,
                    0xC1,
                    0x0E,
                    0x44,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
