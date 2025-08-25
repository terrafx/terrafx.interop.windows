// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDevicePairingRequestedEventArgs2.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs2"]/*' />
[Guid("C83752D9-E4D3-4DB0-A360-A105E437DBDC")]
[NativeTypeName("struct IDevicePairingRequestedEventArgs2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDevicePairingRequestedEventArgs2 : IDevicePairingRequestedEventArgs2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDevicePairingRequestedEventArgs2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IDevicePairingRequestedEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs2*, uint>)(lpVtbl[1]))((IDevicePairingRequestedEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs2*, uint>)(lpVtbl[2]))((IDevicePairingRequestedEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IDevicePairingRequestedEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs2*, HSTRING*, int>)(lpVtbl[4]))((IDevicePairingRequestedEventArgs2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IDevicePairingRequestedEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDevicePairingRequestedEventArgs2.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs2.AcceptWithPasswordCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AcceptWithPasswordCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* passwordCredential)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs2*, IPasswordCredential*, int>)(lpVtbl[6]))((IDevicePairingRequestedEventArgs2*)Unsafe.AsPointer(ref this), passwordCredential);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AcceptWithPasswordCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* passwordCredential);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential*, int> AcceptWithPasswordCredential;
    }
}
