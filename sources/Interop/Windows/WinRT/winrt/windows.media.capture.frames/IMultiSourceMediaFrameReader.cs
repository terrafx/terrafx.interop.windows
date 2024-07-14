// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMultiSourceMediaFrameReader.xml' path='doc/member[@name="IMultiSourceMediaFrameReader"]/*' />
[Guid("8D144402-F763-488D-98F2-B437BCF075E7")]
[NativeTypeName("struct IMultiSourceMediaFrameReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMultiSourceMediaFrameReader : IMultiSourceMediaFrameReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMultiSourceMediaFrameReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, Guid*, void**, int>)(lpVtbl[0]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, uint>)(lpVtbl[1]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, uint>)(lpVtbl[2]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, uint*, Guid**, int>)(lpVtbl[3]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, HSTRING*, int>)(lpVtbl[4]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, TrustLevel*, int>)(lpVtbl[5]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMultiSourceMediaFrameReader.xml' path='doc/member[@name="IMultiSourceMediaFrameReader.add_FrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_FrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReader_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameArrivedEventArgs_t *")] ITypedEventHandler<Pointer<IMultiSourceMediaFrameReader>, Pointer<IMultiSourceMediaFrameArrivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, ITypedEventHandler<Pointer<IMultiSourceMediaFrameReader>, Pointer<IMultiSourceMediaFrameArrivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMultiSourceMediaFrameReader.xml' path='doc/member[@name="IMultiSourceMediaFrameReader.remove_FrameArrived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_FrameArrived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, EventRegistrationToken, int>)(lpVtbl[7]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMultiSourceMediaFrameReader.xml' path='doc/member[@name="IMultiSourceMediaFrameReader.TryAcquireLatestFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryAcquireLatestFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMultiSourceMediaFrameReference **")] IMultiSourceMediaFrameReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, IMultiSourceMediaFrameReference**, int>)(lpVtbl[8]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMultiSourceMediaFrameReader.xml' path='doc/member[@name="IMultiSourceMediaFrameReader.StartAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReaderStartStatus_t **")] IAsyncOperation<MultiSourceMediaFrameReaderStartStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, IAsyncOperation<MultiSourceMediaFrameReaderStartStatus>**, int>)(lpVtbl[9]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IMultiSourceMediaFrameReader.xml' path='doc/member[@name="IMultiSourceMediaFrameReader.StopAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** action)
    {
        return ((delegate* unmanaged[MemberFunction]<IMultiSourceMediaFrameReader*, IAsyncAction**, int>)(lpVtbl[10]))((IMultiSourceMediaFrameReader*)Unsafe.AsPointer(ref this), action);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_FrameArrived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReader_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameArrivedEventArgs_t *")] ITypedEventHandler<Pointer<IMultiSourceMediaFrameReader>, Pointer<IMultiSourceMediaFrameArrivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_FrameArrived(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT TryAcquireLatestFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMultiSourceMediaFrameReference **")] IMultiSourceMediaFrameReference** value);

        [VtblIndex(9)]
        HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReaderStartStatus_t **")] IAsyncOperation<MultiSourceMediaFrameReaderStartStatus>** operation);

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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReader_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameArrivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMultiSourceMediaFrameReader>, Pointer<IMultiSourceMediaFrameArrivedEventArgs>>*, EventRegistrationToken*, int> add_FrameArrived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FrameArrived;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMultiSourceMediaFrameReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMultiSourceMediaFrameReference**, int> TryAcquireLatestFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReaderStartStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<MultiSourceMediaFrameReaderStartStatus>**, int> StartAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StopAsync;
    }
}
