// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F5D2-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLInputElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLInputElement : IHTMLInputElement.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLInputElement*, uint>)(lpVtbl[1]))((IHTMLInputElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLInputElement*, uint>)(lpVtbl[2]))((IHTMLInputElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, uint*, int>)(lpVtbl[3]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[7]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[8]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[9]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[10]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[11]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[12]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_status([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[13]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_status([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[14]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[15]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[16]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_form(IHTMLFormElement** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, IHTMLFormElement**, int>)(lpVtbl[17]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_size([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[18]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_size([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[19]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_maxLength([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[20]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_maxLength([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[21]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT select()
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int>)(lpVtbl[22]))((IHTMLInputElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_onchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_onchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_onselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_onselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_defaultValue([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[27]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_defaultValue([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[28]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_readOnly([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[29]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[30]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT createTextRange(IHTMLTxtRange** range)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, IHTMLTxtRange**, int>)(lpVtbl[31]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), range);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT put_indeterminate([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[32]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_indeterminate([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[33]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT put_defaultChecked([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[34]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_defaultChecked([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[35]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_checked([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[36]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_checked([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[37]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT put_border(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[38]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_border(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[39]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT put_vspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[40]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_vspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[41]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT put_hspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[42]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_hspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[43]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT put_alt([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[44]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[45]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[46]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[47]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT put_lowsrc([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[48]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT get_lowsrc([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[49]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT put_vrml([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[50]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT get_vrml([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[51]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT put_dynsrc([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[52]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_dynsrc([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[53]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[54]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT get_complete([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[55]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT put_loop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[56]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT get_loop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[57]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[58]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[59]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[60]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[61]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[62]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[63]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT put_onabort(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[64]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT get_onabort(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[65]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT put_width([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[66]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT get_width([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[67]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT put_height([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[68]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT get_height([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[69]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT put_start([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[70]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT get_start([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[71]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT put_type([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(8)]
            HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(9)]
            HRESULT put_value([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(10)]
            HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(11)]
            HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(12)]
            HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(13)]
            HRESULT put_status([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(14)]
            HRESULT get_status([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(15)]
            HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(16)]
            HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(17)]
            HRESULT get_form(IHTMLFormElement** p);

            [VtblIndex(18)]
            HRESULT put_size([NativeTypeName("long")] int v);

            [VtblIndex(19)]
            HRESULT get_size([NativeTypeName("long *")] int* p);

            [VtblIndex(20)]
            HRESULT put_maxLength([NativeTypeName("long")] int v);

            [VtblIndex(21)]
            HRESULT get_maxLength([NativeTypeName("long *")] int* p);

            [VtblIndex(22)]
            HRESULT select();

            [VtblIndex(23)]
            HRESULT put_onchange(VARIANT v);

            [VtblIndex(24)]
            HRESULT get_onchange(VARIANT* p);

            [VtblIndex(25)]
            HRESULT put_onselect(VARIANT v);

            [VtblIndex(26)]
            HRESULT get_onselect(VARIANT* p);

            [VtblIndex(27)]
            HRESULT put_defaultValue([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(28)]
            HRESULT get_defaultValue([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(29)]
            HRESULT put_readOnly([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(30)]
            HRESULT get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(31)]
            HRESULT createTextRange(IHTMLTxtRange** range);

            [VtblIndex(32)]
            HRESULT put_indeterminate([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(33)]
            HRESULT get_indeterminate([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(34)]
            HRESULT put_defaultChecked([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(35)]
            HRESULT get_defaultChecked([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(36)]
            HRESULT put_checked([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(37)]
            HRESULT get_checked([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(38)]
            HRESULT put_border(VARIANT v);

            [VtblIndex(39)]
            HRESULT get_border(VARIANT* p);

            [VtblIndex(40)]
            HRESULT put_vspace([NativeTypeName("long")] int v);

            [VtblIndex(41)]
            HRESULT get_vspace([NativeTypeName("long *")] int* p);

            [VtblIndex(42)]
            HRESULT put_hspace([NativeTypeName("long")] int v);

            [VtblIndex(43)]
            HRESULT get_hspace([NativeTypeName("long *")] int* p);

            [VtblIndex(44)]
            HRESULT put_alt([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(45)]
            HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(46)]
            HRESULT put_src([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(47)]
            HRESULT get_src([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(48)]
            HRESULT put_lowsrc([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(49)]
            HRESULT get_lowsrc([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(50)]
            HRESULT put_vrml([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(51)]
            HRESULT get_vrml([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(52)]
            HRESULT put_dynsrc([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(53)]
            HRESULT get_dynsrc([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(54)]
            HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(55)]
            HRESULT get_complete([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(56)]
            HRESULT put_loop(VARIANT v);

            [VtblIndex(57)]
            HRESULT get_loop(VARIANT* p);

            [VtblIndex(58)]
            HRESULT put_align([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(59)]
            HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(60)]
            HRESULT put_onload(VARIANT v);

            [VtblIndex(61)]
            HRESULT get_onload(VARIANT* p);

            [VtblIndex(62)]
            HRESULT put_onerror(VARIANT v);

            [VtblIndex(63)]
            HRESULT get_onerror(VARIANT* p);

            [VtblIndex(64)]
            HRESULT put_onabort(VARIANT v);

            [VtblIndex(65)]
            HRESULT get_onabort(VARIANT* p);

            [VtblIndex(66)]
            HRESULT put_width([NativeTypeName("long")] int v);

            [VtblIndex(67)]
            HRESULT get_width([NativeTypeName("long *")] int* p);

            [VtblIndex(68)]
            HRESULT put_height([NativeTypeName("long")] int v);

            [VtblIndex(69)]
            HRESULT get_height([NativeTypeName("long *")] int* p);

            [VtblIndex(70)]
            HRESULT put_start([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(71)]
            HRESULT get_start([NativeTypeName("BSTR *")] ushort** p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_type;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_type;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_value;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_value;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_name;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_name;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short, int> put_status;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short*, int> get_status;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short, int> put_disabled;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short*, int> get_disabled;

            [NativeTypeName("HRESULT (IHTMLFormElement **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, IHTMLFormElement**, int> get_form;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int, int> put_size;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int*, int> get_size;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int, int> put_maxLength;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int*, int> get_maxLength;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int> select;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT, int> put_onchange;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT*, int> get_onchange;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT, int> put_onselect;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT*, int> get_onselect;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_defaultValue;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_defaultValue;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short, int> put_readOnly;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short*, int> get_readOnly;

            [NativeTypeName("HRESULT (IHTMLTxtRange **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, IHTMLTxtRange**, int> createTextRange;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short, int> put_indeterminate;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short*, int> get_indeterminate;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short, int> put_defaultChecked;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short*, int> get_defaultChecked;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short, int> put_checked;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short*, int> get_checked;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT, int> put_border;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT*, int> get_border;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int, int> put_vspace;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int*, int> get_vspace;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int, int> put_hspace;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int*, int> get_hspace;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_alt;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_alt;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_src;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_src;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_lowsrc;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_lowsrc;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_vrml;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_vrml;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_dynsrc;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_dynsrc;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_readyState;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, short*, int> get_complete;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT, int> put_loop;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT*, int> get_loop;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_align;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_align;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT, int> put_onload;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT*, int> get_onload;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT, int> put_onerror;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT*, int> get_onerror;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT, int> put_onabort;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, VARIANT*, int> get_onabort;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int, int> put_width;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int*, int> get_width;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int, int> put_height;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, int*, int> get_height;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort*, int> put_start;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLInputElement*, ushort**, int> get_start;
        }
    }
}
