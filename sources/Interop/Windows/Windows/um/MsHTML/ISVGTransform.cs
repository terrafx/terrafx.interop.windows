// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("305104F7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGTransform : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGTransform : ISVGTransform.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGTransform*, Guid*, void**, int>)(lpVtbl[0]))((ISVGTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGTransform*, uint>)(lpVtbl[1]))((ISVGTransform*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGTransform*, uint>)(lpVtbl[2]))((ISVGTransform*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGTransform*, uint*, int>)(lpVtbl[3]))((ISVGTransform*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGTransform*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGTransform*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGTransform*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGTransform*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGTransform*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGTransform*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_type(short v)
    {
        return ((delegate* unmanaged<ISVGTransform*, short, int>)(lpVtbl[7]))((ISVGTransform*)Unsafe.AsPointer(ref this), v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_type(short* p)
    {
        return ((delegate* unmanaged<ISVGTransform*, short*, int>)(lpVtbl[8]))((ISVGTransform*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_matrix(ISVGMatrix* v)
    {
        return ((delegate* unmanaged<ISVGTransform*, ISVGMatrix*, int>)(lpVtbl[9]))((ISVGTransform*)Unsafe.AsPointer(ref this), v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_matrix(ISVGMatrix** p)
    {
        return ((delegate* unmanaged<ISVGTransform*, ISVGMatrix**, int>)(lpVtbl[10]))((ISVGTransform*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_angle(float v)
    {
        return ((delegate* unmanaged<ISVGTransform*, float, int>)(lpVtbl[11]))((ISVGTransform*)Unsafe.AsPointer(ref this), v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_angle(float* p)
    {
        return ((delegate* unmanaged<ISVGTransform*, float*, int>)(lpVtbl[12]))((ISVGTransform*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT setMatrix(ISVGMatrix* matrix)
    {
        return ((delegate* unmanaged<ISVGTransform*, ISVGMatrix*, int>)(lpVtbl[13]))((ISVGTransform*)Unsafe.AsPointer(ref this), matrix);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT setTranslate(float tx, float ty)
    {
        return ((delegate* unmanaged<ISVGTransform*, float, float, int>)(lpVtbl[14]))((ISVGTransform*)Unsafe.AsPointer(ref this), tx, ty);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT setScale(float sx, float sy)
    {
        return ((delegate* unmanaged<ISVGTransform*, float, float, int>)(lpVtbl[15]))((ISVGTransform*)Unsafe.AsPointer(ref this), sx, sy);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT setRotate(float angle, float cx, float cy)
    {
        return ((delegate* unmanaged<ISVGTransform*, float, float, float, int>)(lpVtbl[16]))((ISVGTransform*)Unsafe.AsPointer(ref this), angle, cx, cy);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT setSkewX(float angle)
    {
        return ((delegate* unmanaged<ISVGTransform*, float, int>)(lpVtbl[17]))((ISVGTransform*)Unsafe.AsPointer(ref this), angle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT setSkewY(float angle)
    {
        return ((delegate* unmanaged<ISVGTransform*, float, int>)(lpVtbl[18]))((ISVGTransform*)Unsafe.AsPointer(ref this), angle);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_type(short v);

        [VtblIndex(8)]
        HRESULT get_type(short* p);

        [VtblIndex(9)]
        HRESULT putref_matrix(ISVGMatrix* v);

        [VtblIndex(10)]
        HRESULT get_matrix(ISVGMatrix** p);

        [VtblIndex(11)]
        HRESULT put_angle(float v);

        [VtblIndex(12)]
        HRESULT get_angle(float* p);

        [VtblIndex(13)]
        HRESULT setMatrix(ISVGMatrix* matrix);

        [VtblIndex(14)]
        HRESULT setTranslate(float tx, float ty);

        [VtblIndex(15)]
        HRESULT setScale(float sx, float sy);

        [VtblIndex(16)]
        HRESULT setRotate(float angle, float cx, float cy);

        [VtblIndex(17)]
        HRESULT setSkewX(float angle);

        [VtblIndex(18)]
        HRESULT setSkewY(float angle);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, short, int> put_type;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, short*, int> get_type;

        [NativeTypeName("HRESULT (ISVGMatrix *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, ISVGMatrix*, int> putref_matrix;

        [NativeTypeName("HRESULT (ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, ISVGMatrix**, int> get_matrix;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, float, int> put_angle;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, float*, int> get_angle;

        [NativeTypeName("HRESULT (ISVGMatrix *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, ISVGMatrix*, int> setMatrix;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, float, float, int> setTranslate;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, float, float, int> setScale;

        [NativeTypeName("HRESULT (float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, float, float, float, int> setRotate;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, float, int> setSkewX;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<ISVGTransform*, float, int> setSkewY;
    }
}
