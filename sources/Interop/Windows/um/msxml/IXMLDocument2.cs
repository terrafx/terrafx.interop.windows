// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2B8DE2FE-8D2D-11D1-B2FC-00C04FD915A9")]
    [NativeTypeName("struct IXMLDocument2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IXMLDocument2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDocument2*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDocument2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDocument2*, uint>)(lpVtbl[1]))((IXMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDocument2*, uint>)(lpVtbl[2]))((IXMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDocument2*, uint*, int>)(lpVtbl[3]))((IXMLDocument2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDocument2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDocument2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDocument2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDocument2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDocument2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDocument2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_root(IXMLElement2** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, IXMLElement2**, int>)(lpVtbl[7]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[8]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[9]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[10]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[11]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_URL([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort*, int>)(lpVtbl[12]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[13]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_readyState([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IXMLDocument2*, int*, int>)(lpVtbl[14]))((IXMLDocument2*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[15]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_charset([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort*, int>)(lpVtbl[16]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_version([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[17]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_doctype([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[18]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_dtdURL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[19]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT createElement(VARIANT vType, VARIANT var1, IXMLElement2** ppElem)
        {
            return ((delegate* unmanaged<IXMLDocument2*, VARIANT, VARIANT, IXMLElement2**, int>)(lpVtbl[20]))((IXMLDocument2*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_async([NativeTypeName("VARIANT_BOOL *")] short* pf)
        {
            return ((delegate* unmanaged<IXMLDocument2*, short*, int>)(lpVtbl[21]))((IXMLDocument2*)Unsafe.AsPointer(ref this), pf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_async([NativeTypeName("VARIANT_BOOL")] short f)
        {
            return ((delegate* unmanaged<IXMLDocument2*, short, int>)(lpVtbl[22]))((IXMLDocument2*)Unsafe.AsPointer(ref this), f);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IXMLElement2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, IXMLElement2**, int> get_root;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_fileSize;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_fileModifiedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_fileUpdatedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_URL;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort*, int> put_URL;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_mimeType;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, int*, int> get_readyState;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_charset;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort*, int> put_charset;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_version;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_doctype;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, ushort**, int> get_dtdURL;

            [NativeTypeName("HRESULT (VARIANT, VARIANT, IXMLElement2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, VARIANT, VARIANT, IXMLElement2**, int> createElement;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, short*, int> get_async;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDocument2*, short, int> put_async;
        }
    }
}
