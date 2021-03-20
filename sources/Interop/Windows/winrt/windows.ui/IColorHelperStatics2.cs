// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24D9AF02-6EB0-4B94-855C-FCF0818D9A16")]
    [NativeTypeName("struct IColorHelperStatics2 : IInspectable")]
    public unsafe partial struct IColorHelperStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IColorHelperStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IColorHelperStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IColorHelperStatics2*, uint>)(lpVtbl[1]))((IColorHelperStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IColorHelperStatics2*, uint>)(lpVtbl[2]))((IColorHelperStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IColorHelperStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IColorHelperStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IColorHelperStatics2*, IntPtr*, int>)(lpVtbl[4]))((IColorHelperStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IColorHelperStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IColorHelperStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ToDisplayName([NativeTypeName("ABI::Windows::UI::Color")] Color color, [NativeTypeName("HSTRING *")] IntPtr* returnValue)
        {
            return ((delegate* unmanaged<IColorHelperStatics2*, Color, IntPtr*, int>)(lpVtbl[6]))((IColorHelperStatics2*)Unsafe.AsPointer(ref this), color, returnValue);
        }
    }
}
