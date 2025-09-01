// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeocircleFactory.xml' path='doc/member[@name="IGeocircleFactory"]/*' />
[Guid("AFD6531F-72B1-4F7D-87CC-4ED4C9849C05")]
[NativeTypeName("struct IGeocircleFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeocircleFactory : IGeocircleFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGeocircleFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, Guid*, void**, int>)(lpVtbl[0]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, uint>)(lpVtbl[1]))((IGeocircleFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, uint>)(lpVtbl[2]))((IGeocircleFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, HSTRING*, int>)(lpVtbl[4]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, TrustLevel*, int>)(lpVtbl[5]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeocircleFactory.xml' path='doc/member[@name="IGeocircleFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, BasicGeoposition, double, IGeocircle**, int>)(lpVtbl[6]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), position, radius, value);
    }

    /// <include file='IGeocircleFactory.xml' path='doc/member[@name="IGeocircleFactory.CreateWithAltitudeReferenceSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithAltitudeReferenceSystem([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, BasicGeoposition, double, AltitudeReferenceSystem, IGeocircle**, int>)(lpVtbl[7]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), position, radius, altitudeReferenceSystem, value);
    }

    /// <include file='IGeocircleFactory.xml' path='doc/member[@name="IGeocircleFactory.CreateWithAltitudeReferenceSystemAndSpatialReferenceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithAltitudeReferenceSystemAndSpatialReferenceId([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeocircleFactory*, BasicGeoposition, double, AltitudeReferenceSystem, uint, IGeocircle**, int>)(lpVtbl[8]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), position, radius, altitudeReferenceSystem, spatialReferenceId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value);

        [VtblIndex(7)]
        HRESULT CreateWithAltitudeReferenceSystem([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value);

        [VtblIndex(8)]
        HRESULT CreateWithAltitudeReferenceSystemAndSpatialReferenceId([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, DOUBLE, ABI::Windows::Devices::Geolocation::IGeocircle **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition, double, IGeocircle**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, DOUBLE, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, ABI::Windows::Devices::Geolocation::IGeocircle **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition, double, AltitudeReferenceSystem, IGeocircle**, int> CreateWithAltitudeReferenceSystem;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition, DOUBLE, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, UINT32, ABI::Windows::Devices::Geolocation::IGeocircle **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition, double, AltitudeReferenceSystem, uint, IGeocircle**, int> CreateWithAltitudeReferenceSystemAndSpatialReferenceId;
    }
}
