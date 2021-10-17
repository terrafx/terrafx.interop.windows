// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("332C4425-26CB-11D0-B483-00C04FD90119")]
    [NativeTypeName("struct IHTMLDocument2 : IHTMLDocument")]
    [NativeInheritance("IHTMLDocument")]
    public unsafe partial struct IHTMLDocument2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDocument2*, uint>)(lpVtbl[1]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDocument2*, uint>)(lpVtbl[2]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, uint*, int>)(lpVtbl[3]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Script(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IDispatch**, int>)(lpVtbl[7]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_all(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[8]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_body(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElement**, int>)(lpVtbl[9]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_activeElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElement**, int>)(lpVtbl[10]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_images(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[11]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_applets(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[12]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_links(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[13]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_forms(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[14]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_anchors(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[15]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_title([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[16]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_title([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[17]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_scripts(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[18]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_designMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[19]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_designMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[20]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_selection(IHTMLSelectionObject** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLSelectionObject**, int>)(lpVtbl[21]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[22]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_frames(IHTMLFramesCollection2** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLFramesCollection2**, int>)(lpVtbl[23]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_embeds(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[24]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_plugins(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[25]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_alinkColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[26]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_alinkColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[27]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[28]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[29]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_fgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[30]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_fgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[31]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_linkColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[32]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_linkColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[33]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_vlinkColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[34]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_vlinkColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[35]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_referrer([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[36]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_location(IHTMLLocation** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLLocation**, int>)(lpVtbl[37]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastModified([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[38]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_URL([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[39]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[40]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_domain([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[41]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_domain([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[42]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_cookie([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[43]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_cookie([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[44]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_expando([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, short, int>)(lpVtbl[45]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_expando([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, short*, int>)(lpVtbl[46]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int put_charset([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[47]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_charset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[48]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int put_defaultCharset([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[49]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_defaultCharset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[50]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[51]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[52]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileCreatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[53]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[54]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[55]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_security([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[56]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_protocol([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[57]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_nameProp([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[58]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int write(SAFEARRAY* psarray)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, SAFEARRAY*, int>)(lpVtbl[59]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), psarray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int writeln(SAFEARRAY* psarray)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, SAFEARRAY*, int>)(lpVtbl[60]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), psarray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int open([NativeTypeName("BSTR")] ushort* url, VARIANT name, VARIANT features, VARIANT replace, IDispatch** pomWindowResult)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, VARIANT, VARIANT, VARIANT, IDispatch**, int>)(lpVtbl[61]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), url, name, features, replace, pomWindowResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int close()
        {
            return ((delegate* unmanaged<IHTMLDocument2*, int>)(lpVtbl[62]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int clear()
        {
            return ((delegate* unmanaged<IHTMLDocument2*, int>)(lpVtbl[63]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int queryCommandSupported([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[64]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int queryCommandEnabled([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[65]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int queryCommandState([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[66]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int queryCommandIndeterm([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[67]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int queryCommandText([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("BSTR *")] ushort** pcmdText)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, ushort**, int>)(lpVtbl[68]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pcmdText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, VARIANT*, int>)(lpVtbl[69]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pcmdValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int execCommand([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short, VARIANT, short*, int>)(lpVtbl[70]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, showUI, value, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int execCommandShowHelp([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[71]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int createElement([NativeTypeName("BSTR")] ushort* eTag, IHTMLElement** newElem)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, IHTMLElement**, int>)(lpVtbl[72]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), eTag, newElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int put_onhelp(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[73]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_onhelp(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[74]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int put_onclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[75]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_onclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[76]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondblclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[77]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondblclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[78]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeyup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[79]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeyup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[80]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeydown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[81]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeydown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[82]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int put_onkeypress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[83]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int get_onkeypress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[84]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[85]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[86]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmousedown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[87]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmousedown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[88]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmousemove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[89]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmousemove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[90]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[91]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[92]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[93]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[94]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[95]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int get_onreadystatechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[96]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int put_onafterupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[97]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int get_onafterupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[98]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int put_onrowexit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[99]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int get_onrowexit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[100]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int put_onrowenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[101]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int get_onrowenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[102]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[103]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[104]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int put_onselectstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[105]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int get_onselectstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[106]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int elementFromPoint([NativeTypeName("long")] int x, [NativeTypeName("long")] int y, IHTMLElement** elementHit)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, int, int, IHTMLElement**, int>)(lpVtbl[107]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), x, y, elementHit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentWindow(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLWindow2**, int>)(lpVtbl[108]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int get_styleSheets(IHTMLStyleSheetsCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLStyleSheetsCollection**, int>)(lpVtbl[109]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[110]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[111]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerrorupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[112]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerrorupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[113]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int toString([NativeTypeName("BSTR *")] ushort** String)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[114]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), String);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        [return: NativeTypeName("HRESULT")]
        public int createStyleSheet([NativeTypeName("BSTR")] ushort* bstrHref, [NativeTypeName("long")] int lIndex, IHTMLStyleSheet** ppnewStyleSheet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int, IHTMLStyleSheet**, int>)(lpVtbl[115]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), bstrHref, lIndex, ppnewStyleSheet);
        }
    }
}
