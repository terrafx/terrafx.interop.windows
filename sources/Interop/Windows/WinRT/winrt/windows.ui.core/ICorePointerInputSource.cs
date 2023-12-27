// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource"]/*' />
[Guid("BBF1BB18-E47A-48EB-8807-F8F8D3EA4551")]
[NativeTypeName("struct ICorePointerInputSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICorePointerInputSource : ICorePointerInputSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICorePointerInputSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, Guid*, void**, int>)(lpVtbl[0]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, uint>)(lpVtbl[1]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, uint>)(lpVtbl[2]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, uint*, Guid**, int>)(lpVtbl[3]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, HSTRING*, int>)(lpVtbl[4]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, TrustLevel*, int>)(lpVtbl[5]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.ReleasePointerCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReleasePointerCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, int>)(lpVtbl[6]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.SetPointerCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPointerCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, int>)(lpVtbl[7]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.get_HasCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_HasCapture([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, byte*, int>)(lpVtbl[8]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.get_PointerPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PointerPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, Point*, int>)(lpVtbl[9]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.get_PointerCursor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor **")] ICoreCursor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ICoreCursor**, int>)(lpVtbl[10]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.put_PointerCursor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor *")] ICoreCursor* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ICoreCursor*, int>)(lpVtbl[11]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.add_PointerCaptureLost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_PointerCaptureLost([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.remove_PointerCaptureLost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_PointerCaptureLost(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[13]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.add_PointerEntered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_PointerEntered([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.remove_PointerEntered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_PointerEntered(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[15]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.add_PointerExited"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_PointerExited([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.remove_PointerExited"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_PointerExited(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[17]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.add_PointerMoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_PointerMoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[18]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.remove_PointerMoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_PointerMoved(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[19]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.add_PointerPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_PointerPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[20]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.remove_PointerPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_PointerPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[21]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.add_PointerReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT add_PointerReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[22]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.remove_PointerReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT remove_PointerReleased(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[23]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.add_PointerWheelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_PointerWheelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[24]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerInputSource.xml' path='doc/member[@name="ICorePointerInputSource.remove_PointerWheelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_PointerWheelChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerInputSource*, EventRegistrationToken, int>)(lpVtbl[25]))((ICorePointerInputSource*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReleasePointerCapture();

        [VtblIndex(7)]
        HRESULT SetPointerCapture();

        [VtblIndex(8)]
        HRESULT get_HasCapture([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_PointerPosition([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(10)]
        HRESULT get_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor **")] ICoreCursor** value);

        [VtblIndex(11)]
        HRESULT put_PointerCursor([NativeTypeName("ABI::Windows::UI::Core::ICoreCursor *")] ICoreCursor* value);

        [VtblIndex(12)]
        HRESULT add_PointerCaptureLost([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(13)]
        HRESULT remove_PointerCaptureLost(EventRegistrationToken cookie);

        [VtblIndex(14)]
        HRESULT add_PointerEntered([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(15)]
        HRESULT remove_PointerEntered(EventRegistrationToken cookie);

        [VtblIndex(16)]
        HRESULT add_PointerExited([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(17)]
        HRESULT remove_PointerExited(EventRegistrationToken cookie);

        [VtblIndex(18)]
        HRESULT add_PointerMoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(19)]
        HRESULT remove_PointerMoved(EventRegistrationToken cookie);

        [VtblIndex(20)]
        HRESULT add_PointerPressed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(21)]
        HRESULT remove_PointerPressed(EventRegistrationToken cookie);

        [VtblIndex(22)]
        HRESULT add_PointerReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(23)]
        HRESULT remove_PointerReleased(EventRegistrationToken cookie);

        [VtblIndex(24)]
        HRESULT add_PointerWheelChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(25)]
        HRESULT remove_PointerWheelChanged(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReleasePointerCapture;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SetPointerCapture;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasCapture;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_PointerPosition;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreCursor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreCursor**, int> get_PointerCursor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreCursor *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreCursor*, int> put_PointerCursor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerCaptureLost;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerCaptureLost;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerEntered;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerEntered;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerExited;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerExited;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerMoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerMoved;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerReleased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerReleased;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IInspectable>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerWheelChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerWheelChanged;
    }
}
