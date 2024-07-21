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

/// <include file='ISpatialAnchorRawCoordinateSystemAdjustedEventArgs.xml' path='doc/member[@name="ISpatialAnchorRawCoordinateSystemAdjustedEventArgs"]/*' />
[Guid("A1E81EB8-56C7-3117-A2E4-81E0FCF28E00")]
[NativeTypeName("struct ISpatialAnchorRawCoordinateSystemAdjustedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchorRawCoordinateSystemAdjustedEventArgs : ISpatialAnchorRawCoordinateSystemAdjustedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchorRawCoordinateSystemAdjustedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*, uint>)(lpVtbl[1]))((ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*, uint>)(lpVtbl[2]))((ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAnchorRawCoordinateSystemAdjustedEventArgs.xml' path='doc/member[@name="ISpatialAnchorRawCoordinateSystemAdjustedEventArgs.get_OldRawCoordinateSystemToNewRawCoordinateSystemTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OldRawCoordinateSystemToNewRawCoordinateSystemTransform([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*, Matrix4x4*, int>)(lpVtbl[6]))((ISpatialAnchorRawCoordinateSystemAdjustedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OldRawCoordinateSystemToNewRawCoordinateSystemTransform([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Matrix4x4 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Matrix4x4*, int> get_OldRawCoordinateSystemToNewRawCoordinateSystemTransform;
    }
}
