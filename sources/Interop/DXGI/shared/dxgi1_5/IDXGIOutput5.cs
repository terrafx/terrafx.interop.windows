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
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIOutput5* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIOutput5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIOutput5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIOutput5* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIOutput5* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIOutput5* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIOutput5* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGIOutput5* pThis, [NativeTypeName("DXGI_OUTPUT_DESC *")] DXGI_OUTPUT_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayModeList(IDXGIOutput5* pThis, DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindClosestMatchingMode(IDXGIOutput5* pThis, [NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WaitForVBlank(IDXGIOutput5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TakeOwnership(IDXGIOutput5* pThis, [NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseOwnership(IDXGIOutput5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGammaControlCapabilities(IDXGIOutput5* pThis, [NativeTypeName("DXGI_GAMMA_CONTROL_CAPABILITIES *")] DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGammaControl(IDXGIOutput5* pThis, [NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGammaControl(IDXGIOutput5* pThis, [NativeTypeName("DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDisplaySurface(IDXGIOutput5* pThis, [NativeTypeName("IDXGISurface *")] IDXGISurface* pScanoutSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplaySurfaceData(IDXGIOutput5* pThis, [NativeTypeName("IDXGISurface *")] IDXGISurface* pDestination);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDXGIOutput5* pThis, [NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayModeList1(IDXGIOutput5* pThis, DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindClosestMatchingMode1(IDXGIOutput5* pThis, [NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplaySurfaceData1(IDXGIOutput5* pThis, [NativeTypeName("IDXGIResource *")] IDXGIResource* pDestination);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DuplicateOutput(IDXGIOutput5* pThis, [NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _SupportsOverlays(IDXGIOutput5* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckOverlaySupport(IDXGIOutput5* pThis, DXGI_FORMAT EnumFormat, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckOverlayColorSpaceSupport(IDXGIOutput5* pThis, DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DuplicateOutput1(IDXGIOutput5* pThis, [NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint SupportedFormatsCount, [NativeTypeName("const DXGI_FORMAT *")] DXGI_FORMAT* pSupportedFormats, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIOutput5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDXGIOutput5*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDXGIOutput5*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDXGIOutput5*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)((IDXGIOutput5*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_OUTPUT_DESC *")] DXGI_OUTPUT_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDisplayModeList>(lpVtbl->GetDisplayModeList)((IDXGIOutput5*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindClosestMatchingMode>(lpVtbl->FindClosestMatchingMode)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            return Marshal.GetDelegateForFunctionPointer<_WaitForVBlank>(lpVtbl->WaitForVBlank)((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive)
        {
            return Marshal.GetDelegateForFunctionPointer<_TakeOwnership>(lpVtbl->TakeOwnership)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
        }

        public void ReleaseOwnership()
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseOwnership>(lpVtbl->ReleaseOwnership)((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities([NativeTypeName("DXGI_GAMMA_CONTROL_CAPABILITIES *")] DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGammaControlCapabilities>(lpVtbl->GetGammaControlCapabilities)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pGammaCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGammaControl>(lpVtbl->SetGammaControl)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl([NativeTypeName("DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGammaControl>(lpVtbl->GetGammaControl)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface([NativeTypeName("IDXGISurface *")] IDXGISurface* pScanoutSurface)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDisplaySurface>(lpVtbl->SetDisplaySurface)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pScanoutSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData([NativeTypeName("IDXGISurface *")] IDXGISurface* pDestination)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDisplaySurfaceData>(lpVtbl->GetDisplaySurfaceData)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDestination);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList1(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDisplayModeList1>(lpVtbl->GetDisplayModeList1)((IDXGIOutput5*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode1([NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindClosestMatchingMode1>(lpVtbl->FindClosestMatchingMode1)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData1([NativeTypeName("IDXGIResource *")] IDXGIResource* pDestination)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDisplaySurfaceData1>(lpVtbl->GetDisplaySurfaceData1)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDestination);
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication)
        {
            return Marshal.GetDelegateForFunctionPointer<_DuplicateOutput>(lpVtbl->DuplicateOutput)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
        }

        [return: NativeTypeName("BOOL")]
        public int SupportsOverlays()
        {
            return Marshal.GetDelegateForFunctionPointer<_SupportsOverlays>(lpVtbl->SupportsOverlays)((IDXGIOutput5*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckOverlaySupport(DXGI_FORMAT EnumFormat, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckOverlaySupport>(lpVtbl->CheckOverlaySupport)((IDXGIOutput5*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckOverlayColorSpaceSupport>(lpVtbl->CheckOverlayColorSpaceSupport)((IDXGIOutput5*)Unsafe.AsPointer(ref this), Format, ColorSpace, pConcernedDevice, pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput1([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint SupportedFormatsCount, [NativeTypeName("const DXGI_FORMAT *")] DXGI_FORMAT* pSupportedFormats, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication)
        {
            return Marshal.GetDelegateForFunctionPointer<_DuplicateOutput1>(lpVtbl->DuplicateOutput1)((IDXGIOutput5*)Unsafe.AsPointer(ref this), pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetParent;

            [NativeTypeName("HRESULT (DXGI_OUTPUT_DESC *) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC *) __attribute__((stdcall))")]
            public IntPtr GetDisplayModeList;

            [NativeTypeName("HRESULT (const DXGI_MODE_DESC *, DXGI_MODE_DESC *, IUnknown *) __attribute__((stdcall))")]
            public IntPtr FindClosestMatchingMode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr WaitForVBlank;

            [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
            public IntPtr TakeOwnership;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr ReleaseOwnership;

            [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL_CAPABILITIES *) __attribute__((stdcall))")]
            public IntPtr GetGammaControlCapabilities;

            [NativeTypeName("HRESULT (const DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
            public IntPtr SetGammaControl;

            [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
            public IntPtr GetGammaControl;

            [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
            public IntPtr SetDisplaySurface;

            [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
            public IntPtr GetDisplaySurfaceData;

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
            public IntPtr GetFrameStatistics;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC1 *) __attribute__((stdcall))")]
            public IntPtr GetDisplayModeList1;

            [NativeTypeName("HRESULT (const DXGI_MODE_DESC1 *, DXGI_MODE_DESC1 *, IUnknown *) __attribute__((stdcall))")]
            public IntPtr FindClosestMatchingMode1;

            [NativeTypeName("HRESULT (IDXGIResource *) __attribute__((stdcall))")]
            public IntPtr GetDisplaySurfaceData1;

            [NativeTypeName("HRESULT (IUnknown *, IDXGIOutputDuplication **) __attribute__((stdcall))")]
            public IntPtr DuplicateOutput;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr SupportsOverlays;

            [NativeTypeName("HRESULT (DXGI_FORMAT, IUnknown *, UINT *) __attribute__((stdcall))")]
            public IntPtr CheckOverlaySupport;

            [NativeTypeName("HRESULT (DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, IUnknown *, UINT *) __attribute__((stdcall))")]
            public IntPtr CheckOverlayColorSpaceSupport;

            [NativeTypeName("HRESULT (IUnknown *, UINT, UINT, const DXGI_FORMAT *, IDXGIOutputDuplication **) __attribute__((stdcall))")]
            public IntPtr DuplicateOutput1;
        }
    }
}
