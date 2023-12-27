// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEdgeGesture.xml' path='doc/member[@name="IEdgeGesture"]/*' />
[Guid("580D5292-2AB1-49AA-A7F0-33BD3F8DF9F1")]
[NativeTypeName("struct IEdgeGesture : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEdgeGesture : IEdgeGesture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEdgeGesture));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, Guid*, void**, int>)(lpVtbl[0]))((IEdgeGesture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, uint>)(lpVtbl[1]))((IEdgeGesture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, uint>)(lpVtbl[2]))((IEdgeGesture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, uint*, Guid**, int>)(lpVtbl[3]))((IEdgeGesture*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, HSTRING*, int>)(lpVtbl[4]))((IEdgeGesture*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, TrustLevel*, int>)(lpVtbl[5]))((IEdgeGesture*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEdgeGesture.xml' path='doc/member[@name="IEdgeGesture.add_Starting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Starting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IEdgeGesture*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IEdgeGesture.xml' path='doc/member[@name="IEdgeGesture.remove_Starting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Starting(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, EventRegistrationToken, int>)(lpVtbl[7]))((IEdgeGesture*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IEdgeGesture.xml' path='doc/member[@name="IEdgeGesture.add_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Completed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IEdgeGesture*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IEdgeGesture.xml' path='doc/member[@name="IEdgeGesture.remove_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Completed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, EventRegistrationToken, int>)(lpVtbl[9]))((IEdgeGesture*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IEdgeGesture.xml' path='doc/member[@name="IEdgeGesture.add_Canceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_Canceled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IEdgeGesture*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IEdgeGesture.xml' path='doc/member[@name="IEdgeGesture.remove_Canceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_Canceled(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEdgeGesture*, EventRegistrationToken, int>)(lpVtbl[11]))((IEdgeGesture*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Starting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Starting(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Completed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Completed(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_Canceled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *")] ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_Canceled(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>*, EventRegistrationToken*, int> add_Starting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Starting;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>*, EventRegistrationToken*, int> add_Completed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Completed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CInput__CEdgeGesture_Windows__CUI__CInput__CEdgeGestureEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IEdgeGesture>, Pointer<IEdgeGestureEventArgs>>*, EventRegistrationToken*, int> add_Canceled;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Canceled;
    }
}
