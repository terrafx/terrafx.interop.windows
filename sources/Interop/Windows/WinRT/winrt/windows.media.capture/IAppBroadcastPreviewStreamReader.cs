// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader"]/*' />
[Guid("92228D50-DB3F-40A8-8CD4-F4E371DDAB37")]
[NativeTypeName("struct IAppBroadcastPreviewStreamReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastPreviewStreamReader : IAppBroadcastPreviewStreamReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastPreviewStreamReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, uint>)(lpVtbl[1]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, uint>)(lpVtbl[2]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader.get_VideoWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, uint*, int>)(lpVtbl[6]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader.get_VideoHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, uint*, int>)(lpVtbl[7]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader.get_VideoStride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideoStride([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, uint*, int>)(lpVtbl[8]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader.get_VideoBitmapPixelFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VideoBitmapPixelFormat([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")] BitmapPixelFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, BitmapPixelFormat*, int>)(lpVtbl[9]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader.get_VideoBitmapAlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoBitmapAlphaMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")] BitmapAlphaMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, BitmapAlphaMode*, int>)(lpVtbl[10]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader.TryGetNextVideoFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TryGetNextVideoFrame([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamVideoFrame **")] IAppBroadcastPreviewStreamVideoFrame** frame)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, IAppBroadcastPreviewStreamVideoFrame**, int>)(lpVtbl[11]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), frame);
    }

    /// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader.add_VideoFrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_VideoFrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreviewStreamReader_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastPreviewStreamReader>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, ITypedEventHandler<Pointer<IAppBroadcastPreviewStreamReader>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppBroadcastPreviewStreamReader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamReader.remove_VideoFrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_VideoFrameArrived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamReader*, EventRegistrationToken, int>)(lpVtbl[13]))((IAppBroadcastPreviewStreamReader*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_VideoHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_VideoStride([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_VideoBitmapPixelFormat([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")] BitmapPixelFormat* value);

        [VtblIndex(10)]
        HRESULT get_VideoBitmapAlphaMode([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")] BitmapAlphaMode* value);

        [VtblIndex(11)]
        HRESULT TryGetNextVideoFrame([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamVideoFrame **")] IAppBroadcastPreviewStreamVideoFrame** frame);

        [VtblIndex(12)]
        HRESULT add_VideoFrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreviewStreamReader_IInspectable_t *")] ITypedEventHandler<Pointer<IAppBroadcastPreviewStreamReader>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_VideoFrameArrived(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_VideoWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_VideoHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_VideoStride;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapPixelFormat*, int> get_VideoBitmapPixelFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapAlphaMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapAlphaMode*, int> get_VideoBitmapAlphaMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastPreviewStreamVideoFrame**, int> TryGetNextVideoFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreviewStreamReader_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppBroadcastPreviewStreamReader>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_VideoFrameArrived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VideoFrameArrived;
    }
}
