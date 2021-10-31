// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D11On12On7.h in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct ID3D11On12On7 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11On12On7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11On12On7*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11On12On7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11On12On7*, uint>)(lpVtbl[1]))((ID3D11On12On7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11On12On7*, uint>)(lpVtbl[2]))((ID3D11On12On7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetThreadDeviceCreationParams(ID3D12Device* pDevice, ID3D12CommandQueue* pGraphicsQueue)
        {
            ((delegate* unmanaged<ID3D11On12On7*, ID3D12Device*, ID3D12CommandQueue*, void>)(lpVtbl[3]))((ID3D11On12On7*)Unsafe.AsPointer(ref this), pDevice, pGraphicsQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetThreadResourceCreationParams(ID3D12Resource* pResource)
        {
            ((delegate* unmanaged<ID3D11On12On7*, ID3D12Resource*, void>)(lpVtbl[4]))((ID3D11On12On7*)Unsafe.AsPointer(ref this), pResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D11On12On7Device* GetThreadLastCreatedDevice()
        {
            return ((delegate* unmanaged<ID3D11On12On7*, ID3D11On12On7Device*>)(lpVtbl[5]))((ID3D11On12On7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("ID3D11On12On7Resource *")]
        public void* GetThreadLastCreatedResource()
        {
            return ((delegate* unmanaged<ID3D11On12On7*, void*>)(lpVtbl[6]))((ID3D11On12On7*)Unsafe.AsPointer(ref this));
        }
    }
}
