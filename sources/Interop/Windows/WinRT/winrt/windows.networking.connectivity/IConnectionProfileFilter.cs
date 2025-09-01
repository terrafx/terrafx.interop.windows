// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter"]/*' />
[Guid("204C7CC8-BD2D-4E8D-A4B3-455EC337388A")]
[NativeTypeName("struct IConnectionProfileFilter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionProfileFilter : IConnectionProfileFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IConnectionProfileFilter);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, uint>)(lpVtbl[1]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, uint>)(lpVtbl[2]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, HSTRING*, int>)(lpVtbl[4]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, TrustLevel*, int>)(lpVtbl[5]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.put_IsConnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsConnected([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, byte, int>)(lpVtbl[6]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.get_IsConnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsConnected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, byte*, int>)(lpVtbl[7]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.put_IsWwanConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsWwanConnectionProfile([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, byte, int>)(lpVtbl[8]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.get_IsWwanConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsWwanConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, byte*, int>)(lpVtbl[9]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.put_IsWlanConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsWlanConnectionProfile([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, byte, int>)(lpVtbl[10]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.get_IsWlanConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsWlanConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, byte*, int>)(lpVtbl[11]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.put_NetworkCostType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_NetworkCostType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType")] NetworkCostType value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, NetworkCostType, int>)(lpVtbl[12]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.get_NetworkCostType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_NetworkCostType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType *")] NetworkCostType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, NetworkCostType*, int>)(lpVtbl[13]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.put_ServiceProviderGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ServiceProviderGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t *")] IReference<Guid>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, IReference<Guid>*, int>)(lpVtbl[14]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionProfileFilter.xml' path='doc/member[@name="IConnectionProfileFilter.get_ServiceProviderGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ServiceProviderGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")] IReference<Guid>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionProfileFilter*, IReference<Guid>**, int>)(lpVtbl[15]))((IConnectionProfileFilter*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsConnected([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_IsConnected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_IsWwanConnectionProfile([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_IsWwanConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_IsWlanConnectionProfile([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_IsWlanConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_NetworkCostType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType")] NetworkCostType value);

        [VtblIndex(13)]
        HRESULT get_NetworkCostType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType *")] NetworkCostType* value);

        [VtblIndex(14)]
        HRESULT put_ServiceProviderGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t *")] IReference<Guid>* value);

        [VtblIndex(15)]
        HRESULT get_ServiceProviderGuid([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_GUID_t **")] IReference<Guid>** value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsConnected;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsConnected;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsWwanConnectionProfile;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsWwanConnectionProfile;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsWlanConnectionProfile;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsWlanConnectionProfile;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::NetworkCostType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NetworkCostType, int> put_NetworkCostType;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::NetworkCostType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NetworkCostType*, int> get_NetworkCostType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_GUID_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Guid>*, int> put_ServiceProviderGuid;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_GUID_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Guid>**, int> get_ServiceProviderGuid;
    }
}
