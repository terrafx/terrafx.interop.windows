// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F813-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLCommentElement2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLCommentElement2 : IHTMLCommentElement2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, uint>)(lpVtbl[1]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, uint>)(lpVtbl[2]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, uint*, int>)(lpVtbl[3]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_data([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, ushort*, int>)(lpVtbl[7]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_data([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, ushort**, int>)(lpVtbl[8]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, int*, int>)(lpVtbl[9]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR *")] ushort** pbstrsubString)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, int, int, ushort**, int>)(lpVtbl[10]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), offset, Count, pbstrsubString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT appendData([NativeTypeName("BSTR")] ushort* bstrstring)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, ushort*, int>)(lpVtbl[11]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), bstrstring);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* bstrstring)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, int, ushort*, int>)(lpVtbl[12]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), offset, bstrstring);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, int, int, int>)(lpVtbl[13]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), offset, Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR")] ushort* bstrstring)
        {
            return ((delegate* unmanaged<IHTMLCommentElement2*, int, int, ushort*, int>)(lpVtbl[14]))((IHTMLCommentElement2*)Unsafe.AsPointer(ref this), offset, Count, bstrstring);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT put_data([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(8)]
            HRESULT get_data([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(9)]
            HRESULT get_length([NativeTypeName("long *")] int* p);

            [VtblIndex(10)]
            HRESULT substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR *")] ushort** pbstrsubString);

            [VtblIndex(11)]
            HRESULT appendData([NativeTypeName("BSTR")] ushort* bstrstring);

            [VtblIndex(12)]
            HRESULT insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* bstrstring);

            [VtblIndex(13)]
            HRESULT deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count);

            [VtblIndex(14)]
            HRESULT replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR")] ushort* bstrstring);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, ushort*, int> put_data;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, ushort**, int> get_data;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, int*, int> get_length;

            [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, int, int, ushort**, int> substringData;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, ushort*, int> appendData;

            [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, int, ushort*, int> insertData;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, int, int, int> deleteData;

            [NativeTypeName("HRESULT (long, long, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLCommentElement2*, int, int, ushort*, int> replaceData;
        }
    }
}
