// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("15806F6E-1D70-4B48-98E6-3B1A007509AB")]
    [NativeTypeName("struct ISpMMSysAudio : ISpAudio")]
    [NativeInheritance("ISpAudio")]
    public unsafe partial struct ISpMMSysAudio
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, Guid*, void**, int>)(lpVtbl[0]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint>)(lpVtbl[1]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint>)(lpVtbl[2]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, void*, uint, uint*, int>)(lpVtbl[3]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, void*, uint, uint*, int>)(lpVtbl[4]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[8]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, int>)(lpVtbl[9]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, STATSTG*, uint, int>)(lpVtbl[12]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IStream** ppstm)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, IStream**, int>)(lpVtbl[13]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormat([NativeTypeName("GUID *")] Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[14]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetState(SPAUDIOSTATE NewState, [NativeTypeName("ULONGLONG")] ulong ullReserved)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, SPAUDIOSTATE, ulong, int>)(lpVtbl[15]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), NewState, ullReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetFormat([NativeTypeName("const GUID &")] Guid* rguidFmtId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[16]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), rguidFmtId, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus(SPAUDIOSTATUS* pStatus)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, SPAUDIOSTATUS*, int>)(lpVtbl[17]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int SetBufferInfo([NativeTypeName("const SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[18]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferInfo(SPAUDIOBUFFERINFO* pBuffInfo)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[19]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFormat([NativeTypeName("GUID *")] Guid* pFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[20]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pFormatId, ppCoMemWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr EventHandle()
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, IntPtr>)(lpVtbl[21]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetVolumeLevel([NativeTypeName("ULONG *")] uint* pLevel)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint*, int>)(lpVtbl[22]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolumeLevel([NativeTypeName("ULONG")] uint Level)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[23]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int GetBufferNotifySize([NativeTypeName("ULONG *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint*, int>)(lpVtbl[24]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int SetBufferNotifySize([NativeTypeName("ULONG")] uint cbSize)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[25]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), cbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceId([NativeTypeName("UINT *")] uint* puDeviceId)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint*, int>)(lpVtbl[26]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), puDeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SetDeviceId([NativeTypeName("UINT")] uint uDeviceId)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[27]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), uDeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int GetMMHandle(void** pHandle)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, void**, int>)(lpVtbl[28]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineId([NativeTypeName("UINT *")] uint* puLineId)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint*, int>)(lpVtbl[29]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), puLineId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineId([NativeTypeName("UINT")] uint uLineId)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[30]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), uLineId);
        }
    }
}
