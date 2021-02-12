// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45C35144-154E-4797-BED8-D33AE7BF8794")]
    [NativeTypeName("struct ITfCleanupContextDurationSink : IUnknown")]
    public unsafe partial struct ITfCleanupContextDurationSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCleanupContextDurationSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCleanupContextDurationSink*, uint>)(lpVtbl[1]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCleanupContextDurationSink*, uint>)(lpVtbl[2]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStartCleanupContext()
        {
            return ((delegate* unmanaged<ITfCleanupContextDurationSink*, int>)(lpVtbl[3]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnEndCleanupContext()
        {
            return ((delegate* unmanaged<ITfCleanupContextDurationSink*, int>)(lpVtbl[4]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this));
        }
    }
}
