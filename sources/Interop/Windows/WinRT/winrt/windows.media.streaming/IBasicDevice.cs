// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice"]/*' />
[Guid("F4F26CBB-7962-48B7-80F7-C3A5D753BCB0")]
[NativeTypeName("struct IBasicDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBasicDevice : IBasicDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBasicDevice);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, Guid*, void**, int>)(lpVtbl[0]))((IBasicDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, uint>)(lpVtbl[1]))((IBasicDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, uint>)(lpVtbl[2]))((IBasicDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, uint*, Guid**, int>)(lpVtbl[3]))((IBasicDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[4]))((IBasicDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, TrustLevel*, int>)(lpVtbl[5]))((IBasicDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[6]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.put_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FriendlyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING, int>)(lpVtbl[7]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_ManufacturerName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ManufacturerName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[8]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_ManufacturerUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ManufacturerUrl(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[9]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_UniqueDeviceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UniqueDeviceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[10]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_ModelName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ModelName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[11]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_ModelNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ModelNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[12]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_ModelUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ModelUrl(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[13]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[14]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_SerialNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SerialNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[15]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_PresentationUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_PresentationUrl(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, HSTRING*, int>)(lpVtbl[16]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_RemoteStreamingUrls"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RemoteStreamingUrls([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, IVector<HSTRING>**, int>)(lpVtbl[17]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_PhysicalAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_PhysicalAddresses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, IVector<HSTRING>**, int>)(lpVtbl[18]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_IpAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_IpAddresses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, IVector<HSTRING>**, int>)(lpVtbl[19]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_CanWakeDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_CanWakeDevices([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, byte*, int>)(lpVtbl[20]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_DiscoveredOnCurrentNetwork"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_DiscoveredOnCurrentNetwork([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, byte*, int>)(lpVtbl[21]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Media::Streaming::DeviceTypes *")] DeviceTypes* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, DeviceTypes*, int>)(lpVtbl[22]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_Icons"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Icons([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIDeviceIcon_t **")] IVector<Pointer<IDeviceIcon>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, IVector<Pointer<IDeviceIcon>>**, int>)(lpVtbl[23]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.get_ConnectionStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_ConnectionStatus([NativeTypeName("ABI::Windows::Media::Streaming::ConnectionStatus *")] ConnectionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, ConnectionStatus*, int>)(lpVtbl[24]))((IBasicDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.add_ConnectionStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT add_ConnectionStatusChanged([NativeTypeName("ABI::Windows::Media::Streaming::IConnectionStatusHandler *")] IConnectionStatusHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, IConnectionStatusHandler*, EventRegistrationToken*, int>)(lpVtbl[25]))((IBasicDevice*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBasicDevice.xml' path='doc/member[@name="IBasicDevice.remove_ConnectionStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT remove_ConnectionStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicDevice*, EventRegistrationToken, int>)(lpVtbl[26]))((IBasicDevice*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FriendlyName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_FriendlyName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_ManufacturerName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_ManufacturerUrl(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_UniqueDeviceName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_ModelName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_ModelNumber(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_ModelUrl(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_SerialNumber(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_PresentationUrl(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_RemoteStreamingUrls([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(18)]
        HRESULT get_PhysicalAddresses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(19)]
        HRESULT get_IpAddresses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(20)]
        HRESULT get_CanWakeDevices([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT get_DiscoveredOnCurrentNetwork([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Media::Streaming::DeviceTypes *")] DeviceTypes* value);

        [VtblIndex(23)]
        HRESULT get_Icons([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIDeviceIcon_t **")] IVector<Pointer<IDeviceIcon>>** value);

        [VtblIndex(24)]
        HRESULT get_ConnectionStatus([NativeTypeName("ABI::Windows::Media::Streaming::ConnectionStatus *")] ConnectionStatus* value);

        [VtblIndex(25)]
        HRESULT add_ConnectionStatusChanged([NativeTypeName("ABI::Windows::Media::Streaming::IConnectionStatusHandler *")] IConnectionStatusHandler* handler, EventRegistrationToken* token);

        [VtblIndex(26)]
        HRESULT remove_ConnectionStatusChanged(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ManufacturerName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ManufacturerUrl;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UniqueDeviceName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ModelName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ModelNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ModelUrl;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SerialNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PresentationUrl;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_RemoteStreamingUrls;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_PhysicalAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_IpAddresses;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanWakeDevices;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DiscoveredOnCurrentNetwork;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::DeviceTypes *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DeviceTypes*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIDeviceIcon_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IDeviceIcon>>**, int> get_Icons;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::ConnectionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ConnectionStatus*, int> get_ConnectionStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IConnectionStatusHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IConnectionStatusHandler*, EventRegistrationToken*, int> add_ConnectionStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ConnectionStatusChanged;
    }
}
