// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A1EF0D5-1581-4741-88E4-209A49F11A10")]
    [NativeTypeName("struct ISpeechWaveFormatEx : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechWaveFormatEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, uint>)(lpVtbl[1]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, uint>)(lpVtbl[2]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, uint*, int>)(lpVtbl[3]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_FormatTag(short* FormatTag)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short*, int>)(lpVtbl[7]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), FormatTag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_FormatTag(short FormatTag)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short, int>)(lpVtbl[8]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), FormatTag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Channels(short* Channels)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short*, int>)(lpVtbl[9]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), Channels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_Channels(short Channels)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short, int>)(lpVtbl[10]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), Channels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_SamplesPerSec([NativeTypeName("long *")] int* SamplesPerSec)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int*, int>)(lpVtbl[11]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), SamplesPerSec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_SamplesPerSec([NativeTypeName("long")] int SamplesPerSec)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int, int>)(lpVtbl[12]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), SamplesPerSec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_AvgBytesPerSec([NativeTypeName("long *")] int* AvgBytesPerSec)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int*, int>)(lpVtbl[13]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), AvgBytesPerSec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_AvgBytesPerSec([NativeTypeName("long")] int AvgBytesPerSec)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int, int>)(lpVtbl[14]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), AvgBytesPerSec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_BlockAlign(short* BlockAlign)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short*, int>)(lpVtbl[15]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), BlockAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_BlockAlign(short BlockAlign)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short, int>)(lpVtbl[16]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), BlockAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_BitsPerSample(short* BitsPerSample)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short*, int>)(lpVtbl[17]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), BitsPerSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_BitsPerSample(short BitsPerSample)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short, int>)(lpVtbl[18]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), BitsPerSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_ExtraData(VARIANT* ExtraData)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, VARIANT*, int>)(lpVtbl[19]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), ExtraData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_ExtraData(VARIANT ExtraData)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, VARIANT, int>)(lpVtbl[20]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), ExtraData);
        }
    }
}
