// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC446FE8-BFEC-4C64-AB4F-49F038F0C6D2")]
    [NativeTypeName("struct IAppxBundleWriter : IUnknown")]
    public unsafe partial struct IAppxBundleWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, uint>)(lpVtbl[1]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, uint>)(lpVtbl[2]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream)
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, ushort*, IStream*, int>)(lpVtbl[3]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this), fileName, packageStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, int>)(lpVtbl[4]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this));
        }
    }
}
