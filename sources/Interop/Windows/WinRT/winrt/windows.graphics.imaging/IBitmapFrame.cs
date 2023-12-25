// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame"]/*' />
[Guid("72A49A1C-8081-438D-91BC-94ECFC8185C6")]
[NativeTypeName("struct IBitmapFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapFrame : IBitmapFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapFrame));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, uint>)(lpVtbl[1]))((IBitmapFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, uint>)(lpVtbl[2]))((IBitmapFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, uint*, Guid**, int>)(lpVtbl[3]))((IBitmapFrame*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, HSTRING*, int>)(lpVtbl[4]))((IBitmapFrame*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, TrustLevel*, int>)(lpVtbl[5]))((IBitmapFrame*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.GetThumbnailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IBitmapFrame*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_BitmapProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BitmapProperties([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **")] IBitmapPropertiesView** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, IBitmapPropertiesView**, int>)(lpVtbl[7]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_BitmapPixelFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BitmapPixelFormat([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")] BitmapPixelFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, BitmapPixelFormat*, int>)(lpVtbl[8]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_BitmapAlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BitmapAlphaMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")] BitmapAlphaMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, BitmapAlphaMode*, int>)(lpVtbl[9]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_DpiX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DpiX(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, double*, int>)(lpVtbl[10]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_DpiY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DpiY(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, double*, int>)(lpVtbl[11]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_PixelWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PixelWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, uint*, int>)(lpVtbl[12]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_PixelHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PixelHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, uint*, int>)(lpVtbl[13]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_OrientedPixelWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_OrientedPixelWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, uint*, int>)(lpVtbl[14]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.get_OrientedPixelHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_OrientedPixelHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, uint*, int>)(lpVtbl[15]))((IBitmapFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.GetPixelDataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPixelDataAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[16]))((IBitmapFrame*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IBitmapFrame.xml' path='doc/member[@name="IBitmapFrame.GetPixelDataTransformedAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPixelDataTransformedAsync([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alphaMode, [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform *")] IBitmapTransform* transform, [NativeTypeName("ABI::Windows::Graphics::Imaging::ExifOrientationMode")] ExifOrientationMode exifOrientationMode, [NativeTypeName("ABI::Windows::Graphics::Imaging::ColorManagementMode")] ColorManagementMode colorManagementMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapFrame*, BitmapPixelFormat, BitmapAlphaMode, IBitmapTransform*, ExifOrientationMode, ColorManagementMode, IAsyncOperation<IntPtr>**, int>)(lpVtbl[17]))((IBitmapFrame*)Unsafe.AsPointer(ref this), pixelFormat, alphaMode, transform, exifOrientationMode, colorManagementMode, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **")] IAsyncOperation<IntPtr>** asyncInfo);

        [VtblIndex(7)]
        HRESULT get_BitmapProperties([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **")] IBitmapPropertiesView** value);

        [VtblIndex(8)]
        HRESULT get_BitmapPixelFormat([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")] BitmapPixelFormat* value);

        [VtblIndex(9)]
        HRESULT get_BitmapAlphaMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")] BitmapAlphaMode* value);

        [VtblIndex(10)]
        HRESULT get_DpiX(double* value);

        [VtblIndex(11)]
        HRESULT get_DpiY(double* value);

        [VtblIndex(12)]
        HRESULT get_PixelWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_PixelHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT get_OrientedPixelWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(15)]
        HRESULT get_OrientedPixelHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT GetPixelDataAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **")] IAsyncOperation<IntPtr>** asyncInfo);

        [VtblIndex(17)]
        HRESULT GetPixelDataTransformedAsync([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alphaMode, [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform *")] IBitmapTransform* transform, [NativeTypeName("ABI::Windows::Graphics::Imaging::ExifOrientationMode")] ExifOrientationMode exifOrientationMode, [NativeTypeName("ABI::Windows::Graphics::Imaging::ColorManagementMode")] ColorManagementMode colorManagementMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **")] IAsyncOperation<IntPtr>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetThumbnailAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBitmapPropertiesView**, int> get_BitmapProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapPixelFormat*, int> get_BitmapPixelFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapAlphaMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapAlphaMode*, int> get_BitmapAlphaMode;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_DpiX;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_DpiY;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PixelWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PixelHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_OrientedPixelWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_OrientedPixelHeight;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetPixelDataAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::IBitmapTransform *, ABI::Windows::Graphics::Imaging::ExifOrientationMode, ABI::Windows::Graphics::Imaging::ColorManagementMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CPixelDataProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapPixelFormat, BitmapAlphaMode, IBitmapTransform*, ExifOrientationMode, ColorManagementMode, IAsyncOperation<IntPtr>**, int> GetPixelDataTransformedAsync;
    }
}
