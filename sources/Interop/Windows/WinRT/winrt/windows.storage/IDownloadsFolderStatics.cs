// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDownloadsFolderStatics.xml' path='doc/member[@name="IDownloadsFolderStatics"]/*' />
[Guid("27862ED0-404E-47DF-A1E2-E37308BE7B37")]
[NativeTypeName("struct IDownloadsFolderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDownloadsFolderStatics : IDownloadsFolderStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDownloadsFolderStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, uint>)(lpVtbl[1]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, uint>)(lpVtbl[2]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, HSTRING*, int>)(lpVtbl[4]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDownloadsFolderStatics.xml' path='doc/member[@name="IDownloadsFolderStatics.CreateFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFileAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[6]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), desiredName, operation);
    }

    /// <include file='IDownloadsFolderStatics.xml' path='doc/member[@name="IDownloadsFolderStatics.CreateFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFolderAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, HSTRING, IAsyncOperation<Pointer<IStorageFolder>>**, int>)(lpVtbl[7]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), desiredName, operation);
    }

    /// <include file='IDownloadsFolderStatics.xml' path='doc/member[@name="IDownloadsFolderStatics.CreateFileWithCollisionOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFileWithCollisionOptionAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[8]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), desiredName, option, operation);
    }

    /// <include file='IDownloadsFolderStatics.xml' path='doc/member[@name="IDownloadsFolderStatics.CreateFolderWithCollisionOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFolderWithCollisionOptionAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics*, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IStorageFolder>>**, int>)(lpVtbl[9]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), desiredName, option, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFileAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(7)]
        HRESULT CreateFolderAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation);

        [VtblIndex(8)]
        HRESULT CreateFileWithCollisionOptionAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(9)]
        HRESULT CreateFolderWithCollisionOptionAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int> CreateFileAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IStorageFolder>>**, int> CreateFolderAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IStorageFile>>**, int> CreateFileWithCollisionOptionAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IStorageFolder>>**, int> CreateFolderWithCollisionOptionAsync;
    }
}
