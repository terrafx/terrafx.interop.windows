// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C8D99D1-4FBF-4181-A82C-AF66BF7BD24E")]
    [NativeTypeName("struct IDXGIAdapter4 : IDXGIAdapter3")]
    public unsafe partial struct IDXGIAdapter4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGIAdapter4*, uint>)(lpVtbl[1]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGIAdapter4*, uint>)(lpVtbl[2]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumOutputs([NativeTypeName("UINT")] uint Output, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, uint, IDXGIOutput**, int>)(lpVtbl[7]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), Output, ppOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_ADAPTER_DESC *")] DXGI_ADAPTER_DESC* pDesc)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, DXGI_ADAPTER_DESC*, int>)(lpVtbl[8]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CheckInterfaceSupport([NativeTypeName("const GUID &")] Guid* InterfaceName, [NativeTypeName("LARGE_INTEGER *")] LARGE_INTEGER* pUMDVersion)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, Guid*, LARGE_INTEGER*, int>)(lpVtbl[9]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), InterfaceName, pUMDVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc1([NativeTypeName("DXGI_ADAPTER_DESC1 *")] DXGI_ADAPTER_DESC1* pDesc)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, DXGI_ADAPTER_DESC1*, int>)(lpVtbl[10]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc2([NativeTypeName("DXGI_ADAPTER_DESC2 *")] DXGI_ADAPTER_DESC2* pDesc)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, DXGI_ADAPTER_DESC2*, int>)(lpVtbl[11]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterHardwareContentProtectionTeardownStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, IntPtr, uint*, int>)(lpVtbl[12]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void UnregisterHardwareContentProtectionTeardownStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* stdcall<IDXGIAdapter4*, uint, void>)(lpVtbl[13]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryVideoMemoryInfo([NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("DXGI_QUERY_VIDEO_MEMORY_INFO *")] DXGI_QUERY_VIDEO_MEMORY_INFO* pVideoMemoryInfo)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, uint, DXGI_MEMORY_SEGMENT_GROUP, DXGI_QUERY_VIDEO_MEMORY_INFO*, int>)(lpVtbl[14]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVideoMemoryReservation([NativeTypeName("UINT")] uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, [NativeTypeName("UINT64")] ulong Reservation)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, uint, DXGI_MEMORY_SEGMENT_GROUP, ulong, int>)(lpVtbl[15]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), NodeIndex, MemorySegmentGroup, Reservation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterVideoMemoryBudgetChangeNotificationEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, IntPtr, uint*, int>)(lpVtbl[16]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void UnregisterVideoMemoryBudgetChangeNotification([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* stdcall<IDXGIAdapter4*, uint, void>)(lpVtbl[17]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc3([NativeTypeName("DXGI_ADAPTER_DESC3 *")] DXGI_ADAPTER_DESC3* pDesc)
        {
            return ((delegate* stdcall<IDXGIAdapter4*, DXGI_ADAPTER_DESC3*, int>)(lpVtbl[18]))((IDXGIAdapter4*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
