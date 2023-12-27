// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioTrack.xml' path='doc/member[@name="IAudioTrack"]/*' />
[Guid("F23B6E77-3EF7-40DE-B943-068B1321701D")]
[NativeTypeName("struct IAudioTrack : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioTrack : IAudioTrack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioTrack));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, Guid*, void**, int>)(lpVtbl[0]))((IAudioTrack*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, uint>)(lpVtbl[1]))((IAudioTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, uint>)(lpVtbl[2]))((IAudioTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioTrack*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, HSTRING*, int>)(lpVtbl[4]))((IAudioTrack*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, TrustLevel*, int>)(lpVtbl[5]))((IAudioTrack*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioTrack.xml' path='doc/member[@name="IAudioTrack.add_OpenFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_OpenFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CAudioTrack_Windows__CMedia__CCore__CAudioTrackOpenFailedEventArgs_t *")] ITypedEventHandler<Pointer<IAudioTrack>, Pointer<IAudioTrackOpenFailedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, ITypedEventHandler<Pointer<IAudioTrack>, Pointer<IAudioTrackOpenFailedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAudioTrack*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioTrack.xml' path='doc/member[@name="IAudioTrack.remove_OpenFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_OpenFailed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, EventRegistrationToken, int>)(lpVtbl[7]))((IAudioTrack*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAudioTrack.xml' path='doc/member[@name="IAudioTrack.GetEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, IAudioEncodingProperties**, int>)(lpVtbl[8]))((IAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioTrack.xml' path='doc/member[@name="IAudioTrack.get_PlaybackItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PlaybackItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, IMediaPlaybackItem**, int>)(lpVtbl[9]))((IAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioTrack.xml' path='doc/member[@name="IAudioTrack.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, HSTRING*, int>)(lpVtbl[10]))((IAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioTrack.xml' path='doc/member[@name="IAudioTrack.get_SupportInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SupportInfo([NativeTypeName("ABI::Windows::Media::Core::IAudioTrackSupportInfo **")] IAudioTrackSupportInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrack*, IAudioTrackSupportInfo**, int>)(lpVtbl[11]))((IAudioTrack*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_OpenFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CAudioTrack_Windows__CMedia__CCore__CAudioTrackOpenFailedEventArgs_t *")] ITypedEventHandler<Pointer<IAudioTrack>, Pointer<IAudioTrackOpenFailedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_OpenFailed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT GetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(9)]
        HRESULT get_PlaybackItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);

        [VtblIndex(10)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_SupportInfo([NativeTypeName("ABI::Windows::Media::Core::IAudioTrackSupportInfo **")] IAudioTrackSupportInfo** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CAudioTrack_Windows__CMedia__CCore__CAudioTrackOpenFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioTrack>, Pointer<IAudioTrackOpenFailedEventArgs>>*, EventRegistrationToken*, int> add_OpenFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OpenFailed;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties**, int> GetEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> get_PlaybackItem;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IAudioTrackSupportInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioTrackSupportInfo**, int> get_SupportInfo;
    }
}
