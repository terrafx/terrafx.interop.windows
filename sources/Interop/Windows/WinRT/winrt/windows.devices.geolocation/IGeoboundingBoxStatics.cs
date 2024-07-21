// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeoboundingBoxStatics.xml' path='doc/member[@name="IGeoboundingBoxStatics"]/*' />
[Guid("67B80708-E61A-4CD0-841B-93233792B5CA")]
[NativeTypeName("struct IGeoboundingBoxStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeoboundingBoxStatics : IGeoboundingBoxStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeoboundingBoxStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, uint>)(lpVtbl[1]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, uint>)(lpVtbl[2]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, HSTRING*, int>)(lpVtbl[4]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeoboundingBoxStatics.xml' path='doc/member[@name="IGeoboundingBoxStatics.TryCompute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryCompute([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, IIterable<BasicGeoposition>*, IGeoboundingBox**, int>)(lpVtbl[6]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), positions, value);
    }

    /// <include file='IGeoboundingBoxStatics.xml' path='doc/member[@name="IGeoboundingBoxStatics.TryComputeWithAltitudeReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryComputeWithAltitudeReference([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeRefSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, IIterable<BasicGeoposition>*, AltitudeReferenceSystem, IGeoboundingBox**, int>)(lpVtbl[7]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), positions, altitudeRefSystem, value);
    }

    /// <include file='IGeoboundingBoxStatics.xml' path='doc/member[@name="IGeoboundingBoxStatics.TryComputeWithAltitudeReferenceAndSpatialReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryComputeWithAltitudeReferenceAndSpatialReference([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeRefSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBoxStatics*, IIterable<BasicGeoposition>*, AltitudeReferenceSystem, uint, IGeoboundingBox**, int>)(lpVtbl[8]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), positions, altitudeRefSystem, spatialReferenceId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryCompute([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value);

        [VtblIndex(7)]
        HRESULT TryComputeWithAltitudeReference([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeRefSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value);

        [VtblIndex(8)]
        HRESULT TryComputeWithAltitudeReferenceAndSpatialReference([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeRefSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<BasicGeoposition>*, IGeoboundingBox**, int> TryCompute;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<BasicGeoposition>*, AltitudeReferenceSystem, IGeoboundingBox**, int> TryComputeWithAltitudeReference;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *, ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem, UINT32, ABI::Windows::Devices::Geolocation::IGeoboundingBox **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<BasicGeoposition>*, AltitudeReferenceSystem, uint, IGeoboundingBox**, int> TryComputeWithAltitudeReferenceAndSpatialReference;
    }
}
