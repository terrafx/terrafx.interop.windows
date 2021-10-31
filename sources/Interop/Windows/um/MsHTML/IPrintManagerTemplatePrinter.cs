// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F633BE14-9EFF-4C4D-929E-05717B21B3E6")]
    [NativeTypeName("struct IPrintManagerTemplatePrinter : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IPrintManagerTemplatePrinter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, Guid*, void**, int>)(lpVtbl[0]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, uint>)(lpVtbl[1]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, uint>)(lpVtbl[2]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, uint*, int>)(lpVtbl[3]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT startPrint()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, int>)(lpVtbl[7]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT drawPreviewPage(IDispatch* pElemDisp, [NativeTypeName("long")] int nPage)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, IDispatch*, int, int>)(lpVtbl[8]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this), pElemDisp, nPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT setPageCount([NativeTypeName("long")] int nPage)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, int, int>)(lpVtbl[9]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this), nPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT invalidatePreview()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, int>)(lpVtbl[10]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT getPrintTaskOptionValue([NativeTypeName("BSTR")] ushort* bstrKey, VARIANT* pvarin)
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, ushort*, VARIANT*, int>)(lpVtbl[11]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this), bstrKey, pvarin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT endPrint()
        {
            return ((delegate* unmanaged<IPrintManagerTemplatePrinter*, int>)(lpVtbl[12]))((IPrintManagerTemplatePrinter*)Unsafe.AsPointer(ref this));
        }
    }
}
