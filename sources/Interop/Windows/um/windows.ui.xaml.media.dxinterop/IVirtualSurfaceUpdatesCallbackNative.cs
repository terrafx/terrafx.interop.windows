// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DBF2E947-8E6C-4254-9EEE-7738F71386C9")]
    [NativeTypeName("struct IVirtualSurfaceUpdatesCallbackNative : IUnknown")]
    public unsafe partial struct IVirtualSurfaceUpdatesCallbackNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVirtualSurfaceUpdatesCallbackNative*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVirtualSurfaceUpdatesCallbackNative*, uint>)(lpVtbl[1]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVirtualSurfaceUpdatesCallbackNative*, uint>)(lpVtbl[2]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdatesNeeded()
        {
            return ((delegate* stdcall<IVirtualSurfaceUpdatesCallbackNative*, int>)(lpVtbl[3]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
        }
    }
}
