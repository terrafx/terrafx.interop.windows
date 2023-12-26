// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource"]/*' />
[Guid("4C7332EF-D39F-4396-B4D9-043957A7C964")]
[NativeTypeName("struct IAdaptiveMediaSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSource : IAdaptiveMediaSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, uint>)(lpVtbl[1]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, uint>)(lpVtbl[2]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_IsLive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsLive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, byte*, int>)(lpVtbl[6]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_DesiredLiveOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DesiredLiveOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, TimeSpan*, int>)(lpVtbl[7]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.put_DesiredLiveOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DesiredLiveOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, TimeSpan, int>)(lpVtbl[8]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_InitialBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InitialBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, uint*, int>)(lpVtbl[9]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.put_InitialBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_InitialBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, uint, int>)(lpVtbl[10]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_CurrentDownloadBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CurrentDownloadBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, uint*, int>)(lpVtbl[11]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_CurrentPlaybackBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CurrentPlaybackBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, uint*, int>)(lpVtbl[12]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_AvailableBitrates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AvailableBitrates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **")] IVectorView<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, IVectorView<uint>**, int>)(lpVtbl[13]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_DesiredMinBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DesiredMinBitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, IReference<uint>**, int>)(lpVtbl[14]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.put_DesiredMinBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_DesiredMinBitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, IReference<uint>*, int>)(lpVtbl[15]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_DesiredMaxBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DesiredMaxBitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, IReference<uint>**, int>)(lpVtbl[16]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.put_DesiredMaxBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_DesiredMaxBitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, IReference<uint>*, int>)(lpVtbl[17]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_AudioOnlyPlayback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_AudioOnlyPlayback([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, byte*, int>)(lpVtbl[18]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_InboundBitsPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_InboundBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, ulong*, int>)(lpVtbl[19]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.get_InboundBitsPerSecondWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_InboundBitsPerSecondWindow([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, TimeSpan*, int>)(lpVtbl[20]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.put_InboundBitsPerSecondWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_InboundBitsPerSecondWindow([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, TimeSpan, int>)(lpVtbl[21]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.add_DownloadBitrateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT add_DownloadBitrateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadBitrateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[22]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.remove_DownloadBitrateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT remove_DownloadBitrateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, EventRegistrationToken, int>)(lpVtbl[23]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.add_PlaybackBitrateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_PlaybackBitrateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourcePlaybackBitrateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[24]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.remove_PlaybackBitrateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_PlaybackBitrateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, EventRegistrationToken, int>)(lpVtbl[25]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.add_DownloadRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT add_DownloadRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[26]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.remove_DownloadRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT remove_DownloadRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, EventRegistrationToken, int>)(lpVtbl[27]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.add_DownloadCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT add_DownloadCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadCompletedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[28]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.remove_DownloadCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT remove_DownloadCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, EventRegistrationToken, int>)(lpVtbl[29]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.add_DownloadFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT add_DownloadFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadFailedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[30]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAdaptiveMediaSource.xml' path='doc/member[@name="IAdaptiveMediaSource.remove_DownloadFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT remove_DownloadFailed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource*, EventRegistrationToken, int>)(lpVtbl[31]))((IAdaptiveMediaSource*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsLive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_DesiredLiveOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT put_DesiredLiveOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(9)]
        HRESULT get_InitialBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_InitialBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_CurrentDownloadBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT get_CurrentPlaybackBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_AvailableBitrates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **")] IVectorView<uint>** value);

        [VtblIndex(14)]
        HRESULT get_DesiredMinBitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(15)]
        HRESULT put_DesiredMinBitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(16)]
        HRESULT get_DesiredMaxBitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(17)]
        HRESULT put_DesiredMaxBitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(18)]
        HRESULT get_AudioOnlyPlayback([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT get_InboundBitsPerSecond([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(20)]
        HRESULT get_InboundBitsPerSecondWindow([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(21)]
        HRESULT put_InboundBitsPerSecondWindow([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(22)]
        HRESULT add_DownloadBitrateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadBitrateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(23)]
        HRESULT remove_DownloadBitrateChanged(EventRegistrationToken token);

        [VtblIndex(24)]
        HRESULT add_PlaybackBitrateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourcePlaybackBitrateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(25)]
        HRESULT remove_PlaybackBitrateChanged(EventRegistrationToken token);

        [VtblIndex(26)]
        HRESULT add_DownloadRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(27)]
        HRESULT remove_DownloadRequested(EventRegistrationToken token);

        [VtblIndex(28)]
        HRESULT add_DownloadCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadCompletedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(29)]
        HRESULT remove_DownloadCompleted(EventRegistrationToken token);

        [VtblIndex(30)]
        HRESULT add_DownloadFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadFailedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(31)]
        HRESULT remove_DownloadFailed(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsLive;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_DesiredLiveOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_DesiredLiveOffset;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_InitialBitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_InitialBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CurrentDownloadBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CurrentPlaybackBitrate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<uint>**, int> get_AvailableBitrates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_DesiredMinBitrate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_DesiredMinBitrate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_DesiredMaxBitrate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_DesiredMaxBitrate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AudioOnlyPlayback;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_InboundBitsPerSecond;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_InboundBitsPerSecondWindow;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_InboundBitsPerSecondWindow;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadBitrateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_DownloadBitrateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DownloadBitrateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourcePlaybackBitrateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PlaybackBitrateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlaybackBitrateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_DownloadRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DownloadRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_DownloadCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DownloadCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSource_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceDownloadFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_DownloadFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DownloadFailed;
    }
}
