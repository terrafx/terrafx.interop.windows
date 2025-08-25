// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs"]/*' />
[Guid("3AF64F06-6D9C-494A-B7A9-B3A5DEE6AD68")]
[NativeTypeName("struct IAdaptiveMediaSourceDiagnosticAvailableEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceDiagnosticAvailableEventArgs : IAdaptiveMediaSourceDiagnosticAvailableEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAdaptiveMediaSourceDiagnosticAvailableEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, uint>)(lpVtbl[1]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, uint>)(lpVtbl[2]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_DiagnosticType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DiagnosticType([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceDiagnosticType *")] AdaptiveMediaSourceDiagnosticType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, AdaptiveMediaSourceDiagnosticType*, int>)(lpVtbl[6]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_RequestId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestId([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, IReference<int>**, int>)(lpVtbl[7]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, IReference<TimeSpan>**, int>)(lpVtbl[8]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_SegmentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SegmentId([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, IReference<ulong>**, int>)(lpVtbl[9]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_ResourceType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ResourceType([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceResourceType_t **")] IReference<AdaptiveMediaSourceResourceType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, IReference<AdaptiveMediaSourceResourceType>**, int>)(lpVtbl[10]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_ResourceUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ResourceUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, IUriRuntimeClass**, int>)(lpVtbl[11]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_ResourceByteRangeOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ResourceByteRangeOffset([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, IReference<ulong>**, int>)(lpVtbl[12]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_ResourceByteRangeLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ResourceByteRangeLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, IReference<ulong>**, int>)(lpVtbl[13]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDiagnosticAvailableEventArgs.xml' path='doc/member[@name="IAdaptiveMediaSourceDiagnosticAvailableEventArgs.get_Bitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Bitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDiagnosticAvailableEventArgs*, IReference<uint>**, int>)(lpVtbl[14]))((IAdaptiveMediaSourceDiagnosticAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DiagnosticType([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceDiagnosticType *")] AdaptiveMediaSourceDiagnosticType* value);

        [VtblIndex(7)]
        HRESULT get_RequestId([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(8)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(9)]
        HRESULT get_SegmentId([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(10)]
        HRESULT get_ResourceType([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceResourceType_t **")] IReference<AdaptiveMediaSourceResourceType>** value);

        [VtblIndex(11)]
        HRESULT get_ResourceUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(12)]
        HRESULT get_ResourceByteRangeOffset([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(13)]
        HRESULT get_ResourceByteRangeLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(14)]
        HRESULT get_Bitrate([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceDiagnosticType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AdaptiveMediaSourceDiagnosticType*, int> get_DiagnosticType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_RequestId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_SegmentId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceResourceType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<AdaptiveMediaSourceResourceType>**, int> get_ResourceType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ResourceUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_ResourceByteRangeOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_ResourceByteRangeLength;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_Bitrate;
    }
}
