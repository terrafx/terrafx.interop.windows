// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs"]/*' />
[Guid("C83FDFFD-44A9-47A2-BF96-03398B4BFAAF")]
[NativeTypeName("struct IAdaptiveMediaSourceDownloadRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceDownloadRequestedEventArgs : IAdaptiveMediaSourceDownloadRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceDownloadRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, uint>)(lpVtbl[1]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, uint>)(lpVtbl[2]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs.get_ResourceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResourceType([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceResourceType *")] AdaptiveMediaSourceResourceType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, AdaptiveMediaSourceResourceType*, int>)(lpVtbl[6]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs.get_ResourceUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResourceUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, IUriRuntimeClass**, int>)(lpVtbl[7]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs.get_ResourceByteRangeOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResourceByteRangeOffset([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, IReference<ulong>**, int>)(lpVtbl[8]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs.get_ResourceByteRangeLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ResourceByteRangeLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, IReference<ulong>**, int>)(lpVtbl[9]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs.get_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Result([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadResult **")] IAdaptiveMediaSourceDownloadResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, IAdaptiveMediaSourceDownloadResult**, int>)(lpVtbl[10]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadRequestedDeferral **")] IAdaptiveMediaSourceDownloadRequestedDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs*, IAdaptiveMediaSourceDownloadRequestedDeferral**, int>)(lpVtbl[11]))((IAdaptiveMediaSourceDownloadRequestedEventArgs*)Unsafe.AsPointer(ref this), deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResourceType([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceResourceType *")] AdaptiveMediaSourceResourceType* value);

        [VtblIndex(7)]
        HRESULT get_ResourceUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(8)]
        HRESULT get_ResourceByteRangeOffset([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(9)]
        HRESULT get_ResourceByteRangeLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(10)]
        HRESULT get_Result([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadResult **")] IAdaptiveMediaSourceDownloadResult** value);

        [VtblIndex(11)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadRequestedDeferral **")] IAdaptiveMediaSourceDownloadRequestedDeferral** deferral);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceResourceType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdaptiveMediaSourceResourceType*, int> get_ResourceType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ResourceUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_ResourceByteRangeOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_ResourceByteRangeLength;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveMediaSourceDownloadResult**, int> get_Result;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadRequestedDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveMediaSourceDownloadRequestedDeferral**, int> GetDeferral;
    }
}
