// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDownloadsFolderStatics2.xml' path='doc/member[@name="IDownloadsFolderStatics2"]/*' />
[Guid("E93045BD-8EF8-4F8E-8D15-AC0E265F390D")]
[NativeTypeName("struct IDownloadsFolderStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDownloadsFolderStatics2 : IDownloadsFolderStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDownloadsFolderStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, uint>)(lpVtbl[1]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, uint>)(lpVtbl[2]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, HSTRING*, int>)(lpVtbl[4]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDownloadsFolderStatics2.xml' path='doc/member[@name="IDownloadsFolderStatics2.CreateFileForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFileForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, IUser*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[6]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), user, desiredName, operation);
    }

    /// <include file='IDownloadsFolderStatics2.xml' path='doc/member[@name="IDownloadsFolderStatics2.CreateFolderForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFolderForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, IUser*, HSTRING, IAsyncOperation<Pointer<IStorageFolder>>**, int>)(lpVtbl[7]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), user, desiredName, operation);
    }

    /// <include file='IDownloadsFolderStatics2.xml' path='doc/member[@name="IDownloadsFolderStatics2.CreateFileForUserWithCollisionOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFileForUserWithCollisionOptionAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, IUser*, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[8]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), user, desiredName, option, operation);
    }

    /// <include file='IDownloadsFolderStatics2.xml' path='doc/member[@name="IDownloadsFolderStatics2.CreateFolderForUserWithCollisionOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFolderForUserWithCollisionOptionAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDownloadsFolderStatics2*, IUser*, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IStorageFolder>>**, int>)(lpVtbl[9]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), user, desiredName, option, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFileForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(7)]
        HRESULT CreateFolderForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation);

        [VtblIndex(8)]
        HRESULT CreateFileForUserWithCollisionOptionAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(9)]
        HRESULT CreateFolderForUserWithCollisionOptionAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int> CreateFileForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, IAsyncOperation<Pointer<IStorageFolder>>**, int> CreateFolderForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IStorageFile>>**, int> CreateFileForUserWithCollisionOptionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, CreationCollisionOption, IAsyncOperation<Pointer<IStorageFolder>>**, int> CreateFolderForUserWithCollisionOptionAsync;
    }
}
