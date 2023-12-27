// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageItemContentProperties.xml' path='doc/member[@name="IStorageItemContentProperties"]/*' />
[Guid("05294BAD-BC38-48BF-85D7-770E0E2AE0BA")]
[NativeTypeName("struct IStorageItemContentProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageItemContentProperties : IStorageItemContentProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageItemContentProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, uint>)(lpVtbl[1]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, uint>)(lpVtbl[2]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, HSTRING*, int>)(lpVtbl[4]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageItemContentProperties.xml' path='doc/member[@name="IStorageItemContentProperties.GetMusicPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMusicPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CMusicProperties_t **")] IAsyncOperation<Pointer<IMusicProperties>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, IAsyncOperation<Pointer<IMusicProperties>>**, int>)(lpVtbl[6]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageItemContentProperties.xml' path='doc/member[@name="IStorageItemContentProperties.GetVideoPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVideoPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CVideoProperties_t **")] IAsyncOperation<Pointer<IVideoProperties>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, IAsyncOperation<Pointer<IVideoProperties>>**, int>)(lpVtbl[7]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageItemContentProperties.xml' path='doc/member[@name="IStorageItemContentProperties.GetImagePropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetImagePropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CImageProperties_t **")] IAsyncOperation<Pointer<ImageProperties>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, IAsyncOperation<Pointer<ImageProperties>>**, int>)(lpVtbl[8]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStorageItemContentProperties.xml' path='doc/member[@name="IStorageItemContentProperties.GetDocumentPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDocumentPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CDocumentProperties_t **")] IAsyncOperation<Pointer<IDocumentProperties>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemContentProperties*, IAsyncOperation<Pointer<IDocumentProperties>>**, int>)(lpVtbl[9]))((IStorageItemContentProperties*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetMusicPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CMusicProperties_t **")] IAsyncOperation<Pointer<IMusicProperties>>** operation);

        [VtblIndex(7)]
        HRESULT GetVideoPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CVideoProperties_t **")] IAsyncOperation<Pointer<IVideoProperties>>** operation);

        [VtblIndex(8)]
        HRESULT GetImagePropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CImageProperties_t **")] IAsyncOperation<Pointer<ImageProperties>>** operation);

        [VtblIndex(9)]
        HRESULT GetDocumentPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CDocumentProperties_t **")] IAsyncOperation<Pointer<IDocumentProperties>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CMusicProperties_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IMusicProperties>>**, int> GetMusicPropertiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CVideoProperties_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVideoProperties>>**, int> GetVideoPropertiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CImageProperties_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ImageProperties>>**, int> GetImagePropertiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CDocumentProperties_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IDocumentProperties>>**, int> GetDocumentPropertiesAsync;
    }
}
