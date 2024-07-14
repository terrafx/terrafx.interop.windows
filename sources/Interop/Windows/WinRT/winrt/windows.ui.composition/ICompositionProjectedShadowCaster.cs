// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionProjectedShadowCaster.xml' path='doc/member[@name="ICompositionProjectedShadowCaster"]/*' />
[Guid("B1D7D426-1E36-5A62-BE56-A16112FDD148")]
[NativeTypeName("struct ICompositionProjectedShadowCaster : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionProjectedShadowCaster : ICompositionProjectedShadowCaster.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionProjectedShadowCaster));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, uint>)(lpVtbl[1]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, uint>)(lpVtbl[2]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, HSTRING*, int>)(lpVtbl[4]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionProjectedShadowCaster.xml' path='doc/member[@name="ICompositionProjectedShadowCaster.get_Brush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Brush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")] ICompositionBrush** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, ICompositionBrush**, int>)(lpVtbl[6]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadowCaster.xml' path='doc/member[@name="ICompositionProjectedShadowCaster.put_Brush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Brush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")] ICompositionBrush* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, ICompositionBrush*, int>)(lpVtbl[7]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadowCaster.xml' path='doc/member[@name="ICompositionProjectedShadowCaster.get_CastingVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CastingVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, IVisual**, int>)(lpVtbl[8]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadowCaster.xml' path='doc/member[@name="ICompositionProjectedShadowCaster.put_CastingVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CastingVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCaster*, IVisual*, int>)(lpVtbl[9]))((ICompositionProjectedShadowCaster*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Brush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")] ICompositionBrush** value);

        [VtblIndex(7)]
        HRESULT put_Brush([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")] ICompositionBrush* value);

        [VtblIndex(8)]
        HRESULT get_CastingVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual** value);

        [VtblIndex(9)]
        HRESULT put_CastingVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionBrush**, int> get_Brush;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionBrush *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionBrush*, int> put_Brush;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual**, int> get_CastingVisual;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> put_CastingVisual;
    }
}
