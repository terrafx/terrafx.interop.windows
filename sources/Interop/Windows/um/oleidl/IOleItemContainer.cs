// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011C-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleItemContainer : IOleContainer")]
    public unsafe partial struct IOleItemContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleItemContainer*, Guid*, void**, int>)(lpVtbl[0]))((IOleItemContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleItemContainer*, uint>)(lpVtbl[1]))((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleItemContainer*, uint>)(lpVtbl[2]))((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName(IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, IMoniker** ppmkOut)
        {
            return ((delegate* unmanaged<IOleItemContainer*, IBindCtx*, ushort*, uint*, IMoniker**, int>)(lpVtbl[3]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumObjects([NativeTypeName("DWORD")] uint grfFlags, IEnumUnknown** ppenum)
        {
            return ((delegate* unmanaged<IOleItemContainer*, uint, IEnumUnknown**, int>)(lpVtbl[4]))((IOleItemContainer*)Unsafe.AsPointer(ref this), grfFlags, ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockContainer([NativeTypeName("BOOL")] int fLock)
        {
            return ((delegate* unmanaged<IOleItemContainer*, int, int>)(lpVtbl[5]))((IOleItemContainer*)Unsafe.AsPointer(ref this), fLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObject([NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("DWORD")] uint dwSpeedNeeded, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleItemContainer*, ushort*, uint, IBindCtx*, Guid*, void**, int>)(lpVtbl[6]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, dwSpeedNeeded, pbc, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectStorage([NativeTypeName("LPOLESTR")] ushort* pszItem, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppvStorage)
        {
            return ((delegate* unmanaged<IOleItemContainer*, ushort*, IBindCtx*, Guid*, void**, int>)(lpVtbl[7]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, pbc, riid, ppvStorage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("LPOLESTR")] ushort* pszItem)
        {
            return ((delegate* unmanaged<IOleItemContainer*, ushort*, int>)(lpVtbl[8]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem);
        }
    }
}
