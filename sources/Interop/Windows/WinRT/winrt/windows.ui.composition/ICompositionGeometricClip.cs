// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionGeometricClip.xml' path='doc/member[@name="ICompositionGeometricClip"]/*' />
[Guid("C840B581-81C9-4444-A2C1-CCAECE3A50E5")]
[NativeTypeName("struct ICompositionGeometricClip : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGeometricClip : ICompositionGeometricClip.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGeometricClip));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, uint>)(lpVtbl[1]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, uint>)(lpVtbl[2]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, HSTRING*, int>)(lpVtbl[4]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionGeometricClip.xml' path='doc/member[@name="ICompositionGeometricClip.get_Geometry"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Geometry([NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry **")] ICompositionGeometry** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, ICompositionGeometry**, int>)(lpVtbl[6]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGeometricClip.xml' path='doc/member[@name="ICompositionGeometricClip.put_Geometry"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Geometry([NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")] ICompositionGeometry* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, ICompositionGeometry*, int>)(lpVtbl[7]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGeometricClip.xml' path='doc/member[@name="ICompositionGeometricClip.get_ViewBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ViewBox([NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox **")] ICompositionViewBox** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, ICompositionViewBox**, int>)(lpVtbl[8]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGeometricClip.xml' path='doc/member[@name="ICompositionGeometricClip.put_ViewBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ViewBox([NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox *")] ICompositionViewBox* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometricClip*, ICompositionViewBox*, int>)(lpVtbl[9]))((ICompositionGeometricClip*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Geometry([NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry **")] ICompositionGeometry** value);

        [VtblIndex(7)]
        HRESULT put_Geometry([NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")] ICompositionGeometry* value);

        [VtblIndex(8)]
        HRESULT get_ViewBox([NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox **")] ICompositionViewBox** value);

        [VtblIndex(9)]
        HRESULT put_ViewBox([NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox *")] ICompositionViewBox* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionGeometry**, int> get_Geometry;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionGeometry*, int> put_Geometry;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionViewBox **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionViewBox**, int> get_ViewBox;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionViewBox *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionViewBox*, int> put_ViewBox;
    }
}
