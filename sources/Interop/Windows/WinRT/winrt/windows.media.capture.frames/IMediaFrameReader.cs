// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameReader.xml' path='doc/member[@name="IMediaFrameReader"]/*' />
[Guid("E4C94395-2028-48ED-90B0-D1C1B162E24C")]
[NativeTypeName("struct IMediaFrameReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameReader : IMediaFrameReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, uint>)(lpVtbl[1]))((IMediaFrameReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, uint>)(lpVtbl[2]))((IMediaFrameReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameReader.xml' path='doc/member[@name="IMediaFrameReader.add_FrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_FrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_Windows__CMedia__CCapture__CFrames__CMediaFrameArrivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaFrameReader>, Pointer<IMediaFrameArrivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, ITypedEventHandler<Pointer<IMediaFrameReader>, Pointer<IMediaFrameArrivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaFrameReader.xml' path='doc/member[@name="IMediaFrameReader.remove_FrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_FrameArrived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaFrameReader.xml' path='doc/member[@name="IMediaFrameReader.TryAcquireLatestFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryAcquireLatestFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")] IMediaFrameReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, IMediaFrameReference**, int>)(lpVtbl[8]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameReader.xml' path='doc/member[@name="IMediaFrameReader.StartAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReaderStartStatus_t **")] IAsyncOperation<MediaFrameReaderStartStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, IAsyncOperation<MediaFrameReaderStartStatus>**, int>)(lpVtbl[9]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IMediaFrameReader.xml' path='doc/member[@name="IMediaFrameReader.StopAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReader*, IAsyncAction**, int>)(lpVtbl[10]))((IMediaFrameReader*)Unsafe.AsPointer(ref this), action);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_FrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_Windows__CMedia__CCapture__CFrames__CMediaFrameArrivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaFrameReader>, Pointer<IMediaFrameArrivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_FrameArrived(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT TryAcquireLatestFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")] IMediaFrameReference** value);

        [VtblIndex(9)]
        HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReaderStartStatus_t **")] IAsyncOperation<MediaFrameReaderStartStatus>** operation);

        [VtblIndex(10)]
        HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_Windows__CMedia__CCapture__CFrames__CMediaFrameArrivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaFrameReader>, Pointer<IMediaFrameArrivedEventArgs>>*, EventRegistrationToken*, int> add_FrameArrived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FrameArrived;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameReference**, int> TryAcquireLatestFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReaderStartStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<MediaFrameReaderStartStatus>**, int> StartAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StopAsync;
    }
}
