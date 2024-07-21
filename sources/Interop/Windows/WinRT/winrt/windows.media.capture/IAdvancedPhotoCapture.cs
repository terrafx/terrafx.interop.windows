// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedPhotoCapture.xml' path='doc/member[@name="IAdvancedPhotoCapture"]/*' />
[Guid("83FFAAFA-6667-44DC-973C-A6BCE596AA0F")]
[NativeTypeName("struct IAdvancedPhotoCapture : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedPhotoCapture : IAdvancedPhotoCapture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedPhotoCapture));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, uint>)(lpVtbl[1]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, uint>)(lpVtbl[2]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedPhotoCapture.xml' path='doc/member[@name="IAdvancedPhotoCapture.CaptureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CaptureAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedCapturedPhoto_t **")] IAsyncOperation<Pointer<IAdvancedCapturedPhoto>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, IAsyncOperation<Pointer<IAdvancedCapturedPhoto>>**, int>)(lpVtbl[6]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAdvancedPhotoCapture.xml' path='doc/member[@name="IAdvancedPhotoCapture.CaptureWithContextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CaptureWithContextAsync(IInspectable* context, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedCapturedPhoto_t **")] IAsyncOperation<Pointer<IAdvancedCapturedPhoto>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, IInspectable*, IAsyncOperation<Pointer<IAdvancedCapturedPhoto>>**, int>)(lpVtbl[7]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), context, operation);
    }

    /// <include file='IAdvancedPhotoCapture.xml' path='doc/member[@name="IAdvancedPhotoCapture.add_OptionalReferencePhotoCaptured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_OptionalReferencePhotoCaptured([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAdvancedPhotoCapture_Windows__CMedia__CCapture__COptionalReferencePhotoCapturedEventArgs_t *")] ITypedEventHandler<Pointer<IAdvancedPhotoCapture>, Pointer<IOptionalReferencePhotoCapturedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, ITypedEventHandler<Pointer<IAdvancedPhotoCapture>, Pointer<IOptionalReferencePhotoCapturedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAdvancedPhotoCapture.xml' path='doc/member[@name="IAdvancedPhotoCapture.remove_OptionalReferencePhotoCaptured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_OptionalReferencePhotoCaptured(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, EventRegistrationToken, int>)(lpVtbl[9]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAdvancedPhotoCapture.xml' path='doc/member[@name="IAdvancedPhotoCapture.add_AllPhotosCaptured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_AllPhotosCaptured([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAdvancedPhotoCapture_IInspectable_t *")] ITypedEventHandler<Pointer<IAdvancedPhotoCapture>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, ITypedEventHandler<Pointer<IAdvancedPhotoCapture>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAdvancedPhotoCapture.xml' path='doc/member[@name="IAdvancedPhotoCapture.remove_AllPhotosCaptured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_AllPhotosCaptured(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, EventRegistrationToken, int>)(lpVtbl[11]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAdvancedPhotoCapture.xml' path='doc/member[@name="IAdvancedPhotoCapture.FinishAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FinishAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedPhotoCapture*, IAsyncAction**, int>)(lpVtbl[12]))((IAdvancedPhotoCapture*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CaptureAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedCapturedPhoto_t **")] IAsyncOperation<Pointer<IAdvancedCapturedPhoto>>** operation);

        [VtblIndex(7)]
        HRESULT CaptureWithContextAsync(IInspectable* context, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedCapturedPhoto_t **")] IAsyncOperation<Pointer<IAdvancedCapturedPhoto>>** operation);

        [VtblIndex(8)]
        HRESULT add_OptionalReferencePhotoCaptured([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAdvancedPhotoCapture_Windows__CMedia__CCapture__COptionalReferencePhotoCapturedEventArgs_t *")] ITypedEventHandler<Pointer<IAdvancedPhotoCapture>, Pointer<IOptionalReferencePhotoCapturedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_OptionalReferencePhotoCaptured(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_AllPhotosCaptured([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAdvancedPhotoCapture_IInspectable_t *")] ITypedEventHandler<Pointer<IAdvancedPhotoCapture>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_AllPhotosCaptured(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT FinishAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedCapturedPhoto_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IAdvancedCapturedPhoto>>**, int> CaptureAsync;

        [NativeTypeName("HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CAdvancedCapturedPhoto_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, IAsyncOperation<Pointer<IAdvancedCapturedPhoto>>**, int> CaptureWithContextAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAdvancedPhotoCapture_Windows__CMedia__CCapture__COptionalReferencePhotoCapturedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAdvancedPhotoCapture>, Pointer<IOptionalReferencePhotoCapturedEventArgs>>*, EventRegistrationToken*, int> add_OptionalReferencePhotoCaptured;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OptionalReferencePhotoCaptured;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAdvancedPhotoCapture_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAdvancedPhotoCapture>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_AllPhotosCaptured;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AllPhotosCaptured;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> FinishAsync;
    }
}
