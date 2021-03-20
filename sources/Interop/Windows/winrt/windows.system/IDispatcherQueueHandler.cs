// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DFA2DC9C-1A2D-4917-98F2-939AF1D6E0C8")]
    [NativeTypeName("struct IDispatcherQueueHandler : IUnknown")]
    public unsafe partial struct IDispatcherQueueHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDispatcherQueueHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDispatcherQueueHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDispatcherQueueHandler*, uint>)(lpVtbl[1]))((IDispatcherQueueHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDispatcherQueueHandler*, uint>)(lpVtbl[2]))((IDispatcherQueueHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke()
        {
            return ((delegate* unmanaged<IDispatcherQueueHandler*, int>)(lpVtbl[3]))((IDispatcherQueueHandler*)Unsafe.AsPointer(ref this));
        }
    }
}
