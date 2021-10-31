// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104F8-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGTransformList : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGTransformList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGTransformList*, Guid*, void**, int>)(lpVtbl[0]))((ISVGTransformList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGTransformList*, uint>)(lpVtbl[1]))((ISVGTransformList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGTransformList*, uint>)(lpVtbl[2]))((ISVGTransformList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGTransformList*, uint*, int>)(lpVtbl[3]))((ISVGTransformList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGTransformList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGTransformList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGTransformList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGTransformList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGTransformList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGTransformList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_numberOfItems([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<ISVGTransformList*, int, int>)(lpVtbl[7]))((ISVGTransformList*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_numberOfItems([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ISVGTransformList*, int*, int>)(lpVtbl[8]))((ISVGTransformList*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT clear()
        {
            return ((delegate* unmanaged<ISVGTransformList*, int>)(lpVtbl[9]))((ISVGTransformList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT initialize(ISVGTransform* newItem, ISVGTransform** ppResult)
        {
            return ((delegate* unmanaged<ISVGTransformList*, ISVGTransform*, ISVGTransform**, int>)(lpVtbl[10]))((ISVGTransformList*)Unsafe.AsPointer(ref this), newItem, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT getItem([NativeTypeName("long")] int index, ISVGTransform** ppResult)
        {
            return ((delegate* unmanaged<ISVGTransformList*, int, ISVGTransform**, int>)(lpVtbl[11]))((ISVGTransformList*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT insertItemBefore(ISVGTransform* newItem, [NativeTypeName("long")] int index, ISVGTransform** ppResult)
        {
            return ((delegate* unmanaged<ISVGTransformList*, ISVGTransform*, int, ISVGTransform**, int>)(lpVtbl[12]))((ISVGTransformList*)Unsafe.AsPointer(ref this), newItem, index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT replaceItem(ISVGTransform* newItem, [NativeTypeName("long")] int index, ISVGTransform** ppResult)
        {
            return ((delegate* unmanaged<ISVGTransformList*, ISVGTransform*, int, ISVGTransform**, int>)(lpVtbl[13]))((ISVGTransformList*)Unsafe.AsPointer(ref this), newItem, index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT removeItem([NativeTypeName("long")] int index, ISVGTransform** ppResult)
        {
            return ((delegate* unmanaged<ISVGTransformList*, int, ISVGTransform**, int>)(lpVtbl[14]))((ISVGTransformList*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT appendItem(ISVGTransform* newItem, ISVGTransform** ppResult)
        {
            return ((delegate* unmanaged<ISVGTransformList*, ISVGTransform*, ISVGTransform**, int>)(lpVtbl[15]))((ISVGTransformList*)Unsafe.AsPointer(ref this), newItem, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT createSVGTransformFromMatrix(ISVGMatrix* newItem, ISVGTransform** ppResult)
        {
            return ((delegate* unmanaged<ISVGTransformList*, ISVGMatrix*, ISVGTransform**, int>)(lpVtbl[16]))((ISVGTransformList*)Unsafe.AsPointer(ref this), newItem, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT consolidate(ISVGTransform** ppResult)
        {
            return ((delegate* unmanaged<ISVGTransformList*, ISVGTransform**, int>)(lpVtbl[17]))((ISVGTransformList*)Unsafe.AsPointer(ref this), ppResult);
        }
    }
}
