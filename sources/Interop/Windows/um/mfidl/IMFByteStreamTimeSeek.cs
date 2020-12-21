// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64976BFA-FB61-4041-9069-8C9A5F659BEB")]
    [NativeTypeName("struct IMFByteStreamTimeSeek : IUnknown")]
    public unsafe partial struct IMFByteStreamTimeSeek
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamTimeSeek*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamTimeSeek*, uint>)(lpVtbl[1]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamTimeSeek*, uint>)(lpVtbl[2]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsTimeSeekSupported([NativeTypeName("BOOL *")] int* pfTimeSeekIsSupported)
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamTimeSeek*, int*, int>)(lpVtbl[3]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this), pfTimeSeekIsSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TimeSeek([NativeTypeName("QWORD")] ulong qwTimePosition)
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamTimeSeek*, ulong, int>)(lpVtbl[4]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this), qwTimePosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimeSeekResult([NativeTypeName("QWORD *")] ulong* pqwStartTime, [NativeTypeName("QWORD *")] ulong* pqwStopTime, [NativeTypeName("QWORD *")] ulong* pqwDuration)
        {
            return ((delegate* unmanaged[Stdcall]<IMFByteStreamTimeSeek*, ulong*, ulong*, ulong*, int>)(lpVtbl[5]))((IMFByteStreamTimeSeek*)Unsafe.AsPointer(ref this), pqwStartTime, pqwStopTime, pqwDuration);
        }
    }
}
