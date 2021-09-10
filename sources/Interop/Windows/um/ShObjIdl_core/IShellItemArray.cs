// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B63EA76D-1F85-456F-A19C-48159EFA858B")]
    [NativeTypeName("struct IShellItemArray : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellItemArray
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellItemArray*, Guid*, void**, int>)(lpVtbl[0]))((IShellItemArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellItemArray*, uint>)(lpVtbl[1]))((IShellItemArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellItemArray*, uint>)(lpVtbl[2]))((IShellItemArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int BindToHandler(IBindCtx* pbc, [NativeTypeName("const GUID &")] Guid* bhid, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut)
        {
            return ((delegate* unmanaged<IShellItemArray*, IBindCtx*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IShellItemArray*)Unsafe.AsPointer(ref this), pbc, bhid, riid, ppvOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItemArray*, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[4]))((IShellItemArray*)Unsafe.AsPointer(ref this), flags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDescriptionList([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyType, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItemArray*, PROPERTYKEY*, Guid*, void**, int>)(lpVtbl[5]))((IShellItemArray*)Unsafe.AsPointer(ref this), keyType, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributes(SIATTRIBFLAGS AttribFlags, [NativeTypeName("SFGAOF")] uint sfgaoMask, [NativeTypeName("SFGAOF *")] uint* psfgaoAttribs)
        {
            return ((delegate* unmanaged<IShellItemArray*, SIATTRIBFLAGS, uint, uint*, int>)(lpVtbl[6]))((IShellItemArray*)Unsafe.AsPointer(ref this), AttribFlags, sfgaoMask, psfgaoAttribs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("DWORD *")] uint* pdwNumItems)
        {
            return ((delegate* unmanaged<IShellItemArray*, uint*, int>)(lpVtbl[7]))((IShellItemArray*)Unsafe.AsPointer(ref this), pdwNumItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemAt([NativeTypeName("DWORD")] uint dwIndex, IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IShellItemArray*, uint, IShellItem**, int>)(lpVtbl[8]))((IShellItemArray*)Unsafe.AsPointer(ref this), dwIndex, ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EnumItems(IEnumShellItems** ppenumShellItems)
        {
            return ((delegate* unmanaged<IShellItemArray*, IEnumShellItems**, int>)(lpVtbl[9]))((IShellItemArray*)Unsafe.AsPointer(ref this), ppenumShellItems);
        }
    }
}
