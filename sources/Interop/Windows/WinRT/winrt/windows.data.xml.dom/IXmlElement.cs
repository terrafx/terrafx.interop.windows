// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement"]/*' />
[Guid("2DFB8A1F-6B10-4EF8-9F83-EFCCE8FAEC37")]
[NativeTypeName("struct IXmlElement : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlElement : IXmlElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, Guid*, void**, int>)(lpVtbl[0]))((IXmlElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, uint>)(lpVtbl[1]))((IXmlElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, uint>)(lpVtbl[2]))((IXmlElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, uint*, Guid**, int>)(lpVtbl[3]))((IXmlElement*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, HSTRING*, int>)(lpVtbl[4]))((IXmlElement*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, TrustLevel*, int>)(lpVtbl[5]))((IXmlElement*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.get_TagName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TagName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, HSTRING*, int>)(lpVtbl[6]))((IXmlElement*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.GetAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAttribute(HSTRING attributeName, HSTRING* attributeValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, HSTRING, HSTRING*, int>)(lpVtbl[7]))((IXmlElement*)Unsafe.AsPointer(ref this), attributeName, attributeValue);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.SetAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetAttribute(HSTRING attributeName, HSTRING attributeValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, HSTRING, HSTRING, int>)(lpVtbl[8]))((IXmlElement*)Unsafe.AsPointer(ref this), attributeName, attributeValue);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.RemoveAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAttribute(HSTRING attributeName)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, HSTRING, int>)(lpVtbl[9]))((IXmlElement*)Unsafe.AsPointer(ref this), attributeName);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.GetAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAttributeNode(HSTRING attributeName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** attributeNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, HSTRING, IXmlAttribute**, int>)(lpVtbl[10]))((IXmlElement*)Unsafe.AsPointer(ref this), attributeName, attributeNode);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.SetAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetAttributeNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")] IXmlAttribute* newAttribute, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** previousAttribute)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, IXmlAttribute*, IXmlAttribute**, int>)(lpVtbl[11]))((IXmlElement*)Unsafe.AsPointer(ref this), newAttribute, previousAttribute);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.RemoveAttributeNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveAttributeNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")] IXmlAttribute* attributeNode, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** removedAttribute)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, IXmlAttribute*, IXmlAttribute**, int>)(lpVtbl[12]))((IXmlElement*)Unsafe.AsPointer(ref this), attributeNode, removedAttribute);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.GetElementsByTagName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetElementsByTagName(HSTRING tagName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList** elements)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, HSTRING, IXmlNodeList**, int>)(lpVtbl[13]))((IXmlElement*)Unsafe.AsPointer(ref this), tagName, elements);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.SetAttributeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetAttributeNS(IInspectable* namespaceUri, HSTRING qualifiedName, HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, IInspectable*, HSTRING, HSTRING, int>)(lpVtbl[14]))((IXmlElement*)Unsafe.AsPointer(ref this), namespaceUri, qualifiedName, value);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.GetAttributeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetAttributeNS(IInspectable* namespaceUri, HSTRING localName, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, IInspectable*, HSTRING, HSTRING*, int>)(lpVtbl[15]))((IXmlElement*)Unsafe.AsPointer(ref this), namespaceUri, localName, value);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.RemoveAttributeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RemoveAttributeNS(IInspectable* namespaceUri, HSTRING localName)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, IInspectable*, HSTRING, int>)(lpVtbl[16]))((IXmlElement*)Unsafe.AsPointer(ref this), namespaceUri, localName);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.SetAttributeNodeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetAttributeNodeNS([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")] IXmlAttribute* newAttribute, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** previousAttribute)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, IXmlAttribute*, IXmlAttribute**, int>)(lpVtbl[17]))((IXmlElement*)Unsafe.AsPointer(ref this), newAttribute, previousAttribute);
    }

    /// <include file='IXmlElement.xml' path='doc/member[@name="IXmlElement.GetAttributeNodeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAttributeNodeNS(IInspectable* namespaceUri, HSTRING localName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** previousAttribute)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlElement*, IInspectable*, HSTRING, IXmlAttribute**, int>)(lpVtbl[18]))((IXmlElement*)Unsafe.AsPointer(ref this), namespaceUri, localName, previousAttribute);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TagName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetAttribute(HSTRING attributeName, HSTRING* attributeValue);

        [VtblIndex(8)]
        HRESULT SetAttribute(HSTRING attributeName, HSTRING attributeValue);

        [VtblIndex(9)]
        HRESULT RemoveAttribute(HSTRING attributeName);

        [VtblIndex(10)]
        HRESULT GetAttributeNode(HSTRING attributeName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** attributeNode);

        [VtblIndex(11)]
        HRESULT SetAttributeNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")] IXmlAttribute* newAttribute, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** previousAttribute);

        [VtblIndex(12)]
        HRESULT RemoveAttributeNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")] IXmlAttribute* attributeNode, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** removedAttribute);

        [VtblIndex(13)]
        HRESULT GetElementsByTagName(HSTRING tagName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList** elements);

        [VtblIndex(14)]
        HRESULT SetAttributeNS(IInspectable* namespaceUri, HSTRING qualifiedName, HSTRING value);

        [VtblIndex(15)]
        HRESULT GetAttributeNS(IInspectable* namespaceUri, HSTRING localName, HSTRING* value);

        [VtblIndex(16)]
        HRESULT RemoveAttributeNS(IInspectable* namespaceUri, HSTRING localName);

        [VtblIndex(17)]
        HRESULT SetAttributeNodeNS([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")] IXmlAttribute* newAttribute, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** previousAttribute);

        [VtblIndex(18)]
        HRESULT GetAttributeNodeNS(IInspectable* namespaceUri, HSTRING localName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** previousAttribute);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TagName;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING*, int> GetAttribute;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> SetAttribute;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> RemoveAttribute;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlAttribute**, int> GetAttributeNode;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlAttribute *, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlAttribute*, IXmlAttribute**, int> SetAttributeNode;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlAttribute *, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlAttribute*, IXmlAttribute**, int> RemoveAttributeNode;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlNodeList**, int> GetElementsByTagName;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, HSTRING, HSTRING, int> SetAttributeNS;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, HSTRING, HSTRING*, int> GetAttributeNS;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, HSTRING, int> RemoveAttributeNS;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlAttribute *, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlAttribute*, IXmlAttribute**, int> SetAttributeNodeNS;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, HSTRING, IXmlAttribute**, int> GetAttributeNodeNS;
    }
}
