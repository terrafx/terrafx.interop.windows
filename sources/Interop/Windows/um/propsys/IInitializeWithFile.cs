// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B7D14566-0509-4CCE-A71F-0A554233BD9B")]
    public unsafe partial struct IInitializeWithFile
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInitializeWithFile*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeWithFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInitializeWithFile*, uint>)(lpVtbl[1]))((IInitializeWithFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInitializeWithFile*, uint>)(lpVtbl[2]))((IInitializeWithFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPCWSTR")] ushort* pszFilePath, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* stdcall<IInitializeWithFile*, ushort*, uint, int>)(lpVtbl[3]))((IInitializeWithFile*)Unsafe.AsPointer(ref this), pszFilePath, grfMode);
        }
    }
}
