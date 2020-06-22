// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IQualProp
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IQualProp*, Guid*, void**, int>)(lpVtbl[0]))((IQualProp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IQualProp*, uint>)(lpVtbl[1]))((IQualProp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IQualProp*, uint>)(lpVtbl[2]))((IQualProp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_FramesDroppedInRenderer([NativeTypeName("int *")] int* pcFrames)
        {
            return ((delegate* stdcall<IQualProp*, int*, int>)(lpVtbl[3]))((IQualProp*)Unsafe.AsPointer(ref this), pcFrames);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_FramesDrawn([NativeTypeName("int *")] int* pcFramesDrawn)
        {
            return ((delegate* stdcall<IQualProp*, int*, int>)(lpVtbl[4]))((IQualProp*)Unsafe.AsPointer(ref this), pcFramesDrawn);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AvgFrameRate([NativeTypeName("int *")] int* piAvgFrameRate)
        {
            return ((delegate* stdcall<IQualProp*, int*, int>)(lpVtbl[5]))((IQualProp*)Unsafe.AsPointer(ref this), piAvgFrameRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Jitter([NativeTypeName("int *")] int* iJitter)
        {
            return ((delegate* stdcall<IQualProp*, int*, int>)(lpVtbl[6]))((IQualProp*)Unsafe.AsPointer(ref this), iJitter);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AvgSyncOffset([NativeTypeName("int *")] int* piAvg)
        {
            return ((delegate* stdcall<IQualProp*, int*, int>)(lpVtbl[7]))((IQualProp*)Unsafe.AsPointer(ref this), piAvg);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_DevSyncOffset([NativeTypeName("int *")] int* piDev)
        {
            return ((delegate* stdcall<IQualProp*, int*, int>)(lpVtbl[8]))((IQualProp*)Unsafe.AsPointer(ref this), piDev);
        }
    }
}
