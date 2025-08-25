// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITransportParameters.xml' path='doc/member[@name="ITransportParameters"]/*' />
[Guid("EB0C4E24-2283-438D-8FFF-DBE9DF1CB2CC")]
[NativeTypeName("struct ITransportParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITransportParameters : ITransportParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITransportParameters);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, Guid*, void**, int>)(lpVtbl[0]))((ITransportParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, uint>)(lpVtbl[1]))((ITransportParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, uint>)(lpVtbl[2]))((ITransportParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, uint*, Guid**, int>)(lpVtbl[3]))((ITransportParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, HSTRING*, int>)(lpVtbl[4]))((ITransportParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, TrustLevel*, int>)(lpVtbl[5]))((ITransportParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITransportParameters.xml' path='doc/member[@name="ITransportParameters.get_ActionInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ActionInformation([NativeTypeName("ABI::Windows::Media::Streaming::IMediaRendererActionInformation **")] IMediaRendererActionInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, IMediaRendererActionInformation**, int>)(lpVtbl[6]))((ITransportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITransportParameters.xml' path='doc/member[@name="ITransportParameters.get_TrackInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TrackInformation([NativeTypeName("ABI::Windows::Media::Streaming::TrackInformation *")] TrackInformation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, TrackInformation*, int>)(lpVtbl[7]))((ITransportParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITransportParameters.xml' path='doc/member[@name="ITransportParameters.get_TransportInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TransportInformation([NativeTypeName("ABI::Windows::Media::Streaming::TransportInformation *")] TransportInformation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParameters*, TransportInformation*, int>)(lpVtbl[8]))((ITransportParameters*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ActionInformation([NativeTypeName("ABI::Windows::Media::Streaming::IMediaRendererActionInformation **")] IMediaRendererActionInformation** value);

        [VtblIndex(7)]
        HRESULT get_TrackInformation([NativeTypeName("ABI::Windows::Media::Streaming::TrackInformation *")] TrackInformation* value);

        [VtblIndex(8)]
        HRESULT get_TransportInformation([NativeTypeName("ABI::Windows::Media::Streaming::TransportInformation *")] TransportInformation* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IMediaRendererActionInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaRendererActionInformation**, int> get_ActionInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::TrackInformation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrackInformation*, int> get_TrackInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::TransportInformation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TransportInformation*, int> get_TransportInformation;
    }
}
