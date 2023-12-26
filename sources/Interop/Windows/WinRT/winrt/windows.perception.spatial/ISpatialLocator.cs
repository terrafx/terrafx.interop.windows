// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator"]/*' />
[Guid("F6478925-9E0C-3BB6-997E-B64ECCA24CF4")]
[NativeTypeName("struct ISpatialLocator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialLocator : ISpatialLocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialLocator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialLocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, uint>)(lpVtbl[1]))((ISpatialLocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, uint>)(lpVtbl[2]))((ISpatialLocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialLocator*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, HSTRING*, int>)(lpVtbl[4]))((ISpatialLocator*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialLocator*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.get_Locatability"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Locatability([NativeTypeName("ABI::Windows::Perception::Spatial::SpatialLocatability *")] SpatialLocatability* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, SpatialLocatability*, int>)(lpVtbl[6]))((ISpatialLocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.add_LocatabilityChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_LocatabilityChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ISpatialLocator*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.remove_LocatabilityChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_LocatabilityChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, EventRegistrationToken, int>)(lpVtbl[8]))((ISpatialLocator*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.add_PositionalTrackingDeactivating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PositionalTrackingDeactivating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_Windows__CPerception__CSpatial__CSpatialLocatorPositionalTrackingDeactivatingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ISpatialLocator*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.remove_PositionalTrackingDeactivating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PositionalTrackingDeactivating(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, EventRegistrationToken, int>)(lpVtbl[10]))((ISpatialLocator*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.TryLocateAtTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TryLocateAtTimestamp([NativeTypeName("ABI::Windows::Perception::IPerceptionTimestamp *")] IPerceptionTimestamp* timestamp, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocation **")] ISpatialLocation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, IPerceptionTimestamp*, ISpatialCoordinateSystem*, ISpatialLocation**, int>)(lpVtbl[11]))((ISpatialLocator*)Unsafe.AsPointer(ref this), timestamp, coordinateSystem, value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateAttachedFrameOfReferenceAtCurrentHeading([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **")] ISpatialLocatorAttachedFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, ISpatialLocatorAttachedFrameOfReference**, int>)(lpVtbl[12]))((ISpatialLocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **")] ISpatialLocatorAttachedFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, Vector3, ISpatialLocatorAttachedFrameOfReference**, int>)(lpVtbl[13]))((ISpatialLocator*)Unsafe.AsPointer(ref this), relativePosition, value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion relativeOrientation, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **")] ISpatialLocatorAttachedFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, Vector3, Quaternion, ISpatialLocatorAttachedFrameOfReference**, int>)(lpVtbl[14]))((ISpatialLocator*)Unsafe.AsPointer(ref this), relativePosition, relativeOrientation, value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion relativeOrientation, double relativeHeadingInRadians, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **")] ISpatialLocatorAttachedFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, Vector3, Quaternion, double, ISpatialLocatorAttachedFrameOfReference**, int>)(lpVtbl[15]))((ISpatialLocator*)Unsafe.AsPointer(ref this), relativePosition, relativeOrientation, relativeHeadingInRadians, value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateStationaryFrameOfReferenceAtCurrentLocation([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")] ISpatialStationaryFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, ISpatialStationaryFrameOfReference**, int>)(lpVtbl[16]))((ISpatialLocator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")] ISpatialStationaryFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, Vector3, ISpatialStationaryFrameOfReference**, int>)(lpVtbl[17]))((ISpatialLocator*)Unsafe.AsPointer(ref this), relativePosition, value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion relativeOrientation, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")] ISpatialStationaryFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, Vector3, Quaternion, ISpatialStationaryFrameOfReference**, int>)(lpVtbl[18]))((ISpatialLocator*)Unsafe.AsPointer(ref this), relativePosition, relativeOrientation, value);
    }

    /// <include file='ISpatialLocator.xml' path='doc/member[@name="ISpatialLocator.CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion relativeOrientation, double relativeHeadingInRadians, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")] ISpatialStationaryFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocator*, Vector3, Quaternion, double, ISpatialStationaryFrameOfReference**, int>)(lpVtbl[19]))((ISpatialLocator*)Unsafe.AsPointer(ref this), relativePosition, relativeOrientation, relativeHeadingInRadians, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Locatability([NativeTypeName("ABI::Windows::Perception::Spatial::SpatialLocatability *")] SpatialLocatability* value);

        [VtblIndex(7)]
        HRESULT add_LocatabilityChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(8)]
        HRESULT remove_LocatabilityChanged(EventRegistrationToken cookie);

        [VtblIndex(9)]
        HRESULT add_PositionalTrackingDeactivating([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_Windows__CPerception__CSpatial__CSpatialLocatorPositionalTrackingDeactivatingEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(10)]
        HRESULT remove_PositionalTrackingDeactivating(EventRegistrationToken cookie);

        [VtblIndex(11)]
        HRESULT TryLocateAtTimestamp([NativeTypeName("ABI::Windows::Perception::IPerceptionTimestamp *")] IPerceptionTimestamp* timestamp, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocation **")] ISpatialLocation** value);

        [VtblIndex(12)]
        HRESULT CreateAttachedFrameOfReferenceAtCurrentHeading([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **")] ISpatialLocatorAttachedFrameOfReference** value);

        [VtblIndex(13)]
        HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **")] ISpatialLocatorAttachedFrameOfReference** value);

        [VtblIndex(14)]
        HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion relativeOrientation, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **")] ISpatialLocatorAttachedFrameOfReference** value);

        [VtblIndex(15)]
        HRESULT CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion relativeOrientation, double relativeHeadingInRadians, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **")] ISpatialLocatorAttachedFrameOfReference** value);

        [VtblIndex(16)]
        HRESULT CreateStationaryFrameOfReferenceAtCurrentLocation([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")] ISpatialStationaryFrameOfReference** value);

        [VtblIndex(17)]
        HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")] ISpatialStationaryFrameOfReference** value);

        [VtblIndex(18)]
        HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion relativeOrientation, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")] ISpatialStationaryFrameOfReference** value);

        [VtblIndex(19)]
        HRESULT CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 relativePosition, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion relativeOrientation, double relativeHeadingInRadians, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **")] ISpatialStationaryFrameOfReference** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::SpatialLocatability *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpatialLocatability*, int> get_Locatability;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_LocatabilityChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LocatabilityChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialLocator_Windows__CPerception__CSpatial__CSpatialLocatorPositionalTrackingDeactivatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PositionalTrackingDeactivating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PositionalTrackingDeactivating;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::IPerceptionTimestamp *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::ISpatialLocation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPerceptionTimestamp*, ISpatialCoordinateSystem*, ISpatialLocation**, int> TryLocateAtTimestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialLocatorAttachedFrameOfReference**, int> CreateAttachedFrameOfReferenceAtCurrentHeading;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, ISpatialLocatorAttachedFrameOfReference**, int> CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, Quaternion, ISpatialLocatorAttachedFrameOfReference**, int> CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, DOUBLE, ABI::Windows::Perception::Spatial::ISpatialLocatorAttachedFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, Quaternion, double, ISpatialLocatorAttachedFrameOfReference**, int> CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialStationaryFrameOfReference**, int> CreateStationaryFrameOfReferenceAtCurrentLocation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, ISpatialStationaryFrameOfReference**, int> CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, Quaternion, ISpatialStationaryFrameOfReference**, int> CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, DOUBLE, ABI::Windows::Perception::Spatial::ISpatialStationaryFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, Quaternion, double, ISpatialStationaryFrameOfReference**, int> CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading;
    }
}
