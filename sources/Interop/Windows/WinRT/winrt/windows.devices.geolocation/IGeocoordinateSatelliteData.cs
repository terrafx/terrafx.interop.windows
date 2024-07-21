// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeocoordinateSatelliteData.xml' path='doc/member[@name="IGeocoordinateSatelliteData"]/*' />
[Guid("C32A74D9-2608-474C-912C-06DD490F4AF7")]
[NativeTypeName("struct IGeocoordinateSatelliteData : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeocoordinateSatelliteData : IGeocoordinateSatelliteData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeocoordinateSatelliteData));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, Guid*, void**, int>)(lpVtbl[0]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, uint>)(lpVtbl[1]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, uint>)(lpVtbl[2]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, HSTRING*, int>)(lpVtbl[4]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, TrustLevel*, int>)(lpVtbl[5]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeocoordinateSatelliteData.xml' path='doc/member[@name="IGeocoordinateSatelliteData.get_PositionDilutionOfPrecision"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PositionDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, IReference<double>**, int>)(lpVtbl[6]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), ppValue);
    }

    /// <include file='IGeocoordinateSatelliteData.xml' path='doc/member[@name="IGeocoordinateSatelliteData.get_HorizontalDilutionOfPrecision"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HorizontalDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, IReference<double>**, int>)(lpVtbl[7]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), ppValue);
    }

    /// <include file='IGeocoordinateSatelliteData.xml' path='doc/member[@name="IGeocoordinateSatelliteData.get_VerticalDilutionOfPrecision"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VerticalDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinateSatelliteData*, IReference<double>**, int>)(lpVtbl[8]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), ppValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PositionDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue);

        [VtblIndex(7)]
        HRESULT get_HorizontalDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue);

        [VtblIndex(8)]
        HRESULT get_VerticalDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_PositionDilutionOfPrecision;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_HorizontalDilutionOfPrecision;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_VerticalDilutionOfPrecision;
    }
}
