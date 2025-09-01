// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIPInformation.xml' path='doc/member[@name="IIPInformation"]/*' />
[Guid("D85145E0-138F-47D7-9B3A-36BB488CEF33")]
[NativeTypeName("struct IIPInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIPInformation : IIPInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIPInformation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIPInformation*, Guid*, void**, int>)(lpVtbl[0]))((IIPInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIPInformation*, uint>)(lpVtbl[1]))((IIPInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIPInformation*, uint>)(lpVtbl[2]))((IIPInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIPInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IIPInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIPInformation*, HSTRING*, int>)(lpVtbl[4]))((IIPInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIPInformation*, TrustLevel*, int>)(lpVtbl[5]))((IIPInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIPInformation.xml' path='doc/member[@name="IIPInformation.get_NetworkAdapter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NetworkAdapter([NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter **")] INetworkAdapter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIPInformation*, INetworkAdapter**, int>)(lpVtbl[6]))((IIPInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIPInformation.xml' path='doc/member[@name="IIPInformation.get_PrefixLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrefixLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")] IReference<byte>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIPInformation*, IReference<byte>**, int>)(lpVtbl[7]))((IIPInformation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NetworkAdapter([NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter **")] INetworkAdapter** value);

        [VtblIndex(7)]
        HRESULT get_PrefixLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")] IReference<byte>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::INetworkAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, INetworkAdapter**, int> get_NetworkAdapter;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_byte_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<byte>**, int> get_PrefixLength;
    }
}
