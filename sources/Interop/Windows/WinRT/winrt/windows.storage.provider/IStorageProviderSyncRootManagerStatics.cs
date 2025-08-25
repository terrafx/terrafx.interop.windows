// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderSyncRootManagerStatics.xml' path='doc/member[@name="IStorageProviderSyncRootManagerStatics"]/*' />
[Guid("3E99FBBF-8FE3-4B40-ABC7-F6FC3D74C98E")]
[NativeTypeName("struct IStorageProviderSyncRootManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSyncRootManagerStatics : IStorageProviderSyncRootManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderSyncRootManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, uint>)(lpVtbl[1]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, uint>)(lpVtbl[2]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderSyncRootManagerStatics.xml' path='doc/member[@name="IStorageProviderSyncRootManagerStatics.Register"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Register([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo *")] IStorageProviderSyncRootInfo* syncRootInformation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, IStorageProviderSyncRootInfo*, int>)(lpVtbl[6]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), syncRootInformation);
    }

    /// <include file='IStorageProviderSyncRootManagerStatics.xml' path='doc/member[@name="IStorageProviderSyncRootManagerStatics.Unregister"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Unregister(HSTRING id)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, HSTRING, int>)(lpVtbl[7]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), id);
    }

    /// <include file='IStorageProviderSyncRootManagerStatics.xml' path='doc/member[@name="IStorageProviderSyncRootManagerStatics.GetSyncRootInformationForFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSyncRootInformationForFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* folder, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo **")] IStorageProviderSyncRootInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, IStorageFolder*, IStorageProviderSyncRootInfo**, int>)(lpVtbl[8]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), folder, result);
    }

    /// <include file='IStorageProviderSyncRootManagerStatics.xml' path='doc/member[@name="IStorageProviderSyncRootManagerStatics.GetSyncRootInformationForId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSyncRootInformationForId(HSTRING id, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo **")] IStorageProviderSyncRootInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, HSTRING, IStorageProviderSyncRootInfo**, int>)(lpVtbl[9]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IStorageProviderSyncRootManagerStatics.xml' path='doc/member[@name="IStorageProviderSyncRootManagerStatics.GetCurrentSyncRoots"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCurrentSyncRoots([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CProvider__CStorageProviderSyncRootInfo_t **")] IVectorView<Pointer<IStorageProviderSyncRootInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderSyncRootManagerStatics*, IVectorView<Pointer<IStorageProviderSyncRootInfo>>**, int>)(lpVtbl[10]))((IStorageProviderSyncRootManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Register([NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo *")] IStorageProviderSyncRootInfo* syncRootInformation);

        [VtblIndex(7)]
        HRESULT Unregister(HSTRING id);

        [VtblIndex(8)]
        HRESULT GetSyncRootInformationForFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* folder, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo **")] IStorageProviderSyncRootInfo** result);

        [VtblIndex(9)]
        HRESULT GetSyncRootInformationForId(HSTRING id, [NativeTypeName("ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo **")] IStorageProviderSyncRootInfo** result);

        [VtblIndex(10)]
        HRESULT GetCurrentSyncRoots([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CProvider__CStorageProviderSyncRootInfo_t **")] IVectorView<Pointer<IStorageProviderSyncRootInfo>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageProviderSyncRootInfo*, int> Register;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> Unregister;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder *, ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder*, IStorageProviderSyncRootInfo**, int> GetSyncRootInformationForFolder;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Provider::IStorageProviderSyncRootInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IStorageProviderSyncRootInfo**, int> GetSyncRootInformationForId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CProvider__CStorageProviderSyncRootInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IStorageProviderSyncRootInfo>>**, int> GetCurrentSyncRoots;
    }
}
