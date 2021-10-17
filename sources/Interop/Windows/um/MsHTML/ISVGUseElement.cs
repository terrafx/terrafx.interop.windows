// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104ED-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGUseElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGUseElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGUseElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGUseElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGUseElement*, uint>)(lpVtbl[1]))((ISVGUseElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGUseElement*, uint>)(lpVtbl[2]))((ISVGUseElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGUseElement*, uint*, int>)(lpVtbl[3]))((ISVGUseElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGUseElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGUseElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGUseElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGUseElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGUseElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGUseElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int putref_x(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_x(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int putref_y(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_y(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int putref_width(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_width(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int putref_height(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_height(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int putref_instanceRoot(ISVGElementInstance* v)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGElementInstance*, int>)(lpVtbl[15]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_instanceRoot(ISVGElementInstance** p)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGElementInstance**, int>)(lpVtbl[16]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int putref_animatedInstanceRoot(ISVGElementInstance* v)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGElementInstance*, int>)(lpVtbl[17]))((ISVGUseElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_animatedInstanceRoot(ISVGElementInstance** p)
        {
            return ((delegate* unmanaged<ISVGUseElement*, ISVGElementInstance**, int>)(lpVtbl[18]))((ISVGUseElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
