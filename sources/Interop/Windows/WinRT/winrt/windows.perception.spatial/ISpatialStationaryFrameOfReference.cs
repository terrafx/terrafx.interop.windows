// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialStationaryFrameOfReference.xml' path='doc/member[@name="ISpatialStationaryFrameOfReference"]/*' />
[Guid("09DBCCB9-BCF8-3E7F-BE7E-7EDCCBB178A8")]
[NativeTypeName("struct ISpatialStationaryFrameOfReference : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialStationaryFrameOfReference : ISpatialStationaryFrameOfReference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpatialStationaryFrameOfReference);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStationaryFrameOfReference*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialStationaryFrameOfReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStationaryFrameOfReference*, uint>)(lpVtbl[1]))((ISpatialStationaryFrameOfReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStationaryFrameOfReference*, uint>)(lpVtbl[2]))((ISpatialStationaryFrameOfReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStationaryFrameOfReference*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialStationaryFrameOfReference*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStationaryFrameOfReference*, HSTRING*, int>)(lpVtbl[4]))((ISpatialStationaryFrameOfReference*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStationaryFrameOfReference*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialStationaryFrameOfReference*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialStationaryFrameOfReference.xml' path='doc/member[@name="ISpatialStationaryFrameOfReference.get_CoordinateSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStationaryFrameOfReference*, ISpatialCoordinateSystem**, int>)(lpVtbl[6]))((ISpatialStationaryFrameOfReference*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value);
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
    }
}
