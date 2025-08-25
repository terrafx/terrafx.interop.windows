// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageLibraryChangeTrackerTriggerDetails.xml' path='doc/member[@name="IStorageLibraryChangeTrackerTriggerDetails"]/*' />
[Guid("1DC7A369-B7A3-4DF2-9D61-EBA85A0343D2")]
[NativeTypeName("struct IStorageLibraryChangeTrackerTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageLibraryChangeTrackerTriggerDetails : IStorageLibraryChangeTrackerTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageLibraryChangeTrackerTriggerDetails);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTrackerTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTrackerTriggerDetails*, uint>)(lpVtbl[1]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTrackerTriggerDetails*, uint>)(lpVtbl[2]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTrackerTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTrackerTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTrackerTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageLibraryChangeTrackerTriggerDetails.xml' path='doc/member[@name="IStorageLibraryChangeTrackerTriggerDetails.get_Folder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTrackerTriggerDetails*, IStorageFolder**, int>)(lpVtbl[6]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageLibraryChangeTrackerTriggerDetails.xml' path='doc/member[@name="IStorageLibraryChangeTrackerTriggerDetails.get_ChangeTracker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTracker **")] IStorageLibraryChangeTracker** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTrackerTriggerDetails*, IStorageLibraryChangeTracker**, int>)(lpVtbl[7]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(7)]
        HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTracker **")] IStorageLibraryChangeTracker** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_Folder;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageLibraryChangeTracker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageLibraryChangeTracker**, int> get_ChangeTracker;
    }
}
