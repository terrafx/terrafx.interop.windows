// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageLibraryContentChangedTriggerDetails.xml' path='doc/member[@name="IStorageLibraryContentChangedTriggerDetails"]/*' />
[Guid("2A371977-ABBF-4E1D-8AA5-6385D8884799")]
[NativeTypeName("struct IStorageLibraryContentChangedTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageLibraryContentChangedTriggerDetails : IStorageLibraryContentChangedTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageLibraryContentChangedTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerDetails*, uint>)(lpVtbl[1]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerDetails*, uint>)(lpVtbl[2]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageLibraryContentChangedTriggerDetails.xml' path='doc/member[@name="IStorageLibraryContentChangedTriggerDetails.get_Folder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerDetails*, IStorageFolder**, int>)(lpVtbl[6]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageLibraryContentChangedTriggerDetails.xml' path='doc/member[@name="IStorageLibraryContentChangedTriggerDetails.CreateModifiedSinceQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateModifiedSinceQuery([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime lastQueryTime, [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerDetails*, WinRTDateTime, IStorageItemQueryResult**, int>)(lpVtbl[7]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), lastQueryTime, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(7)]
        HRESULT CreateModifiedSinceQuery([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime lastQueryTime, [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Storage::Search::IStorageItemQueryResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, IStorageItemQueryResult**, int> CreateModifiedSinceQuery;
    }
}
