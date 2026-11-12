// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;
using static TerraFX.Interop.DirectX.D3D12_SHADER_CACHE_SESSION_SUBOBJECT_FLAGS;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported D3DX12 pipeline stream helpers.</summary>
public static unsafe class D3DX12PipelineStreamManualTests
{
    /// <summary>Default streams initialize each subobject tag and the parser preserves PSDB data.</summary>
    [Test]
    public static void CD3DX12_PIPELINE_STATE_STREAM7_ParsesPsdb()
    {
        CD3DX12_PIPELINE_STATE_STREAM7 stream = new();
        Assert.That(stream.Psdb.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PSDB));

        D3D12_SHADER_CACHE_SESSION_SUBOBJECT_DESC expected = new()
        {
            Flags = D3D12_SHADER_CACHE_SESSION_SUBOBJECT_FLAG_CREATE_ONLY,
        };
        stream.Psdb.pssInner = expected;

        D3D12_PIPELINE_STATE_STREAM_DESC streamDesc = new()
        {
            SizeInBytes = (nuint)sizeof(CD3DX12_PIPELINE_STATE_STREAM7),
            pPipelineStateSubobjectStream = &stream,
        };
        CD3DX12_PIPELINE_STATE_STREAM7_PARSE_HELPER parser = new();

        HRESULT result = DirectX.D3DX12ParsePipelineStream(in streamDesc, (ID3DX12PipelineParserCallbacks*)&parser);
        Assert.That(result.Value, Is.Zero);
        Assert.That(parser.PipelineStream.Psdb.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PSDB));
        Assert.That(parser.PipelineStream.Psdb.pssInner.Flags, Is.EqualTo(expected.Flags));

        CD3DX12_PIPELINE_STATE_STREAM6_PARSE_HELPER legacyParser = new();
        result = DirectX.D3DX12ParsePipelineStream(in streamDesc, (ID3DX12PipelineParserCallbacks*)&legacyParser);
        Assert.That(result.Value, Is.Zero);
    }

    /// <summary>Legacy stream defaults initialize subobject tags that were absent from the source descriptor.</summary>
    [Test]
    public static void CD3DX12_PIPELINE_STATE_STREAM6_InitializesDefaultSubobjectTags()
    {
        CD3DX12_PIPELINE_STATE_STREAM6 stream = new();

        Assert.That(stream.AS.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS));
        Assert.That(stream.MS.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS));
        Assert.That(stream.CS.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS));
        Assert.That(stream.SerializedRootSignature.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SERIALIZED_ROOT_SIGNATURE));
    }

    /// <summary>Descriptor-based stream construction also initializes omitted subobject tags.</summary>
    [Test]
    public static void CD3DX12_PIPELINE_STATE_STREAM7_DescriptorCtorInitializesOmittedSubobjectTags()
    {
        D3D12_GRAPHICS_PIPELINE_STATE_DESC desc = default;
        CD3DX12_PIPELINE_STATE_STREAM7 stream = new(in desc);

        Assert.That(stream.AS.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS));
        Assert.That(stream.MS.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS));
        Assert.That(stream.CS.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS));
        Assert.That(stream.SerializedRootSignature.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SERIALIZED_ROOT_SIGNATURE));
        Assert.That(stream.Psdb.pssType, Is.EqualTo(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PSDB));
    }
}
