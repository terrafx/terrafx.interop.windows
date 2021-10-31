// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7279FC81-709D-4095-B63D-69FE4B0D9030")]
    [NativeTypeName("struct IXmlReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IXmlReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXmlReader*, Guid*, void**, int>)(lpVtbl[0]))((IXmlReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXmlReader*, uint>)(lpVtbl[1]))((IXmlReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXmlReader*, uint>)(lpVtbl[2]))((IXmlReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput(IUnknown* pInput)
        {
            return ((delegate* unmanaged<IXmlReader*, IUnknown*, int>)(lpVtbl[3]))((IXmlReader*)Unsafe.AsPointer(ref this), pInput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetProperty([NativeTypeName("UINT")] uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue)
        {
            return ((delegate* unmanaged<IXmlReader*, uint, nint*, int>)(lpVtbl[4]))((IXmlReader*)Unsafe.AsPointer(ref this), nProperty, ppValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetProperty([NativeTypeName("UINT")] uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue)
        {
            return ((delegate* unmanaged<IXmlReader*, uint, nint, int>)(lpVtbl[5]))((IXmlReader*)Unsafe.AsPointer(ref this), nProperty, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Read(XmlNodeType* pNodeType)
        {
            return ((delegate* unmanaged<IXmlReader*, XmlNodeType*, int>)(lpVtbl[6]))((IXmlReader*)Unsafe.AsPointer(ref this), pNodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetNodeType(XmlNodeType* pNodeType)
        {
            return ((delegate* unmanaged<IXmlReader*, XmlNodeType*, int>)(lpVtbl[7]))((IXmlReader*)Unsafe.AsPointer(ref this), pNodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MoveToFirstAttribute()
        {
            return ((delegate* unmanaged<IXmlReader*, int>)(lpVtbl[8]))((IXmlReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT MoveToNextAttribute()
        {
            return ((delegate* unmanaged<IXmlReader*, int>)(lpVtbl[9]))((IXmlReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT MoveToAttributeByName([NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri)
        {
            return ((delegate* unmanaged<IXmlReader*, ushort*, ushort*, int>)(lpVtbl[10]))((IXmlReader*)Unsafe.AsPointer(ref this), pwszLocalName, pwszNamespaceUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT MoveToElement()
        {
            return ((delegate* unmanaged<IXmlReader*, int>)(lpVtbl[11]))((IXmlReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetQualifiedName([NativeTypeName("LPCWSTR *")] ushort** ppwszQualifiedName, [NativeTypeName("UINT *")] uint* pcwchQualifiedName)
        {
            return ((delegate* unmanaged<IXmlReader*, ushort**, uint*, int>)(lpVtbl[12]))((IXmlReader*)Unsafe.AsPointer(ref this), ppwszQualifiedName, pcwchQualifiedName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetNamespaceUri([NativeTypeName("LPCWSTR *")] ushort** ppwszNamespaceUri, [NativeTypeName("UINT *")] uint* pcwchNamespaceUri)
        {
            return ((delegate* unmanaged<IXmlReader*, ushort**, uint*, int>)(lpVtbl[13]))((IXmlReader*)Unsafe.AsPointer(ref this), ppwszNamespaceUri, pcwchNamespaceUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetLocalName([NativeTypeName("LPCWSTR *")] ushort** ppwszLocalName, [NativeTypeName("UINT *")] uint* pcwchLocalName)
        {
            return ((delegate* unmanaged<IXmlReader*, ushort**, uint*, int>)(lpVtbl[14]))((IXmlReader*)Unsafe.AsPointer(ref this), ppwszLocalName, pcwchLocalName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetPrefix([NativeTypeName("LPCWSTR *")] ushort** ppwszPrefix, [NativeTypeName("UINT *")] uint* pcwchPrefix)
        {
            return ((delegate* unmanaged<IXmlReader*, ushort**, uint*, int>)(lpVtbl[15]))((IXmlReader*)Unsafe.AsPointer(ref this), ppwszPrefix, pcwchPrefix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetValue([NativeTypeName("LPCWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT *")] uint* pcwchValue)
        {
            return ((delegate* unmanaged<IXmlReader*, ushort**, uint*, int>)(lpVtbl[16]))((IXmlReader*)Unsafe.AsPointer(ref this), ppwszValue, pcwchValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT ReadValueChunk([NativeTypeName("WCHAR *")] ushort* pwchBuffer, [NativeTypeName("UINT")] uint cwchChunkSize, [NativeTypeName("UINT *")] uint* pcwchRead)
        {
            return ((delegate* unmanaged<IXmlReader*, ushort*, uint, uint*, int>)(lpVtbl[17]))((IXmlReader*)Unsafe.AsPointer(ref this), pwchBuffer, cwchChunkSize, pcwchRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetBaseUri([NativeTypeName("LPCWSTR *")] ushort** ppwszBaseUri, [NativeTypeName("UINT *")] uint* pcwchBaseUri)
        {
            return ((delegate* unmanaged<IXmlReader*, ushort**, uint*, int>)(lpVtbl[18]))((IXmlReader*)Unsafe.AsPointer(ref this), ppwszBaseUri, pcwchBaseUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public BOOL IsDefault()
        {
            return ((delegate* unmanaged<IXmlReader*, int>)(lpVtbl[19]))((IXmlReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public BOOL IsEmptyElement()
        {
            return ((delegate* unmanaged<IXmlReader*, int>)(lpVtbl[20]))((IXmlReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetLineNumber([NativeTypeName("UINT *")] uint* pnLineNumber)
        {
            return ((delegate* unmanaged<IXmlReader*, uint*, int>)(lpVtbl[21]))((IXmlReader*)Unsafe.AsPointer(ref this), pnLineNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetLinePosition([NativeTypeName("UINT *")] uint* pnLinePosition)
        {
            return ((delegate* unmanaged<IXmlReader*, uint*, int>)(lpVtbl[22]))((IXmlReader*)Unsafe.AsPointer(ref this), pnLinePosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetAttributeCount([NativeTypeName("UINT *")] uint* pnAttributeCount)
        {
            return ((delegate* unmanaged<IXmlReader*, uint*, int>)(lpVtbl[23]))((IXmlReader*)Unsafe.AsPointer(ref this), pnAttributeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetDepth([NativeTypeName("UINT *")] uint* pnDepth)
        {
            return ((delegate* unmanaged<IXmlReader*, uint*, int>)(lpVtbl[24]))((IXmlReader*)Unsafe.AsPointer(ref this), pnDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public BOOL IsEOF()
        {
            return ((delegate* unmanaged<IXmlReader*, int>)(lpVtbl[25]))((IXmlReader*)Unsafe.AsPointer(ref this));
        }
    }
}
