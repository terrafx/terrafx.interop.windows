// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundDownloaderStaticMethods.xml' path='doc/member[@name="IBackgroundDownloaderStaticMethods"]/*' />
[Guid("52A65A35-C64E-426C-9919-540D0D21A650")]
[NativeTypeName("struct IBackgroundDownloaderStaticMethods : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundDownloaderStaticMethods : IBackgroundDownloaderStaticMethods.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundDownloaderStaticMethods));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundDownloaderStaticMethods*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods*, uint>)(lpVtbl[1]))((IBackgroundDownloaderStaticMethods*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods*, uint>)(lpVtbl[2]))((IBackgroundDownloaderStaticMethods*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundDownloaderStaticMethods*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundDownloaderStaticMethods*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundDownloaderStaticMethods*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundDownloaderStaticMethods.xml' path='doc/member[@name="IBackgroundDownloaderStaticMethods.GetCurrentDownloadsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentDownloadsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods*, IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>**, int>)(lpVtbl[6]))((IBackgroundDownloaderStaticMethods*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IBackgroundDownloaderStaticMethods.xml' path='doc/member[@name="IBackgroundDownloaderStaticMethods.GetCurrentDownloadsForGroupAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("GetCurrentDownloadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentDownloadsForTransferGroupAsync.")]
    public HRESULT GetCurrentDownloadsForGroupAsync(HSTRING group, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>**, int>)(lpVtbl[7]))((IBackgroundDownloaderStaticMethods*)Unsafe.AsPointer(ref this), group, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentDownloadsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>** operation);

        [VtblIndex(7)]
        [Obsolete("GetCurrentDownloadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentDownloadsForTransferGroupAsync.")]
        HRESULT GetCurrentDownloadsForGroupAsync(HSTRING group, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>**, int> GetCurrentDownloadsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **) __attribute__((stdcall))")]
        [Obsolete("GetCurrentDownloadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentDownloadsForTransferGroupAsync.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>**, int> GetCurrentDownloadsForGroupAsync;
    }
}
