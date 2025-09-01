// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceAccessInformation.xml' path='doc/member[@name="IDeviceAccessInformation"]/*' />
[Guid("0BAA9A73-6DE5-4915-8DDD-9A0554A6F545")]
[NativeTypeName("struct IDeviceAccessInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceAccessInformation : IDeviceAccessInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDeviceAccessInformation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, uint>)(lpVtbl[1]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, uint>)(lpVtbl[2]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, HSTRING*, int>)(lpVtbl[4]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceAccessInformation.xml' path='doc/member[@name="IDeviceAccessInformation.add_AccessChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_AccessChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceAccessInformation_Windows__CDevices__CEnumeration__CDeviceAccessChangedEventArgs_t *")] ITypedEventHandler<Pointer<IDeviceAccessInformation>, Pointer<IDeviceAccessChangedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, ITypedEventHandler<Pointer<IDeviceAccessInformation>, Pointer<IDeviceAccessChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IDeviceAccessInformation.xml' path='doc/member[@name="IDeviceAccessInformation.remove_AccessChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_AccessChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, EventRegistrationToken, int>)(lpVtbl[7]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IDeviceAccessInformation.xml' path='doc/member[@name="IDeviceAccessInformation.get_CurrentStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CurrentStatus([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceAccessStatus *")] DeviceAccessStatus* status)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceAccessInformation*, DeviceAccessStatus*, int>)(lpVtbl[8]))((IDeviceAccessInformation*)Unsafe.AsPointer(ref this), status);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_AccessChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceAccessInformation_Windows__CDevices__CEnumeration__CDeviceAccessChangedEventArgs_t *")] ITypedEventHandler<Pointer<IDeviceAccessInformation>, Pointer<IDeviceAccessChangedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(7)]
        HRESULT remove_AccessChanged(EventRegistrationToken cookie);

        [VtblIndex(8)]
        HRESULT get_CurrentStatus([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceAccessStatus *")] DeviceAccessStatus* status);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceAccessInformation_Windows__CDevices__CEnumeration__CDeviceAccessChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDeviceAccessInformation>, Pointer<IDeviceAccessChangedEventArgs>>*, EventRegistrationToken*, int> add_AccessChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AccessChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DeviceAccessStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DeviceAccessStatus*, int> get_CurrentStatus;
    }
}
