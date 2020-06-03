// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E8-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IInternetThreadSwitch
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetThreadSwitch*, Guid*, void**, int>)(lpVtbl[0]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetThreadSwitch*, uint>)(lpVtbl[1]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetThreadSwitch*, uint>)(lpVtbl[2]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Prepare()
        {
            return ((delegate* stdcall<IInternetThreadSwitch*, int>)(lpVtbl[3]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Continue()
        {
            return ((delegate* stdcall<IInternetThreadSwitch*, int>)(lpVtbl[4]))((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
        }
    }
}
