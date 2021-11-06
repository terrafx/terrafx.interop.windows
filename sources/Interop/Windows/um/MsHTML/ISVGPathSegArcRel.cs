// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510507-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGPathSegArcRel : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGPathSegArcRel : ISVGPathSegArcRel.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, Guid*, void**, int>)(lpVtbl[0]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, uint>)(lpVtbl[1]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, uint>)(lpVtbl[2]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, uint*, int>)(lpVtbl[3]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_x(float v)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float, int>)(lpVtbl[7]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_x(float* p)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float*, int>)(lpVtbl[8]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_y(float v)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float, int>)(lpVtbl[9]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_y(float* p)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float*, int>)(lpVtbl[10]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_r1(float v)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float, int>)(lpVtbl[11]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_r1(float* p)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float*, int>)(lpVtbl[12]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_r2(float v)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float, int>)(lpVtbl[13]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_r2(float* p)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float*, int>)(lpVtbl[14]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_angle(float v)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float, int>)(lpVtbl[15]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_angle(float* p)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, float*, int>)(lpVtbl[16]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_largeArcFlag([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, short, int>)(lpVtbl[17]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_largeArcFlag([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, short*, int>)(lpVtbl[18]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_sweepFlag([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, short, int>)(lpVtbl[19]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_sweepFlag([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<ISVGPathSegArcRel*, short*, int>)(lpVtbl[20]))((ISVGPathSegArcRel*)Unsafe.AsPointer(ref this), p);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT put_x(float v);

            [VtblIndex(8)]
            HRESULT get_x(float* p);

            [VtblIndex(9)]
            HRESULT put_y(float v);

            [VtblIndex(10)]
            HRESULT get_y(float* p);

            [VtblIndex(11)]
            HRESULT put_r1(float v);

            [VtblIndex(12)]
            HRESULT get_r1(float* p);

            [VtblIndex(13)]
            HRESULT put_r2(float v);

            [VtblIndex(14)]
            HRESULT get_r2(float* p);

            [VtblIndex(15)]
            HRESULT put_angle(float v);

            [VtblIndex(16)]
            HRESULT get_angle(float* p);

            [VtblIndex(17)]
            HRESULT put_largeArcFlag([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(18)]
            HRESULT get_largeArcFlag([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(19)]
            HRESULT put_sweepFlag([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(20)]
            HRESULT get_sweepFlag([NativeTypeName("VARIANT_BOOL *")] short* p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float, int> put_x;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float*, int> get_x;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float, int> put_y;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float*, int> get_y;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float, int> put_r1;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float*, int> get_r1;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float, int> put_r2;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float*, int> get_r2;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float, int> put_angle;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, float*, int> get_angle;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, short, int> put_largeArcFlag;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, short*, int> get_largeArcFlag;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, short, int> put_sweepFlag;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGPathSegArcRel*, short*, int> get_sweepFlag;
        }
    }
}
