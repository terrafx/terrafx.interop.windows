// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemStatusTypeFilterFactory.xml' path='doc/member[@name="IRemoteSystemStatusTypeFilterFactory"]/*' />
[Guid("33CF78FA-D724-4125-AC7A-8D281E44C949")]
[NativeTypeName("struct IRemoteSystemStatusTypeFilterFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemStatusTypeFilterFactory : IRemoteSystemStatusTypeFilterFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemStatusTypeFilterFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatusTypeFilterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemStatusTypeFilterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatusTypeFilterFactory*, uint>)(lpVtbl[1]))((IRemoteSystemStatusTypeFilterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatusTypeFilterFactory*, uint>)(lpVtbl[2]))((IRemoteSystemStatusTypeFilterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatusTypeFilterFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemStatusTypeFilterFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatusTypeFilterFactory*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemStatusTypeFilterFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatusTypeFilterFactory*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemStatusTypeFilterFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemStatusTypeFilterFactory.xml' path='doc/member[@name="IRemoteSystemStatusTypeFilterFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemStatusType")] RemoteSystemStatusType remoteSystemStatusType, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemStatusTypeFilter **")] IRemoteSystemStatusTypeFilter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemStatusTypeFilterFactory*, RemoteSystemStatusType, IRemoteSystemStatusTypeFilter**, int>)(lpVtbl[6]))((IRemoteSystemStatusTypeFilterFactory*)Unsafe.AsPointer(ref this), remoteSystemStatusType, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemStatusType")] RemoteSystemStatusType remoteSystemStatusType, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemStatusTypeFilter **")] IRemoteSystemStatusTypeFilter** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::RemoteSystemStatusType, ABI::Windows::System::RemoteSystems::IRemoteSystemStatusTypeFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RemoteSystemStatusType, IRemoteSystemStatusTypeFilter**, int> Create;
    }
}
