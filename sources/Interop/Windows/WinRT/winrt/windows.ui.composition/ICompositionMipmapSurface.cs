// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionMipmapSurface.xml' path='doc/member[@name="ICompositionMipmapSurface"]/*' />
[Guid("4863675C-CF4A-4B1C-9ECE-C5EC0C2B2FE6")]
[NativeTypeName("struct ICompositionMipmapSurface : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionMipmapSurface : ICompositionMipmapSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionMipmapSurface);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, uint>)(lpVtbl[1]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, uint>)(lpVtbl[2]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, HSTRING*, int>)(lpVtbl[4]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionMipmapSurface.xml' path='doc/member[@name="ICompositionMipmapSurface.get_LevelCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LevelCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, uint*, int>)(lpVtbl[6]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionMipmapSurface.xml' path='doc/member[@name="ICompositionMipmapSurface.get_AlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AlphaMode([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")] DirectXAlphaMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, DirectXAlphaMode*, int>)(lpVtbl[7]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionMipmapSurface.xml' path='doc/member[@name="ICompositionMipmapSurface.get_PixelFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PixelFormat([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat *")] DirectXPixelFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, DirectXPixelFormat*, int>)(lpVtbl[8]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionMipmapSurface.xml' path='doc/member[@name="ICompositionMipmapSurface.get_SizeInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SizeInt32([NativeTypeName("ABI::Windows::Graphics::SizeInt32 *")] SizeInt32* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, SizeInt32*, int>)(lpVtbl[9]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionMipmapSurface.xml' path='doc/member[@name="ICompositionMipmapSurface.GetDrawingSurfaceForLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDrawingSurfaceForLevel([NativeTypeName("UINT32")] uint level, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")] ICompositionDrawingSurface** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionMipmapSurface*, uint, ICompositionDrawingSurface**, int>)(lpVtbl[10]))((ICompositionMipmapSurface*)Unsafe.AsPointer(ref this), level, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LevelCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_AlphaMode([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")] DirectXAlphaMode* value);

        [VtblIndex(8)]
        HRESULT get_PixelFormat([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat *")] DirectXPixelFormat* value);

        [VtblIndex(9)]
        HRESULT get_SizeInt32([NativeTypeName("ABI::Windows::Graphics::SizeInt32 *")] SizeInt32* value);

        [VtblIndex(10)]
        HRESULT GetDrawingSurfaceForLevel([NativeTypeName("UINT32")] uint level, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")] ICompositionDrawingSurface** result);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_LevelCount;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXAlphaMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXAlphaMode*, int> get_AlphaMode;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXPixelFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXPixelFormat*, int> get_PixelFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SizeInt32*, int> get_SizeInt32;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::UI::Composition::ICompositionDrawingSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ICompositionDrawingSurface**, int> GetDrawingSurfaceForLevel;
    }
}
