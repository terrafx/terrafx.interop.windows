// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("332E5848-2E15-458E-85C4-C911C0C3D6F4")]
    [NativeTypeName("struct IRandomAccessStreamFileAccessMode : IUnknown")]
    public unsafe partial struct IRandomAccessStreamFileAccessMode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRandomAccessStreamFileAccessMode*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint>)(lpVtbl[1]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint>)(lpVtbl[2]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMode([NativeTypeName("DWORD *")] uint* fileAccessMode)
        {
            return ((delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint*, int>)(lpVtbl[3]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this), fileAccessMode);
        }
    }
}
