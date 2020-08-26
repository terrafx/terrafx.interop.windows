// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8C7B80BF-EE42-4B59-B1DF-55668E1BDCA8")]
    [NativeTypeName("struct IMFSampleGrabberSinkCallback : IMFClockStateSink")]
    public unsafe partial struct IMFSampleGrabberSinkCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, uint>)(lpVtbl[1]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, uint>)(lpVtbl[2]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockStart([NativeTypeName("MFTIME")] long hnsSystemTime, [NativeTypeName("LONGLONG")] long llClockStartOffset)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, long, long, int>)(lpVtbl[3]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime, llClockStartOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, long, int>)(lpVtbl[4]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, long, int>)(lpVtbl[5]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, long, int>)(lpVtbl[6]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, long, float, int>)(lpVtbl[7]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), hnsSystemTime, flRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetPresentationClock([NativeTypeName("IMFPresentationClock *")] IMFPresentationClock* pPresentationClock)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, IMFPresentationClock*, int>)(lpVtbl[8]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), pPresentationClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnProcessSample([NativeTypeName("const GUID &")] Guid* guidMajorMediaType, [NativeTypeName("DWORD")] uint dwSampleFlags, [NativeTypeName("LONGLONG")] long llSampleTime, [NativeTypeName("LONGLONG")] long llSampleDuration, [NativeTypeName("const BYTE *")] byte* pSampleBuffer, [NativeTypeName("DWORD")] uint dwSampleSize)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, Guid*, uint, long, long, byte*, uint, int>)(lpVtbl[9]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this), guidMajorMediaType, dwSampleFlags, llSampleTime, llSampleDuration, pSampleBuffer, dwSampleSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnShutdown()
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback*, int>)(lpVtbl[10]))((IMFSampleGrabberSinkCallback*)Unsafe.AsPointer(ref this));
        }
    }
}
