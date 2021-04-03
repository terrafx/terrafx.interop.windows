// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("75CF3930-3244-4FE0-A8C8-E0BCB270B889")]
    [NativeTypeName("struct IAppxBlockMapBlock : IUnknown")]
    public unsafe partial struct IAppxBlockMapBlock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlock*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBlockMapBlock*, uint>)(lpVtbl[1]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBlockMapBlock*, uint>)(lpVtbl[2]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHash([NativeTypeName("UINT32 *")] uint* bufferSize, [NativeTypeName("BYTE **")] byte** buffer)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlock*, uint*, byte**, int>)(lpVtbl[3]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this), bufferSize, buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCompressedSize([NativeTypeName("UINT32 *")] uint* size)
        {
            return ((delegate* unmanaged<IAppxBlockMapBlock*, uint*, int>)(lpVtbl[4]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this), size);
        }
    }
}
