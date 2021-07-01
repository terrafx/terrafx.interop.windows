// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72380D55-8D2B-43A3-8513-2B6EF31434E9")]
    [NativeTypeName("struct IProcessInitControl : IUnknown")]
    public unsafe partial struct IProcessInitControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProcessInitControl*, Guid*, void**, int>)(lpVtbl[0]))((IProcessInitControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProcessInitControl*, uint>)(lpVtbl[1]))((IProcessInitControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProcessInitControl*, uint>)(lpVtbl[2]))((IProcessInitControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResetInitializerTimeout([NativeTypeName("DWORD")] uint dwSecondsRemaining)
        {
            return ((delegate* unmanaged<IProcessInitControl*, uint, int>)(lpVtbl[3]))((IProcessInitControl*)Unsafe.AsPointer(ref this), dwSecondsRemaining);
        }
    }
}
