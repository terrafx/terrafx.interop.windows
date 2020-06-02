// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BDB64DF4-EA2F-4C70-B861-AAAB1258BB5D")]
    public unsafe partial struct ID3D11On12Device1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11On12Device1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11On12Device1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWrappedResource([NativeTypeName("IUnknown *")] IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppResource11)
        {
            return lpVtbl->CreateWrappedResource((ID3D11On12Device1*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
        }

        public void ReleaseWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            lpVtbl->ReleaseWrappedResources((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        public void AcquireWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            lpVtbl->AcquireWrappedResources((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return lpVtbl->GetD3D12Device((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11On12Device1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11On12Device1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11On12Device1*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, const D3D11_RESOURCE_FLAGS *, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11On12Device1*, IUnknown*, D3D11_RESOURCE_FLAGS*, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, Guid*, void**, int> CreateWrappedResource;

            [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11On12Device1*, ID3D11Resource**, uint, void> ReleaseWrappedResources;

            [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11On12Device1*, ID3D11Resource**, uint, void> AcquireWrappedResources;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11On12Device1*, Guid*, void**, int> GetD3D12Device;
        }
    }
}
