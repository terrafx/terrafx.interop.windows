// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaSource4.xml' path='doc/member[@name="IMediaSource4"]/*' />
[Guid("BDAFAD57-8EFF-4C63-85A6-84DE0AE3E4F2")]
[NativeTypeName("struct IMediaSource4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaSource4 : IMediaSource4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaSource4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSource4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, uint>)(lpVtbl[1]))((IMediaSource4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, uint>)(lpVtbl[2]))((IMediaSource4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaSource4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, HSTRING*, int>)(lpVtbl[4]))((IMediaSource4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, TrustLevel*, int>)(lpVtbl[5]))((IMediaSource4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaSource4.xml' path='doc/member[@name="IMediaSource4.get_AdaptiveMediaSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AdaptiveMediaSource([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **")] IAdaptiveMediaSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, IAdaptiveMediaSource**, int>)(lpVtbl[6]))((IMediaSource4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSource4.xml' path='doc/member[@name="IMediaSource4.get_MediaStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, IMediaStreamSource**, int>)(lpVtbl[7]))((IMediaSource4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSource4.xml' path='doc/member[@name="IMediaSource4.get_MseStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MseStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMseStreamSource **")] IMseStreamSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, IMseStreamSource**, int>)(lpVtbl[8]))((IMediaSource4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSource4.xml' path='doc/member[@name="IMediaSource4.get_Uri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, IUriRuntimeClass**, int>)(lpVtbl[9]))((IMediaSource4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSource4.xml' path='doc/member[@name="IMediaSource4.OpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource4*, IAsyncAction**, int>)(lpVtbl[10]))((IMediaSource4*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AdaptiveMediaSource([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **")] IAdaptiveMediaSource** value);

        [VtblIndex(7)]
        HRESULT get_MediaStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value);

        [VtblIndex(8)]
        HRESULT get_MseStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMseStreamSource **")] IMseStreamSource** value);

        [VtblIndex(9)]
        HRESULT get_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(10)]
        HRESULT OpenAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveMediaSource**, int> get_AdaptiveMediaSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSource**, int> get_MediaStreamSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMseStreamSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMseStreamSource**, int> get_MseStreamSource;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_Uri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> OpenAsync;
    }
}
