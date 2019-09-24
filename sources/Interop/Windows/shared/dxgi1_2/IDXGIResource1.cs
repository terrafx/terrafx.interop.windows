// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30961379-4609-4A41-998E-54FE567EE0C1")]
    public unsafe struct IDXGIResource1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIResource1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIResource1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIResource1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] IDXGIResource1* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] IDXGIResource1* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] IDXGIResource1* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetParent(
            [In] IDXGIResource1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDevice(
            [In] IDXGIResource1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppDevice
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSharedHandle(
            [In] IDXGIResource1* This,
            [Out, NativeTypeName("HANDLE")] IntPtr* pSharedHandle
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetUsage(
            [In] IDXGIResource1* This,
            [Out, NativeTypeName("DXGI_USAGE")] uint* pUsage
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetEvictionPriority(
            [In] IDXGIResource1* This,
            [In, NativeTypeName("UINT")] uint EvictionPriority
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetEvictionPriority(
            [In] IDXGIResource1* This,
            [Out, NativeTypeName("UINT")] uint* pEvictionPriority
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateSubresourceSurface(
            [In] IDXGIResource1* This,
            [In, NativeTypeName("UINT")] uint index,
            [Out] IDXGISurface2** ppSurface
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateSharedHandle(
            [In] IDXGIResource1* This,
            [In, Optional] SECURITY_ATTRIBUTES* pAttributes,
            [In, NativeTypeName("DWORD")] uint dwAccess,
            [In, Optional, NativeTypeName("LPCWSTR")] char* lpName,
            [Out, NativeTypeName("HANDLE")] IntPtr* pHandle
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
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
            fixed (IDXGIResource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEvictionPriority>(lpVtbl->GetEvictionPriority)(
                    This,
                    pEvictionPriority
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSubresourceSurface(
            [In, NativeTypeName("UINT")] uint index,
            [Out] IDXGISurface2** ppSurface
        )
        {
            fixed (IDXGIResource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSubresourceSurface>(lpVtbl->CreateSubresourceSurface)(
                    This,
                    index,
                    ppSurface
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedHandle(
            [In, Optional] SECURITY_ATTRIBUTES* pAttributes,
            [In, NativeTypeName("DWORD")] uint dwAccess,
            [In, Optional, NativeTypeName("LPCWSTR")] char* lpName,
            [Out, NativeTypeName("HANDLE")] IntPtr* pHandle
        )
        {
            fixed (IDXGIResource1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSharedHandle>(lpVtbl->CreateSharedHandle)(
                    This,
                    pAttributes,
                    dwAccess,
                    lpName,
                    pHandle
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

            public IntPtr CreateSubresourceSurface;

            public IntPtr CreateSharedHandle;
        }
    }
}
