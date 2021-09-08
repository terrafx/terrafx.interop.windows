// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleContainer : IParseDisplayName")]
    [NativeInheritance("IParseDisplayName")]
    public unsafe partial struct IOleContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleContainer*, Guid*, void**, int>)(lpVtbl[0]))((IOleContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleContainer*, uint>)(lpVtbl[1]))((IOleContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleContainer*, uint>)(lpVtbl[2]))((IOleContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName(IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, IMoniker** ppmkOut)
        {
            return ((delegate* unmanaged<IOleContainer*, IBindCtx*, ushort*, uint*, IMoniker**, int>)(lpVtbl[3]))((IOleContainer*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int EnumObjects([NativeTypeName("DWORD")] uint grfFlags, IEnumUnknown** ppenum)
        {
            return ((delegate* unmanaged<IOleContainer*, uint, IEnumUnknown**, int>)(lpVtbl[4]))((IOleContainer*)Unsafe.AsPointer(ref this), grfFlags, ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int LockContainer([NativeTypeName("BOOL")] int fLock)
        {
            return ((delegate* unmanaged<IOleContainer*, int, int>)(lpVtbl[5]))((IOleContainer*)Unsafe.AsPointer(ref this), fLock);
        }
    }
}
