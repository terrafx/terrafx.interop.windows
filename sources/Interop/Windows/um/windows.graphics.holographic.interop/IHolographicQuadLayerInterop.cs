// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFA688F0-639E-4A47-83D7-6B7F5EBF7FED")]
    [NativeTypeName("struct IHolographicQuadLayerInterop : IInspectable")]
    public unsafe partial struct IHolographicQuadLayerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, uint>)(lpVtbl[1]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, uint>)(lpVtbl[2]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, IntPtr*, int>)(lpVtbl[4]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDirect3D12ContentBufferResource([NativeTypeName("ID3D12Device *")] ID3D12Device* pDevice, [NativeTypeName("D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pTexture2DDesc, [NativeTypeName("ID3D12Resource **")] ID3D12Resource** ppTexture2DResource)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12Resource**, int>)(lpVtbl[6]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pDevice, pTexture2DDesc, ppTexture2DResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDirect3D12HardwareProtectedContentBufferResource([NativeTypeName("ID3D12Device *")] ID3D12Device* pDevice, [NativeTypeName("D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pTexture2DDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("ID3D12Resource **")] ID3D12Resource** ppCreatedTexture2DResource)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12ProtectedResourceSession*, ID3D12Resource**, int>)(lpVtbl[7]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pDevice, pTexture2DDesc, pProtectedResourceSession, ppCreatedTexture2DResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AcquireDirect3D12BufferResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResourceToAcquire, [NativeTypeName("ID3D12CommandQueue *")] ID3D12CommandQueue* pCommandQueue)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Resource*, ID3D12CommandQueue*, int>)(lpVtbl[8]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pResourceToAcquire, pCommandQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AcquireDirect3D12BufferResourceWithTimeout([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResourceToAcquire, [NativeTypeName("ID3D12CommandQueue *")] ID3D12CommandQueue* pCommandQueue, [NativeTypeName("UINT64")] ulong duration)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Resource*, ID3D12CommandQueue*, ulong, int>)(lpVtbl[9]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pResourceToAcquire, pCommandQueue, duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnacquireDirect3D12BufferResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResourceToUnacquire)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerInterop*, ID3D12Resource*, int>)(lpVtbl[10]))((IHolographicQuadLayerInterop*)Unsafe.AsPointer(ref this), pResourceToUnacquire);
        }
    }
}
