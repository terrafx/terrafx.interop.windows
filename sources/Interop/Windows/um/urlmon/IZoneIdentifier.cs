// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CD45F185-1B21-48E2-967B-EAD743A8914E")]
    [NativeTypeName("struct IZoneIdentifier : IUnknown")]
    public unsafe partial struct IZoneIdentifier
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IZoneIdentifier*, Guid*, void**, int>)(lpVtbl[0]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IZoneIdentifier*, uint>)(lpVtbl[1]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IZoneIdentifier*, uint>)(lpVtbl[2]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return ((delegate* stdcall<IZoneIdentifier*, uint*, int>)(lpVtbl[3]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("DWORD")] uint dwZone)
        {
            return ((delegate* stdcall<IZoneIdentifier*, uint, int>)(lpVtbl[4]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), dwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int Remove()
        {
            return ((delegate* stdcall<IZoneIdentifier*, int>)(lpVtbl[5]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }
    }
}
