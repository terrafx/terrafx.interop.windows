// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_5.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("3D585D5A-BD4A-489E-B1F4-3DBCB6452FFB")]
    public unsafe struct IDXGISwapChain4
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGISwapChain4* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGISwapChain4* This
        );
        #endregion

        #region IDXGIObject Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetParent(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );
        #endregion

        #region IDXGIDeviceSubObject Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDevice(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppDevice
        );
        #endregion

        #region IDXGISwapChain Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Present(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("UINT")] uint SyncInterval,
            [In, NativeTypeName("UINT")] uint Flags
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetBuffer(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("UINT")] uint Buffer,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [In, Out] void** ppSurface
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFullscreenState(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("BOOL")] int Fullscreen,
            [In] IDXGIOutput* pTarget = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFullscreenState(
            [In] IDXGISwapChain4* This,
            [Out, NativeTypeName("BOOL")] int* pFullscreen = null,
            [Out] IDXGIOutput** ppTarget = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc(
            [In] IDXGISwapChain4* This,
            [Out] DXGI_SWAP_CHAIN_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ResizeBuffers(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("UINT")] uint BufferCount,
            [In, NativeTypeName("UINT")] uint Width,
            [In, NativeTypeName("UINT")] uint Height,
            [In] DXGI_FORMAT NewFormat,
            [In, NativeTypeName("UINT")] uint SwapChainFlags
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ResizeTarget(
            [In] IDXGISwapChain4* This,
            [In] DXGI_MODE_DESC* pNewTargetParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContainingOutput(
            [In] IDXGISwapChain4* This,
            [Out] IDXGIOutput** ppOutput
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFrameStatistics(
            [In] IDXGISwapChain4* This,
            [Out] DXGI_FRAME_STATISTICS* pStats
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLastPresentCount(
            [In] IDXGISwapChain4* This,
            [Out, NativeTypeName("UINT")] uint* pLastPresentCount
        );
        #endregion

        #region IDXGISwapChain1 Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc1(
            [In] IDXGISwapChain4* This,
            [Out] DXGI_SWAP_CHAIN_DESC1* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFullscreenDesc(
            [In] IDXGISwapChain4* This,
            [Out] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetHwnd(
            [In] IDXGISwapChain4* This,
            [Out, NativeTypeName("HWND")] IntPtr* pHwnd
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCoreWindow(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("REFIID")] Guid* refiid,
            [Out] void** ppUnk
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Present1(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("UINT")] uint SyncInterval,
            [In, NativeTypeName("UINT")] uint PresentFlags,
            [In] DXGI_PRESENT_PARAMETERS* pPresentParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsTemporaryMonoSupported(
            [In] IDXGISwapChain4* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRestrictToOutput(
            [In] IDXGISwapChain4* This,
            [Out] IDXGIOutput** ppRestrictToOutput
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBackgroundColor(
            [In] IDXGISwapChain4* This,
            [In] DXGI_RGBA* pColor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetBackgroundColor(
            [In] IDXGISwapChain4* This,
            [Out] DXGI_RGBA* pColor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetRotation(
            [In] IDXGISwapChain4* This,
            [In] DXGI_MODE_ROTATION Rotation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRotation(
            [In] IDXGISwapChain4* This,
            [Out] DXGI_MODE_ROTATION* pRotation
        );
        #endregion

        #region IDXGISwapChain2 Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSourceSize(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("UINT")] uint Width,
            [In, NativeTypeName("UINT")] uint Height
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSourceSize(
            [In] IDXGISwapChain4* This,
            [Out, NativeTypeName("UINT")] uint* pWidth,
            [Out, NativeTypeName("UINT")] uint* pHeight
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMaximumFrameLatency(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("UINT")] uint MaxLatency
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMaximumFrameLatency(
            [In] IDXGISwapChain4* This,
            [Out, NativeTypeName("UINT")] uint* pMaxLatency
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HANDLE")]
        public /* static */ delegate IntPtr _GetFrameLatencyWaitableObject(
            [In] IDXGISwapChain4* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMatrixTransform(
            [In] IDXGISwapChain4* This,
            [In] DXGI_MATRIX_3X2_F* pMatrix
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMatrixTransform(
            [In] IDXGISwapChain4* This,
            [Out] DXGI_MATRIX_3X2_F* pMatrix
        );
        #endregion

        #region IDXGISwapChain3 Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT")]
        public /* static */ delegate uint _GetCurrentBackBufferIndex(
            [In] IDXGISwapChain4* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CheckColorSpaceSupport(
            [In] IDXGISwapChain4* This,
            [In] DXGI_COLOR_SPACE_TYPE ColorSpace,
            [Out, NativeTypeName("UINT")] uint* pColorSpaceSupport
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetColorSpace1(
            [In] IDXGISwapChain4* This,
            [In] DXGI_COLOR_SPACE_TYPE ColorSpace
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ResizeBuffers1(
            [In] IDXGISwapChain4* This,
            [In, NativeTypeName("UINT")] uint BufferCount,
            [In, NativeTypeName("UINT")] uint Width,
            [In, NativeTypeName("UINT")] uint Height,
            [In] DXGI_FORMAT Format,
            [In, NativeTypeName("UINT")] uint SwapChainFlags,
            [In, NativeTypeName("UINT[]")] uint* pCreationNodeMask,
            [In, NativeTypeName("IUnknown*[]")] IUnknown** ppPresentQueue
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetHDRMetaData(
            [In] IDXGISwapChain4* This,
            [In] DXGI_HDR_METADATA_TYPE Type,
            [In, NativeTypeName("UINT")] uint Size,
            [In] void* pMetaData = null
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGISwapChain4* This = &this)
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
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDXGIObject Methods
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        )
        {
            fixed (IDXGISwapChain4* This = &this)
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
            fixed (IDXGISwapChain4* This = &this)
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
            fixed (IDXGISwapChain4* This = &this)
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
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }
        #endregion

        #region IDXGIDeviceSubObject Methods
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppDevice
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(
                    This,
                    riid,
                    ppDevice
                );
            }
        }
        #endregion

        #region IDXGISwapChain Methods
        [return: NativeTypeName("HRESULT")]
        public int Present(
            [In, NativeTypeName("UINT")] uint SyncInterval,
            [In, NativeTypeName("UINT")] uint Flags
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Present>(lpVtbl->Present)(
                    This,
                    SyncInterval,
                    Flags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer(
            [In, NativeTypeName("UINT")] uint Buffer,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [In, Out] void** ppSurface
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBuffer>(lpVtbl->GetBuffer)(
                    This,
                    Buffer,
                    riid,
                    ppSurface
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFullscreenState(
            [In, NativeTypeName("BOOL")] int Fullscreen,
            [In] IDXGIOutput* pTarget = null
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFullscreenState>(lpVtbl->SetFullscreenState)(
                    This,
                    Fullscreen,
                    pTarget
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenState(
            [Out, NativeTypeName("BOOL")] int* pFullscreen = null,
            [Out] IDXGIOutput** ppTarget = null
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFullscreenState>(lpVtbl->GetFullscreenState)(
                    This,
                    pFullscreen,
                    ppTarget
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(
            [Out] DXGI_SWAP_CHAIN_DESC* pDesc
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers(
            [In, NativeTypeName("UINT")] uint BufferCount,
            [In, NativeTypeName("UINT")] uint Width,
            [In, NativeTypeName("UINT")] uint Height,
            [In] DXGI_FORMAT NewFormat,
            [In, NativeTypeName("UINT")] uint SwapChainFlags
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeBuffers>(lpVtbl->ResizeBuffers)(
                    This,
                    BufferCount,
                    Width,
                    Height,
                    NewFormat,
                    SwapChainFlags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeTarget(
            [In] DXGI_MODE_DESC* pNewTargetParameters
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeTarget>(lpVtbl->ResizeTarget)(
                    This,
                    pNewTargetParameters
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingOutput(
            [Out] IDXGIOutput** ppOutput
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainingOutput>(lpVtbl->GetContainingOutput)(
                    This,
                    ppOutput
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics(
            [Out] DXGI_FRAME_STATISTICS* pStats
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)(
                    This,
                    pStats
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastPresentCount(
            [Out, NativeTypeName("UINT")] uint* pLastPresentCount
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLastPresentCount>(lpVtbl->GetLastPresentCount)(
                    This,
                    pLastPresentCount
                );
            }
        }
        #endregion

        #region IDXGISwapChain1 Methods
        [return: NativeTypeName("HRESULT")]
        public int GetDesc1(
            [Out] DXGI_SWAP_CHAIN_DESC1* pDesc
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc1>(lpVtbl->GetDesc1)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFullscreenDesc(
            [Out] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFullscreenDesc>(lpVtbl->GetFullscreenDesc)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHwnd(
            [Out, NativeTypeName("HWND")] IntPtr* pHwnd
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetHwnd>(lpVtbl->GetHwnd)(
                    This,
                    pHwnd
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCoreWindow(
            [In, NativeTypeName("REFIID")] Guid* refiid,
            [Out] void** ppUnk
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCoreWindow>(lpVtbl->GetCoreWindow)(
                    This,
                    refiid,
                    ppUnk
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Present1(
            [In, NativeTypeName("UINT")] uint SyncInterval,
            [In, NativeTypeName("UINT")] uint PresentFlags,
            [In] DXGI_PRESENT_PARAMETERS* pPresentParameters
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Present1>(lpVtbl->Present1)(
                    This,
                    SyncInterval,
                    PresentFlags,
                    pPresentParameters
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsTemporaryMonoSupported()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsTemporaryMonoSupported>(lpVtbl->IsTemporaryMonoSupported)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRestrictToOutput(
            [Out] IDXGIOutput** ppRestrictToOutput
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRestrictToOutput>(lpVtbl->GetRestrictToOutput)(
                    This,
                    ppRestrictToOutput
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundColor(
            [In] DXGI_RGBA* pColor
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBackgroundColor>(lpVtbl->SetBackgroundColor)(
                    This,
                    pColor
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor(
            [Out] DXGI_RGBA* pColor
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBackgroundColor>(lpVtbl->GetBackgroundColor)(
                    This,
                    pColor
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(
            [In] DXGI_MODE_ROTATION Rotation
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetRotation>(lpVtbl->SetRotation)(
                    This,
                    Rotation
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation(
            [Out] DXGI_MODE_ROTATION* pRotation
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRotation>(lpVtbl->GetRotation)(
                    This,
                    pRotation
                );
            }
        }
        #endregion

        #region IDXGISwapChain2 Methods
        [return: NativeTypeName("HRESULT")]
        public int SetSourceSize(
            [In, NativeTypeName("UINT")] uint Width,
            [In, NativeTypeName("UINT")] uint Height
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSourceSize>(lpVtbl->SetSourceSize)(
                    This,
                    Width,
                    Height
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceSize(
            [Out, NativeTypeName("UINT")] uint* pWidth,
            [Out, NativeTypeName("UINT")] uint* pHeight
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSourceSize>(lpVtbl->GetSourceSize)(
                    This,
                    pWidth,
                    pHeight
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency(
            [In, NativeTypeName("UINT")] uint MaxLatency
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMaximumFrameLatency>(lpVtbl->SetMaximumFrameLatency)(
                    This,
                    MaxLatency
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency(
            [Out, NativeTypeName("UINT")] uint* pMaxLatency
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumFrameLatency>(lpVtbl->GetMaximumFrameLatency)(
                    This,
                    pMaxLatency
                );
            }
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetFrameLatencyWaitableObject()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameLatencyWaitableObject>(lpVtbl->GetFrameLatencyWaitableObject)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixTransform(
            [In] DXGI_MATRIX_3X2_F* pMatrix
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMatrixTransform>(lpVtbl->SetMatrixTransform)(
                    This,
                    pMatrix
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatrixTransform(
            [Out] DXGI_MATRIX_3X2_F* pMatrix
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMatrixTransform>(lpVtbl->GetMatrixTransform)(
                    This,
                    pMatrix
                );
            }
        }
        #endregion

        #region IDXGISwapChain3 Methods
        [return: NativeTypeName("UINT")]
        public uint GetCurrentBackBufferIndex()
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentBackBufferIndex>(lpVtbl->GetCurrentBackBufferIndex)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckColorSpaceSupport(
            [In] DXGI_COLOR_SPACE_TYPE ColorSpace,
            [Out, NativeTypeName("UINT")] uint* pColorSpaceSupport
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckColorSpaceSupport>(lpVtbl->CheckColorSpaceSupport)(
                    This,
                    ColorSpace,
                    pColorSpaceSupport
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorSpace1(
            [In] DXGI_COLOR_SPACE_TYPE ColorSpace
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetColorSpace1>(lpVtbl->SetColorSpace1)(
                    This,
                    ColorSpace
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ResizeBuffers1(
            [In, NativeTypeName("UINT")] uint BufferCount,
            [In, NativeTypeName("UINT")] uint Width,
            [In, NativeTypeName("UINT")] uint Height,
            [In] DXGI_FORMAT Format,
            [In, NativeTypeName("UINT")] uint SwapChainFlags,
            [In, NativeTypeName("UINT[]")] uint* pCreationNodeMask,
            [In, NativeTypeName("IUnknown*[]")] IUnknown** ppPresentQueue
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ResizeBuffers1>(lpVtbl->ResizeBuffers1)(
                    This,
                    BufferCount,
                    Width,
                    Height,
                    Format,
                    SwapChainFlags,
                    pCreationNodeMask,
                    ppPresentQueue
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int SetHDRMetaData(
            [In] DXGI_HDR_METADATA_TYPE Type,
            [In, NativeTypeName("UINT")] uint Size,
            [In] void* pMetaData = null
        )
        {
            fixed (IDXGISwapChain4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetHDRMetaData>(lpVtbl->SetHDRMetaData)(
                    This,
                    Type,
                    Size,
                    pMetaData
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IDXGIObject Fields
            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;
            #endregion

            #region IDXGIDeviceSubObject Fields
            public IntPtr GetDevice;
            #endregion

            #region IDXGISwapChain Fields
            public IntPtr Present;

            public IntPtr GetBuffer;

            public IntPtr SetFullscreenState;

            public IntPtr GetFullscreenState;

            public IntPtr GetDesc;

            public IntPtr ResizeBuffers;

            public IntPtr ResizeTarget;

            public IntPtr GetContainingOutput;

            public IntPtr GetFrameStatistics;

            public IntPtr GetLastPresentCount;
            #endregion

            #region IDXGISwapChain1 Fields
            public IntPtr GetDesc1;

            public IntPtr GetFullscreenDesc;

            public IntPtr GetHwnd;

            public IntPtr GetCoreWindow;

            public IntPtr Present1;

            public IntPtr IsTemporaryMonoSupported;

            public IntPtr GetRestrictToOutput;

            public IntPtr SetBackgroundColor;

            public IntPtr GetBackgroundColor;

            public IntPtr SetRotation;

            public IntPtr GetRotation;
            #endregion

            #region IDXGISwapChain2 Fields
            public IntPtr SetSourceSize;

            public IntPtr GetSourceSize;

            public IntPtr SetMaximumFrameLatency;

            public IntPtr GetMaximumFrameLatency;

            public IntPtr GetFrameLatencyWaitableObject;

            public IntPtr SetMatrixTransform;

            public IntPtr GetMatrixTransform;
            #endregion

            #region IDXGISwapChain3 Fields
            public IntPtr GetCurrentBackBufferIndex;

            public IntPtr CheckColorSpaceSupport;

            public IntPtr SetColorSpace1;

            public IntPtr ResizeBuffers1;
            #endregion

            #region Fields
            public IntPtr SetHDRMetaData;
            #endregion
        }
        #endregion
    }
}
