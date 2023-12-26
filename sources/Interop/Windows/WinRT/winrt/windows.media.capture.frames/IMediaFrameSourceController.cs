// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameSourceController.xml' path='doc/member[@name="IMediaFrameSourceController"]/*' />
[Guid("6D076635-316D-4B8F-B7B6-EEB04A8C6525")]
[NativeTypeName("struct IMediaFrameSourceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSourceController : IMediaFrameSourceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSourceController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, uint>)(lpVtbl[1]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, uint>)(lpVtbl[2]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameSourceController.xml' path='doc/member[@name="IMediaFrameSourceController.GetPropertyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropertyAsync(HSTRING propertyId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this), propertyId, value);
    }

    /// <include file='IMediaFrameSourceController.xml' path='doc/member[@name="IMediaFrameSourceController.SetPropertyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPropertyAsync(HSTRING propertyId, IInspectable* propertyValue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **")] IAsyncOperation<MediaFrameSourceSetPropertyStatus>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, HSTRING, IInspectable*, IAsyncOperation<MediaFrameSourceSetPropertyStatus>**, int>)(lpVtbl[7]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this), propertyId, propertyValue, value);
    }

    /// <include file='IMediaFrameSourceController.xml' path='doc/member[@name="IMediaFrameSourceController.get_VideoDeviceController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideoDeviceController([NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceController **")] IVideoDeviceController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController*, IVideoDeviceController**, int>)(lpVtbl[8]))((IMediaFrameSourceController*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPropertyAsync(HSTRING propertyId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **")] IAsyncOperation<IntPtr>** value);

        [VtblIndex(7)]
        HRESULT SetPropertyAsync(HSTRING propertyId, IInspectable* propertyValue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **")] IAsyncOperation<MediaFrameSourceSetPropertyStatus>** value);

        [VtblIndex(8)]
        HRESULT get_VideoDeviceController([NativeTypeName("ABI::Windows::Media::Devices::IVideoDeviceController **")] IVideoDeviceController** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetPropertyAsync;

        [NativeTypeName("HRESULT (HSTRING, IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IInspectable*, IAsyncOperation<MediaFrameSourceSetPropertyStatus>**, int> SetPropertyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IVideoDeviceController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoDeviceController**, int> get_VideoDeviceController;
    }
}
