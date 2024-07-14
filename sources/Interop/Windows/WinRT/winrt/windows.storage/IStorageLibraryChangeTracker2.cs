// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageLibraryChangeTracker2.xml' path='doc/member[@name="IStorageLibraryChangeTracker2"]/*' />
[Guid("CD051C3B-0F9F-42F9-8FB3-158D82E13821")]
[NativeTypeName("struct IStorageLibraryChangeTracker2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageLibraryChangeTracker2 : IStorageLibraryChangeTracker2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageLibraryChangeTracker2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTracker2*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryChangeTracker2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTracker2*, uint>)(lpVtbl[1]))((IStorageLibraryChangeTracker2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTracker2*, uint>)(lpVtbl[2]))((IStorageLibraryChangeTracker2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTracker2*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryChangeTracker2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTracker2*, HSTRING*, int>)(lpVtbl[4]))((IStorageLibraryChangeTracker2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTracker2*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryChangeTracker2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageLibraryChangeTracker2.xml' path='doc/member[@name="IStorageLibraryChangeTracker2.EnableWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnableWithOptions([NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTrackerOptions *")] IStorageLibraryChangeTrackerOptions* options)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTracker2*, IStorageLibraryChangeTrackerOptions*, int>)(lpVtbl[6]))((IStorageLibraryChangeTracker2*)Unsafe.AsPointer(ref this), options);
    }

    /// <include file='IStorageLibraryChangeTracker2.xml' path='doc/member[@name="IStorageLibraryChangeTracker2.Disable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Disable()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChangeTracker2*, int>)(lpVtbl[7]))((IStorageLibraryChangeTracker2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT EnableWithOptions([NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTrackerOptions *")] IStorageLibraryChangeTrackerOptions* options);

        [VtblIndex(7)]
        HRESULT Disable();
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageLibraryChangeTrackerOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageLibraryChangeTrackerOptions*, int> EnableWithOptions;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Disable;
    }
}
