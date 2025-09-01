// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.faceanalysis.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFaceTrackerStatics.xml' path='doc/member[@name="IFaceTrackerStatics"]/*' />
[Guid("E9629198-1801-3FA5-932E-31D767AF6C4D")]
[NativeTypeName("struct IFaceTrackerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFaceTrackerStatics : IFaceTrackerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFaceTrackerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, uint>)(lpVtbl[1]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, uint>)(lpVtbl[2]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, HSTRING*, int>)(lpVtbl[4]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFaceTrackerStatics.xml' path='doc/member[@name="IFaceTrackerStatics.CreateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CFaceAnalysis__CFaceTracker_t **")] IAsyncOperation<Pointer<IFaceTracker>>** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, IAsyncOperation<Pointer<IFaceTracker>>**, int>)(lpVtbl[6]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IFaceTrackerStatics.xml' path='doc/member[@name="IFaceTrackerStatics.GetSupportedBitmapPixelFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSupportedBitmapPixelFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapPixelFormat_t **")] IVectorView<BitmapPixelFormat>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, IVectorView<BitmapPixelFormat>**, int>)(lpVtbl[7]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IFaceTrackerStatics.xml' path='doc/member[@name="IFaceTrackerStatics.IsBitmapPixelFormatSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsBitmapPixelFormatSupported([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat bitmapPixelFormat, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, BitmapPixelFormat, byte*, int>)(lpVtbl[8]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this), bitmapPixelFormat, result);
    }

    /// <include file='IFaceTrackerStatics.xml' path='doc/member[@name="IFaceTrackerStatics.get_IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTrackerStatics*, byte*, int>)(lpVtbl[9]))((IFaceTrackerStatics*)Unsafe.AsPointer(ref this), returnValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CFaceAnalysis__CFaceTracker_t **")] IAsyncOperation<Pointer<IFaceTracker>>** returnValue);

        [VtblIndex(7)]
        HRESULT GetSupportedBitmapPixelFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapPixelFormat_t **")] IVectorView<BitmapPixelFormat>** result);

        [VtblIndex(8)]
        HRESULT IsBitmapPixelFormatSupported([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat bitmapPixelFormat, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* returnValue);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CFaceAnalysis__CFaceTracker_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IFaceTracker>>**, int> CreateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapPixelFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<BitmapPixelFormat>**, int> GetSupportedBitmapPixelFormats;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapPixelFormat, byte*, int> IsBitmapPixelFormatSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSupported;
    }
}
