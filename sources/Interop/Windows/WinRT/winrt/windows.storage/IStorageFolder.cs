// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder"]/*' />
[Guid("72D1CB78-B3EF-4F75-A80B-6FD9DAE2944B")]
[NativeTypeName("struct IStorageFolder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFolder : IStorageFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFolder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, uint>)(lpVtbl[1]))((IStorageFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, uint>)(lpVtbl[2]))((IStorageFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFolder*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, HSTRING*, int>)(lpVtbl[4]))((IStorageFolder*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFolder*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.CreateFileAsyncOverloadDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFileAsyncOverloadDefaultOptions(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageFolder*)Unsafe.AsPointer(ref this), desiredName, operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.CreateFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFileAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, HSTRING, CreationCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IStorageFolder*)Unsafe.AsPointer(ref this), desiredName, options, operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.CreateFolderAsyncOverloadDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFolderAsyncOverloadDefaultOptions(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IStorageFolder*)Unsafe.AsPointer(ref this), desiredName, operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.CreateFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFolderAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, HSTRING, CreationCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IStorageFolder*)Unsafe.AsPointer(ref this), desiredName, options, operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.GetFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFileAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IStorageFolder*)Unsafe.AsPointer(ref this), name, operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.GetFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFolderAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IStorageFolder*)Unsafe.AsPointer(ref this), name, operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.GetItemAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetItemAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[12]))((IStorageFolder*)Unsafe.AsPointer(ref this), name, operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.GetFilesAsyncOverloadDefaultOptionsStartAndCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFilesAsyncOverloadDefaultOptionsStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IStorageFolder*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.GetFoldersAsyncOverloadDefaultOptionsStartAndCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFoldersAsyncOverloadDefaultOptionsStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[14]))((IStorageFolder*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageFolder.xml' path='doc/member[@name="IStorageFolder.GetItemsAsyncOverloadDefaultStartAndCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetItemsAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFolder*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[15]))((IStorageFolder*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFileAsyncOverloadDefaultOptions(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT CreateFileAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT CreateFolderAsyncOverloadDefaultOptions(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(9)]
        HRESULT CreateFolderAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(10)]
        HRESULT GetFileAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(11)]
        HRESULT GetFolderAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(12)]
        HRESULT GetItemAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(13)]
        HRESULT GetFilesAsyncOverloadDefaultOptionsStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(14)]
        HRESULT GetFoldersAsyncOverloadDefaultOptionsStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(15)]
        HRESULT GetItemsAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<IntPtr>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> CreateFileAsyncOverloadDefaultOptions;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, CreationCollisionOption, IAsyncOperation<IntPtr>**, int> CreateFileAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> CreateFolderAsyncOverloadDefaultOptions;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, CreationCollisionOption, IAsyncOperation<IntPtr>**, int> CreateFolderAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetFileAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetFolderAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetItemAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetFilesAsyncOverloadDefaultOptionsStartAndCount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetFoldersAsyncOverloadDefaultOptionsStartAndCount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetItemsAsyncOverloadDefaultStartAndCount;
    }
}
