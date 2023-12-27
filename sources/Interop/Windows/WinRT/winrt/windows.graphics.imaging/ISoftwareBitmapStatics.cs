// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISoftwareBitmapStatics.xml' path='doc/member[@name="ISoftwareBitmapStatics"]/*' />
[Guid("DF0385DB-672F-4A9D-806E-C2442F343E86")]
[NativeTypeName("struct ISoftwareBitmapStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISoftwareBitmapStatics : ISoftwareBitmapStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftwareBitmapStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, uint>)(lpVtbl[1]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, uint>)(lpVtbl[2]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, HSTRING*, int>)(lpVtbl[4]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISoftwareBitmapStatics.xml' path='doc/member[@name="ISoftwareBitmapStatics.Copy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Copy([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, ISoftwareBitmap*, ISoftwareBitmap**, int>)(lpVtbl[6]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), source, value);
    }

    /// <include file='ISoftwareBitmapStatics.xml' path='doc/member[@name="ISoftwareBitmapStatics.Convert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Convert([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat format, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, ISoftwareBitmap*, BitmapPixelFormat, ISoftwareBitmap**, int>)(lpVtbl[7]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), source, format, value);
    }

    /// <include file='ISoftwareBitmapStatics.xml' path='doc/member[@name="ISoftwareBitmapStatics.ConvertWithAlpha"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConvertWithAlpha([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat format, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, ISoftwareBitmap*, BitmapPixelFormat, BitmapAlphaMode, ISoftwareBitmap**, int>)(lpVtbl[8]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), source, format, alpha, value);
    }

    /// <include file='ISoftwareBitmapStatics.xml' path='doc/member[@name="ISoftwareBitmapStatics.CreateCopyFromBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateCopyFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat format, [NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, IBuffer*, BitmapPixelFormat, int, int, ISoftwareBitmap**, int>)(lpVtbl[9]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), source, format, width, height, value);
    }

    /// <include file='ISoftwareBitmapStatics.xml' path='doc/member[@name="ISoftwareBitmapStatics.CreateCopyWithAlphaFromBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateCopyWithAlphaFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat format, [NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, IBuffer*, BitmapPixelFormat, int, int, BitmapAlphaMode, ISoftwareBitmap**, int>)(lpVtbl[10]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), source, format, width, height, alpha, value);
    }

    /// <include file='ISoftwareBitmapStatics.xml' path='doc/member[@name="ISoftwareBitmapStatics.CreateCopyFromSurfaceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateCopyFromSurfaceAsync([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* surface, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, IDirect3DSurface*, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int>)(lpVtbl[11]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), surface, value);
    }

    /// <include file='ISoftwareBitmapStatics.xml' path='doc/member[@name="ISoftwareBitmapStatics.CreateCopyWithAlphaFromSurfaceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCopyWithAlphaFromSurfaceAsync([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* surface, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISoftwareBitmapStatics*, IDirect3DSurface*, BitmapAlphaMode, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int>)(lpVtbl[12]))((ISoftwareBitmapStatics*)Unsafe.AsPointer(ref this), surface, alpha, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Copy([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);

        [VtblIndex(7)]
        HRESULT Convert([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat format, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);

        [VtblIndex(8)]
        HRESULT ConvertWithAlpha([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat format, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);

        [VtblIndex(9)]
        HRESULT CreateCopyFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat format, [NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);

        [VtblIndex(10)]
        HRESULT CreateCopyWithAlphaFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* source, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat format, [NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha, [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);

        [VtblIndex(11)]
        HRESULT CreateCopyFromSurfaceAsync([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* surface, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value);

        [VtblIndex(12)]
        HRESULT CreateCopyWithAlphaFromSurfaceAsync([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* surface, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap*, ISoftwareBitmap**, int> Copy;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap*, BitmapPixelFormat, ISoftwareBitmap**, int> Convert;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap*, BitmapPixelFormat, BitmapAlphaMode, ISoftwareBitmap**, int> ConvertWithAlpha;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Graphics::Imaging::BitmapPixelFormat, INT32, INT32, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, BitmapPixelFormat, int, int, ISoftwareBitmap**, int> CreateCopyFromBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Graphics::Imaging::BitmapPixelFormat, INT32, INT32, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, BitmapPixelFormat, int, int, BitmapAlphaMode, ISoftwareBitmap**, int> CreateCopyWithAlphaFromBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int> CreateCopyFromSurfaceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, BitmapAlphaMode, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int> CreateCopyWithAlphaFromSurfaceAsync;
    }
}
