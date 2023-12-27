// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2"]/*' />
[Guid("F8BA7C79-1FC8-4097-AD70-C0FA18CC0050")]
[NativeTypeName("struct IMediaPlaybackSession2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackSession2 : IMediaPlaybackSession2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackSession2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, uint>)(lpVtbl[1]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, uint>)(lpVtbl[2]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.add_BufferedRangesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_BufferedRangesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.remove_BufferedRangesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_BufferedRangesChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.add_PlayedRangesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_PlayedRangesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.remove_PlayedRangesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_PlayedRangesChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, EventRegistrationToken, int>)(lpVtbl[9]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.add_SeekableRangesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_SeekableRangesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.remove_SeekableRangesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_SeekableRangesChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.add_SupportedPlaybackRatesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_SupportedPlaybackRatesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.remove_SupportedPlaybackRatesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_SupportedPlaybackRatesChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, EventRegistrationToken, int>)(lpVtbl[13]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.get_SphericalVideoProjection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SphericalVideoProjection([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSphericalVideoProjection **")] IMediaPlaybackSphericalVideoProjection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, IMediaPlaybackSphericalVideoProjection**, int>)(lpVtbl[14]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.get_IsMirroring"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsMirroring([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, byte*, int>)(lpVtbl[15]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.put_IsMirroring"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsMirroring([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, byte, int>)(lpVtbl[16]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.GetBufferedRanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetBufferedRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **")] IVectorView<MediaTimeRange>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, IVectorView<MediaTimeRange>**, int>)(lpVtbl[17]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.GetPlayedRanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetPlayedRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **")] IVectorView<MediaTimeRange>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, IVectorView<MediaTimeRange>**, int>)(lpVtbl[18]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.GetSeekableRanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetSeekableRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **")] IVectorView<MediaTimeRange>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, IVectorView<MediaTimeRange>**, int>)(lpVtbl[19]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSession2.xml' path='doc/member[@name="IMediaPlaybackSession2.IsSupportedPlaybackRateRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsSupportedPlaybackRateRange(double rate1, double rate2, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSession2*, double, double, byte*, int>)(lpVtbl[20]))((IMediaPlaybackSession2*)Unsafe.AsPointer(ref this), rate1, rate2, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_BufferedRangesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_BufferedRangesChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_PlayedRangesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_PlayedRangesChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_SeekableRangesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_SeekableRangesChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_SupportedPlaybackRatesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_SupportedPlaybackRatesChanged(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT get_SphericalVideoProjection([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSphericalVideoProjection **")] IMediaPlaybackSphericalVideoProjection** value);

        [VtblIndex(15)]
        HRESULT get_IsMirroring([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_IsMirroring([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT GetBufferedRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **")] IVectorView<MediaTimeRange>** value);

        [VtblIndex(18)]
        HRESULT GetPlayedRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **")] IVectorView<MediaTimeRange>** value);

        [VtblIndex(19)]
        HRESULT GetSeekableRanges([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **")] IVectorView<MediaTimeRange>** value);

        [VtblIndex(20)]
        HRESULT IsSupportedPlaybackRateRange(double rate1, double rate2, [NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_BufferedRangesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BufferedRangesChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_PlayedRangesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlayedRangesChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SeekableRangesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SeekableRangesChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SupportedPlaybackRatesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SupportedPlaybackRatesChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSphericalVideoProjection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackSphericalVideoProjection**, int> get_SphericalVideoProjection;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMirroring;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsMirroring;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<MediaTimeRange>**, int> GetBufferedRanges;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<MediaTimeRange>**, int> GetPlayedRanges;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaTimeRange_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<MediaTimeRange>**, int> GetSeekableRanges;

        [NativeTypeName("HRESULT (DOUBLE, DOUBLE, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, double, byte*, int> IsSupportedPlaybackRateRange;
    }
}
