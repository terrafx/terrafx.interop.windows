// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView"]/*' />
[Guid("D222D519-4361-451E-96C4-60F4F9742DB0")]
[NativeTypeName("struct IApplicationView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationView : IApplicationView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IApplicationView);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, uint>)(lpVtbl[1]))((IApplicationView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, uint>)(lpVtbl[2]))((IApplicationView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationView*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, HSTRING*, int>)(lpVtbl[4]))((IApplicationView*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationView*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Orientation([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewOrientation *")] ApplicationViewOrientation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, ApplicationViewOrientation*, int>)(lpVtbl[6]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.get_AdjacentToLeftDisplayEdge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AdjacentToLeftDisplayEdge([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, byte*, int>)(lpVtbl[7]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.get_AdjacentToRightDisplayEdge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AdjacentToRightDisplayEdge([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, byte*, int>)(lpVtbl[8]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.get_IsFullScreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("To check full screen mode, use IsFullScreenMode. To check if the view is adjacent to both edges, use AdjacentToLeftDisplayEdge and AdjacentToRightDisplayEdge. For more info, see MSDN.")]
    public HRESULT get_IsFullScreen([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, byte*, int>)(lpVtbl[9]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.get_IsOnLockScreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsOnLockScreen([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, byte*, int>)(lpVtbl[10]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.get_IsScreenCaptureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsScreenCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, byte*, int>)(lpVtbl[11]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.put_IsScreenCaptureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_IsScreenCaptureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, byte, int>)(lpVtbl[12]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, HSTRING, int>)(lpVtbl[13]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, HSTRING*, int>)(lpVtbl[14]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Id([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, int*, int>)(lpVtbl[15]))((IApplicationView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.add_Consolidated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_Consolidated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_Windows__CUI__CViewManagement__CApplicationViewConsolidatedEventArgs_t *")] ITypedEventHandler<Pointer<IApplicationView>, Pointer<IApplicationViewConsolidatedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, ITypedEventHandler<Pointer<IApplicationView>, Pointer<IApplicationViewConsolidatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IApplicationView*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IApplicationView.xml' path='doc/member[@name="IApplicationView.remove_Consolidated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_Consolidated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationView*, EventRegistrationToken, int>)(lpVtbl[17]))((IApplicationView*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Orientation([NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewOrientation *")] ApplicationViewOrientation* value);

        [VtblIndex(7)]
        HRESULT get_AdjacentToLeftDisplayEdge([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_AdjacentToRightDisplayEdge([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        [Obsolete("To check full screen mode, use IsFullScreenMode. To check if the view is adjacent to both edges, use AdjacentToLeftDisplayEdge and AdjacentToRightDisplayEdge. For more info, see MSDN.")]
        HRESULT get_IsFullScreen([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_IsOnLockScreen([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsScreenCaptureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_IsScreenCaptureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_Id([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(16)]
        HRESULT add_Consolidated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_Windows__CUI__CViewManagement__CApplicationViewConsolidatedEventArgs_t *")] ITypedEventHandler<Pointer<IApplicationView>, Pointer<IApplicationViewConsolidatedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_Consolidated(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewOrientation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationViewOrientation*, int> get_Orientation;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AdjacentToLeftDisplayEdge;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AdjacentToRightDisplayEdge;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("To check full screen mode, use IsFullScreenMode. To check if the view is adjacent to both edges, use AdjacentToLeftDisplayEdge and AdjacentToRightDisplayEdge. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsFullScreen;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsOnLockScreen;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsScreenCaptureEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsScreenCaptureEnabled;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_Windows__CUI__CViewManagement__CApplicationViewConsolidatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IApplicationView>, Pointer<IApplicationViewConsolidatedEventArgs>>*, EventRegistrationToken*, int> add_Consolidated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Consolidated;
    }
}
