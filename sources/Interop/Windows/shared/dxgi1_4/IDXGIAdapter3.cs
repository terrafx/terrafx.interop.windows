// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_4.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("645967A4-1392-4310-A798-8053CE3E93FD")]
    public unsafe struct IDXGIAdapter3
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIAdapter3* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIAdapter3* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetParent(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _EnumOutputs(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("UINT")] uint Output,
            [In, Out] IDXGIOutput** ppOutput
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc(
            [In] IDXGIAdapter3* This,
            [Out] DXGI_ADAPTER_DESC* pDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CheckInterfaceSupport(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("REFGUID")] Guid* InterfaceName,
            [Out] LARGE_INTEGER* pUMDVersion
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc1(
            [In] IDXGIAdapter3* This,
            [Out] DXGI_ADAPTER_DESC1* pDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDesc2(
            [In] IDXGIAdapter3* This,
            [Out] DXGI_ADAPTER_DESC2* pDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RegisterHardwareContentProtectionTeardownStatusEvent(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("HANDLE")] IntPtr hEvent,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _UnregisterHardwareContentProtectionTeardownStatus(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("DWORD")] uint dwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryVideoMemoryInfo(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("UINT")] uint NodeIndex,
            [In] DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup,
            [Out] DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetVideoMemoryReservation(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("UINT")] uint NodeIndex,
            [In] DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup,
            [In, NativeTypeName("UINT64")] ulong Reservation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RegisterVideoMemoryBudgetChangeNotificationEvent(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("HANDLE")] IntPtr hEvent,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _UnregisterVideoMemoryBudgetChangeNotification(
            [In] IDXGIAdapter3* This,
            [In, NativeTypeName("DWORD")] uint dwCookie
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIAdapter3* This = &this)
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
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIAdapter3* This = &this)
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
            fixed (IDXGIAdapter3* This = &this)
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
            fixed (IDXGIAdapter3* This = &this)
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
            fixed (IDXGIAdapter3* This = &this)
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
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumOutputs(
            [In, NativeTypeName("UINT")] uint Output,
            [In, Out] IDXGIOutput** ppOutput
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumOutputs>(lpVtbl->EnumOutputs)(
                    This,
                    Output,
                    ppOutput
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(
            [Out] DXGI_ADAPTER_DESC* pDesc
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckInterfaceSupport(
            [In, NativeTypeName("REFGUID")] Guid* InterfaceName,
            [Out] LARGE_INTEGER* pUMDVersion
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckInterfaceSupport>(lpVtbl->CheckInterfaceSupport)(
                    This,
                    InterfaceName,
                    pUMDVersion
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1(
            [Out] DXGI_ADAPTER_DESC1* pDesc
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc1>(lpVtbl->GetDesc1)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc2(
            [Out] DXGI_ADAPTER_DESC2* pDesc
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc2>(lpVtbl->GetDesc2)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterHardwareContentProtectionTeardownStatusEvent(
            [In, NativeTypeName("HANDLE")] IntPtr hEvent,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterHardwareContentProtectionTeardownStatusEvent>(lpVtbl->RegisterHardwareContentProtectionTeardownStatusEvent)(
                    This,
                    hEvent,
                    pdwCookie
                );
            }
        }

        public void UnregisterHardwareContentProtectionTeardownStatus(
            [In, NativeTypeName("DWORD")] uint dwCookie
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterHardwareContentProtectionTeardownStatus>(lpVtbl->UnregisterHardwareContentProtectionTeardownStatus)(
                    This,
                    dwCookie
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryVideoMemoryInfo(
            [In, NativeTypeName("UINT")] uint NodeIndex,
            [In] DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup,
            [Out] DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryVideoMemoryInfo>(lpVtbl->QueryVideoMemoryInfo)(
                    This,
                    NodeIndex,
                    MemorySegmentGroup,
                    pVideoMemoryInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVideoMemoryReservation(
            [In, NativeTypeName("UINT")] uint NodeIndex,
            [In] DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup,
            [In, NativeTypeName("UINT64")] ulong Reservation
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetVideoMemoryReservation>(lpVtbl->SetVideoMemoryReservation)(
                    This,
                    NodeIndex,
                    MemorySegmentGroup,
                    Reservation
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterVideoMemoryBudgetChangeNotificationEvent(
            [In, NativeTypeName("HANDLE")] IntPtr hEvent,
            [Out, NativeTypeName("DWORD")] uint* pdwCookie
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterVideoMemoryBudgetChangeNotificationEvent>(lpVtbl->RegisterVideoMemoryBudgetChangeNotificationEvent)(
                    This,
                    hEvent,
                    pdwCookie
                );
            }
        }

        public void UnregisterVideoMemoryBudgetChangeNotification(
            [In, NativeTypeName("DWORD")] uint dwCookie
        )
        {
            fixed (IDXGIAdapter3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterVideoMemoryBudgetChangeNotification>(lpVtbl->UnregisterVideoMemoryBudgetChangeNotification)(
                    This,
                    dwCookie
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
        }
    }
}
