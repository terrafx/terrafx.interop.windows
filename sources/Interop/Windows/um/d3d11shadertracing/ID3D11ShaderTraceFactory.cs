// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1FBAD429-66AB-41CC-9617-667AC10E4459")]
    [NativeTypeName("struct ID3D11ShaderTraceFactory : IUnknown")]
    public unsafe partial struct ID3D11ShaderTraceFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11ShaderTraceFactory*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11ShaderTraceFactory*, uint>)(lpVtbl[1]))((ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11ShaderTraceFactory*, uint>)(lpVtbl[2]))((ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateShaderTrace(IUnknown* pShader, D3D11_SHADER_TRACE_DESC* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace)
        {
            return ((delegate* unmanaged<ID3D11ShaderTraceFactory*, IUnknown*, D3D11_SHADER_TRACE_DESC*, ID3D11ShaderTrace**, int>)(lpVtbl[3]))((ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref this), pShader, pTraceDesc, ppShaderTrace);
        }
    }
}
