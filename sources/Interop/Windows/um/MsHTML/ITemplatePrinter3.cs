// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104A3-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ITemplatePrinter3 : ITemplatePrinter2")]
    [NativeInheritance("ITemplatePrinter2")]
    public unsafe partial struct ITemplatePrinter3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, Guid*, void**, int>)(lpVtbl[0]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, uint>)(lpVtbl[1]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, uint>)(lpVtbl[2]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, uint*, int>)(lpVtbl[3]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int startDoc([NativeTypeName("BSTR")] ushort* bstrTitle, [NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, short*, int>)(lpVtbl[7]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), bstrTitle, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int stopDoc()
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int>)(lpVtbl[8]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int printBlankPage()
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int>)(lpVtbl[9]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int printPage(IDispatch* pElemDisp)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, int>)(lpVtbl[10]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pElemDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int ensurePrintDialogDefaults([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[11]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int showPrintDialog([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[12]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int showPageSetupDialog([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[13]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int printNonNative(IUnknown* pMarkup, [NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IUnknown*, short*, int>)(lpVtbl[14]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pMarkup, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int printNonNativeFrames(IUnknown* pMarkup, [NativeTypeName("VARIANT_BOOL")] short fActiveFrame)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IUnknown*, short, int>)(lpVtbl[15]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pMarkup, fActiveFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_framesetDocument([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[16]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_framesetDocument([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[17]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_frameActive([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[18]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_frameActive([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[19]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_frameAsShown([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[20]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_frameAsShown([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[21]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_selection([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[22]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_selection([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[23]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_selectedPages([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[24]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_selectedPages([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[25]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_currentPage([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[26]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_currentPage([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[27]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_currentPageAvail([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[28]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_currentPageAvail([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[29]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_collate([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[30]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_collate([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[31]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_duplex([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[32]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_copies([NativeTypeName("USHORT")] ushort v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort, int>)(lpVtbl[33]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_copies([NativeTypeName("USHORT *")] ushort* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, int>)(lpVtbl[34]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_pageFrom([NativeTypeName("USHORT")] ushort v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort, int>)(lpVtbl[35]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageFrom([NativeTypeName("USHORT *")] ushort* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, int>)(lpVtbl[36]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_pageTo([NativeTypeName("USHORT")] ushort v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort, int>)(lpVtbl[37]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageTo([NativeTypeName("USHORT *")] ushort* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, int>)(lpVtbl[38]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_tableOfLinks([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[39]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_tableOfLinks([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[40]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_allLinkedDocuments([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[41]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_allLinkedDocuments([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[42]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_header([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, int>)(lpVtbl[43]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_header([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort**, int>)(lpVtbl[44]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_footer([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, int>)(lpVtbl[45]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_footer([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort**, int>)(lpVtbl[46]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginLeft([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int, int>)(lpVtbl[47]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginLeft([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[48]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginRight([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int, int>)(lpVtbl[49]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginRight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[50]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginTop([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int, int>)(lpVtbl[51]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginTop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[52]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int put_marginBottom([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int, int>)(lpVtbl[53]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_marginBottom([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[54]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[55]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[56]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_unprintableLeft([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[57]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_unprintableTop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[58]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_unprintableRight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[59]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_unprintableBottom([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[60]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int updatePageStatus([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, int*, int>)(lpVtbl[61]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int put_selectionEnabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[62]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_selectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[63]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int put_frameActiveEnabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[64]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_frameActiveEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[65]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int put_orientation([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, int>)(lpVtbl[66]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_orientation([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort**, int>)(lpVtbl[67]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int put_usePrinterCopyCollate([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short, int>)(lpVtbl[68]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_usePrinterCopyCollate([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, short*, int>)(lpVtbl[69]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int deviceSupports([NativeTypeName("BSTR")] ushort* bstrProperty, VARIANT* pvar)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, VARIANT*, int>)(lpVtbl[70]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), bstrProperty, pvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int put_headerFooterFont([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort*, int>)(lpVtbl[71]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_headerFooterFont([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, ushort**, int>)(lpVtbl[72]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int getPageMarginTop(IDispatch* pageRule, [NativeTypeName("long")] int pageWidth, [NativeTypeName("long")] int pageHeight, VARIANT* pMargin)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, int, int, VARIANT*, int>)(lpVtbl[73]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pageRule, pageWidth, pageHeight, pMargin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int getPageMarginRight(IDispatch* pageRule, [NativeTypeName("long")] int pageWidth, [NativeTypeName("long")] int pageHeight, VARIANT* pMargin)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, int, int, VARIANT*, int>)(lpVtbl[74]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pageRule, pageWidth, pageHeight, pMargin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int getPageMarginBottom(IDispatch* pageRule, [NativeTypeName("long")] int pageWidth, [NativeTypeName("long")] int pageHeight, VARIANT* pMargin)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, int, int, VARIANT*, int>)(lpVtbl[75]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pageRule, pageWidth, pageHeight, pMargin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int getPageMarginLeft(IDispatch* pageRule, [NativeTypeName("long")] int pageWidth, [NativeTypeName("long")] int pageHeight, VARIANT* pMargin)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, int, int, VARIANT*, int>)(lpVtbl[76]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pageRule, pageWidth, pageHeight, pMargin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int getPageMarginTopImportant(IDispatch* pageRule, [NativeTypeName("VARIANT_BOOL *")] short* pbImportant)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, short*, int>)(lpVtbl[77]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pageRule, pbImportant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int getPageMarginRightImportant(IDispatch* pageRule, [NativeTypeName("VARIANT_BOOL *")] short* pbImportant)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, short*, int>)(lpVtbl[78]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pageRule, pbImportant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int getPageMarginBottomImportant(IDispatch* pageRule, [NativeTypeName("VARIANT_BOOL *")] short* pbImportant)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, short*, int>)(lpVtbl[79]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pageRule, pbImportant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int getPageMarginLeftImportant(IDispatch* pageRule, [NativeTypeName("VARIANT_BOOL *")] short* pbImportant)
        {
            return ((delegate* unmanaged<ITemplatePrinter3*, IDispatch*, short*, int>)(lpVtbl[80]))((ITemplatePrinter3*)Unsafe.AsPointer(ref this), pageRule, pbImportant);
        }
    }
}
