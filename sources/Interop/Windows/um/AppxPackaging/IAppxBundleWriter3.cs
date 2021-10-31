// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD711152-F969-4193-82D5-9DDF2786D21A")]
    [NativeTypeName("struct IAppxBundleWriter3 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleWriter3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, uint>)(lpVtbl[1]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, uint>)(lpVtbl[2]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream)
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, ushort*, IStream*, int>)(lpVtbl[3]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this), fileName, inputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Close([NativeTypeName("LPCWSTR")] ushort* hashMethodString)
        {
            return ((delegate* unmanaged<IAppxBundleWriter3*, ushort*, int>)(lpVtbl[4]))((IAppxBundleWriter3*)Unsafe.AsPointer(ref this), hashMethodString);
        }
    }
}
