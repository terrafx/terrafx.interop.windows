// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter"]/*' />
[Guid("7279FC88-709D-4095-B63D-69FE4B0D9030")]
[NativeTypeName("struct IXmlWriter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXmlWriter : IXmlWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlWriter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, Guid*, void**, int>)(lpVtbl[0]))((IXmlWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, uint>)(lpVtbl[1]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, uint>)(lpVtbl[2]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.SetOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOutput(IUnknown* pOutput)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, IUnknown*, int>)(lpVtbl[3]))((IXmlWriter*)Unsafe.AsPointer(ref this), pOutput);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.GetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, uint, nint*, int>)(lpVtbl[4]))((IXmlWriter*)Unsafe.AsPointer(ref this), nProperty, ppValue);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.SetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, uint, nint, int>)(lpVtbl[5]))((IXmlWriter*)Unsafe.AsPointer(ref this), nProperty, pValue);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteAttributes(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, IXmlReader*, BOOL, int>)(lpVtbl[6]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteAttributeString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WriteAttributeString([NativeTypeName("LPCWSTR")] char* pwszPrefix, [NativeTypeName("LPCWSTR")] char* pwszLocalName, [NativeTypeName("LPCWSTR")] char* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] char* pwszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, char*, char*, char*, int>)(lpVtbl[7]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri, pwszValue);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteCData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteCData([NativeTypeName("LPCWSTR")] char* pwszText)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, int>)(lpVtbl[8]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszText);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteCharEntity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteCharEntity([NativeTypeName("WCHAR")] char wch)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char, int>)(lpVtbl[9]))((IXmlWriter*)Unsafe.AsPointer(ref this), wch);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteChars"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WriteChars([NativeTypeName("const WCHAR *")] char* pwch, uint cwch)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, uint, int>)(lpVtbl[10]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwch, cwch);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteComment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteComment([NativeTypeName("LPCWSTR")] char* pwszComment)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, int>)(lpVtbl[11]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszComment);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteDocType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteDocType([NativeTypeName("LPCWSTR")] char* pwszName, [NativeTypeName("LPCWSTR")] char* pwszPublicId, [NativeTypeName("LPCWSTR")] char* pwszSystemId, [NativeTypeName("LPCWSTR")] char* pwszSubset)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, char*, char*, char*, int>)(lpVtbl[12]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName, pwszPublicId, pwszSystemId, pwszSubset);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteElementString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT WriteElementString([NativeTypeName("LPCWSTR")] char* pwszPrefix, [NativeTypeName("LPCWSTR")] char* pwszLocalName, [NativeTypeName("LPCWSTR")] char* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] char* pwszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, char*, char*, char*, int>)(lpVtbl[13]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri, pwszValue);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteEndDocument"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteEndDocument()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, int>)(lpVtbl[14]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteEndElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteEndElement()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, int>)(lpVtbl[15]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteEntityRef"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT WriteEntityRef([NativeTypeName("LPCWSTR")] char* pwszName)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, int>)(lpVtbl[16]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteFullEndElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT WriteFullEndElement()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, int>)(lpVtbl[17]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT WriteName([NativeTypeName("LPCWSTR")] char* pwszName)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, int>)(lpVtbl[18]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteNmToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteNmToken([NativeTypeName("LPCWSTR")] char* pwszNmToken)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, int>)(lpVtbl[19]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszNmToken);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteNode(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, IXmlReader*, BOOL, int>)(lpVtbl[20]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteNodeShallow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT WriteNodeShallow(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, IXmlReader*, BOOL, int>)(lpVtbl[21]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteProcessingInstruction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT WriteProcessingInstruction([NativeTypeName("LPCWSTR")] char* pwszName, [NativeTypeName("LPCWSTR")] char* pwszText)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, char*, int>)(lpVtbl[22]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName, pwszText);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteQualifiedName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT WriteQualifiedName([NativeTypeName("LPCWSTR")] char* pwszLocalName, [NativeTypeName("LPCWSTR")] char* pwszNamespaceUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, char*, int>)(lpVtbl[23]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszLocalName, pwszNamespaceUri);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteRaw"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT WriteRaw([NativeTypeName("LPCWSTR")] char* pwszData)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, int>)(lpVtbl[24]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszData);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteRawChars"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT WriteRawChars([NativeTypeName("const WCHAR *")] char* pwch, uint cwch)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, uint, int>)(lpVtbl[25]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwch, cwch);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteStartDocument"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT WriteStartDocument(XmlStandalone standalone)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, XmlStandalone, int>)(lpVtbl[26]))((IXmlWriter*)Unsafe.AsPointer(ref this), standalone);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteStartElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT WriteStartElement([NativeTypeName("LPCWSTR")] char* pwszPrefix, [NativeTypeName("LPCWSTR")] char* pwszLocalName, [NativeTypeName("LPCWSTR")] char* pwszNamespaceUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, char*, char*, int>)(lpVtbl[27]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT WriteString([NativeTypeName("LPCWSTR")] char* pwszText)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, int>)(lpVtbl[28]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszText);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteSurrogateCharEntity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT WriteSurrogateCharEntity([NativeTypeName("WCHAR")] char wchLow, [NativeTypeName("WCHAR")] char wchHigh)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char, char, int>)(lpVtbl[29]))((IXmlWriter*)Unsafe.AsPointer(ref this), wchLow, wchHigh);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteWhitespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT WriteWhitespace([NativeTypeName("LPCWSTR")] char* pwszWhitespace)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, char*, int>)(lpVtbl[30]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszWhitespace);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.Flush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlWriter*, int>)(lpVtbl[31]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetOutput(IUnknown* pOutput);

        [VtblIndex(4)]
        HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue);

        [VtblIndex(5)]
        HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue);

        [VtblIndex(6)]
        HRESULT WriteAttributes(IXmlReader* pReader, BOOL fWriteDefaultAttributes);

        [VtblIndex(7)]
        HRESULT WriteAttributeString([NativeTypeName("LPCWSTR")] char* pwszPrefix, [NativeTypeName("LPCWSTR")] char* pwszLocalName, [NativeTypeName("LPCWSTR")] char* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] char* pwszValue);

        [VtblIndex(8)]
        HRESULT WriteCData([NativeTypeName("LPCWSTR")] char* pwszText);

        [VtblIndex(9)]
        HRESULT WriteCharEntity([NativeTypeName("WCHAR")] char wch);

        [VtblIndex(10)]
        HRESULT WriteChars([NativeTypeName("const WCHAR *")] char* pwch, uint cwch);

        [VtblIndex(11)]
        HRESULT WriteComment([NativeTypeName("LPCWSTR")] char* pwszComment);

        [VtblIndex(12)]
        HRESULT WriteDocType([NativeTypeName("LPCWSTR")] char* pwszName, [NativeTypeName("LPCWSTR")] char* pwszPublicId, [NativeTypeName("LPCWSTR")] char* pwszSystemId, [NativeTypeName("LPCWSTR")] char* pwszSubset);

        [VtblIndex(13)]
        HRESULT WriteElementString([NativeTypeName("LPCWSTR")] char* pwszPrefix, [NativeTypeName("LPCWSTR")] char* pwszLocalName, [NativeTypeName("LPCWSTR")] char* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] char* pwszValue);

        [VtblIndex(14)]
        HRESULT WriteEndDocument();

        [VtblIndex(15)]
        HRESULT WriteEndElement();

        [VtblIndex(16)]
        HRESULT WriteEntityRef([NativeTypeName("LPCWSTR")] char* pwszName);

        [VtblIndex(17)]
        HRESULT WriteFullEndElement();

        [VtblIndex(18)]
        HRESULT WriteName([NativeTypeName("LPCWSTR")] char* pwszName);

        [VtblIndex(19)]
        HRESULT WriteNmToken([NativeTypeName("LPCWSTR")] char* pwszNmToken);

        [VtblIndex(20)]
        HRESULT WriteNode(IXmlReader* pReader, BOOL fWriteDefaultAttributes);

        [VtblIndex(21)]
        HRESULT WriteNodeShallow(IXmlReader* pReader, BOOL fWriteDefaultAttributes);

        [VtblIndex(22)]
        HRESULT WriteProcessingInstruction([NativeTypeName("LPCWSTR")] char* pwszName, [NativeTypeName("LPCWSTR")] char* pwszText);

        [VtblIndex(23)]
        HRESULT WriteQualifiedName([NativeTypeName("LPCWSTR")] char* pwszLocalName, [NativeTypeName("LPCWSTR")] char* pwszNamespaceUri);

        [VtblIndex(24)]
        HRESULT WriteRaw([NativeTypeName("LPCWSTR")] char* pwszData);

        [VtblIndex(25)]
        HRESULT WriteRawChars([NativeTypeName("const WCHAR *")] char* pwch, uint cwch);

        [VtblIndex(26)]
        HRESULT WriteStartDocument(XmlStandalone standalone);

        [VtblIndex(27)]
        HRESULT WriteStartElement([NativeTypeName("LPCWSTR")] char* pwszPrefix, [NativeTypeName("LPCWSTR")] char* pwszLocalName, [NativeTypeName("LPCWSTR")] char* pwszNamespaceUri);

        [VtblIndex(28)]
        HRESULT WriteString([NativeTypeName("LPCWSTR")] char* pwszText);

        [VtblIndex(29)]
        HRESULT WriteSurrogateCharEntity([NativeTypeName("WCHAR")] char wchLow, [NativeTypeName("WCHAR")] char wchHigh);

        [VtblIndex(30)]
        HRESULT WriteWhitespace([NativeTypeName("LPCWSTR")] char* pwszWhitespace);

        [VtblIndex(31)]
        HRESULT Flush();
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, int> SetOutput;

        [NativeTypeName("HRESULT (UINT, LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint*, int> GetProperty;

        [NativeTypeName("HRESULT (UINT, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint, int> SetProperty;

        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlReader*, BOOL, int> WriteAttributes;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, char*, int> WriteAttributeString;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> WriteCData;

        [NativeTypeName("HRESULT (WCHAR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char, int> WriteCharEntity;

        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> WriteChars;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> WriteComment;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, char*, int> WriteDocType;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, char*, int> WriteElementString;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> WriteEndDocument;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> WriteEndElement;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> WriteEntityRef;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> WriteFullEndElement;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> WriteName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> WriteNmToken;

        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlReader*, BOOL, int> WriteNode;

        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlReader*, BOOL, int> WriteNodeShallow;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> WriteProcessingInstruction;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> WriteQualifiedName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> WriteRaw;

        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> WriteRawChars;

        [NativeTypeName("HRESULT (XmlStandalone) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, XmlStandalone, int> WriteStartDocument;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, int> WriteStartElement;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> WriteString;

        [NativeTypeName("HRESULT (WCHAR, WCHAR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char, char, int> WriteSurrogateCharEntity;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> WriteWhitespace;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Flush;
    }
}
