// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011C-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleItemContainer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleItemContainer*, Guid*, void**, int>)(lpVtbl[0]))((IOleItemContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleItemContainer*, uint>)(lpVtbl[1]))((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleItemContainer*, uint>)(lpVtbl[2]))((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseDisplayName([NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("IMoniker **")] IMoniker** ppmkOut)
        {
            return ((delegate* stdcall<IOleItemContainer*, IBindCtx*, ushort*, uint*, IMoniker**, int>)(lpVtbl[3]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumObjects([NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppenum)
        {
            return ((delegate* stdcall<IOleItemContainer*, uint, IEnumUnknown**, int>)(lpVtbl[4]))((IOleItemContainer*)Unsafe.AsPointer(ref this), grfFlags, ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockContainer([NativeTypeName("BOOL")] int fLock)
        {
            return ((delegate* stdcall<IOleItemContainer*, int, int>)(lpVtbl[5]))((IOleItemContainer*)Unsafe.AsPointer(ref this), fLock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectA([NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("DWORD")] uint dwSpeedNeeded, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleItemContainer*, ushort*, uint, IBindCtx*, Guid*, void**, int>)(lpVtbl[6]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, dwSpeedNeeded, pbc, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectStorage([NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvStorage)
        {
            return ((delegate* stdcall<IOleItemContainer*, ushort*, IBindCtx*, Guid*, void**, int>)(lpVtbl[7]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, pbc, riid, ppvStorage);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsRunning([NativeTypeName("LPOLESTR")] ushort* pszItem)
        {
            return ((delegate* stdcall<IOleItemContainer*, ushort*, int>)(lpVtbl[8]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem);
        }
    }
}
