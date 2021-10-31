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
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, uint*, int>)(lpVtbl[3]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Script(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IDispatch**, int>)(lpVtbl[7]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_all(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[8]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_body(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElement**, int>)(lpVtbl[9]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_activeElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElement**, int>)(lpVtbl[10]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_images(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[11]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_applets(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[12]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_links(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[13]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_forms(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[14]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_anchors(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[15]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_title([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[16]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_title([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[17]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_scripts(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[18]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_designMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[19]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_designMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[20]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_selection(IHTMLSelectionObject** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLSelectionObject**, int>)(lpVtbl[21]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[22]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_frames(IHTMLFramesCollection2** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLFramesCollection2**, int>)(lpVtbl[23]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_embeds(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[24]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_plugins(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLElementCollection**, int>)(lpVtbl[25]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_alinkColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[26]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_alinkColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[27]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[28]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[29]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT put_fgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[30]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_fgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[31]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT put_linkColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[32]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_linkColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[33]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT put_vlinkColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[34]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_vlinkColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[35]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_referrer([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[36]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_location(IHTMLLocation** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLLocation**, int>)(lpVtbl[37]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_lastModified([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[38]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT put_URL([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[39]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[40]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT put_domain([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[41]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_domain([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[42]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT put_cookie([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[43]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_cookie([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[44]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT put_expando([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, short, int>)(lpVtbl[45]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_expando([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, short*, int>)(lpVtbl[46]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT put_charset([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[47]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_charset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[48]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT put_defaultCharset([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int>)(lpVtbl[49]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_defaultCharset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[50]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[51]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[52]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_fileCreatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[53]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[54]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[55]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT get_security([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[56]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[57]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT get_nameProp([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[58]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT write(SAFEARRAY* psarray)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, SAFEARRAY*, int>)(lpVtbl[59]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), psarray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT writeln(SAFEARRAY* psarray)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, SAFEARRAY*, int>)(lpVtbl[60]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), psarray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT open([NativeTypeName("BSTR")] ushort* url, VARIANT name, VARIANT features, VARIANT replace, IDispatch** pomWindowResult)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, VARIANT, VARIANT, VARIANT, IDispatch**, int>)(lpVtbl[61]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), url, name, features, replace, pomWindowResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT close()
        {
            return ((delegate* unmanaged<IHTMLDocument2*, int>)(lpVtbl[62]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT clear()
        {
            return ((delegate* unmanaged<IHTMLDocument2*, int>)(lpVtbl[63]))((IHTMLDocument2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT queryCommandSupported([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[64]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT queryCommandEnabled([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[65]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT queryCommandState([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[66]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[67]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT queryCommandText([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("BSTR *")] ushort** pcmdText)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, ushort**, int>)(lpVtbl[68]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pcmdText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, VARIANT*, int>)(lpVtbl[69]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pcmdValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT execCommand([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short, VARIANT, short*, int>)(lpVtbl[70]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, showUI, value, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT execCommandShowHelp([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, short*, int>)(lpVtbl[71]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT createElement([NativeTypeName("BSTR")] ushort* eTag, IHTMLElement** newElem)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, IHTMLElement**, int>)(lpVtbl[72]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), eTag, newElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT put_onhelp(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[73]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT get_onhelp(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[74]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT put_onclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[75]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT get_onclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[76]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT put_ondblclick(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[77]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT get_ondblclick(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[78]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT put_onkeyup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[79]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT get_onkeyup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[80]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT put_onkeydown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[81]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT get_onkeydown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[82]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT put_onkeypress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[83]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT get_onkeypress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[84]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT put_onmouseup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[85]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT get_onmouseup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[86]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT put_onmousedown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[87]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT get_onmousedown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[88]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT put_onmousemove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[89]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT get_onmousemove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[90]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HRESULT put_onmouseout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[91]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public HRESULT get_onmouseout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[92]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HRESULT put_onmouseover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[93]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public HRESULT get_onmouseover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[94]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HRESULT put_onreadystatechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[95]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public HRESULT get_onreadystatechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[96]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public HRESULT put_onafterupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[97]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        public HRESULT get_onafterupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[98]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        public HRESULT put_onrowexit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[99]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        public HRESULT get_onrowexit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[100]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        public HRESULT put_onrowenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[101]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        public HRESULT get_onrowenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[102]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        public HRESULT put_ondragstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[103]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        public HRESULT get_ondragstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[104]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        public HRESULT put_onselectstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[105]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        public HRESULT get_onselectstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[106]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        public HRESULT elementFromPoint([NativeTypeName("long")] int x, [NativeTypeName("long")] int y, IHTMLElement** elementHit)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, int, int, IHTMLElement**, int>)(lpVtbl[107]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), x, y, elementHit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        public HRESULT get_parentWindow(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLWindow2**, int>)(lpVtbl[108]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        public HRESULT get_styleSheets(IHTMLStyleSheetsCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, IHTMLStyleSheetsCollection**, int>)(lpVtbl[109]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        public HRESULT put_onbeforeupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[110]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        public HRESULT get_onbeforeupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[111]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        public HRESULT put_onerrorupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT, int>)(lpVtbl[112]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        public HRESULT get_onerrorupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, VARIANT*, int>)(lpVtbl[113]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort**, int>)(lpVtbl[114]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), String);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        public HRESULT createStyleSheet([NativeTypeName("BSTR")] ushort* bstrHref, [NativeTypeName("long")] int lIndex, IHTMLStyleSheet** ppnewStyleSheet)
        {
            return ((delegate* unmanaged<IHTMLDocument2*, ushort*, int, IHTMLStyleSheet**, int>)(lpVtbl[115]))((IHTMLDocument2*)Unsafe.AsPointer(ref this), bstrHref, lIndex, ppnewStyleSheet);
        }
    }
}
