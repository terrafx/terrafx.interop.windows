// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICivicAddress.xml' path='doc/member[@name="ICivicAddress"]/*' />
[Guid("A8567A1A-64F4-4D48-BCEA-F6B008ECA34C")]
[NativeTypeName("struct ICivicAddress : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICivicAddress : ICivicAddress.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICivicAddress));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, Guid*, void**, int>)(lpVtbl[0]))((ICivicAddress*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, uint>)(lpVtbl[1]))((ICivicAddress*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, uint>)(lpVtbl[2]))((ICivicAddress*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, uint*, Guid**, int>)(lpVtbl[3]))((ICivicAddress*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, HSTRING*, int>)(lpVtbl[4]))((ICivicAddress*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, TrustLevel*, int>)(lpVtbl[5]))((ICivicAddress*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICivicAddress.xml' path='doc/member[@name="ICivicAddress.get_Country"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Country(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, HSTRING*, int>)(lpVtbl[6]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICivicAddress.xml' path='doc/member[@name="ICivicAddress.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_State(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, HSTRING*, int>)(lpVtbl[7]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICivicAddress.xml' path='doc/member[@name="ICivicAddress.get_City"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_City(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, HSTRING*, int>)(lpVtbl[8]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICivicAddress.xml' path='doc/member[@name="ICivicAddress.get_PostalCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PostalCode(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, HSTRING*, int>)(lpVtbl[9]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICivicAddress.xml' path='doc/member[@name="ICivicAddress.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICivicAddress*, WinRTDateTime*, int>)(lpVtbl[10]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Country(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_State(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_City(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_PostalCode(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Country;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_State;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_City;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PostalCode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Timestamp;
    }
}
