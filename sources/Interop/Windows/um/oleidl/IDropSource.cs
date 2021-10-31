// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000121-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IDropSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDropSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDropSource*, Guid*, void**, int>)(lpVtbl[0]))((IDropSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDropSource*, uint>)(lpVtbl[1]))((IDropSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDropSource*, uint>)(lpVtbl[2]))((IDropSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryContinueDrag(BOOL fEscapePressed, [NativeTypeName("DWORD")] uint grfKeyState)
        {
            return ((delegate* unmanaged<IDropSource*, BOOL, uint, int>)(lpVtbl[3]))((IDropSource*)Unsafe.AsPointer(ref this), fEscapePressed, grfKeyState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GiveFeedback([NativeTypeName("DWORD")] uint dwEffect)
        {
            return ((delegate* unmanaged<IDropSource*, uint, int>)(lpVtbl[4]))((IDropSource*)Unsafe.AsPointer(ref this), dwEffect);
        }
    }
}
