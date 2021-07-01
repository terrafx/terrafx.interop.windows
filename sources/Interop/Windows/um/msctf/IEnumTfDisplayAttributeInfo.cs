// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7CEF04D7-CB75-4E80-A7AB-5F5BC7D332DE")]
    [NativeTypeName("struct IEnumTfDisplayAttributeInfo : IUnknown")]
    public unsafe partial struct IEnumTfDisplayAttributeInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint>)(lpVtbl[1]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint>)(lpVtbl[2]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfDisplayAttributeInfo** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, IEnumTfDisplayAttributeInfo**, int>)(lpVtbl[3]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, ITfDisplayAttributeInfo** rgInfo, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint, ITfDisplayAttributeInfo**, uint*, int>)(lpVtbl[4]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), ulCount, rgInfo, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, int>)(lpVtbl[5]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfDisplayAttributeInfo*, uint, int>)(lpVtbl[6]))((IEnumTfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
