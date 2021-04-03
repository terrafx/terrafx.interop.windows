// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8A6BB301-7E7E-41F4-A8E0-5B32F7F99B18")]
    [NativeTypeName("struct IDXGIOutput3 : IDXGIOutput2")]
    public unsafe partial struct IDXGIOutput3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIOutput3*, uint>)(lpVtbl[1]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIOutput3*, uint>)(lpVtbl[2]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_OUTPUT_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_OUTPUT_DESC*, int>)(lpVtbl[7]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, DXGI_MODE_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int>)(lpVtbl[8]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            return ((delegate* unmanaged<IDXGIOutput3*, int>)(lpVtbl[10]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership(IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, IUnknown*, int, int>)(lpVtbl[11]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseOwnership()
        {
            ((delegate* unmanaged<IDXGIOutput3*, void>)(lpVtbl[12]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities(DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int>)(lpVtbl[13]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pGammaCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[14]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl(DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[15]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface(IDXGISurface* pScanoutSurface)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pScanoutSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData(IDXGISurface* pDestination)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDestination);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_FRAME_STATISTICS*, int>)(lpVtbl[18]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pStats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList1(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, DXGI_MODE_DESC1* pDesc)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC1*, int>)(lpVtbl[19]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode1([NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch, DXGI_MODE_DESC1* pClosestMatch, IUnknown* pConcernedDevice)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_MODE_DESC1*, DXGI_MODE_DESC1*, IUnknown*, int>)(lpVtbl[20]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData1(IDXGIResource* pDestination)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, IDXGIResource*, int>)(lpVtbl[21]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDestination);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput(IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, IUnknown*, IDXGIOutputDuplication**, int>)(lpVtbl[22]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int SupportsOverlays()
        {
            return ((delegate* unmanaged<IDXGIOutput3*, int>)(lpVtbl[23]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckOverlaySupport(DXGI_FORMAT EnumFormat, IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return ((delegate* unmanaged<IDXGIOutput3*, DXGI_FORMAT, IUnknown*, uint*, int>)(lpVtbl[24]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
        }
    }
}
