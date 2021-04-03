// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45101AB7-7C3A-4BCE-9500-12C09024B298")]
    [NativeTypeName("struct ICastingSourceInfo : IUnknown")]
    public unsafe partial struct ICastingSourceInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICastingSourceInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICastingSourceInfo*, uint>)(lpVtbl[1]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICastingSourceInfo*, uint>)(lpVtbl[2]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetController(ICastingController** controller)
        {
            return ((delegate* unmanaged<ICastingSourceInfo*, ICastingController**, int>)(lpVtbl[3]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this), controller);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties(INamedPropertyStore** props)
        {
            return ((delegate* unmanaged<ICastingSourceInfo*, INamedPropertyStore**, int>)(lpVtbl[4]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this), props);
        }
    }
}
