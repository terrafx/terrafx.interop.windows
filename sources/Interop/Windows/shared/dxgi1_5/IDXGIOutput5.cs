// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("80A07424-AB52-42EB-833C-0C42FD282D98")]
    public unsafe partial struct IDXGIOutput5
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGIOutput5*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGIOutput5*, uint>)(lpVtbl[1]))((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGIOutput5*, uint>)(lpVtbl[2]))((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIOutput5*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IDXGIOutput5*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIOutput5*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return ((delegate* stdcall<IDXGIOutput5*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_OUTPUT_DESC *")] DXGI_OUTPUT_DESC* pDesc)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_OUTPUT_DESC*, int>)(lpVtbl[7]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pDesc)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int>)(lpVtbl[8]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            return ((delegate* stdcall<IDXGIOutput5*, int>)(lpVtbl[10]))((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive)
        {
            return ((delegate* stdcall<IDXGIOutput5*, IUnknown*, int, int>)(lpVtbl[11]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
        }

        public void ReleaseOwnership()
        {
            ((delegate* stdcall<IDXGIOutput5*, void>)(lpVtbl[12]))((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities([NativeTypeName("DXGI_GAMMA_CONTROL_CAPABILITIES *")] DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int>)(lpVtbl[13]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pGammaCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[14]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl([NativeTypeName("DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_GAMMA_CONTROL*, int>)(lpVtbl[15]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface([NativeTypeName("IDXGISurface *")] IDXGISurface* pScanoutSurface)
        {
            return ((delegate* stdcall<IDXGIOutput5*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pScanoutSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData([NativeTypeName("IDXGISurface *")] IDXGISurface* pDestination)
        {
            return ((delegate* stdcall<IDXGIOutput5*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDestination);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_FRAME_STATISTICS*, int>)(lpVtbl[18]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList1(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pDesc)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC1*, int>)(lpVtbl[19]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode1([NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_MODE_DESC1*, DXGI_MODE_DESC1*, IUnknown*, int>)(lpVtbl[20]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData1([NativeTypeName("IDXGIResource *")] IDXGIResource* pDestination)
        {
            return ((delegate* stdcall<IDXGIOutput5*, IDXGIResource*, int>)(lpVtbl[21]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDestination);
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication)
        {
            return ((delegate* stdcall<IDXGIOutput5*, IUnknown*, IDXGIOutputDuplication**, int>)(lpVtbl[22]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
        }

        [return: NativeTypeName("BOOL")]
        public int SupportsOverlays()
        {
            return ((delegate* stdcall<IDXGIOutput5*, int>)(lpVtbl[23]))((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckOverlaySupport(DXGI_FORMAT EnumFormat, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_FORMAT, IUnknown*, uint*, int>)(lpVtbl[24]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return ((delegate* stdcall<IDXGIOutput5*, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, IUnknown*, uint*, int>)(lpVtbl[25]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), Format, ColorSpace, pConcernedDevice, pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput1([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint SupportedFormatsCount, [NativeTypeName("const DXGI_FORMAT *")] DXGI_FORMAT* pSupportedFormats, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication)
        {
            return ((delegate* stdcall<IDXGIOutput5*, IUnknown*, uint, uint, DXGI_FORMAT*, IDXGIOutputDuplication**, int>)(lpVtbl[26]))((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
        }
    }
}
