// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderKnownFolderSyncRequestedHandler.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncRequestedHandler"]/*' />
[Guid("C4CBB4F5-13DD-5C8E-8B96-336FC30C629B")]
[NativeTypeName("struct IStorageProviderKnownFolderSyncRequestedHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorageProviderKnownFolderSyncRequestedHandler : IStorageProviderKnownFolderSyncRequestedHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderKnownFolderSyncRequestedHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderKnownFolderSyncRequestedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestedHandler*, uint>)(lpVtbl[1]))((IStorageProviderKnownFolderSyncRequestedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestedHandler*, uint>)(lpVtbl[2]))((IStorageProviderKnownFolderSyncRequestedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStorageProviderKnownFolderSyncRequestedHandler.xml' path='doc/member[@name="IStorageProviderKnownFolderSyncRequestedHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestArgs *")] IStorageProviderKnownFolderSyncRequestArgs* args)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderKnownFolderSyncRequestedHandler*, IStorageProviderKnownFolderSyncRequestArgs*, int>)(lpVtbl[3]))((IStorageProviderKnownFolderSyncRequestedHandler*)Unsafe.AsPointer(ref this), args);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestArgs *")] IStorageProviderKnownFolderSyncRequestArgs* args);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestArgs *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderKnownFolderSyncRequestArgs*, int> Invoke;
    }
}
