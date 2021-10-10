// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6A9D9026-0E6E-464C-B000-42ECC07DE673")]
    [NativeTypeName("struct IObjectWithFolderEnumMode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IObjectWithFolderEnumMode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectWithFolderEnumMode*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithFolderEnumMode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectWithFolderEnumMode*, uint>)(lpVtbl[1]))((IObjectWithFolderEnumMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectWithFolderEnumMode*, uint>)(lpVtbl[2]))((IObjectWithFolderEnumMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetMode(FOLDER_ENUM_MODE feMode)
        {
            return ((delegate* unmanaged<IObjectWithFolderEnumMode*, FOLDER_ENUM_MODE, int>)(lpVtbl[3]))((IObjectWithFolderEnumMode*)Unsafe.AsPointer(ref this), feMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetMode(FOLDER_ENUM_MODE* pfeMode)
        {
            return ((delegate* unmanaged<IObjectWithFolderEnumMode*, FOLDER_ENUM_MODE*, int>)(lpVtbl[4]))((IObjectWithFolderEnumMode*)Unsafe.AsPointer(ref this), pfeMode);
        }
    }
}
