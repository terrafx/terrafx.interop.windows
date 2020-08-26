// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("068346E8-AAEC-4B84-ADD7-137F513F77A1")]
    [NativeTypeName("struct IDXGIOutput6 : IDXGIOutput5")]
    public unsafe partial struct IDXGIOutput6
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGIOutput6*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGIOutput6*, uint>)(lpVtbl[1]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGIOutput6*, uint>)(lpVtbl[2]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIOutput6*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IDXGIOutput6*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIOutput6*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return ((delegate* stdcall<IDXGIOutput6*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_OUTPUT_DESC *")] DXGI_OUTPUT_DESC* pDesc)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_OUTPUT_DESC*, int>)(lpVtbl[7]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pDesc)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int>)(lpVtbl[8]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            return ((delegate* stdcall<IDXGIOutput6*, int>)(lpVtbl[10]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive)
        {
            return ((delegate* stdcall<IDXGIOutput6*, IUnknown*, int, int>)(lpVtbl[11]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseOwnership()
        {
            ((delegate* stdcall<IDXGIOutput6*, void>)(lpVtbl[12]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities([NativeTypeName("DXGI_GAMMA_CONTROL_CAPABILITIES *")] DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int>)(lpVtbl[13]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pGammaCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[14]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl([NativeTypeName("DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[15]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface([NativeTypeName("IDXGISurface *")] IDXGISurface* pScanoutSurface)
        {
            return ((delegate* stdcall<IDXGIOutput6*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pScanoutSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData([NativeTypeName("IDXGISurface *")] IDXGISurface* pDestination)
        {
            return ((delegate* stdcall<IDXGIOutput6*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDestination);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_FRAME_STATISTICS*, int>)(lpVtbl[18]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pStats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList1(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pDesc)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC1*, int>)(lpVtbl[19]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode1([NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_MODE_DESC1*, DXGI_MODE_DESC1*, IUnknown*, int>)(lpVtbl[20]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData1([NativeTypeName("IDXGIResource *")] IDXGIResource* pDestination)
        {
            return ((delegate* stdcall<IDXGIOutput6*, IDXGIResource*, int>)(lpVtbl[21]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDestination);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication)
        {
            return ((delegate* stdcall<IDXGIOutput6*, IUnknown*, IDXGIOutputDuplication**, int>)(lpVtbl[22]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int SupportsOverlays()
        {
            return ((delegate* stdcall<IDXGIOutput6*, int>)(lpVtbl[23]))((IDXGIOutput6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckOverlaySupport(DXGI_FORMAT EnumFormat, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_FORMAT, IUnknown*, uint*, int>)(lpVtbl[24]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, IUnknown*, uint*, int>)(lpVtbl[25]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), Format, ColorSpace, pConcernedDevice, pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput1([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint SupportedFormatsCount, [NativeTypeName("const DXGI_FORMAT *")] DXGI_FORMAT* pSupportedFormats, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication)
        {
            return ((delegate* stdcall<IDXGIOutput6*, IUnknown*, uint, uint, DXGI_FORMAT*, IDXGIOutputDuplication**, int>)(lpVtbl[26]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc1([NativeTypeName("DXGI_OUTPUT_DESC1 *")] DXGI_OUTPUT_DESC1* pDesc)
        {
            return ((delegate* stdcall<IDXGIOutput6*, DXGI_OUTPUT_DESC1*, int>)(lpVtbl[27]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckHardwareCompositionSupport([NativeTypeName("UINT *")] uint* pFlags)
        {
            return ((delegate* stdcall<IDXGIOutput6*, uint*, int>)(lpVtbl[28]))((IDXGIOutput6*)Unsafe.AsPointer(ref this), pFlags);
        }
    }
}
