// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9D758A0-4617-11CF-95FC-00AA00680DB4")]
    [NativeTypeName("struct IProgressNotify : IUnknown")]
    public unsafe partial struct IProgressNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProgressNotify*, Guid*, void**, int>)(lpVtbl[0]))((IProgressNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProgressNotify*, uint>)(lpVtbl[1]))((IProgressNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProgressNotify*, uint>)(lpVtbl[2]))((IProgressNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnProgress([NativeTypeName("DWORD")] uint dwProgressCurrent, [NativeTypeName("DWORD")] uint dwProgressMaximum, [NativeTypeName("BOOL")] int fAccurate, [NativeTypeName("BOOL")] int fOwner)
        {
            return ((delegate* unmanaged<IProgressNotify*, uint, uint, int, int, int>)(lpVtbl[3]))((IProgressNotify*)Unsafe.AsPointer(ref this), dwProgressCurrent, dwProgressMaximum, fAccurate, fOwner);
        }
    }
}
