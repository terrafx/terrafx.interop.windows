// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("42D4D099-7C1A-4A89-B836-6C6F22160DF0")]
    [NativeTypeName("struct ITfEditRecord : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfEditRecord
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfEditRecord*, Guid*, void**, int>)(lpVtbl[0]))((ITfEditRecord*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfEditRecord*, uint>)(lpVtbl[1]))((ITfEditRecord*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfEditRecord*, uint>)(lpVtbl[2]))((ITfEditRecord*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectionStatus(BOOL* pfChanged)
        {
            return ((delegate* unmanaged<ITfEditRecord*, BOOL*, int>)(lpVtbl[3]))((ITfEditRecord*)Unsafe.AsPointer(ref this), pfChanged);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextAndPropertyUpdates([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID **")] Guid** prgProperties, [NativeTypeName("ULONG")] uint cProperties, IEnumTfRanges** ppEnum)
        {
            return ((delegate* unmanaged<ITfEditRecord*, uint, Guid**, uint, IEnumTfRanges**, int>)(lpVtbl[4]))((ITfEditRecord*)Unsafe.AsPointer(ref this), dwFlags, prgProperties, cProperties, ppEnum);
        }
    }
}
