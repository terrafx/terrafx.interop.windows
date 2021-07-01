// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("583F34D0-DE25-11D2-AFDD-00105A2799B5")]
    [NativeTypeName("struct IEnumTfLangBarItems : IUnknown")]
    public unsafe partial struct IEnumTfLangBarItems
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfLangBarItems*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfLangBarItems*, uint>)(lpVtbl[1]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfLangBarItems*, uint>)(lpVtbl[2]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfLangBarItems** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfLangBarItems*, IEnumTfLangBarItems**, int>)(lpVtbl[3]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, ITfLangBarItem** ppItem, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfLangBarItems*, uint, ITfLangBarItem**, uint*, int>)(lpVtbl[4]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this), ulCount, ppItem, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfLangBarItems*, int>)(lpVtbl[5]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfLangBarItems*, uint, int>)(lpVtbl[6]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
