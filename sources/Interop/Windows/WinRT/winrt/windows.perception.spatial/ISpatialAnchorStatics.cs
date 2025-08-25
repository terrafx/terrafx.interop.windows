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

/// <include file='ISpatialAnchorStatics.xml' path='doc/member[@name="ISpatialAnchorStatics"]/*' />
[Guid("A9928642-0174-311C-AE79-0E5107669F16")]
[NativeTypeName("struct ISpatialAnchorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchorStatics : ISpatialAnchorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpatialAnchorStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, uint>)(lpVtbl[1]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, uint>)(lpVtbl[2]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAnchorStatics.xml' path='doc/member[@name="ISpatialAnchorStatics.TryCreateRelativeTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryCreateRelativeTo([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")] ISpatialAnchor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, ISpatialCoordinateSystem*, ISpatialAnchor**, int>)(lpVtbl[6]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this), coordinateSystem, value);
    }

    /// <include file='ISpatialAnchorStatics.xml' path='doc/member[@name="ISpatialAnchorStatics.TryCreateWithPositionRelativeTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryCreateWithPositionRelativeTo([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 position, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")] ISpatialAnchor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, ISpatialCoordinateSystem*, Vector3, ISpatialAnchor**, int>)(lpVtbl[7]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this), coordinateSystem, position, value);
    }

    /// <include file='ISpatialAnchorStatics.xml' path='doc/member[@name="ISpatialAnchorStatics.TryCreateWithPositionAndOrientationRelativeTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryCreateWithPositionAndOrientationRelativeTo([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 position, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion orientation, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")] ISpatialAnchor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStatics*, ISpatialCoordinateSystem*, Vector3, Quaternion, ISpatialAnchor**, int>)(lpVtbl[8]))((ISpatialAnchorStatics*)Unsafe.AsPointer(ref this), coordinateSystem, position, orientation, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryCreateRelativeTo([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")] ISpatialAnchor** value);

        [VtblIndex(7)]
        HRESULT TryCreateWithPositionRelativeTo([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 position, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")] ISpatialAnchor** value);

        [VtblIndex(8)]
        HRESULT TryCreateWithPositionAndOrientationRelativeTo([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 position, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion orientation, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor **")] ISpatialAnchor** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Perception::Spatial::ISpatialAnchor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem*, ISpatialAnchor**, int> TryCreateRelativeTo;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Perception::Spatial::ISpatialAnchor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem*, Vector3, ISpatialAnchor**, int> TryCreateWithPositionRelativeTo;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Quaternion, ABI::Windows::Perception::Spatial::ISpatialAnchor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem*, Vector3, Quaternion, ISpatialAnchor**, int> TryCreateWithPositionAndOrientationRelativeTo;
    }
}
