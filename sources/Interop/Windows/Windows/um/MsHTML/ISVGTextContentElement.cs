// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3051051A-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGTextContentElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGTextContentElement : ISVGTextContentElement.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, uint>)(lpVtbl[1]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, uint>)(lpVtbl[2]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, uint*, int>)(lpVtbl[3]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_textLength(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_textLength(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_lengthAdjust(ISVGAnimatedEnumeration* v)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[9]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_lengthAdjust(ISVGAnimatedEnumeration** p)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[10]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT getNumberOfChars([NativeTypeName("long *")] int* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int*, int>)(lpVtbl[11]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT getComputedTextLength(float* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, float*, int>)(lpVtbl[12]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT getSubStringLength([NativeTypeName("long")] int charnum, [NativeTypeName("long")] int nchars, float* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, int, float*, int>)(lpVtbl[13]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, nchars, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT getStartPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, ISVGPoint**, int>)(lpVtbl[14]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT getEndPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint** ppResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, ISVGPoint**, int>)(lpVtbl[15]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT getExtentOfChar([NativeTypeName("long")] int charnum, ISVGRect** ppResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, ISVGRect**, int>)(lpVtbl[16]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT getRotationOfChar([NativeTypeName("long")] int charnum, float* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, float*, int>)(lpVtbl[17]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT getCharNumAtPosition(ISVGPoint* point, [NativeTypeName("long *")] int* pResult)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, ISVGPoint*, int*, int>)(lpVtbl[18]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), point, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT selectSubString([NativeTypeName("long")] int charnum, [NativeTypeName("long")] int nchars)
        {
            return ((delegate* unmanaged<ISVGTextContentElement*, int, int, int>)(lpVtbl[19]))((ISVGTextContentElement*)Unsafe.AsPointer(ref this), charnum, nchars);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT putref_textLength(ISVGAnimatedLength* v);

            [VtblIndex(8)]
            HRESULT get_textLength(ISVGAnimatedLength** p);

            [VtblIndex(9)]
            HRESULT putref_lengthAdjust(ISVGAnimatedEnumeration* v);

            [VtblIndex(10)]
            HRESULT get_lengthAdjust(ISVGAnimatedEnumeration** p);

            [VtblIndex(11)]
            HRESULT getNumberOfChars([NativeTypeName("long *")] int* pResult);

            [VtblIndex(12)]
            HRESULT getComputedTextLength(float* pResult);

            [VtblIndex(13)]
            HRESULT getSubStringLength([NativeTypeName("long")] int charnum, [NativeTypeName("long")] int nchars, float* pResult);

            [VtblIndex(14)]
            HRESULT getStartPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint** ppResult);

            [VtblIndex(15)]
            HRESULT getEndPositionOfChar([NativeTypeName("long")] int charnum, ISVGPoint** ppResult);

            [VtblIndex(16)]
            HRESULT getExtentOfChar([NativeTypeName("long")] int charnum, ISVGRect** ppResult);

            [VtblIndex(17)]
            HRESULT getRotationOfChar([NativeTypeName("long")] int charnum, float* pResult);

            [VtblIndex(18)]
            HRESULT getCharNumAtPosition(ISVGPoint* point, [NativeTypeName("long *")] int* pResult);

            [VtblIndex(19)]
            HRESULT selectSubString([NativeTypeName("long")] int charnum, [NativeTypeName("long")] int nchars);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedLength*, int> putref_textLength;

            [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedLength**, int> get_textLength;

            [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedEnumeration*, int> putref_lengthAdjust;

            [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, ISVGAnimatedEnumeration**, int> get_lengthAdjust;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, int*, int> getNumberOfChars;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, float*, int> getComputedTextLength;

            [NativeTypeName("HRESULT (long, long, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, int, int, float*, int> getSubStringLength;

            [NativeTypeName("HRESULT (long, ISVGPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, int, ISVGPoint**, int> getStartPositionOfChar;

            [NativeTypeName("HRESULT (long, ISVGPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, int, ISVGPoint**, int> getEndPositionOfChar;

            [NativeTypeName("HRESULT (long, ISVGRect **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, int, ISVGRect**, int> getExtentOfChar;

            [NativeTypeName("HRESULT (long, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, int, float*, int> getRotationOfChar;

            [NativeTypeName("HRESULT (ISVGPoint *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, ISVGPoint*, int*, int> getCharNumAtPosition;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGTextContentElement*, int, int, int> selectSubString;
        }
    }
}
