// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510706-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLMediaElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLMediaElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, uint>)(lpVtbl[1]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, uint>)(lpVtbl[2]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, uint*, int>)(lpVtbl[3]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_error(IHTMLMediaError** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, IHTMLMediaError**, int>)(lpVtbl[7]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort*, int>)(lpVtbl[8]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort**, int>)(lpVtbl[9]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_currentSrc([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort**, int>)(lpVtbl[10]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_networkState(ushort* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort*, int>)(lpVtbl[11]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_preload([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort*, int>)(lpVtbl[12]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_preload([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort**, int>)(lpVtbl[13]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_buffered(IHTMLTimeRanges** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, IHTMLTimeRanges**, int>)(lpVtbl[14]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT load()
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, int>)(lpVtbl[15]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT canPlayType([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR *")] ushort** canPlay)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort*, ushort**, int>)(lpVtbl[16]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), type, canPlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_seeking([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[17]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_currentTime(float v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float, int>)(lpVtbl[18]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_currentTime(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[19]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_initialTime(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[20]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_duration(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[21]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_paused([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[22]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_defaultPlaybackRate(float v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float, int>)(lpVtbl[23]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_defaultPlaybackRate(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[24]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_playbackRate(float v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float, int>)(lpVtbl[25]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_playbackRate(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[26]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_played(IHTMLTimeRanges** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, IHTMLTimeRanges**, int>)(lpVtbl[27]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_seekable(IHTMLTimeRanges** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, IHTMLTimeRanges**, int>)(lpVtbl[28]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_ended([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[29]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT put_autoplay([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[30]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_autoplay([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[31]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT put_loop([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[32]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_loop([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[33]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT play()
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, int>)(lpVtbl[34]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT pause()
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, int>)(lpVtbl[35]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_controls([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[36]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_controls([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[37]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT put_volume(float v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float, int>)(lpVtbl[38]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_volume(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[39]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT put_muted([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[40]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_muted([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[41]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT put_autobuffer([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[42]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_autobuffer([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[43]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
