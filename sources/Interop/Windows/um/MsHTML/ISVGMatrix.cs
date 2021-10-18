// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104F6-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGMatrix : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGMatrix
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGMatrix*, Guid*, void**, int>)(lpVtbl[0]))((ISVGMatrix*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGMatrix*, uint>)(lpVtbl[1]))((ISVGMatrix*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGMatrix*, uint>)(lpVtbl[2]))((ISVGMatrix*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGMatrix*, uint*, int>)(lpVtbl[3]))((ISVGMatrix*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGMatrix*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGMatrix*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGMatrix*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGMatrix*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGMatrix*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGMatrix*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_a(float v)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, int>)(lpVtbl[7]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_a(float* p)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float*, int>)(lpVtbl[8]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_b(float v)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, int>)(lpVtbl[9]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_b(float* p)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float*, int>)(lpVtbl[10]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_c(float v)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, int>)(lpVtbl[11]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_c(float* p)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float*, int>)(lpVtbl[12]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_d(float v)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, int>)(lpVtbl[13]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_d(float* p)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float*, int>)(lpVtbl[14]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_e(float v)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, int>)(lpVtbl[15]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_e(float* p)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float*, int>)(lpVtbl[16]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_f(float v)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, int>)(lpVtbl[17]))((ISVGMatrix*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_f(float* p)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float*, int>)(lpVtbl[18]))((ISVGMatrix*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int multiply(ISVGMatrix* secondMatrix, ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, ISVGMatrix*, ISVGMatrix**, int>)(lpVtbl[19]))((ISVGMatrix*)Unsafe.AsPointer(ref this), secondMatrix, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int inverse(ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, ISVGMatrix**, int>)(lpVtbl[20]))((ISVGMatrix*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int translate(float x, float y, ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, float, ISVGMatrix**, int>)(lpVtbl[21]))((ISVGMatrix*)Unsafe.AsPointer(ref this), x, y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int scale(float scaleFactor, ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, ISVGMatrix**, int>)(lpVtbl[22]))((ISVGMatrix*)Unsafe.AsPointer(ref this), scaleFactor, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int scaleNonUniform(float scaleFactorX, float scaleFactorY, ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, float, ISVGMatrix**, int>)(lpVtbl[23]))((ISVGMatrix*)Unsafe.AsPointer(ref this), scaleFactorX, scaleFactorY, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int rotate(float angle, ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, ISVGMatrix**, int>)(lpVtbl[24]))((ISVGMatrix*)Unsafe.AsPointer(ref this), angle, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int rotateFromVector(float x, float y, ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, float, ISVGMatrix**, int>)(lpVtbl[25]))((ISVGMatrix*)Unsafe.AsPointer(ref this), x, y, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int flipX(ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, ISVGMatrix**, int>)(lpVtbl[26]))((ISVGMatrix*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int flipY(ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, ISVGMatrix**, int>)(lpVtbl[27]))((ISVGMatrix*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int skewX(float angle, ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, ISVGMatrix**, int>)(lpVtbl[28]))((ISVGMatrix*)Unsafe.AsPointer(ref this), angle, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int skewY(float angle, ISVGMatrix** ppResult)
        {
            return ((delegate* unmanaged<ISVGMatrix*, float, ISVGMatrix**, int>)(lpVtbl[29]))((ISVGMatrix*)Unsafe.AsPointer(ref this), angle, ppResult);
        }
    }
}
