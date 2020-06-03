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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12Tools*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Tools*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12Tools*, uint>)(lpVtbl[1]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12Tools*, uint>)(lpVtbl[2]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }

        public void EnableShaderInstrumentation([NativeTypeName("BOOL")] int bEnable)
        {
            ((delegate* stdcall<ID3D12Tools*, int, void>)(lpVtbl[3]))((ID3D12Tools*)Unsafe.AsPointer(ref this), bEnable);
        }

        [return: NativeTypeName("BOOL")]
        public int ShaderInstrumentationEnabled()
        {
            return ((delegate* stdcall<ID3D12Tools*, int>)(lpVtbl[4]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
        }
    }
}
