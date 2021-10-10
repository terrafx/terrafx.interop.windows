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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDocument2*, uint*, int>)(lpVtbl[3]))((IXMLDocument2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDocument2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDocument2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDocument2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDocument2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDocument2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDocument2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_root(IXMLElement2** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, IXMLElement2**, int>)(lpVtbl[7]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[8]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[9]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[10]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[11]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_URL([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort*, int>)(lpVtbl[12]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[13]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IXMLDocument2*, int*, int>)(lpVtbl[14]))((IXMLDocument2*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_charset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[15]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_charset([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort*, int>)(lpVtbl[16]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_version([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[17]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[18]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_dtdURL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IXMLDocument2*, ushort**, int>)(lpVtbl[19]))((IXMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int createElement(VARIANT vType, VARIANT var1, IXMLElement2** ppElem)
        {
            return ((delegate* unmanaged<IXMLDocument2*, VARIANT, VARIANT, IXMLElement2**, int>)(lpVtbl[20]))((IXMLDocument2*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_async([NativeTypeName("VARIANT_BOOL *")] short* pf)
        {
            return ((delegate* unmanaged<IXMLDocument2*, short*, int>)(lpVtbl[21]))((IXMLDocument2*)Unsafe.AsPointer(ref this), pf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_async([NativeTypeName("VARIANT_BOOL")] short f)
        {
            return ((delegate* unmanaged<IXMLDocument2*, short, int>)(lpVtbl[22]))((IXMLDocument2*)Unsafe.AsPointer(ref this), f);
        }
    }
}
