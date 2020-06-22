// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("607574EB-F4B6-45C1-B08C-CB715122901D")]
    public unsafe partial struct IPlayToControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPlayToControl*, Guid*, void**, int>)(lpVtbl[0]))((IPlayToControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPlayToControl*, uint>)(lpVtbl[1]))((IPlayToControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPlayToControl*, uint>)(lpVtbl[2]))((IPlayToControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IMFSharingEngineClassFactory *")] IMFSharingEngineClassFactory* pFactory)
        {
            return ((delegate* stdcall<IPlayToControl*, IMFSharingEngineClassFactory*, int>)(lpVtbl[3]))((IPlayToControl*)Unsafe.AsPointer(ref this), pFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int Disconnect()
        {
            return ((delegate* stdcall<IPlayToControl*, int>)(lpVtbl[4]))((IPlayToControl*)Unsafe.AsPointer(ref this));
        }
    }
}
