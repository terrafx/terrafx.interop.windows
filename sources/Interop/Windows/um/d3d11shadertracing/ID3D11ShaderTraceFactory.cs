// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1FBAD429-66AB-41CC-9617-667AC10E4459")]
    public unsafe partial struct ID3D11ShaderTraceFactory
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateShaderTrace([NativeTypeName("IUnknown *")] IUnknown* pShader, [NativeTypeName("D3D11_SHADER_TRACE_DESC *")] D3D11_SHADER_TRACE_DESC* pTraceDesc, [NativeTypeName("ID3D11ShaderTrace **")] ID3D11ShaderTrace** ppShaderTrace)
        {
            return lpVtbl->CreateShaderTrace((ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref this), pShader, pTraceDesc, ppShaderTrace);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTraceFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTraceFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTraceFactory*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, D3D11_SHADER_TRACE_DESC *, ID3D11ShaderTrace **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ShaderTraceFactory*, IUnknown*, D3D11_SHADER_TRACE_DESC*, ID3D11ShaderTrace**, int> CreateShaderTrace;
        }
    }
}
