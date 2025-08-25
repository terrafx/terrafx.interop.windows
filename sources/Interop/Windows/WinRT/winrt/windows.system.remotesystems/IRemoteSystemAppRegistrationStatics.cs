// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemAppRegistrationStatics.xml' path='doc/member[@name="IRemoteSystemAppRegistrationStatics"]/*' />
[Guid("01B99840-CFD2-453F-AE25-C2539F086AFD")]
[NativeTypeName("struct IRemoteSystemAppRegistrationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemAppRegistrationStatics : IRemoteSystemAppRegistrationStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemAppRegistrationStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemAppRegistrationStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemAppRegistrationStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemAppRegistrationStatics*, uint>)(lpVtbl[1]))((IRemoteSystemAppRegistrationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemAppRegistrationStatics*, uint>)(lpVtbl[2]))((IRemoteSystemAppRegistrationStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemAppRegistrationStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemAppRegistrationStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemAppRegistrationStatics*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemAppRegistrationStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemAppRegistrationStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemAppRegistrationStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemAppRegistrationStatics.xml' path='doc/member[@name="IRemoteSystemAppRegistrationStatics.GetDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefault([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemAppRegistration **")] IRemoteSystemAppRegistration** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemAppRegistrationStatics*, IRemoteSystemAppRegistration**, int>)(lpVtbl[6]))((IRemoteSystemAppRegistrationStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IRemoteSystemAppRegistrationStatics.xml' path='doc/member[@name="IRemoteSystemAppRegistrationStatics.GetForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemAppRegistration **")] IRemoteSystemAppRegistration** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemAppRegistrationStatics*, IUser*, IRemoteSystemAppRegistration**, int>)(lpVtbl[7]))((IRemoteSystemAppRegistrationStatics*)Unsafe.AsPointer(ref this), user, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefault([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemAppRegistration **")] IRemoteSystemAppRegistration** result);

        [VtblIndex(7)]
        HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemAppRegistration **")] IRemoteSystemAppRegistration** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemAppRegistration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemAppRegistration**, int> GetDefault;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::System::RemoteSystems::IRemoteSystemAppRegistration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IRemoteSystemAppRegistration**, int> GetForUser;
    }
}
