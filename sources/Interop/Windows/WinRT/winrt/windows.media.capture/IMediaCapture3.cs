// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCapture3.xml' path='doc/member[@name="IMediaCapture3"]/*' />
[Guid("D4136F30-1564-466E-BC0A-AF94E02AB016")]
[NativeTypeName("struct IMediaCapture3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCapture3 : IMediaCapture3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCapture3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCapture3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, uint>)(lpVtbl[1]))((IMediaCapture3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, uint>)(lpVtbl[2]))((IMediaCapture3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCapture3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, HSTRING*, int>)(lpVtbl[4]))((IMediaCapture3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCapture3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCapture3.xml' path='doc/member[@name="IMediaCapture3.PrepareVariablePhotoSequenceCaptureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PrepareVariablePhotoSequenceCaptureAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")] IImageEncodingProperties* type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CCore__CVariablePhotoSequenceCapture_t **")] IAsyncOperation<Pointer<IVariablePhotoSequenceCapture>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, IImageEncodingProperties*, IAsyncOperation<Pointer<IVariablePhotoSequenceCapture>>**, int>)(lpVtbl[6]))((IMediaCapture3*)Unsafe.AsPointer(ref this), type, operation);
    }

    /// <include file='IMediaCapture3.xml' path='doc/member[@name="IMediaCapture3.add_FocusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_FocusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CMediaCaptureFocusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IMediaCaptureFocusChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IMediaCaptureFocusChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IMediaCapture3*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaCapture3.xml' path='doc/member[@name="IMediaCapture3.remove_FocusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_FocusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, EventRegistrationToken, int>)(lpVtbl[8]))((IMediaCapture3*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaCapture3.xml' path='doc/member[@name="IMediaCapture3.add_PhotoConfirmationCaptured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PhotoConfirmationCaptured([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CPhotoConfirmationCapturedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IPhotoConfirmationCapturedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IPhotoConfirmationCapturedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IMediaCapture3*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaCapture3.xml' path='doc/member[@name="IMediaCapture3.remove_PhotoConfirmationCaptured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PhotoConfirmationCaptured(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture3*, EventRegistrationToken, int>)(lpVtbl[10]))((IMediaCapture3*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT PrepareVariablePhotoSequenceCaptureAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")] IImageEncodingProperties* type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CCore__CVariablePhotoSequenceCapture_t **")] IAsyncOperation<Pointer<IVariablePhotoSequenceCapture>>** operation);

        [VtblIndex(7)]
        HRESULT add_FocusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CMediaCaptureFocusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IMediaCaptureFocusChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_FocusChanged(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_PhotoConfirmationCaptured([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CPhotoConfirmationCapturedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IPhotoConfirmationCapturedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_PhotoConfirmationCaptured(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CCore__CVariablePhotoSequenceCapture_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImageEncodingProperties*, IAsyncOperation<Pointer<IVariablePhotoSequenceCapture>>**, int> PrepareVariablePhotoSequenceCaptureAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CMediaCaptureFocusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IMediaCaptureFocusChangedEventArgs>>*, EventRegistrationToken*, int> add_FocusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FocusChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCapture_Windows__CMedia__CCapture__CPhotoConfirmationCapturedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaCapture>, Pointer<IPhotoConfirmationCapturedEventArgs>>*, EventRegistrationToken*, int> add_PhotoConfirmationCaptured;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PhotoConfirmationCaptured;
    }
}
