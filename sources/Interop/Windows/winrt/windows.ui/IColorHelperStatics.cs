// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8504DBEA-FB6A-4144-A6C2-33499C9284F5")]
    [NativeTypeName("struct IColorHelperStatics : IInspectable")]
    public unsafe partial struct IColorHelperStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IColorHelperStatics*, Guid*, void**, int>)(lpVtbl[0]))((IColorHelperStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IColorHelperStatics*, uint>)(lpVtbl[1]))((IColorHelperStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IColorHelperStatics*, uint>)(lpVtbl[2]))((IColorHelperStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IColorHelperStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IColorHelperStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IColorHelperStatics*, IntPtr*, int>)(lpVtbl[4]))((IColorHelperStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IColorHelperStatics*, TrustLevel*, int>)(lpVtbl[5]))((IColorHelperStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FromArgb([NativeTypeName("BYTE")] byte a, [NativeTypeName("BYTE")] byte r, [NativeTypeName("BYTE")] byte g, [NativeTypeName("BYTE")] byte b, [NativeTypeName("ABI::Windows::UI::Color *")] Color* returnValue)
        {
            return ((delegate* unmanaged<IColorHelperStatics*, byte, byte, byte, byte, Color*, int>)(lpVtbl[6]))((IColorHelperStatics*)Unsafe.AsPointer(ref this), a, r, g, b, returnValue);
        }
    }
}
