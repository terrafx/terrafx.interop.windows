// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument"]/*' />
[Guid("F7F3A506-1E87-42D6-BCFB-B8C809FA5494")]
[NativeTypeName("struct IXmlDocument : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlDocument : IXmlDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IXmlDocument);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, Guid*, void**, int>)(lpVtbl[0]))((IXmlDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, uint>)(lpVtbl[1]))((IXmlDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, uint>)(lpVtbl[2]))((IXmlDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, uint*, Guid**, int>)(lpVtbl[3]))((IXmlDocument*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING*, int>)(lpVtbl[4]))((IXmlDocument*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, TrustLevel*, int>)(lpVtbl[5]))((IXmlDocument*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.get_Doctype"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Doctype([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocumentType **")] IXmlDocumentType** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, IXmlDocumentType**, int>)(lpVtbl[6]))((IXmlDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.get_Implementation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Implementation([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDomImplementation **")] IXmlDomImplementation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, IXmlDomImplementation**, int>)(lpVtbl[7]))((IXmlDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.get_DocumentElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DocumentElement([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, IXmlElement**, int>)(lpVtbl[8]))((IXmlDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateElement(HSTRING tagName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement** newElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, IXmlElement**, int>)(lpVtbl[9]))((IXmlDocument*)Unsafe.AsPointer(ref this), tagName, newElement);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateDocumentFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateDocumentFragment([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocumentFragment **")] IXmlDocumentFragment** newDocumentFragment)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, IXmlDocumentFragment**, int>)(lpVtbl[10]))((IXmlDocument*)Unsafe.AsPointer(ref this), newDocumentFragment);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateTextNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateTextNode(HSTRING data, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlText **")] IXmlText** newTextNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, IXmlText**, int>)(lpVtbl[11]))((IXmlDocument*)Unsafe.AsPointer(ref this), data, newTextNode);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateComment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateComment(HSTRING data, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlComment **")] IXmlComment** newComment)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, IXmlComment**, int>)(lpVtbl[12]))((IXmlDocument*)Unsafe.AsPointer(ref this), data, newComment);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateProcessingInstruction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateProcessingInstruction(HSTRING target, HSTRING data, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlProcessingInstruction **")] IXmlProcessingInstruction** newProcessingInstruction)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, HSTRING, IXmlProcessingInstruction**, int>)(lpVtbl[13]))((IXmlDocument*)Unsafe.AsPointer(ref this), target, data, newProcessingInstruction);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateAttribute(HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** newAttribute)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, IXmlAttribute**, int>)(lpVtbl[14]))((IXmlDocument*)Unsafe.AsPointer(ref this), name, newAttribute);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateEntityReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateEntityReference(HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlEntityReference **")] IXmlEntityReference** newEntityReference)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, IXmlEntityReference**, int>)(lpVtbl[15]))((IXmlDocument*)Unsafe.AsPointer(ref this), name, newEntityReference);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.GetElementsByTagName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetElementsByTagName(HSTRING tagName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList** elements)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, IXmlNodeList**, int>)(lpVtbl[16]))((IXmlDocument*)Unsafe.AsPointer(ref this), tagName, elements);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateCDataSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateCDataSection(HSTRING data, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlCDataSection **")] IXmlCDataSection** newCDataSection)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, IXmlCDataSection**, int>)(lpVtbl[17]))((IXmlDocument*)Unsafe.AsPointer(ref this), data, newCDataSection);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.get_DocumentUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DocumentUri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING*, int>)(lpVtbl[18]))((IXmlDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateAttributeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateAttributeNS(IInspectable* namespaceUri, HSTRING qualifiedName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** newAttribute)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, IInspectable*, HSTRING, IXmlAttribute**, int>)(lpVtbl[19]))((IXmlDocument*)Unsafe.AsPointer(ref this), namespaceUri, qualifiedName, newAttribute);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.CreateElementNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateElementNS(IInspectable* namespaceUri, HSTRING qualifiedName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement** newElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, IInspectable*, HSTRING, IXmlElement**, int>)(lpVtbl[20]))((IXmlDocument*)Unsafe.AsPointer(ref this), namespaceUri, qualifiedName, newElement);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.GetElementById"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetElementById(HSTRING elementId, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement** element)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, HSTRING, IXmlElement**, int>)(lpVtbl[21]))((IXmlDocument*)Unsafe.AsPointer(ref this), elementId, element);
    }

    /// <include file='IXmlDocument.xml' path='doc/member[@name="IXmlDocument.ImportNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ImportNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode* node, [NativeTypeName("boolean")] byte deep, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** newNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlDocument*, IXmlNode*, byte, IXmlNode**, int>)(lpVtbl[22]))((IXmlDocument*)Unsafe.AsPointer(ref this), node, deep, newNode);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Doctype([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocumentType **")] IXmlDocumentType** value);

        [VtblIndex(7)]
        HRESULT get_Implementation([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDomImplementation **")] IXmlDomImplementation** value);

        [VtblIndex(8)]
        HRESULT get_DocumentElement([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement** value);

        [VtblIndex(9)]
        HRESULT CreateElement(HSTRING tagName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement** newElement);

        [VtblIndex(10)]
        HRESULT CreateDocumentFragment([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocumentFragment **")] IXmlDocumentFragment** newDocumentFragment);

        [VtblIndex(11)]
        HRESULT CreateTextNode(HSTRING data, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlText **")] IXmlText** newTextNode);

        [VtblIndex(12)]
        HRESULT CreateComment(HSTRING data, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlComment **")] IXmlComment** newComment);

        [VtblIndex(13)]
        HRESULT CreateProcessingInstruction(HSTRING target, HSTRING data, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlProcessingInstruction **")] IXmlProcessingInstruction** newProcessingInstruction);

        [VtblIndex(14)]
        HRESULT CreateAttribute(HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** newAttribute);

        [VtblIndex(15)]
        HRESULT CreateEntityReference(HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlEntityReference **")] IXmlEntityReference** newEntityReference);

        [VtblIndex(16)]
        HRESULT GetElementsByTagName(HSTRING tagName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList** elements);

        [VtblIndex(17)]
        HRESULT CreateCDataSection(HSTRING data, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlCDataSection **")] IXmlCDataSection** newCDataSection);

        [VtblIndex(18)]
        HRESULT get_DocumentUri(HSTRING* value);

        [VtblIndex(19)]
        HRESULT CreateAttributeNS(IInspectable* namespaceUri, HSTRING qualifiedName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")] IXmlAttribute** newAttribute);

        [VtblIndex(20)]
        HRESULT CreateElementNS(IInspectable* namespaceUri, HSTRING qualifiedName, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement** newElement);

        [VtblIndex(21)]
        HRESULT GetElementById(HSTRING elementId, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement** element);

        [VtblIndex(22)]
        HRESULT ImportNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode* node, [NativeTypeName("boolean")] byte deep, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** newNode);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocumentType **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDocumentType**, int> get_Doctype;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDomImplementation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDomImplementation**, int> get_Implementation;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlElement**, int> get_DocumentElement;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlElement**, int> CreateElement;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocumentFragment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlDocumentFragment**, int> CreateDocumentFragment;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlText **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlText**, int> CreateTextNode;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlComment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlComment**, int> CreateComment;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlProcessingInstruction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IXmlProcessingInstruction**, int> CreateProcessingInstruction;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlAttribute**, int> CreateAttribute;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlEntityReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlEntityReference**, int> CreateEntityReference;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlNodeList**, int> GetElementsByTagName;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlCDataSection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlCDataSection**, int> CreateCDataSection;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DocumentUri;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, HSTRING, IXmlAttribute**, int> CreateAttributeNS;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, HSTRING, IXmlElement**, int> CreateElementNS;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlElement**, int> GetElementById;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, boolean, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlNode*, byte, IXmlNode**, int> ImportNode;
    }
}
