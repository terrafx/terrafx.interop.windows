// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeoboundingBox.xml' path='doc/member[@name="IGeoboundingBox"]/*' />
[Guid("0896C80B-274F-43DA-9A06-CBFCDAEB4EC2")]
[NativeTypeName("struct IGeoboundingBox : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeoboundingBox : IGeoboundingBox.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeoboundingBox));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, Guid*, void**, int>)(lpVtbl[0]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, uint>)(lpVtbl[1]))((IGeoboundingBox*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, uint>)(lpVtbl[2]))((IGeoboundingBox*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, uint*, Guid**, int>)(lpVtbl[3]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, HSTRING*, int>)(lpVtbl[4]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, TrustLevel*, int>)(lpVtbl[5]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeoboundingBox.xml' path='doc/member[@name="IGeoboundingBox.get_NorthwestCorner"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NorthwestCorner([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, BasicGeoposition*, int>)(lpVtbl[6]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeoboundingBox.xml' path='doc/member[@name="IGeoboundingBox.get_SoutheastCorner"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SoutheastCorner([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, BasicGeoposition*, int>)(lpVtbl[7]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeoboundingBox.xml' path='doc/member[@name="IGeoboundingBox.get_Center"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Center([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, BasicGeoposition*, int>)(lpVtbl[8]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeoboundingBox.xml' path='doc/member[@name="IGeoboundingBox.get_MinAltitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinAltitude(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, double*, int>)(lpVtbl[9]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeoboundingBox.xml' path='doc/member[@name="IGeoboundingBox.get_MaxAltitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxAltitude(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeoboundingBox*, double*, int>)(lpVtbl[10]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NorthwestCorner([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value);

        [VtblIndex(7)]
        HRESULT get_SoutheastCorner([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value);

        [VtblIndex(8)]
        HRESULT get_Center([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value);

        [VtblIndex(9)]
        HRESULT get_MinAltitude(double* value);

        [VtblIndex(10)]
        HRESULT get_MaxAltitude(double* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition*, int> get_NorthwestCorner;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition*, int> get_SoutheastCorner;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::BasicGeoposition *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BasicGeoposition*, int> get_Center;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MinAltitude;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MaxAltitude;
    }
}
