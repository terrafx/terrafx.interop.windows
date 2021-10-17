// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F2D4-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLInputRangeElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLInputRangeElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, uint>)(lpVtbl[1]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, uint>)(lpVtbl[2]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, uint*, int>)(lpVtbl[3]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, short, int>)(lpVtbl[7]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, short*, int>)(lpVtbl[8]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int>)(lpVtbl[9]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_alt([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int>)(lpVtbl[10]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_alt([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int>)(lpVtbl[11]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int>)(lpVtbl[12]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int>)(lpVtbl[13]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_value([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int>)(lpVtbl[14]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_value([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int>)(lpVtbl[15]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_min([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int>)(lpVtbl[16]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_min([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int>)(lpVtbl[17]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_max([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int>)(lpVtbl[18]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_max([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int>)(lpVtbl[19]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_step([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort*, int>)(lpVtbl[20]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_step([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, ushort**, int>)(lpVtbl[21]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_valueAsNumber(double v)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, double, int>)(lpVtbl[22]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_valueAsNumber(double* p)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, double*, int>)(lpVtbl[23]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int stepUp([NativeTypeName("long")] int n = 1)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, int, int>)(lpVtbl[24]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int stepDown([NativeTypeName("long")] int n = 1)
        {
            return ((delegate* unmanaged<IHTMLInputRangeElement*, int, int>)(lpVtbl[25]))((IHTMLInputRangeElement*)Unsafe.AsPointer(ref this), n);
        }
    }
}
