// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDelegatedInkTrailVisualStatics.xml' path='doc/member[@name="IDelegatedInkTrailVisualStatics"]/*' />
[Guid("0DAF6BD5-42C6-555C-9267-E0AC663AF836")]
[NativeTypeName("struct IDelegatedInkTrailVisualStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDelegatedInkTrailVisualStatics : IDelegatedInkTrailVisualStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDelegatedInkTrailVisualStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisualStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDelegatedInkTrailVisualStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisualStatics*, uint>)(lpVtbl[1]))((IDelegatedInkTrailVisualStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisualStatics*, uint>)(lpVtbl[2]))((IDelegatedInkTrailVisualStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisualStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDelegatedInkTrailVisualStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisualStatics*, HSTRING*, int>)(lpVtbl[4]))((IDelegatedInkTrailVisualStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisualStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDelegatedInkTrailVisualStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDelegatedInkTrailVisualStatics.xml' path='doc/member[@name="IDelegatedInkTrailVisualStatics.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* compositor, [NativeTypeName("ABI::Windows::UI::Composition::IDelegatedInkTrailVisual **")] IDelegatedInkTrailVisual** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisualStatics*, ICompositor*, IDelegatedInkTrailVisual**, int>)(lpVtbl[6]))((IDelegatedInkTrailVisualStatics*)Unsafe.AsPointer(ref this), compositor, result);
    }

    /// <include file='IDelegatedInkTrailVisualStatics.xml' path='doc/member[@name="IDelegatedInkTrailVisualStatics.CreateForSwapChain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateForSwapChain([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* compositor, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface *")] ICompositionSurface* swapChain, [NativeTypeName("ABI::Windows::UI::Composition::IDelegatedInkTrailVisual **")] IDelegatedInkTrailVisual** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDelegatedInkTrailVisualStatics*, ICompositor*, ICompositionSurface*, IDelegatedInkTrailVisual**, int>)(lpVtbl[7]))((IDelegatedInkTrailVisualStatics*)Unsafe.AsPointer(ref this), compositor, swapChain, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* compositor, [NativeTypeName("ABI::Windows::UI::Composition::IDelegatedInkTrailVisual **")] IDelegatedInkTrailVisual** result);

        [VtblIndex(7)]
        HRESULT CreateForSwapChain([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* compositor, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface *")] ICompositionSurface* swapChain, [NativeTypeName("ABI::Windows::UI::Composition::IDelegatedInkTrailVisual **")] IDelegatedInkTrailVisual** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::IDelegatedInkTrailVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, IDelegatedInkTrailVisual**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::UI::Composition::ICompositionSurface *, ABI::Windows::UI::Composition::IDelegatedInkTrailVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, ICompositionSurface*, IDelegatedInkTrailVisual**, int> CreateForSwapChain;
    }
}
