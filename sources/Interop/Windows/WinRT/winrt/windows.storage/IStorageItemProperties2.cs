// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageItemProperties2.xml' path='doc/member[@name="IStorageItemProperties2"]/*' />
[Guid("8E86A951-04B9-4BD2-929D-FEF3F71621D0")]
[NativeTypeName("struct IStorageItemProperties2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageItemProperties2 : IStorageItemProperties2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageItemProperties2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, uint>)(lpVtbl[1]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, uint>)(lpVtbl[2]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, HSTRING*, int>)(lpVtbl[4]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageItemProperties2.xml' path='doc/member[@name="IStorageItemProperties2.GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, ThumbnailMode, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), mode, operation);
    }

    /// <include file='IStorageItemProperties2.xml' path='doc/member[@name="IStorageItemProperties2.GetScaledImageAsThumbnailAsyncOverloadDefaultOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetScaledImageAsThumbnailAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, ThumbnailMode, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), mode, requestedSize, operation);
    }

    /// <include file='IStorageItemProperties2.xml' path='doc/member[@name="IStorageItemProperties2.GetScaledImageAsThumbnailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetScaledImageAsThumbnailAsync([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] ThumbnailOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemProperties2*, ThumbnailMode, uint, ThumbnailOptions, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), mode, requestedSize, options, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT GetScaledImageAsThumbnailAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT GetScaledImageAsThumbnailAsync([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] ThumbnailOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, ThumbnailMode, IAsyncOperation<IntPtr>**, int> GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ThumbnailMode, uint, IAsyncOperation<IntPtr>**, int> GetScaledImageAsThumbnailAsyncOverloadDefaultOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Storage::FileProperties::ThumbnailOptions, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ThumbnailMode, uint, ThumbnailOptions, IAsyncOperation<IntPtr>**, int> GetScaledImageAsThumbnailAsync;
    }
}
