// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC90F331-4740-43FA-866E-67F12CB58223")]
    [NativeTypeName("struct ID3D11On12Device2 : ID3D11On12Device1")]
    public unsafe partial struct ID3D11On12Device2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11On12Device2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11On12Device2*, uint>)(lpVtbl[1]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11On12Device2*, uint>)(lpVtbl[2]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWrappedResource([NativeTypeName("IUnknown *")] IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppResource11)
        {
            return ((delegate* stdcall<ID3D11On12Device2*, IUnknown*, D3D11_RESOURCE_FLAGS*, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, Guid*, void**, int>)(lpVtbl[3]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
        }

        public void ReleaseWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            ((delegate* stdcall<ID3D11On12Device2*, ID3D11Resource**, uint, void>)(lpVtbl[4]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        public void AcquireWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            ((delegate* stdcall<ID3D11On12Device2*, ID3D11Resource**, uint, void>)(lpVtbl[5]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* stdcall<ID3D11On12Device2*, Guid*, void**, int>)(lpVtbl[6]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnwrapUnderlyingResource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource11, [NativeTypeName("ID3D12CommandQueue *")] ID3D12CommandQueue* pCommandQueue, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvResource12)
        {
            return ((delegate* stdcall<ID3D11On12Device2*, ID3D11Resource*, ID3D12CommandQueue*, Guid*, void**, int>)(lpVtbl[7]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), pResource11, pCommandQueue, riid, ppvResource12);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReturnUnderlyingResource([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource11, [NativeTypeName("UINT")] uint NumSync, [NativeTypeName("UINT64 *")] ulong* pSignalValues, [NativeTypeName("ID3D12Fence **")] ID3D12Fence** ppFences)
        {
            return ((delegate* stdcall<ID3D11On12Device2*, ID3D11Resource*, uint, ulong*, ID3D12Fence**, int>)(lpVtbl[8]))((ID3D11On12Device2*)Unsafe.AsPointer(ref this), pResource11, NumSync, pSignalValues, ppFences);
        }
    }
}
