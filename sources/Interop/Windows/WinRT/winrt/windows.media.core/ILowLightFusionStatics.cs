// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILowLightFusionStatics.xml' path='doc/member[@name="ILowLightFusionStatics"]/*' />
[Guid("5305016D-C29E-40E2-87A9-9E1FD2F192F5")]
[NativeTypeName("struct ILowLightFusionStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLightFusionStatics : ILowLightFusionStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILowLightFusionStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, Guid*, void**, int>)(lpVtbl[0]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, uint>)(lpVtbl[1]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, uint>)(lpVtbl[2]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, HSTRING*, int>)(lpVtbl[4]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, TrustLevel*, int>)(lpVtbl[5]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILowLightFusionStatics.xml' path='doc/member[@name="ILowLightFusionStatics.get_SupportedBitmapPixelFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedBitmapPixelFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapPixelFormat_t **")] IVectorView<BitmapPixelFormat>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, IVectorView<BitmapPixelFormat>**, int>)(lpVtbl[6]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLightFusionStatics.xml' path='doc/member[@name="ILowLightFusionStatics.get_MaxSupportedFrameCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxSupportedFrameCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, int*, int>)(lpVtbl[7]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLightFusionStatics.xml' path='doc/member[@name="ILowLightFusionStatics.FuseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FuseAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t *")] IIterable<Pointer<ISoftwareBitmap>>* frameSet, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CCore__CLowLightFusionResult_double_t **")] IAsyncOperationWithProgress<Pointer<ILowLightFusionResult>, double>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLightFusionStatics*, IIterable<Pointer<ISoftwareBitmap>>*, IAsyncOperationWithProgress<Pointer<ILowLightFusionResult>, double>**, int>)(lpVtbl[8]))((ILowLightFusionStatics*)Unsafe.AsPointer(ref this), frameSet, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedBitmapPixelFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapPixelFormat_t **")] IVectorView<BitmapPixelFormat>** value);

        [VtblIndex(7)]
        HRESULT get_MaxSupportedFrameCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT FuseAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t *")] IIterable<Pointer<ISoftwareBitmap>>* frameSet, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CCore__CLowLightFusionResult_double_t **")] IAsyncOperationWithProgress<Pointer<ILowLightFusionResult>, double>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapPixelFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<BitmapPixelFormat>**, int> get_SupportedBitmapPixelFormats;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MaxSupportedFrameCount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CGraphics__CImaging__CSoftwareBitmap_t *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CCore__CLowLightFusionResult_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<ISoftwareBitmap>>*, IAsyncOperationWithProgress<Pointer<ILowLightFusionResult>, double>**, int> FuseAsync;
    }
}
