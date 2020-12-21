// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BDB64DF4-EA2F-4C70-B861-AAAB1258BB5D")]
    [NativeTypeName("struct ID3D11On12Device1 : ID3D11On12Device")]
    public unsafe partial struct ID3D11On12Device1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, uint>)(lpVtbl[1]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, uint>)(lpVtbl[2]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWrappedResource([NativeTypeName("IUnknown *")] IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppResource11)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, IUnknown*, D3D11_RESOURCE_FLAGS*, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, Guid*, void**, int>)(lpVtbl[3]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, ID3D11Resource**, uint, void>)(lpVtbl[4]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AcquireWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, ID3D11Resource**, uint, void>)(lpVtbl[5]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)(lpVtbl[6]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }
    }
}
