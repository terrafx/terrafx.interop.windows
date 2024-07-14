// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShapeVisual.xml' path='doc/member[@name="IShapeVisual"]/*' />
[Guid("F2BD13C3-BA7E-4B0F-9126-FFB7536B8176")]
[NativeTypeName("struct IShapeVisual : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShapeVisual : IShapeVisual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShapeVisual));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, Guid*, void**, int>)(lpVtbl[0]))((IShapeVisual*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, uint>)(lpVtbl[1]))((IShapeVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, uint>)(lpVtbl[2]))((IShapeVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, uint*, Guid**, int>)(lpVtbl[3]))((IShapeVisual*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, HSTRING*, int>)(lpVtbl[4]))((IShapeVisual*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, TrustLevel*, int>)(lpVtbl[5]))((IShapeVisual*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShapeVisual.xml' path='doc/member[@name="IShapeVisual.get_Shapes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Shapes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CComposition__CCompositionShape_t **")] IVector<Pointer<ICompositionShape>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, IVector<Pointer<ICompositionShape>>**, int>)(lpVtbl[6]))((IShapeVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShapeVisual.xml' path='doc/member[@name="IShapeVisual.get_ViewBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ViewBox([NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox **")] ICompositionViewBox** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, ICompositionViewBox**, int>)(lpVtbl[7]))((IShapeVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShapeVisual.xml' path='doc/member[@name="IShapeVisual.put_ViewBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ViewBox([NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox *")] ICompositionViewBox* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShapeVisual*, ICompositionViewBox*, int>)(lpVtbl[8]))((IShapeVisual*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Shapes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CComposition__CCompositionShape_t **")] IVector<Pointer<ICompositionShape>>** value);

        [VtblIndex(7)]
        HRESULT get_ViewBox([NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox **")] ICompositionViewBox** value);

        [VtblIndex(8)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CComposition__CCompositionShape_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<ICompositionShape>>**, int> get_Shapes;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionViewBox **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionViewBox**, int> get_ViewBox;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionViewBox *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionViewBox*, int> put_ViewBox;
    }
}
