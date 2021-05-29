// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C76AF6D-1FD7-4831-81D1-3B71D5A13C44")]
    [NativeTypeName("struct ISpeechMMSysAudio : ISpeechAudio")]
    public unsafe partial struct ISpeechMMSysAudio
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, uint>)(lpVtbl[1]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, uint>)(lpVtbl[2]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, uint*, int>)(lpVtbl[3]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Format(ISpeechAudioFormat** AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat**, int>)(lpVtbl[7]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_Format(ISpeechAudioFormat* AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat*, int>)(lpVtbl[8]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read(VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, VARIANT*, int, int*, int>)(lpVtbl[9]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Buffer, NumberOfBytes, BytesRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, VARIANT, int*, int>)(lpVtbl[10]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Buffer, BytesWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, VARIANT* NewPosition)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int>)(lpVtbl[11]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Position, Origin, NewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Status(ISpeechAudioStatus** Status)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioStatus**, int>)(lpVtbl[12]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BufferInfo(ISpeechAudioBufferInfo** BufferInfo)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioBufferInfo**, int>)(lpVtbl[13]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), BufferInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DefaultFormat(ISpeechAudioFormat** StreamFormat)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat**, int>)(lpVtbl[14]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), StreamFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Volume([NativeTypeName("long *")] int* Volume)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[15]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Volume([NativeTypeName("long")] int Volume)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, int>)(lpVtbl[16]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BufferNotifySize([NativeTypeName("long *")] int* BufferNotifySize)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[17]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), BufferNotifySize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BufferNotifySize([NativeTypeName("long")] int BufferNotifySize)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, int>)(lpVtbl[18]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), BufferNotifySize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EventHandle([NativeTypeName("long *")] int* EventHandle)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[19]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), EventHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetState(SpeechAudioState State)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, SpeechAudioState, int>)(lpVtbl[20]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DeviceId([NativeTypeName("long *")] int* DeviceId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[21]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), DeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DeviceId([NativeTypeName("long")] int DeviceId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, int>)(lpVtbl[22]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), DeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LineId([NativeTypeName("long *")] int* LineId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[23]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), LineId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_LineId([NativeTypeName("long")] int LineId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, int>)(lpVtbl[24]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), LineId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MMHandle([NativeTypeName("long *")] int* Handle)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[25]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Handle);
        }
    }
}
