// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundDownloaderStaticMethods2.xml' path='doc/member[@name="IBackgroundDownloaderStaticMethods2"]/*' />
[Guid("2FAA1327-1AD4-4CA5-B2CD-08DBF0746AFE")]
[NativeTypeName("struct IBackgroundDownloaderStaticMethods2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundDownloaderStaticMethods2 : IBackgroundDownloaderStaticMethods2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundDownloaderStaticMethods2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods2*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundDownloaderStaticMethods2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods2*, uint>)(lpVtbl[1]))((IBackgroundDownloaderStaticMethods2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods2*, uint>)(lpVtbl[2]))((IBackgroundDownloaderStaticMethods2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods2*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundDownloaderStaticMethods2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods2*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundDownloaderStaticMethods2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods2*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundDownloaderStaticMethods2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundDownloaderStaticMethods2.xml' path='doc/member[@name="IBackgroundDownloaderStaticMethods2.GetCurrentDownloadsForTransferGroupAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentDownloadsForTransferGroupAsync([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *")] IBackgroundTransferGroup* group, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderStaticMethods2*, IBackgroundTransferGroup*, IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>**, int>)(lpVtbl[6]))((IBackgroundDownloaderStaticMethods2*)Unsafe.AsPointer(ref this), group, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentDownloadsForTransferGroupAsync([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *")] IBackgroundTransferGroup* group, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferGroup *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTransferGroup*, IAsyncOperation<Pointer<IVectorView<Pointer<IDownloadOperation>>>>**, int> GetCurrentDownloadsForTransferGroupAsync;
    }
}
