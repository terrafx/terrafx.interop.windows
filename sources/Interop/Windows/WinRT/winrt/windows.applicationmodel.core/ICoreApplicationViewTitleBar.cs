// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar"]/*' />
[Guid("006D35E3-E1F1-431B-9508-29B96926AC53")]
[NativeTypeName("struct ICoreApplicationViewTitleBar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreApplicationViewTitleBar : ICoreApplicationViewTitleBar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreApplicationViewTitleBar));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, uint>)(lpVtbl[1]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, uint>)(lpVtbl[2]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, HSTRING*, int>)(lpVtbl[4]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.put_ExtendViewIntoTitleBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ExtendViewIntoTitleBar([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, byte, int>)(lpVtbl[6]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.get_ExtendViewIntoTitleBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendViewIntoTitleBar([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, byte*, int>)(lpVtbl[7]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.get_SystemOverlayLeftInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SystemOverlayLeftInset(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, double*, int>)(lpVtbl[8]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.get_SystemOverlayRightInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SystemOverlayRightInset(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, double*, int>)(lpVtbl[9]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.get_Height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Height(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, double*, int>)(lpVtbl[10]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.add_LayoutMetricsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_LayoutMetricsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationViewTitleBar_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreApplicationViewTitleBar>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, ITypedEventHandler<Pointer<ICoreApplicationViewTitleBar>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.remove_LayoutMetricsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_LayoutMetricsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, EventRegistrationToken, int>)(lpVtbl[12]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.get_IsVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, byte*, int>)(lpVtbl[13]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.add_IsVisibleChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_IsVisibleChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationViewTitleBar_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreApplicationViewTitleBar>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, ITypedEventHandler<Pointer<ICoreApplicationViewTitleBar>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplicationViewTitleBar.xml' path='doc/member[@name="ICoreApplicationViewTitleBar.remove_IsVisibleChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_IsVisibleChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationViewTitleBar*, EventRegistrationToken, int>)(lpVtbl[15]))((ICoreApplicationViewTitleBar*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ExtendViewIntoTitleBar([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_ExtendViewIntoTitleBar([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_SystemOverlayLeftInset(double* value);

        [VtblIndex(9)]
        HRESULT get_SystemOverlayRightInset(double* value);

        [VtblIndex(10)]
        HRESULT get_Height(double* value);

        [VtblIndex(11)]
        HRESULT add_LayoutMetricsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationViewTitleBar_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreApplicationViewTitleBar>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_LayoutMetricsChanged(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT add_IsVisibleChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationViewTitleBar_IInspectable_t *")] ITypedEventHandler<Pointer<ICoreApplicationViewTitleBar>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_IsVisibleChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ExtendViewIntoTitleBar;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ExtendViewIntoTitleBar;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_SystemOverlayLeftInset;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_SystemOverlayRightInset;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Height;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationViewTitleBar_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreApplicationViewTitleBar>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_LayoutMetricsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LayoutMetricsChanged;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVisible;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationViewTitleBar_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreApplicationViewTitleBar>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_IsVisibleChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_IsVisibleChanged;
    }
}
