// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFF8E175-019E-11D3-A08E-00C04F8EF9B5")]
    [NativeTypeName("struct ISpeechAudio : ISpeechBaseStream")]
    public unsafe partial struct ISpeechAudio
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechAudio*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechAudio*, uint>)(lpVtbl[1]))((ISpeechAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechAudio*, uint>)(lpVtbl[2]))((ISpeechAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechAudio*, uint*, int>)(lpVtbl[3]))((ISpeechAudio*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechAudio*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechAudio*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechAudio*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechAudio*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechAudio*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechAudio*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Format([NativeTypeName("ISpeechAudioFormat **")] ISpeechAudioFormat** AudioFormat)
        {
            return ((delegate* stdcall<ISpeechAudio*, ISpeechAudioFormat**, int>)(lpVtbl[7]))((ISpeechAudio*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_Format([NativeTypeName("ISpeechAudioFormat *")] ISpeechAudioFormat* AudioFormat)
        {
            return ((delegate* stdcall<ISpeechAudio*, ISpeechAudioFormat*, int>)(lpVtbl[8]))((ISpeechAudio*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("VARIANT *")] VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead)
        {
            return ((delegate* stdcall<ISpeechAudio*, VARIANT*, int, int*, int>)(lpVtbl[9]))((ISpeechAudio*)Unsafe.AsPointer(ref this), Buffer, NumberOfBytes, BytesRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten)
        {
            return ((delegate* stdcall<ISpeechAudio*, VARIANT, int*, int>)(lpVtbl[10]))((ISpeechAudio*)Unsafe.AsPointer(ref this), Buffer, BytesWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, [NativeTypeName("VARIANT *")] VARIANT* NewPosition)
        {
            return ((delegate* stdcall<ISpeechAudio*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int>)(lpVtbl[11]))((ISpeechAudio*)Unsafe.AsPointer(ref this), Position, Origin, NewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Status([NativeTypeName("ISpeechAudioStatus **")] ISpeechAudioStatus** Status)
        {
            return ((delegate* stdcall<ISpeechAudio*, ISpeechAudioStatus**, int>)(lpVtbl[12]))((ISpeechAudio*)Unsafe.AsPointer(ref this), Status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BufferInfo([NativeTypeName("ISpeechAudioBufferInfo **")] ISpeechAudioBufferInfo** BufferInfo)
        {
            return ((delegate* stdcall<ISpeechAudio*, ISpeechAudioBufferInfo**, int>)(lpVtbl[13]))((ISpeechAudio*)Unsafe.AsPointer(ref this), BufferInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DefaultFormat([NativeTypeName("ISpeechAudioFormat **")] ISpeechAudioFormat** StreamFormat)
        {
            return ((delegate* stdcall<ISpeechAudio*, ISpeechAudioFormat**, int>)(lpVtbl[14]))((ISpeechAudio*)Unsafe.AsPointer(ref this), StreamFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Volume([NativeTypeName("long *")] int* Volume)
        {
            return ((delegate* stdcall<ISpeechAudio*, int*, int>)(lpVtbl[15]))((ISpeechAudio*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Volume([NativeTypeName("long")] int Volume)
        {
            return ((delegate* stdcall<ISpeechAudio*, int, int>)(lpVtbl[16]))((ISpeechAudio*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BufferNotifySize([NativeTypeName("long *")] int* BufferNotifySize)
        {
            return ((delegate* stdcall<ISpeechAudio*, int*, int>)(lpVtbl[17]))((ISpeechAudio*)Unsafe.AsPointer(ref this), BufferNotifySize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BufferNotifySize([NativeTypeName("long")] int BufferNotifySize)
        {
            return ((delegate* stdcall<ISpeechAudio*, int, int>)(lpVtbl[18]))((ISpeechAudio*)Unsafe.AsPointer(ref this), BufferNotifySize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EventHandle([NativeTypeName("long *")] int* EventHandle)
        {
            return ((delegate* stdcall<ISpeechAudio*, int*, int>)(lpVtbl[19]))((ISpeechAudio*)Unsafe.AsPointer(ref this), EventHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetState(SpeechAudioState State)
        {
            return ((delegate* stdcall<ISpeechAudio*, SpeechAudioState, int>)(lpVtbl[20]))((ISpeechAudio*)Unsafe.AsPointer(ref this), State);
        }
    }
}
