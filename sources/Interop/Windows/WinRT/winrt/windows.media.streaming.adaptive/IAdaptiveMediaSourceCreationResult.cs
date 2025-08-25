// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSourceCreationResult.xml' path='doc/member[@name="IAdaptiveMediaSourceCreationResult"]/*' />
[Guid("4686B6B2-800F-4E31-9093-76D4782013E7")]
[NativeTypeName("struct IAdaptiveMediaSourceCreationResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceCreationResult : IAdaptiveMediaSourceCreationResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAdaptiveMediaSourceCreationResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, uint>)(lpVtbl[1]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, uint>)(lpVtbl[2]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSourceCreationResult.xml' path='doc/member[@name="IAdaptiveMediaSourceCreationResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceCreationStatus *")] AdaptiveMediaSourceCreationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, AdaptiveMediaSourceCreationStatus*, int>)(lpVtbl[6]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceCreationResult.xml' path='doc/member[@name="IAdaptiveMediaSourceCreationResult.get_MediaSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaSource([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **")] IAdaptiveMediaSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, IAdaptiveMediaSource**, int>)(lpVtbl[7]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceCreationResult.xml' path='doc/member[@name="IAdaptiveMediaSourceCreationResult.get_HttpResponseMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_HttpResponseMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")] IHttpResponseMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceCreationResult*, IHttpResponseMessage**, int>)(lpVtbl[8]))((IAdaptiveMediaSourceCreationResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceCreationStatus *")] AdaptiveMediaSourceCreationStatus* value);

        [VtblIndex(7)]
        HRESULT get_MediaSource([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **")] IAdaptiveMediaSource** value);

        [VtblIndex(8)]
        HRESULT get_HttpResponseMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")] IHttpResponseMessage** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceCreationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdaptiveMediaSourceCreationStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveMediaSource**, int> get_MediaSource;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpResponseMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpResponseMessage**, int> get_HttpResponseMessage;
    }
}
