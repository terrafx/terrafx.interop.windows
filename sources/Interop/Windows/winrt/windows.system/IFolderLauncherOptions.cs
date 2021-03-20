// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB91C27D-6B87-432A-BD04-776C6F5FB2AB")]
    [NativeTypeName("struct IFolderLauncherOptions : IInspectable")]
    public unsafe partial struct IFolderLauncherOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderLauncherOptions*, Guid*, void**, int>)(lpVtbl[0]))((IFolderLauncherOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderLauncherOptions*, uint>)(lpVtbl[1]))((IFolderLauncherOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderLauncherOptions*, uint>)(lpVtbl[2]))((IFolderLauncherOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IFolderLauncherOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IFolderLauncherOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IFolderLauncherOptions*, IntPtr*, int>)(lpVtbl[4]))((IFolderLauncherOptions*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IFolderLauncherOptions*, TrustLevel*, int>)(lpVtbl[5]))((IFolderLauncherOptions*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ItemsToSelect([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CIStorageItem_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IFolderLauncherOptions*, IVector<IntPtr>**, int>)(lpVtbl[6]))((IFolderLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }
    }
}
