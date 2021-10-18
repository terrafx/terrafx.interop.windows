// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106F4-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLStyleSheet4 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLStyleSheet4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, uint>)(lpVtbl[1]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, uint>)(lpVtbl[2]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, uint*, int>)(lpVtbl[3]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, ushort**, int>)(lpVtbl[7]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_href(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, VARIANT*, int>)(lpVtbl[8]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_title([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, ushort**, int>)(lpVtbl[9]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerNode(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, IHTMLElement**, int>)(lpVtbl[10]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerRule(IHTMLCSSRule** p)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, IHTMLCSSRule**, int>)(lpVtbl[11]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_cssRules(IHTMLStyleSheetRulesCollection** p)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, IHTMLStyleSheetRulesCollection**, int>)(lpVtbl[12]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_media(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, VARIANT*, int>)(lpVtbl[13]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int insertRule([NativeTypeName("BSTR")] ushort* bstrRule, [NativeTypeName("long")] int lIndex, [NativeTypeName("long *")] int* plNewIndex)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, ushort*, int, int*, int>)(lpVtbl[14]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), bstrRule, lIndex, plNewIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int deleteRule([NativeTypeName("long")] int lIndex = -1)
        {
            return ((delegate* unmanaged<IHTMLStyleSheet4*, int, int>)(lpVtbl[15]))((IHTMLStyleSheet4*)Unsafe.AsPointer(ref this), lIndex);
        }
    }
}
