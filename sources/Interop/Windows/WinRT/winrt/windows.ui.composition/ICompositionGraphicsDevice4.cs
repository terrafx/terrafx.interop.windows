// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionGraphicsDevice4.xml' path='doc/member[@name="ICompositionGraphicsDevice4"]/*' />
[Guid("5A73BFF9-A97F-4CF5-BA46-98EF358E71B1")]
[NativeTypeName("struct ICompositionGraphicsDevice4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGraphicsDevice4 : ICompositionGraphicsDevice4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGraphicsDevice4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice4*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGraphicsDevice4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice4*, uint>)(lpVtbl[1]))((ICompositionGraphicsDevice4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice4*, uint>)(lpVtbl[2]))((ICompositionGraphicsDevice4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice4*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionGraphicsDevice4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice4*, HSTRING*, int>)(lpVtbl[4]))((ICompositionGraphicsDevice4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice4*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionGraphicsDevice4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionGraphicsDevice4.xml' path='doc/member[@name="ICompositionGraphicsDevice4.CaptureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CaptureAsync([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* captureVisual, [NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 size, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, float sdrBoost, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CComposition__CICompositionSurface_t **")] IAsyncOperation<Pointer<ICompositionSurface>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice4*, IVisual*, SizeInt32, DirectXPixelFormat, DirectXAlphaMode, float, IAsyncOperation<Pointer<ICompositionSurface>>**, int>)(lpVtbl[6]))((ICompositionGraphicsDevice4*)Unsafe.AsPointer(ref this), captureVisual, size, pixelFormat, alphaMode, sdrBoost, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CaptureAsync([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* captureVisual, [NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 size, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, float sdrBoost, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CComposition__CICompositionSurface_t **")] IAsyncOperation<Pointer<ICompositionSurface>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::Graphics::SizeInt32, ABI::Windows::Graphics::DirectX::DirectXPixelFormat, ABI::Windows::Graphics::DirectX::DirectXAlphaMode, FLOAT, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CComposition__CICompositionSurface_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, SizeInt32, DirectXPixelFormat, DirectXAlphaMode, float, IAsyncOperation<Pointer<ICompositionSurface>>**, int> CaptureAsync;
    }
}
