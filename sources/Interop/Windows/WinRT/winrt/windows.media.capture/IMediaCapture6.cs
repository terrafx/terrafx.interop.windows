// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCapture6.xml' path='doc/member[@name="IMediaCapture6"]/*' />
[Guid("228948BD-4B20-4BB1-9FD6-A583212A1012")]
[NativeTypeName("struct IMediaCapture6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCapture6 : IMediaCapture6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCapture6));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCapture6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, uint>)(lpVtbl[1]))((IMediaCapture6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, uint>)(lpVtbl[2]))((IMediaCapture6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCapture6*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, HSTRING*, int>)(lpVtbl[4]))((IMediaCapture6*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCapture6*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCapture6.xml' path='doc/member[@name="IMediaCapture6.add_CaptureDeviceExclusiveControlStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_CaptureDeviceExclusiveControlStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CMediaCaptureDeviceExclusiveControlStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaCapture6*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaCapture6.xml' path='doc/member[@name="IMediaCapture6.remove_CaptureDeviceExclusiveControlStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_CaptureDeviceExclusiveControlStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaCapture6*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaCapture6.xml' path='doc/member[@name="IMediaCapture6.CreateMultiSourceFrameReaderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateMultiSourceFrameReaderAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t *")] IIterable<Pointer<IMediaFrameSource>>* inputSources, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReader_t **")] IAsyncOperation<Pointer<IMultiSourceMediaFrameReader>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture6*, IIterable<Pointer<IMediaFrameSource>>*, IAsyncOperation<Pointer<IMultiSourceMediaFrameReader>>**, int>)(lpVtbl[8]))((IMediaCapture6*)Unsafe.AsPointer(ref this), inputSources, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_CaptureDeviceExclusiveControlStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CMediaCaptureDeviceExclusiveControlStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_CaptureDeviceExclusiveControlStatusChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT CreateMultiSourceFrameReaderAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t *")] IIterable<Pointer<IMediaFrameSource>>* inputSources, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReader_t **")] IAsyncOperation<Pointer<IMultiSourceMediaFrameReader>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CMediaCaptureDeviceExclusiveControlStatusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs>>*, EventRegistrationToken*, int> add_CaptureDeviceExclusiveControlStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CaptureDeviceExclusiveControlStatusChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMultiSourceMediaFrameReader_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IMediaFrameSource>>*, IAsyncOperation<Pointer<IMultiSourceMediaFrameReader>>**, int> CreateMultiSourceFrameReaderAsync;
    }
}
