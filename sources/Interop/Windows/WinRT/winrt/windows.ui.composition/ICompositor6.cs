// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositor6.xml' path='doc/member[@name="ICompositor6"]/*' />
[Guid("7A38B2BD-CEC8-4EEB-830F-D8D07AEDEBC3")]
[NativeTypeName("struct ICompositor6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor6 : ICompositor6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositor6));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, Guid*, void**, int>)(lpVtbl[0]))((ICompositor6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, uint>)(lpVtbl[1]))((ICompositor6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, uint>)(lpVtbl[2]))((ICompositor6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositor6*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, HSTRING*, int>)(lpVtbl[4]))((ICompositor6*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, TrustLevel*, int>)(lpVtbl[5]))((ICompositor6*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositor6.xml' path='doc/member[@name="ICompositor6.CreateGeometricClip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateGeometricClip([NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometricClip **")] ICompositionGeometricClip** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, ICompositionGeometricClip**, int>)(lpVtbl[6]))((ICompositor6*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor6.xml' path='doc/member[@name="ICompositor6.CreateGeometricClipWithGeometry"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateGeometricClipWithGeometry([NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")] ICompositionGeometry* geometry, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometricClip **")] ICompositionGeometricClip** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, ICompositionGeometry*, ICompositionGeometricClip**, int>)(lpVtbl[7]))((ICompositor6*)Unsafe.AsPointer(ref this), geometry, result);
    }

    /// <include file='ICompositor6.xml' path='doc/member[@name="ICompositor6.CreateRedirectVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateRedirectVisual([NativeTypeName("ABI::Windows::UI::Composition::IRedirectVisual **")] IRedirectVisual** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, IRedirectVisual**, int>)(lpVtbl[8]))((ICompositor6*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ICompositor6.xml' path='doc/member[@name="ICompositor6.CreateRedirectVisualWithSourceVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateRedirectVisualWithSourceVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* source, [NativeTypeName("ABI::Windows::UI::Composition::IRedirectVisual **")] IRedirectVisual** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, IVisual*, IRedirectVisual**, int>)(lpVtbl[9]))((ICompositor6*)Unsafe.AsPointer(ref this), source, result);
    }

    /// <include file='ICompositor6.xml' path='doc/member[@name="ICompositor6.CreateBooleanKeyFrameAnimation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateBooleanKeyFrameAnimation([NativeTypeName("ABI::Windows::UI::Composition::IBooleanKeyFrameAnimation **")] IBooleanKeyFrameAnimation** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositor6*, IBooleanKeyFrameAnimation**, int>)(lpVtbl[10]))((ICompositor6*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateGeometricClip([NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometricClip **")] ICompositionGeometricClip** result);

        [VtblIndex(7)]
        HRESULT CreateGeometricClipWithGeometry([NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")] ICompositionGeometry* geometry, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometricClip **")] ICompositionGeometricClip** result);

        [VtblIndex(8)]
        HRESULT CreateRedirectVisual([NativeTypeName("ABI::Windows::UI::Composition::IRedirectVisual **")] IRedirectVisual** result);

        [VtblIndex(9)]
        HRESULT CreateRedirectVisualWithSourceVisual([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* source, [NativeTypeName("ABI::Windows::UI::Composition::IRedirectVisual **")] IRedirectVisual** result);

        [VtblIndex(10)]
        HRESULT CreateBooleanKeyFrameAnimation([NativeTypeName("ABI::Windows::UI::Composition::IBooleanKeyFrameAnimation **")] IBooleanKeyFrameAnimation** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionGeometricClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionGeometricClip**, int> CreateGeometricClip;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry *, ABI::Windows::UI::Composition::ICompositionGeometricClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionGeometry*, ICompositionGeometricClip**, int> CreateGeometricClipWithGeometry;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IRedirectVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRedirectVisual**, int> CreateRedirectVisual;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::UI::Composition::IRedirectVisual **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, IRedirectVisual**, int> CreateRedirectVisualWithSourceVisual;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IBooleanKeyFrameAnimation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBooleanKeyFrameAnimation**, int> CreateBooleanKeyFrameAnimation;
    }
}
