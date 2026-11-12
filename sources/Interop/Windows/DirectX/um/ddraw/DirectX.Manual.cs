// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class DirectX
{
    public static HRESULT MAKE_DDHRESULT(int code) => MAKE_HRESULT(1, _FACDD, code);

    public static uint GET_WHQL_YEAR(uint dwWHQLLevel) => dwWHQLLevel / 0x10000;

    public static uint GET_WHQL_MONTH(uint dwWHQLLevel) => (dwWHQLLevel / 0x100) & 0xFF;

    public static uint GET_WHQL_DAY(uint dwWHQLLevel) => dwWHQLLevel & 0xFF;
}
