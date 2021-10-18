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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, uint*, int>)(lpVtbl[3]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_error(IHTMLMediaError** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, IHTMLMediaError**, int>)(lpVtbl[7]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int put_src([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort*, int>)(lpVtbl[8]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_src([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort**, int>)(lpVtbl[9]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_currentSrc([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort**, int>)(lpVtbl[10]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_networkState([NativeTypeName("USHORT *")] ushort* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort*, int>)(lpVtbl[11]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_preload([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort*, int>)(lpVtbl[12]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_preload([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort**, int>)(lpVtbl[13]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_buffered(IHTMLTimeRanges** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, IHTMLTimeRanges**, int>)(lpVtbl[14]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int load()
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, int>)(lpVtbl[15]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int canPlayType([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR *")] ushort** canPlay)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, ushort*, ushort**, int>)(lpVtbl[16]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), type, canPlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_seeking([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[17]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_currentTime(float v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float, int>)(lpVtbl[18]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_currentTime(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[19]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_initialTime(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[20]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_duration(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[21]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_paused([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[22]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_defaultPlaybackRate(float v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float, int>)(lpVtbl[23]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_defaultPlaybackRate(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[24]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_playbackRate(float v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float, int>)(lpVtbl[25]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_playbackRate(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[26]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_played(IHTMLTimeRanges** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, IHTMLTimeRanges**, int>)(lpVtbl[27]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_seekable(IHTMLTimeRanges** p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, IHTMLTimeRanges**, int>)(lpVtbl[28]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_ended([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[29]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_autoplay([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[30]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_autoplay([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[31]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_loop([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[32]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_loop([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[33]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int play()
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, int>)(lpVtbl[34]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int pause()
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, int>)(lpVtbl[35]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_controls([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[36]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_controls([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[37]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_volume(float v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float, int>)(lpVtbl[38]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_volume(float* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, float*, int>)(lpVtbl[39]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_muted([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[40]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_muted([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[41]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_autobuffer([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short, int>)(lpVtbl[42]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_autobuffer([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMediaElement*, short*, int>)(lpVtbl[43]))((IHTMLMediaElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
