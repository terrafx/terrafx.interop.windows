// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("670D1D20-A068-11D0-B3F0-00AA003761C5")]
    [NativeTypeName("struct IAMCopyCaptureFileProgress : IUnknown")]
    public unsafe partial struct IAMCopyCaptureFileProgress
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, Guid*, void**, int>)(lpVtbl[0]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, uint>)(lpVtbl[1]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, uint>)(lpVtbl[2]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Progress(int iProgress)
        {
            return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, int, int>)(lpVtbl[3]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this), iProgress);
        }
    }
}
