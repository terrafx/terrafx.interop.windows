// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownRemoteSystemCapabilitiesStatics.xml' path='doc/member[@name="IKnownRemoteSystemCapabilitiesStatics"]/*' />
[Guid("8108E380-7F8A-44E4-92CD-03B6469B94A3")]
[NativeTypeName("struct IKnownRemoteSystemCapabilitiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownRemoteSystemCapabilitiesStatics : IKnownRemoteSystemCapabilitiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKnownRemoteSystemCapabilitiesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, uint>)(lpVtbl[1]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, uint>)(lpVtbl[2]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, HSTRING*, int>)(lpVtbl[4]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownRemoteSystemCapabilitiesStatics.xml' path='doc/member[@name="IKnownRemoteSystemCapabilitiesStatics.get_AppService"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppService(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, HSTRING*, int>)(lpVtbl[6]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownRemoteSystemCapabilitiesStatics.xml' path='doc/member[@name="IKnownRemoteSystemCapabilitiesStatics.get_LaunchUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LaunchUri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, HSTRING*, int>)(lpVtbl[7]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownRemoteSystemCapabilitiesStatics.xml' path='doc/member[@name="IKnownRemoteSystemCapabilitiesStatics.get_RemoteSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RemoteSession(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, HSTRING*, int>)(lpVtbl[8]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownRemoteSystemCapabilitiesStatics.xml' path='doc/member[@name="IKnownRemoteSystemCapabilitiesStatics.get_SpatialEntity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SpatialEntity(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownRemoteSystemCapabilitiesStatics*, HSTRING*, int>)(lpVtbl[9]))((IKnownRemoteSystemCapabilitiesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppService(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_LaunchUri(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RemoteSession(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_SpatialEntity(HSTRING* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppService;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LaunchUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteSession;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SpatialEntity;
    }
}
