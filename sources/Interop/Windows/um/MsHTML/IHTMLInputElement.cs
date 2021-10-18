// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F5D2-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLInputElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLInputElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, uint*, int>)(lpVtbl[3]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_type([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[7]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[8]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_value([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[9]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_value([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[10]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[11]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[12]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_status([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[13]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_status([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[14]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[15]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[16]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_form(IHTMLFormElement** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, IHTMLFormElement**, int>)(lpVtbl[17]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_size([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[18]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_size([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[19]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_maxLength([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[20]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_maxLength([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[21]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int select()
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int>)(lpVtbl[22]))((IHTMLInputElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_onchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_onchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_onselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_onselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_defaultValue([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[27]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_defaultValue([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[28]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_readOnly([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[29]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_readOnly([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[30]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int createTextRange(IHTMLTxtRange** range)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, IHTMLTxtRange**, int>)(lpVtbl[31]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), range);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_indeterminate([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[32]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_indeterminate([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[33]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_defaultChecked([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[34]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_defaultChecked([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[35]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_checked([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short, int>)(lpVtbl[36]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_checked([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[37]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_border(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[38]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_border(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[39]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_vspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[40]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_vspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[41]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_hspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[42]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_hspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[43]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_alt([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[44]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_alt([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[45]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int put_src([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[46]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_src([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[47]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int put_lowsrc([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[48]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_lowsrc([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[49]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int put_vrml([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[50]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_vrml([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[51]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int put_dynsrc([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[52]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_dynsrc([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[53]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[54]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_complete([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, short*, int>)(lpVtbl[55]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int put_loop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[56]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_loop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[57]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int put_align([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[58]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_align([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[59]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[60]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[61]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[62]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[63]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int put_onabort(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT, int>)(lpVtbl[64]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_onabort(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, VARIANT*, int>)(lpVtbl[65]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int put_width([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[66]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_width([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[67]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int put_height([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int, int>)(lpVtbl[68]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_height([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, int*, int>)(lpVtbl[69]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int put_start([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort*, int>)(lpVtbl[70]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int get_start([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputElement*, ushort**, int>)(lpVtbl[71]))((IHTMLInputElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
