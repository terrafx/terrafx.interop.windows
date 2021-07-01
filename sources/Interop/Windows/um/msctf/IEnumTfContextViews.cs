// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F0C0F8DD-CF38-44E1-BB0F-68CF0D551C78")]
    [NativeTypeName("struct IEnumTfContextViews : IUnknown")]
    public unsafe partial struct IEnumTfContextViews
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfContextViews*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfContextViews*, uint>)(lpVtbl[1]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfContextViews*, uint>)(lpVtbl[2]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfContextViews** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfContextViews*, IEnumTfContextViews**, int>)(lpVtbl[3]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, ITfContextView** rgViews, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfContextViews*, uint, ITfContextView**, uint*, int>)(lpVtbl[4]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this), ulCount, rgViews, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfContextViews*, int>)(lpVtbl[5]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfContextViews*, uint, int>)(lpVtbl[6]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
