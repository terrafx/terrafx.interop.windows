// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaBindingEventArgs.xml' path='doc/member[@name="IMediaBindingEventArgs"]/*' />
[Guid("B61CB25A-1B6D-4630-A86D-2F0837F712E5")]
[NativeTypeName("struct IMediaBindingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaBindingEventArgs : IMediaBindingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaBindingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, uint>)(lpVtbl[1]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, uint>)(lpVtbl[2]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaBindingEventArgs.xml' path='doc/member[@name="IMediaBindingEventArgs.add_Canceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Canceled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaBindingEventArgs_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaBindingEventArgs>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, ITypedEventHandler<Pointer<IMediaBindingEventArgs>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaBindingEventArgs.xml' path='doc/member[@name="IMediaBindingEventArgs.remove_Canceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Canceled(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaBindingEventArgs.xml' path='doc/member[@name="IMediaBindingEventArgs.get_MediaBinder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MediaBinder([NativeTypeName("ABI::Windows::Media::Core::IMediaBinder **")] IMediaBinder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, IMediaBinder**, int>)(lpVtbl[8]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBindingEventArgs.xml' path='doc/member[@name="IMediaBindingEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, IDeferral**, int>)(lpVtbl[9]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), deferral);
    }

    /// <include file='IMediaBindingEventArgs.xml' path='doc/member[@name="IMediaBindingEventArgs.SetUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, IUriRuntimeClass*, int>)(lpVtbl[10]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), uri);
    }

    /// <include file='IMediaBindingEventArgs.xml' path='doc/member[@name="IMediaBindingEventArgs.SetStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, HSTRING contentType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, IRandomAccessStream*, HSTRING, int>)(lpVtbl[11]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), stream, contentType);
    }

    /// <include file='IMediaBindingEventArgs.xml' path='doc/member[@name="IMediaBindingEventArgs.SetStreamReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetStreamReference([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* stream, HSTRING contentType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBindingEventArgs*, IRandomAccessStreamReference*, HSTRING, int>)(lpVtbl[12]))((IMediaBindingEventArgs*)Unsafe.AsPointer(ref this), stream, contentType);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Canceled([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaBindingEventArgs_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaBindingEventArgs>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Canceled(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_MediaBinder([NativeTypeName("ABI::Windows::Media::Core::IMediaBinder **")] IMediaBinder** value);

        [VtblIndex(9)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** deferral);

        [VtblIndex(10)]
        HRESULT SetUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri);

        [VtblIndex(11)]
        HRESULT SetStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, HSTRING contentType);

        [VtblIndex(12)]
        HRESULT SetStreamReference([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* stream, HSTRING contentType);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaBindingEventArgs_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaBindingEventArgs>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Canceled;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Canceled;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaBinder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBinder**, int> get_MediaBinder;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> SetUri;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, HSTRING, int> SetStream;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, HSTRING, int> SetStreamReference;
    }
}
