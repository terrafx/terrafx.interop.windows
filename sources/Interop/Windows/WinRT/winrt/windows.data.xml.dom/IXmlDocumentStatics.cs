// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IXmlDocumentStatics.xml' path='doc/member[@name="IXmlDocumentStatics"]/*' />
[Guid("5543D254-D757-4B79-9539-232B18F50BF1")]
[NativeTypeName("struct IXmlDocumentStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlDocumentStatics : IXmlDocumentStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlDocumentStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, Guid*, void**, int>)(lpVtbl[0]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, uint>)(lpVtbl[1]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, uint>)(lpVtbl[2]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, HSTRING*, int>)(lpVtbl[4]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, TrustLevel*, int>)(lpVtbl[5]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IXmlDocumentStatics.xml' path='doc/member[@name="IXmlDocumentStatics.LoadFromUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LoadFromUriAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **")] IAsyncOperation<Pointer<IXmlDocument>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, IUriRuntimeClass*, IAsyncOperation<Pointer<IXmlDocument>>**, int>)(lpVtbl[6]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this), uri, asyncInfo);
    }

    /// <include file='IXmlDocumentStatics.xml' path='doc/member[@name="IXmlDocumentStatics.LoadFromUriWithSettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LoadFromUriWithSettingsAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *")] IXmlLoadSettings* loadSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **")] IAsyncOperation<Pointer<IXmlDocument>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, IUriRuntimeClass*, IXmlLoadSettings*, IAsyncOperation<Pointer<IXmlDocument>>**, int>)(lpVtbl[7]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this), uri, loadSettings, asyncInfo);
    }

    /// <include file='IXmlDocumentStatics.xml' path='doc/member[@name="IXmlDocumentStatics.LoadFromFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LoadFromFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **")] IAsyncOperation<Pointer<IXmlDocument>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, IStorageFile*, IAsyncOperation<Pointer<IXmlDocument>>**, int>)(lpVtbl[8]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this), file, asyncInfo);
    }

    /// <include file='IXmlDocumentStatics.xml' path='doc/member[@name="IXmlDocumentStatics.LoadFromFileWithSettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LoadFromFileWithSettingsAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *")] IXmlLoadSettings* loadSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **")] IAsyncOperation<Pointer<IXmlDocument>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentStatics*, IStorageFile*, IXmlLoadSettings*, IAsyncOperation<Pointer<IXmlDocument>>**, int>)(lpVtbl[9]))((IXmlDocumentStatics*)Unsafe.AsPointer(ref this), file, loadSettings, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LoadFromUriAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **")] IAsyncOperation<Pointer<IXmlDocument>>** asyncInfo);

        [VtblIndex(7)]
        HRESULT LoadFromUriWithSettingsAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *")] IXmlLoadSettings* loadSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **")] IAsyncOperation<Pointer<IXmlDocument>>** asyncInfo);

        [VtblIndex(8)]
        HRESULT LoadFromFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **")] IAsyncOperation<Pointer<IXmlDocument>>** asyncInfo);

        [VtblIndex(9)]
        HRESULT LoadFromFileWithSettingsAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *")] IXmlLoadSettings* loadSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **")] IAsyncOperation<Pointer<IXmlDocument>>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperation<Pointer<IXmlDocument>>**, int> LoadFromUriAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IXmlLoadSettings*, IAsyncOperation<Pointer<IXmlDocument>>**, int> LoadFromUriWithSettingsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<IXmlDocument>>**, int> LoadFromFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CData__CXml__CDom__CXmlDocument_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IXmlLoadSettings*, IAsyncOperation<Pointer<IXmlDocument>>**, int> LoadFromFileWithSettingsAsync;
    }
}
