// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaBinder.xml' path='doc/member[@name="IMediaBinder"]/*' />
[Guid("2B7E40AA-DE07-424F-83F1-F1DE46C4FA2E")]
[NativeTypeName("struct IMediaBinder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaBinder : IMediaBinder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaBinder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBinder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, uint>)(lpVtbl[1]))((IMediaBinder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, uint>)(lpVtbl[2]))((IMediaBinder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaBinder*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, HSTRING*, int>)(lpVtbl[4]))((IMediaBinder*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, TrustLevel*, int>)(lpVtbl[5]))((IMediaBinder*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaBinder.xml' path='doc/member[@name="IMediaBinder.add_Binding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Binding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaBinder_Windows__CMedia__CCore__CMediaBindingEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBinder>, Pointer<IMediaBindingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, ITypedEventHandler<Pointer<IMediaBinder>, Pointer<IMediaBindingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaBinder*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaBinder.xml' path='doc/member[@name="IMediaBinder.remove_Binding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Binding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaBinder*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaBinder.xml' path='doc/member[@name="IMediaBinder.get_Token"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Token(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, HSTRING*, int>)(lpVtbl[8]))((IMediaBinder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBinder.xml' path='doc/member[@name="IMediaBinder.put_Token"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Token(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, HSTRING, int>)(lpVtbl[9]))((IMediaBinder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBinder.xml' path='doc/member[@name="IMediaBinder.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBinder*, IMediaSource2**, int>)(lpVtbl[10]))((IMediaBinder*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Binding([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaBinder_Windows__CMedia__CCore__CMediaBindingEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBinder>, Pointer<IMediaBindingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Binding(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_Token(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Token(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaBinder_Windows__CMedia__CCore__CMediaBindingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaBinder>, Pointer<IMediaBindingEventArgs>>*, EventRegistrationToken*, int> add_Binding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Binding;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Token;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Token;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource2**, int> get_Source;
    }
}
