// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D81F90A3-8156-44F7-AD28-5ABB87003274")]
    [NativeTypeName("struct IProtectFocus : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IProtectFocus
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProtectFocus*, Guid*, void**, int>)(lpVtbl[0]))((IProtectFocus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProtectFocus*, uint>)(lpVtbl[1]))((IProtectFocus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProtectFocus*, uint>)(lpVtbl[2]))((IProtectFocus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AllowFocusChange(BOOL* pfAllow)
        {
            return ((delegate* unmanaged<IProtectFocus*, BOOL*, int>)(lpVtbl[3]))((IProtectFocus*)Unsafe.AsPointer(ref this), pfAllow);
        }
    }
}
