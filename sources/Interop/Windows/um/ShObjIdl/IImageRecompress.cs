// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("505F1513-6B3E-4892-A272-59F8889A4D3E")]
    [NativeTypeName("struct IImageRecompress : IUnknown")]
    public unsafe partial struct IImageRecompress
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IImageRecompress*, Guid*, void**, int>)(lpVtbl[0]))((IImageRecompress*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IImageRecompress*, uint>)(lpVtbl[1]))((IImageRecompress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IImageRecompress*, uint>)(lpVtbl[2]))((IImageRecompress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RecompressImage(IShellItem* psi, int cx, int cy, int iQuality, IStorage* pstg, IStream** ppstrmOut)
        {
            return ((delegate* unmanaged<IImageRecompress*, IShellItem*, int, int, int, IStorage*, IStream**, int>)(lpVtbl[3]))((IImageRecompress*)Unsafe.AsPointer(ref this), psi, cx, cy, iQuality, pstg, ppstrmOut);
        }
    }
}
