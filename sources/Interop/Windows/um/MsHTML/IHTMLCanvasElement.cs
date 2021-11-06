// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106E4-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCanvasElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCanvasElement : IHTMLCanvasElement.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, uint>)(lpVtbl[1]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, uint>)(lpVtbl[2]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, uint*, int>)(lpVtbl[3]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_width([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, int, int>)(lpVtbl[7]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_width([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, int*, int>)(lpVtbl[8]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_height([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, int, int>)(lpVtbl[9]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_height([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, int*, int>)(lpVtbl[10]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT getContext([NativeTypeName("BSTR")] ushort* contextId, ICanvasRenderingContext2D** ppContext)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, ushort*, ICanvasRenderingContext2D**, int>)(lpVtbl[11]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), contextId, ppContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT toDataURL([NativeTypeName("BSTR")] ushort* type, VARIANT jpegquality, [NativeTypeName("BSTR *")] ushort** pUrl)
        {
            return ((delegate* unmanaged<IHTMLCanvasElement*, ushort*, VARIANT, ushort**, int>)(lpVtbl[12]))((IHTMLCanvasElement*)Unsafe.AsPointer(ref this), type, jpegquality, pUrl);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT put_width([NativeTypeName("long")] int v);

            [VtblIndex(8)]
            HRESULT get_width([NativeTypeName("long *")] int* p);

            [VtblIndex(9)]
            HRESULT put_height([NativeTypeName("long")] int v);

            [VtblIndex(10)]
            HRESULT get_height([NativeTypeName("long *")] int* p);

            [VtblIndex(11)]
            HRESULT getContext([NativeTypeName("BSTR")] ushort* contextId, ICanvasRenderingContext2D** ppContext);

            [VtblIndex(12)]
            HRESULT toDataURL([NativeTypeName("BSTR")] ushort* type, VARIANT jpegquality, [NativeTypeName("BSTR *")] ushort** pUrl);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, int, int> put_width;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, int*, int> get_width;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, int, int> put_height;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, int*, int> get_height;

            [NativeTypeName("HRESULT (BSTR, ICanvasRenderingContext2D **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, ushort*, ICanvasRenderingContext2D**, int> getContext;

            [NativeTypeName("HRESULT (BSTR, VARIANT, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCanvasElement*, ushort*, VARIANT, ushort**, int> toDataURL;
        }
    }
}
