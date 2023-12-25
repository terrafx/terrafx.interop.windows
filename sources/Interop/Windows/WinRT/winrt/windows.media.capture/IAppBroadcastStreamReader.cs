// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader"]/*' />
[Guid("B338BCF9-3364-4460-B5F1-3CC2796A8AA2")]
[NativeTypeName("struct IAppBroadcastStreamReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastStreamReader : IAppBroadcastStreamReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastStreamReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint>)(lpVtbl[1]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint>)(lpVtbl[2]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.get_AudioChannels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AudioChannels([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint*, int>)(lpVtbl[6]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.get_AudioSampleRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AudioSampleRate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint*, int>)(lpVtbl[7]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.get_AudioAacSequence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AudioAacSequence([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, IBuffer**, int>)(lpVtbl[8]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.get_AudioBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AudioBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint*, int>)(lpVtbl[9]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.TryGetNextAudioFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryGetNextAudioFrame([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamAudioFrame **")] IAppBroadcastStreamAudioFrame** frame)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, IAppBroadcastStreamAudioFrame**, int>)(lpVtbl[10]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), frame);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.get_VideoWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_VideoWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint*, int>)(lpVtbl[11]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.get_VideoHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_VideoHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint*, int>)(lpVtbl[12]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.get_VideoBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_VideoBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, uint*, int>)(lpVtbl[13]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.TryGetNextVideoFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT TryGetNextVideoFrame([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamVideoFrame **")] IAppBroadcastStreamVideoFrame** frame)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, IAppBroadcastStreamVideoFrame**, int>)(lpVtbl[14]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), frame);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.add_AudioFrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_AudioFrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastStreamReader_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.remove_AudioFrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_AudioFrameArrived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, EventRegistrationToken, int>)(lpVtbl[16]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.add_VideoFrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_VideoFrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastStreamReader_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppBroadcastStreamReader.xml' path='doc/member[@name="IAppBroadcastStreamReader.remove_VideoFrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_VideoFrameArrived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamReader*, EventRegistrationToken, int>)(lpVtbl[18]))((IAppBroadcastStreamReader*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AudioChannels([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_AudioSampleRate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_AudioAacSequence([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT get_AudioBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT TryGetNextAudioFrame([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamAudioFrame **")] IAppBroadcastStreamAudioFrame** frame);

        [VtblIndex(11)]
        HRESULT get_VideoWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT get_VideoHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_VideoBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT TryGetNextVideoFrame([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamVideoFrame **")] IAppBroadcastStreamVideoFrame** frame);

        [VtblIndex(15)]
        HRESULT add_AudioFrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastStreamReader_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_AudioFrameArrived(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_VideoFrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastStreamReader_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_VideoFrameArrived(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_AudioChannels;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_AudioSampleRate;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_AudioAacSequence;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_AudioBitrate;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastStreamAudioFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastStreamAudioFrame**, int> TryGetNextAudioFrame;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_VideoWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_VideoHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_VideoBitrate;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastStreamVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastStreamVideoFrame**, int> TryGetNextVideoFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastStreamReader_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_AudioFrameArrived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AudioFrameArrived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastStreamReader_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_VideoFrameArrived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VideoFrameArrived;
    }
}
