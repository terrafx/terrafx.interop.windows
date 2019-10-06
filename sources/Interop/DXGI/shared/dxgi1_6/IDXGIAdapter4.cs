// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_6.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C8D99D1-4FBF-4181-A82C-AF66BF7BD24E")]
    public unsafe partial struct IDXGIAdapter4
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIAdapter4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIAdapter4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIAdapter4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIAdapter4* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIAdapter4* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIAdapter4* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIAdapter4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumOutputs(IDXGIAdapter4* This, [NativeTypeName("UINT")] uint Output, IDXGIOutput** ppOutput);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(IDXGIAdapter4* This, DXGI_ADAPTER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckInterfaceSupport(IDXGIAdapter4* This, [NativeTypeName("REFGUID")] Guid* InterfaceName, LARGE_INTEGER* pUMDVersion);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc1(IDXGIAdapter4* This, DXGI_ADAPTER_DESC1* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc2(IDXGIAdapter4* This, DXGI_ADAPTER_DESC2* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterHardwareContentProtectionTeardownStatusEvent(IDXGIAdapter4* This, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterHardwareContentProtectionTeardownStatus(IDXGIAdapter4* This, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryVideoMemoryInfo(IDXGIAdapter4* This, [NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVideoMemoryReservation(IDXGIAdapter4* This, [NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("UINT64")] ulong Reservation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterVideoMemoryBudgetChangeNotificationEvent(IDXGIAdapter4* This, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterVideoMemoryBudgetChangeNotification(IDXGIAdapter4* This, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc3(IDXGIAdapter4* This, DXGI_ADAPTER_DESC3* pDesc);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumOutputs([NativeTypeName("UINT")] uint Output, IDXGIOutput** ppOutput)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumOutputs>(lpVtbl->EnumOutputs)(This, Output, ppOutput);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_ADAPTER_DESC* pDesc)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckInterfaceSupport([NativeTypeName("REFGUID")] Guid* InterfaceName, LARGE_INTEGER* pUMDVersion)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckInterfaceSupport>(lpVtbl->CheckInterfaceSupport)(This, InterfaceName, pUMDVersion);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1(DXGI_ADAPTER_DESC1* pDesc)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc1>(lpVtbl->GetDesc1)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc2(DXGI_ADAPTER_DESC2* pDesc)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc2>(lpVtbl->GetDesc2)(This, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterHardwareContentProtectionTeardownStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterHardwareContentProtectionTeardownStatusEvent>(lpVtbl->RegisterHardwareContentProtectionTeardownStatusEvent)(This, hEvent, pdwCookie);
            }
        }

        public void UnregisterHardwareContentProtectionTeardownStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterHardwareContentProtectionTeardownStatus>(lpVtbl->UnregisterHardwareContentProtectionTeardownStatus)(This, dwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryVideoMemoryInfo([NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryVideoMemoryInfo>(lpVtbl->QueryVideoMemoryInfo)(This, NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVideoMemoryReservation([NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("UINT64")] ulong Reservation)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetVideoMemoryReservation>(lpVtbl->SetVideoMemoryReservation)(This, NodeIndex, MemorySegmentGroup, Reservation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterVideoMemoryBudgetChangeNotificationEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterVideoMemoryBudgetChangeNotificationEvent>(lpVtbl->RegisterVideoMemoryBudgetChangeNotificationEvent)(This, hEvent, pdwCookie);
            }
        }

        public void UnregisterVideoMemoryBudgetChangeNotification([NativeTypeName("DWORD")] uint dwCookie)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterVideoMemoryBudgetChangeNotification>(lpVtbl->UnregisterVideoMemoryBudgetChangeNotification)(This, dwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc3(DXGI_ADAPTER_DESC3* pDesc)
        {
            fixed (IDXGIAdapter4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc3>(lpVtbl->GetDesc3)(This, pDesc);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;

            public IntPtr EnumOutputs;

            public IntPtr GetDesc;

            public IntPtr CheckInterfaceSupport;

            public IntPtr GetDesc1;

            public IntPtr GetDesc2;

            public IntPtr RegisterHardwareContentProtectionTeardownStatusEvent;

            public IntPtr UnregisterHardwareContentProtectionTeardownStatus;

            public IntPtr QueryVideoMemoryInfo;

            public IntPtr SetVideoMemoryReservation;

            public IntPtr RegisterVideoMemoryBudgetChangeNotificationEvent;

            public IntPtr UnregisterVideoMemoryBudgetChangeNotification;

            public IntPtr GetDesc3;
        }
    }
}
