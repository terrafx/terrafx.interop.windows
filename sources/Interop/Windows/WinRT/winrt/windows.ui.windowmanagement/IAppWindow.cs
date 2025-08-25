// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow"]/*' />
[Guid("663014A6-B75E-5DBD-995C-F0117FA3FB61")]
[NativeTypeName("struct IAppWindow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindow : IAppWindow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppWindow);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, Guid*, void**, int>)(lpVtbl[0]))((IAppWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, uint>)(lpVtbl[1]))((IAppWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, uint>)(lpVtbl[2]))((IAppWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, uint*, Guid**, int>)(lpVtbl[3]))((IAppWindow*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, HSTRING*, int>)(lpVtbl[4]))((IAppWindow*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, TrustLevel*, int>)(lpVtbl[5]))((IAppWindow*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content([NativeTypeName("ABI::Windows::UI::IUIContentRoot **")] IUIContentRoot** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IUIContentRoot**, int>)(lpVtbl[6]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_DispatcherQueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IDispatcherQueue**, int>)(lpVtbl[7]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_Frame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Frame([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowFrame **")] IAppWindowFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IAppWindowFrame**, int>)(lpVtbl[8]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_IsVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, byte*, int>)(lpVtbl[9]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_PersistedStateId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PersistedStateId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, HSTRING*, int>)(lpVtbl[10]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.put_PersistedStateId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PersistedStateId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, HSTRING, int>)(lpVtbl[11]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_Presenter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Presenter([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPresenter **")] IAppWindowPresenter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IAppWindowPresenter**, int>)(lpVtbl[12]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, HSTRING*, int>)(lpVtbl[13]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, HSTRING, int>)(lpVtbl[14]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_TitleBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_TitleBar([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowTitleBar **")] IAppWindowTitleBar** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IAppWindowTitleBar**, int>)(lpVtbl[15]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_UIContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_UIContext([NativeTypeName("ABI::Windows::UI::IUIContext **")] IUIContext** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IUIContext**, int>)(lpVtbl[16]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.get_WindowingEnvironment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_WindowingEnvironment([NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")] IWindowingEnvironment** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IWindowingEnvironment**, int>)(lpVtbl[17]))((IAppWindow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.CloseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CloseAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IAsyncAction**, int>)(lpVtbl[18]))((IAppWindow*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.GetPlacement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetPlacement([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPlacement **")] IAppWindowPlacement** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IAppWindowPlacement**, int>)(lpVtbl[19]))((IAppWindow*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.GetDisplayRegions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDisplayRegions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **")] IVectorView<Pointer<IDisplayRegion>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IVectorView<Pointer<IDisplayRegion>>**, int>)(lpVtbl[20]))((IAppWindow*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.RequestMoveToDisplayRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RequestMoveToDisplayRegion([NativeTypeName("ABI::Windows::UI::WindowManagement::IDisplayRegion *")] IDisplayRegion* displayRegion)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IDisplayRegion*, int>)(lpVtbl[21]))((IAppWindow*)Unsafe.AsPointer(ref this), displayRegion);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.RequestMoveAdjacentToCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT RequestMoveAdjacentToCurrentView()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, int>)(lpVtbl[22]))((IAppWindow*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.RequestMoveAdjacentToWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT RequestMoveAdjacentToWindow([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindow *")] IAppWindow* anchorWindow)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IAppWindow*, int>)(lpVtbl[23]))((IAppWindow*)Unsafe.AsPointer(ref this), anchorWindow);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.RequestMoveRelativeToWindowContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT RequestMoveRelativeToWindowContent([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindow *")] IAppWindow* anchorWindow, [NativeTypeName("ABI::Windows::Foundation::Point")] Point contentOffset)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IAppWindow*, Point, int>)(lpVtbl[24]))((IAppWindow*)Unsafe.AsPointer(ref this), anchorWindow, contentOffset);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.RequestMoveRelativeToCurrentViewContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT RequestMoveRelativeToCurrentViewContent([NativeTypeName("ABI::Windows::Foundation::Point")] Point contentOffset)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, Point, int>)(lpVtbl[25]))((IAppWindow*)Unsafe.AsPointer(ref this), contentOffset);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.RequestMoveRelativeToDisplayRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT RequestMoveRelativeToDisplayRegion([NativeTypeName("ABI::Windows::UI::WindowManagement::IDisplayRegion *")] IDisplayRegion* displayRegion, [NativeTypeName("ABI::Windows::Foundation::Point")] Point displayRegionOffset)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IDisplayRegion*, Point, int>)(lpVtbl[26]))((IAppWindow*)Unsafe.AsPointer(ref this), displayRegion, displayRegionOffset);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.RequestSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT RequestSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size frameSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, Size, int>)(lpVtbl[27]))((IAppWindow*)Unsafe.AsPointer(ref this), frameSize);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.TryShowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT TryShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, IAsyncOperation<bool>**, int>)(lpVtbl[28]))((IAppWindow*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.add_Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_Changed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowChangedEventArgs_t *")] ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[29]))((IAppWindow*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.remove_Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_Changed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, EventRegistrationToken, int>)(lpVtbl[30]))((IAppWindow*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.add_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowClosedEventArgs_t *")] ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowClosedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowClosedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[31]))((IAppWindow*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.remove_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, EventRegistrationToken, int>)(lpVtbl[32]))((IAppWindow*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.add_CloseRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT add_CloseRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowCloseRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowCloseRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowCloseRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[33]))((IAppWindow*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppWindow.xml' path='doc/member[@name="IAppWindow.remove_CloseRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT remove_CloseRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindow*, EventRegistrationToken, int>)(lpVtbl[34]))((IAppWindow*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content([NativeTypeName("ABI::Windows::UI::IUIContentRoot **")] IUIContentRoot** value);

        [VtblIndex(7)]
        HRESULT get_DispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** value);

        [VtblIndex(8)]
        HRESULT get_Frame([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowFrame **")] IAppWindowFrame** value);

        [VtblIndex(9)]
        HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_PersistedStateId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_PersistedStateId(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Presenter([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPresenter **")] IAppWindowPresenter** value);

        [VtblIndex(13)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_TitleBar([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowTitleBar **")] IAppWindowTitleBar** value);

        [VtblIndex(16)]
        HRESULT get_UIContext([NativeTypeName("ABI::Windows::UI::IUIContext **")] IUIContext** value);

        [VtblIndex(17)]
        HRESULT get_WindowingEnvironment([NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")] IWindowingEnvironment** value);

        [VtblIndex(18)]
        HRESULT CloseAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(19)]
        HRESULT GetPlacement([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPlacement **")] IAppWindowPlacement** result);

        [VtblIndex(20)]
        HRESULT GetDisplayRegions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **")] IVectorView<Pointer<IDisplayRegion>>** result);

        [VtblIndex(21)]
        HRESULT RequestMoveToDisplayRegion([NativeTypeName("ABI::Windows::UI::WindowManagement::IDisplayRegion *")] IDisplayRegion* displayRegion);

        [VtblIndex(22)]
        HRESULT RequestMoveAdjacentToCurrentView();

        [VtblIndex(23)]
        HRESULT RequestMoveAdjacentToWindow([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindow *")] IAppWindow* anchorWindow);

        [VtblIndex(24)]
        HRESULT RequestMoveRelativeToWindowContent([NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindow *")] IAppWindow* anchorWindow, [NativeTypeName("ABI::Windows::Foundation::Point")] Point contentOffset);

        [VtblIndex(25)]
        HRESULT RequestMoveRelativeToCurrentViewContent([NativeTypeName("ABI::Windows::Foundation::Point")] Point contentOffset);

        [VtblIndex(26)]
        HRESULT RequestMoveRelativeToDisplayRegion([NativeTypeName("ABI::Windows::UI::WindowManagement::IDisplayRegion *")] IDisplayRegion* displayRegion, [NativeTypeName("ABI::Windows::Foundation::Point")] Point displayRegionOffset);

        [VtblIndex(27)]
        HRESULT RequestSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size frameSize);

        [VtblIndex(28)]
        HRESULT TryShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(29)]
        HRESULT add_Changed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowChangedEventArgs_t *")] ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(30)]
        HRESULT remove_Changed(EventRegistrationToken token);

        [VtblIndex(31)]
        HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowClosedEventArgs_t *")] ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowClosedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(32)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(33)]
        HRESULT add_CloseRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowCloseRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowCloseRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(34)]
        HRESULT remove_CloseRequested(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::IUIContentRoot **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUIContentRoot**, int> get_Content;

        [NativeTypeName("HRESULT (ABI::Windows::System::IDispatcherQueue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatcherQueue**, int> get_DispatcherQueue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppWindowFrame**, int> get_Frame;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVisible;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PersistedStateId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PersistedStateId;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowPresenter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppWindowPresenter**, int> get_Presenter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowTitleBar **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppWindowTitleBar**, int> get_TitleBar;

        [NativeTypeName("HRESULT (ABI::Windows::UI::IUIContext **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUIContext**, int> get_UIContext;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IWindowingEnvironment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWindowingEnvironment**, int> get_WindowingEnvironment;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> CloseAsync;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowPlacement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppWindowPlacement**, int> GetPlacement;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IDisplayRegion>>**, int> GetDisplayRegions;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IDisplayRegion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayRegion*, int> RequestMoveToDisplayRegion;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RequestMoveAdjacentToCurrentView;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IAppWindow *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppWindow*, int> RequestMoveAdjacentToWindow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IAppWindow *, ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppWindow*, Point, int> RequestMoveRelativeToWindowContent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, int> RequestMoveRelativeToCurrentViewContent;

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowManagement::IDisplayRegion *, ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDisplayRegion*, Point, int> RequestMoveRelativeToDisplayRegion;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, int> RequestSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> TryShowAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowChangedEventArgs>>*, EventRegistrationToken*, int> add_Changed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Changed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowClosedEventArgs>>*, EventRegistrationToken*, int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowCloseRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppWindow>, Pointer<IAppWindowCloseRequestedEventArgs>>*, EventRegistrationToken*, int> add_CloseRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CloseRequested;
    }
}
