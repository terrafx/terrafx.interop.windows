// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D7AE132-A690-4C00-B75A-6AAE1FEAAC80")]
    [NativeTypeName("struct IAppxManifestReader5 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestReader5
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestReader5*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestReader5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestReader5*, uint>)(lpVtbl[1]))((IAppxManifestReader5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestReader5*, uint>)(lpVtbl[2]))((IAppxManifestReader5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetMainPackageDependencies(IAppxManifestMainPackageDependenciesEnumerator** mainPackageDependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader5*, IAppxManifestMainPackageDependenciesEnumerator**, int>)(lpVtbl[3]))((IAppxManifestReader5*)Unsafe.AsPointer(ref this), mainPackageDependencies);
        }
    }
}
