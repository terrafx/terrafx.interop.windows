// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("478F3A9B-E0C9-4827-9228-6F5505FFE76A")]
    [NativeTypeName("struct IKsJackDescription2 : IUnknown")]
    public unsafe partial struct IKsJackDescription2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IKsJackDescription2*, Guid*, void**, int>)(lpVtbl[0]))((IKsJackDescription2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IKsJackDescription2*, uint>)(lpVtbl[1]))((IKsJackDescription2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IKsJackDescription2*, uint>)(lpVtbl[2]))((IKsJackDescription2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetJackCount([NativeTypeName("UINT *")] uint* pcJacks)
        {
            return ((delegate* unmanaged[Stdcall]<IKsJackDescription2*, uint*, int>)(lpVtbl[3]))((IKsJackDescription2*)Unsafe.AsPointer(ref this), pcJacks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetJackDescription2([NativeTypeName("UINT")] uint nJack, [NativeTypeName("KSJACK_DESCRIPTION2 *")] KSJACK_DESCRIPTION2* pDescription2)
        {
            return ((delegate* unmanaged[Stdcall]<IKsJackDescription2*, uint, KSJACK_DESCRIPTION2*, int>)(lpVtbl[4]))((IKsJackDescription2*)Unsafe.AsPointer(ref this), nJack, pDescription2);
        }
    }
}
