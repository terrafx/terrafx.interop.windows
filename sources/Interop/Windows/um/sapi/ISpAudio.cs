// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C05C768F-FAE8-4EC2-8E07-338321C12452")]
    [NativeTypeName("struct ISpAudio : ISpStreamFormat")]
    public unsafe partial struct ISpAudio
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpAudio*, Guid*, void**, int>)(lpVtbl[0]))((ISpAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpAudio*, uint>)(lpVtbl[1]))((ISpAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpAudio*, uint>)(lpVtbl[2]))((ISpAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<ISpAudio*, void*, uint, uint*, int>)(lpVtbl[3]))((ISpAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<ISpAudio*, void*, uint, uint*, int>)(lpVtbl[4]))((ISpAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* stdcall<ISpAudio*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((ISpAudio*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* stdcall<ISpAudio*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ISpAudio*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* stdcall<ISpAudio*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ISpAudio*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* stdcall<ISpAudio*, uint, int>)(lpVtbl[8]))((ISpAudio*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* stdcall<ISpAudio*, int>)(lpVtbl[9]))((ISpAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<ISpAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((ISpAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<ISpAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((ISpAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* stdcall<ISpAudio*, STATSTG*, uint, int>)(lpVtbl[12]))((ISpAudio*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return ((delegate* stdcall<ISpAudio*, IStream**, int>)(lpVtbl[13]))((ISpAudio*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormat([NativeTypeName("GUID *")] Guid* pguidFormatId, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* stdcall<ISpAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[14]))((ISpAudio*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetState(SPAUDIOSTATE NewState, [NativeTypeName("ULONGLONG")] ulong ullReserved)
        {
            return ((delegate* stdcall<ISpAudio*, SPAUDIOSTATE, ulong, int>)(lpVtbl[15]))((ISpAudio*)Unsafe.AsPointer(ref this), NewState, ullReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFormat([NativeTypeName("const GUID &")] Guid* rguidFmtId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* stdcall<ISpAudio*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[16]))((ISpAudio*)Unsafe.AsPointer(ref this), rguidFmtId, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("SPAUDIOSTATUS *")] SPAUDIOSTATUS* pStatus)
        {
            return ((delegate* stdcall<ISpAudio*, SPAUDIOSTATUS*, int>)(lpVtbl[17]))((ISpAudio*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBufferInfo([NativeTypeName("const SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo)
        {
            return ((delegate* stdcall<ISpAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[18]))((ISpAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferInfo([NativeTypeName("SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo)
        {
            return ((delegate* stdcall<ISpAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[19]))((ISpAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFormat([NativeTypeName("GUID *")] Guid* pFormatId, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* stdcall<ISpAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[20]))((ISpAudio*)Unsafe.AsPointer(ref this), pFormatId, ppCoMemWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr EventHandle()
        {
            return ((delegate* stdcall<ISpAudio*, IntPtr>)(lpVtbl[21]))((ISpAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVolumeLevel([NativeTypeName("ULONG *")] uint* pLevel)
        {
            return ((delegate* stdcall<ISpAudio*, uint*, int>)(lpVtbl[22]))((ISpAudio*)Unsafe.AsPointer(ref this), pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolumeLevel([NativeTypeName("ULONG")] uint Level)
        {
            return ((delegate* stdcall<ISpAudio*, uint, int>)(lpVtbl[23]))((ISpAudio*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferNotifySize([NativeTypeName("ULONG *")] uint* pcbSize)
        {
            return ((delegate* stdcall<ISpAudio*, uint*, int>)(lpVtbl[24]))((ISpAudio*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBufferNotifySize([NativeTypeName("ULONG")] uint cbSize)
        {
            return ((delegate* stdcall<ISpAudio*, uint, int>)(lpVtbl[25]))((ISpAudio*)Unsafe.AsPointer(ref this), cbSize);
        }
    }
}
