// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A1EF0D5-1581-4741-88E4-209A49F11A10")]
    [NativeTypeName("struct ISpeechWaveFormatEx : IDispatch")]
    public unsafe partial struct ISpeechWaveFormatEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, uint>)(lpVtbl[1]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, uint>)(lpVtbl[2]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, uint*, int>)(lpVtbl[3]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FormatTag([NativeTypeName("short *")] short* FormatTag)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short*, int>)(lpVtbl[7]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), FormatTag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FormatTag(short FormatTag)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short, int>)(lpVtbl[8]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), FormatTag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Channels([NativeTypeName("short *")] short* Channels)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short*, int>)(lpVtbl[9]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), Channels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Channels(short Channels)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short, int>)(lpVtbl[10]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), Channels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SamplesPerSec([NativeTypeName("long *")] int* SamplesPerSec)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int*, int>)(lpVtbl[11]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), SamplesPerSec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SamplesPerSec([NativeTypeName("long")] int SamplesPerSec)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int, int>)(lpVtbl[12]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), SamplesPerSec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AvgBytesPerSec([NativeTypeName("long *")] int* AvgBytesPerSec)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int*, int>)(lpVtbl[13]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), AvgBytesPerSec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AvgBytesPerSec([NativeTypeName("long")] int AvgBytesPerSec)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, int, int>)(lpVtbl[14]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), AvgBytesPerSec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BlockAlign([NativeTypeName("short *")] short* BlockAlign)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short*, int>)(lpVtbl[15]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), BlockAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BlockAlign(short BlockAlign)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short, int>)(lpVtbl[16]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), BlockAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BitsPerSample([NativeTypeName("short *")] short* BitsPerSample)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short*, int>)(lpVtbl[17]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), BitsPerSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BitsPerSample(short BitsPerSample)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, short, int>)(lpVtbl[18]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), BitsPerSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExtraData([NativeTypeName("VARIANT *")] VARIANT* ExtraData)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, VARIANT*, int>)(lpVtbl[19]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), ExtraData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ExtraData(VARIANT ExtraData)
        {
            return ((delegate* unmanaged<ISpeechWaveFormatEx*, VARIANT, int>)(lpVtbl[20]))((ISpeechWaveFormatEx*)Unsafe.AsPointer(ref this), ExtraData);
        }
    }
}
