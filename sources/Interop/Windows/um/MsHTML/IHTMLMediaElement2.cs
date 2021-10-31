// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510809-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLMediaElement2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLMediaElement2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, uint>)(lpVtbl[1]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, uint>)(lpVtbl[2]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, uint*, int>)(lpVtbl[3]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_currentTimeDouble(double v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double, int>)(lpVtbl[7]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_currentTimeDouble(double* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int>)(lpVtbl[8]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_initialTimeDouble(double* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int>)(lpVtbl[9]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_durationDouble(double* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int>)(lpVtbl[10]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_defaultPlaybackRateDouble(double v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double, int>)(lpVtbl[11]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_defaultPlaybackRateDouble(double* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int>)(lpVtbl[12]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_playbackRateDouble(double v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double, int>)(lpVtbl[13]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_playbackRateDouble(double* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int>)(lpVtbl[14]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_volumeDouble(double v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double, int>)(lpVtbl[15]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_volumeDouble(double* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int>)(lpVtbl[16]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
