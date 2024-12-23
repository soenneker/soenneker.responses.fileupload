using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Responses.FileUpload.Tests;

[Collection("Collection")]
public class FileUploadResponseTests : FixturedUnitTest
{
    public FileUploadResponseTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
