// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F1DA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLAnchorElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLAnchorElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, uint>)(lpVtbl[1]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, uint>)(lpVtbl[2]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, uint*, int>)(lpVtbl[3]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_href([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[7]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_href([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[8]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_target([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[9]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_target([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[10]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_rel([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[11]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_rel([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[12]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_rev([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[13]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_rev([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[14]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_urn([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[15]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_urn([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[16]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_Methods([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[17]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_Methods([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[18]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[19]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[20]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_host([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[21]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_host([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[22]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_hostname([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[23]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_hostname([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[24]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_pathname([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[25]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_pathname([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[26]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_port([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[27]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_port([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[28]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_protocol([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[29]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_protocol([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[30]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_search([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[31]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_search([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[32]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_hash([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[33]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_hash([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[34]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_onblur(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, VARIANT, int>)(lpVtbl[35]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_onblur(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, VARIANT*, int>)(lpVtbl[36]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfocus(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, VARIANT, int>)(lpVtbl[37]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfocus(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, VARIANT*, int>)(lpVtbl[38]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_accessKey([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort*, int>)(lpVtbl[39]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_accessKey([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[40]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_protocolLong([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[41]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[42]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_nameProp([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, ushort**, int>)(lpVtbl[43]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_tabIndex(short v)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, short, int>)(lpVtbl[44]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_tabIndex(short* p)
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, short*, int>)(lpVtbl[45]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int focus()
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, int>)(lpVtbl[46]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int blur()
        {
            return ((delegate* unmanaged<IHTMLAnchorElement*, int>)(lpVtbl[47]))((IHTMLAnchorElement*)Unsafe.AsPointer(ref this));
        }
    }
}
