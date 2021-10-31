// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051080D-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLMSCSSKeyframesRule : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLMSCSSKeyframesRule
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, uint>)(lpVtbl[1]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, uint>)(lpVtbl[2]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, uint*, int>)(lpVtbl[3]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort*, int>)(lpVtbl[7]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort**, int>)(lpVtbl[8]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_cssRules(IHTMLStyleSheetRulesCollection** p)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, IHTMLStyleSheetRulesCollection**, int>)(lpVtbl[9]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT appendRule([NativeTypeName("BSTR")] ushort* bstrRule)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort*, int>)(lpVtbl[10]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), bstrRule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT deleteRule([NativeTypeName("BSTR")] ushort* bstrKey)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort*, int>)(lpVtbl[11]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), bstrKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT findRule([NativeTypeName("BSTR")] ushort* bstrKey, IHTMLMSCSSKeyframeRule** ppMSKeyframeRule)
        {
            return ((delegate* unmanaged<IHTMLMSCSSKeyframesRule*, ushort*, IHTMLMSCSSKeyframeRule**, int>)(lpVtbl[12]))((IHTMLMSCSSKeyframesRule*)Unsafe.AsPointer(ref this), bstrKey, ppMSKeyframeRule);
        }
    }
}
