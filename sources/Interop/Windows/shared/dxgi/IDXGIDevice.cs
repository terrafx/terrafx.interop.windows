// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("54EC77FA-1377-44E6-8C32-88FD5F44C84C")]
    public unsafe struct IDXGIDevice
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIDevice* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIDevice* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIDevice* This
        );
        #endregion

        #region IDXGIObject Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] IDXGIDevice* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] IDXGIDevice* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] IDXGIDevice* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetParent(
            [In] IDXGIDevice* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAdapter(
            [In] IDXGIDevice* This,
            [Out] IDXGIAdapter** pAdapter
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateSurface(
            [In] IDXGIDevice* This,
            [In] DXGI_SURFACE_DESC* pDesc,
            [In, NativeTypeName("UINT")] uint NumSurfaces,
            [In, NativeTypeName("DXGI_USAGE")] uint Usage,
            [In, Optional] DXGI_SHARED_RESOURCE* pSharedResource,
            [Out, NativeTypeName("IDXGISurface*[]")] IDXGISurface** ppSurface
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryResourceResidency(
            [In] IDXGIDevice* This,
            [In, NativeTypeName("IUnknown*[]")] IUnknown** ppResources,
            [Out, NativeTypeName("DXGI_RESIDENCY[]")] DXGI_RESIDENCY* pResidencyStatus,
            [In, NativeTypeName("UINT")] uint NumResources
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetGPUThreadPriority(
            [In] IDXGIDevice* This,
            [In, NativeTypeName("INT")] int Priority
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGPUThreadPriority(
            [In] IDXGIDevice* This,
            [Out, NativeTypeName("INT")] int* pPriority
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIDevice* This = &this)
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
            fixed (IDXGIDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIDevice* This = &this)
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
            fixed (IDXGIDevice* This = &this)
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
            fixed (IDXGIDevice* This = &this)
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
            fixed (IDXGIDevice* This = &this)
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
            fixed (IDXGIDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetAdapter(
            [Out] IDXGIAdapter** pAdapter
        )
        {
            fixed (IDXGIDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAdapter>(lpVtbl->GetAdapter)(
                    This,
                    pAdapter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface(
            [In] DXGI_SURFACE_DESC* pDesc,
            [In, NativeTypeName("UINT")] uint NumSurfaces,
            [In, NativeTypeName("DXGI_USAGE")] uint Usage,
            [In, Optional] DXGI_SHARED_RESOURCE* pSharedResource,
            [Out, NativeTypeName("IDXGISurface*[]")] IDXGISurface** ppSurface
        )
        {
            fixed (IDXGIDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSurface>(lpVtbl->CreateSurface)(
                    This,
                    pDesc,
                    NumSurfaces,
                    Usage,
                    pSharedResource,
                    ppSurface
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryResourceResidency(
            [In, NativeTypeName("IUnknown*[]")] IUnknown** ppResources,
            [Out, NativeTypeName("DXGI_RESIDENCY[]")] DXGI_RESIDENCY* pResidencyStatus,
            [In, NativeTypeName("UINT")] uint NumResources
        )
        {
            fixed (IDXGIDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryResourceResidency>(lpVtbl->QueryResourceResidency)(
                    This,
                    ppResources,
                    pResidencyStatus,
                    NumResources
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGPUThreadPriority(
            [In, NativeTypeName("INT")] int Priority
        )
        {
            fixed (IDXGIDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetGPUThreadPriority>(lpVtbl->SetGPUThreadPriority)(
                    This,
                    Priority
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGPUThreadPriority(
            [Out, NativeTypeName("INT")] int* pPriority
        )
        {
            fixed (IDXGIDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGPUThreadPriority>(lpVtbl->GetGPUThreadPriority)(
                    This,
                    pPriority
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

            #region Fields
            public IntPtr GetAdapter;

            public IntPtr CreateSurface;

            public IntPtr QueryResourceResidency;

            public IntPtr SetGPUThreadPriority;

            public IntPtr GetGPUThreadPriority;
            #endregion
        }
        #endregion
    }
}
