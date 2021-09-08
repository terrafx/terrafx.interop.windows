// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("826ABE3D-3ACD-47D3-84F2-88AAEDCF6304")]
    [NativeTypeName("struct IOplockBreakingHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOplockBreakingHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOplockBreakingHandler*, Guid*, void**, int>)(lpVtbl[0]))((IOplockBreakingHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOplockBreakingHandler*, uint>)(lpVtbl[1]))((IOplockBreakingHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOplockBreakingHandler*, uint>)(lpVtbl[2]))((IOplockBreakingHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OplockBreaking()
        {
            return ((delegate* unmanaged<IOplockBreakingHandler*, int>)(lpVtbl[3]))((IOplockBreakingHandler*)Unsafe.AsPointer(ref this));
        }
    }
}
