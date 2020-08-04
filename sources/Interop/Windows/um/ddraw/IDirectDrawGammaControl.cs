// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("69C11C3E-B46B-11D1-AD7A-00C04FC29B4E")]
    public unsafe partial struct IDirectDrawGammaControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectDrawGammaControl*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectDrawGammaControl*, uint>)(lpVtbl[1]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectDrawGammaControl*, uint>)(lpVtbl[2]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaRamp([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDGAMMARAMP")] DDGAMMARAMP* param1)
        {
            return ((delegate* stdcall<IDirectDrawGammaControl*, uint, DDGAMMARAMP*, int>)(lpVtbl[3]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGammaRamp([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDGAMMARAMP")] DDGAMMARAMP* param1)
        {
            return ((delegate* stdcall<IDirectDrawGammaControl*, uint, DDGAMMARAMP*, int>)(lpVtbl[4]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
