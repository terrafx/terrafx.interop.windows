// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("901DB4C7-31CE-41A2-85DC-8FA0BF41B8DA")]
    [NativeTypeName("struct ICodecAPI : IUnknown")]
    public unsafe partial struct ICodecAPI
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, void**, int>)(lpVtbl[0]))((ICodecAPI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICodecAPI*, uint>)(lpVtbl[1]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICodecAPI*, uint>)(lpVtbl[2]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsSupported([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, int>)(lpVtbl[3]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsModifiable([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, int>)(lpVtbl[4]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, VARIANT* ValueMin, VARIANT* ValueMax, VARIANT* SteppingDelta)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, ValueMin, ValueMax, SteppingDelta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT**, uint*, int>)(lpVtbl[6]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Values, ValuesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[7]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[8]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[9]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterForEvent([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("LONG_PTR")] nint userData)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, nint, int>)(lpVtbl[10]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, userData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterForEvent([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, int>)(lpVtbl[11]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAllDefaults()
        {
            return ((delegate* unmanaged<ICodecAPI*, int>)(lpVtbl[12]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetValueWithNotify([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value, [NativeTypeName("GUID **")] Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid*, VARIANT*, Guid**, uint*, int>)(lpVtbl[13]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value, ChangedParam, ChangedParamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAllDefaultsWithNotify([NativeTypeName("GUID **")] Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* unmanaged<ICodecAPI*, Guid**, uint*, int>)(lpVtbl[14]))((ICodecAPI*)Unsafe.AsPointer(ref this), ChangedParam, ChangedParamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllSettings(IStream* __MIDL__ICodecAPI0000)
        {
            return ((delegate* unmanaged<ICodecAPI*, IStream*, int>)(lpVtbl[15]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAllSettings(IStream* __MIDL__ICodecAPI0001)
        {
            return ((delegate* unmanaged<ICodecAPI*, IStream*, int>)(lpVtbl[16]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0001);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAllSettingsWithNotify(IStream* __MIDL__ICodecAPI0002, [NativeTypeName("GUID **")] Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* unmanaged<ICodecAPI*, IStream*, Guid**, uint*, int>)(lpVtbl[17]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0002, ChangedParam, ChangedParamCount);
        }
    }
}
