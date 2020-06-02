// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7071E1F0-E84B-4B33-974F-12FA49DE65C5")]
    public unsafe partial struct ID3D12Tools
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12Tools*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        public void EnableShaderInstrumentation([NativeTypeName("BOOL")] int bEnable)
        {
            lpVtbl->EnableShaderInstrumentation((ID3D12Tools*)Unsafe.AsPointer(ref this), bEnable);
        }

        [return: NativeTypeName("BOOL")]
        public int ShaderInstrumentationEnabled()
        {
            return lpVtbl->ShaderInstrumentationEnabled((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Tools*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Tools*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Tools*, uint> Release;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Tools*, int, void> EnableShaderInstrumentation;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Tools*, int> ShaderInstrumentationEnabled;
        }
    }
}
