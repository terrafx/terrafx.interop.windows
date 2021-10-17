// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00BB2761-6A77-11D0-A535-00C04FD7D062")]
    [NativeTypeName("struct IObjMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IObjMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjMgr*, Guid*, void**, int>)(lpVtbl[0]))((IObjMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjMgr*, uint>)(lpVtbl[1]))((IObjMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjMgr*, uint>)(lpVtbl[2]))((IObjMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Append(IUnknown* punk)
        {
            return ((delegate* unmanaged<IObjMgr*, IUnknown*, int>)(lpVtbl[3]))((IObjMgr*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Remove(IUnknown* punk)
        {
            return ((delegate* unmanaged<IObjMgr*, IUnknown*, int>)(lpVtbl[4]))((IObjMgr*)Unsafe.AsPointer(ref this), punk);
        }
    }
}
