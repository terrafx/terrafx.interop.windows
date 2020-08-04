// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7CC1F9C5-6D02-41FA-9500-E1809EB48EEC")]
    [NativeTypeName("struct IHolographicCameraInterop : IInspectable")]
    public unsafe partial struct IHolographicCameraInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, uint>)(lpVtbl[1]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, uint>)(lpVtbl[2]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, IntPtr*, int>)(lpVtbl[4]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), className);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDirect3D12BackBufferResource([NativeTypeName("ID3D12Device *")] ID3D12Device* pDevice, [NativeTypeName("D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pTexture2DDesc, [NativeTypeName("ID3D12Resource **")] ID3D12Resource** ppCreatedTexture2DResource)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12Resource**, int>)(lpVtbl[6]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pDevice, pTexture2DDesc, ppCreatedTexture2DResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDirect3D12HardwareProtectedBackBufferResource([NativeTypeName("ID3D12Device *")] ID3D12Device* pDevice, [NativeTypeName("D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pTexture2DDesc, [NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession, [NativeTypeName("ID3D12Resource **")] ID3D12Resource** ppCreatedTexture2DResource)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, ID3D12Device*, D3D12_RESOURCE_DESC*, ID3D12ProtectedResourceSession*, ID3D12Resource**, int>)(lpVtbl[7]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pDevice, pTexture2DDesc, pProtectedResourceSession, ppCreatedTexture2DResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int AcquireDirect3D12BufferResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResourceToAcquire, [NativeTypeName("ID3D12CommandQueue *")] ID3D12CommandQueue* pCommandQueue)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, ID3D12Resource*, ID3D12CommandQueue*, int>)(lpVtbl[8]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pResourceToAcquire, pCommandQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int AcquireDirect3D12BufferResourceWithTimeout([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResourceToAcquire, [NativeTypeName("ID3D12CommandQueue *")] ID3D12CommandQueue* pCommandQueue, [NativeTypeName("UINT64")] ulong duration)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, ID3D12Resource*, ID3D12CommandQueue*, ulong, int>)(lpVtbl[9]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pResourceToAcquire, pCommandQueue, duration);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnacquireDirect3D12BufferResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResourceToUnacquire)
        {
            return ((delegate* stdcall<IHolographicCameraInterop*, ID3D12Resource*, int>)(lpVtbl[10]))((IHolographicCameraInterop*)Unsafe.AsPointer(ref this), pResourceToUnacquire);
        }
    }
}
