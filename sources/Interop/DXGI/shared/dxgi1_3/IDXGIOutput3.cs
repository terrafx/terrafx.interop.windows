// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8A6BB301-7E7E-41F4-A8E0-5B32F7F99B18")]
    public unsafe struct IDXGIOutput3
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIOutput3* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIOutput3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIOutput3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIOutput3* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIOutput3* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIOutput3* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIOutput3* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGIOutput3* This, DXGI_OUTPUT_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayModeList(IDXGIOutput3* This, DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC[]")] DXGI_MODE_DESC* pDesc = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindClosestMatchingMode(IDXGIOutput3* This, DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WaitForVBlank(IDXGIOutput3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TakeOwnership(IDXGIOutput3* This, IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseOwnership(IDXGIOutput3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGammaControlCapabilities(IDXGIOutput3* This, DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGammaControl(IDXGIOutput3* This, DXGI_GAMMA_CONTROL* pArray);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGammaControl(IDXGIOutput3* This, DXGI_GAMMA_CONTROL* pArray);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDisplaySurface(IDXGIOutput3* This, IDXGISurface* pScanoutSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplaySurfaceData(IDXGIOutput3* This, IDXGISurface* pDestination);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDXGIOutput3* This, DXGI_FRAME_STATISTICS* pStats);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayModeList1(IDXGIOutput3* This, DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint* pNumModes, DXGI_MODE_DESC1* pDesc = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindClosestMatchingMode1(IDXGIOutput3* This, DXGI_MODE_DESC1* pModeToMatch, DXGI_MODE_DESC1* pClosestMatch, IUnknown* pConcernedDevice = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplaySurfaceData1(IDXGIOutput3* This, IDXGIResource* pDestination);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DuplicateOutput(IDXGIOutput3* This, IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _SupportsOverlays(IDXGIOutput3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckOverlaySupport(IDXGIOutput3* This, DXGI_FORMAT EnumFormat, IUnknown* pConcernedDevice, [NativeTypeName("UINT")] uint* pFlags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_OUTPUT_DESC* pDesc)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC[]")] DXGI_MODE_DESC* pDesc = null)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDisplayModeList>(lpVtbl->GetDisplayModeList)(This, EnumFormat, Flags, pNumModes, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode(DXGI_MODE_DESC* pModeToMatch, DXGI_MODE_DESC* pClosestMatch, IUnknown* pConcernedDevice = null)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindClosestMatchingMode>(lpVtbl->FindClosestMatchingMode)(This, pModeToMatch, pClosestMatch, pConcernedDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WaitForVBlank>(lpVtbl->WaitForVBlank)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership(IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_TakeOwnership>(lpVtbl->TakeOwnership)(This, pDevice, Exclusive);
            }
        }

        public void ReleaseOwnership()
        {
            fixed (IDXGIOutput3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseOwnership>(lpVtbl->ReleaseOwnership)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities(DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGammaControlCapabilities>(lpVtbl->GetGammaControlCapabilities)(This, pGammaCaps);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl(DXGI_GAMMA_CONTROL* pArray)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetGammaControl>(lpVtbl->SetGammaControl)(This, pArray);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl(DXGI_GAMMA_CONTROL* pArray)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGammaControl>(lpVtbl->GetGammaControl)(This, pArray);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface(IDXGISurface* pScanoutSurface)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDisplaySurface>(lpVtbl->SetDisplaySurface)(This, pScanoutSurface);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData(IDXGISurface* pDestination)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDisplaySurfaceData>(lpVtbl->GetDisplaySurfaceData)(This, pDestination);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)(This, pStats);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList1(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint* pNumModes, DXGI_MODE_DESC1* pDesc = null)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDisplayModeList1>(lpVtbl->GetDisplayModeList1)(This, EnumFormat, Flags, pNumModes, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode1(DXGI_MODE_DESC1* pModeToMatch, DXGI_MODE_DESC1* pClosestMatch, IUnknown* pConcernedDevice = null)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindClosestMatchingMode1>(lpVtbl->FindClosestMatchingMode1)(This, pModeToMatch, pClosestMatch, pConcernedDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData1(IDXGIResource* pDestination)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDisplaySurfaceData1>(lpVtbl->GetDisplaySurfaceData1)(This, pDestination);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput(IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DuplicateOutput>(lpVtbl->DuplicateOutput)(This, pDevice, ppOutputDuplication);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int SupportsOverlays()
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SupportsOverlays>(lpVtbl->SupportsOverlays)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckOverlaySupport(DXGI_FORMAT EnumFormat, IUnknown* pConcernedDevice, [NativeTypeName("UINT")] uint* pFlags)
        {
            fixed (IDXGIOutput3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckOverlaySupport>(lpVtbl->CheckOverlaySupport)(This, EnumFormat, pConcernedDevice, pFlags);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;

            public IntPtr GetDesc;

            public IntPtr GetDisplayModeList;

            public IntPtr FindClosestMatchingMode;

            public IntPtr WaitForVBlank;

            public IntPtr TakeOwnership;

            public IntPtr ReleaseOwnership;

            public IntPtr GetGammaControlCapabilities;

            public IntPtr SetGammaControl;

            public IntPtr GetGammaControl;

            public IntPtr SetDisplaySurface;

            public IntPtr GetDisplaySurfaceData;

            public IntPtr GetFrameStatistics;

            public IntPtr GetDisplayModeList1;

            public IntPtr FindClosestMatchingMode1;

            public IntPtr GetDisplaySurfaceData1;

            public IntPtr DuplicateOutput;

            public IntPtr SupportsOverlays;

            public IntPtr CheckOverlaySupport;
        }
    }
}
