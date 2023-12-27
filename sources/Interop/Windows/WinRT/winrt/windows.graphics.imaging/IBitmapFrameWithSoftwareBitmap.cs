// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBitmapFrameWithSoftwareBitmap.xml' path='doc/member[@name="IBitmapFrameWithSoftwareBitmap"]/*' />
[Guid("FE287C9A-420C-4963-87AD-691436E08383")]
[NativeTypeName("struct IBitmapFrameWithSoftwareBitmap : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapFrameWithSoftwareBitmap : IBitmapFrameWithSoftwareBitmap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapFrameWithSoftwareBitmap));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, uint>)(lpVtbl[1]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, uint>)(lpVtbl[2]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, uint*, Guid**, int>)(lpVtbl[3]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, HSTRING*, int>)(lpVtbl[4]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, TrustLevel*, int>)(lpVtbl[5]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBitmapFrameWithSoftwareBitmap.xml' path='doc/member[@name="IBitmapFrameWithSoftwareBitmap.GetSoftwareBitmapAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSoftwareBitmapAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int>)(lpVtbl[6]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrameWithSoftwareBitmap.xml' path='doc/member[@name="IBitmapFrameWithSoftwareBitmap.GetSoftwareBitmapConvertedAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSoftwareBitmapConvertedAsync([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alphaMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, BitmapPixelFormat, BitmapAlphaMode, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int>)(lpVtbl[7]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), pixelFormat, alphaMode, value);
    }

    /// <include file='IBitmapFrameWithSoftwareBitmap.xml' path='doc/member[@name="IBitmapFrameWithSoftwareBitmap.GetSoftwareBitmapTransformedAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSoftwareBitmapTransformedAsync([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alphaMode, [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform *")] IBitmapTransform* transform, [NativeTypeName("ABI::Windows::Graphics::Imaging::ExifOrientationMode")] ExifOrientationMode exifOrientationMode, [NativeTypeName("ABI::Windows::Graphics::Imaging::ColorManagementMode")] ColorManagementMode colorManagementMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrameWithSoftwareBitmap*, BitmapPixelFormat, BitmapAlphaMode, IBitmapTransform*, ExifOrientationMode, ColorManagementMode, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int>)(lpVtbl[8]))((IBitmapFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), pixelFormat, alphaMode, transform, exifOrientationMode, colorManagementMode, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetSoftwareBitmapAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value);

        [VtblIndex(7)]
        HRESULT GetSoftwareBitmapConvertedAsync([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alphaMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value);

        [VtblIndex(8)]
        HRESULT GetSoftwareBitmapTransformedAsync([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alphaMode, [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform *")] IBitmapTransform* transform, [NativeTypeName("ABI::Windows::Graphics::Imaging::ExifOrientationMode")] ExifOrientationMode exifOrientationMode, [NativeTypeName("ABI::Windows::Graphics::Imaging::ColorManagementMode")] ColorManagementMode colorManagementMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **")] IAsyncOperation<Pointer<ISoftwareBitmap>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int> GetSoftwareBitmapAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapPixelFormat, BitmapAlphaMode, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int> GetSoftwareBitmapConvertedAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::IBitmapTransform *, ABI::Windows::Graphics::Imaging::ExifOrientationMode, ABI::Windows::Graphics::Imaging::ColorManagementMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapPixelFormat, BitmapAlphaMode, IBitmapTransform*, ExifOrientationMode, ColorManagementMode, IAsyncOperation<Pointer<ISoftwareBitmap>>**, int> GetSoftwareBitmapTransformedAsync;
    }
}
