// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDownloadOperation.xml' path='doc/member[@name="IDownloadOperation"]/*' />
[Guid("BD87EBB0-5714-4E09-BA68-BEF73903B0D7")]
[NativeTypeName("struct IDownloadOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDownloadOperation : IDownloadOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDownloadOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, Guid*, void**, int>)(lpVtbl[0]))((IDownloadOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, uint>)(lpVtbl[1]))((IDownloadOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, uint>)(lpVtbl[2]))((IDownloadOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IDownloadOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, HSTRING*, int>)(lpVtbl[4]))((IDownloadOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, TrustLevel*, int>)(lpVtbl[5]))((IDownloadOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDownloadOperation.xml' path='doc/member[@name="IDownloadOperation.get_ResultFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResultFile([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, IStorageFile**, int>)(lpVtbl[6]))((IDownloadOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDownloadOperation.xml' path='doc/member[@name="IDownloadOperation.get_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Progress([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundDownloadProgress *")] BackgroundDownloadProgress* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, BackgroundDownloadProgress*, int>)(lpVtbl[7]))((IDownloadOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDownloadOperation.xml' path='doc/member[@name="IDownloadOperation.StartAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperationWithProgress<IntPtr, IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, IAsyncOperationWithProgress<IntPtr, IntPtr>**, int>)(lpVtbl[8]))((IDownloadOperation*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDownloadOperation.xml' path='doc/member[@name="IDownloadOperation.AttachAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AttachAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperationWithProgress<IntPtr, IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, IAsyncOperationWithProgress<IntPtr, IntPtr>**, int>)(lpVtbl[9]))((IDownloadOperation*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDownloadOperation.xml' path='doc/member[@name="IDownloadOperation.Pause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, int>)(lpVtbl[10]))((IDownloadOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDownloadOperation.xml' path='doc/member[@name="IDownloadOperation.Resume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadOperation*, int>)(lpVtbl[11]))((IDownloadOperation*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResultFile([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);

        [VtblIndex(7)]
        HRESULT get_Progress([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundDownloadProgress *")] BackgroundDownloadProgress* value);

        [VtblIndex(8)]
        HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperationWithProgress<IntPtr, IntPtr>** operation);

        [VtblIndex(9)]
        HRESULT AttachAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperationWithProgress<IntPtr, IntPtr>** operation);

        [VtblIndex(10)]
        HRESULT Pause();

        [VtblIndex(11)]
        HRESULT Resume();
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_ResultFile;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundDownloadProgress *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundDownloadProgress*, int> get_Progress;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperationWithProgress<IntPtr, IntPtr>**, int> StartAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperationWithProgress<IntPtr, IntPtr>**, int> AttachAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;
    }
}
