// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemConnectionInfoStatics.xml' path='doc/member[@name="IRemoteSystemConnectionInfoStatics"]/*' />
[Guid("AC831E2D-66C5-56D7-A4CE-705D94925AD6")]
[NativeTypeName("struct IRemoteSystemConnectionInfoStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemConnectionInfoStatics : IRemoteSystemConnectionInfoStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemConnectionInfoStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionInfoStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemConnectionInfoStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionInfoStatics*, uint>)(lpVtbl[1]))((IRemoteSystemConnectionInfoStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionInfoStatics*, uint>)(lpVtbl[2]))((IRemoteSystemConnectionInfoStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionInfoStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemConnectionInfoStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionInfoStatics*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemConnectionInfoStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionInfoStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemConnectionInfoStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemConnectionInfoStatics.xml' path='doc/member[@name="IRemoteSystemConnectionInfoStatics.TryCreateFromAppServiceConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryCreateFromAppServiceConnection([NativeTypeName("ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *")] IAppServiceConnection* connection, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionInfo **")] IRemoteSystemConnectionInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionInfoStatics*, IAppServiceConnection*, IRemoteSystemConnectionInfo**, int>)(lpVtbl[6]))((IRemoteSystemConnectionInfoStatics*)Unsafe.AsPointer(ref this), connection, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryCreateFromAppServiceConnection([NativeTypeName("ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *")] IAppServiceConnection* connection, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionInfo **")] IRemoteSystemConnectionInfo** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *, ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppServiceConnection*, IRemoteSystemConnectionInfo**, int> TryCreateFromAppServiceConnection;
    }
}
