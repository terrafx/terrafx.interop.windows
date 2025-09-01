// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialLocatorAttachedFrameOfReference.xml' path='doc/member[@name="ISpatialLocatorAttachedFrameOfReference"]/*' />
[Guid("E1774EF6-1F4F-499C-9625-EF5E6ED7A048")]
[NativeTypeName("struct ISpatialLocatorAttachedFrameOfReference : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialLocatorAttachedFrameOfReference : ISpatialLocatorAttachedFrameOfReference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpatialLocatorAttachedFrameOfReference);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, uint>)(lpVtbl[1]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, uint>)(lpVtbl[2]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, HSTRING*, int>)(lpVtbl[4]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialLocatorAttachedFrameOfReference.xml' path='doc/member[@name="ISpatialLocatorAttachedFrameOfReference.get_RelativePosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RelativePosition([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, Vector3*, int>)(lpVtbl[6]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocatorAttachedFrameOfReference.xml' path='doc/member[@name="ISpatialLocatorAttachedFrameOfReference.put_RelativePosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_RelativePosition([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, Vector3, int>)(lpVtbl[7]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocatorAttachedFrameOfReference.xml' path='doc/member[@name="ISpatialLocatorAttachedFrameOfReference.get_RelativeOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RelativeOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, Quaternion*, int>)(lpVtbl[8]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocatorAttachedFrameOfReference.xml' path='doc/member[@name="ISpatialLocatorAttachedFrameOfReference.put_RelativeOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RelativeOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, Quaternion, int>)(lpVtbl[9]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocatorAttachedFrameOfReference.xml' path='doc/member[@name="ISpatialLocatorAttachedFrameOfReference.AdjustHeading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AdjustHeading(double headingOffsetInRadians)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, double, int>)(lpVtbl[10]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), headingOffsetInRadians);
    }

    /// <include file='ISpatialLocatorAttachedFrameOfReference.xml' path='doc/member[@name="ISpatialLocatorAttachedFrameOfReference.GetStationaryCoordinateSystemAtTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStationaryCoordinateSystemAtTimestamp([NativeTypeName("ABI::Windows::Perception::IPerceptionTimestamp *")] IPerceptionTimestamp* timestamp, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, IPerceptionTimestamp*, ISpatialCoordinateSystem**, int>)(lpVtbl[11]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), timestamp, value);
    }

    /// <include file='ISpatialLocatorAttachedFrameOfReference.xml' path='doc/member[@name="ISpatialLocatorAttachedFrameOfReference.TryGetRelativeHeadingAtTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TryGetRelativeHeadingAtTimestamp([NativeTypeName("ABI::Windows::Perception::IPerceptionTimestamp *")] IPerceptionTimestamp* timestamp, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocatorAttachedFrameOfReference*, IPerceptionTimestamp*, IReference<double>**, int>)(lpVtbl[12]))((ISpatialLocatorAttachedFrameOfReference*)Unsafe.AsPointer(ref this), timestamp, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RelativePosition([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(7)]
        HRESULT put_RelativePosition([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(8)]
        HRESULT get_RelativeOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value);

        [VtblIndex(9)]
        HRESULT put_RelativeOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value);

        [VtblIndex(10)]
        HRESULT AdjustHeading(double headingOffsetInRadians);

        [VtblIndex(11)]
        HRESULT GetStationaryCoordinateSystemAtTimestamp([NativeTypeName("ABI::Windows::Perception::IPerceptionTimestamp *")] IPerceptionTimestamp* timestamp, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value);

        [VtblIndex(12)]
        HRESULT TryGetRelativeHeadingAtTimestamp([NativeTypeName("ABI::Windows::Perception::IPerceptionTimestamp *")] IPerceptionTimestamp* timestamp, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_RelativePosition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_RelativePosition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion*, int> get_RelativeOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion, int> put_RelativeOrientation;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> AdjustHeading;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::IPerceptionTimestamp *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPerceptionTimestamp*, ISpatialCoordinateSystem**, int> GetStationaryCoordinateSystemAtTimestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::IPerceptionTimestamp *, ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPerceptionTimestamp*, IReference<double>**, int> TryGetRelativeHeadingAtTimestamp;
    }
}
