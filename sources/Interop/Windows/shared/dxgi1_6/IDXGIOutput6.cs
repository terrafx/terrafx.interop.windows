// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_6.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("068346E8-AAEC-4B84-ADD7-137F513F77A1")]
    public unsafe struct IDXGIOutput6
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDXGIOutput6* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDXGIOutput6* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDXGIOutput6* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(
            [In] IDXGIOutput6* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(
            [In] IDXGIOutput6* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(
            [In] IDXGIOutput6* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(
            [In] IDXGIOutput6* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(
            [In] IDXGIOutput6* This,
            [Out] DXGI_OUTPUT_DESC* pDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayModeList(
            [In] IDXGIOutput6* This,
            [In] DXGI_FORMAT EnumFormat,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, Out, NativeTypeName("UINT")] uint* pNumModes,
            [Out, NativeTypeName("DXGI_MODE_DESC[]")] DXGI_MODE_DESC* pDesc = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindClosestMatchingMode(
            [In] IDXGIOutput6* This,
            [In] DXGI_MODE_DESC* pModeToMatch,
            [Out] DXGI_MODE_DESC* pClosestMatch,
            [In] IUnknown* pConcernedDevice = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WaitForVBlank(
            [In] IDXGIOutput6* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TakeOwnership(
            [In] IDXGIOutput6* This,
            [In] IUnknown* pDevice,
            [In, NativeTypeName("BOOL")] int Exclusive
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseOwnership(
            [In] IDXGIOutput6* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGammaControlCapabilities(
            [In] IDXGIOutput6* This,
            [Out] DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGammaControl(
            [In] IDXGIOutput6* This,
            [In] DXGI_GAMMA_CONTROL* pArray
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGammaControl(
            [In] IDXGIOutput6* This,
            [Out] DXGI_GAMMA_CONTROL* pArray
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDisplaySurface(
            [In] IDXGIOutput6* This,
            [In] IDXGISurface* pScanoutSurface
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplaySurfaceData(
            [In] IDXGIOutput6* This,
            [In] IDXGISurface* pDestination
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(
            [In] IDXGIOutput6* This,
            [Out] DXGI_FRAME_STATISTICS* pStats
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayModeList1(
            [In] IDXGIOutput6* This,
            [In] DXGI_FORMAT EnumFormat,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, Out, NativeTypeName("UINT")] uint* pNumModes,
            [Out] DXGI_MODE_DESC1* pDesc = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindClosestMatchingMode1(
            [In] IDXGIOutput6* This,
            [In] DXGI_MODE_DESC1* pModeToMatch,
            [Out] DXGI_MODE_DESC1* pClosestMatch,
            [In] IUnknown* pConcernedDevice = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplaySurfaceData1(
            [In] IDXGIOutput6* This,
            [In] IDXGIResource* pDestination
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DuplicateOutput(
            [In] IDXGIOutput6* This,
            [In] IUnknown* pDevice,
            [Out] IDXGIOutputDuplication** ppOutputDuplication
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _SupportsOverlays(
            [In] IDXGIOutput6* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckOverlaySupport(
            [In] IDXGIOutput6* This,
            [In] DXGI_FORMAT EnumFormat,
            [In] IUnknown* pConcernedDevice,
            [Out, NativeTypeName("UINT")] uint* pFlags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckOverlayColorSpaceSupport(
            [In] IDXGIOutput6* This,
            [In] DXGI_FORMAT Format,
            [In] DXGI_COLOR_SPACE_TYPE ColorSpace,
            [In] IUnknown* pConcernedDevice,
            [Out, NativeTypeName("UINT")] uint* pFlags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DuplicateOutput1(
            [In] IDXGIOutput6* This,
            [In] IUnknown* pDevice,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, NativeTypeName("UINT")] uint SupportedFormatsCount,
            [In, NativeTypeName("DXGI_FORMAT[]")] DXGI_FORMAT* pSupportedFormats,
            [Out] IDXGIOutputDuplication** ppOutputDuplication
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc1(
            [In] IDXGIOutput6* This,
            [Out] DXGI_OUTPUT_DESC1* pDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckHardwareCompositionSupport(
            [In] IDXGIOutput6* This,
            [Out, NativeTypeName("UINT")] uint* pFlags
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(
                    This,
                    Name,
                    DataSize,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface(
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(
                    This,
                    Name,
                    pUnknown
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(
                    This,
                    Name,
                    pDataSize,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(
            [Out] DXGI_OUTPUT_DESC* pDesc
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(
            [In] DXGI_FORMAT EnumFormat,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, Out, NativeTypeName("UINT")] uint* pNumModes,
            [Out, NativeTypeName("DXGI_MODE_DESC[]")] DXGI_MODE_DESC* pDesc = null
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDisplayModeList>(lpVtbl->GetDisplayModeList)(
                    This,
                    EnumFormat,
                    Flags,
                    pNumModes,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode(
            [In] DXGI_MODE_DESC* pModeToMatch,
            [Out] DXGI_MODE_DESC* pClosestMatch,
            [In] IUnknown* pConcernedDevice = null
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindClosestMatchingMode>(lpVtbl->FindClosestMatchingMode)(
                    This,
                    pModeToMatch,
                    pClosestMatch,
                    pConcernedDevice
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WaitForVBlank>(lpVtbl->WaitForVBlank)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership(
            [In] IUnknown* pDevice,
            [In, NativeTypeName("BOOL")] int Exclusive
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_TakeOwnership>(lpVtbl->TakeOwnership)(
                    This,
                    pDevice,
                    Exclusive
                );
            }
        }

        public void ReleaseOwnership()
        {
            fixed (IDXGIOutput6* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseOwnership>(lpVtbl->ReleaseOwnership)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities(
            [Out] DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGammaControlCapabilities>(lpVtbl->GetGammaControlCapabilities)(
                    This,
                    pGammaCaps
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl(
            [In] DXGI_GAMMA_CONTROL* pArray
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetGammaControl>(lpVtbl->SetGammaControl)(
                    This,
                    pArray
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl(
            [Out] DXGI_GAMMA_CONTROL* pArray
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGammaControl>(lpVtbl->GetGammaControl)(
                    This,
                    pArray
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface(
            [In] IDXGISurface* pScanoutSurface
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDisplaySurface>(lpVtbl->SetDisplaySurface)(
                    This,
                    pScanoutSurface
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData(
            [In] IDXGISurface* pDestination
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDisplaySurfaceData>(lpVtbl->GetDisplaySurfaceData)(
                    This,
                    pDestination
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(
            [Out] DXGI_FRAME_STATISTICS* pStats
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)(
                    This,
                    pStats
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList1(
            [In] DXGI_FORMAT EnumFormat,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, Out, NativeTypeName("UINT")] uint* pNumModes,
            [Out] DXGI_MODE_DESC1* pDesc = null
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDisplayModeList1>(lpVtbl->GetDisplayModeList1)(
                    This,
                    EnumFormat,
                    Flags,
                    pNumModes,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode1(
            [In] DXGI_MODE_DESC1* pModeToMatch,
            [Out] DXGI_MODE_DESC1* pClosestMatch,
            [In] IUnknown* pConcernedDevice = null
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindClosestMatchingMode1>(lpVtbl->FindClosestMatchingMode1)(
                    This,
                    pModeToMatch,
                    pClosestMatch,
                    pConcernedDevice
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData1(
            [In] IDXGIResource* pDestination
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDisplaySurfaceData1>(lpVtbl->GetDisplaySurfaceData1)(
                    This,
                    pDestination
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput(
            [In] IUnknown* pDevice,
            [Out] IDXGIOutputDuplication** ppOutputDuplication
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DuplicateOutput>(lpVtbl->DuplicateOutput)(
                    This,
                    pDevice,
                    ppOutputDuplication
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int SupportsOverlays()
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SupportsOverlays>(lpVtbl->SupportsOverlays)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckOverlaySupport(
            [In] DXGI_FORMAT EnumFormat,
            [In] IUnknown* pConcernedDevice,
            [Out, NativeTypeName("UINT")] uint* pFlags
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckOverlaySupport>(lpVtbl->CheckOverlaySupport)(
                    This,
                    EnumFormat,
                    pConcernedDevice,
                    pFlags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckOverlayColorSpaceSupport(
            [In] DXGI_FORMAT Format,
            [In] DXGI_COLOR_SPACE_TYPE ColorSpace,
            [In] IUnknown* pConcernedDevice,
            [Out, NativeTypeName("UINT")] uint* pFlags
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckOverlayColorSpaceSupport>(lpVtbl->CheckOverlayColorSpaceSupport)(
                    This,
                    Format,
                    ColorSpace,
                    pConcernedDevice,
                    pFlags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput1(
            [In] IUnknown* pDevice,
            [In, NativeTypeName("UINT")] uint Flags,
            [In, NativeTypeName("UINT")] uint SupportedFormatsCount,
            [In, NativeTypeName("DXGI_FORMAT[]")] DXGI_FORMAT* pSupportedFormats,
            [Out] IDXGIOutputDuplication** ppOutputDuplication
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DuplicateOutput1>(lpVtbl->DuplicateOutput1)(
                    This,
                    pDevice,
                    Flags,
                    SupportedFormatsCount,
                    pSupportedFormats,
                    ppOutputDuplication
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1(
            [Out] DXGI_OUTPUT_DESC1* pDesc
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc1>(lpVtbl->GetDesc1)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckHardwareCompositionSupport(
            [Out, NativeTypeName("UINT")] uint* pFlags
        )
        {
            fixed (IDXGIOutput6* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckHardwareCompositionSupport>(lpVtbl->CheckHardwareCompositionSupport)(
                    This,
                    pFlags
                );
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

            public IntPtr CheckOverlayColorSpaceSupport;

            public IntPtr DuplicateOutput1;

            public IntPtr GetDesc1;

            public IntPtr CheckHardwareCompositionSupport;
        }
    }
}
