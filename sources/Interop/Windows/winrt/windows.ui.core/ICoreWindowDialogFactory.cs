// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFB2A855-1C59-4B13-B1E5-16E29805F7C4")]
    [NativeTypeName("struct ICoreWindowDialogFactory : IInspectable")]
    public unsafe partial struct ICoreWindowDialogFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindowDialogFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowDialogFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindowDialogFactory*, uint>)(lpVtbl[1]))((ICoreWindowDialogFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindowDialogFactory*, uint>)(lpVtbl[2]))((ICoreWindowDialogFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindowDialogFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowDialogFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindowDialogFactory*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindowDialogFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindowDialogFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowDialogFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithTitle([NativeTypeName("HSTRING")] IntPtr title, [NativeTypeName("ABI::Windows::UI::Core::ICoreWindowDialog **")] ICoreWindowDialog** coreWindowDialog)
        {
            return ((delegate* unmanaged<ICoreWindowDialogFactory*, IntPtr, ICoreWindowDialog**, int>)(lpVtbl[6]))((ICoreWindowDialogFactory*)Unsafe.AsPointer(ref this), title, coreWindowDialog);
        }
    }
}
