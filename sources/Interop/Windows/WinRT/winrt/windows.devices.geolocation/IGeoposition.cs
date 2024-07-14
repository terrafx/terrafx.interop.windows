// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeoposition.xml' path='doc/member[@name="IGeoposition"]/*' />
[Guid("C18D0454-7D41-4FF7-A957-9DFFB4EF7F5B")]
[NativeTypeName("struct IGeoposition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeoposition : IGeoposition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeoposition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoposition*, Guid*, void**, int>)(lpVtbl[0]))((IGeoposition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoposition*, uint>)(lpVtbl[1]))((IGeoposition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoposition*, uint>)(lpVtbl[2]))((IGeoposition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoposition*, uint*, Guid**, int>)(lpVtbl[3]))((IGeoposition*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoposition*, HSTRING*, int>)(lpVtbl[4]))((IGeoposition*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoposition*, TrustLevel*, int>)(lpVtbl[5]))((IGeoposition*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeoposition.xml' path='doc/member[@name="IGeoposition.get_Coordinate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Coordinate([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocoordinate **")] IGeocoordinate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoposition*, IGeocoordinate**, int>)(lpVtbl[6]))((IGeoposition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeoposition.xml' path='doc/member[@name="IGeoposition.get_CivicAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CivicAddress([NativeTypeName("ABI::Windows::Devices::Geolocation::ICivicAddress **")] ICivicAddress** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoposition*, ICivicAddress**, int>)(lpVtbl[7]))((IGeoposition*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Coordinate([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocoordinate **")] IGeocoordinate** value);

        [VtblIndex(7)]
        HRESULT get_CivicAddress([NativeTypeName("ABI::Windows::Devices::Geolocation::ICivicAddress **")] ICivicAddress** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::IGeocoordinate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGeocoordinate**, int> get_Coordinate;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::ICivicAddress **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICivicAddress**, int> get_CivicAddress;
    }
}
