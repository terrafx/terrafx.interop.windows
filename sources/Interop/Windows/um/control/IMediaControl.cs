// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B1-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaControl : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IMediaControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaControl*, Guid*, void**, int>)(lpVtbl[0]))((IMediaControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaControl*, uint>)(lpVtbl[1]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaControl*, uint>)(lpVtbl[2]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IMediaControl*, uint*, int>)(lpVtbl[3]))((IMediaControl*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IMediaControl*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IMediaControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IMediaControl*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IMediaControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IMediaControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IMediaControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Run()
        {
            return ((delegate* unmanaged<IMediaControl*, int>)(lpVtbl[7]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Pause()
        {
            return ((delegate* unmanaged<IMediaControl*, int>)(lpVtbl[8]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IMediaControl*, int>)(lpVtbl[9]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetState([NativeTypeName("LONG")] int msTimeout, [NativeTypeName("OAFilterState *")] int* pfs)
        {
            return ((delegate* unmanaged<IMediaControl*, int, int*, int>)(lpVtbl[10]))((IMediaControl*)Unsafe.AsPointer(ref this), msTimeout, pfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT RenderFile([NativeTypeName("BSTR")] ushort* strFilename)
        {
            return ((delegate* unmanaged<IMediaControl*, ushort*, int>)(lpVtbl[11]))((IMediaControl*)Unsafe.AsPointer(ref this), strFilename);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddSourceFilter([NativeTypeName("BSTR")] ushort* strFilename, IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IMediaControl*, ushort*, IDispatch**, int>)(lpVtbl[12]))((IMediaControl*)Unsafe.AsPointer(ref this), strFilename, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_FilterCollection(IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IMediaControl*, IDispatch**, int>)(lpVtbl[13]))((IMediaControl*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_RegFilterCollection(IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IMediaControl*, IDispatch**, int>)(lpVtbl[14]))((IMediaControl*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT StopWhenReady()
        {
            return ((delegate* unmanaged<IMediaControl*, int>)(lpVtbl[15]))((IMediaControl*)Unsafe.AsPointer(ref this));
        }
    }
}
