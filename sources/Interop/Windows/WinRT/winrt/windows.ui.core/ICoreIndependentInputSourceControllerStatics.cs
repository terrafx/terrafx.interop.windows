// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreIndependentInputSourceControllerStatics.xml' path='doc/member[@name="ICoreIndependentInputSourceControllerStatics"]/*' />
[Guid("3EDC4E20-9A8A-5691-8586-FCA4CB57526D")]
[NativeTypeName("struct ICoreIndependentInputSourceControllerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreIndependentInputSourceControllerStatics : ICoreIndependentInputSourceControllerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreIndependentInputSourceControllerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceControllerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICoreIndependentInputSourceControllerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceControllerStatics*, uint>)(lpVtbl[1]))((ICoreIndependentInputSourceControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceControllerStatics*, uint>)(lpVtbl[2]))((ICoreIndependentInputSourceControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceControllerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreIndependentInputSourceControllerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceControllerStatics*, HSTRING*, int>)(lpVtbl[4]))((ICoreIndependentInputSourceControllerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceControllerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICoreIndependentInputSourceControllerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreIndependentInputSourceControllerStatics.xml' path='doc/member[@name="ICoreIndependentInputSourceControllerStatics.CreateForVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateForVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* visual, [NativeTypeName("ABI::Windows::UI::Core::ICoreIndependentInputSourceController **")] ICoreIndependentInputSourceController** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceControllerStatics*, IVisual*, ICoreIndependentInputSourceController**, int>)(lpVtbl[6]))((ICoreIndependentInputSourceControllerStatics*)Unsafe.AsPointer(ref this), visual, result);
    }

    /// <include file='ICoreIndependentInputSourceControllerStatics.xml' path='doc/member[@name="ICoreIndependentInputSourceControllerStatics.CreateForIVisualElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateForIVisualElement([NativeTypeName("ABI::Windows::UI::Composition::IVisualElement *")] IVisualElement* visualElement, [NativeTypeName("ABI::Windows::UI::Core::ICoreIndependentInputSourceController **")] ICoreIndependentInputSourceController** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreIndependentInputSourceControllerStatics*, IVisualElement*, ICoreIndependentInputSourceController**, int>)(lpVtbl[7]))((ICoreIndependentInputSourceControllerStatics*)Unsafe.AsPointer(ref this), visualElement, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateForVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* visual, [NativeTypeName("ABI::Windows::UI::Core::ICoreIndependentInputSourceController **")] ICoreIndependentInputSourceController** result);

        [VtblIndex(7)]
        HRESULT CreateForIVisualElement([NativeTypeName("ABI::Windows::UI::Composition::IVisualElement *")] IVisualElement* visualElement, [NativeTypeName("ABI::Windows::UI::Core::ICoreIndependentInputSourceController **")] ICoreIndependentInputSourceController** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::UI::Core::ICoreIndependentInputSourceController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, ICoreIndependentInputSourceController**, int> CreateForVisual;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisualElement *, ABI::Windows::UI::Core::ICoreIndependentInputSourceController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisualElement*, ICoreIndependentInputSourceController**, int> CreateForIVisualElement;
    }
}
