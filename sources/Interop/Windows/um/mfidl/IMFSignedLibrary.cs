// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4A724BCA-FF6A-4C07-8E0D-7A358421CF06")]
    [NativeTypeName("struct IMFSignedLibrary : IUnknown")]
    public unsafe partial struct IMFSignedLibrary
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSignedLibrary*, Guid*, void**, int>)(lpVtbl[0]))((IMFSignedLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSignedLibrary*, uint>)(lpVtbl[1]))((IMFSignedLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSignedLibrary*, uint>)(lpVtbl[2]))((IMFSignedLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProcedureAddress([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("PVOID *")] void** address)
        {
            return ((delegate* unmanaged<IMFSignedLibrary*, sbyte*, void**, int>)(lpVtbl[3]))((IMFSignedLibrary*)Unsafe.AsPointer(ref this), name, address);
        }
    }
}
