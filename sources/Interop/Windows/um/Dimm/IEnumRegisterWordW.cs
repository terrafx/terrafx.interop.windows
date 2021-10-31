// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4955DD31-B159-11D0-8FCF-00AA006BCC59")]
    [NativeTypeName("struct IEnumRegisterWordW : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumRegisterWordW
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumRegisterWordW*, Guid*, void**, int>)(lpVtbl[0]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumRegisterWordW*, uint>)(lpVtbl[1]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumRegisterWordW*, uint>)(lpVtbl[2]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Clone(IEnumRegisterWordW** ppEnum)
        {
            return ((delegate* unmanaged<IEnumRegisterWordW*, IEnumRegisterWordW**, int>)(lpVtbl[3]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, REGISTERWORDW* rgRegisterWord, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumRegisterWordW*, uint, REGISTERWORDW*, uint*, int>)(lpVtbl[4]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this), ulCount, rgRegisterWord, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumRegisterWordW*, int>)(lpVtbl[5]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumRegisterWordW*, uint, int>)(lpVtbl[6]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
