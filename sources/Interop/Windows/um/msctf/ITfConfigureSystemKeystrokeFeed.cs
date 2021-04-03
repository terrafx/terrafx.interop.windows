// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0D2C969A-BC9C-437C-84EE-951C49B1A764")]
    [NativeTypeName("struct ITfConfigureSystemKeystrokeFeed : IUnknown")]
    public unsafe partial struct ITfConfigureSystemKeystrokeFeed
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, Guid*, void**, int>)(lpVtbl[0]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, uint>)(lpVtbl[1]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, uint>)(lpVtbl[2]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisableSystemKeystrokeFeed()
        {
            return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, int>)(lpVtbl[3]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableSystemKeystrokeFeed()
        {
            return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, int>)(lpVtbl[4]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this));
        }
    }
}
