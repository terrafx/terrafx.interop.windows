// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSource3.xml' path='doc/member[@name="IAdaptiveMediaSource3"]/*' />
[Guid("BA7023FD-C334-461B-A36E-C99F54F7174A")]
[NativeTypeName("struct IAdaptiveMediaSource3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSource3 : IAdaptiveMediaSource3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSource3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, uint>)(lpVtbl[1]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, uint>)(lpVtbl[2]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSource3.xml' path='doc/member[@name="IAdaptiveMediaSource3.get_MinLiveOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MinLiveOffset([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, IReference<TimeSpan>**, int>)(lpVtbl[6]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource3.xml' path='doc/member[@name="IAdaptiveMediaSource3.get_MaxSeekableWindowSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxSeekableWindowSize([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, IReference<TimeSpan>**, int>)(lpVtbl[7]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource3.xml' path='doc/member[@name="IAdaptiveMediaSource3.get_DesiredSeekableWindowSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DesiredSeekableWindowSize([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, IReference<TimeSpan>**, int>)(lpVtbl[8]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource3.xml' path='doc/member[@name="IAdaptiveMediaSource3.put_DesiredSeekableWindowSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DesiredSeekableWindowSize([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, IReference<TimeSpan>*, int>)(lpVtbl[9]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource3.xml' path='doc/member[@name="IAdaptiveMediaSource3.get_Diagnostics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Diagnostics([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDiagnostics **")] IAdaptiveMediaSourceDiagnostics** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, IAdaptiveMediaSourceDiagnostics**, int>)(lpVtbl[10]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSource3.xml' path='doc/member[@name="IAdaptiveMediaSource3.GetCorrelatedTimes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCorrelatedTimes([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceCorrelatedTimes **")] IAdaptiveMediaSourceCorrelatedTimes** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSource3*, IAdaptiveMediaSourceCorrelatedTimes**, int>)(lpVtbl[11]))((IAdaptiveMediaSource3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MinLiveOffset([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(7)]
        HRESULT get_MaxSeekableWindowSize([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(8)]
        HRESULT get_DesiredSeekableWindowSize([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(9)]
        HRESULT put_DesiredSeekableWindowSize([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(10)]
        HRESULT get_Diagnostics([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDiagnostics **")] IAdaptiveMediaSourceDiagnostics** value);

        [VtblIndex(11)]
        HRESULT GetCorrelatedTimes([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceCorrelatedTimes **")] IAdaptiveMediaSourceCorrelatedTimes** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_MinLiveOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_MaxSeekableWindowSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_DesiredSeekableWindowSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_DesiredSeekableWindowSize;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDiagnostics **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveMediaSourceDiagnostics**, int> get_Diagnostics;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceCorrelatedTimes **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveMediaSourceCorrelatedTimes**, int> GetCorrelatedTimes;
    }
}
