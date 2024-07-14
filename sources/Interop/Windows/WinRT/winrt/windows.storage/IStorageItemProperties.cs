// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageItemProperties.xml' path='doc/member[@name="IStorageItemProperties"]/*' />
[Guid("86664478-8029-46FE-A789-1C2F3E2FFB5C")]
[NativeTypeName("struct IStorageItemProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageItemProperties : IStorageItemProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageItemProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, uint>)(lpVtbl[1]))((IStorageItemProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, uint>)(lpVtbl[2]))((IStorageItemProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, HSTRING*, int>)(lpVtbl[4]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageItemProperties.xml' path='doc/member[@name="IStorageItemProperties.GetThumbnailAsyncOverloadDefaultSizeDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetThumbnailAsyncOverloadDefaultSizeDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, ThumbnailMode, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), mode, operation);
    }

    /// <include file='IStorageItemProperties.xml' path='doc/member[@name="IStorageItemProperties.GetThumbnailAsyncOverloadDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetThumbnailAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, ThumbnailMode, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), mode, requestedSize, operation);
    }

    /// <include file='IStorageItemProperties.xml' path='doc/member[@name="IStorageItemProperties.GetThumbnailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] ThumbnailOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, ThumbnailMode, uint, ThumbnailOptions, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), mode, requestedSize, options, operation);
    }

    /// <include file='IStorageItemProperties.xml' path='doc/member[@name="IStorageItemProperties.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, HSTRING*, int>)(lpVtbl[9]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageItemProperties.xml' path='doc/member[@name="IStorageItemProperties.get_DisplayType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DisplayType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, HSTRING*, int>)(lpVtbl[10]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageItemProperties.xml' path='doc/member[@name="IStorageItemProperties.get_FolderRelativeId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_FolderRelativeId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, HSTRING*, int>)(lpVtbl[11]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageItemProperties.xml' path='doc/member[@name="IStorageItemProperties.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Storage::FileProperties::IStorageItemContentProperties **")] IStorageItemContentProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties*, IStorageItemContentProperties**, int>)(lpVtbl[12]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetThumbnailAsyncOverloadDefaultSizeDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT GetThumbnailAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] ThumbnailOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(9)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_DisplayType(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_FolderRelativeId(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Storage::FileProperties::IStorageItemContentProperties **")] IStorageItemContentProperties** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ThumbnailMode, IAsyncOperation<IntPtr>**, int> GetThumbnailAsyncOverloadDefaultSizeDefaultOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ThumbnailMode, uint, IAsyncOperation<IntPtr>**, int> GetThumbnailAsyncOverloadDefaultOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Storage::FileProperties::ThumbnailOptions, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ThumbnailMode, uint, ThumbnailOptions, IAsyncOperation<IntPtr>**, int> GetThumbnailAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FolderRelativeId;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::IStorageItemContentProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItemContentProperties**, int> get_Properties;
    }
}
