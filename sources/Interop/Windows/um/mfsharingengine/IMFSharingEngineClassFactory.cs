// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2BA61F92-8305-413B-9733-FAF15F259384")]
    [NativeTypeName("struct IMFSharingEngineClassFactory : IUnknown")]
    public unsafe partial struct IMFSharingEngineClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSharingEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFSharingEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSharingEngineClassFactory*, uint>)(lpVtbl[1]))((IMFSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSharingEngineClassFactory*, uint>)(lpVtbl[2]))((IMFSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttr, [NativeTypeName("IUnknown **")] IUnknown** ppEngine)
        {
            return ((delegate* unmanaged<IMFSharingEngineClassFactory*, uint, IMFAttributes*, IUnknown**, int>)(lpVtbl[3]))((IMFSharingEngineClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppEngine);
        }
    }
}
