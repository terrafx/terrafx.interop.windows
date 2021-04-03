// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24CD47F7-81D8-4785-ADB2-AF697A963CD2")]
    [NativeTypeName("struct IMFBufferListNotify : IUnknown")]
    public unsafe partial struct IMFBufferListNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFBufferListNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFBufferListNotify*, uint>)(lpVtbl[1]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFBufferListNotify*, uint>)(lpVtbl[2]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnAddSourceBuffer()
        {
            ((delegate* unmanaged<IMFBufferListNotify*, void>)(lpVtbl[3]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnRemoveSourceBuffer()
        {
            ((delegate* unmanaged<IMFBufferListNotify*, void>)(lpVtbl[4]))((IMFBufferListNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
