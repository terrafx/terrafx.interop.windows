// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E3BC42CD-4E5C-11D3-9144-00104BA11C5E")]
    [NativeTypeName("struct IRedbookDiscMaster : IUnknown")]
    public unsafe partial struct IRedbookDiscMaster
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, Guid*, void**, int>)(lpVtbl[0]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, uint>)(lpVtbl[1]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, uint>)(lpVtbl[2]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTotalAudioTracks([NativeTypeName("long *")] int* pnTracks)
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[3]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnTracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTotalAudioBlocks([NativeTypeName("long *")] int* pnBlocks)
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[4]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUsedAudioBlocks([NativeTypeName("long *")] int* pnBlocks)
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[5]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableAudioTrackBlocks([NativeTypeName("long *")] int* pnBlocks)
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[6]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioBlockSize([NativeTypeName("long *")] int* pnBlockBytes)
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, int*, int>)(lpVtbl[7]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pnBlockBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAudioTrack([NativeTypeName("long")] int nBlocks)
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, int, int>)(lpVtbl[8]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), nBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddAudioTrackBlocks(byte* pby, [NativeTypeName("long")] int cb)
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, byte*, int, int>)(lpVtbl[9]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this), pby, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloseAudioTrack()
        {
            return ((delegate* unmanaged<IRedbookDiscMaster*, int>)(lpVtbl[10]))((IRedbookDiscMaster*)Unsafe.AsPointer(ref this));
        }
    }
}
