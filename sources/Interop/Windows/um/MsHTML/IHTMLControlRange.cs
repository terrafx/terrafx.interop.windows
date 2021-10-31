// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F29C-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLControlRange : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLControlRange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLControlRange*, uint>)(lpVtbl[1]))((IHTMLControlRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLControlRange*, uint>)(lpVtbl[2]))((IHTMLControlRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, uint*, int>)(lpVtbl[3]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT select()
        {
            return ((delegate* unmanaged<IHTMLControlRange*, int>)(lpVtbl[7]))((IHTMLControlRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT add(IHTMLControlElement* item)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, IHTMLControlElement*, int>)(lpVtbl[8]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT remove([NativeTypeName("long")] int index)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, int, int>)(lpVtbl[9]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT item([NativeTypeName("long")] int index, IHTMLElement** pdisp)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, int, IHTMLElement**, int>)(lpVtbl[10]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), index, pdisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT scrollIntoView(VARIANT varargStart)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, VARIANT, int>)(lpVtbl[11]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), varargStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT queryCommandSupported([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, ushort*, short*, int>)(lpVtbl[12]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT queryCommandEnabled([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, ushort*, short*, int>)(lpVtbl[13]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT queryCommandState([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, ushort*, short*, int>)(lpVtbl[14]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, ushort*, short*, int>)(lpVtbl[15]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT queryCommandText([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("BSTR *")] ushort** pcmdText)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, ushort*, ushort**, int>)(lpVtbl[16]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pcmdText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, ushort*, VARIANT*, int>)(lpVtbl[17]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pcmdValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT execCommand([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, ushort*, short, VARIANT, short*, int>)(lpVtbl[18]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, showUI, value, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT execCommandShowHelp([NativeTypeName("BSTR")] ushort* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, ushort*, short*, int>)(lpVtbl[19]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT commonParentElement(IHTMLElement** parent)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, IHTMLElement**, int>)(lpVtbl[20]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLControlRange*, int*, int>)(lpVtbl[21]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), p);
        }
    }
}
