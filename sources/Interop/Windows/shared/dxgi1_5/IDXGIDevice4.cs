// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_5.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("95B4F95F-D8DA-4CA4-9EE6-3B76D5968A10")]
    public unsafe struct IDXGIDevice4
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIDevice4* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIDevice4* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetParent(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAdapter(
            [In] IDXGIDevice4* This,
            [Out] IDXGIAdapter** pAdapter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateSurface(
            [In] IDXGIDevice4* This,
            [In] DXGI_SURFACE_DESC* pDesc,
            [In, NativeTypeName("UINT")] uint NumSurfaces,
            [In, NativeTypeName("DXGI_USAGE")] uint Usage,
            [In, Optional] DXGI_SHARED_RESOURCE* pSharedResource,
            [Out, NativeTypeName("IDXGISurface*[]")] IDXGISurface** ppSurface
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryResourceResidency(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("IUnknown*[]")] IUnknown** ppResources,
            [Out, NativeTypeName("DXGI_RESIDENCY[]")] DXGI_RESIDENCY* pResidencyStatus,
            [In, NativeTypeName("UINT")] uint NumResources
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetGPUThreadPriority(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("INT")] int Priority
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGPUThreadPriority(
            [In] IDXGIDevice4* This,
            [Out, NativeTypeName("INT")] int* pPriority
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMaximumFrameLatency(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("UINT")] uint MaxLatency
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMaximumFrameLatency(
            [In] IDXGIDevice4* This,
            [Out, NativeTypeName("UINT")] uint* pMaxLatency
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _OfferResources(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("UINT")] uint NumResources,
            [In, NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [In] DXGI_OFFER_RESOURCE_PRIORITY Priority
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ReclaimResources(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("UINT")] uint NumResources,
            [In, NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [Out, NativeTypeName("BOOL")] int* pDiscarded = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _EnqueueSetEvent(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("HANDLE")] IntPtr hEvent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _Trim(
            [In] IDXGIDevice4* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _OfferResources1(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("UINT")] uint NumResources,
            [In, NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [In] DXGI_OFFER_RESOURCE_PRIORITY Priority,
            [In, NativeTypeName("UINT")] uint Flags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ReclaimResources1(
            [In] IDXGIDevice4* This,
            [In, NativeTypeName("UINT")] uint NumResources,
            [In, NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [Out] DXGI_RECLAIM_RESOURCE_RESULTS* pResults
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdapter(
            [Out] IDXGIAdapter** pAdapter
        )
        {
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGPUThreadPriority>(lpVtbl->GetGPUThreadPriority)(
                    This,
                    pPriority
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency(
            [In, NativeTypeName("UINT")] uint MaxLatency
        )
        {
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumFrameLatency>(lpVtbl->GetMaximumFrameLatency)(
                    This,
                    pMaxLatency
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources(
            [In, NativeTypeName("UINT")] uint NumResources,
            [In, NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [In] DXGI_OFFER_RESOURCE_PRIORITY Priority
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OfferResources>(lpVtbl->OfferResources)(
                    This,
                    NumResources,
                    ppResources,
                    Priority
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReclaimResources(
            [In, NativeTypeName("UINT")] uint NumResources,
            [In, NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [Out, NativeTypeName("BOOL")] int* pDiscarded = null
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReclaimResources>(lpVtbl->ReclaimResources)(
                    This,
                    NumResources,
                    ppResources,
                    pDiscarded
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueSetEvent(
            [In, NativeTypeName("HANDLE")] IntPtr hEvent
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnqueueSetEvent>(lpVtbl->EnqueueSetEvent)(
                    This,
                    hEvent
                );
            }
        }

        public void Trim()
        {
            fixed (IDXGIDevice4* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Trim>(lpVtbl->Trim)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources1(
            [In, NativeTypeName("UINT")] uint NumResources,
            [In, NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [In] DXGI_OFFER_RESOURCE_PRIORITY Priority,
            [In, NativeTypeName("UINT")] uint Flags
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OfferResources1>(lpVtbl->OfferResources1)(
                    This,
                    NumResources,
                    ppResources,
                    Priority,
                    Flags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReclaimResources1(
            [In, NativeTypeName("UINT")] uint NumResources,
            [In, NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [Out] DXGI_RECLAIM_RESOURCE_RESULTS* pResults
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReclaimResources1>(lpVtbl->ReclaimResources1)(
                    This,
                    NumResources,
                    ppResources,
                    pResults
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

            public IntPtr GetAdapter;

            public IntPtr CreateSurface;

            public IntPtr QueryResourceResidency;

            public IntPtr SetGPUThreadPriority;

            public IntPtr GetGPUThreadPriority;

            public IntPtr SetMaximumFrameLatency;

            public IntPtr GetMaximumFrameLatency;

            public IntPtr OfferResources;

            public IntPtr ReclaimResources;

            public IntPtr EnqueueSetEvent;

            public IntPtr Trim;

            public IntPtr OfferResources1;

            public IntPtr ReclaimResources1;
        }
    }
}
