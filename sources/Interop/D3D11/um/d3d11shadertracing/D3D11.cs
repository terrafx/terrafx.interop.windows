// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class D3D11
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D3DDisassemble11Trace", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3DDisassemble11Trace([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("ID3D11ShaderTrace *")] ID3D11ShaderTrace* pTrace, [NativeTypeName("UINT")] uint StartStep, [NativeTypeName("UINT")] uint NumSteps, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("struct ID3D10Blob **")] ID3DBlob** ppDisassembly);
    }
}
