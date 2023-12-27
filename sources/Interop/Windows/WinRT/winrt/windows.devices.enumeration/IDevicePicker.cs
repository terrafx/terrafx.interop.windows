// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker"]/*' />
[Guid("84997AA2-034A-4440-8813-7D0BD479BF5A")]
[NativeTypeName("struct IDevicePicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDevicePicker : IDevicePicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDevicePicker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, Guid*, void**, int>)(lpVtbl[0]))((IDevicePicker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, uint>)(lpVtbl[1]))((IDevicePicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, uint>)(lpVtbl[2]))((IDevicePicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, uint*, Guid**, int>)(lpVtbl[3]))((IDevicePicker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, HSTRING*, int>)(lpVtbl[4]))((IDevicePicker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, TrustLevel*, int>)(lpVtbl[5]))((IDevicePicker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.get_Filter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Filter([NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerFilter **")] IDevicePickerFilter** filter)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, IDevicePickerFilter**, int>)(lpVtbl[6]))((IDevicePicker*)Unsafe.AsPointer(ref this), filter);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.get_Appearance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Appearance([NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **")] IDevicePickerAppearance** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, IDevicePickerAppearance**, int>)(lpVtbl[7]))((IDevicePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.get_RequestedProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RequestedProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, IVector<HSTRING>**, int>)(lpVtbl[8]))((IDevicePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.add_DeviceSelected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_DeviceSelected([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceSelectedEventArgs_t *")] ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IDeviceSelectedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IDeviceSelectedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IDevicePicker*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.remove_DeviceSelected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_DeviceSelected(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, EventRegistrationToken, int>)(lpVtbl[10]))((IDevicePicker*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.add_DisconnectButtonClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_DisconnectButtonClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceDisconnectButtonClickedEventArgs_t *")] ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IDeviceDisconnectButtonClickedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IDeviceDisconnectButtonClickedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IDevicePicker*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.remove_DisconnectButtonClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_DisconnectButtonClicked(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, EventRegistrationToken, int>)(lpVtbl[12]))((IDevicePicker*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.add_DevicePickerDismissed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_DevicePickerDismissed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_IInspectable_t *")] ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IDevicePicker*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.remove_DevicePickerDismissed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_DevicePickerDismissed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, EventRegistrationToken, int>)(lpVtbl[14]))((IDevicePicker*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.Show"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Show([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, Rect, int>)(lpVtbl[15]))((IDevicePicker*)Unsafe.AsPointer(ref this), selection);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.ShowWithPlacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ShowWithPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement placement)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, Rect, Placement, int>)(lpVtbl[16]))((IDevicePicker*)Unsafe.AsPointer(ref this), selection, placement);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.PickSingleDeviceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PickSingleDeviceAsync([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, Rect, IAsyncOperation<Pointer<IDeviceInformation>>**, int>)(lpVtbl[17]))((IDevicePicker*)Unsafe.AsPointer(ref this), selection, operation);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.PickSingleDeviceAsyncWithPlacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT PickSingleDeviceAsyncWithPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement placement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, Rect, Placement, IAsyncOperation<Pointer<IDeviceInformation>>**, int>)(lpVtbl[18]))((IDevicePicker*)Unsafe.AsPointer(ref this), selection, placement, operation);
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.Hide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Hide()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, int>)(lpVtbl[19]))((IDevicePicker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDevicePicker.xml' path='doc/member[@name="IDevicePicker.SetDisplayStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetDisplayStatus([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device, HSTRING status, [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePickerDisplayStatusOptions")] DevicePickerDisplayStatusOptions options)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePicker*, IDeviceInformation*, HSTRING, DevicePickerDisplayStatusOptions, int>)(lpVtbl[20]))((IDevicePicker*)Unsafe.AsPointer(ref this), device, status, options);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Filter([NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerFilter **")] IDevicePickerFilter** filter);

        [VtblIndex(7)]
        HRESULT get_Appearance([NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **")] IDevicePickerAppearance** value);

        [VtblIndex(8)]
        HRESULT get_RequestedProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(9)]
        HRESULT add_DeviceSelected([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceSelectedEventArgs_t *")] ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IDeviceSelectedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_DeviceSelected(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_DisconnectButtonClicked([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceDisconnectButtonClickedEventArgs_t *")] ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IDeviceDisconnectButtonClickedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_DisconnectButtonClicked(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_DevicePickerDismissed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_IInspectable_t *")] ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_DevicePickerDismissed(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT Show([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection);

        [VtblIndex(16)]
        HRESULT ShowWithPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement placement);

        [VtblIndex(17)]
        HRESULT PickSingleDeviceAsync([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** operation);

        [VtblIndex(18)]
        HRESULT PickSingleDeviceAsyncWithPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement placement, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IAsyncOperation<Pointer<IDeviceInformation>>** operation);

        [VtblIndex(19)]
        HRESULT Hide();

        [VtblIndex(20)]
        HRESULT SetDisplayStatus([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device, HSTRING status, [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePickerDisplayStatusOptions")] DevicePickerDisplayStatusOptions options);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDevicePickerFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDevicePickerFilter**, int> get_Filter;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDevicePickerAppearance**, int> get_Appearance;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_RequestedProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceSelectedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IDeviceSelectedEventArgs>>*, EventRegistrationToken*, int> add_DeviceSelected;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DeviceSelected;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_Windows__CDevices__CEnumeration__CDeviceDisconnectButtonClickedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IDeviceDisconnectButtonClickedEventArgs>>*, EventRegistrationToken*, int> add_DisconnectButtonClicked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DisconnectButtonClicked;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDevicePicker_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDevicePicker>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_DevicePickerDismissed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DevicePickerDismissed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, int> Show;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, Placement, int> ShowWithPlacement;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, IAsyncOperation<Pointer<IDeviceInformation>>**, int> PickSingleDeviceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, Placement, IAsyncOperation<Pointer<IDeviceInformation>>**, int> PickSingleDeviceAsyncWithPlacement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Hide;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation *, HSTRING, ABI::Windows::Devices::Enumeration::DevicePickerDisplayStatusOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation*, HSTRING, DevicePickerDisplayStatusOptions, int> SetDisplayStatus;
    }
}
