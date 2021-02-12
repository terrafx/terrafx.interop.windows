// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A2DE3BC1-3D8E-11D3-81A9-F753FBE61A00")]
    [NativeTypeName("struct ITextStoreAnchorEx : IUnknown")]
    public unsafe partial struct ITextStoreAnchorEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreAnchorEx*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreAnchorEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreAnchorEx*, uint>)(lpVtbl[1]))((ITextStoreAnchorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreAnchorEx*, uint>)(lpVtbl[2]))((ITextStoreAnchorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ScrollToRect([NativeTypeName("IAnchor *")] IAnchor* pStart, [NativeTypeName("IAnchor *")] IAnchor* pEnd, RECT rc, [NativeTypeName("DWORD")] uint dwPosition)
        {
            return ((delegate* unmanaged<ITextStoreAnchorEx*, IAnchor*, IAnchor*, RECT, uint, int>)(lpVtbl[3]))((ITextStoreAnchorEx*)Unsafe.AsPointer(ref this), pStart, pEnd, rc, dwPosition);
        }
    }
}
