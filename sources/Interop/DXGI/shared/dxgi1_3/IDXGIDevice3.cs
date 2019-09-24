// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6007896C-3244-4AFD-BF18-A6D3BEDA5023")]
    public unsafe struct IDXGIDevice3
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIDevice3* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIDevice3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIDevice3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIDevice3* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIDevice3* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIDevice3* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIDevice3* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAdapter(IDXGIDevice3* This, IDXGIAdapter** pAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurface(IDXGIDevice3* This, DXGI_SURFACE_DESC* pDesc, [NativeTypeName("UINT")] uint NumSurfaces, [NativeTypeName("DXGI_USAGE")] uint Usage, [Optional] DXGI_SHARED_RESOURCE* pSharedResource, [NativeTypeName("IDXGISurface*[]")] IDXGISurface** ppSurface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryResourceResidency(IDXGIDevice3* This, [NativeTypeName("IUnknown*[]")] IUnknown** ppResources, [NativeTypeName("DXGI_RESIDENCY[]")] DXGI_RESIDENCY* pResidencyStatus, [NativeTypeName("UINT")] uint NumResources);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGPUThreadPriority(IDXGIDevice3* This, [NativeTypeName("INT")] int Priority);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGPUThreadPriority(IDXGIDevice3* This, [NativeTypeName("INT")] int* pPriority);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMaximumFrameLatency(IDXGIDevice3* This, [NativeTypeName("UINT")] uint MaxLatency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMaximumFrameLatency(IDXGIDevice3* This, [NativeTypeName("UINT")] uint* pMaxLatency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OfferResources(IDXGIDevice3* This, [NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReclaimResources(IDXGIDevice3* This, [NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources, [NativeTypeName("BOOL")] int* pDiscarded = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnqueueSetEvent(IDXGIDevice3* This, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Trim(IDXGIDevice3* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdapter(IDXGIAdapter** pAdapter)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAdapter>(lpVtbl->GetAdapter)(This, pAdapter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface(DXGI_SURFACE_DESC* pDesc, [NativeTypeName("UINT")] uint NumSurfaces, [NativeTypeName("DXGI_USAGE")] uint Usage, [Optional] DXGI_SHARED_RESOURCE* pSharedResource, [NativeTypeName("IDXGISurface*[]")] IDXGISurface** ppSurface)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSurface>(lpVtbl->CreateSurface)(This, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryResourceResidency([NativeTypeName("IUnknown*[]")] IUnknown** ppResources, [NativeTypeName("DXGI_RESIDENCY[]")] DXGI_RESIDENCY* pResidencyStatus, [NativeTypeName("UINT")] uint NumResources)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryResourceResidency>(lpVtbl->QueryResourceResidency)(This, ppResources, pResidencyStatus, NumResources);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGPUThreadPriority([NativeTypeName("INT")] int Priority)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetGPUThreadPriority>(lpVtbl->SetGPUThreadPriority)(This, Priority);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGPUThreadPriority([NativeTypeName("INT")] int* pPriority)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGPUThreadPriority>(lpVtbl->GetGPUThreadPriority)(This, pPriority);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaximumFrameLatency([NativeTypeName("UINT")] uint MaxLatency)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMaximumFrameLatency>(lpVtbl->SetMaximumFrameLatency)(This, MaxLatency);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaximumFrameLatency([NativeTypeName("UINT")] uint* pMaxLatency)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumFrameLatency>(lpVtbl->GetMaximumFrameLatency)(This, pMaxLatency);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OfferResources>(lpVtbl->OfferResources)(This, NumResources, ppResources, Priority);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReclaimResources([NativeTypeName("UINT")] uint NumResources, [NativeTypeName("IDXGIResource*[]")] IDXGIResource** ppResources, [NativeTypeName("BOOL")] int* pDiscarded = null)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReclaimResources>(lpVtbl->ReclaimResources)(This, NumResources, ppResources, pDiscarded);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnqueueSetEvent([NativeTypeName("HANDLE")] IntPtr hEvent)
        {
            fixed (IDXGIDevice3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnqueueSetEvent>(lpVtbl->EnqueueSetEvent)(This, hEvent);
            }
        }

        public void Trim()
        {
            fixed (IDXGIDevice3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Trim>(lpVtbl->Trim)(This);
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
        }
    }
}
