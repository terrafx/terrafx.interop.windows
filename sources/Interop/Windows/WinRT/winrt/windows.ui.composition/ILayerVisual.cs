// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILayerVisual.xml' path='doc/member[@name="ILayerVisual"]/*' />
[Guid("AF843985-0444-4887-8E83-B40B253F822C")]
[NativeTypeName("struct ILayerVisual : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILayerVisual : ILayerVisual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILayerVisual));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILayerVisual*, Guid*, void**, int>)(lpVtbl[0]))((ILayerVisual*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILayerVisual*, uint>)(lpVtbl[1]))((ILayerVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILayerVisual*, uint>)(lpVtbl[2]))((ILayerVisual*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILayerVisual*, uint*, Guid**, int>)(lpVtbl[3]))((ILayerVisual*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILayerVisual*, HSTRING*, int>)(lpVtbl[4]))((ILayerVisual*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILayerVisual*, TrustLevel*, int>)(lpVtbl[5]))((ILayerVisual*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILayerVisual.xml' path='doc/member[@name="ILayerVisual.get_Effect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Effect([NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectBrush **")] ICompositionEffectBrush** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILayerVisual*, ICompositionEffectBrush**, int>)(lpVtbl[6]))((ILayerVisual*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILayerVisual.xml' path='doc/member[@name="ILayerVisual.put_Effect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Effect([NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectBrush *")] ICompositionEffectBrush* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILayerVisual*, ICompositionEffectBrush*, int>)(lpVtbl[7]))((ILayerVisual*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Effect([NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectBrush **")] ICompositionEffectBrush** value);

        [VtblIndex(7)]
        HRESULT put_Effect([NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectBrush *")] ICompositionEffectBrush* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionEffectBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionEffectBrush**, int> get_Effect;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionEffectBrush *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionEffectBrush*, int> put_Effect;
    }
}
