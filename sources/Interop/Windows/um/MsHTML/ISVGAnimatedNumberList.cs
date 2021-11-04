// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104CE-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGAnimatedNumberList : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGAnimatedNumberList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, Guid*, void**, int>)(lpVtbl[0]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, uint>)(lpVtbl[1]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, uint>)(lpVtbl[2]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, uint*, int>)(lpVtbl[3]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_baseVal(ISVGNumberList* v)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, ISVGNumberList*, int>)(lpVtbl[7]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_baseVal(ISVGNumberList** p)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, ISVGNumberList**, int>)(lpVtbl[8]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_animVal(ISVGNumberList* v)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, ISVGNumberList*, int>)(lpVtbl[9]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_animVal(ISVGNumberList** p)
        {
            return ((delegate* unmanaged<ISVGAnimatedNumberList*, ISVGNumberList**, int>)(lpVtbl[10]))((ISVGAnimatedNumberList*)Unsafe.AsPointer(ref this), p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (ISVGNumberList *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, ISVGNumberList*, int> putref_baseVal;

            [NativeTypeName("HRESULT (ISVGNumberList **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, ISVGNumberList**, int> get_baseVal;

            [NativeTypeName("HRESULT (ISVGNumberList *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, ISVGNumberList*, int> putref_animVal;

            [NativeTypeName("HRESULT (ISVGNumberList **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedNumberList*, ISVGNumberList**, int> get_animVal;
        }
    }
}
