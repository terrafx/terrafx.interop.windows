// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundUploaderUserConsent.xml' path='doc/member[@name="IBackgroundUploaderUserConsent"]/*' />
[Guid("3BB384CB-0760-461D-907F-5138F84D44C1")]
[NativeTypeName("struct IBackgroundUploaderUserConsent : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IBackgroundUploaderUserConsent is deprecated and may not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IBackgroundUploaderUserConsent : IBackgroundUploaderUserConsent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundUploaderUserConsent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderUserConsent*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundUploaderUserConsent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderUserConsent*, uint>)(lpVtbl[1]))((IBackgroundUploaderUserConsent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderUserConsent*, uint>)(lpVtbl[2]))((IBackgroundUploaderUserConsent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderUserConsent*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundUploaderUserConsent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderUserConsent*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundUploaderUserConsent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderUserConsent*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundUploaderUserConsent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundUploaderUserConsent.xml' path='doc/member[@name="IBackgroundUploaderUserConsent.RequestUnconstrainedUploadsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.")]
    public HRESULT RequestUnconstrainedUploadsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t *")] IIterable<Pointer<IUploadOperation>>* operations, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **")] IAsyncOperation<Pointer<IUnconstrainedTransferRequestResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderUserConsent*, IIterable<Pointer<IUploadOperation>>*, IAsyncOperation<Pointer<IUnconstrainedTransferRequestResult>>**, int>)(lpVtbl[6]))((IBackgroundUploaderUserConsent*)Unsafe.AsPointer(ref this), operations, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.")]
        HRESULT RequestUnconstrainedUploadsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t *")] IIterable<Pointer<IUploadOperation>>* operations, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **")] IAsyncOperation<Pointer<IUnconstrainedTransferRequestResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **) __attribute__((stdcall))")]
        [Obsolete("RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IUploadOperation>>*, IAsyncOperation<Pointer<IUnconstrainedTransferRequestResult>>**, int> RequestUnconstrainedUploadsAsync;
    }
}
