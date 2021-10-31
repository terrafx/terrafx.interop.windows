// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7CC1F9C5-6D02-41FA-9500-E1809EB48EEC")]
    [NativeTypeName("struct IHolographicCameraInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IHolographicCameraInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, uint>)(lpVtbl[1]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, uint>)(lpVtbl[2]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, HSTRING*, int>)(lpVtbl[4]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateDirect3D12BackBufferResource(ID3D12Device* pDevice, D3D12_RESOURCE_DESC* pTexture2DDesc, ID3D12Resource** ppCreatedTexture2DResource)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12Resource**, int>)(lpVtbl[6]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pDevice, pTexture2DDesc, ppCreatedTexture2DResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateDirect3D12HardwareProtectedBackBufferResource(ID3D12Device* pDevice, D3D12_RESOURCE_DESC* pTexture2DDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ID3D12Resource** ppCreatedTexture2DResource)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12ProtectedResourceSession*, ID3D12Resource**, int>)(lpVtbl[7]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pDevice, pTexture2DDesc, pProtectedResourceSession, ppCreatedTexture2DResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AcquireDirect3D12BufferResource(ID3D12Resource* pResourceToAcquire, ID3D12CommandQueue* pCommandQueue)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, ID3D12Resource*, ID3D12CommandQueue*, int>)(lpVtbl[8]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pResourceToAcquire, pCommandQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AcquireDirect3D12BufferResourceWithTimeout(ID3D12Resource* pResourceToAcquire, ID3D12CommandQueue* pCommandQueue, [NativeTypeName("UINT64")] ulong duration)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, ID3D12Resource*, ID3D12CommandQueue*, ulong, int>)(lpVtbl[9]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pResourceToAcquire, pCommandQueue, duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT UnacquireDirect3D12BufferResource(ID3D12Resource* pResourceToUnacquire)
        {
            return ((delegate* unmanaged<IHolographicCameraInterop*, ID3D12Resource*, int>)(lpVtbl[10]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pResourceToUnacquire);
        }
    }
}
