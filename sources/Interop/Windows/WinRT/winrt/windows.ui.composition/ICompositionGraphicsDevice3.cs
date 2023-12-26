// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionGraphicsDevice3.xml' path='doc/member[@name="ICompositionGraphicsDevice3"]/*' />
[Guid("37F67514-D3EF-49D1-B69D-0D8EABEB3626")]
[NativeTypeName("struct ICompositionGraphicsDevice3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGraphicsDevice3 : ICompositionGraphicsDevice3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGraphicsDevice3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice3*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGraphicsDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice3*, uint>)(lpVtbl[1]))((ICompositionGraphicsDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice3*, uint>)(lpVtbl[2]))((ICompositionGraphicsDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice3*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionGraphicsDevice3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice3*, HSTRING*, int>)(lpVtbl[4]))((ICompositionGraphicsDevice3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice3*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionGraphicsDevice3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionGraphicsDevice3.xml' path='doc/member[@name="ICompositionGraphicsDevice3.CreateMipmapSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateMipmapSurface([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionMipmapSurface **")] ICompositionMipmapSurface** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice3*, SizeInt32, DirectXPixelFormat, DirectXAlphaMode, ICompositionMipmapSurface**, int>)(lpVtbl[6]))((ICompositionGraphicsDevice3*)Unsafe.AsPointer(ref this), sizePixels, pixelFormat, alphaMode, result);
    }

    /// <include file='ICompositionGraphicsDevice3.xml' path='doc/member[@name="ICompositionGraphicsDevice3.Trim"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Trim()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice3*, int>)(lpVtbl[7]))((ICompositionGraphicsDevice3*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateMipmapSurface([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionMipmapSurface **")] ICompositionMipmapSurface** result);

        [VtblIndex(7)]
        HRESULT Trim();
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32, ABI::Windows::Graphics::DirectX::DirectXPixelFormat, ABI::Windows::Graphics::DirectX::DirectXAlphaMode, ABI::Windows::UI::Composition::ICompositionMipmapSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SizeInt32, DirectXPixelFormat, DirectXAlphaMode, ICompositionMipmapSurface**, int> CreateMipmapSurface;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Trim;
    }
}
