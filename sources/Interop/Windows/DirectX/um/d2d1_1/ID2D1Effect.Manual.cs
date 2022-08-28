// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct ID2D1Effect
{
    public HRESULT GetValueByName<T>([NativeTypeName("PCWSTR")] ushort* propertyName, [NativeTypeName("T *")] T* value)
        where T : unmanaged
    {
        return GetValueByName(propertyName, (byte*)value, unchecked((uint)sizeof(T)));
    }

    public T GetValueByName<T>([NativeTypeName("PCWSTR")] ushort* propertyName)
        where T : unmanaged
    {
        T value;
        _ = GetValueByName(propertyName, (byte*)&value, unchecked((uint)sizeof(T)));
        return value;
    }

    public HRESULT SetValueByName<T>([NativeTypeName("PCWSTR")] ushort* propertyName, [NativeTypeName("const T &")] T* value)
        where T : unmanaged
    {
        return SetValueByName(propertyName, (byte*)value, unchecked((uint)sizeof(T)));
    }

    public HRESULT GetValue<U>(U index, byte* data, [NativeTypeName("UINT32")] uint dataSize)
        where U : unmanaged
    {
        return GetValue((uint)(object)index, data, dataSize);
    }

    public HRESULT GetValue<T, U>(U index, [NativeTypeName("T *")] T* value)
        where T : unmanaged
        where U : unmanaged
    {
        return GetValue((uint)(object)index, (byte*)value, unchecked((uint)sizeof(T)));
    }

    public T GetValue<T, U>(U index)
        where T : unmanaged
        where U : unmanaged
    {
        T value;
        _ = GetValue((uint)(object)index, (byte*)&value, unchecked((uint)sizeof(T)));
        return value;
    }

    public HRESULT SetValue<U>(U index, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
        where U : unmanaged
    {
        return SetValue((uint)(object)index, data, dataSize);
    }

    public HRESULT SetValue<T, U>(U index, [NativeTypeName("const T &")] T* value)
        where T : unmanaged
        where U : unmanaged
    {
        return SetValue((uint)(object)index, (byte*)value, unchecked((uint)sizeof(T)));
    }

    public HRESULT GetPropertyName<U>(U index, [NativeTypeName("PWSTR")] ushort* name, [NativeTypeName("UINT32")] uint nameCount)
        where U : unmanaged
    {
        return GetPropertyName((uint)(object)index, name, nameCount);
    }

    [return: NativeTypeName("UINT32")]
    public uint GetPropertyNameLength<U>(U index)
        where U : unmanaged
    {
        return GetPropertyNameLength((uint)(object)index);
    }

    public D2D1_PROPERTY_TYPE GetType<U>(U index)
        where U : unmanaged
    {
        return GetType((uint)(object)index);
    }

    [return: NativeTypeName("UINT32")]
    public uint GetValueSize<U>(U index)
        where U : unmanaged
    {
        return GetValueSize((uint)(object)index);
    }

    public HRESULT GetSubProperties<U>(U index, [NativeTypeName("ID2D1Properties **")] ID2D1Properties** subProperties)
        where U : unmanaged
    {
        return GetSubProperties((uint)(object)index, subProperties);
    }
}
