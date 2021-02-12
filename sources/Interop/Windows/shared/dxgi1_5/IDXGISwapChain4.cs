// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D585D5A-BD4A-489E-B1F4-3DBCB6452FFB")]
    [NativeTypeName("struct IDXGISwapChain4 : IDXGISwapChain3")]
    public unsafe partial struct IDXGISwapChain4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint>)(lpVtbl[1]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint>)(lpVtbl[2]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint, uint, int>)(lpVtbl[8]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("UINT")] uint Buffer, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSurface)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pTarget)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, int, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState([NativeTypeName("BOOL *")] int* pFullscreen, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppTarget)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, int*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_SWAP_CHAIN_DESC*, int>)(lpVtbl[12]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint, uint, uint, DXGI_FORMAT, uint, int>)(lpVtbl[13]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_MODE_DESC*, int>)(lpVtbl[14]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pNewTargetParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput([NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), ppOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_FRAME_STATISTICS*, int>)(lpVtbl[16]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pStats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount([NativeTypeName("UINT *")] uint* pLastPresentCount)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pLastPresentCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc1([NativeTypeName("DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_SWAP_CHAIN_DESC1*, int>)(lpVtbl[18]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenDesc([NativeTypeName("DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, int>)(lpVtbl[19]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHwnd([NativeTypeName("HWND *")] IntPtr* pHwnd)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, IntPtr*, int>)(lpVtbl[20]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pHwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, [NativeTypeName("void **")] void** ppUnk)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, Guid*, void**, int>)(lpVtbl[21]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), refiid, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Present1([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")] DXGI_PRESENT_PARAMETERS* pPresentParameters)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint, uint, DXGI_PRESENT_PARAMETERS*, int>)(lpVtbl[22]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsTemporaryMonoSupported()
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, int>)(lpVtbl[23]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRestrictToOutput([NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppRestrictToOutput)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, IDXGIOutput**, int>)(lpVtbl[24]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DXGI_RGBA* pColor)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_RGBA*, int>)(lpVtbl[25]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor([NativeTypeName("DXGI_RGBA *")] DXGI_RGBA* pColor)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_RGBA*, int>)(lpVtbl[26]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotation(DXGI_MODE_ROTATION Rotation)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_MODE_ROTATION, int>)(lpVtbl[27]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("DXGI_MODE_ROTATION *")] DXGI_MODE_ROTATION* pRotation)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_MODE_ROTATION*, int>)(lpVtbl[28]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint, uint, int>)(lpVtbl[29]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceSize([NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint*, uint*, int>)(lpVtbl[30]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency([NativeTypeName("UINT")] uint MaxLatency)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint, int>)(lpVtbl[31]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency([NativeTypeName("UINT *")] uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint*, int>)(lpVtbl[32]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pMaxLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetFrameLatencyWaitableObject()
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, IntPtr>)(lpVtbl[33]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMatrixTransform([NativeTypeName("const DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_MATRIX_3X2_F*, int>)(lpVtbl[34]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatrixTransform([NativeTypeName("DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_MATRIX_3X2_F*, int>)(lpVtbl[35]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), pMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetCurrentBackBufferIndex()
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint>)(lpVtbl[36]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckColorSpaceSupport(DXGI_COLOR_SPACE_TYPE ColorSpace, [NativeTypeName("UINT *")] uint* pColorSpaceSupport)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_COLOR_SPACE_TYPE, uint*, int>)(lpVtbl[37]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), ColorSpace, pColorSpaceSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorSpace1(DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_COLOR_SPACE_TYPE, int>)(lpVtbl[38]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), ColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers1([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SwapChainFlags, [NativeTypeName("const UINT *")] uint* pCreationNodeMask, [NativeTypeName("IUnknown *const *")] IUnknown** ppPresentQueue)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, uint, uint, uint, DXGI_FORMAT, uint, uint*, IUnknown**, int>)(lpVtbl[39]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHDRMetaData(DXGI_HDR_METADATA_TYPE Type, [NativeTypeName("UINT")] uint Size, [NativeTypeName("void *")] void* pMetaData)
        {
            return ((delegate* unmanaged<IDXGISwapChain4*, DXGI_HDR_METADATA_TYPE, uint, void*, int>)(lpVtbl[40]))((IDXGISwapChain4*)Unsafe.AsPointer(ref this), Type, Size, pMetaData);
        }
    }
}
