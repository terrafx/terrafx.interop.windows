// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAnchor.xml' path='doc/member[@name="ISpatialAnchor"]/*' />
[Guid("0529E5CE-1D34-3702-BCEC-EABFF578A869")]
[NativeTypeName("struct ISpatialAnchor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchor : ISpatialAnchor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAnchor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, uint>)(lpVtbl[1]))((ISpatialAnchor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, uint>)(lpVtbl[2]))((ISpatialAnchor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAnchor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAnchor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAnchor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAnchor.xml' path='doc/member[@name="ISpatialAnchor.get_CoordinateSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, ISpatialCoordinateSystem**, int>)(lpVtbl[6]))((ISpatialAnchor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAnchor.xml' path='doc/member[@name="ISpatialAnchor.get_RawCoordinateSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RawCoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, ISpatialCoordinateSystem**, int>)(lpVtbl[7]))((ISpatialAnchor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAnchor.xml' path='doc/member[@name="ISpatialAnchor.add_RawCoordinateSystemAdjusted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_RawCoordinateSystemAdjusted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialAnchor_Windows__CPerception__CSpatial__CSpatialAnchorRawCoordinateSystemAdjustedEventArgs_t *")] ITypedEventHandler<Pointer<ISpatialAnchor>, Pointer<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, ITypedEventHandler<Pointer<ISpatialAnchor>, Pointer<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ISpatialAnchor*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ISpatialAnchor.xml' path='doc/member[@name="ISpatialAnchor.remove_RawCoordinateSystemAdjusted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_RawCoordinateSystemAdjusted(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchor*, EventRegistrationToken, int>)(lpVtbl[9]))((ISpatialAnchor*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value);

        [VtblIndex(7)]
        HRESULT get_RawCoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value);

        [VtblIndex(8)]
        HRESULT add_RawCoordinateSystemAdjusted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialAnchor_Windows__CPerception__CSpatial__CSpatialAnchorRawCoordinateSystemAdjustedEventArgs_t *")] ITypedEventHandler<Pointer<ISpatialAnchor>, Pointer<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(9)]
        HRESULT remove_RawCoordinateSystemAdjusted(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem**, int> get_RawCoordinateSystem;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CPerception__CSpatial__CSpatialAnchor_Windows__CPerception__CSpatial__CSpatialAnchorRawCoordinateSystemAdjustedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISpatialAnchor>, Pointer<ISpatialAnchorRawCoordinateSystemAdjustedEventArgs>>*, EventRegistrationToken*, int> add_RawCoordinateSystemAdjusted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RawCoordinateSystemAdjusted;
    }
}
