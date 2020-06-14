// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("15806F6E-1D70-4B48-98E6-3B1A007509AB")]
    public unsafe partial struct ISpMMSysAudio
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, Guid*, void**, int>)(lpVtbl[0]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint>)(lpVtbl[1]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint>)(lpVtbl[2]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, void*, uint, uint*, int>)(lpVtbl[3]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, void*, uint, uint*, int>)(lpVtbl[4]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint, int>)(lpVtbl[8]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* stdcall<ISpMMSysAudio*, int>)(lpVtbl[9]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, STATSTG*, uint, int>)(lpVtbl[12]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, IStream**, int>)(lpVtbl[13]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormat([NativeTypeName("GUID *")] Guid* pguidFormatId, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[14]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetState(SPAUDIOSTATE NewState, [NativeTypeName("ULONGLONG")] ulong ullReserved)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, SPAUDIOSTATE, ulong, int>)(lpVtbl[15]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), NewState, ullReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFormat([NativeTypeName("const GUID &")] Guid* rguidFmtId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[16]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), rguidFmtId, pWaveFormatEx);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("SPAUDIOSTATUS *")] SPAUDIOSTATUS* pStatus)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, SPAUDIOSTATUS*, int>)(lpVtbl[17]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBufferInfo([NativeTypeName("const SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[18]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBufferInfo([NativeTypeName("SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[19]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFormat([NativeTypeName("GUID *")] Guid* pFormatId, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[20]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pFormatId, ppCoMemWaveFormatEx);
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr EventHandle()
        {
            return ((delegate* stdcall<ISpMMSysAudio*, IntPtr>)(lpVtbl[21]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVolumeLevel([NativeTypeName("ULONG *")] uint* pLevel)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint*, int>)(lpVtbl[22]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVolumeLevel([NativeTypeName("ULONG")] uint Level)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint, int>)(lpVtbl[23]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), Level);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBufferNotifySize([NativeTypeName("ULONG *")] uint* pcbSize)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint*, int>)(lpVtbl[24]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBufferNotifySize([NativeTypeName("ULONG")] uint cbSize)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint, int>)(lpVtbl[25]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), cbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceId([NativeTypeName("UINT *")] uint* puDeviceId)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint*, int>)(lpVtbl[26]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), puDeviceId);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDeviceId([NativeTypeName("UINT")] uint uDeviceId)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint, int>)(lpVtbl[27]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), uDeviceId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMMHandle([NativeTypeName("void **")] void** pHandle)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, void**, int>)(lpVtbl[28]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineId([NativeTypeName("UINT *")] uint* puLineId)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint*, int>)(lpVtbl[29]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), puLineId);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineId([NativeTypeName("UINT")] uint uLineId)
        {
            return ((delegate* stdcall<ISpMMSysAudio*, uint, int>)(lpVtbl[30]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), uLineId);
        }
    }
}
