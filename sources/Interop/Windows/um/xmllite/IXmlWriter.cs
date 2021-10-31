// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7279FC88-709D-4095-B63D-69FE4B0D9030")]
    [NativeTypeName("struct IXmlWriter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IXmlWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXmlWriter*, Guid*, void**, int>)(lpVtbl[0]))((IXmlWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXmlWriter*, uint>)(lpVtbl[1]))((IXmlWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXmlWriter*, uint>)(lpVtbl[2]))((IXmlWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutput(IUnknown* pOutput)
        {
            return ((delegate* unmanaged<IXmlWriter*, IUnknown*, int>)(lpVtbl[3]))((IXmlWriter*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("UINT")] uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue)
        {
            return ((delegate* unmanaged<IXmlWriter*, uint, nint*, int>)(lpVtbl[4]))((IXmlWriter*)Unsafe.AsPointer(ref this), nProperty, ppValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperty([NativeTypeName("UINT")] uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue)
        {
            return ((delegate* unmanaged<IXmlWriter*, uint, nint, int>)(lpVtbl[5]))((IXmlWriter*)Unsafe.AsPointer(ref this), nProperty, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int WriteAttributes(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
        {
            return ((delegate* unmanaged<IXmlWriter*, IXmlReader*, BOOL, int>)(lpVtbl[6]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int WriteAttributeString([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] ushort* pwszValue)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, ushort*, ushort*, int>)(lpVtbl[7]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri, pwszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int WriteCData([NativeTypeName("LPCWSTR")] ushort* pwszText)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, int>)(lpVtbl[8]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int WriteCharEntity([NativeTypeName("WCHAR")] ushort wch)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort, int>)(lpVtbl[9]))((IXmlWriter*)Unsafe.AsPointer(ref this), wch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int WriteChars([NativeTypeName("const WCHAR *")] ushort* pwch, [NativeTypeName("UINT")] uint cwch)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, uint, int>)(lpVtbl[10]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwch, cwch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int WriteComment([NativeTypeName("LPCWSTR")] ushort* pwszComment)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, int>)(lpVtbl[11]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszComment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int WriteDocType([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszPublicId, [NativeTypeName("LPCWSTR")] ushort* pwszSystemId, [NativeTypeName("LPCWSTR")] ushort* pwszSubset)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, ushort*, ushort*, int>)(lpVtbl[12]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName, pwszPublicId, pwszSystemId, pwszSubset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int WriteElementString([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] ushort* pwszValue)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, ushort*, ushort*, int>)(lpVtbl[13]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri, pwszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int WriteEndDocument()
        {
            return ((delegate* unmanaged<IXmlWriter*, int>)(lpVtbl[14]))((IXmlWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int WriteEndElement()
        {
            return ((delegate* unmanaged<IXmlWriter*, int>)(lpVtbl[15]))((IXmlWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int WriteEntityRef([NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, int>)(lpVtbl[16]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int WriteFullEndElement()
        {
            return ((delegate* unmanaged<IXmlWriter*, int>)(lpVtbl[17]))((IXmlWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int WriteName([NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, int>)(lpVtbl[18]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNmToken([NativeTypeName("LPCWSTR")] ushort* pwszNmToken)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, int>)(lpVtbl[19]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszNmToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNode(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
        {
            return ((delegate* unmanaged<IXmlWriter*, IXmlReader*, BOOL, int>)(lpVtbl[20]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNodeShallow(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
        {
            return ((delegate* unmanaged<IXmlWriter*, IXmlReader*, BOOL, int>)(lpVtbl[21]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int WriteProcessingInstruction([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszText)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, int>)(lpVtbl[22]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName, pwszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int WriteQualifiedName([NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, int>)(lpVtbl[23]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszLocalName, pwszNamespaceUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int WriteRaw([NativeTypeName("LPCWSTR")] ushort* pwszData)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, int>)(lpVtbl[24]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int WriteRawChars([NativeTypeName("const WCHAR *")] ushort* pwch, [NativeTypeName("UINT")] uint cwch)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, uint, int>)(lpVtbl[25]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwch, cwch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int WriteStartDocument(XmlStandalone standalone)
        {
            return ((delegate* unmanaged<IXmlWriter*, XmlStandalone, int>)(lpVtbl[26]))((IXmlWriter*)Unsafe.AsPointer(ref this), standalone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int WriteStartElement([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, ushort*, int>)(lpVtbl[27]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int WriteString([NativeTypeName("LPCWSTR")] ushort* pwszText)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, int>)(lpVtbl[28]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int WriteSurrogateCharEntity([NativeTypeName("WCHAR")] ushort wchLow, [NativeTypeName("WCHAR")] ushort wchHigh)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort, ushort, int>)(lpVtbl[29]))((IXmlWriter*)Unsafe.AsPointer(ref this), wchLow, wchHigh);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int WriteWhitespace([NativeTypeName("LPCWSTR")] ushort* pwszWhitespace)
        {
            return ((delegate* unmanaged<IXmlWriter*, ushort*, int>)(lpVtbl[30]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszWhitespace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* unmanaged<IXmlWriter*, int>)(lpVtbl[31]))((IXmlWriter*)Unsafe.AsPointer(ref this));
        }
    }
}
