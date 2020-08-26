// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("19666FB4-BABE-4C55-BC03-0A074DA37E2A")]
    [NativeTypeName("struct IMFSourceBufferAppendMode : IUnknown")]
    public unsafe partial struct IMFSourceBufferAppendMode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceBufferAppendMode*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSourceBufferAppendMode*, uint>)(lpVtbl[1]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSourceBufferAppendMode*, uint>)(lpVtbl[2]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MF_MSE_APPEND_MODE GetAppendMode()
        {
            return ((delegate* stdcall<IMFSourceBufferAppendMode*, MF_MSE_APPEND_MODE>)(lpVtbl[3]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppendMode(MF_MSE_APPEND_MODE mode)
        {
            return ((delegate* stdcall<IMFSourceBufferAppendMode*, MF_MSE_APPEND_MODE, int>)(lpVtbl[4]))((IMFSourceBufferAppendMode*)Unsafe.AsPointer(ref this), mode);
        }
    }
}
