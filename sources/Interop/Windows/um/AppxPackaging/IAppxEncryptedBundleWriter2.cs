// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E644BE82-F0FA-42B8-A956-8D1CB48EE379")]
    [NativeTypeName("struct IAppxEncryptedBundleWriter2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxEncryptedBundleWriter2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedBundleWriter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter2*, uint>)(lpVtbl[1]))((IAppxEncryptedBundleWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter2*, uint>)(lpVtbl[2]))((IAppxEncryptedBundleWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter2*, ushort*, IStream*, int>)(lpVtbl[3]))((IAppxEncryptedBundleWriter2*)Unsafe.AsPointer(ref this), fileName, inputStream);
        }
    }
}
