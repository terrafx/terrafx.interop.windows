// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DCDAA858-895A-4A22-A5EB-67BDA506096D")]
    [NativeTypeName("struct IAudioFormatEnumerator : IUnknown")]
    public unsafe partial struct IAudioFormatEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioFormatEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioFormatEnumerator*, uint>)(lpVtbl[1]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAudioFormatEnumerator*, uint>)(lpVtbl[2]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* count)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioFormatEnumerator*, uint*, int>)(lpVtbl[3]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormat([NativeTypeName("UINT32")] uint index, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** format)
        {
            return ((delegate* unmanaged[Stdcall]<IAudioFormatEnumerator*, uint, WAVEFORMATEX**, int>)(lpVtbl[4]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), index, format);
        }
    }
}
