// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E46A9787-2B71-444D-A4B5-1FAB7B708D6A")]
    [NativeTypeName("struct IVideoFrameStep : IUnknown")]
    public unsafe partial struct IVideoFrameStep
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVideoFrameStep*, Guid*, void**, int>)(lpVtbl[0]))((IVideoFrameStep*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVideoFrameStep*, uint>)(lpVtbl[1]))((IVideoFrameStep*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVideoFrameStep*, uint>)(lpVtbl[2]))((IVideoFrameStep*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Step([NativeTypeName("DWORD")] uint dwFrames, [NativeTypeName("IUnknown *")] IUnknown* pStepObject)
        {
            return ((delegate* unmanaged<IVideoFrameStep*, uint, IUnknown*, int>)(lpVtbl[3]))((IVideoFrameStep*)Unsafe.AsPointer(ref this), dwFrames, pStepObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanStep([NativeTypeName("long")] int bMultiple, [NativeTypeName("IUnknown *")] IUnknown* pStepObject)
        {
            return ((delegate* unmanaged<IVideoFrameStep*, int, IUnknown*, int>)(lpVtbl[4]))((IVideoFrameStep*)Unsafe.AsPointer(ref this), bMultiple, pStepObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelStep()
        {
            return ((delegate* unmanaged<IVideoFrameStep*, int>)(lpVtbl[5]))((IVideoFrameStep*)Unsafe.AsPointer(ref this));
        }
    }
}
