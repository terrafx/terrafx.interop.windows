// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoTrack.xml' path='doc/member[@name="IVideoTrack"]/*' />
[Guid("99F3B7F3-E298-4396-BB6A-A51BE6A2A20A")]
[NativeTypeName("struct IVideoTrack : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoTrack : IVideoTrack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoTrack));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, Guid*, void**, int>)(lpVtbl[0]))((IVideoTrack*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, uint>)(lpVtbl[1]))((IVideoTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, uint>)(lpVtbl[2]))((IVideoTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoTrack*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, HSTRING*, int>)(lpVtbl[4]))((IVideoTrack*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, TrustLevel*, int>)(lpVtbl[5]))((IVideoTrack*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoTrack.xml' path='doc/member[@name="IVideoTrack.add_OpenFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_OpenFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CVideoTrack_Windows__CMedia__CCore__CVideoTrackOpenFailedEventArgs_t *")] ITypedEventHandler<Pointer<IVideoTrack>, Pointer<IVideoTrackOpenFailedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, ITypedEventHandler<Pointer<IVideoTrack>, Pointer<IVideoTrackOpenFailedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IVideoTrack*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IVideoTrack.xml' path='doc/member[@name="IVideoTrack.remove_OpenFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_OpenFailed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, EventRegistrationToken, int>)(lpVtbl[7]))((IVideoTrack*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IVideoTrack.xml' path='doc/member[@name="IVideoTrack.GetEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, IVideoEncodingProperties**, int>)(lpVtbl[8]))((IVideoTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTrack.xml' path='doc/member[@name="IVideoTrack.get_PlaybackItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PlaybackItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, IMediaPlaybackItem**, int>)(lpVtbl[9]))((IVideoTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTrack.xml' path='doc/member[@name="IVideoTrack.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, HSTRING*, int>)(lpVtbl[10]))((IVideoTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTrack.xml' path='doc/member[@name="IVideoTrack.get_SupportInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SupportInfo([NativeTypeName("ABI::Windows::Media::Core::IVideoTrackSupportInfo **")] IVideoTrackSupportInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrack*, IVideoTrackSupportInfo**, int>)(lpVtbl[11]))((IVideoTrack*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_OpenFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CVideoTrack_Windows__CMedia__CCore__CVideoTrackOpenFailedEventArgs_t *")] ITypedEventHandler<Pointer<IVideoTrack>, Pointer<IVideoTrackOpenFailedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_OpenFailed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT GetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value);

        [VtblIndex(9)]
        HRESULT get_PlaybackItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);

        [VtblIndex(10)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_SupportInfo([NativeTypeName("ABI::Windows::Media::Core::IVideoTrackSupportInfo **")] IVideoTrackSupportInfo** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CVideoTrack_Windows__CMedia__CCore__CVideoTrackOpenFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IVideoTrack>, Pointer<IVideoTrackOpenFailedEventArgs>>*, EventRegistrationToken*, int> add_OpenFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OpenFailed;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties**, int> GetEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> get_PlaybackItem;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IVideoTrackSupportInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoTrackSupportInfo**, int> get_SupportInfo;
    }
}
