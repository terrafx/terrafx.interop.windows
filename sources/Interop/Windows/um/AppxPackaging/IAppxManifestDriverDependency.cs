// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1210CB94-5A92-4602-BE24-79F318AF4AF9")]
    [NativeTypeName("struct IAppxManifestDriverDependency : IUnknown")]
    public unsafe partial struct IAppxManifestDriverDependency
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependency*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestDriverDependency*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependency*, uint>)(lpVtbl[1]))((IAppxManifestDriverDependency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependency*, uint>)(lpVtbl[2]))((IAppxManifestDriverDependency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDriverConstraints([NativeTypeName("IAppxManifestDriverConstraintsEnumerator **")] IAppxManifestDriverConstraintsEnumerator** driverConstraints)
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependency*, IAppxManifestDriverConstraintsEnumerator**, int>)(lpVtbl[3]))((IAppxManifestDriverDependency*)Unsafe.AsPointer(ref this), driverConstraints);
        }
    }
}
