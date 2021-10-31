// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F52E2B61-18A1-11D1-B105-00805F49916B")]
    [NativeTypeName("struct IXMLDocument : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDocument
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDocument*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDocument*, uint>)(lpVtbl[1]))((IXMLDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDocument*, uint>)(lpVtbl[2]))((IXMLDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDocument*, uint*, int>)(lpVtbl[3]))((IXMLDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDocument*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDocument*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDocument*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_root(IXMLElement** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, IXMLElement**, int>)(lpVtbl[7]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[8]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[9]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[10]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[11]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_URL([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort*, int>)(lpVtbl[12]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[13]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_readyState([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IXMLDocument*, int*, int>)(lpVtbl[14]))((IXMLDocument*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[15]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_charset([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort*, int>)(lpVtbl[16]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_version([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[17]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_doctype([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[18]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_dtdURL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument*, ushort**, int>)(lpVtbl[19]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT createElement(VARIANT vType, VARIANT var1, IXMLElement** ppElem)
        {
            return ((delegate* unmanaged<IXMLDocument*, VARIANT, VARIANT, IXMLElement**, int>)(lpVtbl[20]))((IXMLDocument*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
        }
    }
}
