// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F329791D-540B-4A9F-BC75-3282B7D73193")]
    [NativeTypeName("struct IAppxSourceContentGroupMapReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxSourceContentGroupMapReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, uint>)(lpVtbl[1]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, uint>)(lpVtbl[2]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetRequiredGroup(IAppxContentGroup** requiredGroup)
        {
            return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, IAppxContentGroup**, int>)(lpVtbl[3]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this), requiredGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAutomaticGroups(IAppxContentGroupsEnumerator** automaticGroupsEnumerator)
        {
            return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, IAppxContentGroupsEnumerator**, int>)(lpVtbl[4]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this), automaticGroupsEnumerator);
        }
    }
}
