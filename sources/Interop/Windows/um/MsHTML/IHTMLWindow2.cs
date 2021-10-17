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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, uint*, int>)(lpVtbl[3]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int item(VARIANT* pvarIndex, VARIANT* pvarResult)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, VARIANT*, int>)(lpVtbl[7]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), pvarIndex, pvarResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int*, int>)(lpVtbl[8]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_frames(IHTMLFramesCollection2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLFramesCollection2**, int>)(lpVtbl[9]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_defaultStatus([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[10]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_defaultStatus([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort**, int>)(lpVtbl[11]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_status([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[12]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_status([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort**, int>)(lpVtbl[13]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int setTimeout([NativeTypeName("BSTR")] ushort* expression, [NativeTypeName("long")] int msec, VARIANT* language, [NativeTypeName("long *")] int* timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int, VARIANT*, int*, int>)(lpVtbl[14]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), expression, msec, language, timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int clearTimeout([NativeTypeName("long")] int timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int>)(lpVtbl[15]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int alert([NativeTypeName("BSTR")] ushort* message = null)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[16]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), message);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int confirm([NativeTypeName("BSTR")] ushort* message, [NativeTypeName("VARIANT_BOOL *")] short* confirmed)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, short*, int>)(lpVtbl[17]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), message, confirmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int prompt([NativeTypeName("BSTR")] ushort* message, [NativeTypeName("BSTR")] ushort* defstr, VARIANT* textdata)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[18]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), message, defstr, textdata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_Image(IHTMLImageElementFactory** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLImageElementFactory**, int>)(lpVtbl[19]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_location(IHTMLLocation** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLLocation**, int>)(lpVtbl[20]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_history(IOmHistory** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IOmHistory**, int>)(lpVtbl[21]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int close()
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int>)(lpVtbl[22]))((IHTMLWindow2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_opener(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[23]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_opener(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[24]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_navigator(IOmNavigator** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IOmNavigator**, int>)(lpVtbl[25]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[26]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort**, int>)(lpVtbl[27]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_parent(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLWindow2**, int>)(lpVtbl[28]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int open([NativeTypeName("BSTR")] ushort* url, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* features, [NativeTypeName("VARIANT_BOOL")] short replace, IHTMLWindow2** pomWindowResult)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, ushort*, ushort*, short, IHTMLWindow2**, int>)(lpVtbl[29]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), url, name, features, replace, pomWindowResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_self(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLWindow2**, int>)(lpVtbl[30]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_top(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLWindow2**, int>)(lpVtbl[31]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_window(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLWindow2**, int>)(lpVtbl[32]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int navigate([NativeTypeName("BSTR")] ushort* url)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int>)(lpVtbl[33]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), url);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfocus(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[34]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfocus(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[35]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_onblur(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[36]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_onblur(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[37]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[38]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[39]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[40]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[41]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_onunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[42]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_onunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[43]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_onhelp(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[44]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_onhelp(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[45]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[46]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[47]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int put_onresize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[48]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_onresize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[49]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int put_onscroll(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[50]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_onscroll(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[51]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_document(IHTMLDocument2** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLDocument2**, int>)(lpVtbl[52]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_event(IHTMLEventObj** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLEventObj**, int>)(lpVtbl[53]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get__newEnum(IUnknown** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IUnknown**, int>)(lpVtbl[54]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int showModalDialog([NativeTypeName("BSTR")] ushort* dialog, VARIANT* varArgIn, VARIANT* varOptions, VARIANT* varArgOut)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[55]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), dialog, varArgIn, varOptions, varArgOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int showHelp([NativeTypeName("BSTR")] ushort* helpURL, VARIANT helpArg, [NativeTypeName("BSTR")] ushort* features = null)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, VARIANT, ushort*, int>)(lpVtbl[56]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), helpURL, helpArg, features);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_screen(IHTMLScreen** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLScreen**, int>)(lpVtbl[57]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_Option(IHTMLOptionElementFactory** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IHTMLOptionElementFactory**, int>)(lpVtbl[58]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int focus()
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int>)(lpVtbl[59]))((IHTMLWindow2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_closed([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, short*, int>)(lpVtbl[60]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int blur()
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int>)(lpVtbl[61]))((IHTMLWindow2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int scroll([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[62]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientInformation(IOmNavigator** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IOmNavigator**, int>)(lpVtbl[63]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int setInterval([NativeTypeName("BSTR")] ushort* expression, [NativeTypeName("long")] int msec, VARIANT* language, [NativeTypeName("long *")] int* timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, int, VARIANT*, int*, int>)(lpVtbl[64]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), expression, msec, language, timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int clearInterval([NativeTypeName("long")] int timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int>)(lpVtbl[65]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int put_offscreenBuffering(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT, int>)(lpVtbl[66]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_offscreenBuffering(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, VARIANT*, int>)(lpVtbl[67]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int execScript([NativeTypeName("BSTR")] ushort* code, [NativeTypeName("BSTR")] ushort* language, VARIANT* pvarRet)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[68]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), code, language, pvarRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int toString([NativeTypeName("BSTR *")] ushort** String)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, ushort**, int>)(lpVtbl[69]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), String);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int scrollBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[70]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int scrollTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[71]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int moveTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[72]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int moveBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[73]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int resizeTo([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[74]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int resizeBy([NativeTypeName("long")] int x, [NativeTypeName("long")] int y)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, int, int, int>)(lpVtbl[75]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_external(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLWindow2*, IDispatch**, int>)(lpVtbl[76]))((IHTMLWindow2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
