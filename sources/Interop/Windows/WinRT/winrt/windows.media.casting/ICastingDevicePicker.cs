// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker"]/*' />
[Guid("DCD39924-0591-49BE-AACB-4B82EE756A95")]
[NativeTypeName("struct ICastingDevicePicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICastingDevicePicker : ICastingDevicePicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICastingDevicePicker);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, Guid*, void**, int>)(lpVtbl[0]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, uint>)(lpVtbl[1]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, uint>)(lpVtbl[2]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, uint*, Guid**, int>)(lpVtbl[3]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, HSTRING*, int>)(lpVtbl[4]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, TrustLevel*, int>)(lpVtbl[5]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.get_Filter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Filter([NativeTypeName("ABI::Windows::Media::Casting::ICastingDevicePickerFilter **")] ICastingDevicePickerFilter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, ICastingDevicePickerFilter**, int>)(lpVtbl[6]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.get_Appearance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Appearance([NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **")] IDevicePickerAppearance** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, IDevicePickerAppearance**, int>)(lpVtbl[7]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.add_CastingDeviceSelected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_CastingDeviceSelected([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_Windows__CMedia__CCasting__CCastingDeviceSelectedEventArgs_t *")] ITypedEventHandler<Pointer<ICastingDevicePicker>, Pointer<ICastingDeviceSelectedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, ITypedEventHandler<Pointer<ICastingDevicePicker>, Pointer<ICastingDeviceSelectedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.remove_CastingDeviceSelected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_CastingDeviceSelected(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, EventRegistrationToken, int>)(lpVtbl[9]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.add_CastingDevicePickerDismissed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_CastingDevicePickerDismissed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_IInspectable_t *")] ITypedEventHandler<Pointer<ICastingDevicePicker>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, ITypedEventHandler<Pointer<ICastingDevicePicker>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.remove_CastingDevicePickerDismissed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_CastingDevicePickerDismissed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, EventRegistrationToken, int>)(lpVtbl[11]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.Show"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Show([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, Rect, int>)(lpVtbl[12]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), selection);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.ShowWithPlacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ShowWithPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, Rect, Placement, int>)(lpVtbl[13]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this), selection, preferredPlacement);
    }

    /// <include file='ICastingDevicePicker.xml' path='doc/member[@name="ICastingDevicePicker.Hide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Hide()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevicePicker*, int>)(lpVtbl[14]))((ICastingDevicePicker*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Filter([NativeTypeName("ABI::Windows::Media::Casting::ICastingDevicePickerFilter **")] ICastingDevicePickerFilter** value);

        [VtblIndex(7)]
        HRESULT get_Appearance([NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **")] IDevicePickerAppearance** value);

        [VtblIndex(8)]
        HRESULT add_CastingDeviceSelected([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_Windows__CMedia__CCasting__CCastingDeviceSelectedEventArgs_t *")] ITypedEventHandler<Pointer<ICastingDevicePicker>, Pointer<ICastingDeviceSelectedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_CastingDeviceSelected(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_CastingDevicePickerDismissed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_IInspectable_t *")] ITypedEventHandler<Pointer<ICastingDevicePicker>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_CastingDevicePickerDismissed(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT Show([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection);

        [VtblIndex(13)]
        HRESULT ShowWithPlacement([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement);

        [VtblIndex(14)]
        HRESULT Hide();
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::ICastingDevicePickerFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICastingDevicePickerFilter**, int> get_Filter;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDevicePickerAppearance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDevicePickerAppearance**, int> get_Appearance;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_Windows__CMedia__CCasting__CCastingDeviceSelectedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICastingDevicePicker>, Pointer<ICastingDeviceSelectedEventArgs>>*, EventRegistrationToken*, int> add_CastingDeviceSelected;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CastingDeviceSelected;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingDevicePicker_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICastingDevicePicker>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_CastingDevicePickerDismissed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CastingDevicePickerDismissed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, int> Show;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, Placement, int> ShowWithPlacement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Hide;
    }
}
