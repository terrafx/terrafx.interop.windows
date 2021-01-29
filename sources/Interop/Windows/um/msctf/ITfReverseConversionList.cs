// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("151D69F0-86F4-4674-B721-56911E797F47")]
    [NativeTypeName("struct ITfReverseConversionList : IUnknown")]
    public unsafe partial struct ITfReverseConversionList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfReverseConversionList*, Guid*, void**, int>)(lpVtbl[0]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfReverseConversionList*, uint>)(lpVtbl[1]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfReverseConversionList*, uint>)(lpVtbl[2]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLength([NativeTypeName("UINT *")] uint* puIndex)
        {
            return ((delegate* unmanaged<ITfReverseConversionList*, uint*, int>)(lpVtbl[3]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this), puIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pbstr)
        {
            return ((delegate* unmanaged<ITfReverseConversionList*, uint, ushort**, int>)(lpVtbl[4]))((ITfReverseConversionList*)Unsafe.AsPointer(ref this), uIndex, pbstr);
        }
    }
}
