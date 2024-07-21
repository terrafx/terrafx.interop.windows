// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageFile2.xml' path='doc/member[@name="IStorageFile2"]/*' />
[Guid("954E4BCF-0A77-42FB-B777-C2ED58A52E44")]
[NativeTypeName("struct IStorageFile2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFile2 : IStorageFile2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFile2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile2*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFile2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile2*, uint>)(lpVtbl[1]))((IStorageFile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile2*, uint>)(lpVtbl[2]))((IStorageFile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile2*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFile2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile2*, HSTRING*, int>)(lpVtbl[4]))((IStorageFile2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile2*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFile2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageFile2.xml' path='doc/member[@name="IStorageFile2.OpenWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile2*, FileAccessMode, StorageOpenOptions, IAsyncOperation<Pointer<IRandomAccessStream>>**, int>)(lpVtbl[6]))((IStorageFile2*)Unsafe.AsPointer(ref this), accessMode, options, operation);
    }

    /// <include file='IStorageFile2.xml' path='doc/member[@name="IStorageFile2.OpenTransactedWriteWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenTransactedWriteWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFile2*, StorageOpenOptions, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int>)(lpVtbl[7]))((IStorageFile2*)Unsafe.AsPointer(ref this), options, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation);

        [VtblIndex(7)]
        HRESULT OpenTransactedWriteWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileAccessMode, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FileAccessMode, StorageOpenOptions, IAsyncOperation<Pointer<IRandomAccessStream>>**, int> OpenWithOptionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageOpenOptions, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int> OpenTransactedWriteWithOptionsAsync;
    }
}
