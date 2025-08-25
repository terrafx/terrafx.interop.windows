// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemDiscoveryTypeFilter.xml' path='doc/member[@name="IRemoteSystemDiscoveryTypeFilter"]/*' />
[Guid("42D9041F-EE5A-43DA-AC6A-6FEE25460741")]
[NativeTypeName("struct IRemoteSystemDiscoveryTypeFilter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemDiscoveryTypeFilter : IRemoteSystemDiscoveryTypeFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemDiscoveryTypeFilter);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemDiscoveryTypeFilter*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemDiscoveryTypeFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemDiscoveryTypeFilter*, uint>)(lpVtbl[1]))((IRemoteSystemDiscoveryTypeFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemDiscoveryTypeFilter*, uint>)(lpVtbl[2]))((IRemoteSystemDiscoveryTypeFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemDiscoveryTypeFilter*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemDiscoveryTypeFilter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemDiscoveryTypeFilter*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemDiscoveryTypeFilter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemDiscoveryTypeFilter*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemDiscoveryTypeFilter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemDiscoveryTypeFilter.xml' path='doc/member[@name="IRemoteSystemDiscoveryTypeFilter.get_RemoteSystemDiscoveryType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RemoteSystemDiscoveryType([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemDiscoveryType *")] RemoteSystemDiscoveryType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemDiscoveryTypeFilter*, RemoteSystemDiscoveryType*, int>)(lpVtbl[6]))((IRemoteSystemDiscoveryTypeFilter*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RemoteSystemDiscoveryType([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemDiscoveryType *")] RemoteSystemDiscoveryType* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::RemoteSystemDiscoveryType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RemoteSystemDiscoveryType*, int> get_RemoteSystemDiscoveryType;
    }
}
