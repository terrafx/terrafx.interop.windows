// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("595E39D1-2724-4663-99B1-DA969DE28364")]
    [NativeTypeName("struct IDXGIOutput2 : IDXGIOutput1")]
    [NativeInheritance("IDXGIOutput1")]
    public unsafe partial struct IDXGIOutput2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIOutput2*, uint>)(lpVtbl[1]))((IDXGIOutput2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIOutput2*, uint>)(lpVtbl[2]))((IDXGIOutput2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_OUTPUT_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_OUTPUT_DESC*, int>)(lpVtbl[7]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, DXGI_MODE_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int>)(lpVtbl[8]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            return ((delegate* unmanaged<IDXGIOutput2*, int>)(lpVtbl[10]))((IDXGIOutput2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership(IUnknown* pDevice, BOOL Exclusive)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, IUnknown*, BOOL, int>)(lpVtbl[11]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void ReleaseOwnership()
        {
            ((delegate* unmanaged<IDXGIOutput2*, void>)(lpVtbl[12]))((IDXGIOutput2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities(DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int>)(lpVtbl[13]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pGammaCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[14]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl(DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[15]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface(IDXGISurface* pScanoutSurface)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pScanoutSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData(IDXGISurface* pDestination)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pDestination);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_FRAME_STATISTICS*, int>)(lpVtbl[18]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pStats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList1(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, DXGI_MODE_DESC1* pDesc)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC1*, int>)(lpVtbl[19]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode1([NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch, DXGI_MODE_DESC1* pClosestMatch, IUnknown* pConcernedDevice)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, DXGI_MODE_DESC1*, DXGI_MODE_DESC1*, IUnknown*, int>)(lpVtbl[20]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData1(IDXGIResource* pDestination)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, IDXGIResource*, int>)(lpVtbl[21]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pDestination);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput(IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            return ((delegate* unmanaged<IDXGIOutput2*, IUnknown*, IDXGIOutputDuplication**, int>)(lpVtbl[22]))((IDXGIOutput2*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public BOOL SupportsOverlays()
        {
            return ((delegate* unmanaged<IDXGIOutput2*, int>)(lpVtbl[23]))((IDXGIOutput2*)Unsafe.AsPointer(ref this));
        }
    }
}
