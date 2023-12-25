// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer"]/*' />
[Guid("2C012EC3-D975-47FB-96AC-A6418B326D2B")]
[NativeTypeName("struct IMediaRenderer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaRenderer : IMediaRenderer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaRenderer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, Guid*, void**, int>)(lpVtbl[0]))((IMediaRenderer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, uint>)(lpVtbl[1]))((IMediaRenderer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, uint>)(lpVtbl[2]))((IMediaRenderer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaRenderer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, HSTRING*, int>)(lpVtbl[4]))((IMediaRenderer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, TrustLevel*, int>)(lpVtbl[5]))((IMediaRenderer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.get_IsAudioSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsAudioSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, byte*, int>)(lpVtbl[6]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.get_IsVideoSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsVideoSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, byte*, int>)(lpVtbl[7]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.get_IsImageSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsImageSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, byte*, int>)(lpVtbl[8]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.get_ActionInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ActionInformation([NativeTypeName("ABI::Windows::Media::Streaming::IMediaRendererActionInformation **")] IMediaRendererActionInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IMediaRendererActionInformation**, int>)(lpVtbl[9]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SetSourceFromUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSourceFromUriAsync(HSTRING URI, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, HSTRING, IAsyncOperation<uint>**, int>)(lpVtbl[10]))((IMediaRenderer*)Unsafe.AsPointer(ref this), URI, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SetSourceFromStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetSourceFromStreamAsync(IInspectable* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IInspectable*, IAsyncOperation<uint>**, int>)(lpVtbl[11]))((IMediaRenderer*)Unsafe.AsPointer(ref this), stream, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SetSourceFromMediaSourceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetSourceFromMediaSourceAsync(IInspectable* mediaSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IInspectable*, IAsyncOperation<uint>**, int>)(lpVtbl[12]))((IMediaRenderer*)Unsafe.AsPointer(ref this), mediaSource, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SetNextSourceFromUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetNextSourceFromUriAsync(HSTRING URI, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, HSTRING, IAsyncOperation<uint>**, int>)(lpVtbl[13]))((IMediaRenderer*)Unsafe.AsPointer(ref this), URI, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SetNextSourceFromStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetNextSourceFromStreamAsync(IInspectable* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IInspectable*, IAsyncOperation<uint>**, int>)(lpVtbl[14]))((IMediaRenderer*)Unsafe.AsPointer(ref this), stream, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SetNextSourceFromMediaSourceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetNextSourceFromMediaSourceAsync(IInspectable* mediaSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IInspectable*, IAsyncOperation<uint>**, int>)(lpVtbl[15]))((IMediaRenderer*)Unsafe.AsPointer(ref this), mediaSource, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.PlayAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PlayAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IAsyncAction**, int>)(lpVtbl[16]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.PlayAtSpeedAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PlayAtSpeedAsync([NativeTypeName("ABI::Windows::Media::Streaming::PlaySpeed")] PlaySpeed playSpeed, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, PlaySpeed, IAsyncAction**, int>)(lpVtbl[17]))((IMediaRenderer*)Unsafe.AsPointer(ref this), playSpeed, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.StopAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IAsyncAction**, int>)(lpVtbl[18]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.PauseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT PauseAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IAsyncAction**, int>)(lpVtbl[19]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.GetMuteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetMuteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IAsyncOperation<bool>**, int>)(lpVtbl[20]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SetMuteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetMuteAsync([NativeTypeName("boolean")] byte mute, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, byte, IAsyncAction**, int>)(lpVtbl[21]))((IMediaRenderer*)Unsafe.AsPointer(ref this), mute, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.GetVolumeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVolumeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IAsyncOperation<uint>**, int>)(lpVtbl[22]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SetVolumeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetVolumeAsync([NativeTypeName("UINT32")] uint volume, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, uint, IAsyncAction**, int>)(lpVtbl[23]))((IMediaRenderer*)Unsafe.AsPointer(ref this), volume, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.SeekAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SeekAsync([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan target, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, TimeSpan, IAsyncAction**, int>)(lpVtbl[24]))((IMediaRenderer*)Unsafe.AsPointer(ref this), target, value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.GetTransportInformationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetTransportInformationAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CTransportInformation_t **")] IAsyncOperation<TransportInformation>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IAsyncOperation<TransportInformation>**, int>)(lpVtbl[25]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.GetPositionInformationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetPositionInformationAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CPositionInformation_t **")] IAsyncOperation<PositionInformation>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IAsyncOperation<PositionInformation>**, int>)(lpVtbl[26]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.add_TransportParametersUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT add_TransportParametersUpdate([NativeTypeName("ABI::Windows::Media::Streaming::ITransportParametersUpdateHandler *")] ITransportParametersUpdateHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, ITransportParametersUpdateHandler*, EventRegistrationToken*, int>)(lpVtbl[27]))((IMediaRenderer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.remove_TransportParametersUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT remove_TransportParametersUpdate(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, EventRegistrationToken, int>)(lpVtbl[28]))((IMediaRenderer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.add_RenderingParametersUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_RenderingParametersUpdate([NativeTypeName("ABI::Windows::Media::Streaming::IRenderingParametersUpdateHandler *")] IRenderingParametersUpdateHandler* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IRenderingParametersUpdateHandler*, EventRegistrationToken*, int>)(lpVtbl[29]))((IMediaRenderer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.remove_RenderingParametersUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_RenderingParametersUpdate(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, EventRegistrationToken, int>)(lpVtbl[30]))((IMediaRenderer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaRenderer.xml' path='doc/member[@name="IMediaRenderer.NextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT NextAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRenderer*, IAsyncAction**, int>)(lpVtbl[31]))((IMediaRenderer*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsAudioSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsVideoSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsImageSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_ActionInformation([NativeTypeName("ABI::Windows::Media::Streaming::IMediaRendererActionInformation **")] IMediaRendererActionInformation** value);

        [VtblIndex(10)]
        HRESULT SetSourceFromUriAsync(HSTRING URI, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value);

        [VtblIndex(11)]
        HRESULT SetSourceFromStreamAsync(IInspectable* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value);

        [VtblIndex(12)]
        HRESULT SetSourceFromMediaSourceAsync(IInspectable* mediaSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value);

        [VtblIndex(13)]
        HRESULT SetNextSourceFromUriAsync(HSTRING URI, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value);

        [VtblIndex(14)]
        HRESULT SetNextSourceFromStreamAsync(IInspectable* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value);

        [VtblIndex(15)]
        HRESULT SetNextSourceFromMediaSourceAsync(IInspectable* mediaSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value);

        [VtblIndex(16)]
        HRESULT PlayAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(17)]
        HRESULT PlayAtSpeedAsync([NativeTypeName("ABI::Windows::Media::Streaming::PlaySpeed")] PlaySpeed playSpeed, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(18)]
        HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(19)]
        HRESULT PauseAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(20)]
        HRESULT GetMuteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** value);

        [VtblIndex(21)]
        HRESULT SetMuteAsync([NativeTypeName("boolean")] byte mute, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(22)]
        HRESULT GetVolumeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** value);

        [VtblIndex(23)]
        HRESULT SetVolumeAsync([NativeTypeName("UINT32")] uint volume, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(24)]
        HRESULT SeekAsync([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan target, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(25)]
        HRESULT GetTransportInformationAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CTransportInformation_t **")] IAsyncOperation<TransportInformation>** value);

        [VtblIndex(26)]
        HRESULT GetPositionInformationAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CPositionInformation_t **")] IAsyncOperation<PositionInformation>** value);

        [VtblIndex(27)]
        HRESULT add_TransportParametersUpdate([NativeTypeName("ABI::Windows::Media::Streaming::ITransportParametersUpdateHandler *")] ITransportParametersUpdateHandler* handler, EventRegistrationToken* token);

        [VtblIndex(28)]
        HRESULT remove_TransportParametersUpdate(EventRegistrationToken token);

        [VtblIndex(29)]
        HRESULT add_RenderingParametersUpdate([NativeTypeName("ABI::Windows::Media::Streaming::IRenderingParametersUpdateHandler *")] IRenderingParametersUpdateHandler* handler, EventRegistrationToken* token);

        [VtblIndex(30)]
        HRESULT remove_RenderingParametersUpdate(EventRegistrationToken token);

        [VtblIndex(31)]
        HRESULT NextAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);
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

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAudioSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVideoSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsImageSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IMediaRendererActionInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaRendererActionInformation**, int> get_ActionInformation;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<uint>**, int> SetSourceFromUriAsync;

        [NativeTypeName("HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, IAsyncOperation<uint>**, int> SetSourceFromStreamAsync;

        [NativeTypeName("HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, IAsyncOperation<uint>**, int> SetSourceFromMediaSourceAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<uint>**, int> SetNextSourceFromUriAsync;

        [NativeTypeName("HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, IAsyncOperation<uint>**, int> SetNextSourceFromStreamAsync;

        [NativeTypeName("HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, IAsyncOperation<uint>**, int> SetNextSourceFromMediaSourceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> PlayAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::PlaySpeed, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PlaySpeed, IAsyncAction**, int> PlayAtSpeedAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StopAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> PauseAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> GetMuteAsync;

        [NativeTypeName("HRESULT (::boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, IAsyncAction**, int> SetMuteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<uint>**, int> GetVolumeAsync;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAsyncAction**, int> SetVolumeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, IAsyncAction**, int> SeekAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CTransportInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<TransportInformation>**, int> GetTransportInformationAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CPositionInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<PositionInformation>**, int> GetPositionInformationAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::ITransportParametersUpdateHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITransportParametersUpdateHandler*, EventRegistrationToken*, int> add_TransportParametersUpdate;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TransportParametersUpdate;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IRenderingParametersUpdateHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRenderingParametersUpdateHandler*, EventRegistrationToken*, int> add_RenderingParametersUpdate;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RenderingParametersUpdate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> NextAsync;
    }
}
