// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice"]/*' />
[Guid("EFA8F889-CFFA-59F4-97E4-74705B7DC490")]
[NativeTypeName("struct IPhoneLineTransportDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineTransportDevice : IPhoneLineTransportDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLineTransportDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, uint>)(lpVtbl[1]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, uint>)(lpVtbl[2]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, HSTRING*, int>)(lpVtbl[4]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, HSTRING*, int>)(lpVtbl[6]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.get_Transport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Transport([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *")] PhoneLineTransport* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, PhoneLineTransport*, int>)(lpVtbl[7]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **")] IAsyncOperation<DeviceAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, IAsyncOperation<DeviceAccessStatus>**, int>)(lpVtbl[8]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.RegisterApp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterApp()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, int>)(lpVtbl[9]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.RegisterAppForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterAppForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, IUser*, int>)(lpVtbl[10]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), user);
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.UnregisterApp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnregisterApp()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, int>)(lpVtbl[11]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.UnregisterAppForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnregisterAppForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, IUser*, int>)(lpVtbl[12]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), user);
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.IsRegistered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsRegistered([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, byte*, int>)(lpVtbl[13]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.Connect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Connect([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, byte*, int>)(lpVtbl[14]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneLineTransportDevice.xml' path='doc/member[@name="IPhoneLineTransportDevice.ConnectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ConnectAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDevice*, IAsyncOperation<bool>**, int>)(lpVtbl[15]))((IPhoneLineTransportDevice*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Transport([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *")] PhoneLineTransport* value);

        [VtblIndex(8)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **")] IAsyncOperation<DeviceAccessStatus>** operation);

        [VtblIndex(9)]
        HRESULT RegisterApp();

        [VtblIndex(10)]
        HRESULT RegisterAppForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user);

        [VtblIndex(11)]
        HRESULT UnregisterApp();

        [VtblIndex(12)]
        HRESULT UnregisterAppForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user);

        [VtblIndex(13)]
        HRESULT IsRegistered([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(14)]
        HRESULT Connect([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(15)]
        HRESULT ConnectAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneLineTransport*, int> get_Transport;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<DeviceAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RegisterApp;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, int> RegisterAppForUser;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> UnregisterApp;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, int> UnregisterAppForUser;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsRegistered;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> Connect;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> ConnectAsync;
    }
}
