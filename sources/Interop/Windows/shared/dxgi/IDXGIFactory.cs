// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B7166EC-21C7-44AE-B21A-C9AE321AE369")]
    public unsafe struct IDXGIFactory
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDXGIFactory* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDXGIFactory* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDXGIFactory* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(
            [In] IDXGIFactory* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(
            [In] IDXGIFactory* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(
            [In] IDXGIFactory* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(
            [In] IDXGIFactory* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters(
            [In] IDXGIFactory* This,
            [In, NativeTypeName("UINT")] uint Adapter,
            [Out] IDXGIAdapter** ppAdapter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeWindowAssociation(
            [In] IDXGIFactory* This,
            [In, NativeTypeName("HWND")] IntPtr WindowHandle,
            [In, NativeTypeName("UINT")] uint Flags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindowAssociation(
            [In] IDXGIFactory* This,
            [Out, NativeTypeName("HWND")] IntPtr* pWindowHandle
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChain(
            [In] IDXGIFactory* This,
            [In] IUnknown* pDevice,
            [In] DXGI_SWAP_CHAIN_DESC* pDesc,
            [Out] IDXGISwapChain** ppSwapChain
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSoftwareAdapter(
            [In] IDXGIFactory* This,
            [In, NativeTypeName("HMODULE")] IntPtr Module,
            [Out] IDXGIAdapter** ppAdapter
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
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
            fixed (IDXGIFactory* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSoftwareAdapter>(lpVtbl->CreateSoftwareAdapter)(
                    This,
                    Module,
                    ppAdapter
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
        }
    }
}
