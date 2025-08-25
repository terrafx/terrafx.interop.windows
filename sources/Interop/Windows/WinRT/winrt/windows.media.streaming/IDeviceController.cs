// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceController.xml' path='doc/member[@name="IDeviceController"]/*' />
[Guid("4FEEB26D-50A7-402B-896A-BE95064D6BFF")]
[NativeTypeName("struct IDeviceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceController : IDeviceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDeviceController);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, uint>)(lpVtbl[1]))((IDeviceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, uint>)(lpVtbl[2]))((IDeviceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, HSTRING*, int>)(lpVtbl[4]))((IDeviceController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceController.xml' path='doc/member[@name="IDeviceController.get_CachedDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CachedDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIBasicDevice_t **")] IVector<Pointer<IBasicDevice>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, IVector<Pointer<IBasicDevice>>**, int>)(lpVtbl[6]))((IDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceController.xml' path='doc/member[@name="IDeviceController.AddDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddDevice(HSTRING uniqueDeviceName)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, HSTRING, int>)(lpVtbl[7]))((IDeviceController*)Unsafe.AsPointer(ref this), uniqueDeviceName);
    }

    /// <include file='IDeviceController.xml' path='doc/member[@name="IDeviceController.RemoveDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveDevice([NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* device)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, IBasicDevice*, int>)(lpVtbl[8]))((IDeviceController*)Unsafe.AsPointer(ref this), device);
    }

    /// <include file='IDeviceController.xml' path='doc/member[@name="IDeviceController.add_DeviceArrival"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_DeviceArrival([NativeTypeName("ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *")] IDeviceControllerFinderHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, IDeviceControllerFinderHandler*, EventRegistrationToken*, int>)(lpVtbl[9]))((IDeviceController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDeviceController.xml' path='doc/member[@name="IDeviceController.remove_DeviceArrival"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_DeviceArrival(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, EventRegistrationToken, int>)(lpVtbl[10]))((IDeviceController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDeviceController.xml' path='doc/member[@name="IDeviceController.add_DeviceDeparture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_DeviceDeparture([NativeTypeName("ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *")] IDeviceControllerFinderHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, IDeviceControllerFinderHandler*, EventRegistrationToken*, int>)(lpVtbl[11]))((IDeviceController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDeviceController.xml' path='doc/member[@name="IDeviceController.remove_DeviceDeparture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_DeviceDeparture(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceController*, EventRegistrationToken, int>)(lpVtbl[12]))((IDeviceController*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CachedDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIBasicDevice_t **")] IVector<Pointer<IBasicDevice>>** value);

        [VtblIndex(7)]
        HRESULT AddDevice(HSTRING uniqueDeviceName);

        [VtblIndex(8)]
        HRESULT RemoveDevice([NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* device);

        [VtblIndex(9)]
        HRESULT add_DeviceArrival([NativeTypeName("ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *")] IDeviceControllerFinderHandler* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_DeviceArrival(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_DeviceDeparture([NativeTypeName("ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *")] IDeviceControllerFinderHandler* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_DeviceDeparture(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CStreaming__CIBasicDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IBasicDevice>>**, int> get_CachedDevices;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AddDevice;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IBasicDevice *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBasicDevice*, int> RemoveDevice;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceControllerFinderHandler*, EventRegistrationToken*, int> add_DeviceArrival;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DeviceArrival;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IDeviceControllerFinderHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceControllerFinderHandler*, EventRegistrationToken*, int> add_DeviceDeparture;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DeviceDeparture;
    }
}
