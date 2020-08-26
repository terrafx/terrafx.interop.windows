// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87E47623-2CEB-45D6-9B88-D8520C4DCBBC")]
    [NativeTypeName("struct IMFSourceBufferNotify : IUnknown")]
    public unsafe partial struct IMFSourceBufferNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceBufferNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSourceBufferNotify*, uint>)(lpVtbl[1]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSourceBufferNotify*, uint>)(lpVtbl[2]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnUpdateStart()
        {
            ((delegate* stdcall<IMFSourceBufferNotify*, void>)(lpVtbl[3]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnAbort()
        {
            ((delegate* stdcall<IMFSourceBufferNotify*, void>)(lpVtbl[4]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnError([NativeTypeName("HRESULT")] int hr)
        {
            ((delegate* stdcall<IMFSourceBufferNotify*, int, void>)(lpVtbl[5]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnUpdate()
        {
            ((delegate* stdcall<IMFSourceBufferNotify*, void>)(lpVtbl[6]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnUpdateEnd()
        {
            ((delegate* stdcall<IMFSourceBufferNotify*, void>)(lpVtbl[7]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
