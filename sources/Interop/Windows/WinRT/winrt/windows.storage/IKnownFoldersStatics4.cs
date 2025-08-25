// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownFoldersStatics4.xml' path='doc/member[@name="IKnownFoldersStatics4"]/*' />
[Guid("1722E6BF-9FF9-4B21-BED5-90ECB13A192E")]
[NativeTypeName("struct IKnownFoldersStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownFoldersStatics4 : IKnownFoldersStatics4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKnownFoldersStatics4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, uint>)(lpVtbl[1]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, uint>)(lpVtbl[2]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, HSTRING*, int>)(lpVtbl[4]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, TrustLevel*, int>)(lpVtbl[5]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownFoldersStatics4.xml' path='doc/member[@name="IKnownFoldersStatics4.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Storage::KnownFolderId")] KnownFolderId folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CKnownFoldersAccessStatus_t **")] IAsyncOperation<KnownFoldersAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, KnownFolderId, IAsyncOperation<KnownFoldersAccessStatus>**, int>)(lpVtbl[6]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this), folderId, operation);
    }

    /// <include file='IKnownFoldersStatics4.xml' path='doc/member[@name="IKnownFoldersStatics4.RequestAccessForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Storage::KnownFolderId")] KnownFolderId folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CKnownFoldersAccessStatus_t **")] IAsyncOperation<KnownFoldersAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, IUser*, KnownFolderId, IAsyncOperation<KnownFoldersAccessStatus>**, int>)(lpVtbl[7]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this), user, folderId, operation);
    }

    /// <include file='IKnownFoldersStatics4.xml' path='doc/member[@name="IKnownFoldersStatics4.GetFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFolderAsync([NativeTypeName("ABI::Windows::Storage::KnownFolderId")] KnownFolderId folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics4*, KnownFolderId, IAsyncOperation<Pointer<IStorageFolder>>**, int>)(lpVtbl[8]))((IKnownFoldersStatics4*)Unsafe.AsPointer(ref this), folderId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Storage::KnownFolderId")] KnownFolderId folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CKnownFoldersAccessStatus_t **")] IAsyncOperation<KnownFoldersAccessStatus>** operation);

        [VtblIndex(7)]
        HRESULT RequestAccessForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Storage::KnownFolderId")] KnownFolderId folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CKnownFoldersAccessStatus_t **")] IAsyncOperation<KnownFoldersAccessStatus>** operation);

        [VtblIndex(8)]
        HRESULT GetFolderAsync([NativeTypeName("ABI::Windows::Storage::KnownFolderId")] KnownFolderId folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::KnownFolderId, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CKnownFoldersAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KnownFolderId, IAsyncOperation<KnownFoldersAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Storage::KnownFolderId, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CKnownFoldersAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, KnownFolderId, IAsyncOperation<KnownFoldersAccessStatus>**, int> RequestAccessForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::KnownFolderId, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KnownFolderId, IAsyncOperation<Pointer<IStorageFolder>>**, int> GetFolderAsync;
    }
}
