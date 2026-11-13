// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW"]/*' />
[Guid("641BD880-2DC8-11D0-90EA-00AA0060F86C")]
[NativeTypeName("struct IStillImageW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStillImageW : IStillImageW.Interface, INativeGuid
{
    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStillImageW);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, Guid*, void**, int>)(lpVtbl[0]))((IStillImageW*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, uint>)(lpVtbl[1]))((IStillImageW*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, uint>)(lpVtbl[2]))((IStillImageW*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(HINSTANCE hinst, [NativeTypeName("DWORD")] uint dwVersion)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, HINSTANCE, uint, int>)(lpVtbl[3]))((IStillImageW*)Unsafe.AsPointer(ref this), hinst, dwVersion);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.GetDeviceList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDeviceList([NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwItemsReturned, [NativeTypeName("LPVOID *")] void** ppBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, uint, uint, uint*, void**, int>)(lpVtbl[4]))((IStillImageW*)Unsafe.AsPointer(ref this), dwType, dwFlags, pdwItemsReturned, ppBuffer);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.GetDeviceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDeviceInfo([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("LPVOID *")] void** ppBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, void**, int>)(lpVtbl[5]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName, ppBuffer);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.CreateDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateDevice([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("DWORD")] uint dwMode, [NativeTypeName("PSTIDEVICE *")] IStiDevice** pDevice, [NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, uint, IStiDevice**, IUnknown*, int>)(lpVtbl[6]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName, dwMode, pDevice, punkOuter);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.GetDeviceValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceValue([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("LPWSTR")] char* pValueName, [NativeTypeName("LPDWORD")] uint* pType, [NativeTypeName("LPBYTE")] byte* pData, [NativeTypeName("LPDWORD")] uint* cbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, char*, uint*, byte*, uint*, int>)(lpVtbl[7]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName, pValueName, pType, pData, cbData);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.SetDeviceValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDeviceValue([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("LPWSTR")] char* pValueName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("LPBYTE")] byte* pData, [NativeTypeName("DWORD")] uint cbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, char*, uint, byte*, uint, int>)(lpVtbl[8]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName, pValueName, Type, pData, cbData);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.GetSTILaunchInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSTILaunchInformation([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("DWORD *")] uint* pdwEventCode, [NativeTypeName("LPWSTR")] char* pwszEventName)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, uint*, char*, int>)(lpVtbl[9]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName, pdwEventCode, pwszEventName);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.RegisterLaunchApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterLaunchApplication([NativeTypeName("LPWSTR")] char* pwszAppName, [NativeTypeName("LPWSTR")] char* pwszCommandLine)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, char*, int>)(lpVtbl[10]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszAppName, pwszCommandLine);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.UnregisterLaunchApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnregisterLaunchApplication([NativeTypeName("LPWSTR")] char* pwszAppName)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, int>)(lpVtbl[11]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszAppName);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.EnableHwNotifications"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnableHwNotifications([NativeTypeName("LPCWSTR")] char* pwszDeviceName, BOOL bNewState)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, BOOL, int>)(lpVtbl[12]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName, bNewState);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.GetHwNotificationState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetHwNotificationState([NativeTypeName("LPCWSTR")] char* pwszDeviceName, BOOL* pbCurrentState)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, BOOL*, int>)(lpVtbl[13]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName, pbCurrentState);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.RefreshDeviceBus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RefreshDeviceBus([NativeTypeName("LPCWSTR")] char* pwszDeviceName)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, int>)(lpVtbl[14]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.LaunchApplicationForDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT LaunchApplicationForDevice([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("LPWSTR")] char* pwszAppName, [NativeTypeName("LPSTINOTIFY")] STINOTIFY* pStiNotify)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, char*, char*, STINOTIFY*, int>)(lpVtbl[15]))((IStillImageW*)Unsafe.AsPointer(ref this), pwszDeviceName, pwszAppName, pStiNotify);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.SetupDeviceParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetupDeviceParameters([NativeTypeName("PSTI_DEVICE_INFORMATIONW")] STI_DEVICE_INFORMATIONW* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, STI_DEVICE_INFORMATIONW*, int>)(lpVtbl[16]))((IStillImageW*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IStillImageW.xml' path='doc/member[@name="IStillImageW.WriteToErrorLog"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT WriteToErrorLog([NativeTypeName("DWORD")] uint dwMessageType, [NativeTypeName("LPCWSTR")] char* pszMessage)
    {
        return ((delegate* unmanaged[MemberFunction]<IStillImageW*, uint, char*, int>)(lpVtbl[17]))((IStillImageW*)Unsafe.AsPointer(ref this), dwMessageType, pszMessage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(HINSTANCE hinst, [NativeTypeName("DWORD")] uint dwVersion);

        [VtblIndex(4)]
        HRESULT GetDeviceList([NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwItemsReturned, [NativeTypeName("LPVOID *")] void** ppBuffer);

        [VtblIndex(5)]
        HRESULT GetDeviceInfo([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("LPVOID *")] void** ppBuffer);

        [VtblIndex(6)]
        HRESULT CreateDevice([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("DWORD")] uint dwMode, [NativeTypeName("PSTIDEVICE *")] IStiDevice** pDevice, [NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter);

        [VtblIndex(7)]
        HRESULT GetDeviceValue([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("LPWSTR")] char* pValueName, [NativeTypeName("LPDWORD")] uint* pType, [NativeTypeName("LPBYTE")] byte* pData, [NativeTypeName("LPDWORD")] uint* cbData);

        [VtblIndex(8)]
        HRESULT SetDeviceValue([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("LPWSTR")] char* pValueName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("LPBYTE")] byte* pData, [NativeTypeName("DWORD")] uint cbData);

        [VtblIndex(9)]
        HRESULT GetSTILaunchInformation([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("DWORD *")] uint* pdwEventCode, [NativeTypeName("LPWSTR")] char* pwszEventName);

        [VtblIndex(10)]
        HRESULT RegisterLaunchApplication([NativeTypeName("LPWSTR")] char* pwszAppName, [NativeTypeName("LPWSTR")] char* pwszCommandLine);

        [VtblIndex(11)]
        HRESULT UnregisterLaunchApplication([NativeTypeName("LPWSTR")] char* pwszAppName);

        [VtblIndex(12)]
        HRESULT EnableHwNotifications([NativeTypeName("LPCWSTR")] char* pwszDeviceName, BOOL bNewState);

        [VtblIndex(13)]
        HRESULT GetHwNotificationState([NativeTypeName("LPCWSTR")] char* pwszDeviceName, BOOL* pbCurrentState);

        [VtblIndex(14)]
        HRESULT RefreshDeviceBus([NativeTypeName("LPCWSTR")] char* pwszDeviceName);

        [VtblIndex(15)]
        HRESULT LaunchApplicationForDevice([NativeTypeName("LPWSTR")] char* pwszDeviceName, [NativeTypeName("LPWSTR")] char* pwszAppName, [NativeTypeName("LPSTINOTIFY")] STINOTIFY* pStiNotify);

        [VtblIndex(16)]
        HRESULT SetupDeviceParameters([NativeTypeName("PSTI_DEVICE_INFORMATIONW")] STI_DEVICE_INFORMATIONW* param0);

        [VtblIndex(17)]
        HRESULT WriteToErrorLog([NativeTypeName("DWORD")] uint dwMessageType, [NativeTypeName("LPCWSTR")] char* pszMessage);
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

        [NativeTypeName("HRESULT (HINSTANCE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HINSTANCE, uint, int> Initialize;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *, LPVOID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint*, void**, int> GetDeviceList;

        [NativeTypeName("HRESULT (LPWSTR, LPVOID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void**, int> GetDeviceInfo;

        [NativeTypeName("HRESULT (LPWSTR, DWORD, PSTIDEVICE *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, IStiDevice**, IUnknown*, int> CreateDevice;

        [NativeTypeName("HRESULT (LPWSTR, LPWSTR, LPDWORD, LPBYTE, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint*, byte*, uint*, int> GetDeviceValue;

        [NativeTypeName("HRESULT (LPWSTR, LPWSTR, DWORD, LPBYTE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, byte*, uint, int> SetDeviceValue;

        [NativeTypeName("HRESULT (LPWSTR, DWORD *, LPWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, char*, int> GetSTILaunchInformation;

        [NativeTypeName("HRESULT (LPWSTR, LPWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> RegisterLaunchApplication;

        [NativeTypeName("HRESULT (LPWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> UnregisterLaunchApplication;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL, int> EnableHwNotifications;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, int> GetHwNotificationState;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> RefreshDeviceBus;

        [NativeTypeName("HRESULT (LPWSTR, LPWSTR, LPSTINOTIFY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, STINOTIFY*, int> LaunchApplicationForDevice;

        [NativeTypeName("HRESULT (PSTI_DEVICE_INFORMATIONW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STI_DEVICE_INFORMATIONW*, int> SetupDeviceParameters;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> WriteToErrorLog;
    }
}
