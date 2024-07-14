// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar"]/*' />
[Guid("0FFCC5BF-98D0-4864-B1E8-B3F4020BE8B4")]
[NativeTypeName("struct IStatusBar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStatusBar : IStatusBar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStatusBar));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, Guid*, void**, int>)(lpVtbl[0]))((IStatusBar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, uint>)(lpVtbl[1]))((IStatusBar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, uint>)(lpVtbl[2]))((IStatusBar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, uint*, Guid**, int>)(lpVtbl[3]))((IStatusBar*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, HSTRING*, int>)(lpVtbl[4]))((IStatusBar*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, TrustLevel*, int>)(lpVtbl[5]))((IStatusBar*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.ShowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, IAsyncAction**, int>)(lpVtbl[6]))((IStatusBar*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.HideAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT HideAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, IAsyncAction**, int>)(lpVtbl[7]))((IStatusBar*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.get_BackgroundOpacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundOpacity(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, double*, int>)(lpVtbl[8]))((IStatusBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.put_BackgroundOpacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BackgroundOpacity(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, double, int>)(lpVtbl[9]))((IStatusBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.get_ForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, IReference<Color>**, int>)(lpVtbl[10]))((IStatusBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.put_ForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, IReference<Color>*, int>)(lpVtbl[11]))((IStatusBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.get_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, IReference<Color>**, int>)(lpVtbl[12]))((IStatusBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.put_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, IReference<Color>*, int>)(lpVtbl[13]))((IStatusBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.get_ProgressIndicator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ProgressIndicator([NativeTypeName("ABI::Windows::UI::ViewManagement::IStatusBarProgressIndicator **")] IStatusBarProgressIndicator** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, IStatusBarProgressIndicator**, int>)(lpVtbl[14]))((IStatusBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.get_OccludedRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_OccludedRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, Rect*, int>)(lpVtbl[15]))((IStatusBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.add_Showing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *")] ITypedEventHandler<Pointer<IStatusBar>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, ITypedEventHandler<Pointer<IStatusBar>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IStatusBar*)Unsafe.AsPointer(ref this), eventHandler, token);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.remove_Showing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_Showing(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, EventRegistrationToken, int>)(lpVtbl[17]))((IStatusBar*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.add_Hiding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_Hiding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *")] ITypedEventHandler<Pointer<IStatusBar>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, ITypedEventHandler<Pointer<IStatusBar>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[18]))((IStatusBar*)Unsafe.AsPointer(ref this), eventHandler, token);
    }

    /// <include file='IStatusBar.xml' path='doc/member[@name="IStatusBar.remove_Hiding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_Hiding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IStatusBar*, EventRegistrationToken, int>)(lpVtbl[19]))((IStatusBar*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue);

        [VtblIndex(7)]
        HRESULT HideAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue);

        [VtblIndex(8)]
        HRESULT get_BackgroundOpacity(double* value);

        [VtblIndex(9)]
        HRESULT put_BackgroundOpacity(double value);

        [VtblIndex(10)]
        HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(11)]
        HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(12)]
        HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(13)]
        HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(14)]
        HRESULT get_ProgressIndicator([NativeTypeName("ABI::Windows::UI::ViewManagement::IStatusBarProgressIndicator **")] IStatusBarProgressIndicator** value);

        [VtblIndex(15)]
        HRESULT get_OccludedRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(16)]
        HRESULT add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *")] ITypedEventHandler<Pointer<IStatusBar>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_Showing(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_Hiding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *")] ITypedEventHandler<Pointer<IStatusBar>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* token);

        [VtblIndex(19)]
        HRESULT remove_Hiding(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> ShowAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> HideAsync;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_BackgroundOpacity;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_BackgroundOpacity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::IStatusBarProgressIndicator **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStatusBarProgressIndicator**, int> get_ProgressIndicator;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_OccludedRect;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IStatusBar>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Showing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Showing;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IStatusBar>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Hiding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Hiding;
    }
}
