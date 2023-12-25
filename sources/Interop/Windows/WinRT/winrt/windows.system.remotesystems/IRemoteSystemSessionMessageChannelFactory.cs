// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemSessionMessageChannelFactory.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannelFactory"]/*' />
[Guid("295E1C4A-BD16-4298-B7CE-415482B0E11D")]
[NativeTypeName("struct IRemoteSystemSessionMessageChannelFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSessionMessageChannelFactory : IRemoteSystemSessionMessageChannelFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemSessionMessageChannelFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannelFactory*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemSessionMessageChannelFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannelFactory*, uint>)(lpVtbl[1]))((IRemoteSystemSessionMessageChannelFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannelFactory*, uint>)(lpVtbl[2]))((IRemoteSystemSessionMessageChannelFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannelFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemSessionMessageChannelFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannelFactory*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemSessionMessageChannelFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannelFactory*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemSessionMessageChannelFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemSessionMessageChannelFactory.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannelFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession *")] IRemoteSystemSession* session, HSTRING channelName, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **")] IRemoteSystemSessionMessageChannel** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannelFactory*, IRemoteSystemSession*, HSTRING, IRemoteSystemSessionMessageChannel**, int>)(lpVtbl[6]))((IRemoteSystemSessionMessageChannelFactory*)Unsafe.AsPointer(ref this), session, channelName, value);
    }

    /// <include file='IRemoteSystemSessionMessageChannelFactory.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannelFactory.CreateWithReliability"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithReliability([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession *")] IRemoteSystemSession* session, HSTRING channelName, [NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemSessionMessageChannelReliability")] RemoteSystemSessionMessageChannelReliability reliability, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **")] IRemoteSystemSessionMessageChannel** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannelFactory*, IRemoteSystemSession*, HSTRING, RemoteSystemSessionMessageChannelReliability, IRemoteSystemSessionMessageChannel**, int>)(lpVtbl[7]))((IRemoteSystemSessionMessageChannelFactory*)Unsafe.AsPointer(ref this), session, channelName, reliability, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession *")] IRemoteSystemSession* session, HSTRING channelName, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **")] IRemoteSystemSessionMessageChannel** value);

        [VtblIndex(7)]
        HRESULT CreateWithReliability([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession *")] IRemoteSystemSession* session, HSTRING channelName, [NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemSessionMessageChannelReliability")] RemoteSystemSessionMessageChannelReliability reliability, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **")] IRemoteSystemSessionMessageChannel** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSession *, HSTRING, ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemSession*, HSTRING, IRemoteSystemSessionMessageChannel**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSession *, HSTRING, ABI::Windows::System::RemoteSystems::RemoteSystemSessionMessageChannelReliability, ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemSession*, HSTRING, RemoteSystemSessionMessageChannelReliability, IRemoteSystemSessionMessageChannel**, int> CreateWithReliability;
    }
}
