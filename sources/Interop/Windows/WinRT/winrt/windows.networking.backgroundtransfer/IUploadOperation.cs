// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUploadOperation.xml' path='doc/member[@name="IUploadOperation"]/*' />
[Guid("3E5624E0-7389-434C-8B35-427FD36BBDAE")]
[NativeTypeName("struct IUploadOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUploadOperation : IUploadOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUploadOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, Guid*, void**, int>)(lpVtbl[0]))((IUploadOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, uint>)(lpVtbl[1]))((IUploadOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, uint>)(lpVtbl[2]))((IUploadOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IUploadOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, HSTRING*, int>)(lpVtbl[4]))((IUploadOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, TrustLevel*, int>)(lpVtbl[5]))((IUploadOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUploadOperation.xml' path='doc/member[@name="IUploadOperation.get_SourceFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceFile([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, IStorageFile**, int>)(lpVtbl[6]))((IUploadOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUploadOperation.xml' path='doc/member[@name="IUploadOperation.get_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Progress([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundUploadProgress *")] BackgroundUploadProgress* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, BackgroundUploadProgress*, int>)(lpVtbl[7]))((IUploadOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUploadOperation.xml' path='doc/member[@name="IUploadOperation.StartAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperationWithProgress<Pointer<IUploadOperation>, Pointer<IUploadOperation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, IAsyncOperationWithProgress<Pointer<IUploadOperation>, Pointer<IUploadOperation>>**, int>)(lpVtbl[8]))((IUploadOperation*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IUploadOperation.xml' path='doc/member[@name="IUploadOperation.AttachAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AttachAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperationWithProgress<Pointer<IUploadOperation>, Pointer<IUploadOperation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUploadOperation*, IAsyncOperationWithProgress<Pointer<IUploadOperation>, Pointer<IUploadOperation>>**, int>)(lpVtbl[9]))((IUploadOperation*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceFile([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);

        [VtblIndex(7)]
        HRESULT get_Progress([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundUploadProgress *")] BackgroundUploadProgress* value);

        [VtblIndex(8)]
        HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperationWithProgress<Pointer<IUploadOperation>, Pointer<IUploadOperation>>** operation);

        [VtblIndex(9)]
        HRESULT AttachAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperationWithProgress<Pointer<IUploadOperation>, Pointer<IUploadOperation>>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_SourceFile;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundUploadProgress *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundUploadProgress*, int> get_Progress;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperationWithProgress<Pointer<IUploadOperation>, Pointer<IUploadOperation>>**, int> StartAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperationWithProgress<Pointer<IUploadOperation>, Pointer<IUploadOperation>>**, int> AttachAsync;
    }
}
