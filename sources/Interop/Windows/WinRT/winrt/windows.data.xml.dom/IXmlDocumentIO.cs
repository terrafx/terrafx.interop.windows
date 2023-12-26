// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IXmlDocumentIO.xml' path='doc/member[@name="IXmlDocumentIO"]/*' />
[Guid("6CD0E74E-EE65-4489-9EBF-CA43E87BA637")]
[NativeTypeName("struct IXmlDocumentIO : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlDocumentIO : IXmlDocumentIO.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlDocumentIO));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, Guid*, void**, int>)(lpVtbl[0]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, uint>)(lpVtbl[1]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, uint>)(lpVtbl[2]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, uint*, Guid**, int>)(lpVtbl[3]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, HSTRING*, int>)(lpVtbl[4]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, TrustLevel*, int>)(lpVtbl[5]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IXmlDocumentIO.xml' path='doc/member[@name="IXmlDocumentIO.LoadXml"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LoadXml(HSTRING xml)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, HSTRING, int>)(lpVtbl[6]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this), xml);
    }

    /// <include file='IXmlDocumentIO.xml' path='doc/member[@name="IXmlDocumentIO.LoadXmlWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LoadXmlWithSettings(HSTRING xml, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *")] IXmlLoadSettings* loadSettings)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, HSTRING, IXmlLoadSettings*, int>)(lpVtbl[7]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this), xml, loadSettings);
    }

    /// <include file='IXmlDocumentIO.xml' path='doc/member[@name="IXmlDocumentIO.SaveToFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SaveToFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocumentIO*, IStorageFile*, IAsyncAction**, int>)(lpVtbl[8]))((IXmlDocumentIO*)Unsafe.AsPointer(ref this), file, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LoadXml(HSTRING xml);

        [VtblIndex(7)]
        HRESULT LoadXmlWithSettings(HSTRING xml, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *")] IXmlLoadSettings* loadSettings);

        [VtblIndex(8)]
        HRESULT SaveToFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> LoadXml;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlLoadSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlLoadSettings*, int> LoadXmlWithSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncAction**, int> SaveToFileAsync;
    }
}
