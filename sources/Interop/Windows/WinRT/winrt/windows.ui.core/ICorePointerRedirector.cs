// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICorePointerRedirector.xml' path='doc/member[@name="ICorePointerRedirector"]/*' />
[Guid("8F9D0C94-5688-4B0C-A9F1-F931F7FA3DC3")]
[NativeTypeName("struct ICorePointerRedirector : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICorePointerRedirector : ICorePointerRedirector.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICorePointerRedirector);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, Guid*, void**, int>)(lpVtbl[0]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, uint>)(lpVtbl[1]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, uint>)(lpVtbl[2]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, uint*, Guid**, int>)(lpVtbl[3]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, HSTRING*, int>)(lpVtbl[4]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, TrustLevel*, int>)(lpVtbl[5]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICorePointerRedirector.xml' path='doc/member[@name="ICorePointerRedirector.add_PointerRoutedAway"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_PointerRoutedAway([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerRedirector.xml' path='doc/member[@name="ICorePointerRedirector.remove_PointerRoutedAway"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_PointerRoutedAway(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, EventRegistrationToken, int>)(lpVtbl[7]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICorePointerRedirector.xml' path='doc/member[@name="ICorePointerRedirector.add_PointerRoutedTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_PointerRoutedTo([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerRedirector.xml' path='doc/member[@name="ICorePointerRedirector.remove_PointerRoutedTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_PointerRoutedTo(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, EventRegistrationToken, int>)(lpVtbl[9]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICorePointerRedirector.xml' path='doc/member[@name="ICorePointerRedirector.add_PointerRoutedReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_PointerRoutedReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICorePointerRedirector.xml' path='doc/member[@name="ICorePointerRedirector.remove_PointerRoutedReleased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_PointerRoutedReleased(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICorePointerRedirector*, EventRegistrationToken, int>)(lpVtbl[11]))((ICorePointerRedirector*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_PointerRoutedAway([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(7)]
        HRESULT remove_PointerRoutedAway(EventRegistrationToken cookie);

        [VtblIndex(8)]
        HRESULT add_PointerRoutedTo([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(9)]
        HRESULT remove_PointerRoutedTo(EventRegistrationToken cookie);

        [VtblIndex(10)]
        HRESULT add_PointerRoutedReleased([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *")] ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(11)]
        HRESULT remove_PointerRoutedReleased(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerRoutedAway;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerRoutedAway;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerRoutedTo;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerRoutedTo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CICorePointerRedirector_Windows__CUI__CCore__CPointerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICorePointerRedirector>, Pointer<IPointerEventArgs>>*, EventRegistrationToken*, int> add_PointerRoutedReleased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PointerRoutedReleased;
    }
}
