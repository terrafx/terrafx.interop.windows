// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate"]/*' />
[Guid("EE21A3AA-976A-4C70-803D-083EA55BCBC4")]
[NativeTypeName("struct IGeocoordinate : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeocoordinate : IGeocoordinate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeocoordinate));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, Guid*, void**, int>)(lpVtbl[0]))((IGeocoordinate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, uint>)(lpVtbl[1]))((IGeocoordinate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, uint>)(lpVtbl[2]))((IGeocoordinate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocoordinate*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, HSTRING*, int>)(lpVtbl[4]))((IGeocoordinate*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, TrustLevel*, int>)(lpVtbl[5]))((IGeocoordinate*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate.get_Latitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude")]
    public HRESULT get_Latitude(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, double*, int>)(lpVtbl[6]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate.get_Longitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude")]
    public HRESULT get_Longitude(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, double*, int>)(lpVtbl[7]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate.get_Altitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude")]
    public HRESULT get_Altitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, IReference<double>**, int>)(lpVtbl[8]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate.get_Accuracy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Accuracy(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, double*, int>)(lpVtbl[9]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate.get_AltitudeAccuracy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AltitudeAccuracy([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, IReference<double>**, int>)(lpVtbl[10]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate.get_Heading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Heading([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, IReference<double>**, int>)(lpVtbl[11]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate.get_Speed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Speed([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, IReference<double>**, int>)(lpVtbl[12]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeocoordinate.xml' path='doc/member[@name="IGeocoordinate.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocoordinate*, WinRTDateTime*, int>)(lpVtbl[13]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude")]
        HRESULT get_Latitude(double* value);

        [VtblIndex(7)]
        [Obsolete("Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude")]
        HRESULT get_Longitude(double* value);

        [VtblIndex(8)]
        [Obsolete("Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude")]
        HRESULT get_Altitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(9)]
        HRESULT get_Accuracy(double* value);

        [VtblIndex(10)]
        HRESULT get_AltitudeAccuracy([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(11)]
        HRESULT get_Heading([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(12)]
        HRESULT get_Speed([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(13)]
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        [Obsolete("Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Latitude;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        [Obsolete("Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Longitude;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        [Obsolete("Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_Altitude;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Accuracy;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_AltitudeAccuracy;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_Heading;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_Speed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Timestamp;
    }
}
