// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialBoundingVolumeStatics.xml' path='doc/member[@name="ISpatialBoundingVolumeStatics"]/*' />
[Guid("05889117-B3E1-36D8-B017-566181A5B196")]
[NativeTypeName("struct ISpatialBoundingVolumeStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialBoundingVolumeStatics : ISpatialBoundingVolumeStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpatialBoundingVolumeStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, uint>)(lpVtbl[1]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, uint>)(lpVtbl[2]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialBoundingVolumeStatics.xml' path='doc/member[@name="ISpatialBoundingVolumeStatics.FromBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromBox([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingBox")] SpatialBoundingBox box, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")] ISpatialBoundingVolume** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, ISpatialCoordinateSystem*, SpatialBoundingBox, ISpatialBoundingVolume**, int>)(lpVtbl[6]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this), coordinateSystem, box, value);
    }

    /// <include file='ISpatialBoundingVolumeStatics.xml' path='doc/member[@name="ISpatialBoundingVolumeStatics.FromOrientedBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromOrientedBox([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingOrientedBox")] SpatialBoundingOrientedBox box, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")] ISpatialBoundingVolume** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, ISpatialCoordinateSystem*, SpatialBoundingOrientedBox, ISpatialBoundingVolume**, int>)(lpVtbl[7]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this), coordinateSystem, box, value);
    }

    /// <include file='ISpatialBoundingVolumeStatics.xml' path='doc/member[@name="ISpatialBoundingVolumeStatics.FromSphere"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromSphere([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingSphere")] SpatialBoundingSphere sphere, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")] ISpatialBoundingVolume** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, ISpatialCoordinateSystem*, SpatialBoundingSphere, ISpatialBoundingVolume**, int>)(lpVtbl[8]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this), coordinateSystem, sphere, value);
    }

    /// <include file='ISpatialBoundingVolumeStatics.xml' path='doc/member[@name="ISpatialBoundingVolumeStatics.FromFrustum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FromFrustum([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingFrustum")] SpatialBoundingFrustum frustum, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")] ISpatialBoundingVolume** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialBoundingVolumeStatics*, ISpatialCoordinateSystem*, SpatialBoundingFrustum, ISpatialBoundingVolume**, int>)(lpVtbl[9]))((ISpatialBoundingVolumeStatics*)Unsafe.AsPointer(ref this), coordinateSystem, frustum, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromBox([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingBox")] SpatialBoundingBox box, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")] ISpatialBoundingVolume** value);

        [VtblIndex(7)]
        HRESULT FromOrientedBox([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingOrientedBox")] SpatialBoundingOrientedBox box, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")] ISpatialBoundingVolume** value);

        [VtblIndex(8)]
        HRESULT FromSphere([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingSphere")] SpatialBoundingSphere sphere, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")] ISpatialBoundingVolume** value);

        [VtblIndex(9)]
        HRESULT FromFrustum([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialBoundingFrustum")] SpatialBoundingFrustum frustum, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **")] ISpatialBoundingVolume** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::SpatialBoundingBox, ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem*, SpatialBoundingBox, ISpatialBoundingVolume**, int> FromBox;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::SpatialBoundingOrientedBox, ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem*, SpatialBoundingOrientedBox, ISpatialBoundingVolume**, int> FromOrientedBox;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::SpatialBoundingSphere, ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem*, SpatialBoundingSphere, ISpatialBoundingVolume**, int> FromSphere;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::SpatialBoundingFrustum, ABI::Windows::Perception::Spatial::ISpatialBoundingVolume **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem*, SpatialBoundingFrustum, ISpatialBoundingVolume**, int> FromFrustum;
    }
}
