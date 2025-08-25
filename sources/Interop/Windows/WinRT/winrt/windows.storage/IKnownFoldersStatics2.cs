// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownFoldersStatics2.xml' path='doc/member[@name="IKnownFoldersStatics2"]/*' />
[Guid("194BD0CD-CF6E-4D07-9D53-E9163A2536E9")]
[NativeTypeName("struct IKnownFoldersStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownFoldersStatics2 : IKnownFoldersStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKnownFoldersStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, uint>)(lpVtbl[1]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, uint>)(lpVtbl[2]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, HSTRING*, int>)(lpVtbl[4]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownFoldersStatics2.xml' path='doc/member[@name="IKnownFoldersStatics2.get_Objects3D"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Objects3D([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, IStorageFolder**, int>)(lpVtbl[6]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownFoldersStatics2.xml' path='doc/member[@name="IKnownFoldersStatics2.get_AppCaptures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppCaptures([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, IStorageFolder**, int>)(lpVtbl[7]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownFoldersStatics2.xml' path='doc/member[@name="IKnownFoldersStatics2.get_RecordedCalls"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RecordedCalls([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics2*, IStorageFolder**, int>)(lpVtbl[8]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Objects3D([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(7)]
        HRESULT get_AppCaptures([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(8)]
        HRESULT get_RecordedCalls([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_Objects3D;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_AppCaptures;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_RecordedCalls;
    }
}
