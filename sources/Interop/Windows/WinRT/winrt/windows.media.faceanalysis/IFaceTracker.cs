// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.faceanalysis.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFaceTracker.xml' path='doc/member[@name="IFaceTracker"]/*' />
[Guid("6BA67D8C-A841-4420-93E6-2420A1884FCF")]
[NativeTypeName("struct IFaceTracker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFaceTracker : IFaceTracker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFaceTracker);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, Guid*, void**, int>)(lpVtbl[0]))((IFaceTracker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, uint>)(lpVtbl[1]))((IFaceTracker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, uint>)(lpVtbl[2]))((IFaceTracker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, uint*, Guid**, int>)(lpVtbl[3]))((IFaceTracker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, HSTRING*, int>)(lpVtbl[4]))((IFaceTracker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, TrustLevel*, int>)(lpVtbl[5]))((IFaceTracker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFaceTracker.xml' path='doc/member[@name="IFaceTracker.ProcessNextFrameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProcessNextFrameAsync([NativeTypeName("ABI::Windows::Media::IVideoFrame *")] IVideoFrame* videoFrame, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **")] IAsyncOperation<Pointer<IVector<Pointer<IDetectedFace>>>>** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, IVideoFrame*, IAsyncOperation<Pointer<IVector<Pointer<IDetectedFace>>>>**, int>)(lpVtbl[6]))((IFaceTracker*)Unsafe.AsPointer(ref this), videoFrame, returnValue);
    }

    /// <include file='IFaceTracker.xml' path='doc/member[@name="IFaceTracker.get_MinDetectableFaceSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MinDetectableFaceSize([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize *")] BitmapSize* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, BitmapSize*, int>)(lpVtbl[7]))((IFaceTracker*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IFaceTracker.xml' path='doc/member[@name="IFaceTracker.put_MinDetectableFaceSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_MinDetectableFaceSize([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, BitmapSize, int>)(lpVtbl[8]))((IFaceTracker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFaceTracker.xml' path='doc/member[@name="IFaceTracker.get_MaxDetectableFaceSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxDetectableFaceSize([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize *")] BitmapSize* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, BitmapSize*, int>)(lpVtbl[9]))((IFaceTracker*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IFaceTracker.xml' path='doc/member[@name="IFaceTracker.put_MaxDetectableFaceSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_MaxDetectableFaceSize([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFaceTracker*, BitmapSize, int>)(lpVtbl[10]))((IFaceTracker*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ProcessNextFrameAsync([NativeTypeName("ABI::Windows::Media::IVideoFrame *")] IVideoFrame* videoFrame, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **")] IAsyncOperation<Pointer<IVector<Pointer<IDetectedFace>>>>** returnValue);

        [VtblIndex(7)]
        HRESULT get_MinDetectableFaceSize([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize *")] BitmapSize* returnValue);

        [VtblIndex(8)]
        HRESULT put_MinDetectableFaceSize([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize value);

        [VtblIndex(9)]
        HRESULT get_MaxDetectableFaceSize([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize *")] BitmapSize* returnValue);

        [VtblIndex(10)]
        HRESULT put_MaxDetectableFaceSize([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoFrame *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoFrame*, IAsyncOperation<Pointer<IVector<Pointer<IDetectedFace>>>>**, int> ProcessNextFrameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapSize *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapSize*, int> get_MinDetectableFaceSize;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapSize) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapSize, int> put_MinDetectableFaceSize;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapSize *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapSize*, int> get_MaxDetectableFaceSize;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapSize) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapSize, int> put_MaxDetectableFaceSize;
    }
}
