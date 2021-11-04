// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104BF-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IRulesApplied : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IRulesApplied
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRulesApplied*, Guid*, void**, int>)(lpVtbl[0]))((IRulesApplied*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRulesApplied*, uint>)(lpVtbl[1]))((IRulesApplied*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRulesApplied*, uint>)(lpVtbl[2]))((IRulesApplied*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IRulesApplied*, uint*, int>)(lpVtbl[3]))((IRulesApplied*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IRulesApplied*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IRulesApplied*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IRulesApplied*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IRulesApplied*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IRulesApplied*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IRulesApplied*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_element(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IRulesApplied*, IHTMLElement**, int>)(lpVtbl[7]))((IRulesApplied*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_inlineStyles(IHTMLStyle** p)
        {
            return ((delegate* unmanaged<IRulesApplied*, IHTMLStyle**, int>)(lpVtbl[8]))((IRulesApplied*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_appliedRules(IHTMLStyleSheetRulesAppliedCollection** p)
        {
            return ((delegate* unmanaged<IRulesApplied*, IHTMLStyleSheetRulesAppliedCollection**, int>)(lpVtbl[9]))((IRulesApplied*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT propertyIsInline([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IRulesApplied*, ushort*, short*, int>)(lpVtbl[10]))((IRulesApplied*)Unsafe.AsPointer(ref this), name, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT propertyIsInheritable([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IRulesApplied*, ushort*, short*, int>)(lpVtbl[11]))((IRulesApplied*)Unsafe.AsPointer(ref this), name, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT hasInheritableProperty([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IRulesApplied*, short*, int>)(lpVtbl[12]))((IRulesApplied*)Unsafe.AsPointer(ref this), p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, IHTMLElement**, int> get_element;

            [NativeTypeName("HRESULT (IHTMLStyle **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, IHTMLStyle**, int> get_inlineStyles;

            [NativeTypeName("HRESULT (IHTMLStyleSheetRulesAppliedCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, IHTMLStyleSheetRulesAppliedCollection**, int> get_appliedRules;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, ushort*, short*, int> propertyIsInline;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, ushort*, short*, int> propertyIsInheritable;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRulesApplied*, short*, int> hasInheritableProperty;
        }
    }
}
