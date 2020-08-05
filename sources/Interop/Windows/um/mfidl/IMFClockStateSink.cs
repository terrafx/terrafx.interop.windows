// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F6696E82-74F7-4F3D-A178-8A5E09C3659F")]
    [NativeTypeName("struct IMFClockStateSink : IUnknown")]
    public unsafe partial struct IMFClockStateSink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFClockStateSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFClockStateSink*, uint>)(lpVtbl[1]))((IMFClockStateSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFClockStateSink*, uint>)(lpVtbl[2]))((IMFClockStateSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockStart([NativeTypeName("MFTIME")] long hnsSystemTime, [NativeTypeName("LONGLONG")] long llClockStartOffset)
        {
            return ((delegate* stdcall<IMFClockStateSink*, long, long, int>)(lpVtbl[3]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime, llClockStartOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFClockStateSink*, long, int>)(lpVtbl[4]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFClockStateSink*, long, int>)(lpVtbl[5]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFClockStateSink*, long, int>)(lpVtbl[6]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate)
        {
            return ((delegate* stdcall<IMFClockStateSink*, long, float, int>)(lpVtbl[7]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime, flRate);
        }
    }
}
