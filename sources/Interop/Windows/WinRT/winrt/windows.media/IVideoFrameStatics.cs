// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoFrameStatics.xml' path='doc/member[@name="IVideoFrameStatics"]/*' />
[Guid("AB2A556F-6111-4B33-8EC3-2B209A02E17A")]
[NativeTypeName("struct IVideoFrameStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoFrameStatics : IVideoFrameStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoFrameStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, Guid*, void**, int>)(lpVtbl[0]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, uint>)(lpVtbl[1]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, uint>)(lpVtbl[2]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, HSTRING*, int>)(lpVtbl[4]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, TrustLevel*, int>)(lpVtbl[5]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoFrameStatics.xml' path='doc/member[@name="IVideoFrameStatics.CreateAsDirect3D11SurfaceBacked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAsDirect3D11SurfaceBacked([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat format, [NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, DirectXPixelFormat, int, int, IVideoFrame**, int>)(lpVtbl[6]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this), format, width, height, result);
    }

    /// <include file='IVideoFrameStatics.xml' path='doc/member[@name="IVideoFrameStatics.CreateAsDirect3D11SurfaceBackedWithDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAsDirect3D11SurfaceBackedWithDevice([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat format, [NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")] IDirect3DDevice* device, [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, DirectXPixelFormat, int, int, IDirect3DDevice*, IVideoFrame**, int>)(lpVtbl[7]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this), format, width, height, device, result);
    }

    /// <include file='IVideoFrameStatics.xml' path='doc/member[@name="IVideoFrameStatics.CreateWithSoftwareBitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithSoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* bitmap, [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, ISoftwareBitmap*, IVideoFrame**, int>)(lpVtbl[8]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this), bitmap, result);
    }

    /// <include file='IVideoFrameStatics.xml' path='doc/member[@name="IVideoFrameStatics.CreateWithDirect3D11Surface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateWithDirect3D11Surface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* surface, [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrameStatics*, IDirect3DSurface*, IVideoFrame**, int>)(lpVtbl[9]))((IVideoFrameStatics*)Unsafe.AsPointer(ref this), surface, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAsDirect3D11SurfaceBacked([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat format, [NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** result);

        [VtblIndex(7)]
        HRESULT CreateAsDirect3D11SurfaceBackedWithDevice([NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat format, [NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")] IDirect3DDevice* device, [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** result);

        [VtblIndex(8)]
        HRESULT CreateWithSoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* bitmap, [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** result);

        [VtblIndex(9)]
        HRESULT CreateWithDirect3D11Surface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* surface, [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXPixelFormat, INT32, INT32, ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXPixelFormat, int, int, IVideoFrame**, int> CreateAsDirect3D11SurfaceBacked;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::DirectXPixelFormat, INT32, INT32, ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *, ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DirectXPixelFormat, int, int, IDirect3DDevice*, IVideoFrame**, int> CreateAsDirect3D11SurfaceBackedWithDevice;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap*, IVideoFrame**, int> CreateWithSoftwareBitmap;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, IVideoFrame**, int> CreateWithDirect3D11Surface;
    }
}
