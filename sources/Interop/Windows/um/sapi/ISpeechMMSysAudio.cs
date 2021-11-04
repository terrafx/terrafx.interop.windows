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
    [NativeInheritance("ISpeechAudio")]
    public unsafe partial struct ISpeechMMSysAudio : ISpeechMMSysAudio.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, uint>)(lpVtbl[1]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, uint>)(lpVtbl[2]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, uint*, int>)(lpVtbl[3]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Format(ISpeechAudioFormat** AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat**, int>)(lpVtbl[7]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT putref_Format(ISpeechAudioFormat* AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat*, int>)(lpVtbl[8]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Read(VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, VARIANT*, int, int*, int>)(lpVtbl[9]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Buffer, NumberOfBytes, BytesRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, VARIANT, int*, int>)(lpVtbl[10]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Buffer, BytesWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, VARIANT* NewPosition)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int>)(lpVtbl[11]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Position, Origin, NewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_Status(ISpeechAudioStatus** Status)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioStatus**, int>)(lpVtbl[12]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_BufferInfo(ISpeechAudioBufferInfo** BufferInfo)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioBufferInfo**, int>)(lpVtbl[13]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), BufferInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_DefaultFormat(ISpeechAudioFormat** StreamFormat)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat**, int>)(lpVtbl[14]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), StreamFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_Volume([NativeTypeName("long *")] int* Volume)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[15]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_Volume([NativeTypeName("long")] int Volume)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, int>)(lpVtbl[16]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_BufferNotifySize([NativeTypeName("long *")] int* BufferNotifySize)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[17]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), BufferNotifySize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_BufferNotifySize([NativeTypeName("long")] int BufferNotifySize)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, int>)(lpVtbl[18]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), BufferNotifySize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_EventHandle([NativeTypeName("long *")] int* EventHandle)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[19]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), EventHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetState(SpeechAudioState State)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, SpeechAudioState, int>)(lpVtbl[20]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_DeviceId([NativeTypeName("long *")] int* DeviceId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[21]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), DeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_DeviceId([NativeTypeName("long")] int DeviceId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, int>)(lpVtbl[22]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), DeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_LineId([NativeTypeName("long *")] int* LineId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[23]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), LineId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_LineId([NativeTypeName("long")] int LineId)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int, int>)(lpVtbl[24]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), LineId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_MMHandle([NativeTypeName("long *")] int* Handle)
        {
            return ((delegate* unmanaged<ISpeechMMSysAudio*, int*, int>)(lpVtbl[25]))((ISpeechMMSysAudio*)Unsafe.AsPointer(ref this), Handle);
        }

        public interface Interface : ISpeechAudio.Interface
        {
            [VtblIndex(21)]
            HRESULT get_DeviceId([NativeTypeName("long *")] int* DeviceId);

            [VtblIndex(22)]
            HRESULT put_DeviceId([NativeTypeName("long")] int DeviceId);

            [VtblIndex(23)]
            HRESULT get_LineId([NativeTypeName("long *")] int* LineId);

            [VtblIndex(24)]
            HRESULT put_LineId([NativeTypeName("long")] int LineId);

            [VtblIndex(25)]
            HRESULT get_MMHandle([NativeTypeName("long *")] int* Handle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (ISpeechAudioFormat **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat**, int> get_Format;

            [NativeTypeName("HRESULT (ISpeechAudioFormat *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat*, int> putref_Format;

            [NativeTypeName("HRESULT (VARIANT *, long, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, VARIANT*, int, int*, int> Read;

            [NativeTypeName("HRESULT (VARIANT, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, VARIANT, int*, int> Write;

            [NativeTypeName("HRESULT (VARIANT, SpeechStreamSeekPositionType, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int> Seek;

            [NativeTypeName("HRESULT (ISpeechAudioStatus **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioStatus**, int> get_Status;

            [NativeTypeName("HRESULT (ISpeechAudioBufferInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioBufferInfo**, int> get_BufferInfo;

            [NativeTypeName("HRESULT (ISpeechAudioFormat **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, ISpeechAudioFormat**, int> get_DefaultFormat;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int*, int> get_Volume;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int, int> put_Volume;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int*, int> get_BufferNotifySize;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int, int> put_BufferNotifySize;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int*, int> get_EventHandle;

            [NativeTypeName("HRESULT (SpeechAudioState) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, SpeechAudioState, int> SetState;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int*, int> get_DeviceId;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int, int> put_DeviceId;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int*, int> get_LineId;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int, int> put_LineId;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMMSysAudio*, int*, int> get_MMHandle;
        }
    }
}
