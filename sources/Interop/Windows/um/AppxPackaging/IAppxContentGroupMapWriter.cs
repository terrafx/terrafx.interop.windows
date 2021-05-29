// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D07AB776-A9DE-4798-8C14-3DB31E687C78")]
    [NativeTypeName("struct IAppxContentGroupMapWriter : IUnknown")]
    public unsafe partial struct IAppxContentGroupMapWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxContentGroupMapWriter*, uint>)(lpVtbl[1]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxContentGroupMapWriter*, uint>)(lpVtbl[2]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddAutomaticGroup([NativeTypeName("LPCWSTR")] ushort* groupName)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapWriter*, ushort*, int>)(lpVtbl[3]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this), groupName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddAutomaticFile([NativeTypeName("LPCWSTR")] ushort* fileName)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapWriter*, ushort*, int>)(lpVtbl[4]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this), fileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IAppxContentGroupMapWriter*, int>)(lpVtbl[5]))((IAppxContentGroupMapWriter*)Unsafe.AsPointer(ref this));
        }
    }
}
