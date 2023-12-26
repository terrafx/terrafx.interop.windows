// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics"]/*' />
[Guid("0AA6ED32-6589-49DA-AFDE-594270CA0AAC")]
[NativeTypeName("struct ICameraIntrinsics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraIntrinsics : ICameraIntrinsics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraIntrinsics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, Guid*, void**, int>)(lpVtbl[0]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, uint>)(lpVtbl[1]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, uint>)(lpVtbl[2]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, uint*, Guid**, int>)(lpVtbl[3]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, HSTRING*, int>)(lpVtbl[4]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, TrustLevel*, int>)(lpVtbl[5]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.get_FocalLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FocalLength([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, Vector2*, int>)(lpVtbl[6]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.get_PrincipalPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrincipalPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, Vector2*, int>)(lpVtbl[7]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.get_RadialDistortion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RadialDistortion([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, Vector3*, int>)(lpVtbl[8]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.get_TangentialDistortion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TangentialDistortion([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, Vector2*, int>)(lpVtbl[9]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.get_ImageWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ImageWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, uint*, int>)(lpVtbl[10]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.get_ImageHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ImageHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, uint*, int>)(lpVtbl[11]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.ProjectOntoFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ProjectOntoFrame([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 coordinate, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, Vector3, Point*, int>)(lpVtbl[12]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), coordinate, result);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.UnprojectAtUnitDepth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UnprojectAtUnitDepth([NativeTypeName("ABI::Windows::Foundation::Point")] Point pixelCoordinate, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, Point, Vector2*, int>)(lpVtbl[13]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), pixelCoordinate, result);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.ProjectManyOntoFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ProjectManyOntoFrame([NativeTypeName("UINT32")] uint coordinatesLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* coordinates, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, uint, Vector3*, uint, Point*, int>)(lpVtbl[14]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), coordinatesLength, coordinates, resultsLength, results);
    }

    /// <include file='ICameraIntrinsics.xml' path='doc/member[@name="ICameraIntrinsics.UnprojectPixelsAtUnitDepth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT UnprojectPixelsAtUnitDepth([NativeTypeName("UINT32")] uint pixelCoordinatesLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* pixelCoordinates, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* results)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics*, uint, Point*, uint, Vector2*, int>)(lpVtbl[15]))((ICameraIntrinsics*)Unsafe.AsPointer(ref this), pixelCoordinatesLength, pixelCoordinates, resultsLength, results);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FocalLength([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(7)]
        HRESULT get_PrincipalPoint([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(8)]
        HRESULT get_RadialDistortion([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(9)]
        HRESULT get_TangentialDistortion([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(10)]
        HRESULT get_ImageWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT get_ImageHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT ProjectOntoFrame([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 coordinate, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result);

        [VtblIndex(13)]
        HRESULT UnprojectAtUnitDepth([NativeTypeName("ABI::Windows::Foundation::Point")] Point pixelCoordinate, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* result);

        [VtblIndex(14)]
        HRESULT ProjectManyOntoFrame([NativeTypeName("UINT32")] uint coordinatesLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* coordinates, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results);

        [VtblIndex(15)]
        HRESULT UnprojectPixelsAtUnitDepth([NativeTypeName("UINT32")] uint pixelCoordinatesLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* pixelCoordinates, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* results);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_FocalLength;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_PrincipalPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_RadialDistortion;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_TangentialDistortion;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ImageWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ImageHeight;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, Point*, int> ProjectOntoFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, Vector2*, int> UnprojectAtUnitDepth;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Numerics::Vector3 *, UINT32, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Vector3*, uint, Point*, int> ProjectManyOntoFrame;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Point *, UINT32, ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Point*, uint, Vector2*, int> UnprojectPixelsAtUnitDepth;
    }
}
