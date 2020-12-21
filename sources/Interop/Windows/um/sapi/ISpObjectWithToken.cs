// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B559F40-E952-11D2-BB91-00C04F8EE6C0")]
    [NativeTypeName("struct ISpObjectWithToken : IUnknown")]
    public unsafe partial struct ISpObjectWithToken
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectWithToken*, Guid*, void**, int>)(lpVtbl[0]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectWithToken*, uint>)(lpVtbl[1]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectWithToken*, uint>)(lpVtbl[2]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetObjectToken([NativeTypeName("ISpObjectToken *")] ISpObjectToken* pToken)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectWithToken*, ISpObjectToken*, int>)(lpVtbl[3]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this), pToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectToken([NativeTypeName("ISpObjectToken **")] ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged[Stdcall]<ISpObjectWithToken*, ISpObjectToken**, int>)(lpVtbl[4]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this), ppToken);
        }
    }
}
