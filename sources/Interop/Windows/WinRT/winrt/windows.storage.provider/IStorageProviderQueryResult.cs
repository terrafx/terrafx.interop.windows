// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult"]/*' />
[Guid("F1CD00AE-B4A9-5D20-A598-3EB4DD8FF8F4")]
[NativeTypeName("struct IStorageProviderQueryResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderQueryResult : IStorageProviderQueryResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageProviderQueryResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, uint>)(lpVtbl[1]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, uint>)(lpVtbl[2]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind *")] StorageProviderResultKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, StorageProviderResultKind*, int>)(lpVtbl[6]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.put_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Kind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind")] StorageProviderResultKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, StorageProviderResultKind, int>)(lpVtbl[7]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.get_ResultId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResultId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, HSTRING*, int>)(lpVtbl[8]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.put_ResultId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ResultId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, HSTRING, int>)(lpVtbl[9]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.get_RemoteFileId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RemoteFileId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, HSTRING*, int>)(lpVtbl[10]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.put_RemoteFileId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RemoteFileId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, HSTRING, int>)(lpVtbl[11]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.get_FilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FilePath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, HSTRING*, int>)(lpVtbl[12]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.put_FilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_FilePath(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, HSTRING, int>)(lpVtbl[13]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQueryResult.xml' path='doc/member[@name="IStorageProviderQueryResult.get_RequestedProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_RequestedProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQueryResult*, IPropertySet**, int>)(lpVtbl[14]))((IStorageProviderQueryResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind *")] StorageProviderResultKind* value);

        [VtblIndex(7)]
        HRESULT put_Kind([NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderResultKind")] StorageProviderResultKind value);

        [VtblIndex(8)]
        HRESULT get_ResultId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_ResultId(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_RemoteFileId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_RemoteFileId(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_FilePath(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_FilePath(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_RequestedProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderResultKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderResultKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::StorageProviderResultKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageProviderResultKind, int> put_Kind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ResultId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ResultId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteFileId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteFileId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FilePath;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FilePath;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_RequestedProperties;
    }
}
