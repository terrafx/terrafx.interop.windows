// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAnchorStore.xml' path='doc/member[@name="ISpatialAnchorStore"]/*' />
[Guid("B0BC3636-486A-3CB0-9E6F-1245165C4DB6")]
[NativeTypeName("struct ISpatialAnchorStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchorStore : ISpatialAnchorStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchorStore));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, uint>)(lpVtbl[1]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, uint>)(lpVtbl[2]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAnchorStore.xml' path='doc/member[@name="ISpatialAnchorStore.GetAllSavedAnchors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAllSavedAnchors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **")] IMapView<HSTRING, IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, IMapView<HSTRING, IntPtr>**, int>)(lpVtbl[6]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAnchorStore.xml' path='doc/member[@name="ISpatialAnchorStore.TrySave"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TrySave(HSTRING id, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* anchor, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, HSTRING, ISpatialAnchor*, byte*, int>)(lpVtbl[7]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this), id, anchor, succeeded);
    }

    /// <include file='ISpatialAnchorStore.xml' path='doc/member[@name="ISpatialAnchorStore.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Remove(HSTRING id)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, HSTRING, int>)(lpVtbl[8]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this), id);
    }

    /// <include file='ISpatialAnchorStore.xml' path='doc/member[@name="ISpatialAnchorStore.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorStore*, int>)(lpVtbl[9]))((ISpatialAnchorStore*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAllSavedAnchors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **")] IMapView<HSTRING, IntPtr>** value);

        [VtblIndex(7)]
        HRESULT TrySave(HSTRING id, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* anchor, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(8)]
        HRESULT Remove(HSTRING id);

        [VtblIndex(9)]
        HRESULT Clear();
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, IntPtr>**, int> GetAllSavedAnchors;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Perception::Spatial::ISpatialAnchor *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISpatialAnchor*, byte*, int> TrySave;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;
    }
}
