// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("17D49A3D-F8B8-4B2F-B254-52319DD64C53")]
    [NativeTypeName("struct ITfReadOnlyProperty : IUnknown")]
    public unsafe partial struct ITfReadOnlyProperty
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfReadOnlyProperty*, Guid*, void**, int>)(lpVtbl[0]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfReadOnlyProperty*, uint>)(lpVtbl[1]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfReadOnlyProperty*, uint>)(lpVtbl[2]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfReadOnlyProperty*, Guid*, int>)(lpVtbl[3]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumRanges([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("IEnumTfRanges **")] IEnumTfRanges** ppEnum, [NativeTypeName("ITfRange *")] ITfRange* pTargetRange)
        {
            return ((delegate* unmanaged<ITfReadOnlyProperty*, uint, IEnumTfRanges**, ITfRange*, int>)(lpVtbl[4]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), ec, ppEnum, pTargetRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ITfRange *")] ITfRange* pRange, [NativeTypeName("VARIANT *")] VARIANT* pvarValue)
        {
            return ((delegate* unmanaged<ITfReadOnlyProperty*, uint, ITfRange*, VARIANT*, int>)(lpVtbl[5]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), ec, pRange, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContext([NativeTypeName("ITfContext **")] ITfContext** ppContext)
        {
            return ((delegate* unmanaged<ITfReadOnlyProperty*, ITfContext**, int>)(lpVtbl[6]))((ITfReadOnlyProperty*)Unsafe.AsPointer(ref this), ppContext);
        }
    }
}
