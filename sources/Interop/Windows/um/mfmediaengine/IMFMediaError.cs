// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC0E10D2-AB2A-4501-A951-06BB1075184C")]
    [NativeTypeName("struct IMFMediaError : IUnknown")]
    public unsafe partial struct IMFMediaError
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaError*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaError*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaError*, uint>)(lpVtbl[1]))((IMFMediaError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaError*, uint>)(lpVtbl[2]))((IMFMediaError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("USHORT")]
        public ushort GetErrorCode()
        {
            return ((delegate* stdcall<IMFMediaError*, ushort>)(lpVtbl[3]))((IMFMediaError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtendedErrorCode()
        {
            return ((delegate* stdcall<IMFMediaError*, int>)(lpVtbl[4]))((IMFMediaError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetErrorCode(MF_MEDIA_ENGINE_ERR error)
        {
            return ((delegate* stdcall<IMFMediaError*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[5]))((IMFMediaError*)Unsafe.AsPointer(ref this), error);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetExtendedErrorCode([NativeTypeName("HRESULT")] int error)
        {
            return ((delegate* stdcall<IMFMediaError*, int, int>)(lpVtbl[6]))((IMFMediaError*)Unsafe.AsPointer(ref this), error);
        }
    }
}
