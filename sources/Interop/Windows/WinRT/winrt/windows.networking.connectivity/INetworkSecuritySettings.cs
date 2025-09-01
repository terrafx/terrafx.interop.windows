// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INetworkSecuritySettings.xml' path='doc/member[@name="INetworkSecuritySettings"]/*' />
[Guid("7CA07E8D-917B-4B5F-B84D-28F7A5AC5402")]
[NativeTypeName("struct INetworkSecuritySettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INetworkSecuritySettings : INetworkSecuritySettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_INetworkSecuritySettings);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkSecuritySettings*, Guid*, void**, int>)(lpVtbl[0]))((INetworkSecuritySettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkSecuritySettings*, uint>)(lpVtbl[1]))((INetworkSecuritySettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkSecuritySettings*, uint>)(lpVtbl[2]))((INetworkSecuritySettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkSecuritySettings*, uint*, Guid**, int>)(lpVtbl[3]))((INetworkSecuritySettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkSecuritySettings*, HSTRING*, int>)(lpVtbl[4]))((INetworkSecuritySettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkSecuritySettings*, TrustLevel*, int>)(lpVtbl[5]))((INetworkSecuritySettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INetworkSecuritySettings.xml' path='doc/member[@name="INetworkSecuritySettings.get_NetworkAuthenticationType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NetworkAuthenticationType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkAuthenticationType *")] NetworkAuthenticationType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkSecuritySettings*, NetworkAuthenticationType*, int>)(lpVtbl[6]))((INetworkSecuritySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkSecuritySettings.xml' path='doc/member[@name="INetworkSecuritySettings.get_NetworkEncryptionType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_NetworkEncryptionType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkEncryptionType *")] NetworkEncryptionType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkSecuritySettings*, NetworkEncryptionType*, int>)(lpVtbl[7]))((INetworkSecuritySettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NetworkAuthenticationType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkAuthenticationType *")] NetworkAuthenticationType* value);

        [VtblIndex(7)]
        HRESULT get_NetworkEncryptionType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkEncryptionType *")] NetworkEncryptionType* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::NetworkAuthenticationType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NetworkAuthenticationType*, int> get_NetworkAuthenticationType;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::NetworkEncryptionType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NetworkEncryptionType*, int> get_NetworkEncryptionType;
    }
}
