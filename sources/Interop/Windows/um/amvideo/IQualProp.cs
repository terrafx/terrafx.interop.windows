// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IQualProp : IUnknown")]
    public unsafe partial struct IQualProp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IQualProp*, Guid*, void**, int>)(lpVtbl[0]))((IQualProp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQualProp*, uint>)(lpVtbl[1]))((IQualProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQualProp*, uint>)(lpVtbl[2]))((IQualProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FramesDroppedInRenderer([NativeTypeName("int *")] int* pcFrames)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[3]))((IQualProp*)Unsafe.AsPointer(ref this), pcFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FramesDrawn([NativeTypeName("int *")] int* pcFramesDrawn)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[4]))((IQualProp*)Unsafe.AsPointer(ref this), pcFramesDrawn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AvgFrameRate([NativeTypeName("int *")] int* piAvgFrameRate)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[5]))((IQualProp*)Unsafe.AsPointer(ref this), piAvgFrameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Jitter([NativeTypeName("int *")] int* iJitter)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[6]))((IQualProp*)Unsafe.AsPointer(ref this), iJitter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AvgSyncOffset([NativeTypeName("int *")] int* piAvg)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[7]))((IQualProp*)Unsafe.AsPointer(ref this), piAvg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DevSyncOffset([NativeTypeName("int *")] int* piDev)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[8]))((IQualProp*)Unsafe.AsPointer(ref this), piDev);
        }
    }
}
