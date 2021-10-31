// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("332C4427-26CB-11D0-B483-00C04FD90119")]
    [NativeTypeName("struct IHTMLWindow2 : IHTMLFramesCollection2")]
    [NativeInheritance("IHTMLFramesCollection2")]
    public unsafe partial struct IHTMLWindow2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLWindow2*, uint>)(lpVtbl[1]))((IHTMLWindow2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLWindow2*, uint>)(lpVtbl[2]))((IHTMLWindow2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, uint*, int>)(lpVtbl[3]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT item(VARIANT* pvarIndex, VARIANT* pvarResult)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, VARIANT*, int>)(lpVtbl[7]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), pvarIndex, pvarResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int*, int>)(lpVtbl[8]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_frames(IHTMLFramesCollection2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLFramesCollection2**, int>)(lpVtbl[9]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_defaultStatus([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[10]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_defaultStatus([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort**, int>)(lpVtbl[11]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_status([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[12]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_status([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort**, int>)(lpVtbl[13]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT setTimeout([NativeTypeName("BSTR")] ushort* expression, [NativeTypeName("long")] int msec, VARIANT* language, [NativeTypeName("long *")] int* timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int, VARIANT*, int*, int>)(lpVtbl[14]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), expression, msec, language, timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT clearTimeout([NativeTypeName("long")] int timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int>)(lpVtbl[15]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT alert([NativeTypeName("BSTR")] ushort* message = null)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[16]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), message);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT confirm([NativeTypeName("BSTR")] ushort* message, [NativeTypeName("VARIANT_BOOL *")] short* confirmed)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, short*, int>)(lpVtbl[17]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), message, confirmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT prompt([NativeTypeName("BSTR")] ushort* message, [NativeTypeName("BSTR")] ushort* defstr, VARIANT* textdata)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[18]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), message, defstr, textdata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_Image(IHTMLImageElementFactory** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLImageElementFactory**, int>)(lpVtbl[19]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_location(IHTMLLocation** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLLocation**, int>)(lpVtbl[20]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_history(IOmHistory** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IOmHistory**, int>)(lpVtbl[21]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT close()
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int>)(lpVtbl[22]))((IHTMLWindow2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_opener(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[23]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_opener(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[24]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_navigator(IOmNavigator** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IOmNavigator**, int>)(lpVtbl[25]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[26]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort**, int>)(lpVtbl[27]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_parent(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLWindow2**, int>)(lpVtbl[28]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT open([NativeTypeName("BSTR")] ushort* url, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* features, [NativeTypeName("VARIANT_BOOL")] short replace, IHTMLWindow2** pomWindowResult)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, ushort*, ushort*, short, IHTMLWindow2**, int>)(lpVtbl[29]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), url, name, features, replace, pomWindowResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_self(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLWindow2**, int>)(lpVtbl[30]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_top(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLWindow2**, int>)(lpVtbl[31]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_window(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLWindow2**, int>)(lpVtbl[32]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT navigate([NativeTypeName("BSTR")] ushort* url)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[33]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), url);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT put_onfocus(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[34]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_onfocus(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[35]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_onblur(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[36]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_onblur(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[37]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[38]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[39]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT put_onbeforeunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[40]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_onbeforeunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[41]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT put_onunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[42]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_onunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[43]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT put_onhelp(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[44]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_onhelp(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[45]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[46]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[47]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT put_onresize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[48]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT get_onresize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[49]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT put_onscroll(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[50]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT get_onscroll(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[51]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_document(IHTMLDocument2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLDocument2**, int>)(lpVtbl[52]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_event(IHTMLEventObj** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLEventObj**, int>)(lpVtbl[53]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get__newEnum(IUnknown** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IUnknown**, int>)(lpVtbl[54]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT showModalDialog([NativeTypeName("BSTR")] ushort* dialog, VARIANT* varArgIn, VARIANT* varOptions, VARIANT* varArgOut)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[55]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), dialog, varArgIn, varOptions, varArgOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT showHelp([NativeTypeName("BSTR")] ushort* helpURL, VARIANT helpArg, [NativeTypeName("BSTR")] ushort* features = null)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, VARIANT, ushort*, int>)(lpVtbl[56]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), helpURL, helpArg, features);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT get_screen(IHTMLScreen** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLScreen**, int>)(lpVtbl[57]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT get_Option(IHTMLOptionElementFactory** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLOptionElementFactory**, int>)(lpVtbl[58]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT focus()
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int>)(lpVtbl[59]))((IHTMLWindow2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT get_closed([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, short*, int>)(lpVtbl[60]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT blur()
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int>)(lpVtbl[61]))((IHTMLWindow2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT scroll([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[62]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT get_clientInformation(IOmNavigator** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IOmNavigator**, int>)(lpVtbl[63]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT setInterval([NativeTypeName("BSTR")] ushort* expression, [NativeTypeName("long")] int msec, VARIANT* language, [NativeTypeName("long *")] int* timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int, VARIANT*, int*, int>)(lpVtbl[64]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), expression, msec, language, timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT clearInterval([NativeTypeName("long")] int timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int>)(lpVtbl[65]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT put_offscreenBuffering(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[66]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT get_offscreenBuffering(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[67]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT execScript([NativeTypeName("BSTR")] ushort* code, [NativeTypeName("BSTR")] ushort* language, VARIANT* pvarRet)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[68]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), code, language, pvarRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort**, int>)(lpVtbl[69]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), String);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT scrollBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[70]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT scrollTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[71]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT moveTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[72]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT moveBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[73]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT resizeTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[74]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT resizeBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[75]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT get_external(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IDispatch**, int>)(lpVtbl[76]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
