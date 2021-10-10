// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87E47623-2CEB-45D6-9B88-D8520C4DCBBC")]
    [NativeTypeName("struct IMFSourceBufferNotify : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSourceBufferNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceBufferNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceBufferNotify*, uint>)(lpVtbl[1]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceBufferNotify*, uint>)(lpVtbl[2]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void OnUpdateStart()
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, void>)(lpVtbl[3]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void OnAbort()
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, void>)(lpVtbl[4]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void OnError([NativeTypeName("HRESULT")] int hr)
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, int, void>)(lpVtbl[5]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void OnUpdate()
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, void>)(lpVtbl[6]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void OnUpdateEnd()
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, void>)(lpVtbl[7]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
