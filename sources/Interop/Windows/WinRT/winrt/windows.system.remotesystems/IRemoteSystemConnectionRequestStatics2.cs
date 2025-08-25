// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemConnectionRequestStatics2.xml' path='doc/member[@name="IRemoteSystemConnectionRequestStatics2"]/*' />
[Guid("460F1027-64EC-598E-A800-4F2EE58DEF19")]
[NativeTypeName("struct IRemoteSystemConnectionRequestStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemConnectionRequestStatics2 : IRemoteSystemConnectionRequestStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemConnectionRequestStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionRequestStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemConnectionRequestStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionRequestStatics2*, uint>)(lpVtbl[1]))((IRemoteSystemConnectionRequestStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionRequestStatics2*, uint>)(lpVtbl[2]))((IRemoteSystemConnectionRequestStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionRequestStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemConnectionRequestStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionRequestStatics2*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemConnectionRequestStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionRequestStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemConnectionRequestStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemConnectionRequestStatics2.xml' path='doc/member[@name="IRemoteSystemConnectionRequestStatics2.CreateFromConnectionToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromConnectionToken(HSTRING connectionToken, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **")] IRemoteSystemConnectionRequest** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionRequestStatics2*, HSTRING, IRemoteSystemConnectionRequest**, int>)(lpVtbl[6]))((IRemoteSystemConnectionRequestStatics2*)Unsafe.AsPointer(ref this), connectionToken, result);
    }

    /// <include file='IRemoteSystemConnectionRequestStatics2.xml' path='doc/member[@name="IRemoteSystemConnectionRequestStatics2.CreateFromConnectionTokenForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromConnectionTokenForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING connectionToken, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **")] IRemoteSystemConnectionRequest** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemConnectionRequestStatics2*, IUser*, HSTRING, IRemoteSystemConnectionRequest**, int>)(lpVtbl[7]))((IRemoteSystemConnectionRequestStatics2*)Unsafe.AsPointer(ref this), user, connectionToken, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromConnectionToken(HSTRING connectionToken, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **")] IRemoteSystemConnectionRequest** result);

        [VtblIndex(7)]
        HRESULT CreateFromConnectionTokenForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING connectionToken, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **")] IRemoteSystemConnectionRequest** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IRemoteSystemConnectionRequest**, int> CreateFromConnectionToken;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, IRemoteSystemConnectionRequest**, int> CreateFromConnectionTokenForUser;
    }
}
