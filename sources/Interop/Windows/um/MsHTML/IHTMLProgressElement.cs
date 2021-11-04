// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F2D6-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLProgressElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLProgressElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, uint>)(lpVtbl[1]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, uint>)(lpVtbl[2]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, uint*, int>)(lpVtbl[3]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_value(float v)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, float, int>)(lpVtbl[7]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_value(float* p)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, float*, int>)(lpVtbl[8]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_max(float v)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, float, int>)(lpVtbl[9]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_max(float* p)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, float*, int>)(lpVtbl[10]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_position(float* p)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, float*, int>)(lpVtbl[11]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_form(IHTMLFormElement** p)
        {
            return ((delegate* unmanaged<IHTMLProgressElement*, IHTMLFormElement**, int>)(lpVtbl[12]))((IHTMLProgressElement*)Unsafe.AsPointer(ref this), p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, float, int> put_value;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, float*, int> get_value;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, float, int> put_max;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, float*, int> get_max;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, float*, int> get_position;

            [NativeTypeName("HRESULT (IHTMLFormElement **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLProgressElement*, IHTMLFormElement**, int> get_form;
        }
    }
}
