// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25483823-CD46-4C7D-86CA-47AA95B837BD")]
    public unsafe struct IDXGIFactory3
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDXGIFactory3* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDXGIFactory3* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("UINT")] uint Adapter,
            [Out] IDXGIAdapter** ppAdapter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeWindowAssociation(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("HWND")] IntPtr WindowHandle,
            [In, NativeTypeName("UINT")] uint Flags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindowAssociation(
            [In] IDXGIFactory3* This,
            [Out, NativeTypeName("HWND")] IntPtr* pWindowHandle
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChain(
            [In] IDXGIFactory3* This,
            [In] IUnknown* pDevice,
            [In] DXGI_SWAP_CHAIN_DESC* pDesc,
            [Out] IDXGISwapChain** ppSwapChain
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSoftwareAdapter(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("HMODULE")] IntPtr Module,
            [Out] IDXGIAdapter** ppAdapter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters1(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("UINT")] uint Adapter,
            [Out] IDXGIAdapter1** ppAdapter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsCurrent(
            [In] IDXGIFactory3* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsWindowedStereoEnabled(
            [In] IDXGIFactory3* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForHwnd(
            [In] IDXGIFactory3* This,
            [In] IUnknown* pDevice,
            [In, NativeTypeName("HWND")] IntPtr hWnd,
            [In] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForCoreWindow(
            [In] IDXGIFactory3* This,
            [In] IUnknown* pDevice,
            [In] IUnknown* pWindow,
            [In] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSharedResourceAdapterLuid(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("HANDLE")] IntPtr hResource,
            [Out] LUID* pLuid
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterStereoStatusWindow(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("HWND")] IntPtr WindowHandle,
            [In, NativeTypeName("UINT")] uint wMsg,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterStereoStatusEvent(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("HANDLE")] IntPtr hEvent,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterStereoStatus(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("DWORD")] uint dwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterOcclusionStatusWindow(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("HWND")] IntPtr WindowHandle,
            [In, NativeTypeName("UINT")] uint wMsg,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterOcclusionStatusEvent(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("HANDLE")] IntPtr hEvent,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterOcclusionStatus(
            [In] IDXGIFactory3* This,
            [In, NativeTypeName("UINT")] uint dwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForComposition(
            [In] IDXGIFactory3* This,
            [In] IUnknown* pDevice,
            [In] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetCreationFlags(
            [In] IDXGIFactory3* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIFactory3* This = &this)
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
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIFactory3* This = &this)
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
            fixed (IDXGIFactory3* This = &this)
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
            fixed (IDXGIFactory3* This = &this)
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
            fixed (IDXGIFactory3* This = &this)
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
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters(
            [In, NativeTypeName("UINT")] uint Adapter,
            [Out] IDXGIAdapter** ppAdapter
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumAdapters>(lpVtbl->EnumAdapters)(
                    This,
                    Adapter,
                    ppAdapter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation(
            [In, NativeTypeName("HWND")] IntPtr WindowHandle,
            [In, NativeTypeName("UINT")] uint Flags
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MakeWindowAssociation>(lpVtbl->MakeWindowAssociation)(
                    This,
                    WindowHandle,
                    Flags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation(
            [Out, NativeTypeName("HWND")] IntPtr* pWindowHandle
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWindowAssociation>(lpVtbl->GetWindowAssociation)(
                    This,
                    pWindowHandle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain(
            [In] IUnknown* pDevice,
            [In] DXGI_SWAP_CHAIN_DESC* pDesc,
            [Out] IDXGISwapChain** ppSwapChain
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChain>(lpVtbl->CreateSwapChain)(
                    This,
                    pDevice,
                    pDesc,
                    ppSwapChain
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter(
            [In, NativeTypeName("HMODULE")] IntPtr Module,
            [Out] IDXGIAdapter** ppAdapter
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSoftwareAdapter>(lpVtbl->CreateSoftwareAdapter)(
                    This,
                    Module,
                    ppAdapter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters1(
            [In, NativeTypeName("UINT")] uint Adapter,
            [Out] IDXGIAdapter1** ppAdapter
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumAdapters1>(lpVtbl->EnumAdapters1)(
                    This,
                    Adapter,
                    ppAdapter
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsCurrent()
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsCurrent>(lpVtbl->IsCurrent)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsWindowedStereoEnabled()
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsWindowedStereoEnabled>(lpVtbl->IsWindowedStereoEnabled)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForHwnd(
            [In] IUnknown* pDevice,
            [In, NativeTypeName("HWND")] IntPtr hWnd,
            [In] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForHwnd>(lpVtbl->CreateSwapChainForHwnd)(
                    This,
                    pDevice,
                    hWnd,
                    pDesc,
                    pFullscreenDesc,
                    pRestrictToOutput,
                    ppSwapChain
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCoreWindow(
            [In] IUnknown* pDevice,
            [In] IUnknown* pWindow,
            [In] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForCoreWindow>(lpVtbl->CreateSwapChainForCoreWindow)(
                    This,
                    pDevice,
                    pWindow,
                    pDesc,
                    pRestrictToOutput,
                    ppSwapChain
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedResourceAdapterLuid(
            [In, NativeTypeName("HANDLE")] IntPtr hResource,
            [Out] LUID* pLuid
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSharedResourceAdapterLuid>(lpVtbl->GetSharedResourceAdapterLuid)(
                    This,
                    hResource,
                    pLuid
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusWindow(
            [In, NativeTypeName("HWND")] IntPtr WindowHandle,
            [In, NativeTypeName("UINT")] uint wMsg,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterStereoStatusWindow>(lpVtbl->RegisterStereoStatusWindow)(
                    This,
                    WindowHandle,
                    wMsg,
                    pdwCookie
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusEvent(
            [In, NativeTypeName("HANDLE")] IntPtr hEvent,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterStereoStatusEvent>(lpVtbl->RegisterStereoStatusEvent)(
                    This,
                    hEvent,
                    pdwCookie
                );
            }
        }

        public void UnregisterStereoStatus(
            [In, NativeTypeName("DWORD")] uint dwCookie
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterStereoStatus>(lpVtbl->UnregisterStereoStatus)(
                    This,
                    dwCookie
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusWindow(
            [In, NativeTypeName("HWND")] IntPtr WindowHandle,
            [In, NativeTypeName("UINT")] uint wMsg,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterOcclusionStatusWindow>(lpVtbl->RegisterOcclusionStatusWindow)(
                    This,
                    WindowHandle,
                    wMsg,
                    pdwCookie
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusEvent(
            [In, NativeTypeName("HANDLE")] IntPtr hEvent,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterOcclusionStatusEvent>(lpVtbl->RegisterOcclusionStatusEvent)(
                    This,
                    hEvent,
                    pdwCookie
                );
            }
        }

        public void UnregisterOcclusionStatus(
            [In, NativeTypeName("UINT")] uint dwCookie
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterOcclusionStatus>(lpVtbl->UnregisterOcclusionStatus)(
                    This,
                    dwCookie
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForComposition(
            [In] IUnknown* pDevice,
            [In] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        )
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForComposition>(lpVtbl->CreateSwapChainForComposition)(
                    This,
                    pDevice,
                    pDesc,
                    pRestrictToOutput,
                    ppSwapChain
                );
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            fixed (IDXGIFactory3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCreationFlags>(lpVtbl->GetCreationFlags)(
                    This
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

            public IntPtr EnumAdapters;

            public IntPtr MakeWindowAssociation;

            public IntPtr GetWindowAssociation;

            public IntPtr CreateSwapChain;

            public IntPtr CreateSoftwareAdapter;

            public IntPtr EnumAdapters1;

            public IntPtr IsCurrent;

            public IntPtr IsWindowedStereoEnabled;

            public IntPtr CreateSwapChainForHwnd;

            public IntPtr CreateSwapChainForCoreWindow;

            public IntPtr GetSharedResourceAdapterLuid;

            public IntPtr RegisterStereoStatusWindow;

            public IntPtr RegisterStereoStatusEvent;

            public IntPtr UnregisterStereoStatus;

            public IntPtr RegisterOcclusionStatusWindow;

            public IntPtr RegisterOcclusionStatusEvent;

            public IntPtr UnregisterOcclusionStatus;

            public IntPtr CreateSwapChainForComposition;

            public IntPtr GetCreationFlags;
        }
    }
}
