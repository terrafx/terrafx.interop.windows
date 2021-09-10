// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ImageTranscode.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAE86DDD-DC11-421C-B7AB-CC55D1D65C44")]
    [NativeTypeName("struct ITranscodeImage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITranscodeImage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITranscodeImage*, Guid*, void**, int>)(lpVtbl[0]))((ITranscodeImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITranscodeImage*, uint>)(lpVtbl[1]))((ITranscodeImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITranscodeImage*, uint>)(lpVtbl[2]))((ITranscodeImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int TranscodeImage(IShellItem* pShellItem, [NativeTypeName("UINT")] uint uiMaxWidth, [NativeTypeName("UINT")] uint uiMaxHeight, [NativeTypeName("DWORD")] uint flags, IStream* pvImage, [NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged<ITranscodeImage*, IShellItem*, uint, uint, uint, IStream*, uint*, uint*, int>)(lpVtbl[3]))((ITranscodeImage*)Unsafe.AsPointer(ref this), pShellItem, uiMaxWidth, uiMaxHeight, flags, pvImage, puiWidth, puiHeight);
        }
    }
}
