// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDepthCorrelatedCoordinateMapper.xml' path='doc/member[@name="IDepthCorrelatedCoordinateMapper"]/*' />
[Guid("F95D89FB-8AF0-4CB0-926D-696866E5046A")]
[NativeTypeName("struct IDepthCorrelatedCoordinateMapper : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDepthCorrelatedCoordinateMapper : IDepthCorrelatedCoordinateMapper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDepthCorrelatedCoordinateMapper));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, Guid*, void**, int>)(lpVtbl[0]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, uint>)(lpVtbl[1]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, uint>)(lpVtbl[2]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, uint*, Guid**, int>)(lpVtbl[3]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, HSTRING*, int>)(lpVtbl[4]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, TrustLevel*, int>)(lpVtbl[5]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDepthCorrelatedCoordinateMapper.xml' path='doc/member[@name="IDepthCorrelatedCoordinateMapper.UnprojectPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnprojectPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point sourcePoint, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* targetCoordinateSystem, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, Point, ISpatialCoordinateSystem*, Vector3*, int>)(lpVtbl[6]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this), sourcePoint, targetCoordinateSystem, result);
    }

    /// <include file='IDepthCorrelatedCoordinateMapper.xml' path='doc/member[@name="IDepthCorrelatedCoordinateMapper.UnprojectPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnprojectPoints([NativeTypeName("UINT32")] uint sourcePointsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* sourcePoints, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* targetCoordinateSystem, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* results)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, uint, Point*, ISpatialCoordinateSystem*, uint, Vector3*, int>)(lpVtbl[7]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this), sourcePointsLength, sourcePoints, targetCoordinateSystem, resultsLength, results);
    }

    /// <include file='IDepthCorrelatedCoordinateMapper.xml' path='doc/member[@name="IDepthCorrelatedCoordinateMapper.MapPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MapPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point sourcePoint, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* targetCoordinateSystem, [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")] ICameraIntrinsics* targetCameraIntrinsics, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, Point, ISpatialCoordinateSystem*, ICameraIntrinsics*, Point*, int>)(lpVtbl[8]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this), sourcePoint, targetCoordinateSystem, targetCameraIntrinsics, result);
    }

    /// <include file='IDepthCorrelatedCoordinateMapper.xml' path='doc/member[@name="IDepthCorrelatedCoordinateMapper.MapPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT MapPoints([NativeTypeName("UINT32")] uint sourcePointsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* sourcePoints, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* targetCoordinateSystem, [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")] ICameraIntrinsics* targetCameraIntrinsics, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthCorrelatedCoordinateMapper*, uint, Point*, ISpatialCoordinateSystem*, ICameraIntrinsics*, uint, Point*, int>)(lpVtbl[9]))((IDepthCorrelatedCoordinateMapper*)Unsafe.AsPointer(ref this), sourcePointsLength, sourcePoints, targetCoordinateSystem, targetCameraIntrinsics, resultsLength, results);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT UnprojectPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point sourcePoint, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* targetCoordinateSystem, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* result);

        [VtblIndex(7)]
        HRESULT UnprojectPoints([NativeTypeName("UINT32")] uint sourcePointsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* sourcePoints, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* targetCoordinateSystem, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* results);

        [VtblIndex(8)]
        HRESULT MapPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point sourcePoint, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* targetCoordinateSystem, [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")] ICameraIntrinsics* targetCameraIntrinsics, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result);

        [VtblIndex(9)]
        HRESULT MapPoints([NativeTypeName("UINT32")] uint sourcePointsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* sourcePoints, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* targetCoordinateSystem, [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")] ICameraIntrinsics* targetCameraIntrinsics, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, ISpatialCoordinateSystem*, Vector3*, int> UnprojectPoint;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Point *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, UINT32, ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Point*, ISpatialCoordinateSystem*, uint, Vector3*, int> UnprojectPoints;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Media::Devices::Core::ICameraIntrinsics *, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, ISpatialCoordinateSystem*, ICameraIntrinsics*, Point*, int> MapPoint;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Point *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Media::Devices::Core::ICameraIntrinsics *, UINT32, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Point*, ISpatialCoordinateSystem*, ICameraIntrinsics*, uint, Point*, int> MapPoints;
    }
}
