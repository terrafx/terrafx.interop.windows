// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B2745EFD-42CE-48CA-81F1-A96E02538A90")]
    public unsafe partial struct ISpPhoneticAlphabetSelection
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetSelection*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetSelection*, uint>)(lpVtbl[1]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetSelection*, uint>)(lpVtbl[2]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsAlphabetUPS([NativeTypeName("BOOL *")] int* pfIsUPS)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetSelection*, int*, int>)(lpVtbl[3]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this), pfIsUPS);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphabetToUPS([NativeTypeName("BOOL")] int fForceUPS)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetSelection*, int, int>)(lpVtbl[4]))((ISpPhoneticAlphabetSelection*)Unsafe.AsPointer(ref this), fForceUPS);
        }
    }
}
