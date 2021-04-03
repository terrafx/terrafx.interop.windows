// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FB6904C4-42F0-4B62-9C46-983AF7DA7C83")]
    [NativeTypeName("struct IDxcVersionInfo2 : IDxcVersionInfo")]
    public unsafe partial struct IDxcVersionInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcVersionInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcVersionInfo2*, uint>)(lpVtbl[1]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcVersionInfo2*, uint>)(lpVtbl[2]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
        {
            return ((delegate* unmanaged<IDxcVersionInfo2*, uint*, uint*, int>)(lpVtbl[3]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pMajor, pMinor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
        {
            return ((delegate* unmanaged<IDxcVersionInfo2*, uint*, int>)(lpVtbl[4]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCommitInfo([NativeTypeName("UINT32 *")] uint* pCommitCount, [NativeTypeName("char **")] sbyte** pCommitHash)
        {
            return ((delegate* unmanaged<IDxcVersionInfo2*, uint*, sbyte**, int>)(lpVtbl[5]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pCommitCount, pCommitHash);
        }
    }
}
