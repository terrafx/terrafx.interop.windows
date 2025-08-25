// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSelectorStatics.xml' path='doc/member[@name="IStreamSelectorStatics"]/*' />
[Guid("8A4CD4A1-ED85-4E0F-BD68-8A6862E4636D")]
[NativeTypeName("struct IStreamSelectorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSelectorStatics : IStreamSelectorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStreamSelectorStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, uint>)(lpVtbl[1]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, uint>)(lpVtbl[2]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, HSTRING*, int>)(lpVtbl[4]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSelectorStatics.xml' path='doc/member[@name="IStreamSelectorStatics.SelectBestStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SelectBestStreamAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* storageFile, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* selectorProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, IStorageFile*, IPropertySet*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int>)(lpVtbl[6]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this), storageFile, selectorProperties, value);
    }

    /// <include file='IStreamSelectorStatics.xml' path='doc/member[@name="IStreamSelectorStatics.GetStreamPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStreamPropertiesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* storageFile, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* selectorProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IPropertySet>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, IStorageFile*, IPropertySet*, IAsyncOperation<Pointer<IVectorView<Pointer<IPropertySet>>>>**, int>)(lpVtbl[7]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this), storageFile, selectorProperties, value);
    }

    /// <include file='IStreamSelectorStatics.xml' path='doc/member[@name="IStreamSelectorStatics.SelectBestStreamFromStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SelectBestStreamFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* selectorProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, IRandomAccessStream*, IPropertySet*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int>)(lpVtbl[8]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this), stream, selectorProperties, value);
    }

    /// <include file='IStreamSelectorStatics.xml' path='doc/member[@name="IStreamSelectorStatics.GetStreamPropertiesFromStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetStreamPropertiesFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* selectorProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IPropertySet>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSelectorStatics*, IRandomAccessStream*, IPropertySet*, IAsyncOperation<Pointer<IVectorView<Pointer<IPropertySet>>>>**, int>)(lpVtbl[9]))((IStreamSelectorStatics*)Unsafe.AsPointer(ref this), stream, selectorProperties, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SelectBestStreamAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* storageFile, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* selectorProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** value);

        [VtblIndex(7)]
        HRESULT GetStreamPropertiesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* storageFile, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* selectorProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IPropertySet>>>>** value);

        [VtblIndex(8)]
        HRESULT SelectBestStreamFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* selectorProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** value);

        [VtblIndex(9)]
        HRESULT GetStreamPropertiesFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* selectorProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IPropertySet>>>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IPropertySet*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int> SelectBestStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IPropertySet*, IAsyncOperation<Pointer<IVectorView<Pointer<IPropertySet>>>>**, int> GetStreamPropertiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, IPropertySet*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int> SelectBestStreamFromStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___F__CIPropertySet_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, IPropertySet*, IAsyncOperation<Pointer<IVectorView<Pointer<IPropertySet>>>>**, int> GetStreamPropertiesFromStreamAsync;
    }
}
