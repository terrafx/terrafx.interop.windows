// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CF5C4FD-E54C-4EA5-BA4E-F8C4B105A8C8")]
    [NativeTypeName("struct IAppxPackageWriter2 : IUnknown")]
    public unsafe partial struct IAppxPackageWriter2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxPackageWriter2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackageWriter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxPackageWriter2*, uint>)(lpVtbl[1]))((IAppxPackageWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxPackageWriter2*, uint>)(lpVtbl[2]))((IAppxPackageWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close(IStream* manifest, IStream* contentGroupMap)
        {
            return ((delegate* unmanaged<IAppxPackageWriter2*, IStream*, IStream*, int>)(lpVtbl[3]))((IAppxPackageWriter2*)Unsafe.AsPointer(ref this), manifest, contentGroupMap);
        }
    }
}
