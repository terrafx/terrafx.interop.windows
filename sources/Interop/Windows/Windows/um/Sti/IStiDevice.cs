// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice"]/*' />
[Guid("6CFA5A80-2DC8-11D0-90EA-00AA0060F86C")]
[NativeTypeName("struct IStiDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStiDevice : IStiDevice.Interface, INativeGuid
{
    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStiDevice);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, Guid*, void**, int>)(lpVtbl[0]))((IStiDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, uint>)(lpVtbl[1]))((IStiDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, uint>)(lpVtbl[2]))((IStiDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(HINSTANCE hinst, [NativeTypeName("LPCWSTR")] char* pwszDeviceName, [NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("DWORD")] uint dwMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, HINSTANCE, char*, uint, uint, int>)(lpVtbl[3]))((IStiDevice*)Unsafe.AsPointer(ref this), hinst, pwszDeviceName, dwVersion, dwMode);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.GetCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCapabilities([NativeTypeName("PSTI_DEV_CAPS")] STI_DEV_CAPS* pDevCaps)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, STI_DEV_CAPS*, int>)(lpVtbl[4]))((IStiDevice*)Unsafe.AsPointer(ref this), pDevCaps);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.GetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStatus([NativeTypeName("PSTI_DEVICE_STATUS")] STI_DEVICE_STATUS* pDevStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, STI_DEVICE_STATUS*, int>)(lpVtbl[5]))((IStiDevice*)Unsafe.AsPointer(ref this), pDevStatus);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.DeviceReset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeviceReset()
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, int>)(lpVtbl[6]))((IStiDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.Diagnostic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Diagnostic([NativeTypeName("LPSTI_DIAG")] STI_DIAG* pBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, STI_DIAG*, int>)(lpVtbl[7]))((IStiDevice*)Unsafe.AsPointer(ref this), pBuffer);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.Escape"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Escape([NativeTypeName("STI_RAW_CONTROL_CODE")] uint EscapeFunction, [NativeTypeName("LPVOID")] void* lpInData, [NativeTypeName("DWORD")] uint cbInDataSize, [NativeTypeName("LPVOID")] void* pOutData, [NativeTypeName("DWORD")] uint dwOutDataSize, [NativeTypeName("LPDWORD")] uint* pdwActualData)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, uint, void*, uint, void*, uint, uint*, int>)(lpVtbl[8]))((IStiDevice*)Unsafe.AsPointer(ref this), EscapeFunction, lpInData, cbInDataSize, pOutData, dwOutDataSize, pdwActualData);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.GetLastError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetLastError([NativeTypeName("LPDWORD")] uint* pdwLastDeviceError)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, uint*, int>)(lpVtbl[9]))((IStiDevice*)Unsafe.AsPointer(ref this), pdwLastDeviceError);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.LockDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockDevice([NativeTypeName("DWORD")] uint dwTimeOut)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, uint, int>)(lpVtbl[10]))((IStiDevice*)Unsafe.AsPointer(ref this), dwTimeOut);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.UnLockDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnLockDevice()
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, int>)(lpVtbl[11]))((IStiDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.RawReadData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RawReadData([NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytes, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, void*, uint*, OVERLAPPED*, int>)(lpVtbl[12]))((IStiDevice*)Unsafe.AsPointer(ref this), lpBuffer, lpdwNumberOfBytes, lpOverlapped);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.RawWriteData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RawWriteData([NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytes, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, void*, uint, OVERLAPPED*, int>)(lpVtbl[13]))((IStiDevice*)Unsafe.AsPointer(ref this), lpBuffer, nNumberOfBytes, lpOverlapped);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.RawReadCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RawReadCommand([NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytes, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, void*, uint*, OVERLAPPED*, int>)(lpVtbl[14]))((IStiDevice*)Unsafe.AsPointer(ref this), lpBuffer, lpdwNumberOfBytes, lpOverlapped);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.RawWriteCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RawWriteCommand([NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytes, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, void*, uint, OVERLAPPED*, int>)(lpVtbl[15]))((IStiDevice*)Unsafe.AsPointer(ref this), lpBuffer, nNumberOfBytes, lpOverlapped);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.Subscribe"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Subscribe([NativeTypeName("LPSTISUBSCRIBE")] STISUBSCRIBE* lpSubsribe)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, STISUBSCRIBE*, int>)(lpVtbl[16]))((IStiDevice*)Unsafe.AsPointer(ref this), lpSubsribe);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.GetLastNotificationData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetLastNotificationData([NativeTypeName("LPSTINOTIFY")] STINOTIFY* lpNotify)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, STINOTIFY*, int>)(lpVtbl[17]))((IStiDevice*)Unsafe.AsPointer(ref this), lpNotify);
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.UnSubscribe"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT UnSubscribe()
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, int>)(lpVtbl[18]))((IStiDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStiDevice.xml' path='doc/member[@name="IStiDevice.GetLastErrorInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetLastErrorInfo([NativeTypeName("STI_ERROR_INFO *")] STI_ERROR_INFOW* pLastErrorInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IStiDevice*, STI_ERROR_INFOW*, int>)(lpVtbl[19]))((IStiDevice*)Unsafe.AsPointer(ref this), pLastErrorInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(HINSTANCE hinst, [NativeTypeName("LPCWSTR")] char* pwszDeviceName, [NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("DWORD")] uint dwMode);

        [VtblIndex(4)]
        HRESULT GetCapabilities([NativeTypeName("PSTI_DEV_CAPS")] STI_DEV_CAPS* pDevCaps);

        [VtblIndex(5)]
        HRESULT GetStatus([NativeTypeName("PSTI_DEVICE_STATUS")] STI_DEVICE_STATUS* pDevStatus);

        [VtblIndex(6)]
        HRESULT DeviceReset();

        [VtblIndex(7)]
        HRESULT Diagnostic([NativeTypeName("LPSTI_DIAG")] STI_DIAG* pBuffer);

        [VtblIndex(8)]
        HRESULT Escape([NativeTypeName("STI_RAW_CONTROL_CODE")] uint EscapeFunction, [NativeTypeName("LPVOID")] void* lpInData, [NativeTypeName("DWORD")] uint cbInDataSize, [NativeTypeName("LPVOID")] void* pOutData, [NativeTypeName("DWORD")] uint dwOutDataSize, [NativeTypeName("LPDWORD")] uint* pdwActualData);

        [VtblIndex(9)]
        HRESULT GetLastError([NativeTypeName("LPDWORD")] uint* pdwLastDeviceError);

        [VtblIndex(10)]
        HRESULT LockDevice([NativeTypeName("DWORD")] uint dwTimeOut);

        [VtblIndex(11)]
        HRESULT UnLockDevice();

        [VtblIndex(12)]
        HRESULT RawReadData([NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytes, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [VtblIndex(13)]
        HRESULT RawWriteData([NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytes, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [VtblIndex(14)]
        HRESULT RawReadCommand([NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytes, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [VtblIndex(15)]
        HRESULT RawWriteCommand([NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytes, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [VtblIndex(16)]
        HRESULT Subscribe([NativeTypeName("LPSTISUBSCRIBE")] STISUBSCRIBE* lpSubsribe);

        [VtblIndex(17)]
        HRESULT GetLastNotificationData([NativeTypeName("LPSTINOTIFY")] STINOTIFY* lpNotify);

        [VtblIndex(18)]
        HRESULT UnSubscribe();

        [VtblIndex(19)]
        HRESULT GetLastErrorInfo([NativeTypeName("STI_ERROR_INFO *")] STI_ERROR_INFOW* pLastErrorInfo);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HINSTANCE, LPCWSTR, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HINSTANCE, char*, uint, uint, int> Initialize;

        [NativeTypeName("HRESULT (PSTI_DEV_CAPS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STI_DEV_CAPS*, int> GetCapabilities;

        [NativeTypeName("HRESULT (PSTI_DEVICE_STATUS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STI_DEVICE_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DeviceReset;

        [NativeTypeName("HRESULT (LPSTI_DIAG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STI_DIAG*, int> Diagnostic;

        [NativeTypeName("HRESULT (STI_RAW_CONTROL_CODE, LPVOID, DWORD, LPVOID, DWORD, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint, void*, uint, uint*, int> Escape;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetLastError;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> LockDevice;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> UnLockDevice;

        [NativeTypeName("HRESULT (LPVOID, LPDWORD, LPOVERLAPPED) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint*, OVERLAPPED*, int> RawReadData;

        [NativeTypeName("HRESULT (LPVOID, DWORD, LPOVERLAPPED) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, OVERLAPPED*, int> RawWriteData;

        [NativeTypeName("HRESULT (LPVOID, LPDWORD, LPOVERLAPPED) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint*, OVERLAPPED*, int> RawReadCommand;

        [NativeTypeName("HRESULT (LPVOID, DWORD, LPOVERLAPPED) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, OVERLAPPED*, int> RawWriteCommand;

        [NativeTypeName("HRESULT (LPSTISUBSCRIBE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STISUBSCRIBE*, int> Subscribe;

        [NativeTypeName("HRESULT (LPSTINOTIFY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STINOTIFY*, int> GetLastNotificationData;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> UnSubscribe;

        [NativeTypeName("HRESULT (STI_ERROR_INFO *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STI_ERROR_INFOW*, int> GetLastErrorInfo;
    }
}
