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

/// <include file='ISpatialStageFrameOfReference.xml' path='doc/member[@name="ISpatialStageFrameOfReference"]/*' />
[Guid("7A8A3464-AD0D-4590-AB86-33062B674926")]
[NativeTypeName("struct ISpatialStageFrameOfReference : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialStageFrameOfReference : ISpatialStageFrameOfReference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpatialStageFrameOfReference);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, uint>)(lpVtbl[1]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, uint>)(lpVtbl[2]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, HSTRING*, int>)(lpVtbl[4]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialStageFrameOfReference.xml' path='doc/member[@name="ISpatialStageFrameOfReference.get_CoordinateSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, ISpatialCoordinateSystem**, int>)(lpVtbl[6]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialStageFrameOfReference.xml' path='doc/member[@name="ISpatialStageFrameOfReference.get_MovementRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MovementRange([NativeTypeName("ABI::Windows::Perception::Spatial::SpatialMovementRange *")] SpatialMovementRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, SpatialMovementRange*, int>)(lpVtbl[7]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialStageFrameOfReference.xml' path='doc/member[@name="ISpatialStageFrameOfReference.get_LookDirectionRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LookDirectionRange([NativeTypeName("ABI::Windows::Perception::Spatial::SpatialLookDirectionRange *")] SpatialLookDirectionRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, SpatialLookDirectionRange*, int>)(lpVtbl[8]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialStageFrameOfReference.xml' path='doc/member[@name="ISpatialStageFrameOfReference.GetCoordinateSystemAtCurrentLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCoordinateSystemAtCurrentLocation([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocator *")] ISpatialLocator* locator, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, ISpatialLocator*, ISpatialCoordinateSystem**, int>)(lpVtbl[9]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), locator, result);
    }

    /// <include file='ISpatialStageFrameOfReference.xml' path='doc/member[@name="ISpatialStageFrameOfReference.TryGetMovementBounds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryGetMovementBounds([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 **")] Vector3** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReference*, ISpatialCoordinateSystem*, uint*, Vector3**, int>)(lpVtbl[10]))((ISpatialStageFrameOfReference*)Unsafe.AsPointer(ref this), coordinateSystem, valueLength, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value);

        [VtblIndex(7)]
        HRESULT get_MovementRange([NativeTypeName("ABI::Windows::Perception::Spatial::SpatialMovementRange *")] SpatialMovementRange* value);

        [VtblIndex(8)]
        HRESULT get_LookDirectionRange([NativeTypeName("ABI::Windows::Perception::Spatial::SpatialLookDirectionRange *")] SpatialLookDirectionRange* value);

        [VtblIndex(9)]
        HRESULT GetCoordinateSystemAtCurrentLocation([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialLocator *")] ISpatialLocator* locator, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** result);

        [VtblIndex(10)]
        HRESULT TryGetMovementBounds([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("UINT32 *")] uint* valueLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 **")] Vector3** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem**, int> get_CoordinateSystem;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::SpatialMovementRange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpatialMovementRange*, int> get_MovementRange;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::SpatialLookDirectionRange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpatialLookDirectionRange*, int> get_LookDirectionRange;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialLocator *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialLocator*, ISpatialCoordinateSystem**, int> GetCoordinateSystemAtCurrentLocation;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, UINT32 *, ABI::Windows::Foundation::Numerics::Vector3 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem*, uint*, Vector3**, int> TryGetMovementBounds;
    }
}
