// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5DA89BF4-3773-46BE-B650-7E744863B7E8")]
    [NativeTypeName("struct IAppxManifestApplication : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestApplication
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestApplication*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestApplication*, uint>)(lpVtbl[1]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestApplication*, uint>)(lpVtbl[2]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("LPWSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IAppxManifestApplication*, ushort*, ushort**, int>)(lpVtbl[3]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this), name, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAppUserModelId([NativeTypeName("LPWSTR *")] ushort** appUserModelId)
        {
            return ((delegate* unmanaged<IAppxManifestApplication*, ushort**, int>)(lpVtbl[4]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this), appUserModelId);
        }
    }
}
