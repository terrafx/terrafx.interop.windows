// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance"]/*' />
[Guid("E69A12C6-E627-4ED8-9B6C-460AF445E56D")]
[NativeTypeName("struct IDevicePickerAppearance : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDevicePickerAppearance : IDevicePickerAppearance.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDevicePickerAppearance);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Guid*, void**, int>)(lpVtbl[0]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, uint>)(lpVtbl[1]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, uint>)(lpVtbl[2]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, uint*, Guid**, int>)(lpVtbl[3]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, HSTRING*, int>)(lpVtbl[4]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, TrustLevel*, int>)(lpVtbl[5]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, HSTRING*, int>)(lpVtbl[6]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, HSTRING, int>)(lpVtbl[7]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.get_ForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color*, int>)(lpVtbl[8]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.put_ForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color, int>)(lpVtbl[9]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.get_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color*, int>)(lpVtbl[10]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.put_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color, int>)(lpVtbl[11]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.get_AccentColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AccentColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color*, int>)(lpVtbl[12]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.put_AccentColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_AccentColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color, int>)(lpVtbl[13]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.get_SelectedForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SelectedForegroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color*, int>)(lpVtbl[14]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.put_SelectedForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_SelectedForegroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color, int>)(lpVtbl[15]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.get_SelectedBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SelectedBackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color*, int>)(lpVtbl[16]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.put_SelectedBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_SelectedBackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color, int>)(lpVtbl[17]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.get_SelectedAccentColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SelectedAccentColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color*, int>)(lpVtbl[18]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePickerAppearance.xml' path='doc/member[@name="IDevicePickerAppearance.put_SelectedAccentColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_SelectedAccentColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePickerAppearance*, Color, int>)(lpVtbl[19]))((IDevicePickerAppearance*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(10)]
        HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(11)]
        HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(12)]
        HRESULT get_AccentColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(13)]
        HRESULT put_AccentColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(14)]
        HRESULT get_SelectedForegroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(15)]
        HRESULT put_SelectedForegroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(16)]
        HRESULT get_SelectedBackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(17)]
        HRESULT put_SelectedBackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(18)]
        HRESULT get_SelectedAccentColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(19)]
        HRESULT put_SelectedAccentColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_AccentColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_AccentColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_SelectedForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_SelectedForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_SelectedBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_SelectedBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_SelectedAccentColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_SelectedAccentColor;
    }
}
