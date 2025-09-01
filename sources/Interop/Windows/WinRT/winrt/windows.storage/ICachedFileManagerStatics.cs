// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICachedFileManagerStatics.xml' path='doc/member[@name="ICachedFileManagerStatics"]/*' />
[Guid("8FFC224A-E782-495D-B614-654C4F0B2370")]
[NativeTypeName("struct ICachedFileManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICachedFileManagerStatics : ICachedFileManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICachedFileManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileManagerStatics*, uint>)(lpVtbl[1]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileManagerStatics*, uint>)(lpVtbl[2]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICachedFileManagerStatics.xml' path='doc/member[@name="ICachedFileManagerStatics.DeferUpdates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeferUpdates([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileManagerStatics*, IStorageFile*, int>)(lpVtbl[6]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), file);
    }

    /// <include file='ICachedFileManagerStatics.xml' path='doc/member[@name="ICachedFileManagerStatics.CompleteUpdatesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CompleteUpdatesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CProvider__CFileUpdateStatus_t **")] IAsyncOperation<FileUpdateStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileManagerStatics*, IStorageFile*, IAsyncOperation<FileUpdateStatus>**, int>)(lpVtbl[7]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), file, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT DeferUpdates([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file);

        [VtblIndex(7)]
        HRESULT CompleteUpdatesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CProvider__CFileUpdateStatus_t **")] IAsyncOperation<FileUpdateStatus>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, int> DeferUpdates;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CProvider__CFileUpdateStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<FileUpdateStatus>**, int> CompleteUpdatesAsync;
    }
}
