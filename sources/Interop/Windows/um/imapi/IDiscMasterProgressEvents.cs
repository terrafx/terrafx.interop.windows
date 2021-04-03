// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC9E51C1-4E5D-11D3-9144-00104BA11C5E")]
    [NativeTypeName("struct IDiscMasterProgressEvents : IUnknown")]
    public unsafe partial struct IDiscMasterProgressEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, Guid*, void**, int>)(lpVtbl[0]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, uint>)(lpVtbl[1]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, uint>)(lpVtbl[2]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCancel([NativeTypeName("boolean *")] byte* pbCancel)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, byte*, int>)(lpVtbl[3]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), pbCancel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyPnPActivity()
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, int>)(lpVtbl[4]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyAddProgress([NativeTypeName("long")] int nCompletedSteps, [NativeTypeName("long")] int nTotalSteps)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int, int>)(lpVtbl[5]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nCompletedSteps, nTotalSteps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyBlockProgress([NativeTypeName("long")] int nCompleted, [NativeTypeName("long")] int nTotal)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int, int>)(lpVtbl[6]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nCompleted, nTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyTrackProgress([NativeTypeName("long")] int nCurrentTrack, [NativeTypeName("long")] int nTotalTracks)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int, int>)(lpVtbl[7]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nCurrentTrack, nTotalTracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyPreparingBurn([NativeTypeName("long")] int nEstimatedSeconds)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int>)(lpVtbl[8]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nEstimatedSeconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyClosingDisc([NativeTypeName("long")] int nEstimatedSeconds)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int>)(lpVtbl[9]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nEstimatedSeconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyBurnComplete([NativeTypeName("HRESULT")] int status)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int>)(lpVtbl[10]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyEraseComplete([NativeTypeName("HRESULT")] int status)
        {
            return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int>)(lpVtbl[11]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), status);
        }
    }
}
