// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BCC18B79-BA16-442F-80C4-8A59C30C463B")]
    [NativeTypeName("struct IShellItemImageFactory : IUnknown")]
    public unsafe partial struct IShellItemImageFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellItemImageFactory*, Guid*, void**, int>)(lpVtbl[0]))((IShellItemImageFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellItemImageFactory*, uint>)(lpVtbl[1]))((IShellItemImageFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellItemImageFactory*, uint>)(lpVtbl[2]))((IShellItemImageFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImage(SIZE size, [NativeTypeName("SIIGBF")] int flags, [NativeTypeName("HBITMAP *")] IntPtr* phbm)
        {
            return ((delegate* unmanaged<IShellItemImageFactory*, SIZE, int, IntPtr*, int>)(lpVtbl[3]))((IShellItemImageFactory*)Unsafe.AsPointer(ref this), size, flags, phbm);
        }
    }
}
