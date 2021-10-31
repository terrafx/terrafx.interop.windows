// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510511-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGAnimatedPathData : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGAnimatedPathData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, Guid*, void**, int>)(lpVtbl[0]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, uint>)(lpVtbl[1]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, uint>)(lpVtbl[2]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, uint*, int>)(lpVtbl[3]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_pathSegList(ISVGPathSegList* v)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, ISVGPathSegList*, int>)(lpVtbl[7]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_pathSegList(ISVGPathSegList** p)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, ISVGPathSegList**, int>)(lpVtbl[8]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_normalizedPathSegList(ISVGPathSegList* v)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, ISVGPathSegList*, int>)(lpVtbl[9]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_normalizedPathSegList(ISVGPathSegList** p)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, ISVGPathSegList**, int>)(lpVtbl[10]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_animatedPathSegList(ISVGPathSegList* v)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, ISVGPathSegList*, int>)(lpVtbl[11]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_animatedPathSegList(ISVGPathSegList** p)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, ISVGPathSegList**, int>)(lpVtbl[12]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT putref_animatedNormalizedPathSegList(ISVGPathSegList* v)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, ISVGPathSegList*, int>)(lpVtbl[13]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_animatedNormalizedPathSegList(ISVGPathSegList** p)
        {
            return ((delegate* unmanaged<ISVGAnimatedPathData*, ISVGPathSegList**, int>)(lpVtbl[14]))((ISVGAnimatedPathData*)Unsafe.AsPointer(ref this), p);
        }
    }
}
