// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08C03412-F96B-11D0-A475-00AA006BCC59")]
    [NativeTypeName("struct IEnumRegisterWordA : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumRegisterWordA
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumRegisterWordA*, Guid*, void**, int>)(lpVtbl[0]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumRegisterWordA*, uint>)(lpVtbl[1]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumRegisterWordA*, uint>)(lpVtbl[2]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumRegisterWordA** ppEnum)
        {
            return ((delegate* unmanaged<IEnumRegisterWordA*, IEnumRegisterWordA**, int>)(lpVtbl[3]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, REGISTERWORDA* rgRegisterWord, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumRegisterWordA*, uint, REGISTERWORDA*, uint*, int>)(lpVtbl[4]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this), ulCount, rgRegisterWord, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumRegisterWordA*, int>)(lpVtbl[5]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumRegisterWordA*, uint, int>)(lpVtbl[6]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
