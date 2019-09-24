// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("035F3AB4-482E-4E50-B41F-8A7F8BD8960B")]
    public unsafe struct IDXGIResource
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDXGIResource* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDXGIResource* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDXGIResource* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(
            [In] IDXGIResource* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(
            [In] IDXGIResource* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(
            [In] IDXGIResource* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(
            [In] IDXGIResource* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(
            [In] IDXGIResource* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppDevice
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSharedHandle(
            [In] IDXGIResource* This,
            [Out, NativeTypeName("HANDLE")] IntPtr* pSharedHandle
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUsage(
            [In] IDXGIResource* This,
            [Out, NativeTypeName("DXGI_USAGE")] uint* pUsage
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEvictionPriority(
            [In] IDXGIResource* This,
            [In, NativeTypeName("UINT")] uint EvictionPriority
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEvictionPriority(
            [In] IDXGIResource* This,
            [Out, NativeTypeName("UINT")] uint* pEvictionPriority
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIResource* This = &this)
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
            fixed (IDXGIResource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIResource* This = &this)
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
            fixed (IDXGIResource* This = &this)
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
            fixed (IDXGIResource* This = &this)
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
            fixed (IDXGIResource* This = &this)
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
            fixed (IDXGIResource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppDevice
        )
        {
            fixed (IDXGIResource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(
                    This,
                    riid,
                    ppDevice
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedHandle(
            [Out, NativeTypeName("HANDLE")] IntPtr* pSharedHandle
        )
        {
            fixed (IDXGIResource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSharedHandle>(lpVtbl->GetSharedHandle)(
                    This,
                    pSharedHandle
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUsage(
            [Out, NativeTypeName("DXGI_USAGE")] uint* pUsage
        )
        {
            fixed (IDXGIResource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetUsage>(lpVtbl->GetUsage)(
                    This,
                    pUsage
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEvictionPriority(
            [In, NativeTypeName("UINT")] uint EvictionPriority
        )
        {
            fixed (IDXGIResource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetEvictionPriority>(lpVtbl->SetEvictionPriority)(
                    This,
                    EvictionPriority
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvictionPriority(
            [Out, NativeTypeName("UINT")] uint* pEvictionPriority
        )
        {
            fixed (IDXGIResource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEvictionPriority>(lpVtbl->GetEvictionPriority)(
                    This,
                    pEvictionPriority
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

            public IntPtr GetDevice;

            public IntPtr GetSharedHandle;

            public IntPtr GetUsage;

            public IntPtr SetEvictionPriority;

            public IntPtr GetEvictionPriority;
        }
    }
}
