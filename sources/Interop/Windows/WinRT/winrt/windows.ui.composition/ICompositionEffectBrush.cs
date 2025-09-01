// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionEffectBrush.xml' path='doc/member[@name="ICompositionEffectBrush"]/*' />
[Guid("BF7F795E-83CC-44BF-A447-3E3C071789EC")]
[NativeTypeName("struct ICompositionEffectBrush : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionEffectBrush : ICompositionEffectBrush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionEffectBrush);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectBrush*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionEffectBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectBrush*, uint>)(lpVtbl[1]))((ICompositionEffectBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectBrush*, uint>)(lpVtbl[2]))((ICompositionEffectBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectBrush*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionEffectBrush*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectBrush*, HSTRING*, int>)(lpVtbl[4]))((ICompositionEffectBrush*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectBrush*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionEffectBrush*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionEffectBrush.xml' path='doc/member[@name="ICompositionEffectBrush.GetSourceParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceParameter(HSTRING name, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")] ICompositionBrush** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectBrush*, HSTRING, ICompositionBrush**, int>)(lpVtbl[6]))((ICompositionEffectBrush*)Unsafe.AsPointer(ref this), name, result);
    }

    /// <include file='ICompositionEffectBrush.xml' path='doc/member[@name="ICompositionEffectBrush.SetSourceParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSourceParameter(HSTRING name, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")] ICompositionBrush* source)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectBrush*, HSTRING, ICompositionBrush*, int>)(lpVtbl[7]))((ICompositionEffectBrush*)Unsafe.AsPointer(ref this), name, source);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetSourceParameter(HSTRING name, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")] ICompositionBrush** result);

        [VtblIndex(7)]
        HRESULT SetSourceParameter(HSTRING name, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")] ICompositionBrush* source);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ICompositionBrush**, int> GetSourceParameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionBrush *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ICompositionBrush*, int> SetSourceParameter;
    }
}
