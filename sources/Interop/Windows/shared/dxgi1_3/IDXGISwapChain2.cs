// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("A8BE2AC4-199F-4946-B331-79599FB98DE7")]
    public unsafe struct IDXGISwapChain2
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGISwapChain2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGISwapChain2* This
        );
        #endregion

        #region IDXGIObject Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetParent(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );
        #endregion

        #region IDXGIDeviceSubObject Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDevice(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppDevice
        );
        #endregion

        #region IDXGISwapChain Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Present(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("UINT")] uint SyncInterval,
            [In, NativeTypeName("UINT")] uint Flags
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetBuffer(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("UINT")] uint Buffer,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [In, Out] void** ppSurface
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFullscreenState(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("BOOL")] int Fullscreen,
            [In] IDXGIOutput* pTarget = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFullscreenState(
            [In] IDXGISwapChain2* This,
            [Out, NativeTypeName("BOOL")] int* pFullscreen = null,
            [Out] IDXGIOutput** ppTarget = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc(
            [In] IDXGISwapChain2* This,
            [Out] DXGI_SWAP_CHAIN_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ResizeBuffers(
            [In] IDXGISwapChain2* This,
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
            [In] IDXGISwapChain2* This,
            [In] DXGI_MODE_DESC* pNewTargetParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContainingOutput(
            [In] IDXGISwapChain2* This,
            [Out] IDXGIOutput** ppOutput
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFrameStatistics(
            [In] IDXGISwapChain2* This,
            [Out] DXGI_FRAME_STATISTICS* pStats
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLastPresentCount(
            [In] IDXGISwapChain2* This,
            [Out, NativeTypeName("UINT")] uint* pLastPresentCount
        );
        #endregion

        #region IDXGISwapChain1 Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc1(
            [In] IDXGISwapChain2* This,
            [Out] DXGI_SWAP_CHAIN_DESC1* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFullscreenDesc(
            [In] IDXGISwapChain2* This,
            [Out] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetHwnd(
            [In] IDXGISwapChain2* This,
            [Out, NativeTypeName("HWND")] IntPtr* pHwnd
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCoreWindow(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("REFIID")] Guid* refiid,
            [Out] void** ppUnk
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Present1(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("UINT")] uint SyncInterval,
            [In, NativeTypeName("UINT")] uint PresentFlags,
            [In] DXGI_PRESENT_PARAMETERS* pPresentParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsTemporaryMonoSupported(
            [In] IDXGISwapChain2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRestrictToOutput(
            [In] IDXGISwapChain2* This,
            [Out] IDXGIOutput** ppRestrictToOutput
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBackgroundColor(
            [In] IDXGISwapChain2* This,
            [In] DXGI_RGBA* pColor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetBackgroundColor(
            [In] IDXGISwapChain2* This,
            [Out] DXGI_RGBA* pColor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetRotation(
            [In] IDXGISwapChain2* This,
            [In] DXGI_MODE_ROTATION Rotation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRotation(
            [In] IDXGISwapChain2* This,
            [Out] DXGI_MODE_ROTATION* pRotation
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSourceSize(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("UINT")] uint Width,
            [In, NativeTypeName("UINT")] uint Height
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSourceSize(
            [In] IDXGISwapChain2* This,
            [Out, NativeTypeName("UINT")] uint* pWidth,
            [Out, NativeTypeName("UINT")] uint* pHeight
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMaximumFrameLatency(
            [In] IDXGISwapChain2* This,
            [In, NativeTypeName("UINT")] uint MaxLatency
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMaximumFrameLatency(
            [In] IDXGISwapChain2* This,
            [Out, NativeTypeName("UINT")] uint* pMaxLatency
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HANDLE")]
        public /* static */ delegate IntPtr _GetFrameLatencyWaitableObject(
            [In] IDXGISwapChain2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMatrixTransform(
            [In] IDXGISwapChain2* This,
            [In] DXGI_MATRIX_3X2_F* pMatrix
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMatrixTransform(
            [In] IDXGISwapChain2* This,
            [Out] DXGI_MATRIX_3X2_F* pMatrix
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_SetPrivateData>(lpVtbl->SetPrivateData)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetPrivateData>(lpVtbl->GetPrivateData)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetParent>(lpVtbl->GetParent)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetDevice>(lpVtbl->GetDevice)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_Present>(lpVtbl->Present)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetBuffer>(lpVtbl->GetBuffer)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_SetFullscreenState>(lpVtbl->SetFullscreenState)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetFullscreenState>(lpVtbl->GetFullscreenState)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetDesc>(lpVtbl->GetDesc)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_ResizeBuffers>(lpVtbl->ResizeBuffers)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_ResizeTarget>(lpVtbl->ResizeTarget)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetContainingOutput>(lpVtbl->GetContainingOutput)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetLastPresentCount>(lpVtbl->GetLastPresentCount)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetDesc1>(lpVtbl->GetDesc1)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetFullscreenDesc>(lpVtbl->GetFullscreenDesc)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetHwnd>(lpVtbl->GetHwnd)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetCoreWindow>(lpVtbl->GetCoreWindow)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_Present1>(lpVtbl->Present1)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_IsTemporaryMonoSupported>(lpVtbl->IsTemporaryMonoSupported)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRestrictToOutput(
            [Out] IDXGIOutput** ppRestrictToOutput
        )
        {
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetRestrictToOutput>(lpVtbl->GetRestrictToOutput)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_SetBackgroundColor>(lpVtbl->SetBackgroundColor)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetBackgroundColor>(lpVtbl->GetBackgroundColor)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_SetRotation>(lpVtbl->SetRotation)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetRotation>(lpVtbl->GetRotation)(
                    This,
                    pRotation
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int SetSourceSize(
            [In, NativeTypeName("UINT")] uint Width,
            [In, NativeTypeName("UINT")] uint Height
        )
        {
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_SetSourceSize>(lpVtbl->SetSourceSize)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetSourceSize>(lpVtbl->GetSourceSize)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_SetMaximumFrameLatency>(lpVtbl->SetMaximumFrameLatency)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetMaximumFrameLatency>(lpVtbl->GetMaximumFrameLatency)(
                    This,
                    pMaxLatency
                );
            }
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetFrameLatencyWaitableObject()
        {
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetFrameLatencyWaitableObject>(lpVtbl->GetFrameLatencyWaitableObject)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixTransform(
            [In] DXGI_MATRIX_3X2_F* pMatrix
        )
        {
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_SetMatrixTransform>(lpVtbl->SetMatrixTransform)(
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
            fixed (IDXGISwapChain2* This = &this)
            {
                return MarshalFunction<_GetMatrixTransform>(lpVtbl->GetMatrixTransform)(
                    This,
                    pMatrix
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

            #region Fields
            public IntPtr SetSourceSize;

            public IntPtr GetSourceSize;

            public IntPtr SetMaximumFrameLatency;

            public IntPtr GetMaximumFrameLatency;

            public IntPtr GetFrameLatencyWaitableObject;

            public IntPtr SetMatrixTransform;

            public IntPtr GetMatrixTransform;
            #endregion
        }
        #endregion
    }
}
