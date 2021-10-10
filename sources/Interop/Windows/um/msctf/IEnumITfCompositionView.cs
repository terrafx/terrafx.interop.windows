// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5EFD22BA-7838-46CB-88E2-CADB14124F8F")]
    [NativeTypeName("struct IEnumITfCompositionView : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumITfCompositionView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumITfCompositionView*, Guid*, void**, int>)(lpVtbl[0]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumITfCompositionView*, uint>)(lpVtbl[1]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumITfCompositionView*, uint>)(lpVtbl[2]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumITfCompositionView** ppEnum)
        {
            return ((delegate* unmanaged<IEnumITfCompositionView*, IEnumITfCompositionView**, int>)(lpVtbl[3]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, ITfCompositionView** rgCompositionView, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumITfCompositionView*, uint, ITfCompositionView**, uint*, int>)(lpVtbl[4]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this), ulCount, rgCompositionView, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumITfCompositionView*, int>)(lpVtbl[5]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumITfCompositionView*, uint, int>)(lpVtbl[6]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
