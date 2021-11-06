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
    public unsafe partial struct ISpMMSysAudio : ISpMMSysAudio.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, void*, uint, uint*, int>)(lpVtbl[3]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, void*, uint, uint*, int>)(lpVtbl[4]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[8]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Revert()
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, int>)(lpVtbl[9]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, STATSTG*, uint, int>)(lpVtbl[12]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Clone(IStream** ppstm)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, IStream**, int>)(lpVtbl[13]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetFormat(Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[14]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetState(SPAUDIOSTATE NewState, [NativeTypeName("ULONGLONG")] ulong ullReserved)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, SPAUDIOSTATE, ulong, int>)(lpVtbl[15]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), NewState, ullReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetFormat([NativeTypeName("const GUID &")] Guid* rguidFmtId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[16]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), rguidFmtId, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetStatus(SPAUDIOSTATUS* pStatus)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, SPAUDIOSTATUS*, int>)(lpVtbl[17]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetBufferInfo([NativeTypeName("const SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[18]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetBufferInfo(SPAUDIOBUFFERINFO* pBuffInfo)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[19]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetDefaultFormat(Guid* pFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[20]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pFormatId, ppCoMemWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HANDLE EventHandle()
        {
            return ((HANDLE)(((delegate* unmanaged<ISpMMSysAudio*, void*>)(lpVtbl[21]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetVolumeLevel([NativeTypeName("ULONG *")] uint* pLevel)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint*, int>)(lpVtbl[22]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetVolumeLevel([NativeTypeName("ULONG")] uint Level)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[23]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetBufferNotifySize([NativeTypeName("ULONG *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint*, int>)(lpVtbl[24]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetBufferNotifySize([NativeTypeName("ULONG")] uint cbSize)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[25]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), cbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetDeviceId(uint* puDeviceId)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint*, int>)(lpVtbl[26]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), puDeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetDeviceId(uint uDeviceId)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[27]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), uDeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetMMHandle(void** pHandle)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, void**, int>)(lpVtbl[28]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetLineId(uint* puLineId)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint*, int>)(lpVtbl[29]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), puLineId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT SetLineId(uint uLineId)
        {
            return ((delegate* unmanaged<ISpMMSysAudio*, uint, int>)(lpVtbl[30]))((ISpMMSysAudio*)Unsafe.AsPointer(ref this), uLineId);
        }

        public interface Interface : ISpAudio.Interface
        {
            [VtblIndex(26)]
            HRESULT GetDeviceId(uint* puDeviceId);

            [VtblIndex(27)]
            HRESULT SetDeviceId(uint uDeviceId);

            [VtblIndex(28)]
            HRESULT GetMMHandle(void** pHandle);

            [VtblIndex(29)]
            HRESULT GetLineId(uint* puLineId);

            [VtblIndex(30)]
            HRESULT SetLineId(uint uLineId);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint> Release;

            [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, void*, uint, uint*, int> Read;

            [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, void*, uint, uint*, int> Write;

            [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

            [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, int> SetSize;

            [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> CopyTo;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint, int> Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, int> Revert;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> LockRegion;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> UnlockRegion;

            [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, STATSTG*, uint, int> Stat;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, IStream**, int> Clone;

            [NativeTypeName("HRESULT (GUID *, WAVEFORMATEX **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX**, int> GetFormat;

            [NativeTypeName("HRESULT (SPAUDIOSTATE, ULONGLONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, SPAUDIOSTATE, ulong, int> SetState;

            [NativeTypeName("HRESULT (const GUID &, const WAVEFORMATEX *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX*, int> SetFormat;

            [NativeTypeName("HRESULT (SPAUDIOSTATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, SPAUDIOSTATUS*, int> GetStatus;

            [NativeTypeName("HRESULT (const SPAUDIOBUFFERINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, SPAUDIOBUFFERINFO*, int> SetBufferInfo;

            [NativeTypeName("HRESULT (SPAUDIOBUFFERINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, SPAUDIOBUFFERINFO*, int> GetBufferInfo;

            [NativeTypeName("HRESULT (GUID *, WAVEFORMATEX **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, Guid*, WAVEFORMATEX**, int> GetDefaultFormat;

            [NativeTypeName("HANDLE () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, void*> EventHandle;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint*, int> GetVolumeLevel;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint, int> SetVolumeLevel;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint*, int> GetBufferNotifySize;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint, int> SetBufferNotifySize;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint*, int> GetDeviceId;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint, int> SetDeviceId;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, void**, int> GetMMHandle;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint*, int> GetLineId;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpMMSysAudio*, uint, int> SetLineId;
        }
    }
}
