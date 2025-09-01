// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILowLagPhotoSequenceCapture.xml' path='doc/member[@name="ILowLagPhotoSequenceCapture"]/*' />
[Guid("7CC346BB-B9A9-4C91-8FFA-287E9C668669")]
[NativeTypeName("struct ILowLagPhotoSequenceCapture : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLagPhotoSequenceCapture : ILowLagPhotoSequenceCapture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ILowLagPhotoSequenceCapture);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, Guid*, void**, int>)(lpVtbl[0]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, uint>)(lpVtbl[1]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, uint>)(lpVtbl[2]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, uint*, Guid**, int>)(lpVtbl[3]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, HSTRING*, int>)(lpVtbl[4]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, TrustLevel*, int>)(lpVtbl[5]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILowLagPhotoSequenceCapture.xml' path='doc/member[@name="ILowLagPhotoSequenceCapture.StartAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, IAsyncAction**, int>)(lpVtbl[6]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='ILowLagPhotoSequenceCapture.xml' path='doc/member[@name="ILowLagPhotoSequenceCapture.StopAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, IAsyncAction**, int>)(lpVtbl[7]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='ILowLagPhotoSequenceCapture.xml' path='doc/member[@name="ILowLagPhotoSequenceCapture.FinishAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FinishAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, IAsyncAction**, int>)(lpVtbl[8]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='ILowLagPhotoSequenceCapture.xml' path='doc/member[@name="ILowLagPhotoSequenceCapture.add_PhotoCaptured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PhotoCaptured([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_Windows__CMedia__CCapture__CPhotoCapturedEventArgs_t *")] ITypedEventHandler<Pointer<ILowLagPhotoSequenceCapture>, Pointer<IPhotoCapturedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, ITypedEventHandler<Pointer<ILowLagPhotoSequenceCapture>, Pointer<IPhotoCapturedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ILowLagPhotoSequenceCapture.xml' path='doc/member[@name="ILowLagPhotoSequenceCapture.remove_PhotoCaptured"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PhotoCaptured(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceCapture*, EventRegistrationToken, int>)(lpVtbl[10]))((ILowLagPhotoSequenceCapture*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT FinishAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(9)]
        HRESULT add_PhotoCaptured([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_Windows__CMedia__CCapture__CPhotoCapturedEventArgs_t *")] ITypedEventHandler<Pointer<ILowLagPhotoSequenceCapture>, Pointer<IPhotoCapturedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_PhotoCaptured(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StartAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StopAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> FinishAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_Windows__CMedia__CCapture__CPhotoCapturedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ILowLagPhotoSequenceCapture>, Pointer<IPhotoCapturedEventArgs>>*, EventRegistrationToken*, int> add_PhotoCaptured;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PhotoCaptured;
    }
}
