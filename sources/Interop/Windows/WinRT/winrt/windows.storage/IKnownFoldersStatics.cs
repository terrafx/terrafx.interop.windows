// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownFoldersStatics.xml' path='doc/member[@name="IKnownFoldersStatics"]/*' />
[Guid("5A2A7520-4802-452D-9AD9-4351ADA7EC35")]
[NativeTypeName("struct IKnownFoldersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownFoldersStatics : IKnownFoldersStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKnownFoldersStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, uint>)(lpVtbl[1]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, uint>)(lpVtbl[2]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, HSTRING*, int>)(lpVtbl[4]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownFoldersStatics.xml' path='doc/member[@name="IKnownFoldersStatics.get_MusicLibrary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MusicLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[6]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownFoldersStatics.xml' path='doc/member[@name="IKnownFoldersStatics.get_PicturesLibrary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PicturesLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[7]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownFoldersStatics.xml' path='doc/member[@name="IKnownFoldersStatics.get_VideosLibrary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideosLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[8]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownFoldersStatics.xml' path='doc/member[@name="IKnownFoldersStatics.get_DocumentsLibrary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DocumentsLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[9]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownFoldersStatics.xml' path='doc/member[@name="IKnownFoldersStatics.get_HomeGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HomeGroup([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[10]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownFoldersStatics.xml' path='doc/member[@name="IKnownFoldersStatics.get_RemovableDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RemovableDevices([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[11]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownFoldersStatics.xml' path='doc/member[@name="IKnownFoldersStatics.get_MediaServerDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MediaServerDevices([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[12]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MusicLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(7)]
        HRESULT get_PicturesLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(8)]
        HRESULT get_VideosLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(9)]
        HRESULT get_DocumentsLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(10)]
        HRESULT get_HomeGroup([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(11)]
        HRESULT get_RemovableDevices([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(12)]
        HRESULT get_MediaServerDevices([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_MusicLibrary;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_PicturesLibrary;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_VideosLibrary;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_DocumentsLibrary;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_HomeGroup;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_RemovableDevices;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_MediaServerDevices;
    }
}
