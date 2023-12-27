// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo"]/*' />
[Guid("31DC02BC-990A-4904-AA96-FE364381F136")]
[NativeTypeName("struct IAppBroadcastBackgroundServiceStreamInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastBackgroundServiceStreamInfo : IAppBroadcastBackgroundServiceStreamInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastBackgroundServiceStreamInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, uint>)(lpVtbl[1]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, uint>)(lpVtbl[2]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.get_StreamState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StreamState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastStreamState *")] AppBroadcastStreamState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, AppBroadcastStreamState*, int>)(lpVtbl[6]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.put_DesiredVideoEncodingBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredVideoEncodingBitrate([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, ulong, int>)(lpVtbl[7]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.get_DesiredVideoEncodingBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DesiredVideoEncodingBitrate([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, ulong*, int>)(lpVtbl[8]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.put_BandwidthTestBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BandwidthTestBitrate([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, ulong, int>)(lpVtbl[9]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.get_BandwidthTestBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BandwidthTestBitrate([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, ulong*, int>)(lpVtbl[10]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.put_AudioCodec"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AudioCodec(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, HSTRING, int>)(lpVtbl[11]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.get_AudioCodec"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AudioCodec(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, HSTRING*, int>)(lpVtbl[12]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.get_BroadcastStreamReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BroadcastStreamReader([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamReader **")] IAppBroadcastStreamReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, IAppBroadcastStreamReader**, int>)(lpVtbl[13]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.add_StreamStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_StreamStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IAppBroadcastStreamStateChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IAppBroadcastStreamStateChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.remove_StreamStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_StreamStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, EventRegistrationToken, int>)(lpVtbl[15]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.add_VideoEncodingResolutionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_VideoEncodingResolutionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.remove_VideoEncodingResolutionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_VideoEncodingResolutionChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, EventRegistrationToken, int>)(lpVtbl[17]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.add_VideoEncodingBitrateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_VideoEncodingBitrateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[18]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastBackgroundServiceStreamInfo.xml' path='doc/member[@name="IAppBroadcastBackgroundServiceStreamInfo.remove_VideoEncodingBitrateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_VideoEncodingBitrateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastBackgroundServiceStreamInfo*, EventRegistrationToken, int>)(lpVtbl[19]))((IAppBroadcastBackgroundServiceStreamInfo*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StreamState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastStreamState *")] AppBroadcastStreamState* value);

        [VtblIndex(7)]
        HRESULT put_DesiredVideoEncodingBitrate([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(8)]
        HRESULT get_DesiredVideoEncodingBitrate([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(9)]
        HRESULT put_BandwidthTestBitrate([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(10)]
        HRESULT get_BandwidthTestBitrate([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(11)]
        HRESULT put_AudioCodec(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_AudioCodec(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_BroadcastStreamReader([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamReader **")] IAppBroadcastStreamReader** value);

        [VtblIndex(14)]
        HRESULT add_StreamStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IAppBroadcastStreamStateChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_StreamStateChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_VideoEncodingResolutionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_VideoEncodingResolutionChanged(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_VideoEncodingBitrateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(19)]
        HRESULT remove_VideoEncodingBitrateChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastStreamState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastStreamState*, int> get_StreamState;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_DesiredVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_DesiredVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_BandwidthTestBitrate;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_BandwidthTestBitrate;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AudioCodec;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioCodec;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastStreamReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastStreamReader**, int> get_BroadcastStreamReader;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IAppBroadcastStreamStateChangedEventArgs>>*, EventRegistrationToken*, int> add_StreamStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StreamStateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_VideoEncodingResolutionChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VideoEncodingResolutionChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundServiceStreamInfo_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppBroadcastBackgroundServiceStreamInfo>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_VideoEncodingBitrateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VideoEncodingBitrateChanged;
    }
}
