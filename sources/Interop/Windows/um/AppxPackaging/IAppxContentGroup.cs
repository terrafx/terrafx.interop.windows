// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("328F6468-C04F-4E3C-B6FA-6B8D27F3003A")]
    [NativeTypeName("struct IAppxContentGroup : IUnknown")]
    public unsafe partial struct IAppxContentGroup
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxContentGroup*, Guid*, void**, int>)(lpVtbl[0]))((IAppxContentGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxContentGroup*, uint>)(lpVtbl[1]))((IAppxContentGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxContentGroup*, uint>)(lpVtbl[2]))((IAppxContentGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** groupName)
        {
            return ((delegate* unmanaged<IAppxContentGroup*, ushort**, int>)(lpVtbl[3]))((IAppxContentGroup*)Unsafe.AsPointer(ref this), groupName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFiles(IAppxContentGroupFilesEnumerator** enumerator)
        {
            return ((delegate* unmanaged<IAppxContentGroup*, IAppxContentGroupFilesEnumerator**, int>)(lpVtbl[4]))((IAppxContentGroup*)Unsafe.AsPointer(ref this), enumerator);
        }
    }
}
