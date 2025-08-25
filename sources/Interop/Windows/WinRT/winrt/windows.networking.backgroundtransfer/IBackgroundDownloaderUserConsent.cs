// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundDownloaderUserConsent.xml' path='doc/member[@name="IBackgroundDownloaderUserConsent"]/*' />
[Guid("5D14E906-9266-4808-BD71-5925F2A3130A")]
[NativeTypeName("struct IBackgroundDownloaderUserConsent : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IBackgroundDownloaderUserConsent is deprecated and may not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IBackgroundDownloaderUserConsent : IBackgroundDownloaderUserConsent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundDownloaderUserConsent);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderUserConsent*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundDownloaderUserConsent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderUserConsent*, uint>)(lpVtbl[1]))((IBackgroundDownloaderUserConsent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderUserConsent*, uint>)(lpVtbl[2]))((IBackgroundDownloaderUserConsent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderUserConsent*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundDownloaderUserConsent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderUserConsent*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundDownloaderUserConsent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderUserConsent*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundDownloaderUserConsent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundDownloaderUserConsent.xml' path='doc/member[@name="IBackgroundDownloaderUserConsent.RequestUnconstrainedDownloadsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.")]
    public HRESULT RequestUnconstrainedDownloadsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t *")] IIterable<Pointer<IDownloadOperation>>* operations, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **")] IAsyncOperation<Pointer<IUnconstrainedTransferRequestResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderUserConsent*, IIterable<Pointer<IDownloadOperation>>*, IAsyncOperation<Pointer<IUnconstrainedTransferRequestResult>>**, int>)(lpVtbl[6]))((IBackgroundDownloaderUserConsent*)Unsafe.AsPointer(ref this), operations, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.")]
        HRESULT RequestUnconstrainedDownloadsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t *")] IIterable<Pointer<IDownloadOperation>>* operations, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **")] IAsyncOperation<Pointer<IUnconstrainedTransferRequestResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **) __attribute__((stdcall))")]
        [Obsolete("RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IDownloadOperation>>*, IAsyncOperation<Pointer<IUnconstrainedTransferRequestResult>>**, int> RequestUnconstrainedDownloadsAsync;
    }
}
