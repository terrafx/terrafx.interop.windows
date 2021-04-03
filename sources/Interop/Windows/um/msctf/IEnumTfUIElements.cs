// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("887AA91E-ACBA-4931-84DA-3C5208CF543F")]
    [NativeTypeName("struct IEnumTfUIElements : IUnknown")]
    public unsafe partial struct IEnumTfUIElements
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfUIElements*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfUIElements*, uint>)(lpVtbl[1]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfUIElements*, uint>)(lpVtbl[2]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfUIElements** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfUIElements*, IEnumTfUIElements**, int>)(lpVtbl[3]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, ITfUIElement** ppElement, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfUIElements*, uint, ITfUIElement**, uint*, int>)(lpVtbl[4]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this), ulCount, ppElement, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfUIElements*, int>)(lpVtbl[5]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfUIElements*, uint, int>)(lpVtbl[6]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
