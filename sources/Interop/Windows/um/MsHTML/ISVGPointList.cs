// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104F5-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGPointList : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGPointList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGPointList*, Guid*, void**, int>)(lpVtbl[0]))((ISVGPointList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGPointList*, uint>)(lpVtbl[1]))((ISVGPointList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGPointList*, uint>)(lpVtbl[2]))((ISVGPointList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGPointList*, uint*, int>)(lpVtbl[3]))((ISVGPointList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGPointList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGPointList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGPointList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGPointList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGPointList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGPointList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_numberOfItems([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<ISVGPointList*, int, int>)(lpVtbl[7]))((ISVGPointList*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_numberOfItems([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ISVGPointList*, int*, int>)(lpVtbl[8]))((ISVGPointList*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int clear()
        {
            return ((delegate* unmanaged<ISVGPointList*, int>)(lpVtbl[9]))((ISVGPointList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int initialize(ISVGPoint* pNewItem, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, ISVGPoint*, ISVGPoint**, int>)(lpVtbl[10]))((ISVGPointList*)Unsafe.AsPointer(ref this), pNewItem, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int getItem([NativeTypeName("long")] int index, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, int, ISVGPoint**, int>)(lpVtbl[11]))((ISVGPointList*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int insertItemBefore(ISVGPoint* pNewItem, [NativeTypeName("long")] int index, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, ISVGPoint*, int, ISVGPoint**, int>)(lpVtbl[12]))((ISVGPointList*)Unsafe.AsPointer(ref this), pNewItem, index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int replaceItem(ISVGPoint* pNewItem, [NativeTypeName("long")] int index, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, ISVGPoint*, int, ISVGPoint**, int>)(lpVtbl[13]))((ISVGPointList*)Unsafe.AsPointer(ref this), pNewItem, index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int removeItem([NativeTypeName("long")] int index, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, int, ISVGPoint**, int>)(lpVtbl[14]))((ISVGPointList*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int appendItem(ISVGPoint* pNewItem, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGPointList*, ISVGPoint*, ISVGPoint**, int>)(lpVtbl[15]))((ISVGPointList*)Unsafe.AsPointer(ref this), pNewItem, ppResult);
        }
    }
}
