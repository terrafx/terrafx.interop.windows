// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem"]/*' />
[Guid("4207A996-CA2F-42F7-BDE8-8B10457A7F30")]
[NativeTypeName("struct IStorageItem : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageItem : IStorageItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageItem);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, uint>)(lpVtbl[1]))((IStorageItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, uint>)(lpVtbl[2]))((IStorageItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItem*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, HSTRING*, int>)(lpVtbl[4]))((IStorageItem*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItem*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.RenameAsyncOverloadDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RenameAsyncOverloadDefaultOptions(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, HSTRING, IAsyncAction**, int>)(lpVtbl[6]))((IStorageItem*)Unsafe.AsPointer(ref this), desiredName, operation);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.RenameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RenameAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, HSTRING, NameCollisionOption, IAsyncAction**, int>)(lpVtbl[7]))((IStorageItem*)Unsafe.AsPointer(ref this), desiredName, option, operation);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.DeleteAsyncOverloadDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, IAsyncAction**, int>)(lpVtbl[8]))((IStorageItem*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Storage::StorageDeleteOption")] StorageDeleteOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, StorageDeleteOption, IAsyncAction**, int>)(lpVtbl[9]))((IStorageItem*)Unsafe.AsPointer(ref this), option, operation);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.GetBasicPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetBasicPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CBasicProperties_t **")] IAsyncOperation<Pointer<IBasicProperties>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, IAsyncOperation<Pointer<IBasicProperties>>**, int>)(lpVtbl[10]))((IStorageItem*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, HSTRING*, int>)(lpVtbl[11]))((IStorageItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.get_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Path(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, HSTRING*, int>)(lpVtbl[12]))((IStorageItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.get_Attributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Attributes([NativeTypeName("ABI::Windows::Storage::FileAttributes *")] FileAttributes* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, FileAttributes*, int>)(lpVtbl[13]))((IStorageItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.get_DateCreated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DateCreated([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, WinRTDateTime*, int>)(lpVtbl[14]))((IStorageItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageItem.xml' path='doc/member[@name="IStorageItem.IsOfType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsOfType([NativeTypeName("ABI::Windows::Storage::StorageItemTypes")] StorageItemTypes type, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItem*, StorageItemTypes, byte*, int>)(lpVtbl[15]))((IStorageItem*)Unsafe.AsPointer(ref this), type, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RenameAsyncOverloadDefaultOptions(HSTRING desiredName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT RenameAsync(HSTRING desiredName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT DeleteAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(9)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Storage::StorageDeleteOption")] StorageDeleteOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(10)]
        HRESULT GetBasicPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CBasicProperties_t **")] IAsyncOperation<Pointer<IBasicProperties>>** operation);

        [VtblIndex(11)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Path(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Attributes([NativeTypeName("ABI::Windows::Storage::FileAttributes *")] FileAttributes* value);

        [VtblIndex(14)]
        HRESULT get_DateCreated([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(15)]
        HRESULT IsOfType([NativeTypeName("ABI::Windows::Storage::StorageItemTypes")] StorageItemTypes type, [NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> RenameAsyncOverloadDefaultOptions;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::NameCollisionOption, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, NameCollisionOption, IAsyncAction**, int> RenameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAsyncOverloadDefaultOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::StorageDeleteOption, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageDeleteOption, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CBasicProperties_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IBasicProperties>>**, int> GetBasicPropertiesAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Path;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FileAttributes*, int> get_Attributes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_DateCreated;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::StorageItemTypes, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageItemTypes, byte*, int> IsOfType;
    }
}
