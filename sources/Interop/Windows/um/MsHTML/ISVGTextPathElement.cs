// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051051F-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGTextPathElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGTextPathElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, uint>)(lpVtbl[1]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, uint>)(lpVtbl[2]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, uint*, int>)(lpVtbl[3]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int putref_startOffset(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_startOffset(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int putref_method(ISVGAnimatedEnumeration* v)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[9]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_method(ISVGAnimatedEnumeration** p)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[10]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int putref_spacing(ISVGAnimatedEnumeration* v)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[11]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_spacing(ISVGAnimatedEnumeration** p)
        {
            return ((delegate* unmanaged<ISVGTextPathElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[12]))((ISVGTextPathElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
