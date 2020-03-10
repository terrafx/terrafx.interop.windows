// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C8D99D1-4FBF-4181-A82C-AF66BF7BD24E")]
    public unsafe partial struct IDXGIAdapter4
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIAdapter4* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIAdapter4* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIAdapter4* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIAdapter4* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIAdapter4* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIAdapter4* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIAdapter4* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumOutputs(IDXGIAdapter4* pThis, [NativeTypeName("UINT")] uint Output, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGIAdapter4* pThis, [NativeTypeName("DXGI_ADAPTER_DESC *")] DXGI_ADAPTER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckInterfaceSupport(IDXGIAdapter4* pThis, [NativeTypeName("const GUID &")] Guid* InterfaceName, [NativeTypeName("LARGE_INTEGER *")] LARGE_INTEGER* pUMDVersion);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc1(IDXGIAdapter4* pThis, [NativeTypeName("DXGI_ADAPTER_DESC1 *")] DXGI_ADAPTER_DESC1* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc2(IDXGIAdapter4* pThis, [NativeTypeName("DXGI_ADAPTER_DESC2 *")] DXGI_ADAPTER_DESC2* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterHardwareContentProtectionTeardownStatusEvent(IDXGIAdapter4* pThis, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterHardwareContentProtectionTeardownStatus(IDXGIAdapter4* pThis, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryVideoMemoryInfo(IDXGIAdapter4* pThis, [NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("DXGI_QUERY_VIDEO_MEMORY_INFO *")] DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVideoMemoryReservation(IDXGIAdapter4* pThis, [NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("UINT64")] ulong Reservation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterVideoMemoryBudgetChangeNotificationEvent(IDXGIAdapter4* pThis, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterVideoMemoryBudgetChangeNotification(IDXGIAdapter4* pThis, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc3(IDXGIAdapter4* pThis, [NativeTypeName("DXGI_ADAPTER_DESC3 *")] DXGI_ADAPTER_DESC3* pDesc);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIAdapter4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIAdapter4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumOutputs([NativeTypeName("UINT")] uint Output, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumOutputs>(lpVtbl->EnumOutputs)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), Output, ppOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_ADAPTER_DESC *")] DXGI_ADAPTER_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckInterfaceSupport([NativeTypeName("const GUID &")] Guid* InterfaceName, [NativeTypeName("LARGE_INTEGER *")] LARGE_INTEGER* pUMDVersion)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckInterfaceSupport>(lpVtbl->CheckInterfaceSupport)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), InterfaceName, pUMDVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1([NativeTypeName("DXGI_ADAPTER_DESC1 *")] DXGI_ADAPTER_DESC1* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc1>(lpVtbl->GetDesc1)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc2([NativeTypeName("DXGI_ADAPTER_DESC2 *")] DXGI_ADAPTER_DESC2* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc2>(lpVtbl->GetDesc2)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterHardwareContentProtectionTeardownStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterHardwareContentProtectionTeardownStatusEvent>(lpVtbl->RegisterHardwareContentProtectionTeardownStatusEvent)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterHardwareContentProtectionTeardownStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            Marshal.GetDelegateForFunctionPointer<_UnregisterHardwareContentProtectionTeardownStatus>(lpVtbl->UnregisterHardwareContentProtectionTeardownStatus)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryVideoMemoryInfo([NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("DXGI_QUERY_VIDEO_MEMORY_INFO *")] DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryVideoMemoryInfo>(lpVtbl->QueryVideoMemoryInfo)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVideoMemoryReservation([NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("UINT64")] ulong Reservation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVideoMemoryReservation>(lpVtbl->SetVideoMemoryReservation)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), NodeIndex, MemorySegmentGroup, Reservation);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterVideoMemoryBudgetChangeNotificationEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterVideoMemoryBudgetChangeNotificationEvent>(lpVtbl->RegisterVideoMemoryBudgetChangeNotificationEvent)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterVideoMemoryBudgetChangeNotification([NativeTypeName("DWORD")] uint dwCookie)
        {
            Marshal.GetDelegateForFunctionPointer<_UnregisterVideoMemoryBudgetChangeNotification>(lpVtbl->UnregisterVideoMemoryBudgetChangeNotification)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc3([NativeTypeName("DXGI_ADAPTER_DESC3 *")] DXGI_ADAPTER_DESC3* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc3>(lpVtbl->GetDesc3)((IDXGIAdapter4*)Unsafe.AsPointer(ref this), pDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetParent;

            [NativeTypeName("HRESULT (UINT, IDXGIOutput **) __attribute__((stdcall))")]
            public IntPtr EnumOutputs;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC *) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("HRESULT (const GUID &, LARGE_INTEGER *) __attribute__((stdcall))")]
            public IntPtr CheckInterfaceSupport;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC1 *) __attribute__((stdcall))")]
            public IntPtr GetDesc1;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC2 *) __attribute__((stdcall))")]
            public IntPtr GetDesc2;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public IntPtr RegisterHardwareContentProtectionTeardownStatusEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public IntPtr UnregisterHardwareContentProtectionTeardownStatus;

            [NativeTypeName("HRESULT (UINT, DXGI_MEMORY_SEGMENT_GROUP, DXGI_QUERY_VIDEO_MEMORY_INFO *) __attribute__((stdcall))")]
            public IntPtr QueryVideoMemoryInfo;

            [NativeTypeName("HRESULT (UINT, DXGI_MEMORY_SEGMENT_GROUP, UINT64) __attribute__((stdcall))")]
            public IntPtr SetVideoMemoryReservation;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public IntPtr RegisterVideoMemoryBudgetChangeNotificationEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public IntPtr UnregisterVideoMemoryBudgetChangeNotification;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC3 *) __attribute__((stdcall))")]
            public IntPtr GetDesc3;
        }
    }
}
