// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemSessionJoinResult.xml' path='doc/member[@name="IRemoteSystemSessionJoinResult"]/*' />
[Guid("CE7B1F04-A03E-41A4-900B-1E79328C1267")]
[NativeTypeName("struct IRemoteSystemSessionJoinResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSessionJoinResult : IRemoteSystemSessionJoinResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemSessionJoinResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionJoinResult*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemSessionJoinResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionJoinResult*, uint>)(lpVtbl[1]))((IRemoteSystemSessionJoinResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionJoinResult*, uint>)(lpVtbl[2]))((IRemoteSystemSessionJoinResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionJoinResult*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemSessionJoinResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionJoinResult*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemSessionJoinResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionJoinResult*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemSessionJoinResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemSessionJoinResult.xml' path='doc/member[@name="IRemoteSystemSessionJoinResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemSessionJoinStatus *")] RemoteSystemSessionJoinStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionJoinResult*, RemoteSystemSessionJoinStatus*, int>)(lpVtbl[6]))((IRemoteSystemSessionJoinResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemSessionJoinResult.xml' path='doc/member[@name="IRemoteSystemSessionJoinResult.get_Session"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Session([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession **")] IRemoteSystemSession** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionJoinResult*, IRemoteSystemSession**, int>)(lpVtbl[7]))((IRemoteSystemSessionJoinResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemSessionJoinStatus *")] RemoteSystemSessionJoinStatus* value);

        [VtblIndex(7)]
        HRESULT get_Session([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession **")] IRemoteSystemSession** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::RemoteSystemSessionJoinStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RemoteSystemSessionJoinStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSession **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemSession**, int> get_Session;
    }
}
